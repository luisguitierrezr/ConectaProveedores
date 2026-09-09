import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_c_Proveedor_ReportCurrentAccount_mvc_TranslationsResources from "./ConectaProveedores.c_Proveedor.ReportCurrentAccount.mvc$translationsResources.js";
import ConectaProveedores_c_ProveedorController$default from "./ConectaProveedores.c_Proveedor.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Proveedor_ReportCurrentAccount_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSupplierUserByUserId$AggrRefresh: 0,
getPaymentTerms$AggrRefresh: 0,
getSapData$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getSupplierUserByUserId$AggrRefresh: [],
getPaymentTerms$AggrRefresh: [],
getSapData$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getSupplierUserByUserId$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierUserByUserId$AggrRefresh"))) {
this._getSupplierUserByUserId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierUserByUserId", "screenservices/ConectaProveedores/c_Proveedor/ReportCurrentAccount/ScreenDataSetGetSupplierUserByUserId", "ZHm6glvv3a4RocMm8iuhpQ", maxRecords, startIndex, function (b) {
model.variables.getSupplierUserByUserIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierUserByUserIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierUserByUserIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSupplierUserByUserIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierUserByUserId", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUserByUserId");
span.setAttribute("outsystems.function.key", "7c17d2d6-48d2-4736-a7f3-cc8071db6ab6");
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

return this._getSupplierUserByUserId$AggrRefresh;
}set getSupplierUserByUserId$AggrRefresh(value) {this._getSupplierUserByUserId$AggrRefresh = value;
}

get getPaymentTerms$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentTerms$AggrRefresh"))) {
this._getPaymentTerms$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentTerms", "screenservices/ConectaProveedores/c_Proveedor/ReportCurrentAccount/ScreenDataSetGetPaymentTerms", "+6OhqwjTKpS9lXyr02rGqw", maxRecords, startIndex, function (b) {
model.variables.getPaymentTermsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTerms", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTerms");
span.setAttribute("outsystems.function.key", "e4416ea3-ba8a-4a17-9885-c37ecd82002a");
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

return this._getPaymentTerms$AggrRefresh;
}set getPaymentTerms$AggrRefresh(value) {this._getPaymentTerms$AggrRefresh = value;
}

get getSapData$DataActRefresh() {if(!(this.hasOwnProperty("_getSapData$DataActRefresh"))) {
this._getSapData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSapData", "screenservices/ConectaProveedores/c_Proveedor/ReportCurrentAccount/DataActionGetSapData", "f4Ax0UdABchGTjINnLPsng", function (b) {
model.variables.getSapDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSapDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSapDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSapDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSapData", function (span) {
if(span) {
span.setAttribute("code.function", "GetSapData");
span.setAttribute("outsystems.function.key", "a52c9622-f23f-450d-bdf5-6b44b62155b3");
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

return this._getSapData$DataActRefresh;
}set getSapData$DataActRefresh(value) {this._getSapData$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSupplierUserByUserId$AggrRefresh", "getPaymentTerms$AggrRefresh", "getSapData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "6a5ce4b6-9875-42ff-b237-dcac983c2cc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
try {// Execute Action: SetCurrentLocale
OS$SystemActions.setCurrentLocale("es-MX", callContext);
} catch (ex) {
(function () {
OS$Logger.debug("ReportCurrentAccount.OnInitialize", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "1eef2c21-8a29-4a0b-8b22-86122547ba3b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {return ;

} finally {
if(span) {
span.end();
}

}

}, 1);
}

throw ex;
})();
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSupplierUserByUserIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierUserByUserIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUserByUserIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "df9cbf89-9f18-4b7f-9116-c475975a5ae0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSupplierUserByUserIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSapData
var result = controller.getSapData$DataActRefresh(callContext);
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
_getSapDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSapDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSapDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "ef4a57dc-c83e-4520-a066-04afd404d080");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSapDataOnAfterFetch");
callContext = controller.callContext(callContext);
var listDistinctVar = new OS$DataTypes.VariableHolder();
// Foreach GetSapData.List.T_FAC_PAG_CAB_Out
callContext.iterationContext.registerIterationStart(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr);
try {var t_FAC_PAG_CAB_OutIterator = callContext.iterationContext.getIterator(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr);
var t_FAC_PAG_CAB_OutIndex = 0;
while (((t_FAC_PAG_CAB_OutIndex < model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr.length))) {
t_FAC_PAG_CAB_OutIterator.currentRowNumber = t_FAC_PAG_CAB_OutIndex;
// Set Zero
// GetSapData.List.T_FAC_PAG_CAB_Out.Current.KURSF = 0
model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr.getItem(t_FAC_PAG_CAB_OutIndex.valueOf()).kURSFAttr = OS$BuiltinFunctions.integerToDecimal(0);
t_FAC_PAG_CAB_OutIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr);
}

// Execute Action: ListDistinct
listDistinctVar.value = OS$SystemActions.listDistinct(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr, callContext);

// GetSapData.List.T_FAC_PAG_CAB_Out = ListDistinct.DistinctList
model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr = listDistinctVar.value.distinctListOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "6a5ce4b6-9875-42ff-b237-dcac983c2cc4");
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

getSupplierUserByUserIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierUserByUserIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUserByUserIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "df9cbf89-9f18-4b7f-9116-c475975a5ae0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSupplierUserByUserIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getSapDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSapDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSapDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "ef4a57dc-c83e-4520-a066-04afd404d080");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSapDataOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

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
return ConectaProveedores_c_ProveedorController$default.handleError(ex, this.callContext());
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

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


