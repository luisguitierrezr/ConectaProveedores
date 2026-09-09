import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_d4fdf5fe986f15577c3a6610348f52f6, RC_34272dae45b4de5e1332f46c6e8700b9 } from "./ConectaProveedores.model.js";
import { EN_20bdea9cf8f17569719f414a83b584b6EntityRecord } from "./SecurityAuth.model.js";

class GetLoggedUserInfoAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d4fdf5fe986f15577c3a6610348f52f6));
}
static fromStructure(str) {
return new GetLoggedUserInfoAggrRec(new GetLoggedUserInfoAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetLoggedUserInfoAggrRec.init();

class GetUsersFromSameRegionAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_34272dae45b4de5e1332f46c6e8700b9));
}
static fromStructure(str) {
return new GetUsersFromSameRegionAggrRec(new GetUsersFromSameRegionAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUsersFromSameRegionAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_UserDropdownValid", "l_UserDropdownValidVar", "l_UserDropdownValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("l_UserDropdownValidationMessage", "l_UserDropdownValidationMessageVar", "l_UserDropdownValidationMessage", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_UserApplicationRoleTemp", "l_UserApplicationRoleTempIn", "l_UserApplicationRoleTemp", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord());
}, false, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord), 
this.attr("_l_UserApplicationRoleTempInDataFetchStatus", "_l_UserApplicationRoleTempInDataFetchStatus", "_l_UserApplicationRoleTempInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetLoggedUserInfo", "getLoggedUserInfoAggr", "GetLoggedUserInfo", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetLoggedUserInfoAggrRec());
}, true, GetLoggedUserInfoAggrRec), 
this.attr("GetUsersFromSameRegion", "getUsersFromSameRegionAggr", "GetUsersFromSameRegion", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUsersFromSameRegionAggrRec());
}, true, GetUsersFromSameRegionAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_DateFrom: OS$Model.ValidationWidgetRecord,
Input_DateTo: OS$Model.ValidationWidgetRecord
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
if("l_UserApplicationRoleTemp" in inputs) {
this.variables.l_UserApplicationRoleTempIn = inputs.l_UserApplicationRoleTemp;
if("_l_UserApplicationRoleTempInDataFetchStatus" in inputs) {
this.variables._l_UserApplicationRoleTempInDataFetchStatus = inputs._l_UserApplicationRoleTempInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


