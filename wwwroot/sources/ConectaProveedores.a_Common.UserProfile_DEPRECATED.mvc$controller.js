import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, BuiltinFunctions as OS$BuiltinFunctions, Authorization as OS$Authorization, SystemStructures as OS$SystemStructures, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_a_Common_UserProfile_DEPRECATED_mvc_controller_StopCountdown_JSClearTimerIntervalHandleJS from "./ConectaProveedores.a_Common.UserProfile_DEPRECATED.mvc$controller.StopCountdown.JSClearTimerIntervalHandleJS.js";
import ConectaProveedores_a_Common_UserProfile_DEPRECATED_mvc_TranslationsResources from "./ConectaProveedores.a_Common.UserProfile_DEPRECATED.mvc$translationsResources.js";
import ConectaProveedores_a_CommonController$default from "./ConectaProveedores.a_Common.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import ConectaProveedores_a_Common_UserProfile_DEPRECATED_mvc_controller_SendVerificationCode_JsSetIntervalJS from "./ConectaProveedores.a_Common.UserProfile_DEPRECATED.mvc$controller.SendVerificationCode.JsSetIntervalJS.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_UserProfile_DEPRECATED_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
updateCountdown$Action: function updateCountdown$Action$Proxy() {
return controller.executeActionInsideJSNode(controller._updateCountdown$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "UpdateCountdown");
}
};
this.dataFetchDependenciesOriginal = {
getUserDetails$AggrRefresh: 0,
getApplicationRoles$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserDetails$AggrRefresh: [],
getApplicationRoles$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
updateUser$ServerAction(userUpdateInfoIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UpdateUser", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateUser");
span.setAttribute("outsystems.function.key", "70b63cde-a83a-4969-9055-59ede2651c62");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserUpdateInfo: OS$DataConversion.ServerDataConverter.to(userUpdateInfoIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UpdateUser", "screenservices/ConectaProveedores/a_Common/UserProfile_DEPRECATED/ActionUpdateUser", "Bowez_paTaTI1XpaenFzaw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.UserProfile_DEPRECATED$ActionUpdateUser"))();
executeServerActionResult.updateUserResultOut = OS$DataConversion.ServerDataConverter.from(outputs.UpdateUserResult, OS$SystemStructures.UpdateUserResultRec);
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
sendChangeEmail$ServerAction(applicationNameIn, customerEmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendChangeEmail", function (span) {
if(span) {
span.setAttribute("code.function", "SendChangeEmail");
span.setAttribute("outsystems.function.key", "bfc89435-186e-4b59-9466-ec4a06915318");
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
return controller.callServerAction("SendChangeEmail", "screenservices/ConectaProveedores/a_Common/UserProfile_DEPRECATED/ActionSendChangeEmail", "cVmxBPyjBA5_1lAbHjfpvA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.UserProfile_DEPRECATED$ActionSendChangeEmail"))();
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
get getUserDetails$AggrRefresh() {if(!(this.hasOwnProperty("_getUserDetails$AggrRefresh"))) {
this._getUserDetails$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserDetails", "screenservices/ConectaProveedores/a_Common/UserProfile_DEPRECATED/ScreenDataSetGetUserDetails", "IJ45LyA89cyA8bLeN6OBrg", maxRecords, startIndex, function (b) {
model.variables.getUserDetailsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserDetailsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserDetailsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getUserDetailsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserDetails", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDetails");
span.setAttribute("outsystems.function.key", "0f5f107f-3a49-46d3-9128-dd36c98ff4f9");
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

return this._getUserDetails$AggrRefresh;
}set getUserDetails$AggrRefresh(value) {this._getUserDetails$AggrRefresh = value;
}

get getApplicationRoles$AggrRefresh() {if(!(this.hasOwnProperty("_getApplicationRoles$AggrRefresh"))) {
this._getApplicationRoles$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApplicationRoles", "screenservices/ConectaProveedores/a_Common/UserProfile_DEPRECATED/ScreenDataSetGetApplicationRoles", "9RxWe9tzZBR5X1fAE4DMEw", maxRecords, startIndex, function (b) {
model.variables.getApplicationRolesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApplicationRolesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApplicationRolesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApplicationRoles", function (span) {
if(span) {
span.setAttribute("code.function", "GetApplicationRoles");
span.setAttribute("outsystems.function.key", "64718547-2034-457e-8a46-5cb39ff3f1ed");
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

return this._getApplicationRoles$AggrRefresh;
}set getApplicationRoles$AggrRefresh(value) {this._getApplicationRoles$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserDetails$AggrRefresh", "getApplicationRoles$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_stopCountdown$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("StopCountdown", function (span) {
if(span) {
span.setAttribute("code.function", "StopCountdown");
span.setAttribute("outsystems.function.key", "01862b6f-84f0-4e1c-9f77-361b7f9f81d4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("StopCountdown");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("JSClearTimerIntervalHandle", function (span) {
if(span) {
span.setAttribute("code.function", "JSClearTimerIntervalHandle");
span.setAttribute("outsystems.function.key", "46c7a8c9-b2f2-4107-9a3e-a4e1fec75eed");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_a_Common_UserProfile_DEPRECATED_mvc_controller_StopCountdown_JSClearTimerIntervalHandleJS, "JSClearTimerIntervalHandle", "StopCountdown", {
TimerHandle: OS$DataConversion.JSNodeParamConverter.to(model.variables.timerIntervalHandleVar, OS$DataTypes.DataTypes.Object)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
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
span.setAttribute("outsystems.function.key", "3939a2f9-9651-46ae-994f-a59d05ea6f8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var isExternalUserVar = new OS$DataTypes.VariableHolder();
// Clear executing flags
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsExecuting_GetCode = False
model.variables.isExecuting_GetCodeVar = false;
// Execute Action: IsExternalUser
isExternalUserVar.value = OS$SystemActions.isExternalUser(callContext);

// Set IsExternal
// IsExternal = IsExternalUser.IsExternalUser
model.variables.isExternalVar = isExternalUserVar.value.isExternalUserOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_saveChangesOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveChangesOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveChangesOnClick");
span.setAttribute("outsystems.function.key", "4e7536ad-8064-4d66-9f18-eb786a58c8b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveChangesOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var updateUserVar = new OS$DataTypes.VariableHolder();
var finishUpdateEmailVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Execute Action: ValidateUserDetails
controller._validateUserDetails$Action(callContext);
// Is Form Valid?
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("ProfileDetailsForm")).validAttr)) {
// Changed Email?
return OS$Flow.executeSequence(function () {
if((((model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr) !== (model.variables.oldEmailVar)))) {
// Execute Action: FinishUpdateEmail
model.flush();
return OS$SystemActions.finishUpdateEmail(model.variables.verificationCodeVar, callContext).then(function (value) {
finishUpdateEmailVar.value = value;
}).then(function () {
// Success?
if((!(finishUpdateEmailVar.value.finishUpdateEmailResultOut.successAttr))) {
// Invalid Verification Code?
if((finishUpdateEmailVar.value.finishUpdateEmailResultOut.finishUpdateEmailFailureReasonAttr.invalidVerificationCodeAttr)) {
// Invalid Verification code
// VerificationCodeInput.Valid = False
model.widgets.get(idService.getId("VerificationCodeInput")).validAttr = false;
// VerificationCodeInput.ValidationMessage = "Invalid verification code"
model.widgets.get(idService.getId("VerificationCodeInput")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("j1D1Nse1ukWtah6vllgbhg#Value.23135945.1", "Invalid verification code");
}

}

});
} else {
// →
}

}).then(function () {
// Is Form valid?
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("ProfileDetailsForm")).validAttr)) {
// Execute Action: UpdateUser
model.flush();
return controller.updateUser$ServerAction(OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr, new OS$SystemStructures.UserUpdateInfoRec(), function (source, target) {
target.nameAttr = source.nameAttr;
target.photoURLAttr = source.photoUrlAttr;
return target;
}), callContext).then(function (value) {
updateUserVar.value = value;
}).then(function () {
// Success?
if((updateUserVar.value.updateUserResultOut.successAttr)) {
// Update client variables and clear local vars
// UserName = GetUserDetails.List.Current.User.Name
ConectaProveedoresClientVariables.setUserName(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr);
// UserPhotoURL = GetUserDetails.List.Current.User.PhotoUrl
ConectaProveedoresClientVariables.setUserPhotoURL(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr);
// VerificationCode = ""
model.variables.verificationCodeVar = "";
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
// ShowVerificationCode = False
model.variables.showVerificationCodeVar = false;
// ShowGetCodeButton = False
model.variables.showGetCodeButtonVar = false;
// User updated successfully
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hal2puklU0qaPqdzdA1Ybw#Message.-2024545483.1", "Your profile has been successfully updated!"), /*Success*/ 1);
// Destination: /ConectaProveedores/UserProfile_DEPRECATED
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "UserProfile_DEPRECATED", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Invalid credentials?
if((updateUserVar.value.updateUserResultOut.updateUserFailureReasonAttr.invalidCredentialsAttr)) {
// Invalid credentials.
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vtQy1LMoAUqMgKqN7SnDOw#Message.-2114236877.1", "Invalid credentials"), /*Error*/ 3);
} else {
// Invalid Name?
if((updateUserVar.value.updateUserResultOut.updateUserFailureReasonAttr.invalidNameAttr)) {
// Invalid Name
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fI0paGPW2E6KkRMZjVOKoQ#Message.633171764.1", "Invalid name"), /*Error*/ 3);
} else {
// Invalid PhotoURL?
if((updateUserVar.value.updateUserResultOut.updateUserFailureReasonAttr.invalidPhotoURLAttr)) {
// Invalid PhotoURL
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Svr7WRef3kWe00+JpUHpUQ#Message.1433973718.1", "Invalid photo URL."), /*Error*/ 3);
} else {
// Update user failed.
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tKonquYwJECrkdpEc7Wtpw#Message.1913925139.1", "Update user failed."), /*Error*/ 3);
// IsExecuting = False
// IsExecuting = False
model.variables.isExecutingVar = false;
return OS$Flow.returnAsync();

}

}

}

// IsExecuting = False
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
} else {
// IsExecuting = False
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
});
} else {
// IsExecuting = False
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
}).catch(function (ex) {
OS$Logger.debug("UserProfile_DEPRECATED.SaveChangesOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "6fc58061-77c7-4d1b-8160-b57dbee8e1b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Exception Message
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// IsExecuting = False
// IsExecuting = False
model.variables.isExecutingVar = false;
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
_updateCountdown$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UpdateCountdown", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateCountdown");
span.setAttribute("outsystems.function.key", "53ee8e5d-6b6b-4b43-8993-5f995fed1652");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UpdateCountdown");
callContext = controller.callContext(callContext);
// --CountdownValue
// CountdownValue = CountdownValue - 1
model.variables.countdownValueVar = (model.variables.countdownValueVar - 1);
// Countdown ended?
if(((model.variables.countdownValueVar <= 0))) {
// Execute Action: StopCountdown
controller._stopCountdown$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_sendVerificationCode$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SendVerificationCode", function (span) {
if(span) {
span.setAttribute("code.function", "SendVerificationCode");
span.setAttribute("outsystems.function.key", "7ddd9475-737d-48b4-a9e0-bc2d7e4780ae");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SendVerificationCode");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var sendChangeEmailVar = new OS$DataTypes.VariableHolder();
var jsSetIntervalJSResult = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Email Changed?
return OS$Flow.executeSequence(function () {
if((((model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr) !== (model.variables.oldEmailVar)))) {
// IsExecuting_GetCode = True
// IsExecuting_GetCode = True
model.variables.isExecuting_GetCodeVar = true;
// Execute Action: ValidateUserDetails
controller._validateUserDetails$Action(callContext);
// Execute Action: SendChangeEmail
model.flush();
return controller.sendChangeEmail$ServerAction(OS$BuiltinFunctions.getAppName(), model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, callContext).then(function (value) {
sendChangeEmailVar.value = value;
}).then(function () {
// Success?
if((sendChangeEmailVar.value.successOut)) {
// Verification Code Sent
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ELxB2vA1dkKRoVbli9KPOw#Message.-79964080.1", "A verification code was sent to your email"), /*Info*/ 0);
// Set Verification Code Vars
// ShowVerificationCode = True
model.variables.showVerificationCodeVar = true;
// CountdownValue = 5
model.variables.countdownValueVar = 5;
// Disable send code button for N-seconds.
jsSetIntervalJSResult.value = OS$Logger.startActiveSpan("JsSetInterval", function (span) {
if(span) {
span.setAttribute("code.function", "JsSetInterval");
span.setAttribute("outsystems.function.key", "698bd723-3610-4f81-a389-db9d143d51ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_a_Common_UserProfile_DEPRECATED_mvc_controller_SendVerificationCode_JsSetIntervalJS, "JsSetInterval", "SendVerificationCode", {
IntervalDuration: OS$DataConversion.JSNodeParamConverter.to(model.variables.intervalDurationVar, OS$DataTypes.DataTypes.Integer),
TimerHandle: OS$DataConversion.JSNodeParamConverter.to(null, OS$DataTypes.DataTypes.Object)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.UserProfile_DEPRECATED.SendVerificationCode$jsSetIntervalJSResult"))();
jsNodeResult.timerHandleOut = OS$DataConversion.JSNodeParamConverter.from($parameters.TimerHandle, OS$DataTypes.DataTypes.Object);
return jsNodeResult;
}, {
UpdateCountdown: controller.clientActionProxies.updateCountdown$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Set IntervalId
// TimerIntervalHandle = JsSetInterval.TimerHandle
model.variables.timerIntervalHandleVar = jsSetIntervalJSResult.value.timerHandleOut;
// IsExecuting_GetCode = False
// IsExecuting_GetCode = False
model.variables.isExecuting_GetCodeVar = false;
} else {
// IsExecuting_GetCode = False
// IsExecuting_GetCode = False
model.variables.isExecuting_GetCodeVar = false;
// Unable to send email
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0xJnrCCMIE27gmrh0oS1HQ#Message.1280536335.1", "Unable to send email. Please try again later."), /*Error*/ 3);
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("UserProfile_DEPRECATED.SendVerificationCode", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "00be22d9-1f87-4f3c-abb3-938232eb4065");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Exception Message
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// IsExecuting_GetCode = False
// IsExecuting_GetCode = False
model.variables.isExecuting_GetCodeVar = false;
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
_validateInputsOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateInputsOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateInputsOnChange");
span.setAttribute("outsystems.function.key", "85da9908-bb3c-4a9d-adab-fd77c9be5045");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateInputsOnChange");
callContext = controller.callContext(callContext);
// Set Show Get Code Button
// ShowGetCodeButton = OldEmail <> GetUserDetails.List.Current.User.Email and Trim <> "" and EmailAddressValidate
model.variables.showGetCodeButtonVar = ((((model.variables.oldEmailVar) !== (model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr)) && ((OS$BuiltinFunctions.trim(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr)) !== (""))) && OS$BuiltinFunctions.emailAddressValidate(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr));
// Execute Action: ValidateUserDetails
controller._validateUserDetails$Action(callContext);
// Execute Action: CheckIsButtonEnabled
controller._checkIsButtonEnabled$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validateUserDetails$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateUserDetails", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateUserDetails");
span.setAttribute("outsystems.function.key", "8eab9c0b-0877-468f-91c2-8da09215d3be");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateUserDetails");
callContext = controller.callContext(callContext);
// Is Email Valid?
if(((((OS$BuiltinFunctions.trim(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr)) !== ("")) && OS$BuiltinFunctions.emailAddressValidate(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr)))) {
// Email Valid = True
// EmailInput.Valid = True
model.widgets.get(idService.getId("EmailInput")).validAttr = true;
// EmailInput.ValidationMessage = ""
model.widgets.get(idService.getId("EmailInput")).validationMessageAttr = "";
} else {
// Email Valid = False
// EmailInput.Valid = False
model.widgets.get(idService.getId("EmailInput")).validAttr = false;
// EmailInput.ValidationMessage = "Please enter a valid email address"
model.widgets.get(idService.getId("EmailInput")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DnGqFRN2v0KGqZ7axH6xVw#Value.1202984367.1", "Please enter a valid email address");
}

// Has Name?
if((((OS$BuiltinFunctions.trim(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)) !== ("")))) {
// Name Valid = True
// NameInput.Valid = True
model.widgets.get(idService.getId("NameInput")).validAttr = true;
// NameInput.ValidationMessage = ""
model.widgets.get(idService.getId("NameInput")).validationMessageAttr = "";
} else {
// Name Valid = False
// NameInput.Valid = False
model.widgets.get(idService.getId("NameInput")).validAttr = false;
// NameInput.ValidationMessage = "Please enter a valid name"
model.widgets.get(idService.getId("NameInput")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AtAJ+OeBz0+WC_bs7+r_fQ#Value.1693038956.1", "Please enter a valid name");
}

// Show Get Code Button?
if(((model.variables.showGetCodeButtonVar && model.variables.showVerificationCodeVar))) {
// Has Verification Code?
if((((OS$BuiltinFunctions.trim(model.variables.verificationCodeVar)) !== ("")))) {
// VerificationCodeValid = True
// VerificationCodeInput.Valid = True
model.widgets.get(idService.getId("VerificationCodeInput")).validAttr = true;
// VerificationCodeInput.ValidationMessage = ""
model.widgets.get(idService.getId("VerificationCodeInput")).validationMessageAttr = "";
} else {
// VerificationCode Valid = False
// VerificationCodeInput.Valid = False
model.widgets.get(idService.getId("VerificationCodeInput")).validAttr = false;
// VerificationCodeInput.ValidationMessage = "Invalid verification code"
model.widgets.get(idService.getId("VerificationCodeInput")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BcJVn9uGfEWO+GoValdw2w#Value.23135945.1", "Invalid verification code");
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
_getUserDetailsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserDetailsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDetailsOnAfterFetch");
span.setAttribute("outsystems.function.key", "9f6a1be3-c855-462f-83e6-65a795c1f767");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetUserDetailsOnAfterFetch");
callContext = controller.callContext(callContext);
// Logged User?
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Store Initial User Details
// OldName = GetUserDetails.List.Current.User.Name
model.variables.oldNameVar = model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr;
// OldPhotoURL = GetUserDetails.List.Current.User.PhotoUrl
model.variables.oldPhotoURLVar = model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr;
// OldEmail = GetUserDetails.List.Current.User.Email
model.variables.oldEmailVar = model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onDestroy$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "a993f5ee-f706-42df-8b86-0b0276e76dd2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: StopCountdown
controller._stopCountdown$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_checkIsButtonEnabled$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckIsButtonEnabled", function (span) {
if(span) {
span.setAttribute("code.function", "CheckIsButtonEnabled");
span.setAttribute("outsystems.function.key", "d6c76eb3-de07-4a03-abf5-5fa43fe11940");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckIsButtonEnabled");
callContext = controller.callContext(callContext);
// Name or Photo Changed?
if((((((model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr) !== (model.variables.oldNameVar)) || ((model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr) !== (model.variables.oldPhotoURLVar))) && (model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr === model.variables.oldEmailVar)))) {
// IsButtonEnabled = true
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
} else {
// Email changed?
if((((model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr) !== (model.variables.oldEmailVar)))) {
// Has code been sent?
if((model.variables.showVerificationCodeVar)) {
// Verification code added?
if(((OS$BuiltinFunctions.length(model.variables.verificationCodeVar) === 6))) {
// IsButtonEnabled = true
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
return ;

}

}

}

// IsButtonEnabled = false
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

stopCountdown$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("StopCountdown__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StopCountdown");
span.setAttribute("outsystems.function.key", "01862b6f-84f0-4e1c-9f77-361b7f9f81d4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._stopCountdown$Action, callContext);
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
span.setAttribute("outsystems.function.key", "3939a2f9-9651-46ae-994f-a59d05ea6f8d");
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

saveChangesOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveChangesOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveChangesOnClick");
span.setAttribute("outsystems.function.key", "4e7536ad-8064-4d66-9f18-eb786a58c8b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveChangesOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

updateCountdown$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UpdateCountdown__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UpdateCountdown");
span.setAttribute("outsystems.function.key", "53ee8e5d-6b6b-4b43-8993-5f995fed1652");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._updateCountdown$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

sendVerificationCode$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendVerificationCode__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SendVerificationCode");
span.setAttribute("outsystems.function.key", "7ddd9475-737d-48b4-a9e0-bc2d7e4780ae");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._sendVerificationCode$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

validateInputsOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateInputsOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateInputsOnChange");
span.setAttribute("outsystems.function.key", "85da9908-bb3c-4a9d-adab-fd77c9be5045");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateInputsOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validateUserDetails$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateUserDetails__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateUserDetails");
span.setAttribute("outsystems.function.key", "8eab9c0b-0877-468f-91c2-8da09215d3be");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateUserDetails$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getUserDetailsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserDetailsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDetailsOnAfterFetch");
span.setAttribute("outsystems.function.key", "9f6a1be3-c855-462f-83e6-65a795c1f767");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getUserDetailsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "a993f5ee-f706-42df-8b86-0b0276e76dd2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onDestroy$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

checkIsButtonEnabled$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckIsButtonEnabled__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckIsButtonEnabled");
span.setAttribute("outsystems.function.key", "d6c76eb3-de07-4a03-abf5-5fa43fe11940");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkIsButtonEnabled$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

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
this._onDestroyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onDestroy$Action(callContext);

};
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
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ConectaProveedores]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.UserProfile_DEPRECATED$ActionUpdateUser", [{
name: "UpdateUserResult",
attrName: "updateUserResultOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new OS$SystemStructures.UpdateUserResultRec();
},
complexType: OS$SystemStructures.UpdateUserResultRec
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.UserProfile_DEPRECATED$ActionSendChangeEmail", [{
name: "Success",
attrName: "successOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.UserProfile_DEPRECATED.SendVerificationCode$jsSetIntervalJSResult", [{
name: "TimerHandle",
attrName: "timerHandleOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Object,
defaultValue: function () {
return null;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


