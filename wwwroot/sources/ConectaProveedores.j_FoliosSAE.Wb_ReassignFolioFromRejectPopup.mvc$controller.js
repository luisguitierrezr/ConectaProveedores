import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.mvc$translationsResources.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import { SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType } from "./ConectaProveedores.staticEntities.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getApprovalProcessTypes$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getApprovalProcessTypes$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
folioReassignFromReject$ServerAction(i_FolioIdIn, i_AssignUserIdIn, i_AssignApprovalProcessIdIn, i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioReassignFromReject", function (span) {
if(span) {
span.setAttribute("code.function", "FolioReassignFromReject");
span.setAttribute("outsystems.function.key", "41d98836-dd6b-489a-a814-7c7b04a78163");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_AssignUserId: OS$DataConversion.ServerDataConverter.to(i_AssignUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_AssignApprovalProcessId: OS$DataConversion.ServerDataConverter.to(i_AssignApprovalProcessIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioReassignFromReject", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolioFromRejectPopup/ActionFolioReassignFromReject", "IadkMh6CoRt6YkDweLS+Yg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup$ActionFolioReassignFromReject"))();
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
get getApprovalProcessTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalProcessTypes$AggrRefresh"))) {
this._getApprovalProcessTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalProcessTypes", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolioFromRejectPopup/ScreenDataSetGetApprovalProcessTypes", "WHEf6WnBa2d2sGKbjgyTUw", maxRecords, startIndex, function (b) {
model.variables.getApprovalProcessTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalProcessTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalProcessTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalProcessTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalProcessTypes");
span.setAttribute("outsystems.function.key", "41f20525-5dce-467d-b8dc-5517a5a55a8b");
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

return this._getApprovalProcessTypes$AggrRefresh;
}set getApprovalProcessTypes$AggrRefresh(value) {this._getApprovalProcessTypes$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getApprovalProcessTypes$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_reassignOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ReassignOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ReassignOnClick");
span.setAttribute("outsystems.function.key", "881472db-c515-4199-9969-9c10365de3b3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ReassignOnClick");
callContext = controller.callContext(callContext);
var folioReassignFromRejectVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("Form")).validAttr)) {
return OS$Flow.executeSequence(function () {
if(((((model.variables.l_ActiveTabVar === 0) && (model.variables.l_SelectedUserVar === OS$BuiltinFunctions.nullTextIdentifier())) || (((model.variables.l_ActiveTabVar === 1) && model.variables.l_SelectedApprovalProcessVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.l_ApprovalProcessTypeSelectedVar) !== (ConectaProveedores_staticEntities_approvalProcessType.alternative)))))) {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage((((model.variables.l_ActiveTabVar === 0)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_4MjsfmLtEWkJ_uRDgI0lQ#Message.-1978855793.1", "You need to select a user!")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_4MjsfmLtEWkJ_uRDgI0lQ#Message.-1183347557.1", "You need to select a workflow!"))), /*Error*/ 3);
} else {
// Execute Action: FolioReassignFromReject
model.flush();
return controller.folioReassignFromReject$ServerAction(model.variables.i_FolioIdIn, (((model.variables.l_ActiveTabVar === 0)) ? (model.variables.l_SelectedUserVar) : (OS$BuiltinFunctions.nullTextIdentifier())), OS$BuiltinFunctions.integerToLongInteger((((model.variables.l_ActiveTabVar === 1)) ? ((((model.variables.l_ApprovalProcessTypeSelectedVar === ConectaProveedores_staticEntities_approvalProcessType.alternative)) ? (OS$BuiltinFunctions.nullIdentifier()) : (OS$BuiltinFunctions.longIntegerToInteger(model.variables.l_SelectedApprovalProcessVar)))) : (OS$BuiltinFunctions.nullIdentifier()))), model.variables.l_MotiveVar, callContext).then(function (value) {
folioReassignFromRejectVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((folioReassignFromRejectVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NbUoMvMT602DYktOidYvrw#Message.-384804993.1", "Folio was reassigned."), /*Success*/ 1);
// Trigger Event: Close
return controller.close$Action(true, callContext);
} else {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(folioReassignFromRejectVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
});
}

});
} else {
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_wb_SearchApprovalProcessDropdownRefresh$Action(approvalProcessIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchApprovalProcessDropdownRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchApprovalProcessDropdownRefresh");
span.setAttribute("outsystems.function.key", "a74109dd-94ab-405d-a040-1870cdd7662b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SearchApprovalProcessDropdownRefresh");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.Wb_SearchApprovalProcessDropdownRefresh$vars"))());
vars.value.approvalProcessIdInLocal = approvalProcessIdIn;
// l_SelectedApprovalProcess = ApprovalProcessId
model.variables.l_SelectedApprovalProcessVar = vars.value.approvalProcessIdInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_SearchUserDropdownRefresh$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchUserDropdownRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserDropdownRefresh");
span.setAttribute("outsystems.function.key", "c49f021d-344e-4fa6-b90d-ac6f933f35f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SearchUserDropdownRefresh");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.Wb_SearchUserDropdownRefresh$vars"))());
vars.value.userIdInLocal = userIdIn;
// l_SelectedUser = UserId
model.variables.l_SelectedUserVar = vars.value.userIdInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_ApprovalProcessTypeSelectedOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_ApprovalProcessTypeSelectedOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ApprovalProcessTypeSelectedOnChange");
span.setAttribute("outsystems.function.key", "de181443-0e43-49b2-8596-b4da27509cf2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_ApprovalProcessTypeSelectedOnChange");
callContext = controller.callContext(callContext);
// l_SelectedApprovalProcess = NullIdentifier
model.variables.l_SelectedApprovalProcessVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "f314fcc1-b755-471a-854e-716454c04eef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
// l_ActiveTab = ActiveTab
model.variables.l_ActiveTabVar = vars.value.activeTabInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

reassignOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ReassignOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ReassignOnClick");
span.setAttribute("outsystems.function.key", "881472db-c515-4199-9969-9c10365de3b3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._reassignOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SearchApprovalProcessDropdownRefresh$Action(approvalProcessIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchApprovalProcessDropdownRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchApprovalProcessDropdownRefresh");
span.setAttribute("outsystems.function.key", "a74109dd-94ab-405d-a040-1870cdd7662b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SearchApprovalProcessDropdownRefresh$Action, callContext, approvalProcessIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_SearchUserDropdownRefresh$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchUserDropdownRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserDropdownRefresh");
span.setAttribute("outsystems.function.key", "c49f021d-344e-4fa6-b90d-ac6f933f35f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SearchUserDropdownRefresh$Action, callContext, userIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_ApprovalProcessTypeSelectedOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_ApprovalProcessTypeSelectedOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ApprovalProcessTypeSelectedOnChange");
span.setAttribute("outsystems.function.key", "de181443-0e43-49b2-8596-b4da27509cf2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_ApprovalProcessTypeSelectedOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "f314fcc1-b755-471a-854e-716454c04eef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._tabsOnTabChange$Action, callContext, activeTabIn);
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup$ActionFolioReassignFromReject", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.Wb_SearchApprovalProcessDropdownRefresh$vars", [{
name: "ApprovalProcessId",
attrName: "approvalProcessIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.Wb_SearchUserDropdownRefresh$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


