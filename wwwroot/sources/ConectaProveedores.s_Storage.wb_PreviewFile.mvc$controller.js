import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action, setClientTimeouts$Action$Proxy as ConectaProveedoresController$setClientTimeouts$Action$Proxy, getFileChunk$Action$Proxy as ConectaProveedoresController$getFileChunk$Action$Proxy } from "./ConectaProveedores.controller.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_controller_StartFileDownload_JavaScript_StartDonwloadJS from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$controller.StartFileDownload.JavaScript_StartDonwloadJS.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_controller_ProcessNextFileChunk_RunJavaScript_ProcessOneChunkJS from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$controller.ProcessNextFileChunk.RunJavaScript_ProcessOneChunkJS.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_controller_FinalizeFileDownload_RunJavaScript_FinalizeDownloadJS from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$controller.FinalizeFileDownload.RunJavaScript_FinalizeDownloadJS.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_TranslationsResources from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_s_Storage_wb_PreviewFile_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onChunkError$Action: function onChunkError$Action$Proxy(errorMessageIn) {
errorMessageIn = (errorMessageIn === undefined) ? "" : errorMessageIn;
return controller.executeActionInsideJSNode(controller._onChunkError$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(errorMessageIn, OS$DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnChunkError");
},
onChunkProcessed$Action: function onChunkProcessed$Action$Proxy(isFinishedIn) {
isFinishedIn = (isFinishedIn === undefined) ? false : isFinishedIn;
return controller.executeActionInsideJSNode(controller._onChunkProcessed$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(isFinishedIn, OS$DataTypes.DataTypes.Boolean)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnChunkProcessed");
}
};
this.dataFetchDependenciesOriginal = {
getStorageById$AggrRefresh: -1
};
this.dataFetchDependentsGraph = {
getStorageById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
getFileDataFromBase64$ServerAction(i_Base64In, i_FilenameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFileDataFromBase64", function (span) {
if(span) {
span.setAttribute("code.function", "GetFileDataFromBase64");
span.setAttribute("outsystems.function.key", "470a0bc9-161f-4219-90dd-a8b32f82e19e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Base64: OS$DataConversion.ServerDataConverter.to(i_Base64In, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Filename: OS$DataConversion.ServerDataConverter.to(i_FilenameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetFileDataFromBase64", "screenservices/ConectaProveedores/s_Storage/wb_PreviewFile/ActionGetFileDataFromBase64", "_a2rg8BFQDXbgQnzciHk4g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile$ActionGetFileDataFromBase64"))();
executeServerActionResult.o_BinaryOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Binary, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.o_xmlOut = OS$DataConversion.ServerDataConverter.from(outputs.o_xml, OS$DataTypes.DataTypes.Text);
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
get getStorageById$AggrRefresh() {if(!(this.hasOwnProperty("_getStorageById$AggrRefresh"))) {
this._getStorageById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetStorageById", "screenservices/ConectaProveedores/s_Storage/wb_PreviewFile/ScreenDataSetGetStorageById", "7Jh2qQxG4ohWYg3hZh5BdA", maxRecords, startIndex, function (b) {
model.variables.getStorageByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getStorageByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getStorageByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getStorageByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetStorageById", function (span) {
if(span) {
span.setAttribute("code.function", "GetStorageById");
span.setAttribute("outsystems.function.key", "4e7a9d16-b524-43c9-98a6-0c55de5c6dc5");
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

return this._getStorageById$AggrRefresh;
}set getStorageById$AggrRefresh(value) {this._getStorageById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getStorageById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onChunkProcessed$Action(isFinishedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnChunkProcessed", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkProcessed");
span.setAttribute("outsystems.function.key", "1a28011a-0e19-46ed-90a4-6cebfb5f82ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChunkProcessed");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.OnChunkProcessed$vars"))());
vars.value.isFinishedInLocal = isFinishedIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isFinishedInLocal)) {
// Execute Action: FinalizeFileDownload
return controller._finalizeFileDownload$Action(callContext);
} else {
// Execute Action: ProcessNextFileChunk
controller._processNextFileChunk$Action(callContext);
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
_previewOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PreviewOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "PreviewOnClick");
span.setAttribute("outsystems.function.key", "4f69a350-ea3e-43bc-b0da-93199277dade");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PreviewOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: StartFileDownload
return controller._startFileDownload$Action(model.variables.i_StorageIdIn, OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(((model.variables.i_FileSizeIn.equals(OS$BuiltinFunctions.integerToLongInteger(0))) ? (OS$BuiltinFunctions.integerToDecimal(1)) : (((model.variables.i_FileSizeIn.lte(OS$BuiltinFunctions.integerToLongInteger(((3 * 1024) * 1024)))) ? (OS$BuiltinFunctions.integerToDecimal(1)) : (((OS$BuiltinFunctions.mod(OS$BuiltinFunctions.longIntegerToDecimal(model.variables.i_FileSizeIn), OS$BuiltinFunctions.integerToDecimal(((3 * 1024) * 1024))).equals(OS$BuiltinFunctions.integerToDecimal(0))) ? (OS$BuiltinFunctions.longIntegerToDecimal(model.variables.i_FileSizeIn).div(OS$BuiltinFunctions.integerToDecimal(((3 * 1024) * 1024)))) : (OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.longIntegerToDecimal(model.variables.i_FileSizeIn).div(OS$BuiltinFunctions.integerToDecimal(((3 * 1024) * 1024)))).plus(OS$BuiltinFunctions.integerToDecimal(1)))))))))), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_closeOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CloseOnClick");
span.setAttribute("outsystems.function.key", "652db929-a0b4-4f96-bad4-50055204b92b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseOnClick");
callContext = controller.callContext(callContext);
// l_PopupToggler = False
model.variables.l_PopupTogglerVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_startFileDownload$Action(fileIdIn, totalChunksIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("StartFileDownload", function (span) {
if(span) {
span.setAttribute("code.function", "StartFileDownload");
span.setAttribute("outsystems.function.key", "65996051-dd76-46a8-87d4-24e9a4e27ad2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("StartFileDownload");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.StartFileDownload$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.totalChunksInLocal = totalChunksIn;
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetStorageById
var result = controller.getStorageById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
OS$Logger.startActiveSpan("JavaScript_StartDonwload", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript_StartDonwload");
span.setAttribute("outsystems.function.key", "b367cda5-5971-4e14-af1a-6cdebca6e17d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_controller_StartFileDownload_JavaScript_StartDonwloadJS, "JavaScript_StartDonwload", "StartFileDownload", {
FileId: OS$DataConversion.JSNodeParamConverter.to(vars.value.fileIdInLocal, OS$DataTypes.DataTypes.LongInteger),
TotalChunks: OS$DataConversion.JSNodeParamConverter.to(vars.value.totalChunksInLocal, OS$DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: ProcessNextFileChunk
controller._processNextFileChunk$Action(callContext);
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
span.setAttribute("outsystems.function.key", "76a0e37d-bbcd-4da2-b7f4-0d3266b3ac77");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((false)) {
// Refresh Query: GetStorageById
var result = controller.getStorageById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
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
_onChunkError$Action(errorMessageIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnChunkError", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkError");
span.setAttribute("outsystems.function.key", "8c56cf70-9fd3-40b3-b84a-46eac2b61ce3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnChunkError");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.OnChunkError$vars"))());
vars.value.errorMessageInLocal = errorMessageIn;
// FileStruct = FileStructEmpty
model.variables.fileStructVar = vars.value.fileStructEmptyVar;
// XML_Text = XML_TextEmpty
model.variables.xML_TextVar = vars.value.xML_TextEmptyVar;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorMessageInLocal, /*Error*/ 3);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_processNextFileChunk$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ProcessNextFileChunk", function (span) {
if(span) {
span.setAttribute("code.function", "ProcessNextFileChunk");
span.setAttribute("outsystems.function.key", "c32e2979-6e61-4e18-8472-1ea330b45cd1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ProcessNextFileChunk");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("RunJavaScript_ProcessOneChunk", function (span) {
if(span) {
span.setAttribute("code.function", "RunJavaScript_ProcessOneChunk");
span.setAttribute("outsystems.function.key", "955bc376-d699-49c0-b290-048d725f5836");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_controller_ProcessNextFileChunk_RunJavaScript_ProcessOneChunkJS, "RunJavaScript_ProcessOneChunk", "ProcessNextFileChunk", null, function ($parameters) {
}, {
SetClientTimeouts: ConectaProveedoresController$setClientTimeouts$Action$Proxy,
OnChunkError: controller.clientActionProxies.onChunkError$Action,
GetFileChunk: ConectaProveedoresController$getFileChunk$Action$Proxy,
OnChunkProcessed: controller.clientActionProxies.onChunkProcessed$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getStorageByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetStorageByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetStorageByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "d6b4da11-fa09-4b09-b7ce-b0762a7baff4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetStorageByIdOnAfterFetch");
callContext = controller.callContext(callContext);
// FileStruct.Name = GetStorageById.List.Current.Storage.Filename
model.variables.fileStructVar.nameAttr = model.variables.getStorageByIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_finalizeFileDownload$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("FinalizeFileDownload", function (span) {
if(span) {
span.setAttribute("code.function", "FinalizeFileDownload");
span.setAttribute("outsystems.function.key", "e0676ff9-2149-4d9d-b9d7-b88e61a35528");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("FinalizeFileDownload");
callContext = controller.callContext(callContext);
var getFileDataFromBase64Var = new OS$DataTypes.VariableHolder();
var runJavaScript_FinalizeDownloadJSResult = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
runJavaScript_FinalizeDownloadJSResult.value = OS$Logger.startActiveSpan("RunJavaScript_FinalizeDownload", function (span) {
if(span) {
span.setAttribute("code.function", "RunJavaScript_FinalizeDownload");
span.setAttribute("outsystems.function.key", "62836223-8091-46fd-8e20-a5b14a861e31");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_controller_FinalizeFileDownload_RunJavaScript_FinalizeDownloadJS, "RunJavaScript_FinalizeDownload", "FinalizeFileDownload", {
File: OS$DataConversion.JSNodeParamConverter.to("", OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.FinalizeFileDownload$runJavaScript_FinalizeDownloadJSResult"))();
jsNodeResult.fileOut = OS$DataConversion.JSNodeParamConverter.from($parameters.File, OS$DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: GetFileDataFromBase64
model.flush();
return controller.getFileDataFromBase64$ServerAction(runJavaScript_FinalizeDownloadJSResult.value.fileOut, model.variables.getStorageByIdAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.filenameAttr, callContext).then(function (value) {
getFileDataFromBase64Var.value = value;
}).then(function () {
// Assign Locals
// XML_Text = GetFileDataFromBase64.o_xml
model.variables.xML_TextVar = getFileDataFromBase64Var.value.o_xmlOut;
// FileStruct.BinaryData = GetFileDataFromBase64.o_Binary
model.variables.fileStructVar.binaryDataAttr = getFileDataFromBase64Var.value.o_BinaryOut;
// Set l_PopupToggler
// l_PopupToggler = True
model.variables.l_PopupTogglerVar = true;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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

onChunkProcessed$Action(isFinishedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnChunkProcessed__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkProcessed");
span.setAttribute("outsystems.function.key", "1a28011a-0e19-46ed-90a4-6cebfb5f82ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onChunkProcessed$Action, callContext, isFinishedIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

previewOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PreviewOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PreviewOnClick");
span.setAttribute("outsystems.function.key", "4f69a350-ea3e-43bc-b0da-93199277dade");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._previewOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

closeOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseOnClick");
span.setAttribute("outsystems.function.key", "652db929-a0b4-4f96-bad4-50055204b92b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

startFileDownload$Action(fileIdIn, totalChunksIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("StartFileDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StartFileDownload");
span.setAttribute("outsystems.function.key", "65996051-dd76-46a8-87d4-24e9a4e27ad2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._startFileDownload$Action, callContext, fileIdIn, totalChunksIn);
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
span.setAttribute("outsystems.function.key", "76a0e37d-bbcd-4da2-b7f4-0d3266b3ac77");
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

onChunkError$Action(errorMessageIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnChunkError__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkError");
span.setAttribute("outsystems.function.key", "8c56cf70-9fd3-40b3-b84a-46eac2b61ce3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onChunkError$Action, callContext, errorMessageIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

processNextFileChunk$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ProcessNextFileChunk__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ProcessNextFileChunk");
span.setAttribute("outsystems.function.key", "c32e2979-6e61-4e18-8472-1ea330b45cd1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._processNextFileChunk$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getStorageByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetStorageByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetStorageByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "d6b4da11-fa09-4b09-b7ce-b0762a7baff4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getStorageByIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

finalizeFileDownload$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FinalizeFileDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FinalizeFileDownload");
span.setAttribute("outsystems.function.key", "e0676ff9-2149-4d9d-b9d7-b88e61a35528");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._finalizeFileDownload$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile$ActionGetFileDataFromBase64", [{
name: "o_Binary",
attrName: "o_BinaryOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "o_xml",
attrName: "o_xmlOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.OnChunkProcessed$vars", [{
name: "IsFinished",
attrName: "isFinishedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.StartFileDownload$vars", [{
name: "FileId",
attrName: "fileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "TotalChunks",
attrName: "totalChunksInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.OnChunkError$vars", [{
name: "ErrorMessage",
attrName: "errorMessageInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FileStructEmpty",
attrName: "fileStructEmptyVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}, {
name: "XML_TextEmpty",
attrName: "xML_TextEmptyVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_PreviewFile.FinalizeFileDownload$runJavaScript_FinalizeDownloadJSResult", [{
name: "File",
attrName: "fileOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


