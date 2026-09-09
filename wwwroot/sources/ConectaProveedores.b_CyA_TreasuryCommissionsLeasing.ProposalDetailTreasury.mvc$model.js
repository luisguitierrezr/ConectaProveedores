import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, RC_b34001d496bee16bcec019df0c313eb6, RC_931c5818c70fb94c867f1591b8f8bd0d } from "./ConectaProveedores.model.js";

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

class GetProposalLinesByProposalIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_b34001d496bee16bcec019df0c313eb6));
}
static fromStructure(str) {
return new GetProposalLinesByProposalIdAggrRec(new GetProposalLinesByProposalIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLinesByProposalIdAggrRec.init();

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



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_IsSelected", "l_IsSelectedVar", "l_IsSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_IsShowSelectAll", "i_IsShowSelectAllVar", "i_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DateTextFormatted", "dateTextFormattedVar", "DateTextFormatted", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_RefeshSideBar", "l_RefeshSideBarVar", "l_RefeshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ShowUnpayPopup", "l_ShowUnpayPopupVar", "l_ShowUnpayPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ProposalLineIdForPopup", "l_ProposalLineIdForPopupVar", "l_ProposalLineIdForPopup", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_PaymentStatus", "l_PaymentStatusVar", "l_PaymentStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ShowUnpaidDetailPopup", "l_ShowUnpaidDetailPopupVar", "l_ShowUnpaidDetailPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ProposalLinelIdUnpaidDetail", "l_ProposalLinelIdUnpaidDetailVar", "l_ProposalLinelIdUnpaidDetail", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetProposalDetailTreasury", "l_ColumnJSONVarGetProposalDetailTreasuryVar", "l_ColumnJSONVarGetProposalDetailTreasury", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetProposalDetailTreasury", "l_CountAfterFetchGetProposalDetailTreasuryVar", "l_CountAfterFetchGetProposalDetailTreasury", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_SelectdLogDocumentId", "l_SelectdLogDocumentIdVar", "l_SelectdLogDocumentId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_SelectdLogDocumentNumber", "l_SelectdLogDocumentNumberVar", "l_SelectdLogDocumentNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_RefeshDocumentSideBar", "l_RefeshDocumentSideBarVar", "l_RefeshDocumentSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ClaimEnable", "l_ClaimEnableVar", "l_ClaimEnable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("i_ProposalId", "i_ProposalIdIn", "i_ProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApprovalStatuses", "getApprovalStatusesAggr", "GetApprovalStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalStatusesAggrRec());
}, true, GetApprovalStatusesAggrRec), 
this.attr("GetProposalLinesByProposalId", "getProposalLinesByProposalIdAggr", "GetProposalLinesByProposalId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLinesByProposalIdAggrRec());
}, true, GetProposalLinesByProposalIdAggrRec), 
this.attr("GetProposalById", "getProposalByIdAggr", "GetProposalById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalByIdAggrRec());
}, true, GetProposalByIdAggrRec)
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
Dropdown_l_PaymentStatus: OS$Model.ValidationWidgetRecord,
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
if("i_ProposalId" in inputs) {
this.variables.i_ProposalIdIn = DataConversion.ServerDataConverter.from(inputs.i_ProposalId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


