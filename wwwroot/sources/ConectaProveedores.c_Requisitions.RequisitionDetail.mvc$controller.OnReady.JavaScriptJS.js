export default function ($actions, $roles, $public) {
function initTextareaAutoResize() {

  document.addEventListener('input', function (e) {
    const ta = e.target;

    if (ta.matches('.custom-textarea textarea')) {
      ta.style.height = 'auto';
      ta.style.height = Math.min(ta.scrollHeight, 120) + 'px';
    }
  });
}

initTextareaAutoResize();

};




