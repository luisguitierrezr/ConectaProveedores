export default function ($parameters, $actions, $roles, $public) {
$parameters.TimerHandle = setInterval(() => {
    $actions.UpdateCountdown && $actions.UpdateCountdown();
}, $parameters.IntervalDuration);
};




