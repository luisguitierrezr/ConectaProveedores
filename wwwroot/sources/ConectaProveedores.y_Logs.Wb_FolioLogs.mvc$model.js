import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_3ad59a78981b4fa31a09641e4a914930, RC_9f9ef21ffaabef46bdddd7ca965685a7, RC_d896ddfd96504faa41bec68e2ff8d0eb } from "./ConectaProveedores.model.js";

class GetUsersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_3ad59a78981b4fa31a09641e4a914930));
}
static fromStructure(str) {
return new GetUsersAggrRec(new GetUsersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUsersAggrRec.init();

class GetFolioLogsByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_9f9ef21ffaabef46bdddd7ca965685a7));
}
static fromStructure(str) {
return new GetFolioLogsByFolioIdAggrRec(new GetFolioLogsByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioLogsByFolioIdAggrRec.init();

class CountFolioLogsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d896ddfd96504faa41bec68e2ff8d0eb));
}
static fromStructure(str) {
return new CountFolioLogsAggrRec(new CountFolioLogsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

CountFolioLogsAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_DateTimeVar", "l_DateTimeVarVar", "l_DateTimeVar", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_UserName", "l_UserNameVar", "l_UserName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 10;
}, false), 
this.attr("i_refresh", "i_refreshIn", "i_refresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetUsers", "getUsersAggr", "GetUsers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUsersAggrRec());
}, true, GetUsersAggrRec), 
this.attr("GetFolioLogsByFolioId", "getFolioLogsByFolioIdAggr", "GetFolioLogsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioLogsByFolioIdAggrRec());
}, true, GetFolioLogsByFolioIdAggrRec), 
this.attr("CountFolioLogs", "countFolioLogsAggr", "CountFolioLogs", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new CountFolioLogsAggrRec());
}, true, CountFolioLogsAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Dropdown1: OS$Model.ValidationWidgetRecord,
Input_DateTimeVar: OS$Model.ValidationWidgetRecord
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
if("i_refresh" in inputs) {
this.variables.i_refreshIn = inputs.i_refresh;
if("_i_refreshInDataFetchStatus" in inputs) {
this.variables._i_refreshInDataFetchStatus = inputs._i_refreshInDataFetchStatus;
}

}

if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = inputs.i_FolioId;
if("_i_FolioIdInDataFetchStatus" in inputs) {
this.variables._i_FolioIdInDataFetchStatus = inputs._i_FolioIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


