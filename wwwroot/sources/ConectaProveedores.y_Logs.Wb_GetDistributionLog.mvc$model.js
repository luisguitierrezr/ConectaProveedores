import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure } from "./AuditEngine.model.js";
import JSONBeautifier_JSONBeautifier_JSONBeautifier_mvcModel from "./JSONBeautifier.JSONBeautifier.JSONBeautifier.mvc$model.js";


class GetDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("AuditList", "auditListOut", "AuditList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure))), 
this.attr("Count", "countOut", "Count", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("ShowPopup", "showPopupVar", "ShowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("JSON_After", "jSON_AfterVar", "JSON_After", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("JSON_Before", "jSON_BeforeVar", "JSON_Before", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("OriginId", "originIdIn", "OriginId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_originIdInDataFetchStatus", "_originIdInDataFetchStatus", "_originIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("PeriodInit", "periodInitIn", "PeriodInit", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_periodInitInDataFetchStatus", "_periodInitInDataFetchStatus", "_periodInitInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("PeriodEnd", "periodEndIn", "PeriodEnd", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_periodEndInDataFetchStatus", "_periodEndInDataFetchStatus", "_periodEndInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxRecords", "maxRecordsIn", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_maxRecordsInDataFetchStatus", "_maxRecordsInDataFetchStatus", "_maxRecordsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowErrors", "showErrorsIn", "ShowErrors", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showErrorsInDataFetchStatus", "_showErrorsInDataFetchStatus", "_showErrorsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Refresh", "i_RefreshIn", "i_Refresh", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_RefreshInDataFetchStatus", "_i_RefreshInDataFetchStatus", "_i_RefreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Identifier", "identifierIn", "Identifier", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_identifierInDataFetchStatus", "_identifierInDataFetchStatus", "_identifierInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetData", "getDataDataAct", "GetData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDataDataActRec());
}, true, GetDataDataActRec)
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = JSONBeautifier_JSONBeautifier_JSONBeautifier_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("OriginId" in inputs) {
this.variables.originIdIn = inputs.OriginId;
if("_originIdInDataFetchStatus" in inputs) {
this.variables._originIdInDataFetchStatus = inputs._originIdInDataFetchStatus;
}

}

if("PeriodInit" in inputs) {
this.variables.periodInitIn = inputs.PeriodInit;
if("_periodInitInDataFetchStatus" in inputs) {
this.variables._periodInitInDataFetchStatus = inputs._periodInitInDataFetchStatus;
}

}

if("PeriodEnd" in inputs) {
this.variables.periodEndIn = inputs.PeriodEnd;
if("_periodEndInDataFetchStatus" in inputs) {
this.variables._periodEndInDataFetchStatus = inputs._periodEndInDataFetchStatus;
}

}

if("MaxRecords" in inputs) {
this.variables.maxRecordsIn = inputs.MaxRecords;
if("_maxRecordsInDataFetchStatus" in inputs) {
this.variables._maxRecordsInDataFetchStatus = inputs._maxRecordsInDataFetchStatus;
}

}

if("ShowErrors" in inputs) {
this.variables.showErrorsIn = inputs.ShowErrors;
if("_showErrorsInDataFetchStatus" in inputs) {
this.variables._showErrorsInDataFetchStatus = inputs._showErrorsInDataFetchStatus;
}

}

if("i_Refresh" in inputs) {
this.variables.i_RefreshIn = inputs.i_Refresh;
if("_i_RefreshInDataFetchStatus" in inputs) {
this.variables._i_RefreshInDataFetchStatus = inputs._i_RefreshInDataFetchStatus;
}

}

if("Identifier" in inputs) {
this.variables.identifierIn = inputs.Identifier;
if("_identifierInDataFetchStatus" in inputs) {
this.variables._identifierInDataFetchStatus = inputs._identifierInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


