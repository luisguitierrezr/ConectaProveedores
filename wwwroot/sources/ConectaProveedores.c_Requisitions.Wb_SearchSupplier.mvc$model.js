import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_4b3e229d9fe6ec886da8c5cf0d4be972, RC_c81aee5ce0504fe68694be6deb703b5e } from "./ConectaProveedores.model.js";

class GetRequisitionByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_4b3e229d9fe6ec886da8c5cf0d4be972));
}
static fromStructure(str) {
return new GetRequisitionByIdAggrRec(new GetRequisitionByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionByIdAggrRec.init();

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
this.attr("RequisitionId", "requisitionIdIn", "RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetRequisitionById", "getRequisitionByIdAggr", "GetRequisitionById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionByIdAggrRec());
}, true, GetRequisitionByIdAggrRec), 
this.attr("GetSupplierById", "getSupplierByIdAggr", "GetSupplierById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierByIdAggrRec());
}, true, GetSupplierByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
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

if("RequisitionId" in inputs) {
this.variables.requisitionIdIn = inputs.RequisitionId;
if("_requisitionIdInDataFetchStatus" in inputs) {
this.variables._requisitionIdInDataFetchStatus = inputs._requisitionIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


