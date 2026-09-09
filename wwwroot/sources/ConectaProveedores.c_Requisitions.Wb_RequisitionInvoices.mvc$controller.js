import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoicesByRequisitionId$AggrRefresh: -1,
getRequisitionData$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoicesByRequisitionId$AggrRefresh: [],
getRequisitionData$DataActRefresh: []
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
return controller.callServerAction("DownloadInvoiceFiles", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionInvoices/ActionDownloadInvoiceFiles", "q4fidEzmLEnK5H0av1aFqw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices$ActionDownloadInvoiceFiles"))();
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
getCanUploadInvoicesByRequisitionId$ServerAction(i_RequisitionIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetCanUploadInvoicesByRequisitionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetCanUploadInvoicesByRequisitionId");
span.setAttribute("outsystems.function.key", "2779b5ba-f797-4092-8712-795a450b0759");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetCanUploadInvoicesByRequisitionId", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionInvoices/ActionGetCanUploadInvoicesByRequisitionId", "8VYjevsePtVrdv0jNlr2Zw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices$ActionGetCanUploadInvoicesByRequisitionId"))();
executeServerActionResult.i_CanUploadOut = OS$DataConversion.ServerDataConverter.from(outputs.i_CanUpload, OS$DataTypes.DataTypes.Boolean);
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
get getInvoicesByRequisitionId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesByRequisitionId$AggrRefresh"))) {
this._getInvoicesByRequisitionId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesByRequisitionId", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionInvoices/ScreenDataSetGetInvoicesByRequisitionId", "W2jD2o2pW_REN+W8+0p1dQ", maxRecords, startIndex, function (b) {
model.variables.getInvoicesByRequisitionIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesByRequisitionIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesByRequisitionIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesByRequisitionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByRequisitionId");
span.setAttribute("outsystems.function.key", "29c147ec-611a-491e-b3fc-1d28ca33f086");
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

return this._getInvoicesByRequisitionId$AggrRefresh;
}set getInvoicesByRequisitionId$AggrRefresh(value) {this._getInvoicesByRequisitionId$AggrRefresh = value;
}

get getRequisitionData$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitionData$DataActRefresh"))) {
this._getRequisitionData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitionData", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionInvoices/DataActionGetRequisitionData", "S5ocBl5hzIkAvHA6ft2QQA", function (b) {
model.variables.getRequisitionDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionData", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionData");
span.setAttribute("outsystems.function.key", "c03bfa88-06a6-4109-a440-f847a6975a00");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
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

return this._getRequisitionData$DataActRefresh;
}set getRequisitionData$DataActRefresh(value) {this._getRequisitionData$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoicesByRequisitionId$AggrRefresh", "getRequisitionData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_togglePopupMultiUploadInvoices$Action(needsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupMultiUploadInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupMultiUploadInvoices");
span.setAttribute("outsystems.function.key", "052f42a9-6a1f-4732-b5e6-73b18569a062");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("TogglePopupMultiUploadInvoices");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.TogglePopupMultiUploadInvoices$vars"))());
vars.value.needsRefreshInLocal = needsRefreshIn;
return OS$Flow.executeAsyncFlow(function () {
// l_IsOpenPopupMultiupload = notl_IsOpenPopupMultiupload
model.variables.l_IsOpenPopupMultiuploadVar = (!(model.variables.l_IsOpenPopupMultiuploadVar));
return OS$Flow.executeSequence(function () {
if((vars.value.needsRefreshInLocal)) {
// Refresh Query: GetRequisitionData
var result = controller.getRequisitionData$DataActRefresh(callContext);
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
_onClickDownload$Action(invoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickDownload", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickDownload");
span.setAttribute("outsystems.function.key", "25a6ab2e-8854-4564-bfe0-10528f9a2ba8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickDownload");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.OnClickDownload$vars"))());
vars.value.invoiceIdInLocal = invoiceIdIn;
var downloadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadInvoiceFiles
model.flush();
return controller.downloadInvoiceFiles$ServerAction(vars.value.invoiceIdInLocal, callContext).then(function (value) {
downloadInvoiceFilesVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadInvoiceFilesVar.value.binaryZIPOut, (((model.variables.getInvoicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip")));
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
_togglePopupUploadInvoices$Action(needsRefreshIn, invoiceIdIn, invoiceStatusIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupUploadInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupUploadInvoices");
span.setAttribute("outsystems.function.key", "66d5951c-2e57-4457-be20-bf69c6c73ed9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("TogglePopupUploadInvoices");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.TogglePopupUploadInvoices$vars"))());
vars.value.needsRefreshInLocal = needsRefreshIn;
vars.value.invoiceIdInLocal = invoiceIdIn;
vars.value.invoiceStatusIdInLocal = invoiceStatusIdIn;
return OS$Flow.executeAsyncFlow(function () {
// l_IsOpenPopupInvoices = notl_IsOpenPopupInvoices
model.variables.l_IsOpenPopupInvoicesVar = (!(model.variables.l_IsOpenPopupInvoicesVar));
// l_InvoiceIdToPopup = InvoiceId
model.variables.l_InvoiceIdToPopupVar = vars.value.invoiceIdInLocal;
// l_InvoiceStatusIdToPopup = InvoiceStatusId
model.variables.l_InvoiceStatusIdToPopupVar = vars.value.invoiceStatusIdInLocal;
return OS$Flow.executeSequence(function () {
if((vars.value.needsRefreshInLocal)) {
// Refresh Query: GetRequisitionData
var result = controller.getRequisitionData$DataActRefresh(callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7536a83e-c3eb-4682-b6ed-c343ac0fdda5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((true)) {
// Refresh Query: GetRequisitionData
var result = controller.getRequisitionData$DataActRefresh(callContext);
model.flush();
return result;
} else {
// Refresh Query: GetInvoicesByRequisitionId
var result = controller.getInvoicesByRequisitionId$AggrRefresh(9999, 0, callContext);
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
_getRequisitionDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "af0a48ab-9dcb-46f1-a8f6-3016f77dc859");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRequisitionDataOnAfterFetch");
callContext = controller.callContext(callContext);
var getCanUploadInvoicesByRequisitionIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetCanUploadInvoicesByRequisitionId
model.flush();
return controller.getCanUploadInvoicesByRequisitionId$ServerAction(model.variables.i_RequisitionIdIn, callContext).then(function (value) {
getCanUploadInvoicesByRequisitionIdVar.value = value;
}).then(function () {
// l_CanUploadInvoice = CheckProveedorRole() or GetCanUploadInvoicesByRequisitionId.i_CanUpload
model.variables.l_CanUploadInvoiceVar = (ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut || getCanUploadInvoicesByRequisitionIdVar.value.i_CanUploadOut);
// Refresh Query: GetInvoicesByRequisitionId
var result = controller.getInvoicesByRequisitionId$AggrRefresh(9999, 0, callContext);
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

togglePopupMultiUploadInvoices$Action(needsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupMultiUploadInvoices__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupMultiUploadInvoices");
span.setAttribute("outsystems.function.key", "052f42a9-6a1f-4732-b5e6-73b18569a062");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._togglePopupMultiUploadInvoices$Action, callContext, needsRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onClickDownload$Action(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickDownload");
span.setAttribute("outsystems.function.key", "25a6ab2e-8854-4564-bfe0-10528f9a2ba8");
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

togglePopupUploadInvoices$Action(needsRefreshIn, invoiceIdIn, invoiceStatusIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupUploadInvoices__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupUploadInvoices");
span.setAttribute("outsystems.function.key", "66d5951c-2e57-4457-be20-bf69c6c73ed9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._togglePopupUploadInvoices$Action, callContext, needsRefreshIn, invoiceIdIn, invoiceStatusIdIn);
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
span.setAttribute("outsystems.function.key", "7536a83e-c3eb-4682-b6ed-c343ac0fdda5");
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

getRequisitionDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "af0a48ab-9dcb-46f1-a8f6-3016f77dc859");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRequisitionDataOnAfterFetch$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices$ActionDownloadInvoiceFiles", [{
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices$ActionGetCanUploadInvoicesByRequisitionId", [{
name: "i_CanUpload",
attrName: "i_CanUploadOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.TogglePopupMultiUploadInvoices$vars", [{
name: "NeedsRefresh",
attrName: "needsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.OnClickDownload$vars", [{
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.TogglePopupUploadInvoices$vars", [{
name: "NeedsRefresh",
attrName: "needsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "InvoiceStatusId",
attrName: "invoiceStatusIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


