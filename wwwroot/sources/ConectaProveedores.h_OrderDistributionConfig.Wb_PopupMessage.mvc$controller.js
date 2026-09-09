import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_h_OrderDistributionConfig_Wb_PopupMessage_mvc_TranslationsResources from "./ConectaProveedores.h_OrderDistributionConfig.Wb_PopupMessage.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_h_OrderDistributionConfig_Wb_PopupMessage_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_buttonOnClick$Action(actionContinueIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ButtonOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ButtonOnClick");
span.setAttribute("outsystems.function.key", "a84d2aa2-4544-4b8a-928f-e478e516450c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ButtonOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PopupMessage.ButtonOnClick$vars"))());
vars.value.actionContinueInLocal = actionContinueIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((model.variables.isMandatoryMessageIn && (OS$BuiltinFunctions.length(model.variables.actionTextVar) < 5)) && vars.value.actionContinueInLocal))) {
// TextArea_ActionText.Valid = False
model.widgets.get(idService.getId("TextArea_ActionText")).validAttr = false;
// TextArea_ActionText.ValidationMessage = "Please enter a valid justification."
model.widgets.get(idService.getId("TextArea_ActionText")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hiuWzYuD40mwP_MLqLgTeA#Value.797551901.1", "Please enter a valid justification.");
} else {
// Trigger Event: Result
return controller.result$Action(model.variables.actionTextVar, vars.value.actionContinueInLocal, callContext);
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

buttonOnClick$Action(actionContinueIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ButtonOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ButtonOnClick");
span.setAttribute("outsystems.function.key", "a84d2aa2-4544-4b8a-928f-e478e516450c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._buttonOnClick$Action, callContext, actionContinueIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get result$Action() {if(!(this.hasOwnProperty("_result$Action"))) {
this._result$Action = function () {
return Promise.resolve();
};
}

return this._result$Action;
}set result$Action(value) {this._result$Action = value;
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PopupMessage.ButtonOnClick$vars", [{
name: "ActionContinue",
attrName: "actionContinueInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


