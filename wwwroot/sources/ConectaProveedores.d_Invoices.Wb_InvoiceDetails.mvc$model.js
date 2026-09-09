import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_8675220d3fe960c67254ae28d587388e, EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord, RC_f925a49e2decb9ca9ea463dccae74847, RC_2c7478516bbd3eed6a35183496a9f500, EN_a9440c310249b67518f0615139b4c690EntityRecord, RC_eac76b624d2264108f6fbeb95d9d43ba } from "./ConectaProveedores.model.js";
import OutSystemsUI_Adaptive_Columns3_mvcModel from "./OutSystemsUI.Adaptive.Columns3.mvc$model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";
import OutSystemsUI_Content_Accordion_mvcModel from "./OutSystemsUI.Content.Accordion.mvc$model.js";
import OutSystemsUI_Content_AccordionItem_mvcModel from "./OutSystemsUI.Content.AccordionItem.mvc$model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvcModel from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceCancel.mvc$model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvcModel from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceModify.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvcModel from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$model.js";

class GetInvoiceExtendedMoreChargesTotalAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_8675220d3fe960c67254ae28d587388e));
}
static fromStructure(str) {
return new GetInvoiceExtendedMoreChargesTotalAggrRec(new GetInvoiceExtendedMoreChargesTotalAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedMoreChargesTotalAggrRec.init();

class GetInvoiceExtendedRelationsByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord, {
name: "InvoiceExtendedRelations",
attrName: "invoiceExtendedRelationsAttr",
nameForJson: "InvoiceExtendedRelations",
uniqueId: "759c053a-d9cf-faec-26c5-9da8e40042d4"
}))));
}
static fromStructure(str) {
return new GetInvoiceExtendedRelationsByInvoiceIdAggrRec(new GetInvoiceExtendedRelationsByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedRelationsByInvoiceIdAggrRec.init();

class GetInvoiceAccountingByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f925a49e2decb9ca9ea463dccae74847));
}
static fromStructure(str) {
return new GetInvoiceAccountingByInvoiceIdAggrRec(new GetInvoiceAccountingByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceAccountingByInvoiceIdAggrRec.init();

class GetInvoiceExtendedByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2c7478516bbd3eed6a35183496a9f500));
}
static fromStructure(str) {
return new GetInvoiceExtendedByIdAggrRec(new GetInvoiceExtendedByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedByIdAggrRec.init();

class GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a9440c310249b67518f0615139b4c690EntityRecord, {
name: "InvoiceExtendedMoreCharges",
attrName: "invoiceExtendedMoreChargesAttr",
nameForJson: "InvoiceExtendedMoreCharges",
uniqueId: "152a5bcd-bf97-0bfb-a2a0-da40766a2168"
}))));
}
static fromStructure(str) {
return new GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec(new GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec.init();

class GetInvoiceApprovalAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_eac76b624d2264108f6fbeb95d9d43ba));
}
static fromStructure(str) {
return new GetInvoiceApprovalAggrRec(new GetInvoiceApprovalAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceApprovalAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsBusy", "l_IsBusyVar", "l_IsBusy", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowCancelPopup", "l_ShowCancelPopupVar", "l_ShowCancelPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowModifyPopup", "l_ShowModifyPopupVar", "l_ShowModifyPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowApproveInvoice", "l_ShowApproveInvoiceVar", "l_ShowApproveInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
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
this.attr("IsActiveUser", "isActiveUserIn", "IsActiveUser", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isActiveUserInDataFetchStatus", "_isActiveUserInDataFetchStatus", "_isActiveUserInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceExtendedMoreChargesTotal", "getInvoiceExtendedMoreChargesTotalAggr", "GetInvoiceExtendedMoreChargesTotal", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedMoreChargesTotalAggrRec());
}, true, GetInvoiceExtendedMoreChargesTotalAggrRec), 
this.attr("GetInvoiceExtendedRelationsByInvoiceId", "getInvoiceExtendedRelationsByInvoiceIdAggr", "GetInvoiceExtendedRelationsByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedRelationsByInvoiceIdAggrRec());
}, true, GetInvoiceExtendedRelationsByInvoiceIdAggrRec), 
this.attr("GetInvoiceAccountingByInvoiceId", "getInvoiceAccountingByInvoiceIdAggr", "GetInvoiceAccountingByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceAccountingByInvoiceIdAggrRec());
}, true, GetInvoiceAccountingByInvoiceIdAggrRec), 
this.attr("GetInvoiceExtendedById", "getInvoiceExtendedByIdAggr", "GetInvoiceExtendedById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedByIdAggrRec());
}, true, GetInvoiceExtendedByIdAggrRec), 
this.attr("GetInvoiceExtendedMoreChargesByInvoiceId", "getInvoiceExtendedMoreChargesByInvoiceIdAggr", "GetInvoiceExtendedMoreChargesByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec());
}, true, GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec), 
this.attr("GetInvoiceApproval", "getInvoiceApprovalAggr", "GetInvoiceApproval", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceApprovalAggrRec());
}, true, GetInvoiceApprovalAggrRec)
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
Model._hasValidationWidgetsValue = (((((((OutSystemsUI_Adaptive_Columns3_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Accordion_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_AccordionItem_mvcModel.hasValidationWidgets) || ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceCancel_mvcModel.hasValidationWidgets) || ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceModify_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_PopupApprove_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_InvoiceId" in inputs) {
this.variables.i_InvoiceIdIn = inputs.i_InvoiceId;
if("_i_InvoiceIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceIdInDataFetchStatus = inputs._i_InvoiceIdInDataFetchStatus;
}

}

if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = inputs.i_RequisitionId;
if("_i_RequisitionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionIdInDataFetchStatus = inputs._i_RequisitionIdInDataFetchStatus;
}

}

if("IsActiveUser" in inputs) {
this.variables.isActiveUserIn = inputs.IsActiveUser;
if("_isActiveUserInDataFetchStatus" in inputs) {
this.variables._isActiveUserInDataFetchStatus = inputs._isActiveUserInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


