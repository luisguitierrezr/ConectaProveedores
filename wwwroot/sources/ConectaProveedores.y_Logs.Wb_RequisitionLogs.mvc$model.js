import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_f5b6f78be278df3dd44e2d0a42d99692, RC_76b1ff1d6a963752b041dfef3f1cb835, RC_3ad59a78981b4fa31a09641e4a914930 } from "./ConectaProveedores.model.js";

class GetRequisitionLogsByRequisitionIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f5b6f78be278df3dd44e2d0a42d99692));
}
static fromStructure(str) {
return new GetRequisitionLogsByRequisitionIdAggrRec(new GetRequisitionLogsByRequisitionIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionLogsByRequisitionIdAggrRec.init();

class CountRequisitionLogsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_76b1ff1d6a963752b041dfef3f1cb835));
}
static fromStructure(str) {
return new CountRequisitionLogsAggrRec(new CountRequisitionLogsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

CountRequisitionLogsAggrRec.init();

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
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_refresh", "i_refreshIn", "i_refresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetRequisitionLogsByRequisitionId", "getRequisitionLogsByRequisitionIdAggr", "GetRequisitionLogsByRequisitionId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionLogsByRequisitionIdAggrRec());
}, true, GetRequisitionLogsByRequisitionIdAggrRec), 
this.attr("CountRequisitionLogs", "countRequisitionLogsAggr", "CountRequisitionLogs", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new CountRequisitionLogsAggrRec());
}, true, CountRequisitionLogsAggrRec), 
this.attr("GetUsers", "getUsersAggr", "GetUsers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUsersAggrRec());
}, true, GetUsersAggrRec)
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
if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = inputs.i_RequisitionId;
if("_i_RequisitionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionIdInDataFetchStatus = inputs._i_RequisitionIdInDataFetchStatus;
}

}

if("i_refresh" in inputs) {
this.variables.i_refreshIn = inputs.i_refresh;
if("_i_refreshInDataFetchStatus" in inputs) {
this.variables._i_refreshInDataFetchStatus = inputs._i_refreshInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


