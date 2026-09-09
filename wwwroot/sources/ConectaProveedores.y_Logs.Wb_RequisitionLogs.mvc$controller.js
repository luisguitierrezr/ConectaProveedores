import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_y_Logs_Wb_RequisitionLogs_mvc_TranslationsResources from "./ConectaProveedores.y_Logs.Wb_RequisitionLogs.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Logs_Wb_RequisitionLogs_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRequisitionLogsByRequisitionId$AggrRefresh: 0,
countRequisitionLogs$AggrRefresh: 0,
getUsers$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getRequisitionLogsByRequisitionId$AggrRefresh: [],
countRequisitionLogs$AggrRefresh: [],
getUsers$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
exportRequisitionLog$ServerAction(i_RequisitionIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportRequisitionLog", function (span) {
if(span) {
span.setAttribute("code.function", "ExportRequisitionLog");
span.setAttribute("outsystems.function.key", "10d55920-7aa9-434e-9517-f41adbd3087e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ExportRequisitionLog", "screenservices/ConectaProveedores/y_Logs/Wb_RequisitionLogs/ActionExportRequisitionLog", "qjoHyfG_bBGPMSiWer0nfw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_RequisitionLogs$ActionExportRequisitionLog"))();
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
get getRequisitionLogsByRequisitionId$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionLogsByRequisitionId$AggrRefresh"))) {
this._getRequisitionLogsByRequisitionId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionLogsByRequisitionId", "screenservices/ConectaProveedores/y_Logs/Wb_RequisitionLogs/ScreenDataSetGetRequisitionLogsByRequisitionId", "CXFJhRM1WJ2ERE9jRqx1Jg", maxRecords, startIndex, function (b) {
model.variables.getRequisitionLogsByRequisitionIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionLogsByRequisitionIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionLogsByRequisitionIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionLogsByRequisitionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionLogsByRequisitionId");
span.setAttribute("outsystems.function.key", "2651c8a2-e156-4374-83c8-f7708c865a82");
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

return this._getRequisitionLogsByRequisitionId$AggrRefresh;
}set getRequisitionLogsByRequisitionId$AggrRefresh(value) {this._getRequisitionLogsByRequisitionId$AggrRefresh = value;
}

get countRequisitionLogs$AggrRefresh() {if(!(this.hasOwnProperty("_countRequisitionLogs$AggrRefresh"))) {
this._countRequisitionLogs$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetCountRequisitionLogs", "screenservices/ConectaProveedores/y_Logs/Wb_RequisitionLogs/ScreenDataSetCountRequisitionLogs", "CMEFWk5DLDhuLtp9eeDmEw", maxRecords, startIndex, function (b) {
model.variables.countRequisitionLogsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.countRequisitionLogsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.countRequisitionLogsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("CountRequisitionLogs", function (span) {
if(span) {
span.setAttribute("code.function", "CountRequisitionLogs");
span.setAttribute("outsystems.function.key", "27255755-dda9-41ae-b751-1a0cacbcb18b");
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

return this._countRequisitionLogs$AggrRefresh;
}set countRequisitionLogs$AggrRefresh(value) {this._countRequisitionLogs$AggrRefresh = value;
}

get getUsers$AggrRefresh() {if(!(this.hasOwnProperty("_getUsers$AggrRefresh"))) {
this._getUsers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUsers", "screenservices/ConectaProveedores/y_Logs/Wb_RequisitionLogs/ScreenDataSetGetUsers", "NkXTOQa_zPJBLW1BS3vpPA", maxRecords, startIndex, function (b) {
model.variables.getUsersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsers", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsers");
span.setAttribute("outsystems.function.key", "ca80d2af-c9ca-4727-a9e2-2afec21037c5");
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
this._dataFetchActionNames = ["getRequisitionLogsByRequisitionId$AggrRefresh", "countRequisitionLogs$AggrRefresh", "getUsers$AggrRefresh"];
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
span.setAttribute("outsystems.function.key", "09accb94-1e6f-4d54-a843-909c2d6545f0");
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
// Refresh Query: GetRequisitionLogsByRequisitionId
var result = controller.getRequisitionLogsByRequisitionId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: CountRequisitionLogs
var result = controller.countRequisitionLogs$AggrRefresh(300, 0, callContext);
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
_downloadExcelFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadExcelFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "a86bcc83-b77f-44cd-ad7f-481bd95fbc8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadExcelFile");
callContext = controller.callContext(callContext);
var exportRequisitionLogVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Is Table Empty?
return OS$Flow.executeSequence(function () {
if((!(model.variables.getRequisitionLogsByRequisitionIdAggr.listOut.isEmpty))) {
// Execute Action: ExportRequisitionLog
model.flush();
return controller.exportRequisitionLog$ServerAction(model.variables.i_RequisitionIdIn, callContext).then(function (value) {
exportRequisitionLogVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportRequisitionLogVar.value.o_FileOut, (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zWdCDR8wLECfih_OQ2GNgg#Filename.-1868617008.1", "ExportLog") + ".xlsx")));
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
span.setAttribute("outsystems.function.key", "bb744cb7-e390-462c-9279-e8b55d128344");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Logs.Wb_RequisitionLogs.DatePickerOnSelected$vars"))());
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
_clearFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "d1e20e46-4d58-44ec-b402-fffb5247e8d8");
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

// Refresh Query: GetRequisitionLogsByRequisitionId
var result = controller.getRequisitionLogsByRequisitionId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "f814e214-97a4-418b-bce8-a506748af315");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetRequisitionLogsByRequisitionId
var result = controller.getRequisitionLogsByRequisitionId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "fd97622b-6217-4048-b4d1-323b8fe7250b");
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
// Refresh Query: GetRequisitionLogsByRequisitionId
var result = controller.getRequisitionLogsByRequisitionId$AggrRefresh(model.variables.maxRecordsVar, 0, callContext);
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
span.setAttribute("outsystems.function.key", "fe38de5c-7c7a-484b-9b28-758cdf5d2b7f");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "09accb94-1e6f-4d54-a843-909c2d6545f0");
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

downloadExcelFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadExcelFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadExcelFile");
span.setAttribute("outsystems.function.key", "a86bcc83-b77f-44cd-ad7f-481bd95fbc8d");
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
span.setAttribute("outsystems.function.key", "bb744cb7-e390-462c-9279-e8b55d128344");
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

clearFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFilters");
span.setAttribute("outsystems.function.key", "d1e20e46-4d58-44ec-b402-fffb5247e8d8");
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

searchOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "f814e214-97a4-418b-bce8-a506748af315");
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

seeMoreOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeMoreOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeMoreOnClick");
span.setAttribute("outsystems.function.key", "fd97622b-6217-4048-b4d1-323b8fe7250b");
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
span.setAttribute("outsystems.function.key", "fe38de5c-7c7a-484b-9b28-758cdf5d2b7f");
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
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_RequisitionLogs$ActionExportRequisitionLog", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.y_Logs.Wb_RequisitionLogs.DatePickerOnSelected$vars", [{
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


