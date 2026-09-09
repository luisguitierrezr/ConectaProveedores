import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_g_Reports_LinesReport_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.LinesReport.mvc$translationsResources.js";
import ConectaProveedores_g_ReportsController$default from "./ConectaProveedores.g_Reports.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_LinesReport_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoices$AggrRefresh: -1,
getRegions$AggrRefresh: 0,
getUserApplicationRoles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoices$AggrRefresh: [],
getRegions$AggrRefresh: [],
getUserApplicationRoles$DataActRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/g_Reports/LinesReport/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/g_Reports/LinesReport/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport$ActionGetSettings"))();
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
generateLinesReport62$ServerAction(i_Report62_DateFromIn, i_Report62_DateToIn, i_Report62_RegionIdIn, i_Report62_SupplierIdIn, i_OffsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateLinesReport62", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateLinesReport62");
span.setAttribute("outsystems.function.key", "8232e595-6550-4669-88e3-5d291f7cbeef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Report62_DateFrom: OS$DataConversion.ServerDataConverter.to(i_Report62_DateFromIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_Report62_DateTo: OS$DataConversion.ServerDataConverter.to(i_Report62_DateToIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_Report62_RegionId: OS$DataConversion.ServerDataConverter.to(i_Report62_RegionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_Report62_SupplierId: OS$DataConversion.ServerDataConverter.to(i_Report62_SupplierIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_OffsetUtc: OS$DataConversion.ServerDataConverter.to(i_OffsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateLinesReport62", "screenservices/ConectaProveedores/g_Reports/LinesReport/ActionGenerateLinesReport62", "rnnutq+CVO5bnHXWzR99Jw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport$ActionGenerateLinesReport62"))();
executeServerActionResult.fileOut = OS$DataConversion.ServerDataConverter.from(outputs.File, ST_a158c76eb93396680623c04244f48b6cStructure);
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/g_Reports/LinesReport/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getInvoices$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoices$AggrRefresh"))) {
this._getInvoices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoices", "screenservices/ConectaProveedores/g_Reports/LinesReport/ScreenDataSetGetInvoices", "uww2vJ2K1zo8xHtGjSzb3g", maxRecords, startIndex, function (b) {
model.variables.getInvoicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoicesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoices");
span.setAttribute("outsystems.function.key", "e930a4fa-02f6-44c0-a9d5-edaf32d5e599");
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

return this._getInvoices$AggrRefresh;
}set getInvoices$AggrRefresh(value) {this._getInvoices$AggrRefresh = value;
}

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/g_Reports/LinesReport/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "f041d3a7-3f56-453a-bf14-631703c5ba0d");
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

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/g_Reports/LinesReport/DataActionGetUserApplicationRoles", "JZzjF7tEQEQgiJIkoWlJ4w", function (b) {
model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserApplicationRolesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRoles", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRoles");
span.setAttribute("outsystems.function.key", "d9e10fab-6865-44dc-9dc8-de1c9954981a");
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

return this._getUserApplicationRoles$DataActRefresh;
}set getUserApplicationRoles$DataActRefresh(value) {this._getUserApplicationRoles$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoices$AggrRefresh", "getRegions$AggrRefresh", "getUserApplicationRoles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_clearDateFrom$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "0ecf10f1-f08e-4c1b-ad73-75b43414d3a5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateFrom");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Report62_DateFrom = NullDate
ConectaProveedoresClientVariables.setReport62_DateFrom(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerFrom"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerFrom"), callContext);

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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "30ec2f62-c4cf-474a-8119-2b4cdd3b45a1");
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
rec.screenAttr = "62 Report";
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "4898665d-772e-4a87-8330-1d491d21e1e8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsToEmpty = Report62_DateFrom = NullDate or Report62_DateTo = NullDate
model.variables.isToEmptyVar = (ConectaProveedoresClientVariables.getReport62_DateFrom().equals(OS$BuiltinFunctions.nullDate()) || ConectaProveedoresClientVariables.getReport62_DateTo().equals(OS$BuiltinFunctions.nullDate()));
// empty roles?
return OS$Flow.executeSequence(function () {
if((((model.variables.getUserApplicationRolesDataAct.userRolesListOut.isEmpty && (!(model.variables.getUserApplicationRolesDataAct.isAuditorOut))) && model.variables.getUserApplicationRolesDataAct.userSupplierOut.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result;
} else {
// ApplicationRoleIdForAggregate = GetUserApplicationRoles.UserRolesList[GetUserApplicationRoles.UserRolesList.Length - 1].ApplicationRoleId
model.variables.applicationRoleIdForAggregateVar = model.variables.getUserApplicationRolesDataAct.userRolesListOut.getItem((model.variables.getUserApplicationRolesDataAct.userRolesListOut.length - 1)).applicationRoleIdAttr;
// Report62_RegionId = If
ConectaProveedoresClientVariables.setReport62_RegionId(((model.variables.getUserApplicationRolesDataAct.isAllRegionsOut) ? (ConectaProveedoresClientVariables.getReport62_RegionId()) : (model.variables.getUserApplicationRolesDataAct.userRegionOut)));
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// ReInvokeToggler = notReInvokeToggler
model.variables.reInvokeTogglerVar = (!(model.variables.reInvokeTogglerVar));
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "558d8dab-06b5-409b-9e21-be04f25e68cb");
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
_datePickerTo$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerTo", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "64ec3451-34a2-4860-9c43-869177752485");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DatePickerTo$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Report62_DateTo = SelectedDate
ConectaProveedoresClientVariables.setReport62_DateTo(vars.value.selectedDateInLocal);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_datePickerFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "6d109cc4-3e53-47c5-874f-274ceefad6b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DatePickerFrom$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Report62_DateFrom = SelectedDate
ConectaProveedoresClientVariables.setReport62_DateFrom(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "71b495ca-6a41-496c-acbd-b086669603c1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Report62_SupplierId = SupplierId
ConectaProveedoresClientVariables.setReport62_SupplierId(vars.value.supplierIdInLocal);
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
_getInvoicesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "7722b055-53da-4e79-abe2-2edfd17a4c1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoicesOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Count
return OS$Flow.executeSequence(function () {
if(((model.variables.countAfterFetchVar === 0))) {
// CountAfterFetch = CountAfterFetch + 1
model.variables.countAfterFetchVar = (model.variables.countAfterFetchVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("LinesReportTable"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// ColumnJSONVar = GetSettings.OutSettingsText
model.variables.columnJSONVarVar = getSettingsVar.value.outSettingsTextOut;
// ReInvokeToggler = notReInvokeToggler
model.variables.reInvokeTogglerVar = (!(model.variables.reInvokeTogglerVar));
// Loading = False
model.variables.loadingVar = false;
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
_dropdownSearchRegionOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchRegionOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchRegionOnChanged");
span.setAttribute("outsystems.function.key", "81043331-e830-4d7f-a6c5-eb22ca0b86a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchRegionOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DropdownSearchRegionOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Report62_RegionId = LongIntegerToIdentifier
ConectaProveedoresClientVariables.setReport62_RegionId(OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "92e20229-fe55-4688-94c5-616b514c0038");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// Report62_RegionId = If
ConectaProveedoresClientVariables.setReport62_RegionId(OS$BuiltinFunctions.integerToLongInteger(((model.variables.getUserApplicationRolesDataAct.isAllRegionsOut) ? (OS$BuiltinFunctions.nullIdentifier()) : (OS$BuiltinFunctions.longIntegerToInteger(model.variables.getUserApplicationRolesDataAct.userRegionOut)))));
// Report62_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setReport62_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Report62_DateFrom = NullDate
ConectaProveedoresClientVariables.setReport62_DateFrom(OS$BuiltinFunctions.nullDate());
// Report62_DateTo = NullDate
ConectaProveedoresClientVariables.setReport62_DateTo(OS$BuiltinFunctions.nullDate());
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
span.setAttribute("outsystems.function.key", "9f11b748-9ddc-4f79-8a86-d69498a1dc6d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerDateToVar = new OS$DataTypes.VariableHolder();
var datePickerDateFromVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = 0
model.variables.startIndexVar = 0;
// IsToEmpty = False
model.variables.isToEmptyVar = false;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
// Execute Action: DatePickerDateFrom
datePickerDateFromVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerFrom"), callContext);

// Execute Action: DatePickerDateTo
datePickerDateToVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerTo"), callContext);

}

// has dates?
if((!((!(ConectaProveedoresClientVariables.getReport62_DateFrom().equals(OS$BuiltinFunctions.nullDate())) && !(ConectaProveedoresClientVariables.getReport62_DateTo().equals(OS$BuiltinFunctions.nullDate())))))) {
// IsToEmpty = True
model.variables.isToEmptyVar = true;
}

// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// ReInvokeToggler = notReInvokeToggler
model.variables.reInvokeTogglerVar = (!(model.variables.reInvokeTogglerVar));
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
_generateReportOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GenerateReportOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportOnClick");
span.setAttribute("outsystems.function.key", "b8da2b95-e202-4ba8-8811-f9b75a4b3958");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GenerateReportOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var generateLinesReport62Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// empty?
return OS$Flow.executeSequence(function () {
if((model.variables.getInvoicesAggr.listOut.isEmpty)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cGv51ZORRkKaiq_XteMF4Q#Message.-1473724744.1", "The selected list to download is empty."), /*Error*/ 3);
} else {
// more than 12 months
return OS$Flow.executeSequence(function () {
if((OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addMonths(ConectaProveedoresClientVariables.getReport62_DateFrom(), 12)).lt(ConectaProveedoresClientVariables.getReport62_DateTo()))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CsjFJ3z1C0uTwStPO48wfg#Message.338494342.1", "The date must be at maximum 12 months after the reference date."), /*Error*/ 3);
} else {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: GenerateLinesReport62
model.flush();
return controller.generateLinesReport62$ServerAction(ConectaProveedoresClientVariables.getReport62_DateFrom(), ConectaProveedoresClientVariables.getReport62_DateTo(), ConectaProveedoresClientVariables.getReport62_RegionId(), ConectaProveedoresClientVariables.getReport62_SupplierId(), (ConectaProveedoresClientVariables.getOffsetUtc() * (-1)), callContext).then(function (value) {
generateLinesReport62Var.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateLinesReport62Var.value.fileOut.binaryDataAttr, generateLinesReport62Var.value.fileOut.nameAttr));
});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("LinesReport.GenerateReportOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "4a62a03b-6c90-49b8-b032-e6fd460a85a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bUF_2Hy9VUq8FxoEriFXSg#Message.1989930733.1", "There was a problem generating the report. Please try again later."), /*Error*/ 3);
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "bf47f35e-09cd-4ef3-ade6-334e0a56920a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// ReInvokeToggler = notReInvokeToggler
model.variables.reInvokeTogglerVar = (!(model.variables.reInvokeTogglerVar));
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
_clearDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "c8d0addf-0db5-41d3-9d61-1799b11cf13a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateTo");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Report62_DateTo = NullDate
ConectaProveedoresClientVariables.setReport62_DateTo(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerTo"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerTo"), callContext);

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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "d2312307-b145-4183-bab7-3a0905b77a7e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.OnSort$vars"))());
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
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// ReInvokeToggler = notReInvokeToggler
model.variables.reInvokeTogglerVar = (!(model.variables.reInvokeTogglerVar));
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
span.setAttribute("outsystems.function.key", "f896d7c3-bd04-4b75-8674-38297b98b79f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.LinesReport.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("LinesReportTable"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// ColumnJSONVar = ColumnJSON
model.variables.columnJSONVarVar = vars.value.columnJSONInLocal;
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

clearDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "0ecf10f1-f08e-4c1b-ad73-75b43414d3a5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearDateFrom$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "30ec2f62-c4cf-474a-8119-2b4cdd3b45a1");
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

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "4898665d-772e-4a87-8330-1d491d21e1e8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUserApplicationRolesOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "558d8dab-06b5-409b-9e21-be04f25e68cb");
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

datePickerTo$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "64ec3451-34a2-4860-9c43-869177752485");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerTo$Action, callContext, selectedDateIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

datePickerFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "6d109cc4-3e53-47c5-874f-274ceefad6b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerFrom$Action, callContext, selectedDateIn);
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
span.setAttribute("outsystems.function.key", "71b495ca-6a41-496c-acbd-b086669603c1");
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

getInvoicesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "7722b055-53da-4e79-abe2-2edfd17a4c1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoicesOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdownSearchRegionOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchRegionOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchRegionOnChanged");
span.setAttribute("outsystems.function.key", "81043331-e830-4d7f-a6c5-eb22ca0b86a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchRegionOnChanged$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "92e20229-fe55-4688-94c5-616b514c0038");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "9f11b748-9ddc-4f79-8a86-d69498a1dc6d");
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

generateReportOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateReportOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportOnClick");
span.setAttribute("outsystems.function.key", "b8da2b95-e202-4ba8-8811-f9b75a4b3958");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._generateReportOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "bf47f35e-09cd-4ef3-ade6-334e0a56920a");
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

clearDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "c8d0addf-0db5-41d3-9d61-1799b11cf13a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearDateTo$Action, callContext);
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
span.setAttribute("outsystems.function.key", "d2312307-b145-4183-bab7-3a0905b77a7e");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "f896d7c3-bd04-4b75-8674-38297b98b79f");
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
return ConectaProveedores_g_ReportsController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.TelcelUserAuditor, ConectaProveedoresController$default.roles.Requisiciones]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport$ActionGenerateLinesReport62", [{
name: "File",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DatePickerTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DatePickerFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.DropdownSearchRegionOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.LinesReport.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


