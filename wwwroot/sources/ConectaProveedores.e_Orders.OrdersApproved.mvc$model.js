import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_b4754aede4b6751be05d5ea422ed168c, RC_99fa4277b2264c97bde8f4525bdc92e0 } from "./ConectaProveedores.model.js";

class GetOrdersApprovedFullAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_b4754aede4b6751be05d5ea422ed168c));
}
static fromStructure(str) {
return new GetOrdersApprovedFullAggrRec(new GetOrdersApprovedFullAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrdersApprovedFullAggrRec.init();

class GetOrdersApprovedAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_b4754aede4b6751be05d5ea422ed168c));
}
static fromStructure(str) {
return new GetOrdersApprovedAggrRec(new GetOrdersApprovedAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrdersApprovedAggrRec.init();



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
this.attr("l_ShowOrderApproval", "l_ShowOrderApprovalVar", "l_ShowOrderApproval", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderIdForPopup", "l_OrderIdForPopupVar", "l_OrderIdForPopup", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("IsListFullNeedRefresh", "isListFullNeedRefreshVar", "IsListFullNeedRefresh", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetOrdersApprovedFull", "getOrdersApprovedFullAggr", "GetOrdersApprovedFull", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrdersApprovedFullAggrRec());
}, true, GetOrdersApprovedFullAggrRec), 
this.attr("GetOrdersApproved", "getOrdersApprovedAggr", "GetOrdersApproved", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrdersApprovedAggrRec());
}, true, GetOrdersApprovedAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Number: OS$Model.ValidationWidgetRecord
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


