import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad, ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure } from "./ConectaProveedores.model.js";
import { EN_31f501c551d210017fcb34b5237e3390EntityRecord } from "./Organization.model.js";

class GetOrderDistributionConfigAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad));
}
static fromStructure(str) {
return new GetOrderDistributionConfigAggrRec(new GetOrderDistributionConfigAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderDistributionConfigAggrRec.init();

class GetRegionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_31f501c551d210017fcb34b5237e3390EntityRecord, {
name: "Region",
attrName: "regionAttr",
nameForJson: "Region",
uniqueId: "deb85dc3-6640-fa92-8dae-5df2493065d0"
}))));
}
static fromStructure(str) {
return new GetRegionsAggrRec(new GetRegionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRegionsAggrRec.init();


class GetOrderMainDataOnInputDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("OutFilters", "outFiltersOut", "OutFilters", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure());
}, true, ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure), 
this.attr("IsOrderRejected", "isOrderRejectedOut", "IsOrderRejected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetOrderMainDataOnInputDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_TabNumber", "l_TabNumberVar", "l_TabNumber", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_ShowAudit", "l_ShowAuditVar", "l_ShowAudit", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_AuditInitialDateTime", "l_AuditInitialDateTimeVar", "l_AuditInitialDateTime", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_AuditFinalDateTime", "l_AuditFinalDateTimeVar", "l_AuditFinalDateTime", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_IsOrderRejected", "l_IsOrderRejectedVar", "l_IsOrderRejected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsOpenPopupConfirmation", "isOpenPopupConfirmationVar", "IsOpenPopupConfirmation", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("RequestDistributionConfigId_ToSave", "requestDistributionConfigId_ToSaveVar", "RequestDistributionConfigId_ToSave", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("OrderMainId_ToSave", "orderMainId_ToSaveVar", "OrderMainId_ToSave", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_InPopup", "i_InPopupIn", "i_InPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_InPopupInDataFetchStatus", "_i_InPopupInDataFetchStatus", "_i_InPopupInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderDistributionConfig", "getOrderDistributionConfigAggr", "GetOrderDistributionConfig", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderDistributionConfigAggrRec());
}, true, GetOrderDistributionConfigAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
this.attr("GetOrderMainDataOnInput", "getOrderMainDataOnInputDataAct", "GetOrderMainDataOnInput", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainDataOnInputDataActRec());
}, true, GetOrderMainDataOnInputDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Dropdown1: OS$Model.ValidationWidgetRecord,
Input_Applicant: OS$Model.ValidationWidgetRecord,
Input_ApplicantDesc: OS$Model.ValidationWidgetRecord,
Input_Direction: OS$Model.ValidationWidgetRecord,
Input_Role: OS$Model.ValidationWidgetRecord,
ButtonGroup1: OS$Model.ValidationWidgetRecord,
Input_PeriodInit: OS$Model.ValidationWidgetRecord,
Input_PeriodEnd: OS$Model.ValidationWidgetRecord
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
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

if("i_InPopup" in inputs) {
this.variables.i_InPopupIn = inputs.i_InPopup;
if("_i_InPopupInDataFetchStatus" in inputs) {
this.variables._i_InPopupInDataFetchStatus = inputs._i_InPopupInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


