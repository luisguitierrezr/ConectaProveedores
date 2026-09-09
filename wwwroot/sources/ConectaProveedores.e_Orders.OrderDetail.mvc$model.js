import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, RC_64337b445a88908182ed34f64cf1399b, RC_06eea14cc287e1e6b6d33a1bc97971e2 } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrdersCreatedOrUpdatedBy.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$model.js";
import OutSystemsUI_Navigation_Tabs_mvcModel from "./OutSystemsUI.Navigation.Tabs.mvc$model.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvcModel from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$model.js";
import OutSystemsUI_Navigation_TabsContentItem_mvcModel from "./OutSystemsUI.Navigation.TabsContentItem.mvc$model.js";
import ConectaProveedores_e_Orders_wb_OrderDetail_1Info_mvcModel from "./ConectaProveedores.e_Orders.wb_OrderDetail_1Info.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$model.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.mvc$model.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_mvcModel from "./ConectaProveedores.j_FoliosSAE.Wb_FolioSAE_Proveedor.mvc$model.js";
import ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_mvcModel from "./ConectaProveedores.e_Orders.wb_OrderItemEntriesByOrderId.mvc$model.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.mvc$model.js";
import ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvcModel from "./ConectaProveedores.e_Orders.WB_OrderFinancialFiles.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvcModel from "./ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.mvc$model.js";
import OutSystemsUI_Interaction_Sidebar_mvcModel from "./OutSystemsUI.Interaction.Sidebar.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import ConectaProveedores_y_Logs_Wb_OrderLogs_mvcModel from "./ConectaProveedores.y_Logs.Wb_OrderLogs.mvc$model.js";
import ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvcModel from "./ConectaProveedores.y_Logs.Wb_SAPEntriesLogs.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderReject_Popup.mvc$model.js";

class GetRejectCommentAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, {
name: "OrderComment",
attrName: "orderCommentAttr",
nameForJson: "OrderComment",
uniqueId: "cd61721e-e821-21e7-8e40-55ba4deb1fa6"
}))));
}
static fromStructure(str) {
return new GetRejectCommentAggrRec(new GetRejectCommentAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRejectCommentAggrRec.init();

class GetOrdersByContractNumberAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_64337b445a88908182ed34f64cf1399b));
}
static fromStructure(str) {
return new GetOrdersByContractNumberAggrRec(new GetOrdersByContractNumberAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrdersByContractNumberAggrRec.init();

class GetOrderMainByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_06eea14cc287e1e6b6d33a1bc97971e2));
}
static fromStructure(str) {
return new GetOrderMainByIdAggrRec(new GetOrderMainByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainByIdAggrRec.init();


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsActiveDEV_HU13008_Complement", "o_IsActiveDEV_HU13008_ComplementOut", "o_IsActiveDEV_HU13008_Complement", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
o_IsActiveDEV_HU13008_ComplementOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ShowOrderReject_Popup", "showOrderReject_PopupVar", "ShowOrderReject_Popup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RefreshSideBar", "l_RefreshSideBarVar", "l_RefreshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ActiveTab", "l_ActiveTabVar", "l_ActiveTab", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("IsShowHistoric", "isShowHistoricVar", "IsShowHistoric", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ForceRefresh", "l_ForceRefreshVar", "l_ForceRefresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetRejectComment", "getRejectCommentAggr", "GetRejectComment", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRejectCommentAggrRec());
}, true, GetRejectCommentAggrRec), 
this.attr("GetOrdersByContractNumber", "getOrdersByContractNumberAggr", "GetOrdersByContractNumber", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrdersByContractNumberAggrRec());
}, true, GetOrdersByContractNumberAggrRec), 
this.attr("GetOrderMainById", "getOrderMainByIdAggr", "GetOrderMainById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainByIdAggrRec());
}, true, GetOrderMainByIdAggrRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec)
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
Model._hasValidationWidgetsValue = ((((((((((((((((((((ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvcModel.hasValidationWidgets || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_mvcModel.hasValidationWidgets) || OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_Tabs_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsHeaderItem_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsContentItem_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_wb_OrderDetail_1Info_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvcModel.hasValidationWidgets) || ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_mvcModel.hasValidationWidgets) || ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_mvcModel.hasValidationWidgets) || ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvcModel.hasValidationWidgets) || OutSystemsUI_Interaction_Sidebar_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Logs_Wb_OrderLogs_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = DataConversion.ServerDataConverter.from(inputs.i_OrderId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


