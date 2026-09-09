function scrollChatToBottom() {
  const chat = document.querySelector('.chat-main');
  if (!chat) return;

  requestAnimationFrame(() => {
    chat.scrollTop = chat.scrollHeight;
  });
}
