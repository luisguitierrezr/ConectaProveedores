import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_0601d361b69aac23601da3c9e115bec5, ST_e39617f0f094a322d4157f34fe424dadStructure } from "./ConectaProveedores.model.js";
import { ST_34313c5cf94d7ce3c5404858c22fafd9Structure } from "./OutSystemsCharts.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsCharts_Charts_DonutChart_mvcModel from "./OutSystemsCharts.Charts.DonutChart.mvc$model.js";
import OutSystemsCharts_Addons_ChartLegend_mvcModel from "./OutSystemsCharts.Addons.ChartLegend.mvc$model.js";
import OutSystemsCharts_Addons_ChartSeriesStyling_mvcModel from "./OutSystemsCharts.Addons.ChartSeriesStyling.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_m_Manuals_ManualDetailView_mvcModel from "./ConectaProveedores.m_Manuals.ManualDetailView.mvc$model.js";


class GetManuals2DataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ManualsList", "manualsListOut", "ManualsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_0601d361b69aac23601da3c9e115bec5))());
}, true, (OS$GenericTypeCache.getGenericList(RC_0601d361b69aac23601da3c9e115bec5))), 
this.attr("ShowViewAll", "showViewAllOut", "ShowViewAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetManuals2DataActRec.init();

class GetUserApplicationRolesAndMoreDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("IsCorporativoCxP", "isCorporativoCxPOut", "IsCorporativoCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AppRolesListText", "appRolesListTextOut", "AppRolesListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TelcelDirectionsListText", "telcelDirectionsListTextOut", "TelcelDirectionsListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsAreaCxP", "isAreaCxPOut", "IsAreaCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsActiveDEV_Dashboard", "isActiveDEV_DashboardOut", "IsActiveDEV_Dashboard", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesAndMoreDataActRec.init();

class GetRequisitionsKPIDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_RequisitionCounts", "o_RequisitionCountsOut", "o_RequisitionCounts", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_34313c5cf94d7ce3c5404858c22fafd9Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_34313c5cf94d7ce3c5404858c22fafd9Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetRequisitionsKPIDataActRec(new GetRequisitionsKPIDataActRec.RecordClass({
o_RequisitionCountsOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionsKPIDataActRec.init();

class GetInvoicesKPIDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_InvoiceCounts", "o_InvoiceCountsOut", "o_InvoiceCounts", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_34313c5cf94d7ce3c5404858c22fafd9Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_34313c5cf94d7ce3c5404858c22fafd9Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetInvoicesKPIDataActRec(new GetInvoicesKPIDataActRec.RecordClass({
o_InvoiceCountsOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesKPIDataActRec.init();

class GetFoliosKPIDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_OrderCounts", "o_OrderCountsOut", "o_OrderCounts", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_34313c5cf94d7ce3c5404858c22fafd9Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_34313c5cf94d7ce3c5404858c22fafd9Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetFoliosKPIDataActRec(new GetFoliosKPIDataActRec.RecordClass({
o_OrderCountsOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFoliosKPIDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ShowPopup", "showPopupVar", "ShowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ManualId", "l_ManualIdVar", "l_ManualId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("GetManuals2", "getManuals2DataAct", "GetManuals2", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetManuals2DataActRec());
}, true, GetManuals2DataActRec), 
this.attr("GetUserApplicationRolesAndMore", "getUserApplicationRolesAndMoreDataAct", "GetUserApplicationRolesAndMore", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesAndMoreDataActRec());
}, true, GetUserApplicationRolesAndMoreDataActRec), 
this.attr("GetRequisitionsKPI", "getRequisitionsKPIDataAct", "GetRequisitionsKPI", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionsKPIDataActRec());
}, true, GetRequisitionsKPIDataActRec), 
this.attr("GetInvoicesKPI", "getInvoicesKPIDataAct", "GetInvoicesKPI", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesKPIDataActRec());
}, true, GetInvoicesKPIDataActRec), 
this.attr("GetFoliosKPI", "getFoliosKPIDataAct", "GetFoliosKPI", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFoliosKPIDataActRec());
}, true, GetFoliosKPIDataActRec)
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
Model._hasValidationWidgetsValue = ((((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || OutSystemsCharts_Charts_DonutChart_mvcModel.hasValidationWidgets) || OutSystemsCharts_Addons_ChartLegend_mvcModel.hasValidationWidgets) || OutSystemsCharts_Addons_ChartSeriesStyling_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_m_Manuals_ManualDetailView_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


