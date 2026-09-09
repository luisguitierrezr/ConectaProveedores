import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_TranslationsResources from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getProposalLogsByProposalId$AggrRefresh: 0,
countProposalLogs$AggrRefresh: 0,
getUsers$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getProposalLogsByProposalId$AggrRefresh: [],
countProposalLogs$AggrRefresh: [],
getUsers$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
exportProposalLog$ServerAction(i_ProposalIdIn, i_ProposalLineIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportProposalLog", function (span) {
if(span) {
span.setAttribute("code.function", "ExportProposalLog");
span.setAttribute("outsystems.function.key", "a07f8e2c-0799-4937-897a-038796fa64d2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_ProposalLineId: OS$DataConversion.ServerDataConverter.to(i_ProposalLineIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ExportProposalLog", "screenservices/ConectaProveedores/y_Logs/Wb_ProposalLogs/ActionExportProposalLog", "lhR09pUZWgSZGLnt9VfJ_Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_ProposalLogs$ActionExportProposalLog"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, OS$DataTypes.DataTypes.BinaryData);
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
get getProposalLogsByProposalId$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLogsByProposalId$AggrRefresh"))) {
this._getProposalLogsByProposalId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLogsByProposalId", "screenservices/ConectaProveedores/y_Logs/Wb_ProposalLogs/ScreenDataSetGetProposalLogsByProposalId", "w7p+EG6m1pCgVSHRuMg4Xw", maxRecords, startIndex, function (b) {
model.variables.getProposalLogsByProposalIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLogsByProposalIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLogsByProposalIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLogsByProposalId", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLogsByProposalId");
span.setAttribute("outsystems.function.key", "87a61342-db3e-4117-b3e6-b35ea322af43");
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

return this._getProposalLogsByProposalId$AggrRefresh;
}set getProposalLogsByProposalId$AggrRefresh(value) {this._getProposalLogsByProposalId$AggrRefresh = value;
}

get countProposalLogs$AggrRefresh() {if(!(this.hasOwnProperty("_countProposalLogs$AggrRefresh"))) {
this._countProposalLogs$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetCountProposalLogs", "screenservices/ConectaProveedores/y_Logs/Wb_ProposalLogs/ScreenDataSetCountProposalLogs", "IpLOb0OcKCRoe2H4ypn1uw", maxRecords, startIndex, function (b) {
model.variables.countProposalLogsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.countProposalLogsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.countProposalLogsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("CountProposalLogs", function (span) {
if(span) {
span.setAttribute("code.function", "CountProposalLogs");
span.setAttribute("outsystems.function.key", "9ef26a77-fd4e-4b46-b779-1af3818f9939");
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

return this._countProposalLogs$AggrRefresh;
}set countProposalLogs$AggrRefresh(value) {this._countProposalLogs$AggrRefresh = value;
}

get getUsers$AggrRefresh() {if(!(this.hasOwnProperty("_getUsers$AggrRefresh"))) {
this._getUsers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUsers", "screenservices/ConectaProveedores/y_Logs/Wb_ProposalLogs/ScreenDataSetGetUsers", "jmM4tFTbi1n+mJrsKmwiSg", maxRecords, startIndex, function (b) {
model.variables.getUsersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsers", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsers");
span.setAttribute("outsystems.function.key", "e0e4867b-97fa-4871-b94a-a27dc4765436");
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

return this._getUsers$AggrRefresh;
}set getUsers$AggrRefresh(value) {this._getUsers$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getProposalLogsByProposalId$AggrRefresh", "countProposalLogs$AggrRefresh", "getUsers$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_searchOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SearchOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "4328ac05-b6b6-4782-8578-99adf157ca77");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetProposalLogsByProposalId
var result = controller.getProposalLogsByProposalId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_downloadExcelFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadExcelFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "49fa0933-a15b-40ea-91a8-143e7123eb20");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadExcelFile");
callContext = controller.callContext(callContext);
var exportProposalLogVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Is Table Empty?
return OS$Flow.executeSequence(function () {
if((!(model.variables.getProposalLogsByProposalIdAggr.listOut.isEmpty))) {
// Execute Action: ExportProposalLog
model.flush();
return controller.exportProposalLog$ServerAction(model.variables.i_ProposalIdIn, model.variables.i_ProposalLineIdIn, callContext).then(function (value) {
exportProposalLogVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportProposalLogVar.value.o_FileOut, (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1+l3diCzmEmeaCKFwyydRQ#Filename.-1868617008.1", "ExportLog") + ".xlsx")));
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
_datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "88d44c4c-eaab-47e0-ac61-06f35dad72a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_ProposalLogs.DatePickerOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// l_DateTimeVar = SelectedDateTime
model.variables.l_DateTimeVarVar = OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClick", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "a0184a7c-09e2-4468-a5f9-49f900b77502");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClick");
callContext = controller.callContext(callContext);
var datePickerOpenVar = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerOpen
datePickerOpenVar.value = OutSystemsUIController$datePickerOpen$Action(idService.getId("DatePickerID2"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "c7d14bc6-7761-49b3-b1cc-38c0702a66d0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearFilters");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Reset Filters
// l_DateTimeVar = NullDate
model.variables.l_DateTimeVarVar = OS$BuiltinFunctions.nullDate();
// l_UserName = NullTextIdentifier
model.variables.l_UserNameVar = OS$BuiltinFunctions.nullTextIdentifier();
// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerID2"), callContext);

// Refresh Query: GetProposalLogsByProposalId
var result = controller.getProposalLogsByProposalId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_seeMoreOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeMoreOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "d0b4cbbc-05d6-4fdb-b468-b53de083fd74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SeeMoreOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// MaxRecords + 10
// MaxRecords = MaxRecords + 10
model.variables.maxRecordsVar = (model.variables.maxRecordsVar + 10);
// Refresh Query: GetProposalLogsByProposalId
var result = controller.getProposalLogsByProposalId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "ed9542e7-169e-4bdf-a6c0-3aa3e78d1162");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// i_refresh = i_refresh
model.variables.i_refreshIn = model.variables.i_refreshIn;
// Refresh Query: GetProposalLogsByProposalId
var result = controller.getProposalLogsByProposalId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: CountProposalLogs
var result = controller.countProposalLogs$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetUsers
var result = controller.getUsers$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Reset Max Records
// MaxRecords = 10
model.variables.maxRecordsVar = 10;
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

searchOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "4328ac05-b6b6-4782-8578-99adf157ca77");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._searchOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

downloadExcelFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadExcelFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "49fa0933-a15b-40ea-91a8-143e7123eb20");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadExcelFile$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "88d44c4c-eaab-47e0-ac61-06f35dad72a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "a0184a7c-09e2-4468-a5f9-49f900b77502");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "c7d14bc6-7761-49b3-b1cc-38c0702a66d0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearFilters$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

seeMoreOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeMoreOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "d0b4cbbc-05d6-4fdb-b468-b53de083fd74");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._seeMoreOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "ed9542e7-169e-4bdf-a6c0-3aa3e78d1162");
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
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_ProposalLogs$ActionExportProposalLog", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_ProposalLogs.DatePickerOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


