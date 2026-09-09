import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getCurrencies$AggrRefresh: 0,
getOperators$AggrRefresh: 0,
getProposalStatus$AggrRefresh: 0,
getBanks$AggrRefresh: 0,
getProposalTypes$AggrRefresh: 0,
getProposals$AggrRefresh: 0,
getUploadType$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getCurrencies$AggrRefresh: [],
getOperators$AggrRefresh: [],
getProposalStatus$AggrRefresh: [],
getBanks$AggrRefresh: [],
getProposalTypes$AggrRefresh: [],
getProposals$AggrRefresh: [],
getUploadType$DataActRefresh: []
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
return controller.callServerAction("DownloadFileWithProposalId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ActionDownloadFileWithProposalId", "orzRncjq6at+5OYp6Ib1PA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer$ActionDownloadFileWithProposalId"))();
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer$ActionGetSettings"))();
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
get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "63fa31ba-d047-497e-b289-c6e3070a96b1");
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

get getOperators$AggrRefresh() {if(!(this.hasOwnProperty("_getOperators$AggrRefresh"))) {
this._getOperators$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOperators", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ScreenDataSetGetOperators", "FLVfBwjABjz9rC3dLNwU+w", maxRecords, startIndex, function (b) {
model.variables.getOperatorsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOperatorsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOperatorsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOperators", function (span) {
if(span) {
span.setAttribute("code.function", "GetOperators");
span.setAttribute("outsystems.function.key", "69e130d7-d56f-4ed9-9da3-7994eeeb1d3c");
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

get getProposalStatus$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalStatus$AggrRefresh"))) {
this._getProposalStatus$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalStatus", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ScreenDataSetGetProposalStatus", "fHnB7KKekLnAKr0PQushoA", maxRecords, startIndex, function (b) {
model.variables.getProposalStatusAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalStatusAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalStatusAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalStatus", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalStatus");
span.setAttribute("outsystems.function.key", "9e52fd38-0af3-4a6c-a3e0-41ddb9637e16");
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

return this._getProposalStatus$AggrRefresh;
}set getProposalStatus$AggrRefresh(value) {this._getProposalStatus$AggrRefresh = value;
}

get getBanks$AggrRefresh() {if(!(this.hasOwnProperty("_getBanks$AggrRefresh"))) {
this._getBanks$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBanks", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ScreenDataSetGetBanks", "7ybLE4e_O0XTjUbXrZeJEA", maxRecords, startIndex, function (b) {
model.variables.getBanksAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBanksAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBanksAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBanks", function (span) {
if(span) {
span.setAttribute("code.function", "GetBanks");
span.setAttribute("outsystems.function.key", "a6966edf-c9fe-444b-a100-4f76895f0f4a");
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

get getProposalTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getProposalTypes$AggrRefresh"))) {
this._getProposalTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalTypes", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ScreenDataSetGetProposalTypes", "qrypbYK+KS+7H1Kl+dChmQ", maxRecords, startIndex, function (b) {
model.variables.getProposalTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalTypes");
span.setAttribute("outsystems.function.key", "c9bd479a-57b8-4296-8c69-36b77e2bc7fb");
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

return this._getProposalTypes$AggrRefresh;
}set getProposalTypes$AggrRefresh(value) {this._getProposalTypes$AggrRefresh = value;
}

get getProposals$AggrRefresh() {if(!(this.hasOwnProperty("_getProposals$AggrRefresh"))) {
this._getProposals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposals", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/ScreenDataSetGetProposals", "yaoIQycJJBm6o8RJ79Iu6A", maxRecords, startIndex, function (b) {
model.variables.getProposalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposals", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposals");
span.setAttribute("outsystems.function.key", "fc41f251-10a3-46b7-b8af-3f7d4d745531");
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

return this._getProposals$AggrRefresh;
}set getProposals$AggrRefresh(value) {this._getProposals$AggrRefresh = value;
}

get getUploadType$DataActRefresh() {if(!(this.hasOwnProperty("_getUploadType$DataActRefresh"))) {
this._getUploadType$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUploadType", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsListViewer/DataActionGetUploadType", "kRch7b3NNnE8jBcf8fUWTQ", function (b) {
model.variables.getUploadTypeDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUploadTypeDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUploadTypeDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUploadType", function (span) {
if(span) {
span.setAttribute("code.function", "GetUploadType");
span.setAttribute("outsystems.function.key", "176f69f8-dc8f-4dca-9732-661ab99658c9");
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

return this._getUploadType$DataActRefresh;
}set getUploadType$DataActRefresh(value) {this._getUploadType$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getCurrencies$AggrRefresh", "getOperators$AggrRefresh", "getProposalStatus$AggrRefresh", "getBanks$AggrRefresh", "getProposalTypes$AggrRefresh", "getProposals$AggrRefresh", "getUploadType$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "14c35b3e-5c01-4e01-9903-3323a320adfb");
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
_onDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "1e5fe4b5-c64e-43b7-971b-bb4ddeab7fc2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDebounce");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Proposals_AmountMLFrom = TextToDecimal
ConectaProveedoresClientVariables.setProposals_AmountMLFrom(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountFromTextVar));
// Proposals_AmountMLTo = TextToDecimal
ConectaProveedoresClientVariables.setProposals_AmountMLTo(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountToTextVar));
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
_datePickerOnPaymentDateTo$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDateTo");
span.setAttribute("outsystems.function.key", "2552c2de-18b6-4acc-ad42-666487b8db5c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnPaymentDateTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.DatePickerOnPaymentDateTo$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Proposals_PaymentDateTo = SelectedDate
ConectaProveedoresClientVariables.setProposals_PaymentDateTo(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "294a9092-3128-40bf-99a2-d3417695a11f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetProposals
var result = controller.getProposals$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_clearDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "57d9a66e-2c5d-412d-9ca7-7cb4243ab643");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateTo");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Proposals_PaymentDateTo = NullDate
ConectaProveedoresClientVariables.setProposals_PaymentDateTo(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("Datepicker"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("Datepicker"), callContext);

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
_downloadFile$Action(i_ProposalIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "5b8cfbb9-252c-4ccb-97fe-7de609f5904e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.DownloadFile$vars"))());
vars.value.i_ProposalIdInLocal = i_ProposalIdIn;
var downloadFileWithProposalIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadFileWithProposalId
model.flush();
return controller.downloadFileWithProposalId$ServerAction(vars.value.i_ProposalIdInLocal, callContext).then(function (value) {
downloadFileWithProposalIdVar.value = value;
}).then(function () {
if((((downloadFileWithProposalIdVar.value.o_FilenameOut) !== ("")))) {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadFileWithProposalIdVar.value.o_BinaryDataOut, downloadFileWithProposalIdVar.value.o_FilenameOut));
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cZuEVX5hrk+KPt3msiKMWA#Message.525723613.1", "File not found."), /*Error*/ 3);
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
span.setAttribute("outsystems.function.key", "62faf2b8-baf6-4cee-ad5f-4bbbbac6aa16");
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
rec.screenAttr = "CyA - Proposals List Viewer";
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
_datePickerOnPaymentDateFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDateFrom");
span.setAttribute("outsystems.function.key", "7299067a-1695-4e25-8c2d-1bdfe345d8b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnPaymentDateFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.DatePickerOnPaymentDateFrom$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Requisitions_ProveedorFilter_UploadDateFrom = SelectedDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateFrom(vars.value.selectedDateInLocal);
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
span.setAttribute("outsystems.function.key", "96b066c7-9324-4c9b-b755-383913115ed9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresProposalsGetProposals"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetProposal = ColumnJSON
model.variables.l_ColumnJSONVarGetProposalVar = vars.value.columnJSONInLocal;
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "af5ff63a-6e73-407a-8f50-09a775e1287b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// l_AmountFromText = Proposals_AmountMLFrom
model.variables.l_AmountFromTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getProposals_AmountMLFrom());
// l_AmountToText = Proposals_AmountMLTo
model.variables.l_AmountToTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getProposals_AmountMLTo());
// l_ShowFilters = Proposals_Operator_AmountML <> NullTextIdentifier or Proposals_AmountMLFrom <> 0 or Proposals_AmountMLTo <> 0 or Proposals_Currency <> NullTextIdentifier or Proposals_UploadType <> NullIdentifier
model.variables.l_ShowFiltersVar = ((((((ConectaProveedoresClientVariables.getProposals_Operator_AmountML()) !== (OS$BuiltinFunctions.nullTextIdentifier())) || !(ConectaProveedoresClientVariables.getProposals_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((ConectaProveedoresClientVariables.getProposals_Currency()) !== (OS$BuiltinFunctions.nullTextIdentifier()))) || ((ConectaProveedoresClientVariables.getProposals_UploadType()) !== (OS$BuiltinFunctions.nullIdentifier())));
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
span.setAttribute("outsystems.function.key", "c2eb6dd2-5544-46c7-9b2d-631034e95c39");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerClear2Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Clear Filters
// Proposals_Region = NullIdentifier
ConectaProveedoresClientVariables.setProposals_Region(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Proposals_Bank = NullIdentifier
ConectaProveedoresClientVariables.setProposals_Bank(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Proposals_Operator_AmountML = NullTextIdentifier
ConectaProveedoresClientVariables.setProposals_Operator_AmountML(OS$BuiltinFunctions.nullTextIdentifier());
// Proposals_AmountMLFrom = 0
ConectaProveedoresClientVariables.setProposals_AmountMLFrom(OS$BuiltinFunctions.integerToDecimal(0));
// Proposals_AmountMLTo = 0
ConectaProveedoresClientVariables.setProposals_AmountMLTo(OS$BuiltinFunctions.integerToDecimal(0));
// Proposals_PaymentDateFrom = NullDate
ConectaProveedoresClientVariables.setProposals_PaymentDateFrom(OS$BuiltinFunctions.nullDate());
// Proposals_Status = NullIdentifier
ConectaProveedoresClientVariables.setProposals_Status(OS$BuiltinFunctions.nullIdentifier());
// Proposals_Currency = NullTextIdentifier
ConectaProveedoresClientVariables.setProposals_Currency(OS$BuiltinFunctions.nullTextIdentifier());
// Proposals_ProposalSearch = NullTextIdentifier
ConectaProveedoresClientVariables.setProposals_ProposalSearch(OS$BuiltinFunctions.nullTextIdentifier());
// Proposals_PaymentDateTo = NullDate
ConectaProveedoresClientVariables.setProposals_PaymentDateTo(OS$BuiltinFunctions.nullDate());
// Proposals_UploadType = NullIdentifier
ConectaProveedoresClientVariables.setProposals_UploadType(OS$BuiltinFunctions.nullIdentifier());
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
// Show filters
// l_ShowFilters = False
model.variables.l_ShowFiltersVar = false;
// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("Datepicker"), callContext);

// Execute Action: DatePickerClear2
datePickerClear2Var.value = OutSystemsUIController$datePickerClear$Action(idService.getId("Datepicker2"), callContext);

}

// Refresh Query: GetProposals
var result = controller.getProposals$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "e70ef34e-e881-4f60-9d87-c96647826014");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.OnSort$vars"))());
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
// Refresh Query: GetProposals
var result = controller.getProposals$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_getProposalOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalOnAfterFetch");
span.setAttribute("outsystems.function.key", "eddcf14d-fc99-40d4-8ca7-b8274aa65d4f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
if(((!(model.variables.getProposalsAggr.listOut.isEmpty)))) {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getProposalsAggr.listOut, function (p) {
return (!(p.fileExtendedAttr.isProcessedAttr));
}, callContext);

// l_IsAutoRefresh = ListIndexOf.Position <> -1
model.variables.l_IsAutoRefreshVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
}

return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetProposalVar === 0))) {
// l_CountAfterFetchGetProposal = l_CountAfterFetchGetProposal + 1
model.variables.l_CountAfterFetchGetProposalVar = (model.variables.l_CountAfterFetchGetProposalVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresProposalsGetProposals"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetProposal = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetProposalVar = getSettingsVar.value.outSettingsTextOut;
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
_clearDateFrom$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "f1332903-b50d-460b-85a9-07bef43b9a21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearDateFrom");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Proposals_PaymentDateFrom = NullDate
ConectaProveedoresClientVariables.setProposals_PaymentDateFrom(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("Datepicker2"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("Datepicker2"), callContext);

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
_expandFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExpandFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "f2a8752e-a274-4efc-97fa-675b72ec64b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.ExpandFilters$vars"))());
return OS$Flow.executeAsyncFlow(function () {
// l_ShowFilters = notl_ShowFilters
model.variables.l_ShowFiltersVar = (!(model.variables.l_ShowFiltersVar));
// Show filters
return OS$Flow.executeSequence(function () {
if((!(model.variables.l_ShowFiltersVar))) {
// IsRefresh = Proposals_Operator_AmountML <> NullTextIdentifier or Proposals_AmountMLFrom <> 0 or Proposals_AmountMLTo <> 0 or Proposals_Currency <> NullTextIdentifier or Proposals_UploadType <> NullIdentifier
vars.value.isRefreshVar = ((((((ConectaProveedoresClientVariables.getProposals_Operator_AmountML()) !== (OS$BuiltinFunctions.nullTextIdentifier())) || !(ConectaProveedoresClientVariables.getProposals_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((ConectaProveedoresClientVariables.getProposals_Currency()) !== (OS$BuiltinFunctions.nullTextIdentifier()))) || ((ConectaProveedoresClientVariables.getProposals_UploadType()) !== (OS$BuiltinFunctions.nullIdentifier())));
// Clear Filters
// Proposals_Operator_AmountML = NullTextIdentifier
ConectaProveedoresClientVariables.setProposals_Operator_AmountML(OS$BuiltinFunctions.nullTextIdentifier());
// Proposals_AmountMLFrom = 0
ConectaProveedoresClientVariables.setProposals_AmountMLFrom(OS$BuiltinFunctions.integerToDecimal(0));
// Proposals_AmountMLTo = 0
ConectaProveedoresClientVariables.setProposals_AmountMLTo(OS$BuiltinFunctions.integerToDecimal(0));
// Proposals_Currency = NullTextIdentifier
ConectaProveedoresClientVariables.setProposals_Currency(OS$BuiltinFunctions.nullTextIdentifier());
// Proposals_UploadType = NullIdentifier
ConectaProveedoresClientVariables.setProposals_UploadType(OS$BuiltinFunctions.nullIdentifier());
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshVar)) {
// Refresh Query: GetProposals
var result = controller.getProposals$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "14c35b3e-5c01-4e01-9903-3323a320adfb");
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

onDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "1e5fe4b5-c64e-43b7-971b-bb4ddeab7fc2");
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

datePickerOnPaymentDateTo$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDateTo");
span.setAttribute("outsystems.function.key", "2552c2de-18b6-4acc-ad42-666487b8db5c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnPaymentDateTo$Action, callContext, selectedDateIn);
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
span.setAttribute("outsystems.function.key", "294a9092-3128-40bf-99a2-d3417695a11f");
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

clearDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "57d9a66e-2c5d-412d-9ca7-7cb4243ab643");
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

downloadFile$Action(i_ProposalIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "5b8cfbb9-252c-4ccb-97fe-7de609f5904e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadFile$Action, callContext, i_ProposalIdIn);
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
span.setAttribute("outsystems.function.key", "62faf2b8-baf6-4cee-ad5f-4bbbbac6aa16");
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

datePickerOnPaymentDateFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDateFrom");
span.setAttribute("outsystems.function.key", "7299067a-1695-4e25-8c2d-1bdfe345d8b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnPaymentDateFrom$Action, callContext, selectedDateIn);
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
span.setAttribute("outsystems.function.key", "96b066c7-9324-4c9b-b755-383913115ed9");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "af5ff63a-6e73-407a-8f50-09a775e1287b");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "c2eb6dd2-5544-46c7-9b2d-631034e95c39");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "e70ef34e-e881-4f60-9d87-c96647826014");
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

getProposalOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalOnAfterFetch");
span.setAttribute("outsystems.function.key", "eddcf14d-fc99-40d4-8ca7-b8274aa65d4f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

clearDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "f1332903-b50d-460b-85a9-07bef43b9a21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearDateFrom$Action, callContext);
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
span.setAttribute("outsystems.function.key", "f2a8752e-a274-4efc-97fa-675b72ec64b6");
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
return ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ComissionesArrendamientosViewer]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer$ActionDownloadFileWithProposalId", [{
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.DatePickerOnPaymentDateTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.DownloadFile$vars", [{
name: "i_ProposalId",
attrName: "i_ProposalIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.DatePickerOnPaymentDateFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


