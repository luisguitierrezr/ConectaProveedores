import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getProposalById$AggrRefresh: 0,
getProposalLinesByProposalId$AggrRefresh: -1,
getFileImportLogsByFileId$AggrRefresh: -1
};
this.dataFetchDependentsGraph = {
getProposalById$AggrRefresh: ["getFileImportLogsByFileId$AggrRefresh"],
getProposalLinesByProposalId$AggrRefresh: [],
getFileImportLogsByFileId$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("DownloadFileWithProposalId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ActionDownloadFileWithProposalId", "orzRncjq6at+5OYp6Ib1PA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError$ActionDownloadFileWithProposalId"))();
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError$ActionGetSettings"))();
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalById", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ScreenDataSetGetProposalById", "Dno0SXwM7txWV1bQi9NwMQ", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "813d6b23-2aed-4e76-8559-c58e10971302");
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

get getProposalLinesByProposalId$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalLinesByProposalId$AggrRefresh"))) {
this._getProposalLinesByProposalId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalLinesByProposalId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ScreenDataSetGetProposalLinesByProposalId", "v90tH6wU6LkG1vM_E1694A", maxRecords, startIndex, function (b) {
model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalLinesByProposalIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalLinesByProposalIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalLinesByProposalId", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalLinesByProposalId");
span.setAttribute("outsystems.function.key", "9a607690-9d50-4e3d-8458-21efa21825e3");
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

get getFileImportLogsByFileId$AggrRefresh() {if(!(this.hasOwnProperty("_getFileImportLogsByFileId$AggrRefresh"))) {
this._getFileImportLogsByFileId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFileImportLogsByFileId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalDetailError/ScreenDataSetGetFileImportLogsByFileId", "eEh3pKPD+ZM7Vel4Si5exA", maxRecords, startIndex, function (b) {
model.variables.getFileImportLogsByFileIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFileImportLogsByFileIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFileImportLogsByFileIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFileImportLogsByFileId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFileImportLogsByFileId");
span.setAttribute("outsystems.function.key", "d099bb06-e466-4a55-964c-3bbe717180e9");
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

return this._getFileImportLogsByFileId$AggrRefresh;
}set getFileImportLogsByFileId$AggrRefresh(value) {this._getFileImportLogsByFileId$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getProposalById$AggrRefresh", "getProposalLinesByProposalId$AggrRefresh", "getFileImportLogsByFileId$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_seeLogsOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeLogsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "003d32de-91f3-4753-a87d-9b835bc6ecef");
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1935acbd-1987-4c0a-ae17-c27173b15e81");
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
rec.screenAttr = "CyA - Proposal Detail Error";
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "6f7be482-5bcc-46d3-a425-660c90c99c4c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.OnSort$vars"))());
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "73ad3ddc-d433-4172-b5c1-2ce20ec36a0a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresProposalDetailErrorProposalLines"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetProposalDetailError = ColumnJSON
model.variables.l_ColumnJSONVarGetProposalDetailErrorVar = vars.value.columnJSONInLocal;
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "b3dc34ba-a256-481c-8952-c8c34966f5e7");
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "d667bda1-01f4-4419-9996-48d931ce70f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
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
_downloadFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "ebcafc93-6833-4b26-9e94-2349c1320609");
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nPaC7cEaz0m0k5n_j6t5vQ#Message.525723613.1", "File not found."), /*Error*/ 3);
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
span.setAttribute("outsystems.function.key", "f0ae3a68-aa52-455f-a499-5370023c54dc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarLog"), callContext);

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
span.setAttribute("outsystems.function.key", "f9202aa2-f1da-44b6-a32b-c08c9ff04508");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalByIdOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// No proposal data
return OS$Flow.executeSequence(function () {
if((model.variables.getProposalByIdAggr.listOut.isEmpty)) {
// Destination: /ConectaProveedores/ProposalsListViewer
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsListViewer", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Not ErrorAPI
return OS$Flow.executeSequence(function () {
if((((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr) !== (ConectaProveedores_staticEntities_proposalStatus.errorAPI)))) {
// Destination: /ConectaProveedores/ProposalDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetail", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.i_ProposalIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Refresh Query: GetProposalLinesByProposalId
var result = controller.getProposalLinesByProposalId$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetFileImportLogsByFileId
var result = controller.getFileImportLogsByFileId$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// DateTextFormatted = If
model.variables.dateTextFormattedVar = ((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr.equals(OS$BuiltinFunctions.nullDate())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("htXpmAZ0SEWleb+G8ZMv6A#Value.965837104.1", "Undefined")) : (OS$BuiltinFunctions.formatDateTime(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy")));
}).then(function () {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetProposalDetailErrorVar === 0))) {
// l_CountAfterFetchGetProposalDetailError = l_CountAfterFetchGetProposalDetailError + 1
model.variables.l_CountAfterFetchGetProposalDetailErrorVar = (model.variables.l_CountAfterFetchGetProposalDetailErrorVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresProposalDetailErrorProposalLines"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetProposalDetailError = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetProposalDetailErrorVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// l_Loading = False
model.variables.l_LoadingVar = false;
});
}

});
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

seeLogsOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeLogsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "003d32de-91f3-4753-a87d-9b835bc6ecef");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1935acbd-1987-4c0a-ae17-c27173b15e81");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "6f7be482-5bcc-46d3-a425-660c90c99c4c");
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
span.setAttribute("outsystems.function.key", "73ad3ddc-d433-4172-b5c1-2ce20ec36a0a");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "b3dc34ba-a256-481c-8952-c8c34966f5e7");
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

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "d667bda1-01f4-4419-9996-48d931ce70f7");
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

downloadFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "ebcafc93-6833-4b26-9e94-2349c1320609");
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
span.setAttribute("outsystems.function.key", "f0ae3a68-aa52-455f-a499-5370023c54dc");
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

getProposalByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "f9202aa2-f1da-44b6-a32b-c08c9ff04508");
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
roles: [ConectaProveedoresController$default.roles.ComissionesArrendamientosAdmin, ConectaProveedoresController$default.roles.ComissionesArrendamientosViewer]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError$ActionDownloadFileWithProposalId", [{
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.PaginationOnNavigate$vars", [{
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


