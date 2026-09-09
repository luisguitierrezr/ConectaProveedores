import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_j_FoliosSAE_FolioSAE_Details_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.FolioSAE_Details.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_FolioSAE_Details_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioItemsByFolioId$AggrRefresh: 0,
getFolioApprovalRejectReason$AggrRefresh: -1,
getFolioComments$AggrRefresh: 0,
getFirstApproval$AggrRefresh: 0,
getFolioById$AggrRefresh: -1,
getUserApplicationRoles$DataActRefresh: 0,
getRejectComment$DataActRefresh: -1,
getFolioApprovalDisplay$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getFolioItemsByFolioId$AggrRefresh: [],
getFolioApprovalRejectReason$AggrRefresh: [],
getFolioComments$AggrRefresh: [],
getFirstApproval$AggrRefresh: [],
getFolioById$AggrRefresh: ["getRejectComment$DataActRefresh", "getFolioApprovalDisplay$DataActRefresh"],
getUserApplicationRoles$DataActRefresh: ["getFolioById$AggrRefresh"],
getRejectComment$DataActRefresh: [],
getFolioApprovalDisplay$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
folioCancelFromProveedor$ServerAction(i_FolioIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioCancelFromProveedor", function (span) {
if(span) {
span.setAttribute("code.function", "FolioCancelFromProveedor");
span.setAttribute("outsystems.function.key", "187b8207-0664-4b42-9d55-86f255a294f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioCancelFromProveedor", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ActionFolioCancelFromProveedor", "C7nqxnK5J+DlTcCQ6Oj8ag", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details$ActionFolioCancelFromProveedor"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
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
auditCreateWrapper$ServerAction(sourceIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AuditCreateWrapper", function (span) {
if(span) {
span.setAttribute("code.function", "AuditCreateWrapper");
span.setAttribute("outsystems.function.key", "29ed484b-b7f1-432a-9518-6b19b3ff7cf9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Source: OS$DataConversion.ServerDataConverter.to(sourceIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getFolioItemsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioItemsByFolioId$AggrRefresh"))) {
this._getFolioItemsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioItemsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ScreenDataSetGetFolioItemsByFolioId", "ThsXqfcJ_cmZ3sfSw6f06A", maxRecords, startIndex, function (b) {
model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioItemsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioItemsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioItemsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioId");
span.setAttribute("outsystems.function.key", "0cc3bbc2-a537-4a1f-8b6c-fd32ce872595");
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

return this._getFolioItemsByFolioId$AggrRefresh;
}set getFolioItemsByFolioId$AggrRefresh(value) {this._getFolioItemsByFolioId$AggrRefresh = value;
}

get getFolioApprovalRejectReason$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioApprovalRejectReason$AggrRefresh"))) {
this._getFolioApprovalRejectReason$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioApprovalRejectReason", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ScreenDataSetGetFolioApprovalRejectReason", "p6xYQLI8Jbh5uMewTpEvGQ", maxRecords, startIndex, function (b) {
model.variables.getFolioApprovalRejectReasonAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioApprovalRejectReasonAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioApprovalRejectReasonAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioApprovalRejectReason", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalRejectReason");
span.setAttribute("outsystems.function.key", "402dda4e-7219-4daf-b09b-1d2bba1dd7a5");
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

return this._getFolioApprovalRejectReason$AggrRefresh;
}set getFolioApprovalRejectReason$AggrRefresh(value) {this._getFolioApprovalRejectReason$AggrRefresh = value;
}

get getFolioComments$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioComments$AggrRefresh"))) {
this._getFolioComments$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioComments", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ScreenDataSetGetFolioComments", "HZbIcsZqIVN0tCEPa4xSRA", maxRecords, startIndex, function (b) {
model.variables.getFolioCommentsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioCommentsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioCommentsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioComments", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioComments");
span.setAttribute("outsystems.function.key", "5adbb5a6-8ac9-4c15-860a-b0ca374a7e32");
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

return this._getFolioComments$AggrRefresh;
}set getFolioComments$AggrRefresh(value) {this._getFolioComments$AggrRefresh = value;
}

get getFirstApproval$AggrRefresh() {if(!(this.hasOwnProperty("_getFirstApproval$AggrRefresh"))) {
this._getFirstApproval$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFirstApproval", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ScreenDataSetGetFirstApproval", "_x4itn6E8yku49J_fOy64w", maxRecords, startIndex, function (b) {
model.variables.getFirstApprovalAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFirstApprovalAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFirstApprovalAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFirstApproval", function (span) {
if(span) {
span.setAttribute("code.function", "GetFirstApproval");
span.setAttribute("outsystems.function.key", "abc2bc51-2f9d-4ba7-8acd-1348a3e60e34");
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

return this._getFirstApproval$AggrRefresh;
}set getFirstApproval$AggrRefresh(value) {this._getFirstApproval$AggrRefresh = value;
}

get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/ScreenDataSetGetFolioById", "OtyQqCIpnkhtLBbEQTqG0w", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getFolioByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "efa7070e-554f-48ab-af8a-26c055e689de");
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

return this._getFolioById$AggrRefresh;
}set getFolioById$AggrRefresh(value) {this._getFolioById$AggrRefresh = value;
}

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/DataActionGetUserApplicationRoles", "12jnPC+mCW7cuQvB89HM9w", function (b) {
model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserApplicationRolesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRoles", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRoles");
span.setAttribute("outsystems.function.key", "4dc77fdd-f11b-4e1e-a1f6-89cae004f70a");
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

return this._getUserApplicationRoles$DataActRefresh;
}set getUserApplicationRoles$DataActRefresh(value) {this._getUserApplicationRoles$DataActRefresh = value;
}

get getRejectComment$DataActRefresh() {if(!(this.hasOwnProperty("_getRejectComment$DataActRefresh"))) {
this._getRejectComment$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRejectComment", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/DataActionGetRejectComment", "b8mnYvCwuA6ngz49zWpenQ", function (b) {
model.variables.getRejectCommentDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRejectCommentDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRejectCommentDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRejectComment", function (span) {
if(span) {
span.setAttribute("code.function", "GetRejectComment");
span.setAttribute("outsystems.function.key", "b00b2ce9-6aef-426a-9cca-badf6ad0cc53");
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

return this._getRejectComment$DataActRefresh;
}set getRejectComment$DataActRefresh(value) {this._getRejectComment$DataActRefresh = value;
}

get getFolioApprovalDisplay$DataActRefresh() {if(!(this.hasOwnProperty("_getFolioApprovalDisplay$DataActRefresh"))) {
this._getFolioApprovalDisplay$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFolioApprovalDisplay", "screenservices/ConectaProveedores/j_FoliosSAE/FolioSAE_Details/DataActionGetFolioApprovalDisplay", "APXHJE5apgYORbxfYEYNkw", function (b) {
model.variables.getFolioApprovalDisplayDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioApprovalDisplayDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioApprovalDisplayDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioApprovalDisplay", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalDisplay");
span.setAttribute("outsystems.function.key", "c4bcd284-74ef-4e07-b256-27ec024d655a");
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

return this._getFolioApprovalDisplay$DataActRefresh;
}set getFolioApprovalDisplay$DataActRefresh(value) {this._getFolioApprovalDisplay$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioItemsByFolioId$AggrRefresh", "getFolioApprovalRejectReason$AggrRefresh", "getFolioComments$AggrRefresh", "getFirstApproval$AggrRefresh", "getFolioById$AggrRefresh", "getUserApplicationRoles$DataActRefresh", "getRejectComment$DataActRefresh", "getFolioApprovalDisplay$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "03e35cce-3697-46b0-89d8-9f4ef6cfb4c7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioById
var result = controller.getFolioById$AggrRefresh(1, 0, callContext);
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
_wb_FormActionsRefresh$Action(i_IsOnlyHistoryIn, i_IsRedirectToFolioListIn, i_IsRedirectToFoliosRejectedIn, i_IsInvoiceApprovalIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_FormActionsRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FormActionsRefresh");
span.setAttribute("outsystems.function.key", "1feff64c-27e1-41c3-b074-9a028b4aedc0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_FormActionsRefresh");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details.Wb_FormActionsRefresh$vars"))());
vars.value.i_IsOnlyHistoryInLocal = i_IsOnlyHistoryIn;
vars.value.i_IsRedirectToFolioListInLocal = i_IsRedirectToFolioListIn;
vars.value.i_IsRedirectToFoliosRejectedInLocal = i_IsRedirectToFoliosRejectedIn;
vars.value.i_IsInvoiceApprovalInLocal = i_IsInvoiceApprovalIn;
if((vars.value.i_IsOnlyHistoryInLocal)) {
// l_RefreshOrderEntra_Historic = CurrDateTime
model.variables.l_RefreshOrderEntra_HistoricVar = OS$BuiltinFunctions.currDateTime();
// Destination: /ConectaProveedores/FolioSAE_Details
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} else {
if((vars.value.i_IsRedirectToFolioListInLocal)) {
if((vars.value.i_IsInvoiceApprovalInLocal)) {
// Destination: /ConectaProveedores/ForeignInvoicesPendingValidation
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ForeignInvoicesPendingValidation", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} else {
// Destination: /ConectaProveedores/FoliosSAEForApproval
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FoliosSAEForApproval", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

} else {
if((vars.value.i_IsRedirectToFoliosRejectedInLocal)) {
// Destination: /ConectaProveedores/FoliosSAERejected
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FoliosSAERejected", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} else {
// Destination: /ConectaProveedores/FolioSAE_Details
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

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
_getFolioByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "233062f5-ef7f-4c36-b2b0-04cd6951f899");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetFolioByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.getFolioByIdAggr.listOut.isEmpty)) {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
return OS$Flow.executeSequence(function () {
if((ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)) {
// Refresh Query: GetFolioApprovalRejectReason
var result = controller.getFolioApprovalRejectReason$AggrRefresh(1, 0, callContext);
model.flush();
return result;
} else {
// Refresh Query: GetFolioApprovalDisplay
var result = controller.getFolioApprovalDisplay$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetRejectComment
var result = controller.getRejectComment$DataActRefresh(callContext);
model.flush();
return result;
});
}

}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
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
_wb_SAECInvoicesRefresh$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SAECInvoicesRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SAECInvoicesRefresh");
span.setAttribute("outsystems.function.key", "2b39c157-1e62-4197-9579-a8bbd39ff115");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SAECInvoicesRefresh");
callContext = controller.callContext(callContext);
// Destination: /ConectaProveedores/FolioSAE_Details
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openCloseCancelPopUp$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenCloseCancelPopUp", function (span) {
if(span) {
span.setAttribute("code.function", "OpenCloseCancelPopUp");
span.setAttribute("outsystems.function.key", "37885a8f-fbd0-4d30-bf3c-3391469e7ff1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenCloseCancelPopUp");
callContext = controller.callContext(callContext);
// ShowCancelPopup = notShowCancelPopup
model.variables.showCancelPopupVar = (!(model.variables.showCancelPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence");
span.setAttribute("outsystems.function.key", "3df7ff4a-15a3-46ea-b7e2-05efc48a47a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_cancelOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "780cce37-9068-4351-8199-fc0071361895");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CancelOnClick");
callContext = controller.callContext(callContext);
var folioCancelFromProveedorVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FolioCancelFromProveedor
model.flush();
return controller.folioCancelFromProveedor$ServerAction(model.variables.i_FolioIdIn, callContext).then(function (value) {
folioCancelFromProveedorVar.value = value;
}).then(function () {
// IsSuccess?
if((folioCancelFromProveedorVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CgM0NmTXKkeM_G_JrvpOBA#Message.-843665336.1", "Folio canceled with success!"), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Details
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Details", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(folioCancelFromProveedorVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "bba7eebf-5f93-4eea-bfc0-eb5f0ccd4b9d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort2 += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort2 = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetFolioItemsByFolioId
var result = controller.getFolioItemsByFolioId$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
span.setAttribute("outsystems.function.key", "ce532bbb-e0d3-4c58-8293-3386ea66d753");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetFolioItemsByFolioId
var result = controller.getFolioItemsByFolioId$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "d1217f43-5b70-4c89-8fd9-46fadf57a308");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "fc26a78b-b57e-452e-b3a5-53268a47057e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: AuditCreateWrapper
model.flush();
return controller.auditCreateWrapper$ServerAction(function () {
var rec = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.originAttr = ConectaProveedores_staticEntities_origin.screenAccess;
rec.identifierAttr = model.variables.i_FolioIdIn;
rec.messageAttr = "";
rec.screenAttr = "Folio SAE Details";
rec.functionalityAttr = "View";
rec.occurrenceRoleNameAttr = "";
return rec;
}(), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "03e35cce-3697-46b0-89d8-9f4ef6cfb4c7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUserApplicationRolesOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_FormActionsRefresh$Action(i_IsOnlyHistoryIn, i_IsRedirectToFolioListIn, i_IsRedirectToFoliosRejectedIn, i_IsInvoiceApprovalIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_FormActionsRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FormActionsRefresh");
span.setAttribute("outsystems.function.key", "1feff64c-27e1-41c3-b074-9a028b4aedc0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_FormActionsRefresh$Action, callContext, i_IsOnlyHistoryIn, i_IsRedirectToFolioListIn, i_IsRedirectToFoliosRejectedIn, i_IsInvoiceApprovalIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getFolioByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "233062f5-ef7f-4c36-b2b0-04cd6951f899");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getFolioByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SAECInvoicesRefresh$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SAECInvoicesRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SAECInvoicesRefresh");
span.setAttribute("outsystems.function.key", "2b39c157-1e62-4197-9579-a8bbd39ff115");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SAECInvoicesRefresh$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openCloseCancelPopUp$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenCloseCancelPopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenCloseCancelPopUp");
span.setAttribute("outsystems.function.key", "37885a8f-fbd0-4d30-bf3c-3391469e7ff1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openCloseCancelPopUp$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence");
span.setAttribute("outsystems.function.key", "3df7ff4a-15a3-46ea-b7e2-05efc48a47a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

cancelOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "780cce37-9068-4351-8199-fc0071361895");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._cancelOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "bba7eebf-5f93-4eea-bfc0-eb5f0ccd4b9d");
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

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "ce532bbb-e0d3-4c58-8293-3386ea66d753");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "d1217f43-5b70-4c89-8fd9-46fadf57a308");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "fc26a78b-b57e-452e-b3a5-53268a47057e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
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
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
return ConectaProveedores_j_FoliosSAEController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Proveedor, ConectaProveedoresController$default.roles.Folios, ConectaProveedoresController$default.roles.ComissionesArrendamientosViewer]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details$ActionFolioCancelFromProveedor", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details.Wb_FormActionsRefresh$vars", [{
name: "i_IsOnlyHistory",
attrName: "i_IsOnlyHistoryInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsRedirectToFolioList",
attrName: "i_IsRedirectToFolioListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsRedirectToFoliosRejected",
attrName: "i_IsRedirectToFoliosRejectedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsInvoiceApproval",
attrName: "i_IsInvoiceApprovalInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FolioSAE_Details.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


