import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord } from "./Organization.model.js";
import { RC_04c362ab7ba29f051f4f0e5fa0df3577, ST_1bddfac19e9b0cef65924aa7568fd106Structure, RC_d14c83cafc2c8c4853d5f866ece1c59b, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";

class GetCompaniesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, {
name: "Company",
attrName: "companyAttr",
nameForJson: "Company",
uniqueId: "99a1fa6d-f481-ec5b-1908-e770c81b73b1"
}))));
}
static fromStructure(str) {
return new GetCompaniesAggrRec(new GetCompaniesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCompaniesAggrRec.init();

class GerOrderByOrderNumberAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_04c362ab7ba29f051f4f0e5fa0df3577));
}
static fromStructure(str) {
return new GerOrderByOrderNumberAggrRec(new GerOrderByOrderNumberAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GerOrderByOrderNumberAggrRec.init();


class GetOrderMainItemsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_1bddfac19e9b0cef65924aa7568fd106Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_1bddfac19e9b0cef65924aa7568fd106Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetOrderMainItemsDataActRec(new GetOrderMainItemsDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainItemsDataActRec.init();

class GetOrdersDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_d14c83cafc2c8c4853d5f866ece1c59b))());
}, true, (OS$GenericTypeCache.getGenericList(RC_d14c83cafc2c8c4853d5f866ece1c59b))), 
this.attr("Count", "countOut", "Count", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetOrdersDataActRec.init();

class GetApplicantTypeDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ApprovalProcessTypeId", "approvalProcessTypeIdOut", "ApprovalProcessTypeId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return OS$BuiltinFunctions.nullIdentifier();
}, true), 
this.attr("ApplicantId", "applicantIdOut", "ApplicantId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetApplicantTypeDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_Step", "l_StepVar", "l_Step", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 1;
}, false), 
this.attr("l_OrderNumberFilter", "l_OrderNumberFilterVar", "l_OrderNumberFilter", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CompanyIdFilter", "l_CompanyIdFilterVar", "l_CompanyIdFilter", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_OrderIdSelected", "l_OrderIdSelectedVar", "l_OrderIdSelected", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("IsSelected", "isSelectedVar", "IsSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("LocalSelectedLines", "localSelectedLinesVar", "LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsShowSelectAll", "l_IsShowSelectAllVar", "l_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderIdNumberSelected", "l_OrderIdNumberSelectedVar", "l_OrderIdNumberSelected", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsExcludeFinalDelivery", "l_IsExcludeFinalDeliveryVar", "l_IsExcludeFinalDelivery", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowOnlyAvailable", "l_ShowOnlyAvailableVar", "l_ShowOnlyAvailable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetCompanies", "getCompaniesAggr", "GetCompanies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCompaniesAggrRec());
}, true, GetCompaniesAggrRec), 
this.attr("GerOrderByOrderNumber", "gerOrderByOrderNumberAggr", "GerOrderByOrderNumber", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GerOrderByOrderNumberAggrRec());
}, true, GerOrderByOrderNumberAggrRec), 
this.attr("GetOrderMainItems", "getOrderMainItemsDataAct", "GetOrderMainItems", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainItemsDataActRec());
}, true, GetOrderMainItemsDataActRec), 
this.attr("GetOrders", "getOrdersDataAct", "GetOrders", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrdersDataActRec());
}, true, GetOrdersDataActRec), 
this.attr("GetApplicantType", "getApplicantTypeDataAct", "GetApplicantType", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApplicantTypeDataActRec());
}, true, GetApplicantTypeDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_OrderNumberFilter: OS$Model.ValidationWidgetRecord,
Dropdown_CompanyIdFilter: OS$Model.ValidationWidgetRecord,
Switch_IsExcludeFinalDelivery: OS$Model.ValidationWidgetRecord,
Switch_ShowOnlyAvailable: OS$Model.ValidationWidgetRecord,
CheckboxIsSelectAll: OS$Model.ValidationWidgetRecord,
CheckboxIsSelected: OS$Model.ValidationWidgetRecord
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


