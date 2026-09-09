import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord } from "./Organization.model.js";

class GetApprovalProcessTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord, {
name: "ApprovalProcessType",
attrName: "approvalProcessTypeAttr",
nameForJson: "ApprovalProcessType",
uniqueId: "66db0edc-ff7e-a9b0-aa25-8e335add1ccc"
}))));
}
static fromStructure(str) {
return new GetApprovalProcessTypesAggrRec(new GetApprovalProcessTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalProcessTypesAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ActiveTab", "l_ActiveTabVar", "l_ActiveTab", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_Motive", "l_MotiveVar", "l_Motive", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsValidSearchUserDropdown", "l_IsValidSearchUserDropdownVar", "l_IsValidSearchUserDropdown", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("l_SelectedUser", "l_SelectedUserVar", "l_SelectedUser", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsValidSearchApprovalProcessDropdown", "l_IsValidSearchApprovalProcessDropdownVar", "l_IsValidSearchApprovalProcessDropdown", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("l_SelectedApprovalProcess", "l_SelectedApprovalProcessVar", "l_SelectedApprovalProcess", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ApprovalProcessTypeSelected", "l_ApprovalProcessTypeSelectedVar", "l_ApprovalProcessTypeSelected", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApprovalProcessTypes", "getApprovalProcessTypesAggr", "GetApprovalProcessTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalProcessTypesAggrRec());
}, true, GetApprovalProcessTypesAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Dropdown_ApprovalProcessTypeSelected: OS$Model.ValidationWidgetRecord,
Form: OS$Model.ValidationWidgetRecord,
TextArea_l_Motive: OS$Model.ValidationWidgetRecord
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
if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = inputs.i_FolioId;
if("_i_FolioIdInDataFetchStatus" in inputs) {
this.variables._i_FolioIdInDataFetchStatus = inputs._i_FolioIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


