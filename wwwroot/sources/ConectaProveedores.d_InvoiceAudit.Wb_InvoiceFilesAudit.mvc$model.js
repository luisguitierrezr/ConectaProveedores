import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_eb0c76f6f640a3fe05b6e66cf112863f } from "./ConectaProveedores.model.js";

class InvoiceFilesByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_eb0c76f6f640a3fe05b6e66cf112863f));
}
static fromStructure(str) {
return new InvoiceFilesByIdAggrRec(new InvoiceFilesByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

InvoiceFilesByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_InvoiceName", "i_InvoiceNameIn", "i_InvoiceName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_InvoiceNameInDataFetchStatus", "_i_InvoiceNameInDataFetchStatus", "_i_InvoiceNameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsSaveAllFiles", "i_IsSaveAllFilesIn", "i_IsSaveAllFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsSaveAllFilesInDataFetchStatus", "_i_IsSaveAllFilesInDataFetchStatus", "_i_IsSaveAllFilesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsSaveSelectedFiles", "i_IsSaveSelectedFilesIn", "i_IsSaveSelectedFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsSaveSelectedFilesInDataFetchStatus", "_i_IsSaveSelectedFilesInDataFetchStatus", "_i_IsSaveSelectedFilesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InvoiceFilesById", "invoiceFilesByIdAggr", "InvoiceFilesById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new InvoiceFilesByIdAggrRec());
}, true, InvoiceFilesByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Checkbox1: OS$Model.ValidationWidgetRecord
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
if("i_InvoiceId" in inputs) {
this.variables.i_InvoiceIdIn = inputs.i_InvoiceId;
if("_i_InvoiceIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceIdInDataFetchStatus = inputs._i_InvoiceIdInDataFetchStatus;
}

}

if("i_InvoiceName" in inputs) {
this.variables.i_InvoiceNameIn = inputs.i_InvoiceName;
if("_i_InvoiceNameInDataFetchStatus" in inputs) {
this.variables._i_InvoiceNameInDataFetchStatus = inputs._i_InvoiceNameInDataFetchStatus;
}

}

if("i_IsSaveAllFiles" in inputs) {
this.variables.i_IsSaveAllFilesIn = inputs.i_IsSaveAllFiles;
if("_i_IsSaveAllFilesInDataFetchStatus" in inputs) {
this.variables._i_IsSaveAllFilesInDataFetchStatus = inputs._i_IsSaveAllFilesInDataFetchStatus;
}

}

if("i_IsSaveSelectedFiles" in inputs) {
this.variables.i_IsSaveSelectedFilesIn = inputs.i_IsSaveSelectedFiles;
if("_i_IsSaveSelectedFilesInDataFetchStatus" in inputs) {
this.variables._i_IsSaveSelectedFilesInDataFetchStatus = inputs._i_IsSaveSelectedFilesInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


