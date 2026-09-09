import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ENUserEntityRecord } from "./System_.model.js";
import { RC_c2921a936d592680b8275006015423c4 } from "./ConectaProveedores.model.js";

class GetUserDetailsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(ENUserEntityRecord, {
name: "User",
attrName: "userAttr",
nameForJson: "User",
uniqueId: "ced01335-8a82-a813-f1d9-a5108f17ce79"
}))));
}
static fromStructure(str) {
return new GetUserDetailsAggrRec(new GetUserDetailsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserDetailsAggrRec.init();

class GetApplicationRolesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c2921a936d592680b8275006015423c4));
}
static fromStructure(str) {
return new GetApplicationRolesAggrRec(new GetApplicationRolesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApplicationRolesAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OldName", "oldNameVar", "OldName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("OldEmail", "oldEmailVar", "OldEmail", true, false, OS$DataTypes.DataTypes.Email, function () {
return "";
}, false), 
this.attr("OldPhotoURL", "oldPhotoURLVar", "OldPhotoURL", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsExternal", "isExternalVar", "IsExternal", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("VerificationCode", "verificationCodeVar", "VerificationCode", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ShowVerificationCode", "showVerificationCodeVar", "ShowVerificationCode", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ShowGetCodeButton", "showGetCodeButtonVar", "ShowGetCodeButton", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("CountdownValue", "countdownValueVar", "CountdownValue", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("TimerIntervalHandle", "timerIntervalHandleVar", "TimerIntervalHandle", true, false, OS$DataTypes.DataTypes.Object, function () {
return null;
}, false), 
this.attr("IsButtonEnabled", "isButtonEnabledVar", "IsButtonEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IntervalDuration", "intervalDurationVar", "IntervalDuration", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 1000;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting_GetCode", "isExecuting_GetCodeVar", "IsExecuting_GetCode", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetUserDetails", "getUserDetailsAggr", "GetUserDetails", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserDetailsAggrRec());
}, true, GetUserDetailsAggrRec), 
this.attr("GetApplicationRoles", "getApplicationRolesAggr", "GetApplicationRoles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApplicationRolesAggrRec());
}, true, GetApplicationRolesAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
ProfileDetailsForm: OS$Model.ValidationWidgetRecord,
NameInput: OS$Model.ValidationWidgetRecord,
PhotoUrlInput: OS$Model.ValidationWidgetRecord,
EmailInput: OS$Model.ValidationWidgetRecord,
VerificationCodeInput: OS$Model.ValidationWidgetRecord
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


