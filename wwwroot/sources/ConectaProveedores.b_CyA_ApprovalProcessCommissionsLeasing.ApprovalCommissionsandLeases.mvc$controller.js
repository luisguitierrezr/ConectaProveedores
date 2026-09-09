import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions, BuiltinFunctions as OS$BuiltinFunctions, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { sidebarClose$Action as OutSystemsUIController$sidebarClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, datePickerClose$Action as OutSystemsUIController$datePickerClose$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { RC_474c5c8cc36282ebfc11b03838b11802, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import { SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_ApprovalCommissionsandLeases_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getProposalLines$AggrRefresh: -1,
getOperators$AggrRefresh: 0,
getBanks$AggrRefresh: 0,
getProposalLinesSum$AggrRefresh: -1,
getProposalType$AggrRefresh: 0,
getCompanies$AggrRefresh: 0,
getApprovalStatuses$AggrRefresh: 0,
getUserApplicationRoles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getProposalLines$AggrRefresh: [],
getOperators$AggrRefresh: [],
getBanks$AggrRefresh: [],
getProposalLinesSum$AggrRefresh: [],
getProposalType$AggrRefresh: [],
getCompanies$AggrRefresh: [],
getApprovalStatuses$AggrRefresh: [],
getUserApplicationRoles$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approveRejectSingleProposalLineApprovalLevel$ServerAction(i_ProposalIdIn, i_ProposalLineApprovalLevelIdIn, i_IsRejectIn, i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveRejectSingleProposalLineApprovalLevel", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRejectSingleProposalLineApprovalLevel");
span.setAttribute("outsystems.function.key", "cbd322d5-0b24-4e90-baaa-f350b3ab5dde");
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
}),
i_IsReject: OS$DataConversion.ServerDataConverter.to(i_IsRejectIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApproveRejectSingleProposalLineApprovalLevel", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ActionApproveRejectSingleProposalLineApprovalLevel", "oV5RW64HGgfchjl2JqmJ0Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases$ActionApproveRejectSingleProposalLineApprovalLevel"))();
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
approveMultipleProposalLineApprovalLevel$ServerAction(i_ProposalLineApprovalLevelIdListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveMultipleProposalLineApprovalLevel", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveMultipleProposalLineApprovalLevel");
span.setAttribute("outsystems.function.key", "e93ec8b5-40f3-422c-a112-66c1fb6aba47");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalLineApprovalLevelIdList: OS$DataConversion.ServerDataConverter.to(i_ProposalLineApprovalLevelIdListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApproveMultipleProposalLineApprovalLevel", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ActionApproveMultipleProposalLineApprovalLevel", "WvM+wke2_eYgXC0TSkx0uQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases$ActionGetSettings"))();
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getProposalLines$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLines$AggrRefresh"))) {
this._getProposalLines$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLines", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetProposalLines", "_I_MxuZmwY8LvMO+T53C6A", maxRecords, startIndex, function (b) {
model.variables.getProposalLinesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLinesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLinesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalLinesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLines", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLines");
span.setAttribute("outsystems.function.key", "21394e4f-20a1-486d-a42c-30f74c8166f6");
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

return this._getProposalLines$AggrRefresh;
}set getProposalLines$AggrRefresh(value) {this._getProposalLines$AggrRefresh = value;
}

get getOperators$AggrRefresh() {if(!(this.hasOwnProperty("_getOperators$AggrRefresh"))) {
this._getOperators$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOperators", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetOperators", "FLVfBwjABjz9rC3dLNwU+w", maxRecords, startIndex, function (b) {
model.variables.getOperatorsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOperatorsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOperatorsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOperators", function (span) {
if(span) {
span.setAttribute("code.function", "GetOperators");
span.setAttribute("outsystems.function.key", "2b3a3528-7607-4ed6-a5f6-b08a70724a10");
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

return this._getOperators$AggrRefresh;
}set getOperators$AggrRefresh(value) {this._getOperators$AggrRefresh = value;
}

get getBanks$AggrRefresh() {if(!(this.hasOwnProperty("_getBanks$AggrRefresh"))) {
this._getBanks$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBanks", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetBanks", "7ybLE4e_O0XTjUbXrZeJEA", maxRecords, startIndex, function (b) {
model.variables.getBanksAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBanksAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBanksAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBanks", function (span) {
if(span) {
span.setAttribute("code.function", "GetBanks");
span.setAttribute("outsystems.function.key", "3bd949c1-75d4-488c-bd6c-80b385ccd657");
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

return this._getBanks$AggrRefresh;
}set getBanks$AggrRefresh(value) {this._getBanks$AggrRefresh = value;
}

get getProposalLinesSum$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLinesSum$AggrRefresh"))) {
this._getProposalLinesSum$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLinesSum", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetProposalLinesSum", "fIz18otbbTNDZDakOkLJ1A", maxRecords, startIndex, function (b) {
model.variables.getProposalLinesSumAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLinesSumAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLinesSumAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLinesSum", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesSum");
span.setAttribute("outsystems.function.key", "599b1689-aaa4-42aa-8fac-fa4c2b7a65a5");
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

return this._getProposalLinesSum$AggrRefresh;
}set getProposalLinesSum$AggrRefresh(value) {this._getProposalLinesSum$AggrRefresh = value;
}

get getProposalType$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalType$AggrRefresh"))) {
this._getProposalType$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalType", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetProposalType", "LLI8FEO94RAUN2o6yCTqqg", maxRecords, startIndex, function (b) {
model.variables.getProposalTypeAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalTypeAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalTypeAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalType", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalType");
span.setAttribute("outsystems.function.key", "7dae5dfb-c942-42e8-b8a9-b96b238b4055");
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

return this._getProposalType$AggrRefresh;
}set getProposalType$AggrRefresh(value) {this._getProposalType$AggrRefresh = value;
}

get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetCompanies", "dUlLiZXilCXZfHjYY_ZYJg", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "83dee54a-f338-4f44-b2d4-cc21a957dc5c");
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

return this._getCompanies$AggrRefresh;
}set getCompanies$AggrRefresh(value) {this._getCompanies$AggrRefresh = value;
}

get getApprovalStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalStatuses$AggrRefresh"))) {
this._getApprovalStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalStatuses", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/ScreenDataSetGetApprovalStatuses", "g+CnQprbRRjyfmXNHj7_5Q", maxRecords, startIndex, function (b) {
model.variables.getApprovalStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalStatuses");
span.setAttribute("outsystems.function.key", "91b68e83-eaf6-4ace-be97-b5a853aa2e8a");
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

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/b_CyA_ApprovalProcessCommissionsLeasing/ApprovalCommissionsandLeases/DataActionGetUserApplicationRoles", "KJN0iiF+6VDNj5WLLyNy+Q", function (b) {
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
span.setAttribute("outsystems.function.key", "f372aed9-dc80-4168-afe8-f5f4f51ddf9c");
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


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getProposalLines$AggrRefresh", "getOperators$AggrRefresh", "getBanks$AggrRefresh", "getProposalLinesSum$AggrRefresh", "getProposalType$AggrRefresh", "getCompanies$AggrRefresh", "getApprovalStatuses$AggrRefresh", "getUserApplicationRoles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "038ebe1f-9d79-47a9-8ae1-1787f7ad65c1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Commision_Leases_SupplierId = SupplierId
ConectaProveedoresClientVariables.setCommision_Leases_SupplierId(vars.value.supplierIdInLocal);
// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
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
span.setAttribute("outsystems.function.key", "06341375-6a09-4314-930c-7a1c9373a1a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarDocumentCloseVar = new OS$DataTypes.VariableHolder();
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
_selectAllLines$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectAllLines", function (span) {
if(span) {
span.setAttribute("code.function", "SelectAllLines");
span.setAttribute("outsystems.function.key", "0e631b74-54a6-4aed-adf1-7eda00aa2812");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectAllLines");
callContext = controller.callContext(callContext);
if((model.variables.l_IsSelectAllVar)) {
// l_IsSelected = True
model.variables.l_IsSelectedVar = true;
// Foreach GetProposalLines.List
callContext.iterationContext.registerIterationStart(model.variables.getProposalLinesAggr.listOut);
try {var getProposalLinesIterator = callContext.iterationContext.getIterator(model.variables.getProposalLinesAggr.listOut);
var getProposalLinesIndex = 0;
while (((getProposalLinesIndex < model.variables.getProposalLinesAggr.listOut.length))) {
getProposalLinesIterator.currentRowNumber = getProposalLinesIndex;
// IsSelected = True
// GetProposalLines.List.Current.IsSelected = GetProposalLines.List.Current.ProposalLineApprovalLevel.ApprovalStatusId = NotApproved
model.variables.getProposalLinesAggr.listOut.getItem(getProposalLinesIndex.valueOf()).isSelectedAttr = (model.variables.getProposalLinesAggr.listOut.getItem(getProposalLinesIndex.valueOf()).proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved);
getProposalLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getProposalLinesAggr.listOut);
}

} else {
// Foreach GetProposalLines.List
callContext.iterationContext.registerIterationStart(model.variables.getProposalLinesAggr.listOut);
try {var getProposalLinesIterator = callContext.iterationContext.getIterator(model.variables.getProposalLinesAggr.listOut);
var getProposalLinesIndex = 0;
while (((getProposalLinesIndex < model.variables.getProposalLinesAggr.listOut.length))) {
getProposalLinesIterator.currentRowNumber = getProposalLinesIndex;
// IsSelected = False
// GetProposalLines.List.Current.IsSelected = False
model.variables.getProposalLinesAggr.listOut.getItem(getProposalLinesIndex.valueOf()).isSelectedAttr = false;
getProposalLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getProposalLinesAggr.listOut);
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
_approveOnClick$Action(i_ProposalIdIn, i_ProposalLineApprovalLevelIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveOnClick");
span.setAttribute("outsystems.function.key", "0eb57b65-1f59-452a-82d2-76311b81cf63");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ApproveOnClick$vars"))());
vars.value.i_ProposalIdInLocal = i_ProposalIdIn;
vars.value.i_ProposalLineApprovalLevelIdInLocal = i_ProposalLineApprovalLevelIdIn;
var approveRejectSingleProposalLineApprovalLevelVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ApproveRejectSingleProposalLineApprovalLevel
model.flush();
return controller.approveRejectSingleProposalLineApprovalLevel$ServerAction(vars.value.i_ProposalIdInLocal, vars.value.i_ProposalLineApprovalLevelIdInLocal, false, "", callContext).then(function (value) {
approveRejectSingleProposalLineApprovalLevelVar.value = value;
}).then(function () {
// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}).then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kCsYYmKv0E+renD7x0Sy+g#Message.15392839.1", "Proposal line has been approved."), /*Success*/ 1);
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
_showRejectPopup$Action(i_ProposalIdIn, i_ProposalLineApprovalLevelIdToRejectSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowRejectPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowRejectPopup");
span.setAttribute("outsystems.function.key", "320fd6b4-7825-4937-a93a-194b20c20cd7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowRejectPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ShowRejectPopup$vars"))());
vars.value.i_ProposalIdInLocal = i_ProposalIdIn;
vars.value.i_ProposalLineApprovalLevelIdToRejectSelectedInLocal = i_ProposalLineApprovalLevelIdToRejectSelectedIn;
// l_ProposalIdForRejectPopup = i_ProposalId
model.variables.l_ProposalIdForRejectPopupVar = vars.value.i_ProposalIdInLocal;
// l_ProposalLineApprovalLevelIdToReject = i_ProposalLineApprovalLevelIdToRejectSelected
model.variables.l_ProposalLineApprovalLevelIdToRejectVar = vars.value.i_ProposalLineApprovalLevelIdToRejectSelectedInLocal;
// l_ShowRejectPopup = True
model.variables.l_ShowRejectPopupVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_approveSelectedOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveSelectedOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveSelectedOnClick");
span.setAttribute("outsystems.function.key", "3ac266dd-0e23-449e-8d0f-9e5766e2da28");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveSelectedOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ApproveSelectedOnClick$vars"))());
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getProposalLinesAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(vars.value.l_ProposalLineApprovalLevelIdListVar, function () {
var rec = new RC_474c5c8cc36282ebfc11b03838b11802();
rec.proposalIdAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).proposalAttr.idAttr;
rec.proposalLineApprovalLevelIdAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).proposalLineApprovalLevelAttr.idAttr;
return rec;
}(), callContext);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

// Execute Action: ApproveMultipleProposalLineApprovalLevel
model.flush();
return controller.approveMultipleProposalLineApprovalLevel$ServerAction(vars.value.l_ProposalLineApprovalLevelIdListVar, callContext).then(function () {
// Execute Action: ListClear
OS$SystemActions.listClear(vars.value.l_ProposalLineApprovalLevelIdListVar, callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tnn9oqGfB0iUtrQylYFfUA#Message.-98676807.1", "Your proposal lines have been approved."), /*Success*/ 1);
// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}).then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// Reset SelectAll
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// l_IsSelected = False
model.variables.l_IsSelectedVar = false;
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
_getProposalLinesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalLinesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesOnAfterFetch");
span.setAttribute("outsystems.function.key", "3c9cec9f-1c26-4481-8112-953d97930cde");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalLinesOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getProposalLinesAggr.listOut, function (p) {
return (p.proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved);
}, callContext);

// l_IsShowSelectAll = ListIndexOf.Position <> -1
model.variables.l_IsShowSelectAllVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
// Refresh Query: GetProposalLinesSum
var result = controller.getProposalLinesSum$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetProposalLinesVar === 0))) {
// l_CountAfterFetchGetProposalLines = l_CountAfterFetchGetProposalLines + 1
model.variables.l_CountAfterFetchGetProposalLinesVar = (model.variables.l_CountAfterFetchGetProposalLinesVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresApprovalCommissionsandLeasesGetP"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetProposalLines = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetProposalLinesVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// l_Loading = False
model.variables.l_LoadingVar = false;
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "41c17529-6e21-4313-a347-c7fcf1ace2ea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerClearPaymentDateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Clear filters
// Commision_Leases_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_AssignedTo = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_AssignedTo(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_CompanyId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_CompanyId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_RegionId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_RegionId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_BankId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_BankId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_ProposalSearch = ""
ConectaProveedoresClientVariables.setCommision_Leases_ProposalSearch("");
// Commision_Leases_TypeId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_TypeId(OS$BuiltinFunctions.nullIdentifier());
// Commision_Leases_ApprovalStatusId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_ApprovalStatusId(OS$BuiltinFunctions.nullIdentifier());
// Commision_Leases_UploadDate = NullDate
ConectaProveedoresClientVariables.setCommision_Leases_UploadDate(OS$BuiltinFunctions.nullDate());
// Commision_Leases_PaymentDate = NullDate
ConectaProveedoresClientVariables.setCommision_Leases_PaymentDate(OS$BuiltinFunctions.nullDate());
// Commision_Operator_AmountML = NullTextIdentifier
ConectaProveedoresClientVariables.setCommision_Operator_AmountML(OS$BuiltinFunctions.nullTextIdentifier());
// Commision_Leases_AmountMLFrom = 0
ConectaProveedoresClientVariables.setCommision_Leases_AmountMLFrom(OS$BuiltinFunctions.integerToDecimal(0));
// Commision_Leases_AmountMLTo = 0
ConectaProveedoresClientVariables.setCommision_Leases_AmountMLTo(OS$BuiltinFunctions.integerToDecimal(0));
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
// Execute Action: DatePickerClearPaymentDate
datePickerClearPaymentDateVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerPaymentDate"), callContext);

}

// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "5ee1c2f3-796f-433d-b659-8154ceda7a33");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "896a8b43-dc93-44a4-a2cd-945ec68586b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// No UserApplicationRoles?
return OS$Flow.executeSequence(function () {
if((!(model.variables.getUserApplicationRolesDataAct.userRolesListOut.isEmpty))) {
// l_ApplicationRoleIdForAggregate = GetUserApplicationRoles.UserRolesList[GetUserApplicationRoles.UserRolesList.Length - 1].ApplicationRoleId
model.variables.l_ApplicationRoleIdForAggregateVar = model.variables.getUserApplicationRolesDataAct.userRolesListOut.getItem((model.variables.getUserApplicationRolesDataAct.userRolesListOut.length - 1)).applicationRoleIdAttr;
// Has more than 1 role?
if(((model.variables.getUserApplicationRolesDataAct.userRolesListOut.length > 1))) {
// l_IsAllowSelectApplicationRoles = True
model.variables.l_IsAllowSelectApplicationRolesVar = true;
}

// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_isAnyLineSelected$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("IsAnyLineSelected", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "8e781ba5-d087-42b5-a417-a4ad9e28a4a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("IsAnyLineSelected");
callContext = controller.callContext(callContext);
var listIndexOf2Var = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getProposalLinesAggr.listOut, function (p) {
return ((!(p.isSelectedAttr)) && (p.proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
}, callContext);

if((((listIndexOfVar.value.positionOut) !== ((-1))))) {
// Execute Action: ListIndexOf2
listIndexOf2Var.value = OS$SystemActions.listIndexOf(model.variables.getProposalLinesAggr.listOut, function (p) {
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "a4a9e8ec-131c-4602-a977-3418f9867a2e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.OnSort$vars"))());
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
// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "a770108b-3725-4487-80f4-8915d92269f3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn2
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresApprovalCommissionsandLeasesGetP"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetProposalLines = ColumnJSON
model.variables.l_ColumnJSONVarGetProposalLinesVar = vars.value.columnJSONInLocal;
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
span.setAttribute("outsystems.function.key", "b4503883-3aa7-4a48-9fca-cd22d7c00474");
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
rec.identifierAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.messageAttr = "";
rec.screenAttr = "CyA - Approval Commissions and Leases";
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
span.setAttribute("outsystems.function.key", "bab1e99e-c046-41bd-8d21-d6dbe9329bba");
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
_expandFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExpandFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "bdaaa254-8693-40e2-bca9-7060f098eeb3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ExpandFilters$vars"))());
return OS$Flow.executeAsyncFlow(function () {
// l_ShowFilters = notl_ShowFilters
model.variables.l_ShowFiltersVar = (!(model.variables.l_ShowFiltersVar));
return OS$Flow.executeSequence(function () {
if((!(model.variables.l_ShowFiltersVar))) {
// IsRefresh = Commision_Leases_SupplierId <> NullIdentifier or Commision_Leases_AssignedTo <> NullIdentifier or Commision_Leases_CompanyId <> NullIdentifier or Commision_Leases_RegionId <> NullIdentifier or Commision_Leases_BankId <> NullIdentifier
vars.value.isRefreshVar = ((((!(ConectaProveedoresClientVariables.getCommision_Leases_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getCommision_Leases_AssignedTo().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_BankId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
// Clear filters
// Commision_Leases_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_AssignedTo = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_AssignedTo(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_CompanyId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_CompanyId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_RegionId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_RegionId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_BankId = NullIdentifier
ConectaProveedoresClientVariables.setCommision_Leases_BankId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Commision_Leases_AmountMLFrom = 0
ConectaProveedoresClientVariables.setCommision_Leases_AmountMLFrom(OS$BuiltinFunctions.integerToDecimal(0));
// Commision_Leases_AmountMLTo = 0
ConectaProveedoresClientVariables.setCommision_Leases_AmountMLTo(OS$BuiltinFunctions.integerToDecimal(0));
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshVar)) {
// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

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
_showDocumentLog$Action(l_DocumentIdIn, l_DocumentNumberIn, l_ProposalIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowDocumentLog", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDocumentLog");
span.setAttribute("outsystems.function.key", "c0a4ca75-7dbd-4a9e-8c12-19ef1561be9f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowDocumentLog");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ShowDocumentLog$vars"))());
vars.value.l_DocumentIdInLocal = l_DocumentIdIn;
vars.value.l_DocumentNumberInLocal = l_DocumentNumberIn;
vars.value.l_ProposalIdInLocal = l_ProposalIdIn;
var sidebarOpenVar = new OS$DataTypes.VariableHolder();
// l_SelectdLogDocumentId = l_DocumentId
model.variables.l_SelectdLogDocumentIdVar = vars.value.l_DocumentIdInLocal;
// l_RefeshDocumentSideBar = CurrDateTime
model.variables.l_RefeshDocumentSideBarVar = OS$BuiltinFunctions.currDateTime();
// l_SelectdLogDocumentNumber = l_DocumentNumber
model.variables.l_SelectdLogDocumentNumberVar = vars.value.l_DocumentNumberInLocal;
// l_SelectdLogProposalId = l_ProposalId
model.variables.l_SelectdLogProposalIdVar = vars.value.l_ProposalIdInLocal;
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
_datePickerOnPaymentDate$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDate");
span.setAttribute("outsystems.function.key", "d9126b31-3e73-404f-a2b9-7af4c85158a4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnPaymentDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.DatePickerOnPaymentDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Commision_Leases_PaymentDate = SelectedDateTime
ConectaProveedoresClientVariables.setCommision_Leases_PaymentDate(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "eeb16a82-c5fd-40b6-85f5-160f553aee71");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// l_AmountFromText = Commision_Leases_AmountMLFrom
model.variables.l_AmountFromTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getCommision_Leases_AmountMLFrom());
// l_AmountToText = Commision_Leases_AmountMLTo
model.variables.l_AmountToTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getCommision_Leases_AmountMLTo());
// l_ShowFilters = Commision_Leases_SupplierId <> NullIdentifier or Commision_Leases_AssignedTo <> NullIdentifier or Commision_Leases_CompanyId <> NullIdentifier or Commision_Leases_RegionId <> NullIdentifier or Commision_Leases_BankId <> NullIdentifier
model.variables.l_ShowFiltersVar = ((((!(ConectaProveedoresClientVariables.getCommision_Leases_SupplierId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getCommision_Leases_AssignedTo().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getCommision_Leases_BankId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_rejectPopupClose$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RejectPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "RejectPopupClose");
span.setAttribute("outsystems.function.key", "f03ed237-10d7-467a-96da-3fc1fe0d6dee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RejectPopupClose");
callContext = controller.callContext(callContext);
// l_ShowRejectPopup = False
model.variables.l_ShowRejectPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_CalendarClearClear$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CalendarClearClear", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CalendarClearClear");
span.setAttribute("outsystems.function.key", "f414d226-fdd5-40db-bf55-d86713f71977");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CalendarClearClear");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
// Commision_Leases_PaymentDate = NullDate
ConectaProveedoresClientVariables.setCommision_Leases_PaymentDate(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerPaymentDate"), callContext);

// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerPaymentDate"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_rejectPopupReject$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RejectPopupReject", function (span) {
if(span) {
span.setAttribute("code.function", "RejectPopupReject");
span.setAttribute("outsystems.function.key", "fcd8200b-bf08-4433-9992-7df0db938974");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RejectPopupReject");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetProposalLines
var result = controller.getProposalLines$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// l_ShowRejectPopup = False
model.variables.l_ShowRejectPopupVar = false;
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
_onDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "feeb2954-faa2-492e-b81c-eaf3a882fee1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDebounce");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Commision_Leases_AmountMLFrom = TextToDecimal
ConectaProveedoresClientVariables.setCommision_Leases_AmountMLFrom(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountFromTextVar));
// Commision_Leases_AmountMLTo = TextToDecimal
ConectaProveedoresClientVariables.setCommision_Leases_AmountMLTo(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountToTextVar));
// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;

dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "038ebe1f-9d79-47a9-8ae1-1787f7ad65c1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSuppliersOnChanged$Action, callContext, supplierIdIn);
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
span.setAttribute("outsystems.function.key", "06341375-6a09-4314-930c-7a1c9373a1a9");
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

selectAllLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectAllLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectAllLines");
span.setAttribute("outsystems.function.key", "0e631b74-54a6-4aed-adf1-7eda00aa2812");
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

approveOnClick$Action(i_ProposalIdIn, i_ProposalLineApprovalLevelIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveOnClick");
span.setAttribute("outsystems.function.key", "0eb57b65-1f59-452a-82d2-76311b81cf63");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approveOnClick$Action, callContext, i_ProposalIdIn, i_ProposalLineApprovalLevelIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showRejectPopup$Action(i_ProposalIdIn, i_ProposalLineApprovalLevelIdToRejectSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowRejectPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowRejectPopup");
span.setAttribute("outsystems.function.key", "320fd6b4-7825-4937-a93a-194b20c20cd7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showRejectPopup$Action, callContext, i_ProposalIdIn, i_ProposalLineApprovalLevelIdToRejectSelectedIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

approveSelectedOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveSelectedOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveSelectedOnClick");
span.setAttribute("outsystems.function.key", "3ac266dd-0e23-449e-8d0f-9e5766e2da28");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approveSelectedOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getProposalLinesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalLinesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesOnAfterFetch");
span.setAttribute("outsystems.function.key", "3c9cec9f-1c26-4481-8112-953d97930cde");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalLinesOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "41c17529-6e21-4313-a347-c7fcf1ace2ea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refreshList$Action, callContext, i_IsClearFiltersIn);
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
span.setAttribute("outsystems.function.key", "5ee1c2f3-796f-433d-b659-8154ceda7a33");
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

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "896a8b43-dc93-44a4-a2cd-945ec68586b5");
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

isAnyLineSelected$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("IsAnyLineSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "8e781ba5-d087-42b5-a417-a4ad9e28a4a3");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "a4a9e8ec-131c-4602-a977-3418f9867a2e");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "a770108b-3725-4487-80f4-8915d92269f3");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "b4503883-3aa7-4a48-9fca-cd22d7c00474");
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
span.setAttribute("outsystems.function.key", "bab1e99e-c046-41bd-8d21-d6dbe9329bba");
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

expandFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExpandFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "bdaaa254-8693-40e2-bca9-7060f098eeb3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._expandFilters$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showDocumentLog$Action(l_DocumentIdIn, l_DocumentNumberIn, l_ProposalIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowDocumentLog__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDocumentLog");
span.setAttribute("outsystems.function.key", "c0a4ca75-7dbd-4a9e-8c12-19ef1561be9f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showDocumentLog$Action, callContext, l_DocumentIdIn, l_DocumentNumberIn, l_ProposalIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

datePickerOnPaymentDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDate");
span.setAttribute("outsystems.function.key", "d9126b31-3e73-404f-a2b9-7af4c85158a4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnPaymentDate$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "eeb16a82-c5fd-40b6-85f5-160f553aee71");
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

rejectPopupClose$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RejectPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RejectPopupClose");
span.setAttribute("outsystems.function.key", "f03ed237-10d7-467a-96da-3fc1fe0d6dee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._rejectPopupClose$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_CalendarClearClear$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CalendarClearClear__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CalendarClearClear");
span.setAttribute("outsystems.function.key", "f414d226-fdd5-40db-bf55-d86713f71977");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CalendarClearClear$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

rejectPopupReject$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RejectPopupReject__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RejectPopupReject");
span.setAttribute("outsystems.function.key", "fcd8200b-bf08-4433-9992-7df0db938974");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._rejectPopupReject$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "feeb2954-faa2-492e-b81c-eaf3a882fee1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onDebounce$Action, callContext);
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
return ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasingController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ComissionesArrendamientos]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases$ActionApproveRejectSingleProposalLineApprovalLevel", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ApproveOnClick$vars", [{
name: "i_ProposalId",
attrName: "i_ProposalIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_ProposalLineApprovalLevelId",
attrName: "i_ProposalLineApprovalLevelIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ShowRejectPopup$vars", [{
name: "i_ProposalId",
attrName: "i_ProposalIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_ProposalLineApprovalLevelIdToRejectSelected",
attrName: "i_ProposalLineApprovalLevelIdToRejectSelectedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ApproveSelectedOnClick$vars", [{
name: "l_ProposalLineApprovalLevelIdList",
attrName: "l_ProposalLineApprovalLevelIdListVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(RC_474c5c8cc36282ebfc11b03838b11802))();
},
complexType: (OS$GenericTypeCache.getGenericList(RC_474c5c8cc36282ebfc11b03838b11802))
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.ShowDocumentLog$vars", [{
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
}, {
name: "l_ProposalId",
attrName: "l_ProposalIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.DatePickerOnPaymentDate$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


