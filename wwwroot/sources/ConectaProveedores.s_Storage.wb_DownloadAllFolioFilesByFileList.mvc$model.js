import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ZipName", "zipNameIn", "ZipName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_zipNameInDataFetchStatus", "_zipNameInDataFetchStatus", "_zipNameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("FileJsonList", "fileJsonListIn", "FileJsonList", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_fileJsonListInDataFetchStatus", "_fileJsonListInDataFetchStatus", "_fileJsonListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("ZipName" in inputs) {
this.variables.zipNameIn = inputs.ZipName;
if("_zipNameInDataFetchStatus" in inputs) {
this.variables._zipNameInDataFetchStatus = inputs._zipNameInDataFetchStatus;
}

}

if("FileJsonList" in inputs) {
this.variables.fileJsonListIn = inputs.FileJsonList;
if("_fileJsonListInDataFetchStatus" in inputs) {
this.variables._fileJsonListInDataFetchStatus = inputs._fileJsonListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


