export default function ($actions, $roles, $public) {
// Select all images with the class 'zoomable'
const images = document.querySelectorAll('.zoomable');

images.forEach(img => {
  img.addEventListener('click', () => {
    img.classList.toggle('zoomed'); // toggle zoom on click
  });
});
};




