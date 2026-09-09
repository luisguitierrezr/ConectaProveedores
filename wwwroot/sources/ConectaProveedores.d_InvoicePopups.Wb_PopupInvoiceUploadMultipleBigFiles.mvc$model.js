import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_2b77a78552d1dad3876c3ebd8f5c8ec1, ST_5478c3bb197e3019856d4a634c17d91dStructure } from "./ConectaProveedores.model.js";
import BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvcModel from "./BigUpload.BigUpload.wb_BigUploadMultipleFiles.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import OutSystemsUI_Utilities_ButtonLoading_mvcModel from "./OutSystemsUI.Utilities.ButtonLoading.mvc$model.js";


class GetInvoicesByRequisitionOrFolioDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("InvoicesList", "invoicesListOut", "InvoicesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_2b77a78552d1dad3876c3ebd8f5c8ec1))());
}, true, (OS$GenericTypeCache.getGenericList(RC_2b77a78552d1dad3876c3ebd8f5c8ec1)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetInvoicesByRequisitionOrFolioDataActRec(new GetInvoicesByRequisitionOrFolioDataActRec.RecordClass({
invoicesListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
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
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_5478c3bb197e3019856d4a634c17d91dStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_5478c3bb197e3019856d4a634c17d91dStructure))), 
this.attr("HasChanged", "hasChangedVar", "HasChanged", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsSaving", "isSavingVar", "IsSaving", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
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
Model._hasValidationWidgetsValue = (((BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_ButtonLoading_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
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

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


