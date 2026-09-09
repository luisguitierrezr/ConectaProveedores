export default function ($parameters, $actions, $roles, $public) {
const data = window.sapDownload;

if (!data || !data.chunks || data.chunks.length === 0) {
    throw new Error("No chunks available");
}

console.log("Preparing base64 file...", {
    fileName: data.fileName,
    totalChunks: data.totalChunks,
    chunksLoaded: data.chunks.length
});

let fullBase64 = data.chunks
    .join("")
    .replace(/data:.*?;base64,/g, "")
    .replace(/\s/g, "")
    .trim();

while (fullBase64.length % 4 !== 0) {
    fullBase64 += "=";
}

console.log("Base64 prepared:", {
    length: fullBase64.length,
    mod4: fullBase64.length % 4,
    start: fullBase64.substring(0, 50),
    end: fullBase64.substring(fullBase64.length - 50)
});

const invalidChars = fullBase64.match(/[^A-Za-z0-9+/=]/g);

if (invalidChars) {
    console.error("Invalid base64 chars:", invalidChars.slice(0, 20));

    throw new Error(
        "Base64 inválido. Existem caracteres inválidos."
    );
}

$parameters.File = fullBase64;

delete window.sapDownload;
};




