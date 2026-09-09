import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Logger as OS$Logger, Flow as OS$Flow, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_controller_StartFileDownloadZip_JavaScript_StartDonwloadJS from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$controller.StartFileDownloadZip.JavaScript_StartDonwloadJS.js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_controller_ProcessNextFileChunkZip_RunJavaScript_ProcessOneChunkJS from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$controller.ProcessNextFileChunkZip.RunJavaScript_ProcessOneChunkJS.js";
import ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_TranslationsResources from "./ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.mvc$translationsResources.js";
import ConectaProveedoresController$default, { setClientTimeouts$Action$Proxy as ConectaProveedoresController$setClientTimeouts$Action$Proxy, getFileChunk$Action$Proxy as ConectaProveedoresController$getFileChunk$Action$Proxy } from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_TranslationsResources);
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
endProcessZip$Action: function endProcessZip$Action$Proxy() {
return controller.executeActionInsideJSNode(controller._endProcessZip$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "EndProcessZip");
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
_startFileDownloadZip$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("StartFileDownloadZip", function (span) {
if(span) {
span.setAttribute("code.function", "StartFileDownloadZip");
span.setAttribute("outsystems.function.key", "31fd21c8-10c9-449d-b9ca-45818cd9b228");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("StartFileDownloadZip");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: StartProcessZip
return controller._startProcessZip$Action(callContext).then(function () {
OS$Logger.startActiveSpan("JavaScript_StartDonwload", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript_StartDonwload");
span.setAttribute("outsystems.function.key", "60b659e7-fd3f-4b0b-b6ea-47517ab3116d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_controller_StartFileDownloadZip_JavaScript_StartDonwloadJS, "JavaScript_StartDonwload", "StartFileDownloadZip", {
FilesJson: OS$DataConversion.JSNodeParamConverter.to(model.variables.fileJsonListIn, OS$DataTypes.DataTypes.Text),
ZipFileName: OS$DataConversion.JSNodeParamConverter.to(model.variables.zipNameIn, OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: ProcessNextFileChunkZip
controller._processNextFileChunkZip$Action(callContext);
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
_endProcessZip$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("EndProcessZip", function (span) {
if(span) {
span.setAttribute("code.function", "EndProcessZip");
span.setAttribute("outsystems.function.key", "4445896b-bdda-474a-bc8f-6f9fb91930fb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("EndProcessZip");
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
_startProcessZip$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("StartProcessZip", function (span) {
if(span) {
span.setAttribute("code.function", "StartProcessZip");
span.setAttribute("outsystems.function.key", "4f6cc13a-2ace-43c0-a728-6198a8b1a015");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("StartProcessZip");
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
_processNextFileChunkZip$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ProcessNextFileChunkZip", function (span) {
if(span) {
span.setAttribute("code.function", "ProcessNextFileChunkZip");
span.setAttribute("outsystems.function.key", "5a848d3d-16fb-4941-8c53-2cdb7ea8bb7b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ProcessNextFileChunkZip");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("RunJavaScript_ProcessOneChunk", function (span) {
if(span) {
span.setAttribute("code.function", "RunJavaScript_ProcessOneChunk");
span.setAttribute("outsystems.function.key", "802cf4b7-a927-4ce3-bd14-2aed379c85c4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByFileList_mvc_controller_ProcessNextFileChunkZip_RunJavaScript_ProcessOneChunkJS, "RunJavaScript_ProcessOneChunk", "ProcessNextFileChunkZip", null, function ($parameters) {
}, {
OnChunkError: controller.clientActionProxies.onChunkError$Action,
SetClientTimeouts: ConectaProveedoresController$setClientTimeouts$Action$Proxy,
GetFileChunk: ConectaProveedoresController$getFileChunk$Action$Proxy,
EndProcessZip: controller.clientActionProxies.endProcessZip$Action
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
_linkOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "a42094a0-3f95-42c0-a711-ce793414dcf3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LinkOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: StartFileDownloadZip
return controller._startFileDownloadZip$Action(callContext);
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
span.setAttribute("outsystems.function.key", "e9e8c82d-7f7b-4e29-9a03-7ccd11218136");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnChunkError");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.OnChunkError$vars"))());
vars.value.errorMessageInLocal = errorMessageIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: EndProcessZip
return controller._endProcessZip$Action(callContext).then(function () {
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

startFileDownloadZip$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("StartFileDownloadZip__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StartFileDownloadZip");
span.setAttribute("outsystems.function.key", "31fd21c8-10c9-449d-b9ca-45818cd9b228");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._startFileDownloadZip$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

endProcessZip$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("EndProcessZip__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "EndProcessZip");
span.setAttribute("outsystems.function.key", "4445896b-bdda-474a-bc8f-6f9fb91930fb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._endProcessZip$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

startProcessZip$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("StartProcessZip__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "StartProcessZip");
span.setAttribute("outsystems.function.key", "4f6cc13a-2ace-43c0-a728-6198a8b1a015");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._startProcessZip$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

processNextFileChunkZip$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ProcessNextFileChunkZip__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ProcessNextFileChunkZip");
span.setAttribute("outsystems.function.key", "5a848d3d-16fb-4941-8c53-2cdb7ea8bb7b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._processNextFileChunkZip$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

linkOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "a42094a0-3f95-42c0-a711-ce793414dcf3");
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

onChunkError$Action(errorMessageIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnChunkError__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnChunkError");
span.setAttribute("outsystems.function.key", "e9e8c82d-7f7b-4e29-9a03-7ccd11218136");
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
Controller.registerVariableGroupType("ConectaProveedores.s_Storage.wb_DownloadAllFolioFilesByFileList.OnChunkError$vars", [{
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


