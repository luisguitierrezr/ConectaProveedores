console.log('[Copilot] Script started');


function loadScript(url, callback) {
  if (window.WebChat) {
    callback();
    return;
  }
  
  // Temporarily hide AMD define so webchat.js registers on window
  var originalDefine = window.define;
  window.define = undefined;
  
  var script = document.createElement('script');
  script.src = url;
  script.onload = function() {
    // Restore define
    window.define = originalDefine;
    console.log('[Copilot] Script loaded, WebChat:', !!window.WebChat);
    waitReady(callback);
  };
  document.head.appendChild(script);
}

function waitReady(callback) {
  console.log('[Copilot] waitReady - WebChat available:', !!window.WebChat);
  if (window.WebChat) {
    callback();
  } else {
    setTimeout(function() { waitReady(callback); }, 200);
  }
}