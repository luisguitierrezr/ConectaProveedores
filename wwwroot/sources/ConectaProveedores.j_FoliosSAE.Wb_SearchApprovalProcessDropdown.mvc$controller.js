import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getApprovalProcesss$AggrRefresh: 0,
getApprovalProcessById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getApprovalProcesss$AggrRefresh: [],
getApprovalProcessById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getApprovalProcesss$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalProcesss$AggrRefresh"))) {
this._getApprovalProcesss$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalProcesss", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SearchApprovalProcessDropdown/ScreenDataSetGetApprovalProcesss", "_zbsLFjo0_6mQ+Cscy829w", maxRecords, startIndex, function (b) {
model.variables.getApprovalProcesssAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalProcesssAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalProcesssAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalProcesss", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalProcesss");
span.setAttribute("outsystems.function.key", "03b45834-fb34-410b-856c-17486bd5a204");
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

return this._getApprovalProcesss$AggrRefresh;
}set getApprovalProcesss$AggrRefresh(value) {this._getApprovalProcesss$AggrRefresh = value;
}

get getApprovalProcessById$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalProcessById$AggrRefresh"))) {
this._getApprovalProcessById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalProcessById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SearchApprovalProcessDropdown/ScreenDataSetGetApprovalProcessById", "uq0uFK678oUmoLD891KCdw", maxRecords, startIndex, function (b) {
model.variables.getApprovalProcessByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalProcessByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalProcessByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalProcessById", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalProcessById");
span.setAttribute("outsystems.function.key", "f4ef276b-ada9-4c68-b65c-5ce37842e11b");
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

return this._getApprovalProcessById$AggrRefresh;
}set getApprovalProcessById$AggrRefresh(value) {this._getApprovalProcessById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getApprovalProcesss$AggrRefresh", "getApprovalProcessById$AggrRefresh"];
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
span.setAttribute("outsystems.function.key", "28950108-4d52-4441-a964-0d7fe3e699f2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((model.variables.i_IsValidIn) !== (model.variables.l_IsValidVar)))) {
// l_IsValid = i_IsValid
model.variables.l_IsValidVar = model.variables.i_IsValidIn;
} else {
// Refresh Query: GetApprovalProcessById
var result = controller.getApprovalProcessById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetApprovalProcesss
var result = controller.getApprovalProcesss$AggrRefresh(model.variables.l_ApprovalProcessMaxRecordVar, 0, callContext);
model.flush();
return result;
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
_clearApprovalProcess$Action(isSearchIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearApprovalProcess", function (span) {
if(span) {
span.setAttribute("code.function", "ClearApprovalProcess");
span.setAttribute("outsystems.function.key", "5b4e11d5-e97d-4541-a605-a53dc4f1da6c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearApprovalProcess");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.ClearApprovalProcess$vars"))());
vars.value.isSearchInLocal = isSearchIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isSearchInLocal)) {
// l_ApprovalProcessSearchText = ""
model.variables.l_ApprovalProcessSearchTextVar = "";
// Refresh Query: GetApprovalProcesss
var result = controller.getApprovalProcesss$AggrRefresh(model.variables.l_ApprovalProcessMaxRecordVar, 0, callContext);
model.flush();
return result;
} else {
// Trigger Event: Refresh
return controller.refresh$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), callContext);
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
_input_ApprovalProcessSearchTextOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_ApprovalProcessSearchTextOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ApprovalProcessSearchTextOnChange");
span.setAttribute("outsystems.function.key", "aa927cda-716e-4884-92f2-ef2df7d7d61f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Input_ApprovalProcessSearchTextOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetApprovalProcesss
var result = controller.getApprovalProcesss$AggrRefresh(model.variables.l_ApprovalProcessMaxRecordVar, 0, callContext);
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
_loadMoreOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LoadMoreOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LoadMoreOnClick");
span.setAttribute("outsystems.function.key", "eaff75ef-711a-43ce-90c6-091e29671ac9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LoadMoreOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_ApprovalProcessMaxRecord = l_ApprovalProcessMaxRecord + 20
model.variables.l_ApprovalProcessMaxRecordVar = (model.variables.l_ApprovalProcessMaxRecordVar + 20);
// Refresh Query: GetApprovalProcesss
var result = controller.getApprovalProcesss$AggrRefresh(model.variables.l_ApprovalProcessMaxRecordVar, 0, callContext);
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "28950108-4d52-4441-a964-0d7fe3e699f2");
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

clearApprovalProcess$Action(isSearchIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearApprovalProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearApprovalProcess");
span.setAttribute("outsystems.function.key", "5b4e11d5-e97d-4541-a605-a53dc4f1da6c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearApprovalProcess$Action, callContext, isSearchIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

input_ApprovalProcessSearchTextOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_ApprovalProcessSearchTextOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_ApprovalProcessSearchTextOnChange");
span.setAttribute("outsystems.function.key", "aa927cda-716e-4884-92f2-ef2df7d7d61f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._input_ApprovalProcessSearchTextOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

loadMoreOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LoadMoreOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LoadMoreOnClick");
span.setAttribute("outsystems.function.key", "eaff75ef-711a-43ce-90c6-091e29671ac9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._loadMoreOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get refresh$Action() {if(!(this.hasOwnProperty("_refresh$Action"))) {
this._refresh$Action = function () {
return Promise.resolve();
};
}

return this._refresh$Action;
}set refresh$Action(value) {this._refresh$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.ClearApprovalProcess$vars", [{
name: "IsSearch",
attrName: "isSearchInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


