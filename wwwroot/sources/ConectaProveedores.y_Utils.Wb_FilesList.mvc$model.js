import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StorageFileList", "storageFileListIn", "StorageFileList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))), 
this.attr("_storageFileListInDataFetchStatus", "_storageFileListInDataFetchStatus", "_storageFileListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("NameForZIP", "nameForZIPIn", "NameForZIP", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_nameForZIPInDataFetchStatus", "_nameForZIPInDataFetchStatus", "_nameForZIPInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
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
Model._hasValidationWidgetsValue = (OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("StorageFileList" in inputs) {
this.variables.storageFileListIn = inputs.StorageFileList;
if("_storageFileListInDataFetchStatus" in inputs) {
this.variables._storageFileListInDataFetchStatus = inputs._storageFileListInDataFetchStatus;
}

}

if("NameForZIP" in inputs) {
this.variables.nameForZIPIn = inputs.NameForZIP;
if("_nameForZIPInDataFetchStatus" in inputs) {
this.variables._nameForZIPInDataFetchStatus = inputs._nameForZIPInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


