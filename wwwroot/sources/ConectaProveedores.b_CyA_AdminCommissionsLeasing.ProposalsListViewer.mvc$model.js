import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_327b52812b8badb247bde4975c10d441EntityRecord, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord } from "./Common.model.js";
import { EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, EN_7de728375ec552c47f71bca85f9991d9EntityRecord, RC_ce0b7a0d9784faac9b31d2f092421318, ST_714c559a98f1e1080cbf60de3228e843Structure } from "./ConectaProveedores.model.js";

class GetCurrenciesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_327b52812b8badb247bde4975c10d441EntityRecord, {
name: "Currency",
attrName: "currencyAttr",
nameForJson: "Currency",
uniqueId: "0468f02f-35e6-ccd6-a092-f321c5d8a88e"
}))));
}
static fromStructure(str) {
return new GetCurrenciesAggrRec(new GetCurrenciesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCurrenciesAggrRec.init();

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

class GetProposalStatusAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, {
name: "ProposalStatus",
attrName: "proposalStatusAttr",
nameForJson: "ProposalStatus",
uniqueId: "5627f7a3-ec06-3e60-2863-ee6b4dd816a2"
}))));
}
static fromStructure(str) {
return new GetProposalStatusAggrRec(new GetProposalStatusAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalStatusAggrRec.init();

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

class GetProposalTypesAggrRec extends 
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
return new GetProposalTypesAggrRec(new GetProposalTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalTypesAggrRec.init();

class GetProposalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_ce0b7a0d9784faac9b31d2f092421318));
}
static fromStructure(str) {
return new GetProposalsAggrRec(new GetProposalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalsAggrRec.init();


class GetUploadTypeDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_714c559a98f1e1080cbf60de3228e843Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_714c559a98f1e1080cbf60de3228e843Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetUploadTypeDataActRec(new GetUploadTypeDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUploadTypeDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "FileExtended.id desc";
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ShowFilters", "l_ShowFiltersVar", "l_ShowFilters", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetProposal", "l_ColumnJSONVarGetProposalVar", "l_ColumnJSONVarGetProposal", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetProposal", "l_CountAfterFetchGetProposalVar", "l_CountAfterFetchGetProposal", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsAutoRefresh", "l_IsAutoRefreshVar", "l_IsAutoRefresh", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_AmountFromText", "l_AmountFromTextVar", "l_AmountFromText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AmountToText", "l_AmountToTextVar", "l_AmountToText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetCurrencies", "getCurrenciesAggr", "GetCurrencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCurrenciesAggrRec());
}, true, GetCurrenciesAggrRec), 
this.attr("GetOperators", "getOperatorsAggr", "GetOperators", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOperatorsAggrRec());
}, true, GetOperatorsAggrRec), 
this.attr("GetProposalStatus", "getProposalStatusAggr", "GetProposalStatus", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalStatusAggrRec());
}, true, GetProposalStatusAggrRec), 
this.attr("GetBanks", "getBanksAggr", "GetBanks", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBanksAggrRec());
}, true, GetBanksAggrRec), 
this.attr("GetProposalTypes", "getProposalTypesAggr", "GetProposalTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalTypesAggrRec());
}, true, GetProposalTypesAggrRec), 
this.attr("GetProposals", "getProposalsAggr", "GetProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalsAggrRec());
}, true, GetProposalsAggrRec), 
this.attr("GetUploadType", "getUploadTypeDataAct", "GetUploadType", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUploadTypeDataActRec());
}, true, GetUploadTypeDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Nothing2: OS$Model.ValidationWidgetRecord,
Dropdown_Bank: OS$Model.ValidationWidgetRecord,
Input_PaymentDate2: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Dropdown_Status: OS$Model.ValidationWidgetRecord,
Input_AmountML: OS$Model.ValidationWidgetRecord,
Input_AmountML2: OS$Model.ValidationWidgetRecord,
Dropdown_Currency: OS$Model.ValidationWidgetRecord,
Dropdown_Status2: OS$Model.ValidationWidgetRecord,
Dropdown_Status3: OS$Model.ValidationWidgetRecord
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


