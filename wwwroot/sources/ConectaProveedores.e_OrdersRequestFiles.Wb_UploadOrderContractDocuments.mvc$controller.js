import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvc_TranslationsResources from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getOrderContractFileById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getOrderContractFileById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
uploadOrderContractDocument$ServerAction(i_OrderRequestFileIdIn, i_OrderContractFileIn, i_OrderMainIdIn, i_InvoiceForeignIn, i_FileIn, i_FilesListIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadOrderContractDocument", function (span) {
if(span) {
span.setAttribute("code.function", "UploadOrderContractDocument");
span.setAttribute("outsystems.function.key", "97bb63dc-1419-450c-95b6-86322207e712");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderRequestFileId: OS$DataConversion.ServerDataConverter.to(i_OrderRequestFileIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_OrderContractFile: OS$DataConversion.ServerDataConverter.to(i_OrderContractFileIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_OrderMainId: OS$DataConversion.ServerDataConverter.to(i_OrderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_InvoiceForeign: OS$DataConversion.ServerDataConverter.to(i_InvoiceForeignIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_File: OS$DataConversion.ServerDataConverter.to(i_FileIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_FilesList: OS$DataConversion.ServerDataConverter.to(i_FilesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UploadOrderContractDocument", "screenservices/ConectaProveedores/e_OrdersRequestFiles/Wb_UploadOrderContractDocuments/ActionUploadOrderContractDocument", "Yg8c5fJGtlbueC43057GiA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getOrderContractFileById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderContractFileById$AggrRefresh"))) {
this._getOrderContractFileById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderContractFileById", "screenservices/ConectaProveedores/e_OrdersRequestFiles/Wb_UploadOrderContractDocuments/ScreenDataSetGetOrderContractFileById", "dzap3svqJ5o8fxLWTxf4uQ", maxRecords, startIndex, function (b) {
model.variables.getOrderContractFileByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderContractFileByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderContractFileByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderContractFileById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderContractFileById");
span.setAttribute("outsystems.function.key", "654a9fa2-d605-4ea5-8e4c-5e1ecb1c693b");
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

return this._getOrderContractFileById$AggrRefresh;
}set getOrderContractFileById$AggrRefresh(value) {this._getOrderContractFileById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getOrderContractFileById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_CustomFileUploadOnDropFile$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDropFile", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDropFile");
span.setAttribute("outsystems.function.key", "778cb2c3-d810-4625-859a-f0ccf4e3d339");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomFileUploadOnDropFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.Wb_CustomFileUploadOnDropFile$vars"))());
vars.value.fileInLocal = fileIn.clone();
// l_File = File
model.variables.l_FileVar = vars.value.fileInLocal;
// Have files?
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// AreFilesUploaded = True
model.variables.areFilesUploadedVar = true;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_CustomFileUploadOnDelete$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDelete", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDelete");
span.setAttribute("outsystems.function.key", "919f6229-8606-4f60-8f50-e369e4287f90");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomFileUploadOnDelete");
callContext = controller.callContext(callContext);
// l_File
// l_File = l_FileEmpty
model.variables.l_FileVar = model.variables.l_FileEmptyVar;
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "99ba00b8-6633-441a-be73-f2a0f7bfa2fd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderContractFileById
var result = controller.getOrderContractFileById$AggrRefresh(50, 0, callContext);
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
_sendFilesOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SendFilesOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SendFilesOnClick");
span.setAttribute("outsystems.function.key", "e4ffebed-8db4-4ecd-9221-3d8ea14d5509");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SendFilesOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: UploadOrderContractDocument
model.flush();
return controller.uploadOrderContractDocument$ServerAction(model.variables.i_OrderRequestFileIdIn, model.variables.getOrderContractFileByIdAggr.listOut.getCurrent(callContext.iterationContext), model.variables.i_OrderMainIdIn, model.variables.invoiceForeignVar, model.variables.l_FileVar, model.variables.filesListVar, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function () {
// Trigger Event: Update
return controller.update$Action(callContext);
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
}).catch(function (ex) {
OS$Logger.debug("Wb_UploadOrderContractDocuments.SendFilesOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "5cf1dfa3-bd23-49bf-92cb-1f2c29c695f2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
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

wb_CustomFileUploadOnDropFile$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDropFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDropFile");
span.setAttribute("outsystems.function.key", "778cb2c3-d810-4625-859a-f0ccf4e3d339");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CustomFileUploadOnDropFile$Action, callContext, fileIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_CustomFileUploadOnDelete$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDelete__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDelete");
span.setAttribute("outsystems.function.key", "919f6229-8606-4f60-8f50-e369e4287f90");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CustomFileUploadOnDelete$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "99ba00b8-6633-441a-be73-f2a0f7bfa2fd");
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

sendFilesOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendFilesOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SendFilesOnClick");
span.setAttribute("outsystems.function.key", "e4ffebed-8db4-4ecd-9221-3d8ea14d5509");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._sendFilesOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get cancel$Action() {if(!(this.hasOwnProperty("_cancel$Action"))) {
this._cancel$Action = function () {
return Promise.resolve();
};
}

return this._cancel$Action;
}set cancel$Action(value) {this._cancel$Action = value;
}

get update$Action() {if(!(this.hasOwnProperty("_update$Action"))) {
this._update$Action = function () {
return Promise.resolve();
};
}

return this._update$Action;
}set update$Action(value) {this._update$Action = value;
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.Wb_CustomFileUploadOnDropFile$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


