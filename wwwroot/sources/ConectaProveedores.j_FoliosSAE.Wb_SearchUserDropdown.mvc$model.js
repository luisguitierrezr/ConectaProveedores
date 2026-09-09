import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ENUserEntityRecord } from "./System_.model.js";
import { RC_77956dae907db5f208e8a848dc366336 } from "./ConectaProveedores.model.js";

class GetUserByIdAggrRec extends 
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
return new GetUserByIdAggrRec(new GetUserByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserByIdAggrRec.init();

class GetUsersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_77956dae907db5f208e8a848dc366336));
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
this.attr("l_UserSearchText", "l_UserSearchTextVar", "l_UserSearchText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_UserMaxRecord", "l_UserMaxRecordVar", "l_UserMaxRecord", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 20;
}, false), 
this.attr("l_IsValid", "l_IsValidVar", "l_IsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("i_IsDisable", "i_IsDisableIn", "i_IsDisable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsDisableInDataFetchStatus", "_i_IsDisableInDataFetchStatus", "_i_IsDisableInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_UserId", "i_UserIdIn", "i_UserId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_UserIdInDataFetchStatus", "_i_UserIdInDataFetchStatus", "_i_UserIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsValid", "i_IsValidIn", "i_IsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsValidInDataFetchStatus", "_i_IsValidInDataFetchStatus", "_i_IsValidInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsMandatory", "i_IsMandatoryIn", "i_IsMandatory", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", "_i_IsMandatoryInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsFilter", "i_IsFilterIn", "i_IsFilter", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsFilterInDataFetchStatus", "_i_IsFilterInDataFetchStatus", "_i_IsFilterInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_LabelText", "i_LabelTextIn", "i_LabelText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_LabelTextInDataFetchStatus", "_i_LabelTextInDataFetchStatus", "_i_LabelTextInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetUserById", "getUserByIdAggr", "GetUserById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserByIdAggrRec());
}, true, GetUserByIdAggrRec), 
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
Input_UserSearchText: OS$Model.ValidationWidgetRecord
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
if("i_IsDisable" in inputs) {
this.variables.i_IsDisableIn = inputs.i_IsDisable;
if("_i_IsDisableInDataFetchStatus" in inputs) {
this.variables._i_IsDisableInDataFetchStatus = inputs._i_IsDisableInDataFetchStatus;
}

}

if("i_UserId" in inputs) {
this.variables.i_UserIdIn = inputs.i_UserId;
if("_i_UserIdInDataFetchStatus" in inputs) {
this.variables._i_UserIdInDataFetchStatus = inputs._i_UserIdInDataFetchStatus;
}

}

if("i_IsValid" in inputs) {
this.variables.i_IsValidIn = inputs.i_IsValid;
if("_i_IsValidInDataFetchStatus" in inputs) {
this.variables._i_IsValidInDataFetchStatus = inputs._i_IsValidInDataFetchStatus;
}

}

if("i_IsMandatory" in inputs) {
this.variables.i_IsMandatoryIn = inputs.i_IsMandatory;
if("_i_IsMandatoryInDataFetchStatus" in inputs) {
this.variables._i_IsMandatoryInDataFetchStatus = inputs._i_IsMandatoryInDataFetchStatus;
}

}

if("i_IsFilter" in inputs) {
this.variables.i_IsFilterIn = inputs.i_IsFilter;
if("_i_IsFilterInDataFetchStatus" in inputs) {
this.variables._i_IsFilterInDataFetchStatus = inputs._i_IsFilterInDataFetchStatus;
}

}

if("i_LabelText" in inputs) {
this.variables.i_LabelTextIn = inputs.i_LabelText;
if("_i_LabelTextInDataFetchStatus" in inputs) {
this.variables._i_LabelTextInDataFetchStatus = inputs._i_LabelTextInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


