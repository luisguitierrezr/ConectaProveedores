import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_a32d2d6effb998fa5a8e4b01f03a15ca, RC_26cbbaf47ee3c0155ebd57237529c97f } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvcModel from "./OutSystemsUI.Interaction.DropdownSearch.mvc$model.js";


class GetUsersListDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_UsersList", "o_UsersListOut", "o_UsersList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_a32d2d6effb998fa5a8e4b01f03a15ca))());
}, true, (OS$GenericTypeCache.getGenericList(RC_a32d2d6effb998fa5a8e4b01f03a15ca)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetUsersListDataActRec(new GetUsersListDataActRec.RecordClass({
o_UsersListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUsersListDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_AssignUserId", "l_AssignUserIdVar", "l_AssignUserId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_IsBulkAssign", "i_IsBulkAssignIn", "i_IsBulkAssign", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsBulkAssignInDataFetchStatus", "_i_IsBulkAssignInDataFetchStatus", "_i_IsBulkAssignInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_OrderList", "i_OrderListIn", "i_OrderList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_26cbbaf47ee3c0155ebd57237529c97f))());
}, false, (OS$GenericTypeCache.getGenericList(RC_26cbbaf47ee3c0155ebd57237529c97f))), 
this.attr("_i_OrderListInDataFetchStatus", "_i_OrderListInDataFetchStatus", "_i_OrderListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetUsersList", "getUsersListDataAct", "GetUsersList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUsersListDataActRec());
}, true, GetUsersListDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = (OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || OutSystemsUI_Interaction_DropdownSearch_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_IsBulkAssign" in inputs) {
this.variables.i_IsBulkAssignIn = inputs.i_IsBulkAssign;
if("_i_IsBulkAssignInDataFetchStatus" in inputs) {
this.variables._i_IsBulkAssignInDataFetchStatus = inputs._i_IsBulkAssignInDataFetchStatus;
}

}

if("i_OrderList" in inputs) {
this.variables.i_OrderListIn = inputs.i_OrderList;
if("_i_OrderListInDataFetchStatus" in inputs) {
this.variables._i_OrderListInDataFetchStatus = inputs._i_OrderListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


