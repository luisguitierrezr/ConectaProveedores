import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { RC_6a01c4ef1c8f90eed41c7255c682f6e0 } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import OutSystemsUI_Utilities_ButtonLoading_mvcModel from "./OutSystemsUI.Utilities.ButtonLoading.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderApprovalLevelList", "l_OrderApprovalLevelListIn", "l_OrderApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_6a01c4ef1c8f90eed41c7255c682f6e0))());
}, false, (OS$GenericTypeCache.getGenericList(RC_6a01c4ef1c8f90eed41c7255c682f6e0))), 
this.attr("_l_OrderApprovalLevelListInDataFetchStatus", "_l_OrderApprovalLevelListInDataFetchStatus", "_l_OrderApprovalLevelListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
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
Model._hasValidationWidgetsValue = ((OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_ButtonLoading_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("l_OrderApprovalLevelList" in inputs) {
this.variables.l_OrderApprovalLevelListIn = inputs.l_OrderApprovalLevelList;
if("_l_OrderApprovalLevelListInDataFetchStatus" in inputs) {
this.variables._l_OrderApprovalLevelListInDataFetchStatus = inputs._l_OrderApprovalLevelListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


