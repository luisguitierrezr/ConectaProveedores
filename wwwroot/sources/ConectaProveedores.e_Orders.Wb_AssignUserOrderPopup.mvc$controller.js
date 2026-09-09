import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup.mvc$translationsResources.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure, RC_1b6a0ce1f3825bc6a50605a3cd525b9e } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getUsersList$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getUsersList$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
assignOrderToUser$ServerAction(i_OrderIdIn, i_OrderApprovalLevelIdIn, i_UserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AssignOrderToUser", function (span) {
if(span) {
span.setAttribute("code.function", "AssignOrderToUser");
span.setAttribute("outsystems.function.key", "f34d8387-e740-42d7-82e3-97de656062a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderId: OS$DataConversion.ServerDataConverter.to(i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_OrderApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_OrderApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AssignOrderToUser", "screenservices/ConectaProveedores/e_Orders/Wb_AssignUserOrderPopup/ActionAssignOrderToUser", "nLWXcMcWtxCamYSLGwx1JA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup$ActionAssignOrderToUser"))();
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
assignBulkOrderToUser$ServerAction(i_UserIdIn, i_OrderListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AssignBulkOrderToUser", function (span) {
if(span) {
span.setAttribute("code.function", "AssignBulkOrderToUser");
span.setAttribute("outsystems.function.key", "d68692b5-2cc8-4ff7-a365-615f2c7a9ba7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_OrderList: OS$DataConversion.ServerDataConverter.to(i_OrderListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AssignBulkOrderToUser", "screenservices/ConectaProveedores/e_Orders/Wb_AssignUserOrderPopup/ActionAssignBulkOrderToUser", "ytE4Rujvzg4diTsD+OTG8Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup$ActionAssignBulkOrderToUser"))();
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
get getUsersList$DataActRefresh() {if(!(this.hasOwnProperty("_getUsersList$DataActRefresh"))) {
this._getUsersList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUsersList", "screenservices/ConectaProveedores/e_Orders/Wb_AssignUserOrderPopup/DataActionGetUsersList", "F_qrSqHhzk_sQbNRyT9zyA", function (b) {
model.variables.getUsersListDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersListDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersListDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsersList", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsersList");
span.setAttribute("outsystems.function.key", "acc372c1-8a8c-44b7-90ed-711e4fbd5776");
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

return this._getUsersList$DataActRefresh;
}set getUsersList$DataActRefresh(value) {this._getUsersList$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUsersList$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "10ca64a3-39f0-4179-a97e-e25d9a9e2a2e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetUsersList
var result = controller.getUsersList$DataActRefresh(callContext);
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
_dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "d9efb5cd-3f43-4ddf-ae40-3a12c06af55a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup.DropdownSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// l_AssignUserId = TextToIdentifier
model.variables.l_AssignUserIdVar = OS$BuiltinFunctions.textToIdentifier(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_assignOnClick$Action(i_IsAssignToMeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AssignOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "AssignOnClick");
span.setAttribute("outsystems.function.key", "f83271e0-14e6-4c8d-a613-e4fa8dfa9cfb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("AssignOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup.AssignOnClick$vars"))());
vars.value.i_IsAssignToMeInLocal = i_IsAssignToMeIn;
var assignOrderToUserVar = new OS$DataTypes.VariableHolder();
var assignBulkOrderToUserVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsExecuting = True
model.variables.l_IsExecutingVar = true;
// AssingToMe?
if((vars.value.i_IsAssignToMeInLocal)) {
// l_UserIdAssigned = GetUserId
vars.value.l_UserIdAssignedVar = OS$BuiltinFunctions.getUserId();
} else {
// l_UserIdAssigned = l_AssignUserId
vars.value.l_UserIdAssignedVar = model.variables.l_AssignUserIdVar;
}

return OS$Flow.executeSequence(function () {
if((model.variables.i_IsBulkAssignIn)) {
// Execute Action: AssignBulkOrderToUser
model.flush();
return controller.assignBulkOrderToUser$ServerAction(vars.value.l_UserIdAssignedVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.i_OrderListIn, new (OS$GenericTypeCache.getGenericList(RC_1b6a0ce1f3825bc6a50605a3cd525b9e))(), function (source, target) {
target.orderApprovaLevelIdAttr = source.orderApprovaLevelAttr.idAttr;
target.orderMainIdAttr = source.orderMainAttr.idAttr;
return target;
}), callContext).then(function (value) {
assignBulkOrderToUserVar.value = value;
}).then(function () {
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
// Success?
return OS$Flow.executeSequence(function () {
if((assignBulkOrderToUserVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Z1oKaByO70mUvsozPm33PA#Message.1706893657.1", "Assignation done to multiple orders with success."), /*Success*/ 1);
// Trigger Event: Close3
return controller.close$Action(true, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(assignBulkOrderToUserVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Trigger Event: Close2
return controller.close$Action(true, callContext);
}

});
});
} else {
// Execute Action: AssignOrderToUser
model.flush();
return controller.assignOrderToUser$ServerAction(model.variables.i_OrderListIn.getCurrent(callContext.iterationContext).orderMainAttr.idAttr, model.variables.i_OrderListIn.getCurrent(callContext.iterationContext).orderApprovaLevelAttr.idAttr, vars.value.l_UserIdAssignedVar, callContext).then(function (value) {
assignOrderToUserVar.value = value;
}).then(function () {
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
// Success?
return OS$Flow.executeSequence(function () {
if((assignOrderToUserVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FwNQovLgKkafnpUpPYYqaw#Message.444420513.1", "Assignation done with success."), /*Success*/ 1);
// Trigger Event: Close
return controller.close$Action(true, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(assignOrderToUserVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "10ca64a3-39f0-4179-a97e-e25d9a9e2a2e");
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

dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "d9efb5cd-3f43-4ddf-ae40-3a12c06af55a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

assignOnClick$Action(i_IsAssignToMeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AssignOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AssignOnClick");
span.setAttribute("outsystems.function.key", "f83271e0-14e6-4c8d-a613-e4fa8dfa9cfb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._assignOnClick$Action, callContext, i_IsAssignToMeIn);
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup$ActionAssignOrderToUser", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup$ActionAssignBulkOrderToUser", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup.DropdownSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_AssignUserOrderPopup.AssignOnClick$vars", [{
name: "i_IsAssignToMe",
attrName: "i_IsAssignToMeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "l_UserIdAssigned",
attrName: "l_UserIdAssignedVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


