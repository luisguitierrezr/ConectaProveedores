import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoicesByFolioId$AggrRefresh: 0,
getFolioById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoicesByFolioId$AggrRefresh: [],
getFolioById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
downloadInvoiceFiles$ServerAction(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadInvoiceFiles");
span.setAttribute("outsystems.function.key", "a7ddfd23-59f0-4a80-8ec4-33c9d74b80ff");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadInvoiceFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FoliosContabilizationInvoiceSAPStatus/ActionDownloadInvoiceFiles", "q4fidEzmLEnK5H0av1aFqw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus$ActionDownloadInvoiceFiles"))();
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
invoiceAccountingProcess_Create$ServerAction(invoiceIdIn, commentIn, isFCPIn, requisitionIdIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceAccountingProcess_Create", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceAccountingProcess_Create");
span.setAttribute("outsystems.function.key", "e40b2c67-8df6-4197-a514-5ac09e368352");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
Comment: OS$DataConversion.ServerDataConverter.to(commentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IsFCP: OS$DataConversion.ServerDataConverter.to(isFCPIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
RequisitionId: OS$DataConversion.ServerDataConverter.to(requisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("InvoiceAccountingProcess_Create", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FoliosContabilizationInvoiceSAPStatus/ActionInvoiceAccountingProcess_Create", "7ta6duQcTOb1HdUse50VXA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getInvoicesByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesByFolioId$AggrRefresh"))) {
this._getInvoicesByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FoliosContabilizationInvoiceSAPStatus/ScreenDataSetGetInvoicesByFolioId", "eNk_TWhNfKE6FMEbOmT6FA", maxRecords, startIndex, function (b) {
model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getInvoicesByFolioIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByFolioId");
span.setAttribute("outsystems.function.key", "53536129-4cc5-477d-a2f7-433e8dc688fe");
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

return this._getInvoicesByFolioId$AggrRefresh;
}set getInvoicesByFolioId$AggrRefresh(value) {this._getInvoicesByFolioId$AggrRefresh = value;
}

get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FoliosContabilizationInvoiceSAPStatus/ScreenDataSetGetFolioById", "7ueKcXlIr0yPrYZxMFEBDg", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "9d8621b6-e270-4b43-b396-a67023bb3c27");
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

return this._getFolioById$AggrRefresh;
}set getFolioById$AggrRefresh(value) {this._getFolioById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoicesByFolioId$AggrRefresh", "getFolioById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onClickDownload$Action(invoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickDownload", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickDownload");
span.setAttribute("outsystems.function.key", "5f9e5c1b-3b72-4dd3-84c3-4597ab8d5111");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickDownload");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.OnClickDownload$vars"))());
vars.value.invoiceIdInLocal = invoiceIdIn;
var downloadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadInvoiceFiles
model.flush();
return controller.downloadInvoiceFiles$ServerAction(vars.value.invoiceIdInLocal, callContext).then(function (value) {
downloadInvoiceFilesVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadInvoiceFilesVar.value.binaryZIPOut, (((model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip")));
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
_retryOnClick$Action(invoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RetryOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RetryOnClick");
span.setAttribute("outsystems.function.key", "76cb0302-b06b-468f-8417-55f6968c4661");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RetryOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.RetryOnClick$vars"))());
vars.value.invoiceIdInLocal = invoiceIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: InvoiceAccountingProcess_Create
model.flush();
return controller.invoiceAccountingProcess_Create$ServerAction(vars.value.invoiceIdInLocal, "", true, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function () {
// Refresh Query: GetInvoicesByFolioId
var result = controller.getInvoicesByFolioId$AggrRefresh(9999, 0, callContext);
model.flush();
return result;
}).then(function () {
// l_IsInvoiceRetryAccountingRefresh = True
model.variables.l_IsInvoiceRetryAccountingRefreshVar = true;
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("a+UGq0ltYEqNwV9uNDTibQ#Message.-984304323.1", "Your invoice has been sent for contabilization"), /*Info*/ 0);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Close
return controller.close$Action(true, callContext);
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
_getInvoicesByFolioIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesByFolioIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "8c472b0e-f8d5-46b0-93d9-b46b89820867");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetInvoicesByFolioIdOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesByFolioIdAggr.listOut, function (p) {
return ((p.invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.canceled));
}, callContext);

// l_CanUploadInvoice = ListFilter.FilteredList.Empty
model.variables.l_CanUploadInvoiceVar = listFilterVar.value.filteredListOut.isEmpty;
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
span.setAttribute("outsystems.function.key", "d7b27078-d32a-4ee8-856d-c28c9b0da3f5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoicesByFolioId
var result = controller.getInvoicesByFolioId$AggrRefresh(9999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetFolioById
var result = controller.getFolioById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
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

onClickDownload$Action(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickDownload");
span.setAttribute("outsystems.function.key", "5f9e5c1b-3b72-4dd3-84c3-4597ab8d5111");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickDownload$Action, callContext, invoiceIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

retryOnClick$Action(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RetryOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RetryOnClick");
span.setAttribute("outsystems.function.key", "76cb0302-b06b-468f-8417-55f6968c4661");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._retryOnClick$Action, callContext, invoiceIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getInvoicesByFolioIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesByFolioIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "8c472b0e-f8d5-46b0-93d9-b46b89820867");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getInvoicesByFolioIdOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "d7b27078-d32a-4ee8-856d-c28c9b0da3f5");
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

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus$ActionDownloadInvoiceFiles", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.OnClickDownload$vars", [{
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.RetryOnClick$vars", [{
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


