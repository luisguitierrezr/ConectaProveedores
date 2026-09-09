import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_c81aee5ce0504fe68694be6deb703b5e } from "./ConectaProveedores.model.js";
import { EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord } from "./Organization.model.js";

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

class GetSupplierByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, {
name: "Supplier",
attrName: "supplierAttr",
nameForJson: "Supplier",
uniqueId: "4934ec74-dc6a-8063-7b84-c0985f5b12ce"
}))));
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
this.attr("l_SupplierSearchText", "l_SupplierSearchTextVar", "l_SupplierSearchText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_SupplierMaxRecord", "l_SupplierMaxRecordVar", "l_SupplierMaxRecord", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 20;
}, false), 
this.attr("l_IsValid", "l_IsValidVar", "l_IsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("i_IsDisable", "i_IsDisableIn", "i_IsDisable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsDisableInDataFetchStatus", "_i_IsDisableInDataFetchStatus", "_i_IsDisableInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_SupplierId", "i_SupplierIdIn", "i_SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_RequisitionDetailRegionId", "i_RequisitionDetailRegionIdIn", "i_RequisitionDetailRegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionDetailRegionIdInDataFetchStatus", "_i_RequisitionDetailRegionIdInDataFetchStatus", "_i_RequisitionDetailRegionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsValid", "i_IsValidIn", "i_IsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsValidInDataFetchStatus", "_i_IsValidInDataFetchStatus", "_i_IsValidInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsMandatory", "i_IsMandatoryIn", "i_IsMandatory", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsFilter", "i_IsFilterIn", "i_IsFilter", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsFilterInDataFetchStatus", "_i_IsFilterInDataFetchStatus", "_i_IsFilterInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSuppliers", "getSuppliersAggr", "GetSuppliers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSuppliersAggrRec());
}, true, GetSuppliersAggrRec), 
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
Input_SupplierSearchText: OS$Model.ValidationWidgetRecord
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
if("i_IsDisable" in inputs) {
this.variables.i_IsDisableIn = inputs.i_IsDisable;
if("_i_IsDisableInDataFetchStatus" in inputs) {
this.variables._i_IsDisableInDataFetchStatus = inputs._i_IsDisableInDataFetchStatus;
}

}

if("i_SupplierId" in inputs) {
this.variables.i_SupplierIdIn = inputs.i_SupplierId;
if("_i_SupplierIdInDataFetchStatus" in inputs) {
this.variables._i_SupplierIdInDataFetchStatus = inputs._i_SupplierIdInDataFetchStatus;
}

}

if("i_RequisitionDetailRegionId" in inputs) {
this.variables.i_RequisitionDetailRegionIdIn = inputs.i_RequisitionDetailRegionId;
if("_i_RequisitionDetailRegionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionDetailRegionIdInDataFetchStatus = inputs._i_RequisitionDetailRegionIdInDataFetchStatus;
}

}

if("i_IsValid" in inputs) {
this.variables.i_IsValidIn = inputs.i_IsValid;
if("_i_IsValidInDataFetchStatus" in inputs) {
this.variables._i_IsValidInDataFetchStatus = inputs._i_IsValidInDataFetchStatus;
}

}

if("i_IsMandatory" in inputs) {
this.variables.i_IsMandatoryIn = inputs.i_IsMandatory;
if("_i_IsMandatoryInDataFetchStatus" in inputs) {
this.variables._i_IsMandatoryInDataFetchStatus = inputs._i_IsMandatoryInDataFetchStatus;
}

}

if("i_IsFilter" in inputs) {
this.variables.i_IsFilterIn = inputs.i_IsFilter;
if("_i_IsFilterInDataFetchStatus" in inputs) {
this.variables._i_IsFilterInDataFetchStatus = inputs._i_IsFilterInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


