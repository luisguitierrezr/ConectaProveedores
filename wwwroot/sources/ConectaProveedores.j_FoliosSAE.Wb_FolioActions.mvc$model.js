import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_e278706027049cb67d7e751f6d362f51, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Navigation_Submenu_mvcModel from "./OutSystemsUI.Navigation.Submenu.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvcModel from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvcModel from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$model.js";
import ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_mvcModel from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioPopup.mvc$model.js";
import ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_mvcModel from "./ConectaProveedores.j_FoliosSAE.Wb_EstablishFlowPopup.mvc$model.js";
import ConectaProveedores_k_Deviations_Wb_CompleteEntry_mvcModel from "./ConectaProveedores.k_Deviations.Wb_CompleteEntry.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_CancelFolioPopup_mvcModel from "./ConectaProveedores.y_Utils.Wb_CancelFolioPopup.mvc$model.js";
import ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_mvcModel from "./ConectaProveedores.j_FoliosSAE.Wb_IncorrectAssignmentPopup.mvc$model.js";
import ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvcModel from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.mvc$model.js";

class GetFolioApprovalLevelByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_e278706027049cb67d7e751f6d362f51));
}
static fromStructure(str) {
return new GetFolioApprovalLevelByIdAggrRec(new GetFolioApprovalLevelByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalLevelByIdAggrRec.init();


class GetFolioTypeDADataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_ShowOptions", "o_ShowOptionsOut", "o_ShowOptions", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_HU13045", "o_IsActiveDEV_HU13045Out", "o_IsActiveDEV_HU13045", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetFolioTypeDADataActRec.init();

class GetUserInfoDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsAllowedCancelFolio", "isAllowedCancelFolioOut", "IsAllowedCancelFolio", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsAllowedReassign", "isAllowedReassignOut", "IsAllowedReassign", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserInfoDataActRec.init();

class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("AppRoleListText", "appRoleListTextOut", "AppRoleListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("EntraRolesListText", "entraRolesListTextOut", "EntraRolesListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_PopupTitle", "l_PopupTitleVar", "l_PopupTitle", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_ShowPopUp", "l_ShowPopUpVar", "l_ShowPopUp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowApprovePopup", "l_ShowApprovePopupVar", "l_ShowApprovePopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowEstablishFlowPopup", "l_ShowEstablishFlowPopupVar", "l_ShowEstablishFlowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowReassignPopup", "l_ShowReassignPopupVar", "l_ShowReassignPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowCompleteEntryPopup", "l_ShowCompleteEntryPopupVar", "l_ShowCompleteEntryPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowResendEntryPopup", "l_ShowResendEntryPopupVar", "l_ShowResendEntryPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_EvidenceRequest", "l_EvidenceRequestVar", "l_EvidenceRequest", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_Reject", "l_RejectVar", "l_Reject", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_Comment", "l_CommentVar", "l_Comment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_Cancel", "l_CancelVar", "l_Cancel", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsFirstApprover", "l_IsFirstApproverVar", "l_IsFirstApprover", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("I_ShowCancelPopup", "i_ShowCancelPopupVar", "I_ShowCancelPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowIncorrectAssignmentPopup", "l_ShowIncorrectAssignmentPopupVar", "l_ShowIncorrectAssignmentPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowReassignFolioFromRejectPopup", "l_ShowReassignFolioFromRejectPopupVar", "l_ShowReassignFolioFromRejectPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_DirectReport", "i_DirectReportIn", "i_DirectReport", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_DirectReportInDataFetchStatus", "_i_DirectReportInDataFetchStatus", "_i_DirectReportInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioApprovalLevelById", "getFolioApprovalLevelByIdAggr", "GetFolioApprovalLevelById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalLevelByIdAggrRec());
}, true, GetFolioApprovalLevelByIdAggrRec), 
this.attr("GetFolioTypeDA", "getFolioTypeDADataAct", "GetFolioTypeDA", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioTypeDADataActRec());
}, true, GetFolioTypeDADataActRec), 
this.attr("GetUserInfo", "getUserInfoDataAct", "GetUserInfo", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserInfoDataActRec());
}, true, GetUserInfoDataActRec), 
this.attr("GetUserApplicationRoles", "getUserApplicationRolesDataAct", "GetUserApplicationRoles", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesDataActRec());
}, true, GetUserApplicationRolesDataActRec)
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
Model._hasValidationWidgetsValue = ((((((((OutSystemsUI_Navigation_Submenu_mvcModel.hasValidationWidgets || ConectaProveedores_y_Utils_Wb_PopupApprove_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvcModel.hasValidationWidgets) || ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_mvcModel.hasValidationWidgets) || ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_mvcModel.hasValidationWidgets) || ConectaProveedores_k_Deviations_Wb_CompleteEntry_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_CancelFolioPopup_mvcModel.hasValidationWidgets) || ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_mvcModel.hasValidationWidgets) || ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = inputs.i_FolioId;
if("_i_FolioIdInDataFetchStatus" in inputs) {
this.variables._i_FolioIdInDataFetchStatus = inputs._i_FolioIdInDataFetchStatus;
}

}

if("i_DirectReport" in inputs) {
this.variables.i_DirectReportIn = inputs.i_DirectReport;
if("_i_DirectReportInDataFetchStatus" in inputs) {
this.variables._i_DirectReportInDataFetchStatus = inputs._i_DirectReportInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


