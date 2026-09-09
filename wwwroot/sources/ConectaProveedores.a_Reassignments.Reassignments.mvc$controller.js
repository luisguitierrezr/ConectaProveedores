import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action, notificationOpen$Action as OutSystemsUIController$notificationOpen$Action } from "./OutSystemsUI.controller.js";
import { ST_6fc999fa8f6e0055c73f2f167c4bad19Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_a_Reassignments_Reassignments_mvc_TranslationsResources from "./ConectaProveedores.a_Reassignments.Reassignments.mvc$translationsResources.js";
import ConectaProveedores_a_ReassignmentsController$default from "./ConectaProveedores.a_Reassignments.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Reassignments_Reassignments_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getReassignmentsByCreatedBy$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getReassignmentsByCreatedBy$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
auditCreateWrapper$ServerAction(sourceIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AuditCreateWrapper", function (span) {
if(span) {
span.setAttribute("code.function", "AuditCreateWrapper");
span.setAttribute("outsystems.function.key", "29ed484b-b7f1-432a-9518-6b19b3ff7cf9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Source: OS$DataConversion.ServerDataConverter.to(sourceIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/a_Reassignments/Reassignments/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
revertReassign$ServerAction(i_ReassignmentIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RevertReassign", function (span) {
if(span) {
span.setAttribute("code.function", "RevertReassign");
span.setAttribute("outsystems.function.key", "15881ced-2143-48ba-af20-0f6f938797d5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ReassignmentId: OS$DataConversion.ServerDataConverter.to(i_ReassignmentIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("RevertReassign", "screenservices/ConectaProveedores/a_Reassignments/Reassignments/ActionRevertReassign", "keAvJbWDGrW2Z3NP8Uj3Hw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments$ActionRevertReassign"))();
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
get getReassignmentsByCreatedBy$AggrRefresh() {if(!(this.hasOwnProperty("_getReassignmentsByCreatedBy$AggrRefresh"))) {
this._getReassignmentsByCreatedBy$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetReassignmentsByCreatedBy", "screenservices/ConectaProveedores/a_Reassignments/Reassignments/ScreenDataSetGetReassignmentsByCreatedBy", "J1EfGNt_O5rKgm_0AlNAOA", maxRecords, startIndex, function (b) {
model.variables.getReassignmentsByCreatedByAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getReassignmentsByCreatedByAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getReassignmentsByCreatedByAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetReassignmentsByCreatedBy", function (span) {
if(span) {
span.setAttribute("code.function", "GetReassignmentsByCreatedBy");
span.setAttribute("outsystems.function.key", "eea853d5-c3c4-4f7a-9e91-2307878f0b44");
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

return this._getReassignmentsByCreatedBy$AggrRefresh;
}set getReassignmentsByCreatedBy$AggrRefresh(value) {this._getReassignmentsByCreatedBy$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getReassignmentsByCreatedBy$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "37b9c1f6-a1e1-4dde-8d87-ecd711f8d47d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: AuditCreateWrapper
model.flush();
return controller.auditCreateWrapper$ServerAction(function () {
var rec = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.originAttr = ConectaProveedores_staticEntities_origin.screenAccess;
rec.identifierAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.messageAttr = "";
rec.screenAttr = "Reassignments";
rec.functionalityAttr = "View";
rec.occurrenceRoleNameAttr = ConectaProveedoresClientVariables.getApplicationRole();
return rec;
}(), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_openSidebar$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenSidebar", function (span) {
if(span) {
span.setAttribute("code.function", "OpenSidebar");
span.setAttribute("outsystems.function.key", "81fff518-21c9-445c-b8aa-16551b18fee5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenSidebar");
callContext = controller.callContext(callContext);
var sidebarOpenVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarOpen
sidebarOpenVar.value = OutSystemsUIController$sidebarOpen$Action(idService.getId("NewReassignSidebar"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_ReassignmentFormConfirm$Action(notificationContentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_ReassignmentFormConfirm", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ReassignmentFormConfirm");
span.setAttribute("outsystems.function.key", "b641a2ad-baae-482c-8934-53cd5f716203");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_ReassignmentFormConfirm");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments.Wb_ReassignmentFormConfirm$vars"))());
vars.value.notificationContentInLocal = notificationContentIn.clone();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("NewReassignSidebar"), callContext);

// NotifContent = NotificationContent
model.variables.notifContentVar = vars.value.notificationContentInLocal;
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("Notif"), callContext);

// Refresh Query: GetReassignmentsByCreatedBy
var result = controller.getReassignmentsByCreatedBy$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_closeSidebar$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseSidebar", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "e6f31711-ef6f-42d8-9193-223d901a515a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("NewReassignSidebar"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_newReassignSidebarOnToggle$Action(isOpenIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("NewReassignSidebarOnToggle", function (span) {
if(span) {
span.setAttribute("code.function", "NewReassignSidebarOnToggle");
span.setAttribute("outsystems.function.key", "ebe9b36f-2bf6-42c8-904e-3ac8b2312c57");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("NewReassignSidebarOnToggle");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments.NewReassignSidebarOnToggle$vars"))());
vars.value.isOpenInLocal = isOpenIn;
// l_IsSidebarOpen = IsOpen
model.variables.l_IsSidebarOpenVar = vars.value.isOpenInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_revertReassign$Action(l_ReassignmentIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RevertReassign", function (span) {
if(span) {
span.setAttribute("code.function", "RevertReassign");
span.setAttribute("outsystems.function.key", "fac33450-497f-4d59-b585-bce2178e2ae7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RevertReassign");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments.RevertReassign$vars"))());
vars.value.l_ReassignmentIdInLocal = l_ReassignmentIdIn;
var revertReassignVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: RevertReassign
model.flush();
return controller.revertReassign$ServerAction(vars.value.l_ReassignmentIdInLocal, callContext).then(function (value) {
revertReassignVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((revertReassignVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ezrPu5rnGk29LK79EWtp6g#Message.1483110403.1", "Reassignment revoked!"), /*Success*/ 1);
// Refresh Query: GetReassignmentsByCreatedBy
var result = controller.getReassignmentsByCreatedBy$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(revertReassignVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "37b9c1f6-a1e1-4dde-8d87-ecd711f8d47d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

openSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenSidebar");
span.setAttribute("outsystems.function.key", "81fff518-21c9-445c-b8aa-16551b18fee5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openSidebar$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_ReassignmentFormConfirm$Action(notificationContentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_ReassignmentFormConfirm__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ReassignmentFormConfirm");
span.setAttribute("outsystems.function.key", "b641a2ad-baae-482c-8934-53cd5f716203");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_ReassignmentFormConfirm$Action, callContext, notificationContentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

closeSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "e6f31711-ef6f-42d8-9193-223d901a515a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeSidebar$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

newReassignSidebarOnToggle$Action(isOpenIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("NewReassignSidebarOnToggle__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "NewReassignSidebarOnToggle");
span.setAttribute("outsystems.function.key", "ebe9b36f-2bf6-42c8-904e-3ac8b2312c57");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._newReassignSidebarOnToggle$Action, callContext, isOpenIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

revertReassign$Action(l_ReassignmentIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RevertReassign__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RevertReassign");
span.setAttribute("outsystems.function.key", "fac33450-497f-4d59-b585-bce2178e2ae7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._revertReassign$Action, callContext, l_ReassignmentIdIn);
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
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
return ConectaProveedores_a_ReassignmentsController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ConectaProveedores]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments$ActionRevertReassign", [{
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
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments.Wb_ReassignmentFormConfirm$vars", [{
name: "NotificationContent",
attrName: "notificationContentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
},
complexType: ST_6fc999fa8f6e0055c73f2f167c4bad19Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments.NewReassignSidebarOnToggle$vars", [{
name: "IsOpen",
attrName: "isOpenInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Reassignments.RevertReassign$vars", [{
name: "l_ReassignmentId",
attrName: "l_ReassignmentIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


