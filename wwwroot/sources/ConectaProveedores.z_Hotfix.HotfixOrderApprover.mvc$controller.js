import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_z_Hotfix_HotfixOrderApprover_mvc_TranslationsResources from "./ConectaProveedores.z_Hotfix.HotfixOrderApprover.mvc$translationsResources.js";
import ConectaProveedores_z_HotfixController$default from "./ConectaProveedores.z_Hotfix.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_z_Hotfix_HotfixOrderApprover_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getUserOriginal$AggrRefresh: -1,
getOrderStatuses$AggrRefresh: 0,
getInvoices$AggrRefresh: -1,
getOrderApprovalLevelsByAssignedTo$AggrRefresh: -1,
getRequisitions$DataActRefresh: -1,
getUserApplicationRolesAndMore$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getUserOriginal$AggrRefresh: ["getOrderApprovalLevelsByAssignedTo$AggrRefresh"],
getOrderStatuses$AggrRefresh: [],
getInvoices$AggrRefresh: [],
getOrderApprovalLevelsByAssignedTo$AggrRefresh: [],
getRequisitions$DataActRefresh: [],
getUserApplicationRolesAndMore$DataActRefresh: ["getInvoices$AggrRefresh", "getRequisitions$DataActRefresh"]
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
hotfixOrderApproverReplaceAll$ServerAction(userOriginalIn, userSubstituteIn, orderNumberFilterIn, orderStatusIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("HotfixOrderApproverReplaceAll", function (span) {
if(span) {
span.setAttribute("code.function", "HotfixOrderApproverReplaceAll");
span.setAttribute("outsystems.function.key", "51c88f50-ea0b-47b6-aea3-609e722f7729");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserOriginal: OS$DataConversion.ServerDataConverter.to(userOriginalIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
UserSubstitute: OS$DataConversion.ServerDataConverter.to(userSubstituteIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OrderNumberFilter: OS$DataConversion.ServerDataConverter.to(orderNumberFilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OrderStatusId: OS$DataConversion.ServerDataConverter.to(orderStatusIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("HotfixOrderApproverReplaceAll", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/ActionHotfixOrderApproverReplaceAll", "jZbh4uW3FvWknlCGVw1VoA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover$ActionHotfixOrderApproverReplaceAll"))();
executeServerActionResult.errorMessageOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMessage, OS$DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
hotfixOrderApproverReplaceSingle$ServerAction(userOriginalIn, userSubstituteIn, orderApprovalLevelIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("HotfixOrderApproverReplaceSingle", function (span) {
if(span) {
span.setAttribute("code.function", "HotfixOrderApproverReplaceSingle");
span.setAttribute("outsystems.function.key", "e89996a6-7959-4264-b5bc-62dce7757bc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserOriginal: OS$DataConversion.ServerDataConverter.to(userOriginalIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
UserSubstitute: OS$DataConversion.ServerDataConverter.to(userSubstituteIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OrderApprovalLevelIdSelected: OS$DataConversion.ServerDataConverter.to(orderApprovalLevelIdSelectedIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("HotfixOrderApproverReplaceSingle", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/ActionHotfixOrderApproverReplaceSingle", "cWEvHEcp96tbVMQa_us4Tw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover$ActionHotfixOrderApproverReplaceSingle"))();
executeServerActionResult.errorMessageOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMessage, OS$DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;

// Aggregates and Data Actions
get getUserOriginal$AggrRefresh() {if(!(this.hasOwnProperty("_getUserOriginal$AggrRefresh"))) {
this._getUserOriginal$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserOriginal", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/ScreenDataSetGetUserOriginal", "7wD4ZijinpmjCfV+amlbLw", maxRecords, startIndex, function (b) {
model.variables.getUserOriginalAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserOriginalAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserOriginalAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserOriginalOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserOriginal", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserOriginal");
span.setAttribute("outsystems.function.key", "735a6789-2593-46f6-8d52-a98c72fe76ed");
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

return this._getUserOriginal$AggrRefresh;
}set getUserOriginal$AggrRefresh(value) {this._getUserOriginal$AggrRefresh = value;
}

get getOrderStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderStatuses$AggrRefresh"))) {
this._getOrderStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderStatuses", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/ScreenDataSetGetOrderStatuses", "JufeXrUSLyaU5dJZ+VE2aQ", maxRecords, startIndex, function (b) {
model.variables.getOrderStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderStatuses");
span.setAttribute("outsystems.function.key", "9ca0fd95-3e64-4bf3-a87d-dec71ca7aea8");
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

return this._getOrderStatuses$AggrRefresh;
}set getOrderStatuses$AggrRefresh(value) {this._getOrderStatuses$AggrRefresh = value;
}

get getInvoices$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoices$AggrRefresh"))) {
this._getInvoices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoices", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/ScreenDataSetGetInvoices", "OQ0oXv765XdDNIPSGbOeMw", maxRecords, startIndex, function (b) {
model.variables.getInvoicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoices");
span.setAttribute("outsystems.function.key", "d6f3084d-5269-4240-ab05-2c05c348a60a");
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

return this._getInvoices$AggrRefresh;
}set getInvoices$AggrRefresh(value) {this._getInvoices$AggrRefresh = value;
}

get getOrderApprovalLevelsByAssignedTo$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderApprovalLevelsByAssignedTo$AggrRefresh"))) {
this._getOrderApprovalLevelsByAssignedTo$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderApprovalLevelsByAssignedTo", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/ScreenDataSetGetOrderApprovalLevelsByAssignedTo", "nlhaPPqpOL3bk5CMxJvZIw", maxRecords, startIndex, function (b) {
model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderApprovalLevelsByAssignedToAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderApprovalLevelsByAssignedToAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderApprovalLevelsByAssignedTo", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderApprovalLevelsByAssignedTo");
span.setAttribute("outsystems.function.key", "e93ea21c-e709-4131-ab19-9a2773135687");
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

return this._getOrderApprovalLevelsByAssignedTo$AggrRefresh;
}set getOrderApprovalLevelsByAssignedTo$AggrRefresh(value) {this._getOrderApprovalLevelsByAssignedTo$AggrRefresh = value;
}

get getRequisitions$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitions$DataActRefresh"))) {
this._getRequisitions$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitions", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/DataActionGetRequisitions", "JmOSFYKQZSdqWwCVaAceiw", function (b) {
model.variables.getRequisitionsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitions");
span.setAttribute("outsystems.function.key", "99ece280-b3ea-4b77-9d07-cafd63529978");
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

return this._getRequisitions$DataActRefresh;
}set getRequisitions$DataActRefresh(value) {this._getRequisitions$DataActRefresh = value;
}

get getUserApplicationRolesAndMore$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRolesAndMore$DataActRefresh"))) {
this._getUserApplicationRolesAndMore$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRolesAndMore", "screenservices/ConectaProveedores/z_Hotfix/HotfixOrderApprover/DataActionGetUserApplicationRolesAndMore", "M8hdTcy12h0pVIu_bhbMnQ", function (b) {
model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesAndMoreDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesAndMoreDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getUserApplicationRolesAndMoreOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRolesAndMore", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesAndMore");
span.setAttribute("outsystems.function.key", "f1e5d87d-eaf5-4e84-85aa-12876c64f347");
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

return this._getUserApplicationRolesAndMore$DataActRefresh;
}set getUserApplicationRolesAndMore$DataActRefresh(value) {this._getUserApplicationRolesAndMore$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserOriginal$AggrRefresh", "getOrderStatuses$AggrRefresh", "getInvoices$AggrRefresh", "getOrderApprovalLevelsByAssignedTo$AggrRefresh", "getRequisitions$DataActRefresh", "getUserApplicationRolesAndMore$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_replaceAllOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ReplaceAllOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ReplaceAllOnClick");
span.setAttribute("outsystems.function.key", "012202a4-6d11-4523-923d-342d8cc7534c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ReplaceAllOnClick");
callContext = controller.callContext(callContext);
var hotfixOrderApproverReplaceAllVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: HotfixOrderApproverReplaceAll
model.flush();
return controller.hotfixOrderApproverReplaceAll$ServerAction(model.variables.userOriginalVar, model.variables.userSubstituteVar, model.variables.orderNumberFilterVar, model.variables.orderStatusIdVar, callContext).then(function (value) {
hotfixOrderApproverReplaceAllVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((((hotfixOrderApproverReplaceAllVar.value.errorMessageOut) !== ("")))) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(hotfixOrderApproverReplaceAllVar.value.errorMessageOut, /*Error*/ 3);
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage("Éxito!", /*Success*/ 1);
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_getUserOriginalOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserOriginalOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserOriginalOnAfterFetch");
span.setAttribute("outsystems.function.key", "36b9c0b2-0957-40c3-a1a1-4f25d3209a4e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserOriginalOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_replaceSingleOnClick$Action(orderApprovalLevelIdSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ReplaceSingleOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ReplaceSingleOnClick");
span.setAttribute("outsystems.function.key", "54e33c0c-fe3c-46dd-adf0-9362b32c4c6d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ReplaceSingleOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.ReplaceSingleOnClick$vars"))());
vars.value.orderApprovalLevelIdSelectedInLocal = orderApprovalLevelIdSelectedIn;
var hotfixOrderApproverReplaceSingleVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: HotfixOrderApproverReplaceSingle
model.flush();
return controller.hotfixOrderApproverReplaceSingle$ServerAction(model.variables.userOriginalVar, model.variables.userSubstituteVar, vars.value.orderApprovalLevelIdSelectedInLocal, callContext).then(function (value) {
hotfixOrderApproverReplaceSingleVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((((hotfixOrderApproverReplaceSingleVar.value.errorMessageOut) !== ("")))) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(hotfixOrderApproverReplaceSingleVar.value.errorMessageOut, /*Error*/ 3);
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage("Éxito!", /*Success*/ 1);
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_wb_DropdownSelectUserOriginal$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_DropdownSelectUserOriginal", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DropdownSelectUserOriginal");
span.setAttribute("outsystems.function.key", "815b3d6d-0859-4325-9265-2be1ab564a66");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_DropdownSelectUserOriginal");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.Wb_DropdownSelectUserOriginal$vars"))());
vars.value.userIdInLocal = userIdIn;
return OS$Flow.executeAsyncFlow(function () {
// UserOriginal = UserId
model.variables.userOriginalVar = vars.value.userIdInLocal;
// Refresh Query: GetUserOriginal
var result = controller.getUserOriginal$AggrRefresh(1, 0, callContext);
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "9c0f2b21-ca7d-42bd-a629-a7dcae46c0d4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_debounceOnDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DebounceOnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceOnDebounce");
span.setAttribute("outsystems.function.key", "9d4ecac7-016a-4b32-be7a-1d15fbbca1d0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DebounceOnDebounce");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_wb_DropdownSelectUserSubstitute$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_DropdownSelectUserSubstitute", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DropdownSelectUserSubstitute");
span.setAttribute("outsystems.function.key", "a1df99ce-2336-42e5-a2eb-d766c1a89ee6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_DropdownSelectUserSubstitute");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.Wb_DropdownSelectUserSubstitute$vars"))());
vars.value.userIdInLocal = userIdIn;
// UserSubstitute = UserId
model.variables.userSubstituteVar = vars.value.userIdInLocal;
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
span.setAttribute("outsystems.function.key", "ad005835-95c2-453f-937e-72cf3e8355fe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.OnSort$vars"))());
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
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_dropdown1OnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown1OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown1OnChange");
span.setAttribute("outsystems.function.key", "c36a6fa3-cabb-4919-90bd-703dd2d7e7c1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown1OnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderApprovalLevelsByAssignedTo
var result = controller.getOrderApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_getUserApplicationRolesAndMoreOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesAndMoreOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesAndMoreOnAfterFetch");
span.setAttribute("outsystems.function.key", "e99feada-5838-4b9c-a57a-87dabb10d0e2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetUserApplicationRolesAndMoreOnAfterFetch");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

replaceAllOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ReplaceAllOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ReplaceAllOnClick");
span.setAttribute("outsystems.function.key", "012202a4-6d11-4523-923d-342d8cc7534c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._replaceAllOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getUserOriginalOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserOriginalOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserOriginalOnAfterFetch");
span.setAttribute("outsystems.function.key", "36b9c0b2-0957-40c3-a1a1-4f25d3209a4e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUserOriginalOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

replaceSingleOnClick$Action(orderApprovalLevelIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ReplaceSingleOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ReplaceSingleOnClick");
span.setAttribute("outsystems.function.key", "54e33c0c-fe3c-46dd-adf0-9362b32c4c6d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._replaceSingleOnClick$Action, callContext, orderApprovalLevelIdSelectedIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_DropdownSelectUserOriginal$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_DropdownSelectUserOriginal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DropdownSelectUserOriginal");
span.setAttribute("outsystems.function.key", "815b3d6d-0859-4325-9265-2be1ab564a66");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_DropdownSelectUserOriginal$Action, callContext, userIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "9c0f2b21-ca7d-42bd-a629-a7dcae46c0d4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onPaginationNavigate$Action, callContext, newStartIndexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

debounceOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebounceOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceOnDebounce");
span.setAttribute("outsystems.function.key", "9d4ecac7-016a-4b32-be7a-1d15fbbca1d0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._debounceOnDebounce$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_DropdownSelectUserSubstitute$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_DropdownSelectUserSubstitute__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DropdownSelectUserSubstitute");
span.setAttribute("outsystems.function.key", "a1df99ce-2336-42e5-a2eb-d766c1a89ee6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DropdownSelectUserSubstitute$Action, callContext, userIdIn);
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
span.setAttribute("outsystems.function.key", "ad005835-95c2-453f-937e-72cf3e8355fe");
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

dropdown1OnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown1OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown1OnChange");
span.setAttribute("outsystems.function.key", "c36a6fa3-cabb-4919-90bd-703dd2d7e7c1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown1OnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getUserApplicationRolesAndMoreOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesAndMoreOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesAndMoreOnAfterFetch");
span.setAttribute("outsystems.function.key", "e99feada-5838-4b9c-a57a-87dabb10d0e2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getUserApplicationRolesAndMoreOnAfterFetch$Action, callContext);
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
return ConectaProveedores_z_HotfixController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ConectaProveedoresAdmin]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover$ActionHotfixOrderApproverReplaceAll", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover$ActionHotfixOrderApproverReplaceSingle", [{
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.ReplaceSingleOnClick$vars", [{
name: "OrderApprovalLevelIdSelected",
attrName: "orderApprovalLevelIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.Wb_DropdownSelectUserOriginal$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.Wb_DropdownSelectUserSubstitute$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.z_Hotfix.HotfixOrderApprover.OnSort$vars", [{
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


