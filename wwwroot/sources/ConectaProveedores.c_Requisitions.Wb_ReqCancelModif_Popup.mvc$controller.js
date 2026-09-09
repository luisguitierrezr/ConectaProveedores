import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_ReqCancelModif_Popup.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approvModifReq$ServerAction(i_RequisitionIdIn, i_RequisitionApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovModifReq", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovModifReq");
span.setAttribute("outsystems.function.key", "d9c5608c-7e94-4e74-aa02-418c0dbd29bb");
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
}),
i_RequisitionApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_RequisitionApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
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
return controller.callServerAction("ApprovModifReq", "screenservices/ConectaProveedores/c_Requisitions/Wb_ReqCancelModif_Popup/ActionApprovModifReq", "edod8NCxISGEGK70q5rSdA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_ReqCancelModif_Popup$ActionApprovModifReq"))();
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
requisitionCancel$ServerAction(i_RequisitionIdIn, i_RequisitionApprovalLevelIdIn, i_CancelReasonIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RequisitionCancel", function (span) {
if(span) {
span.setAttribute("code.function", "RequisitionCancel");
span.setAttribute("outsystems.function.key", "01f1538f-b892-4923-9da1-2d68a8666f63");
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
}),
i_RequisitionApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_RequisitionApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_CancelReason: OS$DataConversion.ServerDataConverter.to(i_CancelReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("RequisitionCancel", "screenservices/ConectaProveedores/c_Requisitions/Wb_ReqCancelModif_Popup/ActionRequisitionCancel", "t_Cz8TUtEbxHcmD_3NS1BQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_ReqCancelModif_Popup$ActionRequisitionCancel"))();
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
_confirmOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ConfirmOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "787ef0f6-c5bb-40bf-878f-9f0f7b216f67");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ConfirmOnClick");
callContext = controller.callContext(callContext);
var approvModifReqVar = new OS$DataTypes.VariableHolder();
var requisitionCancelVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsExecuting = True
model.variables.isExecutingVar = true;
// TextArea_l_Reason.Valid = True
model.widgets.get(idService.getId("TextArea_l_Reason")).validAttr = true;
// TextArea_l_Reason.ValidationMessage = ""
model.widgets.get(idService.getId("TextArea_l_Reason")).validationMessageAttr = "";
return OS$Flow.executeSequence(function () {
if(((OS$BuiltinFunctions.trim(model.variables.l_ReasonVar) === ""))) {
// TextArea_l_Reason.Valid = False
model.widgets.get(idService.getId("TextArea_l_Reason")).validAttr = false;
// TextArea_l_Reason.ValidationMessage = "You must state a reason to cancel this requisition."
model.widgets.get(idService.getId("TextArea_l_Reason")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qQx0ihMec0a_OkMkVAmrmQ#Value.-671703557.1", "You must state a reason to cancel this requisition.");
// IsExecuting = False
model.variables.isExecutingVar = false;
} else {
return OS$Flow.executeSequence(function () {
if((model.variables.i_IsCancelIn)) {
// Execute Action: RequisitionCancel
model.flush();
return controller.requisitionCancel$ServerAction(model.variables.i_RequisitionIdIn, model.variables.i_RequisitionApprovalLevelIdIn, model.variables.l_ReasonVar, "", callContext).then(function (value) {
requisitionCancelVar.value = value;
}).then(function () {
if((!(requisitionCancelVar.value.o_OutputOut.isSuccessAttr))) {
OS$FeedbackMessageService.showFeedbackMessage(requisitionCancelVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
return OS$Flow.returnAsync();

}

});
} else {
// Execute Action: ApprovModifReq
model.flush();
return controller.approvModifReq$ServerAction(model.variables.i_RequisitionIdIn, model.variables.i_RequisitionApprovalLevelIdIn, false, model.variables.l_ReasonVar, ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
approvModifReqVar.value = value;
}).then(function () {
if((!(approvModifReqVar.value.o_OutputOut.isSuccessAttr))) {
OS$FeedbackMessageService.showFeedbackMessage(approvModifReqVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
return OS$Flow.returnAsync();

}

});
}

}).then(function () {
// Trigger Event: Action
return controller.action$Action(callContext).then(function () {
// Success Message
OS$FeedbackMessageService.showFeedbackMessage(((model.variables.i_IsCancelIn) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1yK2dLc2rkWvLu0LefKwdw#Message.-1406923915.1", "Requisition canceled with success!")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1yK2dLc2rkWvLu0LefKwdw#Message.-218215899.1", "Modification request sent with success!"))), /*Success*/ 1);
// IsExecuting = False
model.variables.isExecutingVar = false;
});
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "858ec426-ed23-467a-bdda-b0ff4ecf03f8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// l_Reason = ""
model.variables.l_ReasonVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

confirmOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ConfirmOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "787ef0f6-c5bb-40bf-878f-9f0f7b216f67");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._confirmOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "858ec426-ed23-467a-bdda-b0ff4ecf03f8");
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

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
}

get action$Action() {if(!(this.hasOwnProperty("_action$Action"))) {
this._action$Action = function () {
return Promise.resolve();
};
}

return this._action$Action;
}set action$Action(value) {this._action$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_ReqCancelModif_Popup$ActionApprovModifReq", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_ReqCancelModif_Popup$ActionRequisitionCancel", [{
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


