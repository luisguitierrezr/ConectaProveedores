import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvc_TranslationsResources from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
invoiceFilesById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
invoiceFilesById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
downloadZipByStorageIdList$ServerAction(storageIdListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadZipByStorageIdList", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadZipByStorageIdList");
span.setAttribute("outsystems.function.key", "96d47c1a-4794-40f8-9e8b-f86c907531f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
StorageIdList: OS$DataConversion.ServerDataConverter.to(storageIdListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadZipByStorageIdList", "screenservices/ConectaProveedores/d_InvoiceAudit/Wb_InvoiceFilesAudit/ActionDownloadZipByStorageIdList", "_MlgTXx0PjIU+aZSBjJfmg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit$ActionDownloadZipByStorageIdList"))();
executeServerActionResult.binaryZIPOut = OS$DataConversion.ServerDataConverter.from(outputs.BinaryZIP, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.errorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMsg, OS$DataTypes.DataTypes.Text);
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
get invoiceFilesById$AggrRefresh() {if(!(this.hasOwnProperty("_invoiceFilesById$AggrRefresh"))) {
this._invoiceFilesById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetInvoiceFilesById", "screenservices/ConectaProveedores/d_InvoiceAudit/Wb_InvoiceFilesAudit/ScreenDataSetInvoiceFilesById", "wINXILRJICCSpMgDVsTB1g", maxRecords, startIndex, function (b) {
model.variables.invoiceFilesByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.invoiceFilesByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.invoiceFilesByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("InvoiceFilesById", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceFilesById");
span.setAttribute("outsystems.function.key", "305b84d2-6a21-46f0-8b6f-e75277f04a64");
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

return this._invoiceFilesById$AggrRefresh;
}set invoiceFilesById$AggrRefresh(value) {this._invoiceFilesById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["invoiceFilesById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_DownloadFileStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "29c6b314-28df-4ce6-85b7-eadf511feea7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadFileStart");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "5da177c7-3cfe-4791-ac6b-4feeca2bb679");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Is Save All Files
return OS$Flow.executeSequence(function () {
if((model.variables.i_IsSaveAllFilesIn)) {
// Execute Action: DonwloadZIPFilesOnClick
return controller._donwloadZIPFilesOnClick$Action(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.invoiceFilesByIdAggr.listOut, new OS$DataTypes.LongIntegerList(), function (source, target) {
target = source.invoiceFileAttr.storageIdAttr;
return target;
}), callContext).then(function () {
// Trigger Event: AfterSaveAllFiles
return controller.afterSaveAllFiles$Action(callContext);
});
} else {
// Is Save Selected Files
return OS$Flow.executeSequence(function () {
if((model.variables.i_IsSaveSelectedFilesIn)) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.invoiceFilesByIdAggr.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// Execute Action: DonwloadZIPSelectedFilesOnClick
return controller._donwloadZIPFilesOnClick$Action(OS$DataConversion.JSConversions.typeConvertRecordList(listFilterVar.value.filteredListOut, new OS$DataTypes.LongIntegerList(), function (source, target) {
target = source.invoiceFileAttr.storageIdAttr;
return target;
}), callContext).then(function () {
// Trigger Event: AfterSaveSelectedFiles
return controller.afterSaveSelectedFiles$Action(callContext);
});
} else {
// Refresh Query: InvoiceFilesById
var result = controller.invoiceFilesById$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}

});
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
_wb_DownloadFileEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "72c46974-cd4e-4a4f-a7ac-665b18fdc4ba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadFileEnd");
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
_donwloadZIPFilesOnClick$Action(i_FilesListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DonwloadZIPFilesOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DonwloadZIPFilesOnClick");
span.setAttribute("outsystems.function.key", "f884e55d-83eb-48fd-a573-1785c867e8e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DonwloadZIPFilesOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.DonwloadZIPFilesOnClick$vars"))());
vars.value.i_FilesListInLocal = i_FilesListIn.clone();
var downloadZipByStorageIdListVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadZipByStorageIdList
model.flush();
return controller.downloadZipByStorageIdList$ServerAction(vars.value.i_FilesListInLocal, callContext).then(function (value) {
downloadZipByStorageIdListVar.value = value;
}).then(function () {
// no error?
if(((downloadZipByStorageIdListVar.value.errorMsgOut === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V9e9i+E2zkmBcwWONxWkUw#Message.1387295384.1", "You\'ve successfuly donwload all invoices files"), /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadZipByStorageIdListVar.value.binaryZIPOut, (model.variables.i_InvoiceNameIn + ".zip")));
} else {
OS$FeedbackMessageService.showFeedbackMessage(downloadZipByStorageIdListVar.value.errorMsgOut, /*Error*/ 3);
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

wb_DownloadFileStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "29c6b314-28df-4ce6-85b7-eadf511feea7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadFileStart$Action, callContext);
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
span.setAttribute("outsystems.function.key", "5da177c7-3cfe-4791-ac6b-4feeca2bb679");
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

wb_DownloadFileEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "72c46974-cd4e-4a4f-a7ac-665b18fdc4ba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadFileEnd$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

donwloadZIPFilesOnClick$Action(i_FilesListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DonwloadZIPFilesOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DonwloadZIPFilesOnClick");
span.setAttribute("outsystems.function.key", "f884e55d-83eb-48fd-a573-1785c867e8e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._donwloadZIPFilesOnClick$Action, callContext, i_FilesListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get afterSaveSelectedFiles$Action() {if(!(this.hasOwnProperty("_afterSaveSelectedFiles$Action"))) {
this._afterSaveSelectedFiles$Action = function () {
return Promise.resolve();
};
}

return this._afterSaveSelectedFiles$Action;
}set afterSaveSelectedFiles$Action(value) {this._afterSaveSelectedFiles$Action = value;
}

get afterSaveAllFiles$Action() {if(!(this.hasOwnProperty("_afterSaveAllFiles$Action"))) {
this._afterSaveAllFiles$Action = function () {
return Promise.resolve();
};
}

return this._afterSaveAllFiles$Action;
}set afterSaveAllFiles$Action(value) {this._afterSaveAllFiles$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit$ActionDownloadZipByStorageIdList", [{
name: "BinaryZIP",
attrName: "binaryZIPOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.DonwloadZIPFilesOnClick$vars", [{
name: "i_FilesList",
attrName: "i_FilesListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new OS$DataTypes.LongIntegerList();
},
complexType: OS$DataTypes.LongIntegerList
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


