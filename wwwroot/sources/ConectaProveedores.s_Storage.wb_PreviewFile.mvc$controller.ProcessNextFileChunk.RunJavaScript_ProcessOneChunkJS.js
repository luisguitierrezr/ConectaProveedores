export default function ($actions, $roles, $public) {
processOneChunk();

async function processOneChunk() {
    const data = window.sapDownload;


    const now = new Date();
    $actions.SetClientTimeouts(addMinutes(now,2), addMinutes(now, 2));

    if (!data) {
        $actions.OnChunkError("Download data not initialized");
        return;
    }

    if (data.isProcessing) {
        console.warn("Duplicate call ignored. Current chunk:", data.currentChunk);
        return;
    }

    data.isProcessing = true;

    try {
        const chunkIndex = data.currentChunk;

        console.log("STATE BEFORE:", JSON.stringify({
            currentChunk: data.currentChunk,
            totalChunks: data.totalChunks,
            chunksLoaded: data.chunks.length
        }));

        const progress = Math.round(
            (data.chunks.length / data.totalChunks) * 100
        );

        const loading = document.querySelector('[data-download-progress="true"]');

        if (loading) {
            loading.innerText = `Cargando... ${progress}%`;
        }

        updateLoadingProgress(progress);

        const result = await $actions.GetFileChunk(
            data.fileId,
            chunkIndex,
            data.totalChunks
        );

        if (!result || !result.ChunkText) {
            throw new Error("Empty chunk: " + chunkIndex);
        }

        data.chunks.push(result.ChunkText);

        data.currentChunk = chunkIndex + 1;

        const isFinished = data.currentChunk > data.totalChunks;

        console.log("STATE AFTER:", JSON.stringify({
            loadedChunk: chunkIndex,
            nextChunk: data.currentChunk,
            totalChunks: data.totalChunks,
            chunksLoaded: data.chunks.length,
            isFinished: isFinished
        }));

        data.isProcessing = false;

        $actions.OnChunkProcessed(isFinished);

    } catch (error) {
        data.isProcessing = false;
        console.error("Error processing chunk", error);
        $actions.OnChunkError(error.message);
    }
}

function updateLoadingProgress(progress) {

    let attempts = 0;

    const interval = setInterval(() => {

        const loading = document.querySelector('[data-download-progress]');

        if (loading) {
            loading.innerText =
                `Cargando... ${progress}%`;

           clearInterval(interval);
        }
        attempts++;
        if (attempts > 20) {
            clearInterval(interval);
            console.warn(
                "Loading progress element not found"
            );
        }

    }, 100);

}

function addMinutes(date, minutes) {
    return new Date(date.getTime() + minutes * 60 * 1000);
}
};




