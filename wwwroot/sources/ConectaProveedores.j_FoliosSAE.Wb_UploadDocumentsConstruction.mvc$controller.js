import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, SystemActions as OS$SystemActions, Flow as OS$Flow, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstruction_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstruction_mvc_TranslationsResources);
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
_wb_BigUploadMultipleFilesEventstartProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventstartProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventstartProcess");
span.setAttribute("outsystems.function.key", "640b0307-c386-4b73-b87b-275d20dd326e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesEventstartProcess");
callContext = controller.callContext(callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadMultipleFilesEventEndProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventEndProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventEndProcess");
span.setAttribute("outsystems.function.key", "754ac269-c18e-44db-9cb7-1a73cd194aad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesEventEndProcess");
callContext = controller.callContext(callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
span.setAttribute("outsystems.function.key", "94ffbdb3-7e75-4fed-87bd-351a4ff9d9f8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.RemoveFromList$vars"))());
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
span.setAttribute("outsystems.function.key", "a4d0e774-d05b-4dad-9e3d-bf573b615788");
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
_customUploadOnFileChangeBigFile$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeBigFile", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeBigFile");
span.setAttribute("outsystems.function.key", "b845de65-7356-49d3-b99a-361a2906c0d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChangeBigFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.CustomUploadOnFileChangeBigFile$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if(((OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary()) && vars.value.fileInLocal.fileBigFileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+5hRMXX42Uy11_aGuKo3KQ#Message.875725967.1", "Empty file"), /*Error*/ 3);
} else {
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.fileIdAttr = OS$BuiltinFunctions.longIntegerToIdentifier(source.fileBigFileIdAttr);
return target;
}), callContext);
// Execute Action: CheckFiles
return controller._checkFiles$Action(callContext).then(function () {
// Error?
if((((model.variables.errorMsgVar) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(model.variables.errorMsgVar, /*Error*/ 3);
}

});
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
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
_wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesNotifyFileId", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesNotifyFileId");
span.setAttribute("outsystems.function.key", "bd8fc957-572b-4d88-b423-05a2bb4f5dfc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("wb_BigUploadMultipleFilesNotifyFileId");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.wb_BigUploadMultipleFilesNotifyFileId$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.filenameInLocal = filenameIn;
vars.value.mimeTypeInLocal = mimeTypeIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CustomUploadOnFileChangeBigFile
return controller._customUploadOnFileChangeBigFile$Action(function () {
var rec = new ST_1d6498da9105fbe815a7f766352917c0Structure();
rec.fileNameAttr = vars.value.filenameInLocal;
rec.fileMimeTypeAttr = vars.value.mimeTypeInLocal;
rec.fileBigFileIdAttr = vars.value.fileIdInLocal;
return rec;
}(), function () {
var rec = new ST_f9f8b40f5330871047e55e068d129447Structure();
rec.successAttr = true;
return rec;
}(), callContext);
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
span.setAttribute("outsystems.function.key", "bead506f-30b0-40e7-9a91-f6a6d5656e1b");
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
_checkFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckFiles", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "dccd5f99-87d0-4caf-adad-84d55d70381d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CheckFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.CheckFiles$vars"))());
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
OS$SystemActions.listAppendAll(vars.value.filesListDuplicateVar, model.variables.filesListVar, callContext);
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
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(vars.value.filesListDuplicateVar, function (p) {
return (OS$BuiltinFunctions.toUpper(OS$BuiltinFunctions.substr(p.nameAttr, 0, OS$BuiltinFunctions.index(p.nameAttr, ".", 0, false, false))) === OS$BuiltinFunctions.toUpper(OS$BuiltinFunctions.substr(model.variables.filesListVar.getItem(filesListIndex.valueOf()).nameAttr, 0, OS$BuiltinFunctions.index(model.variables.filesListVar.getItem(filesListIndex.valueOf()).nameAttr, ".", 0, false, false))));
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
callContext.iterationContext.registerIterationEnd(model.variables.filesListVar);
}

listAuxIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.listAuxVar);
}

// Send Msg?
if((((vars.value.l_SendErrorMsgVar === true) && (model.variables.l_ErrorMsgAlreadySentVar === false)))) {
// ErrorMsg = "You have more then 1 file with same name. Please Verify."
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7yFrbkPIa0iy_gqMnHO9cA#Value.-1368458398.1", "You have more then 1 file with same name. Please Verify.");
}

// l_ErrorMsgAlreadySent = l_SendErrorMsg
model.variables.l_ErrorMsgAlreadySentVar = vars.value.l_SendErrorMsgVar;
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

wb_BigUploadMultipleFilesEventstartProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventstartProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventstartProcess");
span.setAttribute("outsystems.function.key", "640b0307-c386-4b73-b87b-275d20dd326e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesEventstartProcess$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadMultipleFilesEventEndProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventEndProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventEndProcess");
span.setAttribute("outsystems.function.key", "754ac269-c18e-44db-9cb7-1a73cd194aad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesEventEndProcess$Action, callContext);
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
span.setAttribute("outsystems.function.key", "94ffbdb3-7e75-4fed-87bd-351a4ff9d9f8");
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
span.setAttribute("outsystems.function.key", "a4d0e774-d05b-4dad-9e3d-bf573b615788");
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

customUploadOnFileChangeBigFile$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeBigFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeBigFile");
span.setAttribute("outsystems.function.key", "b845de65-7356-49d3-b99a-361a2906c0d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChangeBigFile$Action, callContext, fileIn, errorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesNotifyFileId__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesNotifyFileId");
span.setAttribute("outsystems.function.key", "bd8fc957-572b-4d88-b423-05a2bb4f5dfc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesNotifyFileId$Action, callContext, fileIdIn, filenameIn, mimeTypeIn);
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
span.setAttribute("outsystems.function.key", "bead506f-30b0-40e7-9a91-f6a6d5656e1b");
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

checkFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "dccd5f99-87d0-4caf-adad-84d55d70381d");
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.CustomUploadOnFileChangeBigFile$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.wb_BigUploadMultipleFilesNotifyFileId$vars", [{
name: "FileId",
attrName: "fileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "Filename",
attrName: "filenameInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "MimeType",
attrName: "mimeTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.CheckFiles$vars", [{
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


