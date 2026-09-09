import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_184336c68155ad9e77005f91e8e8b363, EN_5eda60810da752f579e01795bb7e0de0EntityRecord, RC_acb134934352a9d72fd2cc0509d2f469, RC_a2ea85a9f362412e4b6f04be74bb4c8a, RC_4f0d40ef248987564be81ff3e7fa1eab, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";

class GetUserOriginalAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_184336c68155ad9e77005f91e8e8b363));
}
static fromStructure(str) {
return new GetUserOriginalAggrRec(new GetUserOriginalAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserOriginalAggrRec.init();

class GetOrderStatusesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_5eda60810da752f579e01795bb7e0de0EntityRecord, {
name: "OrderStatus",
attrName: "orderStatusAttr",
nameForJson: "OrderStatus",
uniqueId: "919d72dc-5292-e812-597a-f4fac0a808e4"
}))));
}
static fromStructure(str) {
return new GetOrderStatusesAggrRec(new GetOrderStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderStatusesAggrRec.init();

class GetInvoicesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_acb134934352a9d72fd2cc0509d2f469));
}
static fromStructure(str) {
return new GetInvoicesAggrRec(new GetInvoicesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesAggrRec.init();

class GetOrderApprovalLevelsByAssignedToAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_a2ea85a9f362412e4b6f04be74bb4c8a));
}
static fromStructure(str) {
return new GetOrderApprovalLevelsByAssignedToAggrRec(new GetOrderApprovalLevelsByAssignedToAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderApprovalLevelsByAssignedToAggrRec.init();


class GetRequisitionsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_4f0d40ef248987564be81ff3e7fa1eab))());
}, true, (OS$GenericTypeCache.getGenericList(RC_4f0d40ef248987564be81ff3e7fa1eab)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetRequisitionsDataActRec(new GetRequisitionsDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionsDataActRec.init();

class GetUserApplicationRolesAndMoreDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("AppRolesListText", "appRolesListTextOut", "AppRolesListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsCorporativoCxP", "isCorporativoCxPOut", "IsCorporativoCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_CanUploadInvoices", "o_CanUploadInvoicesOut", "o_CanUploadInvoices", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("TelcelDirectionsListText", "telcelDirectionsListTextOut", "TelcelDirectionsListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("CorporativoRegionId", "corporativoRegionIdOut", "CorporativoRegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("UserRegion", "userRegionOut", "UserRegion", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesAndMoreDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("UserOriginal", "userOriginalVar", "UserOriginal", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("UserSubstitute", "userSubstituteVar", "UserSubstitute", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("OrderNumberFilter", "orderNumberFilterVar", "OrderNumberFilter", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("OrderStatusId", "orderStatusIdVar", "OrderStatusId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("GetUserOriginal", "getUserOriginalAggr", "GetUserOriginal", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserOriginalAggrRec());
}, true, GetUserOriginalAggrRec), 
this.attr("GetOrderStatuses", "getOrderStatusesAggr", "GetOrderStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderStatusesAggrRec());
}, true, GetOrderStatusesAggrRec), 
this.attr("GetInvoices", "getInvoicesAggr", "GetInvoices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesAggrRec());
}, true, GetInvoicesAggrRec), 
this.attr("GetOrderApprovalLevelsByAssignedTo", "getOrderApprovalLevelsByAssignedToAggr", "GetOrderApprovalLevelsByAssignedTo", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderApprovalLevelsByAssignedToAggrRec());
}, true, GetOrderApprovalLevelsByAssignedToAggrRec), 
this.attr("GetRequisitions", "getRequisitionsDataAct", "GetRequisitions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionsDataActRec());
}, true, GetRequisitionsDataActRec), 
this.attr("GetUserApplicationRolesAndMore", "getUserApplicationRolesAndMoreDataAct", "GetUserApplicationRolesAndMore", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesAndMoreDataActRec());
}, true, GetUserApplicationRolesAndMoreDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_TextVar: OS$Model.ValidationWidgetRecord,
Dropdown1: OS$Model.ValidationWidgetRecord
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


