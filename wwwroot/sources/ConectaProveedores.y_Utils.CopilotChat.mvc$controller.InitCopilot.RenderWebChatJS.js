export default function ($parameters, $actions, $roles, $public) {
loadScript('https://cdn.botframework.com/botframework-webchat/latest/webchat.js', async function () {
  console.log('[Copilot] WebChat loaded:', !!window.WebChat);
  //var el = document.getElementById('webchat');
  //var el = document.querySelector('[id$="-webchat"]') || document.getElementById('webchat');
  var el = document.getElementById($parameters.In1);
  console.log('[Copilot] Element found:', el);
  console.log('[Copilot] Element children:', el ? el.children.length : 'N/A');
  if (!el || el.children.length > 0) return;

  //var SECRET = '76UKjjxXyA3nZFtjhdASw0n2QS6B7z8zPtyFmwgDnKglehnRTCfzJQQJ99CDACi5YpzAArohAAABAZBS3zik.4NWHXzb2qE9vqHQzDArE5bvSTY1QXAXc9Wnp65oqdTPg3vKxdMgoJQQJ99CDACi5YpzAArohAAABAZBS2GkH'; // NM bot
  //var SECRET = '6HwHZkLvQssQMniAcRiprCmx9nU96dE6Skw9mYI4NSDXdJv7hDvNJQQJ99CDAC3pKaRAArohAAABAZBS1uhU.1bziu7smX8qcacQPXXS4lzB8tjzH953OPF4Dufr5ajhzeab8valxJQQJ99CDAC3pKaRAArohAAABAZBS3Uuu'; // Telcel bot
  var DL_URL = 'https://directline.botframework.com'; // Telcel bot
  var SECRET = $parameters.SECRET; // Telcel bot
  //var DL_URL = 'https://europe.directline.botframework.com'; // NM Bot
  var screenName = window.location.pathname.split('/').pop() || 'Unknown';

  var contextVars = {
    Screen: screenName,
    Name: $parameters.Name,
    Email: $parameters.Email,
    Initiative: $parameters.Initiative,
    URL: $parameters.URL,
    Roles: $parameters.Roles
  };

  try {
    var res = await fetch(DL_URL + '/v3/directline/tokens/generate', {
      method: 'POST',
      headers: {
        'Authorization': 'Bearer ' + SECRET,
        'Content-Type': 'application/json'
      }
    });
    var data = await res.json();

    var store = window.WebChat.createStore({}, function(ref) {
      var dispatch = ref.dispatch;
      return function(next) {
        return function(action) {
          if (action.type === 'DIRECT_LINE/CONNECT_FULFILLED') {
            dispatch({
              type: 'WEB_CHAT/SEND_EVENT',
              payload: { name: 'pvaSetContext', value: contextVars }
            });
            setTimeout(function() {
              dispatch({
                type: 'WEB_CHAT/SEND_EVENT',
                payload: { name: 'startConversation', value: contextVars }
              });
            }, 2000);
          }
          return next(action);
        };
      };
    });

    window.WebChat.renderWebChat({
      directLine: window.WebChat.createDirectLine({
        token: data.token,
        domain: data.domain || (DL_URL + '/v3/directline')
      }),
      store: store,
      locale: 'es'
    }, el);

  } catch (err) {
    el.innerHTML = '<p style="color:red;">Error: ' + err.message + '</p>';
  }
});
};




