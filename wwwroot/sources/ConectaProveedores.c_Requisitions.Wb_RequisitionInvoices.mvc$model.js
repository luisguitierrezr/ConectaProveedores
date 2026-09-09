import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_0034cf2433ba52d290961e6b42045a29 } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvcModel from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.mvc$model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_mvcModel from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.mvc$model.js";

class GetInvoicesByRequisitionIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_0034cf2433ba52d290961e6b42045a29));
}
static fromStructure(str) {
return new GetInvoicesByRequisitionIdAggrRec(new GetInvoicesByRequisitionIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesByRequisitionIdAggrRec.init();


class GetRequisitionDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("AdvWithoutInvoice", "advWithoutInvoiceOut", "AdvWithoutInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("AllowMultiUpload", "allowMultiUploadOut", "AllowMultiUpload", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("WasAdvWithoutInvoice", "wasAdvWithoutInvoiceOut", "WasAdvWithoutInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("CostCenterSAPId", "costCenterSAPIdOut", "CostCenterSAPId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("CurrencyId", "currencyIdOut", "CurrencyId", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("DivisionFI", "divisionFIOut", "DivisionFI", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Project", "projectOut", "Project", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("PaymentMethodsId", "paymentMethodsIdOut", "PaymentMethodsId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("PaymentTermsId", "paymentTermsIdOut", "PaymentTermsId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("SupplierNr", "supplierNrOut", "SupplierNr", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("TotalAmount", "totalAmountOut", "TotalAmount", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetRequisitionDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_CanUploadInvoice", "l_CanUploadInvoiceVar", "l_CanUploadInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsOpenPopupInvoices", "l_IsOpenPopupInvoicesVar", "l_IsOpenPopupInvoices", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_InvoiceIdToPopup", "l_InvoiceIdToPopupVar", "l_InvoiceIdToPopup", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_InvoiceStatusIdToPopup", "l_InvoiceStatusIdToPopupVar", "l_InvoiceStatusIdToPopup", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_IsOpenPopupMultiupload", "l_IsOpenPopupMultiuploadVar", "l_IsOpenPopupMultiupload", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoicesByRequisitionId", "getInvoicesByRequisitionIdAggr", "GetInvoicesByRequisitionId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesByRequisitionIdAggrRec());
}, true, GetInvoicesByRequisitionIdAggrRec), 
this.attr("GetRequisitionData", "getRequisitionDataDataAct", "GetRequisitionData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionDataDataActRec());
}, true, GetRequisitionDataDataActRec)
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
Model._hasValidationWidgetsValue = ((((ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel.hasValidationWidgets || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvcModel.hasValidationWidgets) || ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = inputs.i_RequisitionId;
if("_i_RequisitionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionIdInDataFetchStatus = inputs._i_RequisitionIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


