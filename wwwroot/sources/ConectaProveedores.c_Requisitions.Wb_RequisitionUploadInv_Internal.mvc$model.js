import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord } from "./Organization.model.js";
import { RC_86423f353b6ff38800cf09bdbbb2131d } from "./ConectaProveedores.model.js";

class GetProjectAssetServicesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, {
name: "Project_Asset_Service",
attrName: "project_Asset_ServiceAttr",
nameForJson: "Project_Asset_Service",
uniqueId: "1b08a2c1-cece-f1e3-b300-6a60b97fc68e"
}))));
}
static fromStructure(str) {
return new GetProjectAssetServicesAggrRec(new GetProjectAssetServicesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProjectAssetServicesAggrRec.init();

class GetRequisitionsForUploadAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_86423f353b6ff38800cf09bdbbb2131d));
}
static fromStructure(str) {
return new GetRequisitionsForUploadAggrRec(new GetRequisitionsForUploadAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionsForUploadAggrRec.init();

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


class GetApprovalProcessIds2DataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_ApprovalProcessIds", "o_ApprovalProcessIdsOut", "o_ApprovalProcessIds", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetApprovalProcessIds2DataActRec(new GetApprovalProcessIds2DataActRec.RecordClass({
o_ApprovalProcessIdsOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalProcessIds2DataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ShowFilters", "l_ShowFiltersVar", "l_ShowFilters", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetRequisitions", "l_ColumnJSONVarGetRequisitionsVar", "l_ColumnJSONVarGetRequisitions", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetRequisitions", "l_CountAfterFetchGetRequisitionsVar", "l_CountAfterFetchGetRequisitions", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_AmountFromText", "l_AmountFromTextVar", "l_AmountFromText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AmountToText", "l_AmountToTextVar", "l_AmountToText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetProjectAssetServices", "getProjectAssetServicesAggr", "GetProjectAssetServices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServicesAggrRec());
}, true, GetProjectAssetServicesAggrRec), 
this.attr("GetRequisitionsForUpload", "getRequisitionsForUploadAggr", "GetRequisitionsForUpload", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionsForUploadAggrRec());
}, true, GetRequisitionsForUploadAggrRec), 
this.attr("GetCompanies", "getCompaniesAggr", "GetCompanies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCompaniesAggrRec());
}, true, GetCompaniesAggrRec), 
this.attr("GetApprovalProcessIds2", "getApprovalProcessIds2DataAct", "GetApprovalProcessIds2", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalProcessIds2DataActRec());
}, true, GetApprovalProcessIds2DataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Nothing2: OS$Model.ValidationWidgetRecord,
Input_AmountML3: OS$Model.ValidationWidgetRecord,
Input_AmountML2: OS$Model.ValidationWidgetRecord,
Dropdown_BankId2: OS$Model.ValidationWidgetRecord,
Dropdown_BankId3: OS$Model.ValidationWidgetRecord,
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


