import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action, notificationOpen$Action as OutSystemsUIController$notificationOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_6fc999fa8f6e0055c73f2f167c4bad19Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_FoliosSAEforReassignment_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_FoliosSAEforReassignment_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getReassignments$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getReassignments$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
folioReassignGeneralRevoke$ServerAction(i_ReassignmentIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioReassignGeneralRevoke", function (span) {
if(span) {
span.setAttribute("code.function", "FolioReassignGeneralRevoke");
span.setAttribute("outsystems.function.key", "cd8a9fd9-3f04-4102-aaad-6e35232b86f3");
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
return controller.callServerAction("FolioReassignGeneralRevoke", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEforReassignment/ActionFolioReassignGeneralRevoke", "xdBcs+wOxMYjcmEp0zdQ3Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment$ActionFolioReassignGeneralRevoke"))();
executeServerActionResult.errorMessageOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMessage, OS$DataTypes.DataTypes.Text);
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
columnTogglerPassColumn$ServerAction(i_ColumnJSONIn, i_TableNameIn, i_UserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "68473301-c3d5-4d78-a652-7ce384c4cbd7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ColumnJSON: OS$DataConversion.ServerDataConverter.to(i_ColumnJSONIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_TableName: OS$DataConversion.ServerDataConverter.to(i_TableNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEforReassignment/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
getSettings$ServerAction(tableNameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "cf0e9209-a3bd-4677-a149-06f9ec265149");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
TableName: OS$DataConversion.ServerDataConverter.to(tableNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEforReassignment/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment$ActionGetSettings"))();
executeServerActionResult.outSettingsTextOut = OS$DataConversion.ServerDataConverter.from(outputs.OutSettingsText, OS$DataTypes.DataTypes.Text);
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
get getReassignments$AggrRefresh() {if(!(this.hasOwnProperty("_getReassignments$AggrRefresh"))) {
this._getReassignments$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetReassignments", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEforReassignment/ScreenDataSetGetReassignments", "JHS8wjN_cul0v_hTW4XMDA", maxRecords, startIndex, function (b) {
model.variables.getReassignmentsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getReassignmentsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getReassignmentsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getReassignmentsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetReassignments", function (span) {
if(span) {
span.setAttribute("code.function", "GetReassignments");
span.setAttribute("outsystems.function.key", "530f924e-d544-4904-9023-eb7fa3b8b857");
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

return this._getReassignments$AggrRefresh;
}set getReassignments$AggrRefresh(value) {this._getReassignments$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getReassignments$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_openSidebar$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenSidebar", function (span) {
if(span) {
span.setAttribute("code.function", "OpenSidebar");
span.setAttribute("outsystems.function.key", "0eeea114-8b40-4cfb-8776-1be00ab390da");
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
_revertReassign$Action(l_ReassignmentIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RevertReassign", function (span) {
if(span) {
span.setAttribute("code.function", "RevertReassign");
span.setAttribute("outsystems.function.key", "138d55c0-7fa7-414a-9773-3235be0b3216");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RevertReassign");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.RevertReassign$vars"))());
vars.value.l_ReassignmentIdInLocal = l_ReassignmentIdIn;
var revertReassignFolioVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: RevertReassignFolio
model.flush();
return controller.folioReassignGeneralRevoke$ServerAction(vars.value.l_ReassignmentIdInLocal, callContext).then(function (value) {
revertReassignFolioVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((((revertReassignFolioVar.value.errorMessageOut) !== ("")))) {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(revertReassignFolioVar.value.errorMessageOut, /*Error*/ 3);
} else {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GrGjFCNmOUSwj26SmT1UeA#Message.1483110403.1", "Reassignment revoked!"), /*Success*/ 1);
// Refresh Query: GetReassignments
var result = controller.getReassignments$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result;
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "1cad604a-f855-42a3-b9f7-ecefbc5ec8fb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("FoliosSAEforReassignment"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVar = ColumnJSON
model.variables.l_ColumnJSONVarVar = vars.value.columnJSONInLocal;
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "1e49f1e2-1d16-418b-baed-22ed1cd0ec1c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetReassignments
var result = controller.getReassignments$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_getReassignmentsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetReassignmentsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetReassignmentsOnAfterFetch");
span.setAttribute("outsystems.function.key", "32ed81d6-69e9-432d-a6ef-353e1b9e8e47");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetReassignmentsOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Count
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchVar === 0))) {
// l_CountAfterFetch = l_CountAfterFetch + 1
model.variables.l_CountAfterFetchVar = (model.variables.l_CountAfterFetchVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("FoliosSAEforReassignment"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVar = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_wb_SearchUserOriginalDropdownRefresh$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchUserOriginalDropdownRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserOriginalDropdownRefresh");
span.setAttribute("outsystems.function.key", "38b82fbe-0497-47d1-9148-61f00368e8c7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SearchUserOriginalDropdownRefresh");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.Wb_SearchUserOriginalDropdownRefresh$vars"))());
vars.value.userIdInLocal = userIdIn;
return OS$Flow.executeAsyncFlow(function () {
// FoliosForReassignment_OriginalUserId = UserId
ConectaProveedoresClientVariables.setFoliosForReassignment_OriginalUserId(vars.value.userIdInLocal);
// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
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
span.setAttribute("outsystems.function.key", "49956027-4109-4bef-b9db-559cee01e240");
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
span.setAttribute("outsystems.function.key", "4e96bfa6-f683-44b0-810a-e732dff67c39");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("NewReassignSidebarOnToggle");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.NewReassignSidebarOnToggle$vars"))());
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "52c85164-32d4-4c42-ae20-5fd98f9e2d86");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = 0
model.variables.startIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
}

// Refresh Query: GetReassignments
var result = controller.getReassignments$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "69215177-a007-4ff3-914d-fc59713c8725");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetColumnVisiblityOnClick");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "7ee9ce8f-5fef-4782-9dd4-24c7bfb30b23");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// FoliosForReassignment_FolioNumber = ""
ConectaProveedoresClientVariables.setFoliosForReassignment_FolioNumber("");
// FoliosForReassignment_OrderNumber = ""
ConectaProveedoresClientVariables.setFoliosForReassignment_OrderNumber("");
// FoliosForReassignment_OriginalUserId = NullTextIdentifier
ConectaProveedoresClientVariables.setFoliosForReassignment_OriginalUserId(OS$BuiltinFunctions.nullTextIdentifier());
// FoliosForReassignment_TargetUserId = NullTextIdentifier
ConectaProveedoresClientVariables.setFoliosForReassignment_TargetUserId(OS$BuiltinFunctions.nullTextIdentifier());
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_SearchUserTargetDropdownRefresh$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchUserTargetDropdownRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserTargetDropdownRefresh");
span.setAttribute("outsystems.function.key", "8f1b6bee-05d8-4215-867d-af1d97d036a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SearchUserTargetDropdownRefresh");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.Wb_SearchUserTargetDropdownRefresh$vars"))());
vars.value.userIdInLocal = userIdIn;
return OS$Flow.executeAsyncFlow(function () {
// FoliosForReassignment_TargetUserId = UserId
ConectaProveedoresClientVariables.setFoliosForReassignment_TargetUserId(vars.value.userIdInLocal);
// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "9e6e7e1f-aef3-44ac-a1a8-cf7c3f8f5e24");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetReassignments
var result = controller.getReassignments$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_wb_ReassignFolioConfirm$Action(notificationContentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_ReassignFolioConfirm", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ReassignFolioConfirm");
span.setAttribute("outsystems.function.key", "f78d32fb-a005-4859-abbd-7a42b3246709");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_ReassignFolioConfirm");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.Wb_ReassignFolioConfirm$vars"))());
vars.value.notificationContentInLocal = notificationContentIn.clone();
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("NewReassignSidebar"), callContext);

// NotifContent = NotificationContent
model.variables.notifContentVar = vars.value.notificationContentInLocal;
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("Notif"), callContext);

// Refresh Query: GetReassignments
var result = controller.getReassignments$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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

openSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenSidebar");
span.setAttribute("outsystems.function.key", "0eeea114-8b40-4cfb-8776-1be00ab390da");
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

revertReassign$Action(l_ReassignmentIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RevertReassign__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RevertReassign");
span.setAttribute("outsystems.function.key", "138d55c0-7fa7-414a-9773-3235be0b3216");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "1cad604a-f855-42a3-b9f7-ecefbc5ec8fb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._columnTogglerPassColumn$Action, callContext, columnJSONIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "1e49f1e2-1d16-418b-baed-22ed1cd0ec1c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSort$Action, callContext, sortByIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getReassignmentsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetReassignmentsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetReassignmentsOnAfterFetch");
span.setAttribute("outsystems.function.key", "32ed81d6-69e9-432d-a6ef-353e1b9e8e47");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getReassignmentsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SearchUserOriginalDropdownRefresh$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchUserOriginalDropdownRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserOriginalDropdownRefresh");
span.setAttribute("outsystems.function.key", "38b82fbe-0497-47d1-9148-61f00368e8c7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SearchUserOriginalDropdownRefresh$Action, callContext, userIdIn);
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
span.setAttribute("outsystems.function.key", "49956027-4109-4bef-b9db-559cee01e240");
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
span.setAttribute("outsystems.function.key", "4e96bfa6-f683-44b0-810a-e732dff67c39");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "52c85164-32d4-4c42-ae20-5fd98f9e2d86");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refreshList$Action, callContext, i_IsClearFiltersIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "69215177-a007-4ff3-914d-fc59713c8725");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setColumnVisiblityOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "7ee9ce8f-5fef-4782-9dd4-24c7bfb30b23");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._resetFilters$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_SearchUserTargetDropdownRefresh$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchUserTargetDropdownRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserTargetDropdownRefresh");
span.setAttribute("outsystems.function.key", "8f1b6bee-05d8-4215-867d-af1d97d036a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SearchUserTargetDropdownRefresh$Action, callContext, userIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "9e6e7e1f-aef3-44ac-a1a8-cf7c3f8f5e24");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onPaginationNavigate$Action, callContext, newStartIndexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_ReassignFolioConfirm$Action(notificationContentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_ReassignFolioConfirm__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ReassignFolioConfirm");
span.setAttribute("outsystems.function.key", "f78d32fb-a005-4859-abbd-7a42b3246709");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_ReassignFolioConfirm$Action, callContext, notificationContentIn);
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
return ConectaProveedores_j_FoliosSAEController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Almacen]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment$ActionFolioReassignGeneralRevoke", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.RevertReassign$vars", [{
name: "l_ReassignmentId",
attrName: "l_ReassignmentIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.Wb_SearchUserOriginalDropdownRefresh$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.NewReassignSidebarOnToggle$vars", [{
name: "IsOpen",
attrName: "isOpenInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.Wb_SearchUserTargetDropdownRefresh$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.Wb_ReassignFolioConfirm$vars", [{
name: "NotificationContent",
attrName: "notificationContentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
},
complexType: ST_6fc999fa8f6e0055c73f2f167c4bad19Structure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


