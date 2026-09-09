import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import { ST_e54bcdc56c6f092fdfed672ad024bfa4Structure, RC_b668eee4846e2937101a51355804499d } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ENUserEntityRecord } from "./System_.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioById$AggrRefresh: 0,
getOrderMains$AggrRefresh: 0,
getSuppliers$AggrRefresh: 0,
getFolioApprovalLevels$AggrRefresh: 0,
getFolioItemsByFolioId$AggrRefresh: 0,
getCurrencies$AggrRefresh: 0,
getCompanies$AggrRefresh: 0,
getUserData$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFolioById$AggrRefresh: [],
getOrderMains$AggrRefresh: [],
getSuppliers$AggrRefresh: [],
getFolioApprovalLevels$AggrRefresh: [],
getFolioItemsByFolioId$AggrRefresh: [],
getCurrencies$AggrRefresh: [],
getCompanies$AggrRefresh: [],
getUserData$DataActRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
cancelFolio$ServerAction(objectIn, folioRejectIn, folioApprovalLevels_ListIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelFolio", function (span) {
if(span) {
span.setAttribute("code.function", "CancelFolio");
span.setAttribute("outsystems.function.key", "4257f0fe-dcb6-4714-bbee-416c8264f1e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Object: OS$DataConversion.ServerDataConverter.to(objectIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
FolioReject: OS$DataConversion.ServerDataConverter.to(folioRejectIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
FolioApprovalLevels_List: OS$DataConversion.ServerDataConverter.to(folioApprovalLevels_ListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("CancelFolio", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ActionCancelFolio", "WRNZNDPipRwzS2RSrvOwwQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail$ActionCancelFolio"))();
executeServerActionResult.errorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMsg, OS$DataTypes.DataTypes.Text);
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
get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetFolioById", "RJfNj93mpUtUsFcG33deXw", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getFolioByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "0b403135-6a39-4212-8ded-b377658a12fb");
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

get getOrderMains$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMains$AggrRefresh"))) {
this._getOrderMains$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMains", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetOrderMains", "9wptoqGyIhY+bk7oZFsLCw", maxRecords, startIndex, function (b) {
model.variables.getOrderMainsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMains", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMains");
span.setAttribute("outsystems.function.key", "4efa4cf9-5506-4331-b0af-473237b8b706");
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

return this._getOrderMains$AggrRefresh;
}set getOrderMains$AggrRefresh(value) {this._getOrderMains$AggrRefresh = value;
}

get getSuppliers$AggrRefresh() {if(!(this.hasOwnProperty("_getSuppliers$AggrRefresh"))) {
this._getSuppliers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSuppliers", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetSuppliers", "XUfoK88vdt8Q9S49yI+Wbw", maxRecords, startIndex, function (b) {
model.variables.getSuppliersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSuppliersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSuppliersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "GetSuppliers");
span.setAttribute("outsystems.function.key", "64c8427e-d78e-49e0-a589-a8d328c2e53c");
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

return this._getSuppliers$AggrRefresh;
}set getSuppliers$AggrRefresh(value) {this._getSuppliers$AggrRefresh = value;
}

get getFolioApprovalLevels$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioApprovalLevels$AggrRefresh"))) {
this._getFolioApprovalLevels$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioApprovalLevels", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetFolioApprovalLevels", "XYhIFg1h4Qtmrh1PGjUCYQ", maxRecords, startIndex, function (b) {
model.variables.getFolioApprovalLevelsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioApprovalLevelsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioApprovalLevelsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioApprovalLevels", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalLevels");
span.setAttribute("outsystems.function.key", "9b387d35-9f9a-4c2e-af3f-d91beffce0ed");
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

return this._getFolioApprovalLevels$AggrRefresh;
}set getFolioApprovalLevels$AggrRefresh(value) {this._getFolioApprovalLevels$AggrRefresh = value;
}

get getFolioItemsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioItemsByFolioId$AggrRefresh"))) {
this._getFolioItemsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioItemsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetFolioItemsByFolioId", "CAtxS2ERBBGr3FuUSoX4qw", maxRecords, startIndex, function (b) {
model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioItemsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioItemsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioItemsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioId");
span.setAttribute("outsystems.function.key", "b67db95e-02fa-4893-9da2-b49809f9b48d");
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

get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "e4ed1c86-a8f4-4dbd-af4d-337d9bc1fb73");
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

return this._getCurrencies$AggrRefresh;
}set getCurrencies$AggrRefresh(value) {this._getCurrencies$AggrRefresh = value;
}

get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/ScreenDataSetGetCompanies", "fuNZkB7C5QmfKr5yUIVg3g", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "e849b8f5-85b6-428f-9c41-defae1d24939");
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

get getUserData$DataActRefresh() {if(!(this.hasOwnProperty("_getUserData$DataActRefresh"))) {
this._getUserData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserData", "screenservices/ConectaProveedores/j_FoliosSAE/PreApprovalFolioDetail/DataActionGetUserData", "u9rDSDiupqS30ElVXCLf9Q", function (b) {
model.variables.getUserDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getUserDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserData", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserData");
span.setAttribute("outsystems.function.key", "9ba7d0ad-d3e0-4f87-8adb-9506e8e5b7b2");
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

return this._getUserData$DataActRefresh;
}set getUserData$DataActRefresh(value) {this._getUserData$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioById$AggrRefresh", "getOrderMains$AggrRefresh", "getSuppliers$AggrRefresh", "getFolioApprovalLevels$AggrRefresh", "getFolioItemsByFolioId$AggrRefresh", "getCurrencies$AggrRefresh", "getCompanies$AggrRefresh", "getUserData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "342cc09e-17b5-41b8-ac16-801405542230");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.OnPaginationNavigate$vars"))());
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
_wb_SAECInvoicesRefresh$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SAECInvoicesRefresh", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SAECInvoicesRefresh");
span.setAttribute("outsystems.function.key", "3ccc532e-c46f-432d-8868-0de669670097");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SAECInvoicesRefresh");
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
_cancelEntryOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelEntryOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CancelEntryOnClick");
span.setAttribute("outsystems.function.key", "3dbf1095-b189-4cdc-9f79-34298da34801");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CancelEntryOnClick");
callContext = controller.callContext(callContext);
// Execute Action: TogglePopup
controller._togglePopup$Action(callContext);
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
span.setAttribute("outsystems.function.key", "41ec27c2-a8c1-4291-bcd5-676bcfad0604");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.tableSort2Var === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort2 += DESC
// TableSort2 = SortBy + " DESC"
model.variables.tableSort2Var = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort2 = SortBy
// TableSort2 = SortBy
model.variables.tableSort2Var = vars.value.sortByInLocal;
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
_wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence");
span.setAttribute("outsystems.function.key", "5160e4d2-02bd-41b1-91cb-29e55e8abc19");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence");
callContext = controller.callContext(callContext);
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
span.setAttribute("outsystems.function.key", "51ea7ceb-5082-45bb-84ad-1b01f7d73e68");
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
rec.screenAttr = "Pre Approval Folio Detail";
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
_getFolioByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "62674a1d-269f-412d-9e29-01d2c63b0431");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetFolioByIdOnAfterFetch");
callContext = controller.callContext(callContext);
// I_CanReject = GetFolioById.List.Current.Invoice.Id <> NullIdentifier and GetFolioById.List.Current.Invoice.InvoiceStatusId <> Rejected
model.variables.i_CanRejectVar = (!(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.rejected)));
// I_CanCancelIncoice = GetFolioById.List.Current.Invoice.Id <> NullIdentifier and GetFolioById.List.Current.Invoice.InvoiceStatusId <> Canceled
model.variables.i_CanCancelIncoiceVar = (!(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.canceled)));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_togglePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopup", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "64a453c8-296e-48f8-866c-f51a54a60dc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopup");
callContext = controller.callContext(callContext);
// ShowCancelFolioPopup = notShowCancelFolioPopup
model.variables.showCancelFolioPopupVar = (!(model.variables.showCancelFolioPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getUserDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "752807a8-2b42-4cdb-be39-a78647710c2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetUserDataOnAfterFetch");
callContext = controller.callContext(callContext);
// Invalid permission?
if(((!(model.variables.getUserDataDataAct.o_IsCXPOut)))) {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_invoiceRejectOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("InvoiceRejectOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceRejectOnChange");
span.setAttribute("outsystems.function.key", "77df2aa5-ee72-4b67-8a33-16ddd6fb17cc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("InvoiceRejectOnChange");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearFolioReject$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFolioReject", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFolioReject");
span.setAttribute("outsystems.function.key", "a13b8b1a-d34a-4430-a5ca-19018aaee15a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearFolioReject");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.ClearFolioReject$vars"))());
// FolioReject = EmptyFolioReject
model.variables.folioRejectVar = vars.value.emptyFolioRejectVar;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_invoiceCancelCheckboxOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("InvoiceCancelCheckboxOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceCancelCheckboxOnChange");
span.setAttribute("outsystems.function.key", "c51bedd6-3404-4840-922b-fd7e704d1db5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("InvoiceCancelCheckboxOnChange");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_confirmCancelFolioOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ConfirmCancelFolioOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmCancelFolioOnClick");
span.setAttribute("outsystems.function.key", "df4f9742-71e3-4985-9847-f4ae91ca33d7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ConfirmCancelFolioOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var cancelFolioVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsExecuting = True
model.variables.isExecutingVar = true;
// No Reason?
return OS$Flow.executeSequence(function () {
if(((((model.variables.folioRejectVar.isCancelEntryAttr || model.variables.folioRejectVar.isCancelInvoiceAttr) || model.variables.folioRejectVar.isCancelFolioAttr) && (model.variables.folioRejectVar.reasonAttr === "")))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("PhXpujMe6kWRX+M6COd5tQ#Message.-1557020001.1", "Reason is mandatory"), /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
} else {
// Execute Action: CancelFolio
model.flush();
return controller.cancelFolio$ServerAction(OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext), new RC_b668eee4846e2937101a51355804499d(), function (source, target) {
target.folioAttr = source.folioAttr;
target.invoiceAttr = source.invoiceAttr;
return target;
}), model.variables.folioRejectVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getFolioApprovalLevelsAggr.listOut, new (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(ENUserEntityRecord, {
name: "User",
attrName: "userAttr",
nameForJson: "User",
uniqueId: "ced01335-8a82-a813-f1d9-a5108f17ce79"
}))))(), function (source, target) {
target.userAttr = source.userAttr;
return target;
}), ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
cancelFolioVar.value = value;
}).then(function () {
// Success
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IS1jBH21E06xGjn6gV0X2g#Message.1437466524.1", "Cancel operation was successfull"), /*Success*/ 1);
// Destination: /ConectaProveedores/PreApprovalFolioDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "PreApprovalFolioDetail", {
i_FolioId: OS$DataConversion.ServerDataConverter.to(model.variables.i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
}

});
}).catch(function (ex) {
OS$Logger.debug("PreApprovalFolioDetail.ConfirmCancelFolioOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "ea2b449a-3422-4b43-a86d-9186797ef51b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// Error
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
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

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "342cc09e-17b5-41b8-ac16-801405542230");
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

wb_SAECInvoicesRefresh$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SAECInvoicesRefresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SAECInvoicesRefresh");
span.setAttribute("outsystems.function.key", "3ccc532e-c46f-432d-8868-0de669670097");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SAECInvoicesRefresh$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

cancelEntryOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelEntryOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelEntryOnClick");
span.setAttribute("outsystems.function.key", "3dbf1095-b189-4cdc-9f79-34298da34801");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._cancelEntryOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "41ec27c2-a8c1-4291-bcd5-676bcfad0604");
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

wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence");
span.setAttribute("outsystems.function.key", "5160e4d2-02bd-41b1-91cb-29e55e8abc19");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence$Action, callContext);
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
span.setAttribute("outsystems.function.key", "51ea7ceb-5082-45bb-84ad-1b01f7d73e68");
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

getFolioByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "62674a1d-269f-412d-9e29-01d2c63b0431");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getFolioByIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

togglePopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "64a453c8-296e-48f8-866c-f51a54a60dc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getUserDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "752807a8-2b42-4cdb-be39-a78647710c2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getUserDataOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

invoiceRejectOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceRejectOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceRejectOnChange");
span.setAttribute("outsystems.function.key", "77df2aa5-ee72-4b67-8a33-16ddd6fb17cc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._invoiceRejectOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearFolioReject$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFolioReject__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFolioReject");
span.setAttribute("outsystems.function.key", "a13b8b1a-d34a-4430-a5ca-19018aaee15a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._clearFolioReject$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

invoiceCancelCheckboxOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceCancelCheckboxOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceCancelCheckboxOnChange");
span.setAttribute("outsystems.function.key", "c51bedd6-3404-4840-922b-fd7e704d1db5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._invoiceCancelCheckboxOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

confirmCancelFolioOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ConfirmCancelFolioOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmCancelFolioOnClick");
span.setAttribute("outsystems.function.key", "df4f9742-71e3-4985-9847-f4ae91ca33d7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._confirmCancelFolioOnClick$Action, callContext);
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
roles: [ConectaProveedoresController$default.roles.Pedidos, ConectaProveedoresController$default.roles.Folios]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail$ActionCancelFolio", [{
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.ClearFolioReject$vars", [{
name: "EmptyFolioReject",
attrName: "emptyFolioRejectVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure();
},
complexType: ST_e54bcdc56c6f092fdfed672ad024bfa4Structure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


