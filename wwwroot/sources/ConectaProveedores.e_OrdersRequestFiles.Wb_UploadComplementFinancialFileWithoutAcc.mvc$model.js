import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_ea3a117956fd50e1901759909d3fbc2f, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_mvcModel from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadWithoutAcc.mvc$model.js";

class GetOrderAccConceptByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_ea3a117956fd50e1901759909d3fbc2f));
}
static fromStructure(str) {
return new GetOrderAccConceptByIdAggrRec(new GetOrderAccConceptByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderAccConceptByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("FilesListExtra", "filesListExtraVar", "FilesListExtra", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("InvoiceForeign", "invoiceForeignVar", "InvoiceForeign", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6f620840109ac6f721328b723ec0152cStructure());
}, false, ST_6f620840109ac6f721328b723ec0152cStructure), 
this.attr("Invoice", "invoiceVar", "Invoice", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord());
}, false, EN_d1d0320db36efbb094ad0082361435a0EntityRecord), 
this.attr("AreFilesUploaded", "areFilesUploadedVar", "AreFilesUploaded", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ClaveProdServ", "claveProdServVar", "ClaveProdServ", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("TipoDeComprobante", "tipoDeComprobanteVar", "TipoDeComprobante", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("OrderMainId", "orderMainIdIn", "OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OrderAccConceptsId", "orderAccConceptsIdIn", "OrderAccConceptsId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderAccConceptsIdInDataFetchStatus", "_orderAccConceptsIdInDataFetchStatus", "_orderAccConceptsIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AccountingDataTypeId", "accountingDataTypeIdIn", "AccountingDataTypeId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_accountingDataTypeIdInDataFetchStatus", "_accountingDataTypeIdInDataFetchStatus", "_accountingDataTypeIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_OrderRequestFileId", "i_OrderRequestFileIdIn", "i_OrderRequestFileId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderRequestFileIdInDataFetchStatus", "_i_OrderRequestFileIdInDataFetchStatus", "_i_OrderRequestFileIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderAccConceptById", "getOrderAccConceptByIdAggr", "GetOrderAccConceptById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderAccConceptByIdAggrRec());
}, true, GetOrderAccConceptByIdAggrRec)
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
Model._hasValidationWidgetsValue = ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("OrderMainId" in inputs) {
this.variables.orderMainIdIn = inputs.OrderMainId;
if("_orderMainIdInDataFetchStatus" in inputs) {
this.variables._orderMainIdInDataFetchStatus = inputs._orderMainIdInDataFetchStatus;
}

}

if("OrderAccConceptsId" in inputs) {
this.variables.orderAccConceptsIdIn = inputs.OrderAccConceptsId;
if("_orderAccConceptsIdInDataFetchStatus" in inputs) {
this.variables._orderAccConceptsIdInDataFetchStatus = inputs._orderAccConceptsIdInDataFetchStatus;
}

}

if("AccountingDataTypeId" in inputs) {
this.variables.accountingDataTypeIdIn = inputs.AccountingDataTypeId;
if("_accountingDataTypeIdInDataFetchStatus" in inputs) {
this.variables._accountingDataTypeIdInDataFetchStatus = inputs._accountingDataTypeIdInDataFetchStatus;
}

}

if("i_OrderRequestFileId" in inputs) {
this.variables.i_OrderRequestFileIdIn = inputs.i_OrderRequestFileId;
if("_i_OrderRequestFileIdInDataFetchStatus" in inputs) {
this.variables._i_OrderRequestFileIdInDataFetchStatus = inputs._i_OrderRequestFileIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


