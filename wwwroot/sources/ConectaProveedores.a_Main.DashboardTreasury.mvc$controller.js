import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_a_Main_DashboardTreasury_mvc_TranslationsResources from "./ConectaProveedores.a_Main.DashboardTreasury.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Main_DashboardTreasury_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getLast10Proposals$AggrRefresh: 0,
getPartiallyPaidProposals$DataActRefresh: 0,
getPaidProposals$DataActRefresh: 0,
getActiveProposals$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getLast10Proposals$AggrRefresh: [],
getPartiallyPaidProposals$DataActRefresh: [],
getPaidProposals$DataActRefresh: [],
getActiveProposals$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getLast10Proposals$AggrRefresh() {if(!(this.hasOwnProperty("_getLast10Proposals$AggrRefresh"))) {
this._getLast10Proposals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetLast10Proposals", "screenservices/ConectaProveedores/a_Main/DashboardTreasury/ScreenDataSetGetLast10Proposals", "sHccw_ybQ5qi0y1E506jNg", maxRecords, startIndex, function (b) {
model.variables.getLast10ProposalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getLast10ProposalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getLast10ProposalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetLast10Proposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetLast10Proposals");
span.setAttribute("outsystems.function.key", "f281d1f1-c924-4a91-b208-0666083d7675");
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

return this._getLast10Proposals$AggrRefresh;
}set getLast10Proposals$AggrRefresh(value) {this._getLast10Proposals$AggrRefresh = value;
}

get getPartiallyPaidProposals$DataActRefresh() {if(!(this.hasOwnProperty("_getPartiallyPaidProposals$DataActRefresh"))) {
this._getPartiallyPaidProposals$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetPartiallyPaidProposals", "screenservices/ConectaProveedores/a_Main/DashboardTreasury/DataActionGetPartiallyPaidProposals", "BQbVRDk+S95T3Dz8z2dYkg", function (b) {
model.variables.getPartiallyPaidProposalsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPartiallyPaidProposalsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPartiallyPaidProposalsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPartiallyPaidProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetPartiallyPaidProposals");
span.setAttribute("outsystems.function.key", "0be395ed-2b37-4515-a233-e4d7d06b73c5");
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

return this._getPartiallyPaidProposals$DataActRefresh;
}set getPartiallyPaidProposals$DataActRefresh(value) {this._getPartiallyPaidProposals$DataActRefresh = value;
}

get getPaidProposals$DataActRefresh() {if(!(this.hasOwnProperty("_getPaidProposals$DataActRefresh"))) {
this._getPaidProposals$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetPaidProposals", "screenservices/ConectaProveedores/a_Main/DashboardTreasury/DataActionGetPaidProposals", "uZupfsnIaBo8nGzEBA10xQ", function (b) {
model.variables.getPaidProposalsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaidProposalsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaidProposalsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaidProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaidProposals");
span.setAttribute("outsystems.function.key", "b547afd4-06c8-48b8-8f55-444a7d30c62d");
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

return this._getPaidProposals$DataActRefresh;
}set getPaidProposals$DataActRefresh(value) {this._getPaidProposals$DataActRefresh = value;
}

get getActiveProposals$DataActRefresh() {if(!(this.hasOwnProperty("_getActiveProposals$DataActRefresh"))) {
this._getActiveProposals$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetActiveProposals", "screenservices/ConectaProveedores/a_Main/DashboardTreasury/DataActionGetActiveProposals", "J5OWxh51MADmoSpy6QxEBQ", function (b) {
model.variables.getActiveProposalsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getActiveProposalsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getActiveProposalsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetActiveProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetActiveProposals");
span.setAttribute("outsystems.function.key", "ba24b6cf-904e-4ec6-b5e2-5c558c01e6a7");
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

return this._getActiveProposals$DataActRefresh;
}set getActiveProposals$DataActRefresh(value) {this._getActiveProposals$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getLast10Proposals$AggrRefresh", "getPartiallyPaidProposals$DataActRefresh", "getPaidProposals$DataActRefresh", "getActiveProposals$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods


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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


