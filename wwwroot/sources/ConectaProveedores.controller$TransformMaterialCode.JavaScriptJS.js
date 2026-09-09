export default function ($parameters, $actions, $roles, $public) {

var input = ($parameters.InString || "").toString().trim();

console.log("Original Input: ", input);


var result = input.replace(/^0+/, '');

if (result === "") {
    result = input === "" ? "" : "0";
}

$parameters.OutString = result;

console.log("Formatted Result: ", $parameters.OutString);
};




