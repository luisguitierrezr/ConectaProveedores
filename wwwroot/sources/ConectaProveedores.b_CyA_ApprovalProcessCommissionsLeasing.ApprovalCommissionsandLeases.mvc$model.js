import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_406ede22ed9cba3b6b03435d73fe20b6, RC_46775da414dc909821822de65ba32d4b, EN_7de728375ec552c47f71bca85f9991d9EntityRecord, EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, ST_9adff333942ff7120fc18c8e55f201fdStructure } from "./ConectaProveedores.model.js";
import { EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord } from "./Common.model.js";
import { EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord } from "./Organization.model.js";

class GetProposalLinesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_406ede22ed9cba3b6b03435d73fe20b6));
}
static fromStructure(str) {
return new GetProposalLinesAggrRec(new GetProposalLinesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLinesAggrRec.init();

class GetOperatorsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, {
name: "Operator",
attrName: "operatorAttr",
nameForJson: "Operator",
uniqueId: "21f3e2fd-18d9-1908-a16d-2c0ca969f965"
}))));
}
static fromStructure(str) {
return new GetOperatorsAggrRec(new GetOperatorsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOperatorsAggrRec.init();

class GetBanksAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord, {
name: "Bank",
attrName: "bankAttr",
nameForJson: "Bank",
uniqueId: "df806ed4-5594-b8c1-2dc4-1d845973c44a"
}))));
}
static fromStructure(str) {
return new GetBanksAggrRec(new GetBanksAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetBanksAggrRec.init();

class GetProposalLinesSumAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_46775da414dc909821822de65ba32d4b));
}
static fromStructure(str) {
return new GetProposalLinesSumAggrRec(new GetProposalLinesSumAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLinesSumAggrRec.init();

class GetProposalTypeAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_7de728375ec552c47f71bca85f9991d9EntityRecord, {
name: "ProposalType",
attrName: "proposalTypeAttr",
nameForJson: "ProposalType",
uniqueId: "d6a77c53-0b0e-1f26-87ee-6b3214e237ef"
}))));
}
static fromStructure(str) {
return new GetProposalTypeAggrRec(new GetProposalTypeAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalTypeAggrRec.init();

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

class GetApprovalStatusesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, {
name: "ApprovalStatus",
attrName: "approvalStatusAttr",
nameForJson: "ApprovalStatus",
uniqueId: "5e94710b-a0de-6484-5af2-f9d1cc088302"
}))));
}
static fromStructure(str) {
return new GetApprovalStatusesAggrRec(new GetApprovalStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalStatusesAggrRec.init();


class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_9adff333942ff7120fc18c8e55f201fdStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_9adff333942ff7120fc18c8e55f201fdStructure)))
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
this.attr("l_ShowFilters", "l_ShowFiltersVar", "l_ShowFilters", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_IsSelected", "l_IsSelectedVar", "l_IsSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsShowSelectAll", "l_IsShowSelectAllVar", "l_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowRejectPopup", "l_ShowRejectPopupVar", "l_ShowRejectPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ProposalIdForRejectPopup", "l_ProposalIdForRejectPopupVar", "l_ProposalIdForRejectPopup", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ProposalLineApprovalLevelIdToReject", "l_ProposalLineApprovalLevelIdToRejectVar", "l_ProposalLineApprovalLevelIdToReject", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ApplicationRoleIdForAggregate", "l_ApplicationRoleIdForAggregateVar", "l_ApplicationRoleIdForAggregate", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_IsAllowSelectApplicationRoles", "l_IsAllowSelectApplicationRolesVar", "l_IsAllowSelectApplicationRoles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetProposalLines", "l_ColumnJSONVarGetProposalLinesVar", "l_ColumnJSONVarGetProposalLines", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetProposalLines", "l_CountAfterFetchGetProposalLinesVar", "l_CountAfterFetchGetProposalLines", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RefeshDocumentSideBar", "l_RefeshDocumentSideBarVar", "l_RefeshDocumentSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_SelectdLogDocumentId", "l_SelectdLogDocumentIdVar", "l_SelectdLogDocumentId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_SelectdLogDocumentNumber", "l_SelectdLogDocumentNumberVar", "l_SelectdLogDocumentNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_SelectdLogProposalId", "l_SelectdLogProposalIdVar", "l_SelectdLogProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_AmountFromText", "l_AmountFromTextVar", "l_AmountFromText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AmountToText", "l_AmountToTextVar", "l_AmountToText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetProposalLines", "getProposalLinesAggr", "GetProposalLines", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLinesAggrRec());
}, true, GetProposalLinesAggrRec), 
this.attr("GetOperators", "getOperatorsAggr", "GetOperators", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOperatorsAggrRec());
}, true, GetOperatorsAggrRec), 
this.attr("GetBanks", "getBanksAggr", "GetBanks", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBanksAggrRec());
}, true, GetBanksAggrRec), 
this.attr("GetProposalLinesSum", "getProposalLinesSumAggr", "GetProposalLinesSum", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLinesSumAggrRec());
}, true, GetProposalLinesSumAggrRec), 
this.attr("GetProposalType", "getProposalTypeAggr", "GetProposalType", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalTypeAggrRec());
}, true, GetProposalTypeAggrRec), 
this.attr("GetCompanies", "getCompaniesAggr", "GetCompanies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCompaniesAggrRec());
}, true, GetCompaniesAggrRec), 
this.attr("GetApprovalStatuses", "getApprovalStatusesAggr", "GetApprovalStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalStatusesAggrRec());
}, true, GetApprovalStatusesAggrRec), 
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
Input_Nothing2: OS$Model.ValidationWidgetRecord,
Dropdown9: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentProposalStatusId: OS$Model.ValidationWidgetRecord,
Dropdown_BankId: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Dropdown_Operator_AmountML2: OS$Model.ValidationWidgetRecord,
Dropdown_Operator_AmountML: OS$Model.ValidationWidgetRecord,
Input_AmountML3: OS$Model.ValidationWidgetRecord,
Input_AmountML2: OS$Model.ValidationWidgetRecord,
Dropdown_l_ApplicationRoleIdForAggregate: OS$Model.ValidationWidgetRecord,
Checkbox3: OS$Model.ValidationWidgetRecord,
Checkbox2: OS$Model.ValidationWidgetRecord
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


