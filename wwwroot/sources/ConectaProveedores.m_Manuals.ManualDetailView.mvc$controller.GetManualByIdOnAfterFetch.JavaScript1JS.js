export default function ($parameters, $actions, $roles, $public) {
setTimeout(() => {
    const video = document.getElementById($parameters.Id);

    if (!video) {
        console.error("Vídeo não encontrado.");
        return;
    }

    video.src = $parameters.videoBase64.startsWith("data:")
        ? $parameters.videoBase64
        : "data:video/mp4;base64," + $parameters.videoBase64;

    video.controls = true;
    video.autoplay = true;
    video.muted = true;      // Necessário para autoplay na maioria dos browsers
    video.playsInline = true;

    video.load();

    video.play().catch(err => {
        console.log("Autoplay bloqueado:", err);
    });

}, 100);
};




