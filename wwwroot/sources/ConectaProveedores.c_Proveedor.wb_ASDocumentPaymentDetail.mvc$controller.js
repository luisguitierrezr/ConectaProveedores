import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, Logger as OS$Logger, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvc_TranslationsResources from "./ConectaProveedores.c_Proveedor.wb_ASDocumentPaymentDetail.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_find$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Find", function (span) {
if(span) {
span.setAttribute("code.function", "Find");
span.setAttribute("outsystems.function.key", "10b42d40-2aae-4546-ad65-9ef844ab6093");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Find");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
if(((model.variables.l_KeywordVar === ""))) {
// L_T_FAC_PAG = L_T_FAC_PAGOriginal
model.variables.l_T_FAC_PAGVar = model.variables.l_T_FAC_PAGOriginalVar;
} else {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.l_T_FAC_PAGOriginalVar, function (p) {
return ((p.xBLNRAttr === model.variables.l_KeywordVar) || (p.aUGBLAttr === model.variables.l_KeywordVar));
}, callContext);

// L_T_FAC_PAG = ListFilter.FilteredList
model.variables.l_T_FAC_PAGVar = listFilterVar.value.filteredListOut;
}

// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "ab6bc8f9-4929-4ddf-a690-1ce137956a0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
var listDistinctVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListSort
OS$SystemActions.listSort(model.variables.i_T_FAC_PAGIn, function (p) {
return p.aUGBLAttr;
}, true, callContext);
// Execute Action: ListDistinct
listDistinctVar.value = OS$SystemActions.listDistinct(model.variables.i_T_FAC_PAGIn, callContext);

// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.l_T_FAC_PAGVar, listDistinctVar.value.distinctListOut, callContext);
// Foreach L_T_FAC_PAG
callContext.iterationContext.registerIterationStart(model.variables.l_T_FAC_PAGVar);
try {var l_T_FAC_PAGIterator = callContext.iterationContext.getIterator(model.variables.l_T_FAC_PAGVar);
var l_T_FAC_PAGIndex = 0;
while (((l_T_FAC_PAGIndex < model.variables.l_T_FAC_PAGVar.length))) {
l_T_FAC_PAGIterator.currentRowNumber = l_T_FAC_PAGIndex;
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.i_PaymentTermsIn, function (p) {
return (OS$BuiltinFunctions.trim(p.estructuraDescripcionPROPAttr) === OS$BuiltinFunctions.trim(model.variables.l_T_FAC_PAGVar.getItem(l_T_FAC_PAGIndex.valueOf()).zTERMAttr));
}, callContext);

// L_T_FAC_PAG.Current.ZTERM = If
model.variables.l_T_FAC_PAGVar.getItem(l_T_FAC_PAGIndex.valueOf()).zTERMAttr = ((listFilterVar.value.filteredListOut.isEmpty) ? (model.variables.l_T_FAC_PAGVar.getItem(l_T_FAC_PAGIndex.valueOf()).zTERMAttr) : (listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).descriptionAttr));
l_T_FAC_PAGIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.l_T_FAC_PAGVar);
}

// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.i_T_FAC_PAGIn, callContext);
// Set Original
// L_T_FAC_PAGOriginal = L_T_FAC_PAG
model.variables.l_T_FAC_PAGOriginalVar = model.variables.l_T_FAC_PAGVar;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

find$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Find__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Find");
span.setAttribute("outsystems.function.key", "10b42d40-2aae-4546-ad65-9ef844ab6093");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._find$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "ab6bc8f9-4929-4ddf-a690-1ce137956a0c");
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

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


