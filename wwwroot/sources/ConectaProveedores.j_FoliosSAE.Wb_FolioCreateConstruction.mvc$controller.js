import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, EN_f81a3d226103fd013068b8763798067aEntityRecord, RC_45d2d2c3c5fe5caa10fa5e20326622ac } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.mvc$translationsResources.js";
import { SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType } from "./ConectaProveedores.staticEntities.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getApprovalList$AggrRefresh: -1,
getOrderDetail$AggrRefresh: 0,
getMinutes$DataActRefresh: 0,
getSettings$DataActRefresh: 0,
getSummary$DataActRefresh: 0,
getMinutesDocuments$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getApprovalList$AggrRefresh: [],
getOrderDetail$AggrRefresh: ["getApprovalList$AggrRefresh"],
getMinutes$DataActRefresh: [],
getSettings$DataActRefresh: [],
getSummary$DataActRefresh: [],
getMinutesDocuments$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
folioCreate$ServerAction(i_SelectedLinesIn, i_OrderMainIdIn, i_FirstApprovalIdIn, i_CommentsIn, invoiceExtendedIn, filesListExtraIn, filesListIn, invoiceIdIn, invoiceForeignToCreateIn, approvalProcessTypeIdIn, constructionDataIn, approvalProcessIdIn, i_SummaryRecIn, i_IsMassCreateIn, i_MinuteSelectedIn, i_OrderAccConceptIDIn, creditNoteFilesListIn, importAnticipoIn, isNationalIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioCreate", function (span) {
if(span) {
span.setAttribute("code.function", "FolioCreate");
span.setAttribute("outsystems.function.key", "5287e67b-9bff-4876-8740-efe041dbf4cf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
I_SelectedLines: OS$DataConversion.ServerDataConverter.to(i_SelectedLinesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
I_OrderMainId: OS$DataConversion.ServerDataConverter.to(i_OrderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
I_FirstApprovalId: OS$DataConversion.ServerDataConverter.to(i_FirstApprovalIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_Comments: OS$DataConversion.ServerDataConverter.to(i_CommentsIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
InvoiceExtended: OS$DataConversion.ServerDataConverter.to(invoiceExtendedIn, {
dataType: OS$DataTypes.DataTypes.Record,
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
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
InvoiceForeignToCreate: OS$DataConversion.ServerDataConverter.to(invoiceForeignToCreateIn, {
dataType: OS$DataTypes.DataTypes.Record,
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
ApprovalProcessId: OS$DataConversion.ServerDataConverter.to(approvalProcessIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_SummaryRec: OS$DataConversion.ServerDataConverter.to(i_SummaryRecIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_IsMassCreate: OS$DataConversion.ServerDataConverter.to(i_IsMassCreateIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_MinuteSelected: OS$DataConversion.ServerDataConverter.to(i_MinuteSelectedIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_OrderAccConceptID: OS$DataConversion.ServerDataConverter.to(i_OrderAccConceptIDIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
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
IsNational: OS$DataConversion.ServerDataConverter.to(isNationalIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioCreate", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/ActionFolioCreate", "4xnZBg4JdXDVujLeNhLc5A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction$ActionFolioCreate"))();
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

// Aggregates and Data Actions
get getApprovalList$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalList$AggrRefresh"))) {
this._getApprovalList$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalList", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/ScreenDataSetGetApprovalList", "CWF6QlHhyibTL8RCKRx_rA", maxRecords, startIndex, function (b) {
model.variables.getApprovalListAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalListAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalListAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalList", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalList");
span.setAttribute("outsystems.function.key", "b172f037-138c-411c-97a9-c5b1789f6900");
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

get getOrderDetail$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderDetail$AggrRefresh"))) {
this._getOrderDetail$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderDetail", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/ScreenDataSetGetOrderDetail", "lpqE3qzMg4wpZUViVv4nAQ", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "b70c884e-f17e-41ff-8616-1aa617151675");
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

get getMinutes$DataActRefresh() {if(!(this.hasOwnProperty("_getMinutes$DataActRefresh"))) {
this._getMinutes$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetMinutes", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/DataActionGetMinutes", "PnK76lq1cA_f5rDsb9jnjw", function (b) {
model.variables.getMinutesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getMinutesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getMinutesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetMinutes", function (span) {
if(span) {
span.setAttribute("code.function", "GetMinutes");
span.setAttribute("outsystems.function.key", "00314119-99e1-47d3-9991-a235d72a1690");
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

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/DataActionGetSettings", "bC78gmCKDDEz1pDpYZrGcw", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "2c7fa6a0-961e-4790-bf2e-68fd2ba3548e");
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

get getSummary$DataActRefresh() {if(!(this.hasOwnProperty("_getSummary$DataActRefresh"))) {
this._getSummary$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSummary", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/DataActionGetSummary", "8Zn+WqR+1XoWIyMin1R8Vw", function (b) {
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
span.setAttribute("outsystems.function.key", "3496a11a-09f4-43f5-a396-a22002220bce");
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
return controller.callDataAction("DataActionGetMinutesDocuments", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreateConstruction/DataActionGetMinutesDocuments", "lea82Ti2aqd5bnkw2ITK9w", function (b) {
model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getMinutesDocumentsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getMinutesDocumentsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetMinutesDocuments", function (span) {
if(span) {
span.setAttribute("code.function", "GetMinutesDocuments");
span.setAttribute("outsystems.function.key", "add3865e-ef59-48cd-b129-4dfefe689ba0");
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
this._dataFetchActionNames = ["getApprovalList$AggrRefresh", "getOrderDetail$AggrRefresh", "getMinutes$DataActRefresh", "getSettings$DataActRefresh", "getSummary$DataActRefresh", "getMinutesDocuments$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_FlowOptionsApprovalProcessSelected$Action(i_ApprovaProcessIdSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_FlowOptionsApprovalProcessSelected", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FlowOptionsApprovalProcessSelected");
span.setAttribute("outsystems.function.key", "191c43ea-afbe-4278-94ee-fc62d78b8a61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_FlowOptionsApprovalProcessSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.Wb_FlowOptionsApprovalProcessSelected$vars"))());
vars.value.i_ApprovaProcessIdSelectedInLocal = i_ApprovaProcessIdSelectedIn;
// l_ApprovalProcessId = i_ApprovaProcessIdSelected
model.variables.l_ApprovalProcessIdVar = vars.value.i_ApprovaProcessIdSelectedInLocal;
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
span.setAttribute("outsystems.function.key", "1c97b731-f564-48e8-9df0-33e53705fed7");
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
_createFolioOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CreateFolioOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CreateFolioOnClick");
span.setAttribute("outsystems.function.key", "258d45b6-bcf3-4cfa-8857-62e8429edceb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CreateFolioOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioCreateVar = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ValidateFinal
controller._validateFinal$Action(callContext);
// With Validation Error
return OS$Flow.executeSequence(function () {
if(((((((((model.variables.withFilesErrorVar || model.variables.withPaymentErrorVar) || model.variables.withConceptMinutesErrorVar) || model.variables.withApprovalProcessErrorVar) || model.variables.datesQuantityPEPErrorVar) || model.variables.withDatesErrorVar) || model.variables.withQuantityErrorVar) || model.variables.maxAmountErrorVar))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_a6ZRDXOa0SyMCG0m8Gg3Q#Message.-1008290854.1", "It was not possible to create the Folio, please review introduced data"), /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesIn, function (p) {
return ((p.isInvoiceErrorAttr || p.isDateErrorAttr) || model.variables.withPaymentErrorVar);
}, callContext);

// With Lines error?
return OS$Flow.executeSequence(function () {
if(((!(listFilterVar.value.filteredListOut.isEmpty)))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WW2nnsdGTUGORA_dH7tJ5w#Message.-1008290854.1", "It was not possible to create the Folio, please review introduced data"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: FolioCreate
model.flush();
return controller.folioCreate$ServerAction(model.variables.localSelectedLinesIn, model.variables.i_OrderIdIn, OS$BuiltinFunctions.nullTextIdentifier(), model.variables.commentsVar, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), model.variables.filesListExtraVar, model.variables.filesListVar, OS$DataTypes.LongInteger.defaultValue, model.variables.invoiceForeignToCreateVar, ConectaProveedores_staticEntities_approvalProcessType.construction, model.variables.constructionStructVar, model.variables.l_ApprovalProcessIdVar, OS$DataConversion.JSConversions.typeConvertRecord(model.variables.l_SummaryRecVar, new RC_45d2d2c3c5fe5caa10fa5e20326622ac(), function (source, target) {
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
}), false, model.variables.minuteSelectedVar, OS$DataTypes.LongInteger.defaultValue, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), OS$BuiltinFunctions.integerToDecimal(0), false, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
folioCreateVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
if((((folioCreateVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(folioCreateVar.value.errorMsgOut, /*Error*/ 3);
} else {
OS$FeedbackMessageService.showFeedbackMessage(((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IUrglL1VZ0G_Stz6tmtX6Q#Message.68060425.1", "Folio") + " ") + folioCreateVar.value.o_FolioNameOut) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IUrglL1VZ0G_Stz6tmtX6Q#Message.664062632.1", "was successfully created.")), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Proveedor
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Proveedor", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
}

});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioCreateConstruction.CreateFolioOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "4e7ae06f-47a8-416a-82d0-cf404cd55d08");
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
_input_PartialDeliveryAmountOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "304360cc-80b3-48c7-be77-d56d28e7fd04");
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
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rgDDS2BNHEaBo2Y4Qj_dWQ#Value.-1625513716.1", "Value not allowed");
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
_input_InvoiceQttOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_InvoiceQttOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_InvoiceQttOnChange");
span.setAttribute("outsystems.function.key", "348f79ca-e0cf-443c-85e8-2175a0d550cd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_InvoiceQttOnChange");
callContext = controller.callContext(callContext);
// Smaller then 0?
if((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Set Zero
// LocalSelectedLines.Current.InvoiceQtt = 0
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
if((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.gt(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr))) {
// Set Max
// LocalSelectedLines.Current.InvoiceQtt = LocalSelectedLines.Current.RemainingQttTotal
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr = model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr;
}

// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = false;
if(((OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr)).gt(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr) || OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr)).equals(OS$BuiltinFunctions.integerToDecimal(0))))) {
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = true;
}

// LocalSelectedLines.Current.RemainingQtt = LocalSelectedLines.Current.RemainingQttTotal - LocalSelectedLines.Current.InvoiceQtt
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr = model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr.minus(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr);
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
_debouncePEPOnDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DebouncePEPOnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "DebouncePEPOnDebounce");
span.setAttribute("outsystems.function.key", "3f23fdf8-adfe-450a-82cf-55d356258889");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DebouncePEPOnDebounce");
callContext = controller.callContext(callContext);
// PEP Empty?
if(((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).pEPAttr === ""))) {
// PEPError
// LocalSelectedLines.Current.IsPEPError = True
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr = true;
} else {
// PEPError
// LocalSelectedLines.Current.IsPEPError = False
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr = false;
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
_datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "52571109-c893-40d7-8785-4b1681f1dc93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.DatePickerOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// DeliveryDate = SelectedDateTime
model.variables.deliveryDateVar = OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.DeliveryDate = DeliveryDate
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).deliveryDateAttr = model.variables.deliveryDateVar;
// LocalSelectedLines.Current.IsDateError = If
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr = ((vars.value.selectedDateTimeInLocal.equals(OS$BuiltinFunctions.nullDate())) ? (true) : (false));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "55e9b20c-1c52-43c8-8980-fb898a6cf37a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PaymentType");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.PaymentType$vars"))());
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
_calcInvoiceAmount$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CalcInvoiceAmount", function (span) {
if(span) {
span.setAttribute("code.function", "CalcInvoiceAmount");
span.setAttribute("outsystems.function.key", "57b32a6d-24fd-4b0c-9587-edef39c3c976");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CalcInvoiceAmount");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.CalcInvoiceAmount$vars"))());
// total = 0
// Total = 0.0
vars.value.totalVar = (OS$DataTypes.Decimal.defaultValue);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Total = Total + LocalSelectedLines.Current.InvoiceQtt / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
vars.value.totalVar = vars.value.totalVar.plus(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).baseQuantityAttr)).times(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
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
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "6602ef6d-59f9-4dae-9b2e-c5411c27fc05");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
// Withprorata = ActiveTab = 1
model.variables.withprorataVar = (vars.value.activeTabInLocal === 1);
if(((vars.value.activeTabInLocal === 0))) {
// l_SummaryRec.PartialDeliveryAmount = 0.00
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = (OS$DataTypes.Decimal.defaultValue);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// setError
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
// LocalSelectedLines.Current.InvoiceQtt = 0
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "828776c1-fe1b-46a0-bdc1-531d902470eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.RemainingQttTotal = LocalSelectedLines.Current.RemainingQtt
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr = model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr;
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
// LocalSelectedLines.Current.IsDateError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr = true;
// LocalSelectedLines.Current.IsPEPError = If
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isPEPErrorAttr = (((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).inputationCodeAttr === "Q")) ? ((((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).pEPAttr === "")) ? (true) : (false))) : (false));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// ConstructionStruct.NA = True
model.variables.constructionStructVar.nAAttr = true;
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
span.setAttribute("outsystems.function.key", "8493f3e6-a662-4fe0-903a-d1d1e7224d97");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "97a60b0d-b7d5-4864-b38f-e03ded8ce545");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Comments = ""
model.variables.commentsVar = "";
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.RemainingQttTotal = LocalSelectedLines.Current.RemainingQtt
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr = model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Refresh Query: GetOrderDetail
var result = controller.getOrderDetail$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSummary
var result = controller.getSummary$DataActRefresh(callContext);
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
_getSummaryOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSummaryOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummaryOnAfterFetch");
span.setAttribute("outsystems.function.key", "a20d564d-e2b5-43c8-a622-dd68e424dc5e");
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
_removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "bf284ae0-b594-49ec-9cb4-8c81e6ef83b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.RemoveOnClick$vars"))());
vars.value.l_CurrentRowNumberInLocal = l_CurrentRowNumberIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.localSelectedLinesIn, vars.value.l_CurrentRowNumberInLocal, callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.localSelectedLinesIn.isEmpty)) {
// Trigger Event: GoBackToStep2
return controller.goBackToStep2$Action(callContext);
} else {
// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
// Execute Action: Prorate
controller._prorate$Action(callContext);
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
_wb_UploadDocumentsConstructionSendFiles$Action(event_FilesListIn, event_MinuteDocumentTypeListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_UploadDocumentsConstructionSendFiles", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_UploadDocumentsConstructionSendFiles");
span.setAttribute("outsystems.function.key", "ccae6245-c369-40f3-b541-b839a6aca79a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_UploadDocumentsConstructionSendFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.Wb_UploadDocumentsConstructionSendFiles$vars"))());
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
span.setAttribute("outsystems.function.key", "d723da58-6ff9-4ce3-9f0f-e816c02c0b0b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectDeliveryDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.SelectDeliveryDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// LocalSelectedLines.Current.DeliveryDate = SelectedDateTime
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr = OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal);
// LocalSelectedLines.Current.IsDateError = If
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isDateErrorAttr = ((!(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (false) : (true));
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
_validateDatesInvoiceQttPEP$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "d9395e3d-3101-4d7b-b878-44aca87d9f07");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateDatesInvoiceQttPEP");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesIn, function (p) {
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
_validateFinal$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateFinal", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "dd6eeb4d-9429-4b57-9cad-358d23ee1715");
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
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr)) {
// WithQuantityError = True
model.variables.withQuantityErrorVar = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr)) {
// WithDatesError = True
model.variables.withDatesErrorVar = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// No Minutes Concept Selected?
if(((model.variables.minuteSelectedVar === 0))) {
// DropdownConceptMinutes.Valid = False
model.widgets.get(idService.getId("DropdownConceptMinutes")).validAttr = false;
// DropdownConceptMinutes.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("DropdownConceptMinutes")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Se91_NPh80uqEgS5iii5ig#Value.-1857341149.1", "This field is mandatory.");
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
model.widgets.get(idService.getId("Input_AdvPaymentValue")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("a4qYSdB5Tk6b0RSfczw+bg#Value.-1857341149.1", "This field is mandatory.");
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
}

}

if((model.variables.constructionStructVar.creditNoteAttr)) {
if((!(model.variables.constructionStructVar.creditNoteValueAttr.gt(OS$BuiltinFunctions.integerToDecimal(0))))) {
// Input_CreditNoteValue.Valid = False
model.widgets.get(idService.getId("Input_CreditNoteValue")).validAttr = false;
// Input_CreditNoteValue.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("Input_CreditNoteValue")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7b2hsSGoSkWoL__tWR3H7g#Value.-1857341149.1", "This field is mandatory.");
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
}

}

if((model.variables.constructionStructVar.voucherAttr)) {
if((!(model.variables.constructionStructVar.voucherValueAttr.gt(OS$BuiltinFunctions.integerToDecimal(0))))) {
// Input_VoucherValue.Valid = False
model.widgets.get(idService.getId("Input_VoucherValue")).validAttr = false;
// Input_VoucherValue.ValidationMessage = "This field is mandatory."
model.widgets.get(idService.getId("Input_VoucherValue")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GyuVX8gEE0StahhqdDUR2A#Value.-1857341149.1", "This field is mandatory.");
// WithPaymentError = True
model.variables.withPaymentErrorVar = true;
}

}

// Approval Process Null
if((model.variables.l_ApprovalProcessIdVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// WithApprovalProcessError = True
model.variables.withApprovalProcessErrorVar = true;
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
_selectMinute$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectMinute", function (span) {
if(span) {
span.setAttribute("code.function", "SelectMinute");
span.setAttribute("outsystems.function.key", "e70dfa60-fae3-4fb1-ab2c-490aceb53e3e");
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
_prorate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Prorate", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "ed0574c3-de1f-4600-b418-bdef60d0eb03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Prorate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.Prorate$vars"))());
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Total = 0
vars.value.totalVar = OS$BuiltinFunctions.integerToDecimal(0);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Total = Total + LocalSelectedLines.Current.RemainingQttTotal / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
vars.value.totalVar = vars.value.totalVar.plus(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).baseQuantityAttr)).times(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Perc = l_SummaryRec.PartialDeliveryAmount / Total
vars.value.percVar = model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.div(vars.value.totalVar);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.InvoiceQtt = TextToDecimal
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr.times(vars.value.percVar), 3, ".", ""));
// >0
if((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// seterror
// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = false;
} else {
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// set IsInvoiceError = false
// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Error?
if(((OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr)).gt(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr) || OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr)).equals(OS$BuiltinFunctions.integerToDecimal(0))))) {
// setError
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Withprorata = False
model.variables.withprorataVar = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Set Original value
// LocalSelectedLines.Current.RemainingQtt = LocalSelectedLines.Current.RemainingQttTotal
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr = model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

}

// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
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

wb_FlowOptionsApprovalProcessSelected$Action(i_ApprovaProcessIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_FlowOptionsApprovalProcessSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FlowOptionsApprovalProcessSelected");
span.setAttribute("outsystems.function.key", "191c43ea-afbe-4278-94ee-fc62d78b8a61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_FlowOptionsApprovalProcessSelected$Action, callContext, i_ApprovaProcessIdSelectedIn);
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
span.setAttribute("outsystems.function.key", "1c97b731-f564-48e8-9df0-33e53705fed7");
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

createFolioOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CreateFolioOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CreateFolioOnClick");
span.setAttribute("outsystems.function.key", "258d45b6-bcf3-4cfa-8857-62e8429edceb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._createFolioOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "304360cc-80b3-48c7-be77-d56d28e7fd04");
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

input_InvoiceQttOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_InvoiceQttOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_InvoiceQttOnChange");
span.setAttribute("outsystems.function.key", "348f79ca-e0cf-443c-85e8-2175a0d550cd");
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

debouncePEPOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebouncePEPOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebouncePEPOnDebounce");
span.setAttribute("outsystems.function.key", "3f23fdf8-adfe-450a-82cf-55d356258889");
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

datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "52571109-c893-40d7-8785-4b1681f1dc93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

paymentType$Action(selectedIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaymentType__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaymentType");
span.setAttribute("outsystems.function.key", "55e9b20c-1c52-43c8-8980-fb898a6cf37a");
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

calcInvoiceAmount$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CalcInvoiceAmount__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CalcInvoiceAmount");
span.setAttribute("outsystems.function.key", "57b32a6d-24fd-4b0c-9587-edef39c3c976");
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

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "6602ef6d-59f9-4dae-9b2e-c5411c27fc05");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "828776c1-fe1b-46a0-bdc1-531d902470eb");
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

debounceInvoiceQttOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebounceInvoiceQttOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceInvoiceQttOnDebounce");
span.setAttribute("outsystems.function.key", "8493f3e6-a662-4fe0-903a-d1d1e7224d97");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "97a60b0d-b7d5-4864-b38f-e03ded8ce545");
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

getSummaryOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSummaryOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummaryOnAfterFetch");
span.setAttribute("outsystems.function.key", "a20d564d-e2b5-43c8-a622-dd68e424dc5e");
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

removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "bf284ae0-b594-49ec-9cb4-8c81e6ef83b7");
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

wb_UploadDocumentsConstructionSendFiles$Action(event_FilesListIn, event_MinuteDocumentTypeListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_UploadDocumentsConstructionSendFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_UploadDocumentsConstructionSendFiles");
span.setAttribute("outsystems.function.key", "ccae6245-c369-40f3-b541-b839a6aca79a");
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

selectDeliveryDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectDeliveryDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDeliveryDate");
span.setAttribute("outsystems.function.key", "d723da58-6ff9-4ce3-9f0f-e816c02c0b0b");
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

validateDatesInvoiceQttPEP$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "d9395e3d-3101-4d7b-b878-44aca87d9f07");
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

validateFinal$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateFinal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "dd6eeb4d-9429-4b57-9cad-358d23ee1715");
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

selectMinute$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectMinute__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectMinute");
span.setAttribute("outsystems.function.key", "e70dfa60-fae3-4fb1-ab2c-490aceb53e3e");
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

prorate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Prorate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "ed0574c3-de1f-4600-b418-bdef60d0eb03");
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction$ActionFolioCreate", [{
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.Wb_FlowOptionsApprovalProcessSelected$vars", [{
name: "i_ApprovaProcessIdSelected",
attrName: "i_ApprovaProcessIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.DatePickerOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.PaymentType$vars", [{
name: "SelectedId",
attrName: "selectedIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.CalcInvoiceAmount$vars", [{
name: "Total",
attrName: "totalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.RemoveOnClick$vars", [{
name: "l_CurrentRowNumber",
attrName: "l_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.Wb_UploadDocumentsConstructionSendFiles$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.SelectDeliveryDate$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.Prorate$vars", [{
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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


