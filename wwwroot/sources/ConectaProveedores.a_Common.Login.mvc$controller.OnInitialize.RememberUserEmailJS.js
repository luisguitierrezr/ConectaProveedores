export default function ($parameters, $actions, $roles, $public) {
$parameters.UserEmail = localStorage.getItem("UserEmail") !== null ? localStorage.getItem("UserEmail") : "";
return $parameters.UserEmail;
};




