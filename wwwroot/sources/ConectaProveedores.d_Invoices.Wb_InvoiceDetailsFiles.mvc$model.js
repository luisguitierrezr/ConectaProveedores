import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_7cb091de697d14a1ce465208aa77fcb0 } from "./ConectaProveedores.model.js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByInvoiceId.mvc$model.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";


class GetInvoiceFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("MainFiles", "mainFilesOut", "MainFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_7cb091de697d14a1ce465208aa77fcb0))());
}, true, (OS$GenericTypeCache.getGenericList(RC_7cb091de697d14a1ce465208aa77fcb0))), 
this.attr("ExtraFiles", "extraFilesOut", "ExtraFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_7cb091de697d14a1ce465208aa77fcb0))());
}, true, (OS$GenericTypeCache.getGenericList(RC_7cb091de697d14a1ce465208aa77fcb0)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetInvoiceFilesDataActRec.init();


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
this.attr("IsProveedor", "isProveedorIn", "IsProveedor", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isProveedorInDataFetchStatus", "_isProveedorInDataFetchStatus", "_isProveedorInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceFiles", "getInvoiceFilesDataAct", "GetInvoiceFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceFilesDataActRec());
}, true, GetInvoiceFilesDataActRec)
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
Model._hasValidationWidgetsValue = (((((ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_mvcModel.hasValidationWidgets || ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
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

if("IsProveedor" in inputs) {
this.variables.isProveedorIn = inputs.IsProveedor;
if("_isProveedorInDataFetchStatus" in inputs) {
this.variables._isProveedorInDataFetchStatus = inputs._isProveedorInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


