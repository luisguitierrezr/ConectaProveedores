export default function ($parameters, $actions, $roles, $public) {
window.sapDownload = {
    fileId: $parameters.FileId,
    totalChunks: Number($parameters.TotalChunks),
    currentChunk: 1,
    chunks: []
};

console.log("Download initialized", window.sapDownload);
};




