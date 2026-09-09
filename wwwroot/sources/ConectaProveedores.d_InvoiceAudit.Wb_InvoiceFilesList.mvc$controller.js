import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, SystemActions as OS$SystemActions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_mvc_TranslationsResources from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesList.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceFiles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceFiles$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getInvoiceFiles$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoiceFiles$DataActRefresh"))) {
this._getInvoiceFiles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoiceFiles", "screenservices/ConectaProveedores/d_InvoiceAudit/Wb_InvoiceFilesList/DataActionGetInvoiceFiles", "ddL6ibEK+y5hKgyyHgbaMw", function (b) {
model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFiles");
span.setAttribute("outsystems.function.key", "03685abf-dd64-474e-aa80-8867b9ce5360");
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

return this._getInvoiceFiles$DataActRefresh;
}set getInvoiceFiles$DataActRefresh(value) {this._getInvoiceFiles$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoiceFiles$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "0533bb3e-e4cd-42e6-a246-f954e28f29a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$DataActRefresh(callContext);
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
_checkboxTopOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckboxTopOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxTopOnClick");
span.setAttribute("outsystems.function.key", "283bd30c-1929-4494-9514-9d57c6c4b952");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckboxTopOnClick");
callContext = controller.callContext(callContext);
var listFilterSelectedVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilterSelected
listFilterSelectedVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesDataAct.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// All Equal?
if((((listFilterSelectedVar.value.filteredListOut.length === model.variables.getInvoiceFilesDataAct.listOut.length) || listFilterSelectedVar.value.filteredListOut.isEmpty))) {
// Foreach GetInvoiceFiles.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoiceFilesDataAct.listOut);
try {var listIterator = callContext.iterationContext.getIterator(model.variables.getInvoiceFilesDataAct.listOut);
var listIndex = 0;
while (((listIndex < model.variables.getInvoiceFilesDataAct.listOut.length))) {
listIterator.currentRowNumber = listIndex;
// GetInvoiceFiles.List.Current.IsSelected = notGetInvoiceFiles.List.Current.IsSelected
model.variables.getInvoiceFilesDataAct.listOut.getItem(listIndex.valueOf()).isSelectedAttr = (!(model.variables.getInvoiceFilesDataAct.listOut.getItem(listIndex.valueOf()).isSelectedAttr));
listIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoiceFilesDataAct.listOut);
}

} else {
// Foreach GetInvoiceFiles.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoiceFilesDataAct.listOut);
try {var listIterator = callContext.iterationContext.getIterator(model.variables.getInvoiceFilesDataAct.listOut);
var listIndex = 0;
while (((listIndex < model.variables.getInvoiceFilesDataAct.listOut.length))) {
listIterator.currentRowNumber = listIndex;
// GetInvoiceFiles.List.Current.IsSelected = True
model.variables.getInvoiceFilesDataAct.listOut.getItem(listIndex.valueOf()).isSelectedAttr = true;
listIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoiceFilesDataAct.listOut);
}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_DownloadFileStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "3f3a1b6a-cb78-460c-9e42-aded03b815b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadFileStart");
callContext = controller.callContext(callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
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
span.setAttribute("outsystems.function.key", "69af3647-ead1-4e15-99b8-aaa5343d5f9a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesList.OnSort$vars"))());
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
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$DataActRefresh(callContext);
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
_checkboxOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckboxOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxOnClick");
span.setAttribute("outsystems.function.key", "88508bf7-2f52-4724-a548-30954a75d574");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckboxOnClick");
callContext = controller.callContext(callContext);
var listFilterSelectedVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilterSelected
listFilterSelectedVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesDataAct.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// IsAllSelected = ListFilterSelected.FilteredList.Length = GetInvoiceFiles.List.Length
model.variables.isAllSelectedVar = (listFilterSelectedVar.value.filteredListOut.length === model.variables.getInvoiceFilesDataAct.listOut.length);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_DownloadFileEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "fba3ea16-04d1-4685-b912-779f13e9b779");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadFileEnd");
callContext = controller.callContext(callContext);
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "0533bb3e-e4cd-42e6-a246-f954e28f29a8");
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

checkboxTopOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckboxTopOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxTopOnClick");
span.setAttribute("outsystems.function.key", "283bd30c-1929-4494-9514-9d57c6c4b952");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkboxTopOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_DownloadFileStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "3f3a1b6a-cb78-460c-9e42-aded03b815b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadFileStart$Action, callContext);
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
span.setAttribute("outsystems.function.key", "69af3647-ead1-4e15-99b8-aaa5343d5f9a");
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

checkboxOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckboxOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxOnClick");
span.setAttribute("outsystems.function.key", "88508bf7-2f52-4724-a548-30954a75d574");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkboxOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_DownloadFileEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "fba3ea16-04d1-4685-b912-779f13e9b779");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadFileEnd$Action, callContext);
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesList.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


