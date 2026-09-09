import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_ab3c433102000c44a55e713fb2ce955d } from "./ConectaProveedores.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvcModel from "./OutSystemsUI.Interaction.DropdownSearch.mvc$model.js";

class GetOrderAccountingsByOrderIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_ab3c433102000c44a55e713fb2ce955d));
}
static fromStructure(str) {
return new GetOrderAccountingsByOrderIdAggrRec(new GetOrderAccountingsByOrderIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderAccountingsByOrderIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OrderMainID", "orderMainIDIn", "OrderMainID", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainIDInDataFetchStatus", "_orderMainIDInDataFetchStatus", "_orderMainIDInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsFromFolio", "isFromFolioIn", "IsFromFolio", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isFromFolioInDataFetchStatus", "_isFromFolioInDataFetchStatus", "_isFromFolioInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsEnable", "isEnableIn", "IsEnable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isEnableInDataFetchStatus", "_isEnableInDataFetchStatus", "_isEnableInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderAccountingsByOrderId", "getOrderAccountingsByOrderIdAggr", "GetOrderAccountingsByOrderId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderAccountingsByOrderIdAggrRec());
}, true, GetOrderAccountingsByOrderIdAggrRec)
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
Model._hasValidationWidgetsValue = OutSystemsUI_Interaction_DropdownSearch_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("OrderMainID" in inputs) {
this.variables.orderMainIDIn = inputs.OrderMainID;
if("_orderMainIDInDataFetchStatus" in inputs) {
this.variables._orderMainIDInDataFetchStatus = inputs._orderMainIDInDataFetchStatus;
}

}

if("IsFromFolio" in inputs) {
this.variables.isFromFolioIn = inputs.IsFromFolio;
if("_isFromFolioInDataFetchStatus" in inputs) {
this.variables._isFromFolioInDataFetchStatus = inputs._isFromFolioInDataFetchStatus;
}

}

if("IsEnable" in inputs) {
this.variables.isEnableIn = inputs.IsEnable;
if("_isEnableInDataFetchStatus" in inputs) {
this.variables._isEnableInDataFetchStatus = inputs._isEnableInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


