import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionOld_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionOld.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionOld_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_checkFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckFiles", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "0ebe6341-ae61-4c8a-8a9e-f251932d52da");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CheckFiles");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Foreach ListAux
callContext.iterationContext.registerIterationStart(model.variables.listAuxVar);
try {var listAuxIterator = callContext.iterationContext.getIterator(model.variables.listAuxVar);
var listAuxIndex = 0;
while (((listAuxIndex < model.variables.listAuxVar.length))) {
listAuxIterator.currentRowNumber = listAuxIndex;
// Set False
// ListAux.Current.WithDocument = False
model.variables.listAuxVar.getItem(listAuxIndex.valueOf()).withDocumentAttr = false;
listAuxIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.listAuxVar);
}

// Foreach ListAux
callContext.iterationContext.registerIterationStart(model.variables.listAuxVar);
try {var listAuxIterator = callContext.iterationContext.getIterator(model.variables.listAuxVar);
var listAuxIndex = 0;
while (((listAuxIndex < model.variables.listAuxVar.length))) {
listAuxIterator.currentRowNumber = listAuxIndex;
// Foreach FilesList
callContext.iterationContext.registerIterationStart(model.variables.filesListVar);
try {var filesListIterator = callContext.iterationContext.getIterator(model.variables.filesListVar);
var filesListIndex = 0;
while (((filesListIndex < model.variables.filesListVar.length))) {
filesListIterator.currentRowNumber = filesListIndex;
// Check Names
if(((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toUpper(model.variables.filesListVar.getItem(filesListIndex.valueOf()).nameAttr), OS$BuiltinFunctions.toUpper(model.variables.listAuxVar.getItem(listAuxIndex.valueOf()).fileNameAttr), 0, false, false) >= 0))) {
// Order Validation
if(((OS$BuiltinFunctions.index(model.variables.filesListVar.getItem(filesListIndex.valueOf()).nameAttr, ("_" + model.variables.orderNumberIn), 0, false, false) >= 0))) {
// Set True
// ListAux.Current.WithDocument = True
model.variables.listAuxVar.getItem(listAuxIndex.valueOf()).withDocumentAttr = true;
}

}

filesListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.filesListVar);
}

listAuxIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.listAuxVar);
}

// Trigger Event: SendFiles
return controller.sendFiles$Action(model.variables.filesListVar, model.variables.listAuxVar, callContext);
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
span.setAttribute("outsystems.function.key", "4e4e1596-ed6f-4c24-b0bf-f4370be55e21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// ListAux = List
model.variables.listAuxVar = OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.listIn, new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))(), function (source, target) {
target.keyAttr = source.keyAttr;
target.valueAttr = source.valueAttr;
target.fileNameAttr = source.fileNameAttr;
target.mandatoryAttr = source.mandatoryAttr;
target.withDocumentAttr = source.withDocumentAttr;
return target;
});
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_removeFromList$Action(indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "59cb68d5-acfb-40c3-9e84-27b534084e0e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionOld.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
// Execute Action: CheckFiles
return controller._checkFiles$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "5c78ab18-06c5-4df8-a256-72c5139cf134");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// ListAux = List
model.variables.listAuxVar = OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.listIn, new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))(), function (source, target) {
target.keyAttr = source.keyAttr;
target.valueAttr = source.valueAttr;
target.fileNameAttr = source.fileNameAttr;
target.mandatoryAttr = source.mandatoryAttr;
target.withDocumentAttr = source.withDocumentAttr;
return target;
});
if((model.variables.isUpdateIn)) {
// FilesList = List
model.variables.filesListVar = OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.listIn, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.isExtraAttr = true;
target.storageIdAttr = source.storageIdAttr;
return target;
});
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "d5aa1edd-c7b9-4f0c-8770-cc03c4e84f0e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionOld.CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.isExtraAttr = true;
return target;
}), callContext);
// Execute Action: CheckFiles
return controller._checkFiles$Action(callContext).then(function () {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qD6A5UZRhU2j0TVaVXdqhg#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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

checkFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "0ebe6341-ae61-4c8a-8a9e-f251932d52da");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._checkFiles$Action, callContext);
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
span.setAttribute("outsystems.function.key", "4e4e1596-ed6f-4c24-b0bf-f4370be55e21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeFromList$Action(indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "59cb68d5-acfb-40c3-9e84-27b534084e0e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, indexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "5c78ab18-06c5-4df8-a256-72c5139cf134");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "d5aa1edd-c7b9-4f0c-8770-cc03c4e84f0e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChange$Action, callContext, fileIn, errorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get sendFiles$Action() {if(!(this.hasOwnProperty("_sendFiles$Action"))) {
this._sendFiles$Action = function () {
return Promise.resolve();
};
}

return this._sendFiles$Action;
}set sendFiles$Action(value) {this._sendFiles$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionOld.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionOld.CustomUploadOnFileChange$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}, {
name: "Error",
attrName: "errorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
},
complexType: ST_f9f8b40f5330871047e55e068d129447Structure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


