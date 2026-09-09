import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvc_TranslationsResources from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
uploadDocumentOrderByProvider$ServerAction(i_RequestFileIdIn, i_OrderMainIdIn, i_FilesListIn, i_FilesListExtraIn, i_InvoiceForeignIn, i_OrderAccConceptsIdIn, i_CreateRequestFileIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadDocumentOrderByProvider", function (span) {
if(span) {
span.setAttribute("code.function", "UploadDocumentOrderByProvider");
span.setAttribute("outsystems.function.key", "8a6b72a5-1217-432a-a378-1edbd363a30f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RequestFileId: OS$DataConversion.ServerDataConverter.to(i_RequestFileIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_OrderMainId: OS$DataConversion.ServerDataConverter.to(i_OrderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
I_FilesList: OS$DataConversion.ServerDataConverter.to(i_FilesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_FilesListExtra: OS$DataConversion.ServerDataConverter.to(i_FilesListExtraIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_InvoiceForeign: OS$DataConversion.ServerDataConverter.to(i_InvoiceForeignIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_OrderAccConceptsId: OS$DataConversion.ServerDataConverter.to(i_OrderAccConceptsIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_CreateRequestFile: OS$DataConversion.ServerDataConverter.to(i_CreateRequestFileIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UploadDocumentOrderByProvider", "screenservices/ConectaProveedores/e_OrdersRequestFiles/Wb_UploadComplementFile/ActionUploadDocumentOrderByProvider", "V9aS3b8q1DPn7uSzjgz86A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile$ActionUploadDocumentOrderByProvider"))();
executeServerActionResult.invoiceIdOut = OS$DataConversion.ServerDataConverter.from(outputs.InvoiceId, OS$DataTypes.DataTypes.LongInteger);
executeServerActionResult.storageIdOut = OS$DataConversion.ServerDataConverter.from(outputs.StorageId, OS$DataTypes.DataTypes.LongInteger);
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
_sendFilesOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SendFilesOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SendFilesOnClick");
span.setAttribute("outsystems.function.key", "61c9fda5-dbea-457e-a7bd-4b2e40e616d9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SendFilesOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var uploadDocumentOrderByProviderVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: UploadDocumentOrderByProvider
model.flush();
return controller.uploadDocumentOrderByProvider$ServerAction(model.variables.i_RequestFileIdIn, model.variables.orderMainIdIn, model.variables.filesListVar, model.variables.filesListExtraVar, model.variables.invoiceForeignVar, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), false, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadDocumentOrderByProviderVar.value = value;
}).then(function () {
// Trigger Event: Update
return controller.update$Action(callContext);
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
}).catch(function (ex) {
OS$Logger.debug("Wb_UploadComplementFile.SendFilesOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "d196c5ed-4dd5-4807-adab-b0df1ae40e6c");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "93dabf76-5a25-4d17-b677-871b5c94eb32");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_SupportSAEUploadSendFilesExtra$Action(o_FilesListExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SupportSAEUploadSendFilesExtra", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SupportSAEUploadSendFilesExtra");
span.setAttribute("outsystems.function.key", "a1e0b98c-944f-4eaa-a467-d302d2f17ccd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SupportSAEUploadSendFilesExtra");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile.Wb_SupportSAEUploadSendFilesExtra$vars"))());
vars.value.o_FilesListExtraInLocal = o_FilesListExtraIn.clone();
// FilesListExtra = o_FilesListExtra
model.variables.filesListExtraVar = vars.value.o_FilesListExtraInLocal;
// Have files?
if(((vars.value.o_FilesListExtraInLocal.length > 0))) {
// AreFilesUploaded = True
model.variables.areFilesUploadedVar = true;
} else {
// AreFilesUploaded = False
model.variables.areFilesUploadedVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

sendFilesOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendFilesOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SendFilesOnClick");
span.setAttribute("outsystems.function.key", "61c9fda5-dbea-457e-a7bd-4b2e40e616d9");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "93dabf76-5a25-4d17-b677-871b5c94eb32");
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

wb_SupportSAEUploadSendFilesExtra$Action(o_FilesListExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SupportSAEUploadSendFilesExtra__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SupportSAEUploadSendFilesExtra");
span.setAttribute("outsystems.function.key", "a1e0b98c-944f-4eaa-a467-d302d2f17ccd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SupportSAEUploadSendFilesExtra$Action, callContext, o_FilesListExtraIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get update$Action() {if(!(this.hasOwnProperty("_update$Action"))) {
this._update$Action = function () {
return Promise.resolve();
};
}

return this._update$Action;
}set update$Action(value) {this._update$Action = value;
}

get cancel$Action() {if(!(this.hasOwnProperty("_cancel$Action"))) {
this._cancel$Action = function () {
return Promise.resolve();
};
}

return this._cancel$Action;
}set cancel$Action(value) {this._cancel$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile$ActionUploadDocumentOrderByProvider", [{
name: "InvoiceId",
attrName: "invoiceIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "StorageId",
attrName: "storageIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile.Wb_SupportSAEUploadSendFilesExtra$vars", [{
name: "o_FilesListExtra",
attrName: "o_FilesListExtraInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


