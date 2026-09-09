import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_6441282eac0a2260326cac952b2cda40, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";

class GetFolioApprovalLevelsByAssignedToAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_6441282eac0a2260326cac952b2cda40));
}
static fromStructure(str) {
return new GetFolioApprovalLevelsByAssignedToAggrRec(new GetFolioApprovalLevelsByAssignedToAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalLevelsByAssignedToAggrRec.init();


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
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Motive", "l_MotiveVar", "l_Motive", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_SourceUserId", "l_SourceUserIdVar", "l_SourceUserId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_SubstituteUserId", "l_SubstituteUserIdVar", "l_SubstituteUserId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_ShowConfirmPopup", "l_ShowConfirmPopupVar", "l_ShowConfirmPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 999;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelect", "l_IsSelectVar", "l_IsSelect", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_IsSidebarOpen", "i_IsSidebarOpenIn", "i_IsSidebarOpen", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsSidebarOpenInDataFetchStatus", "_i_IsSidebarOpenInDataFetchStatus", "_i_IsSidebarOpenInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsInvoiceApproval", "i_IsInvoiceApprovalIn", "i_IsInvoiceApproval", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsInvoiceApprovalInDataFetchStatus", "_i_IsInvoiceApprovalInDataFetchStatus", "_i_IsInvoiceApprovalInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioApprovalLevelsByAssignedTo", "getFolioApprovalLevelsByAssignedToAggr", "GetFolioApprovalLevelsByAssignedTo", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalLevelsByAssignedToAggrRec());
}, true, GetFolioApprovalLevelsByAssignedToAggrRec), 
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
Checkbox_IsSelectAll: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelected: OS$Model.ValidationWidgetRecord,
Form: OS$Model.ValidationWidgetRecord,
TextArea_l_Motive: OS$Model.ValidationWidgetRecord
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
if("i_IsSidebarOpen" in inputs) {
this.variables.i_IsSidebarOpenIn = inputs.i_IsSidebarOpen;
if("_i_IsSidebarOpenInDataFetchStatus" in inputs) {
this.variables._i_IsSidebarOpenInDataFetchStatus = inputs._i_IsSidebarOpenInDataFetchStatus;
}

}

if("i_IsInvoiceApproval" in inputs) {
this.variables.i_IsInvoiceApprovalIn = inputs.i_IsInvoiceApproval;
if("_i_IsInvoiceApprovalInDataFetchStatus" in inputs) {
this.variables._i_IsInvoiceApprovalInDataFetchStatus = inputs._i_IsInvoiceApprovalInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


