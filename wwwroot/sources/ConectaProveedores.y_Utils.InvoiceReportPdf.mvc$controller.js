import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Utils_InvoiceReportPdf_mvc_controller_OnInitialize_JavaScript1JS from "./ConectaProveedores.y_Utils.InvoiceReportPdf.mvc$controller.OnInitialize.JavaScript1JS.js";
import ConectaProveedores_y_Utils_InvoiceReportPdf_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.InvoiceReportPdf.mvc$translationsResources.js";
import ConectaProveedores_y_UtilsController$default from "./ConectaProveedores.y_Utils.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_InvoiceReportPdf_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getMainData$DataActRefresh: 0,
getTableItems$DataActRefresh: -1,
getInvoiceFiles$DataActRefresh: 0,
getEletronicAuthorizations$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getMainData$DataActRefresh: ["getTableItems$DataActRefresh", "getEletronicAuthorizations$DataActRefresh"],
getTableItems$DataActRefresh: [],
getInvoiceFiles$DataActRefresh: [],
getEletronicAuthorizations$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getMainData$DataActRefresh() {if(!(this.hasOwnProperty("_getMainData$DataActRefresh"))) {
this._getMainData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetMainData", "screenservices/ConectaProveedores/y_Utils/InvoiceReportPdf/DataActionGetMainData", "wdrABS+mipJ5C2BZQAeXqw", function (b) {
model.variables.getMainDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getMainDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getMainDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getMainDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetMainData", function (span) {
if(span) {
span.setAttribute("code.function", "GetMainData");
span.setAttribute("outsystems.function.key", "8df569d4-43a4-4226-93ed-831fbb2a3b89");
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

return this._getMainData$DataActRefresh;
}set getMainData$DataActRefresh(value) {this._getMainData$DataActRefresh = value;
}

get getTableItems$DataActRefresh() {if(!(this.hasOwnProperty("_getTableItems$DataActRefresh"))) {
this._getTableItems$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetTableItems", "screenservices/ConectaProveedores/y_Utils/InvoiceReportPdf/DataActionGetTableItems", "ZV7seOXCsRXozCzAyqUR1w", function (b) {
model.variables.getTableItemsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getTableItemsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getTableItemsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetTableItems", function (span) {
if(span) {
span.setAttribute("code.function", "GetTableItems");
span.setAttribute("outsystems.function.key", "a602e3fc-47d6-4525-8f74-cba4fcfc7ae8");
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

return this._getTableItems$DataActRefresh;
}set getTableItems$DataActRefresh(value) {this._getTableItems$DataActRefresh = value;
}

get getInvoiceFiles$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoiceFiles$DataActRefresh"))) {
this._getInvoiceFiles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoiceFiles", "screenservices/ConectaProveedores/y_Utils/InvoiceReportPdf/DataActionGetInvoiceFiles", "YF75rIJ5X8CRGYI1Os94XA", function (b) {
model.variables.getInvoiceFilesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFiles");
span.setAttribute("outsystems.function.key", "bd3bc710-2bc2-49ce-aa5e-76707c50d8ba");
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

get getEletronicAuthorizations$DataActRefresh() {if(!(this.hasOwnProperty("_getEletronicAuthorizations$DataActRefresh"))) {
this._getEletronicAuthorizations$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetEletronicAuthorizations", "screenservices/ConectaProveedores/y_Utils/InvoiceReportPdf/DataActionGetEletronicAuthorizations", "63B7_VnhJPkSpVmNiS3ajw", function (b) {
model.variables.getEletronicAuthorizationsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEletronicAuthorizationsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getEletronicAuthorizationsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetEletronicAuthorizations", function (span) {
if(span) {
span.setAttribute("code.function", "GetEletronicAuthorizations");
span.setAttribute("outsystems.function.key", "ffd996c4-e1e0-49c4-aef5-82d3e5fbc67c");
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

return this._getEletronicAuthorizations$DataActRefresh;
}set getEletronicAuthorizations$DataActRefresh(value) {this._getEletronicAuthorizations$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getMainData$DataActRefresh", "getTableItems$DataActRefresh", "getInvoiceFiles$DataActRefresh", "getEletronicAuthorizations$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "5e8ffa30-a04c-4fc1-93d7-9e19fa1d55bb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var javaScript1JSResult = new OS$DataTypes.VariableHolder();
try {javaScript1JSResult.value = OS$Logger.startActiveSpan("JavaScript1", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript1");
span.setAttribute("outsystems.function.key", "c698db43-dad7-49bc-8c2b-eb19831b56a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_InvoiceReportPdf_mvc_controller_OnInitialize_JavaScript1JS, "JavaScript1", "OnInitialize", {
Offset: OS$DataConversion.JSNodeParamConverter.to(0, OS$DataTypes.DataTypes.Integer)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.InvoiceReportPdf.OnInitialize$javaScript1JSResult"))();
jsNodeResult.offsetOut = OS$DataConversion.JSNodeParamConverter.from($parameters.Offset, OS$DataTypes.DataTypes.Integer);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Offset = JavaScript1.Offset
model.variables.offsetVar = javaScript1JSResult.value.offsetOut;
// Execute Action: SetCurrentLocale
OS$SystemActions.setCurrentLocale("es-MX", callContext);
} catch (ex) {
(function () {
OS$Logger.debug("InvoiceReportPdf.OnInitialize", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "32dd7ab1-b539-48b8-8d63-0996b0da71b0");
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
_getMainDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetMainDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetMainDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "666a5a5e-3ffd-4818-881e-4d053ee51081");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetMainDataOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetTableItems
var result = controller.getTableItems$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetEletronicAuthorizations
var result = controller.getEletronicAuthorizations$DataActRefresh(callContext);
model.flush();
return result;
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "5e8ffa30-a04c-4fc1-93d7-9e19fa1d55bb");
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

getMainDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetMainDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetMainDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "666a5a5e-3ffd-4818-881e-4d053ee51081");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getMainDataOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
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
return ConectaProveedores_y_UtilsController$default.handleError(ex, this.callContext());
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
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.InvoiceReportPdf.OnInitialize$javaScript1JSResult", [{
name: "Offset",
attrName: "offsetOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


