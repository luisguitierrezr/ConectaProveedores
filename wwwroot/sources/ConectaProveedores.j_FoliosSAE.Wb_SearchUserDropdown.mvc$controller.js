import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getUserById$AggrRefresh: 0,
getUsers$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserById$AggrRefresh: [],
getUsers$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getUserById$AggrRefresh() {if(!(this.hasOwnProperty("_getUserById$AggrRefresh"))) {
this._getUserById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SearchUserDropdown/ScreenDataSetGetUserById", "Va4im9w3O8J6O2V4NmI_0w", maxRecords, startIndex, function (b) {
model.variables.getUserByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserById", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserById");
span.setAttribute("outsystems.function.key", "3ef95ab4-7e81-4cf8-b5e4-9d4b7f316d87");
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

return this._getUserById$AggrRefresh;
}set getUserById$AggrRefresh(value) {this._getUserById$AggrRefresh = value;
}

get getUsers$AggrRefresh() {if(!(this.hasOwnProperty("_getUsers$AggrRefresh"))) {
this._getUsers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUsers", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SearchUserDropdown/ScreenDataSetGetUsers", "t2fqeF5CGVGoHASF55LTcQ", maxRecords, startIndex, function (b) {
model.variables.getUsersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsers", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsers");
span.setAttribute("outsystems.function.key", "657fa468-5eca-4128-81a8-acd9e4991def");
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

return this._getUsers$AggrRefresh;
}set getUsers$AggrRefresh(value) {this._getUsers$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserById$AggrRefresh", "getUsers$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_loadMoreOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LoadMoreOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LoadMoreOnClick");
span.setAttribute("outsystems.function.key", "2b77f8f9-9339-4772-be30-ac666596a84d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LoadMoreOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_UserMaxRecord = l_UserMaxRecord + 20
model.variables.l_UserMaxRecordVar = (model.variables.l_UserMaxRecordVar + 20);
// Refresh Query: GetUsers
var result = controller.getUsers$AggrRefresh(model.variables.l_UserMaxRecordVar, 0, callContext);
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
_clearUser$Action(isSearchIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearUser", function (span) {
if(span) {
span.setAttribute("code.function", "ClearUser");
span.setAttribute("outsystems.function.key", "587b43ba-bff5-4923-8d10-7d928e2e8e13");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearUser");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.ClearUser$vars"))());
vars.value.isSearchInLocal = isSearchIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isSearchInLocal)) {
// l_UserSearchText = ""
model.variables.l_UserSearchTextVar = "";
// Refresh Query: GetUsers
var result = controller.getUsers$AggrRefresh(model.variables.l_UserMaxRecordVar, 0, callContext);
model.flush();
return result;
} else {
// Trigger Event: Refresh
return controller.refresh$Action(OS$BuiltinFunctions.nullTextIdentifier(), callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "79178e5e-a2e5-403d-9292-4f8477fa5af7");
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
// Refresh Query: GetUserById
var result = controller.getUserById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetUsers
var result = controller.getUsers$AggrRefresh(model.variables.l_UserMaxRecordVar, 0, callContext);
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
_input_UserSearchTextOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_UserSearchTextOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_UserSearchTextOnChange");
span.setAttribute("outsystems.function.key", "d6b69896-a31a-4c66-b127-2288e63223e2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Input_UserSearchTextOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetUsers
var result = controller.getUsers$AggrRefresh(model.variables.l_UserMaxRecordVar, 0, callContext);
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

loadMoreOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LoadMoreOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LoadMoreOnClick");
span.setAttribute("outsystems.function.key", "2b77f8f9-9339-4772-be30-ac666596a84d");
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

clearUser$Action(isSearchIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearUser__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearUser");
span.setAttribute("outsystems.function.key", "587b43ba-bff5-4923-8d10-7d928e2e8e13");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearUser$Action, callContext, isSearchIn);
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
span.setAttribute("outsystems.function.key", "79178e5e-a2e5-403d-9292-4f8477fa5af7");
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

input_UserSearchTextOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_UserSearchTextOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_UserSearchTextOnChange");
span.setAttribute("outsystems.function.key", "d6b69896-a31a-4c66-b127-2288e63223e2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._input_UserSearchTextOnChange$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.ClearUser$vars", [{
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


