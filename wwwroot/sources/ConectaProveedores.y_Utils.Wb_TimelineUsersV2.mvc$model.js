import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_f14441a8387aba6d017931caef70dd11Structure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("StepList", "stepListIn", "StepList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_f14441a8387aba6d017931caef70dd11Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_f14441a8387aba6d017931caef70dd11Structure))), 
this.attr("_stepListInDataFetchStatus", "_stepListInDataFetchStatus", "_stepListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = (OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("StepList" in inputs) {
this.variables.stepListIn = inputs.StepList;
if("_stepListInDataFetchStatus" in inputs) {
this.variables._stepListInDataFetchStatus = inputs._stepListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


