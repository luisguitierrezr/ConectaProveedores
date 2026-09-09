import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_2b77a78552d1dad3876c3ebd8f5c8ec1, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";

class GetInvoiceFilesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2b77a78552d1dad3876c3ebd8f5c8ec1));
}
static fromStructure(str) {
return new GetInvoiceFilesAggrRec(new GetInvoiceFilesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceFilesAggrRec.init();

class GetCreditNoteInvoiceFilesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2b77a78552d1dad3876c3ebd8f5c8ec1));
}
static fromStructure(str) {
return new GetCreditNoteInvoiceFilesAggrRec(new GetCreditNoteInvoiceFilesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCreditNoteInvoiceFilesAggrRec.init();


class GetSupplierDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ExpedicionFiscal", "expedicionFiscalOut", "ExpedicionFiscal", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Name", "nameOut", "Name", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("RFC", "rFCOut", "RFC", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Society", "societyOut", "Society", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SupplierNr", "supplierNrOut", "SupplierNr", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsNational", "isNationalOut", "IsNational", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsActiveDEV_TK395", "isActiveDEV_TK395Out", "IsActiveDEV_TK395", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSupplierDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ErrorMsg", "errorMsgVar", "ErrorMsg", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("CreditNoteFilesList", "creditNoteFilesListVar", "CreditNoteFilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("IsOpenPopupForeigner", "isOpenPopupForeignerVar", "IsOpenPopupForeigner", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("InvoiceForeign", "invoiceForeignVar", "InvoiceForeign", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6f620840109ac6f721328b723ec0152cStructure());
}, false, ST_6f620840109ac6f721328b723ec0152cStructure), 
this.attr("IsUploadCreditNote", "isUploadCreditNoteVar", "IsUploadCreditNote", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ToStore_Invoice", "toStore_InvoiceVar", "ToStore_Invoice", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord());
}, false, EN_d1d0320db36efbb094ad0082361435a0EntityRecord), 
this.attr("ToStore_ClaveProdServ", "toStore_ClaveProdServVar", "ToStore_ClaveProdServ", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ToStore_TipoDeComprobante", "toStore_TipoDeComprobanteVar", "ToStore_TipoDeComprobante", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsEnable", "l_IsEnableVar", "l_IsEnable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("OrderMainId", "orderMainIdIn", "OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowTitle", "showTitleIn", "ShowTitle", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showTitleInDataFetchStatus", "_showTitleInDataFetchStatus", "_showTitleInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("FolioId", "folioIdIn", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ImportAnticipo", "importAnticipoIn", "ImportAnticipo", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_importAnticipoInDataFetchStatus", "_importAnticipoInDataFetchStatus", "_importAnticipoInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsEnable", "i_IsEnableIn", "i_IsEnable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsEnableInDataFetchStatus", "_i_IsEnableInDataFetchStatus", "_i_IsEnableInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceFiles", "getInvoiceFilesAggr", "GetInvoiceFiles", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceFilesAggrRec());
}, true, GetInvoiceFilesAggrRec), 
this.attr("GetCreditNoteInvoiceFiles", "getCreditNoteInvoiceFilesAggr", "GetCreditNoteInvoiceFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCreditNoteInvoiceFilesAggrRec());
}, true, GetCreditNoteInvoiceFilesAggrRec), 
this.attr("GetSupplier", "getSupplierDataAct", "GetSupplier", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierDataActRec());
}, true, GetSupplierDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Name: OS$Model.ValidationWidgetRecord,
Input_Name2: OS$Model.ValidationWidgetRecord,
Input_Name3: OS$Model.ValidationWidgetRecord,
Input_Name10: OS$Model.ValidationWidgetRecord,
Input_Name4: OS$Model.ValidationWidgetRecord,
Input_Name9: OS$Model.ValidationWidgetRecord,
Input_InvoiceDate: OS$Model.ValidationWidgetRecord,
Input_Name6: OS$Model.ValidationWidgetRecord,
Input_AmountByServiceType: OS$Model.ValidationWidgetRecord,
Input_Name12: OS$Model.ValidationWidgetRecord
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
if("OrderMainId" in inputs) {
this.variables.orderMainIdIn = inputs.OrderMainId;
if("_orderMainIdInDataFetchStatus" in inputs) {
this.variables._orderMainIdInDataFetchStatus = inputs._orderMainIdInDataFetchStatus;
}

}

if("ShowTitle" in inputs) {
this.variables.showTitleIn = inputs.ShowTitle;
if("_showTitleInDataFetchStatus" in inputs) {
this.variables._showTitleInDataFetchStatus = inputs._showTitleInDataFetchStatus;
}

}

if("FolioId" in inputs) {
this.variables.folioIdIn = inputs.FolioId;
if("_folioIdInDataFetchStatus" in inputs) {
this.variables._folioIdInDataFetchStatus = inputs._folioIdInDataFetchStatus;
}

}

if("ImportAnticipo" in inputs) {
this.variables.importAnticipoIn = inputs.ImportAnticipo;
if("_importAnticipoInDataFetchStatus" in inputs) {
this.variables._importAnticipoInDataFetchStatus = inputs._importAnticipoInDataFetchStatus;
}

}

if("i_IsEnable" in inputs) {
this.variables.i_IsEnableIn = inputs.i_IsEnable;
if("_i_IsEnableInDataFetchStatus" in inputs) {
this.variables._i_IsEnableInDataFetchStatus = inputs._i_IsEnableInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


