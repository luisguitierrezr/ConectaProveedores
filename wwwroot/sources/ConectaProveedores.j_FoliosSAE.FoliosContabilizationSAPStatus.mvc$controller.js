import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Authorization as OS$Authorization, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action, datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action, notificationClose$Action as OutSystemsUIController$notificationClose$Action, notificationOpen$Action as OutSystemsUIController$notificationOpen$Action } from "./OutSystemsUI.controller.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus, SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure, RC_4d06af040e4a89ed9c35b745b328b97d } from "./ConectaProveedores.model.js";
import { TextRec } from "./Extension.Text.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSpecialApprovals$AggrRefresh: 0,
getCurrencies$AggrRefresh: 0,
getInvoicesSAP$AggrRefresh: 0,
getFrequencies$AggrRefresh: 0,
getInvoiceStatus$AggrRefresh: 0,
getAccountingDataTypes$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getSpecialApprovals$AggrRefresh: [],
getCurrencies$AggrRefresh: [],
getInvoicesSAP$AggrRefresh: [],
getFrequencies$AggrRefresh: [],
getInvoiceStatus$AggrRefresh: [],
getAccountingDataTypes$AggrRefresh: []
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus$ActionGetSettings"))();
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
invoiceAccountingProcess_Create$ServerAction(invoiceIdIn, commentIn, isFCPIn, requisitionIdIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceAccountingProcess_Create", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceAccountingProcess_Create");
span.setAttribute("outsystems.function.key", "e40b2c67-8df6-4197-a514-5ac09e368352");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
Comment: OS$DataConversion.ServerDataConverter.to(commentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IsFCP: OS$DataConversion.ServerDataConverter.to(isFCPIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
RequisitionId: OS$DataConversion.ServerDataConverter.to(requisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("InvoiceAccountingProcess_Create", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ActionInvoiceAccountingProcess_Create", "7ta6duQcTOb1HdUse50VXA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
generateReportSAPStatus$ServerAction(i_OffsetUtcIn, i_SupplierIdIn, i_InvoiceNameIn, i_FolioNumberIn, i_InvoiceStatusIdIn, i_OrderMainNumberIn, i_AssignedToIn, i_ProjectIn, i_PeriodIn, i_FrequencyIdIn, i_BusinessValueCategoryIn, i_BusinessValueSubCategIn, i_PaidOnIn, i_AmountFromIn, i_AmountToIn, i_CurrencyIdIn, i_InvoiceCreatedOnIn, i_FolioCreatedOnIn, i_SpecialApprovalIdIn, i_CFDITypeIdIn, i_IsSelectAllIn, i_SelectedIdsIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateReportSAPStatus", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReportSAPStatus");
span.setAttribute("outsystems.function.key", "6b29dd22-03dc-4883-a364-0fcabd8a74e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OffsetUtc: OS$DataConversion.ServerDataConverter.to(i_OffsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_SupplierId: OS$DataConversion.ServerDataConverter.to(i_SupplierIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_InvoiceName: OS$DataConversion.ServerDataConverter.to(i_InvoiceNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_FolioNumber: OS$DataConversion.ServerDataConverter.to(i_FolioNumberIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_InvoiceStatusId: OS$DataConversion.ServerDataConverter.to(i_InvoiceStatusIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_OrderMainNumber: OS$DataConversion.ServerDataConverter.to(i_OrderMainNumberIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_AssignedTo: OS$DataConversion.ServerDataConverter.to(i_AssignedToIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Project: OS$DataConversion.ServerDataConverter.to(i_ProjectIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Period: OS$DataConversion.ServerDataConverter.to(i_PeriodIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_FrequencyId: OS$DataConversion.ServerDataConverter.to(i_FrequencyIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_BusinessValueCategory: OS$DataConversion.ServerDataConverter.to(i_BusinessValueCategoryIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_BusinessValueSubCateg: OS$DataConversion.ServerDataConverter.to(i_BusinessValueSubCategIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_PaidOn: OS$DataConversion.ServerDataConverter.to(i_PaidOnIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_AmountFrom: OS$DataConversion.ServerDataConverter.to(i_AmountFromIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_AmountTo: OS$DataConversion.ServerDataConverter.to(i_AmountToIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_CurrencyId: OS$DataConversion.ServerDataConverter.to(i_CurrencyIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_InvoiceCreatedOn: OS$DataConversion.ServerDataConverter.to(i_InvoiceCreatedOnIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_FolioCreatedOn: OS$DataConversion.ServerDataConverter.to(i_FolioCreatedOnIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
}),
i_SpecialApprovalId: OS$DataConversion.ServerDataConverter.to(i_SpecialApprovalIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_CFDITypeId: OS$DataConversion.ServerDataConverter.to(i_CFDITypeIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_IsSelectAll: OS$DataConversion.ServerDataConverter.to(i_IsSelectAllIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_SelectedIds: OS$DataConversion.ServerDataConverter.to(i_SelectedIdsIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateReportSAPStatus", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ActionGenerateReportSAPStatus", "+ea7XwZE17dLs2LVJTe93g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus$ActionGenerateReportSAPStatus"))();
executeServerActionResult.fileOut = OS$DataConversion.ServerDataConverter.from(outputs.File, ST_a158c76eb93396680623c04244f48b6cStructure);
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
string_Join$ServerAction(listIn, separatorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("String_Join", function (span) {
if(span) {
span.setAttribute("code.function", "String_Join");
span.setAttribute("outsystems.function.key", "1cf751c0-0149-42cb-a39f-8982dd6393b3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
List: OS$DataConversion.ServerDataConverter.to(listIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
Separator: OS$DataConversion.ServerDataConverter.to(separatorIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("String_Join", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ActionString_Join", "lNvoEPPn2Douj1QaJi3ZCA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus$ActionString_Join"))();
executeServerActionResult.textOut = OS$DataConversion.ServerDataConverter.from(outputs.Text, OS$DataTypes.DataTypes.Text);
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
get getSpecialApprovals$AggrRefresh() {if(!(this.hasOwnProperty("_getSpecialApprovals$AggrRefresh"))) {
this._getSpecialApprovals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSpecialApprovals", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ScreenDataSetGetSpecialApprovals", "vnJOYyFcujOLSxybVuL+qg", maxRecords, startIndex, function (b) {
model.variables.getSpecialApprovalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialApprovalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialApprovalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialApprovals", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovals");
span.setAttribute("outsystems.function.key", "1942e7dc-ae05-4a65-a6b2-59d44cd2280b");
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

return this._getSpecialApprovals$AggrRefresh;
}set getSpecialApprovals$AggrRefresh(value) {this._getSpecialApprovals$AggrRefresh = value;
}

get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "2cfde5fd-9c8b-4f8e-bbed-8a30945af1bf");
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

get getInvoicesSAP$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesSAP$AggrRefresh"))) {
this._getInvoicesSAP$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesSAP", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ScreenDataSetGetInvoicesSAP", "wb+YTFyqdZ1ldaUVlM0KPA", maxRecords, startIndex, function (b) {
model.variables.getInvoicesSAPAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesSAPAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesSAPAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoicesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesSAP", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesSAP");
span.setAttribute("outsystems.function.key", "366a1d2e-9b4b-417d-9c39-760dfc23cb32");
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

return this._getInvoicesSAP$AggrRefresh;
}set getInvoicesSAP$AggrRefresh(value) {this._getInvoicesSAP$AggrRefresh = value;
}

get getFrequencies$AggrRefresh() {if(!(this.hasOwnProperty("_getFrequencies$AggrRefresh"))) {
this._getFrequencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFrequencies", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ScreenDataSetGetFrequencies", "AzjepyCQFApZH_95qbpcQw", maxRecords, startIndex, function (b) {
model.variables.getFrequenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFrequenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFrequenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFrequencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetFrequencies");
span.setAttribute("outsystems.function.key", "4301e411-287b-4f3f-8034-de141f385779");
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

return this._getFrequencies$AggrRefresh;
}set getFrequencies$AggrRefresh(value) {this._getFrequencies$AggrRefresh = value;
}

get getInvoiceStatus$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceStatus$AggrRefresh"))) {
this._getInvoiceStatus$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceStatus", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ScreenDataSetGetInvoiceStatus", "Fh6rbTuJ7IV8cHXu_VYJ2g", maxRecords, startIndex, function (b) {
model.variables.getInvoiceStatusAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceStatusAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceStatusAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceStatus", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceStatus");
span.setAttribute("outsystems.function.key", "c9b634ae-2743-4183-af21-7a34b287689e");
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

return this._getInvoiceStatus$AggrRefresh;
}set getInvoiceStatus$AggrRefresh(value) {this._getInvoiceStatus$AggrRefresh = value;
}

get getAccountingDataTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountingDataTypes$AggrRefresh"))) {
this._getAccountingDataTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountingDataTypes", "screenservices/ConectaProveedores/j_FoliosSAE/FoliosContabilizationSAPStatus/ScreenDataSetGetAccountingDataTypes", "GSdIV_2QnHAjbJAYrKgrwA", maxRecords, startIndex, function (b) {
model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingDataTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingDataTypes");
span.setAttribute("outsystems.function.key", "d8f22e19-9513-4547-8b16-fe5c1dc7c20b");
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

return this._getAccountingDataTypes$AggrRefresh;
}set getAccountingDataTypes$AggrRefresh(value) {this._getAccountingDataTypes$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSpecialApprovals$AggrRefresh", "getCurrencies$AggrRefresh", "getInvoicesSAP$AggrRefresh", "getFrequencies$AggrRefresh", "getInvoiceStatus$AggrRefresh", "getAccountingDataTypes$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_clearArrivalDate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearArrivalDate", function (span) {
if(span) {
span.setAttribute("code.function", "ClearArrivalDate");
span.setAttribute("outsystems.function.key", "13b5a33d-f97b-484e-9f69-4094dcd96479");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearArrivalDate");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// FolioContabilization_Filters_FolioCreatedOn = NullDate
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FolioCreatedOn(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerArrivalDate"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerArrivalDate"), callContext);

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
_getInvoicesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "3c8f805c-6054-4e73-84bb-d13f8a8f7be9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoicesOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_IsSelected = False
model.variables.l_IsSelectedVar = false;
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesSAPAggr.listOut, function (p) {
return ((p.invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationSuccess) || (p.invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError));
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
return controller.getSettings$ServerAction(idService.getId("InvoicesTable"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVar = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
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
_onClickOpenPaidOn$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickOpenPaidOn", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenPaidOn");
span.setAttribute("outsystems.function.key", "47705298-88aa-486d-8056-a70f2e491d68");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickOpenPaidOn");
callContext = controller.callContext(callContext);
var datePickerPaidOn2Var = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerPaidOn2
datePickerPaidOn2Var.value = OutSystemsUIController$datePickerOpen$Action(idService.getId("DatePickerPaidOn"), callContext);

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
span.setAttribute("outsystems.function.key", "570e63ae-0b90-48c3-821d-5a7fa416abc9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.ExpandFilters$vars"))());
return OS$Flow.executeAsyncFlow(function () {
// l_ShowFilters = notl_ShowFilters
model.variables.l_ShowFiltersVar = (!(model.variables.l_ShowFiltersVar));
return OS$Flow.executeSequence(function () {
if((!(model.variables.l_ShowFiltersVar))) {
// IsRefresh = Requisitions_CompanyId <> NullIdentifier or Requisitions_ProjectId <> NullIdentifier or Requisitions_AmountFrom <> 0 or Requisitions_AmountTo <> 0
vars.value.isRefreshVar = (((!(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))));
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshVar)) {
// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "57dfaa69-5501-4871-bad2-e94f11ad68d0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
var datePickerClearInvoiceDateVar = new OS$DataTypes.VariableHolder();
var datePickerClearPaidOnVar = new OS$DataTypes.VariableHolder();
var datePickerClearArrivalDateVar = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerClearInvoiceDate
datePickerClearInvoiceDateVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerInvoiceDate"), callContext);

// Execute Action: DatePickerClearPaidOn
datePickerClearPaidOnVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerPaidOn"), callContext);

// Execute Action: DatePickerClearArrivalDate
datePickerClearArrivalDateVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerArrivalDate"), callContext);

// Execute Action: GetTotals
controller._getTotals$Action(callContext);
// FolioContabilization_Filters_AmountFrom = 0
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AmountFrom(0);
// FolioContabilization_Filters_AmountTo = 0
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AmountTo(OS$BuiltinFunctions.integerToDecimal(0));
// FolioContabilization_Filters_AssignedTo = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AssignedTo("");
// FolioContabilization_Filters_BusinessValueCategory = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_BusinessValueCategory("");
// FolioContabilization_Filters_BusinessValueSubCateg = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_BusinessValueSubCateg("");
// FolioContabilization_Filters_AccountingTypeId = NullIdentifier
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AccountingTypeId(OS$BuiltinFunctions.nullIdentifier());
// FolioContabilization_Filters_CurrencyId = NullTextIdentifier
ConectaProveedoresClientVariables.setFolioContabilization_Filters_CurrencyId(OS$BuiltinFunctions.nullTextIdentifier());
// FolioContabilization_Filters_FolioCreatedOn = NullDate
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FolioCreatedOn(OS$BuiltinFunctions.nullDate());
// FolioContabilization_Filters_FolioNumber = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FolioNumber("");
// FolioContabilization_Filters_FrequencyId = NullIdentifier
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FrequencyId(OS$BuiltinFunctions.nullIdentifier());
// FolioContabilization_Filters_InvoiceCreatedOn = NullDate
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceCreatedOn(OS$BuiltinFunctions.nullDate());
// FolioContabilization_Filters_InvoiceName = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceName("");
// FolioContabilization_Filters_InvoiceStatusId = NullIdentifier
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceStatusId(OS$BuiltinFunctions.nullIdentifier());
// FolioContabilization_Filters_OrderMainNumber = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_OrderMainNumber("");
// FolioContabilization_Filters_PaidOn = NullDate
ConectaProveedoresClientVariables.setFolioContabilization_Filters_PaidOn(OS$BuiltinFunctions.nullDate());
// FolioContabilization_Filters_Period = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_Period("");
// FolioContabilization_Filters_Project = ""
ConectaProveedoresClientVariables.setFolioContabilization_Filters_Project("");
// FolioContabilization_Filters_SpecialApprovalId = NullIdentifier
ConectaProveedoresClientVariables.setFolioContabilization_Filters_SpecialApprovalId(OS$BuiltinFunctions.nullIdentifier());
// FolioContabilization_Filters_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setFolioContabilization_Filters_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// l_AmountFromText = ""
model.variables.l_AmountFromTextVar = "";
// l_AmountToText = ""
model.variables.l_AmountToTextVar = "";
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
span.setAttribute("outsystems.function.key", "5e458a6c-dcd2-4861-abbe-5b623ca08723");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
return OS$Flow.executeAsyncFlow(function () {
// ClearSelectedIds
// SelectedIds = ""
model.variables.selectedIdsVar = "";
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
}

// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// IsAnyBulkApprovable = False
model.variables.isAnyBulkApprovableVar = false;
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "5e686ac7-f522-49c9-b79d-8e4ab1db9eed");
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
span.setAttribute("outsystems.function.key", "761878c3-dedf-4ced-89c4-a0b3175490d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierIdInLocal = supplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// FolioContabilization_Filters_SupplierId = SupplierId
ConectaProveedoresClientVariables.setFolioContabilization_Filters_SupplierId(vars.value.supplierIdInLocal);
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
_datePickerInvoiceDate$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "78a851c4-7d52-4181-95bb-1357604565ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerInvoiceDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DatePickerInvoiceDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// FolioContabilization_Filters_InvoiceCreatedOn = SelectedDateTime
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceCreatedOn(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
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
span.setAttribute("outsystems.function.key", "7a25aab0-1546-435c-bc28-f79f955988a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDebounce");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// FolioContabilization_Filters_AmountFrom = TextToDecimal
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AmountFrom(OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountFromTextVar))));
// FolioContabilization_Filters_AmountTo = TextToDecimal
ConectaProveedoresClientVariables.setFolioContabilization_Filters_AmountTo(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountToTextVar));
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
span.setAttribute("outsystems.function.key", "8098d8b0-c055-4474-849d-b4b22ffbeb2e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectAllLines");
callContext = controller.callContext(callContext);
// SelectedIds = ""
model.variables.selectedIdsVar = "";
if((model.variables.l_IsSelectAllVar)) {
// l_IsSelected = True
model.variables.l_IsSelectedVar = true;
// Foreach GetInvoicesSAP.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoicesSAPAggr.listOut);
try {var getInvoicesSAPIterator = callContext.iterationContext.getIterator(model.variables.getInvoicesSAPAggr.listOut);
var getInvoicesSAPIndex = 0;
while (((getInvoicesSAPIndex < model.variables.getInvoicesSAPAggr.listOut.length))) {
getInvoicesSAPIterator.currentRowNumber = getInvoicesSAPIndex;
// IsSelected = True
// GetInvoicesSAP.List.Current.IsSelected = True
model.variables.getInvoicesSAPAggr.listOut.getItem(getInvoicesSAPIndex.valueOf()).isSelectedAttr = true;
getInvoicesSAPIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoicesSAPAggr.listOut);
}

// Execute Action: GetTotals
controller._getTotals$Action(callContext);
// Execute Action: CheckAnyBulkApprovable
controller._checkAnyBulkApprovable$Action(callContext);
} else {
// Foreach GetInvoicesSAP.List
callContext.iterationContext.registerIterationStart(model.variables.getInvoicesSAPAggr.listOut);
try {var getInvoicesSAPIterator = callContext.iterationContext.getIterator(model.variables.getInvoicesSAPAggr.listOut);
var getInvoicesSAPIndex = 0;
while (((getInvoicesSAPIndex < model.variables.getInvoicesSAPAggr.listOut.length))) {
getInvoicesSAPIterator.currentRowNumber = getInvoicesSAPIndex;
// IsSelected = False
// GetInvoicesSAP.List.Current.IsSelected = False
model.variables.getInvoicesSAPAggr.listOut.getItem(getInvoicesSAPIndex.valueOf()).isSelectedAttr = false;
getInvoicesSAPIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoicesSAPAggr.listOut);
}

// l_IsSelected = False
model.variables.l_IsSelectedVar = false;
// Execute Action: GetTotals2
controller._getTotals$Action(callContext);
// Execute Action: CheckAnyBulkApprovable2
controller._checkAnyBulkApprovable$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClickOpenInvoiceDate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickOpenInvoiceDate", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenInvoiceDate");
span.setAttribute("outsystems.function.key", "88f4b7a7-5bcb-4a50-ab0c-ea206ecfa024");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickOpenInvoiceDate");
callContext = controller.callContext(callContext);
var datePickerInvoiceDate2Var = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerInvoiceDate2
datePickerInvoiceDate2Var.value = OutSystemsUIController$datePickerOpen$Action(idService.getId("DatePickerInvoiceDate"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_datePickerOnDatePickerPaidOn$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnDatePickerPaidOn", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnDatePickerPaidOn");
span.setAttribute("outsystems.function.key", "8b15da93-8148-4c5a-bdb1-54e1300f9b03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnDatePickerPaidOn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DatePickerOnDatePickerPaidOn$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// FolioContabilization_Filters_PaidOn = SelectedDateTime
ConectaProveedoresClientVariables.setFolioContabilization_Filters_PaidOn(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearInvoiceDate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearInvoiceDate", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInvoiceDate");
span.setAttribute("outsystems.function.key", "8db37f07-9135-4319-8a1f-816e1bbb2ddb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearInvoiceDate");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// FolioContabilization_Filters_InvoiceCreatedOn = NullDate
ConectaProveedoresClientVariables.setFolioContabilization_Filters_InvoiceCreatedOn(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerInvoiceDate"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerInvoiceDate"), callContext);

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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "8e3d252b-4188-4099-b965-d6a879c358c1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.OnSort$vars"))());
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
// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
span.setAttribute("outsystems.function.key", "a12713a5-81c9-4026-a9f9-5460591ba36c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.ColumnTogglerPassColumn$vars"))());
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
_checkAnyBulkApprovable$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckAnyBulkApprovable", function (span) {
if(span) {
span.setAttribute("code.function", "CheckAnyBulkApprovable");
span.setAttribute("outsystems.function.key", "a3d2c9a2-a2dc-4e0f-b1be-17ef8779f9af");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckAnyBulkApprovable");
callContext = controller.callContext(callContext);
var listAnyBulkApprovableVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListAnyBulkApprovable
listAnyBulkApprovableVar.value = OS$SystemActions.listAny(model.variables.getInvoicesSAPAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError));
}, callContext);

// IsAnyBulkApprovable = ListAnyBulkApprovable.Result
model.variables.isAnyBulkApprovableVar = listAnyBulkApprovableVar.value.resultOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClickOpenArrivalDate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickOpenArrivalDate", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenArrivalDate");
span.setAttribute("outsystems.function.key", "abc6b95a-eea9-4c8a-9d0a-397b8c941a0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickOpenArrivalDate");
callContext = controller.callContext(callContext);
var datePickerArrivalDate2Var = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerArrivalDate2
datePickerArrivalDate2Var.value = OutSystemsUIController$datePickerOpen$Action(idService.getId("DatePickerArrivalDate"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_bulkRetryOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("BulkRetryOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "BulkRetryOnClick");
span.setAttribute("outsystems.function.key", "b2488aad-93bf-4d33-b86d-ac856af7b8e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("BulkRetryOnClick");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesSAPAggr.listOut, function (p) {
return (p.isSelectedAttr && (p.invoiceAttr.invoiceStatusIdAttr === ConectaProveedores_staticEntities_invoiceStatus.contabilizationError));
}, callContext);

// Foreach ListFilter.FilteredList
callContext.iterationContext.registerIterationStart(listFilterVar.value.filteredListOut);
return OS$Flow.tryFinally(function () {
var filteredListIterator = callContext.iterationContext.getIterator(listFilterVar.value.filteredListOut);
var filteredListIndex = 0;
return OS$Flow.whileAsync(function () {
return ((filteredListIndex < listFilterVar.value.filteredListOut.length));
}, function () {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: InvoiceAccountingProcess_Create
model.flush();
return controller.invoiceAccountingProcess_Create$ServerAction(listFilterVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr.idAttr, "", true, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function () {
filteredListIndex++;
});
});
}, function () {
callContext.iterationContext.registerIterationEnd(listFilterVar.value.filteredListOut);
}).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fg9D3J7J+E6YDi8yynZhBg#Message.423474808.1", "Your invoices have been sent for contabilization"), /*Info*/ 0);
// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "bd968a6d-a262-42f2-80b2-77b40c4db8dc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
span.setAttribute("outsystems.function.key", "cc529652-6d84-457a-a0b4-1838181cbc53");
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
rec.screenAttr = "Folios Contabilization SAP Status";
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
_clearPaidOn$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearPaidOn", function (span) {
if(span) {
span.setAttribute("code.function", "ClearPaidOn");
span.setAttribute("outsystems.function.key", "da4c0f10-1aed-4ca8-9f51-839e9c07d6bf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearPaidOn");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// FolioContabilization_Filters_PaidOn = NullDate
ConectaProveedoresClientVariables.setFolioContabilization_Filters_PaidOn(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerPaidOn"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerPaidOn"), callContext);

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
_generateReport$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GenerateReport", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReport");
span.setAttribute("outsystems.function.key", "e59ad4d0-ef68-4626-95f4-1cabc9a07d24");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GenerateReport");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var generateReportSAPStatusVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.getInvoicesSAPAggr.listOut.isEmpty)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1RLHopMeeEegn34Ti_P3Xg#Message.-1473724744.1", "The selected list to download is empty."), /*Error*/ 3);
} else {
// l_Loading = True
model.variables.l_LoadingVar = true;
// Execute Action: GenerateReportSAPStatus
model.flush();
return controller.generateReportSAPStatus$ServerAction((ConectaProveedoresClientVariables.getOffsetUtc() * (-1)), ConectaProveedoresClientVariables.getFolioContabilization_Filters_SupplierId(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceName(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioNumber(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceStatusId(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_OrderMainNumber(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_AssignedTo(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_Project(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_Period(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_FrequencyId(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueCategory(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_BusinessValueSubCateg(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_PaidOn(), OS$BuiltinFunctions.integerToDecimal(ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountFrom()), ConectaProveedoresClientVariables.getFolioContabilization_Filters_AmountTo(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_CurrencyId(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_InvoiceCreatedOn(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_FolioCreatedOn(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_SpecialApprovalId(), ConectaProveedoresClientVariables.getFolioContabilization_Filters_AccountingTypeId(), model.variables.l_IsSelectAllVar, model.variables.selectedIdsVar, callContext).then(function (value) {
generateReportSAPStatusVar.value = value;
}).then(function () {
// l_Loading = False
model.variables.l_LoadingVar = false;
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateReportSAPStatusVar.value.fileOut.binaryDataAttr, generateReportSAPStatusVar.value.fileOut.nameAttr));
});
}

});
}).catch(function (ex) {
OS$Logger.debug("FoliosContabilizationSAPStatus.GenerateReport", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "213bea92-c65a-44e1-be40-5165a2613b21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// l_Loading = False
model.variables.l_LoadingVar = false;
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("oUti+PIGQEKvui9YX5jhvA#Message.1989930733.1", "There was a problem generating the report. Please try again later."), /*Error*/ 3);
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
_isAnyLineSelected$Action(folioIdIn, isSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("IsAnyLineSelected", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "e78369e1-9384-4c96-add8-e2f7920d91f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("IsAnyLineSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.IsAnyLineSelected$vars"))());
vars.value.folioIdInLocal = folioIdIn;
vars.value.isSelectedInLocal = isSelectedIn;
var string_JoinVar = new OS$DataTypes.VariableHolder();
var listIndexOf2Var = new OS$DataTypes.VariableHolder();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListIndexOf2
listIndexOf2Var.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesSAPAggr.listOut, function (p) {
return (!(p.isSelectedAttr));
}, callContext);

if((((listIndexOf2Var.value.positionOut) !== ((-1))))) {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getInvoicesSAPAggr.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// l_IsSelected = ListIndexOf.Position <> -1
model.variables.l_IsSelectedVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// Execute Action: GetTotals3
controller._getTotals$Action(callContext);
} else {
// l_IsSelectAll = True
model.variables.l_IsSelectAllVar = true;
// l_IsSelected = True
model.variables.l_IsSelectedVar = true;
}

// Execute Action: CheckAnyBulkApprovable
controller._checkAnyBulkApprovable$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.l_IsSelectAllVar)) {
// SelectedIds = ""
model.variables.selectedIdsVar = "";
// Execute Action: GetTotals4
controller._getTotals$Action(callContext);
} else {
// Execute Action: GetTotals
controller._getTotals$Action(callContext);
return OS$Flow.executeSequence(function () {
if((vars.value.isSelectedInLocal)) {
// ADD FolioID
// SelectedIds = SelectedIds + "#" + FolioId
model.variables.selectedIdsVar = ((model.variables.selectedIdsVar + "#") + OS$BuiltinFunctions.longIntegerToText(vars.value.folioIdInLocal));
} else {
// Execute Action: GetTotals2
controller._getTotals$Action(callContext);
return OS$Flow.executeSequence(function () {
if(((model.variables.selectedIdsVar === ""))) {
// l_IsSelectAll = True
model.variables.l_IsSelectAllVar = true;
// Execute Action: String_Join
model.flush();
return controller.string_Join$ServerAction(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoicesSAPAggr.listOut, new (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(TextRec, {
name: "Text",
attrName: "textAttr",
nameForJson: "Text2",
uniqueId: "0d84b59e-ff89-87c4-71ae-b49dfa9f2c39"
}))))(), function (source, target) {
target.textAttr.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.folioAttr.idAttr);
return target;
}), ",", callContext).then(function (value) {
string_JoinVar.value = value;
}).then(function () {
// SelectedIds = If
model.variables.selectedIdsVar = ((model.variables.getInvoicesSAPAggr.listOut.isEmpty) ? ("") : (OS$BuiltinFunctions.replace(("," + string_JoinVar.value.textOut), ",", "#")));
// SelectedIds = Replace
model.variables.selectedIdsVar = OS$BuiltinFunctions.replace(model.variables.selectedIdsVar, ("#" + OS$BuiltinFunctions.longIntegerToText(vars.value.folioIdInLocal)), "");
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
});
} else {
// Remove Folio ID
// SelectedIds = Replace
model.variables.selectedIdsVar = OS$BuiltinFunctions.replace(model.variables.selectedIdsVar, ("#" + OS$BuiltinFunctions.longIntegerToText(vars.value.folioIdInLocal)), "");
}

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
_getTotals$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetTotals", function (span) {
if(span) {
span.setAttribute("code.function", "GetTotals");
span.setAttribute("outsystems.function.key", "edbcef38-92e7-4e27-938c-5ed0f84288a2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetTotals");
callContext = controller.callContext(callContext);
var listIndexOfCurrencyVar = new OS$DataTypes.VariableHolder();
var notificationOpenVar = new OS$DataTypes.VariableHolder();
var notificationCloseVar = new OS$DataTypes.VariableHolder();
var listFilterSelectedVar = new OS$DataTypes.VariableHolder();
// l_IsCalculating = True
model.variables.l_IsCalculatingVar = true;
// l_TotalSelected = 0
model.variables.l_TotalSelectedVar = 0;
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_TotalsListVar, callContext);
// Execute Action: ListFilterSelected
listFilterSelectedVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesSAPAggr.listOut, function (p) {
return (p.isSelectedAttr && ((p.currencyAttr.codeAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())));
}, callContext);

// Empty?
if((listFilterSelectedVar.value.filteredListOut.isEmpty)) {
// Execute Action: NotificationClose
notificationCloseVar.value = OutSystemsUIController$notificationClose$Action(idService.getId("NotificationTotals"), callContext);

// l_IsCalculating = False
model.variables.l_IsCalculatingVar = false;
} else {
// Execute Action: NotificationOpen
notificationOpenVar.value = OutSystemsUIController$notificationOpen$Action(idService.getId("NotificationTotals"), callContext);

// Foreach ListFilterSelected.FilteredList
callContext.iterationContext.registerIterationStart(listFilterSelectedVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterSelectedVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterSelectedVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// Execute Action: ListIndexOfCurrency
listIndexOfCurrencyVar.value = OS$SystemActions.listIndexOf(model.variables.l_TotalsListVar, function (p) {
return (p.currencyAttr.codeAttr === listFilterSelectedVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).currencyAttr.codeAttr);
}, callContext);

// Exists?
if((((listIndexOfCurrencyVar.value.positionOut) !== ((-1))))) {
// l_TotalsList[ListIndexOfCurrency.Position].TotalAmount = l_TotalsList[ListIndexOfCurrency.Position].TotalAmount + ListFilterSelected.FilteredList.Current.Invoice.TotalAmount
model.variables.l_TotalsListVar.getItem(listIndexOfCurrencyVar.value.positionOut).totalAmountAttr = model.variables.l_TotalsListVar.getItem(listIndexOfCurrencyVar.value.positionOut).totalAmountAttr.plus(listFilterSelectedVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr.totalAmountAttr);
} else {
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.l_TotalsListVar, function () {
var rec = new RC_4d06af040e4a89ed9c35b745b328b97d();
rec.currencyAttr = listFilterSelectedVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).currencyAttr;
rec.totalAmountAttr = listFilterSelectedVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).invoiceAttr.totalAmountAttr;
return rec;
}(), callContext);
}

filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterSelectedVar.value.filteredListOut);
}

// l_IsCalculating = False
model.variables.l_IsCalculatingVar = false;
// l_TotalSelected = ListFilterSelected.FilteredList.Length
model.variables.l_TotalSelectedVar = listFilterSelectedVar.value.filteredListOut.length;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_detailsOnClick$Action(i_InvoiceIdIn, isCloseIn, i_FolioIdIn, i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DetailsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DetailsOnClick");
span.setAttribute("outsystems.function.key", "f36eb6c3-4a20-4250-af00-53b3c18223a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DetailsOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DetailsOnClick$vars"))());
vars.value.i_InvoiceIdInLocal = i_InvoiceIdIn;
vars.value.isCloseInLocal = isCloseIn;
vars.value.i_FolioIdInLocal = i_FolioIdIn;
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isCloseInLocal)) {
// Reset
// l_InvoiceId = NullIdentifier
model.variables.l_InvoiceIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// l_ShowDetails = notl_ShowDetails
model.variables.l_ShowDetailsVar = (!(model.variables.l_ShowDetailsVar));
// l_FolioId = NullIdentifier
model.variables.l_FolioIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsRefreshInLocal)) {
// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}

});
} else {
// l_InvoiceId = i_InvoiceId
model.variables.l_InvoiceIdVar = vars.value.i_InvoiceIdInLocal;
// l_ShowDetails = notl_ShowDetails
model.variables.l_ShowDetailsVar = (!(model.variables.l_ShowDetailsVar));
// l_FolioId = i_FolioId
model.variables.l_FolioIdVar = vars.value.i_FolioIdInLocal;
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
_retryOnClick$Action(invoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RetryOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RetryOnClick");
span.setAttribute("outsystems.function.key", "fb032d20-84b2-4962-b5a2-0cb865fe081b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RetryOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.RetryOnClick$vars"))());
vars.value.invoiceIdInLocal = invoiceIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: InvoiceAccountingProcess_Create
model.flush();
return controller.invoiceAccountingProcess_Create$ServerAction(vars.value.invoiceIdInLocal, "", true, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function () {
// Refresh Query: GetInvoicesSAP
var result = controller.getInvoicesSAP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("sFBm9RjBBkOs3WfSM7pCiA#Message.-984304323.1", "Your invoice has been sent for contabilization"), /*Info*/ 0);
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
_datePickerOnDatePickerArrivalDate$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnDatePickerArrivalDate", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnDatePickerArrivalDate");
span.setAttribute("outsystems.function.key", "fdd15d45-29e6-4d73-9024-9b796a0cc26e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnDatePickerArrivalDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DatePickerOnDatePickerArrivalDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// FolioContabilization_Filters_FolioCreatedOn = SelectedDateTime
ConectaProveedoresClientVariables.setFolioContabilization_Filters_FolioCreatedOn(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

clearArrivalDate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearArrivalDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearArrivalDate");
span.setAttribute("outsystems.function.key", "13b5a33d-f97b-484e-9f69-4094dcd96479");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearArrivalDate$Action, callContext);
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
span.setAttribute("outsystems.function.key", "3c8f805c-6054-4e73-84bb-d13f8a8f7be9");
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

onClickOpenPaidOn$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickOpenPaidOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenPaidOn");
span.setAttribute("outsystems.function.key", "47705298-88aa-486d-8056-a70f2e491d68");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickOpenPaidOn$Action, callContext);
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
span.setAttribute("outsystems.function.key", "570e63ae-0b90-48c3-821d-5a7fa416abc9");
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

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "57dfaa69-5501-4871-bad2-e94f11ad68d0");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "5e458a6c-dcd2-4861-abbe-5b623ca08723");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "5e686ac7-f522-49c9-b79d-8e4ab1db9eed");
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
span.setAttribute("outsystems.function.key", "761878c3-dedf-4ced-89c4-a0b3175490d1");
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

datePickerInvoiceDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerInvoiceDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerInvoiceDate");
span.setAttribute("outsystems.function.key", "78a851c4-7d52-4181-95bb-1357604565ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerInvoiceDate$Action, callContext, selectedDateTimeIn);
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
span.setAttribute("outsystems.function.key", "7a25aab0-1546-435c-bc28-f79f955988a6");
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

selectAllLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectAllLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectAllLines");
span.setAttribute("outsystems.function.key", "8098d8b0-c055-4474-849d-b4b22ffbeb2e");
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

onClickOpenInvoiceDate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickOpenInvoiceDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenInvoiceDate");
span.setAttribute("outsystems.function.key", "88f4b7a7-5bcb-4a50-ab0c-ea206ecfa024");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickOpenInvoiceDate$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

datePickerOnDatePickerPaidOn$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnDatePickerPaidOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnDatePickerPaidOn");
span.setAttribute("outsystems.function.key", "8b15da93-8148-4c5a-bdb1-54e1300f9b03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnDatePickerPaidOn$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearInvoiceDate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearInvoiceDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInvoiceDate");
span.setAttribute("outsystems.function.key", "8db37f07-9135-4319-8a1f-816e1bbb2ddb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearInvoiceDate$Action, callContext);
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
span.setAttribute("outsystems.function.key", "8e3d252b-4188-4099-b965-d6a879c358c1");
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
span.setAttribute("outsystems.function.key", "a12713a5-81c9-4026-a9f9-5460591ba36c");
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

checkAnyBulkApprovable$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckAnyBulkApprovable__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckAnyBulkApprovable");
span.setAttribute("outsystems.function.key", "a3d2c9a2-a2dc-4e0f-b1be-17ef8779f9af");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkAnyBulkApprovable$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickOpenArrivalDate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickOpenArrivalDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenArrivalDate");
span.setAttribute("outsystems.function.key", "abc6b95a-eea9-4c8a-9d0a-397b8c941a0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickOpenArrivalDate$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

bulkRetryOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("BulkRetryOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "BulkRetryOnClick");
span.setAttribute("outsystems.function.key", "b2488aad-93bf-4d33-b86d-ac856af7b8e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._bulkRetryOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "bd968a6d-a262-42f2-80b2-77b40c4db8dc");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "cc529652-6d84-457a-a0b4-1838181cbc53");
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

clearPaidOn$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearPaidOn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearPaidOn");
span.setAttribute("outsystems.function.key", "da4c0f10-1aed-4ca8-9f51-839e9c07d6bf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearPaidOn$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

generateReport$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateReport__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReport");
span.setAttribute("outsystems.function.key", "e59ad4d0-ef68-4626-95f4-1cabc9a07d24");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._generateReport$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

isAnyLineSelected$Action(folioIdIn, isSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("IsAnyLineSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "IsAnyLineSelected");
span.setAttribute("outsystems.function.key", "e78369e1-9384-4c96-add8-e2f7920d91f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._isAnyLineSelected$Action, callContext, folioIdIn, isSelectedIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getTotals$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetTotals__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetTotals");
span.setAttribute("outsystems.function.key", "edbcef38-92e7-4e27-938c-5ed0f84288a2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getTotals$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

detailsOnClick$Action(i_InvoiceIdIn, isCloseIn, i_FolioIdIn, i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DetailsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DetailsOnClick");
span.setAttribute("outsystems.function.key", "f36eb6c3-4a20-4250-af00-53b3c18223a8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._detailsOnClick$Action, callContext, i_InvoiceIdIn, isCloseIn, i_FolioIdIn, i_IsRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

retryOnClick$Action(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RetryOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RetryOnClick");
span.setAttribute("outsystems.function.key", "fb032d20-84b2-4962-b5a2-0cb865fe081b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._retryOnClick$Action, callContext, invoiceIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerOnDatePickerArrivalDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnDatePickerArrivalDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnDatePickerArrivalDate");
span.setAttribute("outsystems.function.key", "fdd15d45-29e6-4d73-9024-9b796a0cc26e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnDatePickerArrivalDate$Action, callContext, selectedDateTimeIn);
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
return ConectaProveedores_j_FoliosSAEController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Folios, ConectaProveedoresController$default.roles.Pedidos]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus$ActionGenerateReportSAPStatus", [{
name: "File",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus$ActionString_Join", [{
name: "Text",
attrName: "textOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId",
attrName: "supplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DatePickerInvoiceDate$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DatePickerOnDatePickerPaidOn$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.IsAnyLineSelected$vars", [{
name: "FolioId",
attrName: "folioIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "IsSelected",
attrName: "isSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DetailsOnClick$vars", [{
name: "i_InvoiceId",
attrName: "i_InvoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "IsClose",
attrName: "isCloseInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_FolioId",
attrName: "i_FolioIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.RetryOnClick$vars", [{
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.DatePickerOnDatePickerArrivalDate$vars", [{
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


