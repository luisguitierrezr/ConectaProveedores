import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_acb134934352a9d72fd2cc0509d2f469, EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, RC_2d026dc77741fad17a11f0df63aa3b4b, ST_e39617f0f094a322d4157f34fe424dadStructure, RC_7d9af3f1351b60af34cc932af3010814, ST_6ac87b97c676cd17082ba2063283d4baStructure, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure } from "./ConectaProveedores.model.js";
import { EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord } from "./Organization.model.js";

class GetInvoicesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_acb134934352a9d72fd2cc0509d2f469));
}
static fromStructure(str) {
return new GetInvoicesAggrRec(new GetInvoicesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesAggrRec.init();

class GetApprovalStatusesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, {
name: "ApprovalStatus",
attrName: "approvalStatusAttr",
nameForJson: "ApprovalStatus",
uniqueId: "5e94710b-a0de-6484-5af2-f9d1cc088302"
}))));
}
static fromStructure(str) {
return new GetApprovalStatusesAggrRec(new GetApprovalStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalStatusesAggrRec.init();

class GetProjectAssetServicesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, {
name: "Project_Asset_Service",
attrName: "project_Asset_ServiceAttr",
nameForJson: "Project_Asset_Service",
uniqueId: "1b08a2c1-cece-f1e3-b300-6a60b97fc68e"
}))));
}
static fromStructure(str) {
return new GetProjectAssetServicesAggrRec(new GetProjectAssetServicesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProjectAssetServicesAggrRec.init();

class GetInvoicesFullAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_acb134934352a9d72fd2cc0509d2f469));
}
static fromStructure(str) {
return new GetInvoicesFullAggrRec(new GetInvoicesFullAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesFullAggrRec.init();

class GetEntraRoleAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2d026dc77741fad17a11f0df63aa3b4b));
}
static fromStructure(str) {
return new GetEntraRoleAggrRec(new GetEntraRoleAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEntraRoleAggrRec.init();

class GetCompaniesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, {
name: "Company",
attrName: "companyAttr",
nameForJson: "Company",
uniqueId: "99a1fa6d-f481-ec5b-1908-e770c81b73b1"
}))));
}
static fromStructure(str) {
return new GetCompaniesAggrRec(new GetCompaniesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCompaniesAggrRec.init();


class GetInvoiceCountToAssignDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsShowInfoMsg", "isShowInfoMsgOut", "IsShowInfoMsg", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetInvoiceCountToAssignDataActRec(new GetInvoiceCountToAssignDataActRec.RecordClass({
isShowInfoMsgOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceCountToAssignDataActRec.init();

class GetUserApplicationRolesAndMoreDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("IsCorporativoCxP", "isCorporativoCxPOut", "IsCorporativoCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AppRolesListText", "appRolesListTextOut", "AppRolesListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TelcelDirectionsListText", "telcelDirectionsListTextOut", "TelcelDirectionsListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsSupervisor", "isSupervisorOut", "IsSupervisor", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsAnalistaCxP", "isAnalistaCxPOut", "IsAnalistaCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsJefeCxP", "isJefeCxPOut", "IsJefeCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("CorporativoRegionId", "corporativoRegionIdOut", "CorporativoRegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("TelcelDirectionsListTextForQuery", "telcelDirectionsListTextForQueryOut", "TelcelDirectionsListTextForQuery", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("UserRegion", "userRegionOut", "UserRegion", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("IsActiveDEV_NewVersionScreenDownloads", "isActiveDEV_NewVersionScreenDownloadsOut", "IsActiveDEV_NewVersionScreenDownloads", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesAndMoreDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ApplicationRoleIdForAggregate", "l_ApplicationRoleIdForAggregateVar", "l_ApplicationRoleIdForAggregate", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ColumnJSONVar", "l_ColumnJSONVarVar", "l_ColumnJSONVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetch", "l_CountAfterFetchVar", "l_CountAfterFetch", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_IsAllowSelectApplicationRoles", "l_IsAllowSelectApplicationRolesVar", "l_IsAllowSelectApplicationRoles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsShowSelectAll", "l_IsShowSelectAllVar", "l_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectedForApproval", "l_IsSelectedForApprovalVar", "l_IsSelectedForApproval", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAllForApproval", "l_IsSelectAllForApprovalVar", "l_IsSelectAllForApproval", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectedForAssignment", "l_IsSelectedForAssignmentVar", "l_IsSelectedForAssignment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAllForAssignment", "l_IsSelectAllForAssignmentVar", "l_IsSelectAllForAssignment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowBulkRejectPopup", "l_ShowBulkRejectPopupVar", "l_ShowBulkRejectPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_InvoiceId", "l_InvoiceIdVar", "l_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_InvoiceApprovalLevelList", "l_InvoiceApprovalLevelListVar", "l_InvoiceApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_7d9af3f1351b60af34cc932af3010814))());
}, false, (OS$GenericTypeCache.getGenericList(RC_7d9af3f1351b60af34cc932af3010814))), 
this.attr("l_InvoiceApprovalLevelId", "l_InvoiceApprovalLevelIdVar", "l_InvoiceApprovalLevelId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ShowBulkApproveInvoices", "l_ShowBulkApproveInvoicesVar", "l_ShowBulkApproveInvoices", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowApproveInvoice", "l_ShowApproveInvoiceVar", "l_ShowApproveInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowRejectInvoice", "l_ShowRejectInvoiceVar", "l_ShowRejectInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowAssignFirstApproverPopup", "l_ShowAssignFirstApproverPopupVar", "l_ShowAssignFirstApproverPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowBulkComment", "l_ShowBulkCommentVar", "l_ShowBulkComment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowComment", "l_ShowCommentVar", "l_ShowComment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowAssignAnalistaPopup", "l_ShowAssignAnalistaPopupVar", "l_ShowAssignAnalistaPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("NotifContent", "notifContentVar", "NotifContent", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6ac87b97c676cd17082ba2063283d4baStructure());
}, false, ST_6ac87b97c676cd17082ba2063283d4baStructure), 
this.attr("NotifError", "notifErrorVar", "NotifError", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure());
}, false, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure), 
this.attr("l_InvoicesTablesIdList", "l_InvoicesTablesIdListVar", "l_InvoicesTablesIdList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new OS$DataTypes.LongIntegerList());
}, false, OS$DataTypes.LongIntegerList), 
this.attr("l_ShowScreenTableDownloads", "l_ShowScreenTableDownloadsVar", "l_ShowScreenTableDownloads", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsListFullNeedRefresh", "isListFullNeedRefreshVar", "IsListFullNeedRefresh", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetInvoices", "getInvoicesAggr", "GetInvoices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesAggrRec());
}, true, GetInvoicesAggrRec), 
this.attr("GetApprovalStatuses", "getApprovalStatusesAggr", "GetApprovalStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalStatusesAggrRec());
}, true, GetApprovalStatusesAggrRec), 
this.attr("GetProjectAssetServices", "getProjectAssetServicesAggr", "GetProjectAssetServices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServicesAggrRec());
}, true, GetProjectAssetServicesAggrRec), 
this.attr("GetInvoicesFull", "getInvoicesFullAggr", "GetInvoicesFull", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesFullAggrRec());
}, true, GetInvoicesFullAggrRec), 
this.attr("GetEntraRole", "getEntraRoleAggr", "GetEntraRole", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntraRoleAggrRec());
}, true, GetEntraRoleAggrRec), 
this.attr("GetCompanies", "getCompaniesAggr", "GetCompanies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCompaniesAggrRec());
}, true, GetCompaniesAggrRec), 
this.attr("GetInvoiceCountToAssign", "getInvoiceCountToAssignDataAct", "GetInvoiceCountToAssign", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceCountToAssignDataActRec());
}, true, GetInvoiceCountToAssignDataActRec), 
this.attr("GetUserApplicationRolesAndMore", "getUserApplicationRolesAndMoreDataAct", "GetUserApplicationRolesAndMore", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesAndMoreDataActRec());
}, true, GetUserApplicationRolesAndMoreDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Search: OS$Model.ValidationWidgetRecord,
Input_Search2: OS$Model.ValidationWidgetRecord,
Dropdown_BankId2: OS$Model.ValidationWidgetRecord,
Dropdown_ApprovalStatus: OS$Model.ValidationWidgetRecord,
Input_PaymentDate2: OS$Model.ValidationWidgetRecord,
Input_PaymentDate3: OS$Model.ValidationWidgetRecord,
Dropdown_l_ApplicationRoleIdForAggregate: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelectAll: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelected: OS$Model.ValidationWidgetRecord
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
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


