import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OnEditMode", "onEditModeIn", "OnEditMode", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_onEditModeInDataFetchStatus", "_onEditModeInDataFetchStatus", "_onEditModeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AllowDelete", "allowDeleteIn", "AllowDelete", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_allowDeleteInDataFetchStatus", "_allowDeleteInDataFetchStatus", "_allowDeleteInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AllowAddNew", "allowAddNewIn", "AllowAddNew", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_allowAddNewInDataFetchStatus", "_allowAddNewInDataFetchStatus", "_allowAddNewInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RowNumber", "rowNumberIn", "RowNumber", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_rowNumberInDataFetchStatus", "_rowNumberInDataFetchStatus", "_rowNumberInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("OnEditMode" in inputs) {
this.variables.onEditModeIn = inputs.OnEditMode;
if("_onEditModeInDataFetchStatus" in inputs) {
this.variables._onEditModeInDataFetchStatus = inputs._onEditModeInDataFetchStatus;
}

}

if("AllowDelete" in inputs) {
this.variables.allowDeleteIn = inputs.AllowDelete;
if("_allowDeleteInDataFetchStatus" in inputs) {
this.variables._allowDeleteInDataFetchStatus = inputs._allowDeleteInDataFetchStatus;
}

}

if("AllowAddNew" in inputs) {
this.variables.allowAddNewIn = inputs.AllowAddNew;
if("_allowAddNewInDataFetchStatus" in inputs) {
this.variables._allowAddNewInDataFetchStatus = inputs._allowAddNewInDataFetchStatus;
}

}

if("RowNumber" in inputs) {
this.variables.rowNumberIn = inputs.RowNumber;
if("_rowNumberInDataFetchStatus" in inputs) {
this.variables._rowNumberInDataFetchStatus = inputs._rowNumberInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


