import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import { sidebarClose$Action as OutSystemsUIController$sidebarClose$Action, sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { RC_786401d4272d8830c4a71cf084346ee6 } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getProposalById$AggrRefresh: 0,
getProposalStatuses$AggrRefresh: 1,
getProposalApprovalLevels$AggrRefresh: -1,
getProposalLinesByProposalId$AggrRefresh: -1
};
this.dataFetchDependentsGraph = {
getProposalById$AggrRefresh: ["getProposalStatuses$AggrRefresh", "getProposalLinesByProposalId$AggrRefresh"],
getProposalStatuses$AggrRefresh: [],
getProposalApprovalLevels$AggrRefresh: [],
getProposalLinesByProposalId$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
undoReject$ServerAction(i_ProposalIdIn, i_ProposalLineApprovalLevelIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UndoReject", function (span) {
if(span) {
span.setAttribute("code.function", "UndoReject");
span.setAttribute("outsystems.function.key", "823cf4d6-559d-4817-ad5e-20c5dde712e5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_ProposalLineApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_ProposalLineApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UndoReject", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ActionUndoReject", "yhzyg0BG5bRlpiWmv9lZyw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail$ActionUndoReject"))();
executeServerActionResult.o_HasProposalChangedStatusOut = OS$DataConversion.ServerDataConverter.from(outputs.o_HasProposalChangedStatus, OS$DataTypes.DataTypes.Boolean);
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
columnTogglerPassColumn$ServerAction(i_ColumnJSONIn, i_TableNameIn, i_UserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "68473301-c3d5-4d78-a652-7ce384c4cbd7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ColumnJSON: OS$DataConversion.ServerDataConverter.to(i_ColumnJSONIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_TableName: OS$DataConversion.ServerDataConverter.to(i_TableNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
downloadFileWithProposalId$ServerAction(i_ProposalIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFileWithProposalId", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFileWithProposalId");
span.setAttribute("outsystems.function.key", "957e4549-c87d-4963-a04d-c44a2965032d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadFileWithProposalId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ActionDownloadFileWithProposalId", "orzRncjq6at+5OYp6Ib1PA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail$ActionDownloadFileWithProposalId"))();
executeServerActionResult.o_FilenameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Filename, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_BinaryDataOut = OS$DataConversion.ServerDataConverter.from(outputs.o_BinaryData, OS$DataTypes.DataTypes.BinaryData);
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
getSettings$ServerAction(tableNameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "cf0e9209-a3bd-4677-a149-06f9ec265149");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
TableName: OS$DataConversion.ServerDataConverter.to(tableNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail$ActionGetSettings"))();
executeServerActionResult.outSettingsTextOut = OS$DataConversion.ServerDataConverter.from(outputs.OutSettingsText, OS$DataTypes.DataTypes.Text);
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
get getProposalById$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalById$AggrRefresh"))) {
this._getProposalById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalById", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ScreenDataSetGetProposalById", "Dno0SXwM7txWV1bQi9NwMQ", maxRecords, startIndex, function (b) {
model.variables.getProposalByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalById", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalById");
span.setAttribute("outsystems.function.key", "00b78da8-3f63-4d4f-b919-4222d9d2ff24");
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

return this._getProposalById$AggrRefresh;
}set getProposalById$AggrRefresh(value) {this._getProposalById$AggrRefresh = value;
}

get getProposalStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalStatuses$AggrRefresh"))) {
this._getProposalStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalStatuses", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ScreenDataSetGetProposalStatuses", "h+LMXx9T8tdR9KmahOZB3Q", maxRecords, startIndex, function (b) {
model.variables.getProposalStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalStatuses");
span.setAttribute("outsystems.function.key", "015020e1-fdb9-465e-9343-7eb21f9e622a");
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

return this._getProposalStatuses$AggrRefresh;
}set getProposalStatuses$AggrRefresh(value) {this._getProposalStatuses$AggrRefresh = value;
}

get getProposalApprovalLevels$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalApprovalLevels$AggrRefresh"))) {
this._getProposalApprovalLevels$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalApprovalLevels", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ScreenDataSetGetProposalApprovalLevels", "KLrFdmWdGnl7pNfZ3U0xWA", maxRecords, startIndex, function (b) {
model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalApprovalLevelsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalApprovalLevelsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalApprovalLevelsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalApprovalLevels", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalApprovalLevels");
span.setAttribute("outsystems.function.key", "70ecd5b0-ce48-424b-b041-35f6ba3bc2db");
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

return this._getProposalApprovalLevels$AggrRefresh;
}set getProposalApprovalLevels$AggrRefresh(value) {this._getProposalApprovalLevels$AggrRefresh = value;
}

get getProposalLinesByProposalId$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLinesByProposalId$AggrRefresh"))) {
this._getProposalLinesByProposalId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLinesByProposalId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetail/ScreenDataSetGetProposalLinesByProposalId", "87CeoiH8hRlNZ9uOX8XUjQ", maxRecords, startIndex, function (b) {
model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLinesByProposalIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLinesByProposalIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalLinesBOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLinesByProposalId", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesByProposalId");
span.setAttribute("outsystems.function.key", "87d52449-15cb-4208-a067-9a8aab9a248f");
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

return this._getProposalLinesByProposalId$AggrRefresh;
}set getProposalLinesByProposalId$AggrRefresh(value) {this._getProposalLinesByProposalId$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getProposalById$AggrRefresh", "getProposalStatuses$AggrRefresh", "getProposalApprovalLevels$AggrRefresh", "getProposalLinesByProposalId$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_showHideCancelPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideCancelPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideCancelPopup");
span.setAttribute("outsystems.function.key", "02c3e6b6-ded5-4f62-b963-4f2f4c69a73d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideCancelPopup");
callContext = controller.callContext(callContext);
// ShowCancelPopup
// l_ShowCancelPopup = notl_ShowCancelPopup
model.variables.l_ShowCancelPopupVar = (!(model.variables.l_ShowCancelPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getProposalByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "2125ab6d-faf2-41ef-bd71-009c68609dd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// No Proposal data
return OS$Flow.executeSequence(function () {
if((model.variables.getProposalByIdAggr.listOut.isEmpty)) {
// Destination: /ConectaProveedores/ProposalsListViewer
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsListViewer", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// l_DateTextFormatted = FormatDateTime
model.variables.l_DateTextFormattedVar = OS$BuiltinFunctions.formatDateTime(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
// Refresh Query: GetProposalApprovalLevels
var result = controller.getProposalApprovalLevels$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_showHideUnpaidPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideUnpaidPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideUnpaidPopup");
span.setAttribute("outsystems.function.key", "252aa26e-cc1f-4766-98bf-44221e1dfca3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideUnpaidPopup");
callContext = controller.callContext(callContext);
// l_ShowUnpaidDetailPopup = notl_ShowUnpaidDetailPopup
model.variables.l_ShowUnpaidDetailPopupVar = (!(model.variables.l_ShowUnpaidDetailPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_undoReject$Action(i_ProposalIdSelectedIn, i_ProposalLineApprovalLevelIdSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UndoReject", function (span) {
if(span) {
span.setAttribute("code.function", "UndoReject");
span.setAttribute("outsystems.function.key", "38e67339-373b-429c-b48b-9f00c3d93afe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UndoReject");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.UndoReject$vars"))());
vars.value.i_ProposalIdSelectedInLocal = i_ProposalIdSelectedIn;
vars.value.i_ProposalLineApprovalLevelIdSelectedInLocal = i_ProposalLineApprovalLevelIdSelectedIn;
var undoRejectVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: UndoReject
model.flush();
return controller.undoReject$ServerAction(vars.value.i_ProposalIdSelectedInLocal, vars.value.i_ProposalLineApprovalLevelIdSelectedInLocal, callContext).then(function (value) {
undoRejectVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((undoRejectVar.value.o_HasProposalChangedStatusOut)) {
// Refresh Query: GetProposalById
var result = controller.getProposalById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
} else {
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

});
}).then(function () {
// Refresh Query: GetProposalStatuses
var result = controller.getProposalStatuses$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "3ea9f7a5-3449-45b5-84bf-d46720aaa2d6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresProposaDetailEditlProposalLinesB"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetProposalLinesB = ColumnJSON
model.variables.l_ColumnJSONVarGetProposalLinesBVar = vars.value.columnJSONInLocal;
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
span.setAttribute("outsystems.function.key", "61beb9e6-e100-46d4-abb9-d78ed510b2e5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.l_TableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort += DESC
// l_TableSort = SortBy + " DESC"
model.variables.l_TableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort = SortBy
// l_TableSort = SortBy
model.variables.l_TableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "67a535ad-f429-405d-b8d2-bf5fb56191d4");
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
rec.identifierAttr = model.variables.i_ProposalIdIn;
rec.messageAttr = "";
rec.screenAttr = "CyA - Proposal Detail";
rec.functionalityAttr = "View";
rec.occurrenceRoleNameAttr = ConectaProveedoresClientVariables.getApplicationRole();
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "8b8fd383-555e-4c8c-a036-3fadf8afd54b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetColumnVisiblityOnClick");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getProposalApprovalLevelsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalApprovalLevelsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "99d799b7-a1c6-432e-a038-fe5d69600228");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalApprovalLevelsOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilter2Var = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Proposal in Tesoreria?
return OS$Flow.executeSequence(function () {
if(((((((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.approved) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.beingPaid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.canceled)))) {
// l_ProposalApprovalLevelId = NullIdentifier
model.variables.l_ProposalApprovalLevelIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
});
} else {
// Execute Action: ListFilter2
listFilter2Var.value = OS$SystemActions.listFilter(model.variables.getProposalApprovalLevelsAggr.listOut, function (p) {
return p.proposalApprovalLevelAttr.hasStartedAttr;
}, callContext);

// Execute Action: ListSort
OS$SystemActions.listSort(listFilter2Var.value.filteredListOut, function (p) {
return p.proposalApprovalLevelAttr.levelNumberAttr;
}, true, callContext);
// l_ListForApprovalLevelDropdown = ListFilter2.FilteredList
model.variables.l_ListForApprovalLevelDropdownVar = OS$DataConversion.JSConversions.typeConvertRecordList(listFilter2Var.value.filteredListOut, new (OS$GenericTypeCache.getGenericList(RC_786401d4272d8830c4a71cf084346ee6))(), function (source, target) {
target.applicationRoleNameAttr = source.applicationRoleAttr.nameAttr;
target.proposalApprovalLevelIdAttr = source.proposalApprovalLevelAttr.idAttr;
return target;
});
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(listFilter2Var.value.filteredListOut, function (p) {
return (p.proposalApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.rejected);
}, callContext);

if((((listIndexOfVar.value.positionOut) !== ((-1))))) {
// l_ProposalApprovalLevelId = l_ListForApprovalLevelDropdown[ListIndexOf.Position].ProposalApprovalLevelId
model.variables.l_ProposalApprovalLevelIdVar = model.variables.l_ListForApprovalLevelDropdownVar.getItem(listIndexOfVar.value.positionOut).proposalApprovalLevelIdAttr;
} else {
// l_ProposalApprovalLevelId = l_ListForApprovalLevelDropdown[l_ListForApprovalLevelDropdown.Length - 1].ProposalApprovalLevelId
model.variables.l_ProposalApprovalLevelIdVar = model.variables.l_ListForApprovalLevelDropdownVar.getItem((model.variables.l_ListForApprovalLevelDropdownVar.length - 1)).proposalApprovalLevelIdAttr;
}

// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_dropdown_l_ProposalApprovalLevelIdOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_l_ProposalApprovalLevelIdOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_l_ProposalApprovalLevelIdOnChange");
span.setAttribute("outsystems.function.key", "a3bc9c69-c60b-456b-bf23-3db9c4c5ee14");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_l_ProposalApprovalLevelIdOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_downloadFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "a991b5e4-0da9-4b28-8dda-e9d6f58069ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadFile");
callContext = controller.callContext(callContext);
var downloadFileWithProposalIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadFileWithProposalId
model.flush();
return controller.downloadFileWithProposalId$ServerAction(model.variables.i_ProposalIdIn, callContext).then(function (value) {
downloadFileWithProposalIdVar.value = value;
}).then(function () {
if((((downloadFileWithProposalIdVar.value.o_FilenameOut) !== ("")))) {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadFileWithProposalIdVar.value.o_BinaryDataOut, downloadFileWithProposalIdVar.value.o_FilenameOut));
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("l9WpCHu_6km6Ox458YgURg#Message.525723613.1", "File not found."), /*Error*/ 3);
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
_closeSidebar$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseSidebar", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "aafcee30-dc32-40d3-8f5c-62d7190582e7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
var sidebarDocumentCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarLog"), callContext);

// Execute Action: SidebarDocumentClose
sidebarDocumentCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarDocumentLog"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_seeLogsOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeLogsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "ace45e9c-2816-4088-b559-43b9a2f528c6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SeeLogsOnClick");
callContext = controller.callContext(callContext);
var sidebarOpenVar = new OS$DataTypes.VariableHolder();
// l_RefeshSideBar = CurrDateTime
model.variables.l_RefeshSideBarVar = OS$BuiltinFunctions.currDateTime();
// Execute Action: SidebarOpen
sidebarOpenVar.value = OutSystemsUIController$sidebarOpen$Action(idService.getId("SidebarLog"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openUnpaidDetailPopup$Action(i_ProposalLineIdSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenUnpaidDetailPopup", function (span) {
if(span) {
span.setAttribute("code.function", "OpenUnpaidDetailPopup");
span.setAttribute("outsystems.function.key", "af42c372-a3d0-4826-8d31-a50929e7c4eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenUnpaidDetailPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.OpenUnpaidDetailPopup$vars"))());
vars.value.i_ProposalLineIdSelectedInLocal = i_ProposalLineIdSelectedIn;
// l_ProposalLineId = i_ProposalLineIdSelected
model.variables.l_ProposalLineIdVar = vars.value.i_ProposalLineIdSelectedInLocal;
// Execute Action: ShowHideUnpaidPopup
controller._showHideUnpaidPopup$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_showDocumentLog$Action(l_DocumentIdIn, l_DocumentNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowDocumentLog", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDocumentLog");
span.setAttribute("outsystems.function.key", "b3641012-d367-4dab-8406-a5320bad0909");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowDocumentLog");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.ShowDocumentLog$vars"))());
vars.value.l_DocumentIdInLocal = l_DocumentIdIn;
vars.value.l_DocumentNumberInLocal = l_DocumentNumberIn;
var sidebarOpenVar = new OS$DataTypes.VariableHolder();
// l_SelectdLogDocumentId = l_DocumentId
model.variables.l_SelectdLogDocumentIdVar = vars.value.l_DocumentIdInLocal;
// l_RefeshDocumentSideBar = CurrDateTime
model.variables.l_RefeshDocumentSideBarVar = OS$BuiltinFunctions.currDateTime();
// l_SelectdLogDocumentNumber = l_DocumentNumber
model.variables.l_SelectdLogDocumentNumberVar = vars.value.l_DocumentNumberInLocal;
// Execute Action: SidebarOpen
sidebarOpenVar.value = OutSystemsUIController$sidebarOpen$Action(idService.getId("SidebarDocumentLog"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getProposalLinesBOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalLinesBOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesBOnAfterFetch");
span.setAttribute("outsystems.function.key", "ba786ce6-4654-4de8-83fb-e8d2dc7c84ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalLinesBOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetProposalLinesBVar === 0))) {
// l_CountAfterFetchGetProposalLinesB = l_CountAfterFetchGetProposalLinesB + 1
model.variables.l_CountAfterFetchGetProposalLinesBVar = (model.variables.l_CountAfterFetchGetProposalLinesBVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresProposaDetailEditlProposalLinesB"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetProposalLinesB = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetProposalLinesBVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// l_Loading = False
model.variables.l_LoadingVar = false;
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
_cancelProposal$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelProposal", function (span) {
if(span) {
span.setAttribute("code.function", "CancelProposal");
span.setAttribute("outsystems.function.key", "c1e21fa9-e239-449f-8af7-a37b7c12a4c5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CancelProposal");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
try {// Execute Action: ShowHidePopup
controller._showHideCancelPopup$Action(callContext);
// Destination: /ConectaProveedores/ProposalDetail
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetail", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} catch (ex) {
(function () {
OS$Logger.debug("ProposalDetail.CancelProposal", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "5ed129c7-6ec8-44b8-8845-a9d97b7253a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8EE84qYtREezmBYosFR7SQ#Message.1425732877.1", "Error while trying to cancel the proposal!"), /*Error*/ 3);
return ;

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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "df4abd5d-05b7-4dae-8778-72dc6b34e707");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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

showHideCancelPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideCancelPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideCancelPopup");
span.setAttribute("outsystems.function.key", "02c3e6b6-ded5-4f62-b963-4f2f4c69a73d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideCancelPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getProposalByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "2125ab6d-faf2-41ef-bd71-009c68609dd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showHideUnpaidPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideUnpaidPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideUnpaidPopup");
span.setAttribute("outsystems.function.key", "252aa26e-cc1f-4766-98bf-44221e1dfca3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideUnpaidPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

undoReject$Action(i_ProposalIdSelectedIn, i_ProposalLineApprovalLevelIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UndoReject__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UndoReject");
span.setAttribute("outsystems.function.key", "38e67339-373b-429c-b48b-9f00c3d93afe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._undoReject$Action, callContext, i_ProposalIdSelectedIn, i_ProposalLineApprovalLevelIdSelectedIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "3ea9f7a5-3449-45b5-84bf-d46720aaa2d6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._columnTogglerPassColumn$Action, callContext, columnJSONIn);
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
span.setAttribute("outsystems.function.key", "61beb9e6-e100-46d4-abb9-d78ed510b2e5");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "67a535ad-f429-405d-b8d2-bf5fb56191d4");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "8b8fd383-555e-4c8c-a036-3fadf8afd54b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setColumnVisiblityOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getProposalApprovalLevelsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalApprovalLevelsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalApprovalLevelsOnAfterFetch");
span.setAttribute("outsystems.function.key", "99d799b7-a1c6-432e-a038-fe5d69600228");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalApprovalLevelsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_l_ProposalApprovalLevelIdOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_l_ProposalApprovalLevelIdOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_l_ProposalApprovalLevelIdOnChange");
span.setAttribute("outsystems.function.key", "a3bc9c69-c60b-456b-bf23-3db9c4c5ee14");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_l_ProposalApprovalLevelIdOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

downloadFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "a991b5e4-0da9-4b28-8dda-e9d6f58069ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadFile$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

closeSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "aafcee30-dc32-40d3-8f5c-62d7190582e7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeSidebar$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

seeLogsOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeLogsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "ace45e9c-2816-4088-b559-43b9a2f528c6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._seeLogsOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openUnpaidDetailPopup$Action(i_ProposalLineIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenUnpaidDetailPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenUnpaidDetailPopup");
span.setAttribute("outsystems.function.key", "af42c372-a3d0-4826-8d31-a50929e7c4eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openUnpaidDetailPopup$Action, callContext, i_ProposalLineIdSelectedIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

showDocumentLog$Action(l_DocumentIdIn, l_DocumentNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowDocumentLog__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDocumentLog");
span.setAttribute("outsystems.function.key", "b3641012-d367-4dab-8406-a5320bad0909");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showDocumentLog$Action, callContext, l_DocumentIdIn, l_DocumentNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getProposalLinesBOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalLinesBOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesBOnAfterFetch");
span.setAttribute("outsystems.function.key", "ba786ce6-4654-4de8-83fb-e8d2dc7c84ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalLinesBOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

cancelProposal$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelProposal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelProposal");
span.setAttribute("outsystems.function.key", "c1e21fa9-e239-449f-8af7-a37b7c12a4c5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._cancelProposal$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "df4abd5d-05b7-4dae-8778-72dc6b34e707");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._paginationOnNavigate$Action, callContext, newStartIndexIn);
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
return ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ComissionesArrendamientosViewer, ConectaProveedoresController$default.roles.ComissionesArrendamientosAdmin]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail$ActionUndoReject", [{
name: "o_HasProposalChangedStatus",
attrName: "o_HasProposalChangedStatusOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail$ActionDownloadFileWithProposalId", [{
name: "o_Filename",
attrName: "o_FilenameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_BinaryData",
attrName: "o_BinaryDataOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.UndoReject$vars", [{
name: "i_ProposalIdSelected",
attrName: "i_ProposalIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_ProposalLineApprovalLevelIdSelected",
attrName: "i_ProposalLineApprovalLevelIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.OpenUnpaidDetailPopup$vars", [{
name: "i_ProposalLineIdSelected",
attrName: "i_ProposalLineIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.ShowDocumentLog$vars", [{
name: "l_DocumentId",
attrName: "l_DocumentIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "l_DocumentNumber",
attrName: "l_DocumentNumberInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.PaginationOnNavigate$vars", [{
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


