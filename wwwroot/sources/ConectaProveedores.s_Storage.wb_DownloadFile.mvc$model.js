import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_StorageId", "i_StorageIdIn", "i_StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Filename", "i_FilenameIn", "i_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_FilenameInDataFetchStatus", "_i_FilenameInDataFetchStatus", "_i_FilenameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FileSize", "i_FileSizeIn", "i_FileSize", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FileSizeInDataFetchStatus", "_i_FileSizeInDataFetchStatus", "_i_FileSizeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("i_StorageId" in inputs) {
this.variables.i_StorageIdIn = inputs.i_StorageId;
if("_i_StorageIdInDataFetchStatus" in inputs) {
this.variables._i_StorageIdInDataFetchStatus = inputs._i_StorageIdInDataFetchStatus;
}

}

if("i_Filename" in inputs) {
this.variables.i_FilenameIn = inputs.i_Filename;
if("_i_FilenameInDataFetchStatus" in inputs) {
this.variables._i_FilenameInDataFetchStatus = inputs._i_FilenameInDataFetchStatus;
}

}

if("i_FileSize" in inputs) {
this.variables.i_FileSizeIn = inputs.i_FileSize;
if("_i_FileSizeInDataFetchStatus" in inputs) {
this.variables._i_FileSizeInDataFetchStatus = inputs._i_FileSizeInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


