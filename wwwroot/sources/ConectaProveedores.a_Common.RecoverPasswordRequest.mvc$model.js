import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";


class GetSettingsEnviromentDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsDevEnvironment", "isDevEnvironmentOut", "IsDevEnvironment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Environment", "environmentOut", "Environment", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSettingsEnviromentDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Email", "emailVar", "Email", true, false, OS$DataTypes.DataTypes.Email, function () {
return "";
}, false), 
this.attr("IsButtonEnabled", "isButtonEnabledVar", "IsButtonEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("GetSettingsEnviroment", "getSettingsEnviromentDataAct", "GetSettingsEnviroment", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsEnviromentDataActRec());
}, true, GetSettingsEnviromentDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
RecoverPasswordForm: OS$Model.ValidationWidgetRecord,
Input_Username: OS$Model.ValidationWidgetRecord
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


