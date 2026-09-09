export default function ($parameters, $actions, $roles, $public) {
var parts = $parameters.InputText.split(",");
var result = [];

for (var i = 0; i < parts.length; i++) {
    var value = parts[i].trim();
    if (value !== "") {
        result.push({
            value: parseInt(value, 10),
            label: ""
        });
    }
}

$parameters.OutputJson = JSON.stringify(result);
};




