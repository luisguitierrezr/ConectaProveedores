import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
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

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


