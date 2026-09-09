import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions, BuiltinFunctions as OS$BuiltinFunctions, JSONUtils as OS$JSONUtils, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure } from "./OutSystemsUI.model.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_controller_OnInitialize_Proposals_RegionsJS from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$controller.OnInitialize.Proposals_RegionsJS.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_controller_OnInitialize_Proposals_CurrencyJS from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$controller.OnInitialize.Proposals_CurrencyJS.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_controller_OnInitialize_Proposals_StatusJS from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$controller.OnInitialize.Proposals_StatusJS.js";
import { sidebarClose$Action as OutSystemsUIController$sidebarClose$Action, sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, setVirtualSelectConfigs$Action as OutSystemsUIController$setVirtualSelectConfigs$Action, dropdownClear$Action as OutSystemsUIController$dropdownClear$Action, dropdownClose$Action as OutSystemsUIController$dropdownClose$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { SE_booleanTypes as ConectaProveedores_staticEntities_booleanTypes, SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.controller.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure, ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getBanks$AggrRefresh: 0,
getProposalTypes$AggrRefresh: 0,
getCurrencies$AggrRefresh: 0,
getRegions$AggrRefresh: 0,
getOperators$AggrRefresh: 0,
getUploadType$DataActRefresh: 0,
getProposalStatus$DataActRefresh: 0,
getProposal$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getBanks$AggrRefresh: [],
getProposalTypes$AggrRefresh: [],
getCurrencies$AggrRefresh: [],
getRegions$AggrRefresh: [],
getOperators$AggrRefresh: [],
getUploadType$DataActRefresh: [],
getProposalStatus$DataActRefresh: [],
getProposal$DataActRefresh: []
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionGetSettings"))();
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
auditReportExport$ServerAction(i_AmountMLFrom_FilterIn, i_AmountMLTo_FilterIn, i_Bank_FilterIn, i_PaymentDate_FilterFromIn, i_PaymentDate_FilterToIn, i_Region_FilterIn, i_Status_FilterIn, i_ProposalTypeIdIn, i_Currency_FilterIn, i_Search_FilterIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AuditReportExport", function (span) {
if(span) {
span.setAttribute("code.function", "AuditReportExport");
span.setAttribute("outsystems.function.key", "17387ea4-03ef-43c8-b865-f80d6b42bc81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_AmountMLFrom_Filter: OS$DataConversion.ServerDataConverter.to(i_AmountMLFrom_FilterIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_AmountMLTo_Filter: OS$DataConversion.ServerDataConverter.to(i_AmountMLTo_FilterIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_Bank_Filter: OS$DataConversion.ServerDataConverter.to(i_Bank_FilterIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_PaymentDate_FilterFrom: OS$DataConversion.ServerDataConverter.to(i_PaymentDate_FilterFromIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_PaymentDate_FilterTo: OS$DataConversion.ServerDataConverter.to(i_PaymentDate_FilterToIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_Region_Filter: OS$DataConversion.ServerDataConverter.to(i_Region_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Status_Filter: OS$DataConversion.ServerDataConverter.to(i_Status_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_ProposalTypeId: OS$DataConversion.ServerDataConverter.to(i_ProposalTypeIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_Currency_Filter: OS$DataConversion.ServerDataConverter.to(i_Currency_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Search_Filter: OS$DataConversion.ServerDataConverter.to(i_Search_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AuditReportExport", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionAuditReportExport", "bGSFH59nqO7cd8_SHx4MGA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionAuditReportExport"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, ST_a158c76eb93396680623c04244f48b6cStructure);
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
filteredProposalsExport$ServerAction(i_AmountMLFrom_FilterIn, i_AmountMLTo_FilterIn, i_Bank_FilterIn, i_PaymentDate_FilterFromIn, i_PaymentDate_FilterToIn, i_Region_FilterIn, i_Status_FilterIn, i_Currency_FilterIn, i_TableSortIn, i_Search_FilterIn, i_UploadTypeIn, i_ProposalTypeIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FilteredProposalsExport", function (span) {
if(span) {
span.setAttribute("code.function", "FilteredProposalsExport");
span.setAttribute("outsystems.function.key", "71963288-4c2b-4847-b111-cf8921d76a40");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_AmountMLFrom_Filter: OS$DataConversion.ServerDataConverter.to(i_AmountMLFrom_FilterIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_AmountMLTo_Filter: OS$DataConversion.ServerDataConverter.to(i_AmountMLTo_FilterIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_Bank_Filter: OS$DataConversion.ServerDataConverter.to(i_Bank_FilterIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_PaymentDate_FilterFrom: OS$DataConversion.ServerDataConverter.to(i_PaymentDate_FilterFromIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_PaymentDate_FilterTo: OS$DataConversion.ServerDataConverter.to(i_PaymentDate_FilterToIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_Region_Filter: OS$DataConversion.ServerDataConverter.to(i_Region_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Status_Filter: OS$DataConversion.ServerDataConverter.to(i_Status_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Currency_Filter: OS$DataConversion.ServerDataConverter.to(i_Currency_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_TableSort: OS$DataConversion.ServerDataConverter.to(i_TableSortIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Search_Filter: OS$DataConversion.ServerDataConverter.to(i_Search_FilterIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_UploadType: OS$DataConversion.ServerDataConverter.to(i_UploadTypeIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_ProposalTypeId: OS$DataConversion.ServerDataConverter.to(i_ProposalTypeIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FilteredProposalsExport", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionFilteredProposalsExport", "FyNrgDc3rchUyWkxMKjiww", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionFilteredProposalsExport"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, ST_a158c76eb93396680623c04244f48b6cStructure);
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
return controller.callServerAction("DownloadFileWithProposalId", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionDownloadFileWithProposalId", "orzRncjq6at+5OYp6Ib1PA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionDownloadFileWithProposalId"))();
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
previousMonthProposalsExport$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PreviousMonthProposalsExport", function (span) {
if(span) {
span.setAttribute("code.function", "PreviousMonthProposalsExport");
span.setAttribute("outsystems.function.key", "934fab42-6008-4256-9274-4d6153cf20b6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("PreviousMonthProposalsExport", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionPreviousMonthProposalsExport", "gaX1zmt4EGuXW99J5O9ZbA", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionPreviousMonthProposalsExport"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, ST_a158c76eb93396680623c04244f48b6cStructure);
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getBanks$AggrRefresh() {if(!(this.hasOwnProperty("_getBanks$AggrRefresh"))) {
this._getBanks$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBanks", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ScreenDataSetGetBanks", "7ybLE4e_O0XTjUbXrZeJEA", maxRecords, startIndex, function (b) {
model.variables.getBanksAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBanksAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBanksAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBanks", function (span) {
if(span) {
span.setAttribute("code.function", "GetBanks");
span.setAttribute("outsystems.function.key", "2f0cc8ff-f1f9-4b44-a91c-725d170ae928");
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProposalTypes", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ScreenDataSetGetProposalTypes", "qrypbYK+KS+7H1Kl+dChmQ", maxRecords, startIndex, function (b) {
model.variables.getProposalTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalTypes");
span.setAttribute("outsystems.function.key", "5aa73d2c-8dea-4fe3-845c-9157178d3e5c");
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

get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "6c3691d7-26ad-4465-a701-931e2fdb388f");
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

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ScreenDataSetGetRegions", "pi9+eTY0K7kS8ozgoS2YpA", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "9c327b54-9826-465a-9688-cd4644c523c3");
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

get getOperators$AggrRefresh() {if(!(this.hasOwnProperty("_getOperators$AggrRefresh"))) {
this._getOperators$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOperators", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/ScreenDataSetGetOperators", "FLVfBwjABjz9rC3dLNwU+w", maxRecords, startIndex, function (b) {
model.variables.getOperatorsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOperatorsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOperatorsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOperators", function (span) {
if(span) {
span.setAttribute("code.function", "GetOperators");
span.setAttribute("outsystems.function.key", "ada9d60a-af6f-4bd2-b994-c1c588c575b6");
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

get getUploadType$DataActRefresh() {if(!(this.hasOwnProperty("_getUploadType$DataActRefresh"))) {
this._getUploadType$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUploadType", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/DataActionGetUploadType", "kRch7b3NNnE8jBcf8fUWTQ", function (b) {
model.variables.getUploadTypeDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUploadTypeDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUploadTypeDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUploadType", function (span) {
if(span) {
span.setAttribute("code.function", "GetUploadType");
span.setAttribute("outsystems.function.key", "57bb37c3-3337-4615-9d65-1682dda5beb3");
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

get getProposalStatus$DataActRefresh() {if(!(this.hasOwnProperty("_getProposalStatus$DataActRefresh"))) {
this._getProposalStatus$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetProposalStatus", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/DataActionGetProposalStatus", "zD3saJtB3UrI0p3BKsO8Tw", function (b) {
model.variables.getProposalStatusDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalStatusDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalStatusDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalStatusOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposalStatus", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalStatus");
span.setAttribute("outsystems.function.key", "818030a9-aeee-4107-9971-62e1dd2222ce");
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

return this._getProposalStatus$DataActRefresh;
}set getProposalStatus$DataActRefresh(value) {this._getProposalStatus$DataActRefresh = value;
}

get getProposal$DataActRefresh() {if(!(this.hasOwnProperty("_getProposal$DataActRefresh"))) {
this._getProposal$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetProposal", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalsList/DataActionGetProposal", "b9OxJSqI+AY50bYLD_q9uA", function (b) {
model.variables.getProposalDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProposalDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProposalDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getProposalOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetProposal", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposal");
span.setAttribute("outsystems.function.key", "b7b7c131-6d62-42f1-a2a7-e74694c247c5");
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

return this._getProposal$DataActRefresh;
}set getProposal$DataActRefresh(value) {this._getProposal$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getBanks$AggrRefresh", "getProposalTypes$AggrRefresh", "getCurrencies$AggrRefresh", "getRegions$AggrRefresh", "getOperators$AggrRefresh", "getUploadType$DataActRefresh", "getProposalStatus$DataActRefresh", "getProposal$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "012fc851-8a05-490f-9f1b-aa288dd5be23");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnSort$vars"))());
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
// Refresh Query: GetProposal
var result = controller.getProposal$DataActRefresh(callContext);
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
_getProposalStatusOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalStatusOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalStatusOnAfterFetch");
span.setAttribute("outsystems.function.key", "0905b248-8c5e-4d8a-b250-cf89ce18a3d7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetProposalStatusOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
if((model.variables.l_SelectedStatusVar.isEmpty)) {
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.l_SelectedStatusVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getProposalStatusDataAct.preSelectedOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = (source.idAttr).toString();
target.labelAttr = source.labelAttr;
return target;
}), callContext);
// Foreach l_SelectedStatus
callContext.iterationContext.registerIterationStart(model.variables.l_SelectedStatusVar);
try {var l_SelectedStatusIterator = callContext.iterationContext.getIterator(model.variables.l_SelectedStatusVar);
var l_SelectedStatusIndex = 0;
while (((l_SelectedStatusIndex < model.variables.l_SelectedStatusVar.length))) {
l_SelectedStatusIterator.currentRowNumber = l_SelectedStatusIndex;
// Proposals_Statuses = Proposals_Statuses + If
ConectaProveedoresClientVariables.setProposals_Statuses((ConectaProveedoresClientVariables.getProposals_Statuses() + (((ConectaProveedoresClientVariables.getProposals_Statuses() === "")) ? (model.variables.l_SelectedStatusVar.getItem(l_SelectedStatusIndex.valueOf()).valueAttr) : (("," + model.variables.l_SelectedStatusVar.getItem(l_SelectedStatusIndex.valueOf()).valueAttr)))));
l_SelectedStatusIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.l_SelectedStatusVar);
}

}

// Refresh Query: GetProposal
var result = controller.getProposal$DataActRefresh(callContext);
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
_getProposalOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetProposalOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalOnAfterFetch");
span.setAttribute("outsystems.function.key", "0ae9af18-6a1a-4765-a119-86098721762f");
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
if(((!(model.variables.getProposalDataAct.listOut.isEmpty)))) {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getProposalDataAct.listOut, function (p) {
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "11e7281c-808f-4644-884d-e470f41f6e94");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var proposals_CurrencyJSResult = new OS$DataTypes.VariableHolder();
var proposals_StatusJSResult = new OS$DataTypes.VariableHolder();
var proposals_RegionsJSResult = new OS$DataTypes.VariableHolder();
var jSONDeserializeOptionStructSatusVar = new OS$DataTypes.VariableHolder(new (OS$Controller.BaseController.getJSONDeserializeOutputType((OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))))());
var jSONDeserializeOptionStructRegionsVar = new OS$DataTypes.VariableHolder(new (OS$Controller.BaseController.getJSONDeserializeOutputType((OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))))());
var jSONDeserializeOptionStructCurrencyVar = new OS$DataTypes.VariableHolder(new (OS$Controller.BaseController.getJSONDeserializeOutputType((OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))))());
// l_AmountFromText = Proposals_AmountMLFrom
model.variables.l_AmountFromTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getProposals_AmountMLFrom());
// l_AmountToText = Proposals_AmountMLTo
model.variables.l_AmountToTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getProposals_AmountMLTo());
// l_ShowFilters = Proposals_Operator_AmountML <> NullTextIdentifier or Proposals_AmountMLFrom <> 0 or Proposals_AmountMLTo <> 0 or Proposals_Currency <> NullTextIdentifier or Proposals_UploadType <> NullIdentifier
model.variables.l_ShowFiltersVar = ((((((ConectaProveedoresClientVariables.getProposals_Operator_AmountML()) !== (OS$BuiltinFunctions.nullTextIdentifier())) || !(ConectaProveedoresClientVariables.getProposals_AmountMLFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getProposals_AmountMLTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || ((ConectaProveedoresClientVariables.getProposals_Currency()) !== (OS$BuiltinFunctions.nullTextIdentifier()))) || ((ConectaProveedoresClientVariables.getProposals_UploadType()) !== (OS$BuiltinFunctions.nullIdentifier())));
proposals_RegionsJSResult.value = OS$Logger.startActiveSpan("Proposals_Regions", function (span) {
if(span) {
span.setAttribute("code.function", "Proposals_Regions");
span.setAttribute("outsystems.function.key", "d22b7dc2-00f2-49f4-b6ef-6825f912365a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_controller_OnInitialize_Proposals_RegionsJS, "Proposals_Regions", "OnInitialize", {
InputText: OS$DataConversion.JSNodeParamConverter.to(ConectaProveedoresClientVariables.getProposals_Regions(), OS$DataTypes.DataTypes.Text),
OutputJson: OS$DataConversion.JSNodeParamConverter.to("", OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnInitialize$proposals_RegionsJSResult"))();
jsNodeResult.outputJsonOut = OS$DataConversion.JSNodeParamConverter.from($parameters.OutputJson, OS$DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// JSON Deserialize: JSONDeserializeOptionStructRegions
jSONDeserializeOptionStructRegionsVar.value.dataOut = OS$JSONUtils.deserializeFromJSON(proposals_RegionsJSResult.value.outputJsonOut, (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)), false);
// l_SelectedRegions = JSONDeserializeOptionStructRegions.Data
model.variables.l_SelectedRegionsVar = jSONDeserializeOptionStructRegionsVar.value.dataOut;
proposals_CurrencyJSResult.value = OS$Logger.startActiveSpan("Proposals_Currency", function (span) {
if(span) {
span.setAttribute("code.function", "Proposals_Currency");
span.setAttribute("outsystems.function.key", "832313fc-7b44-45a7-9448-256620613d85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_controller_OnInitialize_Proposals_CurrencyJS, "Proposals_Currency", "OnInitialize", {
InputText: OS$DataConversion.JSNodeParamConverter.to(ConectaProveedoresClientVariables.getProposals_Currencies(), OS$DataTypes.DataTypes.Text),
OutputJson: OS$DataConversion.JSNodeParamConverter.to("", OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnInitialize$proposals_CurrencyJSResult"))();
jsNodeResult.outputJsonOut = OS$DataConversion.JSNodeParamConverter.from($parameters.OutputJson, OS$DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// JSON Deserialize: JSONDeserializeOptionStructCurrency
jSONDeserializeOptionStructCurrencyVar.value.dataOut = OS$JSONUtils.deserializeFromJSON(proposals_CurrencyJSResult.value.outputJsonOut, (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)), false);
// l_SelectedCurrency = JSONDeserializeOptionStructCurrency.Data
model.variables.l_SelectedCurrencyVar = jSONDeserializeOptionStructCurrencyVar.value.dataOut;
proposals_StatusJSResult.value = OS$Logger.startActiveSpan("Proposals_Status", function (span) {
if(span) {
span.setAttribute("code.function", "Proposals_Status");
span.setAttribute("outsystems.function.key", "8f44d633-41bf-47c6-a9f6-4557cb51506d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_mvc_controller_OnInitialize_Proposals_StatusJS, "Proposals_Status", "OnInitialize", {
InputText: OS$DataConversion.JSNodeParamConverter.to(ConectaProveedoresClientVariables.getProposals_Statuses(), OS$DataTypes.DataTypes.Text),
OutputJson: OS$DataConversion.JSNodeParamConverter.to("", OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnInitialize$proposals_StatusJSResult"))();
jsNodeResult.outputJsonOut = OS$DataConversion.JSNodeParamConverter.from($parameters.OutputJson, OS$DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// JSON Deserialize: JSONDeserializeOptionStructSatus
jSONDeserializeOptionStructSatusVar.value.dataOut = OS$JSONUtils.deserializeFromJSON(proposals_StatusJSResult.value.outputJsonOut, (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)), false);
// l_SelectedStatus = JSONDeserializeOptionStructSatus.Data
model.variables.l_SelectedStatusVar = jSONDeserializeOptionStructSatusVar.value.dataOut;
// set PaymentDateFrom
if((ConectaProveedoresClientVariables.getProposals_PaymentDateFrom().equals(OS$BuiltinFunctions.nullDate()))) {
// Proposals_PaymentDateFrom = NewDate
ConectaProveedoresClientVariables.setProposals_PaymentDateFrom(OS$BuiltinFunctions.newDate(OS$BuiltinFunctions.year(OS$BuiltinFunctions.currDate()), OS$BuiltinFunctions.month(OS$BuiltinFunctions.currDate()), 1));
}

// set PaymentDateto
if((ConectaProveedoresClientVariables.getProposals_PaymentDateTo().equals(OS$BuiltinFunctions.nullDate()))) {
// Proposals_PaymentDateTo = AddDays
ConectaProveedoresClientVariables.setProposals_PaymentDateTo(OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.addMonths(OS$BuiltinFunctions.newDate(OS$BuiltinFunctions.year(OS$BuiltinFunctions.currDate()), OS$BuiltinFunctions.month(OS$BuiltinFunctions.currDate()), 1), 1), (-1))));
}

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
span.setAttribute("outsystems.function.key", "2578c66b-aece-4ead-8f71-42569ef0a0cb");
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
_downloadAuditProposalLines$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadAuditProposalLines", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAuditProposalLines");
span.setAttribute("outsystems.function.key", "4dad5170-b5e8-4050-9160-d89cb46d44b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadAuditProposalLines");
callContext = controller.callContext(callContext);
var auditReportExportVar = new OS$DataTypes.VariableHolder();
var checkComissionesArrendamientosAdminRoleVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckComissionesArrendamientosAdminRole
checkComissionesArrendamientosAdminRoleVar.value = ConectaProveedoresController$default.checkComissionesArrendamientosAdminRole$Action(callContext);

// has role?
return OS$Flow.executeSequence(function () {
if((checkComissionesArrendamientosAdminRoleVar.value.hasRoleOut)) {
// IsBusy = True
model.variables.isBusyVar = true;
// Execute Action: AuditReportExport
model.flush();
return controller.auditReportExport$ServerAction(ConectaProveedoresClientVariables.getProposals_AmountMLFrom(), ConectaProveedoresClientVariables.getProposals_AmountMLTo(), ConectaProveedoresClientVariables.getProposals_Bank(), ConectaProveedoresClientVariables.getProposals_PaymentDateFrom(), ConectaProveedoresClientVariables.getProposals_PaymentDateTo(), (("(" + ConectaProveedoresClientVariables.getProposals_Regions()) + ")"), (("(" + ConectaProveedoresClientVariables.getProposals_Statuses()) + ")"), ConectaProveedoresClientVariables.getProposals_Type(), (("(" + ConectaProveedoresClientVariables.getProposals_Currencies()) + ")"), ConectaProveedoresClientVariables.getProposals_ProposalSearch(), callContext).then(function (value) {
auditReportExportVar.value = value;
}).then(function () {
// IsBusy = False
model.variables.isBusyVar = false;
}).then(function () {
// Success?
if((auditReportExportVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(auditReportExportVar.value.o_OutputOut.messageAttr, /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(auditReportExportVar.value.o_FileOut.binaryDataAttr, auditReportExportVar.value.o_FileOut.nameAttr));
} else {
OS$FeedbackMessageService.showFeedbackMessage(auditReportExportVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NIdWEflDM0iG_de10PJ4JA#Message.-1409656127.1", "No permission. Contact administrator."), /*Error*/ 3);
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
span.setAttribute("outsystems.function.key", "5aa103cf-0954-4e0b-8212-7a9285a7ab99");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetProposal
var result = controller.getProposal$DataActRefresh(callContext);
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
_downloadProposals$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadProposals", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadProposals");
span.setAttribute("outsystems.function.key", "671ca2aa-e107-429e-a7fa-f51e657605c4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadProposals");
callContext = controller.callContext(callContext);
var filteredProposalsExportVar = new OS$DataTypes.VariableHolder();
var checkComissionesArrendamientosAdminRoleVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckComissionesArrendamientosAdminRole
checkComissionesArrendamientosAdminRoleVar.value = ConectaProveedoresController$default.checkComissionesArrendamientosAdminRole$Action(callContext);

// has role?
return OS$Flow.executeSequence(function () {
if((checkComissionesArrendamientosAdminRoleVar.value.hasRoleOut)) {
// IsBusy = True
model.variables.isBusyVar = true;
// Execute Action: FilteredProposalsExport
model.flush();
return controller.filteredProposalsExport$ServerAction(ConectaProveedoresClientVariables.getProposals_AmountMLFrom(), ConectaProveedoresClientVariables.getProposals_AmountMLTo(), ConectaProveedoresClientVariables.getProposals_Bank(), ConectaProveedoresClientVariables.getProposals_PaymentDateFrom(), ConectaProveedoresClientVariables.getProposals_PaymentDateTo(), ConectaProveedoresClientVariables.getProposals_Regions(), ConectaProveedoresClientVariables.getProposals_Statuses(), ConectaProveedoresClientVariables.getProposals_Currencies(), model.variables.l_TableSortVar, ConectaProveedoresClientVariables.getProposals_ProposalSearch(), ConectaProveedoresClientVariables.getProposals_UploadType(), ConectaProveedoresClientVariables.getProposals_Type(), callContext).then(function (value) {
filteredProposalsExportVar.value = value;
}).then(function () {
// IsBusy = False
model.variables.isBusyVar = false;
}).then(function () {
// Success?
if((filteredProposalsExportVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(filteredProposalsExportVar.value.o_OutputOut.messageAttr, /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(filteredProposalsExportVar.value.o_FileOut.binaryDataAttr, filteredProposalsExportVar.value.o_FileOut.nameAttr));
} else {
OS$FeedbackMessageService.showFeedbackMessage(filteredProposalsExportVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V5ysk73fAUC89X58bT0WMg#Message.-1409656127.1", "No permission. Contact administrator."), /*Error*/ 3);
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
_dropdownSearchOnChangedCurrency$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedCurrency", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedCurrency");
span.setAttribute("outsystems.function.key", "68f1748c-a657-40f5-9cfc-68da2bcc8c4c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchOnChangedCurrency");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchOnChangedCurrency$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Proposals_Currencies = ""
ConectaProveedoresClientVariables.setProposals_Currencies("");
// Foreach SelectedOptionList
callContext.iterationContext.registerIterationStart(vars.value.selectedOptionListInLocal);
try {var selectedOptionListIterator = callContext.iterationContext.getIterator(vars.value.selectedOptionListInLocal);
var selectedOptionListIndex = 0;
while (((selectedOptionListIndex < vars.value.selectedOptionListInLocal.length))) {
selectedOptionListIterator.currentRowNumber = selectedOptionListIndex;
// Proposals_Currencies = Proposals_Currencies + If + SelectedOptionList.Current.Value
ConectaProveedoresClientVariables.setProposals_Currencies(((ConectaProveedoresClientVariables.getProposals_Currencies() + ((((ConectaProveedoresClientVariables.getProposals_Currencies()) !== (""))) ? (",") : (""))) + vars.value.selectedOptionListInLocal.getItem(selectedOptionListIndex.valueOf()).valueAttr));
selectedOptionListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(vars.value.selectedOptionListInLocal);
}

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
_seeLogsOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeLogsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "76dfd24b-f39e-4a17-9cc2-4a776cbedfe5");
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
_clearDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "794f1fcf-fdd7-4696-8850-f98c6cadaa4d");
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
_datePickerOnPaymentDateFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDateFrom");
span.setAttribute("outsystems.function.key", "8694e5b3-3686-429e-baaa-ece0c680d9d4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnPaymentDateFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DatePickerOnPaymentDateFrom$vars"))());
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "8747638d-c959-4c1c-9f40-4a1e2bc81e29");
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
_downloadFile$Action(i_ProposalIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "8a08df4c-7e61-43e2-98ae-c0c0e45c1c39");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DownloadFile$vars"))());
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7ybbWHWC+U2Cx3Am4FdtcQ#Message.525723613.1", "File not found."), /*Error*/ 3);
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
_expandFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExpandFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "9240c85f-0b16-4c65-b24f-6666930aaf5c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.ExpandFilters$vars"))());
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
// Refresh Query: GetProposal
var result = controller.getProposal$DataActRefresh(callContext);
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
_onDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "93381795-0b56-4cfc-bfbd-cc47539a1ca7");
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
_dropdownSearchInitialized$Action(dropdownSearchIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchInitialized", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchInitialized");
span.setAttribute("outsystems.function.key", "97ef1fba-9cfb-4500-a369-ecbd5dc6d375");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchInitialized");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchInitialized$vars"))());
vars.value.dropdownSearchIdInLocal = dropdownSearchIdIn;
var setVirtualSelectConfigsVar = new OS$DataTypes.VariableHolder();
// Execute Action: SetVirtualSelectConfigs
setVirtualSelectConfigsVar.value = OutSystemsUIController$setVirtualSelectConfigs$Action(vars.value.dropdownSearchIdInLocal, function () {
var rec = new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure();
rec.allOptionsSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hQutqTh6E06VmWbqEekf+w#Value.65921.1", "All");
rec.optionSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IcbREFoqg0eSxN6sIZU7Qg#Value.1488125414.1", "option selected");
rec.optionsSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yreE69hD0UmmDhIetWODMw#Value.660069853.1", "options selected");
rec.searchAttr = ConectaProveedores_staticEntities_booleanTypes.false;
rec.selectAllTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gYyqYmGPFk2Cl9q02jX5Rg#Value.335921277.1", "Select All");
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
_clearDrops$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearDrops", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDrops");
span.setAttribute("outsystems.function.key", "a455e699-266c-40fa-bc0f-751c46f3e669");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearDrops");
callContext = controller.callContext(callContext);
var dropdownClear2Var = new OS$DataTypes.VariableHolder();
var sidebarClose2Var = new OS$DataTypes.VariableHolder();
var dropdownClear3Var = new OS$DataTypes.VariableHolder();
var dropdownClearVar = new OS$DataTypes.VariableHolder();
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
var sidebarClose3Var = new OS$DataTypes.VariableHolder();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_SelectedStatusVar, callContext);
// Execute Action: ListClear3
OS$SystemActions.listClear(model.variables.l_SelectedCurrencyVar, callContext);
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.l_SelectedRegionsVar, callContext);
// Execute Action: DropdownClear2
dropdownClear2Var.value = OutSystemsUIController$dropdownClear$Action(idService.getId("dropstatus"), true, callContext);

// Execute Action: DropdownClear
dropdownClearVar.value = OutSystemsUIController$dropdownClear$Action(idService.getId("dropcurrency"), true, callContext);

// Execute Action: DropdownClear3
dropdownClear3Var.value = OutSystemsUIController$dropdownClear$Action(idService.getId("dropregions"), true, callContext);

// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$dropdownClose$Action(idService.getId("dropstatus"), callContext);

// Execute Action: SidebarClose2
sidebarClose2Var.value = OutSystemsUIController$dropdownClose$Action(idService.getId("dropcurrency"), callContext);

// Execute Action: SidebarClose3
sidebarClose3Var.value = OutSystemsUIController$dropdownClose$Action(idService.getId("dropregions"), callContext);

} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "b26f31f2-1e0c-4336-943f-6aef63280d9c");
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
_dropdownSearchOnChangedRegions$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedRegions", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedRegions");
span.setAttribute("outsystems.function.key", "ba0eb933-4926-4a52-9905-6369d3a61ee8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchOnChangedRegions");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchOnChangedRegions$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Proposals_Regions = ""
ConectaProveedoresClientVariables.setProposals_Regions("");
// Foreach SelectedOptionList
callContext.iterationContext.registerIterationStart(vars.value.selectedOptionListInLocal);
try {var selectedOptionListIterator = callContext.iterationContext.getIterator(vars.value.selectedOptionListInLocal);
var selectedOptionListIndex = 0;
while (((selectedOptionListIndex < vars.value.selectedOptionListInLocal.length))) {
selectedOptionListIterator.currentRowNumber = selectedOptionListIndex;
// Proposals_Regions = Proposals_Regions + If + SelectedOptionList.Current.Value
ConectaProveedoresClientVariables.setProposals_Regions(((ConectaProveedoresClientVariables.getProposals_Regions() + ((((ConectaProveedoresClientVariables.getProposals_Regions()) !== (""))) ? (",") : (""))) + vars.value.selectedOptionListInLocal.getItem(selectedOptionListIndex.valueOf()).valueAttr));
selectedOptionListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(vars.value.selectedOptionListInLocal);
}

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
span.setAttribute("outsystems.function.key", "ba680db1-cf30-4230-97c5-a99be8093f61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnPaymentDateTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DatePickerOnPaymentDateTo$vars"))());
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "c14daf81-70c4-4362-bcfc-386bd0f32a12");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerClear2Var = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Clear Filters
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
// Proposals_Regions = ""
ConectaProveedoresClientVariables.setProposals_Regions("");
// Proposals_Statuses = ""
ConectaProveedoresClientVariables.setProposals_Statuses("");
// Proposals_Type = NullIdentifier
ConectaProveedoresClientVariables.setProposals_Type(OS$BuiltinFunctions.nullIdentifier());
// Proposals_Currencies = ""
ConectaProveedoresClientVariables.setProposals_Currencies("");
// Execute Action: ClearDrops
controller._clearDrops$Action(callContext);
// Show filters
// l_ShowFilters = False
model.variables.l_ShowFiltersVar = false;
// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("Datepicker"), callContext);

// Execute Action: DatePickerClear2
datePickerClear2Var.value = OutSystemsUIController$datePickerClear$Action(idService.getId("Datepicker2"), callContext);

}

// Refresh Query: GetProposal
var result = controller.getProposal$DataActRefresh(callContext);
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
_dropdownSearchOnChangedStatus$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedStatus", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedStatus");
span.setAttribute("outsystems.function.key", "c6909b4b-c917-4cc0-b232-5fcc62b094e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchOnChangedStatus");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchOnChangedStatus$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Proposals_Statuses = ""
ConectaProveedoresClientVariables.setProposals_Statuses("");
// Foreach SelectedOptionList
callContext.iterationContext.registerIterationStart(vars.value.selectedOptionListInLocal);
try {var selectedOptionListIterator = callContext.iterationContext.getIterator(vars.value.selectedOptionListInLocal);
var selectedOptionListIndex = 0;
while (((selectedOptionListIndex < vars.value.selectedOptionListInLocal.length))) {
selectedOptionListIterator.currentRowNumber = selectedOptionListIndex;
// Proposals_Statuses = Proposals_Statuses + If + SelectedOptionList.Current.Value
ConectaProveedoresClientVariables.setProposals_Statuses(((ConectaProveedoresClientVariables.getProposals_Statuses() + ((((ConectaProveedoresClientVariables.getProposals_Statuses()) !== (""))) ? (",") : (""))) + vars.value.selectedOptionListInLocal.getItem(selectedOptionListIndex.valueOf()).valueAttr));
selectedOptionListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(vars.value.selectedOptionListInLocal);
}

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
_downloadPreviousMonthProposals$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadPreviousMonthProposals", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadPreviousMonthProposals");
span.setAttribute("outsystems.function.key", "cb3db2c1-27fb-4356-acaf-dfc325b81a0a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadPreviousMonthProposals");
callContext = controller.callContext(callContext);
var previousMonthProposalsExportVar = new OS$DataTypes.VariableHolder();
var checkComissionesArrendamientosAdminRoleVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckComissionesArrendamientosAdminRole
checkComissionesArrendamientosAdminRoleVar.value = ConectaProveedoresController$default.checkComissionesArrendamientosAdminRole$Action(callContext);

// has role?
return OS$Flow.executeSequence(function () {
if((checkComissionesArrendamientosAdminRoleVar.value.hasRoleOut)) {
// IsBusy = True
model.variables.isBusyVar = true;
// Execute Action: PreviousMonthProposalsExport
model.flush();
return controller.previousMonthProposalsExport$ServerAction(callContext).then(function (value) {
previousMonthProposalsExportVar.value = value;
}).then(function () {
// IsBusy = False
model.variables.isBusyVar = false;
}).then(function () {
// Success?
if((previousMonthProposalsExportVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(previousMonthProposalsExportVar.value.o_OutputOut.messageAttr, /*Success*/ 1);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(previousMonthProposalsExportVar.value.o_FileOut.binaryDataAttr, previousMonthProposalsExportVar.value.o_FileOut.nameAttr));
} else {
OS$FeedbackMessageService.showFeedbackMessage(previousMonthProposalsExportVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("llzc2qj96EeURN+BHjfAyA#Message.-1409656127.1", "No permission. Contact administrator."), /*Error*/ 3);
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
span.setAttribute("outsystems.function.key", "e0ed96aa-7273-458e-acf7-0618a48890cb");
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
rec.screenAttr = "CyA - Proposals List";
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
_dropdownSearchInitialized2$Action(dropdownSearchIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchInitialized2", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchInitialized2");
span.setAttribute("outsystems.function.key", "e7ac8b94-7709-4edb-99e5-504b68aaac05");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchInitialized2");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchInitialized2$vars"))());
vars.value.dropdownSearchIdInLocal = dropdownSearchIdIn;
var setVirtualSelectConfigsVar = new OS$DataTypes.VariableHolder();
// Execute Action: SetVirtualSelectConfigs
setVirtualSelectConfigsVar.value = OutSystemsUIController$setVirtualSelectConfigs$Action(vars.value.dropdownSearchIdInLocal, function () {
var rec = new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure();
rec.allOptionsSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_OAm33QezUaMYvSBxOnGAg#Value.65921.1", "All");
rec.optionSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("X24IB57eQkKYNv+b3x0xFA#Value.1488125414.1", "option selected");
rec.optionsSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("25ymV9l630+kVa21pJUcXQ#Value.660069853.1", "options selected");
rec.searchAttr = ConectaProveedores_staticEntities_booleanTypes.false;
rec.selectAllTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Br6GAiSif0iADH0fLyO0qA#Value.335921277.1", "Select All");
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
_dropdownSearchInitialized3$Action(dropdownSearchIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchInitialized3", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchInitialized3");
span.setAttribute("outsystems.function.key", "f1273666-4516-42a0-bf10-10fe0097718c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchInitialized3");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchInitialized3$vars"))());
vars.value.dropdownSearchIdInLocal = dropdownSearchIdIn;
var setVirtualSelectConfigsVar = new OS$DataTypes.VariableHolder();
// Execute Action: SetVirtualSelectConfigs
setVirtualSelectConfigsVar.value = OutSystemsUIController$setVirtualSelectConfigs$Action(vars.value.dropdownSearchIdInLocal, function () {
var rec = new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure();
rec.allOptionsSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EHk2GLkfbUyt0LA6k+aRag#Value.65921.1", "All");
rec.optionSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eUGFx4EJE02KAW2Pt8Ccwg#Value.1488125414.1", "option selected");
rec.optionsSelectedTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("aFsDSCEBJkq3oHd0tMbw7w#Value.660069853.1", "options selected");
rec.searchAttr = ConectaProveedores_staticEntities_booleanTypes.false;
rec.selectAllTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("U4EkZ2vkHkOeinOuz_E2NQ#Value.335921277.1", "Select All");
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "f42de840-ea71-4678-9815-2423765fb7ff");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.ColumnTogglerPassColumn$vars"))());
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "012fc851-8a05-490f-9f1b-aa288dd5be23");
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

getProposalStatusOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetProposalStatusOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetProposalStatusOnAfterFetch");
span.setAttribute("outsystems.function.key", "0905b248-8c5e-4d8a-b250-cf89ce18a3d7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getProposalStatusOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "0ae9af18-6a1a-4765-a119-86098721762f");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "11e7281c-808f-4644-884d-e470f41f6e94");
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

closeSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "2578c66b-aece-4ead-8f71-42569ef0a0cb");
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

downloadAuditProposalLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadAuditProposalLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAuditProposalLines");
span.setAttribute("outsystems.function.key", "4dad5170-b5e8-4050-9160-d89cb46d44b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadAuditProposalLines$Action, callContext);
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
span.setAttribute("outsystems.function.key", "5aa103cf-0954-4e0b-8212-7a9285a7ab99");
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

downloadProposals$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadProposals__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadProposals");
span.setAttribute("outsystems.function.key", "671ca2aa-e107-429e-a7fa-f51e657605c4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadProposals$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdownSearchOnChangedCurrency$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedCurrency__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedCurrency");
span.setAttribute("outsystems.function.key", "68f1748c-a657-40f5-9cfc-68da2bcc8c4c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchOnChangedCurrency$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "76dfd24b-f39e-4a17-9cc2-4a776cbedfe5");
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

clearDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateTo");
span.setAttribute("outsystems.function.key", "794f1fcf-fdd7-4696-8850-f98c6cadaa4d");
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

datePickerOnPaymentDateFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnPaymentDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnPaymentDateFrom");
span.setAttribute("outsystems.function.key", "8694e5b3-3686-429e-baaa-ece0c680d9d4");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "8747638d-c959-4c1c-9f40-4a1e2bc81e29");
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

downloadFile$Action(i_ProposalIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadFile");
span.setAttribute("outsystems.function.key", "8a08df4c-7e61-43e2-98ae-c0c0e45c1c39");
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

expandFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExpandFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "9240c85f-0b16-4c65-b24f-6666930aaf5c");
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

onDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "93381795-0b56-4cfc-bfbd-cc47539a1ca7");
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

dropdownSearchInitialized$Action(dropdownSearchIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchInitialized__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchInitialized");
span.setAttribute("outsystems.function.key", "97ef1fba-9cfb-4500-a369-ecbd5dc6d375");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchInitialized$Action, callContext, dropdownSearchIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearDrops$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDrops__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDrops");
span.setAttribute("outsystems.function.key", "a455e699-266c-40fa-bc0f-751c46f3e669");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._clearDrops$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearDateFrom");
span.setAttribute("outsystems.function.key", "b26f31f2-1e0c-4336-943f-6aef63280d9c");
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

dropdownSearchOnChangedRegions$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedRegions__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedRegions");
span.setAttribute("outsystems.function.key", "ba0eb933-4926-4a52-9905-6369d3a61ee8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchOnChangedRegions$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "ba680db1-cf30-4230-97c5-a99be8093f61");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "c14daf81-70c4-4362-bcfc-386bd0f32a12");
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

dropdownSearchOnChangedStatus$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedStatus__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedStatus");
span.setAttribute("outsystems.function.key", "c6909b4b-c917-4cc0-b232-5fcc62b094e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchOnChangedStatus$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

downloadPreviousMonthProposals$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadPreviousMonthProposals__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadPreviousMonthProposals");
span.setAttribute("outsystems.function.key", "cb3db2c1-27fb-4356-acaf-dfc325b81a0a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadPreviousMonthProposals$Action, callContext);
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
span.setAttribute("outsystems.function.key", "e0ed96aa-7273-458e-acf7-0618a48890cb");
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

dropdownSearchInitialized2$Action(dropdownSearchIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchInitialized2__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchInitialized2");
span.setAttribute("outsystems.function.key", "e7ac8b94-7709-4edb-99e5-504b68aaac05");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchInitialized2$Action, callContext, dropdownSearchIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdownSearchInitialized3$Action(dropdownSearchIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchInitialized3__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchInitialized3");
span.setAttribute("outsystems.function.key", "f1273666-4516-42a0-bf10-10fe0097718c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchInitialized3$Action, callContext, dropdownSearchIdIn);
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
span.setAttribute("outsystems.function.key", "f42de840-ea71-4678-9815-2423765fb7ff");
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
roles: [ConectaProveedoresController$default.roles.ComissionesArrendamientosAdmin]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionAuditReportExport", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionFilteredProposalsExport", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionDownloadFileWithProposalId", [{
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList$ActionPreviousMonthProposalsExport", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnInitialize$proposals_CurrencyJSResult", [{
name: "OutputJson",
attrName: "outputJsonOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnInitialize$proposals_StatusJSResult", [{
name: "OutputJson",
attrName: "outputJsonOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.OnInitialize$proposals_RegionsJSResult", [{
name: "OutputJson",
attrName: "outputJsonOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchOnChangedCurrency$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DatePickerOnPaymentDateFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DownloadFile$vars", [{
name: "i_ProposalId",
attrName: "i_ProposalIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchInitialized$vars", [{
name: "DropdownSearchId",
attrName: "dropdownSearchIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchOnChangedRegions$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DatePickerOnPaymentDateTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchOnChangedStatus$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchInitialized2$vars", [{
name: "DropdownSearchId",
attrName: "dropdownSearchIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.DropdownSearchInitialized3$vars", [{
name: "DropdownSearchId",
attrName: "dropdownSearchIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


