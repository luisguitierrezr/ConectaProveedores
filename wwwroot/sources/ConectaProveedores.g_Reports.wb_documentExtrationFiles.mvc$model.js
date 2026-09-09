import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_27be19a2068bdbf4844f837df703a71bStructure } from "./ConectaProveedores.model.js";


class GetAllFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("DocumentExtrationFiles", "documentExtrationFilesOut", "DocumentExtrationFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_27be19a2068bdbf4844f837df703a71bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_27be19a2068bdbf4844f837df703a71bStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetAllFilesDataActRec(new GetAllFilesDataActRec.RecordClass({
documentExtrationFilesOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAllFilesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FileName", "fileNameVar", "FileName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("DateStart", "dateStartVar", "DateStart", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("DateEnd", "dateEndVar", "DateEnd", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("StorageId", "storageIdVar", "StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("IsSelectOne", "isSelectOneVar", "IsSelectOne", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ForceRefresh", "forceRefreshVar", "ForceRefresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("ClickedCollum", "clickedCollumVar", "ClickedCollum", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetAllFiles", "getAllFilesDataAct", "GetAllFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAllFilesDataActRec());
}, true, GetAllFilesDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_TextVar: OS$Model.ValidationWidgetRecord,
Input_DateTimeVar: OS$Model.ValidationWidgetRecord,
Input_DateTimeVar2: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord
};
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

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


