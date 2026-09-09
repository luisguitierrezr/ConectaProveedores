import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { hideLoading$Action as ConectaProveedoresController$hideLoading$Action, showLoading$Action as ConectaProveedoresController$showLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_7837994e68174a4794f15e4233b48555Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_f81a3d226103fd013068b8763798067aEntityRecord } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerUpdateDate$Action as OutSystemsUIController$datePickerUpdateDate$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvc_TranslationsResources from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.mvc$translationsResources.js";
import { ST_ce06f43cf108d98e4f79c0106fcfd0acStructure } from "./Extension.PdfOcrLibrary.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceFilesByInvoiceId$AggrRefresh: -1,
getInvoiceExtendedForeignerById$AggrRefresh: 0,
getInvoicesByRequisitionOrFolio$DataActRefresh: 0,
getSupplier$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceFilesByInvoiceId$AggrRefresh: [],
getInvoiceExtendedForeignerById$AggrRefresh: [],
getInvoicesByRequisitionOrFolio$DataActRefresh: [],
getSupplier$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("Invoice_OCR", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles/ActionInvoice_OCR", "l1Z7Ht+TQvOx9ZV7WJjjKA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles$ActionInvoice_OCR"))();
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
return controller.callServerAction("UploadInvoiceFiles", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles/ActionUploadInvoiceFiles", "N89602WQuvEMIeUa+aj8jw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles$ActionUploadInvoiceFiles"))();
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

// Aggregates and Data Actions
get getInvoiceFilesByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceFilesByInvoiceId$AggrRefresh"))) {
this._getInvoiceFilesByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceFilesByInvoiceId", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles/ScreenDataSetGetInvoiceFilesByInvoiceId", "1JqQEdM1RKGps9HKUhRXsg", maxRecords, startIndex, function (b) {
model.variables.getInvoiceFilesByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getInvoiceFilesByInvoiceIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFilesByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesByInvoiceId");
span.setAttribute("outsystems.function.key", "6b5a5759-6c0e-4c86-b2a6-dd2b808a525b");
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

return this._getInvoiceFilesByInvoiceId$AggrRefresh;
}set getInvoiceFilesByInvoiceId$AggrRefresh(value) {this._getInvoiceFilesByInvoiceId$AggrRefresh = value;
}

get getInvoiceExtendedForeignerById$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedForeignerById$AggrRefresh"))) {
this._getInvoiceExtendedForeignerById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedForeignerById", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles/ScreenDataSetGetInvoiceExtendedForeignerById", "ekq5PyVYF_WhScHqLpMxWw", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedForeignerByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedForeignerByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedForeignerByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedForeignerById", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedForeignerById");
span.setAttribute("outsystems.function.key", "e7b45bac-aedc-47c3-968e-53e7bd55df74");
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

return this._getInvoiceExtendedForeignerById$AggrRefresh;
}set getInvoiceExtendedForeignerById$AggrRefresh(value) {this._getInvoiceExtendedForeignerById$AggrRefresh = value;
}

get getInvoicesByRequisitionOrFolio$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoicesByRequisitionOrFolio$DataActRefresh"))) {
this._getInvoicesByRequisitionOrFolio$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoicesByRequisitionOrFolio", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles/DataActionGetInvoicesByRequisitionOrFolio", "VuADNACJ3oYtFrJeKCow8Q", function (b) {
model.variables.getInvoicesByRequisitionOrFolioDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesByRequisitionOrFolioDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesByRequisitionOrFolioDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesByRequisitionOrFolio", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByRequisitionOrFolio");
span.setAttribute("outsystems.function.key", "6d385976-3e43-4781-b18e-b270c69c284f");
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

return this._getInvoicesByRequisitionOrFolio$DataActRefresh;
}set getInvoicesByRequisitionOrFolio$DataActRefresh(value) {this._getInvoicesByRequisitionOrFolio$DataActRefresh = value;
}

get getSupplier$DataActRefresh() {if(!(this.hasOwnProperty("_getSupplier$DataActRefresh"))) {
this._getSupplier$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSupplier", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadBigFiles/DataActionGetSupplier", "wqJxT+WzW4R2feMDGrfWXw", function (b) {
model.variables.getSupplierDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSupplierOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplier", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplier");
span.setAttribute("outsystems.function.key", "ef5c2e14-d501-4fee-988e-94ac1355f602");
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
this._dataFetchActionNames = ["getInvoiceFilesByInvoiceId$AggrRefresh", "getInvoiceExtendedForeignerById$AggrRefresh", "getInvoicesByRequisitionOrFolio$DataActRefresh", "getSupplier$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_BigUploadMultipleFilesEventEndProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventEndProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventEndProcess");
span.setAttribute("outsystems.function.key", "01e8fb11-2f10-4bc9-97c0-8810c8634eae");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesEventEndProcess");
callContext = controller.callContext(callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_customUploadOnFileChange$Action(fileIn, errorIn, isExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "0c18dca1-6628-4301-bb79-645939765b08");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
vars.value.isExtraInLocal = isExtraIn;
var invoice_OCRVar = new OS$DataTypes.VariableHolder();
var datePickerUpdateDateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if(((OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary()) && vars.value.fileInLocal.fileBigFileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("thlkXis9z0yfLtTkrKiQyA#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// extra?
if((!(vars.value.isExtraInLocal))) {
// Execute Action: ValidationMainXMLPdf
controller._validationMainXMLPdf$Action(vars.value.fileInLocal, callContext);
}

// ok?
return OS$Flow.executeSequence(function () {
if(((model.variables.errorMsgVar === ""))) {
// foreigner mainpdf?
return OS$Flow.executeSequence(function () {
if((((!(vars.value.isExtraInLocal)) && (!(model.variables.getSupplierDataAct.isNationalOut))))) {
// Execute Action: Invoice_OCR
model.flush();
return controller.invoice_OCR$ServerAction(vars.value.fileInLocal.fileContentAttr, callContext).then(function (value) {
invoice_OCRVar.value = value;
}).then(function () {
// InvoiceForeign = Invoice_OCR.ExtractForeignInvoiceDataForUs2
model.variables.invoiceForeignVar = invoice_OCRVar.value.extractForeignInvoiceDataForUs2Out;
// IsShowForeignInvoice = True
model.variables.isShowForeignInvoiceVar = true;
// Execute Action: DatePickerUpdateDate
datePickerUpdateDateVar.value = OutSystemsUIController$datePickerUpdateDate$Action(idService.getId("DatePickerInvoiceDate"), OS$BuiltinFunctions.textToDate(invoice_OCRVar.value.extractForeignInvoiceDataForUs2Out.invoiceDateAttr), callContext);

});
}

}).then(function () {
// extra?
if((!(vars.value.isExtraInLocal))) {
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_7837994e68174a4794f15e4233b48555Structure(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
}), callContext);
}

// HasChanged = True
model.variables.hasChangedVar = true;
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
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
_onChangeInput$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnChangeInput", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeInput");
span.setAttribute("outsystems.function.key", "256955f9-6f9f-427f-ad09-42459b824f36");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnChangeInput");
callContext = controller.callContext(callContext);
// HasChanged = True
model.variables.hasChangedVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadMultipleFilesEventstartProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventstartProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventstartProcess");
span.setAttribute("outsystems.function.key", "476291a5-66ab-4ef3-9e1b-4328eb34807c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesEventstartProcess");
callContext = controller.callContext(callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_customUploadOnFileChangeBigFile$Action(fileIn, errorIn, isExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeBigFile", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeBigFile");
span.setAttribute("outsystems.function.key", "746c5daa-d2ef-4908-935f-86656dc8038d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChangeBigFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.CustomUploadOnFileChangeBigFile$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
vars.value.isExtraInLocal = isExtraIn;
var invoice_OCRVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if(((OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary()) && vars.value.fileInLocal.fileBigFileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IgTTpQQ4I0KaqF7AtkbjPg#Message.875725967.1", "Empty file"), /*Error*/ 3);
} else {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// extra?
if((!(vars.value.isExtraInLocal))) {
// Execute Action: ValidationMainXMLPdf
controller._validationMainXMLPdf$Action(vars.value.fileInLocal, callContext);
}

// ok?
return OS$Flow.executeSequence(function () {
if(((model.variables.errorMsgVar === ""))) {
// foreigner mainpdf?
return OS$Flow.executeSequence(function () {
if((((!(vars.value.isExtraInLocal)) && (!(model.variables.getSupplierDataAct.isNationalOut))))) {
// Execute Action: Invoice_OCR
model.flush();
return controller.invoice_OCR$ServerAction(vars.value.fileInLocal.fileContentAttr, callContext).then(function (value) {
invoice_OCRVar.value = value;
}).then(function () {
// InvoiceForeign = Invoice_OCR.ExtractForeignInvoiceDataForUs2
model.variables.invoiceForeignVar = invoice_OCRVar.value.extractForeignInvoiceDataForUs2Out;
// IsShowForeignInvoice = True
model.variables.isShowForeignInvoiceVar = true;
});
}

}).then(function () {
// extra?
if((!(vars.value.isExtraInLocal))) {
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_7837994e68174a4794f15e4233b48555Structure(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
}), callContext);
}

// HasChanged = True
model.variables.hasChangedVar = true;
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
}

});
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
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
_validationMainXMLPdf$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidationMainXMLPdf", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationMainXMLPdf");
span.setAttribute("outsystems.function.key", "8eded4bb-2599-4bfc-ba14-e08394aab57e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationMainXMLPdf");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.ValidationMainXMLPdf$vars"))());
vars.value.fileInLocal = fileIn.clone();
var listFilterFilesVar = new OS$DataTypes.VariableHolder();
var listFilterExtraVar = new OS$DataTypes.VariableHolder();
var listFilterExistentVar = new OS$DataTypes.VariableHolder();
// 1 national or 0
if(((((model.variables.filesListVar.length < 2) && model.variables.getSupplierDataAct.isNationalOut) || model.variables.filesListVar.isEmpty))) {
// xml national or pdf
if((((vars.value.fileInLocal.fileMimeTypeAttr === "application/pdf") || (((vars.value.fileInLocal.fileMimeTypeAttr === "application/xml") || (vars.value.fileInLocal.fileMimeTypeAttr === "text/xml")) && model.variables.getSupplierDataAct.isNationalOut)))) {
// file name 20?
if(((OS$BuiltinFunctions.length(OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, OS$BuiltinFunctions.index(vars.value.fileInLocal.fileNameAttr, ".", 0, false, false))) <= 20))) {
// same file name?
if((((model.variables.filesListVar.length < 1) || (OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, OS$BuiltinFunctions.index(vars.value.fileInLocal.fileNameAttr, ".", 0, false, false)) === OS$BuiltinFunctions.substr(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr, 0, OS$BuiltinFunctions.index(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr, ".", 0, false, false)))))) {
// Execute Action: ListFilterExistent
listFilterExistentVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesByRequisitionOrFolioDataAct.invoicesListOut, function (p) {
return (p.nameAttr === OS$BuiltinFunctions.substr(vars.value.fileInLocal.fileNameAttr, 0, OS$BuiltinFunctions.index(vars.value.fileInLocal.fileNameAttr, ".", 0, false, false)));
}, callContext);

// Execute Action: ListFilterFiles
listFilterFilesVar.value = OS$SystemActions.listFilter(model.variables.filesListVar, function (p) {
return (p.nameAttr === vars.value.fileInLocal.fileNameAttr);
}, callContext);

// Execute Action: ListFilterExtra
listFilterExtraVar.value = OS$SystemActions.listFilter(model.variables.extraFilesListVar, function (p) {
return (p.nameAttr === vars.value.fileInLocal.fileNameAttr);
}, callContext);

// is unique?
if((!(((listFilterExistentVar.value.filteredListOut.isEmpty && listFilterFilesVar.value.filteredListOut.isEmpty) && listFilterExtraVar.value.filteredListOut.isEmpty)))) {
// ErrorMsg = "Invoice number already uploaded"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IX8f_rPyCEeOZmSlc5IyvA#Value.1039077644.1", "Invoice number already uploaded");
}

} else {
// ErrorMsg = "File names should correspond"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2wC4_j0e802b4rpIWX4u_A#Value.-316167296.1", "File names should correspond");
}

} else {
// ErrorMsg = "File name should have only 20 digits"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YcLVwEfZcUmJGkjLOi17Ow#Value.-2043104880.1", "File name should have only 20 digits");
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bhxVO5UHAkWc0hLfJRKn3A#Value.-1018373344.1", "Main files should be xml and pdf")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bhxVO5UHAkWc0hLfJRKn3A#Value.-704563035.1", "Main file should be pdf")));
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8OkLQXsxJkGFfIrEfa5TQA#Value.-451005041.1", "Main files are limited to 2")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8OkLQXsxJkGFfIrEfa5TQA#Value.-1983470837.1", "Main file is limited to 1")));
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSupplierOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierOnAfterFetch");
span.setAttribute("outsystems.function.key", "901a1d77-f476-4fe7-b6ef-599e2c2291a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSupplierOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceFilesByInvoiceId
var result = controller.getInvoiceFilesByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_saveOnClick$Action(isStartApprovalIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "bb28872f-1fd3-4ab3-b4cb-684963e70975");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.SaveOnClick$vars"))());
vars.value.isStartApprovalInLocal = isStartApprovalIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var uploadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// IsExecuting = IsStartApproval
model.variables.isExecutingVar = vars.value.isStartApprovalInLocal;
// IsSaving = notIsStartApproval
model.variables.isSavingVar = (!(vars.value.isStartApprovalInLocal));
// no change
return OS$Flow.executeSequence(function () {
if((((!(model.variables.hasChangedVar)) && (!(vars.value.isStartApprovalInLocal))))) {
// Trigger Event: ClosePopup2
return controller.closePopup$Action(false, false, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
// Execute Action: UploadInvoiceFiles
model.flush();
return controller.uploadInvoiceFiles$ServerAction(model.variables.invoiceIdIn, model.variables.requisitionIdIn, OS$DataTypes.LongInteger.defaultValue, model.variables.folioIdIn, model.variables.filesListVar, model.variables.extraFilesListVar, false, model.variables.invoiceForeignVar, model.variables.getInvoicesByRequisitionOrFolioDataAct.invoicesSumOut, false, vars.value.isStartApprovalInLocal, 0, OS$DataTypes.LongInteger.defaultValue, OS$DataTypes.Decimal.defaultValue, OS$DataTypes.LongInteger.defaultValue, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadInvoiceFilesVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if((((uploadInvoiceFilesVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(uploadInvoiceFilesVar.value.errorMsgOut, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Success
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isStartApprovalInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("E2xmkNSDb0Ohrsx1Oe1X6w#Message.1934877117.1", "Approval process has began")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("E2xmkNSDb0Ohrsx1Oe1X6w#Message.-490039358.1", "Saved with success"))), /*Success*/ 1);
// Trigger Event: ClosePopup
return controller.closePopup$Action((uploadInvoiceFilesVar.value.errorMsgOut === ""), uploadInvoiceFilesVar.value.isMissingCreditNoteOut, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
});
}

});
});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_PopupInvoiceUploadBigFiles.SaveOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "45b02338-e520-45a6-b691-522a60b68f7b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("uV2fn_KnkEWBF6Wrp+pLAg#Message.-1931461179.1", "Error while trying to upload invoice. Please verify your file or try again later"), /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_getInvoiceFilesByInvoiceIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceFilesByInvoiceIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesByInvoiceIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "bd460b61-5f17-4741-95ac-4c4ec75eb398");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetInvoiceFilesByInvoiceIdOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilterExtraVar = new OS$DataTypes.VariableHolder();
var listFilterMainVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilterMain
listFilterMainVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesByInvoiceIdAggr.listOut, function (p) {
return (!(p.invoiceFileAttr.isExtraAttr));
}, callContext);

// Execute Action: ListFilterExtra
listFilterExtraVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesByInvoiceIdAggr.listOut, function (p) {
return p.invoiceFileAttr.isExtraAttr;
}, callContext);

// FilesList = ListFilterMain.FilteredList
model.variables.filesListVar = OS$DataConversion.JSConversions.typeConvertRecordList(listFilterMainVar.value.filteredListOut, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = source.invoiceFileAttr.idAttr;
target.nameAttr = source.invoiceFileAttr.filenameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.storageIdAttr = source.invoiceFileAttr.storageIdAttr;
return target;
});
// ExtraFilesList = ListFilterExtra.FilteredList
model.variables.extraFilesListVar = OS$DataConversion.JSConversions.typeConvertRecordList(listFilterExtraVar.value.filteredListOut, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = source.invoiceFileAttr.idAttr;
target.nameAttr = source.invoiceFileAttr.filenameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.storageIdAttr = source.invoiceFileAttr.storageIdAttr;
return target;
});
// IsLoading = False
model.variables.isLoadingVar = false;
// IsShowForeignInvoice = If
model.variables.isShowForeignInvoiceVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (false) : ((!(listFilterMainVar.value.filteredListOut.isEmpty))));
// InvoiceForeign = GetInvoiceExtendedForeignerById.List.Current
model.variables.invoiceForeignVar = OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getInvoiceExtendedForeignerByIdAggr.listOut.getCurrent(callContext.iterationContext), new ST_6f620840109ac6f721328b723ec0152cStructure(), function (source, target) {
target.invoiceNumberAttr = source.invoiceExtendedForeignerAttr.invoiceNumberAttr;
target.supplierNameAttr = source.invoiceExtendedForeignerAttr.issuerSocialReasonAttr;
target.supplierTaxIdAttr = source.invoiceExtendedForeignerAttr.issuerTaxIdAttr;
target.invoiceDateAttr = OS$BuiltinFunctions.dateToText(source.invoiceExtendedForeignerAttr.invoiceDateAttr);
target.totalAmountAttr = OS$BuiltinFunctions.decimalToText(source.invoiceExtendedForeignerAttr.totalAmountAttr);
target.currencyAttr = source.invoiceExtendedForeignerAttr.currencyAttr;
target.customerNameDetectedAttr = source.invoiceExtendedForeignerAttr.receiverSocialReasonAttr;
target.customerTaxIdDetectedAttr = source.invoiceExtendedForeignerAttr.receiverRFCAttr;
target.customerAddressDetectedAttr = source.invoiceExtendedForeignerAttr.directionAttr;
return target;
});
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
span.setAttribute("outsystems.function.key", "d535a7bf-51e2-47f3-9b79-a7d49b08a621");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceFilesByInvoiceId
var result = controller.getInvoiceFilesByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoiceExtendedForeignerById
var result = controller.getInvoiceExtendedForeignerById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
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
_calendarClearOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CalendarClearOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarClearOnClick");
span.setAttribute("outsystems.function.key", "deaff741-73ec-4d31-9d45-a690164c04ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CalendarClearOnClick");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
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
_datePickerInvoiceDate$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "e37d5fc7-7365-4a97-84ee-d87fa6bc01c5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerInvoiceDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.DatePickerInvoiceDate$vars"))());
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
_wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesNotifyFileId", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesNotifyFileId");
span.setAttribute("outsystems.function.key", "ecb47999-88f3-4776-b587-d7f0d655b81c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("wb_BigUploadMultipleFilesNotifyFileId");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.wb_BigUploadMultipleFilesNotifyFileId$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.filenameInLocal = filenameIn;
vars.value.mimeTypeInLocal = mimeTypeIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.extraFilesListVar, function () {
var rec = new ST_7837994e68174a4794f15e4233b48555Structure();
rec.nameAttr = vars.value.filenameInLocal;
rec.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
rec.fileIdAttr = OS$BuiltinFunctions.longIntegerToIdentifier(vars.value.fileIdInLocal);
return rec;
}(), callContext);
// Execute Action: CustomUploadOnFileChangeBigFile
return controller._customUploadOnFileChangeBigFile$Action(function () {
var rec = new ST_1d6498da9105fbe815a7f766352917c0Structure();
rec.fileNameAttr = vars.value.filenameInLocal;
rec.fileMimeTypeAttr = vars.value.mimeTypeInLocal;
rec.fileBigFileIdAttr = vars.value.fileIdInLocal;
return rec;
}(), function () {
var rec = new ST_f9f8b40f5330871047e55e068d129447Structure();
rec.successAttr = true;
return rec;
}(), true, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_removeFromList$Action(indexIn, isExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "f886ae06-5a32-4e36-89b5-cdca96f89d21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
vars.value.isExtraInLocal = isExtraIn;
if((vars.value.isExtraInLocal)) {
// Execute Action: ListRemove2
OS$SystemActions.listRemove(model.variables.extraFilesListVar, vars.value.indexInLocal, callContext);
} else {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
}

// HasChanged = True
model.variables.hasChangedVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

wb_BigUploadMultipleFilesEventEndProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventEndProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventEndProcess");
span.setAttribute("outsystems.function.key", "01e8fb11-2f10-4bc9-97c0-8810c8634eae");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesEventEndProcess$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

customUploadOnFileChange$Action(fileIn, errorIn, isExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "0c18dca1-6628-4301-bb79-645939765b08");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChange$Action, callContext, fileIn, errorIn, isExtraIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onChangeInput$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnChangeInput__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeInput");
span.setAttribute("outsystems.function.key", "256955f9-6f9f-427f-ad09-42459b824f36");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onChangeInput$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadMultipleFilesEventstartProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventstartProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventstartProcess");
span.setAttribute("outsystems.function.key", "476291a5-66ab-4ef3-9e1b-4328eb34807c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesEventstartProcess$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

customUploadOnFileChangeBigFile$Action(fileIn, errorIn, isExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeBigFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeBigFile");
span.setAttribute("outsystems.function.key", "746c5daa-d2ef-4908-935f-86656dc8038d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChangeBigFile$Action, callContext, fileIn, errorIn, isExtraIn);
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
span.setAttribute("outsystems.function.key", "8eded4bb-2599-4bfc-ba14-e08394aab57e");
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

getSupplierOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierOnAfterFetch");
span.setAttribute("outsystems.function.key", "901a1d77-f476-4fe7-b6ef-599e2c2291a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSupplierOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

saveOnClick$Action(isStartApprovalIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "bb28872f-1fd3-4ab3-b4cb-684963e70975");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveOnClick$Action, callContext, isStartApprovalIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getInvoiceFilesByInvoiceIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceFilesByInvoiceIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesByInvoiceIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "bd460b61-5f17-4741-95ac-4c4ec75eb398");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getInvoiceFilesByInvoiceIdOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "d535a7bf-51e2-47f3-9b79-a7d49b08a621");
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

calendarClearOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CalendarClearOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CalendarClearOnClick");
span.setAttribute("outsystems.function.key", "deaff741-73ec-4d31-9d45-a690164c04ac");
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

datePickerInvoiceDate$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "e37d5fc7-7365-4a97-84ee-d87fa6bc01c5");
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

wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesNotifyFileId__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesNotifyFileId");
span.setAttribute("outsystems.function.key", "ecb47999-88f3-4776-b587-d7f0d655b81c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesNotifyFileId$Action, callContext, fileIdIn, filenameIn, mimeTypeIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

removeFromList$Action(indexIn, isExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "f886ae06-5a32-4e36-89b5-cdca96f89d21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, indexIn, isExtraIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get closePopup$Action() {if(!(this.hasOwnProperty("_closePopup$Action"))) {
this._closePopup$Action = function () {
return Promise.resolve();
};
}

return this._closePopup$Action;
}set closePopup$Action(value) {this._closePopup$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles$ActionInvoice_OCR", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles$ActionUploadInvoiceFiles", [{
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.CustomUploadOnFileChange$vars", [{
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
}, {
name: "IsExtra",
attrName: "isExtraInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.CustomUploadOnFileChangeBigFile$vars", [{
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
}, {
name: "IsExtra",
attrName: "isExtraInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.ValidationMainXMLPdf$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.SaveOnClick$vars", [{
name: "IsStartApproval",
attrName: "isStartApprovalInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.DatePickerInvoiceDate$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.wb_BigUploadMultipleFilesNotifyFileId$vars", [{
name: "FileId",
attrName: "fileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "Filename",
attrName: "filenameInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "MimeType",
attrName: "mimeTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "IsExtra",
attrName: "isExtraInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


