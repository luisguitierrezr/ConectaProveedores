import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_0a41c52434474d75060edec9b8b557c0, RC_99fa4277b2264c97bde8f4525bdc92e0, RC_6a01c4ef1c8f90eed41c7255c682f6e0 } from "./ConectaProveedores.model.js";

class GetOrdersToApproveAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_0a41c52434474d75060edec9b8b557c0));
}
static fromStructure(str) {
return new GetOrdersToApproveAggrRec(new GetOrdersToApproveAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrdersToApproveAggrRec.init();



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
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetOrders", "l_ColumnJSONVarGetOrdersVar", "l_ColumnJSONVarGetOrders", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetOrders", "l_CountAfterFetchGetOrdersVar", "l_CountAfterFetchGetOrders", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_DaysInAssigmentList", "l_DaysInAssigmentListVar", "l_DaysInAssigmentList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))());
}, false, (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsAnyLineSelected", "l_IsAnyLineSelectedVar", "l_IsAnyLineSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowBulkApproveOrders", "l_ShowBulkApproveOrdersVar", "l_ShowBulkApproveOrders", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderApprovalLevelList", "l_OrderApprovalLevelListVar", "l_OrderApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_6a01c4ef1c8f90eed41c7255c682f6e0))());
}, false, (OS$GenericTypeCache.getGenericList(RC_6a01c4ef1c8f90eed41c7255c682f6e0))), 
this.attr("GetOrdersToApprove", "getOrdersToApproveAggr", "GetOrdersToApprove", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrdersToApproveAggrRec());
}, true, GetOrdersToApproveAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Number: OS$Model.ValidationWidgetRecord,
Dropdown_BankId4: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelectAll: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelected: OS$Model.ValidationWidgetRecord
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


