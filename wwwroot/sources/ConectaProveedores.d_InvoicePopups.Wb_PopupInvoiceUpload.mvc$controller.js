import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_7837994e68174a4794f15e4233b48555Structure, ST_6dc39d329f4b959722daa75bc2f62c1fStructure, EN_f81a3d226103fd013068b8763798067aEntityRecord, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerUpdateDate$Action as OutSystemsUIController$datePickerUpdateDate$Action } from "./OutSystemsUI.controller.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvc_TranslationsResources from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.mvc$translationsResources.js";
import { ST_ce06f43cf108d98e4f79c0106fcfd0acStructure } from "./Extension.PdfOcrLibrary.model.js";
import { SE_folioStatus as ConectaProveedores_staticEntities_folioStatus, SE_accountingDataType as ConectaProveedores_staticEntities_accountingDataType } from "./ConectaProveedores.staticEntities.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceCreditNoteById$AggrRefresh: 0,
getInvoiceFilesByInvoiceId$AggrRefresh: -1,
getInvoiceExtendedForeignerById$AggrRefresh: 0,
getFolioById$AggrRefresh: 0,
getInvoicesByRequisitionOrFolio$DataActRefresh: 0,
getSupplier$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceCreditNoteById$AggrRefresh: [],
getInvoiceFilesByInvoiceId$AggrRefresh: [],
getInvoiceExtendedForeignerById$AggrRefresh: [],
getFolioById$AggrRefresh: [],
getInvoicesByRequisitionOrFolio$DataActRefresh: [],
getSupplier$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
uploadInvoiceFiles_WithCN$ServerAction(invoiceIdIn, requisitionIdIn, orderMainIdIn, folioIdIn, filesListIn, extraFilesListIn, creditNoteFilesListIn, ignoreCreationIn, invoiceForeignIn, invoicesSumIn, isModifyIn, isStartApprovalIn, accountingDataTypeIdIn, orderAccConceptsIDIn, importAnticipoIn, creditNoteInvoiceIdIn, offsetUtcIn, isConstructionIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadInvoiceFiles_WithCN", function (span) {
if(span) {
span.setAttribute("code.function", "UploadInvoiceFiles_WithCN");
span.setAttribute("outsystems.function.key", "20dcbc9f-dd5c-4e44-9e98-5c8008a9eb3c");
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
CreditNoteFilesList: OS$DataConversion.ServerDataConverter.to(creditNoteFilesListIn, {
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
}),
IsConstruction: OS$DataConversion.ServerDataConverter.to(isConstructionIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UploadInvoiceFiles_WithCN", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ActionUploadInvoiceFiles_WithCN", "y7JWEjq5JhGwZtpAqmxcMA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload$ActionUploadInvoiceFiles_WithCN"))();
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
folioInvoiceUpdate$ServerAction(i_FolioIdIn, i_CommentsIn, filesListExtraIn, filesListIn, creditNoteFilesListIn, invoiceToCreateIn, invoiceForeignToCreateIn, importAnticipoIn, offsetUtcIn, i_UpdateCommentIn, i_HaveNewFilesIn, i_NewFileNamesUploadedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioInvoiceUpdate", function (span) {
if(span) {
span.setAttribute("code.function", "FolioInvoiceUpdate");
span.setAttribute("outsystems.function.key", "7d259969-175b-4999-b864-42022ea3a022");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_Comments: OS$DataConversion.ServerDataConverter.to(i_CommentsIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
FilesListExtra: OS$DataConversion.ServerDataConverter.to(filesListExtraIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
FilesList: OS$DataConversion.ServerDataConverter.to(filesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
CreditNoteFilesList: OS$DataConversion.ServerDataConverter.to(creditNoteFilesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
InvoiceToCreate: OS$DataConversion.ServerDataConverter.to(invoiceToCreateIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
InvoiceForeignToCreate: OS$DataConversion.ServerDataConverter.to(invoiceForeignToCreateIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
ImportAnticipo: OS$DataConversion.ServerDataConverter.to(importAnticipoIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_UpdateComment: OS$DataConversion.ServerDataConverter.to(i_UpdateCommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_HaveNewFiles: OS$DataConversion.ServerDataConverter.to(i_HaveNewFilesIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_NewFileNamesUploaded: OS$DataConversion.ServerDataConverter.to(i_NewFileNamesUploadedIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioInvoiceUpdate", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ActionFolioInvoiceUpdate", "mC9Jp8dzEl_Uf25KbKknwA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload$ActionFolioInvoiceUpdate"))();
executeServerActionResult.errorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMsg, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_FolioNameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_FolioName, OS$DataTypes.DataTypes.Text);
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
return controller.callServerAction("Invoice_OCR", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ActionInvoice_OCR", "l1Z7Ht+TQvOx9ZV7WJjjKA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload$ActionInvoice_OCR"))();
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
get getInvoiceCreditNoteById$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceCreditNoteById$AggrRefresh"))) {
this._getInvoiceCreditNoteById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceCreditNoteById", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ScreenDataSetGetInvoiceCreditNoteById", "TqrLbmxL1WAruqXFcT89tA", maxRecords, startIndex, function (b) {
model.variables.getInvoiceCreditNoteByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceCreditNoteByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceCreditNoteByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getInvoiceCreditNoteByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceCreditNoteById", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCreditNoteById");
span.setAttribute("outsystems.function.key", "15cafe59-16fd-4b06-97d2-7ec6e40762cd");
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

return this._getInvoiceCreditNoteById$AggrRefresh;
}set getInvoiceCreditNoteById$AggrRefresh(value) {this._getInvoiceCreditNoteById$AggrRefresh = value;
}

get getInvoiceFilesByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceFilesByInvoiceId$AggrRefresh"))) {
this._getInvoiceFilesByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceFilesByInvoiceId", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ScreenDataSetGetInvoiceFilesByInvoiceId", "1JqQEdM1RKGps9HKUhRXsg", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "2e719108-7644-447a-923e-34c08cf75058");
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedForeignerById", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ScreenDataSetGetInvoiceExtendedForeignerById", "ekq5PyVYF_WhScHqLpMxWw", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedForeignerByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedForeignerByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedForeignerByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedForeignerById", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedForeignerById");
span.setAttribute("outsystems.function.key", "aa81dcae-d0d8-49d3-92c5-4009239c6fae");
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

get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/ScreenDataSetGetFolioById", "F1H1N5xIqblJLJM64VeI+w", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "d2fca6bf-8bf7-4d93-996c-115dfdb5f50a");
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

return this._getFolioById$AggrRefresh;
}set getFolioById$AggrRefresh(value) {this._getFolioById$AggrRefresh = value;
}

get getInvoicesByRequisitionOrFolio$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoicesByRequisitionOrFolio$DataActRefresh"))) {
this._getInvoicesByRequisitionOrFolio$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoicesByRequisitionOrFolio", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/DataActionGetInvoicesByRequisitionOrFolio", "+5mzVrZaW0x1hOwVdK+6iQ", function (b) {
model.variables.getInvoicesByRequisitionOrFolioDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesByRequisitionOrFolioDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesByRequisitionOrFolioDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesByRequisitionOrFolio", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByRequisitionOrFolio");
span.setAttribute("outsystems.function.key", "b6448e95-648f-4f31-8f9f-e712565c4ca7");
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
return controller.callDataAction("DataActionGetSupplier", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUpload/DataActionGetSupplier", "wqJxT+WzW4R2feMDGrfWXw", function (b) {
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
span.setAttribute("outsystems.function.key", "e6a10248-e8d2-42a1-8ef3-fd103721c792");
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
this._dataFetchActionNames = ["getInvoiceCreditNoteById$AggrRefresh", "getInvoiceFilesByInvoiceId$AggrRefresh", "getInvoiceExtendedForeignerById$AggrRefresh", "getFolioById$AggrRefresh", "getInvoicesByRequisitionOrFolio$DataActRefresh", "getSupplier$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_removeFromList$Action(indexIn, isExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "1119c277-b77a-412a-bf2c-7df7cfe0dd93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
vars.value.isExtraInLocal = isExtraIn;
if((vars.value.isExtraInLocal)) {
// Execute Action: ListRemove2
OS$SystemActions.listRemove(model.variables.extraFilesListVar, vars.value.indexInLocal, callContext);
} else {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
// IsUploadCreditNote = False
model.variables.isUploadCreditNoteVar = false;
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
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
_saveOnClick$Action(isStartApprovalIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "1cd38142-f164-4766-aa19-f26a91843194");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.SaveOnClick$vars"))());
vars.value.isStartApprovalInLocal = isStartApprovalIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var uploadInvoiceFiles_WithCNVar = new OS$DataTypes.VariableHolder();
var folioInvoiceUpdateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// IsExecuting = IsStartApproval
model.variables.isExecutingVar = vars.value.isStartApprovalInLocal;
// IsSaving = notIsStartApproval
model.variables.isSavingVar = (!(vars.value.isStartApprovalInLocal));
return OS$Flow.executeSequence(function () {
if(((!(model.widgets.get(idService.getId("Form")).validAttr)))) {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading8
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
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
// IncorrectInvoice?
return OS$Flow.executeSequence(function () {
if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice))) {
// InvoiceToCreate.OrderAccConceptsID = AccData.OrderAccConceptID
vars.value.invoiceToCreateVar.orderAccConceptsIDAttr = model.variables.accDataVar.orderAccConceptIDAttr;
// Execute Action: FolioInvoiceUpdate
model.flush();
return controller.folioInvoiceUpdate$ServerAction(model.variables.folioIdIn, "", OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.extraFilesListVar, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.nameAttr;
target.binaryDataAttr = source.binaryDataAttr;
target.isExtraAttr = true;
target.storageIdAttr = source.storageIdAttr;
target.fileIdAttr = source.fileIdAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.filesListVar, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.nameAttr;
target.binaryDataAttr = source.binaryDataAttr;
target.isExtraAttr = false;
target.storageIdAttr = source.storageIdAttr;
target.fileIdAttr = source.fileIdAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.creditNoteFilesListVar, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.nameAttr;
target.binaryDataAttr = source.binaryDataAttr;
target.storageIdAttr = source.storageIdAttr;
target.fileIdAttr = source.fileIdAttr;
return target;
}), vars.value.invoiceToCreateVar, model.variables.invoiceForeignVar, model.variables.importAnticipoIn, ConectaProveedoresClientVariables.getOffsetUtc(), "", false, "", callContext).then(function (value) {
folioInvoiceUpdateVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((((folioInvoiceUpdateVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(folioInvoiceUpdateVar.value.errorMsgOut, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// IsUploadCreditNote = FolioInvoiceUpdate.IsMissingCreditNote
model.variables.isUploadCreditNoteVar = folioInvoiceUpdateVar.value.isMissingCreditNoteOut;
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: HideLoading7
ConectaProveedoresController$hideLoading$Action(callContext);
// Success
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isStartApprovalInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Q351gORV1k+TsfzsrQt58g#Message.1934877117.1", "Approval process has began")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Q351gORV1k+TsfzsrQt58g#Message.-490039358.1", "Saved with success"))), /*Success*/ 1);
// Trigger Event: ClosePopup3
return controller.closePopup$Action((folioInvoiceUpdateVar.value.errorMsgOut === ""), folioInvoiceUpdateVar.value.isMissingCreditNoteOut, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
});
}

});
});
} else {
// Execute Action: UploadInvoiceFiles_WithCN
model.flush();
return controller.uploadInvoiceFiles_WithCN$ServerAction(model.variables.invoiceIdIn, model.variables.requisitionIdIn, model.variables.orderIdIn, model.variables.folioIdIn, model.variables.filesListVar, model.variables.extraFilesListVar, model.variables.creditNoteFilesListVar, false, model.variables.invoiceForeignVar, OS$BuiltinFunctions.integerToDecimal(0), false, vars.value.isStartApprovalInLocal, ConectaProveedores_staticEntities_accountingDataType.agreedPayments, model.variables.accDataVar.orderAccConceptIDAttr, model.variables.importAnticipoIn, model.variables.creditNoteInvoiceIdIn, ConectaProveedoresClientVariables.getOffsetUtc(), true, callContext).then(function (value) {
uploadInvoiceFiles_WithCNVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if((((uploadInvoiceFiles_WithCNVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(uploadInvoiceFiles_WithCNVar.value.errorMsgOut, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// missing credit note
return OS$Flow.executeSequence(function () {
if((uploadInvoiceFiles_WithCNVar.value.isMissingCreditNoteOut)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qww4ciJ1dUaYqPRxylPCQw#Message.-1235798656.1", "This request requires a credit note to proceed."), /*Warning*/ 2);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// IsUploadCreditNote = True
model.variables.isUploadCreditNoteVar = true;
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Success
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isStartApprovalInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lS+Y818C+UiFdweDXtCJNg#Message.1934877117.1", "Approval process has began")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lS+Y818C+UiFdweDXtCJNg#Message.-490039358.1", "Saved with success"))), /*Success*/ 1);
// Trigger Event: ClosePopup
return controller.closePopup$Action((uploadInvoiceFiles_WithCNVar.value.errorMsgOut === ""), uploadInvoiceFiles_WithCNVar.value.isMissingCreditNoteOut, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
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
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_PopupInvoiceUpload.SaveOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "d9dd5cd4-a04d-4fc1-82b5-d5652912f165");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ojRGiAxOo0ep9ju9oyV8lA#Message.-892909564.1", "Error while trying to upload invoice. Please try again later"), /*Error*/ 3);
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
_customUploadOnFileChangeCreditNote$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeCreditNote", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeCreditNote");
span.setAttribute("outsystems.function.key", "45a7b2ee-bed9-41dc-a747-c8e154db0408");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CustomUploadOnFileChangeCreditNote");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.CustomUploadOnFileChangeCreditNote$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// ok?
if((vars.value.errorInLocal.successAttr)) {
// exists?
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// Execute Action: ValidationCreditNotes
controller._validationCreditNotes$Action(vars.value.fileInLocal, callContext);
// ok?
if(((model.variables.errorMsgVar === ""))) {
// Execute Action: ListAppendCN
OS$SystemActions.listAppend(model.variables.creditNoteFilesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_7837994e68174a4794f15e4233b48555Structure(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
}), callContext);
// HasChanged = True
model.variables.hasChangedVar = true;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
}

} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("L6SkjfW8G0yRo0aGqTApXA#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
}

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
span.setAttribute("outsystems.function.key", "49c02d0e-69f9-4f28-be6c-d1198eaba3e6");
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
_getSupplierOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierOnAfterFetch");
span.setAttribute("outsystems.function.key", "74ce2fe5-8054-439f-99ce-a228081031e0");
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
_datePickerInvoiceDate$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "849aec7d-b650-4529-bbea-f6637c36a48b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerInvoiceDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.DatePickerInvoiceDate$vars"))());
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
_wb_AccSelectSendOrderAccConcept$Action(oFolioAccDataIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_AccSelectSendOrderAccConcept", function (span) {
if(span) {
span.setAttribute("code.function", "wb_AccSelectSendOrderAccConcept");
span.setAttribute("outsystems.function.key", "9029b1f7-97e1-41eb-ab80-a64de889fe5f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_AccSelectSendOrderAccConcept");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.wb_AccSelectSendOrderAccConcept$vars"))());
vars.value.oFolioAccDataInLocal = oFolioAccDataIn.clone();
// AccData = oFolioAccData
model.variables.accDataVar = vars.value.oFolioAccDataInLocal;
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "99206ce0-1aeb-4d3e-9c90-acd3cf7da92b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationMainXMLPdf");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.ValidationMainXMLPdf$vars"))());
vars.value.fileInLocal = fileIn.clone();
var listFilterFilesVar = new OS$DataTypes.VariableHolder();
var listFilterExistentVar = new OS$DataTypes.VariableHolder();
var listFilterExtraVar = new OS$DataTypes.VariableHolder();
var listFilterCreditNoteVar = new OS$DataTypes.VariableHolder();
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
return ((p.invoiceFileAttr.filenameAttr === vars.value.fileInLocal.fileNameAttr) && !(p.invoiceAttr.idAttr.equals(model.variables.invoiceIdIn)));
}, callContext);

// Execute Action: ListFilterFiles
listFilterFilesVar.value = OS$SystemActions.listFilter(model.variables.filesListVar, function (p) {
return (p.nameAttr === vars.value.fileInLocal.fileNameAttr);
}, callContext);

// Execute Action: ListFilterExtra
listFilterExtraVar.value = OS$SystemActions.listFilter(model.variables.extraFilesListVar, function (p) {
return (p.nameAttr === vars.value.fileInLocal.fileNameAttr);
}, callContext);

// Execute Action: ListFilterCreditNote
listFilterCreditNoteVar.value = OS$SystemActions.listFilter(model.variables.creditNoteFilesListVar, function (p) {
return (p.nameAttr === vars.value.fileInLocal.fileNameAttr);
}, callContext);

// is unique?
if((!(((listFilterExistentVar.value.filteredListOut.isEmpty && listFilterFilesVar.value.filteredListOut.isEmpty) && listFilterExtraVar.value.filteredListOut.isEmpty)))) {
// ErrorMsg = "Invoice number already uploaded"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WpRhaojFEUGXOXKG8uITRg#Value.1039077644.1", "Invoice number already uploaded");
}

} else {
// ErrorMsg = "File names should correspond"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8WbEH2Uj0kSc_m3bjBMifw#Value.-316167296.1", "File names should correspond");
}

} else {
// ErrorMsg = "File name should have only 20 digits"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_EL0QOzqAU+C5M9QKh5snQ#Value.-2043104880.1", "File name should have only 20 digits");
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("U5TVeMBmSECY1Od9lhZ_Fg#Value.-1018373344.1", "Main files should be xml and pdf")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("U5TVeMBmSECY1Od9lhZ_Fg#Value.-704563035.1", "Main file should be pdf")));
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("h_8ko4X1C0a4YdzBEzaUJQ#Value.-451005041.1", "Main files are limited to 2")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("h_8ko4X1C0a4YdzBEzaUJQ#Value.-1983470837.1", "Main file is limited to 1")));
}

} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "9d5aef34-4b75-4eba-8a2f-a7f789fa7842");
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
_validationOtherFiles$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidationOtherFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationOtherFiles");
span.setAttribute("outsystems.function.key", "a0fc22e9-9d30-40be-89d1-2be6188c7577");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationOtherFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.ValidationOtherFiles$vars"))());
vars.value.fileInLocal = fileIn.clone();
var listFilterVar = new OS$DataTypes.VariableHolder();
var listFilter3Var = new OS$DataTypes.VariableHolder();
var listFilter2Var = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.filesListVar, function (p) {
return (vars.value.fileInLocal.fileNameAttr === p.nameAttr);
}, callContext);

// Execute Action: ListFilter2
listFilter2Var.value = OS$SystemActions.listFilter(model.variables.extraFilesListVar, function (p) {
return (vars.value.fileInLocal.fileNameAttr === p.nameAttr);
}, callContext);

// Execute Action: ListFilter3
listFilter3Var.value = OS$SystemActions.listFilter(model.variables.creditNoteFilesListVar, function (p) {
return (vars.value.fileInLocal.fileNameAttr === p.nameAttr);
}, callContext);

// is unique?
if((!((listFilterVar.value.filteredListOut.isEmpty && listFilter2Var.value.filteredListOut.isEmpty)))) {
// ErrorMsg = "This filename already exists for this invoice"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eC4RB0FuyECOfCSwXQqDCw#Value.209850919.1", "This filename already exists for this invoice");
}

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
span.setAttribute("outsystems.function.key", "a4078b30-1a3f-4656-ab51-768b77607990");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
vars.value.isExtraInLocal = isExtraIn;
var invoice_OCRVar = new OS$DataTypes.VariableHolder();
var datePickerUpdateDateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// error?
return OS$Flow.executeSequence(function () {
if(((!(vars.value.errorInLocal.successAttr)))) {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// empty?
return OS$Flow.executeSequence(function () {
if((OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary()))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8J_qCMlKBU6kZazHdgxYSg#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// main file?
if((vars.value.isExtraInLocal)) {
// Execute Action: ValidationOtherFiles
controller._validationOtherFiles$Action(vars.value.fileInLocal, callContext);
} else {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// IsUploadCreditNote = False
model.variables.isUploadCreditNoteVar = false;
// Execute Action: ValidationMainXMLPdf
controller._validationMainXMLPdf$Action(vars.value.fileInLocal, callContext);
}

// error?
return OS$Flow.executeSequence(function () {
if((((model.variables.errorMsgVar) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
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
// main?
if(((!(vars.value.isExtraInLocal)))) {
// Execute Action: ListAppendInvoice
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_7837994e68174a4794f15e4233b48555Structure(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
}), callContext);
} else {
// Execute Action: ListAppendExtra
OS$SystemActions.listAppend(model.variables.extraFilesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_7837994e68174a4794f15e4233b48555Structure(), function (source, target) {
target.invoiceFileIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
}), callContext);
}

// HasChanged = True
model.variables.hasChangedVar = true;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
}

});
}

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
_validationCreditNotes$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidationCreditNotes", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationCreditNotes");
span.setAttribute("outsystems.function.key", "d04be5ac-e7e7-4d6b-a67e-94d3a2fb7498");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationCreditNotes");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.ValidationCreditNotes$vars"))());
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
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("61GN7LVJ_0yJLgVaJ5SddQ#Value.-316167296.1", "File names should correspond");
}

} else {
// ErrorMsg = "File name should have maximum 20 digits"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("xnmuxiI1N06jTzFTfdNRTw#Value.-233626228.1", "File name should have maximum 20 digits");
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kWp0j7OpF021ioJlBllMHw#Value.-1018373344.1", "Main files should be xml and pdf")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kWp0j7OpF021ioJlBllMHw#Value.-704563035.1", "Main file should be pdf")));
}

} else {
// ErrorMsg = If
model.variables.errorMsgVar = ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3Sw1yUPvDUu6FkXduCqdWQ#Value.-451005041.1", "Main files are limited to 2")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3Sw1yUPvDUu6FkXduCqdWQ#Value.-1983470837.1", "Main file is limited to 1")));
}

} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "dbed8a6c-b39e-4cf6-954b-892c6609bd61");
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
_getInvoiceCreditNoteByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceCreditNoteByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCreditNoteByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "dec7e290-4b0f-4e1b-98f6-bf79d04d4d72");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetInvoiceCreditNoteByIdOnAfterFetch");
callContext = controller.callContext(callContext);
// IsUploadCreditNote = notGetInvoiceCreditNoteById.List.Empty
model.variables.isUploadCreditNoteVar = (!(model.variables.getInvoiceCreditNoteByIdAggr.listOut.isEmpty));
// CreditNoteFilesList = GetInvoiceCreditNoteById.List
model.variables.creditNoteFilesListVar = OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceCreditNoteByIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_7837994e68174a4794f15e4233b48555Structure))(), function (source, target) {
target.invoiceFileIdAttr = source.invoiceFileAttr.idAttr;
target.nameAttr = source.invoiceFileAttr.filenameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.storageIdAttr = source.invoiceFileAttr.storageIdAttr;
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
span.setAttribute("outsystems.function.key", "f4cdbb3c-083c-4b16-8eb2-421e0b8e47bf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioById
var result = controller.getFolioById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoiceFilesByInvoiceId
var result = controller.getInvoiceFilesByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceExtendedForeignerById
var result = controller.getInvoiceExtendedForeignerById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceCreditNoteById
var result = controller.getInvoiceCreditNoteById$AggrRefresh(1, 0, callContext);
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

removeFromList$Action(indexIn, isExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "1119c277-b77a-412a-bf2c-7df7cfe0dd93");
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

saveOnClick$Action(isStartApprovalIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "1cd38142-f164-4766-aa19-f26a91843194");
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

customUploadOnFileChangeCreditNote$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeCreditNote__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeCreditNote");
span.setAttribute("outsystems.function.key", "45a7b2ee-bed9-41dc-a747-c8e154db0408");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._customUploadOnFileChangeCreditNote$Action, callContext, fileIn, errorIn);
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
span.setAttribute("outsystems.function.key", "49c02d0e-69f9-4f28-be6c-d1198eaba3e6");
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

getSupplierOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierOnAfterFetch");
span.setAttribute("outsystems.function.key", "74ce2fe5-8054-439f-99ce-a228081031e0");
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

datePickerInvoiceDate$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "849aec7d-b650-4529-bbea-f6637c36a48b");
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

wb_AccSelectSendOrderAccConcept$Action(oFolioAccDataIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_AccSelectSendOrderAccConcept__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_AccSelectSendOrderAccConcept");
span.setAttribute("outsystems.function.key", "9029b1f7-97e1-41eb-ab80-a64de889fe5f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_AccSelectSendOrderAccConcept$Action, callContext, oFolioAccDataIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validationMainXMLPdf$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidationMainXMLPdf__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationMainXMLPdf");
span.setAttribute("outsystems.function.key", "99206ce0-1aeb-4d3e-9c90-acd3cf7da92b");
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

getInvoiceFilesByInvoiceIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceFilesByInvoiceIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesByInvoiceIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "9d5aef34-4b75-4eba-8a2f-a7f789fa7842");
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

validationOtherFiles$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidationOtherFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationOtherFiles");
span.setAttribute("outsystems.function.key", "a0fc22e9-9d30-40be-89d1-2be6188c7577");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validationOtherFiles$Action, callContext, fileIn);
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
span.setAttribute("outsystems.function.key", "a4078b30-1a3f-4656-ab51-768b77607990");
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

validationCreditNotes$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidationCreditNotes__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationCreditNotes");
span.setAttribute("outsystems.function.key", "d04be5ac-e7e7-4d6b-a67e-94d3a2fb7498");
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

onChangeInput$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnChangeInput__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChangeInput");
span.setAttribute("outsystems.function.key", "dbed8a6c-b39e-4cf6-954b-892c6609bd61");
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

getInvoiceCreditNoteByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceCreditNoteByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCreditNoteByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "dec7e290-4b0f-4e1b-98f6-bf79d04d4d72");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getInvoiceCreditNoteByIdOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "f4cdbb3c-083c-4b16-8eb2-421e0b8e47bf");
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload$ActionUploadInvoiceFiles_WithCN", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload$ActionFolioInvoiceUpdate", [{
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_FolioName",
attrName: "o_FolioNameOut",
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload$ActionInvoice_OCR", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.RemoveFromList$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.SaveOnClick$vars", [{
name: "IsStartApproval",
attrName: "isStartApprovalInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "InvoiceToCreate",
attrName: "invoiceToCreateVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.CustomUploadOnFileChangeCreditNote$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.DatePickerInvoiceDate$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.wb_AccSelectSendOrderAccConcept$vars", [{
name: "oFolioAccData",
attrName: "oFolioAccDataInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6dc39d329f4b959722daa75bc2f62c1fStructure();
},
complexType: ST_6dc39d329f4b959722daa75bc2f62c1fStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.ValidationMainXMLPdf$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.ValidationOtherFiles$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.CustomUploadOnFileChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUpload.ValidationCreditNotes$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


