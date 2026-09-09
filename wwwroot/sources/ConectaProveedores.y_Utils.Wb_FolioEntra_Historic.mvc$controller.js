import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.Wb_FolioEntra_Historic.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getOrderMainById$AggrRefresh: 0,
getOrderMainApprovalLevels$AggrRefresh: 1,
getEntraUserManagerList$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getOrderMainById$AggrRefresh: ["getOrderMainApprovalLevels$AggrRefresh"],
getOrderMainApprovalLevels$AggrRefresh: ["getEntraUserManagerList$DataActRefresh"],
getEntraUserManagerList$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getOrderMainById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainById$AggrRefresh"))) {
this._getOrderMainById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainById", "screenservices/ConectaProveedores/y_Utils/Wb_FolioEntra_Historic/ScreenDataSetGetOrderMainById", "KywQen9CHYIRvv60scYolw", maxRecords, startIndex, function (b) {
model.variables.getOrderMainByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainById");
span.setAttribute("outsystems.function.key", "916cf9db-d5d3-4c63-8fd3-ccbe4d10989f");
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

return this._getOrderMainById$AggrRefresh;
}set getOrderMainById$AggrRefresh(value) {this._getOrderMainById$AggrRefresh = value;
}

get getOrderMainApprovalLevels$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainApprovalLevels$AggrRefresh"))) {
this._getOrderMainApprovalLevels$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainApprovalLevels", "screenservices/ConectaProveedores/y_Utils/Wb_FolioEntra_Historic/ScreenDataSetGetOrderMainApprovalLevels", "eNSja1n6Bswwml8yz9TcWQ", maxRecords, startIndex, function (b) {
model.variables.getOrderMainApprovalLevelsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainApprovalLevelsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainApprovalLevelsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionsApprovalLevelsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainApprovalLevels", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainApprovalLevels");
span.setAttribute("outsystems.function.key", "f68d945a-2f2f-4b1e-8112-f675efdfaec7");
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

return this._getOrderMainApprovalLevels$AggrRefresh;
}set getOrderMainApprovalLevels$AggrRefresh(value) {this._getOrderMainApprovalLevels$AggrRefresh = value;
}

get getEntraUserManagerList$DataActRefresh() {if(!(this.hasOwnProperty("_getEntraUserManagerList$DataActRefresh"))) {
this._getEntraUserManagerList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetEntraUserManagerList", "screenservices/ConectaProveedores/y_Utils/Wb_FolioEntra_Historic/DataActionGetEntraUserManagerList", "Bv69ti44rzc1f5xg1+PCbg", function (b) {
model.variables.getEntraUserManagerListDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEntraUserManagerListDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getEntraUserManagerListDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getEntraUserManagerListOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetEntraUserManagerList", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraUserManagerList");
span.setAttribute("outsystems.function.key", "df9b2f92-25ca-4d17-8066-f3c9a4db6e6b");
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

return this._getEntraUserManagerList$DataActRefresh;
}set getEntraUserManagerList$DataActRefresh(value) {this._getEntraUserManagerList$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getOrderMainById$AggrRefresh", "getOrderMainApprovalLevels$AggrRefresh", "getEntraUserManagerList$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getRequisitionsApprovalLevelsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionsApprovalLevelsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "062ff47d-aee0-48b5-8957-3b79d765911c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRequisitionsApprovalLevelsOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetEntraUserManagerList
var result = controller.getEntraUserManagerList$DataActRefresh(callContext);
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
_getEntraUserManagerListOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetEntraUserManagerListOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraUserManagerListOnAfterFetch");
span.setAttribute("outsystems.function.key", "5ba69139-7cef-42ef-9db4-b582f1c84cf7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetEntraUserManagerListOnAfterFetch");
callContext = controller.callContext(callContext);
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
span.setAttribute("outsystems.function.key", "eccb7dfb-b1ff-4a8c-9d6a-ccd51fa5de6f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// i_RefreshWB = i_RefreshWB
model.variables.i_RefreshWBIn = model.variables.i_RefreshWBIn;
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.listVar, callContext);
// Refresh Query: GetOrderMainById
var result = controller.getOrderMainById$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetOrderMainApprovalLevels
var result = controller.getOrderMainApprovalLevels$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}).then(function () {
// False
return OS$Flow.executeSequence(function () {
if((false)) {
// Refresh Query: GetEntraUserManagerList
var result = controller.getEntraUserManagerList$DataActRefresh(callContext);
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

getRequisitionsApprovalLevelsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionsApprovalLevelsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "062ff47d-aee0-48b5-8957-3b79d765911c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRequisitionsApprovalLevelsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getEntraUserManagerListOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetEntraUserManagerListOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraUserManagerListOnAfterFetch");
span.setAttribute("outsystems.function.key", "5ba69139-7cef-42ef-9db4-b582f1c84cf7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getEntraUserManagerListOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "eccb7dfb-b1ff-4a8c-9d6a-ccd51fa5de6f");
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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


