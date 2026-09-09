import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord, ST_b1b6df219277397c7c2be747d587880aStructure } from "./Organization.model.js";
import { RC_99fa4277b2264c97bde8f4525bdc92e0 } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
serviceSetUserPreferences$ServerAction(i_PreferencesIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceSetUserPreferences", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceSetUserPreferences");
span.setAttribute("outsystems.function.key", "43ab8855-94cb-4125-adfc-366a47ce2067");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Preferences: OS$DataConversion.ServerDataConverter.to(i_PreferencesIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceSetUserPreferences", "screenservices/ConectaProveedores/y_Utils/Wb_SetTableRecord/ServiceAPIServiceSetUserPreferences", "EnrMJEzru13zm5eu_p43Kw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_SetTableRecord$ServiceAPIServiceSetUserPreferences"))();
executeServerActionResult.o_ReturnOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Return, ST_b1b6df219277397c7c2be747d587880aStructure);
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

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdownOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownOnChange");
span.setAttribute("outsystems.function.key", "05478f28-820c-4487-99da-d683174c95cc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownOnChange");
callContext = controller.callContext(callContext);
var serviceSetUserPreferencesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ServiceSetUserPreferences
model.flush();
return controller.serviceSetUserPreferences$ServerAction(function () {
var rec = new EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord();
rec.idAttr = OS$BuiltinFunctions.getUserId();
rec.tableLinesCountAttr = model.variables.maxRecordsVar;
return rec;
}(), callContext).then(function (value) {
serviceSetUserPreferencesVar.value = value;
}).then(function () {
// MaxRecords = MaxRecords
ConectaProveedoresClientVariables.setMaxRecords(model.variables.maxRecordsVar);
// Trigger Event: Refresh
return controller.refresh$Action(callContext);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "51d05ac1-81b9-437a-b0f2-7f0f89bfaf05");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.recordsListVar, function () {
var list = new (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))();
list.pushAll([function () {
var rec = new RC_99fa4277b2264c97bde8f4525bdc92e0();
rec.textAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Oviqs7fNR02_FhLH5kbY+w#Value.1376800055.1", "5 Records");
rec.valueAttr = 5;
return rec;
}(), function () {
var rec = new RC_99fa4277b2264c97bde8f4525bdc92e0();
rec.textAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("uRpS4pp3JkGy7BcAZz+6uw#Value.784910625.1", "10 Records");
rec.valueAttr = 10;
return rec;
}(), function () {
var rec = new RC_99fa4277b2264c97bde8f4525bdc92e0();
rec.textAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("s7MKdvsuqEShZkzCV+Sbxw#Value.588397120.1", "20 Records");
rec.valueAttr = 20;
return rec;
}(), function () {
var rec = new RC_99fa4277b2264c97bde8f4525bdc92e0();
rec.textAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("U51AmN0HFkeThF5r+SW1+w#Value.-1143395.1", "50 Records");
rec.valueAttr = 50;
return rec;
}(), function () {
var rec = new RC_99fa4277b2264c97bde8f4525bdc92e0();
rec.textAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4e+FqPwEQEausQEJaQd4BQ#Value.-1169846541.1", "100 Records");
rec.valueAttr = 100;
return rec;
}(), function () {
var rec = new RC_99fa4277b2264c97bde8f4525bdc92e0();
rec.textAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Gw1vATUTcUGGcd8h7uDi4A#Value.1328169396.1", "200 Records");
rec.valueAttr = 200;
return rec;
}()]);
return list;
}(), callContext);
// MaxRecords = MaxRecords
model.variables.maxRecordsVar = ConectaProveedoresClientVariables.getMaxRecords();
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

dropdownOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownOnChange");
span.setAttribute("outsystems.function.key", "05478f28-820c-4487-99da-d683174c95cc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "51d05ac1-81b9-437a-b0f2-7f0f89bfaf05");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get refresh$Action() {if(!(this.hasOwnProperty("_refresh$Action"))) {
this._refresh$Action = function () {
return Promise.resolve();
};
}

return this._refresh$Action;
}set refresh$Action(value) {this._refresh$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onInitialize$Action(callContext);

};
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
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_SetTableRecord$ServiceAPIServiceSetUserPreferences", [{
name: "o_Return",
attrName: "o_ReturnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


