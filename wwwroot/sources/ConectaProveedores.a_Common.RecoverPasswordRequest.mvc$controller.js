import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_a_Common_RecoverPasswordRequest_mvc_TranslationsResources from "./ConectaProveedores.a_Common.RecoverPasswordRequest.mvc$translationsResources.js";
import ConectaProveedores_a_CommonController$default from "./ConectaProveedores.a_Common.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_RecoverPasswordRequest_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSettingsEnviroment$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getSettingsEnviroment$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
sendResetPasswordEmail$ServerAction(applicationNameIn, customerEmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendResetPasswordEmail", function (span) {
if(span) {
span.setAttribute("code.function", "SendResetPasswordEmail");
span.setAttribute("outsystems.function.key", "509b534d-7c3a-4800-a9f3-b73d7d09dd19");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
ApplicationName: OS$DataConversion.ServerDataConverter.to(applicationNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
CustomerEmail: OS$DataConversion.ServerDataConverter.to(customerEmailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SendResetPasswordEmail", "screenservices/ConectaProveedores/a_Common/RecoverPasswordRequest/ActionSendResetPasswordEmail", "ZQ3JIWE5Y0g+GWpXfIJc8A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordRequest$ActionSendResetPasswordEmail"))();
executeServerActionResult.successOut = OS$DataConversion.ServerDataConverter.from(outputs.Success, OS$DataTypes.DataTypes.Boolean);
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
get getSettingsEnviroment$DataActRefresh() {if(!(this.hasOwnProperty("_getSettingsEnviroment$DataActRefresh"))) {
this._getSettingsEnviroment$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettingsEnviroment", "screenservices/ConectaProveedores/a_Common/RecoverPasswordRequest/DataActionGetSettingsEnviroment", "hz8SvQr3tsgaFFBBoTRz0Q", function (b) {
model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsEnviromentDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsEnviromentDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettingsEnviroment", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsEnviroment");
span.setAttribute("outsystems.function.key", "2f7fb024-80ed-4c8f-ac60-7e31b39271ba");
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

return this._getSettingsEnviroment$DataActRefresh;
}set getSettingsEnviroment$DataActRefresh(value) {this._getSettingsEnviroment$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSettingsEnviroment$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_resetPasswordOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetPasswordOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ResetPasswordOnClick");
span.setAttribute("outsystems.function.key", "3aad2e06-92b3-4cc7-8b61-e9d6e85af93b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ResetPasswordOnClick");
callContext = controller.callContext(callContext);
var sendResetPasswordEmailVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsEnabled = False
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("RecoverPasswordForm")).validAttr)) {
// IsExecuting = True
model.variables.isExecutingVar = true;
// Execute Action: SendResetPasswordEmail
model.flush();
return controller.sendResetPasswordEmail$ServerAction(OS$BuiltinFunctions.getAppName(), model.variables.emailVar, callContext).then(function (value) {
sendResetPasswordEmailVar.value = value;
}).then(function () {
// Success?
if((sendResetPasswordEmailVar.value.successOut)) {
// IsExecuting
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsEnabled = True
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
// Destination: /ConectaProveedores/RecoverPasswordReset
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RecoverPasswordReset", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qoNiCjEVUkS1_L0CWzdF+w#Message.553463793.1", "An error has occured. Please try again later."), /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsEnabled = True
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
}

});
} else {
// IsEnabled = True
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
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

resetPasswordOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetPasswordOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetPasswordOnClick");
span.setAttribute("outsystems.function.key", "3aad2e06-92b3-4cc7-8b61-e9d6e85af93b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._resetPasswordOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

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
this._onParametersChangedEventHandler = null;
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
return ConectaProveedores_a_CommonController$default.handleError(ex, this.callContext());
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordRequest$ActionSendResetPasswordEmail", [{
name: "Success",
attrName: "successOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


