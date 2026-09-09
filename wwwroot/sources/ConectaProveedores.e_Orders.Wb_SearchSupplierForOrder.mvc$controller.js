import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, GenericTypeCache as OS$GenericTypeCache, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import { dropdownSetValue$Action as OutSystemsUIController$dropdownSetValue$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSupplierById$AggrRefresh: -1,
getOrderById$AggrRefresh: 0,
getSuppliers$AggrRefresh: -1
};
this.dataFetchDependentsGraph = {
getSupplierById$AggrRefresh: [],
getOrderById$AggrRefresh: ["getSuppliers$AggrRefresh"],
getSuppliers$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getSupplierById$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierById$AggrRefresh"))) {
this._getSupplierById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierById", "screenservices/ConectaProveedores/e_Orders/Wb_SearchSupplierForOrder/ScreenDataSetGetSupplierById", "X9jcz5zHtrsjdT5MlBoFSA", maxRecords, startIndex, function (b) {
model.variables.getSupplierByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSupplierByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierById", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierById");
span.setAttribute("outsystems.function.key", "3a20f39c-e5d7-44ef-8e2e-5e50a1a7098c");
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

return this._getSupplierById$AggrRefresh;
}set getSupplierById$AggrRefresh(value) {this._getSupplierById$AggrRefresh = value;
}

get getOrderById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderById$AggrRefresh"))) {
this._getOrderById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderById", "screenservices/ConectaProveedores/e_Orders/Wb_SearchSupplierForOrder/ScreenDataSetGetOrderById", "Ut3IZN7sg94QxjJoYRj6WQ", maxRecords, startIndex, function (b) {
model.variables.getOrderByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRegionsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderById");
span.setAttribute("outsystems.function.key", "9d83204f-3178-4eba-8013-df8c85c272e1");
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

return this._getOrderById$AggrRefresh;
}set getOrderById$AggrRefresh(value) {this._getOrderById$AggrRefresh = value;
}

get getSuppliers$AggrRefresh() {if(!(this.hasOwnProperty("_getSuppliers$AggrRefresh"))) {
this._getSuppliers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSuppliers", "screenservices/ConectaProveedores/e_Orders/Wb_SearchSupplierForOrder/ScreenDataSetGetSuppliers", "MarLzvC0Ak57cuL9zvu4SQ", maxRecords, startIndex, function (b) {
model.variables.getSuppliersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSuppliersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSuppliersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "GetSuppliers");
span.setAttribute("outsystems.function.key", "a66015f9-f443-471e-9516-bf39de0380ee");
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

return this._getSuppliers$AggrRefresh;
}set getSuppliers$AggrRefresh(value) {this._getSuppliers$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSupplierById$AggrRefresh", "getOrderById$AggrRefresh", "getSuppliers$AggrRefresh"];
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
span.setAttribute("outsystems.function.key", "6f0331c9-62e5-4eb1-939b-3e6c3f02f45a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var dropdownSetValueVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderById
var result = controller.getOrderById$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
return OS$Flow.executeSequence(function () {
if((!(true))) {
// Refresh Query: GetSupplierById
var result = controller.getSupplierById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}

});
}).then(function () {
// Execute Action: DropdownSetValue
dropdownSetValueVar.value = OutSystemsUIController$dropdownSetValue$Action(idService.getId("SuppierSearch"), function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.supplierIdIn);
rec.labelAttr = "";
return rec;
}()]);
return list;
}(), true, callContext);

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
_useThisSupplierOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UseThisSupplierOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "UseThisSupplierOnClick");
span.setAttribute("outsystems.function.key", "7a81e97c-5437-4b4e-8739-98c587ef4fac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UseThisSupplierOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: SendSupplierID
return controller.event$Action(model.variables.supplierIdIn, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_getRegionsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRegionsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "a1364e2e-b59d-4281-b1fd-499d1e527133");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRegionsOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSupplierById
var result = controller.getSupplierById$AggrRefresh(1, 0, callContext);
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
_getSupplierByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "de7ee1f1-63ed-4627-826e-f0222065df6b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSupplierByIdOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getOrderByIdAggr.listOut, function (p) {
return (p.regionAttr.divisionFIAttr === OS$BuiltinFunctions.substr(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.tratamientoAttr, 0, 4));
}, callContext);

// GetSupplierById.List.Current.Supplier.Region_ = If
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr = (((!(listFilterVar.value.filteredListOut.isEmpty))) ? (listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr) : (model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.tratamientoAttr));
return OS$Flow.executeSequence(function () {
if((model.variables.isEnabledIn)) {
// Refresh Query: GetSuppliers
var result = controller.getSuppliers$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
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
_dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "f62090f6-f7ca-4632-87c2-e406837033e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.DropdownSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// SupplierId = IntegerToIdentifier
model.variables.supplierIdIn = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
// Refresh Query: GetSupplierById
var result = controller.getSupplierById$AggrRefresh(1, 0, callContext);
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "6f0331c9-62e5-4eb1-939b-3e6c3f02f45a");
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

useThisSupplierOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UseThisSupplierOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UseThisSupplierOnClick");
span.setAttribute("outsystems.function.key", "7a81e97c-5437-4b4e-8739-98c587ef4fac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._useThisSupplierOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getRegionsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRegionsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "a1364e2e-b59d-4281-b1fd-499d1e527133");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRegionsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getSupplierByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "de7ee1f1-63ed-4627-826e-f0222065df6b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSupplierByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "f62090f6-f7ca-4632-87c2-e406837033e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get event$Action() {if(!(this.hasOwnProperty("_event$Action"))) {
this._event$Action = function () {
return Promise.resolve();
};
}

return this._event$Action;
}set event$Action(value) {this._event$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.DropdownSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


