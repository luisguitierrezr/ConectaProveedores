import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_38bf7bcb20a8b257cedfd0071956fdaa, RC_76b1ff1d6a963752b041dfef3f1cb835, RC_3ad59a78981b4fa31a09641e4a914930 } from "./ConectaProveedores.model.js";

class GetProposalLogsByProposalIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_38bf7bcb20a8b257cedfd0071956fdaa));
}
static fromStructure(str) {
return new GetProposalLogsByProposalIdAggrRec(new GetProposalLogsByProposalIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLogsByProposalIdAggrRec.init();

class CountProposalLogsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_76b1ff1d6a963752b041dfef3f1cb835));
}
static fromStructure(str) {
return new CountProposalLogsAggrRec(new CountProposalLogsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

CountProposalLogsAggrRec.init();

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
this.attr("i_ProposalId", "i_ProposalIdIn", "i_ProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ProposalLineId", "i_ProposalLineIdIn", "i_ProposalLineId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalLineIdInDataFetchStatus", "_i_ProposalLineIdInDataFetchStatus", "_i_ProposalLineIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_refresh", "i_refreshIn", "i_refresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetProposalLogsByProposalId", "getProposalLogsByProposalIdAggr", "GetProposalLogsByProposalId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLogsByProposalIdAggrRec());
}, true, GetProposalLogsByProposalIdAggrRec), 
this.attr("CountProposalLogs", "countProposalLogsAggr", "CountProposalLogs", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new CountProposalLogsAggrRec());
}, true, CountProposalLogsAggrRec), 
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
if("i_ProposalId" in inputs) {
this.variables.i_ProposalIdIn = inputs.i_ProposalId;
if("_i_ProposalIdInDataFetchStatus" in inputs) {
this.variables._i_ProposalIdInDataFetchStatus = inputs._i_ProposalIdInDataFetchStatus;
}

}

if("i_ProposalLineId" in inputs) {
this.variables.i_ProposalLineIdIn = inputs.i_ProposalLineId;
if("_i_ProposalLineIdInDataFetchStatus" in inputs) {
this.variables._i_ProposalLineIdInDataFetchStatus = inputs._i_ProposalLineIdInDataFetchStatus;
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


