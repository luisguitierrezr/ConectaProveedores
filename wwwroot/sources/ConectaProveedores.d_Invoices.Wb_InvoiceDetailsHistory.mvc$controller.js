import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
countInvoiceLogs$AggrRefresh: 0,
getUsers$AggrRefresh: 0,
getInvoiceLogsByInvoiceId$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
countInvoiceLogs$AggrRefresh: [],
getUsers$AggrRefresh: [],
getInvoiceLogsByInvoiceId$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
exportInvoiceLogs$ServerAction(i_InvoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportInvoiceLogs", function (span) {
if(span) {
span.setAttribute("code.function", "ExportInvoiceLogs");
span.setAttribute("outsystems.function.key", "7ea43ae3-241f-41b7-90b0-2ef36ae4a082");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ExportInvoiceLogs", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsHistory/ActionExportInvoiceLogs", "kFNSmIpdbIyWbdU4LC59XA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory$ActionExportInvoiceLogs"))();
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
get countInvoiceLogs$AggrRefresh() {if(!(this.hasOwnProperty("_countInvoiceLogs$AggrRefresh"))) {
this._countInvoiceLogs$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetCountInvoiceLogs", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsHistory/ScreenDataSetCountInvoiceLogs", "FlVUhC2n3Z6ozIPySkkw4w", maxRecords, startIndex, function (b) {
model.variables.countInvoiceLogsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.countInvoiceLogsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.countInvoiceLogsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("CountInvoiceLogs", function (span) {
if(span) {
span.setAttribute("code.function", "CountInvoiceLogs");
span.setAttribute("outsystems.function.key", "3c5496ad-7977-4341-9ad5-50e75eb9d784");
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

return this._countInvoiceLogs$AggrRefresh;
}set countInvoiceLogs$AggrRefresh(value) {this._countInvoiceLogs$AggrRefresh = value;
}

get getUsers$AggrRefresh() {if(!(this.hasOwnProperty("_getUsers$AggrRefresh"))) {
this._getUsers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUsers", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsHistory/ScreenDataSetGetUsers", "NjQ4OcV9dc13vZkixlCu_w", maxRecords, startIndex, function (b) {
model.variables.getUsersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsers", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsers");
span.setAttribute("outsystems.function.key", "8f053e88-998f-484a-a0e1-258866038eed");
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

get getInvoiceLogsByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceLogsByInvoiceId$AggrRefresh"))) {
this._getInvoiceLogsByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceLogsByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsHistory/ScreenDataSetGetInvoiceLogsByInvoiceId", "UNYe+L8kx5Wv_y9smJKW4w", maxRecords, startIndex, function (b) {
model.variables.getInvoiceLogsByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceLogsByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceLogsByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceLogsByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceLogsByInvoiceId");
span.setAttribute("outsystems.function.key", "be619f51-c014-4437-a8ff-76292fad6c2c");
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

return this._getInvoiceLogsByInvoiceId$AggrRefresh;
}set getInvoiceLogsByInvoiceId$AggrRefresh(value) {this._getInvoiceLogsByInvoiceId$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["countInvoiceLogs$AggrRefresh", "getUsers$AggrRefresh", "getInvoiceLogsByInvoiceId$AggrRefresh"];
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
span.setAttribute("outsystems.function.key", "14c2ce20-8226-4914-bfc5-43f35d95720b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// i_Refresh = i_Refresh
model.variables.i_RefreshIn = model.variables.i_RefreshIn;
// Refresh Query: GetInvoiceLogsByInvoiceId
var result = controller.getInvoiceLogsByInvoiceId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: CountInvoiceLogs
var result = controller.countInvoiceLogs$AggrRefresh(300, 0, callContext);
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
_searchOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SearchOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "17dbe10d-c875-4ef0-a335-9330e68ee994");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceLogsByInvoiceId
var result = controller.getInvoiceLogsByInvoiceId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "75becb05-5d2a-4d38-8b68-faeb205732c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadExcelFile");
callContext = controller.callContext(callContext);
var exportInvoiceLogsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Is Table Empty?
return OS$Flow.executeSequence(function () {
if((!(model.variables.getInvoiceLogsByInvoiceIdAggr.listOut.isEmpty))) {
// Execute Action: ExportInvoiceLogs
model.flush();
return controller.exportInvoiceLogs$ServerAction(model.variables.i_InvoiceIdIn, callContext).then(function (value) {
exportInvoiceLogsVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportInvoiceLogsVar.value.o_FileOut, (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Omh4Bt_i4E+KgCEkmmkY1g#Filename.-1868617008.1", "ExportLog") + ".xlsx")));
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
_clearFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "8edb4360-c670-48e9-b2b8-4ce005c31085");
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

// Refresh Query: GetInvoiceLogsByInvoiceId
var result = controller.getInvoiceLogsByInvoiceId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "acb87265-eaf9-496e-9da7-8605ff6e03ab");
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
// Refresh Query: GetInvoiceLogsByInvoiceId
var result = controller.getInvoiceLogsByInvoiceId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_onClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClick", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "e8593d7f-a725-48f6-95da-2503bc776749");
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
_datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "f2117dcb-6cc0-44b2-ab4f-a2e4f7472956");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.DatePickerOnSelected$vars"))());
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "14c2ce20-8226-4914-bfc5-43f35d95720b");
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

searchOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "17dbe10d-c875-4ef0-a335-9330e68ee994");
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
span.setAttribute("outsystems.function.key", "75becb05-5d2a-4d38-8b68-faeb205732c0");
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

clearFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "8edb4360-c670-48e9-b2b8-4ce005c31085");
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
span.setAttribute("outsystems.function.key", "acb87265-eaf9-496e-9da7-8605ff6e03ab");
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

onClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "e8593d7f-a725-48f6-95da-2503bc776749");
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

datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "f2117dcb-6cc0-44b2-ab4f-a2e4f7472956");
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory$ActionExportInvoiceLogs", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.DatePickerOnSelected$vars", [{
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


