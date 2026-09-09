import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, FeedbackMessageService as OS$FeedbackMessageService, Logger as OS$Logger, Exceptions as OS$Exceptions, Flow as OS$Flow, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { file_Validate$Action as ConectaProveedoresController$file_Validate$Action, base64ToBinary$Action as ConectaProveedoresController$base64ToBinary$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_controller_OnParametersChanged_DropAreaWidgetIdJS from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$controller.OnParametersChanged.DropAreaWidgetIdJS.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_controller_OnReady_DropAreaWidgetIdJS from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$controller.OnReady.DropAreaWidgetIdJS.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$translationsResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
onDropError$Action: function onDropError$Action$Proxy(messageIn) {
messageIn = (messageIn === undefined) ? "" : messageIn;
return controller.executeActionInsideJSNode(controller._onDropError$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(messageIn, OS$DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnDropError");
},
onDrop$Action: function onDrop$Action$Proxy(fileNameIn, fileContentIn, fileSizeIn, fileTypeIn) {
fileNameIn = (fileNameIn === undefined) ? "" : fileNameIn;
fileContentIn = (fileContentIn === undefined) ? "" : fileContentIn;
fileSizeIn = (fileSizeIn === undefined) ? 0 : fileSizeIn;
fileTypeIn = (fileTypeIn === undefined) ? "" : fileTypeIn;
return controller.executeActionInsideJSNode(controller._onDrop$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(fileNameIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(fileContentIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(fileSizeIn, OS$DataTypes.DataTypes.Integer), OS$DataConversion.JSNodeParamConverter.from(fileTypeIn, OS$DataTypes.DataTypes.Text)), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "OnDrop");
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
_onDropError$Action(messageIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDropError", function (span) {
if(span) {
span.setAttribute("code.function", "OnDropError");
span.setAttribute("outsystems.function.key", "03c3cee0-06bf-498e-a690-2730b0e2e571");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDropError");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_MultiFileUpload.OnDropError$vars"))());
vars.value.messageInLocal = messageIn;
OS$FeedbackMessageService.showFeedbackMessage(vars.value.messageInLocal, /*Error*/ 3);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onDrop$Action(fileNameIn, fileContentIn, fileSizeIn, fileTypeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDrop", function (span) {
if(span) {
span.setAttribute("code.function", "OnDrop");
span.setAttribute("outsystems.function.key", "9f3f6fe8-e475-4ddd-8bab-d2ef3a300208");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDrop");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_MultiFileUpload.OnDrop$vars"))());
vars.value.fileNameInLocal = fileNameIn;
vars.value.fileContentInLocal = fileContentIn;
vars.value.fileSizeInLocal = fileSizeIn;
vars.value.fileTypeInLocal = fileTypeIn;
var communicationExceptionVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var file_ValidateVar = new OS$DataTypes.VariableHolder();
var base64ToBinaryVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: File_Validate
file_ValidateVar.value = ConectaProveedoresController$file_Validate$Action(vars.value.fileSizeInLocal, model.variables.i_FilesMaxSizeIn, vars.value.fileContentInLocal, model.variables.i_AcceptedFileTypesIn, vars.value.fileTypeInLocal, callContext);

// Valid File?
return OS$Flow.executeSequence(function () {
if((file_ValidateVar.value.errorOut.successAttr)) {
// Execute Action: Base64ToBinary
base64ToBinaryVar.value = ConectaProveedoresController$base64ToBinary$Action(file_ValidateVar.value.validBase64Out, callContext);

// Trigger Event: SuccessReceiveFile
return controller.onDropFile$Action(function () {
var rec = new ST_1d6498da9105fbe815a7f766352917c0Structure();
rec.fileNameAttr = vars.value.fileNameInLocal;
rec.fileMimeTypeAttr = vars.value.fileTypeInLocal;
rec.fileSizeAttr = (vars.value.fileSizeInLocal).toString();
rec.fileContentAttr = base64ToBinaryVar.value.binaryOut;
rec.fileContentURLAttr = vars.value.fileContentInLocal;
return rec;
}(), function () {
var rec = new ST_f9f8b40f5330871047e55e068d129447Structure();
rec.successAttr = true;
rec.errorMessageAttr = "";
return rec;
}(), callContext);
} else {
// Trigger Event: ErrorReceiveFile
return controller.onDropFile$Action(function () {
var rec = new ST_1d6498da9105fbe815a7f766352917c0Structure();
return rec;
}(), file_ValidateVar.value.errorOut, callContext);
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_MultiFileUpload.OnDrop", OS$Exceptions.getMessage(ex));
// Handle Error: CommunicationException
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.CommunicationException)) {
OS$Logger.error(null, ex, null, null, 1);
communicationExceptionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("CommunicationException", function (span) {
if(span) {
span.setAttribute("code.function", "CommunicationException");
span.setAttribute("outsystems.function.key", "596e4f61-0072-443b-b24d-6e02d5c9d612");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// CommunicationException
OS$FeedbackMessageService.showFeedbackMessage(communicationExceptionVar.value.exceptionMessageAttr, /*Error*/ 3);
return OS$Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
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
span.setAttribute("outsystems.function.key", "bea23e85-3190-423f-898a-a27d07d22558");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// Javascript that makes a widget area droppable and dragable to files.
OS$Logger.startActiveSpan("DropAreaWidgetId", function (span) {
if(span) {
span.setAttribute("code.function", "DropAreaWidgetId");
span.setAttribute("outsystems.function.key", "ef273245-7aa3-44ef-937c-9aee39b18877");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_controller_OnParametersChanged_DropAreaWidgetIdJS, "DropAreaWidgetId", "OnParametersChanged", {
WidgetId: OS$DataConversion.JSNodeParamConverter.to(idService.getId("DropArea"), OS$DataTypes.DataTypes.Text),
IsEnabled: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_IsEnabledIn, OS$DataTypes.DataTypes.Boolean),
AcceptedFileTypes: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_AcceptedFileTypesIn, OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
OnDropError: controller.clientActionProxies.onDropError$Action,
OnDrop: controller.clientActionProxies.onDrop$Action
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c4578c57-d61e-4997-ba6e-0b337745881f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
// Javascript that makes a widget area droppable and dragable to files.
OS$Logger.startActiveSpan("DropAreaWidgetId", function (span) {
if(span) {
span.setAttribute("code.function", "DropAreaWidgetId");
span.setAttribute("outsystems.function.key", "a30f9d57-3579-4a65-aff6-5ca27a71e9ea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_controller_OnReady_DropAreaWidgetIdJS, "DropAreaWidgetId", "OnReady", {
AcceptedFileTypes: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_AcceptedFileTypesIn, OS$DataTypes.DataTypes.Text),
IsEnabled: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_IsEnabledIn, OS$DataTypes.DataTypes.Boolean),
WidgetId: OS$DataConversion.JSNodeParamConverter.to(idService.getId("DropArea"), OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
OnDropError: controller.clientActionProxies.onDropError$Action,
OnDrop: controller.clientActionProxies.onDrop$Action
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

onDropError$Action(messageIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDropError__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDropError");
span.setAttribute("outsystems.function.key", "03c3cee0-06bf-498e-a690-2730b0e2e571");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onDropError$Action, callContext, messageIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onDrop$Action(fileNameIn, fileContentIn, fileSizeIn, fileTypeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDrop__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDrop");
span.setAttribute("outsystems.function.key", "9f3f6fe8-e475-4ddd-8bab-d2ef3a300208");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onDrop$Action, callContext, fileNameIn, fileContentIn, fileSizeIn, fileTypeIn);
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
span.setAttribute("outsystems.function.key", "bea23e85-3190-423f-898a-a27d07d22558");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c4578c57-d61e-4997-ba6e-0b337745881f");
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

get onDropFile$Action() {if(!(this.hasOwnProperty("_onDropFile$Action"))) {
this._onDropFile$Action = function () {
return Promise.resolve();
};
}

return this._onDropFile$Action;
}set onDropFile$Action(value) {this._onDropFile$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_MultiFileUpload.OnDropError$vars", [{
name: "Message",
attrName: "messageInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_MultiFileUpload.OnDrop$vars", [{
name: "FileName",
attrName: "fileNameInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FileContent",
attrName: "fileContentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FileSize",
attrName: "fileSizeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "FileType",
attrName: "fileTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


