import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$model.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvcModel from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$model.js";


class GetFilesByRequisitionIdDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("FilesPDF", "filesPDFOut", "FilesPDF", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))), 
this.attr("FilesXML", "filesXMLOut", "FilesXML", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))), 
this.attr("OtherFiles", "otherFilesOut", "OtherFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetFilesByRequisitionIdDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsOpenPopupOtherFiles", "l_IsOpenPopupOtherFilesVar", "l_IsOpenPopupOtherFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFilesByRequisitionId", "getFilesByRequisitionIdDataAct", "GetFilesByRequisitionId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFilesByRequisitionIdDataActRec());
}, true, GetFilesByRequisitionIdDataActRec)
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
Model._hasValidationWidgetsValue = ((ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel.hasValidationWidgets || ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_FilesList_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = inputs.i_RequisitionId;
if("_i_RequisitionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionIdInDataFetchStatus = inputs._i_RequisitionIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


