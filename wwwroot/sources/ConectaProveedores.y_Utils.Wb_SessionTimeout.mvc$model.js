import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("WarningTime", "warningTimeOut", "WarningTime", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, true), 
this.attr("LogoutTime", "logoutTimeOut", "LogoutTime", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, true), 
this.attr("WarningMinutes", "warningMinutesOut", "WarningMinutes", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true), 
this.attr("LogoutMinutes", "logoutMinutesOut", "LogoutMinutes", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSettingsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IntervaltId", "intervaltIdVar", "IntervaltId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("ShowWarning", "showWarningVar", "ShowWarning", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Seconds", "secondsVar", "Seconds", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec)
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
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


