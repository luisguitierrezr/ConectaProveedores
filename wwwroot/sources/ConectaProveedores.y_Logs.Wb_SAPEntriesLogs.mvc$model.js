import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_cf58ea0f756ca06745169deb0b41c0eb, RC_76b1ff1d6a963752b041dfef3f1cb835 } from "./ConectaProveedores.model.js";

class GetEntriesByOrderMainIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_cf58ea0f756ca06745169deb0b41c0eb));
}
static fromStructure(str) {
return new GetEntriesByOrderMainIdAggrRec(new GetEntriesByOrderMainIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEntriesByOrderMainIdAggrRec.init();

class CountEntriesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_76b1ff1d6a963752b041dfef3f1cb835));
}
static fromStructure(str) {
return new CountEntriesAggrRec(new CountEntriesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

CountEntriesAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_DateTimeVar", "l_DateTimeVarVar", "l_DateTimeVar", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 10;
}, false), 
this.attr("i_OrderMainId", "i_OrderMainIdIn", "i_OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderMainIdInDataFetchStatus", "_i_OrderMainIdInDataFetchStatus", "_i_OrderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_refresh", "i_refreshIn", "i_refresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", "_i_refreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetEntriesByOrderMainId", "getEntriesByOrderMainIdAggr", "GetEntriesByOrderMainId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntriesByOrderMainIdAggrRec());
}, true, GetEntriesByOrderMainIdAggrRec), 
this.attr("CountEntries", "countEntriesAggr", "CountEntries", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new CountEntriesAggrRec());
}, true, CountEntriesAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
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
if("i_OrderMainId" in inputs) {
this.variables.i_OrderMainIdIn = inputs.i_OrderMainId;
if("_i_OrderMainIdInDataFetchStatus" in inputs) {
this.variables._i_OrderMainIdInDataFetchStatus = inputs._i_OrderMainIdInDataFetchStatus;
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


