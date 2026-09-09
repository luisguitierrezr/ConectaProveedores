import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ActionText", "actionTextVar", "ActionText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsMandatoryMessage", "isMandatoryMessageIn", "IsMandatoryMessage", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isMandatoryMessageInDataFetchStatus", "_isMandatoryMessageInDataFetchStatus", "_isMandatoryMessageInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("LabelText", "labelTextIn", "LabelText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_labelTextInDataFetchStatus", "_labelTextInDataFetchStatus", "_labelTextInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("PromptText", "promptTextIn", "PromptText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_promptTextInDataFetchStatus", "_promptTextInDataFetchStatus", "_promptTextInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
TextArea_ActionText: OS$Model.ValidationWidgetRecord
};
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

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("IsMandatoryMessage" in inputs) {
this.variables.isMandatoryMessageIn = inputs.IsMandatoryMessage;
if("_isMandatoryMessageInDataFetchStatus" in inputs) {
this.variables._isMandatoryMessageInDataFetchStatus = inputs._isMandatoryMessageInDataFetchStatus;
}

}

if("LabelText" in inputs) {
this.variables.labelTextIn = inputs.LabelText;
if("_labelTextInDataFetchStatus" in inputs) {
this.variables._labelTextInDataFetchStatus = inputs._labelTextInDataFetchStatus;
}

}

if("PromptText" in inputs) {
this.variables.promptTextIn = inputs.PromptText;
if("_promptTextInDataFetchStatus" in inputs) {
this.variables._promptTextInDataFetchStatus = inputs._promptTextInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


