import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, notificationOpen$Action as OutSystemsUIController$notificationOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_3dc7a528e6a1e146b195db5c3edb006aStructure, ST_6ac87b97c676cd17082ba2063283d4baStructure, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure, ST_a158c76eb93396680623c04244f48b6cStructure, RC_ab183c41bd8594296e7d4471350fb29f } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFoliosSAE$AggrRefresh: -1,
getFolioStatus$AggrRefresh: 0,
getFoliosSAEFull$AggrRefresh: -1,
getRegions$AggrRefresh: 0,
getUserApplicationRoles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFoliosSAE$AggrRefresh: [],
getFolioStatus$AggrRefresh: [],
getFoliosSAEFull$AggrRefresh: [],
getRegions$AggrRefresh: [],
getUserApplicationRoles$DataActRefresh: ["getFoliosSAE$AggrRefresh", "getFoliosSAEFull$AggrRefresh"]
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval$ActionGetSettings"))();
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
approvRejectFolio$ServerAction(i_FolioIdIn, i_FolioApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovRejectFolio", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovRejectFolio");
span.setAttribute("outsystems.function.key", "2b037169-b232-4efd-bcf0-327a5aae73e6");
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
}),
i_FolioApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_FolioApprovalLevelIdIn, {
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
return controller.callServerAction("ApprovRejectFolio", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ActionApprovRejectFolio", "3lMt9PSpF_QXCgb0Q9x67w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval$ActionApprovRejectFolio"))();
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
screenTableDownloadFoliosSAEScreen$ServerAction(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, i_FolioScreenTableStructureIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ScreenTableDownloadFoliosSAEScreen", function (span) {
if(span) {
span.setAttribute("code.function", "ScreenTableDownloadFoliosSAEScreen");
span.setAttribute("outsystems.function.key", "585ad689-66e2-435f-9d8c-558244ad5c56");
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
i_FolioScreenTableStructure: OS$DataConversion.ServerDataConverter.to(i_FolioScreenTableStructureIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ScreenTableDownloadFoliosSAEScreen", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ActionScreenTableDownloadFoliosSAEScreen", "LVjcGOv1UoUSO9O1l3vMbw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval$ActionScreenTableDownloadFoliosSAEScreen"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, ST_a158c76eb93396680623c04244f48b6cStructure);
executeServerActionResult.o_StringListIdsOut = OS$DataConversion.ServerDataConverter.from(outputs.o_StringListIds, OS$DataTypes.DataTypes.Text);
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getFoliosSAE$AggrRefresh() {if(!(this.hasOwnProperty("_getFoliosSAE$AggrRefresh"))) {
this._getFoliosSAE$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFoliosSAE", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ScreenDataSetGetFoliosSAE", "62fH_TWIO4jS5huf9zYTZA", maxRecords, startIndex, function (b) {
model.variables.getFoliosSAEAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFoliosSAEAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFoliosSAEAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getFoliosOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFoliosSAE", function (span) {
if(span) {
span.setAttribute("code.function", "GetFoliosSAE");
span.setAttribute("outsystems.function.key", "55f5ff86-004d-4948-9b1f-2c0c17498030");
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

return this._getFoliosSAE$AggrRefresh;
}set getFoliosSAE$AggrRefresh(value) {this._getFoliosSAE$AggrRefresh = value;
}

get getFolioStatus$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioStatus$AggrRefresh"))) {
this._getFolioStatus$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioStatus", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ScreenDataSetGetFolioStatus", "xBnU5wAcTZo_8FO6VaKyzw", maxRecords, startIndex, function (b) {
model.variables.getFolioStatusAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioStatusAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioStatusAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioStatus", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioStatus");
span.setAttribute("outsystems.function.key", "73d3d733-8fb6-4e94-8c87-d8c43e9df985");
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

return this._getFolioStatus$AggrRefresh;
}set getFolioStatus$AggrRefresh(value) {this._getFolioStatus$AggrRefresh = value;
}

get getFoliosSAEFull$AggrRefresh() {if(!(this.hasOwnProperty("_getFoliosSAEFull$AggrRefresh"))) {
this._getFoliosSAEFull$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFoliosSAEFull", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ScreenDataSetGetFoliosSAEFull", "XORNFwepOUSGuXg3lejq7g", maxRecords, startIndex, function (b) {
model.variables.getFoliosSAEFullAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFoliosSAEFullAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFoliosSAEFullAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFoliosSAEFull", function (span) {
if(span) {
span.setAttribute("code.function", "GetFoliosSAEFull");
span.setAttribute("outsystems.function.key", "845dd42e-2fa3-46b5-8b05-811161b19ac1");
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

return this._getFoliosSAEFull$AggrRefresh;
}set getFoliosSAEFull$AggrRefresh(value) {this._getFoliosSAEFull$AggrRefresh = value;
}

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/ScreenDataSetGetRegions", "SJnDYtRnLWQGCXlJCfY6FA", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "dfbe964d-d3a6-43fe-8509-5e18a9cdeb41");
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

return this._getRegions$AggrRefresh;
}set getRegions$AggrRefresh(value) {this._getRegions$AggrRefresh = value;
}

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosSAEForApproval/DataActionGetUserApplicationRoles", "RR2x4__eAZDkjpav6tGuow", function (b) {
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
span.setAttribute("outsystems.function.key", "5a69ff78-2836-43bc-82e7-832d8a9e3404");
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
this._dataFetchActionNames = ["getFoliosSAE$AggrRefresh", "getFolioStatus$AggrRefresh", "getFoliosSAEFull$AggrRefresh", "getRegions$AggrRefresh", "getUserApplicationRoles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getFoliosOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFoliosOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFoliosOnAfterFetch");
span.setAttribute("outsystems.function.key", "0c38ab4b-4aa0-40e4-856d-67239b1c46ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetFoliosOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsListFullNeedRefresh = True
model.variables.isListFullNeedRefreshVar = true;
// l_IsSelected = False
model.variables.l_IsSelectedVar = false;
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getFoliosSAEAggr.listOut, function (p) {
return p.canApproveAttr;
}, callContext);

// l_IsShowSelectAll = ListIndexOf.Position <> -1
model.variables.l_IsShowSelectAllVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
// Count
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchVar === 0))) {
// l_CountAfterFetch = l_CountAfterFetch + 1
model.variables.l_CountAfterFetchVar = (model.variables.l_CountAfterFetchVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("FoliosTable2"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVar = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarVar = getSettingsVar.value.outSettingsTextOut;
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "1931c05a-7246-4671-a001-01adfd7214a5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFoliosSAE
var result = controller.getFoliosSAE$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
span.setAttribute("outsystems.function.key", "1a264825-edac-4e17-8949-bdd1ecb5333d");
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
rec.screenAttr = "Folios SAE For Approval";
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "1d0db460-2367-4543-929b-fe032f47e4e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetFoliosSAE
var result = controller.getFoliosSAE$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_wb_a_ApproveFolioPopupClose$Action(isRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_ApproveFolioPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveFolioPopupClose");
span.setAttribute("outsystems.function.key", "29c82a8a-7148-4e8d-80b2-df4c8905a6cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_a_ApproveFolioPopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_a_ApproveFolioPopupClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
var approvRejectFolioVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ApprovRejectFolio
model.flush();
return controller.approvRejectFolio$ServerAction(model.variables.l_FolioIdVar, model.variables.l_FolioApprovalLevelIdVar, true, "", ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
approvRejectFolioVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((approvRejectFolioVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
if((((approvRejectFolioVar.value.o_OutputOut.messageAttr) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("xhW2yuR1PkWmwfChzfxtwA#Message.2112002139.1", "Form has been approved. ") + " ") + approvRejectFolioVar.value.o_OutputOut.messageAttr), /*Success*/ 1);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("v6kVpcnO60uISWYjI7bY7g#Message.899413093.1", "Form has been approved."), /*Success*/ 1);
}

// Clear Locals
// l_ShowApproveFolio = notl_ShowApproveFolio
model.variables.l_ShowApproveFolioVar = (!(model.variables.l_ShowApproveFolioVar));
// Refresh Query: GetFoliosSAE
var result = controller.getFoliosSAE$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(approvRejectFolioVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Clear Locals
// l_ShowApproveFolio = notl_ShowApproveFolio
model.variables.l_ShowApproveFolioVar = (!(model.variables.l_ShowApproveFolioVar));
}

});
});
} else {
// Clear Locals
// l_FolioId = NullIdentifier
model.variables.l_FolioIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_FolioApprovalLevelId = NullIdentifier
model.variables.l_FolioApprovalLevelIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_ShowApproveFolio = notl_ShowApproveFolio
model.variables.l_ShowApproveFolioVar = (!(model.variables.l_ShowApproveFolioVar));
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_clearDateOn$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateOn", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateOn");
span.setAttribute("outsystems.function.key", "2ac9b606-d5bc-4990-8ae5-3fdabaacc693");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateOn");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// FolioForApproval_CreatedOnDate = NullDate
ConectaProveedoresClientVariables.setFolioForApproval_CreatedOnDate(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerCreatedOn"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerCreatedOn"), callContext);

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
_selectAllLines$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectAllLines", function (span) {
if(span) {
span.setAttribute("code.function", "SelectAllLines");
span.setAttribute("outsystems.function.key", "429ac95b-3270-4101-9008-ad99d8f35531");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectAllLines");
callContext = controller.callContext(callContext);
if((model.variables.l_IsSelectAllVar)) {
// l_IsSelected = True
model.variables.l_IsSelectedVar = true;
// Foreach GetFoliosSAE.List
callContext.iterationContext.registerIterationStart(model.variables.getFoliosSAEAggr.listOut);
try {var getFoliosSAEIterator = callContext.iterationContext.getIterator(model.variables.getFoliosSAEAggr.listOut);
var getFoliosSAEIndex = 0;
while (((getFoliosSAEIndex < model.variables.getFoliosSAEAggr.listOut.length))) {
getFoliosSAEIterator.currentRowNumber = getFoliosSAEIndex;
// IsSelected = True
// GetFoliosSAE.List.Current.IsSelected = GetFoliosSAE.List.Current.CanApprove
model.variables.getFoliosSAEAggr.listOut.getItem(getFoliosSAEIndex.valueOf()).isSelectedAttr = model.variables.getFoliosSAEAggr.listOut.getItem(getFoliosSAEIndex.valueOf()).canApproveAttr;
getFoliosSAEIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getFoliosSAEAggr.listOut);
}

} else {
// Foreach GetFoliosSAE.List
callContext.iterationContext.registerIterationStart(model.variables.getFoliosSAEAggr.listOut);
try {var getFoliosSAEIterator = callContext.iterationContext.getIterator(model.variables.getFoliosSAEAggr.listOut);
var getFoliosSAEIndex = 0;
while (((getFoliosSAEIndex < model.variables.getFoliosSAEAggr.listOut.length))) {
getFoliosSAEIterator.currentRowNumber = getFoliosSAEIndex;
// IsSelected = False
// GetFoliosSAE.List.Current.IsSelected = False
model.variables.getFoliosSAEAggr.listOut.getItem(getFoliosSAEIndex.valueOf()).isSelectedAttr = false;
getFoliosSAEIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getFoliosSAEAggr.listOut);
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
_wb_DownloadsFloatOnClick$Action(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_DownloadsFloatOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DownloadsFloatOnClick");
span.setAttribute("outsystems.function.key", "49da27e8-87dc-46e4-b9bb-f311156277d3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_DownloadsFloatOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_DownloadsFloatOnClick$vars"))());
vars.value.i_IsCSVInLocal = i_IsCSVIn;
vars.value.i_IsPDFInLocal = i_IsPDFIn;
vars.value.i_IsXLSInLocal = i_IsXLSIn;
var screenTableDownloadFoliosSAEScreenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.isListFullNeedRefreshVar)) {
// Refresh Query: GetFoliosSAEFull
var result = controller.getFoliosSAEFull$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}

}).then(function () {
// Execute Action: ScreenTableDownloadFoliosSAEScreen
model.flush();
return controller.screenTableDownloadFoliosSAEScreen$ServerAction(vars.value.i_IsCSVInLocal, vars.value.i_IsPDFInLocal, vars.value.i_IsXLSInLocal, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getFoliosSAEFullAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_3dc7a528e6a1e146b195db5c3edb006aStructure))(), function (source, target) {
target.folioIdAttr = source.folioApprovalAttr.folioIdAttr;
target.folioNumberAttr = source.folioAttr.folioNumberAttr;
target.orderNumberAttr = source.orderMainAttr.orderNumberAttr;
target.supplierNameAttr = source.supplierAttr.nameAttr;
target.supplierNumberAttr = source.supplierAttr.numberAttr;
target.regionAttr = source.regionAttr.codeAttr;
target.totalAmountAttr = OS$BuiltinFunctions.decimalToText(source.folioAttr.totalAmountAttr);
target.currencyAttr = source.folioAttr.currencyIdAttr;
target.uploadDateAttr = OS$BuiltinFunctions.formatDateTime(source.folioAttr.createdOnAttr, "dd/MM/yyyy");
target.statusAttr = source.folioStatusAttr.labelAttr;
return target;
}), callContext).then(function (value) {
screenTableDownloadFoliosSAEScreenVar.value = value;
}).then(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
});
}).then(function () {
// error?
if((((screenTableDownloadFoliosSAEScreenVar.value.o_ErrorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(screenTableDownloadFoliosSAEScreenVar.value.o_ErrorMsgOut, /*Error*/ 3);
} else {
// null?
if((OS$DataTypes.areBinaryNulls(screenTableDownloadFoliosSAEScreenVar.value.o_FileOut.binaryDataAttr, OS$BuiltinFunctions.nullBinary()))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("m2ZQH7V14EWsVQDiua9n7g#Message.-1067972576.1", "There was a problem downloading your file. Please contact an administrator."), /*Error*/ 3);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+s3A_xBmK0+868mZLeruRw#Message.269443952.1", "File downloaded with success."), /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(screenTableDownloadFoliosSAEScreenVar.value.o_FileOut.binaryDataAttr, screenTableDownloadFoliosSAEScreenVar.value.o_FileOut.nameAttr));
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "56526e33-3b21-4cd7-a868-08a5514e6199");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerCreatedOn2Var = new OS$DataTypes.VariableHolder();
var datePickerCreatedOn3Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
// Execute Action: DatePickerCreatedOn2
datePickerCreatedOn2Var.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerCreatedOn"), callContext);

// Execute Action: DatePickerCreatedOn3
datePickerCreatedOn3Var.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerCreatedTo"), callContext);

}

// Refresh Query: GetFoliosSAE
var result = controller.getFoliosSAE$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_wb_b_BulkApproveFoliosPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_BulkApproveFoliosPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkApproveFoliosPopupClose");
span.setAttribute("outsystems.function.key", "593c8d04-878e-4dde-9e33-f62f188d268e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_BulkApproveFoliosPopupClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_b_BulkApproveFoliosPopupClose$vars"))());
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

// Refresh Query: GetFoliosSAE
var result = controller.getFoliosSAE$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

}).then(function () {
// Close PopUp
// l_ShowBulkApproveFolio = notl_ShowBulkApproveFolio
model.variables.l_ShowBulkApproveFolioVar = (!(model.variables.l_ShowBulkApproveFolioVar));
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_FolioApprovalLevelListVar, callContext);
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
_datePickerCreatedOn$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerCreatedOn", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerCreatedOn");
span.setAttribute("outsystems.function.key", "72518029-bcc5-4517-950f-d2918d7f9292");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerCreatedOn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.DatePickerCreatedOn$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// FolioApproved_CreatedOnDate = SelectedDate
ConectaProveedoresClientVariables.setFolioApproved_CreatedOnDate(vars.value.selectedDateInLocal);
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "73b72753-2bd2-46d1-bb20-85514f96843a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("IsAnyLineSelected");
callContext = controller.callContext(callContext);
var listIndexOf2Var = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListIndexOf2
listIndexOf2Var.value = OS$SystemActions.listIndexOf(model.variables.getFoliosSAEAggr.listOut, function (p) {
return ((!(p.isSelectedAttr)) && p.canApproveAttr);
}, callContext);

if((((listIndexOf2Var.value.positionOut) !== ((-1))))) {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getFoliosSAEAggr.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// l_IsSelected = ListIndexOf.Position <> -1
model.variables.l_IsSelectedVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
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
_wb_a_ApproveFolioPopupOpen$Action(i_FolioIdIn, i_FolioApprovalLevelIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_ApproveFolioPopupOpen", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveFolioPopupOpen");
span.setAttribute("outsystems.function.key", "78c654a2-3119-4488-af2a-1cd4354b2092");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_a_ApproveFolioPopupOpen");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_a_ApproveFolioPopupOpen$vars"))());
vars.value.i_FolioIdInLocal = i_FolioIdIn;
vars.value.i_FolioApprovalLevelIdInLocal = i_FolioApprovalLevelIdIn;
// Set Locals
// l_FolioId = i_FolioId
model.variables.l_FolioIdVar = vars.value.i_FolioIdInLocal;
// l_FolioApprovalLevelId = i_FolioApprovalLevelId
model.variables.l_FolioApprovalLevelIdVar = vars.value.i_FolioApprovalLevelIdInLocal;
// l_ShowApproveFolio = notl_ShowApproveFolio
model.variables.l_ShowApproveFolioVar = (!(model.variables.l_ShowApproveFolioVar));
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
span.setAttribute("outsystems.function.key", "8162d151-deb1-43cc-9988-27e8c81abb1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_b_BulkApprovePopUpOpen");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// l_ShowBulkApproveFolio = notl_ShowBulkApproveFolio
model.variables.l_ShowBulkApproveFolioVar = (!(model.variables.l_ShowBulkApproveFolioVar));
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getFoliosSAEAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.folioApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListAppendProposalLineApprovalLevelId_s
OS$SystemActions.listAppend(model.variables.l_FolioApprovalLevelListVar, function () {
var rec = new RC_ab183c41bd8594296e7d4471350fb29f();
rec.folioAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).folioAttr;
rec.folioApprovalLevelAttr = listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).folioApprovalLevelAttr;
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "9400b768-b3dd-413f-937e-b1c6e6f4b91f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("FoliosTable2"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "997c69f9-7228-4d7d-a931-3b74412e3d7b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.OnSort$vars"))());
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
// Refresh Query: GetFoliosSAE
var result = controller.getFoliosSAE$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "ae9272e1-ece7-4811-b7c0-6c3bc424685a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// FolioForApproval_FolioNumber = ""
ConectaProveedoresClientVariables.setFolioForApproval_FolioNumber("");
// FolioForApproval_OrderNumber = ""
ConectaProveedoresClientVariables.setFolioForApproval_OrderNumber("");
// FolioForApproval_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setFolioForApproval_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// FolioForApproval_CreatedOnDate = NullDate
ConectaProveedoresClientVariables.setFolioForApproval_CreatedOnDate(OS$BuiltinFunctions.nullDate());
// FolioForApproval_RegionId = NullIdentifier
ConectaProveedoresClientVariables.setFolioForApproval_RegionId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// FolioForApproval_CreatedToDate = NullDate
ConectaProveedoresClientVariables.setFolioForApproval_CreatedToDate(OS$BuiltinFunctions.nullDate());
// FolioForApproval_StatusId = NullIdentifier
ConectaProveedoresClientVariables.setFolioForApproval_StatusId(OS$BuiltinFunctions.nullIdentifier());
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "b57ae961-a3a5-436a-9946-f0c1ee2d3b26");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateTo");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// FolioForApproval_CreatedToDate = NullDate
ConectaProveedoresClientVariables.setFolioForApproval_CreatedToDate(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerCreatedTo"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerCreatedTo"), callContext);

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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "b942ea06-6077-432d-bcea-f9444dd02103");
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
_dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "e5ff832e-6850-498a-8f72-ed67db228d20");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// FolioForApproval_SupplierId = SupplierId
ConectaProveedoresClientVariables.setFolioForApproval_SupplierId(vars.value.supplierIdInLocal);
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

getFoliosOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFoliosOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFoliosOnAfterFetch");
span.setAttribute("outsystems.function.key", "0c38ab4b-4aa0-40e4-856d-67239b1c46ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getFoliosOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "1931c05a-7246-4671-a001-01adfd7214a5");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1a264825-edac-4e17-8949-bdd1ecb5333d");
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

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "1d0db460-2367-4543-929b-fe032f47e4e0");
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

wb_a_ApproveFolioPopupClose$Action(isRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_ApproveFolioPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveFolioPopupClose");
span.setAttribute("outsystems.function.key", "29c82a8a-7148-4e8d-80b2-df4c8905a6cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_a_ApproveFolioPopupClose$Action, callContext, isRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

clearDateOn$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateOn");
span.setAttribute("outsystems.function.key", "2ac9b606-d5bc-4990-8ae5-3fdabaacc693");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearDateOn$Action, callContext);
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
span.setAttribute("outsystems.function.key", "429ac95b-3270-4101-9008-ad99d8f35531");
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

wb_DownloadsFloatOnClick$Action(i_IsCSVIn, i_IsPDFIn, i_IsXLSIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_DownloadsFloatOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_DownloadsFloatOnClick");
span.setAttribute("outsystems.function.key", "49da27e8-87dc-46e4-b9bb-f311156277d3");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "56526e33-3b21-4cd7-a868-08a5514e6199");
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

wb_b_BulkApproveFoliosPopupClose$Action(isRefreshIn, notificationContentIn, notificationErrorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_BulkApproveFoliosPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_BulkApproveFoliosPopupClose");
span.setAttribute("outsystems.function.key", "593c8d04-878e-4dde-9e33-f62f188d268e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_BulkApproveFoliosPopupClose$Action, callContext, isRefreshIn, notificationContentIn, notificationErrorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerCreatedOn$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerCreatedOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerCreatedOn");
span.setAttribute("outsystems.function.key", "72518029-bcc5-4517-950f-d2918d7f9292");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerCreatedOn$Action, callContext, selectedDateIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

isAnyLineSelected$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("IsAnyLineSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "73b72753-2bd2-46d1-bb20-85514f96843a");
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

wb_a_ApproveFolioPopupOpen$Action(i_FolioIdIn, i_FolioApprovalLevelIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_ApproveFolioPopupOpen__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_ApproveFolioPopupOpen");
span.setAttribute("outsystems.function.key", "78c654a2-3119-4488-af2a-1cd4354b2092");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_a_ApproveFolioPopupOpen$Action, callContext, i_FolioIdIn, i_FolioApprovalLevelIdIn);
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
span.setAttribute("outsystems.function.key", "8162d151-deb1-43cc-9988-27e8c81abb1f");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "9400b768-b3dd-413f-937e-b1c6e6f4b91f");
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
span.setAttribute("outsystems.function.key", "997c69f9-7228-4d7d-a931-3b74412e3d7b");
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

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "ae9272e1-ece7-4811-b7c0-6c3bc424685a");
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

clearDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "b57ae961-a3a5-436a-9946-f0c1ee2d3b26");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearDateTo$Action, callContext);
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
span.setAttribute("outsystems.function.key", "b942ea06-6077-432d-bcea-f9444dd02103");
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

dropdownSuppliersOnChanged$Action(supplierIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "e5ff832e-6850-498a-8f72-ed67db228d20");
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
return ConectaProveedores_j_FoliosSAEController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Folios]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval$ActionApprovRejectFolio", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval$ActionScreenTableDownloadFoliosSAEScreen", [{
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
name: "o_ErrorMsg",
attrName: "o_ErrorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_a_ApproveFolioPopupClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_DownloadsFloatOnClick$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_b_BulkApproveFoliosPopupClose$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.DatePickerCreatedOn$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.Wb_a_ApproveFolioPopupOpen$vars", [{
name: "i_FolioId",
attrName: "i_FolioIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_FolioApprovalLevelId",
attrName: "i_FolioApprovalLevelIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


