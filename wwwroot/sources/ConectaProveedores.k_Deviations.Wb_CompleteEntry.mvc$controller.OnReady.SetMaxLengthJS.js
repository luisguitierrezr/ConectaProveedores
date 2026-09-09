export default function ($parameters, $actions, $roles, $public) {
var input_year = document.getElementById($parameters.Input_YearId);

if (input_year && !input_year.dataset.bound) {
    input_year.dataset.bound = "true";

    input_year.addEventListener("keydown", function (e) {
        if (["Backspace","Tab","ArrowLeft","ArrowRight","Delete"].includes(e.key)) return;
        if (e.ctrlKey || e.metaKey) return;

        if (!/^[0-9]$/.test(e.key)) {
            e.preventDefault();
        }
    });

    input_year.addEventListener("paste", function (e) {
        let paste = (e.clipboardData || window.clipboardData).getData("text");
        if (!/^\d+$/.test(paste)) {
            e.preventDefault();
        }
    });
}


var input_number = document.getElementById($parameters.Input_NumberId);

if (input_number && !input_number.dataset.bound) {
    input_number.dataset.bound = "true";

    input_number.addEventListener("keydown", function (e) {
        if (["Backspace","Tab","ArrowLeft","ArrowRight","Delete"].includes(e.key)) return;
        if (e.ctrlKey || e.metaKey) return;

        if (!/^[0-9]$/.test(e.key)) {
            e.preventDefault();
        }
    });

    input_number.addEventListener("paste", function (e) {
        let paste = (e.clipboardData || window.clipboardData).getData("text");
        if (!/^\d+$/.test(paste)) {
            e.preventDefault();
        }
    });
}
};




