import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_c81aee5ce0504fe68694be6deb703b5e, RC_b944c231fcedefdc49a0fe2c36d0fb8a } from "./ConectaProveedores.model.js";

class GetSupplierByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c81aee5ce0504fe68694be6deb703b5e));
}
static fromStructure(str) {
return new GetSupplierByIdAggrRec(new GetSupplierByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierByIdAggrRec.init();

class GetOrderByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_b944c231fcedefdc49a0fe2c36d0fb8a));
}
static fromStructure(str) {
return new GetOrderByIdAggrRec(new GetOrderByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderByIdAggrRec.init();

class GetSuppliersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c81aee5ce0504fe68694be6deb703b5e));
}
static fromStructure(str) {
return new GetSuppliersAggrRec(new GetSuppliersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSuppliersAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SupplierId", "supplierIdIn", "SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_supplierIdInDataFetchStatus", "_supplierIdInDataFetchStatus", "_supplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsEnabled", "isEnabledIn", "IsEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isEnabledInDataFetchStatus", "_isEnabledInDataFetchStatus", "_isEnabledInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OrderMainId", "orderMainIdIn", "OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSupplierById", "getSupplierByIdAggr", "GetSupplierById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierByIdAggrRec());
}, true, GetSupplierByIdAggrRec), 
this.attr("GetOrderById", "getOrderByIdAggr", "GetOrderById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderByIdAggrRec());
}, true, GetOrderByIdAggrRec), 
this.attr("GetSuppliers", "getSuppliersAggr", "GetSuppliers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSuppliersAggrRec());
}, true, GetSuppliersAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form1: OS$Model.ValidationWidgetRecord,
Input_SupplierName: OS$Model.ValidationWidgetRecord,
Input_SocialReason: OS$Model.ValidationWidgetRecord,
Input_RFC: OS$Model.ValidationWidgetRecord,
Input_SupplierNumber: OS$Model.ValidationWidgetRecord,
Input_Region: OS$Model.ValidationWidgetRecord,
Input_Group: OS$Model.ValidationWidgetRecord,
Input_LineOfBusiness: OS$Model.ValidationWidgetRecord
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
if("SupplierId" in inputs) {
this.variables.supplierIdIn = inputs.SupplierId;
if("_supplierIdInDataFetchStatus" in inputs) {
this.variables._supplierIdInDataFetchStatus = inputs._supplierIdInDataFetchStatus;
}

}

if("IsEnabled" in inputs) {
this.variables.isEnabledIn = inputs.IsEnabled;
if("_isEnabledInDataFetchStatus" in inputs) {
this.variables._isEnabledInDataFetchStatus = inputs._isEnabledInDataFetchStatus;
}

}

if("OrderMainId" in inputs) {
this.variables.orderMainIdIn = inputs.OrderMainId;
if("_orderMainIdInDataFetchStatus" in inputs) {
this.variables._orderMainIdInDataFetchStatus = inputs._orderMainIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


