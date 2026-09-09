import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { RC_3797d4971af6bc97d739ac602330acb1, ST_046fb53ebbe142526d95e87ef1ae9711Structure, ST_6ac87b97c676cd17082ba2063283d4baStructure, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkApprove_mvc_TranslationsResources from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkApprove.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceBulkApprove_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
invoiceApproveBulk$ServerAction(i_InvoiceListIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceApproveBulk", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceApproveBulk");
span.setAttribute("outsystems.function.key", "8a0af485-da74-464d-a6a5-505819453c49");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_InvoiceList: OS$DataConversion.ServerDataConverter.to(i_InvoiceListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("InvoiceApproveBulk", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceBulkApprove/ActionInvoiceApproveBulk", "70USZP_f3NtHu5itB3Gx5w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkApprove$ActionInvoiceApproveBulk"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.notificationContentOut = OS$DataConversion.ServerDataConverter.from(outputs.NotificationContent, ST_6ac87b97c676cd17082ba2063283d4baStructure);
executeServerActionResult.notificationErrorOut = OS$DataConversion.ServerDataConverter.from(outputs.NotificationError, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure);
executeServerActionResult.isFinishOut = OS$DataConversion.ServerDataConverter.from(outputs.IsFinish, OS$DataTypes.DataTypes.Boolean);
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
span.setAttribute("outsystems.function.key", "53ae3da5-f889-42b6-9be3-2e4dbc4d4b7a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// l_Comment = ""
model.variables.l_CommentVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_approveOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveOnClick");
span.setAttribute("outsystems.function.key", "69b885de-ef7d-483c-ad75-1af60926a80c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveOnClick");
callContext = controller.callContext(callContext);
var invoiceApproveBulkVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsExecuting = True
model.variables.l_IsExecutingVar = true;
// Execute Action: InvoiceApproveBulk
model.flush();
return controller.invoiceApproveBulk$ServerAction(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.l_InvoiceApprovalLevelListIn, new (OS$GenericTypeCache.getGenericList(RC_3797d4971af6bc97d739ac602330acb1))(), function (source, target) {
target.invoiceApprovalLevelIdAttr = source.invoiceApprovalLevelAttr.idAttr;
target.invoiceIdAttr = source.invoiceIdAttr.idAttr;
target.invoiceNumberAttr = source.invoiceIdAttr.nameAttr;
return target;
}), model.variables.l_CommentVar, ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
invoiceApproveBulkVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((invoiceApproveBulkVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Close
return controller.close$Action(true, invoiceApproveBulkVar.value.notificationContentOut, invoiceApproveBulkVar.value.notificationErrorOut, callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(((invoiceApproveBulkVar.value.isFinishOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("H+ciwu7lukSW7IlhzESRIQ#Message.753435078.1", "Invoices have been sent to accounting.")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("H+ciwu7lukSW7IlhzESRIQ#Message.1359052545.1", "Invoices have been approved."))), /*Success*/ 1);
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
});
} else {
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Close2
return controller.close$Action(true, invoiceApproveBulkVar.value.notificationContentOut, invoiceApproveBulkVar.value.notificationErrorOut, callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(invoiceApproveBulkVar.value.o_OutputOut.messageAttr, /*Warning*/ 2);
});
}

});
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
span.setAttribute("outsystems.function.key", "53ae3da5-f889-42b6-9be3-2e4dbc4d4b7a");
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

approveOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveOnClick");
span.setAttribute("outsystems.function.key", "69b885de-ef7d-483c-ad75-1af60926a80c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approveOnClick$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceBulkApprove$ActionInvoiceApproveBulk", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "NotificationContent",
attrName: "notificationContentOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6ac87b97c676cd17082ba2063283d4baStructure();
},
complexType: ST_6ac87b97c676cd17082ba2063283d4baStructure
}, {
name: "NotificationError",
attrName: "notificationErrorOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
},
complexType: ST_bb4ffb4d3263f72e713312025a0e6fc7Structure
}, {
name: "IsFinish",
attrName: "isFinishOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


