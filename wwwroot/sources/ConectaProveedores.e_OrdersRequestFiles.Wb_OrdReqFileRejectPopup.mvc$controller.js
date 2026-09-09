import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_mvc_TranslationsResources from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrdReqFileRejectPopup.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_OrdersRequestFiles_Wb_OrdReqFileRejectPopup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approvRejectReqOrdFile$ServerAction(i_OrderRequestFileApprovalLevelIdIn, i_IsApproveIn, i_ReasonIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovRejectReqOrdFile", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovRejectReqOrdFile");
span.setAttribute("outsystems.function.key", "fb3c1a9d-6e3d-464f-ab44-65299afebe5a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderRequestFileApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_OrderRequestFileApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Reason: OS$DataConversion.ServerDataConverter.to(i_ReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApprovRejectReqOrdFile", "screenservices/ConectaProveedores/e_OrdersRequestFiles/Wb_OrdReqFileRejectPopup/ActionApprovRejectReqOrdFile", "0lNPuRbZHM66soYx3DvBRA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_OrdReqFileRejectPopup$ActionApprovRejectReqOrdFile"))();
executeServerActionResult.outputOut = OS$DataConversion.ServerDataConverter.from(outputs.Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
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

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "3de01a44-cf90-4587-ac03-0eeae98cd795");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// l_RejectReason = ""
model.variables.l_RejectReasonVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_rejectOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RejectOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RejectOnClick");
span.setAttribute("outsystems.function.key", "e790d3f3-2d5a-41f2-b6dd-4cdda113c403");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RejectOnClick");
callContext = controller.callContext(callContext);
var approvRejectReqOrdFileVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// TextArea_l_RejectReason.Valid = True
model.widgets.get(idService.getId("TextArea_l_RejectReason")).validAttr = true;
// TextArea_l_RejectReason.ValidationMessage = ""
model.widgets.get(idService.getId("TextArea_l_RejectReason")).validationMessageAttr = "";
// l_IsExecuting = True
model.variables.l_IsExecutingVar = true;
return OS$Flow.executeSequence(function () {
if(((OS$BuiltinFunctions.trim(model.variables.l_RejectReasonVar) === ""))) {
// TextArea_l_RejectReason.Valid = False
model.widgets.get(idService.getId("TextArea_l_RejectReason")).validAttr = false;
// TextArea_l_RejectReason.ValidationMessage = "You must state a reason to reject this proposal line."
model.widgets.get(idService.getId("TextArea_l_RejectReason")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("H+AcLs2B0ECCFmEdWHoXwg#Value.-1792125606.1", "You must state a reason to reject this proposal line.");
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
} else {
// Execute Action: ApprovRejectReqOrdFile
model.flush();
return controller.approvRejectReqOrdFile$ServerAction(model.variables.i_OrderRequestFileApprovalLevelIdToRejectIn, false, model.variables.l_RejectReasonVar, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
approvRejectReqOrdFileVar.value = value;
}).then(function () {
// IsSuccess?
return OS$Flow.executeSequence(function () {
if((approvRejectReqOrdFileVar.value.outputOut.isSuccessAttr)) {
// Trigger Event: Reject
return controller.reject$Action(callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CV_AB5BNvEOlTRjyxNkd6A#Message.-1821037626.1", "File has been rejected."), /*Warning*/ 2);
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(approvRejectReqOrdFileVar.value.outputOut.messageAttr, /*Error*/ 3);
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "3de01a44-cf90-4587-ac03-0eeae98cd795");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

rejectOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RejectOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RejectOnClick");
span.setAttribute("outsystems.function.key", "e790d3f3-2d5a-41f2-b6dd-4cdda113c403");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._rejectOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get reject$Action() {if(!(this.hasOwnProperty("_reject$Action"))) {
this._reject$Action = function () {
return Promise.resolve();
};
}

return this._reject$Action;
}set reject$Action(value) {this._reject$Action = value;
}

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_OrdReqFileRejectPopup$ActionApprovRejectReqOrdFile", [{
name: "Output",
attrName: "outputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


