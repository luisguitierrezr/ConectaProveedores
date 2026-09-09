import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_aa8eac9e200aee33e0be6438a23c61c3, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";
import { EN_31f501c551d210017fcb34b5237e3390EntityRecord } from "./Organization.model.js";

class GetInvoicesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_aa8eac9e200aee33e0be6438a23c61c3));
}
static fromStructure(str) {
return new GetInvoicesAggrRec(new GetInvoicesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesAggrRec.init();

class GetRegionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_31f501c551d210017fcb34b5237e3390EntityRecord, {
name: "Region",
attrName: "regionAttr",
nameForJson: "Region",
uniqueId: "deb85dc3-6640-fa92-8dae-5df2493065d0"
}))));
}
static fromStructure(str) {
return new GetRegionsAggrRec(new GetRegionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRegionsAggrRec.init();


class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("IsAuditor", "isAuditorOut", "IsAuditor", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("UserRegion", "userRegionOut", "UserRegion", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("UserSupplier", "userSupplierOut", "UserSupplier", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("IsAllRegions", "isAllRegionsOut", "IsAllRegions", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ApplicationRoleIdForAggregate", "applicationRoleIdForAggregateVar", "ApplicationRoleIdForAggregate", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("ColumnJSONVar", "columnJSONVarVar", "ColumnJSONVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("CountAfterFetch", "countAfterFetchVar", "CountAfterFetch", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("IsToEmpty", "isToEmptyVar", "IsToEmpty", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Loading", "loadingVar", "Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ReInvokeToggler", "reInvokeTogglerVar", "ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetInvoices", "getInvoicesAggr", "GetInvoices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesAggrRec());
}, true, GetInvoicesAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
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
Input_PaymentDate2: OS$Model.ValidationWidgetRecord,
Input_PaymentDate3: OS$Model.ValidationWidgetRecord
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


