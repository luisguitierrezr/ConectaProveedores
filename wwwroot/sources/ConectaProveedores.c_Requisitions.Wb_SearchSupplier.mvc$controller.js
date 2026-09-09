import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_c_Requisitions_Wb_SearchSupplier_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_SearchSupplier.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_SearchSupplier_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRequisitionById$AggrRefresh: 0,
getSupplierById$AggrRefresh: -1
};
this.dataFetchDependentsGraph = {
getRequisitionById$AggrRefresh: [],
getSupplierById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getRequisitionById$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionById$AggrRefresh"))) {
this._getRequisitionById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionById", "screenservices/ConectaProveedores/c_Requisitions/Wb_SearchSupplier/ScreenDataSetGetRequisitionById", "ylyqbLnvmIKE9W_w7wRG9A", maxRecords, startIndex, function (b) {
model.variables.getRequisitionByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRegionsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionById", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionById");
span.setAttribute("outsystems.function.key", "45624b2b-c546-4f79-a2fa-6bb37ba9c6b6");
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

return this._getRequisitionById$AggrRefresh;
}set getRequisitionById$AggrRefresh(value) {this._getRequisitionById$AggrRefresh = value;
}

get getSupplierById$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierById$AggrRefresh"))) {
this._getSupplierById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierById", "screenservices/ConectaProveedores/c_Requisitions/Wb_SearchSupplier/ScreenDataSetGetSupplierById", "X9jcz5zHtrsjdT5MlBoFSA", maxRecords, startIndex, function (b) {
model.variables.getSupplierByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSupplierByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierById", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierById");
span.setAttribute("outsystems.function.key", "f8662750-d141-4b5d-8c7c-2ae7d47f68fb");
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


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getRequisitionById$AggrRefresh", "getSupplierById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdownSuppliersOnChanged$Action(supplierId2In, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "09928918-20ad-43c9-8030-5368a58fa0c9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_SearchSupplier.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierId2InLocal = supplierId2In;
return OS$Flow.executeAsyncFlow(function () {
// SupplierId = SupplierId2
model.variables.supplierIdIn = vars.value.supplierId2InLocal;
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
_useThisSupplierOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UseThisSupplierOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "UseThisSupplierOnClick");
span.setAttribute("outsystems.function.key", "3638d33c-aa55-43c1-a29b-134c79804b67");
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
_getSupplierByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "3d568232-1a17-4aa1-9753-be2bd73614d6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSupplierByIdOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getRequisitionByIdAggr.listOut, function (p) {
return (p.regionAttr.divisionFIAttr === OS$BuiltinFunctions.substr(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.tratamientoAttr, 0, 4));
}, callContext);

// GetSupplierById.List.Current.Supplier.Region_ = If
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr = (((!(listFilterVar.value.filteredListOut.isEmpty))) ? (listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr) : (model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.tratamientoAttr));
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "75b41ed5-4836-4136-bb9e-ce16b3207a8c");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "aeb26b25-7155-432e-8d49-49fc45a6e13a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetRequisitionById
var result = controller.getRequisitionById$AggrRefresh(50, 0, callContext);
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

dropdownSuppliersOnChanged$Action(supplierId2In, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "09928918-20ad-43c9-8030-5368a58fa0c9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSuppliersOnChanged$Action, callContext, supplierId2In);
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
span.setAttribute("outsystems.function.key", "3638d33c-aa55-43c1-a29b-134c79804b67");
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

getSupplierByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "3d568232-1a17-4aa1-9753-be2bd73614d6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSupplierByIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getRegionsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRegionsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "75b41ed5-4836-4136-bb9e-ce16b3207a8c");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "aeb26b25-7155-432e-8d49-49fc45a6e13a");
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_SearchSupplier.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId2",
attrName: "supplierId2InLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


