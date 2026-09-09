import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_6783422774b4547f1160d86529102520, RC_da31ba4ed131103eb5a5b5464cca7643, RC_9f414d82ade67cb4131fecd8fda64580, RC_18c2d75e8e190384e64859e7ed1d4f00 } from "./ConectaProveedores.model.js";
import { ST_7d99a0be08bc4d3199f250548e6c4016Structure } from "./IS_EntraIDGraphConnector.model.js";

class GetSourceUserByEntraIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_6783422774b4547f1160d86529102520));
}
static fromStructure(str) {
return new GetSourceUserByEntraIdAggrRec(new GetSourceUserByEntraIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSourceUserByEntraIdAggrRec.init();


class GetSourceUserContentDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ReqList", "reqListOut", "ReqList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_da31ba4ed131103eb5a5b5464cca7643))());
}, true, (OS$GenericTypeCache.getGenericList(RC_da31ba4ed131103eb5a5b5464cca7643))), 
this.attr("InvList", "invListOut", "InvList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_9f414d82ade67cb4131fecd8fda64580))());
}, true, (OS$GenericTypeCache.getGenericList(RC_9f414d82ade67cb4131fecd8fda64580)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSourceUserContentDataActRec.init();

class GetUsersTargetDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_UserTargetListAU", "o_UserTargetListAUOut", "o_UserTargetListAU", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_18c2d75e8e190384e64859e7ed1d4f00))());
}, true, (OS$GenericTypeCache.getGenericList(RC_18c2d75e8e190384e64859e7ed1d4f00)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetUsersTargetDataActRec(new GetUsersTargetDataActRec.RecordClass({
o_UserTargetListAUOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUsersTargetDataActRec.init();

class GetUsersSourceDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_DirectReportsList", "o_DirectReportsListOut", "o_DirectReportsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_7d99a0be08bc4d3199f250548e6c4016Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_7d99a0be08bc4d3199f250548e6c4016Structure))), 
this.attr("o_HasError", "o_HasErrorOut", "o_HasError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUsersSourceDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Search", "searchVar", "Search", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsAllowConfirm", "l_IsAllowConfirmVar", "l_IsAllowConfirm", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_SourceUserEntraId", "l_SourceUserEntraIdVar", "l_SourceUserEntraId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_SourceUserId", "l_SourceUserIdVar", "l_SourceUserId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_TargetUserAUEntraId", "l_TargetUserAUEntraIdVar", "l_TargetUserAUEntraId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_Reason", "l_ReasonVar", "l_Reason", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_IsSidebarOpen", "i_IsSidebarOpenIn", "i_IsSidebarOpen", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsSidebarOpenInDataFetchStatus", "_i_IsSidebarOpenInDataFetchStatus", "_i_IsSidebarOpenInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSourceUserByEntraId", "getSourceUserByEntraIdAggr", "GetSourceUserByEntraId", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSourceUserByEntraIdAggrRec());
}, true, GetSourceUserByEntraIdAggrRec), 
this.attr("GetSourceUserContent", "getSourceUserContentDataAct", "GetSourceUserContent", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSourceUserContentDataActRec());
}, true, GetSourceUserContentDataActRec), 
this.attr("GetUsersTarget", "getUsersTargetDataAct", "GetUsersTarget", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUsersTargetDataActRec());
}, true, GetUsersTargetDataActRec), 
this.attr("GetUsersSource", "getUsersSourceDataAct", "GetUsersSource", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUsersSourceDataActRec());
}, true, GetUsersSourceDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelected: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelected2: OS$Model.ValidationWidgetRecord,
TextArea_l_Reason: OS$Model.ValidationWidgetRecord
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

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


