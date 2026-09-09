import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_g_Reports_SupplierInvoicesReport_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.SupplierInvoicesReport.mvc$translationsResources.js";
import ConectaProveedores_g_ReportsController$default from "./ConectaProveedores.g_Reports.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure, ST_4301e782f48f03168dfeb78159c19548Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_SupplierInvoicesReport_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceStatuses$AggrRefresh: 0,
getSuppliers$AggrRefresh: 0,
getInvoices$AggrRefresh: -1,
getRegions$AggrRefresh: -1,
getInvoicesAllRecords$AggrRefresh: -1,
getSettings$DataActRefresh: 0,
getUserApplicationRoles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceStatuses$AggrRefresh: [],
getSuppliers$AggrRefresh: [],
getInvoices$AggrRefresh: [],
getRegions$AggrRefresh: [],
getInvoicesAllRecords$AggrRefresh: [],
getSettings$DataActRefresh: [],
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport$ActionGetSettings"))();
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
generateInvoicesReport48$ServerAction(filtersIn, i_OffsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateInvoicesReport48", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateInvoicesReport48");
span.setAttribute("outsystems.function.key", "4b8676da-3228-4c3a-9a93-8d2e9af75c4c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Filters: OS$DataConversion.ServerDataConverter.to(filtersIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_OffsetUtc: OS$DataConversion.ServerDataConverter.to(i_OffsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateInvoicesReport48", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ActionGenerateInvoicesReport48", "S+GMHOnsO+k+AtoNnCeSdw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport$ActionGenerateInvoicesReport48"))();
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
generateInvoicesReport48_Invoices2$ServerAction(i_OffsetUtcIn, invoiceIdListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateInvoicesReport48_Invoices2", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateInvoicesReport48_Invoices2");
span.setAttribute("outsystems.function.key", "2b2a245d-a053-4686-84db-8fb7f6b504a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OffsetUtc: OS$DataConversion.ServerDataConverter.to(i_OffsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
InvoiceIdList: OS$DataConversion.ServerDataConverter.to(invoiceIdListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateInvoicesReport48_Invoices2", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ActionGenerateInvoicesReport48_Invoices2", "zbaL4N0oEk1d1s23EWr3Kw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport$ActionGenerateInvoicesReport48_Invoices2"))();
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

// Aggregates and Data Actions
get getInvoiceStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceStatuses$AggrRefresh"))) {
this._getInvoiceStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceStatuses", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ScreenDataSetGetInvoiceStatuses", "utvzQMvCRKj9zqcwJYu94w", maxRecords, startIndex, function (b) {
model.variables.getInvoiceStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceStatuses");
span.setAttribute("outsystems.function.key", "1d365289-1f3d-447f-8b86-15ba0e8356a8");
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

return this._getInvoiceStatuses$AggrRefresh;
}set getInvoiceStatuses$AggrRefresh(value) {this._getInvoiceStatuses$AggrRefresh = value;
}

get getSuppliers$AggrRefresh() {if(!(this.hasOwnProperty("_getSuppliers$AggrRefresh"))) {
this._getSuppliers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSuppliers", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ScreenDataSetGetSuppliers", "sWvarXmO8jieuqPjhkj3Ew", maxRecords, startIndex, function (b) {
model.variables.getSuppliersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSuppliersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSuppliersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "GetSuppliers");
span.setAttribute("outsystems.function.key", "25e948f0-5c87-4c0f-bb96-8bda72311f5e");
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

return this._getSuppliers$AggrRefresh;
}set getSuppliers$AggrRefresh(value) {this._getSuppliers$AggrRefresh = value;
}

get getInvoices$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoices$AggrRefresh"))) {
this._getInvoices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoices", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ScreenDataSetGetInvoices", "GycdLIWKrbHxQBK5VfeGJw", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "654e5ed3-5b24-4c6d-ae51-78740b8fcaca");
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "8352daf6-0888-4ebd-9422-116257c5baa4");
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

get getInvoicesAllRecords$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesAllRecords$AggrRefresh"))) {
this._getInvoicesAllRecords$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesAllRecords", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/ScreenDataSetGetInvoicesAllRecords", "N4whkgnaq5ijtZatINlt_w", maxRecords, startIndex, function (b) {
model.variables.getInvoicesAllRecordsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesAllRecordsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesAllRecordsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesAllRecords", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesAllRecords");
span.setAttribute("outsystems.function.key", "ec844c50-872f-4d8f-8148-8055f8580a3a");
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

return this._getInvoicesAllRecords$AggrRefresh;
}set getInvoicesAllRecords$AggrRefresh(value) {this._getInvoicesAllRecords$AggrRefresh = value;
}

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/DataActionGetSettings", "jsI1PCbvcpcN_+fOwgD4_w", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSettingsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "41e5bf45-bac9-4efc-a329-7ef681ba4309");
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

return this._getSettings$DataActRefresh;
}set getSettings$DataActRefresh(value) {this._getSettings$DataActRefresh = value;
}

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/g_Reports/SupplierInvoicesReport/DataActionGetUserApplicationRoles", "gJTBMXdb0W8I4iB5LAw6xA", function (b) {
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
span.setAttribute("outsystems.function.key", "a92622c4-4b3e-4ae9-b273-3dd116c83b93");
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
this._dataFetchActionNames = ["getInvoiceStatuses$AggrRefresh", "getSuppliers$AggrRefresh", "getInvoices$AggrRefresh", "getRegions$AggrRefresh", "getInvoicesAllRecords$AggrRefresh", "getSettings$DataActRefresh", "getUserApplicationRoles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "06639edc-1bf5-4e9d-98ce-ef81f764be3b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsToEmpty = InvReport48_DateFrom = NullDate or InvReport48_DateTo = NullDate
model.variables.isToEmptyVar = (ConectaProveedoresClientVariables.getInvReport48_DateFrom().equals(OS$BuiltinFunctions.nullDate()) || ConectaProveedoresClientVariables.getInvReport48_DateTo().equals(OS$BuiltinFunctions.nullDate()));
// empty roles?
return OS$Flow.executeSequence(function () {
if((model.variables.getUserApplicationRolesDataAct.userRolesListOut.isEmpty)) {
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result;
} else {
// ApplicationRoleIdForAggregate = GetUserApplicationRoles.UserRolesList[GetUserApplicationRoles.UserRolesList.Length - 1].ApplicationRoleId
model.variables.applicationRoleIdForAggregateVar = model.variables.getUserApplicationRolesDataAct.userRolesListOut.getItem((model.variables.getUserApplicationRolesDataAct.userRolesListOut.length - 1)).applicationRoleIdAttr;
// InvReport48_RegionId = If
ConectaProveedoresClientVariables.setInvReport48_RegionId(((model.variables.getUserApplicationRolesDataAct.isAllRegionsOut) ? (ConectaProveedoresClientVariables.getInvReport48_RegionId()) : (model.variables.getUserApplicationRolesDataAct.userRegionOut)));
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
_getSettingsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSettingsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsOnAfterFetch");
span.setAttribute("outsystems.function.key", "09b582d5-f624-464a-bc4a-e7c4b79bab16");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSettingsOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetRegions
var result = controller.getRegions$AggrRefresh(99999, 0, callContext);
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
_datePickerTo$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerTo", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "10179620-b60f-4766-9f13-dba553e3cd16");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DatePickerTo$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// InvReport48_DateTo = SelectedDate
ConectaProveedoresClientVariables.setInvReport48_DateTo(vars.value.selectedDateInLocal);
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "25da8cdf-e929-4e63-a94c-e79839c1cdcc");
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
// InvReport48_DateTo = NullDate
ConectaProveedoresClientVariables.setInvReport48_DateTo(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerProveedorTo"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorTo"), callContext);

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
span.setAttribute("outsystems.function.key", "2d1e8599-8658-4345-a973-c7894c2a2915");
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
rec.screenAttr = "Supplier 48 Invoices Report";
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
_getInvoicesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "36078997-55d4-4d9f-91c3-62b11812435a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoicesOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsTableVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoicesAllRecords
var result = controller.getInvoicesAllRecords$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Count
return OS$Flow.executeSequence(function () {
if(((model.variables.countAfterFetchVar === 0))) {
// CountAfterFetch = CountAfterFetch + 1
model.variables.countAfterFetchVar = (model.variables.countAfterFetchVar + 1);
// Execute Action: GetSettingsTable
model.flush();
return controller.getSettings$ServerAction(idService.getId("SupplierInvoicesTable"), callContext).then(function (value) {
getSettingsTableVar.value = value;
}).then(function () {
// ColumnJSONVar = GetSettingsTable.OutSettingsText
model.variables.columnJSONVarVar = getSettingsTableVar.value.outSettingsTextOut;
// ReInvokeToggler = notReInvokeToggler
model.variables.reInvokeTogglerVar = (!(model.variables.reInvokeTogglerVar));
// Loading = False
model.variables.loadingVar = false;
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "3e7fc516-5efb-4587-b3cc-c40555f74e39");
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "6f983990-6406-48cb-b69d-38cf463c42a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("SupplierInvoicesTable"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
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
_generateReportOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GenerateReportOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportOnClick");
span.setAttribute("outsystems.function.key", "8be311a3-72c2-4175-bce2-f74f0404d9c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GenerateReportOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var generateInvoicesReport48Var = new OS$DataTypes.VariableHolder();
var generateInvoicesReport48_Invoices2Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// empty?
return OS$Flow.executeSequence(function () {
if((model.variables.getInvoicesAggr.listOut.isEmpty)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tmSiCwzXR06OkTW73XvyZg#Message.-1473724744.1", "The selected list to download is empty."), /*Error*/ 3);
} else {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.getSettingsDataAct.o_IsActiveDEV_C01Out)) {
// Execute Action: GenerateInvoicesReport48_Invoices2
model.flush();
return controller.generateInvoicesReport48_Invoices2$ServerAction((ConectaProveedoresClientVariables.getOffsetUtc() * (-1)), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoicesAllRecordsAggr.listOut, new OS$DataTypes.LongIntegerList(), function (source, target) {
target = source.invoiceAttr.idAttr;
return target;
}), callContext).then(function (value) {
generateInvoicesReport48_Invoices2Var.value = value;
}).then(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateInvoicesReport48_Invoices2Var.value.fileOut.binaryDataAttr, generateInvoicesReport48_Invoices2Var.value.fileOut.nameAttr));
});
} else {
// Execute Action: GenerateInvoicesReport48
model.flush();
return controller.generateInvoicesReport48$ServerAction(function () {
var rec = new ST_4301e782f48f03168dfeb78159c19548Structure();
rec.invoiceNameAttr = ConectaProveedoresClientVariables.getInvReport48_InvoiceName();
rec.supplierIdAttr = ConectaProveedoresClientVariables.getInvReport48_SupplierId();
rec.invoiceStatusIdAttr = ConectaProveedoresClientVariables.getInvReport48_InvoiceStatusId();
rec.dateFromAttr = ConectaProveedoresClientVariables.getInvReport48_DateFrom();
rec.dateToAttr = ConectaProveedoresClientVariables.getInvReport48_DateTo();
return rec;
}(), (ConectaProveedoresClientVariables.getOffsetUtc() * (-1)), callContext).then(function (value) {
generateInvoicesReport48Var.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateInvoicesReport48Var.value.fileOut.binaryDataAttr, generateInvoicesReport48Var.value.fileOut.nameAttr));
});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("SupplierInvoicesReport.GenerateReportOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "9a3fef73-a559-409f-837d-a626b7287bc1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wyOyF8faAE+Cjom0McafvA#Message.1989930733.1", "There was a problem generating the report. Please try again later."), /*Error*/ 3);
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
span.setAttribute("outsystems.function.key", "95fc798b-b87a-4b06-bd74-02c3161e2021");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.OnPaginationNavigate$vars"))());
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
_datePickerFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "a34a5966-9747-44b3-b45c-33538e71ac6f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DatePickerFrom$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// InvReport48_DateFrom = SelectedDate
ConectaProveedoresClientVariables.setInvReport48_DateFrom(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "a66cf278-454c-475f-aa73-426d1040c93b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// InvReport48_SupplierId = SupplierId
ConectaProveedoresClientVariables.setInvReport48_SupplierId(vars.value.supplierIdInLocal);
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "afcde39e-38c2-4153-9057-08e272b245fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerDateFromVar = new OS$DataTypes.VariableHolder();
var datePickerDateToVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = 0
model.variables.startIndexVar = 0;
// IsToEmpty = False
model.variables.isToEmptyVar = false;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
// Execute Action: DatePickerDateFrom
datePickerDateFromVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorFrom"), callContext);

// Execute Action: DatePickerDateTo
datePickerDateToVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorTo"), callContext);

}

// has dates?
if((!((!(ConectaProveedoresClientVariables.getInvReport48_DateFrom().equals(OS$BuiltinFunctions.nullDate())) && !(ConectaProveedoresClientVariables.getInvReport48_DateTo().equals(OS$BuiltinFunctions.nullDate())))))) {
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
_dropdownStatusOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownStatusOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownStatusOnChanged");
span.setAttribute("outsystems.function.key", "db00b6df-d1bc-49e7-bbbc-50b261f1f307");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownStatusOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DropdownStatusOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// InvReport48_InvoiceStatusId = IntegerToIdentifier
ConectaProveedoresClientVariables.setInvReport48_InvoiceStatusId(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
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
_clearDateFrom$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "e94c5e0f-5da9-41ce-92e7-056e7a912b72");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateFrom");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// InvReport48_DateFrom = NullDate
ConectaProveedoresClientVariables.setInvReport48_DateFrom(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerProveedorFrom"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorFrom"), callContext);

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
span.setAttribute("outsystems.function.key", "eb2a9d4c-cfe3-4719-b75a-4df43c175ada");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// InvReport48_InvoiceName = ""
ConectaProveedoresClientVariables.setInvReport48_InvoiceName("");
// InvReport48_InvoiceStatusId = NullIdentifier
ConectaProveedoresClientVariables.setInvReport48_InvoiceStatusId(OS$BuiltinFunctions.nullIdentifier());
// InvReport48_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setInvReport48_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// InvReport48_DateFrom = NullDate
ConectaProveedoresClientVariables.setInvReport48_DateFrom(OS$BuiltinFunctions.nullDate());
// InvReport48_DateTo = NullDate
ConectaProveedoresClientVariables.setInvReport48_DateTo(OS$BuiltinFunctions.nullDate());
// InvReport48_RegionId = If
ConectaProveedoresClientVariables.setInvReport48_RegionId(OS$BuiltinFunctions.integerToLongInteger(((model.variables.getUserApplicationRolesDataAct.isAllRegionsOut) ? (OS$BuiltinFunctions.nullIdentifier()) : (OS$BuiltinFunctions.longIntegerToInteger(model.variables.getUserApplicationRolesDataAct.userRegionOut)))));
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "f0779f83-b79a-4bd2-ac80-d8b0ed729f5f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.OnSort$vars"))());
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
_dropdownSearchRegionOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchRegionOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchRegionOnChanged");
span.setAttribute("outsystems.function.key", "f63be7ae-b9f7-410b-b430-028a49aa86c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchRegionOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DropdownSearchRegionOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// InvReport48_RegionId = LongIntegerToIdentifier
ConectaProveedoresClientVariables.setInvReport48_RegionId(OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
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

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "06639edc-1bf5-4e9d-98ce-ef81f764be3b");
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

getSettingsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSettingsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsOnAfterFetch");
span.setAttribute("outsystems.function.key", "09b582d5-f624-464a-bc4a-e7c4b79bab16");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSettingsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerTo$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "10179620-b60f-4766-9f13-dba553e3cd16");
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

clearDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "25da8cdf-e929-4e63-a94c-e79839c1cdcc");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "2d1e8599-8658-4345-a973-c7894c2a2915");
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

getInvoicesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "36078997-55d4-4d9f-91c3-62b11812435a");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "3e7fc516-5efb-4587-b3cc-c40555f74e39");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "6f983990-6406-48cb-b69d-38cf463c42a3");
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

generateReportOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateReportOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportOnClick");
span.setAttribute("outsystems.function.key", "8be311a3-72c2-4175-bce2-f74f0404d9c0");
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
span.setAttribute("outsystems.function.key", "95fc798b-b87a-4b06-bd74-02c3161e2021");
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

datePickerFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "a34a5966-9747-44b3-b45c-33538e71ac6f");
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
span.setAttribute("outsystems.function.key", "a66cf278-454c-475f-aa73-426d1040c93b");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "afcde39e-38c2-4153-9057-08e272b245fa");
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

dropdownStatusOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownStatusOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownStatusOnChanged");
span.setAttribute("outsystems.function.key", "db00b6df-d1bc-49e7-bbbc-50b261f1f307");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownStatusOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

clearDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "e94c5e0f-5da9-41ce-92e7-056e7a912b72");
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

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "eb2a9d4c-cfe3-4719-b75a-4df43c175ada");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "f0779f83-b79a-4bd2-ac80-d8b0ed729f5f");
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

dropdownSearchRegionOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchRegionOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchRegionOnChanged");
span.setAttribute("outsystems.function.key", "f63be7ae-b9f7-410b-b430-028a49aa86c0");
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
roles: [ConectaProveedoresController$default.roles.TelcelUserAuditor, ConectaProveedoresController$default.roles.Proveedor]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport$ActionGenerateInvoicesReport48", [{
name: "File",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport$ActionGenerateInvoicesReport48_Invoices2", [{
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
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DatePickerTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DatePickerFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DropdownStatusOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.SupplierInvoicesReport.DropdownSearchRegionOnChanged$vars", [{
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


