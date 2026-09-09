import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_6fe7a87544f5e670c064f35599cfc737 } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvcModel from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$model.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvcModel from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvcModel from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$model.js";

class GetOrderRequestFileApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_6fe7a87544f5e670c064f35599cfc737));
}
static fromStructure(str) {
return new GetOrderRequestFileApprovalLevelsAggrRec(new GetOrderRequestFileApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderRequestFileApprovalLevelsAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ColumnJSONVar", "l_ColumnJSONVarVar", "l_ColumnJSONVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_CountAfterFetch", "l_CountAfterFetchVar", "l_CountAfterFetch", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetOrderRequestFileApprovalLevels", "getOrderRequestFileApprovalLevelsAggr", "GetOrderRequestFileApprovalLevels", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderRequestFileApprovalLevelsAggrRec());
}, true, GetOrderRequestFileApprovalLevelsAggrRec)
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
Model._hasValidationWidgetsValue = (((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_CustomPagination_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_SetTableRecord_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


