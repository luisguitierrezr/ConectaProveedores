import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_cf58ea0f756ca06745169deb0b41c0eb } from "./ConectaProveedores.model.js";
import OutSystemsUI_Navigation_Pagination_mvcModel from "./OutSystemsUI.Navigation.Pagination.mvc$model.js";

class GetOrderItemEntriesByOrderMainItemidAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_cf58ea0f756ca06745169deb0b41c0eb));
}
static fromStructure(str) {
return new GetOrderItemEntriesByOrderMainItemidAggrRec(new GetOrderItemEntriesByOrderMainItemidAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderItemEntriesByOrderMainItemidAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 4;
}, false), 
this.attr("OrderMainItemId", "orderMainItemIdIn", "OrderMainItemId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainItemIdInDataFetchStatus", "_orderMainItemIdInDataFetchStatus", "_orderMainItemIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderItemEntriesByOrderMainItemid", "getOrderItemEntriesByOrderMainItemidAggr", "GetOrderItemEntriesByOrderMainItemid", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderItemEntriesByOrderMainItemidAggrRec());
}, true, GetOrderItemEntriesByOrderMainItemidAggrRec)
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
Model._hasValidationWidgetsValue = OutSystemsUI_Navigation_Pagination_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("OrderMainItemId" in inputs) {
this.variables.orderMainItemIdIn = inputs.OrderMainItemId;
if("_orderMainItemIdInDataFetchStatus" in inputs) {
this.variables._orderMainItemIdInDataFetchStatus = inputs._orderMainItemIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


