import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_605897e6a4b36a23ebf729de65626af9, RC_0bd21c095360ef78cf6d0f1777ecf52a, ST_34625f5643caa3d12448dcec7dd4c7d3Structure, ST_3c480a6d17a69eed60b057b7ed343a1dStructure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvcModel from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$model.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvcModel from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";

class GetInvoicesApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_605897e6a4b36a23ebf729de65626af9));
}
static fromStructure(str) {
return new GetInvoicesApprovalLevelsAggrRec(new GetInvoicesApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesApprovalLevelsAggrRec.init();

class GetInvoiceByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_0bd21c095360ef78cf6d0f1777ecf52a));
}
static fromStructure(str) {
return new GetInvoiceByIdAggrRec(new GetInvoiceByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceByIdAggrRec.init();


class GetEntraUserManagerListDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserList", "userListOut", "UserList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetEntraUserManagerListDataActRec(new GetEntraUserManagerListDataActRec.RecordClass({
userListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEntraUserManagerListDataActRec.init();

class GetSpecialApprovalLevelsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ApprovalList", "approvalListOut", "ApprovalList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_3c480a6d17a69eed60b057b7ed343a1dStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_3c480a6d17a69eed60b057b7ed343a1dStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSpecialApprovalLevelsDataActRec(new GetSpecialApprovalLevelsDataActRec.RecordClass({
approvalListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSpecialApprovalLevelsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("List", "listVar", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))), 
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_RefreshWB", "i_RefreshWBIn", "i_RefreshWB", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_RefreshWBInDataFetchStatus", "_i_RefreshWBInDataFetchStatus", "_i_RefreshWBInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoicesApprovalLevels", "getInvoicesApprovalLevelsAggr", "GetInvoicesApprovalLevels", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesApprovalLevelsAggrRec());
}, true, GetInvoicesApprovalLevelsAggrRec), 
this.attr("GetInvoiceById", "getInvoiceByIdAggr", "GetInvoiceById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceByIdAggrRec());
}, true, GetInvoiceByIdAggrRec), 
this.attr("GetEntraUserManagerList", "getEntraUserManagerListDataAct", "GetEntraUserManagerList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntraUserManagerListDataActRec());
}, true, GetEntraUserManagerListDataActRec), 
this.attr("GetSpecialApprovalLevels", "getSpecialApprovalLevelsDataAct", "GetSpecialApprovalLevels", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSpecialApprovalLevelsDataActRec());
}, true, GetSpecialApprovalLevelsDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = ((((OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvcModel.hasValidationWidgets || OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_InvoiceId" in inputs) {
this.variables.i_InvoiceIdIn = inputs.i_InvoiceId;
if("_i_InvoiceIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceIdInDataFetchStatus = inputs._i_InvoiceIdInDataFetchStatus;
}

}

if("i_RefreshWB" in inputs) {
this.variables.i_RefreshWBIn = inputs.i_RefreshWB;
if("_i_RefreshWBInDataFetchStatus" in inputs) {
this.variables._i_RefreshWBInDataFetchStatus = inputs._i_RefreshWBInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


