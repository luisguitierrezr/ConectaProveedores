import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord, EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_7837994e68174a4794f15e4233b48555Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";

class GetInvoiceFilesByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord, {
name: "InvoiceFile",
attrName: "invoiceFileAttr",
nameForJson: "InvoiceFile",
uniqueId: "18990af8-6f71-69e9-2b71-2b468e13b947"
}))));
}
static fromStructure(str) {
return new GetInvoiceFilesByInvoiceIdAggrRec(new GetInvoiceFilesByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceFilesByInvoiceIdAggrRec.init();

class GetInvoiceExtendedForeignerByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord, {
name: "InvoiceExtendedForeigner",
attrName: "invoiceExtendedForeignerAttr",
nameForJson: "InvoiceExtendedForeigner",
uniqueId: "decbed55-750b-b403-0b04-e46c0306e56b"
}))));
}
static fromStructure(str) {
return new GetInvoiceExtendedForeignerByIdAggrRec(new GetInvoiceExtendedForeignerByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedForeignerByIdAggrRec.init();


class GetInvoicesByRequisitionOrFolioDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("InvoicesList", "invoicesListOut", "InvoicesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_d1d0320db36efbb094ad0082361435a0EntityRecord))());
}, true, (OS$GenericTypeCache.getGenericList(EN_d1d0320db36efbb094ad0082361435a0EntityRecord))), 
this.attr("InvoicesSum", "invoicesSumOut", "InvoicesSum", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetInvoicesByRequisitionOrFolioDataActRec.init();

class GetSupplierDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ExpedicionFiscal", "expedicionFiscalOut", "ExpedicionFiscal", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsNational", "isNationalOut", "IsNational", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
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
this.attr("ExtraFilesList", "extraFilesListVar", "ExtraFilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))), 
this.attr("HasChanged", "hasChangedVar", "HasChanged", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsLoading", "isLoadingVar", "IsLoading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("IsSaving", "isSavingVar", "IsSaving", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsShowForeignInvoice", "isShowForeignInvoiceVar", "IsShowForeignInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("InvoiceForeign", "invoiceForeignVar", "InvoiceForeign", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6f620840109ac6f721328b723ec0152cStructure());
}, false, ST_6f620840109ac6f721328b723ec0152cStructure), 
this.attr("InvoiceId", "invoiceIdIn", "InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InvoiceStatusId", "invoiceStatusIdIn", "InvoiceStatusId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_invoiceStatusIdInDataFetchStatus", "_invoiceStatusIdInDataFetchStatus", "_invoiceStatusIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RequisitionId", "requisitionIdIn", "RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("FolioId", "folioIdIn", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ShowOtherEvidences", "i_ShowOtherEvidencesIn", "i_ShowOtherEvidences", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_ShowOtherEvidencesInDataFetchStatus", "_i_ShowOtherEvidencesInDataFetchStatus", "_i_ShowOtherEvidencesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceFilesByInvoiceId", "getInvoiceFilesByInvoiceIdAggr", "GetInvoiceFilesByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceFilesByInvoiceIdAggrRec());
}, true, GetInvoiceFilesByInvoiceIdAggrRec), 
this.attr("GetInvoiceExtendedForeignerById", "getInvoiceExtendedForeignerByIdAggr", "GetInvoiceExtendedForeignerById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedForeignerByIdAggrRec());
}, true, GetInvoiceExtendedForeignerByIdAggrRec), 
this.attr("GetInvoicesByRequisitionOrFolio", "getInvoicesByRequisitionOrFolioDataAct", "GetInvoicesByRequisitionOrFolio", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesByRequisitionOrFolioDataActRec());
}, true, GetInvoicesByRequisitionOrFolioDataActRec), 
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
Input_Name5: OS$Model.ValidationWidgetRecord,
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
if("InvoiceId" in inputs) {
this.variables.invoiceIdIn = inputs.InvoiceId;
if("_invoiceIdInDataFetchStatus" in inputs) {
this.variables._invoiceIdInDataFetchStatus = inputs._invoiceIdInDataFetchStatus;
}

}

if("InvoiceStatusId" in inputs) {
this.variables.invoiceStatusIdIn = inputs.InvoiceStatusId;
if("_invoiceStatusIdInDataFetchStatus" in inputs) {
this.variables._invoiceStatusIdInDataFetchStatus = inputs._invoiceStatusIdInDataFetchStatus;
}

}

if("RequisitionId" in inputs) {
this.variables.requisitionIdIn = inputs.RequisitionId;
if("_requisitionIdInDataFetchStatus" in inputs) {
this.variables._requisitionIdInDataFetchStatus = inputs._requisitionIdInDataFetchStatus;
}

}

if("FolioId" in inputs) {
this.variables.folioIdIn = inputs.FolioId;
if("_folioIdInDataFetchStatus" in inputs) {
this.variables._folioIdInDataFetchStatus = inputs._folioIdInDataFetchStatus;
}

}

if("i_ShowOtherEvidences" in inputs) {
this.variables.i_ShowOtherEvidencesIn = inputs.i_ShowOtherEvidences;
if("_i_ShowOtherEvidencesInDataFetchStatus" in inputs) {
this.variables._i_ShowOtherEvidencesInDataFetchStatus = inputs._i_ShowOtherEvidencesInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


