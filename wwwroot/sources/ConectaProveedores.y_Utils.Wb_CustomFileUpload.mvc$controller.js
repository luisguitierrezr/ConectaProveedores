import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_controller_OnParametersChanged_DropAreaWidgetIdJS from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$controller.OnParametersChanged.DropAreaWidgetIdJS.js";
import ConectaProveedoresController$default, { file_Validate$Action as ConectaProveedoresController$file_Validate$Action, showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action, base64ToBinary$Action as ConectaProveedoresController$base64ToBinary$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_controller_OnReady_DropAreaWidgetIdJS from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$controller.OnReady.DropAreaWidgetIdJS.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$translationsResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
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
serviceStorageGetFile$ServerAction(i_StorageIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceStorageGetFile", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceStorageGetFile");
span.setAttribute("outsystems.function.key", "1d596008-dc18-403f-8ce0-92ac33d37308");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_StorageId: OS$DataConversion.ServerDataConverter.to(i_StorageIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceStorageGetFile", "screenservices/ConectaProveedores/y_Utils/Wb_CustomFileUpload/ServiceAPIServiceStorageGetFile", "KQirY72iTSCacYF0YZ0tgQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_CustomFileUpload$ServiceAPIServiceStorageGetFile"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.o_filenameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_filename, OS$DataTypes.DataTypes.Text);
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

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
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
span.setAttribute("outsystems.function.key", "1a31a57b-4d56-4f36-8b82-d06a8cd800ef");
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
span.setAttribute("outsystems.function.key", "d4862f0d-6050-47c5-b8ed-8b20014e67ca");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_controller_OnParametersChanged_DropAreaWidgetIdJS, "DropAreaWidgetId", "OnParametersChanged", {
AcceptedFileTypes: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_AcceptedFileTypesIn, OS$DataTypes.DataTypes.Text),
IsEnabled: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_IsEnabledIn, OS$DataTypes.DataTypes.Boolean),
WidgetId: OS$DataConversion.JSNodeParamConverter.to(idService.getId("DropArea"), OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {
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
_onDrop$Action(fileNameIn, fileContentIn, fileSizeIn, fileTypeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDrop", function (span) {
if(span) {
span.setAttribute("code.function", "OnDrop");
span.setAttribute("outsystems.function.key", "2fb2ed7e-3469-4514-b823-a17c916410cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDrop");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_CustomFileUpload.OnDrop$vars"))());
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
// i_StorageId = NullIdentifier
model.variables.i_StorageIdIn = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
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
OS$Logger.debug("Wb_CustomFileUpload.OnDrop", OS$Exceptions.getMessage(ex));
// Handle Error: CommunicationException
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.CommunicationException)) {
OS$Logger.error(null, ex, null, null, 1);
communicationExceptionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("CommunicationException", function (span) {
if(span) {
span.setAttribute("code.function", "CommunicationException");
span.setAttribute("outsystems.function.key", "ab65b430-2725-4ac5-8800-cdaae83eef41");
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c02fb20f-62d1-4512-84bb-096547c7a44e");
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
span.setAttribute("outsystems.function.key", "8e8dd011-fb14-4199-be8a-f537c5380f56");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_controller_OnReady_DropAreaWidgetIdJS, "DropAreaWidgetId", "OnReady", {
WidgetId: OS$DataConversion.JSNodeParamConverter.to(idService.getId("DropArea"), OS$DataTypes.DataTypes.Text),
AcceptedFileTypes: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_AcceptedFileTypesIn, OS$DataTypes.DataTypes.Text),
IsEnabled: OS$DataConversion.JSNodeParamConverter.to(model.variables.i_IsEnabledIn, OS$DataTypes.DataTypes.Boolean)
}, function ($parameters) {
}, {
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
_downloadFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "ca423f11-9448-4968-946c-e09443b222eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadFile");
callContext = controller.callContext(callContext);
var serviceStorageGetFileDepositVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsDownloading = True
model.variables.l_IsDownloadingVar = true;
// Execute Action: ServiceStorageGetFileDeposit
model.flush();
return controller.serviceStorageGetFile$ServerAction(model.variables.i_StorageIdIn, callContext).then(function (value) {
serviceStorageGetFileDepositVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// l_IsDownloading = False
model.variables.l_IsDownloadingVar = false;
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(serviceStorageGetFileDepositVar.value.o_FileOut, serviceStorageGetFileDepositVar.value.o_filenameOut));
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "1a31a57b-4d56-4f36-8b82-d06a8cd800ef");
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

onDrop$Action(fileNameIn, fileContentIn, fileSizeIn, fileTypeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDrop__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDrop");
span.setAttribute("outsystems.function.key", "2fb2ed7e-3469-4514-b823-a17c916410cb");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c02fb20f-62d1-4512-84bb-096547c7a44e");
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

downloadFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "ca423f11-9448-4968-946c-e09443b222eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadFile$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onDelete$Action() {if(!(this.hasOwnProperty("_onDelete$Action"))) {
this._onDelete$Action = function () {
return Promise.resolve();
};
}

return this._onDelete$Action;
}set onDelete$Action(value) {this._onDelete$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_CustomFileUpload$ServiceAPIServiceStorageGetFile", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "o_filename",
attrName: "o_filenameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_CustomFileUpload.OnDrop$vars", [{
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


