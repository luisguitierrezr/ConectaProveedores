import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_284d6b812acb53aa55a28cbe2a22b4ca } from "./ConectaProveedores.model.js";
import { EN_20bdea9cf8f17569719f414a83b584b6EntityRecord } from "./SecurityAuth.model.js";
import OutSystemsUI_Navigation_Tabs_mvcModel from "./OutSystemsUI.Navigation.Tabs.mvc$model.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvcModel from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$model.js";
import OutSystemsUI_Navigation_TabsContentItem_mvcModel from "./OutSystemsUI.Navigation.TabsContentItem.mvc$model.js";
import OutSystemsUI_Content_ListItemContent_mvcModel from "./OutSystemsUI.Content.ListItemContent.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsUI_Navigation_Pagination_mvcModel from "./OutSystemsUI.Navigation.Pagination.mvc$model.js";
import ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvcModel from "./ConectaProveedores.a_Common.Wb_AssignTempRolePopup.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvcModel from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$model.js";

class GetUserApplicationRoleTempsByUserIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_284d6b812acb53aa55a28cbe2a22b4ca));
}
static fromStructure(str) {
return new GetUserApplicationRoleTempsByUserIdAggrRec(new GetUserApplicationRoleTempsByUserIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserApplicationRoleTempsByUserIdAggrRec.init();

class GetUserApplicationRoleTempsByAssignedByAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_284d6b812acb53aa55a28cbe2a22b4ca));
}
static fromStructure(str) {
return new GetUserApplicationRoleTempsByAssignedByAggrRec(new GetUserApplicationRoleTempsByAssignedByAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserApplicationRoleTempsByAssignedByAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_MaxRecords", "l_MaxRecordsVar", "l_MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 5;
}, false), 
this.attr("l_ShowAssignTempRolePopup", "l_ShowAssignTempRolePopupVar", "l_ShowAssignTempRolePopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowConfirmPopup", "l_ShowConfirmPopupVar", "l_ShowConfirmPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_UserApplicationRoleTemp", "l_UserApplicationRoleTempVar", "l_UserApplicationRoleTemp", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord());
}, false, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord), 
this.attr("l_StartIndexAssigned", "l_StartIndexAssignedVar", "l_StartIndexAssigned", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_MaxRecordsAssigned", "l_MaxRecordsAssignedVar", "l_MaxRecordsAssigned", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 5;
}, false), 
this.attr("GetUserApplicationRoleTempsByUserId", "getUserApplicationRoleTempsByUserIdAggr", "GetUserApplicationRoleTempsByUserId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRoleTempsByUserIdAggrRec());
}, true, GetUserApplicationRoleTempsByUserIdAggrRec), 
this.attr("GetUserApplicationRoleTempsByAssignedBy", "getUserApplicationRoleTempsByAssignedByAggr", "GetUserApplicationRoleTempsByAssignedBy", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRoleTempsByAssignedByAggrRec());
}, true, GetUserApplicationRoleTempsByAssignedByAggrRec)
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
Model._hasValidationWidgetsValue = (((((((OutSystemsUI_Navigation_Tabs_mvcModel.hasValidationWidgets || OutSystemsUI_Navigation_TabsHeaderItem_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsContentItem_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_ListItemContent_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_Pagination_mvcModel.hasValidationWidgets) || ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


