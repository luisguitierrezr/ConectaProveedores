import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { hideLoading$Action as ConectaProveedoresController$hideLoading$Action, showLoading$Action as ConectaProveedoresController$showLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.Wb_PreviewFile.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getData$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getData$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getData$DataActRefresh() {if(!(this.hasOwnProperty("_getData$DataActRefresh"))) {
this._getData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetData", "screenservices/ConectaProveedores/g_Reports/Wb_PreviewFile/DataActionGetData", "kQHPPh3sy_LlMxueApKB1Q", function (b) {
model.variables.getDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetData", function (span) {
if(span) {
span.setAttribute("code.function", "GetData");
span.setAttribute("outsystems.function.key", "99eb93cc-bbd3-469f-af4c-e66553dc538c");
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

return this._getData$DataActRefresh;
}set getData$DataActRefresh(value) {this._getData$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_closePopUp$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClosePopUp", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePopUp");
span.setAttribute("outsystems.function.key", "3163a971-e8b3-4f68-a770-87cea3cbf007");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClosePopUp");
callContext = controller.callContext(callContext);
// Clear Locals and Close PopUp
// l_Filename = ""
model.variables.l_FilenameVar = "";
// l_Binary = NullBinary
model.variables.l_BinaryVar = OS$BuiltinFunctions.nullBinary();
// l_PopupToggler = notl_PopupToggler
model.variables.l_PopupTogglerVar = (!(model.variables.l_PopupTogglerVar));
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "9ed98876-ed17-49e4-895c-e92a889d1682");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetDataOnAfterFetch");
callContext = controller.callContext(callContext);
// l_Binary = GetData.o_Binary
model.variables.l_BinaryVar = model.variables.getDataDataAct.o_BinaryOut;
// l_xml = GetData.o_xml
model.variables.l_xmlVar = model.variables.getDataDataAct.o_xmlOut;
// l_Filename = GetData.o_Filename
model.variables.l_FilenameVar = model.variables.getDataDataAct.o_FilenameOut;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// l_PopupToggler = True
model.variables.l_PopupTogglerVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "ddbe7ef8-57ae-4541-9546-807502fc719c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((!(model.variables.storageIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// ForceRefresh = ForceRefresh
model.variables.forceRefreshIn = model.variables.forceRefreshIn;
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Refresh Query: GetData
var result = controller.getData$DataActRefresh(callContext);
model.flush();
return result;
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

closePopUp$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClosePopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePopUp");
span.setAttribute("outsystems.function.key", "3163a971-e8b3-4f68-a770-87cea3cbf007");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closePopUp$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "9ed98876-ed17-49e4-895c-e92a889d1682");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getDataOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "ddbe7ef8-57ae-4541-9546-807502fc719c");
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

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


