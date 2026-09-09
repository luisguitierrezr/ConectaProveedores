import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_OrderReject_Popup.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approvRejectOrder$ServerAction(i_OrderIdIn, i_OrderApprovalLevelIdIn, i_IsApproveIn, i_ReasonIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovRejectOrder", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovRejectOrder");
span.setAttribute("outsystems.function.key", "f73279b7-e725-4093-b0d6-b5e1b430d251");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderId: OS$DataConversion.ServerDataConverter.to(i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_OrderApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_OrderApprovalLevelIdIn, {
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
})
};
return controller.callServerAction("ApprovRejectOrder", "screenservices/ConectaProveedores/e_Orders/Wb_OrderReject_Popup/ActionApprovRejectOrder", "XUq3ADSWmTtz946jlce+mA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderReject_Popup$ActionApprovRejectOrder"))();
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
_confirmOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ConfirmOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "62d4f443-a926-480e-aba0-8218388f3ad0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ConfirmOnClick");
callContext = controller.callContext(callContext);
var approvRejectOrderVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsExecuting = True
model.variables.isExecutingVar = true;
// TextArea_l_Reason.Valid = True
model.widgets.get(idService.getId("TextArea_l_Reason")).validAttr = true;
// TextArea_l_Reason.ValidationMessage = ""
model.widgets.get(idService.getId("TextArea_l_Reason")).validationMessageAttr = "";
return OS$Flow.executeSequence(function () {
if(((OS$BuiltinFunctions.trim(model.variables.l_ReasonVar) === ""))) {
// TextArea_l_Reason.Valid = False
model.widgets.get(idService.getId("TextArea_l_Reason")).validAttr = false;
// TextArea_l_Reason.ValidationMessage = "You must state a reason to reject this order."
model.widgets.get(idService.getId("TextArea_l_Reason")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hxmf2PYgxUCESCHULfBUjA#Value.836343278.1", "You must state a reason to reject this order.");
// IsExecuting = False
model.variables.isExecutingVar = false;
} else {
// Execute Action: ApprovRejectOrder
model.flush();
return controller.approvRejectOrder$ServerAction(model.variables.i_OrderIdIn, model.variables.i_OrderApprovalLevelIdIn, false, model.variables.l_ReasonVar, callContext).then(function (value) {
approvRejectOrderVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((approvRejectOrderVar.value.o_OutputOut.isSuccessAttr)) {
// Trigger Event: Close
return controller.close$Action(true, callContext).then(function () {
// Success Message
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IQZB7hYEOU63a2fo3DANpw#Message.-760324184.1", "Order rejected with success!"), /*Success*/ 1);
// IsExecuting = False
model.variables.isExecutingVar = false;
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(approvRejectOrderVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "b885388b-76cd-4f9a-a298-f4ddd841437d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// l_Reason = ""
model.variables.l_ReasonVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

confirmOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ConfirmOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "62d4f443-a926-480e-aba0-8218388f3ad0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._confirmOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "b885388b-76cd-4f9a-a298-f4ddd841437d");
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderReject_Popup$ActionApprovRejectOrder", [{
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


