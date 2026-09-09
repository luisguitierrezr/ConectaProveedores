import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, GenericTypeCache as OS$GenericTypeCache, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { RC_829c5fdbd08f778c26d3a6457b4b0808, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_Orders_Wb_PopupOrderBulkApprove_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_PopupOrderBulkApprove.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_PopupOrderBulkApprove_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
ordersApproveBulk$ServerAction(i_OrderListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OrdersApproveBulk", function (span) {
if(span) {
span.setAttribute("code.function", "OrdersApproveBulk");
span.setAttribute("outsystems.function.key", "2f8f4638-fde5-4616-b117-5a4785f84b71");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderList: OS$DataConversion.ServerDataConverter.to(i_OrderListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("OrdersApproveBulk", "screenservices/ConectaProveedores/e_Orders/Wb_PopupOrderBulkApprove/ActionOrdersApproveBulk", "ILRozuZizi+LVPLeFnKqww", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_PopupOrderBulkApprove$ActionOrdersApproveBulk"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
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
_approveOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveOnClick");
span.setAttribute("outsystems.function.key", "c38ee97d-1b43-41c8-b85c-779796b68360");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveOnClick");
callContext = controller.callContext(callContext);
var ordersApproveBulkVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsExecuting = True
model.variables.l_IsExecutingVar = true;
// Execute Action: OrdersApproveBulk
model.flush();
return controller.ordersApproveBulk$ServerAction(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.l_OrderApprovalLevelListIn, new (OS$GenericTypeCache.getGenericList(RC_829c5fdbd08f778c26d3a6457b4b0808))(), function (source, target) {
target.orderApprovalLevelIdAttr = source.orderApprovalLevelIdAttr;
target.orderIdAttr = source.orderAttr.idAttr;
return target;
}), callContext).then(function (value) {
ordersApproveBulkVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((ordersApproveBulkVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Close
return controller.close$Action(true, callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mybwkzO_mkycmPz6RgHGTw#Message.-970174080.1", "Orders have been approved."), /*Success*/ 1);
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
});
} else {
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Close2
return controller.close$Action(false, callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(ordersApproveBulkVar.value.o_OutputOut.messageAttr, /*Warning*/ 2);
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

approveOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveOnClick");
span.setAttribute("outsystems.function.key", "c38ee97d-1b43-41c8-b85c-779796b68360");
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_PopupOrderBulkApprove$ActionOrdersApproveBulk", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


