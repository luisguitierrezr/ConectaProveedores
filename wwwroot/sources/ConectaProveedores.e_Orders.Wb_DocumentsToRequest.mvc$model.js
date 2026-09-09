import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_360367a38fba8439556dd1e5826e0428EntityRecord } from "./Organization.model.js";
import { EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord } from "./ConectaProveedores.model.js";

class GetSupplierUsersBySupplierIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_360367a38fba8439556dd1e5826e0428EntityRecord, {
name: "SupplierUser",
attrName: "supplierUserAttr",
nameForJson: "SupplierUser",
uniqueId: "33e6e9ec-201f-65e0-eb7b-d5d251178def"
}))));
}
static fromStructure(str) {
return new GetSupplierUsersBySupplierIdAggrRec(new GetSupplierUsersBySupplierIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierUsersBySupplierIdAggrRec.init();


class GetOrderRequestFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("RequestFiles", "requestFilesOut", "RequestFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord))());
}, true, (OS$GenericTypeCache.getGenericList(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetOrderRequestFilesDataActRec(new GetOrderRequestFilesDataActRec.RecordClass({
requestFilesOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderRequestFilesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_HasError", "l_HasErrorVar", "l_HasError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsValidList", "l_IsValidListVar", "l_IsValidList", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsBusy", "l_IsBusyVar", "l_IsBusy", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_SupplierId", "i_SupplierIdIn", "i_SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_CanEditUserArea", "i_CanEditUserAreaIn", "i_CanEditUserArea", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_CanEditUserAreaInDataFetchStatus", "_i_CanEditUserAreaInDataFetchStatus", "_i_CanEditUserAreaInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_HasError", "i_HasErrorIn", "i_HasError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_HasErrorInDataFetchStatus", "_i_HasErrorInDataFetchStatus", "_i_HasErrorInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_HasntRequestDocuments", "i_HasntRequestDocumentsIn", "i_HasntRequestDocuments", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_HasntRequestDocumentsInDataFetchStatus", "_i_HasntRequestDocumentsInDataFetchStatus", "_i_HasntRequestDocumentsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSupplierUsersBySupplierId", "getSupplierUsersBySupplierIdAggr", "GetSupplierUsersBySupplierId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierUsersBySupplierIdAggrRec());
}, true, GetSupplierUsersBySupplierIdAggrRec), 
this.attr("GetOrderRequestFiles", "getOrderRequestFilesDataAct", "GetOrderRequestFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderRequestFilesDataActRec());
}, true, GetOrderRequestFilesDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
SwitchHasRequestDocuments: OS$Model.ValidationWidgetRecord,
Input_Current2: OS$Model.ValidationWidgetRecord
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
if("i_SupplierId" in inputs) {
this.variables.i_SupplierIdIn = inputs.i_SupplierId;
if("_i_SupplierIdInDataFetchStatus" in inputs) {
this.variables._i_SupplierIdInDataFetchStatus = inputs._i_SupplierIdInDataFetchStatus;
}

}

if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

if("i_CanEditUserArea" in inputs) {
this.variables.i_CanEditUserAreaIn = inputs.i_CanEditUserArea;
if("_i_CanEditUserAreaInDataFetchStatus" in inputs) {
this.variables._i_CanEditUserAreaInDataFetchStatus = inputs._i_CanEditUserAreaInDataFetchStatus;
}

}

if("i_HasError" in inputs) {
this.variables.i_HasErrorIn = inputs.i_HasError;
if("_i_HasErrorInDataFetchStatus" in inputs) {
this.variables._i_HasErrorInDataFetchStatus = inputs._i_HasErrorInDataFetchStatus;
}

}

if("i_HasntRequestDocuments" in inputs) {
this.variables.i_HasntRequestDocumentsIn = inputs.i_HasntRequestDocuments;
if("_i_HasntRequestDocumentsInDataFetchStatus" in inputs) {
this.variables._i_HasntRequestDocumentsInDataFetchStatus = inputs._i_HasntRequestDocumentsInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


