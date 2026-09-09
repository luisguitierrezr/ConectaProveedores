import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_7837994e68174a4794f15e4233b48555Structure, ST_f9f8b40f5330871047e55e068d129447Structure, EN_f81a3d226103fd013068b8763798067aEntityRecord } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.mvc$translationsResources.js";
import { ST_ce06f43cf108d98e4f79c0106fcfd0acStructure } from "./Extension.PdfOcrLibrary.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceFiles$AggrRefresh: 0,
getCreditNoteInvoiceFiles$AggrRefresh: -1,
getSupplier$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceFiles$AggrRefresh: ["getCreditNoteInvoiceFiles$AggrRefresh"],
getCreditNoteInvoiceFiles$AggrRefresh: [],
getSupplier$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
uploadInvoiceFiles$ServerAction(invoiceIdIn, requisitionIdIn, orderMainIdIn, folioIdIn, filesListIn, extraFilesListIn, ignoreCreationIn, invoiceForeignIn, invoicesSumIn, isModifyIn, isStartApprovalIn, accountingDataTypeIdIn, orderAccConceptsIDIn, importAnticipoIn, creditNoteInvoiceIdIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "UploadInvoiceFiles");
span.setAttribute("outsystems.function.key", "c2b9d2c3-0183-44c1-bfa5-8f77a41b98d2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
RequisitionId: OS$DataConversion.ServerDataConverter.to(requisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OrderMainId: OS$DataConversion.ServerDataConverter.to(orderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
FolioId: OS$DataConversion.ServerDataConverter.to(folioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
FilesList: OS$DataConversion.ServerDataConverter.to(filesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
ExtraFilesList: OS$DataConversion.ServerDataConverter.to(extraFilesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
IgnoreCreation: OS$DataConversion.ServerDataConverter.to(ignoreCreationIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
InvoiceForeign: OS$DataConversion.ServerDataConverter.to(invoiceForeignIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
InvoicesSum: OS$DataConversion.ServerDataConverter.to(invoicesSumIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
IsModify: OS$DataConversion.ServerDataConverter.to(isModifyIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
IsStartApproval: OS$DataConversion.ServerDataConverter.to(isStartApprovalIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
AccountingDataTypeId: OS$DataConversion.ServerDataConverter.to(accountingDataTypeIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
OrderAccConceptsID: OS$DataConversion.ServerDataConverter.to(orderAccConceptsIDIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
ImportAnticipo: OS$DataConversion.ServerDataConverter.to(importAnticipoIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
CreditNoteInvoiceId: OS$DataConversion.ServerDataConverter.to(creditNoteInvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UploadInvoiceFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_InvoiceSAECUploadUpdate/ActionUploadInvoiceFiles", "N89602WQuvEMIeUa+aj8jw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate$ActionUploadInvoiceFiles"))();
executeServerActionResult.errorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMsg, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_InvoiceOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Invoice, EN_d1d0320db36efbb094ad0082361435a0EntityRecord);
executeServerActionResult.o_InvoiceExtendedOut = OS$DataConversion.ServerDataConverter.from(outputs.o_InvoiceExtended, EN_f81a3d226103fd013068b8763798067aEntityRecord);
executeServerActionResult.claveProdServOut = OS$DataConversion.ServerDataConverter.from(outputs.ClaveProdServ, OS$DataTypes.DataTypes.Text);
executeServerActionResult.tipoComprobanteOut = OS$DataConversion.ServerDataConverter.from(outputs.TipoComprobante, OS$DataTypes.DataTypes.Text);
executeServerActionResult.isMissingCreditNoteOut = OS$DataConversion.ServerDataConverter.from(outputs.IsMissingCreditNote, OS$DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
invoice_OCR$ServerAction(pDFBinaryDataIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Invoice_OCR", function (span) {
if(span) {
span.setAttribute("code.function", "Invoice_OCR");
span.setAttribute("outsystems.function.key", "7fbd75e8-2e1f-438e-aa4f-698c13c4361a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
PDFBinaryData: OS$DataConversion.ServerDataConverter.to(pDFBinaryDataIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Invoice_OCR", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_InvoiceSAECUploadUpdate/ActionInvoice_OCR", "l1Z7Ht+TQvOx9ZV7WJjjKA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate$ActionInvoice_OCR"))();
executeServerActionResult.extractTextOrOcr2Out = OS$DataConversion.ServerDataConverter.from(outputs.ExtractTextOrOcr2, ST_ce06f43cf108d98e4f79c0106fcfd0acStructure);
executeServerActionResult.extractForeignInvoiceDataForUs2Out = OS$DataConversion.ServerDataConverter.from(outputs.ExtractForeignInvoiceDataForUs2, ST_6f620840109ac6f721328b723ec0152cStructure);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;

// Aggregates and Data Actions
get getInvoiceFiles$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceFiles$AggrRefresh"))) {
this._getInvoiceFiles$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_InvoiceSAECUploadUpdate/ScreenDataSetGetInvoiceFiles", "b3oEJAZW2rITZfWrfkdw6g", maxRecords, startIndex, function (b) {
model.variables.getInvoiceFilesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoiceFilesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFiles");
span.setAttribute("outsystems.function.key", "075e6156-9826-41dc-8e4f-9b886d6e778a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_AGGREGATE_CALL");
}

return OS$Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getInvoiceFiles$AggrRefresh;
}set getInvoiceFiles$AggrRefresh(value) {this._getInvoiceFiles$AggrRefresh = value;
}

get getCreditNoteInvoiceFiles$AggrRefresh() {if(!(this.hasOwnProperty("_getCreditNoteInvoiceFiles$AggrRefresh"))) {
this._getCreditNoteInvoiceFiles$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCreditNoteInvoiceFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_InvoiceSAECUploadUpdate/ScreenDataSetGetCreditNoteInvoiceFiles", "wSiP5hTcflX0Ts6ryHi2wQ", maxRecords, startIndex, function (b) {
model.variables.getCreditNoteInvoiceFilesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCreditNoteInvoiceFilesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCreditNoteInvoiceFilesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCreditNoteInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetCreditNoteInvoiceFiles");
span.setAttribute("outsystems.function.key", "78d92338-db93-4dd1-bcb5-f7f1865afa09");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_AGGREGATE_CALL");
}

return OS$Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getCreditNoteInvoiceFiles$AggrRefresh;
}set getCreditNoteInvoiceFiles$AggrRefresh(value) {this._getCreditNoteInvoiceFiles$AggrRefresh = value;
}

get getSupplier$DataActRefresh() {if(!(this.hasOwnProperty("_getSupplier$DataActRefresh"))) {
this._getSupplier$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSupplier", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_InvoiceSAECUploadUpdate/DataActionGetSupplier", "p9ppP8VM7Passk7i7b1W8A", function (b) {
model.variables.getSupplierDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplier", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplier");
span.setAttribute("outsystems.function.key", "0d97e263-8569-46b5-88d2-77cea011c6fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getSupplier$DataActRefresh;
}set getSupplier$DataActRefresh(value) {this._getSupplier$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoiceFiles$AggrRefresh", "getCreditNoteInvoiceFiles$AggrRefresh", "getSupplier$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_datePickerInvoiceDate$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "06110a87-0648-4bfd-a9b7-8976654f231d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerInvoiceDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.DatePickerInvoiceDate$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// InvoiceForeign.InvoiceDate = SelectedDate
model.variables.invoiceForeignVar.invoiceDateAttr = OS$BuiltinFunctions.dateToText(vars.value.selectedDateInLocal);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_calendarClearOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CalendarClearOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarClearOnClick");
span.setAttribute("outsystems.function.key", "1f619af3-0eec-4d0c-a5b8-3bdd60aad070");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CalendarClearOnClick");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerInvoiceDate"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerInvoiceDate"), callContext);

// InvoiceForeign.InvoiceDate = ""
model.variables.invoiceForeignVar.invoiceDateAttr = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validationCreditNotes$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidationCreditNotes", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationCreditNotes");
span.setAttribute("outsystems.function.key", "30fdb6a9-09d4-49ef-9c58-8e3f8424a921");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationCreditNotes");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.ValidationCreditNotes$vars"))());
vars.value.fileInLocal = fileIn.clone();
// 1 national or 0
if(((((model.variables.creditNoteFilesListVar.length < 2) && model.variables.getSupplierDataAct.isNationalOut) || model.variables.creditNoteFilesListVar.isEmpty))) {
// xml national or pdf
if((((vars.value.fileInLocal.fileMimeTypeAttr === "application/pdf") || (((vars.value.fileInLocal.fileMimeTypeAttr === "application/xml") || (vars.value.fileInLocal.fileMimeTypeAttr === "text/xml")) && model.variables.getSupplierDataAct.isNationalOut)))) {
// file name 20?
if(((OS$BuiltinFunctions.length(OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, OS$BuiltinFunctions.index(vars.value.fileInLocal.fileNameAttr, ".", 0, false, false))) <= 20))) {
// same file name?
if((!(((model.variables.creditNoteFilesListVar.length < 1) || (OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, OS$BuiltinFunctions.index(vars.value.fileInLocal.fileNameAttr, ".", 0, false, false)) === OS$BuiltinFunctions.substr(model.variables.creditNoteFilesListVar.getCurrent(callContext.iterationContext).nameAttr, 0, OS$BuiltinFunctions.index(model.variables.creditNoteFilesListVar.getCurrent(callContext.iterationContext).nameAttr, ".", 0, false, false))))))) {
// ErrorMsg = "File names should correspond"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2NyFHxvrDkSYH+bPrMirKA#Value.-316167296.1", "File names should correspond");
}

} else {
// ErrorMsg = "File name should have maximum 20 digits"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zW0PhFOEKkKIooTlzwcgww#Value.-233626228.1", "File name should have maximum 20 digits");
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nUK8ZnivhkSVfvVS5vqv_A#Value.-1018373344.1", "Main files should be xml and pdf")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nUK8ZnivhkSVfvVS5vqv_A#Value.-704563035.1", "Main file should be pdf")));
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BvV_yaUUR0icgeDLRUBrUw#Value.-451005041.1", "Main files are limited to 2")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BvV_yaUUR0icgeDLRUBrUw#Value.-1983470837.1", "Main file is limited to 1")));
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_removeFromList$Action(indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "5df5e179-3c97-4505-810a-369957b8c2ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
// IsUploadCreditNote = False
model.variables.isUploadCreditNoteVar = false;
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// Trigger Event: RemoveFileCreditNote
return controller.removeFileCreditNote$Action(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), callContext).then(function () {
// Trigger Event: RemoveFile
return controller.removeFile$Action(model.variables.filesListVar, callContext);
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_removeFromListCreditNote$Action(indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromListCreditNote", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromListCreditNote");
span.setAttribute("outsystems.function.key", "5e7d01f9-faa4-4c04-82cd-34f26416b68f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveFromListCreditNote");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.RemoveFromListCreditNote$vars"))());
vars.value.indexInLocal = indexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.creditNoteFilesListVar, vars.value.indexInLocal, callContext);
// Trigger Event: RemoveFileCreditNote
return controller.removeFileCreditNote$Action(model.variables.creditNoteFilesListVar, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_validationMainXMLPdf$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidationMainXMLPdf", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationMainXMLPdf");
span.setAttribute("outsystems.function.key", "a538c96b-7e91-4059-95e8-344f7d8da4bc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationMainXMLPdf");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.ValidationMainXMLPdf$vars"))());
vars.value.fileInLocal = fileIn.clone();
// 1 national or 0
if(((((model.variables.filesListVar.length < 2) && model.variables.getSupplierDataAct.isNationalOut) || model.variables.filesListVar.isEmpty))) {
// xml national or pdf
if((((vars.value.fileInLocal.fileMimeTypeAttr === "application/pdf") || (((vars.value.fileInLocal.fileMimeTypeAttr === "application/xml") || (vars.value.fileInLocal.fileMimeTypeAttr === "text/xml")) && model.variables.getSupplierDataAct.isNationalOut)))) {
// file name 20?
if(((OS$BuiltinFunctions.length(OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, OS$BuiltinFunctions.index(vars.value.fileInLocal.fileNameAttr, ".", 0, false, false))) <= 20))) {
// same file name?
if((!(((model.variables.filesListVar.length < 1) || (OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, 11) === OS$BuiltinFunctions.substr(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr, 0, 11)))))) {
// ErrorMsg = "File names should correspond"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wEM7ecfsVk680qEt60ziMg#Value.-316167296.1", "File names should correspond");
}

} else {
// ErrorMsg = "File name should have maximum 20 digits"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZpAQNOwPpUm+ZWd0JG_+hQ#Value.-233626228.1", "File name should have maximum 20 digits");
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kBWCKJvDE0ulFZsaTkXa7w#Value.-1018373344.1", "Main files should be xml and pdf")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kBWCKJvDE0ulFZsaTkXa7w#Value.-704563035.1", "Main file should be pdf")));
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KtZ5OStCVUCHFcqGu_WD3w#Value.-451005041.1", "Main files are limited to 2")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KtZ5OStCVUCHFcqGu_WD3w#Value.-1983470837.1", "Main file is limited to 1")));
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClosePopupForeigner$Action(isSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClosePopupForeigner", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopupForeigner");
span.setAttribute("outsystems.function.key", "bb94ba91-d09f-42c2-b519-b2c7749f1187");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClosePopupForeigner");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.OnClosePopupForeigner$vars"))());
vars.value.isSaveInLocal = isSaveIn;
var uploadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// close
return OS$Flow.executeSequence(function () {
if(((!(vars.value.isSaveInLocal)))) {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// Execute Action: TogglePopupForeigner2
controller._togglePopupForeigner$Action(callContext);
// Trigger Event: SendFiles2
return controller.sendFiles$Action(model.variables.filesListVar, vars.value.emptyInvoiceVar, model.variables.invoiceForeignVar, "", "", new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), false, model.variables.getSupplierDataAct.isNationalOut, callContext).then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: UploadInvoiceFiles
model.flush();
return controller.uploadInvoiceFiles$ServerAction(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), model.variables.orderMainIdIn, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.filesListVar, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.nameAttr;
target.binaryDataAttr = source.binaryDataAttr;
return target;
}), new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), true, model.variables.invoiceForeignVar, OS$BuiltinFunctions.integerToDecimal(0), false, false, 0, OS$DataTypes.LongInteger.defaultValue, model.variables.importAnticipoIn, OS$DataTypes.LongInteger.defaultValue, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadInvoiceFilesVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if((((uploadInvoiceFilesVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(uploadInvoiceFilesVar.value.errorMsgOut, /*Error*/ 3);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: TogglePopupForeigner
controller._togglePopupForeigner$Action(callContext);
// Trigger Event: SendFiles
return controller.sendFiles$Action(model.variables.filesListVar, uploadInvoiceFilesVar.value.o_InvoiceOut, model.variables.invoiceForeignVar, "", "", new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), false, model.variables.getSupplierDataAct.isNationalOut, callContext).then(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
});
}

});
});
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_togglePopupForeigner$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupForeigner", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupForeigner");
span.setAttribute("outsystems.function.key", "bebaec60-aa4f-4c95-8971-ac037005338a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopupForeigner");
callContext = controller.callContext(callContext);
// IsOpenPopupForeigner = notIsOpenPopupForeigner
model.variables.isOpenPopupForeignerVar = (!(model.variables.isOpenPopupForeignerVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "d6b31d65-a92f-4996-8ea1-3f72195454a4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((model.variables.i_IsEnableIn) !== (model.variables.l_IsEnableVar)))) {
// l_IsEnable = i_IsEnable
model.variables.l_IsEnableVar = model.variables.i_IsEnableIn;
} else {
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_getInvoiceFilesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceFilesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesOnAfterFetch");
span.setAttribute("outsystems.function.key", "d6f723be-3b7a-4c9e-af1c-457daedf79ab");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoiceFilesOnAfterFetch");
callContext = controller.callContext(callContext);
var uploadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceFilesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.invoiceFileAttr.filenameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.isExtraAttr = source.invoiceFileAttr.isExtraAttr;
target.storageIdAttr = source.invoiceFileAttr.storageIdAttr;
return target;
}), callContext);
// Execute Action: UploadInvoiceFiles
model.flush();
return controller.uploadInvoiceFiles$ServerAction(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), model.variables.orderMainIdIn, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.filesListVar, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.nameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.storageIdAttr = source.storageIdAttr;
return target;
}), new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), true, model.variables.invoiceForeignVar, OS$BuiltinFunctions.integerToDecimal(0), false, false, 0, OS$DataTypes.LongInteger.defaultValue, OS$DataTypes.Decimal.defaultValue, OS$DataTypes.LongInteger.defaultValue, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadInvoiceFilesVar.value = value;
}).then(function () {
// Refresh Query: GetCreditNoteInvoiceFiles
var result = controller.getCreditNoteInvoiceFiles$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// needs credit note
if((uploadInvoiceFilesVar.value.isMissingCreditNoteOut)) {
// IsUploadCreditNote = True
model.variables.isUploadCreditNoteVar = true;
// Execute Action: ListAppendAll2
OS$SystemActions.listAppendAll(model.variables.creditNoteFilesListVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getCreditNoteInvoiceFilesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.invoiceFileAttr.filenameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.isExtraAttr = source.invoiceFileAttr.isExtraAttr;
target.storageIdAttr = source.invoiceFileAttr.storageIdAttr;
return target;
}), callContext);
}

// Trigger Event: SendFiles
return controller.sendFiles$Action(model.variables.filesListVar, uploadInvoiceFilesVar.value.o_InvoiceOut, new ST_6f620840109ac6f721328b723ec0152cStructure(), "", uploadInvoiceFilesVar.value.tipoComprobanteOut, model.variables.creditNoteFilesListVar, model.variables.getCreditNoteInvoiceFilesAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr, uploadInvoiceFilesVar.value.isMissingCreditNoteOut, model.variables.getSupplierDataAct.isNationalOut, callContext);
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_customUploadOnFileChangeCreditNote$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeCreditNote", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeCreditNote");
span.setAttribute("outsystems.function.key", "f03b0350-267a-48c6-b467-7407ede4076c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChangeCreditNote");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.CustomUploadOnFileChangeCreditNote$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
var uploadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// Execute Action: ValidationCreditNotes
controller._validationCreditNotes$Action(vars.value.fileInLocal, callContext);
// ok?
return OS$Flow.executeSequence(function () {
if(((model.variables.errorMsgVar === ""))) {
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.creditNoteFilesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.isExtraAttr = false;
return target;
}), callContext);
// 1 file
return OS$Flow.executeSequence(function () {
if(((model.variables.creditNoteFilesListVar.length < 2))) {
// Execute Action: HideLoading7
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: UploadInvoiceFiles
model.flush();
return controller.uploadInvoiceFiles$ServerAction(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), model.variables.orderMainIdIn, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.creditNoteFilesListVar, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.nameAttr;
target.binaryDataAttr = source.binaryDataAttr;
return target;
}), new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), true, model.variables.invoiceForeignVar, OS$BuiltinFunctions.integerToDecimal(0), false, false, 0, OS$DataTypes.LongInteger.defaultValue, OS$DataTypes.Decimal.defaultValue, OS$DataTypes.LongInteger.defaultValue, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadInvoiceFilesVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if((((uploadInvoiceFilesVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(uploadInvoiceFilesVar.value.errorMsgOut, /*Error*/ 3);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Trigger Event: SendFiles
return controller.sendFiles$Action(model.variables.filesListVar, model.variables.toStore_InvoiceVar, model.variables.invoiceForeignVar, model.variables.toStore_ClaveProdServVar, model.variables.toStore_TipoDeComprobanteVar, model.variables.creditNoteFilesListVar, uploadInvoiceFilesVar.value.o_InvoiceOut, true, model.variables.getSupplierDataAct.isNationalOut, callContext).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
}

});
});
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FjKR+YH7_EG2xhrs8LRqnw#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "fcf7ad5f-8d33-422a-b425-1954b677f9ca");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
var uploadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
var invoice_OCRVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// IsUploadCreditNote = False
model.variables.isUploadCreditNoteVar = false;
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// Execute Action: ValidationMainXMLPdf
controller._validationMainXMLPdf$Action(vars.value.fileInLocal, callContext);
// ok?
return OS$Flow.executeSequence(function () {
if(((model.variables.errorMsgVar === ""))) {
// foreigner?
return OS$Flow.executeSequence(function () {
if(((!(model.variables.getSupplierDataAct.isNationalOut)))) {
// Execute Action: Invoice_OCR
model.flush();
return controller.invoice_OCR$ServerAction(vars.value.fileInLocal.fileContentAttr, callContext).then(function (value) {
invoice_OCRVar.value = value;
}).then(function () {
// InvoiceForeign = Invoice_OCR.ExtractForeignInvoiceDataForUs2
model.variables.invoiceForeignVar = invoice_OCRVar.value.extractForeignInvoiceDataForUs2Out;
// Execute Action: ListAppend3
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.isExtraAttr = false;
return target;
}), callContext);
// Execute Action: TogglePopupForeigner
controller._togglePopupForeigner$Action(callContext);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.isExtraAttr = false;
return target;
}), callContext);
// 1 file
return OS$Flow.executeSequence(function () {
if(((model.variables.filesListVar.length < 2))) {
// Execute Action: HideLoading7
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: UploadInvoiceFiles
model.flush();
return controller.uploadInvoiceFiles$ServerAction(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), model.variables.orderMainIdIn, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.filesListVar, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.nameAttr;
target.binaryDataAttr = source.binaryDataAttr;
return target;
}), new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), true, model.variables.invoiceForeignVar, OS$BuiltinFunctions.integerToDecimal(0), false, false, 0, OS$DataTypes.LongInteger.defaultValue, model.variables.importAnticipoIn, OS$DataTypes.LongInteger.defaultValue, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadInvoiceFilesVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if((((uploadInvoiceFilesVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(uploadInvoiceFilesVar.value.errorMsgOut, /*Error*/ 3);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// missing credit note
return OS$Flow.executeSequence(function () {
if((uploadInvoiceFilesVar.value.isMissingCreditNoteOut)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hXyKoH8k8k+Bh+GKLABtJg#Message.-1235798656.1", "This request requires a credit note to proceed."), /*Warning*/ 2);
// IsUploadCreditNote = True
model.variables.isUploadCreditNoteVar = true;
// ToStore_Invoice = UploadInvoiceFiles.o_Invoice
model.variables.toStore_InvoiceVar = uploadInvoiceFilesVar.value.o_InvoiceOut;
// ToStore_ClaveProdServ = UploadInvoiceFiles.ClaveProdServ
model.variables.toStore_ClaveProdServVar = uploadInvoiceFilesVar.value.claveProdServOut;
// ToStore_TipoDeComprobante = UploadInvoiceFiles.TipoComprobante
model.variables.toStore_TipoDeComprobanteVar = uploadInvoiceFilesVar.value.tipoComprobanteOut;
// Execute Action: HideLoading8
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Trigger Event: SendFiles
return controller.sendFiles$Action(model.variables.filesListVar, uploadInvoiceFilesVar.value.o_InvoiceOut, new ST_6f620840109ac6f721328b723ec0152cStructure(), uploadInvoiceFilesVar.value.claveProdServOut, uploadInvoiceFilesVar.value.tipoComprobanteOut, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), false, model.variables.getSupplierDataAct.isNationalOut, callContext).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
}

});
}

});
});
}

});
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("icooO63kjUKpH8qHqU7yOg#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;

datePickerInvoiceDate$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "06110a87-0648-4bfd-a9b7-8976654f231d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerInvoiceDate$Action, callContext, selectedDateIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

calendarClearOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CalendarClearOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarClearOnClick");
span.setAttribute("outsystems.function.key", "1f619af3-0eec-4d0c-a5b8-3bdd60aad070");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._calendarClearOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validationCreditNotes$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidationCreditNotes__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationCreditNotes");
span.setAttribute("outsystems.function.key", "30fdb6a9-09d4-49ef-9c58-8e3f8424a921");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validationCreditNotes$Action, callContext, fileIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeFromList$Action(indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "5df5e179-3c97-4505-810a-369957b8c2ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, indexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

removeFromListCreditNote$Action(indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromListCreditNote__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromListCreditNote");
span.setAttribute("outsystems.function.key", "5e7d01f9-faa4-4c04-82cd-34f26416b68f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeFromListCreditNote$Action, callContext, indexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

validationMainXMLPdf$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidationMainXMLPdf__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationMainXMLPdf");
span.setAttribute("outsystems.function.key", "a538c96b-7e91-4059-95e8-344f7d8da4bc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validationMainXMLPdf$Action, callContext, fileIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClosePopupForeigner$Action(isSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClosePopupForeigner__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopupForeigner");
span.setAttribute("outsystems.function.key", "bb94ba91-d09f-42c2-b519-b2c7749f1187");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClosePopupForeigner$Action, callContext, isSaveIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

togglePopupForeigner$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupForeigner__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupForeigner");
span.setAttribute("outsystems.function.key", "bebaec60-aa4f-4c95-8971-ac037005338a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopupForeigner$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "d6b31d65-a92f-4996-8ea1-3f72195454a4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getInvoiceFilesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceFilesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesOnAfterFetch");
span.setAttribute("outsystems.function.key", "d6f723be-3b7a-4c9e-af1c-457daedf79ab");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoiceFilesOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

customUploadOnFileChangeCreditNote$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeCreditNote__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeCreditNote");
span.setAttribute("outsystems.function.key", "f03b0350-267a-48c6-b467-7407ede4076c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChangeCreditNote$Action, callContext, fileIn, errorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "fcf7ad5f-8d33-422a-b425-1954b677f9ca");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChange$Action, callContext, fileIn, errorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get removeFileCreditNote$Action() {if(!(this.hasOwnProperty("_removeFileCreditNote$Action"))) {
this._removeFileCreditNote$Action = function () {
return Promise.resolve();
};
}

return this._removeFileCreditNote$Action;
}set removeFileCreditNote$Action(value) {this._removeFileCreditNote$Action = value;
}

get sendFiles$Action() {if(!(this.hasOwnProperty("_sendFiles$Action"))) {
this._sendFiles$Action = function () {
return Promise.resolve();
};
}

return this._sendFiles$Action;
}set sendFiles$Action(value) {this._sendFiles$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = null;
}

return this._onReadyEventHandler;
}set onReadyEventHandler(value) {this._onReadyEventHandler = value;
}

get onRenderEventHandler() {if(!(this.hasOwnProperty("_onRenderEventHandler"))) {
this._onRenderEventHandler = null;
}

return this._onRenderEventHandler;
}set onRenderEventHandler(value) {this._onRenderEventHandler = value;
}

get onDestroyEventHandler() {if(!(this.hasOwnProperty("_onDestroyEventHandler"))) {
this._onDestroyEventHandler = null;
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onParametersChanged$Action(callContext);

};
}

return this._onParametersChangedEventHandler;
}set onParametersChangedEventHandler(value) {this._onParametersChangedEventHandler = value;
}

// Sync Event Handler Actions
get onSyncStartEventHandler() {if(!(this.hasOwnProperty("_onSyncStartEventHandler"))) {
this._onSyncStartEventHandler = null;
}

return this._onSyncStartEventHandler;
}set onSyncStartEventHandler(value) {this._onSyncStartEventHandler = value;
}

get onSyncCompleteEventHandler() {if(!(this.hasOwnProperty("_onSyncCompleteEventHandler"))) {
this._onSyncCompleteEventHandler = null;
}

return this._onSyncCompleteEventHandler;
}set onSyncCompleteEventHandler(value) {this._onSyncCompleteEventHandler = value;
}

get onSyncErrorEventHandler() {if(!(this.hasOwnProperty("_onSyncErrorEventHandler"))) {
this._onSyncErrorEventHandler = null;
}

return this._onSyncErrorEventHandler;
}set onSyncErrorEventHandler(value) {this._onSyncErrorEventHandler = value;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex) {
return controller.handleError(ex);
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate$ActionUploadInvoiceFiles", [{
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_Invoice",
attrName: "o_InvoiceOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "o_InvoiceExtended",
attrName: "o_InvoiceExtendedOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_f81a3d226103fd013068b8763798067aEntityRecord();
},
complexType: EN_f81a3d226103fd013068b8763798067aEntityRecord
}, {
name: "ClaveProdServ",
attrName: "claveProdServOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "TipoComprobante",
attrName: "tipoComprobanteOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsMissingCreditNote",
attrName: "isMissingCreditNoteOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate$ActionInvoice_OCR", [{
name: "ExtractTextOrOcr2",
attrName: "extractTextOrOcr2Out",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();
},
complexType: ST_ce06f43cf108d98e4f79c0106fcfd0acStructure
}, {
name: "ExtractForeignInvoiceDataForUs2",
attrName: "extractForeignInvoiceDataForUs2Out",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6f620840109ac6f721328b723ec0152cStructure();
},
complexType: ST_6f620840109ac6f721328b723ec0152cStructure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.DatePickerInvoiceDate$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.ValidationCreditNotes$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.RemoveFromListCreditNote$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.ValidationMainXMLPdf$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.OnClosePopupForeigner$vars", [{
name: "IsSave",
attrName: "isSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "EmptyInvoice",
attrName: "emptyInvoiceVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.CustomUploadOnFileChangeCreditNote$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}, {
name: "Error",
attrName: "errorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
},
complexType: ST_f9f8b40f5330871047e55e068d129447Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.CustomUploadOnFileChange$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}, {
name: "Error",
attrName: "errorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
},
complexType: ST_f9f8b40f5330871047e55e068d129447Structure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


