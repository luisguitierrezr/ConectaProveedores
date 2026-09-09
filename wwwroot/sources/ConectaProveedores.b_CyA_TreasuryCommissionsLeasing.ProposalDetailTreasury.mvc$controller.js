import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Authorization as OS$Authorization, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getApprovalStatuses$AggrRefresh: 0,
getProposalLinesByProposalId$AggrRefresh: -1,
getProposalById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getApprovalStatuses$AggrRefresh: [],
getProposalLinesByProposalId$AggrRefresh: [],
getProposalById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("DownloadFileWithProposalId", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionDownloadFileWithProposalId", "orzRncjq6at+5OYp6Ib1PA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionDownloadFileWithProposalId"))();
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionGetSettings"))();
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
payMultipleProposalLine$ServerAction(i_ProposalLinelIdListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PayMultipleProposalLine", function (span) {
if(span) {
span.setAttribute("code.function", "PayMultipleProposalLine");
span.setAttribute("outsystems.function.key", "3f2653ce-66b1-4b10-a8d7-628680cde41e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalLinelIdList: OS$DataConversion.ServerDataConverter.to(i_ProposalLinelIdListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("PayMultipleProposalLine", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionPayMultipleProposalLine", "TI7cuKtSxBcQXdsgwIjhaw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionPayMultipleProposalLine"))();
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
payUnpaySingleProposalLine$ServerAction(i_ProposalLineIdIn, i_IsPayIn, i_CommentIn, i_BinaryIn, i_FilenameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PayUnpaySingleProposalLine", function (span) {
if(span) {
span.setAttribute("code.function", "PayUnpaySingleProposalLine");
span.setAttribute("outsystems.function.key", "84c5752e-e525-491e-980e-8915d23cc8c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalLineId: OS$DataConversion.ServerDataConverter.to(i_ProposalLineIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsPay: OS$DataConversion.ServerDataConverter.to(i_IsPayIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Binary: OS$DataConversion.ServerDataConverter.to(i_BinaryIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
}),
i_Filename: OS$DataConversion.ServerDataConverter.to(i_FilenameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("PayUnpaySingleProposalLine", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionPayUnpaySingleProposalLine", "NUg35lY6yeqQ7J6gbZnlBg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionPayUnpaySingleProposalLine"))();
executeServerActionResult.o_HasProposalChangedStatusOut = OS$DataConversion.ServerDataConverter.from(outputs.o_HasProposalChangedStatus, OS$DataTypes.DataTypes.Boolean);
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
claimProposalTreasury$ServerAction(i_ProposalIdIn, i_UserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClaimProposalTreasury", function (span) {
if(span) {
span.setAttribute("code.function", "ClaimProposalTreasury");
span.setAttribute("outsystems.function.key", "6511c909-2843-402f-99db-0b4e12a70403");
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
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ClaimProposalTreasury", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ActionClaimProposalTreasury", "DsiygcVP6w+YIuPZ+KtsGA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionClaimProposalTreasury"))();
executeServerActionResult.o_IsSuccessOut = OS$DataConversion.ServerDataConverter.from(outputs.o_IsSuccess, OS$DataTypes.DataTypes.Boolean);
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
get getApprovalStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalStatuses$AggrRefresh"))) {
this._getApprovalStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalStatuses", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ScreenDataSetGetApprovalStatuses", "SOfFGGF3iufQOk4hAyThKw", maxRecords, startIndex, function (b) {
model.variables.getApprovalStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalStatuses");
span.setAttribute("outsystems.function.key", "621fa7d3-db1b-4b7d-b1c3-860a2e75bb83");
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

return this._getApprovalStatuses$AggrRefresh;
}set getApprovalStatuses$AggrRefresh(value) {this._getApprovalStatuses$AggrRefresh = value;
}

get getProposalLinesByProposalId$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLinesByProposalId$AggrRefresh"))) {
this._getProposalLinesByProposalId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLinesByProposalId", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ScreenDataSetGetProposalLinesByProposalId", "o5BbsSc7WXgh_lqLaAJ3_w", maxRecords, startIndex, function (b) {
model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLinesByProposalIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLinesByProposalIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalLinesByProposalIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLinesByProposalId", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesByProposalId");
span.setAttribute("outsystems.function.key", "679d31df-7afb-4ad8-87ee-3d092226126a");
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

get getProposalById$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalById$AggrRefresh"))) {
this._getProposalById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalById", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/ProposalDetailTreasury/ScreenDataSetGetProposalById", "W2z1emK4zPon+dOcI9RdSw", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "e3c234c9-9df1-46ab-b9d9-88dc9adac493");
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


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getApprovalStatuses$AggrRefresh", "getProposalLinesByProposalId$AggrRefresh", "getProposalById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdown_l_PaymentStatusOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_l_PaymentStatusOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_l_PaymentStatusOnChange");
span.setAttribute("outsystems.function.key", "01ed8100-4f4d-4e9f-8b49-f82e609752b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_l_PaymentStatusOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_seeLogsOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeLogsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "0963e466-9ac0-4a52-95ef-747c4f02f450");
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
_wb_RejectPaymentPopupReject$Action(hasProposalChangedStatusIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_RejectPaymentPopupReject", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_RejectPaymentPopupReject");
span.setAttribute("outsystems.function.key", "0f96ba8e-2327-4350-a84e-a57ffb87c778");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_RejectPaymentPopupReject");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.Wb_RejectPaymentPopupReject$vars"))());
vars.value.hasProposalChangedStatusInLocal = hasProposalChangedStatusIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.hasProposalChangedStatusInLocal)) {
// Refresh Query: GetProposalById
var result = controller.getProposalById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
} else {
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// Execute Action: ShowHideUnpayPaymentPopup
controller._showHideUnpayPaymentPopup$Action(callContext);
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
_showDocumentLog$Action(l_DocumentIdIn, l_DocumentNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowDocumentLog", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDocumentLog");
span.setAttribute("outsystems.function.key", "138c2f4e-620d-4df1-b2a5-1cc2ad34a89f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowDocumentLog");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.ShowDocumentLog$vars"))());
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
_downloadFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "1c9f92a2-e5c5-4900-84e3-63bfa3fa2193");
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cPitXzcB90WmTvuBTHaGdA#Message.525723613.1", "File not found."), /*Error*/ 3);
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "2808fa9c-4285-4bd9-8538-8d64ad795f0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_showHideUnpaidPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideUnpaidPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideUnpaidPopup");
span.setAttribute("outsystems.function.key", "2c5f1e52-6c0e-4d91-a2b6-48c9b91bbe80");
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "30e815fb-b871-4a37-8225-2db77571be7c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresProposalDetailTreasuryGetProposa"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetProposalDetailTreasury = ColumnJSON
model.variables.l_ColumnJSONVarGetProposalDetailTreasuryVar = vars.value.columnJSONInLocal;
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
_selectAllLines$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectAllLines", function (span) {
if(span) {
span.setAttribute("code.function", "SelectAllLines");
span.setAttribute("outsystems.function.key", "354b500d-32e3-47b1-9d72-75ac3376c2e7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectAllLines");
callContext = controller.callContext(callContext);
if((model.variables.l_IsSelectAllVar)) {
// l_IsSelected = True
model.variables.l_IsSelectedVar = true;
// Foreach GetProposalLinesByProposalId.List
callContext.iterationContext.registerIterationStart(model.variables.getProposalLinesByProposalIdAggr.listOut);
try {var getProposalLinesByProposalIdIterator = callContext.iterationContext.getIterator(model.variables.getProposalLinesByProposalIdAggr.listOut);
var getProposalLinesByProposalIdIndex = 0;
while (((getProposalLinesByProposalIdIndex < model.variables.getProposalLinesByProposalIdAggr.listOut.length))) {
getProposalLinesByProposalIdIterator.currentRowNumber = getProposalLinesByProposalIdIndex;
// IsSelected = True
// GetProposalLinesByProposalId.List.Current.IsSelected = GetProposalById.List.Current.Proposal.AssignedToId = GetUserId and GetProposalLinesByProposalId.List.Current.ProposalLine.ApprovalStatusId = Approved
model.variables.getProposalLinesByProposalIdAggr.listOut.getItem(getProposalLinesByProposalIdIndex.valueOf()).isSelectedAttr = ((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId()) && (model.variables.getProposalLinesByProposalIdAggr.listOut.getItem(getProposalLinesByProposalIdIndex.valueOf()).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved));
getProposalLinesByProposalIdIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getProposalLinesByProposalIdAggr.listOut);
}

} else {
// Foreach GetProposalLinesByProposalId.List
callContext.iterationContext.registerIterationStart(model.variables.getProposalLinesByProposalIdAggr.listOut);
try {var getProposalLinesByProposalIdIterator = callContext.iterationContext.getIterator(model.variables.getProposalLinesByProposalIdAggr.listOut);
var getProposalLinesByProposalIdIndex = 0;
while (((getProposalLinesByProposalIdIndex < model.variables.getProposalLinesByProposalIdAggr.listOut.length))) {
getProposalLinesByProposalIdIterator.currentRowNumber = getProposalLinesByProposalIdIndex;
// IsSelected = False
// GetProposalLinesByProposalId.List.Current.IsSelected = False
model.variables.getProposalLinesByProposalIdAggr.listOut.getItem(getProposalLinesByProposalIdIndex.valueOf()).isSelectedAttr = false;
getProposalLinesByProposalIdIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getProposalLinesByProposalIdAggr.listOut);
}

// l_IsSelected = False
model.variables.l_IsSelectedVar = false;
}

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
span.setAttribute("outsystems.function.key", "38eb0fd1-df3f-4ee6-987d-b2611cae21a1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Proposal status to be on this screen?
return OS$Flow.executeSequence(function () {
if((((((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.approved) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.beingPaid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid)))) {
// DateTextFormatted = FormatDateTime
model.variables.dateTextFormattedVar = OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.textToDateTime(OS$BuiltinFunctions.dateToText(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr)), "dd/MM/yyyy");
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
});
} else {
// Destination: /ConectaProveedores/ProposalsTreasury
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsTreasury", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "52dc1a78-02cc-4598-af51-d7f30e4a49ee");
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
rec.screenAttr = "CyA - Proposal Detail Treasury";
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
_getProposalLinesByProposalIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalLinesByProposalIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesByProposalIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "5f572155-b314-4f96-a8a7-7a35a9ba2d84");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalLinesByProposalIdOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getProposalLinesByProposalIdAggr.listOut, function (p) {
return ((p.proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved) || (p.proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notPaid));
}, callContext);

// i_IsShowSelectAll = ListIndexOf.Position <> -1
model.variables.i_IsShowSelectAllVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetProposalDetailTreasuryVar === 0))) {
// l_CountAfterFetchGetProposalDetailTreasury = l_CountAfterFetchGetProposalDetailTreasury + 1
model.variables.l_CountAfterFetchGetProposalDetailTreasuryVar = (model.variables.l_CountAfterFetchGetProposalDetailTreasuryVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresProposalDetailTreasuryGetProposa"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetProposalDetailTreasury = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetProposalDetailTreasuryVar = getSettingsVar.value.outSettingsTextOut;
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
_isAnyLineSelected$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("IsAnyLineSelected", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "659ba6ab-28fa-4aec-8f79-dc591b4cdcd4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("IsAnyLineSelected");
callContext = controller.callContext(callContext);
var listIndexOf2Var = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getProposalLinesByProposalIdAggr.listOut, function (p) {
return ((!(p.isSelectedAttr)) && (p.proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved));
}, callContext);

if((((listIndexOfVar.value.positionOut) !== ((-1))))) {
// Execute Action: ListIndexOf2
listIndexOf2Var.value = OS$SystemActions.listIndexOf(model.variables.getProposalLinesByProposalIdAggr.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// l_IsSelected = ListIndexOf2.Position <> -1
model.variables.l_IsSelectedVar = ((listIndexOf2Var.value.positionOut) !== ((-1)));
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
} else {
// l_IsSelectAll = True
model.variables.l_IsSelectAllVar = true;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_paySelectedOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaySelectedOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "PaySelectedOnClick");
span.setAttribute("outsystems.function.key", "98410bd5-ec78-4f9c-9120-50028cab7b66");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaySelectedOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.PaySelectedOnClick$vars"))());
var payMultipleProposalLineVar = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getProposalLinesByProposalIdAggr.listOut, function (p) {
return ((p.isSelectedAttr && (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId())) && (p.proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(vars.value.l__ProposalLinelIdListVar, listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).proposalLineAttr.idAttr, callContext);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

// Execute Action: PayMultipleProposalLine
model.flush();
return controller.payMultipleProposalLine$ServerAction(vars.value.l__ProposalLinelIdListVar, callContext).then(function (value) {
payMultipleProposalLineVar.value = value;
}).then(function () {
// Execute Action: ListClear
OS$SystemActions.listClear(vars.value.l__ProposalLinelIdListVar, callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yP+ivMeLKUmqkI+aGMXoqw#Message.1358550852.1", "Your proposal lines have been paid."), /*Success*/ 1);
}).then(function () {
return OS$Flow.executeSequence(function () {
if((payMultipleProposalLineVar.value.o_HasProposalChangedStatusOut)) {
// Refresh Query: GetProposalById
var result = controller.getProposalById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
} else {
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result;
}

});
}).then(function () {
// Reset SelectAll
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// l_IsSelected = False
model.variables.l_IsSelectedVar = false;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_openUnpaidDetailPopup$Action(i_ProposalLineIdSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenUnpaidDetailPopup", function (span) {
if(span) {
span.setAttribute("code.function", "OpenUnpaidDetailPopup");
span.setAttribute("outsystems.function.key", "a4c3e013-2262-40f9-beba-126d7ef2fd2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenUnpaidDetailPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.OpenUnpaidDetailPopup$vars"))());
vars.value.i_ProposalLineIdSelectedInLocal = i_ProposalLineIdSelectedIn;
// l_ProposalLinelIdUnpaidDetail = i_ProposalLineIdSelected
model.variables.l_ProposalLinelIdUnpaidDetailVar = vars.value.i_ProposalLineIdSelectedInLocal;
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
_payOnClick$Action(i_ProposalLineIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PayOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "PayOnClick");
span.setAttribute("outsystems.function.key", "b957e083-1c03-41cb-b86b-278412ad347b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PayOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.PayOnClick$vars"))());
vars.value.i_ProposalLineIdInLocal = i_ProposalLineIdIn;
var payUnpaySingleProposalLineVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: PayUnpaySingleProposalLine
model.flush();
return controller.payUnpaySingleProposalLine$ServerAction(vars.value.i_ProposalLineIdInLocal, true, "", OS$DataTypes.BinaryData.defaultValue, "", callContext).then(function (value) {
payUnpaySingleProposalLineVar.value = value;
}).then(function () {
// IsSuccess?
return OS$Flow.executeSequence(function () {
if((payUnpaySingleProposalLineVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("c0RlhqMM_0yDJPyROoTX3Q#Message.-1328488750.1", "Proposal line has been paid."), /*Success*/ 1);
return OS$Flow.executeSequence(function () {
if((payUnpaySingleProposalLineVar.value.o_HasProposalChangedStatusOut)) {
// Refresh Query: GetProposalById
var result = controller.getProposalById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
} else {
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(payUnpaySingleProposalLineVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
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
_openUnpayPaymentPopup$Action(l_ProposalLinelIdSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenUnpayPaymentPopup", function (span) {
if(span) {
span.setAttribute("code.function", "OpenUnpayPaymentPopup");
span.setAttribute("outsystems.function.key", "c753e9f9-6065-4481-b689-b31cdf7d8ac4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenUnpayPaymentPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.OpenUnpayPaymentPopup$vars"))());
vars.value.l_ProposalLinelIdSelectedInLocal = l_ProposalLinelIdSelectedIn;
// l_ProposalLineIdForPopup = l_ProposalLinelIdSelected
model.variables.l_ProposalLineIdForPopupVar = vars.value.l_ProposalLinelIdSelectedInLocal;
// Execute Action: ShowHideUnpayPaymentPopup
controller._showHideUnpayPaymentPopup$Action(callContext);
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "cc9706ad-386a-4a87-ab5d-4b46467caea9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarClose2Var = new OS$DataTypes.VariableHolder();
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarLog"), callContext);

// Execute Action: SidebarClose2
sidebarClose2Var.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarDocumentLog"), callContext);

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
span.setAttribute("outsystems.function.key", "e0251bb3-9a38-4145-95d3-77af3c8cb42d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.OnSort$vars"))());
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
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_claimProposal$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClaimProposal", function (span) {
if(span) {
span.setAttribute("code.function", "ClaimProposal");
span.setAttribute("outsystems.function.key", "e4e5239a-a884-47ef-912e-05cfed7fcf94");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClaimProposal");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var claimProposalTreasuryVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_ClaimEnable = False
model.variables.l_ClaimEnableVar = false;
// Execute Action: ClaimProposalTreasury
model.flush();
return controller.claimProposalTreasury$ServerAction(model.variables.i_ProposalIdIn, OS$BuiltinFunctions.getUserId(), callContext).then(function (value) {
claimProposalTreasuryVar.value = value;
}).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qvFvmnR7AESu4GZ89YNNOw#Message.989009417.1", "The proposal has been assigned to you, successfully!"), /*Success*/ 1);
// Refresh Query: GetProposalById
var result = controller.getProposalById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// l_ClaimEnable = True
model.variables.l_ClaimEnableVar = true;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
});
}).catch(function (ex) {
OS$Logger.debug("ProposalDetailTreasury.ClaimProposal", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "9bf332e9-92e7-4655-90ea-ec3bc7bd0335");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// l_ClaimEnable = True
model.variables.l_ClaimEnableVar = true;
return OS$Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
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
span.setAttribute("outsystems.function.key", "e823aab7-abb2-43b2-b90f-31216a09b219");
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
_showHideUnpayPaymentPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideUnpayPaymentPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideUnpayPaymentPopup");
span.setAttribute("outsystems.function.key", "ecd153d1-4cd9-46bf-9b40-d0a79962cbd3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideUnpayPaymentPopup");
callContext = controller.callContext(callContext);
// ShowConfirmPopup
// l_ShowUnpayPopup = notl_ShowUnpayPopup
model.variables.l_ShowUnpayPopupVar = (!(model.variables.l_ShowUnpayPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

dropdown_l_PaymentStatusOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_l_PaymentStatusOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_l_PaymentStatusOnChange");
span.setAttribute("outsystems.function.key", "01ed8100-4f4d-4e9f-8b49-f82e609752b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_l_PaymentStatusOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

seeLogsOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeLogsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "0963e466-9ac0-4a52-95ef-747c4f02f450");
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

wb_RejectPaymentPopupReject$Action(hasProposalChangedStatusIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_RejectPaymentPopupReject__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_RejectPaymentPopupReject");
span.setAttribute("outsystems.function.key", "0f96ba8e-2327-4350-a84e-a57ffb87c778");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_RejectPaymentPopupReject$Action, callContext, hasProposalChangedStatusIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showDocumentLog$Action(l_DocumentIdIn, l_DocumentNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowDocumentLog__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDocumentLog");
span.setAttribute("outsystems.function.key", "138c2f4e-620d-4df1-b2a5-1cc2ad34a89f");
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

downloadFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "1c9f92a2-e5c5-4900-84e3-63bfa3fa2193");
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

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "2808fa9c-4285-4bd9-8538-8d64ad795f0c");
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

showHideUnpaidPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideUnpaidPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideUnpaidPopup");
span.setAttribute("outsystems.function.key", "2c5f1e52-6c0e-4d91-a2b6-48c9b91bbe80");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "30e815fb-b871-4a37-8225-2db77571be7c");
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

selectAllLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectAllLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectAllLines");
span.setAttribute("outsystems.function.key", "354b500d-32e3-47b1-9d72-75ac3376c2e7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._selectAllLines$Action, callContext);
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
span.setAttribute("outsystems.function.key", "38eb0fd1-df3f-4ee6-987d-b2611cae21a1");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "52dc1a78-02cc-4598-af51-d7f30e4a49ee");
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

getProposalLinesByProposalIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalLinesByProposalIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesByProposalIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "5f572155-b314-4f96-a8a7-7a35a9ba2d84");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalLinesByProposalIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

isAnyLineSelected$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("IsAnyLineSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "659ba6ab-28fa-4aec-8f79-dc591b4cdcd4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._isAnyLineSelected$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

paySelectedOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaySelectedOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaySelectedOnClick");
span.setAttribute("outsystems.function.key", "98410bd5-ec78-4f9c-9120-50028cab7b66");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._paySelectedOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

openUnpaidDetailPopup$Action(i_ProposalLineIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenUnpaidDetailPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenUnpaidDetailPopup");
span.setAttribute("outsystems.function.key", "a4c3e013-2262-40f9-beba-126d7ef2fd2b");
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

payOnClick$Action(i_ProposalLineIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PayOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PayOnClick");
span.setAttribute("outsystems.function.key", "b957e083-1c03-41cb-b86b-278412ad347b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._payOnClick$Action, callContext, i_ProposalLineIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

openUnpayPaymentPopup$Action(l_ProposalLinelIdSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenUnpayPaymentPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenUnpayPaymentPopup");
span.setAttribute("outsystems.function.key", "c753e9f9-6065-4481-b689-b31cdf7d8ac4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openUnpayPaymentPopup$Action, callContext, l_ProposalLinelIdSelectedIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

closeSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "cc9706ad-386a-4a87-ab5d-4b46467caea9");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "e0251bb3-9a38-4145-95d3-77af3c8cb42d");
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

claimProposal$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClaimProposal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClaimProposal");
span.setAttribute("outsystems.function.key", "e4e5239a-a884-47ef-912e-05cfed7fcf94");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._claimProposal$Action, callContext);
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
span.setAttribute("outsystems.function.key", "e823aab7-abb2-43b2-b90f-31216a09b219");
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

showHideUnpayPaymentPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideUnpayPaymentPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideUnpayPaymentPopup");
span.setAttribute("outsystems.function.key", "ecd153d1-4cd9-46bf-9b40-d0a79962cbd3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideUnpayPaymentPopup$Action, callContext);
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
return ConectaProveedores_b_CyA_TreasuryCommissionsLeasingController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Tesoreria]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionDownloadFileWithProposalId", [{
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionPayMultipleProposalLine", [{
name: "o_HasProposalChangedStatus",
attrName: "o_HasProposalChangedStatusOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionPayUnpaySingleProposalLine", [{
name: "o_HasProposalChangedStatus",
attrName: "o_HasProposalChangedStatusOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury$ActionClaimProposalTreasury", [{
name: "o_IsSuccess",
attrName: "o_IsSuccessOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.Wb_RejectPaymentPopupReject$vars", [{
name: "HasProposalChangedStatus",
attrName: "hasProposalChangedStatusInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.ShowDocumentLog$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.PaySelectedOnClick$vars", [{
name: "l__ProposalLinelIdList",
attrName: "l__ProposalLinelIdListVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new OS$DataTypes.LongIntegerList();
},
complexType: OS$DataTypes.LongIntegerList
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.OpenUnpaidDetailPopup$vars", [{
name: "i_ProposalLineIdSelected",
attrName: "i_ProposalLineIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.PayOnClick$vars", [{
name: "i_ProposalLineId",
attrName: "i_ProposalLineIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.OpenUnpayPaymentPopup$vars", [{
name: "l_ProposalLinelIdSelected",
attrName: "l_ProposalLinelIdSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.OnSort$vars", [{
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


