import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_a_Common_UserInfo_mvc_controller_OnReady_JavaScript1JS from "./ConectaProveedores.a_Common.UserInfo.mvc$controller.OnReady.JavaScript1JS.js";
import ConectaProveedores_a_Common_UserInfo_mvc_TranslationsResources from "./ConectaProveedores.a_Common.UserInfo.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_UserInfo_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
serviceUserManagementLogsCreate$ServerAction(userIdIn, messageIn, ipAddressIn, screenIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceUserManagementLogsCreate", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceUserManagementLogsCreate");
span.setAttribute("outsystems.function.key", "4521be58-38dd-42d5-bc6c-c83be5f26dc0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserId: OS$DataConversion.ServerDataConverter.to(userIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Message: OS$DataConversion.ServerDataConverter.to(messageIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IpAddress: OS$DataConversion.ServerDataConverter.to(ipAddressIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Screen: OS$DataConversion.ServerDataConverter.to(screenIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceUserManagementLogsCreate", "screenservices/ConectaProveedores/a_Common/UserInfo/ServiceAPIServiceUserManagementLogsCreate", "XChAQnXYflYYarSITwmL4w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.UserInfo$ServiceAPIServiceUserManagementLogsCreate"))();
executeServerActionResult.idOut = OS$DataConversion.ServerDataConverter.from(outputs.Id, OS$DataTypes.DataTypes.LongInteger);
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
_clientLogout$Action(isFromInactivityIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClientLogout", function (span) {
if(span) {
span.setAttribute("code.function", "ClientLogout");
span.setAttribute("outsystems.function.key", "16b8bb2e-2d06-444a-9efc-eb164c5727d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClientLogout");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.UserInfo.ClientLogout$vars"))());
vars.value.isFromInactivityInLocal = isFromInactivityIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var serviceUserManagementLogsCreate7Var = new OS$DataTypes.VariableHolder();
var getExternalLogoutURLVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ServiceUserManagementLogsCreate7
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(OS$BuiltinFunctions.getUserId(), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qvYH4we3O0Cg7FLy0sL97w#Value.-1804272015.1", "The user logged out of the system."), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate7Var.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((OS$SystemActions.isExternalUser(callContext).isExternalUserOut)) {
// Execute Action: GetExternalLogoutURL
model.flush();
return OS$SystemActions.getExternalLogoutURL("", callContext).then(function (value) {
getExternalLogoutURLVar.value = value;
}).then(function () {
// Set external RedirectURL
// RedirectURL = GetExternalLogoutURL.ExternalLogoutURL
vars.value.redirectURLVar = getExternalLogoutURLVar.value.externalLogoutURLOut;
});
} else {
// Execute Action: Logout
model.flush();
return OS$SystemActions.logout(callContext).then(function () {
// Set internal RedirectURL
// RedirectURL = GetOwnerURLPath
vars.value.redirectURLVar = OS$BuiltinFunctions.getOwnerURLPath();
});
}

});
}).then(function () {
// Clear client variables
// UserName = ""
ConectaProveedoresClientVariables.setUserName("");
// UserPhotoURL = ""
ConectaProveedoresClientVariables.setUserPhotoURL("");
// LastURL = ""
ConectaProveedoresClientVariables.setLastURL("");
if((vars.value.isFromInactivityInLocal)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("t234dJB7BUmzpvvzraOsRg#Message.-403712367.1", "Session ended due to inactivity."), /*Error*/ 3);
}

// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
}).catch(function (ex) {
OS$Logger.debug("UserInfo.ClientLogout", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "edc3ba17-da5d-451f-aff6-a5c88c121834");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "178caa22-4a4c-4694-b37a-07d6fef86df8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetUsernameAndPhoto
return controller._getUsernameAndPhoto$Action(callContext).then(function () {
OS$Logger.startActiveSpan("JavaScript1", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript1");
span.setAttribute("outsystems.function.key", "e29a7cae-e13f-4698-8cf1-6a0f576c6c52");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_a_Common_UserInfo_mvc_controller_OnReady_JavaScript1JS, "JavaScript1", "OnReady", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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
_getUsernameAndPhoto$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUsernameAndPhoto", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsernameAndPhoto");
span.setAttribute("outsystems.function.key", "c78050da-d0b4-41e0-b4a6-d2d77ea57b9f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUsernameAndPhoto");
callContext = controller.callContext(callContext);
var getUserProfileVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// No username?
return OS$Flow.executeSequence(function () {
if((((ConectaProveedoresClientVariables.getUserName() === "") && ((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier()))))) {
// Execute Action: GetUserProfile
model.flush();
return OS$SystemActions.getUserProfile(callContext).then(function (value) {
getUserProfileVar.value = value;
}).then(function () {
// Set User Info
// UserName = GetUserProfile.UserInfo.Name
ConectaProveedoresClientVariables.setUserName(getUserProfileVar.value.userInfoOut.nameAttr);
// UserPhotoURL = GetUserProfile.UserInfo.PhotoURL
ConectaProveedoresClientVariables.setUserPhotoURL(getUserProfileVar.value.userInfoOut.photoURLAttr);
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

clientLogout$Action(isFromInactivityIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClientLogout__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClientLogout");
span.setAttribute("outsystems.function.key", "16b8bb2e-2d06-444a-9efc-eb164c5727d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clientLogout$Action, callContext, isFromInactivityIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "178caa22-4a4c-4694-b37a-07d6fef86df8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getUsernameAndPhoto$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUsernameAndPhoto__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsernameAndPhoto");
span.setAttribute("outsystems.function.key", "c78050da-d0b4-41e0-b4a6-d2d77ea57b9f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUsernameAndPhoto$Action, callContext);
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
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.UserInfo$ServiceAPIServiceUserManagementLogsCreate", [{
name: "Id",
attrName: "idOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.UserInfo.ClientLogout$vars", [{
name: "IsFromInactivity",
attrName: "isFromInactivityInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "RedirectURL",
attrName: "redirectURLVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


