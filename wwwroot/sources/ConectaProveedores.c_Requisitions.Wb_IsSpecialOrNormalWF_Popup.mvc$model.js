import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_f4217b217830b749d338ebe1832450a6, RC_e05385e784b7ab877b391b661988aada } from "./ConectaProveedores.model.js";
import { EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord } from "./WorkflowEngine.model.js";


class GetFirstApproverListDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserList", "userListOut", "UserList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_f4217b217830b749d338ebe1832450a6))());
}, true, (OS$GenericTypeCache.getGenericList(RC_f4217b217830b749d338ebe1832450a6)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetFirstApproverListDataActRec(new GetFirstApproverListDataActRec.RecordClass({
userListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFirstApproverListDataActRec.init();

class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsActiveDEV_FlujoRRHH", "o_IsActiveDEV_FlujoRRHHOut", "o_IsActiveDEV_FlujoRRHH", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
o_IsActiveDEV_FlujoRRHHOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();

class GetSpecialWorkflowsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ApprovalProcessList", "approvalProcessListOut", "ApprovalProcessList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord))());
}, true, (OS$GenericTypeCache.getGenericList(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSpecialWorkflowsDataActRec(new GetSpecialWorkflowsDataActRec.RecordClass({
approvalProcessListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSpecialWorkflowsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsBusy", "l_IsBusyVar", "l_IsBusy", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_FirstApproverUserId", "l_FirstApproverUserIdVar", "l_FirstApproverUserId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_SpecialWorkflowSelected", "l_SpecialWorkflowSelectedVar", "l_SpecialWorkflowSelected", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_e05385e784b7ab877b391b661988aada());
}, false, RC_e05385e784b7ab877b391b661988aada), 
this.attr("ProcessTypeCode", "processTypeCodeIn", "ProcessTypeCode", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_processTypeCodeInDataFetchStatus", "_processTypeCodeInDataFetchStatus", "_processTypeCodeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsDonation", "isDonationIn", "IsDonation", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isDonationInDataFetchStatus", "_isDonationInDataFetchStatus", "_isDonationInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFirstApproverList", "getFirstApproverListDataAct", "GetFirstApproverList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFirstApproverListDataActRec());
}, true, GetFirstApproverListDataActRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec), 
this.attr("GetSpecialWorkflows", "getSpecialWorkflowsDataAct", "GetSpecialWorkflows", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSpecialWorkflowsDataActRec());
}, true, GetSpecialWorkflowsDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord
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
if("ProcessTypeCode" in inputs) {
this.variables.processTypeCodeIn = inputs.ProcessTypeCode;
if("_processTypeCodeInDataFetchStatus" in inputs) {
this.variables._processTypeCodeInDataFetchStatus = inputs._processTypeCodeInDataFetchStatus;
}

}

if("IsDonation" in inputs) {
this.variables.isDonationIn = inputs.IsDonation;
if("_isDonationInDataFetchStatus" in inputs) {
this.variables._isDonationInDataFetchStatus = inputs._isDonationInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


