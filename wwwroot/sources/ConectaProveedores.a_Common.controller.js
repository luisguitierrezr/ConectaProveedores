import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import ConectaProveedoresController$default, { hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { DataTypes as OS$DataTypes, Logger as OS$Logger, Exceptions as OS$Exceptions, Flow as OS$Flow, SystemActions as OS$SystemActions, Transitions as OS$Transitions, Navigation as OS$Navigation, ErrorHandling as OS$ErrorHandling, Controller as OS$Controller, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Common_Controller_translationsResources from "./ConectaProveedores.a_Common.controller$translationsResources.js";

class Controller extends 
OS$Controller.BaseController {
getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnException", function (span) {
if(span) {
span.setAttribute("code.function", "OnException");
span.setAttribute("outsystems.function.key", "1a118907-e7fa-4938-90a2-703c8abe0fca.#FlowExceptionHandler");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
callContext = controller.callContext(callContext);
var securityExceptionVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var dataBaseExceptionVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var communicationExceptionVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var noFilesVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var invalidLoginSuppliersVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var invalidSessionVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var fileInvalidVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
OS$Logger.debug("a_Common.OnException", OS$Exceptions.getMessage(ex));
if(OS$ErrorHandling.ignoreError(ex, callContext)) {
return OS$ErrorHandling.IGNORED_ERROR_RESULT;
}

return OS$Flow.tryCatch(function () {
OS$Logger.debug("a_Common.OnException", OS$Exceptions.getMessage(ex));
// Handle Error: NoFiles
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.UserException, "ConectaProveedores.NoFiles")) {
OS$Logger.error(null, ex, null, null, 1);
noFilesVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("NoFiles", function (span) {
if(span) {
span.setAttribute("code.function", "NoFiles");
span.setAttribute("outsystems.function.key", "b0203fbb-b795-4e4a-a65a-25249c75e971");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("i9JO0kK5IUKo0dgIPwxTfg#Message.-46618447.1", "This requisition has no files to download"), /*Error*/ 3);
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

// Handle Error: InvalidLoginSuppliers
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.UserException, "ConectaProveedores.InvalidLoginSuppliers")) {
OS$Logger.error(null, ex, null, null, 1);
invalidLoginSuppliersVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("InvalidLoginSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "InvalidLoginSuppliers");
span.setAttribute("outsystems.function.key", "b0210de0-caee-4241-a440-f7977ce104fd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pCYWW75kV0uMGTEUrpcpLg#Message.-1973574713.1", "There was a problem. Please contact the administrator"), /*Error*/ 3);
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

// Handle Error: InvalidSession
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.UserException, "ConectaProveedores.InvalidSession")) {
OS$Logger.error(null, ex, null, null, 1);
invalidSessionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("InvalidSession", function (span) {
if(span) {
span.setAttribute("code.function", "InvalidSession");
span.setAttribute("outsystems.function.key", "b1af2561-98d1-44c3-b627-47761add8ce5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: Logout
return OS$SystemActions.logout(callContext).then(function () {
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/InvalidSession
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidSession", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

// Handle Error: FileInvalid
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.UserException, "ConectaProveedores.FileInvalid")) {
OS$Logger.error(null, ex, null, null, 1);
fileInvalidVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("FileInvalid", function (span) {
if(span) {
span.setAttribute("code.function", "FileInvalid");
span.setAttribute("outsystems.function.key", "f85495fd-6352-418d-9d0e-987c51fde9ef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(fileInvalidVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading7
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

// Handle Error: SecurityException
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.SecurityException)) {
securityExceptionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("SecurityException", function (span) {
if(span) {
span.setAttribute("code.function", "SecurityException");
span.setAttribute("outsystems.function.key", "1db0d2fa-26aa-479a-9520-99a3a5d75a3a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Logged User?
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// LastRequest
// LastURL = GetBookmarkableURL
ConectaProveedoresClientVariables.setLastURL(OS$BuiltinFunctions.getBookmarkableURL());
// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
}

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

// Handle Error: DataBaseException
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.DataBaseException)) {
OS$Logger.error(null, ex, null, null, 1);
dataBaseExceptionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("DataBaseException", function (span) {
if(span) {
span.setAttribute("code.function", "DataBaseException");
span.setAttribute("outsystems.function.key", "44c56eca-8792-4354-8872-391470dce2a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("h3fWDwmg3UeT0Bqt_cQgxw#Message.878067834.1", "There was a problem with the database request. Please contact the administrator"), /*Error*/ 3);
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

// Handle Error: CommunicationException
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.CommunicationException)) {
OS$Logger.error(null, ex, null, null, 1);
communicationExceptionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("CommunicationException", function (span) {
if(span) {
span.setAttribute("code.function", "CommunicationException");
span.setAttribute("outsystems.function.key", "9f3a4c50-96da-4e7b-99b9-25a7b45412e3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZW2tO1gq9ke3K4B8INEM6w#Message.-1991744483.1", "There was a problem communicating with the server. Please try again or contact your administrator"), /*Error*/ 3);
// Execute Action: HideLoading3
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

// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "22e99060-a32a-4cfa-acb6-7bd2cacb7ce1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hd35JhN3zEmey3w4Y9h7LQ#Message.-1973574713.1", "There was a problem. Please contact the administrator"), /*Error*/ 3);
// Execute Action: HideLoading
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
}, function (unhandledEx) {
OS$Logger.debug("a_Common.OnException", OS$Exceptions.getMessage(ex));
return OS$ErrorHandling.defaultErrorHandler(unhandledEx, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);


};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

}



export default new Controller(ConectaProveedores_a_Common_Controller_translationsResources);



