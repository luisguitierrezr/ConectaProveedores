import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_34625f5643caa3d12448dcec7dd4c7d3Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_RequisitionEntra_Historic.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRequisitionsApprovalLevels$AggrRefresh: -1,
getRequisitionById$AggrRefresh: 0,
getEntraUserManagerList$DataActRefresh: -1,
getSpecialApprovalLevels$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getRequisitionsApprovalLevels$AggrRefresh: ["getEntraUserManagerList$DataActRefresh"],
getRequisitionById$AggrRefresh: ["getRequisitionsApprovalLevels$AggrRefresh", "getSpecialApprovalLevels$DataActRefresh"],
getEntraUserManagerList$DataActRefresh: [],
getSpecialApprovalLevels$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getRequisitionsApprovalLevels$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionsApprovalLevels$AggrRefresh"))) {
this._getRequisitionsApprovalLevels$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionsApprovalLevels", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionEntra_Historic/ScreenDataSetGetRequisitionsApprovalLevels", "TRiDTkETrHn5bIRs9xKYHA", maxRecords, startIndex, function (b) {
model.variables.getRequisitionsApprovalLevelsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsApprovalLevelsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsApprovalLevelsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionsApprovalLevelsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionsApprovalLevels", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsApprovalLevels");
span.setAttribute("outsystems.function.key", "6b915493-ff40-4e60-a7e1-e72207a6fc49");
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

return this._getRequisitionsApprovalLevels$AggrRefresh;
}set getRequisitionsApprovalLevels$AggrRefresh(value) {this._getRequisitionsApprovalLevels$AggrRefresh = value;
}

get getRequisitionById$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionById$AggrRefresh"))) {
this._getRequisitionById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionById", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionEntra_Historic/ScreenDataSetGetRequisitionById", "Wps_Uy8dcqRFQPd75rqROg", maxRecords, startIndex, function (b) {
model.variables.getRequisitionByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionById", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionById");
span.setAttribute("outsystems.function.key", "95213501-c928-4f20-b561-22b51523e725");
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

get getEntraUserManagerList$DataActRefresh() {if(!(this.hasOwnProperty("_getEntraUserManagerList$DataActRefresh"))) {
this._getEntraUserManagerList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetEntraUserManagerList", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionEntra_Historic/DataActionGetEntraUserManagerList", "Bv69ti44rzc1f5xg1+PCbg", function (b) {
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
span.setAttribute("outsystems.function.key", "1266899d-86f2-41ac-b894-1b1c081d0070");
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
return controller.callDataAction("DataActionGetSpecialApprovalLevels", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionEntra_Historic/DataActionGetSpecialApprovalLevels", "KDobedCAcuKOY8GkVJNPLA", function (b) {
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
span.setAttribute("outsystems.function.key", "6dc7d0e0-fcf6-44ab-bdff-aefe37271514");
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
this._dataFetchActionNames = ["getRequisitionsApprovalLevels$AggrRefresh", "getRequisitionById$AggrRefresh", "getEntraUserManagerList$DataActRefresh", "getSpecialApprovalLevels$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "06e31dcd-5416-43e4-8919-bd03c271aae9");
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
// Refresh Query: GetRequisitionById
var result = controller.getRequisitionById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// False
return OS$Flow.executeSequence(function () {
if((false)) {
// Refresh Query: GetRequisitionsApprovalLevels
var result = controller.getRequisitionsApprovalLevels$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetEntraUserManagerList
var result = controller.getEntraUserManagerList$DataActRefresh(callContext);
model.flush();
return result;
});
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
_getRequisitionByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "3eb822df-bb20-432f-853d-5d5b8b57cc11");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRequisitionByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsSpecial workflow?
return OS$Flow.executeSequence(function () {
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.isSpecialAttr)) {
// Refresh Query: GetSpecialApprovalLevels
var result = controller.getSpecialApprovalLevels$DataActRefresh(callContext);
model.flush();
return result;
} else {
// Refresh Query: GetRequisitionsApprovalLevels
var result = controller.getRequisitionsApprovalLevels$AggrRefresh(999999999, 0, callContext);
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
_getRequisitionsApprovalLevelsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionsApprovalLevelsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "7cae13f4-e441-4477-8f17-de32ebe355d8");
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
span.setAttribute("outsystems.function.key", "95a34347-9108-43fa-8532-9ab4d6c11afe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetEntraUserManagerListOnAfterFetch");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.listVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.listVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getRequisitionsApprovalLevelsAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_34625f5643caa3d12448dcec7dd4c7d3Structure))(), function (source, target) {
target.nameAttr = source.user_AssignedAttr.nameAttr;
target.roleAttr = ((((source.applicationRoleAttr.nameAttr) !== (""))) ? (source.applicationRoleAttr.nameAttr) : (source.requisitionApprovalLevelAttr.entraJobTitleAttr));
target.cancelMessageAttr = source.requisitionComment_CancelAttr.messageAttr;
target.approvalStatusIdAttr = source.requisitionApprovalLevelAttr.approvalStatusIdAttr;
target.approveAsAreaUsuariaAttr = source.requisitionApprovalLevelAttr.approveAsAreaUsuariaAttr;
target.modifyMessageAttr = source.requisitionComment_ModifyAttr.messageAttr;
target.isReassignedAttr = source.requisitionApprovalLevelAttr.isReassignedAttr;
target.isSubstituteAttr = ((source.requisitionApprovalLevelAttr.isSubstituteForAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()));
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
_getSpecialApprovalLevelsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSpecialApprovalLevelsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "cab5d710-ba6e-449d-bb25-7580a3ce2ea1");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "06e31dcd-5416-43e4-8919-bd03c271aae9");
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

getRequisitionByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "3eb822df-bb20-432f-853d-5d5b8b57cc11");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRequisitionByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getRequisitionsApprovalLevelsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionsApprovalLevelsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "7cae13f4-e441-4477-8f17-de32ebe355d8");
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
span.setAttribute("outsystems.function.key", "95a34347-9108-43fa-8532-9ab4d6c11afe");
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

getSpecialApprovalLevelsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSpecialApprovalLevelsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "cab5d710-ba6e-449d-bb25-7580a3ce2ea1");
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


