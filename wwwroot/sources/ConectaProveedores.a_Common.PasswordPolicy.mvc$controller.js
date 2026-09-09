import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_a_Common_PasswordPolicy_mvc_TranslationsResources from "./ConectaProveedores.a_Common.PasswordPolicy.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_PasswordPolicy_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getMaxSavedOldPasswords$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getMaxSavedOldPasswords$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
regex_Search$ServerAction(textIn, regexPatternIn, ignoreCaseIn, multiLineIn, singleLineIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Regex_Search", function (span) {
if(span) {
span.setAttribute("code.function", "Regex_Search");
span.setAttribute("outsystems.function.key", "8494954b-2c53-4ae1-8d94-e300f15a170f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Text: OS$DataConversion.ServerDataConverter.to(textIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
RegexPattern: OS$DataConversion.ServerDataConverter.to(regexPatternIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IgnoreCase: OS$DataConversion.ServerDataConverter.to(ignoreCaseIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
MultiLine: OS$DataConversion.ServerDataConverter.to(multiLineIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
SingleLine: OS$DataConversion.ServerDataConverter.to(singleLineIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Regex_Search", "screenservices/ConectaProveedores/a_Common/PasswordPolicy/ActionRegex_Search", "0RNj1XdbNqYLZQCPjMBV1Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.PasswordPolicy$ActionRegex_Search"))();
executeServerActionResult.foundOut = OS$DataConversion.ServerDataConverter.from(outputs.Found, OS$DataTypes.DataTypes.Boolean);
executeServerActionResult.patternResultOut = OS$DataConversion.ServerDataConverter.from(outputs.PatternResult, OS$DataTypes.DataTypes.Text);
executeServerActionResult.firstIndexOut = OS$DataConversion.ServerDataConverter.from(outputs.FirstIndex, OS$DataTypes.DataTypes.Integer);
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
get getMaxSavedOldPasswords$DataActRefresh() {if(!(this.hasOwnProperty("_getMaxSavedOldPasswords$DataActRefresh"))) {
this._getMaxSavedOldPasswords$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetMaxSavedOldPasswords", "screenservices/ConectaProveedores/a_Common/PasswordPolicy/DataActionGetMaxSavedOldPasswords", "nlg6IcraLHUyaVbV8TO16g", function (b) {
model.variables.getMaxSavedOldPasswordsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getMaxSavedOldPasswordsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getMaxSavedOldPasswordsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetMaxSavedOldPasswords", function (span) {
if(span) {
span.setAttribute("code.function", "GetMaxSavedOldPasswords");
span.setAttribute("outsystems.function.key", "cec9ea1c-8d2b-414c-b2f2-2e0be51e85ac");
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

return this._getMaxSavedOldPasswords$DataActRefresh;
}set getMaxSavedOldPasswords$DataActRefresh(value) {this._getMaxSavedOldPasswords$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getMaxSavedOldPasswords$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "032b6c7a-8433-42c8-829e-3acdbfd27a6a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var regex_SearchVar = new OS$DataTypes.VariableHolder();
var validatePasswordComplexityVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ValidatePasswordComplexity
validatePasswordComplexityVar.value = OS$SystemActions.validatePasswordComplexity(model.variables.passwordIn, callContext);

// PasswordValidationResult
// PasswordValidationResult.IsValid = ValidatePasswordComplexity.PasswordValidationResult.IsValid
model.variables.passwordValidationResultVar.isValidAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr;
// PasswordValidationResult.MissingLowerCaseLetter = ValidatePasswordComplexity.PasswordValidationResult.MissingLowerCaseLetter
model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingLowerCaseLetterAttr;
// PasswordValidationResult.MissingMinimumLength = ValidatePasswordComplexity.PasswordValidationResult.MissingMinimumLength
model.variables.passwordValidationResultVar.missingMinimumLengthAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingMinimumLengthAttr;
// PasswordValidationResult.MissingUpperCaseLetter = ValidatePasswordComplexity.PasswordValidationResult.MissingUpperCaseLetter
model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingUpperCaseLetterAttr;
// PasswordValidationResult.MissingNumber = ValidatePasswordComplexity.PasswordValidationResult.MissingNumber
model.variables.passwordValidationResultVar.missingNumberAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingNumberAttr;
// PasswordValidationResult.MissingSpecialCharacter = ValidatePasswordComplexity.PasswordValidationResult.MissingSpecialCharacter
model.variables.passwordValidationResultVar.missingSpecialCharacterAttr = validatePasswordComplexityVar.value.passwordValidationResultOut.missingSpecialCharacterAttr;
// Execute Action: Regex_Search
model.flush();
return controller.regex_Search$ServerAction(model.variables.passwordIn, "^(?=.*[^a-zA-Z0-9]).+$", true, false, false, callContext).then(function (value) {
regex_SearchVar.value = value;
}).then(function () {
if((regex_SearchVar.value.foundOut)) {
// IsMissingSpecialCharacter = False
model.variables.isMissingSpecialCharacterVar = false;
} else {
// Set False
// ValidatePasswordComplexity.PasswordValidationResult.IsValid = False
validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr = false;
// IsMissingSpecialCharacter = True
model.variables.isMissingSpecialCharacterVar = true;
}

// Is valid?
if((validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr)) {
if((model.variables.isValidPasswordVar)) {
return OS$Flow.returnAsync();

} else {
// Set as valid
// IsValidPassword = True
model.variables.isValidPasswordVar = true;
}

} else {
if((model.variables.isValidPasswordVar)) {
// Set as invalid
// IsValidPassword = False
model.variables.isValidPasswordVar = false;
} else {
return OS$Flow.returnAsync();

}

}

// Trigger Event: Compliant
return controller.compliant$Action(validatePasswordComplexityVar.value.passwordValidationResultOut.isValidAttr, callContext);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "59e2359d-ea7f-437b-ac84-c32335fc8dfe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var getPasswordComplexityPolicyVar = new OS$DataTypes.VariableHolder();
// Execute Action: GetPasswordComplexityPolicy
getPasswordComplexityPolicyVar.value = OS$SystemActions.getPasswordComplexityPolicy(callContext);

// Set initial values
// PasswordComplexityPolicy = GetPasswordComplexityPolicy.PasswordComplexityPolicy
model.variables.passwordComplexityPolicyVar = getPasswordComplexityPolicyVar.value.passwordComplexityPolicyOut;
// PasswordValidationResult.IsValid = False
model.variables.passwordValidationResultVar.isValidAttr = false;
// PasswordValidationResult.MissingLowerCaseLetter = True
model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr = true;
// PasswordValidationResult.MissingMinimumLength = True
model.variables.passwordValidationResultVar.missingMinimumLengthAttr = true;
// PasswordValidationResult.MissingUpperCaseLetter = True
model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr = true;
// PasswordValidationResult.MissingNumber = True
model.variables.passwordValidationResultVar.missingNumberAttr = true;
// PasswordValidationResult.MissingSpecialCharacter = True
model.variables.passwordValidationResultVar.missingSpecialCharacterAttr = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "032b6c7a-8433-42c8-829e-3acdbfd27a6a");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "59e2359d-ea7f-437b-ac84-c32335fc8dfe");
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

get compliant$Action() {if(!(this.hasOwnProperty("_compliant$Action"))) {
this._compliant$Action = function () {
return Promise.resolve();
};
}

return this._compliant$Action;
}set compliant$Action(value) {this._compliant$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.PasswordPolicy$ActionRegex_Search", [{
name: "Found",
attrName: "foundOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "PatternResult",
attrName: "patternResultOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FirstIndex",
attrName: "firstIndexOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


