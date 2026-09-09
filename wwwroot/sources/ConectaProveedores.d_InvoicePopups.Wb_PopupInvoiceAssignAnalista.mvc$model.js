import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_77956dae907db5f208e8a848dc366336, RC_7d9af3f1351b60af34cc932af3010814 } from "./ConectaProveedores.model.js";

class GetEligebleUsersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_77956dae907db5f208e8a848dc366336));
}
static fromStructure(str) {
return new GetEligebleUsersAggrRec(new GetEligebleUsersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEligebleUsersAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsBusy", "l_IsBusyVar", "l_IsBusy", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_UserSelected", "l_UserSelectedVar", "l_UserSelected", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_InvoiceApprovalLevelList", "l_InvoiceApprovalLevelListIn", "l_InvoiceApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_7d9af3f1351b60af34cc932af3010814))());
}, false, (OS$GenericTypeCache.getGenericList(RC_7d9af3f1351b60af34cc932af3010814))), 
this.attr("_l_InvoiceApprovalLevelListInDataFetchStatus", "_l_InvoiceApprovalLevelListInDataFetchStatus", "_l_InvoiceApprovalLevelListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetEligebleUsers", "getEligebleUsersAggr", "GetEligebleUsers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEligebleUsersAggrRec());
}, true, GetEligebleUsersAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
Dropdown_UserSelected: OS$Model.ValidationWidgetRecord
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
if("l_InvoiceApprovalLevelList" in inputs) {
this.variables.l_InvoiceApprovalLevelListIn = inputs.l_InvoiceApprovalLevelList;
if("_l_InvoiceApprovalLevelListInDataFetchStatus" in inputs) {
this.variables._l_InvoiceApprovalLevelListInDataFetchStatus = inputs._l_InvoiceApprovalLevelListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


