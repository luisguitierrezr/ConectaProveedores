import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_y_Logs_Wb_OrderLogs_mvc_TranslationsResources from "./ConectaProveedores.y_Logs.Wb_OrderLogs.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Logs_Wb_OrderLogs_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getOrderLogsByOrderMainId$AggrRefresh: 0,
countOrderLogs$AggrRefresh: 0,
getUsers$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getOrderLogsByOrderMainId$AggrRefresh: [],
countOrderLogs$AggrRefresh: [],
getUsers$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
exportOrderLog$ServerAction(i_OrderMainIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportOrderLog", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOrderLog");
span.setAttribute("outsystems.function.key", "2edbfe41-40da-4823-913b-c98fc1824d22");
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
return controller.callServerAction("ExportOrderLog", "screenservices/ConectaProveedores/y_Logs/Wb_OrderLogs/ActionExportOrderLog", "XsGzeGHEra3pQfRE7MYdZw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_OrderLogs$ActionExportOrderLog"))();
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
get getOrderLogsByOrderMainId$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderLogsByOrderMainId$AggrRefresh"))) {
this._getOrderLogsByOrderMainId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderLogsByOrderMainId", "screenservices/ConectaProveedores/y_Logs/Wb_OrderLogs/ScreenDataSetGetOrderLogsByOrderMainId", "FSic+uYeqrCqPLo2wGYalA", maxRecords, startIndex, function (b) {
model.variables.getOrderLogsByOrderMainIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderLogsByOrderMainIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderLogsByOrderMainIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderLogsByOrderMainId", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderLogsByOrderMainId");
span.setAttribute("outsystems.function.key", "6eac3429-e3a5-4586-882e-a76937642d55");
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

return this._getOrderLogsByOrderMainId$AggrRefresh;
}set getOrderLogsByOrderMainId$AggrRefresh(value) {this._getOrderLogsByOrderMainId$AggrRefresh = value;
}

get countOrderLogs$AggrRefresh() {if(!(this.hasOwnProperty("_countOrderLogs$AggrRefresh"))) {
this._countOrderLogs$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetCountOrderLogs", "screenservices/ConectaProveedores/y_Logs/Wb_OrderLogs/ScreenDataSetCountOrderLogs", "nlO2AS7EgsMmXDlIc4ICKw", maxRecords, startIndex, function (b) {
model.variables.countOrderLogsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.countOrderLogsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.countOrderLogsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("CountOrderLogs", function (span) {
if(span) {
span.setAttribute("code.function", "CountOrderLogs");
span.setAttribute("outsystems.function.key", "c87541dc-eab6-4642-94e3-e1e1d62705c4");
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

return this._countOrderLogs$AggrRefresh;
}set countOrderLogs$AggrRefresh(value) {this._countOrderLogs$AggrRefresh = value;
}

get getUsers$AggrRefresh() {if(!(this.hasOwnProperty("_getUsers$AggrRefresh"))) {
this._getUsers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUsers", "screenservices/ConectaProveedores/y_Logs/Wb_OrderLogs/ScreenDataSetGetUsers", "jqFxoyoT3_CGiS1axZZDMQ", maxRecords, startIndex, function (b) {
model.variables.getUsersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsers", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsers");
span.setAttribute("outsystems.function.key", "d7fdbec5-2fa7-42a9-ba2f-042a9e7a321f");
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
this._dataFetchActionNames = ["getOrderLogsByOrderMainId$AggrRefresh", "countOrderLogs$AggrRefresh", "getUsers$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_downloadExcelFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadExcelFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "0e249878-4b9a-4dff-9aa4-01f74ff31be2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadExcelFile");
callContext = controller.callContext(callContext);
var exportOrderLogVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Is Table Empty?
return OS$Flow.executeSequence(function () {
if((!(model.variables.getOrderLogsByOrderMainIdAggr.listOut.isEmpty))) {
// Execute Action: ExportOrderLog
model.flush();
return controller.exportOrderLog$ServerAction(model.variables.i_OrderMainIdIn, callContext).then(function (value) {
exportOrderLogVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportOrderLogVar.value.o_FileOut, (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("M+dW8BR3W0uQGyFHOijHPQ#Filename.-533264118.1", "ExportOrderLog") + ".xlsx")));
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
_searchOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SearchOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "3773c428-a06b-4162-bcd1-95620fdf9d76");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderLogsByOrderMainId
var result = controller.getOrderLogsByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
_datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "4577c3ae-2403-481f-a2d6-9cd5acd075e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_OrderLogs.DatePickerOnSelected$vars"))());
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6fefc504-50aa-4761-97c4-13df0eb6d510");
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
// Refresh Query: GetOrderLogsByOrderMainId
var result = controller.getOrderLogsByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: CountOrderLogs
var result = controller.countOrderLogs$AggrRefresh(300, 0, callContext);
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
_clearFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "9a032053-ceaf-436f-a142-c8995beed875");
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

// Refresh Query: GetOrderLogsByOrderMainId
var result = controller.getOrderLogsByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "b82414cc-1390-48a0-8a25-c48fac7b2135");
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
_seeMoreOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeMoreOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "c90945a3-3540-4a13-8426-43a9e4f3a969");
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
// Refresh Query: GetOrderLogsByOrderMainId
var result = controller.getOrderLogsByOrderMainId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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

downloadExcelFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadExcelFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "0e249878-4b9a-4dff-9aa4-01f74ff31be2");
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

searchOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "3773c428-a06b-4162-bcd1-95620fdf9d76");
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

datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "4577c3ae-2403-481f-a2d6-9cd5acd075e1");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6fefc504-50aa-4761-97c4-13df0eb6d510");
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

clearFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "9a032053-ceaf-436f-a142-c8995beed875");
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

onClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClick");
span.setAttribute("outsystems.function.key", "b82414cc-1390-48a0-8a25-c48fac7b2135");
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

seeMoreOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeMoreOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "c90945a3-3540-4a13-8426-43a9e4f3a969");
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
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_OrderLogs$ActionExportOrderLog", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_OrderLogs.DatePickerOnSelected$vars", [{
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


