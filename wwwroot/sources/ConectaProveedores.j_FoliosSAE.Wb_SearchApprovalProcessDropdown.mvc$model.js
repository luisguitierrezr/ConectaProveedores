import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_8cfc2af1075444d3070aa6269dcfdf32 } from "./ConectaProveedores.model.js";
import { EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord } from "./WorkflowEngine.model.js";

class GetApprovalProcesssAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_8cfc2af1075444d3070aa6269dcfdf32));
}
static fromStructure(str) {
return new GetApprovalProcesssAggrRec(new GetApprovalProcesssAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalProcesssAggrRec.init();

class GetApprovalProcessByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord, {
name: "ApprovalProcess",
attrName: "approvalProcessAttr",
nameForJson: "ApprovalProcess",
uniqueId: "f2bd78b8-6ae9-bba0-b46c-c5d8814834af"
}))));
}
static fromStructure(str) {
return new GetApprovalProcessByIdAggrRec(new GetApprovalProcessByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalProcessByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ApprovalProcessSearchText", "l_ApprovalProcessSearchTextVar", "l_ApprovalProcessSearchText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_ApprovalProcessMaxRecord", "l_ApprovalProcessMaxRecordVar", "l_ApprovalProcessMaxRecord", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 20;
}, false), 
this.attr("l_IsValid", "l_IsValidVar", "l_IsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("i_IsDisable", "i_IsDisableIn", "i_IsDisable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsDisableInDataFetchStatus", "_i_IsDisableInDataFetchStatus", "_i_IsDisableInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ApprovalProcessId", "i_ApprovalProcessIdIn", "i_ApprovalProcessId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ApprovalProcessIdInDataFetchStatus", "_i_ApprovalProcessIdInDataFetchStatus", "_i_ApprovalProcessIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsValid", "i_IsValidIn", "i_IsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsValidInDataFetchStatus", "_i_IsValidInDataFetchStatus", "_i_IsValidInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsMandatory", "i_IsMandatoryIn", "i_IsMandatory", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsFilter", "i_IsFilterIn", "i_IsFilter", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsFilterInDataFetchStatus", "_i_IsFilterInDataFetchStatus", "_i_IsFilterInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ApprovalProcessTypeId", "i_ApprovalProcessTypeIdIn", "i_ApprovalProcessTypeId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_i_ApprovalProcessTypeIdInDataFetchStatus", "_i_ApprovalProcessTypeIdInDataFetchStatus", "_i_ApprovalProcessTypeIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApprovalProcesss", "getApprovalProcesssAggr", "GetApprovalProcesss", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalProcesssAggrRec());
}, true, GetApprovalProcesssAggrRec), 
this.attr("GetApprovalProcessById", "getApprovalProcessByIdAggr", "GetApprovalProcessById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalProcessByIdAggrRec());
}, true, GetApprovalProcessByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_ApprovalProcessSearchText: OS$Model.ValidationWidgetRecord
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
if("i_IsDisable" in inputs) {
this.variables.i_IsDisableIn = inputs.i_IsDisable;
if("_i_IsDisableInDataFetchStatus" in inputs) {
this.variables._i_IsDisableInDataFetchStatus = inputs._i_IsDisableInDataFetchStatus;
}

}

if("i_ApprovalProcessId" in inputs) {
this.variables.i_ApprovalProcessIdIn = inputs.i_ApprovalProcessId;
if("_i_ApprovalProcessIdInDataFetchStatus" in inputs) {
this.variables._i_ApprovalProcessIdInDataFetchStatus = inputs._i_ApprovalProcessIdInDataFetchStatus;
}

}

if("i_IsValid" in inputs) {
this.variables.i_IsValidIn = inputs.i_IsValid;
if("_i_IsValidInDataFetchStatus" in inputs) {
this.variables._i_IsValidInDataFetchStatus = inputs._i_IsValidInDataFetchStatus;
}

}

if("i_IsMandatory" in inputs) {
this.variables.i_IsMandatoryIn = inputs.i_IsMandatory;
if("_i_IsMandatoryInDataFetchStatus" in inputs) {
this.variables._i_IsMandatoryInDataFetchStatus = inputs._i_IsMandatoryInDataFetchStatus;
}

}

if("i_IsFilter" in inputs) {
this.variables.i_IsFilterIn = inputs.i_IsFilter;
if("_i_IsFilterInDataFetchStatus" in inputs) {
this.variables._i_IsFilterInDataFetchStatus = inputs._i_IsFilterInDataFetchStatus;
}

}

if("i_ApprovalProcessTypeId" in inputs) {
this.variables.i_ApprovalProcessTypeIdIn = inputs.i_ApprovalProcessTypeId;
if("_i_ApprovalProcessTypeIdInDataFetchStatus" in inputs) {
this.variables._i_ApprovalProcessTypeIdInDataFetchStatus = inputs._i_ApprovalProcessTypeIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


