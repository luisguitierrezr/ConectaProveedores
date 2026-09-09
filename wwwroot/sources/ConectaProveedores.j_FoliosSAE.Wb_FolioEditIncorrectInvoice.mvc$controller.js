import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_f81a3d226103fd013068b8763798067aEntityRecord, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure, RC_1c2482ce6cd4b83ca44ec0510b231d44, RC_45d2d2c3c5fe5caa10fa5e20326622ac } from "./ConectaProveedores.model.js";
import { ST_f68ab54e767928bb7cc21e9801e8642bStructure, ST_cbb2055cf19f871ed882642269bd43ceStructure } from "./TelcelIntegrations.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import { SE_currency as ConectaProveedores_staticEntities_currency, SE_folioStatus as ConectaProveedores_staticEntities_folioStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioApprovalRejectReason$AggrRefresh: 0,
getFolioById$AggrRefresh: 0,
getFolioCommentsByFolioId$AggrRefresh: 0,
getFolioItemsByFolioId$AggrRefresh: 0,
getOrderDetail$AggrRefresh: 0,
getFolioObservationsByFolioId$AggrRefresh: 0,
getSettings$DataActRefresh: 0,
getFolioFiles$DataActRefresh: 0,
getOrderMainItems$DataActRefresh: -1,
getSummary$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFolioApprovalRejectReason$AggrRefresh: [],
getFolioById$AggrRefresh: [],
getFolioCommentsByFolioId$AggrRefresh: [],
getFolioItemsByFolioId$AggrRefresh: [],
getOrderDetail$AggrRefresh: [],
getFolioObservationsByFolioId$AggrRefresh: [],
getSettings$DataActRefresh: [],
getFolioFiles$DataActRefresh: [],
getOrderMainItems$DataActRefresh: [],
getSummary$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
call_ZMXMIMMF_VISUALIZAR_SAL_ANT$ServerAction(requestIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Call_ZMXMIMMF_VISUALIZAR_SAL_ANT", function (span) {
if(span) {
span.setAttribute("code.function", "Call_ZMXMIMMF_VISUALIZAR_SAL_ANT");
span.setAttribute("outsystems.function.key", "d68763c3-0573-4d0f-b5af-83de06f6eb6c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Request: OS$DataConversion.ServerDataConverter.to(requestIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Call_ZMXMIMMF_VISUALIZAR_SAL_ANT", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT", "mEDBUNKMySFTPNFDy4Vl+Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT"))();
executeServerActionResult.responseOut = OS$DataConversion.ServerDataConverter.from(outputs.Response, ST_cbb2055cf19f871ed882642269bd43ceStructure);
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
return controller.callServerAction("FolioInvoiceUpdate", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ActionFolioInvoiceUpdate", "mC9Jp8dzEl_Uf25KbKknwA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ActionFolioInvoiceUpdate"))();
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
folioUpdate$ServerAction(folioIDIn, i_SelectedLinesIn, i_OrderMainIdIn, i_CommentsIn, filesListExtraIn, filesListIn, approvalProcessTypeIdIn, constructionDataIn, i_SummaryRecIn, invoiceToCreateIn, invoiceForeignToCreateIn, creditNoteFilesListIn, importAnticipoIn, i_UpdateCommentIn, i_HaveNewFilesIn, i_NewFileNamesUploadedIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioUpdate", function (span) {
if(span) {
span.setAttribute("code.function", "FolioUpdate");
span.setAttribute("outsystems.function.key", "8f2495ab-f11c-477e-89f8-efe24aa1bea3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
FolioID: OS$DataConversion.ServerDataConverter.to(folioIDIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
I_SelectedLines: OS$DataConversion.ServerDataConverter.to(i_SelectedLinesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
I_OrderMainId: OS$DataConversion.ServerDataConverter.to(i_OrderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
I_Comments: OS$DataConversion.ServerDataConverter.to(i_CommentsIn, {
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
ApprovalProcessTypeId: OS$DataConversion.ServerDataConverter.to(approvalProcessTypeIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
ConstructionData: OS$DataConversion.ServerDataConverter.to(constructionDataIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_SummaryRec: OS$DataConversion.ServerDataConverter.to(i_SummaryRecIn, {
dataType: OS$DataTypes.DataTypes.Record,
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
CreditNoteFilesList: OS$DataConversion.ServerDataConverter.to(creditNoteFilesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
ImportAnticipo: OS$DataConversion.ServerDataConverter.to(importAnticipoIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
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
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioUpdate", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ActionFolioUpdate", "Ij3zNtckafeTs_J8EUnUiQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ActionFolioUpdate"))();
executeServerActionResult.o_FolioNameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_FolioName, OS$DataTypes.DataTypes.Text);
executeServerActionResult.errorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMsg, OS$DataTypes.DataTypes.Text);
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
getAllAvailableQuantity$ServerAction(getFolioItemsByFolioId_ListIn, folioIdToExcludeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetAllAvailableQuantity", function (span) {
if(span) {
span.setAttribute("code.function", "GetAllAvailableQuantity");
span.setAttribute("outsystems.function.key", "d8134071-3fee-4b2e-ab4d-7578c106805a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
GetFolioItemsByFolioId_List: OS$DataConversion.ServerDataConverter.to(getFolioItemsByFolioId_ListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
FolioIdToExclude: OS$DataConversion.ServerDataConverter.to(folioIdToExcludeIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetAllAvailableQuantity", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ActionGetAllAvailableQuantity", "P4fB3c4JvQ+qBOZ0I70ViA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ActionGetAllAvailableQuantity"))();
executeServerActionResult.localSelectedLinesOut = OS$DataConversion.ServerDataConverter.from(outputs.LocalSelectedLines, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure)));
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
get getFolioApprovalRejectReason$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioApprovalRejectReason$AggrRefresh"))) {
this._getFolioApprovalRejectReason$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioApprovalRejectReason", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ScreenDataSetGetFolioApprovalRejectReason", "p6xYQLI8Jbh5uMewTpEvGQ", maxRecords, startIndex, function (b) {
model.variables.getFolioApprovalRejectReasonAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioApprovalRejectReasonAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioApprovalRejectReasonAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioApprovalRejectReason", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalRejectReason");
span.setAttribute("outsystems.function.key", "24540022-77b7-4108-8a65-4abb59c7fcbc");
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

return this._getFolioApprovalRejectReason$AggrRefresh;
}set getFolioApprovalRejectReason$AggrRefresh(value) {this._getFolioApprovalRejectReason$AggrRefresh = value;
}

get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ScreenDataSetGetFolioById", "F1H1N5xIqblJLJM64VeI+w", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "2865413f-0d72-44c5-87f7-91dece611d3b");
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

get getFolioCommentsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioCommentsByFolioId$AggrRefresh"))) {
this._getFolioCommentsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioCommentsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ScreenDataSetGetFolioCommentsByFolioId", "s3ajRFHrpTi7XECBOWhi2g", maxRecords, startIndex, function (b) {
model.variables.getFolioCommentsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioCommentsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioCommentsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioCommentsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioCommentsByFolioId");
span.setAttribute("outsystems.function.key", "3265ed63-be98-441e-9dd9-6907f84c12c5");
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

return this._getFolioCommentsByFolioId$AggrRefresh;
}set getFolioCommentsByFolioId$AggrRefresh(value) {this._getFolioCommentsByFolioId$AggrRefresh = value;
}

get getFolioItemsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioItemsByFolioId$AggrRefresh"))) {
this._getFolioItemsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioItemsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ScreenDataSetGetFolioItemsByFolioId", "3hWkR5MZcJ0XElZpxxi9+Q", maxRecords, startIndex, function (b) {
model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioItemsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioItemsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getFolioItemsByFolioIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioItemsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioId");
span.setAttribute("outsystems.function.key", "5a2e9ecd-c44c-4372-9635-9824c9a47163");
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

return this._getFolioItemsByFolioId$AggrRefresh;
}set getFolioItemsByFolioId$AggrRefresh(value) {this._getFolioItemsByFolioId$AggrRefresh = value;
}

get getOrderDetail$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderDetail$AggrRefresh"))) {
this._getOrderDetail$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderDetail", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ScreenDataSetGetOrderDetail", "lpqE3qzMg4wpZUViVv4nAQ", maxRecords, startIndex, function (b) {
model.variables.getOrderDetailAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderDetailAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderDetailAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderDetailOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderDetail", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetail");
span.setAttribute("outsystems.function.key", "6b585d25-b449-4ec2-9b14-281ad463225c");
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

return this._getOrderDetail$AggrRefresh;
}set getOrderDetail$AggrRefresh(value) {this._getOrderDetail$AggrRefresh = value;
}

get getFolioObservationsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioObservationsByFolioId$AggrRefresh"))) {
this._getFolioObservationsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioObservationsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/ScreenDataSetGetFolioObservationsByFolioId", "C87c9qyenMu1E4Gz29W+6A", maxRecords, startIndex, function (b) {
model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioObservationsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioObservationsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioObservationsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioObservationsByFolioId");
span.setAttribute("outsystems.function.key", "e56b6056-f6db-4e8d-9e24-509158241283");
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

return this._getFolioObservationsByFolioId$AggrRefresh;
}set getFolioObservationsByFolioId$AggrRefresh(value) {this._getFolioObservationsByFolioId$AggrRefresh = value;
}

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/DataActionGetSettings", "8PNYPHATyRPMvPRoRC3kYg", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "5b6e4d78-7f20-402c-b4a0-294865300bc9");
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

return this._getSettings$DataActRefresh;
}set getSettings$DataActRefresh(value) {this._getSettings$DataActRefresh = value;
}

get getFolioFiles$DataActRefresh() {if(!(this.hasOwnProperty("_getFolioFiles$DataActRefresh"))) {
this._getFolioFiles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFolioFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/DataActionGetFolioFiles", "eMmOE7OnWf6aMnPicbq0+Q", function (b) {
model.variables.getFolioFilesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioFilesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioFilesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioFiles");
span.setAttribute("outsystems.function.key", "83f941e9-0e9c-4db9-82bb-18b0aba42675");
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

return this._getFolioFiles$DataActRefresh;
}set getFolioFiles$DataActRefresh(value) {this._getFolioFiles$DataActRefresh = value;
}

get getOrderMainItems$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderMainItems$DataActRefresh"))) {
this._getOrderMainItems$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderMainItems", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/DataActionGetOrderMainItems", "nMYKJY2YKAefA8NljSFLTw", function (b) {
model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainItemsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainItemsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderMainItemsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainItems", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItems");
span.setAttribute("outsystems.function.key", "d68c8e82-6b35-4dbf-b085-ecf6fd508b13");
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

return this._getOrderMainItems$DataActRefresh;
}set getOrderMainItems$DataActRefresh(value) {this._getOrderMainItems$DataActRefresh = value;
}

get getSummary$DataActRefresh() {if(!(this.hasOwnProperty("_getSummary$DataActRefresh"))) {
this._getSummary$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSummary", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditIncorrectInvoice/DataActionGetSummary", "8Zn+WqR+1XoWIyMin1R8Vw", function (b) {
model.variables.getSummaryDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSummaryDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSummaryDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSummaryOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSummary", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummary");
span.setAttribute("outsystems.function.key", "ec6b1256-fec2-44b9-b614-21d5bbfc17d8");
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

return this._getSummary$DataActRefresh;
}set getSummary$DataActRefresh(value) {this._getSummary$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioApprovalRejectReason$AggrRefresh", "getFolioById$AggrRefresh", "getFolioCommentsByFolioId$AggrRefresh", "getFolioItemsByFolioId$AggrRefresh", "getOrderDetail$AggrRefresh", "getFolioObservationsByFolioId$AggrRefresh", "getSettings$DataActRefresh", "getFolioFiles$DataActRefresh", "getOrderMainItems$DataActRefresh", "getSummary$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_InvoiceSAECUploadSendFilesCreditNote$Action(o_CreditNoteFilesListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFilesCreditNote", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFilesCreditNote");
span.setAttribute("outsystems.function.key", "37a60632-3578-4492-b500-41b4fd0211ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_InvoiceSAECUploadSendFilesCreditNote");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Wb_InvoiceSAECUploadSendFilesCreditNote$vars"))());
vars.value.o_CreditNoteFilesListInLocal = o_CreditNoteFilesListIn.clone();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.creditNoteFilesListVar, vars.value.o_CreditNoteFilesListInLocal, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderDetailOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderDetailOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetailOnAfterFetch");
span.setAttribute("outsystems.function.key", "42b37447-5a1f-48b2-a6a5-e6dd9dc2da8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderDetailOnAfterFetch");
callContext = controller.callContext(callContext);
var call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: Call_ZMXMIMMF_VISUALIZAR_SAL_ANT
model.flush();
return controller.call_ZMXMIMMF_VISUALIZAR_SAL_ANT$ServerAction(function () {
var rec = new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
rec.pI_PEDIDOAttr = model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr;
return rec;
}(), callContext).then(function (value) {
call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar.value = value;
}).then(function () {
// l_ImportAnticipo = Call_ZMXMIMMF_VISUALIZAR_SAL_ANT.Response.PO_IMP_ANT
model.variables.l_ImportAnticipoVar = call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar.value.responseOut.pO_IMP_ANTAttr;
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
_initialValidate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("InitialValidate", function (span) {
if(span) {
span.setAttribute("code.function", "InitialValidate");
span.setAttribute("outsystems.function.key", "51ee734a-ed0f-4935-9870-0a54cbd1e6ab");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("InitialValidate");
callContext = controller.callContext(callContext);
// WithDatesError = False
model.variables.withDatesErrorVar = false;
// WithQuantityError = False
model.variables.withQuantityErrorVar = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) {
// WithQuantityError = True
model.variables.withQuantityErrorVar = true;
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).deliveryDateAttr.equals(OS$BuiltinFunctions.nullDate()))) {
// WithDatesError = True
model.variables.withDatesErrorVar = true;
// LocalSelectedLines.Current.IsDateError = True
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr = true;
} else {
// LocalSelectedLines.Current.IsDateError = False
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr = false;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_updateFolioOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UpdateFolioOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateFolioOnClick");
span.setAttribute("outsystems.function.key", "52b1bf96-450f-4f4c-a0f0-1a5eaa9d2137");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UpdateFolioOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioInvoiceUpdateVar = new OS$DataTypes.VariableHolder();
var folioUpdateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ValidateFinal
controller._validateFinal$Action(callContext);
// With Validation Error
return OS$Flow.executeSequence(function () {
if((((((model.variables.withFilesErrorVar || model.variables.datesQuantityPEPErrorVar) || model.variables.withDatesErrorVar) || model.variables.withQuantityErrorVar) || model.variables.maxAmountErrorVar))) {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dpndbgHNQ0CKpuuFWmvUSA#Message.-1008290854.1", "It was not possible to create the Folio, please review introduced data"), /*Error*/ 3);
} else {
// IncorrectInvoice
return OS$Flow.executeSequence(function () {
if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice))) {
// InvoiceToCreate.OrderAccConceptsID = OrderAccConceptsIdToCreate
model.variables.invoiceToCreateVar.orderAccConceptsIDAttr = model.variables.orderAccConceptsIdToCreateVar;
// Execute Action: FolioInvoiceUpdate
model.flush();
return controller.folioInvoiceUpdate$ServerAction(model.variables.folioIdIn, model.variables.commentsVar, model.variables.filesListExtraVar, model.variables.filesListVar, model.variables.creditNoteFilesListVar, model.variables.invoiceToCreateVar, model.variables.invoiceForeignToCreateVar, model.variables.l_ImportAnticipoVar, ConectaProveedoresClientVariables.getOffsetUtc(), model.variables.l_IsOpenPopupCommentVar, model.variables.haveNewFilesVar, model.variables.newFileNamesUploadedVar, callContext).then(function (value) {
folioInvoiceUpdateVar.value = value;
}).then(function () {
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
if(((folioInvoiceUpdateVar.value.errorMsgOut === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Nr_AKYglcku_EYlodc_OMg#Message.68060425.1", "Folio") + " ") + folioInvoiceUpdateVar.value.o_FolioNameOut) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Nr_AKYglcku_EYlodc_OMg#Message.166241077.1", "was successfully updated.")), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Proveedor
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Proveedor", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioInvoiceUpdateVar.value.errorMsgOut, /*Error*/ 3);
}

});
} else {
// Execute Action: FolioUpdate
model.flush();
return controller.folioUpdate$ServerAction(model.variables.folioIdIn, model.variables.localSelectedLinesVar, model.variables.i_OrderIdIn, model.variables.commentsVar, model.variables.filesListExtraVar, model.variables.filesListVar, model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr, new RC_1c2482ce6cd4b83ca44ec0510b231d44(), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.l_SummaryRecVar, new RC_45d2d2c3c5fe5caa10fa5e20326622ac(), function (source, target) {
target.amountDeliveredAttr = source.amountDeliveredAttr;
target.amountLeftAttr = source.amountLeftAttr;
target.currencyAttr = source.currencyAttr;
target.difference_FormSAE_Invoice_AmountAttr = source.difference_FormSAE_Invoice_AmountAttr;
target.difference_FormSAE_Invoice_PercentAttr = source.difference_FormSAE_Invoice_PercentAttr;
target.invoicingAmountAttr = source.invoicingAmountAttr;
target.partialDeliveryAmountAttr = source.partialDeliveryAmountAttr;
target.percentageDeliveredAttr = source.percentageDeliveredAttr;
target.totalAmountAttr = source.totalAmountAttr;
return target;
}), model.variables.invoiceToCreateVar, model.variables.invoiceForeignToCreateVar, model.variables.creditNoteFilesListVar, model.variables.l_ImportAnticipoVar, model.variables.l_IsOpenPopupCommentVar, model.variables.haveNewFilesVar, model.variables.newFileNamesUploadedVar, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
folioUpdateVar.value = value;
}).then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
if(((folioUpdateVar.value.errorMsgOut === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YVuWtFnFn0qDn7zCVSH6qQ#Message.68060425.1", "Folio") + " ") + folioUpdateVar.value.o_FolioNameOut) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YVuWtFnFn0qDn7zCVSH6qQ#Message.166241077.1", "was successfully updated.")), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Proveedor
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Proveedor", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioUpdateVar.value.errorMsgOut, /*Error*/ 3);
}

});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioEditIncorrectInvoice.UpdateFolioOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "9ade4722-aff9-498a-87e3-df4fdc2dd16f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
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
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "542f03f9-69d0-44cd-8126-b75718c0d3c9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_InvoiceSAECUploadSendFiles$Action(o_FilesListIn, o_InvoiceIn, o_InvoiceForeignIn, isNationalIn, o_InvoiceExtendedIn, i_IsRemoveIn, o_CreditNoteFilesListIn, o_CreditNoteInvoiceIn, o_NeedsCNIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFiles", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFiles");
span.setAttribute("outsystems.function.key", "546cade2-7082-4012-a3d3-a349a0644893");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_InvoiceSAECUploadSendFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Wb_InvoiceSAECUploadSendFiles$vars"))());
vars.value.o_FilesListInLocal = o_FilesListIn.clone();
vars.value.o_InvoiceInLocal = o_InvoiceIn.clone();
vars.value.o_InvoiceForeignInLocal = o_InvoiceForeignIn.clone();
vars.value.isNationalInLocal = isNationalIn;
vars.value.o_InvoiceExtendedInLocal = o_InvoiceExtendedIn.clone();
vars.value.i_IsRemoveInLocal = i_IsRemoveIn;
vars.value.o_CreditNoteFilesListInLocal = o_CreditNoteFilesListIn.clone();
vars.value.o_CreditNoteInvoiceInLocal = o_CreditNoteInvoiceIn.clone();
vars.value.o_NeedsCNInLocal = o_NeedsCNIn;
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.filesListVar, vars.value.o_FilesListInLocal, callContext);
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// Execute Action: ListAppendAll2
OS$SystemActions.listAppendAll(model.variables.creditNoteFilesListVar, vars.value.o_CreditNoteFilesListInLocal, callContext);
if((!(vars.value.i_IsRemoveInLocal))) {
// InvoiceToCreate = o_Invoice
model.variables.invoiceToCreateVar = vars.value.o_InvoiceInLocal;
// InvoiceForeignToCreate = o_InvoiceForeign
model.variables.invoiceForeignToCreateVar = vars.value.o_InvoiceForeignInLocal;
// L_IsNational = IsNational
model.variables.l_IsNationalVar = vars.value.isNationalInLocal;
// InvoiceExtendedToCreate = o_InvoiceExtended
model.variables.invoiceExtendedToCreateVar = vars.value.o_InvoiceExtendedInLocal;
// CreditNoteInvoiceToCreate = o_CreditNoteInvoice
model.variables.creditNoteInvoiceToCreateVar = vars.value.o_CreditNoteInvoiceInLocal;
// CreditNote_IsNeeded = o_NeedsCN
model.variables.creditNote_IsNeededVar = vars.value.o_NeedsCNInLocal;
// Execute Action: ValidateFiles
controller._validateFiles$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_InvoiceSAECUploadSendInvoiceType$Action(orderAccConceptsID_ToSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendInvoiceType", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendInvoiceType");
span.setAttribute("outsystems.function.key", "7b174434-0d53-4244-887d-3d1f98b0e4cf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_InvoiceSAECUploadSendInvoiceType");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Wb_InvoiceSAECUploadSendInvoiceType$vars"))());
vars.value.orderAccConceptsID_ToSaveInLocal = orderAccConceptsID_ToSaveIn;
// OrderAccConceptsIdToCreate = OrderAccConceptsID_ToSave
model.variables.orderAccConceptsIdToCreateVar = vars.value.orderAccConceptsID_ToSaveInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validateDatesInvoiceQttPEP$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "80367c5e-955d-4577-8ac6-ff0be4ed5801");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateDatesInvoiceQttPEP");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesVar, function (p) {
return ((p.isDateErrorAttr || p.isInvoiceErrorAttr) || p.isPEPErrorAttr);
}, callContext);

// Errors?
if(((!(listFilterVar.value.filteredListOut.isEmpty)))) {
// DatesQuantityPEPError = True
model.variables.datesQuantityPEPErrorVar = true;
} else {
// DatesQuantityPEPError = False
model.variables.datesQuantityPEPErrorVar = false;
}

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
span.setAttribute("outsystems.function.key", "81970efc-8fb0-4070-9fbd-c9741723da40");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// LocalSelectedLines = i_LocalSelectedLines
model.variables.localSelectedLinesVar = model.variables.i_LocalSelectedLinesIn;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.RemainingQttTotal = LocalSelectedLines.Current.RemainingQtt
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr = model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

return OS$Flow.executeSequence(function () {
if((!(true))) {
// Refresh Query: GetOrderMainItems
var result = controller.getOrderMainItems$DataActRefresh(callContext);
model.flush();
return result;
}

}).then(function () {
// Refresh Query: GetOrderDetail
var result = controller.getOrderDetail$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSummary
var result = controller.getSummary$DataActRefresh(callContext);
model.flush();
return result;
});
}).then(function () {
return OS$Flow.executeSequence(function () {
if((!(true))) {
// Refresh Query: GetFolioItemsByFolioId
var result = controller.getFolioItemsByFolioId$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}

});
}).then(function () {
// Refresh Query: GetFolioCommentsByFolioId
var result = controller.getFolioCommentsByFolioId$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetFolioById
var result = controller.getFolioById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetFolioApprovalRejectReason
var result = controller.getFolioApprovalRejectReason$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetFolioFiles
var result = controller.getFolioFiles$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetFolioObservationsByFolioId
var result = controller.getFolioObservationsByFolioId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
});
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
_getFolioItemsByFolioIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioItemsByFolioIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "b80de3c3-519d-4dd9-88c4-3af5e4320620");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetFolioItemsByFolioIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderMainItems
var result = controller.getOrderMainItems$DataActRefresh(callContext);
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
_getOrderMainItemsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "bb03c887-5648-4c56-81cc-6a01360c38ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderMainItemsOnAfterFetch");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderMainItemsOnAfterFetch$vars"))());
var getAllAvailableQuantityVar = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetAllAvailableQuantity
model.flush();
return controller.getAllAvailableQuantity$ServerAction(model.variables.getFolioItemsByFolioIdAggr.listOut, model.variables.folioIdIn, callContext).then(function (value) {
getAllAvailableQuantityVar.value = value;
}).then(function () {
// Action Output
// LocalSelectedLines = GetAllAvailableQuantity.LocalSelectedLines
model.variables.localSelectedLinesVar = getAllAvailableQuantityVar.value.localSelectedLinesOut;
}).then(function () {
if((!(model.variables.i_LocalSelectedLinesIn.isEmpty))) {
// Execute Action: ListClear
OS$SystemActions.listClear(vars.value.localSelectedLinesAuxVar, callContext);
// Foreach i_LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.i_LocalSelectedLinesIn);
try {var i_LocalSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.i_LocalSelectedLinesIn);
var i_LocalSelectedLinesIndex = 0;
while (((i_LocalSelectedLinesIndex < model.variables.i_LocalSelectedLinesIn.length))) {
i_LocalSelectedLinesIterator.currentRowNumber = i_LocalSelectedLinesIndex;
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesVar, function (p) {
return p.orderMainIdAttr.equals(model.variables.i_LocalSelectedLinesIn.getItem(i_LocalSelectedLinesIndex.valueOf()).orderMainIdAttr);
}, callContext);

if((!(listFilterVar.value.filteredListOut.isEmpty))) {
// Execute Action: ListAppend
OS$SystemActions.listAppend(vars.value.localSelectedLinesAuxVar, listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext), callContext);
}

i_LocalSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.i_LocalSelectedLinesIn);
}

// LocalSelectedLines = LocalSelectedLinesAux
model.variables.localSelectedLinesVar = vars.value.localSelectedLinesAuxVar;
}

// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
// Execute Action: InitialValidate
controller._initialValidate$Action(callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_togglePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopup", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "c84ea75b-b29e-40c3-964b-2a791bf9324c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("TogglePopup");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: UpdateFolioOnClick
return controller._updateFolioOnClick$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_validateFinal$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateFinal", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "c9c13fca-bc37-4f0c-8d1d-edcfcaa0ef14");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateFinal");
callContext = controller.callContext(callContext);
// WithDatesError = False
model.variables.withDatesErrorVar = false;
// WithQuantityError = False
model.variables.withQuantityErrorVar = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr)) {
// WithQuantityError = True
model.variables.withQuantityErrorVar = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr)) {
// WithDatesError = True
model.variables.withDatesErrorVar = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// No user
if(((model.variables.firstUserIdentifierVar === OS$BuiltinFunctions.nullTextIdentifier()))) {
// ApproverValid = False
model.variables.approverValidVar = false;
// ApproverErrorMessage = "Select one"
model.variables.approverErrorMessageVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pwgeyxWUGESTNIT1DOlk9w#Value.335965538.1", "Select one");
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_prorate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Prorate", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "cbe7de61-ed27-4973-a956-3086a589833d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Prorate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Prorate$vars"))());
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Total = 0
vars.value.totalVar = OS$BuiltinFunctions.integerToDecimal(0);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Total = Total + LocalSelectedLines.Current.RemainingQttTotal / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
vars.value.totalVar = vars.value.totalVar.plus(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttTotalAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).baseQuantityAttr)).times(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// Perc = l_SummaryRec.PartialDeliveryAmount / Total
vars.value.percVar = model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.div(vars.value.totalVar);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.InvoiceQtt = TextToDecimal
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr.times(vars.value.percVar), 3, ".", ""));
// >0
if((model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// seterror
// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = false;
} else {
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// set IsInvoiceError = false
// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Error?
if(((OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr)).gt(model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr) || OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr)).equals(OS$BuiltinFunctions.integerToDecimal(0))))) {
// setError
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Withprorata = False
model.variables.withprorataVar = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Set Original value
// LocalSelectedLines.Current.RemainingQtt = LocalSelectedLines.Current.RemainingQttTotal
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr = model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

}

// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_calcInvoiceAmount$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CalcInvoiceAmount", function (span) {
if(span) {
span.setAttribute("code.function", "CalcInvoiceAmount");
span.setAttribute("outsystems.function.key", "df5cc775-972a-42be-8eed-3a4899d80b91");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CalcInvoiceAmount");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.CalcInvoiceAmount$vars"))());
// total = 0
// Total = 0.0
vars.value.totalVar = (OS$DataTypes.Decimal.defaultValue);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Total = Total + LocalSelectedLines.Current.InvoiceQtt / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
vars.value.totalVar = vars.value.totalVar.plus(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).baseQuantityAttr)).times(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// l_SummaryRec.InvoicingAmount = TextToDecimal
model.variables.l_SummaryRecVar.invoicingAmountAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(vars.value.totalVar, 2, ".", ""));
// l_SummaryRec.Difference_FormSAE_Invoice_Amount = l_SummaryRec.InvoicingAmount - l_SummaryRec.PartialDeliveryAmount
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr = model.variables.l_SummaryRecVar.invoicingAmountAttr.minus(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr);
// l_SummaryRec.Difference_FormSAE_Invoice_Percent = If
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr = ((model.variables.l_SummaryRecVar.invoicingAmountAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))) ? (OS$BuiltinFunctions.integerToDecimal(0)) : (model.variables.l_SummaryRecVar.invoicingAmountAttr.minus(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr).div(model.variables.l_SummaryRecVar.invoicingAmountAttr).times(OS$BuiltinFunctions.integerToDecimal(100))));
// l_SummaryRec.Difference_FormSAE_Invoice_Percent = TextToDecimal
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr, 2, ".", ""));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSummaryOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSummaryOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummaryOnAfterFetch");
span.setAttribute("outsystems.function.key", "f488d549-6054-4f4a-aed9-1df48365b841");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSummaryOnAfterFetch");
callContext = controller.callContext(callContext);
// l_SummaryRec = GetSummary.o_SummaryRec
model.variables.l_SummaryRecVar = model.variables.getSummaryDataAct.o_SummaryRecOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_input_PartialDeliveryAmountOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "f973aeff-97e4-4c15-a727-3b10062eddb4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_PartialDeliveryAmountOnChange");
callContext = controller.callContext(callContext);
// Smaller then 0?
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.lt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Set Zero
// l_SummaryRec.PartialDeliveryAmount = 0
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.gt(model.variables.l_SummaryRecVar.maxAlowedAttr))) {
// Set Max
// l_SummaryRec.PartialDeliveryAmount = l_SummaryRec.MaxAlowed
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = model.variables.l_SummaryRecVar.maxAlowedAttr;
}

// MaxAmountError = False
model.variables.maxAmountErrorVar = false;
// Input_PartialDeliveryAmount.Valid = True
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validAttr = true;
// Pass Max amount 
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.gt(model.variables.l_SummaryRecVar.totalAmountAttr))) {
// MaxAmountError = True
model.variables.maxAmountErrorVar = true;
// Input_PartialDeliveryAmount.Valid = False
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validAttr = false;
// Input_PartialDeliveryAmount.ValidationMessage = "Value not allowed"
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("p0ljbKrTEUy56aFk80A7GQ#Value.-1625513716.1", "Value not allowed");
}

// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validateFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFiles");
span.setAttribute("outsystems.function.key", "fab5e684-0617-4c9e-898c-c65e7d378e45");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateFiles");
callContext = controller.callContext(callContext);
// 2 Files?
if(((((model.variables.filesListVar.length === 2) && model.variables.l_IsNationalVar) || (model.variables.filesListVar.length === 1)))) {
// WithFilesError = False
model.variables.withFilesErrorVar = false;
// skip
if((!((!(model.variables.getSettingsDataAct.isActiveAmountValidationOut))))) {
if((model.variables.l_IsNationalVar)) {
if(((((model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.currencyIdAttr === ConectaProveedores_staticEntities_currency.mXN)) ? (((model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.minus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.plus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)))))))) : (((model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.minus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.plus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut))))))))))) {
OS$FeedbackMessageService.showFeedbackMessage(((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fncn1fALfki6Jmld6UnJyQ#Message.634980261.1", "The value on the invoice is different from the value on the folio:") + " ") + OS$BuiltinFunctions.formatDecimal(model.variables.invoiceExtendedToCreateVar.subtotalAttr, 2, ".", ",")), /*Error*/ 3);
// WithFilesError = True
model.variables.withFilesErrorVar = true;
}

} else {
// ALIGN
if(((((model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.currencyIdAttr === ConectaProveedores_staticEntities_currency.mXN)) ? (((model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).minus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).plus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)))))))) : (((model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).minus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).plus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut))))))))))) {
OS$FeedbackMessageService.showFeedbackMessage(((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bA0lqnHsS0SAlYD4V3iJBA#Message.634980261.1", "The value on the invoice is different from the value on the folio:") + " ") + model.variables.invoiceForeignToCreateVar.totalAmountAttr), /*Error*/ 3);
// WithFilesError = True
model.variables.withFilesErrorVar = true;
}

}

}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "fcc9c630-6df3-41fd-b94a-5467996d1eb0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
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

wb_InvoiceSAECUploadSendFilesCreditNote$Action(o_CreditNoteFilesListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFilesCreditNote__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFilesCreditNote");
span.setAttribute("outsystems.function.key", "37a60632-3578-4492-b500-41b4fd0211ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_InvoiceSAECUploadSendFilesCreditNote$Action, callContext, o_CreditNoteFilesListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderDetailOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderDetailOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetailOnAfterFetch");
span.setAttribute("outsystems.function.key", "42b37447-5a1f-48b2-a6a5-e6dd9dc2da8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderDetailOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

initialValidate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InitialValidate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitialValidate");
span.setAttribute("outsystems.function.key", "51ee734a-ed0f-4935-9870-0a54cbd1e6ab");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._initialValidate$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

updateFolioOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UpdateFolioOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateFolioOnClick");
span.setAttribute("outsystems.function.key", "52b1bf96-450f-4f4c-a0f0-1a5eaa9d2137");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._updateFolioOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "542f03f9-69d0-44cd-8126-b75718c0d3c9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._tabsOnTabChange$Action, callContext, activeTabIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_InvoiceSAECUploadSendFiles$Action(o_FilesListIn, o_InvoiceIn, o_InvoiceForeignIn, isNationalIn, o_InvoiceExtendedIn, i_IsRemoveIn, o_CreditNoteFilesListIn, o_CreditNoteInvoiceIn, o_NeedsCNIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFiles");
span.setAttribute("outsystems.function.key", "546cade2-7082-4012-a3d3-a349a0644893");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_InvoiceSAECUploadSendFiles$Action, callContext, o_FilesListIn, o_InvoiceIn, o_InvoiceForeignIn, isNationalIn, o_InvoiceExtendedIn, i_IsRemoveIn, o_CreditNoteFilesListIn, o_CreditNoteInvoiceIn, o_NeedsCNIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_InvoiceSAECUploadSendInvoiceType$Action(orderAccConceptsID_ToSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendInvoiceType__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendInvoiceType");
span.setAttribute("outsystems.function.key", "7b174434-0d53-4244-887d-3d1f98b0e4cf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_InvoiceSAECUploadSendInvoiceType$Action, callContext, orderAccConceptsID_ToSaveIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validateDatesInvoiceQttPEP$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "80367c5e-955d-4577-8ac6-ff0be4ed5801");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateDatesInvoiceQttPEP$Action, callContext);
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
span.setAttribute("outsystems.function.key", "81970efc-8fb0-4070-9fbd-c9741723da40");
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

getFolioItemsByFolioIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioItemsByFolioIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "b80de3c3-519d-4dd9-88c4-3af5e4320620");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getFolioItemsByFolioIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getOrderMainItemsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "bb03c887-5648-4c56-81cc-6a01360c38ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderMainItemsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

togglePopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "c84ea75b-b29e-40c3-964b-2a791bf9324c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._togglePopup$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

validateFinal$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateFinal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "c9c13fca-bc37-4f0c-8d1d-edcfcaa0ef14");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateFinal$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

prorate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Prorate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "cbe7de61-ed27-4973-a956-3086a589833d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._prorate$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

calcInvoiceAmount$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CalcInvoiceAmount__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CalcInvoiceAmount");
span.setAttribute("outsystems.function.key", "df5cc775-972a-42be-8eed-3a4899d80b91");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._calcInvoiceAmount$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getSummaryOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSummaryOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummaryOnAfterFetch");
span.setAttribute("outsystems.function.key", "f488d549-6054-4f4a-aed9-1df48365b841");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSummaryOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_PartialDeliveryAmountOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "f973aeff-97e4-4c15-a727-3b10062eddb4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_PartialDeliveryAmountOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validateFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFiles");
span.setAttribute("outsystems.function.key", "fab5e684-0617-4c9e-898c-c65e7d378e45");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateFiles$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "fcc9c630-6df3-41fd-b94a-5467996d1eb0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get goBackToStep1$Action() {if(!(this.hasOwnProperty("_goBackToStep1$Action"))) {
this._goBackToStep1$Action = function () {
return Promise.resolve();
};
}

return this._goBackToStep1$Action;
}set goBackToStep1$Action(value) {this._goBackToStep1$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onInitialize$Action(callContext);

};
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT", [{
name: "Response",
attrName: "responseOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_cbb2055cf19f871ed882642269bd43ceStructure();
},
complexType: ST_cbb2055cf19f871ed882642269bd43ceStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ActionFolioInvoiceUpdate", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ActionFolioUpdate", [{
name: "o_FolioName",
attrName: "o_FolioNameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice$ActionGetAllAvailableQuantity", [{
name: "LocalSelectedLines",
attrName: "localSelectedLinesOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Wb_InvoiceSAECUploadSendFilesCreditNote$vars", [{
name: "o_CreditNoteFilesList",
attrName: "o_CreditNoteFilesListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Wb_InvoiceSAECUploadSendFiles$vars", [{
name: "o_FilesList",
attrName: "o_FilesListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}, {
name: "o_Invoice",
attrName: "o_InvoiceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "o_InvoiceForeign",
attrName: "o_InvoiceForeignInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6f620840109ac6f721328b723ec0152cStructure();
},
complexType: ST_6f620840109ac6f721328b723ec0152cStructure
}, {
name: "IsNational",
attrName: "isNationalInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_InvoiceExtended",
attrName: "o_InvoiceExtendedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_f81a3d226103fd013068b8763798067aEntityRecord();
},
complexType: EN_f81a3d226103fd013068b8763798067aEntityRecord
}, {
name: "i_IsRemove",
attrName: "i_IsRemoveInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_CreditNoteFilesList",
attrName: "o_CreditNoteFilesListInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}, {
name: "o_CreditNoteInvoice",
attrName: "o_CreditNoteInvoiceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "o_NeedsCN",
attrName: "o_NeedsCNInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Wb_InvoiceSAECUploadSendInvoiceType$vars", [{
name: "OrderAccConceptsID_ToSave",
attrName: "orderAccConceptsID_ToSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderMainItemsOnAfterFetch$vars", [{
name: "LocalSelectedLinesAux",
attrName: "localSelectedLinesAuxVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.Prorate$vars", [{
name: "Total",
attrName: "totalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}, {
name: "Perc",
attrName: "percVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.CalcInvoiceAmount$vars", [{
name: "Total",
attrName: "totalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


