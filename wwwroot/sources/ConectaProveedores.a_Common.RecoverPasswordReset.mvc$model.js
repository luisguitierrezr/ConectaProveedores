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
this.attr("NewPassword", "newPasswordVar", "NewPassword", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ConfirmPassword", "confirmPasswordVar", "ConfirmPassword", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsPasswordVisible", "isPasswordVisibleVar", "IsPasswordVisible", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsConfirmPasswordVisible", "isConfirmPasswordVisibleVar", "IsConfirmPasswordVisible", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsButtonEnabled", "isButtonEnabledVar", "IsButtonEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsNewPasswordCompliant", "isNewPasswordCompliantVar", "IsNewPasswordCompliant", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("VerificationCode", "verificationCodeVar", "VerificationCode", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Email", "emailVar", "Email", true, false, OS$DataTypes.DataTypes.Email, function () {
return "";
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
PasswordResetForm: OS$Model.ValidationWidgetRecord,
Input_Email: OS$Model.ValidationWidgetRecord,
Input_Code: OS$Model.ValidationWidgetRecord,
Input_NewPassword: OS$Model.ValidationWidgetRecord,
Input_ConfirmPassword: OS$Model.ValidationWidgetRecord
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


