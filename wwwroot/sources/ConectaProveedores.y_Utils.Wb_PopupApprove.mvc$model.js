import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Reason", "l_ReasonVar", "l_Reason", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_Title", "i_TitleIn", "i_Title", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_TitleInDataFetchStatus", "_i_TitleInDataFetchStatus", "_i_TitleInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsCommentNeeded", "i_IsCommentNeededIn", "i_IsCommentNeeded", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsCommentNeededInDataFetchStatus", "_i_IsCommentNeededInDataFetchStatus", "_i_IsCommentNeededInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Form: OS$Model.ValidationWidgetRecord,
TextArea_l_Reason: OS$Model.ValidationWidgetRecord
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
if("i_Title" in inputs) {
this.variables.i_TitleIn = inputs.i_Title;
if("_i_TitleInDataFetchStatus" in inputs) {
this.variables._i_TitleInDataFetchStatus = inputs._i_TitleInDataFetchStatus;
}

}

if("i_IsCommentNeeded" in inputs) {
this.variables.i_IsCommentNeededIn = inputs.i_IsCommentNeeded;
if("_i_IsCommentNeededInDataFetchStatus" in inputs) {
this.variables._i_IsCommentNeededInDataFetchStatus = inputs._i_IsCommentNeededInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


