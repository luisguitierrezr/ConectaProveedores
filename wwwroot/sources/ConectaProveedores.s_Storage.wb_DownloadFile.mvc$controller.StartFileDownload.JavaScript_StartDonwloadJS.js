export default function ($parameters, $actions, $roles, $public) {
window.sapDownload = {
    fileId: $parameters.FileId,
    fileName: $parameters.FileName || "download.bin",
    totalChunks: Number($parameters.TotalChunks),
    currentChunk: 1,
    guid: crypto.randomUUID(),
    chunks: []
};

console.log("Download initialized", window.sapDownload);
};




