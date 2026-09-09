import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_3c6142d371d14231f5ddee7b64c28681Structure, ST_6ac87b97c676cd17082ba2063283d4baStructure, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord, RC_7d9af3f1351b60af34cc932af3010814, ST_a158c76eb93396680623c04244f48b6cStructure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import { SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, notificationOpen$Action as OutSystemsUIController$notificationOpen$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_d_Invoices_Invoices_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices.Invoices.mvc$translationsResources.js";
import ConectaProveedores_d_InvoicesController$default from "./ConectaProveedores.d_Invoices.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_Invoices_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoices$AggrRefresh: -1,
getApprovalStatuses$AggrRefresh: 0,
getProjectAssetServices$AggrRefresh: 0,
getInvoicesFull$AggrRefresh: -1,
getEntraRole$AggrRefresh: 0,
getCompanies$AggrRefresh: 0,
getInvoiceCountToAssign$DataActRefresh: -1,
getUserApplicationRolesAndMore$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoices$AggrRefresh: [],
getApprovalStatuses$AggrRefresh: [],
getProjectAssetServices$AggrRefresh: [],
getInvoicesFull$AggrRefresh: [],
getEntraRole$AggrRefresh: [],
getCompanies$AggrRefresh: [],
getInvoiceCountToAssign$DataActRefresh: [],
getUserApplicationRolesAndMore$DataActRefresh: ["getInvoices$AggrRefresh", "getInvoicesFull$AggrRefresh", "getInvoiceCountToAssign$DataActRefresh"]
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
screenTableDownloadInvoiceScreen$ServerAction(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, i_InvoicesScreenTableStructureIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ScreenTableDownloadInvoiceScreen", function (span) {
if(span) {
span.setAttribute("code.function", "ScreenTableDownloadInvoiceScreen");
span.setAttribute("outsystems.function.key", "82af520b-7b21-4fa7-b049-fdae68dccb10");
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
i_InvoicesScreenTableStructure: OS$DataConversion.ServerDataConverter.to(i_InvoicesScreenTableStructureIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ScreenTableDownloadInvoiceScreen", "screenservices/ConectaProveedores/d_Invoices/Invoices/ActionScreenTableDownloadInvoiceScreen", "DpRGvDMJvL69zi+8w_DTrQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices$ActionScreenTableDownloadInvoiceScreen"))();
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
approvModifInv$ServerAction(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovModifInv", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovModifInv");
span.setAttribute("outsystems.function.key", "37d4e485-7021-4ad2-a8f4-0305ae61b29a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_InvoiceApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_InvoiceApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApprovModifInv", "screenservices/ConectaProveedores/d_Invoices/Invoices/ActionApprovModifInv", "hgVLsCjSSwJ57Oio+PKM9g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices$ActionApprovModifInv"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.isFinishOut = OS$DataConversion.ServerDataConverter.from(outputs.IsFinish, OS$DataTypes.DataTypes.Boolean);
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/d_Invoices/Invoices/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices$ActionGetSettings"))();
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/d_Invoices/Invoices/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/d_Invoices/Invoices/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getInvoices$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoices$AggrRefresh"))) {
this._getInvoices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoices", "screenservices/ConectaProveedores/d_Invoices/Invoices/ScreenDataSetGetInvoices", "NgXFwJZS4b6jnn+qF0GnoA", maxRecords, startIndex, function (b) {
model.variables.getInvoicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoicesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoices");
span.setAttribute("outsystems.function.key", "12a5e649-aa3b-4b83-992f-4137b2e7d1e1");
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

get getApprovalStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getApprovalStatuses$AggrRefresh"))) {
this._getApprovalStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetApprovalStatuses", "screenservices/ConectaProveedores/d_Invoices/Invoices/ScreenDataSetGetApprovalStatuses", "SOfFGGF3iufQOk4hAyThKw", maxRecords, startIndex, function (b) {
model.variables.getApprovalStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalStatuses");
span.setAttribute("outsystems.function.key", "3705df94-804e-4a1e-b1c9-ba4289365c9f");
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/d_Invoices/Invoices/ScreenDataSetGetProjectAssetServices", "QmIftqTsNkC++1frUcNFQw", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "66f3e8c2-4baa-4de3-a80c-ae3f12d0ed91");
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

get getInvoicesFull$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesFull$AggrRefresh"))) {
this._getInvoicesFull$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesFull", "screenservices/ConectaProveedores/d_Invoices/Invoices/ScreenDataSetGetInvoicesFull", "P0otaSD7FShPJJx0NwiiNw", maxRecords, startIndex, function (b) {
model.variables.getInvoicesFullAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesFullAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesFullAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesFull", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesFull");
span.setAttribute("outsystems.function.key", "8562ad81-5f59-41d5-9c56-28ded375305a");
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

return this._getInvoicesFull$AggrRefresh;
}set getInvoicesFull$AggrRefresh(value) {this._getInvoicesFull$AggrRefresh = value;
}

get getEntraRole$AggrRefresh() {if(!(this.hasOwnProperty("_getEntraRole$AggrRefresh"))) {
this._getEntraRole$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetEntraRole", "screenservices/ConectaProveedores/d_Invoices/Invoices/ScreenDataSetGetEntraRole", "7qyGTC_5OnA_VV8+D1QF6g", maxRecords, startIndex, function (b) {
model.variables.getEntraRoleAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEntraRoleAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getEntraRoleAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetEntraRole", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraRole");
span.setAttribute("outsystems.function.key", "cb8c6cad-499a-478b-8758-e21b87fc2d5c");
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

get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/d_Invoices/Invoices/ScreenDataSetGetCompanies", "dUlLiZXilCXZfHjYY_ZYJg", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "ec2ada61-ef6f-49e1-bf14-e706b3a5d403");
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

get getInvoiceCountToAssign$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoiceCountToAssign$DataActRefresh"))) {
this._getInvoiceCountToAssign$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoiceCountToAssign", "screenservices/ConectaProveedores/d_Invoices/Invoices/DataActionGetInvoiceCountToAssign", "rbFeSEFFBjUoT2kUgut5mA", function (b) {
model.variables.getInvoiceCountToAssignDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceCountToAssignDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceCountToAssignDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getInvoiceCountToAssignOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceCountToAssign", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCountToAssign");
span.setAttribute("outsystems.function.key", "1b00dd12-a1ef-4797-82ca-4af9cc27d2d9");
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

return this._getInvoiceCountToAssign$DataActRefresh;
}set getInvoiceCountToAssign$DataActRefresh(value) {this._getInvoiceCountToAssign$DataActRefresh = value;
}

get getUserApplicationRolesAndMore$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRolesAndMore$DataActRefresh"))) {
this._getUserApplicationRolesAndMore$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRolesAndMore", "screenservices/ConectaProveedores/d_Invoices/Invoices/DataActionGetUserApplicationRolesAndMore", "uGs6UYA2x3hwvJTZO3la7g", function (b) {
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
span.setAttribute("outsystems.function.key", "d4d17998-855e-4921-a749-97b5a77c9d1a");
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
this._dataFetchActionNames = ["getInvoices$AggrRefresh", "getApprovalStatuses$AggrRefresh", "getProjectAssetServices$AggrRefresh", "getInvoicesFull$AggrRefresh", "getEntraRole$AggrRefresh", "getCompanies$AggrRefresh", "getInvoiceCountToAssign$DataActRefresh", "getUserApplicationRolesAndMore$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "0d6ec6a3-e2bf-40b4-92af-235e4fb311ed");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_DownloadsFloatOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_DownloadsFloatOnClick$vars"))());
vars.value.i_IsCSVInLocal = i_IsCSVIn;
vars.value.i_IsPDFInLocal = i_IsPDFIn;
vars.value.i_IsXLSInLocal = i_IsXLSIn;
var screenTableDownloadInvoiceScreenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.isListFullNeedRefreshVar)) {
// Refresh Query: GetInvoicesFull
var result = controller.getInvoicesFull$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}

}).then(function () {
// Execute Action: ScreenTableDownloadInvoiceScreen
model.flush();
return controller.screenTableDownloadInvoiceScreen$ServerAction(vars.value.i_IsCSVInLocal, vars.value.i_IsPDFInLocal, vars.value.i_IsXLSInLocal, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoicesFullAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_3c6142d371d14231f5ddee7b64c28681Structure))(), function (source, target) {
target.invoiceIdAttr = source.invoiceAttr.idAttr;
target.invoiceApprovalLevelIdAttr = source.invoiceApprovalLevelAttr.idAttr;
target.invoiceNameAttr = source.invoiceAttr.nameAttr;
target.invoiceStatusAttr = source.invoiceStatusAttr.labelAttr;
target.requisitionNameAttr = source.requisitionAttr.nameAttr;
target.supplierNameAttr = source.supplierAttr.nameAttr;
target.supplierNumberAttr = source.invoiceAccountingAttr.supplierNumberAttr;
target.totalAmountAttr = OS$BuiltinFunctions.decimalToText(source.invoiceAttr.totalAmountAttr);
target.uploadDateAttr = OS$BuiltinFunctions.formatDateTime(source.invoiceAttr.createdOnAttr, "dd/MM/yyyy");
target.assignedToAttr = source.userAttr.nameAttr;
target.actionAttr = source.approvalStatusAttr.labelAttr;
return target;
}), callContext).then(function (value) {
screenTableDownloadInvoiceScreenVar.value = value;
}).then(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
});
}).then(function () {
// error?
if((((screenTableDownloadInvoiceScreenVar.value.o_ErrorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(screenTableDownloadInvoiceScreenVar.value.o_ErrorMsgOut, /*Error*/ 3);
} else {
// null?
if((OS$DataTypes.areBinaryNulls(screenTableDownloadInvoiceScreenVar.value.o_FileOut.binaryDataAttr, OS$BuiltinFunctions.nullBinary()))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3CGhTcEbfEuIf1w5XmrHLA#Message.-1067972576.1", "There was a problem downloading your file. Please contact an administrator."), /*Error*/ 3);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8pWPhZI820S6ehk0nrrBpA#Message.269443952.1", "File downloaded with success."), /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(screenTableDownloadInvoiceScreenVar.value.o_FileOut.binaryDataAttr, screenTableDownloadInvoiceScreenVar.value.o_FileOut.nameAttr));
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "156d0d2d-bb35-4112-9e6d-002073fb3b1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
if(((ConectaProveedoresClientVariables.getInvoice_ApprovalStatusId() === OS$BuiltinFunctions.nullIdentifier()))) {
// Invoice_ApprovalStatusId = NotApproved
ConectaProveedoresClientVariables.setInvoice_ApprovalStatusId(ConectaProveedores_staticEntities_approvalStatus.notApproved);
}

// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_clearUploadDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearUploadDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearUploadDateTo");
span.setAttribute("outsystems.function.key", "17204c58-c41b-44c7-aaeb-a0e8af16047f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearUploadDateTo");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Invoice_UploadDateTo = NullDate
ConectaProveedoresClientVariables.setInvoice_UploadDateTo(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerTo"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerTo"), callContext);

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
_wb_a_RejectInvoicesPopupClose$Action(isRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_RejectInvoicesPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_RejectInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "1c6e17ef-8f73-4df8-95b9-5ffa592ed6c5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_a_RejectInvoicesPopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_RejectInvoicesPopupClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// Close PopUp
// l_ShowRejectInvoice = notl_ShowRejectInvoice
model.variables.l_ShowRejectInvoiceVar = (!(model.variables.l_ShowRejectInvoiceVar));
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
_wb_a_ApproveInvoicePopupClose$Action(isRefreshIn, commentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_ApproveInvoicePopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveInvoicePopupClose");
span.setAttribute("outsystems.function.key", "20e8bc5d-95eb-4e39-91ae-da4a1c785834");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_a_ApproveInvoicePopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_ApproveInvoicePopupClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
vars.value.commentInLocal = commentIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var approvModifInvVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// Execute Action: ApprovModifInv
model.flush();
return controller.approvModifInv$ServerAction(model.variables.l_InvoiceIdVar, model.variables.l_InvoiceApprovalLevelIdVar, true, vars.value.commentInLocal, ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
approvModifInvVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((approvModifInvVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(((approvModifInvVar.value.isFinishOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8pJ8N1YkPEmWJDsvwxKYYQ#Message.678776543.1", "Accounting process has started")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8pJ8N1YkPEmWJDsvwxKYYQ#Message.1926737820.1", "Invoice has been approved."))), /*Success*/ 1);
// Clear Locals
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(approvModifInvVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Clear Locals
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
} else {
// Clear Locals
// l_InvoiceId = NullIdentifier
model.variables.l_InvoiceIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_InvoiceApprovalLevelId = NullIdentifier
model.variables.l_InvoiceApprovalLevelIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
}).catch(function (ex) {
OS$Logger.debug("Invoices.Wb_a_ApproveInvoicePopupClose", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "0d740c50-8568-4cc4-8393-3aab7f391c85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_wb_c_InvoiceCommentClose$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_c_InvoiceCommentClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_InvoiceCommentClose");
span.setAttribute("outsystems.function.key", "2602c5b1-2698-487f-a7fc-ddbe0e610502");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_c_InvoiceCommentClose");
callContext = controller.callContext(callContext);
// Clear Locals
// l_InvoiceId = NullIdentifier
model.variables.l_InvoiceIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_InvoiceApprovalLevelId = NullIdentifier
model.variables.l_InvoiceApprovalLevelIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_ShowComment = notl_ShowComment
model.variables.l_ShowCommentVar = (!(model.variables.l_ShowCommentVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_c_BulkInvoiceCommentOpen$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_c_BulkInvoiceCommentOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_BulkInvoiceCommentOpen");
span.setAttribute("outsystems.function.key", "36108997-6cca-4d07-8644-d704f1d3c0f0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_c_BulkInvoiceCommentOpen");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// l_ShowBulkComment = notl_ShowBulkComment
model.variables.l_ShowBulkCommentVar = (!(model.variables.l_ShowBulkCommentVar));
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(model.variables.l_InvoiceApprovalLevelListVar, function () {
var rec = new RC_7d9af3f1351b60af34cc932af3010814();
rec.invoiceAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr;
rec.invoiceApprovalLevelAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceApprovalLevelAttr;
return rec;
}(), callContext);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_b_BulkApprovePopUpOpen$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkApprovePopUpOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkApprovePopUpOpen");
span.setAttribute("outsystems.function.key", "386dff05-37a8-43e7-9474-9b42f30d7f7c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_b_BulkApprovePopUpOpen");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// l_ShowBulkApproveInvoices = notl_ShowBulkApproveInvoices
model.variables.l_ShowBulkApproveInvoicesVar = (!(model.variables.l_ShowBulkApproveInvoicesVar));
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(model.variables.l_InvoiceApprovalLevelListVar, function () {
var rec = new RC_7d9af3f1351b60af34cc932af3010814();
rec.invoiceAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr;
rec.invoiceApprovalLevelAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceApprovalLevelAttr;
return rec;
}(), callContext);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_b_BulkCancelInvoicesPopupOpen$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkCancelInvoicesPopupOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkCancelInvoicesPopupOpen");
span.setAttribute("outsystems.function.key", "3c9c3cb7-8b9e-4a46-ad2d-5d3d89247ed0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_b_BulkCancelInvoicesPopupOpen");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// l_ShowBulkRejectPopup = notl_ShowBulkRejectPopup
model.variables.l_ShowBulkRejectPopupVar = (!(model.variables.l_ShowBulkRejectPopupVar));
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(model.variables.l_InvoiceApprovalLevelListVar, function () {
var rec = new RC_7d9af3f1351b60af34cc932af3010814();
rec.invoiceAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr;
rec.invoiceApprovalLevelAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceApprovalLevelAttr;
return rec;
}(), callContext);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

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
span.setAttribute("outsystems.function.key", "3da1ceb9-f5b1-42e8-a8c5-8df01810a56d");
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
_wb_a_RejectInvoicePopupOpen$Action(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_RejectInvoicePopupOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_RejectInvoicePopupOpen");
span.setAttribute("outsystems.function.key", "420724d0-ea11-4abc-834c-dad23d785b2d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_a_RejectInvoicePopupOpen");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_RejectInvoicePopupOpen$vars"))());
vars.value.i_InvoiceIdInLocal = i_InvoiceIdIn;
vars.value.i_InvoiceApprovalLevelIdInLocal = i_InvoiceApprovalLevelIdIn;
// Open popup and set locals
// l_ShowRejectInvoice = notl_ShowRejectInvoice
model.variables.l_ShowRejectInvoiceVar = (!(model.variables.l_ShowRejectInvoiceVar));
// l_InvoiceId = i_InvoiceId
model.variables.l_InvoiceIdVar = vars.value.i_InvoiceIdInLocal;
// l_InvoiceApprovalLevelId = i_InvoiceApprovalLevelId
model.variables.l_InvoiceApprovalLevelIdVar = vars.value.i_InvoiceApprovalLevelIdInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_isAnyLineSelected$Action(currentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("IsAnyLineSelected", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "4d8c28fe-d1b0-4112-92ab-5c691fc9c87b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("IsAnyLineSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.IsAnyLineSelected$vars"))());
vars.value.currentRowNumberInLocal = currentRowNumberIn;
var listIndexOf2Var = new OS$DataTypes.VariableHolder();
var listIndexOf4Var = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
var listIndexOf5Var = new OS$DataTypes.VariableHolder();
var listIndexOf3Var = new OS$DataTypes.VariableHolder();
// IsJefeCxP?
if((model.variables.getUserApplicationRolesAndMoreDataAct.isJefeCxPOut)) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && (((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && ((p.invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))));
}, callContext);

// >= 21 selected for approval?
if(((listFilterVar.value.filteredListOut.length >= 21))) {
// GetInvoices.List[CurrentRowNumber].IsSelected = False
model.variables.getInvoicesAggr.listOut.getItem(vars.value.currentRowNumberInLocal).isSelectedAttr = false;
OS$FeedbackMessageService.showFeedbackMessage((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("izSlGdkzbkWcBJuLp5qpPA#Message.552995430.1", "You cannot approve more than 20 invoices at the same time") + "."), /*Warning*/ 2);
return ;

}

}

// Execute Action: ListIndexOf2
listIndexOf2Var.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return ((!(p.isSelectedAttr)) && (((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && ((p.invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))));
}, callContext);

if((((listIndexOf2Var.value.positionOut) !== ((-1))))) {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && (((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && ((p.invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))));
}, callContext);

// l_IsSelectedForApproval = ListIndexOf.Position <> -1
model.variables.l_IsSelectedForApprovalVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
// l_IsSelectAllForApproval = False
model.variables.l_IsSelectAllForApprovalVar = false;
} else {
// l_IsSelectAllForApproval = True
model.variables.l_IsSelectAllForApprovalVar = true;
}

// Execute Action: ListIndexOf4
listIndexOf4Var.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return ((!(p.isSelectedAttr)) && ((((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && p.invoiceApprovalLevelAttr.selectsNextApproverAttr) && (p.invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier())));
}, callContext);

if((((listIndexOf4Var.value.positionOut) !== ((-1))))) {
// Execute Action: ListIndexOf3
listIndexOf3Var.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && ((((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && p.invoiceApprovalLevelAttr.selectsNextApproverAttr) && (p.invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier())));
}, callContext);

// l_IsSelectedForAssignment = ListIndexOf3.Position <> -1
model.variables.l_IsSelectedForAssignmentVar = ((listIndexOf3Var.value.positionOut) !== ((-1)));
// l_IsSelectAllForAssignment = False
model.variables.l_IsSelectAllForAssignmentVar = false;
} else {
// l_IsSelectAllForAssignment = True
model.variables.l_IsSelectAllForAssignmentVar = true;
}

// Execute Action: ListIndexOf5
listIndexOf5Var.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return ((!(p.isSelectedAttr)) && ((((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && ((p.invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))) || ((((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && p.invoiceApprovalLevelAttr.selectsNextApproverAttr) && (p.invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier()))));
}, callContext);

// l_IsSelectAll = ListIndexOf5.Position = -1
model.variables.l_IsSelectAllVar = (listIndexOf5Var.value.positionOut === (-1));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_b_BulkAssignInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkAssignInvoicesPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkAssignInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "55cbbcf1-57cc-462d-93bc-0e8836b5f64a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_BulkAssignInvoicesPopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_b_BulkAssignInvoicesPopupClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
vars.value.notificationContentInLocal = notificationContentIn.clone();
vars.value.notificationErrorInLocal = notificationErrorIn.clone();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// NotifContent = NotificationContent
model.variables.notifContentVar = vars.value.notificationContentInLocal;
// NotifError = NotificationError
model.variables.notifErrorVar = vars.value.notificationErrorInLocal;
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("NotifContentWB"), callContext);

// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// Close PopUp
// l_ShowAssignAnalistaPopup = notl_ShowAssignAnalistaPopup
model.variables.l_ShowAssignAnalistaPopupVar = (!(model.variables.l_ShowAssignAnalistaPopupVar));
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_InvoiceApprovalLevelListVar, callContext);
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
_getInvoicesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "5978d2eb-2f29-4733-b429-d73d7c9b898c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoicesOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
var listIndexOfToApproveVar = new OS$DataTypes.VariableHolder();
var listIndexOfToAssignVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsListFullNeedRefresh = True
model.variables.isListFullNeedRefreshVar = true;
// l_IsSelectedForApproval = False
model.variables.l_IsSelectedForApprovalVar = false;
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// Execute Action: ListIndexOfToApprove
listIndexOfToApproveVar.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return ((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr));
}, callContext);

// Execute Action: ListIndexOfToAssign
listIndexOfToAssignVar.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesAggr.listOut, function (p) {
return ((((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && p.invoiceApprovalLevelAttr.selectsNextApproverAttr) && (p.invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier()));
}, callContext);

// l_IsShowSelectAll = ListIndexOfToApprove.Position <> -1 or ListIndexOfToAssign.Position <> -1
model.variables.l_IsShowSelectAllVar = (((listIndexOfToApproveVar.value.positionOut) !== ((-1))) || ((listIndexOfToAssignVar.value.positionOut) !== ((-1))));
// Count
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchVar === 0))) {
// l_CountAfterFetch = l_CountAfterFetch + 1
model.variables.l_CountAfterFetchVar = (model.variables.l_CountAfterFetchVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("InvoicesTable"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVar = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
}).then(function () {
// IsSupervisor?
return OS$Flow.executeSequence(function () {
if((model.variables.getUserApplicationRolesAndMoreDataAct.isSupervisorOut)) {
// Refresh Query: GetInvoiceCountToAssign
var result = controller.getInvoiceCountToAssign$DataActRefresh(callContext);
model.flush();
return result;
}

});
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
span.setAttribute("outsystems.function.key", "5e7bb968-d3a2-463e-a2bf-bde7cbc8be4b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ScreenTableDownloadsOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.ScreenTableDownloadsOnClick$vars"))());
vars.value.isCloseInLocal = isCloseIn;
// l_ShowScreenTableDownloads = notl_ShowScreenTableDownloads
model.variables.l_ShowScreenTableDownloadsVar = (!(model.variables.l_ShowScreenTableDownloadsVar));
if((vars.value.isCloseInLocal)) {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_InvoicesTablesIdListVar, callContext);
} else {
// Foreach GetInvoices.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoicesAggr.listOut);
try {var getInvoicesIterator = callContext.iterationContext.getIterator(model.variables.getInvoicesAggr.listOut);
var getInvoicesIndex = 0;
while (((getInvoicesIndex < model.variables.getInvoicesAggr.listOut.length))) {
getInvoicesIterator.currentRowNumber = getInvoicesIndex;
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.l_InvoicesTablesIdListVar, model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceAttr.idAttr, callContext);
getInvoicesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoicesAggr.listOut);
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
_getInvoiceCountToAssignOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceCountToAssignOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCountToAssignOnAfterFetch");
span.setAttribute("outsystems.function.key", "6878bf18-24c5-41e8-9254-1fd945e532eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetInvoiceCountToAssignOnAfterFetch");
callContext = controller.callContext(callContext);
var notificationOpenVar = new OS$DataTypes.VariableHolder();
// IsShowInfoMsg?
if((model.variables.getInvoiceCountToAssignDataAct.isShowInfoMsgOut)) {
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("NotifNoPendingAssignInv"), callContext);

}

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
span.setAttribute("outsystems.function.key", "689446e4-5604-41ae-81b7-57e9ffad4411");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Invoice_SupplierId = SupplierId
ConectaProveedoresClientVariables.setInvoice_SupplierId(vars.value.supplierIdInLocal);
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "6ea03d32-13f0-41ee-afac-b05419c4f024");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("InvoicesTable"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVar = ColumnJSON
model.variables.l_ColumnJSONVarVar = vars.value.columnJSONInLocal;
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "7617d2ae-53ee-46b8-8c84-fe3bbb10790a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// Invoice_InvoiceName = ""
ConectaProveedoresClientVariables.setInvoice_InvoiceName("");
// Invoice_RequisitionName = ""
ConectaProveedoresClientVariables.setInvoice_RequisitionName("");
// Invoice_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setInvoice_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Invoice_UploadDateFrom = NullDate
ConectaProveedoresClientVariables.setInvoice_UploadDateFrom(OS$BuiltinFunctions.nullDate());
// Invoice_UploadDateTo = NullDate
ConectaProveedoresClientVariables.setInvoice_UploadDateTo(OS$BuiltinFunctions.nullDate());
// Invoice_CompanyId = NullIdentifier
ConectaProveedoresClientVariables.setInvoice_CompanyId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Invoice_ProjectId = NullIdentifier
ConectaProveedoresClientVariables.setInvoice_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Invoice_ApprovalStatusId = NullIdentifier
ConectaProveedoresClientVariables.setInvoice_ApprovalStatusId(OS$BuiltinFunctions.nullIdentifier());
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
span.setAttribute("outsystems.function.key", "7ac4db38-e6f9-4bdc-800f-3434cb32ea6d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectAllLines");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.SelectAllLines$vars"))());
// Count = 0
vars.value.countVar = 0;
if((model.variables.l_IsSelectAllVar)) {
// Foreach GetInvoices.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoicesAggr.listOut);
try {var getInvoicesIterator = callContext.iterationContext.getIterator(model.variables.getInvoicesAggr.listOut);
var getInvoicesIndex = 0;
while (((getInvoicesIndex < model.variables.getInvoicesAggr.listOut.length))) {
getInvoicesIterator.currentRowNumber = getInvoicesIndex;
if((((vars.value.countVar === 20) && model.variables.getUserApplicationRolesAndMoreDataAct.isJefeCxPOut))) {
return ;

} else {
// IsSelected = True
// GetInvoices.List.Current.IsSelected = GetInvoices.List.Current.InvoiceApprovalLevel.ApprovalStatusId = NotApproved and GetInvoices.List.Current.InvoiceApprovalLevel.AssignedTo = GetUserId or GetInvoices.List.Current.IsUserFromThisRegion and GetInvoices.List.Current.Invoice.InvoiceStatusId <> Accounting or GetInvoices.List.Current.InvoiceApprovalLevel.ApprovalStatusId = ToAssign and GetInvoices.List.Current.InvoiceApprovalLevel.AssignedTo = GetUserId or GetInvoices.List.Current.IsUserFromThisRegion and GetInvoices.List.Current.InvoiceApprovalLevel.SelectsNextApprover and GetInvoices.List.Current.InvoiceApprovalLevel.ApprovedBy = NullTextIdentifier
model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).isSelectedAttr = ((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && ((model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting))) || ((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceApprovalLevelAttr.selectsNextApproverAttr) && (model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier())));
// l_IsSelectedForApproval = If
model.variables.l_IsSelectedForApprovalVar = ((model.variables.l_IsSelectedForApprovalVar) ? (true) : ((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && ((model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.accounting)))));
// l_IsSelectedForAssignment = If
model.variables.l_IsSelectedForAssignmentVar = ((model.variables.l_IsSelectedForAssignmentVar) ? (true) : (((((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || model.variables.getInvoicesAggr.listOut.getCurrent(callContext.iterationContext).isUserFromThisRegionAttr)) && model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceApprovalLevelAttr.selectsNextApproverAttr) && (model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier()))));
// Count = If
vars.value.countVar = ((model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).isSelectedAttr) ? ((vars.value.countVar + 1)) : (vars.value.countVar));
}

getInvoicesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoicesAggr.listOut);
}

} else {
// Foreach GetInvoices.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoicesAggr.listOut);
try {var getInvoicesIterator = callContext.iterationContext.getIterator(model.variables.getInvoicesAggr.listOut);
var getInvoicesIndex = 0;
while (((getInvoicesIndex < model.variables.getInvoicesAggr.listOut.length))) {
getInvoicesIterator.currentRowNumber = getInvoicesIndex;
// IsSelected = False
// GetInvoices.List.Current.IsSelected = False
model.variables.getInvoicesAggr.listOut.getItem(getInvoicesIndex.valueOf()).isSelectedAttr = false;
getInvoicesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoicesAggr.listOut);
}

// l_IsSelectedForApproval = False
model.variables.l_IsSelectedForApprovalVar = false;
// l_IsSelectedForAssignment = False
model.variables.l_IsSelectedForAssignmentVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_d_InvoiceAssignFirstApproverOpen$Action(i_InvoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_d_InvoiceAssignFirstApproverOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_d_InvoiceAssignFirstApproverOpen");
span.setAttribute("outsystems.function.key", "8301462d-2c85-4bfb-af2c-a4c7a46e59f1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_d_InvoiceAssignFirstApproverOpen");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_d_InvoiceAssignFirstApproverOpen$vars"))());
vars.value.i_InvoiceIdInLocal = i_InvoiceIdIn;
// l_ShowAssignFirstApproverPopup = notl_ShowAssignFirstApproverPopup
model.variables.l_ShowAssignFirstApproverPopupVar = (!(model.variables.l_ShowAssignFirstApproverPopupVar));
// l_InvoiceId = i_InvoiceId
model.variables.l_InvoiceIdVar = vars.value.i_InvoiceIdInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_b_BulkApproveInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkApproveInvoicesPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkApproveInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "a07d2c54-c1cd-4916-8e52-a8070cfd6743");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_BulkApproveInvoicesPopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_b_BulkApproveInvoicesPopupClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
vars.value.notificationContentInLocal = notificationContentIn.clone();
vars.value.notificationErrorInLocal = notificationErrorIn.clone();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// NotifContent = NotificationContent
model.variables.notifContentVar = vars.value.notificationContentInLocal;
// NotifError = NotificationError
model.variables.notifErrorVar = vars.value.notificationErrorInLocal;
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("NotifContentWB"), callContext);

// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// Close PopUp
// l_ShowBulkApproveInvoices = notl_ShowBulkApproveInvoices
model.variables.l_ShowBulkApproveInvoicesVar = (!(model.variables.l_ShowBulkApproveInvoicesVar));
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_InvoiceApprovalLevelListVar, callContext);
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
_wb_b_BulkCancelInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkCancelInvoicesPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkCancelInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "a2f995c0-fcdc-4fb4-b131-9ccab20ab763");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_BulkCancelInvoicesPopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_b_BulkCancelInvoicesPopupClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
vars.value.notificationContentInLocal = notificationContentIn.clone();
vars.value.notificationErrorInLocal = notificationErrorIn.clone();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// NotifContent = NotificationContent
model.variables.notifContentVar = vars.value.notificationContentInLocal;
// NotifError = NotificationError
model.variables.notifErrorVar = vars.value.notificationErrorInLocal;
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("NotifContentWB"), callContext);

// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// Close PopUp
// l_ShowBulkRejectPopup = notl_ShowBulkRejectPopup
model.variables.l_ShowBulkRejectPopupVar = (!(model.variables.l_ShowBulkRejectPopupVar));
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_InvoiceApprovalLevelListVar, callContext);
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
_wb_c_InvoiceCommentOpen$Action(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_c_InvoiceCommentOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_InvoiceCommentOpen");
span.setAttribute("outsystems.function.key", "a7f906b3-f1b4-4d23-9c3a-1d75e57fcfa7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_c_InvoiceCommentOpen");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_c_InvoiceCommentOpen$vars"))());
vars.value.i_InvoiceIdInLocal = i_InvoiceIdIn;
vars.value.i_InvoiceApprovalLevelIdInLocal = i_InvoiceApprovalLevelIdIn;
// Set Locals
// l_InvoiceId = i_InvoiceId
model.variables.l_InvoiceIdVar = vars.value.i_InvoiceIdInLocal;
// l_InvoiceApprovalLevelId = i_InvoiceApprovalLevelId
model.variables.l_InvoiceApprovalLevelIdVar = vars.value.i_InvoiceApprovalLevelIdInLocal;
// l_ShowComment = notl_ShowComment
model.variables.l_ShowCommentVar = (!(model.variables.l_ShowCommentVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_d_InvoiceAssignFirstApproverClose$Action(isRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_d_InvoiceAssignFirstApproverClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_d_InvoiceAssignFirstApproverClose");
span.setAttribute("outsystems.function.key", "b526b154-6e5e-42f9-ae4a-8f0b64072f85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_d_InvoiceAssignFirstApproverClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_d_InvoiceAssignFirstApproverClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// l_ShowAssignFirstApproverPopup = notl_ShowAssignFirstApproverPopup
model.variables.l_ShowAssignFirstApproverPopupVar = (!(model.variables.l_ShowAssignFirstApproverPopupVar));
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
_clearUploadDateFrom$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearUploadDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "ClearUploadDateFrom");
span.setAttribute("outsystems.function.key", "ba54b47f-f7ee-43fc-9c8f-b86971abdec4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearUploadDateFrom");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Invoice_UploadDateFrom = NullDate
ConectaProveedoresClientVariables.setInvoice_UploadDateFrom(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerFrom"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerFrom"), callContext);

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
_wb_e_InvoiceAssignAnalistaOpen$Action(i_InvoiceIn, i_InvoiceApprovalLevelIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_e_InvoiceAssignAnalistaOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_e_InvoiceAssignAnalistaOpen");
span.setAttribute("outsystems.function.key", "be11a7fb-ec9c-4cf7-9dd8-7f96dc6bef43");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_e_InvoiceAssignAnalistaOpen");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_e_InvoiceAssignAnalistaOpen$vars"))());
vars.value.i_InvoiceInLocal = i_InvoiceIn.clone();
vars.value.i_InvoiceApprovalLevelInLocal = i_InvoiceApprovalLevelIn.clone();
// l_ShowAssignAnalistaPopup = notl_ShowAssignAnalistaPopup
model.variables.l_ShowAssignAnalistaPopupVar = (!(model.variables.l_ShowAssignAnalistaPopupVar));
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(model.variables.l_InvoiceApprovalLevelListVar, function () {
var rec = new RC_7d9af3f1351b60af34cc932af3010814();
rec.invoiceAttr = vars.value.i_InvoiceInLocal;
rec.invoiceApprovalLevelAttr = vars.value.i_InvoiceApprovalLevelInLocal;
return rec;
}(), callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_b_BulkAssignPopUpOpen$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkAssignPopUpOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkAssignPopUpOpen");
span.setAttribute("outsystems.function.key", "c56aeced-f6f8-4b34-a351-121d90fbf047");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_b_BulkAssignPopUpOpen");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// l_ShowAssignAnalistaPopup = notl_ShowAssignAnalistaPopup
model.variables.l_ShowAssignAnalistaPopupVar = (!(model.variables.l_ShowAssignAnalistaPopupVar));
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesAggr.listOut, function (p) {
return (p.isSelectedAttr && ((((p.invoiceApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toAssign) && ((p.invoiceApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId()) || p.isUserFromThisRegionAttr)) && p.invoiceApprovalLevelAttr.selectsNextApproverAttr) && (p.invoiceApprovalLevelAttr.approvedByAttr === OS$BuiltinFunctions.nullTextIdentifier())));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(model.variables.l_InvoiceApprovalLevelListVar, function () {
var rec = new RC_7d9af3f1351b60af34cc932af3010814();
rec.invoiceAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr;
rec.invoiceApprovalLevelAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceApprovalLevelAttr;
return rec;
}(), callContext);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_c_BulkInvoiceCommentClose$Action(isRefreshIn, notificationContentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_c_BulkInvoiceCommentClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_BulkInvoiceCommentClose");
span.setAttribute("outsystems.function.key", "cfbb0a72-8f9c-4ebd-a127-5e402f10ec64");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_c_BulkInvoiceCommentClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_c_BulkInvoiceCommentClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
vars.value.notificationContentInLocal = notificationContentIn.clone();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
// l_ShowBulkComment = notl_ShowBulkComment
model.variables.l_ShowBulkCommentVar = (!(model.variables.l_ShowBulkCommentVar));
if((vars.value.isRefreshInLocal)) {
// NotifContent = NotificationContent
model.variables.notifContentVar = vars.value.notificationContentInLocal;
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("NotifContentWB"), callContext);

}

// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_InvoiceApprovalLevelListVar, callContext);
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_datePickerTo$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerTo", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "d118549d-6714-4f89-ace3-e9b19e5204bc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DatePickerTo$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Invoice_UploadDateTo = SelectedDate
ConectaProveedoresClientVariables.setInvoice_UploadDateTo(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "d43392aa-802a-49e9-a790-32e19ccb79c5");
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
rec.screenAttr = "FsP - Invoices";
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
_datePickerFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "d910a588-66e8-4894-88ec-4bc032a42b79");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DatePickerFrom$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Invoice_UploadDateFrom = SelectedDate
ConectaProveedoresClientVariables.setInvoice_UploadDateFrom(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "e10d36fd-a352-4714-ae82-c569729f00a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.OnSort$vars"))());
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
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
span.setAttribute("outsystems.function.key", "e12d3bcc-d39d-4399-9ead-33d4407e2c18");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_wb_a_ApproveInvoicePoupOpen$Action(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_ApproveInvoicePoupOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveInvoicePoupOpen");
span.setAttribute("outsystems.function.key", "e4706ede-8f17-49cc-b2e6-122098f56fb3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_a_ApproveInvoicePoupOpen");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_ApproveInvoicePoupOpen$vars"))());
vars.value.i_InvoiceIdInLocal = i_InvoiceIdIn;
vars.value.i_InvoiceApprovalLevelIdInLocal = i_InvoiceApprovalLevelIdIn;
// Set Locals
// l_InvoiceId = i_InvoiceId
model.variables.l_InvoiceIdVar = vars.value.i_InvoiceIdInLocal;
// l_InvoiceApprovalLevelId = i_InvoiceApprovalLevelId
model.variables.l_InvoiceApprovalLevelIdVar = vars.value.i_InvoiceApprovalLevelIdInLocal;
// l_ShowApproveInvoice = notl_ShowApproveInvoice
model.variables.l_ShowApproveInvoiceVar = (!(model.variables.l_ShowApproveInvoiceVar));
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "f5e10207-baf3-475a-b904-360391ea5d73");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerDateToVar = new OS$DataTypes.VariableHolder();
var datePickerDateFromVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
// l_IsSelectedForApproval = False
model.variables.l_IsSelectedForApprovalVar = false;
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// l_IsSelectedForAssignment = False
model.variables.l_IsSelectedForAssignmentVar = false;
// l_IsSelectAllForAssignment = False
model.variables.l_IsSelectAllForAssignmentVar = false;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
// Execute Action: DatePickerDateFrom
datePickerDateFromVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerFrom"), callContext);

// Execute Action: DatePickerDateTo
datePickerDateToVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerTo"), callContext);

}

// Refresh Query: GetInvoices
var result = controller.getInvoices$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_dropdownProjectSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownProjectSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownProjectSearchOnChanged");
span.setAttribute("outsystems.function.key", "fe2051a5-1e69-4b48-92ab-20d02fbdbc6c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownProjectSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DropdownProjectSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Invoice_ProjectId = IntegerToIdentifier
ConectaProveedoresClientVariables.setInvoice_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr))));
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

wb_DownloadsFloatOnClick$Action(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_DownloadsFloatOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DownloadsFloatOnClick");
span.setAttribute("outsystems.function.key", "0d6ec6a3-e2bf-40b4-92af-235e4fb311ed");
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

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "156d0d2d-bb35-4112-9e6d-002073fb3b1f");
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

clearUploadDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearUploadDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearUploadDateTo");
span.setAttribute("outsystems.function.key", "17204c58-c41b-44c7-aaeb-a0e8af16047f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearUploadDateTo$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_a_RejectInvoicesPopupClose$Action(isRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_RejectInvoicesPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_RejectInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "1c6e17ef-8f73-4df8-95b9-5ffa592ed6c5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_a_RejectInvoicesPopupClose$Action, callContext, isRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_a_ApproveInvoicePopupClose$Action(isRefreshIn, commentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_ApproveInvoicePopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveInvoicePopupClose");
span.setAttribute("outsystems.function.key", "20e8bc5d-95eb-4e39-91ae-da4a1c785834");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_a_ApproveInvoicePopupClose$Action, callContext, isRefreshIn, commentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_c_InvoiceCommentClose$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_c_InvoiceCommentClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_InvoiceCommentClose");
span.setAttribute("outsystems.function.key", "2602c5b1-2698-487f-a7fc-ddbe0e610502");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_c_InvoiceCommentClose$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_c_BulkInvoiceCommentOpen$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_c_BulkInvoiceCommentOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_BulkInvoiceCommentOpen");
span.setAttribute("outsystems.function.key", "36108997-6cca-4d07-8644-d704f1d3c0f0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_c_BulkInvoiceCommentOpen$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_b_BulkApprovePopUpOpen$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkApprovePopUpOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkApprovePopUpOpen");
span.setAttribute("outsystems.function.key", "386dff05-37a8-43e7-9474-9b42f30d7f7c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_b_BulkApprovePopUpOpen$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_b_BulkCancelInvoicesPopupOpen$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkCancelInvoicesPopupOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkCancelInvoicesPopupOpen");
span.setAttribute("outsystems.function.key", "3c9c3cb7-8b9e-4a46-ad2d-5d3d89247ed0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_b_BulkCancelInvoicesPopupOpen$Action, callContext);
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
span.setAttribute("outsystems.function.key", "3da1ceb9-f5b1-42e8-a8c5-8df01810a56d");
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

wb_a_RejectInvoicePopupOpen$Action(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_RejectInvoicePopupOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_RejectInvoicePopupOpen");
span.setAttribute("outsystems.function.key", "420724d0-ea11-4abc-834c-dad23d785b2d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_a_RejectInvoicePopupOpen$Action, callContext, i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

isAnyLineSelected$Action(currentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("IsAnyLineSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "4d8c28fe-d1b0-4112-92ab-5c691fc9c87b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._isAnyLineSelected$Action, callContext, currentRowNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_b_BulkAssignInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkAssignInvoicesPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkAssignInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "55cbbcf1-57cc-462d-93bc-0e8836b5f64a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_BulkAssignInvoicesPopupClose$Action, callContext, isRefreshIn, notificationContentIn, notificationErrorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getInvoicesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "5978d2eb-2f29-4733-b429-d73d7c9b898c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoicesOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "5e7bb968-d3a2-463e-a2bf-bde7cbc8be4b");
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

getInvoiceCountToAssignOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceCountToAssignOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCountToAssignOnAfterFetch");
span.setAttribute("outsystems.function.key", "6878bf18-24c5-41e8-9254-1fd945e532eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getInvoiceCountToAssignOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "689446e4-5604-41ae-81b7-57e9ffad4411");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "6ea03d32-13f0-41ee-afac-b05419c4f024");
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

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "7617d2ae-53ee-46b8-8c84-fe3bbb10790a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._resetFilters$Action, callContext);
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
span.setAttribute("outsystems.function.key", "7ac4db38-e6f9-4bdc-800f-3434cb32ea6d");
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

wb_d_InvoiceAssignFirstApproverOpen$Action(i_InvoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_d_InvoiceAssignFirstApproverOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_d_InvoiceAssignFirstApproverOpen");
span.setAttribute("outsystems.function.key", "8301462d-2c85-4bfb-af2c-a4c7a46e59f1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_d_InvoiceAssignFirstApproverOpen$Action, callContext, i_InvoiceIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_b_BulkApproveInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkApproveInvoicesPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkApproveInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "a07d2c54-c1cd-4916-8e52-a8070cfd6743");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_BulkApproveInvoicesPopupClose$Action, callContext, isRefreshIn, notificationContentIn, notificationErrorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_BulkCancelInvoicesPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkCancelInvoicesPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkCancelInvoicesPopupClose");
span.setAttribute("outsystems.function.key", "a2f995c0-fcdc-4fb4-b131-9ccab20ab763");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_BulkCancelInvoicesPopupClose$Action, callContext, isRefreshIn, notificationContentIn, notificationErrorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_c_InvoiceCommentOpen$Action(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_c_InvoiceCommentOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_InvoiceCommentOpen");
span.setAttribute("outsystems.function.key", "a7f906b3-f1b4-4d23-9c3a-1d75e57fcfa7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_c_InvoiceCommentOpen$Action, callContext, i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_d_InvoiceAssignFirstApproverClose$Action(isRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_d_InvoiceAssignFirstApproverClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_d_InvoiceAssignFirstApproverClose");
span.setAttribute("outsystems.function.key", "b526b154-6e5e-42f9-ae4a-8f0b64072f85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_d_InvoiceAssignFirstApproverClose$Action, callContext, isRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

clearUploadDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearUploadDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearUploadDateFrom");
span.setAttribute("outsystems.function.key", "ba54b47f-f7ee-43fc-9c8f-b86971abdec4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearUploadDateFrom$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_e_InvoiceAssignAnalistaOpen$Action(i_InvoiceIn, i_InvoiceApprovalLevelIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_e_InvoiceAssignAnalistaOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_e_InvoiceAssignAnalistaOpen");
span.setAttribute("outsystems.function.key", "be11a7fb-ec9c-4cf7-9dd8-7f96dc6bef43");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_e_InvoiceAssignAnalistaOpen$Action, callContext, i_InvoiceIn, i_InvoiceApprovalLevelIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_b_BulkAssignPopUpOpen$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkAssignPopUpOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkAssignPopUpOpen");
span.setAttribute("outsystems.function.key", "c56aeced-f6f8-4b34-a351-121d90fbf047");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_b_BulkAssignPopUpOpen$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_c_BulkInvoiceCommentClose$Action(isRefreshIn, notificationContentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_c_BulkInvoiceCommentClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_BulkInvoiceCommentClose");
span.setAttribute("outsystems.function.key", "cfbb0a72-8f9c-4ebd-a127-5e402f10ec64");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_c_BulkInvoiceCommentClose$Action, callContext, isRefreshIn, notificationContentIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

datePickerTo$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "d118549d-6714-4f89-ace3-e9b19e5204bc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerTo$Action, callContext, selectedDateIn);
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
span.setAttribute("outsystems.function.key", "d43392aa-802a-49e9-a790-32e19ccb79c5");
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

datePickerFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "d910a588-66e8-4894-88ec-4bc032a42b79");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerFrom$Action, callContext, selectedDateIn);
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
span.setAttribute("outsystems.function.key", "e10d36fd-a352-4714-ae82-c569729f00a6");
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
span.setAttribute("outsystems.function.key", "e12d3bcc-d39d-4399-9ead-33d4407e2c18");
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

wb_a_ApproveInvoicePoupOpen$Action(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_ApproveInvoicePoupOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveInvoicePoupOpen");
span.setAttribute("outsystems.function.key", "e4706ede-8f17-49cc-b2e6-122098f56fb3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_a_ApproveInvoicePoupOpen$Action, callContext, i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "f5e10207-baf3-475a-b904-360391ea5d73");
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

dropdownProjectSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownProjectSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownProjectSearchOnChanged");
span.setAttribute("outsystems.function.key", "fe2051a5-1e69-4b48-92ab-20d02fbdbc6c");
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
return ConectaProveedores_d_InvoicesController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Proveedor, ConectaProveedoresController$default.roles.Requisiciones]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices$ActionScreenTableDownloadInvoiceScreen", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices$ActionApprovModifInv", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "IsFinish",
attrName: "isFinishOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_DownloadsFloatOnClick$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_RejectInvoicesPopupClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_ApproveInvoicePopupClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "Comment",
attrName: "commentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_RejectInvoicePopupOpen$vars", [{
name: "i_InvoiceId",
attrName: "i_InvoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_InvoiceApprovalLevelId",
attrName: "i_InvoiceApprovalLevelIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.IsAnyLineSelected$vars", [{
name: "CurrentRowNumber",
attrName: "currentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_b_BulkAssignInvoicesPopupClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "NotificationContent",
attrName: "notificationContentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6ac87b97c676cd17082ba2063283d4baStructure();
},
complexType: ST_6ac87b97c676cd17082ba2063283d4baStructure
}, {
name: "NotificationError",
attrName: "notificationErrorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
},
complexType: ST_bb4ffb4d3263f72e713312025a0e6fc7Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.ScreenTableDownloadsOnClick$vars", [{
name: "IsClose",
attrName: "isCloseInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.SelectAllLines$vars", [{
name: "Count",
attrName: "countVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_d_InvoiceAssignFirstApproverOpen$vars", [{
name: "i_InvoiceId",
attrName: "i_InvoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_b_BulkApproveInvoicesPopupClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "NotificationContent",
attrName: "notificationContentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6ac87b97c676cd17082ba2063283d4baStructure();
},
complexType: ST_6ac87b97c676cd17082ba2063283d4baStructure
}, {
name: "NotificationError",
attrName: "notificationErrorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
},
complexType: ST_bb4ffb4d3263f72e713312025a0e6fc7Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_b_BulkCancelInvoicesPopupClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "NotificationContent",
attrName: "notificationContentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6ac87b97c676cd17082ba2063283d4baStructure();
},
complexType: ST_6ac87b97c676cd17082ba2063283d4baStructure
}, {
name: "NotificationError",
attrName: "notificationErrorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
},
complexType: ST_bb4ffb4d3263f72e713312025a0e6fc7Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_c_InvoiceCommentOpen$vars", [{
name: "i_InvoiceId",
attrName: "i_InvoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_InvoiceApprovalLevelId",
attrName: "i_InvoiceApprovalLevelIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_d_InvoiceAssignFirstApproverClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_e_InvoiceAssignAnalistaOpen$vars", [{
name: "i_Invoice",
attrName: "i_InvoiceInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "i_InvoiceApprovalLevel",
attrName: "i_InvoiceApprovalLevelInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
},
complexType: EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_c_BulkInvoiceCommentClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "NotificationContent",
attrName: "notificationContentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6ac87b97c676cd17082ba2063283d4baStructure();
},
complexType: ST_6ac87b97c676cd17082ba2063283d4baStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DatePickerTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DatePickerFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.Wb_a_ApproveInvoicePoupOpen$vars", [{
name: "i_InvoiceId",
attrName: "i_InvoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_InvoiceApprovalLevelId",
attrName: "i_InvoiceApprovalLevelIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Invoices.DropdownProjectSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


