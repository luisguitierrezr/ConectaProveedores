import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, SystemActions as OS$SystemActions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getApprover$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getApprover$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getApprover$DataActRefresh() {if(!(this.hasOwnProperty("_getApprover$DataActRefresh"))) {
this._getApprover$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApprover", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_UploadDocumentsConstructionEdit/DataActionGetApprover", "8qIZSj+gK1hAeyqdNkGSDw", function (b) {
model.variables.getApproverDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApproverDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApproverDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprover", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprover");
span.setAttribute("outsystems.function.key", "8a065165-605a-4d4d-9610-870c3f46c0fc");
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

return this._getApprover$DataActRefresh;
}set getApprover$DataActRefresh(value) {this._getApprover$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getApprover$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "4342112c-45b6-4579-a03d-e3b7f634a4ed");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListIn, callContext);
// ListAux = List
model.variables.listAuxVar = OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.listIn, new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))(), function (source, target) {
target.keyAttr = source.keyAttr;
target.valueAttr = source.valueAttr;
target.fileNameAttr = source.fileNameAttr;
target.mandatoryAttr = source.mandatoryAttr;
target.withDocumentAttr = source.withDocumentAttr;
return target;
});
// Refresh Query: GetApprover
var result = controller.getApprover$DataActRefresh(callContext);
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
_customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "54bc2d93-ffd9-4260-9cbb-fb1bcaafbbea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.CustomUploadOnFileChange$vars"))());
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
OS$SystemActions.listAppend(model.variables.filesListIn, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.isExtraAttr = true;
return target;
}), callContext);
// Execute Action: CheckFiles
return controller._checkFiles$Action(callContext).then(function () {
// Error?
if((((model.variables.errorMsgVar) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Hv9p5LymjECB89ER1X4wVA#Message.875725967.1", "Empty file"), /*Error*/ 3);
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
_removeFromList$Action(indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "72c64e0b-2c12-4d4e-a3bc-c058d084ba74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListIn, vars.value.indexInLocal, callContext);
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
span.setAttribute("outsystems.function.key", "78a3d848-c73c-421f-9445-94c0b9dc9f1b");
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
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_checkFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckFiles", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "cd67eaf8-aaec-412a-8253-2a6e88f450d3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CheckFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.CheckFiles$vars"))());
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
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

// Execute Action: ListDuplicate
OS$SystemActions.listAppendAll(vars.value.filesListDuplicateVar, model.variables.filesListIn, callContext);
// Foreach ListAux
callContext.iterationContext.registerIterationStart(model.variables.listAuxVar);
try {var listAuxIterator = callContext.iterationContext.getIterator(model.variables.listAuxVar);
var listAuxIndex = 0;
while (((listAuxIndex < model.variables.listAuxVar.length))) {
listAuxIterator.currentRowNumber = listAuxIndex;
// Foreach FilesList
callContext.iterationContext.registerIterationStart(model.variables.filesListIn);
try {var filesListIterator = callContext.iterationContext.getIterator(model.variables.filesListIn);
var filesListIndex = 0;
while (((filesListIndex < model.variables.filesListIn.length))) {
filesListIterator.currentRowNumber = filesListIndex;
// Check Names
if(((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toUpper(model.variables.filesListIn.getItem(filesListIndex.valueOf()).nameAttr), OS$BuiltinFunctions.toUpper(model.variables.listAuxVar.getItem(listAuxIndex.valueOf()).fileNameAttr), 0, false, false) >= 0))) {
// Order Validation
if(((OS$BuiltinFunctions.index(model.variables.filesListIn.getItem(filesListIndex.valueOf()).nameAttr, ("_" + model.variables.orderNumberIn), 0, false, false) >= 0))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(vars.value.filesListDuplicateVar, function (p) {
return (OS$BuiltinFunctions.toUpper(OS$BuiltinFunctions.substr(p.nameAttr, 0, OS$BuiltinFunctions.index(p.nameAttr, ".", 0, false, false))) === OS$BuiltinFunctions.toUpper(OS$BuiltinFunctions.substr(model.variables.filesListIn.getItem(filesListIndex.valueOf()).nameAttr, 0, OS$BuiltinFunctions.index(model.variables.filesListIn.getItem(filesListIndex.valueOf()).nameAttr, ".", 0, false, false))));
}, callContext);

// More than 1?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// l_SendErrorMsg = True
vars.value.l_SendErrorMsgVar = true;
} else {
// Set True
// ListAux.Current.WithDocument = True
model.variables.listAuxVar.getItem(listAuxIndex.valueOf()).withDocumentAttr = true;
}

}

}

filesListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.filesListIn);
}

listAuxIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.listAuxVar);
}

// Send Msg?
if((((vars.value.l_SendErrorMsgVar === true) && (model.variables.l_ErrorMsgAlreadySentVar === false)))) {
// ErrorMsg = "You have more then 1 file with same name. Please Verify."
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3T261Vi2FkCVSZJq00nOMQ#Value.-1368458398.1", "You have more then 1 file with same name. Please Verify.");
}

// l_ErrorMsgAlreadySent = l_SendErrorMsg
model.variables.l_ErrorMsgAlreadySentVar = vars.value.l_SendErrorMsgVar;
// Trigger Event: SendFiles
return controller.sendFiles$Action(model.variables.filesListIn, model.variables.listAuxVar, callContext);
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
span.setAttribute("outsystems.function.key", "4342112c-45b6-4579-a03d-e3b7f634a4ed");
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

customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "54bc2d93-ffd9-4260-9cbb-fb1bcaafbbea");
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

removeFromList$Action(indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "72c64e0b-2c12-4d4e-a3bc-c058d084ba74");
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
span.setAttribute("outsystems.function.key", "78a3d848-c73c-421f-9445-94c0b9dc9f1b");
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

checkFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "cd67eaf8-aaec-412a-8253-2a6e88f450d3");
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.CustomUploadOnFileChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.CheckFiles$vars", [{
name: "FilesListDuplicate",
attrName: "filesListDuplicateVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}, {
name: "l_SendErrorMsg",
attrName: "l_SendErrorMsgVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


