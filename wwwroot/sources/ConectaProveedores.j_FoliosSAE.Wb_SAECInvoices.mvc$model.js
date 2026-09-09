import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_426e2c309e94de792ac54a8e3665e09a, RC_f049d8b2272822e744e04ef94d71a8ef } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvcModel from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.mvc$model.js";

class GetInvoicesByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_426e2c309e94de792ac54a8e3665e09a));
}
static fromStructure(str) {
return new GetInvoicesByFolioIdAggrRec(new GetInvoicesByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesByFolioIdAggrRec.init();

class GetFolioByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f049d8b2272822e744e04ef94d71a8ef));
}
static fromStructure(str) {
return new GetFolioByIdAggrRec(new GetFolioByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_CanUploadInvoice", "l_CanUploadInvoiceVar", "l_CanUploadInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
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
this.attr("l_CreditNoteInvoiceIdToPopup", "l_CreditNoteInvoiceIdToPopupVar", "l_CreditNoteInvoiceIdToPopup", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ImportAnticipo", "l_ImportAnticipoVar", "l_ImportAnticipo", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsReadOnly", "isReadOnlyIn", "IsReadOnly", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isReadOnlyInDataFetchStatus", "_isReadOnlyInDataFetchStatus", "_isReadOnlyInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoicesByFolioId", "getInvoicesByFolioIdAggr", "GetInvoicesByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesByFolioIdAggrRec());
}, true, GetInvoicesByFolioIdAggrRec), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec)
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
Model._hasValidationWidgetsValue = (((ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel.hasValidationWidgets || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvcModel.hasValidationWidgets);
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

if("IsReadOnly" in inputs) {
this.variables.isReadOnlyIn = inputs.IsReadOnly;
if("_isReadOnlyInDataFetchStatus" in inputs) {
this.variables._isReadOnlyInDataFetchStatus = inputs._isReadOnlyInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


