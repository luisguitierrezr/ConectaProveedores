import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Utils_CopilotChat_mvc_controller_InitCopilot_RenderWebChatJS from "./ConectaProveedores.y_Utils.CopilotChat.mvc$controller.InitCopilot.RenderWebChatJS.js";
import ConectaProveedores_y_Utils_CopilotChat_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.CopilotChat.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_CopilotChat_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
getTelcelCopilotBlockData$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetTelcelCopilotBlockData", function (span) {
if(span) {
span.setAttribute("code.function", "GetTelcelCopilotBlockData");
span.setAttribute("outsystems.function.key", "2446cb8b-30c9-4d8e-ba8c-bbc7f6f165f2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("GetTelcelCopilotBlockData", "screenservices/ConectaProveedores/y_Utils/CopilotChat/ActionGetTelcelCopilotBlockData", "kfR_lvvibRyQOjBi3roqzw", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.CopilotChat$ActionGetTelcelCopilotBlockData"))();
executeServerActionResult.nameOut = OS$DataConversion.ServerDataConverter.from(outputs.Name, OS$DataTypes.DataTypes.Text);
executeServerActionResult.emailOut = OS$DataConversion.ServerDataConverter.from(outputs.Email, OS$DataTypes.DataTypes.Email);
executeServerActionResult.uRLOut = OS$DataConversion.ServerDataConverter.from(outputs.URL, OS$DataTypes.DataTypes.Text);
executeServerActionResult.rolesOut = OS$DataConversion.ServerDataConverter.from(outputs.Roles, OS$DataTypes.DataTypes.Text);
executeServerActionResult.secretOut = OS$DataConversion.ServerDataConverter.from(outputs.Secret, OS$DataTypes.DataTypes.Text);
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
_initCopilot$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("InitCopilot", function (span) {
if(span) {
span.setAttribute("code.function", "InitCopilot");
span.setAttribute("outsystems.function.key", "7070d7d5-904c-4726-9f6e-7cc038fc6e69");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("InitCopilot");
callContext = controller.callContext(callContext);
var getTelcelCopilotBlockDataVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetTelcelCopilotBlockData
model.flush();
return controller.getTelcelCopilotBlockData$ServerAction(callContext).then(function (value) {
getTelcelCopilotBlockDataVar.value = value;
}).then(function () {
OS$Logger.startActiveSpan("RenderWebChat", function (span) {
if(span) {
span.setAttribute("code.function", "RenderWebChat");
span.setAttribute("outsystems.function.key", "c4a555be-d5e3-4efb-9d9d-dcd93fb1a4b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_CopilotChat_mvc_controller_InitCopilot_RenderWebChatJS, "RenderWebChat", "InitCopilot", {
Roles: OS$DataConversion.JSNodeParamConverter.to(getTelcelCopilotBlockDataVar.value.rolesOut, OS$DataTypes.DataTypes.Text),
Name: OS$DataConversion.JSNodeParamConverter.to(getTelcelCopilotBlockDataVar.value.nameOut, OS$DataTypes.DataTypes.Text),
URL: OS$DataConversion.JSNodeParamConverter.to(getTelcelCopilotBlockDataVar.value.uRLOut, OS$DataTypes.DataTypes.Text),
Initiative: OS$DataConversion.JSNodeParamConverter.to(model.variables.initiativeIn, OS$DataTypes.DataTypes.Text),
In1: OS$DataConversion.JSNodeParamConverter.to(idService.getId("webchat"), OS$DataTypes.DataTypes.Text),
SECRET: OS$DataConversion.JSNodeParamConverter.to(getTelcelCopilotBlockDataVar.value.secretOut, OS$DataTypes.DataTypes.Text),
Email: OS$DataConversion.JSNodeParamConverter.to(getTelcelCopilotBlockDataVar.value.emailOut, OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
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

initCopilot$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InitCopilot__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitCopilot");
span.setAttribute("outsystems.function.key", "7070d7d5-904c-4726-9f6e-7cc038fc6e69");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._initCopilot$Action, callContext);
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

return controller.initCopilot$Action(callContext);

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
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.CopilotChat$ActionGetTelcelCopilotBlockData", [{
name: "Name",
attrName: "nameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Email",
attrName: "emailOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Email,
defaultValue: function () {
return "";
}
}, {
name: "URL",
attrName: "uRLOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Roles",
attrName: "rolesOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Secret",
attrName: "secretOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


