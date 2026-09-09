import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_cf466c446053e827622ddde1ad0222be, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import OutSystemsUI_Interaction_Sidebar_mvcModel from "./OutSystemsUI.Interaction.Sidebar.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_mvcModel from "./ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.mvc$model.js";
import OutSystemsUI_Interaction_Notification_mvcModel from "./OutSystemsUI.Interaction.Notification.mvc$model.js";

class GetReassignmentsByCreatedByAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_cf466c446053e827622ddde1ad0222be));
}
static fromStructure(str) {
return new GetReassignmentsByCreatedByAggrRec(new GetReassignmentsByCreatedByAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetReassignmentsByCreatedByAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("NotifContent", "notifContentVar", "NotifContent", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure());
}, false, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure), 
this.attr("l_IsSidebarOpen", "l_IsSidebarOpenVar", "l_IsSidebarOpen", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetReassignmentsByCreatedBy", "getReassignmentsByCreatedByAggr", "GetReassignmentsByCreatedBy", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetReassignmentsByCreatedByAggrRec());
}, true, GetReassignmentsByCreatedByAggrRec)
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
Model._hasValidationWidgetsValue = (((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || OutSystemsUI_Interaction_Sidebar_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_mvcModel.hasValidationWidgets) || OutSystemsUI_Interaction_Notification_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


