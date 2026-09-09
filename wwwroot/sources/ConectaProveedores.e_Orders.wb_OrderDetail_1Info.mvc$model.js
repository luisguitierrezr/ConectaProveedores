import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_7001c2850e85d9dc361469a649a88466, ST_662e235c01358293d93e19bedad72008Structure, ST_9b020d447acc32d28b5e58ce81130d00Structure } from "./ConectaProveedores.model.js";

class GetOrderByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_7001c2850e85d9dc361469a649a88466));
}
static fromStructure(str) {
return new GetOrderByIdAggrRec(new GetOrderByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderByIdAggrRec.init();


class GetOrderMainItemsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_662e235c01358293d93e19bedad72008Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_662e235c01358293d93e19bedad72008Structure))), 
this.attr("Count", "countOut", "Count", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetOrderMainItemsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("TempValues", "tempValuesVar", "TempValues", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_9b020d447acc32d28b5e58ce81130d00Structure());
}, false, ST_9b020d447acc32d28b5e58ce81130d00Structure), 
this.attr("OrderId", "orderIdIn", "OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderIdInDataFetchStatus", "_orderIdInDataFetchStatus", "_orderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderById", "getOrderByIdAggr", "GetOrderById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderByIdAggrRec());
}, true, GetOrderByIdAggrRec), 
this.attr("GetOrderMainItems", "getOrderMainItemsDataAct", "GetOrderMainItems", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainItemsDataActRec());
}, true, GetOrderMainItemsDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_DocumentNumber: OS$Model.ValidationWidgetRecord,
Input_ContractNumber: OS$Model.ValidationWidgetRecord,
Input_OrderRequest: OS$Model.ValidationWidgetRecord,
Input_PurchasingGroup: OS$Model.ValidationWidgetRecord,
Input_Distribution: OS$Model.ValidationWidgetRecord,
Input_Company: OS$Model.ValidationWidgetRecord,
Input_PurchasingGroup2: OS$Model.ValidationWidgetRecord,
Input_Region: OS$Model.ValidationWidgetRecord,
Input_Society: OS$Model.ValidationWidgetRecord,
Input_TotalAmount: OS$Model.ValidationWidgetRecord,
Dropdown1: OS$Model.ValidationWidgetRecord,
Input_TotalAmount2: OS$Model.ValidationWidgetRecord,
Input_IVA2: OS$Model.ValidationWidgetRecord
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
if("OrderId" in inputs) {
this.variables.orderIdIn = inputs.OrderId;
if("_orderIdInDataFetchStatus" in inputs) {
this.variables._orderIdInDataFetchStatus = inputs._orderIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


