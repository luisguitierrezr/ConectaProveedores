import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, RC_1c2482ce6cd4b83ca44ec0510b231d44, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure, RC_45d2d2c3c5fe5caa10fa5e20326622ac, EN_d1d0320db36efbb094ad0082361435a0EntityRecord } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.mvc$translationsResources.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioCommentsByFolioId$AggrRefresh: 0,
getFolioObservationsByFolioId$AggrRefresh: 0,
getOrderDetail$AggrRefresh: 0,
getApprovalList$AggrRefresh: -1,
getFolioExtendedById$AggrRefresh: 0,
getFolioItemsByFolioId$AggrRefresh: 0,
getFolioById$AggrRefresh: 0,
getOrderMainItems$DataActRefresh: -1,
getMinutes$DataActRefresh: 0,
getSummary$DataActRefresh: 0,
getMinutesDocuments$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getFolioCommentsByFolioId$AggrRefresh: [],
getFolioObservationsByFolioId$AggrRefresh: [],
getOrderDetail$AggrRefresh: ["getApprovalList$AggrRefresh"],
getApprovalList$AggrRefresh: [],
getFolioExtendedById$AggrRefresh: [],
getFolioItemsByFolioId$AggrRefresh: [],
getFolioById$AggrRefresh: [],
getOrderMainItems$DataActRefresh: [],
getMinutes$DataActRefresh: [],
getSummary$DataActRefresh: [],
getMinutesDocuments$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("FolioUpdate", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ActionFolioUpdate", "Ij3zNtckafeTs_J8EUnUiQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction$ActionFolioUpdate"))();
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
return controller.callServerAction("GetAllAvailableQuantity", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ActionGetAllAvailableQuantity", "P4fB3c4JvQ+qBOZ0I70ViA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction$ActionGetAllAvailableQuantity"))();
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
get getFolioCommentsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioCommentsByFolioId$AggrRefresh"))) {
this._getFolioCommentsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioCommentsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetFolioCommentsByFolioId", "s3ajRFHrpTi7XECBOWhi2g", maxRecords, startIndex, function (b) {
model.variables.getFolioCommentsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioCommentsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioCommentsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioCommentsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioCommentsByFolioId");
span.setAttribute("outsystems.function.key", "1167a0ad-7433-4da3-9eb0-d7bdbffa2e70");
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

get getFolioObservationsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioObservationsByFolioId$AggrRefresh"))) {
this._getFolioObservationsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioObservationsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetFolioObservationsByFolioId", "C87c9qyenMu1E4Gz29W+6A", maxRecords, startIndex, function (b) {
model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioObservationsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioObservationsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioObservationsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioObservationsByFolioId");
span.setAttribute("outsystems.function.key", "37ff60c0-1cb1-47dd-acc0-3a0870ce3be1");
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

get getOrderDetail$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderDetail$AggrRefresh"))) {
this._getOrderDetail$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderDetail", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetOrderDetail", "lpqE3qzMg4wpZUViVv4nAQ", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "3e6b3599-9083-4b38-8613-982132d1fc62");
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

get getApprovalList$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalList$AggrRefresh"))) {
this._getApprovalList$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalList", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetApprovalList", "CWF6QlHhyibTL8RCKRx_rA", maxRecords, startIndex, function (b) {
model.variables.getApprovalListAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalListAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalListAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalList", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalList");
span.setAttribute("outsystems.function.key", "67e673c7-2c27-41b2-bef0-358dd5a0069a");
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

return this._getApprovalList$AggrRefresh;
}set getApprovalList$AggrRefresh(value) {this._getApprovalList$AggrRefresh = value;
}

get getFolioExtendedById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioExtendedById$AggrRefresh"))) {
this._getFolioExtendedById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioExtendedById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetFolioExtendedById", "vkikiwe+v8n4xIKFXajsnQ", maxRecords, startIndex, function (b) {
model.variables.getFolioExtendedByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioExtendedByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioExtendedByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getFolioExtendedByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioExtendedById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioExtendedById");
span.setAttribute("outsystems.function.key", "6bd3806a-c97e-4c9b-b577-acb555f15ee9");
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

return this._getFolioExtendedById$AggrRefresh;
}set getFolioExtendedById$AggrRefresh(value) {this._getFolioExtendedById$AggrRefresh = value;
}

get getFolioItemsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioItemsByFolioId$AggrRefresh"))) {
this._getFolioItemsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioItemsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetFolioItemsByFolioId", "3hWkR5MZcJ0XElZpxxi9+Q", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "b91e840f-c2da-4f44-bda2-0ea1db176631");
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

get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/ScreenDataSetGetFolioById", "F1H1N5xIqblJLJM64VeI+w", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getFolioById2OnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "ec4563c2-32fd-4c8b-b824-3bfd63f8c6cc");
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

get getOrderMainItems$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderMainItems$DataActRefresh"))) {
this._getOrderMainItems$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderMainItems", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/DataActionGetOrderMainItems", "nMYKJY2YKAefA8NljSFLTw", function (b) {
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
span.setAttribute("outsystems.function.key", "66b7f5a9-361b-4218-ad92-2e1476635c62");
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

get getMinutes$DataActRefresh() {if(!(this.hasOwnProperty("_getMinutes$DataActRefresh"))) {
this._getMinutes$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetMinutes", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/DataActionGetMinutes", "PnK76lq1cA_f5rDsb9jnjw", function (b) {
model.variables.getMinutesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getMinutesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getMinutesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetMinutes", function (span) {
if(span) {
span.setAttribute("code.function", "GetMinutes");
span.setAttribute("outsystems.function.key", "6767add7-711d-4d96-b1dd-9a0e45b590a1");
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

return this._getMinutes$DataActRefresh;
}set getMinutes$DataActRefresh(value) {this._getMinutes$DataActRefresh = value;
}

get getSummary$DataActRefresh() {if(!(this.hasOwnProperty("_getSummary$DataActRefresh"))) {
this._getSummary$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSummary", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/DataActionGetSummary", "8Zn+WqR+1XoWIyMin1R8Vw", function (b) {
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
span.setAttribute("outsystems.function.key", "6c88d6ce-ddd4-411d-a9f7-c72b1fd64066");
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

get getMinutesDocuments$DataActRefresh() {if(!(this.hasOwnProperty("_getMinutesDocuments$DataActRefresh"))) {
this._getMinutesDocuments$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetMinutesDocuments", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioEditConstruction/DataActionGetMinutesDocuments", "PCd2xGFaG8pOj11S2TQsoQ", function (b) {
model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getMinutesDocumentsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getMinutesDocumentsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getMinutesDocumentsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetMinutesDocuments", function (span) {
if(span) {
span.setAttribute("code.function", "GetMinutesDocuments");
span.setAttribute("outsystems.function.key", "9083a892-3e51-4110-a322-12ad8d0936de");
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

return this._getMinutesDocuments$DataActRefresh;
}set getMinutesDocuments$DataActRefresh(value) {this._getMinutesDocuments$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioCommentsByFolioId$AggrRefresh", "getFolioObservationsByFolioId$AggrRefresh", "getOrderDetail$AggrRefresh", "getApprovalList$AggrRefresh", "getFolioExtendedById$AggrRefresh", "getFolioItemsByFolioId$AggrRefresh", "getFolioById$AggrRefresh", "getOrderMainItems$DataActRefresh", "getMinutes$DataActRefresh", "getSummary$DataActRefresh", "getMinutesDocuments$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_updateFolioOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UpdateFolioOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateFolioOnClick");
span.setAttribute("outsystems.function.key", "170d3cd9-919e-4903-a89c-f8f6e687285c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UpdateFolioOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioUpdateVar = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// WithFilesError = False
model.variables.withFilesErrorVar = false;
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ValidateFinal
controller._validateFinal$Action(callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesVar, function (p) {
return (p.isInvoiceErrorAttr || p.isDateErrorAttr);
}, callContext);

// error?
return OS$Flow.executeSequence(function () {
if(((!(listFilterVar.value.filteredListOut.isEmpty)))) {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EPy9lDXy20+yhB037DnYEQ#Message.-1008290854.1", "It was not possible to create the Folio, please review introduced data"), /*Error*/ 3);
} else {
// Execute Action: FolioUpdate
model.flush();
return controller.folioUpdate$ServerAction(model.variables.folioIdIn, model.variables.localSelectedLinesVar, model.variables.i_OrderIdIn, model.variables.commentsVar, model.variables.filesListExtraVar, model.variables.filesListIn, model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr, new RC_1c2482ce6cd4b83ca44ec0510b231d44(), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.l_SummaryRecVar, new RC_45d2d2c3c5fe5caa10fa5e20326622ac(), function (source, target) {
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
}), new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), new ST_6f620840109ac6f721328b723ec0152cStructure(), new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), OS$BuiltinFunctions.integerToDecimal(0), model.variables.l_IsOpenPopupCommentVar, model.variables.haveNewFilesVar, model.variables.newFileNamesUploadedVar, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
folioUpdateVar.value = value;
}).then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
if(((folioUpdateVar.value.errorMsgOut === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fmtMfvOEPkOieL_rt+o5Zg#Message.68060425.1", "Folio") + " ") + folioUpdateVar.value.o_FolioNameOut) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fmtMfvOEPkOieL_rt+o5Zg#Message.166241077.1", "was successfully updated.")), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Proveedor
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Proveedor", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioUpdateVar.value.errorMsgOut, /*Error*/ 3);
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioEditConstruction.UpdateFolioOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "afe13290-2d49-4125-9691-d629d08d4faf");
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
_selectMinute$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectMinute", function (span) {
if(span) {
span.setAttribute("code.function", "SelectMinute");
span.setAttribute("outsystems.function.key", "23fb98f6-e4ce-4db2-97d8-6577e31ef382");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SelectMinute");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetMinutesDocuments
var result = controller.getMinutesDocuments$DataActRefresh(callContext);
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
_input_PartialDeliveryAmountOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "2a23a8c2-7153-4a6a-a1ea-2cf09df703a7");
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
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.gt(model.variables.l_SummaryRecVar.amountLeftAttr))) {
// MaxAmountError = True
model.variables.maxAmountErrorVar = true;
// Input_PartialDeliveryAmount.Valid = False
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validAttr = false;
// Input_PartialDeliveryAmount.ValidationMessage = "Value not allowed"
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Z9KiUU1s8kCLWt79jnINQg#Value.-1625513716.1", "Value not allowed");
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
_validateNewFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateNewFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateNewFiles");
span.setAttribute("outsystems.function.key", "2c5edbb4-3ec0-4f70-ab84-5c4dd184aebb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateNewFiles");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.filesListExtraVar, function (p) {
return !(OS$DataTypes.areBinaryNulls(p.binaryDataAttr, OS$BuiltinFunctions.nullBinary()));
}, callContext);

// NewFileNamesUploaded = ""
model.variables.newFileNamesUploadedVar = "";
// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// NewFileNamesUploaded = If
model.variables.newFileNamesUploadedVar = (((model.variables.newFileNamesUploadedVar === "")) ? (listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).nameAttr) : (((model.variables.newFileNamesUploadedVar + " | ") + listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).nameAttr)));
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

// HaveNewFiles = notListFilter.FilteredList.Empty
model.variables.haveNewFilesVar = (!(listFilterVar.value.filteredListOut.isEmpty));
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "31d1d6a2-ba51-4b4c-bef3-03411c641130");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "33812ebf-312e-4a84-b807-9504becd3fec");
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
// Refresh Query: GetMinutesDocuments
var result = controller.getMinutesDocuments$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
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
// Refresh Query: GetFolioExtendedById
var result = controller.getFolioExtendedById$AggrRefresh(1, 0, callContext);
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
_validateFinal$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateFinal", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "349ef0f5-d960-41d5-805d-284a3890feeb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateFinal");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// WithDatesError = False
model.variables.withDatesErrorVar = false;
// WithQuantityError = False
model.variables.withQuantityErrorVar = false;
// WithFilesError = False
model.variables.withFilesErrorVar = false;
// WithPaymentError = False
model.variables.withPaymentErrorVar = false;
// Input_AdvPaymentValue.Valid = True
model.widgets.get(idService.getId("Input_AdvPaymentValue")).validAttr = true;
// Input_CreditNoteValue.Valid = True
model.widgets.get(idService.getId("Input_CreditNoteValue")).validAttr = true;
// Input_VoucherValue.Valid = True
model.widgets.get(idService.getId("Input_VoucherValue")).validAttr = true;
// WithConceptMinutesError = False
model.variables.withConceptMinutesErrorVar = false;
// DropdownConceptMinutes.Valid = True
model.widgets.get(idService.getId("DropdownConceptMinutes")).validAttr = true;
// WithApprovalProcessError = False
model.variables.withApprovalProcessErrorVar = false;
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

// No Minutes Concept Selected?
if(((model.variables.minuteSelectedVar === 0))) {
// DropdownConceptMinutes.Valid = False
model.widgets.get(idService.getId("DropdownConceptMinutes")).validAttr = false;
// DropdownConceptMinutes.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("DropdownConceptMinutes")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0gbiUuVKHk6afG_Vd8IPhw#Value.-1857341149.1", "This field is mandatory.");
// WithConceptMinutesError = True
model.variables.withConceptMinutesErrorVar = true;
}

// Minutes Concept Selected?
if(((model.variables.minuteSelectedVar > 0))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.minuteDocumentTypeListVar, function (p) {
return ((p.mandatoryAttr === true) && (p.withDocumentAttr === false));
}, callContext);

if((!(listFilterVar.value.filteredListOut.isEmpty))) {
// WithFilesError = True
model.variables.withFilesErrorVar = true;
}

// ALIGN
}

// Without WithPayment_
if((((((model.variables.constructionStructVar.advPaymentAttr === false) && (model.variables.constructionStructVar.creditNoteAttr === false)) && (model.variables.constructionStructVar.nAAttr === false)) && (model.variables.constructionStructVar.voucherAttr === false)))) {
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
} else {
if((model.variables.constructionStructVar.advPaymentAttr)) {
if((!(model.variables.constructionStructVar.advPaymentValueAttr.gt(OS$BuiltinFunctions.integerToDecimal(0))))) {
// Input_AdvPaymentValue.Valid = False
model.widgets.get(idService.getId("Input_AdvPaymentValue")).validAttr = false;
// Input_AdvPaymentValue.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("Input_AdvPaymentValue")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KbvuLr4QU0SX2O_5Rn6D2A#Value.-1857341149.1", "This field is mandatory.");
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
}

}

if((model.variables.constructionStructVar.creditNoteAttr)) {
if((!(model.variables.constructionStructVar.creditNoteValueAttr.gt(OS$BuiltinFunctions.integerToDecimal(0))))) {
// Input_CreditNoteValue.Valid = False
model.widgets.get(idService.getId("Input_CreditNoteValue")).validAttr = false;
// Input_CreditNoteValue.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("Input_CreditNoteValue")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1JkCLeHVokGZLedC2dNxSw#Value.-1857341149.1", "This field is mandatory.");
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
}

}

if((model.variables.constructionStructVar.voucherAttr)) {
if((!(model.variables.constructionStructVar.voucherValueAttr.gt(OS$BuiltinFunctions.integerToDecimal(0))))) {
// Input_VoucherValue.Valid = False
model.widgets.get(idService.getId("Input_VoucherValue")).validAttr = false;
// Input_VoucherValue.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("Input_VoucherValue")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("R6VXmx+I6Eu_VZ_Jo2Iz9Q#Value.-1857341149.1", "This field is mandatory.");
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
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
_wb_UploadDocumentsConstructionSendFiles$Action(event_FilesListIn, event_MinuteDocumentTypeListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_UploadDocumentsConstructionSendFiles", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_UploadDocumentsConstructionSendFiles");
span.setAttribute("outsystems.function.key", "37e7d55a-735b-472f-a11d-eaade4394543");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_UploadDocumentsConstructionSendFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.Wb_UploadDocumentsConstructionSendFiles$vars"))());
vars.value.event_FilesListInLocal = event_FilesListIn.clone();
vars.value.event_MinuteDocumentTypeListInLocal = event_MinuteDocumentTypeListIn.clone();
var listFilterVar = new OS$DataTypes.VariableHolder();
// FilesListExtra = event_FilesList
model.variables.filesListExtraVar = vars.value.event_FilesListInLocal;
// MinuteDocumentTypeList = Event_MinuteDocumentTypeList
model.variables.minuteDocumentTypeListVar = vars.value.event_MinuteDocumentTypeListInLocal;
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(vars.value.event_MinuteDocumentTypeListInLocal, function (p) {
return ((p.mandatoryAttr === true) && (p.withDocumentAttr === false));
}, callContext);

// WithFilesError = notListFilter.FilteredList.Empty
model.variables.withFilesErrorVar = (!(listFilterVar.value.filteredListOut.isEmpty));
// Execute Action: ValidateNewFiles
controller._validateNewFiles$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_debounceInvoiceQttOnDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DebounceInvoiceQttOnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceInvoiceQttOnDebounce");
span.setAttribute("outsystems.function.key", "39181adf-1a38-4925-ba15-523c9e482b23");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DebounceInvoiceQttOnDebounce");
callContext = controller.callContext(callContext);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "39a7f0bf-eb6a-4af3-9884-722ab5927b72");
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
_getMinutesDocumentsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetMinutesDocumentsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetMinutesDocumentsOnAfterFetch");
span.setAttribute("outsystems.function.key", "4359e0bc-afbb-4a47-a658-0999c3d478da");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetMinutesDocumentsOnAfterFetch");
callContext = controller.callContext(callContext);
// FilesListExtra = GetMinutesDocuments.List
model.variables.filesListExtraVar = OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getMinutesDocumentsDataAct.listOut, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.isExtraAttr = true;
target.storageIdAttr = source.storageIdAttr;
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
_selectDeliveryDate$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectDeliveryDate", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDeliveryDate");
span.setAttribute("outsystems.function.key", "5390b7ad-c76c-44cd-a5fd-371659056d88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectDeliveryDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.SelectDeliveryDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// LocalSelectedLines.Current.DeliveryDate = SelectedDateTime
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr = OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal);
// LocalSelectedLines.Current.IsDateError = If
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isDateErrorAttr = ((!(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (false) : (true));
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
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "57a2c2b1-bf79-41f4-9306-2d0229dfe3b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
// Withprorata = ActiveTab = 1
model.variables.withprorataVar = (vars.value.activeTabInLocal === 1);
if(((vars.value.activeTabInLocal === 0))) {
// l_SummaryRec.PartialDeliveryAmount = 0.00
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = (OS$DataTypes.Decimal.defaultValue);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// setError
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
// LocalSelectedLines.Current.InvoiceQtt = 0
model.variables.localSelectedLinesVar.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
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
span.setAttribute("outsystems.function.key", "6dccb35f-08bd-4394-b482-2584b2e74ef8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderDetailOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetApprovalList
var result = controller.getApprovalList$AggrRefresh(999999999, 0, callContext);
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
_getFolioById2OnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioById2OnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById2OnAfterFetch");
span.setAttribute("outsystems.function.key", "73f4a25d-16b8-4935-a8c2-0ffde732fb8f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetFolioById2OnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// MinuteSelected = GetFolioById.List.Current.Folio.MinuteSelected
model.variables.minuteSelectedVar = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.minuteSelectedAttr;
// Refresh Query: GetMinutesDocuments
var result = controller.getMinutesDocuments$DataActRefresh(callContext);
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
_paymentType$Action(selectedIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaymentType", function (span) {
if(span) {
span.setAttribute("code.function", "PaymentType");
span.setAttribute("outsystems.function.key", "7b7ba547-fd72-4964-8849-3a9c61d15af7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PaymentType");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.PaymentType$vars"))());
vars.value.selectedIdInLocal = selectedIdIn;
// Input_AdvPaymentValue.Valid = True
model.widgets.get(idService.getId("Input_AdvPaymentValue")).validAttr = true;
// Input_CreditNoteValue.Valid = True
model.widgets.get(idService.getId("Input_CreditNoteValue")).validAttr = true;
// Input_VoucherValue.Valid = True
model.widgets.get(idService.getId("Input_VoucherValue")).validAttr = true;
// ConstructionStruct.AdvPaymentValue = 0
model.variables.constructionStructVar.advPaymentValueAttr = OS$BuiltinFunctions.integerToDecimal(0);
// ConstructionStruct.CreditNoteValue = 0
model.variables.constructionStructVar.creditNoteValueAttr = OS$BuiltinFunctions.integerToDecimal(0);
// ConstructionStruct.VoucherValue = 0
model.variables.constructionStructVar.voucherValueAttr = OS$BuiltinFunctions.integerToDecimal(0);
if(((vars.value.selectedIdInLocal === "1"))) {
// ConstructionStruct.CreditNote = False
model.variables.constructionStructVar.creditNoteAttr = false;
// ConstructionStruct.Voucher = False
model.variables.constructionStructVar.voucherAttr = false;
// ConstructionStruct.NA = False
model.variables.constructionStructVar.nAAttr = false;
// ConstructionStruct.AdvPayment = True
model.variables.constructionStructVar.advPaymentAttr = true;
} else {
if(((vars.value.selectedIdInLocal === "2"))) {
// ConstructionStruct.AdvPayment = False
model.variables.constructionStructVar.advPaymentAttr = false;
// ConstructionStruct.NA = False
model.variables.constructionStructVar.nAAttr = false;
// ConstructionStruct.Voucher = False
model.variables.constructionStructVar.voucherAttr = false;
// ConstructionStruct.CreditNote = True
model.variables.constructionStructVar.creditNoteAttr = true;
} else {
if(((vars.value.selectedIdInLocal === "3"))) {
// ConstructionStruct.AdvPayment = False
model.variables.constructionStructVar.advPaymentAttr = false;
// ConstructionStruct.CreditNote = False
model.variables.constructionStructVar.creditNoteAttr = false;
// ConstructionStruct.Voucher = True
model.variables.constructionStructVar.voucherAttr = true;
// ConstructionStruct.NA = False
model.variables.constructionStructVar.nAAttr = false;
} else {
// ConstructionStruct.AdvPayment = False
model.variables.constructionStructVar.advPaymentAttr = false;
// ConstructionStruct.CreditNote = False
model.variables.constructionStructVar.creditNoteAttr = false;
// ConstructionStruct.NA = True
model.variables.constructionStructVar.nAAttr = true;
// ConstructionStruct.Voucher = False
model.variables.constructionStructVar.voucherAttr = false;
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
_prorate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Prorate", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "7bc5c7af-acd1-471d-85e4-6b37cd3a49e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Prorate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.Prorate$vars"))());
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
_removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "7d9fe732-4089-4954-a178-a1aaa52ccee6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.RemoveOnClick$vars"))());
vars.value.l_CurrentRowNumberInLocal = l_CurrentRowNumberIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.localSelectedLinesVar, vars.value.l_CurrentRowNumberInLocal, callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.localSelectedLinesVar.isEmpty)) {
// Trigger Event: GoBackToStep1
return controller.goBackToStep1$Action(callContext);
} else {
// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
if((!(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))))) {
// Execute Action: Prorate
controller._prorate$Action(callContext);
}

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
_togglePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopup", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "8df2042a-06d7-47fe-9192-60e4eb44f183");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopup");
callContext = controller.callContext(callContext);
// l_IsOpenPopup = notl_IsOpenPopup
model.variables.l_IsOpenPopupVar = (!(model.variables.l_IsOpenPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getFolioExtendedByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioExtendedByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioExtendedByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "97231916-b77f-4650-addd-0bdb96a9eb8c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetFolioExtendedByIdOnAfterFetch");
callContext = controller.callContext(callContext);
if((model.variables.getFolioExtendedByIdAggr.listOut.isEmpty)) {
// ConstructionStruct = GetFolioExtendedById.List.Current
model.variables.constructionStructVar = OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getFolioExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext), new RC_1c2482ce6cd4b83ca44ec0510b231d44(), function (source, target) {
target.advPaymentAttr = source.folioExtendedAttr.isAdvPaymentAttr;
target.advPaymentValueAttr = source.folioExtendedAttr.advPaymentValueAttr;
target.creditNoteAttr = source.folioExtendedAttr.isCreditNoteAttr;
target.creditNoteValueAttr = source.folioExtendedAttr.creditNoteValueAttr;
target.nAAttr = true;
target.voucherAttr = source.folioExtendedAttr.isVoucherAttr;
target.voucherValueAttr = source.folioExtendedAttr.voucherValueAttr;
return target;
});
} else {
// ConstructionStruct = GetFolioExtendedById.List.Current
model.variables.constructionStructVar = OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getFolioExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext), new RC_1c2482ce6cd4b83ca44ec0510b231d44(), function (source, target) {
target.advPaymentAttr = source.folioExtendedAttr.isAdvPaymentAttr;
target.advPaymentValueAttr = source.folioExtendedAttr.advPaymentValueAttr;
target.creditNoteAttr = source.folioExtendedAttr.isCreditNoteAttr;
target.creditNoteValueAttr = source.folioExtendedAttr.creditNoteValueAttr;
target.nAAttr = source.folioExtendedAttr.isNaAttr;
target.voucherAttr = source.folioExtendedAttr.isVoucherAttr;
target.voucherValueAttr = source.folioExtendedAttr.voucherValueAttr;
return target;
});
}

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
span.setAttribute("outsystems.function.key", "a61d7d9d-c2a2-4155-8e95-7e80e6e8a3e3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CalcInvoiceAmount");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.CalcInvoiceAmount$vars"))());
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
_validateDatesInvoiceQttPEP$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "a9130139-3207-4b4b-9d1a-8b2fc58fd304");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateDatesInvoiceQttPEP");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesVar, function (p) {
return (p.isDateErrorAttr || p.isInvoiceErrorAttr);
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
_getFolioItemsByFolioIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioItemsByFolioIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "bc55bc80-27d0-42d0-96fc-00a240cc2749");
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
_debouncePEPOnDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DebouncePEPOnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "DebouncePEPOnDebounce");
span.setAttribute("outsystems.function.key", "c18110f8-38bc-4b78-983b-bd1d75ea0176");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DebouncePEPOnDebounce");
callContext = controller.callContext(callContext);
// PEP Empty?
if(((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr === ""))) {
// PEPError
// LocalSelectedLines.Current.IsPEPError = True
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isPEPErrorAttr = true;
} else {
// PEPError
// LocalSelectedLines.Current.IsPEPError = False
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isPEPErrorAttr = false;
}

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
_getOrderMainItemsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "cf78aad6-defb-4131-8803-9cd7477f7fb4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderMainItemsOnAfterFetch");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.GetOrderMainItemsOnAfterFetch$vars"))());
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
_input_InvoiceQttOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_InvoiceQttOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_InvoiceQttOnChange");
span.setAttribute("outsystems.function.key", "e732cb83-d104-4743-a6e0-00cf4a873f84");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_InvoiceQttOnChange");
callContext = controller.callContext(callContext);
// Smaller then 0?
if((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Set Zero
// LocalSelectedLines.Current.InvoiceQtt = 0
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
if((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr.gt(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttTotalAttr))) {
// Set Max
// LocalSelectedLines.Current.InvoiceQtt = LocalSelectedLines.Current.RemainingQttTotal
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr = model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttTotalAttr;
}

// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = false;
if(((OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)).gt(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttTotalAttr) || OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)).equals(OS$BuiltinFunctions.integerToDecimal(0))))) {
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = true;
}

// LocalSelectedLines.Current.RemainingQtt = LocalSelectedLines.Current.RemainingQttTotal - LocalSelectedLines.Current.InvoiceQtt
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr = model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttTotalAttr.minus(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr);
// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
}

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
span.setAttribute("outsystems.function.key", "f780ddb5-3f75-468a-9bd5-7a9552437859");
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

updateFolioOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UpdateFolioOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateFolioOnClick");
span.setAttribute("outsystems.function.key", "170d3cd9-919e-4903-a89c-f8f6e687285c");
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

selectMinute$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectMinute__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectMinute");
span.setAttribute("outsystems.function.key", "23fb98f6-e4ce-4db2-97d8-6577e31ef382");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._selectMinute$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

input_PartialDeliveryAmountOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "2a23a8c2-7153-4a6a-a1ea-2cf09df703a7");
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

validateNewFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateNewFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateNewFiles");
span.setAttribute("outsystems.function.key", "2c5edbb4-3ec0-4f70-ab84-5c4dd184aebb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateNewFiles$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

initialValidate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InitialValidate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitialValidate");
span.setAttribute("outsystems.function.key", "31d1d6a2-ba51-4b4c-bef3-03411c641130");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "33812ebf-312e-4a84-b807-9504becd3fec");
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

validateFinal$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateFinal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "349ef0f5-d960-41d5-805d-284a3890feeb");
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

wb_UploadDocumentsConstructionSendFiles$Action(event_FilesListIn, event_MinuteDocumentTypeListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_UploadDocumentsConstructionSendFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_UploadDocumentsConstructionSendFiles");
span.setAttribute("outsystems.function.key", "37e7d55a-735b-472f-a11d-eaade4394543");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_UploadDocumentsConstructionSendFiles$Action, callContext, event_FilesListIn, event_MinuteDocumentTypeListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

debounceInvoiceQttOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebounceInvoiceQttOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceInvoiceQttOnDebounce");
span.setAttribute("outsystems.function.key", "39181adf-1a38-4925-ba15-523c9e482b23");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._debounceInvoiceQttOnDebounce$Action, callContext);
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
span.setAttribute("outsystems.function.key", "39a7f0bf-eb6a-4af3-9884-722ab5927b72");
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

getMinutesDocumentsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetMinutesDocumentsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetMinutesDocumentsOnAfterFetch");
span.setAttribute("outsystems.function.key", "4359e0bc-afbb-4a47-a658-0999c3d478da");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getMinutesDocumentsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

selectDeliveryDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectDeliveryDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDeliveryDate");
span.setAttribute("outsystems.function.key", "5390b7ad-c76c-44cd-a5fd-371659056d88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._selectDeliveryDate$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "57a2c2b1-bf79-41f4-9306-2d0229dfe3b6");
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

getOrderDetailOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderDetailOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetailOnAfterFetch");
span.setAttribute("outsystems.function.key", "6dccb35f-08bd-4394-b482-2584b2e74ef8");
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

getFolioById2OnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioById2OnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById2OnAfterFetch");
span.setAttribute("outsystems.function.key", "73f4a25d-16b8-4935-a8c2-0ffde732fb8f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getFolioById2OnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

paymentType$Action(selectedIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaymentType__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaymentType");
span.setAttribute("outsystems.function.key", "7b7ba547-fd72-4964-8849-3a9c61d15af7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._paymentType$Action, callContext, selectedIdIn);
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
span.setAttribute("outsystems.function.key", "7bc5c7af-acd1-471d-85e4-6b37cd3a49e0");
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

removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "7d9fe732-4089-4954-a178-a1aaa52ccee6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeOnClick$Action, callContext, l_CurrentRowNumberIn);
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
span.setAttribute("outsystems.function.key", "8df2042a-06d7-47fe-9192-60e4eb44f183");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getFolioExtendedByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioExtendedByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioExtendedByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "97231916-b77f-4650-addd-0bdb96a9eb8c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getFolioExtendedByIdOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "a61d7d9d-c2a2-4155-8e95-7e80e6e8a3e3");
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

validateDatesInvoiceQttPEP$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "a9130139-3207-4b4b-9d1a-8b2fc58fd304");
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

getFolioItemsByFolioIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioItemsByFolioIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "bc55bc80-27d0-42d0-96fc-00a240cc2749");
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

debouncePEPOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebouncePEPOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebouncePEPOnDebounce");
span.setAttribute("outsystems.function.key", "c18110f8-38bc-4b78-983b-bd1d75ea0176");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._debouncePEPOnDebounce$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderMainItemsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "cf78aad6-defb-4131-8803-9cd7477f7fb4");
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

input_InvoiceQttOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_InvoiceQttOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_InvoiceQttOnChange");
span.setAttribute("outsystems.function.key", "e732cb83-d104-4743-a6e0-00cf4a873f84");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_InvoiceQttOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "f780ddb5-3f75-468a-9bd5-7a9552437859");
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

get goBackToStep2$Action() {if(!(this.hasOwnProperty("_goBackToStep2$Action"))) {
this._goBackToStep2$Action = function () {
return Promise.resolve();
};
}

return this._goBackToStep2$Action;
}set goBackToStep2$Action(value) {this._goBackToStep2$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction$ActionFolioUpdate", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction$ActionGetAllAvailableQuantity", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.Wb_UploadDocumentsConstructionSendFiles$vars", [{
name: "event_FilesList",
attrName: "event_FilesListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}, {
name: "Event_MinuteDocumentTypeList",
attrName: "event_MinuteDocumentTypeListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.SelectDeliveryDate$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.PaymentType$vars", [{
name: "SelectedId",
attrName: "selectedIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.Prorate$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.RemoveOnClick$vars", [{
name: "l_CurrentRowNumber",
attrName: "l_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.CalcInvoiceAmount$vars", [{
name: "Total",
attrName: "totalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.GetOrderMainItemsOnAfterFetch$vars", [{
name: "LocalSelectedLinesAux",
attrName: "localSelectedLinesAuxVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


