import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvcModel from "./ConectaProveedores.e_Orders.Wb_DocumentsToRequest.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SupplierId", "supplierIdIn", "SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_supplierIdInDataFetchStatus", "_supplierIdInDataFetchStatus", "_supplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("l_CanEditUserArea", "l_CanEditUserAreaIn", "l_CanEditUserArea", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_l_CanEditUserAreaInDataFetchStatus", "_l_CanEditUserAreaInDataFetchStatus", "_l_CanEditUserAreaInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
}, false)
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
Model._hasValidationWidgetsValue = ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

if("SupplierId" in inputs) {
this.variables.supplierIdIn = inputs.SupplierId;
if("_supplierIdInDataFetchStatus" in inputs) {
this.variables._supplierIdInDataFetchStatus = inputs._supplierIdInDataFetchStatus;
}

}

if("l_CanEditUserArea" in inputs) {
this.variables.l_CanEditUserAreaIn = inputs.l_CanEditUserArea;
if("_l_CanEditUserAreaInDataFetchStatus" in inputs) {
this.variables._l_CanEditUserAreaInDataFetchStatus = inputs._l_CanEditUserAreaInDataFetchStatus;
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


