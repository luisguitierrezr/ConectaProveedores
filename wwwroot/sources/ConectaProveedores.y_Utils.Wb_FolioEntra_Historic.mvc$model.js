import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord, RC_12d88e24134057c9d8b3dfc84a66166f, ST_34625f5643caa3d12448dcec7dd4c7d3Structure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvcModel from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$model.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvcModel from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";

class GetOrderMainByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord, {
name: "OrderMain",
attrName: "orderMainAttr",
nameForJson: "OrderMain",
uniqueId: "1583d548-420c-231f-fb93-458312800446"
}))));
}
static fromStructure(str) {
return new GetOrderMainByIdAggrRec(new GetOrderMainByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainByIdAggrRec.init();

class GetOrderMainApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_12d88e24134057c9d8b3dfc84a66166f));
}
static fromStructure(str) {
return new GetOrderMainApprovalLevelsAggrRec(new GetOrderMainApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainApprovalLevelsAggrRec.init();


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


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("List", "listVar", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))), 
this.attr("i_OrderMainId", "i_OrderMainIdIn", "i_OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderMainIdInDataFetchStatus", "_i_OrderMainIdInDataFetchStatus", "_i_OrderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_RefreshWB", "i_RefreshWBIn", "i_RefreshWB", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_RefreshWBInDataFetchStatus", "_i_RefreshWBInDataFetchStatus", "_i_RefreshWBInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderMainById", "getOrderMainByIdAggr", "GetOrderMainById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainByIdAggrRec());
}, true, GetOrderMainByIdAggrRec), 
this.attr("GetOrderMainApprovalLevels", "getOrderMainApprovalLevelsAggr", "GetOrderMainApprovalLevels", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainApprovalLevelsAggrRec());
}, true, GetOrderMainApprovalLevelsAggrRec), 
this.attr("GetEntraUserManagerList", "getEntraUserManagerListDataAct", "GetEntraUserManagerList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntraUserManagerListDataActRec());
}, true, GetEntraUserManagerListDataActRec)
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
Model._hasValidationWidgetsValue = ((((OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvcModel.hasValidationWidgets || OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_OrderMainId" in inputs) {
this.variables.i_OrderMainIdIn = inputs.i_OrderMainId;
if("_i_OrderMainIdInDataFetchStatus" in inputs) {
this.variables._i_OrderMainIdInDataFetchStatus = inputs._i_OrderMainIdInDataFetchStatus;
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


