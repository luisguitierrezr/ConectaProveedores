import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_j_FoliosSAE_PreApprovalFolios_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.PreApprovalFolios.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_PreApprovalFolios_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getPreApprovalFolios$AggrRefresh: 0,
getRegions$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getPreApprovalFolios$AggrRefresh: [],
getRegions$AggrRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolios/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolios/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getPreApprovalFolios$AggrRefresh() {if(!(this.hasOwnProperty("_getPreApprovalFolios$AggrRefresh"))) {
this._getPreApprovalFolios$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPreApprovalFolios", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolios/ScreenDataSetGetPreApprovalFolios", "6xZD9K7drFltw4ymKqVo5Q", maxRecords, startIndex, function (b) {
model.variables.getPreApprovalFoliosAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPreApprovalFoliosAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPreApprovalFoliosAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPreApprovalFolios", function (span) {
if(span) {
span.setAttribute("code.function", "GetPreApprovalFolios");
span.setAttribute("outsystems.function.key", "699d32a5-d853-42b2-866f-27706bc7b40c");
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

return this._getPreApprovalFolios$AggrRefresh;
}set getPreApprovalFolios$AggrRefresh(value) {this._getPreApprovalFolios$AggrRefresh = value;
}

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolios/ScreenDataSetGetRegions", "pi9+eTY0K7kS8ozgoS2YpA", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "98cb4eac-3f42-42ab-80bc-cf4f47bf3852");
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

return this._getRegions$AggrRefresh;
}set getRegions$AggrRefresh(value) {this._getRegions$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getPreApprovalFolios$AggrRefresh", "getRegions$AggrRefresh"];
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
span.setAttribute("outsystems.function.key", "37903e20-7304-482d-a137-8a3db25a867e");
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
rec.screenAttr = "Pre Approval Folios";
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
_clearDateOn$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateOn", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateOn");
span.setAttribute("outsystems.function.key", "40a147be-c25b-4364-9bb4-21ea81d13095");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateOn");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// PreApprovalFolios_CreatedOn = NullDate
ConectaProveedoresClientVariables.setPreApprovalFolios_CreatedOn(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerCreatedOn"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerCreatedOn"), callContext);

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
span.setAttribute("outsystems.function.key", "4f477a12-52e6-480e-9b2c-cf3667cdbc21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetPreApprovalFolios
var result = controller.getPreApprovalFolios$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "5193991c-0a05-494b-b59e-7f301404d75c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// PreApprovalFolios_FolioNumber = ""
ConectaProveedoresClientVariables.setPreApprovalFolios_FolioNumber("");
// PreApprovalFolios_OrderNumber = ""
ConectaProveedoresClientVariables.setPreApprovalFolios_OrderNumber("");
// PreApprovalFolios_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setPreApprovalFolios_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// PreApprovalFolios_CreatedOn = NullDate
ConectaProveedoresClientVariables.setPreApprovalFolios_CreatedOn(OS$BuiltinFunctions.nullDate());
// PreApprovalFolios_RegionId = NullIdentifier
ConectaProveedoresClientVariables.setPreApprovalFolios_RegionId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "78d03857-f23d-4896-8c64-50b5f64afd08");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// PreApprovalFolios_SupplierId = SupplierId
ConectaProveedoresClientVariables.setPreApprovalFolios_SupplierId(vars.value.supplierIdInLocal);
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "79e28792-de7d-42dd-ae54-74fda80fd29b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("PreApprovalTable"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
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
_datePickerCreatedOn$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerCreatedOn", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerCreatedOn");
span.setAttribute("outsystems.function.key", "99c577b8-c9e8-4a12-8d02-1b2cba946402");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerCreatedOn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.DatePickerCreatedOn$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// PreApprovalFolios_CreatedOn = SelectedDate
ConectaProveedoresClientVariables.setPreApprovalFolios_CreatedOn(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "9c1fde3d-7944-407b-9593-3f6a7658ad87");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerCreatedOn2Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = 0
model.variables.startIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
// Execute Action: DatePickerCreatedOn2
datePickerCreatedOn2Var.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerCreatedOn"), callContext);

}

// Refresh Query: GetPreApprovalFolios
var result = controller.getPreApprovalFolios$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "b0f71035-bdf4-4620-a0fd-d7e2e2efbdcc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort2 += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort2 = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetPreApprovalFolios
var result = controller.getPreApprovalFolios$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "b7349762-a252-43c5-a2db-bec56a71035a");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "37903e20-7304-482d-a137-8a3db25a867e");
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

clearDateOn$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateOn");
span.setAttribute("outsystems.function.key", "40a147be-c25b-4364-9bb4-21ea81d13095");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearDateOn$Action, callContext);
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
span.setAttribute("outsystems.function.key", "4f477a12-52e6-480e-9b2c-cf3667cdbc21");
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

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "5193991c-0a05-494b-b59e-7f301404d75c");
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

dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "78d03857-f23d-4896-8c64-50b5f64afd08");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSuppliersOnChanged$Action, callContext, supplierIdIn);
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
span.setAttribute("outsystems.function.key", "79e28792-de7d-42dd-ae54-74fda80fd29b");
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

datePickerCreatedOn$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerCreatedOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerCreatedOn");
span.setAttribute("outsystems.function.key", "99c577b8-c9e8-4a12-8d02-1b2cba946402");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerCreatedOn$Action, callContext, selectedDateIn);
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
span.setAttribute("outsystems.function.key", "9c1fde3d-7944-407b-9593-3f6a7658ad87");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "b0f71035-bdf4-4620-a0fd-d7e2e2efbdcc");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "b7349762-a252-43c5-a2db-bec56a71035a");
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
return ConectaProveedores_j_FoliosSAEController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Pedidos, ConectaProveedoresController$default.roles.Folios]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.DatePickerCreatedOn$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolios.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


