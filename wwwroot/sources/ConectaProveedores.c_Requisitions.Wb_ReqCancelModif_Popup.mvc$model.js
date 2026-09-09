import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Reason", "l_ReasonVar", "l_Reason", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsCancel", "i_IsCancelIn", "i_IsCancel", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsCancelInDataFetchStatus", "_i_IsCancelInDataFetchStatus", "_i_IsCancelInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_RequisitionApprovalLevelId", "i_RequisitionApprovalLevelIdIn", "i_RequisitionApprovalLevelId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionApprovalLevelIdInDataFetchStatus", "_i_RequisitionApprovalLevelIdInDataFetchStatus", "_i_RequisitionApprovalLevelIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = inputs.i_RequisitionId;
if("_i_RequisitionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionIdInDataFetchStatus = inputs._i_RequisitionIdInDataFetchStatus;
}

}

if("i_IsCancel" in inputs) {
this.variables.i_IsCancelIn = inputs.i_IsCancel;
if("_i_IsCancelInDataFetchStatus" in inputs) {
this.variables._i_IsCancelInDataFetchStatus = inputs._i_IsCancelInDataFetchStatus;
}

}

if("i_RequisitionApprovalLevelId" in inputs) {
this.variables.i_RequisitionApprovalLevelIdIn = inputs.i_RequisitionApprovalLevelId;
if("_i_RequisitionApprovalLevelIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionApprovalLevelIdInDataFetchStatus = inputs._i_RequisitionApprovalLevelIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


