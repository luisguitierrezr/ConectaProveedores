export default function ($parameters, $actions, $roles, $public) {
console.log("FilesJson RAW:", $parameters.FilesJson);

const parsedFiles = JSON.parse($parameters.FilesJson);

console.log("FilesJson PARSED:", parsedFiles);
console.log("First file:", parsedFiles[0]);

window.sapZipDownload = {
    zipGuid: crypto.randomUUID(),
    zipFileName: $parameters.ZipFileName || "documentos.zip",
    files: parsedFiles,
    currentFileIndex: 0,
    zip: new JSZip(),
    isProcessing: false
};

window.sapZipDownload.files.forEach(function (file) {
    file.currentChunk = 1;
    file.chunks = [];
    file.guid = crypto.randomUUID();
    file.retryCount = 0;
});

console.log("ZIP Download initialized", window.sapZipDownload);

};




