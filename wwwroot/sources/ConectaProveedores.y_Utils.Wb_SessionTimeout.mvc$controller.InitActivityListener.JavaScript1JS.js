export default function ($parameters, $actions, $roles, $public) {
function addMinutes(date, minutes) {
    return new Date(date.getTime() + minutes * 60 * 1000);
}

(function () {
  if (window.__sessionActivityListenerAdded) return;
  window.__sessionActivityListenerAdded = true;

  const handler = (e) => {
    // ignora cliques no popup
    if (e.target.closest('.popup-sessiontimeout')) return;

    // chama a action do bloco
    const now = new Date();
    $actions.SetClientTimeouts(addMinutes(now, $parameters.WarningTime), addMinutes(now, $parameters.LogoutTime));
  };

  document.addEventListener('click', handler, true);
  document.addEventListener('keydown', handler, true);
})();

};




