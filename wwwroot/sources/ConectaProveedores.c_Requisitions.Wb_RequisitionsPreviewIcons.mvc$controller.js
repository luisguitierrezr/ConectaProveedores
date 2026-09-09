import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
requisitionFilesById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
requisitionFilesById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
getRequisitionFiles$ServerAction(requisitionIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionFiles");
span.setAttribute("outsystems.function.key", "d60f7a09-43de-429d-9f77-63baeecb87bb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
RequisitionId: OS$DataConversion.ServerDataConverter.to(requisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetRequisitionFiles", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsPreviewIcons/ActionGetRequisitionFiles", "uIKXJU1zGFJnswURU5zOTA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons$ActionGetRequisitionFiles"))();
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
checkFiles$ServerAction(requisitionIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckFiles", function (span) {
if(span) {
span.setAttribute("code.function", "CheckFiles");
span.setAttribute("outsystems.function.key", "e4bc166a-393a-4f90-9a4b-99c08242efaa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
RequisitionId: OS$DataConversion.ServerDataConverter.to(requisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("CheckFiles", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsPreviewIcons/ActionCheckFiles", "7NkPYBX1SWRoow8xeWADmw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons$ActionCheckFiles"))();
executeServerActionResult.o_ErrorMessageOut = OS$DataConversion.ServerDataConverter.from(outputs.O_ErrorMessage, OS$DataTypes.DataTypes.Text);
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
get requisitionFilesById$AggrRefresh() {if(!(this.hasOwnProperty("_requisitionFilesById$AggrRefresh"))) {
this._requisitionFilesById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetRequisitionFilesById", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsPreviewIcons/ScreenDataSetRequisitionFilesById", "53h1wwY_frmIXfERFQzpoA", maxRecords, startIndex, function (b) {
model.variables.requisitionFilesByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.requisitionFilesByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.requisitionFilesByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("RequisitionFilesById", function (span) {
if(span) {
span.setAttribute("code.function", "RequisitionFilesById");
span.setAttribute("outsystems.function.key", "22ce3350-cf61-4eca-b6d7-97a56d554a89");
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

return this._requisitionFilesById$AggrRefresh;
}set requisitionFilesById$AggrRefresh(value) {this._requisitionFilesById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["requisitionFilesById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_donwloadZIPFileOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DonwloadZIPFileOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DonwloadZIPFileOnClick");
span.setAttribute("outsystems.function.key", "01a7033e-2ab6-4638-9b24-47cffcd9d126");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DonwloadZIPFileOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var getRequisitionFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: GetRequisitionFiles
model.flush();
return controller.getRequisitionFiles$ServerAction(model.variables.requisitionIdIn, callContext).then(function (value) {
getRequisitionFilesVar.value = value;
}).then(function () {
// error?
if((((getRequisitionFilesVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1fqDaMYNWkWRdxCzCVHknQ#Message.-46618447.1", "This requisition has no files to download"), /*Error*/ 3);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8V3plCr56kK3QyeqonxIbw#Message.691963083.1", "You\'ve successfuly donwload the requisition file"), /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(getRequisitionFilesVar.value.binaryZIPOut, (((model.variables.requisitionNameIn + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip")));
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_RequisitionsPreviewIcons.DonwloadZIPFileOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "467c8707-c897-4dfa-a0e0-7b1bdb0ef019");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
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
_onClickOpenPreview$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickOpenPreview", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenPreview");
span.setAttribute("outsystems.function.key", "4e151835-403c-4b2e-a9c8-f08ca5f757fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickOpenPreview");
callContext = controller.callContext(callContext);
var checkFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: CheckFiles
model.flush();
return controller.checkFiles$ServerAction(model.variables.requisitionIdIn, callContext).then(function (value) {
checkFilesVar.value = value;
}).then(function () {
if(((checkFilesVar.value.o_ErrorMessageOut === ""))) {
// l_PreviewFilesToggler = notl_PreviewFilesToggler
model.variables.l_PreviewFilesTogglerVar = (!(model.variables.l_PreviewFilesTogglerVar));
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JCTmObJ0zkK+lcDhqw9aJA#Message.-474801527.1", "There are no documents available on this requisition."), /*Error*/ 3);
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
span.setAttribute("outsystems.function.key", "b58ecf5c-575f-43d2-824d-971f0bde4f8b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: RequisitionFilesById
var result = controller.requisitionFilesById$AggrRefresh(1, 0, callContext);
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
_closePreviewFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClosePreviewFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePreviewFiles");
span.setAttribute("outsystems.function.key", "cabc9e4c-d36a-4e9d-977e-a22a92e28068");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClosePreviewFiles");
callContext = controller.callContext(callContext);
// Close PopUp
// l_PreviewFilesToggler = notl_PreviewFilesToggler
model.variables.l_PreviewFilesTogglerVar = (!(model.variables.l_PreviewFilesTogglerVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

donwloadZIPFileOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DonwloadZIPFileOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DonwloadZIPFileOnClick");
span.setAttribute("outsystems.function.key", "01a7033e-2ab6-4638-9b24-47cffcd9d126");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._donwloadZIPFileOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onClickOpenPreview$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickOpenPreview__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenPreview");
span.setAttribute("outsystems.function.key", "4e151835-403c-4b2e-a9c8-f08ca5f757fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickOpenPreview$Action, callContext);
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
span.setAttribute("outsystems.function.key", "b58ecf5c-575f-43d2-824d-971f0bde4f8b");
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

closePreviewFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClosePreviewFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePreviewFiles");
span.setAttribute("outsystems.function.key", "cabc9e4c-d36a-4e9d-977e-a22a92e28068");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closePreviewFiles$Action, callContext);
} finally {
if(span) {
span.end();
}

}

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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons$ActionGetRequisitionFiles", [{
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons$ActionCheckFiles", [{
name: "O_ErrorMessage",
attrName: "o_ErrorMessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


