export default function ($actions, $roles, $public) {
const data = window.sapDownload;

if (!data || !data.chunks || data.chunks.length === 0) {
    throw new Error("No chunks available");
}

console.log("Finalizing download...", {
    fileName: data.fileName,
    totalChunks: data.totalChunks,
    chunksLoaded: data.chunks.length,
    expectedBytes: data.totalBytes
});


// ======================================================
// HELPERS
// ======================================================

function cleanBase64(value) {

    if (!value) {
        return "";
    }

    return value
        .replace(/^data:.*?;base64,/, "")
        .replace(/\s/g, "")
        .trim();
}


function base64ToBytes(base64) {

    const binaryString = atob(base64);

    const bytes = new Uint8Array(binaryString.length);

    for (let i = 0; i < binaryString.length; i++) {
        bytes[i] = binaryString.charCodeAt(i);
    }

    return bytes;
}


// Limpar todos os chunks
const cleanedChunks = data.chunks.map(cleanBase64);


// ======================================================
// VERIFICAR SE CADA CHUNK É BASE64 INDEPENDENTE
// ======================================================

let chunksAreIndependent = true;

for (let i = 0; i < cleanedChunks.length; i++) {

    const chunk = cleanedChunks[i];

    if (!chunk) {
        chunksAreIndependent = false;
        break;
    }

    // Base64 completo deve normalmente ser múltiplo de 4
    if (chunk.length % 4 !== 0) {

        console.log(
            `Chunk ${i + 1} não é Base64 completo:`,
            {
                length: chunk.length,
                mod4: chunk.length % 4
            }
        );

        chunksAreIndependent = false;
        break;
    }

    try {

        // IMPORTANTE:
        // aqui NÃO adicionamos padding.
        // Queremos saber se o chunk já é válido sozinho.
        atob(chunk);

    } catch (e) {

        console.log(
            `Chunk ${i + 1} não pode ser decoded sozinho`
        );

        chunksAreIndependent = false;
        break;
    }
}


console.log(
    "Detected chunk format:",
    chunksAreIndependent
        ? "INDEPENDENT BASE64 CHUNKS"
        : "LEGACY BASE64 PARTS"
);


// ======================================================
// CRIAR BINÁRIO
// ======================================================

let blob;


// ------------------------------------------------------
// NOVO FORMATO
// Cada chunk é Base64 independente
// ------------------------------------------------------

if (chunksAreIndependent) {

    const binaryChunks = [];

    let totalDecodedBytes = 0;

    for (
        let chunkIndex = 0;
        chunkIndex < cleanedChunks.length;
        chunkIndex++
    ) {

        const bytes =
            base64ToBytes(cleanedChunks[chunkIndex]);

        binaryChunks.push(bytes);

        totalDecodedBytes += bytes.byteLength;

        console.log(
            `Chunk ${chunkIndex + 1} decoded`,
            {
                base64Length:
                    cleanedChunks[chunkIndex].length,

                binaryLength:
                    bytes.byteLength
            }
        );
    }


    console.log(
        "Total decoded using independent mode:",
        totalDecodedBytes
    );


    // Se sabemos o tamanho esperado,
    // validar antes do download
    if (
        data.totalBytes &&
        totalDecodedBytes !== data.totalBytes
    ) {

        console.warn(
            "Independent mode size mismatch.",
            {
                expected: data.totalBytes,
                actual: totalDecodedBytes
            }
        );

        // Pode ter sido uma falsa deteção.
        // Vamos tentar o modo legacy.
        chunksAreIndependent = false;
    }

    else {

        blob = new Blob(
            binaryChunks,
            {
                type:
                    data.contentType ||
                    "application/octet-stream"
            }
        );
    }
}


// ======================================================
// OPENTEXT / LEGACY
// Os chunks são partes de UMA string Base64
// ======================================================

if (!chunksAreIndependent) {

    console.log(
        "Using legacy joined Base64 mode"
    );


    let fullBase64 =
        cleanedChunks.join("");


    // Aqui sim corrigimos padding depois de juntar tudo
    while (fullBase64.length % 4 !== 0) {
        fullBase64 += "=";
    }


    const invalidChars =
        fullBase64.match(/[^A-Za-z0-9+/=]/g);


    if (invalidChars) {

        console.error(
            "Invalid Base64 chars:",
            invalidChars.slice(0, 20)
        );

        throw new Error(
            "Base64 inválido."
        );
    }


    let bytes;

    try {

        bytes =
            base64ToBytes(fullBase64);

    } catch (error) {

        console.error(
            "Failed to decode joined Base64",
            error
        );

        throw new Error(
            "Erro ao converter Base64 para binário."
        );
    }


    console.log(
        "Total decoded using legacy mode:",
        bytes.byteLength
    );


    if (
        data.totalBytes &&
        bytes.byteLength !== data.totalBytes
    ) {

        console.warn(
            "Final file size differs from expected.",
            {
                expected: data.totalBytes,
                actual: bytes.byteLength
            }
        );
    }


    blob = new Blob(
        [bytes],
        {
            type:
                data.contentType ||
                "application/octet-stream"
        }
    );
}


// ======================================================
// DOWNLOAD
// ======================================================

console.log(
    "Final file created:",
    {
        fileName: data.fileName,
        size: blob.size,
        chunks: data.chunks.length,
        mode:
            chunksAreIndependent
                ? "independent"
                : "legacy"
    }
);


const url =
    URL.createObjectURL(blob);


const a =
    document.createElement("a");


a.href = url;

a.download =
    data.fileName ||
    "download.bin";


document.body.appendChild(a);

a.click();

document.body.removeChild(a);


setTimeout(() => {
    URL.revokeObjectURL(url);
}, 1000);


console.log(
    "Download finished:",
    {
        fileName: data.fileName,
        size: blob.size
    }
);


const loadingText =
    document.querySelector(
        ".LoadingLayerTextClass"
    );


if (loadingText) {
    loadingText.innerText = "Cargando...";
}


// Limpar memória
delete window.sapDownload;
};




