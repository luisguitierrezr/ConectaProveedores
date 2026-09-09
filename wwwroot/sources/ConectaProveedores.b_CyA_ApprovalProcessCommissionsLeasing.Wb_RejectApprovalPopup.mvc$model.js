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
this.attr("i_ProposalId", "i_ProposalIdIn", "i_ProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ProposalLineApprovalLevelIdToReject", "i_ProposalLineApprovalLevelIdToRejectIn", "i_ProposalLineApprovalLevelIdToReject", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalLineApprovalLevelIdToRejectInDataFetchStatus", "_i_ProposalLineApprovalLevelIdToRejectInDataFetchStatus", "_i_ProposalLineApprovalLevelIdToRejectInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("i_ProposalId" in inputs) {
this.variables.i_ProposalIdIn = inputs.i_ProposalId;
if("_i_ProposalIdInDataFetchStatus" in inputs) {
this.variables._i_ProposalIdInDataFetchStatus = inputs._i_ProposalIdInDataFetchStatus;
}

}

if("i_ProposalLineApprovalLevelIdToReject" in inputs) {
this.variables.i_ProposalLineApprovalLevelIdToRejectIn = inputs.i_ProposalLineApprovalLevelIdToReject;
if("_i_ProposalLineApprovalLevelIdToRejectInDataFetchStatus" in inputs) {
this.variables._i_ProposalLineApprovalLevelIdToRejectInDataFetchStatus = inputs._i_ProposalLineApprovalLevelIdToRejectInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


