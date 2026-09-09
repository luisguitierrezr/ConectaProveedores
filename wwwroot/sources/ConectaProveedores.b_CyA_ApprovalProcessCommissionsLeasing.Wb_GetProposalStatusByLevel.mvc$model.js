import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ApprovalStatusLabel", "i_ApprovalStatusLabelIn", "i_ApprovalStatusLabel", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ApprovalStatusLabelInDataFetchStatus", "_i_ApprovalStatusLabelInDataFetchStatus", "_i_ApprovalStatusLabelInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Class", "i_ClassIn", "i_Class", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ClassInDataFetchStatus", "_i_ClassInDataFetchStatus", "_i_ClassInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_ApprovalStatusLabel" in inputs) {
this.variables.i_ApprovalStatusLabelIn = inputs.i_ApprovalStatusLabel;
if("_i_ApprovalStatusLabelInDataFetchStatus" in inputs) {
this.variables._i_ApprovalStatusLabelInDataFetchStatus = inputs._i_ApprovalStatusLabelInDataFetchStatus;
}

}

if("i_Class" in inputs) {
this.variables.i_ClassIn = inputs.i_Class;
if("_i_ClassInDataFetchStatus" in inputs) {
this.variables._i_ClassInDataFetchStatus = inputs._i_ClassInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


