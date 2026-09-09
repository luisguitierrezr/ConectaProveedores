export default function ($actions, $roles, $public) {
function initChatTextarea() {
  const ta = document.querySelector('.chat-input textarea');
  if (!ta) return;

  ta.addEventListener('input', function () {
    this.style.height = 'auto';
    this.style.height = Math.min(this.scrollHeight, 120) + 'px';
  });
}

initChatTextarea();
};




