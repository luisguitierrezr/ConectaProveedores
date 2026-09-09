import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { showPassword$Action as OutSystemsUIController$showPassword$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_a_Common_ChangePassword_mvc_TranslationsResources from "./ConectaProveedores.a_Common.ChangePassword.mvc$translationsResources.js";
import ConectaProveedores_a_CommonController$default from "./ConectaProveedores.a_Common.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_ChangePassword_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getUserDetail$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserDetail$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
checkOldPassword$ServerAction(i_PasswordIn, i_EmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckOldPassword", function (span) {
if(span) {
span.setAttribute("code.function", "CheckOldPassword");
span.setAttribute("outsystems.function.key", "4880bc42-1e57-4af5-bb5b-8cc1b1999ae9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Password: OS$DataConversion.ServerDataConverter.to(i_PasswordIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Email: OS$DataConversion.ServerDataConverter.to(i_EmailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("CheckOldPassword", "screenservices/ConectaProveedores/a_Common/ChangePassword/ServiceAPICheckOldPassword", "RqS1jmY6gGhONwLd9DsLcw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.ChangePassword$ServiceAPICheckOldPassword"))();
executeServerActionResult.o_IsOldOut = OS$DataConversion.ServerDataConverter.from(outputs.o_IsOld, OS$DataTypes.DataTypes.Boolean);
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
get getUserDetail$AggrRefresh() {if(!(this.hasOwnProperty("_getUserDetail$AggrRefresh"))) {
this._getUserDetail$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserDetail", "screenservices/ConectaProveedores/a_Common/ChangePassword/ScreenDataSetGetUserDetail", "CktDaOIkWKeDvBOKJxRhuQ", maxRecords, startIndex, function (b) {
model.variables.getUserDetailAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserDetailAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserDetailAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserDetail", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDetail");
span.setAttribute("outsystems.function.key", "99935c79-947f-49d9-a2bc-096c0afc7b20");
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

return this._getUserDetail$AggrRefresh;
}set getUserDetail$AggrRefresh(value) {this._getUserDetail$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserDetail$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_passwordPolicyCompliant$Action(isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PasswordPolicyCompliant", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "07728f75-ef37-4ffd-849b-433e8232002e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PasswordPolicyCompliant");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.ChangePassword.PasswordPolicyCompliant$vars"))());
vars.value.isValidInLocal = isValidIn;
// IsNewPasswordCompliant = IsValid
model.variables.isNewPasswordCompliantVar = vars.value.isValidInLocal;
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_input_OldPasswordOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_OldPasswordOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_OldPasswordOnChange");
span.setAttribute("outsystems.function.key", "63c4eaad-2473-4408-859f-e6820a94c7a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_OldPasswordOnChange");
callContext = controller.callContext(callContext);
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_setNewPasswordOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetNewPasswordOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetNewPasswordOnClick");
span.setAttribute("outsystems.function.key", "944ade75-c90e-4b11-8da9-58b8d75db121");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SetNewPasswordOnClick");
callContext = controller.callContext(callContext);
var checkOldPasswordVar = new OS$DataTypes.VariableHolder();
var changePasswordVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Passwords matches?
return OS$Flow.executeSequence(function () {
if(((model.variables.newPasswordVar === model.variables.confirmPasswordVar))) {
// Execute Action: CheckOldPassword
model.flush();
return controller.checkOldPassword$ServerAction(model.variables.newPasswordVar, model.variables.getUserDetailAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, callContext).then(function (value) {
checkOldPasswordVar.value = value;
}).then(function () {
// Is not one of the old passwords?
return OS$Flow.executeSequence(function () {
if(((!(checkOldPasswordVar.value.o_IsOldOut)))) {
// Execute Action: ChangePassword
model.flush();
return OS$SystemActions.changePassword(model.variables.getUserDetailAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, model.variables.newPasswordVar, model.variables.oldPasswordVar, callContext).then(function (value) {
changePasswordVar.value = value;
}).then(function () {
// Success?
if((changePasswordVar.value.changePasswordResultOut.successAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hPAPSLxuQEOsB2rBTsYVRA#Message.-122279263.1", "Password successfully changed!"), /*Success*/ 1);
// Destination: /ConectaProveedores/UserProfile
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "UserProfile", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// Invalid Credentials?
if((changePasswordVar.value.changePasswordResultOut.changePasswordFailureReasonAttr.invalidCredentialsAttr)) {
// Password invalid
// Input_OldPassword.Valid = False
model.widgets.get(idService.getId("Input_OldPassword")).validAttr = false;
// Input_OldPassword.ValidationMessage = "Incorrect password."
model.widgets.get(idService.getId("Input_OldPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FIBI39yYE0Kd_coNevtnoQ#Value.-1852870120.1", "Incorrect password.");
} else {
// Password Complexity Failed?
if((changePasswordVar.value.changePasswordResultOut.changePasswordFailureReasonAttr.passwordComplexityPolicyFailedAttr)) {
// Complexity Failed
// Input_NewPassword.Valid = False
model.widgets.get(idService.getId("Input_NewPassword")).validAttr = false;
// Input_NewPassword.ValidationMessage = "Password doesn't meet the requirements."
model.widgets.get(idService.getId("Input_NewPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KHl1FwfYN0ChdE1S6v5zoA#Value.-813044871.1", "Password doesn\'t meet the requirements.");
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Number of Attempts Failed?
if((changePasswordVar.value.changePasswordResultOut.changePasswordFailureReasonAttr.tooManyFailedAttemptsAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5QgVmH_ILE2RzLj1mjXxHg#Message.935977324.1", "Too many failed attempts, please try again after some time."), /*Error*/ 3);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1KWylhM5B0Cg3xKIjc2ZsQ#Message.341658693.1", "An unknown error occurred. Please try again later."), /*Error*/ 3);
}

}

}

}

});
} else {
// Password doesn't match
// Input_ConfirmPassword.Valid = False
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = false;
// Input_ConfirmPassword.ValidationMessage = "You cannot reuse a password that was used in your last five password changes."
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zorF7+Zm402mv2xQ3CORzQ#Value.-230807447.1", "You cannot reuse a password that was used in your last five password changes.");
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
});
} else {
// Passwords don't match
// Input_ConfirmPassword.Valid = False
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = false;
// Input_ConfirmPassword.ValidationMessage = "Password and Confirm password don't match."
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+ekgsak_Ok6BcgG8q5LuQg#Value.597282480.1", "Password and Confirm password don\'t match.");
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
}

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
_setIsButtonEnabled$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetIsButtonEnabled", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "98a42af6-fda1-4ebd-9c87-d5c7dee35c93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetIsButtonEnabled");
callContext = controller.callContext(callContext);
// Is OldPassword empty?
if(((model.variables.oldPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword empty?
if(((model.variables.newPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword compliant?
if((model.variables.isNewPasswordCompliantVar)) {
// Is ConfirmPassword empty?
if(((model.variables.confirmPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// EnableButton
// IsButtonEnabled = True
model.variables.isButtonEnabledVar = true;
}

} else {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
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
_onTogglePasswordVisibility$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnTogglePasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "bb2480a2-2568-4d6b-bd97-9e3a21650114");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnTogglePasswordVisibility");
callContext = controller.callContext(callContext);
var showPassword2Var = new OS$DataTypes.VariableHolder();
var showPasswordVar = new OS$DataTypes.VariableHolder();
// IsPasswordVisible = notIsPasswordVisible
model.variables.isPasswordVisibleVar = (!(model.variables.isPasswordVisibleVar));
// IsConfirmPasswordVisible = notIsConfirmPasswordVisible
model.variables.isConfirmPasswordVisibleVar = (!(model.variables.isConfirmPasswordVisibleVar));
// Execute Action: ShowPassword
showPasswordVar.value = OutSystemsUIController$showPassword$Action(idService.getId("Input_NewPassword"), callContext);

// Execute Action: ShowPassword2
showPassword2Var.value = OutSystemsUIController$showPassword$Action(idService.getId("Input_ConfirmPassword"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_input_ConfirmPasswordOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_ConfirmPasswordOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "da321b80-6d94-4e9d-916d-2c73bb41746a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_ConfirmPasswordOnChange");
callContext = controller.callContext(callContext);
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
// IsEmpty
if(((model.variables.confirmPasswordVar === ""))) {
// ClearErrors
// Input_ConfirmPassword.Valid = True
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = true;
// Input_ConfirmPassword.ValidationMessage = ""
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = "";
}

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
span.setAttribute("outsystems.function.key", "f3b60a7a-65ad-4ea9-97f6-9b913c5ba8d9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// IsExternalUser
if((OS$SystemActions.isExternalUser(callContext).isExternalUserOut)) {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

passwordPolicyCompliant$Action(isValidIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PasswordPolicyCompliant__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "07728f75-ef37-4ffd-849b-433e8232002e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._passwordPolicyCompliant$Action, callContext, isValidIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_OldPasswordOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_OldPasswordOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_OldPasswordOnChange");
span.setAttribute("outsystems.function.key", "63c4eaad-2473-4408-859f-e6820a94c7a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_OldPasswordOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setNewPasswordOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetNewPasswordOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetNewPasswordOnClick");
span.setAttribute("outsystems.function.key", "944ade75-c90e-4b11-8da9-58b8d75db121");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._setNewPasswordOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setIsButtonEnabled$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetIsButtonEnabled__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "98a42af6-fda1-4ebd-9c87-d5c7dee35c93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setIsButtonEnabled$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onTogglePasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnTogglePasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "bb2480a2-2568-4d6b-bd97-9e3a21650114");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onTogglePasswordVisibility$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_ConfirmPasswordOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_ConfirmPasswordOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "da321b80-6d94-4e9d-916d-2c73bb41746a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_ConfirmPasswordOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "f3b60a7a-65ad-4ea9-97f6-9b913c5ba8d9");
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.ChangePassword$ServiceAPICheckOldPassword", [{
name: "o_IsOld",
attrName: "o_IsOldOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.ChangePassword.PasswordPolicyCompliant$vars", [{
name: "IsValid",
attrName: "isValidInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


