import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_a_Main_DashboardAdmin_mvc_TranslationsResources from "./ConectaProveedores.a_Main.DashboardAdmin.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Main_DashboardAdmin_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getLast10Proposals$AggrRefresh: 0,
getErrorAPIProposals$DataActRefresh: 0,
getActiveProposals$DataActRefresh: 0,
getProcessedProposals$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getLast10Proposals$AggrRefresh: [],
getErrorAPIProposals$DataActRefresh: [],
getActiveProposals$DataActRefresh: [],
getProcessedProposals$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
downloadFileWithProposalId$ServerAction(i_ProposalIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFileWithProposalId", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFileWithProposalId");
span.setAttribute("outsystems.function.key", "957e4549-c87d-4963-a04d-c44a2965032d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadFileWithProposalId", "screenservices/ConectaProveedores/a_Main/DashboardAdmin/ActionDownloadFileWithProposalId", "orzRncjq6at+5OYp6Ib1PA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.DashboardAdmin$ActionDownloadFileWithProposalId"))();
executeServerActionResult.o_FilenameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Filename, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_BinaryDataOut = OS$DataConversion.ServerDataConverter.from(outputs.o_BinaryData, OS$DataTypes.DataTypes.BinaryData);
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
get getLast10Proposals$AggrRefresh() {if(!(this.hasOwnProperty("_getLast10Proposals$AggrRefresh"))) {
this._getLast10Proposals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetLast10Proposals", "screenservices/ConectaProveedores/a_Main/DashboardAdmin/ScreenDataSetGetLast10Proposals", "ena8FtIRAxR3dZUfm7RCXA", maxRecords, startIndex, function (b) {
model.variables.getLast10ProposalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getLast10ProposalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getLast10ProposalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetLast10Proposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetLast10Proposals");
span.setAttribute("outsystems.function.key", "540a07be-e89a-415f-8abe-0c000269307e");
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

get getErrorAPIProposals$DataActRefresh() {if(!(this.hasOwnProperty("_getErrorAPIProposals$DataActRefresh"))) {
this._getErrorAPIProposals$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetErrorAPIProposals", "screenservices/ConectaProveedores/a_Main/DashboardAdmin/DataActionGetErrorAPIProposals", "TVTRV1eK7MOq0Ec8MilS0Q", function (b) {
model.variables.getErrorAPIProposalsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getErrorAPIProposalsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getErrorAPIProposalsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetErrorAPIProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetErrorAPIProposals");
span.setAttribute("outsystems.function.key", "150678a0-727a-4ff8-89e2-f7c53670a820");
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

return this._getErrorAPIProposals$DataActRefresh;
}set getErrorAPIProposals$DataActRefresh(value) {this._getErrorAPIProposals$DataActRefresh = value;
}

get getActiveProposals$DataActRefresh() {if(!(this.hasOwnProperty("_getActiveProposals$DataActRefresh"))) {
this._getActiveProposals$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetActiveProposals", "screenservices/ConectaProveedores/a_Main/DashboardAdmin/DataActionGetActiveProposals", "J5OWxh51MADmoSpy6QxEBQ", function (b) {
model.variables.getActiveProposalsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getActiveProposalsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getActiveProposalsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetActiveProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetActiveProposals");
span.setAttribute("outsystems.function.key", "2baaa74f-d6aa-4d3d-aaf6-3d0e41db542a");
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

get getProcessedProposals$DataActRefresh() {if(!(this.hasOwnProperty("_getProcessedProposals$DataActRefresh"))) {
this._getProcessedProposals$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetProcessedProposals", "screenservices/ConectaProveedores/a_Main/DashboardAdmin/DataActionGetProcessedProposals", "xmd7Exw7DQpssayMZE1oQA", function (b) {
model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProcessedProposalsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProcessedProposalsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProcessedProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetProcessedProposals");
span.setAttribute("outsystems.function.key", "61161a4a-c4fc-42f5-a4f2-6b6fb4b9a3f4");
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

return this._getProcessedProposals$DataActRefresh;
}set getProcessedProposals$DataActRefresh(value) {this._getProcessedProposals$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getLast10Proposals$AggrRefresh", "getErrorAPIProposals$DataActRefresh", "getActiveProposals$DataActRefresh", "getProcessedProposals$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_downloadFile$Action(i_ProposalIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "2793ed8d-b587-49db-bd8a-cf74eae01be3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.DashboardAdmin.DownloadFile$vars"))());
vars.value.i_ProposalIdInLocal = i_ProposalIdIn;
var downloadFileWithProposalIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadFileWithProposalId
model.flush();
return controller.downloadFileWithProposalId$ServerAction(vars.value.i_ProposalIdInLocal, callContext).then(function (value) {
downloadFileWithProposalIdVar.value = value;
}).then(function () {
if((((downloadFileWithProposalIdVar.value.o_FilenameOut) !== ("")))) {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadFileWithProposalIdVar.value.o_BinaryDataOut, downloadFileWithProposalIdVar.value.o_FilenameOut));
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8WYw+QoAlEi2GgNeaKW2Jw#Message.525723613.1", "File not found."), /*Error*/ 3);
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

downloadFile$Action(i_ProposalIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "2793ed8d-b587-49db-bd8a-cf74eae01be3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadFile$Action, callContext, i_ProposalIdIn);
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
Controller.registerVariableGroupType("ConectaProveedores.a_Main.DashboardAdmin$ActionDownloadFileWithProposalId", [{
name: "o_Filename",
attrName: "o_FilenameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_BinaryData",
attrName: "o_BinaryDataOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Main.DashboardAdmin.DownloadFile$vars", [{
name: "i_ProposalId",
attrName: "i_ProposalIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


