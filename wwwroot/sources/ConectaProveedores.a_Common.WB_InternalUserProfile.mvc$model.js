import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_3435fb4b7e2feceb28dc5478c72a6c4b, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";

class GetUserDetailsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_3435fb4b7e2feceb28dc5478c72a6c4b));
}
static fromStructure(str) {
return new GetUserDetailsAggrRec(new GetUserDetailsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserDetailsAggrRec.init();


class GetEntraManagerDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ManagerName", "managerNameOut", "ManagerName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetEntraManagerDataActRec(new GetEntraManagerDataActRec.RecordClass({
managerNameOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEntraManagerDataActRec.init();

class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetUserApplicationRolesDataActRec(new GetUserApplicationRolesDataActRec.RecordClass({
userRolesListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserApplicationRolesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsOpenPopUp", "l_IsOpenPopUpVar", "l_IsOpenPopUp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetUserDetails", "getUserDetailsAggr", "GetUserDetails", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserDetailsAggrRec());
}, true, GetUserDetailsAggrRec), 
this.attr("GetEntraManager", "getEntraManagerDataAct", "GetEntraManager", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntraManagerDataActRec());
}, true, GetEntraManagerDataActRec), 
this.attr("GetUserApplicationRoles", "getUserApplicationRolesDataAct", "GetUserApplicationRoles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesDataActRec());
}, true, GetUserApplicationRolesDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
ProfileDetailsForm: OS$Model.ValidationWidgetRecord,
Input_EmployeeNumber: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord,
Input_Email: OS$Model.ValidationWidgetRecord,
Input_JobPosition: OS$Model.ValidationWidgetRecord,
Input_Management: OS$Model.ValidationWidgetRecord,
Input_Department: OS$Model.ValidationWidgetRecord,
Input_RoleTelcell: OS$Model.ValidationWidgetRecord,
Input_SubDirector2: OS$Model.ValidationWidgetRecord,
SubstitutionsForm: OS$Model.ValidationWidgetRecord
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


