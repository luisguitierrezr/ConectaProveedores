import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache, DataConversion } from "@outsystems/runtime-core-js";
import { ST_f54c1d1bac41c2667837ac97bb484830Structure, RC_b6257dfb536e679f8b7be7b4b56f189b, ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure, ST_2667ad63792f2349dc9e4a818559d9ecStructure } from "./ConectaProveedores.model.js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvcModel from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$model.js";
import UltimatePDF_PrintLayout_PrintLayout_mvcModel from "./UltimatePDF.PrintLayout.PrintLayout.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_ValidationReport_mvcModel from "./ConectaProveedores.y_Utils.Wb_ValidationReport.mvc$model.js";


class GetMainDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ValidationReport", "validationReportOut", "ValidationReport", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_f54c1d1bac41c2667837ac97bb484830Structure());
}, true, ST_f54c1d1bac41c2667837ac97bb484830Structure), 
this.attr("InvoiceExtended", "invoiceExtendedOut", "InvoiceExtended", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_b6257dfb536e679f8b7be7b4b56f189b());
}, true, RC_b6257dfb536e679f8b7be7b4b56f189b), 
this.attr("FolioId", "folioIdOut", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("IsFromRequisition", "isFromRequisitionOut", "IsFromRequisition", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetMainDataDataActRec.init();

class GetTableItemsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("TableLine", "tableLineOut", "TableLine", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetTableItemsDataActRec(new GetTableItemsDataActRec.RecordClass({
tableLineOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetTableItemsDataActRec.init();

class GetInvoiceFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("FilesString", "filesStringOut", "FilesString", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetInvoiceFilesDataActRec(new GetInvoiceFilesDataActRec.RecordClass({
filesStringOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceFilesDataActRec.init();

class GetEletronicAuthorizationsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ValidationReportAuthorizationList", "validationReportAuthorizationListOut", "ValidationReportAuthorizationList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_2667ad63792f2349dc9e4a818559d9ecStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_2667ad63792f2349dc9e4a818559d9ecStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetEletronicAuthorizationsDataActRec(new GetEletronicAuthorizationsDataActRec.RecordClass({
validationReportAuthorizationListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEletronicAuthorizationsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Offset", "offsetVar", "Offset", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("InvoiceId", "invoiceIdIn", "InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetMainData", "getMainDataDataAct", "GetMainData", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetMainDataDataActRec());
}, true, GetMainDataDataActRec), 
this.attr("GetTableItems", "getTableItemsDataAct", "GetTableItems", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetTableItemsDataActRec());
}, true, GetTableItemsDataActRec), 
this.attr("GetInvoiceFiles", "getInvoiceFilesDataAct", "GetInvoiceFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceFilesDataActRec());
}, true, GetInvoiceFilesDataActRec), 
this.attr("GetEletronicAuthorizations", "getEletronicAuthorizationsDataAct", "GetEletronicAuthorizations", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEletronicAuthorizationsDataActRec());
}, true, GetEletronicAuthorizationsDataActRec)
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
Model._hasValidationWidgetsValue = ((UltimatePDF_PrintLayout_ScreenToPDF_mvcModel.hasValidationWidgets || UltimatePDF_PrintLayout_PrintLayout_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_ValidationReport_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("InvoiceId" in inputs) {
this.variables.invoiceIdIn = DataConversion.ServerDataConverter.from(inputs.InvoiceId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


