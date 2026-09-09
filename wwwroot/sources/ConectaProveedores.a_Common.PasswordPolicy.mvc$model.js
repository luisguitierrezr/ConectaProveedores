import { Model as OS$Model, DataTypes as OS$DataTypes, SystemStructures as OS$SystemStructures } from "@outsystems/runtime-core-js";


class GetMaxSavedOldPasswordsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Value", "valueOut", "Value", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetMaxSavedOldPasswordsDataActRec(new GetMaxSavedOldPasswordsDataActRec.RecordClass({
valueOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetMaxSavedOldPasswordsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("PasswordComplexityPolicy", "passwordComplexityPolicyVar", "PasswordComplexityPolicy", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new OS$SystemStructures.PasswordComplexityPolicyRec());
}, false, OS$SystemStructures.PasswordComplexityPolicyRec), 
this.attr("PasswordValidationResult", "passwordValidationResultVar", "PasswordValidationResult", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new OS$SystemStructures.PasswordValidationResultRec());
}, false, OS$SystemStructures.PasswordValidationResultRec), 
this.attr("IsValidPassword", "isValidPasswordVar", "IsValidPassword", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsMissingSpecialCharacter", "isMissingSpecialCharacterVar", "IsMissingSpecialCharacter", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("Password", "passwordIn", "Password", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_passwordInDataFetchStatus", "_passwordInDataFetchStatus", "_passwordInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetMaxSavedOldPasswords", "getMaxSavedOldPasswordsDataAct", "GetMaxSavedOldPasswords", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetMaxSavedOldPasswordsDataActRec());
}, true, GetMaxSavedOldPasswordsDataActRec)
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
if("Password" in inputs) {
this.variables.passwordIn = inputs.Password;
if("_passwordInDataFetchStatus" in inputs) {
this.variables._passwordInDataFetchStatus = inputs._passwordInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


