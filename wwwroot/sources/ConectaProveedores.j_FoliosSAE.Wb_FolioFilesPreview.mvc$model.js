import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_a23a10e9592e51ca9ffbbbc42c558496Structure, ST_d381fba44897ce4382b17d5149465d51Structure, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallLeft_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallLeft.mvc$model.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$model.js";


class GetFolioFiles2DataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("FolioMainFiles", "folioMainFilesOut", "FolioMainFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_a23a10e9592e51ca9ffbbbc42c558496Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_a23a10e9592e51ca9ffbbbc42c558496Structure))), 
this.attr("FolioExtraFiles", "folioExtraFilesOut", "FolioExtraFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_a23a10e9592e51ca9ffbbbc42c558496Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_a23a10e9592e51ca9ffbbbc42c558496Structure))), 
this.attr("InvoiceMainFiles", "invoiceMainFilesOut", "InvoiceMainFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_d381fba44897ce4382b17d5149465d51Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_d381fba44897ce4382b17d5149465d51Structure))), 
this.attr("InvoiceExtraFiles", "invoiceExtraFilesOut", "InvoiceExtraFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_d381fba44897ce4382b17d5149465d51Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_d381fba44897ce4382b17d5149465d51Structure))), 
this.attr("IsConstruction", "isConstructionOut", "IsConstruction", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("FolioStatusId", "folioStatusIdOut", "FolioStatusId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("CanSupplierChange", "canSupplierChangeOut", "CanSupplierChange", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("InvoiceID", "invoiceIDOut", "InvoiceID", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("Folio", "folioOut", "Folio", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord());
}, true, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord), 
this.attr("SupplierNumber", "supplierNumberOut", "SupplierNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Invoice", "invoiceOut", "Invoice", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord());
}, true, EN_d1d0320db36efbb094ad0082361435a0EntityRecord), 
this.attr("FilesForDownload", "filesForDownloadOut", "FilesForDownload", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetFolioFiles2DataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_File", "l_FileVar", "l_File", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_a158c76eb93396680623c04244f48b6cStructure());
}, false, ST_a158c76eb93396680623c04244f48b6cStructure), 
this.attr("l_ShowPopupUpload", "l_ShowPopupUploadVar", "l_ShowPopupUpload", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FolioNumber", "i_FolioNumberIn", "i_FolioNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_FolioNumberInDataFetchStatus", "_i_FolioNumberInDataFetchStatus", "_i_FolioNumberInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioFiles2", "getFolioFiles2DataAct", "GetFolioFiles2", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioFiles2DataActRec());
}, true, GetFolioFiles2DataActRec)
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
Model._hasValidationWidgetsValue = ((((((((ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_ColumnsSmallLeft_mvcModel.hasValidationWidgets) || ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel.hasValidationWidgets) || OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = inputs.i_FolioId;
if("_i_FolioIdInDataFetchStatus" in inputs) {
this.variables._i_FolioIdInDataFetchStatus = inputs._i_FolioIdInDataFetchStatus;
}

}

if("i_FolioNumber" in inputs) {
this.variables.i_FolioNumberIn = inputs.i_FolioNumber;
if("_i_FolioNumberInDataFetchStatus" in inputs) {
this.variables._i_FolioNumberInDataFetchStatus = inputs._i_FolioNumberInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


