import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_m_Manuals_ManualDetailView_mvc_controller_GetManualByIdOnAfterFetch_JavaScript1JS from "./ConectaProveedores.m_Manuals.ManualDetailView.mvc$controller.GetManualByIdOnAfterFetch.JavaScript1JS.js";
import ConectaProveedores_m_Manuals_ManualDetailView_mvc_TranslationsResources from "./ConectaProveedores.m_Manuals.ManualDetailView.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_m_Manuals_ManualDetailView_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getManualById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getManualById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getManualById$AggrRefresh() {if(!(this.hasOwnProperty("_getManualById$AggrRefresh"))) {
this._getManualById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetManualById", "screenservices/ConectaProveedores/m_Manuals/ManualDetailView/ScreenDataSetGetManualById", "e4NI1jksALw1fjh_5b5NSA", maxRecords, startIndex, function (b) {
model.variables.getManualByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getManualByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getManualByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getManualByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetManualById", function (span) {
if(span) {
span.setAttribute("code.function", "GetManualById");
span.setAttribute("outsystems.function.key", "d7081b85-8b79-49d9-bc6a-cefc562efae3");
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

return this._getManualById$AggrRefresh;
}set getManualById$AggrRefresh(value) {this._getManualById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getManualById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_cerrarOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CerrarOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CerrarOnClick");
span.setAttribute("outsystems.function.key", "336e16f8-74e0-4f25-afbc-3d14f65b1e5d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CerrarOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: ClosePopup
return controller.closePopup$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
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
span.setAttribute("outsystems.function.key", "70e0c03c-913c-44e8-8ca1-f5fb6382238b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetManualById
var result = controller.getManualById$AggrRefresh(50, 0, callContext);
model.flush();
return result;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_getManualByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetManualByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetManualByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "d418aba6-1ac5-4520-80dc-2dba8b8fdcbf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetManualByIdOnAfterFetch");
callContext = controller.callContext(callContext);
if((model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualsAttr.isVideoAttr)) {
OS$Logger.startActiveSpan("JavaScript1", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript1");
span.setAttribute("outsystems.function.key", "46897b63-e4aa-44cd-8434-3951b8ee94e7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_m_Manuals_ManualDetailView_mvc_controller_GetManualByIdOnAfterFetch_JavaScript1JS, "JavaScript1", "GetManualByIdOnAfterFetch", {
Id: OS$DataConversion.JSNodeParamConverter.to(idService.getId("myVideo"), OS$DataTypes.DataTypes.Text),
videoBase64: OS$DataConversion.JSNodeParamConverter.to(model.variables.getManualByIdAggr.listOut.getCurrent(callContext.iterationContext).manualFileAttr.fileAttr, OS$DataTypes.DataTypes.BinaryData)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_descargarOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DescargarOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DescargarOnClick");
span.setAttribute("outsystems.function.key", "da840464-04e7-41b8-98e3-73f75f3d0a74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DescargarOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: Download
return controller.download$Action(model.variables.i_ManualIdIn, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;

cerrarOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CerrarOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CerrarOnClick");
span.setAttribute("outsystems.function.key", "336e16f8-74e0-4f25-afbc-3d14f65b1e5d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._cerrarOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "70e0c03c-913c-44e8-8ca1-f5fb6382238b");
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

getManualByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetManualByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetManualByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "d418aba6-1ac5-4520-80dc-2dba8b8fdcbf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getManualByIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

descargarOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DescargarOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DescargarOnClick");
span.setAttribute("outsystems.function.key", "da840464-04e7-41b8-98e3-73f75f3d0a74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._descargarOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get download$Action() {if(!(this.hasOwnProperty("_download$Action"))) {
this._download$Action = function () {
return Promise.resolve();
};
}

return this._download$Action;
}set download$Action(value) {this._download$Action = value;
}

get closePopup$Action() {if(!(this.hasOwnProperty("_closePopup$Action"))) {
this._closePopup$Action = function () {
return Promise.resolve();
};
}

return this._closePopup$Action;
}set closePopup$Action(value) {this._closePopup$Action = value;
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


