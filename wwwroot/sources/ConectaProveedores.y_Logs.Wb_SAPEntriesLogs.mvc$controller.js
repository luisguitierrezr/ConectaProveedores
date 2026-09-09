import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvc_TranslationsResources from "./ConectaProveedores.y_Logs.Wb_SAPEntriesLogs.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getEntriesByOrderMainId$AggrRefresh: 0,
countEntries$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getEntriesByOrderMainId$AggrRefresh: [],
countEntries$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
exportOrderEntriesLog$ServerAction(i_OrderMainIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportOrderEntriesLog", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOrderEntriesLog");
span.setAttribute("outsystems.function.key", "ad87a91f-942a-483d-8637-00fb914cfb4d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderMainId: OS$DataConversion.ServerDataConverter.to(i_OrderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ExportOrderEntriesLog", "screenservices/ConectaProveedores/y_Logs/Wb_SAPEntriesLogs/ActionExportOrderEntriesLog", "TVwS6vlFOWs+nqtkQAIDJg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_SAPEntriesLogs$ActionExportOrderEntriesLog"))();
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
get getEntriesByOrderMainId$AggrRefresh() {if(!(this.hasOwnProperty("_getEntriesByOrderMainId$AggrRefresh"))) {
this._getEntriesByOrderMainId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetEntriesByOrderMainId", "screenservices/ConectaProveedores/y_Logs/Wb_SAPEntriesLogs/ScreenDataSetGetEntriesByOrderMainId", "j+LbBLwAzvdDAkSgc8EhoA", maxRecords, startIndex, function (b) {
model.variables.getEntriesByOrderMainIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEntriesByOrderMainIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getEntriesByOrderMainIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetEntriesByOrderMainId", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntriesByOrderMainId");
span.setAttribute("outsystems.function.key", "99855754-d999-4884-bc1b-1e9a9a34ed70");
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

return this._getEntriesByOrderMainId$AggrRefresh;
}set getEntriesByOrderMainId$AggrRefresh(value) {this._getEntriesByOrderMainId$AggrRefresh = value;
}

get countEntries$AggrRefresh() {if(!(this.hasOwnProperty("_countEntries$AggrRefresh"))) {
this._countEntries$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetCountEntries", "screenservices/ConectaProveedores/y_Logs/Wb_SAPEntriesLogs/ScreenDataSetCountEntries", "g0DcGtel3OksH8pUiw6ZaQ", maxRecords, startIndex, function (b) {
model.variables.countEntriesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.countEntriesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.countEntriesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("CountEntries", function (span) {
if(span) {
span.setAttribute("code.function", "CountEntries");
span.setAttribute("outsystems.function.key", "ed2d2960-5f68-4636-8767-76b5426d8e39");
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

return this._countEntries$AggrRefresh;
}set countEntries$AggrRefresh(value) {this._countEntries$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getEntriesByOrderMainId$AggrRefresh", "countEntries$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_seeMoreOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeMoreOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "034b56fc-1514-4bf2-b226-42cfc8495400");
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
// Refresh Query: GetEntriesByOrderMainId
var result = controller.getEntriesByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_searchOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SearchOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "12faa9c9-0401-423b-98bc-3fd600f56820");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetEntriesByOrderMainId
var result = controller.getEntriesByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_clearFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "206dadb9-d247-4d1b-87f6-193f8c27fa2b");
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
// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerID2"), callContext);

// Refresh Query: GetEntriesByOrderMainId
var result = controller.getEntriesByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "513f44cf-99f8-4589-8d5f-bdd48381607c");
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
// Refresh Query: GetEntriesByOrderMainId
var result = controller.getEntriesByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: CountEntries
var result = controller.countEntries$AggrRefresh(300, 0, callContext);
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
_onClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClick", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "9213824c-abb9-4d31-8dc3-3baaf40ceb75");
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
_downloadExcelFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadExcelFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "bc6a5803-dd77-4605-8cc3-c8bb9021d489");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadExcelFile");
callContext = controller.callContext(callContext);
var exportOrderEntriesLogVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Is Table Empty?
return OS$Flow.executeSequence(function () {
if((!(model.variables.getEntriesByOrderMainIdAggr.listOut.isEmpty))) {
// Execute Action: ExportOrderEntriesLog
model.flush();
return controller.exportOrderEntriesLog$ServerAction(model.variables.i_OrderMainIdIn, callContext).then(function (value) {
exportOrderEntriesLogVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportOrderEntriesLogVar.value.o_FileOut, ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("53i+ObrOAUGI5XxadNa0Xg#Filename.339752415.1", "ExportOrderEntriesLog-") + OS$BuiltinFunctions.longIntegerToText(model.variables.i_OrderMainIdIn)) + ".xlsx")));
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
span.setAttribute("outsystems.function.key", "e7f5c4d1-6ee9-4cbe-8a1c-d4943922ebc1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_SAPEntriesLogs.DatePickerOnSelected$vars"))());
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

seeMoreOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeMoreOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "034b56fc-1514-4bf2-b226-42cfc8495400");
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

searchOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "12faa9c9-0401-423b-98bc-3fd600f56820");
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

clearFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "206dadb9-d247-4d1b-87f6-193f8c27fa2b");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "513f44cf-99f8-4589-8d5f-bdd48381607c");
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

onClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "9213824c-abb9-4d31-8dc3-3baaf40ceb75");
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

downloadExcelFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadExcelFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "bc6a5803-dd77-4605-8cc3-c8bb9021d489");
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
span.setAttribute("outsystems.function.key", "e7f5c4d1-6ee9-4cbe-8a1c-d4943922ebc1");
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
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_SAPEntriesLogs$ActionExportOrderEntriesLog", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_SAPEntriesLogs.DatePickerOnSelected$vars", [{
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


