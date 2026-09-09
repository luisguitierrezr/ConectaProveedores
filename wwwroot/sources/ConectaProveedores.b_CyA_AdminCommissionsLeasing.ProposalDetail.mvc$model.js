import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { RC_931c5818c70fb94c867f1591b8f8bd0d, EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, RC_37b2ba4d72ceb89cfb30009990025b2f, RC_1d9708453e759844315b6b93812afa56, RC_786401d4272d8830c4a71cf084346ee6 } from "./ConectaProveedores.model.js";

class GetProposalByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_931c5818c70fb94c867f1591b8f8bd0d));
}
static fromStructure(str) {
return new GetProposalByIdAggrRec(new GetProposalByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalByIdAggrRec.init();

class GetProposalStatusesAggrRec extends 
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
return new GetProposalStatusesAggrRec(new GetProposalStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalStatusesAggrRec.init();

class GetProposalApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_37b2ba4d72ceb89cfb30009990025b2f));
}
static fromStructure(str) {
return new GetProposalApprovalLevelsAggrRec(new GetProposalApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalApprovalLevelsAggrRec.init();

class GetProposalLinesByProposalIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_1d9708453e759844315b6b93812afa56));
}
static fromStructure(str) {
return new GetProposalLinesByProposalIdAggrRec(new GetProposalLinesByProposalIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLinesByProposalIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_DateTextFormatted", "l_DateTextFormattedVar", "l_DateTextFormatted", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_RefeshSideBar", "l_RefeshSideBarVar", "l_RefeshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ShowCancelPopup", "l_ShowCancelPopupVar", "l_ShowCancelPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ProposalApprovalLevelId", "l_ProposalApprovalLevelIdVar", "l_ProposalApprovalLevelId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ShowUnpaidDetailPopup", "l_ShowUnpaidDetailPopupVar", "l_ShowUnpaidDetailPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ProposalLineId", "l_ProposalLineIdVar", "l_ProposalLineId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetProposalLinesB", "l_ColumnJSONVarGetProposalLinesBVar", "l_ColumnJSONVarGetProposalLinesB", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetProposalLinesB", "l_CountAfterFetchGetProposalLinesBVar", "l_CountAfterFetchGetProposalLinesB", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ListForApprovalLevelDropdown", "l_ListForApprovalLevelDropdownVar", "l_ListForApprovalLevelDropdown", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_786401d4272d8830c4a71cf084346ee6))());
}, false, (OS$GenericTypeCache.getGenericList(RC_786401d4272d8830c4a71cf084346ee6))), 
this.attr("l_RefeshDocumentSideBar", "l_RefeshDocumentSideBarVar", "l_RefeshDocumentSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_SelectdLogDocumentId", "l_SelectdLogDocumentIdVar", "l_SelectdLogDocumentId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_SelectdLogDocumentNumber", "l_SelectdLogDocumentNumberVar", "l_SelectdLogDocumentNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_ProposalId", "i_ProposalIdIn", "i_ProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetProposalById", "getProposalByIdAggr", "GetProposalById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalByIdAggrRec());
}, true, GetProposalByIdAggrRec), 
this.attr("GetProposalStatuses", "getProposalStatusesAggr", "GetProposalStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalStatusesAggrRec());
}, true, GetProposalStatusesAggrRec), 
this.attr("GetProposalApprovalLevels", "getProposalApprovalLevelsAggr", "GetProposalApprovalLevels", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalApprovalLevelsAggrRec());
}, true, GetProposalApprovalLevelsAggrRec), 
this.attr("GetProposalLinesByProposalId", "getProposalLinesByProposalIdAggr", "GetProposalLinesByProposalId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLinesByProposalIdAggrRec());
}, true, GetProposalLinesByProposalIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Filename: OS$Model.ValidationWidgetRecord,
Input_ProposalType: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Input_Bank: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord,
Dropdown_l_ProposalApprovalLevelId: OS$Model.ValidationWidgetRecord
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
if("i_ProposalId" in inputs) {
this.variables.i_ProposalIdIn = DataConversion.ServerDataConverter.from(inputs.i_ProposalId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


