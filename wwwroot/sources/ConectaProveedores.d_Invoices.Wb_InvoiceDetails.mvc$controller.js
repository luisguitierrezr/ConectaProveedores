import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetails.mvc$translationsResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceExtendedMoreChargesTotal$AggrRefresh: -1,
getInvoiceExtendedRelationsByInvoiceId$AggrRefresh: -1,
getInvoiceAccountingByInvoiceId$AggrRefresh: 0,
getInvoiceExtendedById$AggrRefresh: -1,
getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh: -1,
getInvoiceApproval$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceExtendedMoreChargesTotal$AggrRefresh: [],
getInvoiceExtendedRelationsByInvoiceId$AggrRefresh: [],
getInvoiceAccountingByInvoiceId$AggrRefresh: [],
getInvoiceExtendedById$AggrRefresh: [],
getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh: [],
getInvoiceApproval$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approvModifInv$ServerAction(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovModifInv", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovModifInv");
span.setAttribute("outsystems.function.key", "37d4e485-7021-4ad2-a8f4-0305ae61b29a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_InvoiceApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_InvoiceApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApprovModifInv", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ActionApprovModifInv", "hgVLsCjSSwJ57Oio+PKM9g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails$ActionApprovModifInv"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.isFinishOut = OS$DataConversion.ServerDataConverter.from(outputs.IsFinish, OS$DataTypes.DataTypes.Boolean);
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
checkUserSession$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckUserSession", function (span) {
if(span) {
span.setAttribute("code.function", "CheckUserSession");
span.setAttribute("outsystems.function.key", "83326f1c-eaba-4dc4-a622-0044ab12fa2e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("CheckUserSession", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ActionCheckUserSession", "r6LGmAV4qXUN0IKWGjbASA", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails$ActionCheckUserSession"))();
executeServerActionResult.isValidSessionOut = OS$DataConversion.ServerDataConverter.from(outputs.IsValidSession, OS$DataTypes.DataTypes.Boolean);
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
get getInvoiceExtendedMoreChargesTotal$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedMoreChargesTotal$AggrRefresh"))) {
this._getInvoiceExtendedMoreChargesTotal$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedMoreChargesTotal", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ScreenDataSetGetInvoiceExtendedMoreChargesTotal", "HGJkmwF++S2EIDr+WjTKcQ", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedMoreChargesTotalAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedMoreChargesTotalAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedMoreChargesTotalAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedMoreChargesTotal", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedMoreChargesTotal");
span.setAttribute("outsystems.function.key", "9403e8fb-72c8-4d89-934a-e93421190edf");
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

return this._getInvoiceExtendedMoreChargesTotal$AggrRefresh;
}set getInvoiceExtendedMoreChargesTotal$AggrRefresh(value) {this._getInvoiceExtendedMoreChargesTotal$AggrRefresh = value;
}

get getInvoiceExtendedRelationsByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedRelationsByInvoiceId$AggrRefresh"))) {
this._getInvoiceExtendedRelationsByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId", "dS4TkaC+YGMee8uX8+xFKA", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedRelationsByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedRelationsByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedRelationsByInvoiceId");
span.setAttribute("outsystems.function.key", "cf7b2010-21d3-4ff2-ab27-7123e2c1e9a7");
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

return this._getInvoiceExtendedRelationsByInvoiceId$AggrRefresh;
}set getInvoiceExtendedRelationsByInvoiceId$AggrRefresh(value) {this._getInvoiceExtendedRelationsByInvoiceId$AggrRefresh = value;
}

get getInvoiceAccountingByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceAccountingByInvoiceId$AggrRefresh"))) {
this._getInvoiceAccountingByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceAccountingByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ScreenDataSetGetInvoiceAccountingByInvoiceId", "v08tXSwqYKWcO_F3bJx6dg", maxRecords, startIndex, function (b) {
model.variables.getInvoiceAccountingByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceAccountingByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceAccountingByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceAccountingByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceAccountingByInvoiceId");
span.setAttribute("outsystems.function.key", "d4107ee9-9213-441e-ba28-6ca0fe8c04cd");
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

return this._getInvoiceAccountingByInvoiceId$AggrRefresh;
}set getInvoiceAccountingByInvoiceId$AggrRefresh(value) {this._getInvoiceAccountingByInvoiceId$AggrRefresh = value;
}

get getInvoiceExtendedById$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedById$AggrRefresh"))) {
this._getInvoiceExtendedById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedById", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ScreenDataSetGetInvoiceExtendedById", "2WPE_5leaqHPkOwpzTcpUQ", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedById", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedById");
span.setAttribute("outsystems.function.key", "da5d32ba-c673-4944-9344-48d811c0ab94");
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

return this._getInvoiceExtendedById$AggrRefresh;
}set getInvoiceExtendedById$AggrRefresh(value) {this._getInvoiceExtendedById$AggrRefresh = value;
}

get getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh"))) {
this._getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "sj7QdCKaGixjzJ+AOBxSkA", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedMoreChargesByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedMoreChargesByInvoiceId");
span.setAttribute("outsystems.function.key", "df7ad8f1-9080-41e3-8b87-5a63dd0fa430");
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

return this._getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh;
}set getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh(value) {this._getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh = value;
}

get getInvoiceApproval$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceApproval$AggrRefresh"))) {
this._getInvoiceApproval$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceApproval", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetails/ScreenDataSetGetInvoiceApproval", "wfk51u1BGH3d15JUu2Mqyw", maxRecords, startIndex, function (b) {
model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceApprovalAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceApprovalAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoiceApprovalOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceApproval", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceApproval");
span.setAttribute("outsystems.function.key", "f5b3a7be-1b77-4e10-a78e-eae78234a5c9");
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

return this._getInvoiceApproval$AggrRefresh;
}set getInvoiceApproval$AggrRefresh(value) {this._getInvoiceApproval$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoiceExtendedMoreChargesTotal$AggrRefresh", "getInvoiceExtendedRelationsByInvoiceId$AggrRefresh", "getInvoiceAccountingByInvoiceId$AggrRefresh", "getInvoiceExtendedById$AggrRefresh", "getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh", "getInvoiceApproval$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onClosePopupApproval$Action(isOkIn, commentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClosePopupApproval", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopupApproval");
span.setAttribute("outsystems.function.key", "18862148-f847-427e-b587-e37d7cc44235");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClosePopupApproval");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails.OnClosePopupApproval$vars"))());
vars.value.isOkInLocal = isOkIn;
vars.value.commentInLocal = commentIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var approvModifInvVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isOkInLocal)) {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ApprovModifInv
model.flush();
return controller.approvModifInv$ServerAction(model.variables.i_InvoiceIdIn, model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr, true, vars.value.commentInLocal, ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
approvModifInvVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((approvModifInvVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(((approvModifInvVar.value.isFinishOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vfksTG7R8kS53YtIBAnsqQ#Message.678776543.1", "Accounting process has started")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vfksTG7R8kS53YtIBAnsqQ#Message.1926737820.1", "Invoice has been approved."))), /*Success*/ 1);
// Clear Locals
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
// Refresh Query: GetInvoiceApproval
var result = controller.getInvoiceApproval$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Destination: /ConectaProveedores/Invoices_Detail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices_Detail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(model.variables.i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(approvModifInvVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Clear Locals
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
} else {
// Clear Locals
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_InvoiceDetails.OnClosePopupApproval", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "16e0ba2c-ead5-444a-a5ce-ce7a77703c75");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading2
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
_onExit$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnExit", function (span) {
if(span) {
span.setAttribute("code.function", "OnExit");
span.setAttribute("outsystems.function.key", "2a24531f-100a-4cff-a90d-e61ef7a27d91");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnExit");
callContext = controller.callContext(callContext);
var checkUserSessionVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckUserSession
model.flush();
return controller.checkUserSession$ServerAction(callContext).then(function (value) {
checkUserSessionVar.value = value;
}).then(function () {
// hasRequisitionId
if((!(model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(true, {
dataType: OS$DataTypes.DataTypes.Boolean
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Destination: /ConectaProveedores/Invoices
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
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
_openApprovePopUp$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenApprovePopUp", function (span) {
if(span) {
span.setAttribute("code.function", "OpenApprovePopUp");
span.setAttribute("outsystems.function.key", "4b7922f6-4e35-41cc-a17b-9f6e00d245d3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenApprovePopUp");
callContext = controller.callContext(callContext);
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openModifyPopUp$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenModifyPopUp", function (span) {
if(span) {
span.setAttribute("code.function", "OpenModifyPopUp");
span.setAttribute("outsystems.function.key", "630606f8-2870-4826-bd09-f93a61590f2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenModifyPopUp");
callContext = controller.callContext(callContext);
// l_ShowModifyPopup = notl_ShowModifyPopup
model.variables.l_ShowModifyPopupVar = (!(model.variables.l_ShowModifyPopupVar));
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
span.setAttribute("outsystems.function.key", "67edbdea-f18b-40fa-9305-e4261fc9c32b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceApproval
var result = controller.getInvoiceApproval$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
return OS$Flow.executeSequence(function () {
if((false)) {
// Refresh Query: GetInvoiceExtendedMoreChargesTotal
var result = controller.getInvoiceExtendedMoreChargesTotal$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoiceExtendedById
var result = controller.getInvoiceExtendedById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceExtendedMoreChargesByInvoiceId
var result = controller.getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceExtendedRelationsByInvoiceId
var result = controller.getInvoiceExtendedRelationsByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceAccountingByInvoiceId
var result = controller.getInvoiceAccountingByInvoiceId$AggrRefresh(1, 0, callContext);
model.flush();
return result;
});
}

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
_openCancelPopUp$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenCancelPopUp", function (span) {
if(span) {
span.setAttribute("code.function", "OpenCancelPopUp");
span.setAttribute("outsystems.function.key", "7bcdad38-f6c0-4c13-999c-8862524df6f0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenCancelPopUp");
callContext = controller.callContext(callContext);
// l_ShowCancelPopup = notl_ShowCancelPopup
model.variables.l_ShowCancelPopupVar = (!(model.variables.l_ShowCancelPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getInvoiceApprovalOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceApprovalOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceApprovalOnAfterFetch");
span.setAttribute("outsystems.function.key", "8eced457-14c8-4149-b412-b88390c33086");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoiceApprovalOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceExtendedById
var result = controller.getInvoiceExtendedById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoiceExtendedMoreChargesByInvoiceId
var result = controller.getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceExtendedRelationsByInvoiceId
var result = controller.getInvoiceExtendedRelationsByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceExtendedMoreChargesTotal
var result = controller.getInvoiceExtendedMoreChargesTotal$AggrRefresh(1, 0, callContext);
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
_hidePopUps$Action(isRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("HidePopUps", function (span) {
if(span) {
span.setAttribute("code.function", "HidePopUps");
span.setAttribute("outsystems.function.key", "c51e8ba6-925b-4e8b-b550-0230487f6230");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("HidePopUps");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails.HidePopUps$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// Refresh Query: GetInvoiceApproval
var result = controller.getInvoiceApproval$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Trigger Event: RefreshMainPageData
return controller.refreshHistory$Action(callContext);
});
}

}).then(function () {
// Boolean Logic
// l_ShowCancelPopup = False
model.variables.l_ShowCancelPopupVar = false;
// l_ShowModifyPopup = False
model.variables.l_ShowModifyPopupVar = false;
// l_ShowApproveInvoice = False
model.variables.l_ShowApproveInvoiceVar = false;
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

onClosePopupApproval$Action(isOkIn, commentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClosePopupApproval__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopupApproval");
span.setAttribute("outsystems.function.key", "18862148-f847-427e-b587-e37d7cc44235");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClosePopupApproval$Action, callContext, isOkIn, commentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onExit$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnExit__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnExit");
span.setAttribute("outsystems.function.key", "2a24531f-100a-4cff-a90d-e61ef7a27d91");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onExit$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

openApprovePopUp$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenApprovePopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenApprovePopUp");
span.setAttribute("outsystems.function.key", "4b7922f6-4e35-41cc-a17b-9f6e00d245d3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openApprovePopUp$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openModifyPopUp$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenModifyPopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenModifyPopUp");
span.setAttribute("outsystems.function.key", "630606f8-2870-4826-bd09-f93a61590f2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openModifyPopUp$Action, callContext);
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
span.setAttribute("outsystems.function.key", "67edbdea-f18b-40fa-9305-e4261fc9c32b");
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

openCancelPopUp$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenCancelPopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenCancelPopUp");
span.setAttribute("outsystems.function.key", "7bcdad38-f6c0-4c13-999c-8862524df6f0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openCancelPopUp$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getInvoiceApprovalOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceApprovalOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceApprovalOnAfterFetch");
span.setAttribute("outsystems.function.key", "8eced457-14c8-4149-b412-b88390c33086");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoiceApprovalOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

hidePopUps$Action(isRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("HidePopUps__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "HidePopUps");
span.setAttribute("outsystems.function.key", "c51e8ba6-925b-4e8b-b550-0230487f6230");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._hidePopUps$Action, callContext, isRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get refreshHistory$Action() {if(!(this.hasOwnProperty("_refreshHistory$Action"))) {
this._refreshHistory$Action = function () {
return Promise.resolve();
};
}

return this._refreshHistory$Action;
}set refreshHistory$Action(value) {this._refreshHistory$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails$ActionApprovModifInv", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "IsFinish",
attrName: "isFinishOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails$ActionCheckUserSession", [{
name: "IsValidSession",
attrName: "isValidSessionOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails.OnClosePopupApproval$vars", [{
name: "IsOk",
attrName: "isOkInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "Comment",
attrName: "commentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetails.HidePopUps$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


