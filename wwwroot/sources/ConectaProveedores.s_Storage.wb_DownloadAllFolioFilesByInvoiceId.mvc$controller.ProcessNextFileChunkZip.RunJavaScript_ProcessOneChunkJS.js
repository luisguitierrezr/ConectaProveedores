export default function ($actions, $roles, $public) {
const zipProcess = window.sapZipDownload;

if (!zipProcess) {
    console.error("ZIP data not initialized");
   if ($actions.OnChunkError) {
        $actions.OnChunkError("ZIP data not initialized");
    }
} else {
    processOneChunkZip(zipProcess);
}

async function processOneChunkZip(data) {
    if (!data) {
        return;
    }
   if (window.sapZipDownload !== data) {
        console.warn("Old ZIP process ignored:", {
            zipGuid: data.zipGuid
        });
        return;
    }
    const file = data.files[data.currentFileIndex];
    if (!file) {
        await finalizeZipDownload(data);
        return;
    }
    const now = new Date();
    $actions.SetClientTimeouts(
        addMinutesZip(now, 2),
        addMinutesZip(now, 2)
    );
    if (data.isProcessing) {

        console.warn("Duplicate ZIP call ignored:", {
            zipGuid: data.zipGuid,
            fileName: file.FileName,
            currentChunk: file.currentChunk
        });
        return;
    }
    data.isProcessing = true;
    try {
        const chunkIndex = file.currentChunk;
        console.log("GET ZIP CHUNK:", {
            zipGuid: data.zipGuid,
            fileId: file.FileId,
            fileName: file.FileName,
            chunk: chunkIndex,
            totalChunks: file.TotalChunks,
            retryCount: file.retryCount
        });
        const fileProgress = Math.round(
            (file.chunks.length / file.TotalChunks) * 100
        );
        const globalProgress = Math.round(
            (
                (
                    data.currentFileIndex +
                    (fileProgress / 100)
                )
                /
                data.files.length
            )
            * 100
        );
        updateZipLoadingProgress(globalProgress);
        const result = await $actions.GetFileChunk(
            file.FileId,
            chunkIndex,
            file.TotalChunks,
            file.guid
        );
        if (window.sapZipDownload !== data) {

            console.warn("STALE ZIP RESPONSE IGNORED:", {
                zipGuid: data.zipGuid,
                fileName: file.FileName,
                chunk: chunkIndex
            });

            return;
        }
        if (
            !result ||
            !result.ChunkText ||
            result.ChunkText.trim() === ""
        ) {
            file.retryCount++;
            console.warn("Empty ZIP chunk received. Retrying...", {
                zipGuid: data.zipGuid,
                fileName: file.FileName,
                chunk: chunkIndex,
                retryCount: file.retryCount
            });
            data.isProcessing = false;
            if (file.retryCount <= 3) {
                await delayZip(500);
                if (window.sapZipDownload === data) {
                    await processOneChunkZip(data);
                }
                return;
            }
            throw new Error(
                "ZIP chunk failed after retries. File: " +
                file.FileName +
                " | Chunk: " +
                chunkIndex
            );
        }
        const cleanChunk = result.ChunkText
            .replace(/^data:.*?;base64,/, "")
            .replace(/\s/g, "")
            .trim();

        if (!cleanChunk) {
            throw new Error(
                "Empty base64 chunk. File: " +
                file.FileName +
                " | Chunk: " +
                chunkIndex
            );
        }
        file.chunks.push(cleanChunk);
        file.retryCount = 0;
        file.currentChunk = chunkIndex + 1;
        const isFileFinished =
           file.currentChunk > file.TotalChunks;
        console.log("ZIP CHUNK OK:", {
            zipGuid: data.zipGuid,
            fileName: file.FileName,
            loadedChunk: chunkIndex,
            nextChunk: file.currentChunk,
            totalChunks: file.TotalChunks,
            chunksLoaded: file.chunks.length,
            isFileFinished: isFileFinished
        });
        data.isProcessing = false;
        if (isFileFinished) {

            await addCurrentFileToZipDownload(
                data,
                file
            );

        }
        else {
            await processOneChunkZip(data);
        }
    } catch (error) {
        data.isProcessing = false;
        if (window.sapZipDownload !== data) {
            console.warn("Error from OLD ZIP process ignored:", {
                zipGuid: data.zipGuid,
                error: error.message
            });
            return;
        }
        console.error(
            "Error processing ZIP chunk:",
            error
        );
        if ($actions.OnChunkError) {
           $actions.OnChunkError(
                error.message || "Unknown ZIP error"
            );
        }
        if ($actions.EndProcessZip) {
            $actions.EndProcessZip();
        }
    }
}

async function addCurrentFileToZipDownload(
    data,
    file
) {
    if (window.sapZipDownload !== data) {

        console.warn("Old ZIP add-file ignored:", {
            zipGuid: data.zipGuid,
            fileName: file.FileName
        });
        return;
    }
    if (
        !file.chunks ||
        file.chunks.length === 0
    ) {
        throw new Error(
            "File has no chunks: " +
            file.FileName
        );
    }
    if (
        file.chunks.length !==
        file.TotalChunks
    ) {
        throw new Error(
            "Missing chunks for " +
            file.FileName +
            ". Expected: " +
            file.TotalChunks +
            ", loaded: " +
            file.chunks.length
        );
    }

    const binaryChunks = [];
    let totalBytes = 0;
    for (
        let i = 0;
        i < file.chunks.length;
        i++
    ) {
        let base64Chunk = file.chunks[i];
        if (!base64Chunk) {
            throw new Error(
                "Empty chunk " +
                (i + 1) +
                " for file: " +
                file.FileName
            );
        }
        base64Chunk = base64Chunk
            .replace(/^data:.*?;base64,/, "")
            .replace(/\s/g, "")
            .trim();
        while (
            base64Chunk.length % 4 !== 0
        ) {
            base64Chunk += "=";
        }
        const invalidChars =
            base64Chunk.match(
                /[^A-Za-z0-9+/=]/g
            );
        if (invalidChars) {
            console.error(
                "Invalid base64 chars:",
                {
                    fileName: file.FileName,
                    chunk: i + 1,
                    invalidChars:
                        invalidChars.slice(0, 20)
                }
            );
            throw new Error(
                "Invalid Base64 in file: " +
                file.FileName +
                " | Chunk: " +
                (i + 1)
            );
        }


        // ====================================================
        // BASE64 -> BINARY
        // ====================================================

        let binaryString;


        try {

            binaryString =
                atob(base64Chunk);

        } catch (decodeError) {

            console.error(
                "Base64 decode error:",
                {
                    fileName: file.FileName,
                    chunk: i + 1,
                    base64Length:
                        base64Chunk.length
                }
            );


            throw new Error(
                "Could not decode chunk " +
                (i + 1) +
                " of file " +
                file.FileName
            );
        }


        const bytes =
            new Uint8Array(
                binaryString.length
            );


        for (
            let j = 0;
            j < binaryString.length;
            j++
        ) {

            bytes[j] =
                binaryString.charCodeAt(j);

        }


        binaryChunks.push(bytes);

        totalBytes += bytes.length;
    }


    // ========================================================
    // JUNTAR TODOS OS CHUNKS BINÁRIOS
    // ========================================================

    const fullFile =
        new Uint8Array(totalBytes);


    let offset = 0;


    for (
        const chunk of binaryChunks
    ) {

        fullFile.set(
            chunk,
            offset
        );

        offset += chunk.length;
    }


    // ========================================================
    // CONFIRMAR NOVAMENTE O PROCESSO
    // ========================================================

    if (window.sapZipDownload !== data) {

        console.warn("Old ZIP process ignored before adding file:", {
            zipGuid: data.zipGuid,
            fileName: file.FileName
        });

        return;
    }


    // ========================================================
    // ADICIONAR AO ZIP
    // ========================================================

    data.zip.file(
        file.FileName,
        fullFile
    );


    console.log("Added to ZIP:", {
        zipGuid: data.zipGuid,
        fileName: file.FileName,
        chunks: file.chunks.length,
        bytes: totalBytes
    });


    // ========================================================
    // LIMPAR MEMÓRIA DESTE FICHEIRO
    // ========================================================

    file.chunks = [];

    file.retryCount = 0;


    // ========================================================
    // PASSAR PARA O PRÓXIMO FICHEIRO
    // ========================================================

    data.currentFileIndex++;


    // ========================================================
    // OUTRO ZIP FOI INICIADO?
    // ========================================================

    if (window.sapZipDownload !== data) {

        console.warn("Old ZIP process stopped:", {
            zipGuid: data.zipGuid
        });

        return;
    }


    // ========================================================
    // PRÓXIMO FICHEIRO
    // ========================================================

    if (
        data.currentFileIndex <
        data.files.length
    ) {

        await processOneChunkZip(data);

    }

    // ========================================================
    // TODOS OS FICHEIROS TERMINADOS
    // ========================================================

    else {

        await finalizeZipDownload(data);

    }
}


// ============================================================
// FINALIZAR ZIP
// ============================================================

async function finalizeZipDownload(data) {

    // ========================================================
    // GARANTIR QUE É O PROCESSO ATUAL
    // ========================================================

    if (
        !data ||
        window.sapZipDownload !== data
    ) {

        console.warn("Old ZIP finalize ignored.");

        return;
    }


    console.log("Generating ZIP...", {
        zipGuid: data.zipGuid,
        files: data.files.length
    });


    updateZipLoadingProgress(100);


    // ========================================================
    // GERAR ZIP
    // ========================================================

    const zipBlob =
        await data.zip.generateAsync(
            {
                type: "blob",

                compression: "DEFLATE",

                compressionOptions: {
                    level: 6
                }
            }
        );


    // ========================================================
    // ENQUANTO O JSZIP GERAVA O ZIP,
    // PODE TER COMEÇADO OUTRO DOWNLOAD
    // ========================================================

    if (window.sapZipDownload !== data) {

        console.warn(
            "Old ZIP generation completed but was ignored:",
            {
                zipGuid: data.zipGuid
            }
        );

        return;
    }


    // ========================================================
    // DOWNLOAD
    // ========================================================

    const url =
        URL.createObjectURL(zipBlob);


    const a =
        document.createElement("a");


    a.href = url;

    a.download =
        data.zipFileName ||
        "documentos.zip";


    document.body.appendChild(a);

    a.click();

    document.body.removeChild(a);


    setTimeout(
        function () {

            URL.revokeObjectURL(url);

        },
        1000
    );


    console.log("ZIP completed:", {
        zipGuid: data.zipGuid,
        zipFileName: data.zipFileName
    });


    // ========================================================
    // LIMPAR APENAS SE CONTINUARMOS A SER O PROCESSO ATUAL
    // ========================================================

    if (window.sapZipDownload === data) {

        window.sapZipDownload = null;

    }


    // ========================================================
    // TERMINAR PROCESSO OUTSYSTEMS
    // ========================================================

    if ($actions.EndProcessZip) {

        $actions.EndProcessZip();

    }
}


// ============================================================
// ATUALIZAR PROGRESSO
// ============================================================

function updateZipLoadingProgress(progress) {

    let safeProgress =
        Number(progress);


    if (
        isNaN(safeProgress) ||
        !isFinite(safeProgress)
    ) {

        safeProgress = 0;

    }


    safeProgress =
        Math.max(
            0,
            Math.min(
                100,
                Math.round(safeProgress)
            )
        );


    let attempts = 0;


    const interval =
        setInterval(
            () => {

                const loading =
                    document.querySelector(
                        '[data-download-progress]'
                    );


                if (loading) {

                    loading.innerText =
                        `Cargando... ${safeProgress}%`;


                    clearInterval(interval);

                    return;
                }


                attempts++;


                if (attempts > 20) {

                    clearInterval(interval);

                    console.warn(
                        "ZIP loading progress element not found"
                    );

                }

            },
            100
        );
}

function addMinutesZip(
    date,
    minutes
) {

    return new Date(
        date.getTime() +
        minutes * 60 * 1000
    );
}


// ============================================================
// DELAY
// ============================================================

function delayZip(ms) {

    return new Promise(
        resolve =>
            setTimeout(
                resolve,
                ms
            )
    );
}
};




