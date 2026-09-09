import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_RejectApprovalPopup_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_RejectApprovalPopup.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_RejectApprovalPopup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approveRejectSingleProposalLineApprovalLevel$ServerAction(i_ProposalIdIn, i_ProposalLineApprovalLevelIdIn, i_IsRejectIn, i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveRejectSingleProposalLineApprovalLevel", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRejectSingleProposalLineApprovalLevel");
span.setAttribute("outsystems.function.key", "cbd322d5-0b24-4e90-baaa-f350b3ab5dde");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_ProposalLineApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_ProposalLineApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsReject: OS$DataConversion.ServerDataConverter.to(i_IsRejectIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApproveRejectSingleProposalLineApprovalLevel", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/Wb_RejectApprovalPopup/ActionApproveRejectSingleProposalLineApprovalLevel", "oV5RW64HGgfchjl2JqmJ0Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_RejectApprovalPopup$ActionApproveRejectSingleProposalLineApprovalLevel"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
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
span.setAttribute("outsystems.function.key", "2256c1f8-2974-414e-8018-7ea14dca9985");
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
span.setAttribute("outsystems.function.key", "7b4ee039-c946-46c8-bd98-e36424a13339");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RejectOnClick");
callContext = controller.callContext(callContext);
var approveRejectSingleProposalLineApprovalLevelVar = new OS$DataTypes.VariableHolder();
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
model.widgets.get(idService.getId("TextArea_l_RejectReason")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dMjzwvy0qEGWCo_SCI8ooQ#Value.-1792125606.1", "You must state a reason to reject this proposal line.");
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
} else {
// Execute Action: ApproveRejectSingleProposalLineApprovalLevel
model.flush();
return controller.approveRejectSingleProposalLineApprovalLevel$ServerAction(model.variables.i_ProposalIdIn, model.variables.i_ProposalLineApprovalLevelIdToRejectIn, true, model.variables.l_RejectReasonVar, callContext).then(function (value) {
approveRejectSingleProposalLineApprovalLevelVar.value = value;
}).then(function () {
// Trigger Event: Reject
return controller.reject$Action(callContext);
}).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8+g2SnvFlUuiIrhEGlkbWg#Message.243985248.1", "Proposal line has been rejected."), /*Warning*/ 2);
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
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
span.setAttribute("outsystems.function.key", "2256c1f8-2974-414e-8018-7ea14dca9985");
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
span.setAttribute("outsystems.function.key", "7b4ee039-c946-46c8-bd98-e36424a13339");
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

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
}

get reject$Action() {if(!(this.hasOwnProperty("_reject$Action"))) {
this._reject$Action = function () {
return Promise.resolve();
};
}

return this._reject$Action;
}set reject$Action(value) {this._reject$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_RejectApprovalPopup$ActionApproveRejectSingleProposalLineApprovalLevel", [{
name: "o_Output",
attrName: "o_OutputOut",
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


