import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_Filename", "i_FilenameIn", "i_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_FilenameInDataFetchStatus", "_i_FilenameInDataFetchStatus", "_i_FilenameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_StorageId", "i_StorageIdIn", "i_StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Size", "i_SizeIn", "i_Size", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_SizeInDataFetchStatus", "_i_SizeInDataFetchStatus", "_i_SizeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = ((ConectaProveedores_s_Storage_wb_PreviewFile_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_s_Storage_wb_DownloadFile_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_Filename" in inputs) {
this.variables.i_FilenameIn = inputs.i_Filename;
if("_i_FilenameInDataFetchStatus" in inputs) {
this.variables._i_FilenameInDataFetchStatus = inputs._i_FilenameInDataFetchStatus;
}

}

if("i_StorageId" in inputs) {
this.variables.i_StorageIdIn = inputs.i_StorageId;
if("_i_StorageIdInDataFetchStatus" in inputs) {
this.variables._i_StorageIdInDataFetchStatus = inputs._i_StorageIdInDataFetchStatus;
}

}

if("i_Size" in inputs) {
this.variables.i_SizeIn = inputs.i_Size;
if("_i_SizeInDataFetchStatus" in inputs) {
this.variables._i_SizeInDataFetchStatus = inputs._i_SizeInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


