import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSuppliers$AggrRefresh: 0,
getSupplierById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getSuppliers$AggrRefresh: [],
getSupplierById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getSuppliers$AggrRefresh() {if(!(this.hasOwnProperty("_getSuppliers$AggrRefresh"))) {
this._getSuppliers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSuppliers", "screenservices/ConectaProveedores/y_Utils/Wb_SearchSupplierDropdown/ScreenDataSetGetSuppliers", "A23RbsYT+BH4yA+krQyKvg", maxRecords, startIndex, function (b) {
model.variables.getSuppliersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSuppliersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSuppliersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "GetSuppliers");
span.setAttribute("outsystems.function.key", "47c46001-d6ad-4530-a73a-1440d2647456");
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

return this._getSuppliers$AggrRefresh;
}set getSuppliers$AggrRefresh(value) {this._getSuppliers$AggrRefresh = value;
}

get getSupplierById$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierById$AggrRefresh"))) {
this._getSupplierById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierById", "screenservices/ConectaProveedores/y_Utils/Wb_SearchSupplierDropdown/ScreenDataSetGetSupplierById", "BpEhcxOZoD4C1KFWlH_Uqw", maxRecords, startIndex, function (b) {
model.variables.getSupplierByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierById", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierById");
span.setAttribute("outsystems.function.key", "68d928cc-effb-4404-93bf-00e28e22d0eb");
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

return this._getSupplierById$AggrRefresh;
}set getSupplierById$AggrRefresh(value) {this._getSupplierById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSuppliers$AggrRefresh", "getSupplierById$AggrRefresh"];
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
span.setAttribute("outsystems.function.key", "09396021-be0c-4c94-94c1-d366b2e6a1c5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LoadMoreOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_SupplierMaxRecord = l_SupplierMaxRecord + 20
model.variables.l_SupplierMaxRecordVar = (model.variables.l_SupplierMaxRecordVar + 20);
// Refresh Query: GetSuppliers
var result = controller.getSuppliers$AggrRefresh(model.variables.l_SupplierMaxRecordVar, 0, callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "3924e23d-ada9-4782-b499-1a0812cebd3d");
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
// Refresh Query: GetSupplierById
var result = controller.getSupplierById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSuppliers
var result = controller.getSuppliers$AggrRefresh(model.variables.l_SupplierMaxRecordVar, 0, callContext);
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
_clearSupplier$Action(isSearchIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearSupplier", function (span) {
if(span) {
span.setAttribute("code.function", "ClearSupplier");
span.setAttribute("outsystems.function.key", "af98da90-2dde-4259-bd42-2dce7c522cfd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearSupplier");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.ClearSupplier$vars"))());
vars.value.isSearchInLocal = isSearchIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isSearchInLocal)) {
// l_SupplierSearchText = ""
model.variables.l_SupplierSearchTextVar = "";
// Refresh Query: GetSuppliers
var result = controller.getSuppliers$AggrRefresh(model.variables.l_SupplierMaxRecordVar, 0, callContext);
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
_input_SupplierSearchTextOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_SupplierSearchTextOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_SupplierSearchTextOnChange");
span.setAttribute("outsystems.function.key", "dae94920-898a-4f5c-ab45-3d4d70e8fce3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Input_SupplierSearchTextOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSuppliers
var result = controller.getSuppliers$AggrRefresh(model.variables.l_SupplierMaxRecordVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "09396021-be0c-4c94-94c1-d366b2e6a1c5");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "3924e23d-ada9-4782-b499-1a0812cebd3d");
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

clearSupplier$Action(isSearchIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearSupplier__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearSupplier");
span.setAttribute("outsystems.function.key", "af98da90-2dde-4259-bd42-2dce7c522cfd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearSupplier$Action, callContext, isSearchIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

input_SupplierSearchTextOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_SupplierSearchTextOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_SupplierSearchTextOnChange");
span.setAttribute("outsystems.function.key", "dae94920-898a-4f5c-ab45-3d4d70e8fce3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._input_SupplierSearchTextOnChange$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.ClearSupplier$vars", [{
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


