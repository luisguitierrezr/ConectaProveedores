import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ConfirmationText", "i_ConfirmationTextIn", "i_ConfirmationText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ConfirmationTextInDataFetchStatus", "_i_ConfirmationTextInDataFetchStatus", "_i_ConfirmationTextInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_PopupTitle", "i_PopupTitleIn", "i_PopupTitle", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_PopupTitleInDataFetchStatus", "_i_PopupTitleInDataFetchStatus", "_i_PopupTitleInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
}

}

class Model extends 
OS$Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("i_ConfirmationText" in inputs) {
this.variables.i_ConfirmationTextIn = inputs.i_ConfirmationText;
if("_i_ConfirmationTextInDataFetchStatus" in inputs) {
this.variables._i_ConfirmationTextInDataFetchStatus = inputs._i_ConfirmationTextInDataFetchStatus;
}

}

if("i_PopupTitle" in inputs) {
this.variables.i_PopupTitleIn = inputs.i_PopupTitle;
if("_i_PopupTitleInDataFetchStatus" in inputs) {
this.variables._i_PopupTitleInDataFetchStatus = inputs._i_PopupTitleInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


