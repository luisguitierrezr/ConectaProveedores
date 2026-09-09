export default function ($actions, $roles, $public) {
processOneChunkZip();

async function processOneChunkZip() {
    const data = window.sapZipDownload;

    if (!data) {
        $actions.OnChunkError("ZIP data not initialized");
        return;
    }

    const file = data.files[data.currentFileIndex];

    if (!file) {
        await finalizeZipDownload();
        return;
    }

    const now = new Date();
    $actions.SetClientTimeouts(addMinutesZip(now, 2), addMinutesZip(now, 2));

    if (data.isProcessing) {
        console.warn("Duplicate call ignored. Current chunk:", file.currentChunk);
        return;
    }

    data.isProcessing = true;

    try {
        const chunkIndex = file.currentChunk;

        console.log("GET ZIP CHUNK:", {
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
            ((data.currentFileIndex + (fileProgress / 100)) / data.files.length) * 100
        );

        updateZipLoadingProgress(globalProgress);

        const result = await $actions.GetFileChunk(
            file.FileId,
            chunkIndex,
            file.TotalChunks,
            file.guid
        );

        if (
            !result ||
            !result.ChunkText ||
            result.ChunkText.trim() === ""
        ) {
            file.retryCount++;

            console.warn("Empty ZIP chunk received. Retrying...", {
                fileName: file.FileName,
                chunk: chunkIndex,
                retryCount: file.retryCount
            });

            data.isProcessing = false;

            if (file.retryCount <= 3) {
                await delayZip(500);
                return await processOneChunkZip();
            }

            throw new Error(
                "ZIP chunk failed after retries. File: " +
                file.FileName +
                " | Chunk: " +
                chunkIndex
            );
        }

        file.chunks.push(
            result.ChunkText
                .replace(/data:.*?;base64,/g, "")
                .replace(/\s/g, "")
                .trim()
        );

        file.retryCount = 0;
        file.currentChunk = chunkIndex + 1;

        const isFileFinished = file.currentChunk > file.TotalChunks;

        console.log("ZIP CHUNK OK:", {
            fileName: file.FileName,
            loadedChunk: chunkIndex,
            nextChunk: file.currentChunk,
            totalChunks: file.TotalChunks,
            chunksLoaded: file.chunks.length,
            isFileFinished: isFileFinished
        });

        data.isProcessing = false;

        if (isFileFinished) {
            await addCurrentFileToZipDownload();
        } else {
            await processOneChunkZip();
        }

    } catch (error) {
        data.isProcessing = false;
        console.error("Error processing ZIP chunk", error);

        if ($actions.OnChunkError) {
            $actions.OnChunkError(error.message);
        }

        if ($actions.EndProcessZip) {
            $actions.EndProcessZip();
        }
    }
}

async function addCurrentFileToZipDownload() {
    const data = window.sapZipDownload;
    const file = data.files[data.currentFileIndex];

    if (!file.chunks || file.chunks.length === 0) {
        throw new Error("File has no chunks: " + file.FileName);
    }

    if (file.chunks.length !== file.TotalChunks) {
        throw new Error(
            "Missing chunks for " +
            file.FileName +
            ". Expected: " +
            file.TotalChunks +
            ", loaded: " +
            file.chunks.length
        );
    }

    let fullBase64 = file.chunks
        .join("")
        .replace(/data:.*?;base64,/g, "")
        .replace(/\s/g, "")
        .trim();

    if (!fullBase64 || fullBase64.length === 0) {
        throw new Error("Empty base64 for file: " + file.FileName);
    }

    while (fullBase64.length % 4 !== 0) {
        fullBase64 += "=";
    }

    const invalidChars = fullBase64.match(/[^A-Za-z0-9+/=]/g);

    if (invalidChars) {
        console.error("Invalid base64 chars in ZIP file:", {
            fileName: file.FileName,
            invalidChars: invalidChars.slice(0, 20)
        });

        throw new Error("Base64 inválido no ficheiro: " + file.FileName);
    }

    data.zip.file(file.FileName, fullBase64, {
        base64: true
    });

    console.log("Added to ZIP:", {
        fileName: file.FileName,
        chunks: file.chunks.length,
        base64Length: fullBase64.length
    });

    file.chunks = [];
    file.retryCount = 0;

    data.currentFileIndex++;

    if (data.currentFileIndex < data.files.length) {
        await processOneChunkZip();
    } else {
        await finalizeZipDownload();
    }
}

async function finalizeZipDownload() {
    const data = window.sapZipDownload;

    updateZipLoadingProgress(100);

    const zipBlob = await data.zip.generateAsync({
        type: "blob",
        compression: "DEFLATE",
        compressionOptions: {
            level: 6
        }
    });

    const url = URL.createObjectURL(zipBlob);

    const a = document.createElement("a");
    a.href = url;
    a.download = data.zipFileName || "documentos.zip";

    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);

    setTimeout(function () {
        URL.revokeObjectURL(url);
    }, 1000);

    console.log("ZIP completed");

    window.sapZipDownload = null;

    if ($actions.EndProcessZip) {
        $actions.EndProcessZip();
    }
}

function updateZipLoadingProgress(progress) {
    const safeProgress = isNaN(progress) ? 0 : progress;

    let attempts = 0;

    const interval = setInterval(() => {
        const loading = document.querySelector('[data-download-progress]');

        if (loading) {
            loading.innerText = `Cargando... ${safeProgress}%`;
            clearInterval(interval);
        }

        attempts++;

        if (attempts > 20) {
            clearInterval(interval);
            console.warn("ZIP loading progress element not found");
        }
    }, 100);
}

function addMinutesZip(date, minutes) {
    return new Date(date.getTime() + minutes * 60 * 1000);
}

function delayZip(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}
};




