export default function ($actions, $roles, $public) {
document.addEventListener("DOMContentLoaded", function () {
    var userInfo = document.querySelector("[id$='UserInfo']");
    if (userInfo) {
        userInfo.style.display = "flex";
        userInfo.style.alignItems = "center";
    }
});
};




