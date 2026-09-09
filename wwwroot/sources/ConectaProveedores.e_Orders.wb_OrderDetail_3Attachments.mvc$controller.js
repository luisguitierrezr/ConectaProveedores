import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_d9010d115c38fb059bccbc457fe11b18Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_Orders_wb_OrderDetail_3Attachments_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.wb_OrderDetail_3Attachments.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_wb_OrderDetail_3Attachments_mvc_TranslationsResources);
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
_wb_DocumentsToRequestUploadParent$Action(orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_DocumentsToRequestUploadParent", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DocumentsToRequestUploadParent");
span.setAttribute("outsystems.function.key", "2cf299e5-42f9-4d99-8705-951556e84a15");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_DocumentsToRequestUploadParent");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.wb_OrderDetail_3Attachments.Wb_DocumentsToRequestUploadParent$vars"))());
vars.value.orderRequestFilesInLocal = orderRequestFilesIn.clone();
vars.value.hasntRequestDocumentsInLocal = hasntRequestDocumentsIn;
vars.value.isValidInLocal = isValidIn;
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: UploadMainParent
return controller.uploadMainParent$Action(vars.value.orderRequestFilesInLocal, vars.value.hasntRequestDocumentsInLocal, vars.value.isValidInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;

wb_DocumentsToRequestUploadParent$Action(orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_DocumentsToRequestUploadParent__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DocumentsToRequestUploadParent");
span.setAttribute("outsystems.function.key", "2cf299e5-42f9-4d99-8705-951556e84a15");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_DocumentsToRequestUploadParent$Action, callContext, orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get uploadMainParent$Action() {if(!(this.hasOwnProperty("_uploadMainParent$Action"))) {
this._uploadMainParent$Action = function () {
return Promise.resolve();
};
}

return this._uploadMainParent$Action;
}set uploadMainParent$Action(value) {this._uploadMainParent$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.wb_OrderDetail_3Attachments.Wb_DocumentsToRequestUploadParent$vars", [{
name: "OrderRequestFiles",
attrName: "orderRequestFilesInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))
}, {
name: "HasntRequestDocuments",
attrName: "hasntRequestDocumentsInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
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


