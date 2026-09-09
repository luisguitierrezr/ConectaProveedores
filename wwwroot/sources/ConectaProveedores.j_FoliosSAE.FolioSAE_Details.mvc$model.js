import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion } from "@outsystems/runtime-core-js";
import { RC_95110bc97f34f4c1561c8cbf2b5015b2, RC_131b941598d8581e5466dbb966f5f0a8, EN_171b22187ea6e4b12c9f086502740307EntityRecord, RC_d41d580f2f54d1ea8dfa839824757d81, RC_619a3314c0f5e7503d1faa5bd2f55a41, ST_e39617f0f094a322d4157f34fe424dadStructure, ST_3c480a6d17a69eed60b057b7ed343a1dStructure } from "./ConectaProveedores.model.js";

class GetFolioItemsByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_95110bc97f34f4c1561c8cbf2b5015b2));
}
static fromStructure(str) {
return new GetFolioItemsByFolioIdAggrRec(new GetFolioItemsByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioItemsByFolioIdAggrRec.init();

class GetFolioApprovalRejectReasonAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_131b941598d8581e5466dbb966f5f0a8));
}
static fromStructure(str) {
return new GetFolioApprovalRejectReasonAggrRec(new GetFolioApprovalRejectReasonAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalRejectReasonAggrRec.init();

class GetFolioCommentsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_171b22187ea6e4b12c9f086502740307EntityRecord, {
name: "FolioObservations",
attrName: "folioObservationsAttr",
nameForJson: "FolioObservations",
uniqueId: "017cba02-e4fd-7f68-4606-081b7269a26b"
}))));
}
static fromStructure(str) {
return new GetFolioCommentsAggrRec(new GetFolioCommentsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioCommentsAggrRec.init();

class GetFirstApprovalAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d41d580f2f54d1ea8dfa839824757d81));
}
static fromStructure(str) {
return new GetFirstApprovalAggrRec(new GetFirstApprovalAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFirstApprovalAggrRec.init();

class GetFolioByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_619a3314c0f5e7503d1faa5bd2f55a41));
}
static fromStructure(str) {
return new GetFolioByIdAggrRec(new GetFolioByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioByIdAggrRec.init();


class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("AppRoleListText", "appRoleListTextOut", "AppRoleListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("EntraRolesListText", "entraRolesListTextOut", "EntraRolesListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsActiveDEV_DisenoUI", "isActiveDEV_DisenoUIOut", "IsActiveDEV_DisenoUI", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();

class GetRejectCommentDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("RejectCommentText", "rejectCommentTextOut", "RejectCommentText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetRejectCommentDataActRec(new GetRejectCommentDataActRec.RecordClass({
rejectCommentTextOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRejectCommentDataActRec.init();

class GetFolioApprovalDisplayDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("FolioApprovalDisplayList", "folioApprovalDisplayListOut", "FolioApprovalDisplayList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_3c480a6d17a69eed60b057b7ed343a1dStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_3c480a6d17a69eed60b057b7ed343a1dStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetFolioApprovalDisplayDataActRec(new GetFolioApprovalDisplayDataActRec.RecordClass({
folioApprovalDisplayListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalDisplayDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_RefreshOrderEntra_Historic", "l_RefreshOrderEntra_HistoricVar", "l_RefreshOrderEntra_Historic", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$BuiltinFunctions.currDateTime();
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ShowCancelPopup", "showCancelPopupVar", "ShowCancelPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsDirectReport", "i_IsDirectReportIn", "i_IsDirectReport", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsDirectReportInDataFetchStatus", "_i_IsDirectReportInDataFetchStatus", "_i_IsDirectReportInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioItemsByFolioId", "getFolioItemsByFolioIdAggr", "GetFolioItemsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioItemsByFolioIdAggrRec());
}, true, GetFolioItemsByFolioIdAggrRec), 
this.attr("GetFolioApprovalRejectReason", "getFolioApprovalRejectReasonAggr", "GetFolioApprovalRejectReason", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalRejectReasonAggrRec());
}, true, GetFolioApprovalRejectReasonAggrRec), 
this.attr("GetFolioComments", "getFolioCommentsAggr", "GetFolioComments", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioCommentsAggrRec());
}, true, GetFolioCommentsAggrRec), 
this.attr("GetFirstApproval", "getFirstApprovalAggr", "GetFirstApproval", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFirstApprovalAggrRec());
}, true, GetFirstApprovalAggrRec), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec), 
this.attr("GetUserApplicationRoles", "getUserApplicationRolesDataAct", "GetUserApplicationRoles", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesDataActRec());
}, true, GetUserApplicationRolesDataActRec), 
this.attr("GetRejectComment", "getRejectCommentDataAct", "GetRejectComment", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRejectCommentDataActRec());
}, true, GetRejectCommentDataActRec), 
this.attr("GetFolioApprovalDisplay", "getFolioApprovalDisplayDataAct", "GetFolioApprovalDisplay", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalDisplayDataActRec());
}, true, GetFolioApprovalDisplayDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
Input_FolioNumber: OS$Model.ValidationWidgetRecord,
Input_OrderNumber: OS$Model.ValidationWidgetRecord,
Input_Description: OS$Model.ValidationWidgetRecord,
Input_TotalAmount: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord,
Input_CurrencyName: OS$Model.ValidationWidgetRecord,
Input_TotalIVA_Amount: OS$Model.ValidationWidgetRecord,
Input_OrderNumber2: OS$Model.ValidationWidgetRecord,
Input_OrderNumber4: OS$Model.ValidationWidgetRecord,
Input_OrderNumber3: OS$Model.ValidationWidgetRecord,
Input_OrderNumber6: OS$Model.ValidationWidgetRecord,
Input_OrderNumber7: OS$Model.ValidationWidgetRecord,
Input_OrderNumber5: OS$Model.ValidationWidgetRecord,
Input_OrderNumber9: OS$Model.ValidationWidgetRecord
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
if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = DataConversion.ServerDataConverter.from(inputs.i_FolioId, OS$DataTypes.DataTypes.LongInteger);
}

if("i_IsDirectReport" in inputs) {
this.variables.i_IsDirectReportIn = DataConversion.ServerDataConverter.from(inputs.i_IsDirectReport, OS$DataTypes.DataTypes.Boolean);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


