import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Logger as OS$Logger, Exceptions as OS$Exceptions, Flow as OS$Flow, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_controller_ProcessNextFileChunk_RunJavaScript_ProcessOneChunkJS from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$controller.ProcessNextFileChunk.RunJavaScript_ProcessOneChunkJS.js";
import ConectaProveedoresController$default, { setClientTimeouts$Action$Proxy as ConectaProveedoresController$setClientTimeouts$Action$Proxy, getFileChunk$Action$Proxy as ConectaProveedoresController$getFileChunk$Action$Proxy } from "./ConectaProveedores.controller.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_controller_FinalizeFileDownload_RunJavaScript_FinalizeDownloadJS from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$controller.FinalizeFileDownload.RunJavaScript_FinalizeDownloadJS.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_controller_StartFileDownload_JavaScript_StartDonwloadJS from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$controller.StartFileDownload.JavaScript_StartDonwloadJS.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_TranslationsResources from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_TranslationsResources);
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
_processNextFileChunk$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ProcessNextFileChunk", function (span) {
if(span) {
span.setAttribute("code.function", "ProcessNextFileChunk");
span.setAttribute("outsystems.function.key", "0116cb26-5546-45e0-8f9d-15a1914aba06");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ProcessNextFileChunk");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("RunJavaScript_ProcessOneChunk", function (span) {
if(span) {
span.setAttribute("code.function", "RunJavaScript_ProcessOneChunk");
span.setAttribute("outsystems.function.key", "7cba81a2-828c-4f3f-8deb-523f5f85e585");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_controller_ProcessNextFileChunk_RunJavaScript_ProcessOneChunkJS, "RunJavaScript_ProcessOneChunk", "ProcessNextFileChunk", null, function ($parameters) {
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
_endProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("EndProcess", function (span) {
if(span) {
span.setAttribute("code.function", "EndProcess");
span.setAttribute("outsystems.function.key", "0d963738-8af4-4e7a-9f6a-8a10ca7e016f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("EndProcess");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: End
return controller.end$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onChunkProcessed$Action(isFinishedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnChunkProcessed", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkProcessed");
span.setAttribute("outsystems.function.key", "20aa34ae-7d43-4e70-abf9-d7f6e97ddceb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChunkProcessed");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadFile.OnChunkProcessed$vars"))());
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
_finalizeFileDownload$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("FinalizeFileDownload", function (span) {
if(span) {
span.setAttribute("code.function", "FinalizeFileDownload");
span.setAttribute("outsystems.function.key", "4e6928e0-a445-487b-839a-da7c672c9e93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("FinalizeFileDownload");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
OS$Logger.startActiveSpan("RunJavaScript_FinalizeDownload", function (span) {
if(span) {
span.setAttribute("code.function", "RunJavaScript_FinalizeDownload");
span.setAttribute("outsystems.function.key", "b4109404-f017-4f48-abd7-f4615acdc19c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_controller_FinalizeFileDownload_RunJavaScript_FinalizeDownloadJS, "RunJavaScript_FinalizeDownload", "FinalizeFileDownload", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: EndProcess
return controller._endProcess$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_linkOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "756dc558-5835-4d18-82af-8149178a9f81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LinkOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: StartFileDownload
return controller._startFileDownload$Action(model.variables.i_StorageIdIn, model.variables.i_FilenameIn, OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(((model.variables.i_FileSizeIn.equals(OS$BuiltinFunctions.integerToLongInteger(0))) ? (OS$BuiltinFunctions.integerToDecimal(1)) : (((model.variables.i_FileSizeIn.lte(OS$BuiltinFunctions.integerToLongInteger(((3 * 1024) * 1024)))) ? (OS$BuiltinFunctions.integerToDecimal(1)) : (((OS$BuiltinFunctions.mod(OS$BuiltinFunctions.longIntegerToDecimal(model.variables.i_FileSizeIn), OS$BuiltinFunctions.integerToDecimal(((3 * 1024) * 1024))).equals(OS$BuiltinFunctions.integerToDecimal(0))) ? (OS$BuiltinFunctions.longIntegerToDecimal(model.variables.i_FileSizeIn).div(OS$BuiltinFunctions.integerToDecimal(((3 * 1024) * 1024)))) : (OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.longIntegerToDecimal(model.variables.i_FileSizeIn).div(OS$BuiltinFunctions.integerToDecimal(((3 * 1024) * 1024)))).plus(OS$BuiltinFunctions.integerToDecimal(1)))))))))), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_startFileDownload$Action(fileIdIn, fileNameIn, totalChunksIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("StartFileDownload", function (span) {
if(span) {
span.setAttribute("code.function", "StartFileDownload");
span.setAttribute("outsystems.function.key", "7bf48ff3-6b2c-491e-9eb6-cf74fbd1e813");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("StartFileDownload");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadFile.StartFileDownload$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.fileNameInLocal = fileNameIn;
vars.value.totalChunksInLocal = totalChunksIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: StartProcess
return controller._startProcess$Action(callContext).then(function () {
OS$Logger.startActiveSpan("JavaScript_StartDonwload", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript_StartDonwload");
span.setAttribute("outsystems.function.key", "6d274fb4-b2cf-47ae-a2bf-ae3b90c57745");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_controller_StartFileDownload_JavaScript_StartDonwloadJS, "JavaScript_StartDonwload", "StartFileDownload", {
FileId: OS$DataConversion.JSNodeParamConverter.to(vars.value.fileIdInLocal, OS$DataTypes.DataTypes.LongInteger),
TotalChunks: OS$DataConversion.JSNodeParamConverter.to(vars.value.totalChunksInLocal, OS$DataTypes.DataTypes.Integer),
FileName: OS$DataConversion.JSNodeParamConverter.to(vars.value.fileNameInLocal, OS$DataTypes.DataTypes.Text)
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
_startProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("StartProcess", function (span) {
if(span) {
span.setAttribute("code.function", "StartProcess");
span.setAttribute("outsystems.function.key", "d49461e7-7c77-4fe1-8294-80266a47f74c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("StartProcess");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: Start
return controller.start$Action(callContext);
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
span.setAttribute("outsystems.function.key", "de070aec-07ee-4083-804e-a4e68e45978c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChunkError");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadFile.OnChunkError$vars"))());
vars.value.errorMessageInLocal = errorMessageIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: EndProcess
return controller._endProcess$Action(callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorMessageInLocal, /*Error*/ 3);
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

processNextFileChunk$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ProcessNextFileChunk__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ProcessNextFileChunk");
span.setAttribute("outsystems.function.key", "0116cb26-5546-45e0-8f9d-15a1914aba06");
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

endProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("EndProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "EndProcess");
span.setAttribute("outsystems.function.key", "0d963738-8af4-4e7a-9f6a-8a10ca7e016f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._endProcess$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onChunkProcessed$Action(isFinishedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnChunkProcessed__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkProcessed");
span.setAttribute("outsystems.function.key", "20aa34ae-7d43-4e70-abf9-d7f6e97ddceb");
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

finalizeFileDownload$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FinalizeFileDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FinalizeFileDownload");
span.setAttribute("outsystems.function.key", "4e6928e0-a445-487b-839a-da7c672c9e93");
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

linkOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "756dc558-5835-4d18-82af-8149178a9f81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._linkOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

startFileDownload$Action(fileIdIn, fileNameIn, totalChunksIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("StartFileDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StartFileDownload");
span.setAttribute("outsystems.function.key", "7bf48ff3-6b2c-491e-9eb6-cf74fbd1e813");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._startFileDownload$Action, callContext, fileIdIn, fileNameIn, totalChunksIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

startProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("StartProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StartProcess");
span.setAttribute("outsystems.function.key", "d49461e7-7c77-4fe1-8294-80266a47f74c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._startProcess$Action, callContext);
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
span.setAttribute("outsystems.function.key", "de070aec-07ee-4083-804e-a4e68e45978c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onChunkError$Action, callContext, errorMessageIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get end$Action() {if(!(this.hasOwnProperty("_end$Action"))) {
this._end$Action = function () {
return Promise.resolve();
};
}

return this._end$Action;
}set end$Action(value) {this._end$Action = value;
}

get start$Action() {if(!(this.hasOwnProperty("_start$Action"))) {
this._start$Action = function () {
return Promise.resolve();
};
}

return this._start$Action;
}set start$Action(value) {this._start$Action = value;
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadFile.OnChunkProcessed$vars", [{
name: "IsFinished",
attrName: "isFinishedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadFile.StartFileDownload$vars", [{
name: "FileId",
attrName: "fileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "FileName",
attrName: "fileNameInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
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
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadFile.OnChunkError$vars", [{
name: "ErrorMessage",
attrName: "errorMessageInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


