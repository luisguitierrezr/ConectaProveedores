import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ENUserEntityRecord } from "./System_.model.js";

class GetUserDetailAggrRec extends 
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
return new GetUserDetailAggrRec(new GetUserDetailAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserDetailAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OldPassword", "oldPasswordVar", "OldPassword", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
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
this.attr("GetUserDetail", "getUserDetailAggr", "GetUserDetail", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserDetailAggrRec());
}, true, GetUserDetailAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
Input_OldPassword: OS$Model.ValidationWidgetRecord,
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


