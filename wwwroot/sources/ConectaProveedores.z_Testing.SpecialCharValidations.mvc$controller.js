import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_z_Testing_SpecialCharValidations_mvc_TranslationsResources from "./ConectaProveedores.z_Testing.SpecialCharValidations.mvc$translationsResources.js";
import ConectaProveedores_z_TestingController$default from "./ConectaProveedores.z_Testing.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_b453bea0930035904f55a74692afd3a8Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_z_Testing_SpecialCharValidations_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
checkRegexValidation$ServerAction(textIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckRegexValidation", function (span) {
if(span) {
span.setAttribute("code.function", "CheckRegexValidation");
span.setAttribute("outsystems.function.key", "fec0da39-a8fd-476f-ac67-bd0d0917bf92");
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
})
};
return controller.callServerAction("CheckRegexValidation", "screenservices/ConectaProveedores/z_Testing/SpecialCharValidations/ActionCheckRegexValidation", "gH5pZHiZ_VAmedz3i1hclw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Testing.SpecialCharValidations$ActionCheckRegexValidation"))();
executeServerActionResult.validOut = OS$DataConversion.ServerDataConverter.from(outputs.Valid, ST_b453bea0930035904f55a74692afd3a8Structure);
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
_buttonOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ButtonOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ButtonOnClick");
span.setAttribute("outsystems.function.key", "f7fbcc59-1a17-440c-8ce3-d0ab49e8b51c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ButtonOnClick");
callContext = controller.callContext(callContext);
var checkRegexValidationVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckRegexValidation
model.flush();
return controller.checkRegexValidation$ServerAction(model.variables.textVarVar, callContext).then(function (value) {
checkRegexValidationVar.value = value;
}).then(function () {
if((!(checkRegexValidationVar.value.validOut.isValidAttr))) {
// Input_TextVar.Valid = False
model.widgets.get(idService.getId("Input_TextVar")).validAttr = false;
// Input_TextVar.ValidationMessage = CheckRegexValidation.Valid.ValidationMessage
model.widgets.get(idService.getId("Input_TextVar")).validationMessageAttr = checkRegexValidationVar.value.validOut.validationMessageAttr;
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

buttonOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ButtonOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ButtonOnClick");
span.setAttribute("outsystems.function.key", "f7fbcc59-1a17-440c-8ce3-d0ab49e8b51c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._buttonOnClick$Action, callContext);
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
return ConectaProveedores_z_TestingController$default.handleError(ex, this.callContext());
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
Controller.registerVariableGroupType("ConectaProveedores.z_Testing.SpecialCharValidations$ActionCheckRegexValidation", [{
name: "Valid",
attrName: "validOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b453bea0930035904f55a74692afd3a8Structure();
},
complexType: ST_b453bea0930035904f55a74692afd3a8Structure
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


