import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_d95078dcb8f428bf6873002913f3165e } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvcModel from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$model.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvcModel from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$model.js";

class GetOrderApprovalsByOrderIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d95078dcb8f428bf6873002913f3165e));
}
static fromStructure(str) {
return new GetOrderApprovalsByOrderIdAggrRec(new GetOrderApprovalsByOrderIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderApprovalsByOrderIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderApprovalsByOrderId", "getOrderApprovalsByOrderIdAggr", "GetOrderApprovalsByOrderId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderApprovalsByOrderIdAggrRec());
}, true, GetOrderApprovalsByOrderIdAggrRec)
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
Model._hasValidationWidgetsValue = (((OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


