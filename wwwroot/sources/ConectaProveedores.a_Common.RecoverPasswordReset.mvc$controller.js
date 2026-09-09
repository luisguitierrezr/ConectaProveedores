import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { showPassword$Action as OutSystemsUIController$showPassword$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_a_Common_RecoverPasswordReset_mvc_TranslationsResources from "./ConectaProveedores.a_Common.RecoverPasswordReset.mvc$translationsResources.js";
import ConectaProveedores_a_CommonController$default from "./ConectaProveedores.a_Common.controller.js";
import ConectaProveedoresController$default, { doLogin$Action as ConectaProveedoresController$doLogin$Action } from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_RecoverPasswordReset_mvc_TranslationsResources);
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
grant$ServerAction(emailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Grant", function (span) {
if(span) {
span.setAttribute("code.function", "Grant");
span.setAttribute("outsystems.function.key", "3c34c91b-7989-476c-a9fb-a977f6f1e7ef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Email: OS$DataConversion.ServerDataConverter.to(emailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Grant", "screenservices/ConectaProveedores/a_Common/RecoverPasswordReset/ActionGrant", "glDztMTMAV8qGnd945xIuA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
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
return controller.callServerAction("ServiceUserManagementLogsCreate", "screenservices/ConectaProveedores/a_Common/RecoverPasswordReset/ServiceAPIServiceUserManagementLogsCreate", "XChAQnXYflYYarSITwmL4w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordReset$ServiceAPIServiceUserManagementLogsCreate"))();
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
return controller.callServerAction("CheckOldPassword", "screenservices/ConectaProveedores/a_Common/RecoverPasswordReset/ServiceAPICheckOldPassword", "RqS1jmY6gGhONwLd9DsLcw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordReset$ServiceAPICheckOldPassword"))();
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
savePassword$ServerAction(i_PasswordIn, i_EmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SavePassword", function (span) {
if(span) {
span.setAttribute("code.function", "SavePassword");
span.setAttribute("outsystems.function.key", "71b907cc-aac9-4a62-a474-b1e0da09e4ab");
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
return controller.callServerAction("SavePassword", "screenservices/ConectaProveedores/a_Common/RecoverPasswordReset/ServiceAPISavePassword", "0yIpwxpi+zq5A2vTf0b5DA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callDataAction("DataActionGetSettingsEnviroment", "screenservices/ConectaProveedores/a_Common/RecoverPasswordReset/DataActionGetSettingsEnviroment", "hz8SvQr3tsgaFFBBoTRz0Q", function (b) {
model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsEnviromentDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsEnviromentDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettingsEnviroment", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsEnviroment");
span.setAttribute("outsystems.function.key", "d40d67d0-1008-415a-9d41-7a68f2e40dd7");
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
_passwordPolicyCompliant$Action(isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PasswordPolicyCompliant", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "5daacc87-042d-496f-b2e5-ceeb36778e92");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PasswordPolicyCompliant");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordReset.PasswordPolicyCompliant$vars"))());
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
_input_ConfirmPasswordOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_ConfirmPasswordOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "5eca7252-a4ae-44bb-af74-76a5230b6146");
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
_onTogglePasswordVisibility$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnTogglePasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "6b47eae9-6b58-4c2a-99b5-a23367bdea3a");
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
_savePasswordOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SavePasswordOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SavePasswordOnClick");
span.setAttribute("outsystems.function.key", "8ee08f37-32b0-43ca-87e0-c49da7dcae74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SavePasswordOnClick");
callContext = controller.callContext(callContext);
var serviceUserManagementLogsCreate7Var = new OS$DataTypes.VariableHolder();
var checkOldPasswordVar = new OS$DataTypes.VariableHolder();
var doLoginVar = new OS$DataTypes.VariableHolder();
var finishResetPasswordVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("PasswordResetForm")).validAttr)) {
return OS$Flow.executeSequence(function () {
if((model.variables.isButtonEnabledVar)) {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Passwords match?
return OS$Flow.executeSequence(function () {
if(((model.variables.newPasswordVar === model.variables.confirmPasswordVar))) {
// Execute Action: CheckOldPassword
model.flush();
return controller.checkOldPassword$ServerAction(model.variables.newPasswordVar, model.variables.emailVar, callContext).then(function (value) {
checkOldPasswordVar.value = value;
}).then(function () {
// Is not one of the old passwords?
return OS$Flow.executeSequence(function () {
if(((!(checkOldPasswordVar.value.o_IsOldOut)))) {
// Execute Action: FinishResetPassword
model.flush();
return OS$SystemActions.finishResetPassword(model.variables.emailVar, model.variables.verificationCodeVar, model.variables.newPasswordVar, callContext).then(function (value) {
finishResetPasswordVar.value = value;
}).then(function () {
// Reset successful?
return OS$Flow.executeSequence(function () {
if((finishResetPasswordVar.value.finishResetPasswordResultOut.successAttr)) {
// Execute Action: DoLogin
model.flush();
return ConectaProveedoresController$doLogin$Action(model.variables.emailVar, model.variables.newPasswordVar, model.variables.getSettingsEnviromentDataAct.environmentOut, callContext).then(function (value) {
doLoginVar.value = value;
}).then(function () {
// Execute Action: Grant
model.flush();
return controller.grant$ServerAction(model.variables.emailVar, callContext);
}).then(function () {
// Execute Action: ServiceUserManagementLogsCreate7
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(doLoginVar.value.userIdOut, ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FvWymm0n8UKakGLecLo15A#Value.-1169046086.1", "The user has successfully changed their password") + ": ") + model.variables.emailVar), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate7Var.value = value;
});
}).then(function () {
// Execute Action: SavePassword
model.flush();
return controller.savePassword$ServerAction(model.variables.newPasswordVar, model.variables.emailVar, callContext);
}).then(function () {
// Execute Action: Logout
model.flush();
return OS$SystemActions.logout(callContext);
}).then(function () {
// Password changed successfully
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("knW5Ril7+EWI1Bg7RLowJg#Message.1417346719.1", "Your password was changed successfully!"), /*Success*/ 1);
// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {
IsResetPassword: OS$DataConversion.ServerDataConverter.to(true, {
dataType: OS$DataTypes.DataTypes.Boolean
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
} else {
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// Password Complexity Failed?
if((finishResetPasswordVar.value.finishResetPasswordResultOut.finishResetPasswordFailureReasonAttr.passwordComplexityPolicyFailedAttr)) {
// Password invalid
// Input_NewPassword.Valid = False
model.widgets.get(idService.getId("Input_NewPassword")).validAttr = false;
// Input_NewPassword.ValidationMessage = "The password does not meet the requirements."
model.widgets.get(idService.getId("Input_NewPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("MJdE2ft1dEW_FHUZQDgZww#Value.-1284253708.1", "The password does not meet the requirements.");
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Invalid Reset Token?
if((finishResetPasswordVar.value.finishResetPasswordResultOut.finishResetPasswordFailureReasonAttr.invalidVerificationCodeAttr)) {
// Invalid code
// Input_Code.Valid = False
model.widgets.get(idService.getId("Input_Code")).validAttr = false;
// Input_Code.ValidationMessage = "The code is invalid."
model.widgets.get(idService.getId("Input_Code")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jSXPntvE3kOq_HslNeHOhA#Value.699937161.1", "The code is invalid.");
} else {
// Unkown Error
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XOi8EG1rREOjQUK3vnbHUQ#Message.-144204223.1", "An unknown error occured. Please try again later."), /*Error*/ 3);
}

}

}

});
});
} else {
// Password doesn't match
// Input_ConfirmPassword.Valid = False
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = false;
// Input_ConfirmPassword.ValidationMessage = "You cannot reuse a password that was used in your last five password changes."
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("G523zIswMEKu11DRQ5FGRQ#Value.-230807447.1", "You cannot reuse a password that was used in your last five password changes.");
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
});
} else {
// Password doesn't match
// Input_ConfirmPassword.Valid = False
model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr = false;
// Input_ConfirmPassword.ValidationMessage = "Passwords doesn't match."
model.widgets.get(idService.getId("Input_ConfirmPassword")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("w+zQhbPkUEioHUCptrjuRw#Value.-166790161.1", "Passwords doesn\'t match.");
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
}

});
}

});
} else {
// Disable Button
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
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
_input_CodeOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_CodeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_CodeOnChange");
span.setAttribute("outsystems.function.key", "d76a7e1a-9641-4607-8a3d-e1ae1c1ddb89");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_CodeOnChange");
callContext = controller.callContext(callContext);
// Execute Action: SetIsButtonEnabled
controller._setIsButtonEnabled$Action(callContext);
// IsEmpty
if(((model.variables.verificationCodeVar === ""))) {
// ClearErrors
// Input_Code.Valid = True
model.widgets.get(idService.getId("Input_Code")).validAttr = true;
// Input_Code.ValidationMessage = ""
model.widgets.get(idService.getId("Input_Code")).validationMessageAttr = "";
}

} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "f0bf0d0f-6564-4593-957b-d6e4b44703ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetIsButtonEnabled");
callContext = controller.callContext(callContext);
// Is Code Empty?
if(((model.variables.verificationCodeVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword Empty?
if(((model.variables.newPasswordVar === ""))) {
// DisableButton
// IsButtonEnabled = False
model.variables.isButtonEnabledVar = false;
} else {
// Is NewPassword Compliant?
if((model.variables.isNewPasswordCompliantVar)) {
// Is ConfirmPassword Empty?
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

passwordPolicyCompliant$Action(isValidIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PasswordPolicyCompliant__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PasswordPolicyCompliant");
span.setAttribute("outsystems.function.key", "5daacc87-042d-496f-b2e5-ceeb36778e92");
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

input_ConfirmPasswordOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_ConfirmPasswordOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ConfirmPasswordOnChange");
span.setAttribute("outsystems.function.key", "5eca7252-a4ae-44bb-af74-76a5230b6146");
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

onTogglePasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnTogglePasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "6b47eae9-6b58-4c2a-99b5-a23367bdea3a");
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

savePasswordOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SavePasswordOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SavePasswordOnClick");
span.setAttribute("outsystems.function.key", "8ee08f37-32b0-43ca-87e0-c49da7dcae74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._savePasswordOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

input_CodeOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_CodeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_CodeOnChange");
span.setAttribute("outsystems.function.key", "d76a7e1a-9641-4607-8a3d-e1ae1c1ddb89");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_CodeOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setIsButtonEnabled$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetIsButtonEnabled__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetIsButtonEnabled");
span.setAttribute("outsystems.function.key", "f0bf0d0f-6564-4593-957b-d6e4b44703ee");
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordReset$ServiceAPIServiceUserManagementLogsCreate", [{
name: "Id",
attrName: "idOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordReset$ServiceAPICheckOldPassword", [{
name: "o_IsOld",
attrName: "o_IsOldOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.RecoverPasswordReset.PasswordPolicyCompliant$vars", [{
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


