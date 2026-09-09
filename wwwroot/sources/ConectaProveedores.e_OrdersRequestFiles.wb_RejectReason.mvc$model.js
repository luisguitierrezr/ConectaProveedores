import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_45b72d53609a7a1da4a98878c5ec7590 } from "./ConectaProveedores.model.js";

class GetOrderRequestFileCommentsByOrderRequestFileIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_45b72d53609a7a1da4a98878c5ec7590));
}
static fromStructure(str) {
return new GetOrderRequestFileCommentsByOrderRequestFileIdAggrRec(new GetOrderRequestFileCommentsByOrderRequestFileIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderRequestFileCommentsByOrderRequestFileIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OrderRequestFilesId", "orderRequestFilesIdIn", "OrderRequestFilesId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderRequestFilesIdInDataFetchStatus", "_orderRequestFilesIdInDataFetchStatus", "_orderRequestFilesIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderRequestFileCommentsByOrderRequestFileId", "getOrderRequestFileCommentsByOrderRequestFileIdAggr", "GetOrderRequestFileCommentsByOrderRequestFileId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderRequestFileCommentsByOrderRequestFileIdAggrRec());
}, true, GetOrderRequestFileCommentsByOrderRequestFileIdAggrRec)
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("OrderRequestFilesId" in inputs) {
this.variables.orderRequestFilesIdIn = inputs.OrderRequestFilesId;
if("_orderRequestFilesIdInDataFetchStatus" in inputs) {
this.variables._orderRequestFilesIdInDataFetchStatus = inputs._orderRequestFilesIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


