import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, RC_bb9053a6ea6eec7bc3ffbc5b5de7b452, RC_24005b43e3f3ca8801049bcbbd68ea10, RC_8129c2d9846bc83a20ef6f3e7b60c809 } from "./ConectaProveedores.model.js";
import { EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord } from "./Common.model.js";
import { EN_31f501c551d210017fcb34b5237e3390EntityRecord } from "./Organization.model.js";

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

class GetProposalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_bb9053a6ea6eec7bc3ffbc5b5de7b452));
}
static fromStructure(str) {
return new GetProposalsAggrRec(new GetProposalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalsAggrRec.init();

class GetProposalsSumAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_24005b43e3f3ca8801049bcbbd68ea10));
}
static fromStructure(str) {
return new GetProposalsSumAggrRec(new GetProposalsSumAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalsSumAggrRec.init();

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

class GetProposalsAssignAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_8129c2d9846bc83a20ef6f3e7b60c809));
}
static fromStructure(str) {
return new GetProposalsAssignAggrRec(new GetProposalsAssignAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalsAssignAggrRec.init();

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



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "FileExtended.id desc";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ShowFilters", "l_ShowFiltersVar", "l_ShowFilters", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RefeshSideBar", "l_RefeshSideBarVar", "l_RefeshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetProposalsTreasury", "l_ColumnJSONVarGetProposalsTreasuryVar", "l_ColumnJSONVarGetProposalsTreasury", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetProposalsTreasury", "l_CountAfterFetchGetProposalsTreasuryVar", "l_CountAfterFetchGetProposalsTreasury", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_proposalId", "l_proposalIdVar", "l_proposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_AmountFromText", "l_AmountFromTextVar", "l_AmountFromText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AmountToText", "l_AmountToTextVar", "l_AmountToText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetProposalStatus", "getProposalStatusAggr", "GetProposalStatus", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalStatusAggrRec());
}, true, GetProposalStatusAggrRec), 
this.attr("GetProposals", "getProposalsAggr", "GetProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalsAggrRec());
}, true, GetProposalsAggrRec), 
this.attr("GetProposalsSum", "getProposalsSumAggr", "GetProposalsSum", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalsSumAggrRec());
}, true, GetProposalsSumAggrRec), 
this.attr("GetOperators", "getOperatorsAggr", "GetOperators", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOperatorsAggrRec());
}, true, GetOperatorsAggrRec), 
this.attr("GetBanks", "getBanksAggr", "GetBanks", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBanksAggrRec());
}, true, GetBanksAggrRec), 
this.attr("GetProposalsAssign", "getProposalsAssignAggr", "GetProposalsAssign", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalsAssignAggrRec());
}, true, GetProposalsAssignAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Nothing: OS$Model.ValidationWidgetRecord,
Dropdown_Region: OS$Model.ValidationWidgetRecord,
Dropdown_Bank: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Dropdown_Status: OS$Model.ValidationWidgetRecord,
Input_AmountML3: OS$Model.ValidationWidgetRecord,
Input_AmountML2: OS$Model.ValidationWidgetRecord,
Dropdown_Status2: OS$Model.ValidationWidgetRecord,
Input_CreationDate: OS$Model.ValidationWidgetRecord
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


