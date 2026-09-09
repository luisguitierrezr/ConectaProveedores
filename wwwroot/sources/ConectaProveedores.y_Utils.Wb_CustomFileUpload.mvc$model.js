import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_a158c76eb93396680623c04244f48b6cStructure, ST_b453bea0930035904f55a74692afd3a8Structure } from "./ConectaProveedores.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsDownloading", "l_IsDownloadingVar", "l_IsDownloading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_AcceptedFileTypes", "i_AcceptedFileTypesIn", "i_AcceptedFileTypes", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_AcceptedFileTypesInDataFetchStatus", "_i_AcceptedFileTypesInDataFetchStatus", "_i_AcceptedFileTypesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FilesMaxSize", "i_FilesMaxSizeIn", "i_FilesMaxSize", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_i_FilesMaxSizeInDataFetchStatus", "_i_FilesMaxSizeInDataFetchStatus", "_i_FilesMaxSizeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsEnabled", "i_IsEnabledIn", "i_IsEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsEnabledInDataFetchStatus", "_i_IsEnabledInDataFetchStatus", "_i_IsEnabledInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_File", "i_FileIn", "i_File", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_a158c76eb93396680623c04244f48b6cStructure());
}, false, ST_a158c76eb93396680623c04244f48b6cStructure), 
this.attr("_i_FileInDataFetchStatus", "_i_FileInDataFetchStatus", "_i_FileInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Label", "i_LabelIn", "i_Label", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_LabelInDataFetchStatus", "_i_LabelInDataFetchStatus", "_i_LabelInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsMandatory", "i_IsMandatoryIn", "i_IsMandatory", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Valid", "i_ValidIn", "i_Valid", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_b453bea0930035904f55a74692afd3a8Structure());
}, false, ST_b453bea0930035904f55a74692afd3a8Structure), 
this.attr("_i_ValidInDataFetchStatus", "_i_ValidInDataFetchStatus", "_i_ValidInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Prompt", "i_PromptIn", "i_Prompt", true, false, OS$DataTypes.DataTypes.Text, function () {
return "Documento (pdf/doc)";
}, false), 
this.attr("_i_PromptInDataFetchStatus", "_i_PromptInDataFetchStatus", "_i_PromptInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_StorageId", "i_StorageIdIn", "i_StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("i_AcceptedFileTypes" in inputs) {
this.variables.i_AcceptedFileTypesIn = inputs.i_AcceptedFileTypes;
if("_i_AcceptedFileTypesInDataFetchStatus" in inputs) {
this.variables._i_AcceptedFileTypesInDataFetchStatus = inputs._i_AcceptedFileTypesInDataFetchStatus;
}

}

if("i_FilesMaxSize" in inputs) {
this.variables.i_FilesMaxSizeIn = inputs.i_FilesMaxSize;
if("_i_FilesMaxSizeInDataFetchStatus" in inputs) {
this.variables._i_FilesMaxSizeInDataFetchStatus = inputs._i_FilesMaxSizeInDataFetchStatus;
}

}

if("i_IsEnabled" in inputs) {
this.variables.i_IsEnabledIn = inputs.i_IsEnabled;
if("_i_IsEnabledInDataFetchStatus" in inputs) {
this.variables._i_IsEnabledInDataFetchStatus = inputs._i_IsEnabledInDataFetchStatus;
}

}

if("i_File" in inputs) {
this.variables.i_FileIn = inputs.i_File;
if("_i_FileInDataFetchStatus" in inputs) {
this.variables._i_FileInDataFetchStatus = inputs._i_FileInDataFetchStatus;
}

}

if("i_Label" in inputs) {
this.variables.i_LabelIn = inputs.i_Label;
if("_i_LabelInDataFetchStatus" in inputs) {
this.variables._i_LabelInDataFetchStatus = inputs._i_LabelInDataFetchStatus;
}

}

if("i_IsMandatory" in inputs) {
this.variables.i_IsMandatoryIn = inputs.i_IsMandatory;
if("_i_IsMandatoryInDataFetchStatus" in inputs) {
this.variables._i_IsMandatoryInDataFetchStatus = inputs._i_IsMandatoryInDataFetchStatus;
}

}

if("i_Valid" in inputs) {
this.variables.i_ValidIn = inputs.i_Valid;
if("_i_ValidInDataFetchStatus" in inputs) {
this.variables._i_ValidInDataFetchStatus = inputs._i_ValidInDataFetchStatus;
}

}

if("i_Prompt" in inputs) {
this.variables.i_PromptIn = inputs.i_Prompt;
if("_i_PromptInDataFetchStatus" in inputs) {
this.variables._i_PromptInDataFetchStatus = inputs._i_PromptInDataFetchStatus;
}

}

if("i_StorageId" in inputs) {
this.variables.i_StorageIdIn = inputs.i_StorageId;
if("_i_StorageIdInDataFetchStatus" in inputs) {
this.variables._i_StorageIdInDataFetchStatus = inputs._i_StorageIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


