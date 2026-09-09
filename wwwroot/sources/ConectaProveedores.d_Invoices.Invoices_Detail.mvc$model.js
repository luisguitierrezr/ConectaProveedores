import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { ST_e39617f0f094a322d4157f34fe424dadStructure, RC_42a47f09e8ab03d8e9c2d1f2f5aa06af } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import OutSystemsUI_Navigation_Tabs_mvcModel from "./OutSystemsUI.Navigation.Tabs.mvc$model.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvcModel from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$model.js";
import OutSystemsUI_Navigation_TabsContentItem_mvcModel from "./OutSystemsUI.Navigation.TabsContentItem.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetails.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsFiles.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsItems.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_mvcModel from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvcModel from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoicesEntra_Historic.mvc$model.js";


class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("ListText", "listTextOut", "ListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsCorporativoCxP", "isCorporativoCxPOut", "IsCorporativoCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();

class GetInitializationDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("InvoiceById", "invoiceByIdOut", "InvoiceById", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_42a47f09e8ab03d8e9c2d1f2f5aa06af))());
}, true, (OS$GenericTypeCache.getGenericList(RC_42a47f09e8ab03d8e9c2d1f2f5aa06af))), 
this.attr("IsUserCxp", "isUserCxpOut", "IsUserCxp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsActiveUser", "isActiveUserOut", "IsActiveUser", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsAllowed", "isAllowedOut", "IsAllowed", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsProveedor", "isProveedorOut", "IsProveedor", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsDEV", "isDEVOut", "IsDEV", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsActiveDEV_AccountingCeBe", "isActiveDEV_AccountingCeBeOut", "IsActiveDEV_AccountingCeBe", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetInitializationDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("RefreshInvoiceDetailsHistory", "refreshInvoiceDetailsHistoryVar", "RefreshInvoiceDetailsHistory", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetUserApplicationRoles", "getUserApplicationRolesDataAct", "GetUserApplicationRoles", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesDataActRec());
}, true, GetUserApplicationRolesDataActRec), 
this.attr("GetInitializationData", "getInitializationDataDataAct", "GetInitializationData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInitializationDataDataActRec());
}, true, GetInitializationDataDataActRec)
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
Model._hasValidationWidgetsValue = (((((((((((((ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_Tabs_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsHeaderItem_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsContentItem_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_InvoiceId" in inputs) {
this.variables.i_InvoiceIdIn = DataConversion.ServerDataConverter.from(inputs.i_InvoiceId, OS$DataTypes.DataTypes.LongInteger);
}

if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = DataConversion.ServerDataConverter.from(inputs.i_RequisitionId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


