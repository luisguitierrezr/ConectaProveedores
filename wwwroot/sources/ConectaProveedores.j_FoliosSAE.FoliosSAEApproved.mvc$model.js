import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_d7d7e269eeb924718adc0d2a0b1d922d, RC_fd17f3b5298bdff8f863d6f0335db07c, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";

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

class GetFoliosSAEFullAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d7d7e269eeb924718adc0d2a0b1d922d));
}
static fromStructure(str) {
return new GetFoliosSAEFullAggrRec(new GetFoliosSAEFullAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFoliosSAEFullAggrRec.init();

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

class GetFolioStatusAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, {
name: "FolioStatus",
attrName: "folioStatusAttr",
nameForJson: "FolioStatus",
uniqueId: "c75df7b2-e7c6-e74a-3a45-dda7bd7b93e2"
}))));
}
static fromStructure(str) {
return new GetFolioStatusAggrRec(new GetFolioStatusAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioStatusAggrRec.init();


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
}, true), 
this.attr("IsActiveDEV_NewVersionScreenDownloads", "isActiveDEV_NewVersionScreenDownloadsOut", "IsActiveDEV_NewVersionScreenDownloads", true, false, OS$DataTypes.DataTypes.Boolean, function () {
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
this.attr("IsListFullNeedRefresh", "isListFullNeedRefreshVar", "IsListFullNeedRefresh", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetFoliosSAE", "getFoliosSAEAggr", "GetFoliosSAE", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFoliosSAEAggrRec());
}, true, GetFoliosSAEAggrRec), 
this.attr("GetFoliosSAEFull", "getFoliosSAEFullAggr", "GetFoliosSAEFull", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFoliosSAEFullAggrRec());
}, true, GetFoliosSAEFullAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
this.attr("GetFolioStatus", "getFolioStatusAggr", "GetFolioStatus", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioStatusAggrRec());
}, true, GetFolioStatusAggrRec), 
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
Dropdown_Status: OS$Model.ValidationWidgetRecord,
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


