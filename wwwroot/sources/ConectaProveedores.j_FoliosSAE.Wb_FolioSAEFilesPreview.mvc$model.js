import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvcModel from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$model.js";


class GetFolioFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("FilePDF", "filePDFOut", "FilePDF", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("FileSizePDF", "fileSizePDFOut", "FileSizePDF", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("FileXML", "fileXMLOut", "FileXML", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("FileSizeXML", "fileSizeXMLOut", "FileSizeXML", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("OtherFiles", "otherFilesOut", "OtherFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetFolioFilesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsOpenPopupOtherFiles", "isOpenPopupOtherFilesVar", "IsOpenPopupOtherFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FolioId", "folioIdIn", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioFiles", "getFolioFilesDataAct", "GetFolioFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioFilesDataActRec());
}, true, GetFolioFilesDataActRec)
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
Model._hasValidationWidgetsValue = (((ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_FilesList_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
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


