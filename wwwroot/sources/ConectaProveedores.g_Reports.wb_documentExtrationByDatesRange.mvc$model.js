import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_cfb4b5cbc9f75e782e7f32736dbeac24 } from "./ConectaProveedores.model.js";

class GetInvoiceFilesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_cfb4b5cbc9f75e782e7f32736dbeac24));
}
static fromStructure(str) {
return new GetInvoiceFilesAggrRec(new GetInvoiceFilesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceFilesAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
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
return 10;
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
this.attr("GetInvoiceFiles", "getInvoiceFilesAggr", "GetInvoiceFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceFilesAggrRec());
}, true, GetInvoiceFilesAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_DateTimeVar3: OS$Model.ValidationWidgetRecord,
Input_DateTimeVar4: OS$Model.ValidationWidgetRecord,
Checkbox4: OS$Model.ValidationWidgetRecord
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


