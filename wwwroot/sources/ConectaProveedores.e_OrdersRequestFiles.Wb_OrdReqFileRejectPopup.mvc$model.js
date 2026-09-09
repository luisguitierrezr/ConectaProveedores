import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_RejectReason", "l_RejectReasonVar", "l_RejectReason", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_OrderRequestFileApprovalLevelIdToReject", "i_OrderRequestFileApprovalLevelIdToRejectIn", "i_OrderRequestFileApprovalLevelIdToReject", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderRequestFileApprovalLevelIdToRejectInDataFetchStatus", "_i_OrderRequestFileApprovalLevelIdToRejectInDataFetchStatus", "_i_OrderRequestFileApprovalLevelIdToRejectInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
TextArea_l_RejectReason: OS$Model.ValidationWidgetRecord
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
if("i_OrderRequestFileApprovalLevelIdToReject" in inputs) {
this.variables.i_OrderRequestFileApprovalLevelIdToRejectIn = inputs.i_OrderRequestFileApprovalLevelIdToReject;
if("_i_OrderRequestFileApprovalLevelIdToRejectInDataFetchStatus" in inputs) {
this.variables._i_OrderRequestFileApprovalLevelIdToRejectInDataFetchStatus = inputs._i_OrderRequestFileApprovalLevelIdToRejectInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


