import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { TextRec } from "./Extension.Text.model.js";
import ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_mvc_TranslationsResources from "./ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.mvc$translationsResources.js";
import ConectaProveedores_z_TableDownloadsPDFController$default from "./ConectaProveedores.z_TableDownloadsPDF.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRequisitions$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getRequisitions$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
string_Split$ServerAction(textIn, delimitersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("String_Split", function (span) {
if(span) {
span.setAttribute("code.function", "String_Split");
span.setAttribute("outsystems.function.key", "1bfff05e-3ca7-47bc-ab04-18bfb301a55f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Text: OS$DataConversion.ServerDataConverter.to(textIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Delimiters: OS$DataConversion.ServerDataConverter.to(delimitersIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("String_Split", "screenservices/ConectaProveedores/z_TableDownloadsPDF/TableDownloadRequisitionsListInternalScreenPDF/ActionString_Split", "KCCQ2PmqBTFATtdp2LjyhQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF$ActionString_Split"))();
executeServerActionResult.listOut = OS$DataConversion.ServerDataConverter.from(outputs.List, (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(TextRec, {
name: "Text",
attrName: "textAttr",
nameForJson: "Text2",
uniqueId: "0d84b59e-ff89-87c4-71ae-b49dfa9f2c39"
})))));
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
get getRequisitions$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitions$DataActRefresh"))) {
this._getRequisitions$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitions", "screenservices/ConectaProveedores/z_TableDownloadsPDF/TableDownloadRequisitionsListInternalScreenPDF/DataActionGetRequisitions", "LhnZeEnEL8PIn6Q1WKzImg", function (b) {
model.variables.getRequisitionsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitions");
span.setAttribute("outsystems.function.key", "7d8e39fd-d295-4d84-a846-7757f7ae9f19");
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

return this._getRequisitions$DataActRefresh;
}set getRequisitions$DataActRefresh(value) {this._getRequisitions$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getRequisitions$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c2b9c8e0-3487-403c-90b2-e3646124119b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var string_SplitVar = new OS$DataTypes.VariableHolder();
var string_SplitLevelsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: String_Split
model.flush();
return controller.string_Split$ServerAction(model.variables.stringListIdsIn, ",", callContext).then(function (value) {
string_SplitVar.value = value;
}).then(function () {
// RequisitionIdList = String_Split.List
model.variables.requisitionIdListVar = OS$DataConversion.JSConversions.typeConvertRecordList(string_SplitVar.value.listOut, new (OS$GenericTypeCache.getGenericList(TextRec))(), function (source, target) {
target = source.textAttr;
return target;
});
// Execute Action: String_SplitLevels
model.flush();
return controller.string_Split$ServerAction(model.variables.stringListLevelIdsIn, ",", callContext).then(function (value) {
string_SplitLevelsVar.value = value;
});
}).then(function () {
// RequisitionLevelIdList = String_SplitLevels.List
model.variables.requisitionLevelIdListVar = OS$DataConversion.JSConversions.typeConvertRecordList(string_SplitLevelsVar.value.listOut, new (OS$GenericTypeCache.getGenericList(TextRec))(), function (source, target) {
target = source.textAttr;
return target;
});
// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: SetCurrentLocale
OS$SystemActions.setCurrentLocale("es-MX", callContext);
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c2b9c8e0-3487-403c-90b2-e3646124119b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onInitialize$Action(callContext);

};
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
return ConectaProveedores_z_TableDownloadsPDFController$default.handleError(ex, this.callContext());
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
Controller.registerVariableGroupType("ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF$ActionString_Split", [{
name: "List",
attrName: "listOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(TextRec, {
name: "Text",
attrName: "textAttr",
nameForJson: "Text2",
uniqueId: "0d84b59e-ff89-87c4-71ae-b49dfa9f2c39"
}))))();
},
complexType: (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(TextRec, {
name: "Text",
attrName: "textAttr",
nameForJson: "Text2",
uniqueId: "0d84b59e-ff89-87c4-71ae-b49dfa9f2c39"
}))))
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


