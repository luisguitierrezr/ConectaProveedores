import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_96ee18663de42b81d96c758873824c1f, RC_99fa4277b2264c97bde8f4525bdc92e0, RC_b2bab424cbee127fcb27bb237f9cab05, RC_26cbbaf47ee3c0155ebd57237529c97f } from "./ConectaProveedores.model.js";

class GetOrdersToComplementAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_96ee18663de42b81d96c758873824c1f));
}
static fromStructure(str) {
return new GetOrdersToComplementAggrRec(new GetOrdersToComplementAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrdersToComplementAggrRec.init();



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
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_DaysWithoutAssigmentList", "l_DaysWithoutAssigmentListVar", "l_DaysWithoutAssigmentList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))());
}, false, (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))), 
this.attr("l_ShowAssignPopUp", "l_ShowAssignPopUpVar", "l_ShowAssignPopUp", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_b2bab424cbee127fcb27bb237f9cab05());
}, false, RC_b2bab424cbee127fcb27bb237f9cab05), 
this.attr("l_ShowRejectPopUp", "l_ShowRejectPopUpVar", "l_ShowRejectPopUp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsAnyLineSelected", "l_IsAnyLineSelectedVar", "l_IsAnyLineSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderList", "l_OrderListVar", "l_OrderList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_26cbbaf47ee3c0155ebd57237529c97f))());
}, false, (OS$GenericTypeCache.getGenericList(RC_26cbbaf47ee3c0155ebd57237529c97f))), 
this.attr("l_OrderIdToReject", "l_OrderIdToRejectVar", "l_OrderIdToReject", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("GetOrdersToComplement", "getOrdersToComplementAggr", "GetOrdersToComplement", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrdersToComplementAggrRec());
}, true, GetOrdersToComplementAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Number: OS$Model.ValidationWidgetRecord,
Dropdown_OrderToComplement_Days: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord,
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


