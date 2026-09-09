import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.WB_OrderFinancialFiles.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getOrderAccountingsByOrderId$AggrRefresh: 0,
getOrderFileById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getOrderAccountingsByOrderId$AggrRefresh: [],
getOrderFileById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getOrderAccountingsByOrderId$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderAccountingsByOrderId$AggrRefresh"))) {
this._getOrderAccountingsByOrderId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderAccountingsByOrderId", "screenservices/ConectaProveedores/e_Orders/WB_OrderFinancialFiles/ScreenDataSetGetOrderAccountingsByOrderId", "Y4dCtZ1tnp3zYmUR2wf4nw", maxRecords, startIndex, function (b) {
model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderAccountingsByOrderIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderAccountingsByOrderIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderAccountingsByOrderId", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderAccountingsByOrderId");
span.setAttribute("outsystems.function.key", "dd9cace4-4ef9-49e0-9f5e-cd66380c3323");
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

return this._getOrderAccountingsByOrderId$AggrRefresh;
}set getOrderAccountingsByOrderId$AggrRefresh(value) {this._getOrderAccountingsByOrderId$AggrRefresh = value;
}

get getOrderFileById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderFileById$AggrRefresh"))) {
this._getOrderFileById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderFileById", "screenservices/ConectaProveedores/e_Orders/WB_OrderFinancialFiles/ScreenDataSetGetOrderFileById", "I1lgGjcQaZOTtHAsQXqxcw", maxRecords, startIndex, function (b) {
model.variables.getOrderFileByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderFileByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderFileByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderFileById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderFileById");
span.setAttribute("outsystems.function.key", "dfcac784-e421-42a3-b4b4-a51d0fe59562");
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

return this._getOrderFileById$AggrRefresh;
}set getOrderFileById$AggrRefresh(value) {this._getOrderFileById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getOrderAccountingsByOrderId$AggrRefresh", "getOrderFileById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_refresh$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Refresh", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "002d9833-4216-4b53-b9eb-5a1901aaa38b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Refresh");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ClosePopup
controller._closePopup$Action(callContext);
// Refresh Query: GetOrderAccountingsByOrderId
var result = controller.getOrderAccountingsByOrderId$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetOrderFileById
var result = controller.getOrderFileById$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: RefreshEvent
return controller.refreshEvent$Action(callContext);
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
_openPopupFinancial$Action(i_OrderAccConceptsIdIn, i_OrderRequestFileIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenPopupFinancial", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopupFinancial");
span.setAttribute("outsystems.function.key", "341bb8f0-7e77-4d8a-85a1-0e20c9f9ce85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenPopupFinancial");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.WB_OrderFinancialFiles.OpenPopupFinancial$vars"))());
vars.value.i_OrderAccConceptsIdInLocal = i_OrderAccConceptsIdIn;
vars.value.i_OrderRequestFileIdInLocal = i_OrderRequestFileIdIn;
// l_OrderAccConceptsId = i_OrderAccConceptsId
model.variables.l_OrderAccConceptsIdVar = vars.value.i_OrderAccConceptsIdInLocal;
// l_AccountingDataTypeId = GetOrderAccountingsByOrderId.List.Current.OrderAccConcepts.AccountingDataTypeId
model.variables.l_AccountingDataTypeIdVar = model.variables.getOrderAccountingsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderAccConceptsAttr.accountingDataTypeIdAttr;
// l_OrderContractFile = NullIdentifier
model.variables.l_OrderContractFileVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_OrderRequestFileIdSelected = i_OrderRequestFileId
model.variables.l_OrderRequestFileIdSelectedVar = vars.value.i_OrderRequestFileIdInLocal;
// l_ShowPopupFinancial = True
model.variables.l_ShowPopupFinancialVar = true;
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
span.setAttribute("outsystems.function.key", "b7526fac-f658-4728-937f-eb1f3b12bd89");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderAccountingsByOrderId
var result = controller.getOrderAccountingsByOrderId$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetOrderFileById
var result = controller.getOrderFileById$AggrRefresh(50, 0, callContext);
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
_closePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClosePopup", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePopup");
span.setAttribute("outsystems.function.key", "c19097e8-d51d-469e-a8c9-075455f4a634");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClosePopup");
callContext = controller.callContext(callContext);
// l_ShowPopupFinancial = False
model.variables.l_ShowPopupFinancialVar = false;
// l_ShowContractPopup = False
model.variables.l_ShowContractPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openPopupContract$Action(i_OrderContractFileIn, i_OrderRequestFileIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenPopupContract", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopupContract");
span.setAttribute("outsystems.function.key", "e28ed865-f32f-47c4-ab51-058a368ec120");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenPopupContract");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.WB_OrderFinancialFiles.OpenPopupContract$vars"))());
vars.value.i_OrderContractFileInLocal = i_OrderContractFileIn;
vars.value.i_OrderRequestFileIdInLocal = i_OrderRequestFileIdIn;
// l_OrderContractFile = i_OrderContractFile
model.variables.l_OrderContractFileVar = vars.value.i_OrderContractFileInLocal;
// l_OrderAccConceptsId = NullIdentifier
model.variables.l_OrderAccConceptsIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_AccountingDataTypeId = NullIdentifier
model.variables.l_AccountingDataTypeIdVar = OS$BuiltinFunctions.nullIdentifier();
// l_OrderRequestFileIdSelected = i_OrderRequestFileId
model.variables.l_OrderRequestFileIdSelectedVar = vars.value.i_OrderRequestFileIdInLocal;
// l_ShowContractPopup = True
model.variables.l_ShowContractPopupVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

refresh$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Refresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "002d9833-4216-4b53-b9eb-5a1901aaa38b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refresh$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

openPopupFinancial$Action(i_OrderAccConceptsIdIn, i_OrderRequestFileIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenPopupFinancial__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopupFinancial");
span.setAttribute("outsystems.function.key", "341bb8f0-7e77-4d8a-85a1-0e20c9f9ce85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openPopupFinancial$Action, callContext, i_OrderAccConceptsIdIn, i_OrderRequestFileIdIn);
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
span.setAttribute("outsystems.function.key", "b7526fac-f658-4728-937f-eb1f3b12bd89");
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

closePopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClosePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePopup");
span.setAttribute("outsystems.function.key", "c19097e8-d51d-469e-a8c9-075455f4a634");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closePopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openPopupContract$Action(i_OrderContractFileIn, i_OrderRequestFileIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenPopupContract__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopupContract");
span.setAttribute("outsystems.function.key", "e28ed865-f32f-47c4-ab51-058a368ec120");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openPopupContract$Action, callContext, i_OrderContractFileIn, i_OrderRequestFileIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get refreshEvent$Action() {if(!(this.hasOwnProperty("_refreshEvent$Action"))) {
this._refreshEvent$Action = function () {
return Promise.resolve();
};
}

return this._refreshEvent$Action;
}set refreshEvent$Action(value) {this._refreshEvent$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.WB_OrderFinancialFiles.OpenPopupFinancial$vars", [{
name: "i_OrderAccConceptsId",
attrName: "i_OrderAccConceptsIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_OrderRequestFileId",
attrName: "i_OrderRequestFileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.WB_OrderFinancialFiles.OpenPopupContract$vars", [{
name: "i_OrderContractFile",
attrName: "i_OrderContractFileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_OrderRequestFileId",
attrName: "i_OrderRequestFileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


