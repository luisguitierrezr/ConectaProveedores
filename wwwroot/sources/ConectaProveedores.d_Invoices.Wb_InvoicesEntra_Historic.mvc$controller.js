import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_34625f5643caa3d12448dcec7dd4c7d3Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices.Wb_InvoicesEntra_Historic.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoicesApprovalLevels$AggrRefresh: -1,
getInvoiceById$AggrRefresh: 0,
getEntraUserManagerList$DataActRefresh: -1,
getSpecialApprovalLevels$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getInvoicesApprovalLevels$AggrRefresh: ["getEntraUserManagerList$DataActRefresh"],
getInvoiceById$AggrRefresh: ["getInvoicesApprovalLevels$AggrRefresh", "getSpecialApprovalLevels$DataActRefresh"],
getEntraUserManagerList$DataActRefresh: [],
getSpecialApprovalLevels$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getInvoicesApprovalLevels$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesApprovalLevels$AggrRefresh"))) {
this._getInvoicesApprovalLevels$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesApprovalLevels", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoicesEntra_Historic/ScreenDataSetGetInvoicesApprovalLevels", "u+3GMQG4zHJSIWVQz44aLw", maxRecords, startIndex, function (b) {
model.variables.getInvoicesApprovalLevelsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesApprovalLevelsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesApprovalLevelsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoicesApprovalLevelsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesApprovalLevels", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesApprovalLevels");
span.setAttribute("outsystems.function.key", "190999a4-fb90-4191-9e2e-63436fcbe5ce");
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

return this._getInvoicesApprovalLevels$AggrRefresh;
}set getInvoicesApprovalLevels$AggrRefresh(value) {this._getInvoicesApprovalLevels$AggrRefresh = value;
}

get getInvoiceById$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceById$AggrRefresh"))) {
this._getInvoiceById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceById", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoicesEntra_Historic/ScreenDataSetGetInvoiceById", "nvgwwRhRZsQ5ac8MoJC+Zg", maxRecords, startIndex, function (b) {
model.variables.getInvoiceByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoiceByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceById", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceById");
span.setAttribute("outsystems.function.key", "54789b8f-c6be-431d-84e8-ec03a4c0dcdf");
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

return this._getInvoiceById$AggrRefresh;
}set getInvoiceById$AggrRefresh(value) {this._getInvoiceById$AggrRefresh = value;
}

get getEntraUserManagerList$DataActRefresh() {if(!(this.hasOwnProperty("_getEntraUserManagerList$DataActRefresh"))) {
this._getEntraUserManagerList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetEntraUserManagerList", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoicesEntra_Historic/DataActionGetEntraUserManagerList", "Bv69ti44rzc1f5xg1+PCbg", function (b) {
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
span.setAttribute("outsystems.function.key", "8c38576b-2afd-4a4e-b796-253b6d538a3c");
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

get getSpecialApprovalLevels$DataActRefresh() {if(!(this.hasOwnProperty("_getSpecialApprovalLevels$DataActRefresh"))) {
this._getSpecialApprovalLevels$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSpecialApprovalLevels", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoicesEntra_Historic/DataActionGetSpecialApprovalLevels", "KDobedCAcuKOY8GkVJNPLA", function (b) {
model.variables.getSpecialApprovalLevelsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialApprovalLevelsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialApprovalLevelsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSpecialApprovalLevelsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialApprovalLevels", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovalLevels");
span.setAttribute("outsystems.function.key", "dfe8f0fe-3621-4fa4-b660-fd5118e960b0");
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

return this._getSpecialApprovalLevels$DataActRefresh;
}set getSpecialApprovalLevels$DataActRefresh(value) {this._getSpecialApprovalLevels$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoicesApprovalLevels$AggrRefresh", "getInvoiceById$AggrRefresh", "getEntraUserManagerList$DataActRefresh", "getSpecialApprovalLevels$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "5713c67b-5853-4c6f-ab39-e4b463dbed82");
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
// Refresh Query: GetInvoiceById
var result = controller.getInvoiceById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoicesApprovalLevels
var result = controller.getInvoicesApprovalLevels$AggrRefresh(999999999, 0, callContext);
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
_getEntraUserManagerListOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetEntraUserManagerListOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraUserManagerListOnAfterFetch");
span.setAttribute("outsystems.function.key", "7ed17c3c-93d7-4468-bdee-4d8782438fe2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetEntraUserManagerListOnAfterFetch");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.listVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.listVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoicesApprovalLevelsAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))(), function (source, target) {
target.nameAttr = source.user_AssignedToAttr.nameAttr;
target.roleAttr = ((((source.applicationRoleAttr.nameAttr) !== (""))) ? (source.applicationRoleAttr.nameAttr) : (source.invoiceApprovalLevelAttr.entraJobTitleAttr));
target.cancelMessageAttr = source.invoiceComment_CancelAttr.messageAttr;
target.approvalStatusIdAttr = source.invoiceApprovalLevelAttr.approvalStatusIdAttr;
target.modifyMessageAttr = source.invoiceComment_ModifyAttr.messageAttr;
target.isReassignedAttr = source.invoiceApprovalLevelAttr.isReassignedAttr;
return target;
}), callContext);
// Execute Action: ListAppendAll2
OS$SystemActions.listAppendAll(model.variables.listVar, model.variables.getEntraUserManagerListDataAct.userListOut, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getInvoiceByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "807e063e-f885-4c66-ba7e-8f3837c8a6bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoiceByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsSpecial workflow?
return OS$Flow.executeSequence(function () {
if((model.variables.getInvoiceByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.isSpecialAttr)) {
// Refresh Query: GetSpecialApprovalLevels
var result = controller.getSpecialApprovalLevels$DataActRefresh(callContext);
model.flush();
return result;
} else {
// Refresh Query: GetInvoicesApprovalLevels
var result = controller.getInvoicesApprovalLevels$AggrRefresh(999999999, 0, callContext);
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
_getSpecialApprovalLevelsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSpecialApprovalLevelsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "b1acd5db-6e09-44f9-9efa-0b6d36c788cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSpecialApprovalLevelsOnAfterFetch");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.listVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.listVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getSpecialApprovalLevelsDataAct.approvalListOut, new (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))(), function (source, target) {
target.nameAttr = source.nameAttr;
target.roleAttr = ((((source.applicationRoleAttr) !== (""))) ? (source.applicationRoleAttr) : (source.combinedJobTitlesAttr));
target.approvalStatusIdAttr = source.approvalStatusIdAttr;
target.isReassignedAttr = source.isReassignedAttr;
target.isSubstituteAttr = ((source.isSubstituteForAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()));
return target;
}), callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getInvoicesApprovalLevelsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesApprovalLevelsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "d7b1135a-e608-4730-aa9a-a52f5dd55583");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoicesApprovalLevelsOnAfterFetch");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "5713c67b-5853-4c6f-ab39-e4b463dbed82");
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

getEntraUserManagerListOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetEntraUserManagerListOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraUserManagerListOnAfterFetch");
span.setAttribute("outsystems.function.key", "7ed17c3c-93d7-4468-bdee-4d8782438fe2");
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

getInvoiceByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "807e063e-f885-4c66-ba7e-8f3837c8a6bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoiceByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getSpecialApprovalLevelsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSpecialApprovalLevelsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "b1acd5db-6e09-44f9-9efa-0b6d36c788cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSpecialApprovalLevelsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getInvoicesApprovalLevelsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesApprovalLevelsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "d7b1135a-e608-4730-aa9a-a52f5dd55583");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoicesApprovalLevelsOnAfterFetch$Action, callContext);
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


