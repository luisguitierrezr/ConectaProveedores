import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_c0133441667bf39f1c8403118864a3c3, RC_fd17f3b5298bdff8f863d6f0335db07c, RC_d7d7e269eeb924718adc0d2a0b1d922d, ST_e39617f0f094a322d4157f34fe424dadStructure, RC_ab183c41bd8594296e7d4471350fb29f, ST_6ac87b97c676cd17082ba2063283d4baStructure, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure } from "./ConectaProveedores.model.js";

class GetSuppliersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c0133441667bf39f1c8403118864a3c3));
}
static fromStructure(str) {
return new GetSuppliersAggrRec(new GetSuppliersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSuppliersAggrRec.init();

class GetRegionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_fd17f3b5298bdff8f863d6f0335db07c));
}
static fromStructure(str) {
return new GetRegionsAggrRec(new GetRegionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRegionsAggrRec.init();

class GetFoliosSAEAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d7d7e269eeb924718adc0d2a0b1d922d));
}
static fromStructure(str) {
return new GetFoliosSAEAggrRec(new GetFoliosSAEAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFoliosSAEAggrRec.init();


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
this.attr("CanBulkApprove", "canBulkApproveOut", "CanBulkApprove", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();


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
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
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
this.attr("l_IsSelected", "l_IsSelectedVar", "l_IsSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsShowSelectAll", "l_IsShowSelectAllVar", "l_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_FolioId", "l_FolioIdVar", "l_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_FolioApprovalLevelList", "l_FolioApprovalLevelListVar", "l_FolioApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_ab183c41bd8594296e7d4471350fb29f))());
}, false, (OS$GenericTypeCache.getGenericList(RC_ab183c41bd8594296e7d4471350fb29f))), 
this.attr("l_FolioApprovalLevelId", "l_FolioApprovalLevelIdVar", "l_FolioApprovalLevelId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ShowBulkApproveFolio", "l_ShowBulkApproveFolioVar", "l_ShowBulkApproveFolio", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowApproveFolio", "l_ShowApproveFolioVar", "l_ShowApproveFolio", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("NotifContent", "notifContentVar", "NotifContent", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6ac87b97c676cd17082ba2063283d4baStructure());
}, false, ST_6ac87b97c676cd17082ba2063283d4baStructure), 
this.attr("NotifError", "notifErrorVar", "NotifError", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure());
}, false, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure), 
this.attr("GetSuppliers", "getSuppliersAggr", "GetSuppliers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSuppliersAggrRec());
}, true, GetSuppliersAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
this.attr("GetFoliosSAE", "getFoliosSAEAggr", "GetFoliosSAE", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFoliosSAEAggrRec());
}, true, GetFoliosSAEAggrRec), 
this.attr("GetUserApplicationRoles", "getUserApplicationRolesDataAct", "GetUserApplicationRoles", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesDataActRec());
}, true, GetUserApplicationRolesDataActRec)
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
Dropdown_Regiond: OS$Model.ValidationWidgetRecord,
Input_CreatedOnDate: OS$Model.ValidationWidgetRecord,
Input_CreatedToDate: OS$Model.ValidationWidgetRecord,
Dropdown_l_ApplicationRoleIdForAggregate: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord,
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


