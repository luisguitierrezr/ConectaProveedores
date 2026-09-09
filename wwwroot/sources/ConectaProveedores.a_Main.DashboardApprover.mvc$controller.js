import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_a_Main_DashboardApprover_mvc_TranslationsResources from "./ConectaProveedores.a_Main.DashboardApprover.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Main_DashboardApprover_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getProposalLines$AggrRefresh: 0,
getApprovedProposalLines$DataActRefresh: 0,
getNotApprovedProposalLines$DataActRefresh: 0,
getRejectedProposalLines$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getProposalLines$AggrRefresh: [],
getApprovedProposalLines$DataActRefresh: [],
getNotApprovedProposalLines$DataActRefresh: [],
getRejectedProposalLines$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getProposalLines$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLines$AggrRefresh"))) {
this._getProposalLines$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLines", "screenservices/ConectaProveedores/a_Main/DashboardApprover/ScreenDataSetGetProposalLines", "oAmSsxy2g5XL5N6EDnaFDA", maxRecords, startIndex, function (b) {
model.variables.getProposalLinesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLinesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLinesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLines", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLines");
span.setAttribute("outsystems.function.key", "efed226a-2855-43b1-84d5-91d3e392033e");
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

return this._getProposalLines$AggrRefresh;
}set getProposalLines$AggrRefresh(value) {this._getProposalLines$AggrRefresh = value;
}

get getApprovedProposalLines$DataActRefresh() {if(!(this.hasOwnProperty("_getApprovedProposalLines$DataActRefresh"))) {
this._getApprovedProposalLines$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApprovedProposalLines", "screenservices/ConectaProveedores/a_Main/DashboardApprover/DataActionGetApprovedProposalLines", "7UNRqq3uvfVmev+SJkXLGA", function (b) {
model.variables.getApprovedProposalLinesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovedProposalLinesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovedProposalLinesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovedProposalLines", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovedProposalLines");
span.setAttribute("outsystems.function.key", "19ec9d90-4821-4986-aadc-505a69a90eb3");
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

return this._getApprovedProposalLines$DataActRefresh;
}set getApprovedProposalLines$DataActRefresh(value) {this._getApprovedProposalLines$DataActRefresh = value;
}

get getNotApprovedProposalLines$DataActRefresh() {if(!(this.hasOwnProperty("_getNotApprovedProposalLines$DataActRefresh"))) {
this._getNotApprovedProposalLines$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetNotApprovedProposalLines", "screenservices/ConectaProveedores/a_Main/DashboardApprover/DataActionGetNotApprovedProposalLines", "Znbhj07Aev6BHS4xIZVBvg", function (b) {
model.variables.getNotApprovedProposalLinesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getNotApprovedProposalLinesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getNotApprovedProposalLinesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetNotApprovedProposalLines", function (span) {
if(span) {
span.setAttribute("code.function", "GetNotApprovedProposalLines");
span.setAttribute("outsystems.function.key", "26de17e7-764a-49c9-bfce-ebb359918a2f");
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

return this._getNotApprovedProposalLines$DataActRefresh;
}set getNotApprovedProposalLines$DataActRefresh(value) {this._getNotApprovedProposalLines$DataActRefresh = value;
}

get getRejectedProposalLines$DataActRefresh() {if(!(this.hasOwnProperty("_getRejectedProposalLines$DataActRefresh"))) {
this._getRejectedProposalLines$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRejectedProposalLines", "screenservices/ConectaProveedores/a_Main/DashboardApprover/DataActionGetRejectedProposalLines", "IuK4ARtij023iVY5JKffPg", function (b) {
model.variables.getRejectedProposalLinesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRejectedProposalLinesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRejectedProposalLinesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRejectedProposalLines", function (span) {
if(span) {
span.setAttribute("code.function", "GetRejectedProposalLines");
span.setAttribute("outsystems.function.key", "fdda5711-f0f9-449b-8797-ef319e8f1ccf");
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

return this._getRejectedProposalLines$DataActRefresh;
}set getRejectedProposalLines$DataActRefresh(value) {this._getRejectedProposalLines$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getProposalLines$AggrRefresh", "getApprovedProposalLines$DataActRefresh", "getNotApprovedProposalLines$DataActRefresh", "getRejectedProposalLines$DataActRefresh"];
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


