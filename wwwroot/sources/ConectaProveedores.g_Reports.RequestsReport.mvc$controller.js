import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, feedbackMessageClose$Action as OutSystemsUIController$feedbackMessageClose$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_g_Reports_RequestsReport_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.RequestsReport.mvc$translationsResources.js";
import ConectaProveedores_g_ReportsController$default from "./ConectaProveedores.g_Reports.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_RequestsReport_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRegions$AggrRefresh: 0,
getApplicants$AggrRefresh: 0,
getCompanies$AggrRefresh: 0,
getUserApplicationRoles$DataActRefresh: 0,
getOrderRequests$DataActRefresh: 1
};
this.dataFetchDependentsGraph = {
getRegions$AggrRefresh: [],
getApplicants$AggrRefresh: [],
getCompanies$AggrRefresh: [],
getUserApplicationRoles$DataActRefresh: ["getOrderRequests$DataActRefresh"],
getOrderRequests$DataActRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
generateReport63$ServerAction(report63_StartDateIn, report63_EndDateIn, report63_OrderNumberIn, report63_SociedadIdIn, userRegionIdIn, isAllRegionsIn, report63_SupplierIdIn, report63_ApplicantIn, isToEmptyIn, report63_RegionIdIn, supplierIdIn, inExcelIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateReport63", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReport63");
span.setAttribute("outsystems.function.key", "4e4399d0-9793-4a07-bf19-81aee893f49a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Report63_StartDate: OS$DataConversion.ServerDataConverter.to(report63_StartDateIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
Report63_EndDate: OS$DataConversion.ServerDataConverter.to(report63_EndDateIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
Report63_OrderNumber: OS$DataConversion.ServerDataConverter.to(report63_OrderNumberIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Report63_SociedadId: OS$DataConversion.ServerDataConverter.to(report63_SociedadIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
UserRegionId: OS$DataConversion.ServerDataConverter.to(userRegionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
IsAllRegions: OS$DataConversion.ServerDataConverter.to(isAllRegionsIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
Report63_SupplierId: OS$DataConversion.ServerDataConverter.to(report63_SupplierIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
Report63_Applicant: OS$DataConversion.ServerDataConverter.to(report63_ApplicantIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IsToEmpty: OS$DataConversion.ServerDataConverter.to(isToEmptyIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
Report63_RegionId: OS$DataConversion.ServerDataConverter.to(report63_RegionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
SupplierId: OS$DataConversion.ServerDataConverter.to(supplierIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
InExcel: OS$DataConversion.ServerDataConverter.to(inExcelIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateReport63", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ActionGenerateReport63", "_MFd_C1Hd5fP5zIAYYgFCQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport$ActionGenerateReport63"))();
executeServerActionResult.fileOut = OS$DataConversion.ServerDataConverter.from(outputs.File, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.filenameOut = OS$DataConversion.ServerDataConverter.from(outputs.Filename, OS$DataTypes.DataTypes.Text);
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport$ActionGetSettings"))();
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
get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "6adaa276-51d9-44d7-b1c2-29776e4535aa");
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

get getApplicants$AggrRefresh() {if(!(this.hasOwnProperty("_getApplicants$AggrRefresh"))) {
this._getApplicants$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApplicants", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ScreenDataSetGetApplicants", "QGj5UPJMXgsrzLLjlFNWXQ", maxRecords, startIndex, function (b) {
model.variables.getApplicantsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApplicantsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApplicantsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApplicants", function (span) {
if(span) {
span.setAttribute("code.function", "GetApplicants");
span.setAttribute("outsystems.function.key", "a3c44fde-e5a2-4dc2-8203-b7791ac5cd37");
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

return this._getApplicants$AggrRefresh;
}set getApplicants$AggrRefresh(value) {this._getApplicants$AggrRefresh = value;
}

get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/g_Reports/RequestsReport/ScreenDataSetGetCompanies", "Q7lNESXlNYNXerq8MHCjFA", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "e67d9163-da15-4661-896a-7b6584e2c570");
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

return this._getCompanies$AggrRefresh;
}set getCompanies$AggrRefresh(value) {this._getCompanies$AggrRefresh = value;
}

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/g_Reports/RequestsReport/DataActionGetUserApplicationRoles", "JhHCXCHkNDUQfjeymf6xrg", function (b) {
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
span.setAttribute("outsystems.function.key", "b65662c8-77f7-4b6f-af09-3cd5cdaaf556");
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

get getOrderRequests$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderRequests$DataActRefresh"))) {
this._getOrderRequests$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderRequests", "screenservices/ConectaProveedores/g_Reports/RequestsReport/DataActionGetOrderRequests", "I1KWyjaSRkiQZW9eOd_dOQ", function (b) {
model.variables.getOrderRequestsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderRequestsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderRequestsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderRequestsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderRequests", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRequests");
span.setAttribute("outsystems.function.key", "dd6e1584-a7f4-421f-aa5c-31827aadcb4a");
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

return this._getOrderRequests$DataActRefresh;
}set getOrderRequests$DataActRefresh(value) {this._getOrderRequests$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getRegions$AggrRefresh", "getApplicants$AggrRefresh", "getCompanies$AggrRefresh", "getUserApplicationRoles$DataActRefresh", "getOrderRequests$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "05f487f6-b862-458c-a354-38723caa0f88");
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
rec.screenAttr = "SAP Requests (Report 63)";
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
_dropdownSearchRegionOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchRegionOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchRegionOnChanged");
span.setAttribute("outsystems.function.key", "07856e70-a9b8-4969-ba4e-b32b376e4fae");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchRegionOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSearchRegionOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Report63_RegionId = LongIntegerToIdentifier
ConectaProveedoresClientVariables.setReport63_RegionId(OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
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
_dropdownSearchApplicantOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchApplicantOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchApplicantOnChanged");
span.setAttribute("outsystems.function.key", "12dd609e-7855-4d18-a0fc-9cb44588145f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchApplicantOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSearchApplicantOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Report63_Applicant = TextToIdentifier
ConectaProveedoresClientVariables.setReport63_Applicant(OS$BuiltinFunctions.textToIdentifier(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr));
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
span.setAttribute("outsystems.function.key", "193b9b4f-e6fb-4cf5-a99e-77ca792a1568");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.OnSort$vars"))());
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
// Refresh Query: GetOrderRequests
var result = controller.getOrderRequests$DataActRefresh(callContext);
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
_datePickerEndOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerEndOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerEndOnSelected");
span.setAttribute("outsystems.function.key", "2637e2c8-8969-4b59-a3dc-65bf4cd31af2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerEndOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DatePickerEndOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Report63_EndDate = SelectedDateTime
ConectaProveedoresClientVariables.setReport63_EndDate(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
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
span.setAttribute("outsystems.function.key", "29aa3bca-04f1-4026-bdb0-472c2bf4096e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Report63_SupplierId = SupplierId
ConectaProveedoresClientVariables.setReport63_SupplierId(vars.value.supplierIdInLocal);
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
_datePickerStartOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerStartOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerStartOnSelected");
span.setAttribute("outsystems.function.key", "3287d716-c813-463b-98ec-02d3c5e9b982");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerStartOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DatePickerStartOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Report63_StartDate = SelectedDateTime
ConectaProveedoresClientVariables.setReport63_StartDate(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearDateFrom$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "38b7b47b-8f04-4e83-865e-730e3c175184");
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
// Report63_StartDate = NullDate
ConectaProveedoresClientVariables.setReport63_StartDate(OS$BuiltinFunctions.nullDate());
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "51486bb4-2a74-46c3-8c99-5e9f7dcfcfbd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("RequestsFromSAPTable"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
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
_generateReportOnClick$Action(inExcelIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GenerateReportOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportOnClick");
span.setAttribute("outsystems.function.key", "5a1d7e27-820e-41b1-95c7-60a10f9a8c50");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GenerateReportOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.GenerateReportOnClick$vars"))());
vars.value.inExcelInLocal = inExcelIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var maxAllowedFileSizeVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var generateReport63Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.getOrderRequestsDataAct.list2Out.isEmpty)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZeXQmGzdvEyL4XZfjBTfug#Message.-1473724744.1", "The selected list to download is empty."), /*Error*/ 3);
} else {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: GenerateReport63
model.flush();
return controller.generateReport63$ServerAction(ConectaProveedoresClientVariables.getReport63_StartDate(), ConectaProveedoresClientVariables.getReport63_EndDate(), ConectaProveedoresClientVariables.getReport63_OrderNumber(), ConectaProveedoresClientVariables.getReport63_SociedadId(), model.variables.getUserApplicationRolesDataAct.userRegionOut, model.variables.getUserApplicationRolesDataAct.isAllRegionsOut, ConectaProveedoresClientVariables.getReport63_SupplierId(), ConectaProveedoresClientVariables.getReport63_Applicant(), model.variables.isToEmptyVar, ConectaProveedoresClientVariables.getReport63_RegionId(), model.variables.getUserApplicationRolesDataAct.supplierIdOut, vars.value.inExcelInLocal, callContext).then(function (value) {
generateReport63Var.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateReport63Var.value.fileOut, generateReport63Var.value.filenameOut));
});
}

});
}).catch(function (ex) {
OS$Logger.debug("RequestsReport.GenerateReportOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: MaxAllowedFileSize
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.UserException, "ConectaProveedores.MaxAllowedFileSize")) {
OS$Logger.error(null, ex, null, null, 1);
maxAllowedFileSizeVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("MaxAllowedFileSize", function (span) {
if(span) {
span.setAttribute("code.function", "MaxAllowedFileSize");
span.setAttribute("outsystems.function.key", "aba0c174-bcc7-4d9c-aeac-bb3c8e77daa0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(maxAllowedFileSizeVar.value.exceptionMessageAttr, /*Info*/ 0);
return OS$Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "8a075a72-ca79-4a43-ab3d-60945144134f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("TbaZwv2fl0e_RSFb3_zCwg#Message.1989930733.1", "There was a problem generating the report. Please try again later."), /*Error*/ 3);
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
_clearDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "6fba4202-557d-4131-82bf-d10485d1ae70");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateTo");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Report63_EndDate = NullDate
ConectaProveedoresClientVariables.setReport63_EndDate(OS$BuiltinFunctions.nullDate());
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
_getOrderRequestsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderRequestsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRequestsOnAfterFetch");
span.setAttribute("outsystems.function.key", "8185789e-cc96-4caf-9dc2-cd0cf03f06f3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderRequestsOnAfterFetch");
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
return controller.getSettings$ServerAction(idService.getId("RequestsFromSAPTable"), callContext).then(function (value) {
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "829ce262-a8dc-4a0a-8447-ab37006992e9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerDateFromVar = new OS$DataTypes.VariableHolder();
var datePickerDateToVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: FeedbackMessageClose
OutSystemsUIController$feedbackMessageClose$Action(callContext);
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

// to empty?
if(((((((((ConectaProveedoresClientVariables.getReport63_Applicant() === OS$BuiltinFunctions.nullTextIdentifier()) && ConectaProveedoresClientVariables.getReport63_EndDate().equals(OS$BuiltinFunctions.nullDate())) && ConectaProveedoresClientVariables.getReport63_StartDate().equals(OS$BuiltinFunctions.nullDate())) && (OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getReport63_OrderNumber()) === "")) && ConectaProveedoresClientVariables.getReport63_SociedadId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getReport63_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (ConectaProveedoresClientVariables.getReport63_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || (!(model.variables.getUserApplicationRolesDataAct.isAllRegionsOut)))))) {
// IsToEmpty = True
model.variables.isToEmptyVar = true;
}

// Refresh Query: GetOrderRequests
var result = controller.getOrderRequests$DataActRefresh(callContext);
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "955b0ddf-d67b-4069-a399-7fe497fd4dba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetOrderRequests
var result = controller.getOrderRequests$DataActRefresh(callContext);
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "b58f3b97-27d9-44d8-ab2f-ad1cc0bacc2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Report63_Applicant = NullTextIdentifier
ConectaProveedoresClientVariables.setReport63_Applicant(OS$BuiltinFunctions.nullTextIdentifier());
// Report63_RegionId = NullIdentifier
ConectaProveedoresClientVariables.setReport63_RegionId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Report63_SociedadId = NullIdentifier
ConectaProveedoresClientVariables.setReport63_SociedadId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Report63_OrderNumber = ""
ConectaProveedoresClientVariables.setReport63_OrderNumber("");
// Report63_EndDate = NullDate
ConectaProveedoresClientVariables.setReport63_EndDate(OS$BuiltinFunctions.nullDate());
// Report63_StartDate = NullDate
ConectaProveedoresClientVariables.setReport63_StartDate(OS$BuiltinFunctions.nullDate());
// Report63_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setReport63_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdownSearchCompanyOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchCompanyOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchCompanyOnChanged");
span.setAttribute("outsystems.function.key", "e30a35a0-a6d4-4fa2-bb78-5d91cab9de57");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchCompanyOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSearchCompanyOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Report63_SociedadId = LongIntegerToIdentifier
ConectaProveedoresClientVariables.setReport63_SociedadId(OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "f0507179-e62e-4765-8473-89e83edeb829");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsToEmpty = Report63_Applicant = NullTextIdentifier and Report63_EndDate = NullDate and Report63_StartDate = NullDate and Trim = "" and Report63_SociedadId = NullIdentifier and Report63_SupplierId = NullIdentifier and Report63_RegionId = NullIdentifier or notGetUserApplicationRoles.IsAllRegions
model.variables.isToEmptyVar = (((((((ConectaProveedoresClientVariables.getReport63_Applicant() === OS$BuiltinFunctions.nullTextIdentifier()) && ConectaProveedoresClientVariables.getReport63_EndDate().equals(OS$BuiltinFunctions.nullDate())) && ConectaProveedoresClientVariables.getReport63_StartDate().equals(OS$BuiltinFunctions.nullDate())) && (OS$BuiltinFunctions.trim(ConectaProveedoresClientVariables.getReport63_OrderNumber()) === "")) && ConectaProveedoresClientVariables.getReport63_SociedadId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getReport63_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (ConectaProveedoresClientVariables.getReport63_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || (!(model.variables.getUserApplicationRolesDataAct.isAllRegionsOut))));
if((model.variables.getUserApplicationRolesDataAct.isAllRegionsOut)) {
// Report63_RegionId = NullIdentifier
ConectaProveedoresClientVariables.setReport63_RegionId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
} else {
// Report63_RegionId = GetUserApplicationRoles.UserRegion
ConectaProveedoresClientVariables.setReport63_RegionId(model.variables.getUserApplicationRolesDataAct.userRegionOut);
}

// Refresh Query: GetOrderRequests
var result = controller.getOrderRequests$DataActRefresh(callContext);
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "f797c41d-7574-4762-a5f6-1732aebd7997");
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
span.setAttribute("outsystems.function.key", "05f487f6-b862-458c-a354-38723caa0f88");
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

dropdownSearchRegionOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchRegionOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchRegionOnChanged");
span.setAttribute("outsystems.function.key", "07856e70-a9b8-4969-ba4e-b32b376e4fae");
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

dropdownSearchApplicantOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchApplicantOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchApplicantOnChanged");
span.setAttribute("outsystems.function.key", "12dd609e-7855-4d18-a0fc-9cb44588145f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchApplicantOnChanged$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "193b9b4f-e6fb-4cf5-a99e-77ca792a1568");
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

datePickerEndOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerEndOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerEndOnSelected");
span.setAttribute("outsystems.function.key", "2637e2c8-8969-4b59-a3dc-65bf4cd31af2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerEndOnSelected$Action, callContext, selectedDateTimeIn);
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
span.setAttribute("outsystems.function.key", "29aa3bca-04f1-4026-bdb0-472c2bf4096e");
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

datePickerStartOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerStartOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerStartOnSelected");
span.setAttribute("outsystems.function.key", "3287d716-c813-463b-98ec-02d3c5e9b982");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerStartOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "38b7b47b-8f04-4e83-865e-730e3c175184");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "51486bb4-2a74-46c3-8c99-5e9f7dcfcfbd");
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

generateReportOnClick$Action(inExcelIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateReportOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportOnClick");
span.setAttribute("outsystems.function.key", "5a1d7e27-820e-41b1-95c7-60a10f9a8c50");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._generateReportOnClick$Action, callContext, inExcelIn);
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
span.setAttribute("outsystems.function.key", "6fba4202-557d-4131-82bf-d10485d1ae70");
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

getOrderRequestsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderRequestsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRequestsOnAfterFetch");
span.setAttribute("outsystems.function.key", "8185789e-cc96-4caf-9dc2-cd0cf03f06f3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderRequestsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "829ce262-a8dc-4a0a-8447-ab37006992e9");
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

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "955b0ddf-d67b-4069-a399-7fe497fd4dba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._paginationOnNavigate$Action, callContext, newStartIndexIn);
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
span.setAttribute("outsystems.function.key", "b58f3b97-27d9-44d8-ab2f-ad1cc0bacc2b");
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

dropdownSearchCompanyOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchCompanyOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchCompanyOnChanged");
span.setAttribute("outsystems.function.key", "e30a35a0-a6d4-4fa2-bb78-5d91cab9de57");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchCompanyOnChanged$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "f0507179-e62e-4765-8473-89e83edeb829");
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
span.setAttribute("outsystems.function.key", "f797c41d-7574-4762-a5f6-1732aebd7997");
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
return ConectaProveedores_g_ReportsController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Reportes]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport$ActionGenerateReport63", [{
name: "File",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "Filename",
attrName: "filenameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSearchRegionOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSearchApplicantOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DatePickerEndOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DatePickerStartOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.GenerateReportOnClick$vars", [{
name: "inExcel",
attrName: "inExcelInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.RequestsReport.DropdownSearchCompanyOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


