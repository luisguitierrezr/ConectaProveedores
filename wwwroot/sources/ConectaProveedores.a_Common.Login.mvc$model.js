import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { RC_82a9276cec67a3d539884db9fd67d1e2 } from "./ConectaProveedores.model.js";

class GetUserExtendedInternalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_82a9276cec67a3d539884db9fd67d1e2));
}
static fromStructure(str) {
return new GetUserExtendedInternalsAggrRec(new GetUserExtendedInternalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserExtendedInternalsAggrRec.init();


class Get2FADataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ISactive", "iSactiveOut", "ISactive", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new Get2FADataActRec(new Get2FADataActRec.RecordClass({
iSactiveOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

Get2FADataActRec.init();

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
this.attr("UserEmail", "userEmailVar", "UserEmail", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Password", "passwordVar", "Password", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("MakePasswordVisible", "makePasswordVisibleVar", "MakePasswordVisible", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("RememberMe", "rememberMeVar", "RememberMe", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsEnabled", "isEnabledVar", "IsEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("ShowSelectUserPopup", "showSelectUserPopupVar", "ShowSelectUserPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Step", "stepVar", "Step", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("UserCode", "userCodeVar", "UserCode", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsEnabledCode", "isEnabledCodeVar", "IsEnabledCode", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("IsExecutingCodeRequest", "isExecutingCodeRequestVar", "IsExecutingCodeRequest", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("UserExternalEmail", "userExternalEmailVar", "UserExternalEmail", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("RegionToBeAssign", "regionToBeAssignVar", "RegionToBeAssign", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Msg", "msgVar", "Msg", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsResetPassword", "isResetPasswordIn", "IsResetPassword", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isResetPasswordInDataFetchStatus", "_isResetPasswordInDataFetchStatus", "_isResetPasswordInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetUserExtendedInternals", "getUserExtendedInternalsAggr", "GetUserExtendedInternals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserExtendedInternalsAggrRec());
}, true, GetUserExtendedInternalsAggrRec), 
this.attr("Get2FA", "get2FADataAct", "Get2FA", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new Get2FADataActRec());
}, true, Get2FADataActRec), 
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
LoginForm: OS$Model.ValidationWidgetRecord,
Input_Username: OS$Model.ValidationWidgetRecord,
Input_Password: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord,
Input_Usercode: OS$Model.ValidationWidgetRecord
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
if("IsResetPassword" in inputs) {
this.variables.isResetPasswordIn = DataConversion.ServerDataConverter.from(inputs.IsResetPassword, OS$DataTypes.DataTypes.Boolean);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


