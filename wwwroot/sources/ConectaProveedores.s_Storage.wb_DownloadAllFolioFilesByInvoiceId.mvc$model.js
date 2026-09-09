import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_d0f36b0aa01c99a6864922a3e47b0bc5, RC_db98be0f77f582e2a41dd64bb6a4005e, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure } from "./ConectaProveedores.model.js";

class GetInvoicesByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d0f36b0aa01c99a6864922a3e47b0bc5));
}
static fromStructure(str) {
return new GetInvoicesByFolioIdAggrRec(new GetInvoicesByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesByFolioIdAggrRec.init();

class GetFolioFilesByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_db98be0f77f582e2a41dd64bb6a4005e));
}
static fromStructure(str) {
return new GetFolioFilesByFolioIdAggrRec(new GetFolioFilesByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioFilesByFolioIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FileJsonList", "fileJsonListVar", "FileJsonList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_6c0a0d3b1d72414f90bb9301bad200fbStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_6c0a0d3b1d72414f90bb9301bad200fbStructure))), 
this.attr("InvoiceId", "invoiceIdIn", "InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ZipName", "zipNameIn", "ZipName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_zipNameInDataFetchStatus", "_zipNameInDataFetchStatus", "_zipNameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ButtonName", "buttonNameIn", "ButtonName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_buttonNameInDataFetchStatus", "_buttonNameInDataFetchStatus", "_buttonNameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoicesByFolioId", "getInvoicesByFolioIdAggr", "GetInvoicesByFolioId", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesByFolioIdAggrRec());
}, true, GetInvoicesByFolioIdAggrRec), 
this.attr("GetFolioFilesByFolioId", "getFolioFilesByFolioIdAggr", "GetFolioFilesByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioFilesByFolioIdAggrRec());
}, true, GetFolioFilesByFolioIdAggrRec)
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
if("InvoiceId" in inputs) {
this.variables.invoiceIdIn = inputs.InvoiceId;
if("_invoiceIdInDataFetchStatus" in inputs) {
this.variables._invoiceIdInDataFetchStatus = inputs._invoiceIdInDataFetchStatus;
}

}

if("ZipName" in inputs) {
this.variables.zipNameIn = inputs.ZipName;
if("_zipNameInDataFetchStatus" in inputs) {
this.variables._zipNameInDataFetchStatus = inputs._zipNameInDataFetchStatus;
}

}

if("ButtonName" in inputs) {
this.variables.buttonNameIn = inputs.ButtonName;
if("_buttonNameInDataFetchStatus" in inputs) {
this.variables._buttonNameInDataFetchStatus = inputs._buttonNameInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


