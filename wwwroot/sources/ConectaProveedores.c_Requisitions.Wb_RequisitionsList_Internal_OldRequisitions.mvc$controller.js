import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_291bf3fef8932fa1af5104e6982c4da9Structure, ST_a158c76eb93396680623c04244f48b6cStructure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import { SE_requisitionStatus as ConectaProveedores_staticEntities_requisitionStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getCompanies$AggrRefresh: 0,
getApprovalStatuses$AggrRefresh: 0,
getProjectAssetServices$AggrRefresh: 0,
getCostCenters$AggrRefresh: 0,
getRequisitionStatuses$AggrRefresh: 0,
getEntraRole$AggrRefresh: 0,
getRequisitionsFull$DataActRefresh: -1,
getUserApplicationRolesAndMore$DataActRefresh: 0,
getRequisitions$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getCompanies$AggrRefresh: [],
getApprovalStatuses$AggrRefresh: [],
getProjectAssetServices$AggrRefresh: [],
getCostCenters$AggrRefresh: [],
getRequisitionStatuses$AggrRefresh: [],
getEntraRole$AggrRefresh: [],
getRequisitionsFull$DataActRefresh: [],
getUserApplicationRolesAndMore$DataActRefresh: ["getRequisitionsFull$DataActRefresh", "getRequisitions$DataActRefresh"],
getRequisitions$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
screenTableDownloadWbRequisitionsListInternal$ServerAction(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, i_RequisitionsListInternalTableListStructureIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ScreenTableDownloadWbRequisitionsListInternal", function (span) {
if(span) {
span.setAttribute("code.function", "ScreenTableDownloadWbRequisitionsListInternal");
span.setAttribute("outsystems.function.key", "9e57e14b-9e97-4608-bf4f-ebc97162c93a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_IsCSV: OS$DataConversion.ServerDataConverter.to(i_IsCSVIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_IsPDF: OS$DataConversion.ServerDataConverter.to(i_IsPDFIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_IsXLS: OS$DataConversion.ServerDataConverter.to(i_IsXLSIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_RequisitionsListInternalTableListStructure: OS$DataConversion.ServerDataConverter.to(i_RequisitionsListInternalTableListStructureIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ScreenTableDownloadWbRequisitionsListInternal", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ActionScreenTableDownloadWbRequisitionsListInternal", "Z7ZqthqRTO4gO6E2yjKD8w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions$ActionScreenTableDownloadWbRequisitionsListInternal"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, ST_a158c76eb93396680623c04244f48b6cStructure);
executeServerActionResult.o_StringListIdsOut = OS$DataConversion.ServerDataConverter.from(outputs.o_StringListIds, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_StringListLevelIdsOut = OS$DataConversion.ServerDataConverter.from(outputs.o_StringListLevelIds, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_ErrorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.o_ErrorMsg, OS$DataTypes.DataTypes.Text);
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions$ActionGetSettings"))();
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
requisitionCancel$ServerAction(i_RequisitionIdIn, i_RequisitionApprovalLevelIdIn, i_CancelReasonIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RequisitionCancel", function (span) {
if(span) {
span.setAttribute("code.function", "RequisitionCancel");
span.setAttribute("outsystems.function.key", "01f1538f-b892-4923-9da1-2d68a8666f63");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_RequisitionApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_RequisitionApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_CancelReason: OS$DataConversion.ServerDataConverter.to(i_CancelReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("RequisitionCancel", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ActionRequisitionCancel", "t_Cz8TUtEbxHcmD_3NS1BQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions$ActionRequisitionCancel"))();
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

// Aggregates and Data Actions
get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ScreenDataSetGetCompanies", "dUlLiZXilCXZfHjYY_ZYJg", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "3840e5ad-0a32-47c5-b972-e61b99a561e0");
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalStatuses", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ScreenDataSetGetApprovalStatuses", "SOfFGGF3iufQOk4hAyThKw", maxRecords, startIndex, function (b) {
model.variables.getApprovalStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalStatuses");
span.setAttribute("outsystems.function.key", "6998ffa3-c6f9-4512-88f6-64596f116685");
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

get getProjectAssetServices$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServices$AggrRefresh"))) {
this._getProjectAssetServices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ScreenDataSetGetProjectAssetServices", "QmIftqTsNkC++1frUcNFQw", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "7031e35d-9e31-4581-b284-5e304091afbb");
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

return this._getProjectAssetServices$AggrRefresh;
}set getProjectAssetServices$AggrRefresh(value) {this._getProjectAssetServices$AggrRefresh = value;
}

get getCostCenters$AggrRefresh() {if(!(this.hasOwnProperty("_getCostCenters$AggrRefresh"))) {
this._getCostCenters$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCostCenters", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ScreenDataSetGetCostCenters", "PFgOcVYTyd2esKT4r8d2yg", maxRecords, startIndex, function (b) {
model.variables.getCostCentersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCostCentersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCostCentersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCostCenters", function (span) {
if(span) {
span.setAttribute("code.function", "GetCostCenters");
span.setAttribute("outsystems.function.key", "8c8b7019-6554-402a-b016-890a4d1e2594");
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

return this._getCostCenters$AggrRefresh;
}set getCostCenters$AggrRefresh(value) {this._getCostCenters$AggrRefresh = value;
}

get getRequisitionStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionStatuses$AggrRefresh"))) {
this._getRequisitionStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionStatuses", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ScreenDataSetGetRequisitionStatuses", "g2bACkjRlxCOdm4LTzpLVw", maxRecords, startIndex, function (b) {
model.variables.getRequisitionStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionStatuses");
span.setAttribute("outsystems.function.key", "b111fa44-00b9-4a77-b567-4f3f444ddd58");
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

return this._getRequisitionStatuses$AggrRefresh;
}set getRequisitionStatuses$AggrRefresh(value) {this._getRequisitionStatuses$AggrRefresh = value;
}

get getEntraRole$AggrRefresh() {if(!(this.hasOwnProperty("_getEntraRole$AggrRefresh"))) {
this._getEntraRole$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetEntraRole", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/ScreenDataSetGetEntraRole", "7qyGTC_5OnA_VV8+D1QF6g", maxRecords, startIndex, function (b) {
model.variables.getEntraRoleAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEntraRoleAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getEntraRoleAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetEntraRole", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraRole");
span.setAttribute("outsystems.function.key", "c8f30c03-81aa-4a61-902b-acaccd6354b4");
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

return this._getEntraRole$AggrRefresh;
}set getEntraRole$AggrRefresh(value) {this._getEntraRole$AggrRefresh = value;
}

get getRequisitionsFull$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitionsFull$DataActRefresh"))) {
this._getRequisitionsFull$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitionsFull", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/DataActionGetRequisitionsFull", "AJ1LpUgQHea1RSHPoqf9kA", function (b) {
model.variables.getRequisitionsFullDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsFullDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsFullDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionsFull", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsFull");
span.setAttribute("outsystems.function.key", "2e3d709f-1854-4a7d-b3ab-c0175a0e95a9");
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

return this._getRequisitionsFull$DataActRefresh;
}set getRequisitionsFull$DataActRefresh(value) {this._getRequisitionsFull$DataActRefresh = value;
}

get getUserApplicationRolesAndMore$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRolesAndMore$DataActRefresh"))) {
this._getUserApplicationRolesAndMore$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRolesAndMore", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/DataActionGetUserApplicationRolesAndMore", "t1QByB8F7Ei1DwTyreXRnA", function (b) {
model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesAndMoreDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesAndMoreDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserApplicationRolesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRolesAndMore", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesAndMore");
span.setAttribute("outsystems.function.key", "820a45a3-edaa-4181-97c8-e9d493034af0");
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

get getRequisitions$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitions$DataActRefresh"))) {
this._getRequisitions$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitions", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Internal_OldRequisitions/DataActionGetRequisitions", "BzbyKeA6+dCLL9ymkZGkdg", function (b) {
model.variables.getRequisitionsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitions");
span.setAttribute("outsystems.function.key", "de2ee5a8-f3ca-4bc7-9cc4-b863dd9f51f0");
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


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getCompanies$AggrRefresh", "getApprovalStatuses$AggrRefresh", "getProjectAssetServices$AggrRefresh", "getCostCenters$AggrRefresh", "getRequisitionStatuses$AggrRefresh", "getEntraRole$AggrRefresh", "getRequisitionsFull$DataActRefresh", "getUserApplicationRolesAndMore$DataActRefresh", "getRequisitions$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_DownloadsFloatOnClick$Action(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_DownloadsFloatOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DownloadsFloatOnClick");
span.setAttribute("outsystems.function.key", "103f63b3-96e3-471a-8816-f0ae877523bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_DownloadsFloatOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.Wb_DownloadsFloatOnClick$vars"))());
vars.value.i_IsCSVInLocal = i_IsCSVIn;
vars.value.i_IsPDFInLocal = i_IsPDFIn;
vars.value.i_IsXLSInLocal = i_IsXLSIn;
var screenTableDownloadWbRequisitionsListInternalVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.isListFullNeedRefreshVar)) {
// Refresh Query: GetRequisitionsFull
var result = controller.getRequisitionsFull$DataActRefresh(callContext);
model.flush();
return result;
}

}).then(function () {
// Execute Action: ScreenTableDownloadWbRequisitionsListInternal
model.flush();
return controller.screenTableDownloadWbRequisitionsListInternal$ServerAction(vars.value.i_IsCSVInLocal, vars.value.i_IsPDFInLocal, vars.value.i_IsXLSInLocal, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getRequisitionsFullDataAct.listOut, new (OS$GenericTypeCache.getGenericList(ST_291bf3fef8932fa1af5104e6982c4da9Structure))(), function (source, target) {
target.requisitionIdAttr = source.requisitionApprovalAttr.requisitionIdAttr;
target.requisitionApprovalLevelIdAttr = source.requisitionApprovalLevelAttr.idAttr;
target.requisitionNameAttr = source.requisitionAttr.nameAttr;
target.requisitionStatusAttr = source.requisitionStatusAttr.labelAttr;
target.creationDateAttr = OS$BuiltinFunctions.formatDateTime(source.requisitionAttr.createdOnAttr, "dd/MM/yyyy");
target.lastChangeAttr = ((OS$BuiltinFunctions.formatDateTime(source.requisitionAttr.updatedOnAttr, "dd/MM/yyyy") + " ") + source.updatedByAttr.valueAttr);
target.requesterAttr = source.userApplicantNameAttr.valueAttr;
target.projectAttr = source.project_Asset_ServiceAttr.descriptionAttr;
target.supplierAttr = ((source.supplierAttr.nameAttr + " ") + source.supplierAttr.numberAttr);
target.regionAttr = source.regionAttr.codeAttr;
target.amountAttr = OS$BuiltinFunctions.formatCurrency(source.requisitionAttr.totalAmountAttr, "", 2, ".", ",");
target.currencyAttr = source.currencyAttr.codeAttr;
target.costCenterAttr = source.costCenterSAPAttr.denominacionAttr;
target.companyAttr = source.companyAttr.descriptionAttr;
target.actionAttr = (((((source.requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (source.requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.expired)) || ((source.requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.canceled) && (source.requisitionApprovalLevelAttr.approvalStatusIdAttr === OS$BuiltinFunctions.nullIdentifier())))) ? ("") : ((((((source.requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()) && ((source.requisitionApprovalLevelAttr.assignedToAttr) !== (OS$BuiltinFunctions.getUserId()))) && (!((source.approvalStatusAttr.idAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved))))) ? ("Submitted") : (((((source.requisitionApprovalLevelAttr.approvalStatusIdAttr) !== (OS$BuiltinFunctions.nullIdentifier()))) ? (((source.requisitionApprovalLevelAttr.isAccountingAttr) ? ((source.approvalStatusAttr.labelAttr + " CxP")) : ((source.approvalStatusAttr.labelAttr + " AU")))) : (""))))));
return target;
}), callContext).then(function (value) {
screenTableDownloadWbRequisitionsListInternalVar.value = value;
}).then(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
});
}).then(function () {
// error?
if((((screenTableDownloadWbRequisitionsListInternalVar.value.o_ErrorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(screenTableDownloadWbRequisitionsListInternalVar.value.o_ErrorMsgOut, /*Error*/ 3);
} else {
// null?
if((OS$DataTypes.areBinaryNulls(screenTableDownloadWbRequisitionsListInternalVar.value.o_FileOut.binaryDataAttr, OS$BuiltinFunctions.nullBinary()))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8kpLqytAbk6Tm_GtnqX9qA#Message.-1067972576.1", "There was a problem downloading your file. Please contact an administrator."), /*Error*/ 3);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cxYqI3At60uEh9qIifZc9g#Message.269443952.1", "File downloaded with success."), /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(screenTableDownloadWbRequisitionsListInternalVar.value.o_FileOut.binaryDataAttr, screenTableDownloadWbRequisitionsListInternalVar.value.o_FileOut.nameAttr));
}

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
span.setAttribute("outsystems.function.key", "176ddecb-8431-4e99-b081-fc008892407a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.OnSort$vars"))());
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
// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
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
_expandFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExpandFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "25d2d3db-fe3c-4c8a-a92f-975cb79f2f27");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ExpandFilters$vars"))());
return OS$Flow.executeAsyncFlow(function () {
// l_ShowFilters = notl_ShowFilters
model.variables.l_ShowFiltersVar = (!(model.variables.l_ShowFiltersVar));
return OS$Flow.executeSequence(function () {
if((!(model.variables.l_ShowFiltersVar))) {
// IsRefresh = Requisitions_CompanyId <> NullIdentifier or Requisitions_ProjectId <> NullIdentifier or Requisitions_AmountFrom <> 0 or Requisitions_AmountTo <> 0
vars.value.isRefreshVar = (((!(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))));
// Reset Filters
// Requisitions_AmountFrom = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountFrom(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_AmountTo = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountTo(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_CompanyId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_CompanyId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_ProjectId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshVar)) {
// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
});
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "33a2a1fc-2ea6-45ea-9ec2-9087f0664205");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresRequisitionsGetRequisitions"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetRequisitions = ColumnJSON
model.variables.l_ColumnJSONVarGetRequisitionsVar = vars.value.columnJSONInLocal;
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
_getRequisitionsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "37927634-dd16-421d-865e-42bf81b358ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRequisitionsOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsListFullNeedRefresh = True
model.variables.isListFullNeedRefreshVar = true;
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetRequisitionsVar === 0))) {
// l_CountAfterFetchGetRequisitions = l_CountAfterFetchGetRequisitions + 1
model.variables.l_CountAfterFetchGetRequisitionsVar = (model.variables.l_CountAfterFetchGetRequisitionsVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresRequisitionsGetRequisitions"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetRequisitions = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetRequisitionsVar = getSettingsVar.value.outSettingsTextOut;
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
_screenTableDownloadsOnClick$Action(isCloseIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ScreenTableDownloadsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ScreenTableDownloadsOnClick");
span.setAttribute("outsystems.function.key", "46ae0c55-0661-4ee8-89f3-256a07e571a1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ScreenTableDownloadsOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ScreenTableDownloadsOnClick$vars"))());
vars.value.isCloseInLocal = isCloseIn;
// l_ShowScreenTableDownloads = notl_ShowScreenTableDownloads
model.variables.l_ShowScreenTableDownloadsVar = (!(model.variables.l_ShowScreenTableDownloadsVar));
if((vars.value.isCloseInLocal)) {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_RequisitionsListInternalIdListVar, callContext);
} else {
// Foreach GetRequisitions.List
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionsDataAct.listOut);
try {var listIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionsDataAct.listOut);
var listIndex = 0;
while (((listIndex < model.variables.getRequisitionsDataAct.listOut.length))) {
listIterator.currentRowNumber = listIndex;
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.l_RequisitionsListInternalIdListVar, model.variables.getRequisitionsDataAct.listOut.getItem(listIndex.valueOf()).requisitionAttr.idAttr, callContext);
listIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionsDataAct.listOut);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "46bfdb0d-ca17-4051-8e08-1abff0ffda3f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// l_AmountFromText = Requisitions_AmountFrom
model.variables.l_AmountFromTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getRequisitions_AmountFrom());
// l_AmountToText = Requisitions_AmountTo
model.variables.l_AmountToTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getRequisitions_AmountTo());
// l_ShowFilters = Requisitions_CompanyId <> NullIdentifier or Requisitions_ProjectId <> NullIdentifier or Requisitions_AmountFrom <> 0 or Requisitions_AmountTo <> 0
model.variables.l_ShowFiltersVar = (((!(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))));
// MaxRecords = If
ConectaProveedoresClientVariables.setMaxRecords((((ConectaProveedoresClientVariables.getMaxRecords() <= 5)) ? (5) : (ConectaProveedoresClientVariables.getMaxRecords())));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "4b9bf9b9-af8c-47ad-8142-2bc58182d276");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Requisitions_SupplierId = SupplierId
ConectaProveedoresClientVariables.setRequisitions_SupplierId(vars.value.supplierIdInLocal);
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
_datePickerOnUploadDate$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnUploadDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnUploadDate");
span.setAttribute("outsystems.function.key", "69c238ea-aadf-4283-8799-bfe1d6ed5aa7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnUploadDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.DatePickerOnUploadDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Requisitions_UploadDate = SelectedDateTime
ConectaProveedoresClientVariables.setRequisitions_UploadDate(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_cancelRequisition$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "CancelRequisition");
span.setAttribute("outsystems.function.key", "75655d22-8da3-4a69-81cf-90ad1370403e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CancelRequisition");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var requisitionCancelVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: RequisitionCancel
model.flush();
return controller.requisitionCancel$ServerAction(model.variables.l_RequisitonToCancelVar, OS$DataTypes.LongInteger.defaultValue, "", "", callContext).then(function (value) {
requisitionCancelVar.value = value;
}).then(function () {
// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: ShowHidePopup2
controller._showHideCancelPopup$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), callContext);
});
}).catch(function (ex) {
OS$Logger.debug("Wb_RequisitionsList_Internal_OldRequisitions.CancelRequisition", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "ffdc7223-87e8-444e-8609-ff9ea63e3232");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AdZzO1itbE62Vw+JvaFjOg#Message.751629479.1", "Error while trying to cancel the requisition!"), /*Error*/ 3);
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "9b9a1c3f-a250-4cf6-9235-73d33af63f01");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
if(((ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId() === OS$BuiltinFunctions.nullIdentifier()))) {
// Requisitions_ApprovalStatusId = NotApproved
ConectaProveedoresClientVariables.setRequisitions_ApprovalStatusId(ConectaProveedores_staticEntities_approvalStatus.notApproved);
}

// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
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
_onDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "a34d73ce-dba6-48de-988a-104ee472b286");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDebounce");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Requisitions_AmountFrom = TextToDecimal
ConectaProveedoresClientVariables.setRequisitions_AmountFrom(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountFromTextVar));
// Requisitions_AmountTo = TextToDecimal
ConectaProveedoresClientVariables.setRequisitions_AmountTo(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountToTextVar));
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "b0817986-4a23-463d-bf45-3875eb680ee7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
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
_clearCreationDate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearCreationDate", function (span) {
if(span) {
span.setAttribute("code.function", "ClearCreationDate");
span.setAttribute("outsystems.function.key", "b13f05b3-d249-498a-acdb-93c954219d5f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearCreationDate");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Requisitions_UploadDate = NullDate
ConectaProveedoresClientVariables.setRequisitions_UploadDate(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerPaymentDateRequisitions"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerPaymentDateRequisitions"), callContext);

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
_dropdownProjectSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownProjectSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownProjectSearchOnChanged");
span.setAttribute("outsystems.function.key", "b4b6edb5-dca9-412b-85fa-a26b84f534eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownProjectSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.DropdownProjectSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Requisitions_ProjectId = IntegerToIdentifier
ConectaProveedoresClientVariables.setRequisitions_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr))));
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "bd82d2c7-d9b5-4bb2-953b-688279271bf3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerClearUploadDateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Reset Filters
// Requisitions_AmountFrom = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountFrom(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_AmountTo = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountTo(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_CompanyId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_CompanyId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_RequisitionSearch = ""
ConectaProveedoresClientVariables.setRequisitions_RequisitionSearch("");
// Requisitions_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_UploadDate = NullDate
ConectaProveedoresClientVariables.setRequisitions_UploadDate(OS$BuiltinFunctions.nullDate());
// Requisitions_ProjectId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_RequisitionsStatusId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_RequisitionsStatusId(OS$BuiltinFunctions.nullIdentifier());
// Requisitions_ProveedorFilter_UploadDateFrom = NullDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateFrom(OS$BuiltinFunctions.nullDate());
// Requisitions_ProveedorFilter_UploadDateTo = NullDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateTo(OS$BuiltinFunctions.nullDate());
// Requisitions_ApprovalStatusId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_ApprovalStatusId(OS$BuiltinFunctions.nullIdentifier());
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
// Requisitions_CostCenterId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_CostCenterId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Execute Action: DatePickerClearUploadDate
datePickerClearUploadDateVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerPaymentDateRequisitions"), callContext);

}

// Refresh Query: GetRequisitions
var result = controller.getRequisitions$DataActRefresh(callContext);
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
_showHideCancelPopup$Action(cancelRequisitionIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideCancelPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideCancelPopup");
span.setAttribute("outsystems.function.key", "c385f4b8-3dfa-4895-bcea-df47ab02483b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideCancelPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ShowHideCancelPopup$vars"))());
vars.value.cancelRequisitionIdInLocal = cancelRequisitionIdIn;
// l_RequisitonToCancel = CancelRequisitionId
model.variables.l_RequisitonToCancelVar = vars.value.cancelRequisitionIdInLocal;
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "c489d65e-d451-421c-9ec6-67a437a3a633");
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

wb_DownloadsFloatOnClick$Action(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_DownloadsFloatOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DownloadsFloatOnClick");
span.setAttribute("outsystems.function.key", "103f63b3-96e3-471a-8816-f0ae877523bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_DownloadsFloatOnClick$Action, callContext, i_IsCSVIn, i_IsPDFIn, i_IsXLSIn);
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
span.setAttribute("outsystems.function.key", "176ddecb-8431-4e99-b081-fc008892407a");
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

expandFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExpandFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "25d2d3db-fe3c-4c8a-a92f-975cb79f2f27");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "33a2a1fc-2ea6-45ea-9ec2-9087f0664205");
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

getRequisitionsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "37927634-dd16-421d-865e-42bf81b358ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRequisitionsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

screenTableDownloadsOnClick$Action(isCloseIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ScreenTableDownloadsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ScreenTableDownloadsOnClick");
span.setAttribute("outsystems.function.key", "46ae0c55-0661-4ee8-89f3-256a07e571a1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._screenTableDownloadsOnClick$Action, callContext, isCloseIn);
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
span.setAttribute("outsystems.function.key", "46bfdb0d-ca17-4051-8e08-1abff0ffda3f");
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

dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "4b9bf9b9-af8c-47ad-8142-2bc58182d276");
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

datePickerOnUploadDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnUploadDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnUploadDate");
span.setAttribute("outsystems.function.key", "69c238ea-aadf-4283-8799-bfe1d6ed5aa7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnUploadDate$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

cancelRequisition$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelRequisition__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelRequisition");
span.setAttribute("outsystems.function.key", "75655d22-8da3-4a69-81cf-90ad1370403e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._cancelRequisition$Action, callContext);
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
span.setAttribute("outsystems.function.key", "9b9a1c3f-a250-4cf6-9235-73d33af63f01");
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

onDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "a34d73ce-dba6-48de-988a-104ee472b286");
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

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "b0817986-4a23-463d-bf45-3875eb680ee7");
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

clearCreationDate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearCreationDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearCreationDate");
span.setAttribute("outsystems.function.key", "b13f05b3-d249-498a-acdb-93c954219d5f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearCreationDate$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdownProjectSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownProjectSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownProjectSearchOnChanged");
span.setAttribute("outsystems.function.key", "b4b6edb5-dca9-412b-85fa-a26b84f534eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownProjectSearchOnChanged$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "bd82d2c7-d9b5-4bb2-953b-688279271bf3");
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

showHideCancelPopup$Action(cancelRequisitionIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideCancelPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideCancelPopup");
span.setAttribute("outsystems.function.key", "c385f4b8-3dfa-4895-bcea-df47ab02483b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideCancelPopup$Action, callContext, cancelRequisitionIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "c489d65e-d451-421c-9ec6-67a437a3a633");
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions$ActionScreenTableDownloadWbRequisitionsListInternal", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}, {
name: "o_StringListIds",
attrName: "o_StringListIdsOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_StringListLevelIds",
attrName: "o_StringListLevelIdsOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_ErrorMsg",
attrName: "o_ErrorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions$ActionRequisitionCancel", [{
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.Wb_DownloadsFloatOnClick$vars", [{
name: "i_IsCSV",
attrName: "i_IsCSVInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsPDF",
attrName: "i_IsPDFInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsXLS",
attrName: "i_IsXLSInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ScreenTableDownloadsOnClick$vars", [{
name: "IsClose",
attrName: "isCloseInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.DatePickerOnUploadDate$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.DropdownProjectSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.ShowHideCancelPopup$vars", [{
name: "CancelRequisitionId",
attrName: "cancelRequisitionIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


