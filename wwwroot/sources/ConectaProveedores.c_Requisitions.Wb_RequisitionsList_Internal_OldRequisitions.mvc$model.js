import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord } from "./Organization.model.js";
import { EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord, RC_2d026dc77741fad17a11f0df63aa3b4b, RC_ed0b8e4be2720d34635f080b43e417d8, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";

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

class GetCostCentersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, {
name: "CostCenterSAP",
attrName: "costCenterSAPAttr",
nameForJson: "CostCenterSAP",
uniqueId: "515e950f-e4b2-9206-769e-5475135e301d"
}))));
}
static fromStructure(str) {
return new GetCostCentersAggrRec(new GetCostCentersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCostCentersAggrRec.init();

class GetRequisitionStatusesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_0554a1252840ba4a5c4e6af5899608adEntityRecord, {
name: "RequisitionStatus",
attrName: "requisitionStatusAttr",
nameForJson: "RequisitionStatus",
uniqueId: "b0a85cd9-83a4-f43f-ec20-a9e94774104b"
}))));
}
static fromStructure(str) {
return new GetRequisitionStatusesAggrRec(new GetRequisitionStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionStatusesAggrRec.init();

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


class GetRequisitionsFullDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_ed0b8e4be2720d34635f080b43e417d8))());
}, true, (OS$GenericTypeCache.getGenericList(RC_ed0b8e4be2720d34635f080b43e417d8))), 
this.attr("SortClause", "sortClauseOut", "SortClause", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetRequisitionsFullDataActRec.init();

class GetUserApplicationRolesAndMoreDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("AppRoleListText", "appRoleListTextOut", "AppRoleListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsCorporativoCxP", "isCorporativoCxPOut", "IsCorporativoCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_CanUploadInvoices", "o_CanUploadInvoicesOut", "o_CanUploadInvoices", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("TelcelDirectionsListText", "telcelDirectionsListTextOut", "TelcelDirectionsListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("CorporativoRegionId", "corporativoRegionIdOut", "CorporativoRegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
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

class GetRequisitionsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_ed0b8e4be2720d34635f080b43e417d8))());
}, true, (OS$GenericTypeCache.getGenericList(RC_ed0b8e4be2720d34635f080b43e417d8))), 
this.attr("TotalCount", "totalCountOut", "TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("SortClause", "sortClauseOut", "SortClause", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetRequisitionsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ShowFilters", "l_ShowFiltersVar", "l_ShowFilters", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "Requisition.Id DESC";
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ApplicationRoleIdForAggregate", "l_ApplicationRoleIdForAggregateVar", "l_ApplicationRoleIdForAggregate", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_IsAllowSelectApplicationRoles", "l_IsAllowSelectApplicationRolesVar", "l_IsAllowSelectApplicationRoles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetRequisitions", "l_ColumnJSONVarGetRequisitionsVar", "l_ColumnJSONVarGetRequisitions", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetRequisitions", "l_CountAfterFetchGetRequisitionsVar", "l_CountAfterFetchGetRequisitions", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ShowCancelPopup", "l_ShowCancelPopupVar", "l_ShowCancelPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_AmountFromText", "l_AmountFromTextVar", "l_AmountFromText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AmountToText", "l_AmountToTextVar", "l_AmountToText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_RequisitonToCancel", "l_RequisitonToCancelVar", "l_RequisitonToCancel", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ShowScreenTableDownloads", "l_ShowScreenTableDownloadsVar", "l_ShowScreenTableDownloads", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RequisitionsListInternalIdList", "l_RequisitionsListInternalIdListVar", "l_RequisitionsListInternalIdList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new OS$DataTypes.LongIntegerList());
}, false, OS$DataTypes.LongIntegerList), 
this.attr("IsListFullNeedRefresh", "isListFullNeedRefreshVar", "IsListFullNeedRefresh", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetCompanies", "getCompaniesAggr", "GetCompanies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCompaniesAggrRec());
}, true, GetCompaniesAggrRec), 
this.attr("GetApprovalStatuses", "getApprovalStatusesAggr", "GetApprovalStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalStatusesAggrRec());
}, true, GetApprovalStatusesAggrRec), 
this.attr("GetProjectAssetServices", "getProjectAssetServicesAggr", "GetProjectAssetServices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServicesAggrRec());
}, true, GetProjectAssetServicesAggrRec), 
this.attr("GetCostCenters", "getCostCentersAggr", "GetCostCenters", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCostCentersAggrRec());
}, true, GetCostCentersAggrRec), 
this.attr("GetRequisitionStatuses", "getRequisitionStatusesAggr", "GetRequisitionStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionStatusesAggrRec());
}, true, GetRequisitionStatusesAggrRec), 
this.attr("GetEntraRole", "getEntraRoleAggr", "GetEntraRole", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntraRoleAggrRec());
}, true, GetEntraRoleAggrRec), 
this.attr("GetRequisitionsFull", "getRequisitionsFullDataAct", "GetRequisitionsFull", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionsFullDataActRec());
}, true, GetRequisitionsFullDataActRec), 
this.attr("GetUserApplicationRolesAndMore", "getUserApplicationRolesAndMoreDataAct", "GetUserApplicationRolesAndMore", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesAndMoreDataActRec());
}, true, GetUserApplicationRolesAndMoreDataActRec), 
this.attr("GetRequisitions", "getRequisitionsDataAct", "GetRequisitions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionsDataActRec());
}, true, GetRequisitionsDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Nothing2: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentProposalStatusId: OS$Model.ValidationWidgetRecord,
Dropdown_ApprovalStatus: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Dropdown_BankId2: OS$Model.ValidationWidgetRecord,
Input_AmountML3: OS$Model.ValidationWidgetRecord,
Input_AmountML2: OS$Model.ValidationWidgetRecord,
Dropdown_BankId4: OS$Model.ValidationWidgetRecord,
Dropdown_l_ApplicationRoleIdForAggregate: OS$Model.ValidationWidgetRecord
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


