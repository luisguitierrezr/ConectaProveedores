import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Logs_Wb_GetDistributionLog_mvc_TranslationsResources from "./ConectaProveedores.y_Logs.Wb_GetDistributionLog.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Logs_Wb_GetDistributionLog_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getData$DataActRefresh: 0
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
return controller.callDataAction("DataActionGetData", "screenservices/ConectaProveedores/y_Logs/Wb_GetDistributionLog/DataActionGetData", "5kL_mt2MsQmzUniIMDukxA", function (b) {
model.variables.getDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetData", function (span) {
if(span) {
span.setAttribute("code.function", "GetData");
span.setAttribute("outsystems.function.key", "328a8c23-9365-4740-b3ed-0917066e6b1f");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "3e346125-5cf2-44fe-9d6f-cc3371b29e70");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// i_Refresh = i_Refresh
model.variables.i_RefreshIn = model.variables.i_RefreshIn;
// Refresh Query: GetData
var result = controller.getData$DataActRefresh(callContext);
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
_closeOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CloseOnClick");
span.setAttribute("outsystems.function.key", "7d2ae72c-e70b-419c-b6ea-a36686667004");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseOnClick");
callContext = controller.callContext(callContext);
// ShowPopup = False
model.variables.showPopupVar = false;
// JSON_After = ""
model.variables.jSON_AfterVar = "";
// JSON_Before = ""
model.variables.jSON_BeforeVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_linkOnClick$Action(jSONAfterIn, jSONBeforeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "830a2059-44d7-4e7c-992d-0af23f58648e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("LinkOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_GetDistributionLog.LinkOnClick$vars"))());
vars.value.jSONAfterInLocal = jSONAfterIn;
vars.value.jSONBeforeInLocal = jSONBeforeIn;
// JSON_After = JSONAfter
model.variables.jSON_AfterVar = vars.value.jSONAfterInLocal;
// JSON_Before = JSONBefore
model.variables.jSON_BeforeVar = vars.value.jSONBeforeInLocal;
// ShowPopup = notShowPopup
model.variables.showPopupVar = (!(model.variables.showPopupVar));
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
span.setAttribute("outsystems.function.key", "3e346125-5cf2-44fe-9d6f-cc3371b29e70");
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

closeOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseOnClick");
span.setAttribute("outsystems.function.key", "7d2ae72c-e70b-419c-b6ea-a36686667004");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

linkOnClick$Action(jSONAfterIn, jSONBeforeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "830a2059-44d7-4e7c-992d-0af23f58648e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._linkOnClick$Action, callContext, jSONAfterIn, jSONBeforeIn);
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
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_GetDistributionLog.LinkOnClick$vars", [{
name: "JSONAfter",
attrName: "jSONAfterInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "JSONBefore",
attrName: "jSONBeforeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


