import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, EN_a9440c310249b67518f0615139b4c690EntityRecord, EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord, RC_3e9738e6e6c45aed847983a73298da67, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord, ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getCostCenters$AggrRefresh: 0,
getInvoiceRetentionsByInvoiceId$AggrRefresh: 0,
getTaxIndicators$AggrRefresh: 0,
getInvoiceApproval$AggrRefresh: 0,
getPaymentMethods$AggrRefresh: 0,
getPaymentTerms$AggrRefresh: 0,
getInvoiceExtendedById$AggrRefresh: 0,
getAccountingAccountsServiceTypes$AggrRefresh: 0,
getRegions$AggrRefresh: 0,
getInvoiceAccountingsByInvoiceId$AggrRefresh: 0,
getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh: 0,
getInvoiceExtendedTaxsByInvoiceId$AggrRefresh: 0,
getData$DataActRefresh: 0,
getInvoiceAccounting$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getCostCenters$AggrRefresh: [],
getInvoiceRetentionsByInvoiceId$AggrRefresh: [],
getTaxIndicators$AggrRefresh: [],
getInvoiceApproval$AggrRefresh: [],
getPaymentMethods$AggrRefresh: [],
getPaymentTerms$AggrRefresh: [],
getInvoiceExtendedById$AggrRefresh: [],
getAccountingAccountsServiceTypes$AggrRefresh: [],
getRegions$AggrRefresh: [],
getInvoiceAccountingsByInvoiceId$AggrRefresh: [],
getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh: [],
getInvoiceExtendedTaxsByInvoiceId$AggrRefresh: [],
getData$DataActRefresh: [],
getInvoiceAccounting$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
checkUserSession$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckUserSession", function (span) {
if(span) {
span.setAttribute("code.function", "CheckUserSession");
span.setAttribute("outsystems.function.key", "83326f1c-eaba-4dc4-a622-0044ab12fa2e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("CheckUserSession", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ActionCheckUserSession", "r6LGmAV4qXUN0IKWGjbASA", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionCheckUserSession"))();
executeServerActionResult.isValidSessionOut = OS$DataConversion.ServerDataConverter.from(outputs.IsValidSession, OS$DataTypes.DataTypes.Boolean);
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
getPaymentMethodDescriptionById$ServerAction(paymentMethodsIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetPaymentMethodDescriptionById", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentMethodDescriptionById");
span.setAttribute("outsystems.function.key", "88122f10-a035-4d8f-a94b-5cdce94260f8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
PaymentMethodsId: OS$DataConversion.ServerDataConverter.to(paymentMethodsIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetPaymentMethodDescriptionById", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ActionGetPaymentMethodDescriptionById", "5elxzoJFNIdUrB+k_rsXhA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionGetPaymentMethodDescriptionById"))();
executeServerActionResult.descOut = OS$DataConversion.ServerDataConverter.from(outputs.Desc, OS$DataTypes.DataTypes.Text);
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
invoiceAccountingSave$ServerAction(i_InvoiceIdIn, i_InvoiceAccountingIn, i_InvoiceAddendumListIn, i_InvoiceExtendedIn, i_InvoiceAccountingServicesListIn, i_IsImportIn, i_InvoiceAccountingEntriesIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceAccountingSave", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceAccountingSave");
span.setAttribute("outsystems.function.key", "ea43a3f3-bb2b-4f16-8d94-70adb559aef6");
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
i_InvoiceAccounting: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_InvoiceAddendumList: OS$DataConversion.ServerDataConverter.to(i_InvoiceAddendumListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_InvoiceExtended: OS$DataConversion.ServerDataConverter.to(i_InvoiceExtendedIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_InvoiceAccountingServicesList: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingServicesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_IsImport: OS$DataConversion.ServerDataConverter.to(i_IsImportIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_InvoiceAccountingEntries: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingEntriesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("InvoiceAccountingSave", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ActionInvoiceAccountingSave", "+OaYtBHOtgAjHh8Am0yN2A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionInvoiceAccountingSave"))();
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
getPaymentTermDescriptionById$ServerAction(paymentTermsIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetPaymentTermDescriptionById", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTermDescriptionById");
span.setAttribute("outsystems.function.key", "a828f986-00bc-4787-8635-9724622cff93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
PaymentTermsId: OS$DataConversion.ServerDataConverter.to(paymentTermsIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetPaymentTermDescriptionById", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ActionGetPaymentTermDescriptionById", "cYRna9jhvR6EqfFFRbf+LQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionGetPaymentTermDescriptionById"))();
executeServerActionResult.descOut = OS$DataConversion.ServerDataConverter.from(outputs.Desc, OS$DataTypes.DataTypes.Text);
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
onSubmitAccounting$ServerAction(i_InvoiceIdIn, i_InvoiceApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, i_InvoiceAccountingIn, i_InvoiceAddendumListIn, i_InvoiceExtendedIn, i_InvoiceAccountingServicesListIn, i_IsImportIn, i_InvoiceAccountingEntriesIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSubmitAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "OnSubmitAccounting");
span.setAttribute("outsystems.function.key", "d689569b-925a-4fd1-901e-b229a72a94e1");
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
i_InvoiceAccounting: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_InvoiceAddendumList: OS$DataConversion.ServerDataConverter.to(i_InvoiceAddendumListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_InvoiceExtended: OS$DataConversion.ServerDataConverter.to(i_InvoiceExtendedIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_InvoiceAccountingServicesList: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingServicesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_IsImport: OS$DataConversion.ServerDataConverter.to(i_IsImportIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_InvoiceAccountingEntries: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingEntriesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("OnSubmitAccounting", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ActionOnSubmitAccounting", "5tCw0KuFXoRxdNCFWu06og", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionOnSubmitAccounting"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.isToFinishOut = OS$DataConversion.ServerDataConverter.from(outputs.IsToFinish, OS$DataTypes.DataTypes.Boolean);
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
getCodeByTaxId$ServerAction(taxIndicatorIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetCodeByTaxId", function (span) {
if(span) {
span.setAttribute("code.function", "GetCodeByTaxId");
span.setAttribute("outsystems.function.key", "0583140c-6817-475d-b144-53dea3b43888");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
TaxIndicatorId: OS$DataConversion.ServerDataConverter.to(taxIndicatorIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetCodeByTaxId", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ActionGetCodeByTaxId", "Ty7QM+GgI+PN2Z+tGRad3Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionGetCodeByTaxId"))();
executeServerActionResult.codeOut = OS$DataConversion.ServerDataConverter.from(outputs.Code, OS$DataTypes.DataTypes.Text);
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
get getCostCenters$AggrRefresh() {if(!(this.hasOwnProperty("_getCostCenters$AggrRefresh"))) {
this._getCostCenters$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCostCenters", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetCostCenters", "PFgOcVYTyd2esKT4r8d2yg", maxRecords, startIndex, function (b) {
model.variables.getCostCentersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCostCentersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCostCentersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCostCenters", function (span) {
if(span) {
span.setAttribute("code.function", "GetCostCenters");
span.setAttribute("outsystems.function.key", "1cdad81b-a827-42cd-aa7b-182cac2bc755");
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

get getInvoiceRetentionsByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceRetentionsByInvoiceId$AggrRefresh"))) {
this._getInvoiceRetentionsByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceRetentionsByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetInvoiceRetentionsByInvoiceId", "XfJdJHOAa26JwHbaGS3tnQ", maxRecords, startIndex, function (b) {
model.variables.getInvoiceRetentionsByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceRetentionsByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceRetentionsByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceRetentionsByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceRetentionsByInvoiceId");
span.setAttribute("outsystems.function.key", "32e1d129-8624-4b57-9631-649b4ad4fd61");
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

return this._getInvoiceRetentionsByInvoiceId$AggrRefresh;
}set getInvoiceRetentionsByInvoiceId$AggrRefresh(value) {this._getInvoiceRetentionsByInvoiceId$AggrRefresh = value;
}

get getTaxIndicators$AggrRefresh() {if(!(this.hasOwnProperty("_getTaxIndicators$AggrRefresh"))) {
this._getTaxIndicators$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetTaxIndicators", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetTaxIndicators", "byk0b5sGlb4sLA6+QluOFg", maxRecords, startIndex, function (b) {
model.variables.getTaxIndicatorsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getTaxIndicatorsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getTaxIndicatorsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetTaxIndicators", function (span) {
if(span) {
span.setAttribute("code.function", "GetTaxIndicators");
span.setAttribute("outsystems.function.key", "4e367852-d90e-4fa4-a3f6-e497a8834cb9");
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

return this._getTaxIndicators$AggrRefresh;
}set getTaxIndicators$AggrRefresh(value) {this._getTaxIndicators$AggrRefresh = value;
}

get getInvoiceApproval$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceApproval$AggrRefresh"))) {
this._getInvoiceApproval$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceApproval", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetInvoiceApproval", "wfk51u1BGH3d15JUu2Mqyw", maxRecords, startIndex, function (b) {
model.variables.getInvoiceApprovalAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceApprovalAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceApprovalAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceApproval", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceApproval");
span.setAttribute("outsystems.function.key", "51cee49f-d2e0-4e63-b779-156a942cc083");
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

return this._getInvoiceApproval$AggrRefresh;
}set getInvoiceApproval$AggrRefresh(value) {this._getInvoiceApproval$AggrRefresh = value;
}

get getPaymentMethods$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentMethods$AggrRefresh"))) {
this._getPaymentMethods$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentMethods", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetPaymentMethods", "npZ34hlfwoGQJHz7xDdwVw", maxRecords, startIndex, function (b) {
model.variables.getPaymentMethodsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentMethodsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentMethodsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentMethods", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentMethods");
span.setAttribute("outsystems.function.key", "6620dd59-3f2e-4a2c-9576-b27e696fb2ff");
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

return this._getPaymentMethods$AggrRefresh;
}set getPaymentMethods$AggrRefresh(value) {this._getPaymentMethods$AggrRefresh = value;
}

get getPaymentTerms$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentTerms$AggrRefresh"))) {
this._getPaymentTerms$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentTerms", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetPaymentTerms", "+6OhqwjTKpS9lXyr02rGqw", maxRecords, startIndex, function (b) {
model.variables.getPaymentTermsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTerms", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTerms");
span.setAttribute("outsystems.function.key", "6f4674b8-0175-4cab-9135-50345b5de6f0");
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

return this._getPaymentTerms$AggrRefresh;
}set getPaymentTerms$AggrRefresh(value) {this._getPaymentTerms$AggrRefresh = value;
}

get getInvoiceExtendedById$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedById$AggrRefresh"))) {
this._getInvoiceExtendedById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedById", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetInvoiceExtendedById", "RlRF4r4Wn6OQ7og9ZiLl4A", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedById", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedById");
span.setAttribute("outsystems.function.key", "8100bdec-1cfc-4236-a51c-0b544d17e2a7");
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

return this._getInvoiceExtendedById$AggrRefresh;
}set getInvoiceExtendedById$AggrRefresh(value) {this._getInvoiceExtendedById$AggrRefresh = value;
}

get getAccountingAccountsServiceTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountingAccountsServiceTypes$AggrRefresh"))) {
this._getAccountingAccountsServiceTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountingAccountsServiceTypes", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetAccountingAccountsServiceTypes", "t28k2Knts2Qv4GQe9TM9NA", maxRecords, startIndex, function (b) {
model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingAccountsServiceTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingAccountsServiceTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingAccountsServiceTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingAccountsServiceTypes");
span.setAttribute("outsystems.function.key", "884cf5d4-0484-4ad8-9cdc-621f27b2f182");
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

return this._getAccountingAccountsServiceTypes$AggrRefresh;
}set getAccountingAccountsServiceTypes$AggrRefresh(value) {this._getAccountingAccountsServiceTypes$AggrRefresh = value;
}

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "a855c0c7-7733-4d84-8be6-0e6e5e23b685");
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

get getInvoiceAccountingsByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceAccountingsByInvoiceId$AggrRefresh"))) {
this._getInvoiceAccountingsByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceAccountingsByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetInvoiceAccountingsByInvoiceId", "BYgI+D2LOkASNVpBBm_Y6w", maxRecords, startIndex, function (b) {
model.variables.getInvoiceAccountingsByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceAccountingsByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceAccountingsByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceAccountingsByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceAccountingsByInvoiceId");
span.setAttribute("outsystems.function.key", "ab4c0eda-5944-4044-822c-4abdf99172ae");
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

return this._getInvoiceAccountingsByInvoiceId$AggrRefresh;
}set getInvoiceAccountingsByInvoiceId$AggrRefresh(value) {this._getInvoiceAccountingsByInvoiceId$AggrRefresh = value;
}

get getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh"))) {
this._getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "sj7QdCKaGixjzJ+AOBxSkA", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedMoreChargesByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedMoreChargesByInvoiceId");
span.setAttribute("outsystems.function.key", "d7e3b6ad-18a4-4c78-bda7-164e0d455ac6");
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

return this._getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh;
}set getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh(value) {this._getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh = value;
}

get getInvoiceExtendedTaxsByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceExtendedTaxsByInvoiceId$AggrRefresh"))) {
this._getInvoiceExtendedTaxsByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId", "BIHVJDSZJX4S+I40KWiYYg", maxRecords, startIndex, function (b) {
model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceExtendedTaxsByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceExtendedTaxsByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceExtendedTaxsByInvoiceId");
span.setAttribute("outsystems.function.key", "e984e0d5-7610-4ee4-a443-cb46a1514a8d");
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

return this._getInvoiceExtendedTaxsByInvoiceId$AggrRefresh;
}set getInvoiceExtendedTaxsByInvoiceId$AggrRefresh(value) {this._getInvoiceExtendedTaxsByInvoiceId$AggrRefresh = value;
}

get getData$DataActRefresh() {if(!(this.hasOwnProperty("_getData$DataActRefresh"))) {
this._getData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetData", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/DataActionGetData", "OLxw5EtdXIuJNpmz4QELpA", function (b) {
model.variables.getDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetData", function (span) {
if(span) {
span.setAttribute("code.function", "GetData");
span.setAttribute("outsystems.function.key", "c0a94230-174c-428d-9ae8-427a145128a7");
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

return this._getData$DataActRefresh;
}set getData$DataActRefresh(value) {this._getData$DataActRefresh = value;
}

get getInvoiceAccounting$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoiceAccounting$DataActRefresh"))) {
this._getInvoiceAccounting$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoiceAccounting", "screenservices/ConectaProveedores/d_Invoices/Wb_i_InvoiceAccounting_Old/DataActionGetInvoiceAccounting", "Gzt7_4GEiBaZ5R9TiJhwyg", function (b) {
model.variables.getInvoiceAccountingDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceAccountingDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceAccountingDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceAccounting");
span.setAttribute("outsystems.function.key", "d17a060c-f041-4bdb-babe-1a189f6b682e");
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

return this._getInvoiceAccounting$DataActRefresh;
}set getInvoiceAccounting$DataActRefresh(value) {this._getInvoiceAccounting$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getCostCenters$AggrRefresh", "getInvoiceRetentionsByInvoiceId$AggrRefresh", "getTaxIndicators$AggrRefresh", "getInvoiceApproval$AggrRefresh", "getPaymentMethods$AggrRefresh", "getPaymentTerms$AggrRefresh", "getInvoiceExtendedById$AggrRefresh", "getAccountingAccountsServiceTypes$AggrRefresh", "getRegions$AggrRefresh", "getInvoiceAccountingsByInvoiceId$AggrRefresh", "getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh", "getInvoiceExtendedTaxsByInvoiceId$AggrRefresh", "getData$DataActRefresh", "getInvoiceAccounting$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onClickRecordRemove$Action(i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickRecordRemove", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickRecordRemove");
span.setAttribute("outsystems.function.key", "03c7f662-89aa-4efd-9011-ba63a94cfee4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickRecordRemove");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickRecordRemove$vars"))());
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
// Execute Action: ListRemoveService
OS$SystemActions.listRemove(model.variables.getInvoiceAccountingDataAct.o_ListOut, vars.value.i_CurrentRowNumberInLocal, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openModifyPopUp$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenModifyPopUp", function (span) {
if(span) {
span.setAttribute("code.function", "OpenModifyPopUp");
span.setAttribute("outsystems.function.key", "0ed4691d-8eae-423d-8d2e-ca3f3ef0d188");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenModifyPopUp");
callContext = controller.callContext(callContext);
// l_ShowModifyPopup = notl_ShowModifyPopup
model.variables.l_ShowModifyPopupVar = (!(model.variables.l_ShowModifyPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_togglePopupApproval$Action(isToApproveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupApproval", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupApproval");
span.setAttribute("outsystems.function.key", "11569949-ef4e-4ab1-b986-dc088898e117");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("TogglePopupApproval");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.TogglePopupApproval$vars"))());
vars.value.isToApproveInLocal = isToApproveIn;
var checkUserSessionVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckUserSession
model.flush();
return controller.checkUserSession$ServerAction(callContext).then(function (value) {
checkUserSessionVar.value = value;
}).then(function () {
// l_ShowApprovalInvoice = notl_ShowApprovalInvoice
model.variables.l_ShowApprovalInvoiceVar = (!(model.variables.l_ShowApprovalInvoiceVar));
// l_IsApproval = IsToApprove
model.variables.l_IsApprovalVar = vars.value.isToApproveInLocal;
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
_dropdown_PaymentMethodIdOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_PaymentMethodIdOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_PaymentMethodIdOnChange");
span.setAttribute("outsystems.function.key", "20d2e3da-2614-4cc9-af93-bf0fddd002ff");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_PaymentMethodIdOnChange");
callContext = controller.callContext(callContext);
var getPaymentMethodDescriptionByIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetPaymentMethodDescriptionById
model.flush();
return controller.getPaymentMethodDescriptionById$ServerAction(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentMethodIdAttr, callContext).then(function (value) {
getPaymentMethodDescriptionByIdVar.value = value;
}).then(function () {
// GetInvoiceAccounting.o_List.Current.PaymentMethod = GetPaymentMethodDescriptionById.Desc
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentMethodAttr = getPaymentMethodDescriptionByIdVar.value.descOut;
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
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
_onClickEditField$Action(fieldIn, isToEditIn, indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickEditField", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickEditField");
span.setAttribute("outsystems.function.key", "235831f7-e40e-4a80-9de5-7ceb92a939f8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickEditField");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickEditField$vars"))());
vars.value.fieldInLocal = fieldIn;
vars.value.isToEditInLocal = isToEditIn;
vars.value.indexInLocal = indexIn;
// Foreach GetInvoiceAccounting.o_List
callContext.iterationContext.registerIterationStart(model.variables.getInvoiceAccountingDataAct.o_ListOut);
try {var o_ListIterator = callContext.iterationContext.getIterator(model.variables.getInvoiceAccountingDataAct.o_ListOut);
var o_ListIndex = 0;
while (((o_ListIndex < model.variables.getInvoiceAccountingDataAct.o_ListOut.length))) {
o_ListIterator.currentRowNumber = o_ListIndex;
// Execute Action: EditField
controller._editField$Action(vars.value.fieldInLocal, vars.value.isToEditInLocal, vars.value.indexInLocal, model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext), callContext);
// GetInvoiceAccounting.o_List.Current.IsErrorFreeText = If
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorFreeTextAttr = (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorFreeTextAttr && (((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0) && ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.freeTextAttr) !== (""))) || ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) > 0) && ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.freeTextAttr) !== ("")))))) ? (false) : (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorFreeTextAttr));
o_ListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoiceAccountingDataAct.o_ListOut);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClickSave$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickSave", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSave");
span.setAttribute("outsystems.function.key", "3a42e48f-6eca-43a1-bfb7-14dcbfe00678");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickSave");
callContext = controller.callContext(callContext);
var invoiceAccountingSaveVar = new OS$DataTypes.VariableHolder();
var listFilterServicesVar = new OS$DataTypes.VariableHolder();
var listFilterAccountingVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ListFilterAccounting
listFilterAccountingVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceAccountingDataAct.o_ListOut, function (p) {
return p.hideServicesFieldsAttr;
}, callContext);

// Execute Action: ListFilterServices
listFilterServicesVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceAccountingDataAct.o_ListOut, function (p) {
return p.hideAccountingFieldsAttr;
}, callContext);

// Execute Action: InvoiceAccountingSave
model.flush();
return controller.invoiceAccountingSave$ServerAction(model.variables.i_InvoiceIdIn, OS$DataConversion.JSConversions.typeConvertRecord(listFilterAccountingVar.value.filteredListOut.getCurrent(callContext.iterationContext), new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), function (source, target) {
target = source.invoiceAccountingAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(EN_a9440c310249b67518f0615139b4c690EntityRecord))(), function (source, target) {
target = source.invoiceExtendedMoreChargesAttr;
return target;
}), model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr, OS$DataConversion.JSConversions.typeConvertRecordList(listFilterServicesVar.value.filteredListOut, new (OS$GenericTypeCache.getGenericList(EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord))(), function (source, target) {
target = source.invoiceAccountingServicesAttr;
return target;
}), model.variables.l_IsImportVar, model.variables.l_InvoiceAccountingEntriesVar, callContext).then(function (value) {
invoiceAccountingSaveVar.value = value;
}).then(function () {
// Success?
if((invoiceAccountingSaveVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6i0S7Aea5Ui9lDzQlOHEYw#Message.1988649132.1", "Saved with success."), /*Success*/ 1);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("p_s4WVWzf02LaeLYQn66AQ#Message.-979985892.1", "Error Saving."), /*Error*/ 3);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_accountOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AccountOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "AccountOnChanged");
span.setAttribute("outsystems.function.key", "4e8be433-5e5d-4880-818b-c6870d9a8e22");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AccountOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.AccountOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.Account = SelectedOptionList.Current.Value
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr = vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr;
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_CostCenterSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_CostCenterSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CostCenterSearchOnChanged");
span.setAttribute("outsystems.function.key", "564ccffd-2379-46b1-869b-9a8fe1a6f737");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_CostCenterSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.Dropdown_CostCenterSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.CostCenterId = IntegerToIdentifier
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.costCenterIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
// GetInvoiceAccounting.o_List.Current.CostCenterSAP = SelectedOptionList.Current.Description + " " + SelectedOptionList.Current.Label
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterSAPAttr = ((vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).descriptionAttr + " ") + vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).labelAttr);
// GetInvoiceAccounting.o_List.Current.BeneficiaryCenterSAP = SelectedOptionList.Current.GroupName
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).beneficiaryCenterSAPAttr = vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).groupNameAttr;
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7bda930f-ec30-405a-91b1-b67c05f95bc7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceExtendedById
var result = controller.getInvoiceExtendedById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoiceExtendedMoreChargesByInvoiceId
var result = controller.getInvoiceExtendedMoreChargesByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetData
var result = controller.getData$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceAccounting
var result = controller.getInvoiceAccounting$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceApproval
var result = controller.getInvoiceApproval$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceRetentionsByInvoiceId
var result = controller.getInvoiceRetentionsByInvoiceId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceExtendedTaxsByInvoiceId
var result = controller.getInvoiceExtendedTaxsByInvoiceId$AggrRefresh(99999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetInvoiceAccountingsByInvoiceId
var result = controller.getInvoiceAccountingsByInvoiceId$AggrRefresh(1, 0, callContext);
model.flush();
return result;
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
_togglePopupCancel$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupCancel", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupCancel");
span.setAttribute("outsystems.function.key", "7c935ffe-6592-42b0-b8d2-182393a4bc17");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopupCancel");
callContext = controller.callContext(callContext);
// l_ShowCancelInvoice = notl_ShowCancelInvoice
model.variables.l_ShowCancelInvoiceVar = (!(model.variables.l_ShowCancelInvoiceVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_PaymentTermsIdOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_PaymentTermsIdOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_PaymentTermsIdOnChange");
span.setAttribute("outsystems.function.key", "9291232c-52b2-473e-8d4e-e1b63173f466");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_PaymentTermsIdOnChange");
callContext = controller.callContext(callContext);
var getPaymentTermDescriptionByIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetPaymentTermDescriptionById
model.flush();
return controller.getPaymentTermDescriptionById$ServerAction(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.paymentTermsIdAttr, callContext).then(function (value) {
getPaymentTermDescriptionByIdVar.value = value;
}).then(function () {
// GetInvoiceAccounting.o_List.Current.PaymentTerm = GetPaymentTermDescriptionById.Desc
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).paymentTermAttr = getPaymentTermDescriptionByIdVar.value.descOut;
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
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
_onImportData$Action(i_InvoiceAccountingIn, i_InvoiceAccountingServicesIn, i_InvoiceAccountingEntriesIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnImportData", function (span) {
if(span) {
span.setAttribute("code.function", "OnImportData");
span.setAttribute("outsystems.function.key", "93f56ab7-70c6-4a4d-a58a-2e7d92b958fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnImportData");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnImportData$vars"))());
vars.value.i_InvoiceAccountingInLocal = i_InvoiceAccountingIn.clone();
vars.value.i_InvoiceAccountingServicesInLocal = i_InvoiceAccountingServicesIn.clone();
vars.value.i_InvoiceAccountingEntriesInLocal = i_InvoiceAccountingEntriesIn.clone();
if(((!(model.variables.isCorpIn)))) {
// Division = i_InvoiceAccounting.Division
vars.value.divisionVar = vars.value.i_InvoiceAccountingInLocal.divisionAttr;
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.getInvoiceAccountingDataAct.o_ListOut, callContext);
// i_InvoiceAccountingServices.Current.InvoiceAccountingServices.Division = Division
vars.value.i_InvoiceAccountingServicesInLocal.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.divisionAttr = vars.value.divisionVar;
// i_InvoiceAccountingEntries.Current.Division = Division
vars.value.i_InvoiceAccountingEntriesInLocal.getCurrent(callContext.iterationContext).divisionAttr = vars.value.divisionVar;
} else {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.getInvoiceAccountingDataAct.o_ListOut, callContext);
}

// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.getInvoiceAccountingDataAct.o_ListOut, function () {
var rec = new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure();
rec.hideServicesFieldsAttr = true;
rec.invoiceAccountingAttr = vars.value.i_InvoiceAccountingInLocal;
rec.iVAIndicatorAttr = vars.value.i_InvoiceAccountingEntriesInLocal.getCurrent(callContext.iterationContext).indicadordeIVAAttr;
rec.paymentMethodAttr = vars.value.i_InvoiceAccountingEntriesInLocal.getCurrent(callContext.iterationContext).v_pagoAttr;
rec.paymentTermAttr = vars.value.i_InvoiceAccountingEntriesInLocal.getCurrent(callContext.iterationContext).condicionesdepagoAttr;
return rec;
}(), callContext);
// Execute Action: ListAppendAllServices
OS$SystemActions.listAppendAll(model.variables.getInvoiceAccountingDataAct.o_ListOut, OS$DataConversion.JSConversions.typeConvertRecordList(vars.value.i_InvoiceAccountingServicesInLocal, new (OS$GenericTypeCache.getGenericList(ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure))(), function (source, target) {
target.costCenterSAPAttr = source.costCenterSAPAttr;
target.hideAccountingFieldsAttr = true;
target.invoiceAccountingAttr.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.invoiceAccountingServicesAttr = source.invoiceAccountingServicesAttr;
target.costCenterAttr.idAttr = model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).costCenterAttr.idAttr;
target.costCenterAttr.soc_Attr = "";
target.costCenterAttr.div_Attr = "";
target.costCenterAttr.areaAttr = "";
target.costCenterAttr.ce_costeAttr = "";
target.costCenterAttr.ceBeAttr = "";
target.costCenterAttr.denominacionAttr = "";
target.costCenterAttr.descripcionAttr = "";
target.costCenterAttr.responsableAttr = "";
target.costCenterAttr.ceCoAttr = "";
target.costCenterAttr.ingresosreales_Ind_debloqueoAttr = "";
target.costCenterAttr.actualiz_comprom__Ind_debloqAttr = "";
target.costCenterAttr.ingresosplan_Ind_debloqueo_Attr = "";
target.costCenterAttr.autorAttr = "";
target.costCenterAttr.isActiveAttr = true;
target.iVAIndicatorAttr = source.indicatorIVAAttr;
target.buyDocNumberAttr = source.invoiceAccountingServicesAttr.buyDocNumberAttr;
target.buyDocPositionAttr = source.invoiceAccountingServicesAttr.buyDocPositionAttr;
return target;
}), callContext);
// l_IsImport = True
model.variables.l_IsImportVar = true;
// l_InvoiceAccountingEntries = i_InvoiceAccountingEntries
model.variables.l_InvoiceAccountingEntriesVar = vars.value.i_InvoiceAccountingEntriesInLocal;
// Execute Action: ShowHideImportPopup
controller._togglePopupImport$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClickSendAccounting$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickSendAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSendAccounting");
span.setAttribute("outsystems.function.key", "a9d024ba-37c1-48cc-a8d8-06b7bb2ffa67");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickSendAccounting");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickSendAccounting$vars"))());
var checkUserSessionVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// TotalToCompare = If
vars.value.totalToCompareVar = (((model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr === "MX")) ? (model.variables.getInvoiceAccountingsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.totalAmountAttr) : (model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr.totalAttr));
// Execute Action: CheckUserSession
model.flush();
return controller.checkUserSession$ServerAction(callContext).then(function (value) {
checkUserSessionVar.value = value;
}).then(function () {
// Foreach GetInvoiceAccounting.o_List
callContext.iterationContext.registerIterationStart(model.variables.getInvoiceAccountingDataAct.o_ListOut);
}).then(function () {
try {var o_ListIterator = callContext.iterationContext.getIterator(model.variables.getInvoiceAccountingDataAct.o_ListOut);
var o_ListIndex = 0;
while (((o_ListIndex < model.variables.getInvoiceAccountingDataAct.o_ListOut.length))) {
o_ListIterator.currentRowNumber = o_ListIndex;
// first row
if(((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrentRowNumber(callContext.iterationContext) === 0))) {
// GetInvoiceAccounting.o_List.Current.IsErrorFreeText = GetInvoiceAccounting.o_List.Current.InvoiceAccounting.FreeText = ""
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorFreeTextAttr = (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.freeTextAttr === "");
// GetInvoiceAccounting.o_List.Current.IsErrorDivision = GetInvoiceAccounting.o_List.Current.InvoiceAccounting.Division = ""
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorDivisionAttr = (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.divisionAttr === "");
// GetInvoiceAccounting.o_List.Current.IsErrorTotalAmount = GetInvoiceAccounting.o_List.Current.InvoiceAccounting.TotalAmount > TotalToCompare
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorTotalAmountAttr = model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.totalAmountAttr.gt(vars.value.totalToCompareVar);
// IsError = GetInvoiceAccounting.o_List.Current.InvoiceAccounting.Division = "" or GetInvoiceAccounting.o_List.Current.InvoiceAccounting.FreeText = ""
vars.value.isErrorVar = ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.divisionAttr === "") || (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.freeTextAttr === ""));
// IsErrorTotal = GetInvoiceAccounting.o_List.Current.InvoiceAccounting.TotalAmount > TotalToCompare
vars.value.isErrorTotalVar = model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.totalAmountAttr.gt(vars.value.totalToCompareVar);
// TotalAmount = GetInvoiceAccounting.o_List.Current.InvoiceAccounting.TotalAmount
vars.value.totalAmountVar = model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingAttr.totalAmountAttr;
} else {
// GetInvoiceAccounting.o_List.Current.IsErrorAccountingAccounts_ServiceType = GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.Account = "" and notGetData.IsAnticipoWithInv
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorAccountingAccounts_ServiceTypeAttr = ((model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.accountAttr === "") && (!(model.variables.getDataDataAct.isAnticipoWithInvOut)));
// GetInvoiceAccounting.o_List.Current.IsErrorFreeText = GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.FreeText = ""
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorFreeTextAttr = (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.freeTextAttr === "");
// GetInvoiceAccounting.o_List.Current.IsErrorDivision = GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.Division = ""
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorDivisionAttr = (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.divisionAttr === "");
// Amount = Amount + GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.Amount
vars.value.amountVar = vars.value.amountVar.plus(model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.amountAttr);
// IsError = GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.Account = "" and notGetData.IsAnticipoWithInv or GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.FreeText = "" or GetInvoiceAccounting.o_List.Current.InvoiceAccountingServices.Division = ""
vars.value.isErrorVar = ((((model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.accountAttr === "") && (!(model.variables.getDataDataAct.isAnticipoWithInvOut))) || (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.freeTextAttr === "")) || (model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).invoiceAccountingServicesAttr.divisionAttr === ""));
}

o_ListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoiceAccountingDataAct.o_ListOut);
}

// dif total sum
if((!(OS$BuiltinFunctions.round(vars.value.amountVar, 2).equals(OS$BuiltinFunctions.round(vars.value.totalAmountVar, 2))))) {
// IsErrorSum = True
vars.value.isErrorSumVar = true;
// Foreach GetInvoiceAccounting.o_List
callContext.iterationContext.registerIterationStart(model.variables.getInvoiceAccountingDataAct.o_ListOut);
try {var o_ListIterator = callContext.iterationContext.getIterator(model.variables.getInvoiceAccountingDataAct.o_ListOut);
var o_ListIndex = 1;
while (((o_ListIndex < model.variables.getInvoiceAccountingDataAct.o_ListOut.length))) {
o_ListIterator.currentRowNumber = o_ListIndex;
// GetInvoiceAccounting.o_List.Current.IsErrorAmount = True
model.variables.getInvoiceAccountingDataAct.o_ListOut.getItem(o_ListIndex.valueOf()).isErrorAmountAttr = true;
o_ListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getInvoiceAccountingDataAct.o_ListOut);
}

}

return OS$Flow.executeSequence(function () {
if((((vars.value.isErrorVar || vars.value.isErrorTotalVar) || vars.value.isErrorSumVar))) {
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isErrorVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XUVvqnhorUybzRqk1zWs8g#Message.250164915.1", "Please fix the fields marked in red")) : (((vars.value.isErrorTotalVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XUVvqnhorUybzRqk1zWs8g#Message.-1458206260.1", "The total amount does not match with the invoice amount.")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XUVvqnhorUybzRqk1zWs8g#Message.-1519593542.1", "The amounts do not match with the total amount."))))), /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: TogglePopupApproval
return controller._togglePopupApproval$Action(true, callContext).then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
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
_dropdown_DivisonOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_DivisonOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DivisonOnChange");
span.setAttribute("outsystems.function.key", "b5041438-f03d-458f-a7aa-d0bbabf2f954");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_DivisonOnChange");
callContext = controller.callContext(callContext);
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClickRecordAdd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickRecordAdd", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickRecordAdd");
span.setAttribute("outsystems.function.key", "b78b8e6c-a8ac-473c-a8bc-843603dfd339");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickRecordAdd");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getTaxIndicatorsAggr.listOut, function (p) {
return (p.taxIndicatorAttr.externalIdAttr === model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr);
}, callContext);

// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.getInvoiceAccountingDataAct.o_ListOut, function () {
var rec = new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure();
rec.hideAccountingFieldsAttr = true;
rec.invoiceAccountingServicesAttr = function () {
var rec = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.iVAIndicatorIdAttr = listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).taxIndicatorAttr.idAttr;
rec.freeTextAttr = model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.freeTextAttr;
rec.divisionAttr = model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.divisionAttr;
rec.iCMEAttr = ((model.variables.getDataDataAct.isAnticipoWithInvOut) ? ("A") : (""));
return rec;
}();
rec.iVAIndicatorAttr = listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).taxIndicatorAttr.externalIdAttr;
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
_editField$Action(fieldIn, isToEditIn, indexIn, currRowIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("EditField", function (span) {
if(span) {
span.setAttribute("code.function", "EditField");
span.setAttribute("outsystems.function.key", "be6b072e-7784-4b87-93b2-1da2e6a00a03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("EditField");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.EditField$vars"))());
vars.value.fieldInLocal = fieldIn;
vars.value.isToEditInLocal = isToEditIn;
vars.value.indexInLocal = indexIn;
vars.value.currRowInLocal = currRowIn;
// set false
// GetInvoiceAccounting.o_List.Current.IsEditAccountingAccounts_ServiceType = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAccountingAccounts_ServiceTypeAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditCostCenterSAP = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditCostCenterSAPAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditFreeText = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditFreeTextAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditDivision = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditDivisionAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditIVA = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditIVAAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditAmount = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAmountAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditTotalAmount = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditTotalAmountAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditPaymentMethod = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentMethodAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditPaymentTerm = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentTermAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditICME = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditICMEAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditBuyDocNumber = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBuyDocNumberAttr = false;
// GetInvoiceAccounting.o_List.Current.IsEditBuyDocPosition = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBuyDocPositionAttr = false;
if((((vars.value.indexInLocal === vars.value.currRowInLocal) && vars.value.isToEditInLocal))) {
if(((vars.value.fieldInLocal === 1))) {
// service
// GetInvoiceAccounting.o_List.Current.IsEditAccountingAccounts_ServiceType = notGetInvoiceAccounting.o_List.Current.IsEditAccountingAccounts_ServiceType
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAccountingAccounts_ServiceTypeAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAccountingAccounts_ServiceTypeAttr));
// GetInvoiceAccounting.o_List.Current.IsErrorAccountingAccounts_ServiceType = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAccountingAccounts_ServiceTypeAttr = false;
} else {
if((vars.value.fieldInLocal === 2)) {
// costcenter
// GetInvoiceAccounting.o_List.Current.IsEditCostCenterSAP = notGetInvoiceAccounting.o_List.Current.IsEditCostCenterSAP
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditCostCenterSAPAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditCostCenterSAPAttr));
// GetInvoiceAccounting.o_List.Current.IsErrorCostCenterSAP = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorCostCenterSAPAttr = false;
} else {
if((vars.value.fieldInLocal === 3)) {
// freetext
// GetInvoiceAccounting.o_List.Current.IsEditFreeText = notGetInvoiceAccounting.o_List.Current.IsEditFreeText
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditFreeTextAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditFreeTextAttr));
} else {
if((vars.value.fieldInLocal === 4)) {
// division
// GetInvoiceAccounting.o_List.Current.IsEditDivision = If
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditDivisionAttr = ((model.variables.isCorpIn) ? ((!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditDivisionAttr))) : (false));
// GetInvoiceAccounting.o_List.Current.IsErrorDivision = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorDivisionAttr = false;
} else {
if((vars.value.fieldInLocal === 5)) {
// iva
// GetInvoiceAccounting.o_List.Current.IsEditIVA = notGetInvoiceAccounting.o_List.Current.IsEditIVA
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditIVAAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditIVAAttr));
} else {
if((vars.value.fieldInLocal === 6)) {
// amount
// GetInvoiceAccounting.o_List.Current.IsEditAmount = notGetInvoiceAccounting.o_List.Current.IsEditAmount
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAmountAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditAmountAttr));
// GetInvoiceAccounting.o_List.Current.IsErrorAmount = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorAmountAttr = false;
} else {
if((vars.value.fieldInLocal === 7)) {
// total
// GetInvoiceAccounting.o_List.Current.IsEditTotalAmount = notGetInvoiceAccounting.o_List.Current.IsEditTotalAmount
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditTotalAmountAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditTotalAmountAttr));
// GetInvoiceAccounting.o_List.Current.IsErrorTotalAmount = False
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isErrorTotalAmountAttr = false;
} else {
if((vars.value.fieldInLocal === 8)) {
// paymethod
// GetInvoiceAccounting.o_List.Current.IsEditPaymentMethod = notGetInvoiceAccounting.o_List.Current.IsEditPaymentMethod
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentMethodAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentMethodAttr));
} else {
if((vars.value.fieldInLocal === 9)) {
// payterm
// GetInvoiceAccounting.o_List.Current.IsEditPaymentTerm = notGetInvoiceAccounting.o_List.Current.IsEditPaymentTerm
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentTermAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditPaymentTermAttr));
} else {
if((vars.value.fieldInLocal === 10)) {
// icme
// GetInvoiceAccounting.o_List.Current.IsEditICME = notGetInvoiceAccounting.o_List.Current.IsEditICME
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditICMEAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditICMEAttr));
} else {
if((vars.value.fieldInLocal === 11)) {
// buydoc nr
// GetInvoiceAccounting.o_List.Current.IsEditBuyDocNumber = notGetInvoiceAccounting.o_List.Current.IsEditBuyDocNumber
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBuyDocNumberAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBuyDocNumberAttr));
} else {
if((vars.value.fieldInLocal === 12)) {
// buydoc pos
// GetInvoiceAccounting.o_List.Current.IsEditBuyDocPosition = notGetInvoiceAccounting.o_List.Current.IsEditBuyDocPosition
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBuyDocPositionAttr = (!(model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).isEditBuyDocPositionAttr));
}

}

}

}

}

}

}

}

}

}

}

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
_wb_PopupInvoiceModifyClose$Action(isRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_PopupInvoiceModifyClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_PopupInvoiceModifyClose");
span.setAttribute("outsystems.function.key", "c96a98ee-3c57-46b2-9e4d-05e4af045157");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_PopupInvoiceModifyClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.Wb_PopupInvoiceModifyClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
if((vars.value.isRefreshInLocal)) {
// Destination: /ConectaProveedores/Invoices_Detail
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices_Detail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(model.variables.i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} else {
// l_ShowModifyPopup = notl_ShowModifyPopup
model.variables.l_ShowModifyPopupVar = (!(model.variables.l_ShowModifyPopupVar));
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_togglePopupImport$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupImport", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupImport");
span.setAttribute("outsystems.function.key", "cb297b3c-295e-44f6-9f0e-3351cc25140f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopupImport");
callContext = controller.callContext(callContext);
// ShowImportPopup
// l_ShowImportPopup = notl_ShowImportPopup
model.variables.l_ShowImportPopupVar = (!(model.variables.l_ShowImportPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClosePopupApproval$Action(isOkIn, commentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClosePopupApproval", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopupApproval");
span.setAttribute("outsystems.function.key", "e893b67b-fa5d-49ab-85e9-af8855fd704c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClosePopupApproval");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClosePopupApproval$vars"))());
vars.value.isOkInLocal = isOkIn;
vars.value.commentInLocal = commentIn;
var onSubmitAccountingVar = new OS$DataTypes.VariableHolder();
var listFilterServicesVar = new OS$DataTypes.VariableHolder();
var listFilterAccountingVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.isOkInLocal)) {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ListFilterServices
listFilterServicesVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceAccountingDataAct.o_ListOut, function (p) {
return p.hideAccountingFieldsAttr;
}, callContext);

// Execute Action: ListFilterAccounting
listFilterAccountingVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceAccountingDataAct.o_ListOut, function (p) {
return p.hideServicesFieldsAttr;
}, callContext);

// Execute Action: OnSubmitAccounting
model.flush();
return controller.onSubmitAccounting$ServerAction(model.variables.i_InvoiceIdIn, model.variables.getInvoiceApprovalAggr.listOut.getCurrent(callContext.iterationContext).invoiceApprovalLevelAttr.idAttr, model.variables.l_IsApprovalVar, vars.value.commentInLocal, OS$DataConversion.JSConversions.typeConvertRecord(listFilterAccountingVar.value.filteredListOut.getCurrent(callContext.iterationContext), new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), function (source, target) {
target = source.invoiceAccountingAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceExtendedMoreChargesByInvoiceIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(EN_a9440c310249b67518f0615139b4c690EntityRecord))(), function (source, target) {
target = source.invoiceExtendedMoreChargesAttr;
return target;
}), model.variables.getInvoiceExtendedByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedAttr, OS$DataConversion.JSConversions.typeConvertRecordList(listFilterServicesVar.value.filteredListOut, new (OS$GenericTypeCache.getGenericList(EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord))(), function (source, target) {
target = source.invoiceAccountingServicesAttr;
return target;
}), model.variables.l_IsImportVar, model.variables.l_InvoiceAccountingEntriesVar, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
onSubmitAccountingVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((onSubmitAccountingVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(((model.variables.l_IsApprovalVar) ? (((onSubmitAccountingVar.value.isToFinishOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gmQN588jX0emKhdkmc7yjw#Message.-904545084.1", "Accounting proces has started.")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gmQN588jX0emKhdkmc7yjw#Message.1926737820.1", "Invoice has been approved.")))) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gmQN588jX0emKhdkmc7yjw#Message.20467194.1", "Invoice has been canceled."))), /*Success*/ 1);
// Execute Action: TogglePopupApproval3
return controller._togglePopupApproval$Action(false, callContext).then(function () {
// Refresh Query: GetInvoiceExtendedById
var result = controller.getInvoiceExtendedById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/Invoices_Detail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices_Detail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(model.variables.i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(onSubmitAccountingVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Refresh Query: GetInvoiceAccounting
var result = controller.getInvoiceAccounting$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Execute Action: TogglePopupApproval2
return controller._togglePopupApproval$Action(false, callContext);
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/Invoices_Detail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices_Detail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(model.variables.i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
}

});
});
} else {
// Execute Action: TogglePopupApproval
return controller._togglePopupApproval$Action(false, callContext);
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
_dropdown_IvaOnChange$Action(isFirstIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_IvaOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_IvaOnChange");
span.setAttribute("outsystems.function.key", "ef739fdb-bc0a-4f7a-9aca-79cf9eb9f668");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_IvaOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.Dropdown_IvaOnChange$vars"))());
vars.value.isFirstInLocal = isFirstIn;
var getCodeByTaxIdVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetCodeByTaxId
model.flush();
return controller.getCodeByTaxId$ServerAction(((vars.value.isFirstInLocal) ? (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingAttr.ivaIndicatorIdAttr) : (model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).invoiceAccountingServicesAttr.iVAIndicatorIdAttr)), callContext).then(function (value) {
getCodeByTaxIdVar.value = value;
}).then(function () {
// GetInvoiceAccounting.o_List.Current.IVAIndicator = GetCodeByTaxId.Code
model.variables.getInvoiceAccountingDataAct.o_ListOut.getCurrent(callContext.iterationContext).iVAIndicatorAttr = getCodeByTaxIdVar.value.codeOut;
// Execute Action: OnClickEditField
controller._onClickEditField$Action(0, false, 0, callContext);
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

onClickRecordRemove$Action(i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickRecordRemove__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickRecordRemove");
span.setAttribute("outsystems.function.key", "03c7f662-89aa-4efd-9011-ba63a94cfee4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickRecordRemove$Action, callContext, i_CurrentRowNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openModifyPopUp$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenModifyPopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenModifyPopUp");
span.setAttribute("outsystems.function.key", "0ed4691d-8eae-423d-8d2e-ca3f3ef0d188");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openModifyPopUp$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

togglePopupApproval$Action(isToApproveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupApproval__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupApproval");
span.setAttribute("outsystems.function.key", "11569949-ef4e-4ab1-b986-dc088898e117");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._togglePopupApproval$Action, callContext, isToApproveIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_PaymentMethodIdOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_PaymentMethodIdOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_PaymentMethodIdOnChange");
span.setAttribute("outsystems.function.key", "20d2e3da-2614-4cc9-af93-bf0fddd002ff");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_PaymentMethodIdOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onClickEditField$Action(fieldIn, isToEditIn, indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickEditField__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickEditField");
span.setAttribute("outsystems.function.key", "235831f7-e40e-4a80-9de5-7ceb92a939f8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickEditField$Action, callContext, fieldIn, isToEditIn, indexIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickSave$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickSave__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSave");
span.setAttribute("outsystems.function.key", "3a42e48f-6eca-43a1-bfb7-14dcbfe00678");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickSave$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

accountOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AccountOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AccountOnChanged");
span.setAttribute("outsystems.function.key", "4e8be433-5e5d-4880-818b-c6870d9a8e22");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._accountOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_CostCenterSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_CostCenterSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CostCenterSearchOnChanged");
span.setAttribute("outsystems.function.key", "564ccffd-2379-46b1-869b-9a8fe1a6f737");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_CostCenterSearchOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "7bda930f-ec30-405a-91b1-b67c05f95bc7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

togglePopupCancel$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupCancel__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupCancel");
span.setAttribute("outsystems.function.key", "7c935ffe-6592-42b0-b8d2-182393a4bc17");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopupCancel$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_PaymentTermsIdOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_PaymentTermsIdOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_PaymentTermsIdOnChange");
span.setAttribute("outsystems.function.key", "9291232c-52b2-473e-8d4e-e1b63173f466");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_PaymentTermsIdOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onImportData$Action(i_InvoiceAccountingIn, i_InvoiceAccountingServicesIn, i_InvoiceAccountingEntriesIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnImportData__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnImportData");
span.setAttribute("outsystems.function.key", "93f56ab7-70c6-4a4d-a58a-2e7d92b958fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onImportData$Action, callContext, i_InvoiceAccountingIn, i_InvoiceAccountingServicesIn, i_InvoiceAccountingEntriesIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickSendAccounting$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickSendAccounting__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSendAccounting");
span.setAttribute("outsystems.function.key", "a9d024ba-37c1-48cc-a8d8-06b7bb2ffa67");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickSendAccounting$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_DivisonOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_DivisonOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DivisonOnChange");
span.setAttribute("outsystems.function.key", "b5041438-f03d-458f-a7aa-d0bbabf2f954");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_DivisonOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickRecordAdd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickRecordAdd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickRecordAdd");
span.setAttribute("outsystems.function.key", "b78b8e6c-a8ac-473c-a8bc-843603dfd339");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickRecordAdd$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

editField$Action(fieldIn, isToEditIn, indexIn, currRowIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("EditField__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "EditField");
span.setAttribute("outsystems.function.key", "be6b072e-7784-4b87-93b2-1da2e6a00a03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._editField$Action, callContext, fieldIn, isToEditIn, indexIn, currRowIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_PopupInvoiceModifyClose$Action(isRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_PopupInvoiceModifyClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_PopupInvoiceModifyClose");
span.setAttribute("outsystems.function.key", "c96a98ee-3c57-46b2-9e4d-05e4af045157");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_PopupInvoiceModifyClose$Action, callContext, isRefreshIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

togglePopupImport$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupImport__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupImport");
span.setAttribute("outsystems.function.key", "cb297b3c-295e-44f6-9f0e-3351cc25140f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopupImport$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClosePopupApproval$Action(isOkIn, commentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClosePopupApproval__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopupApproval");
span.setAttribute("outsystems.function.key", "e893b67b-fa5d-49ab-85e9-af8855fd704c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClosePopupApproval$Action, callContext, isOkIn, commentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_IvaOnChange$Action(isFirstIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_IvaOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_IvaOnChange");
span.setAttribute("outsystems.function.key", "ef739fdb-bc0a-4f7a-9aca-79cf9eb9f668");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_IvaOnChange$Action, callContext, isFirstIn);
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
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onParametersChanged$Action(callContext);

};
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionCheckUserSession", [{
name: "IsValidSession",
attrName: "isValidSessionOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionGetPaymentMethodDescriptionById", [{
name: "Desc",
attrName: "descOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionInvoiceAccountingSave", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionGetPaymentTermDescriptionById", [{
name: "Desc",
attrName: "descOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionOnSubmitAccounting", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "IsToFinish",
attrName: "isToFinishOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old$ActionGetCodeByTaxId", [{
name: "Code",
attrName: "codeOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickRecordRemove$vars", [{
name: "i_CurrentRowNumber",
attrName: "i_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.TogglePopupApproval$vars", [{
name: "IsToApprove",
attrName: "isToApproveInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickEditField$vars", [{
name: "Field",
attrName: "fieldInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "IsToEdit",
attrName: "isToEditInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.AccountOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.Dropdown_CostCenterSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnImportData$vars", [{
name: "i_InvoiceAccounting",
attrName: "i_InvoiceAccountingInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
},
complexType: EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord
}, {
name: "i_InvoiceAccountingServices",
attrName: "i_InvoiceAccountingServicesInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(RC_3e9738e6e6c45aed847983a73298da67))();
},
complexType: (OS$GenericTypeCache.getGenericList(RC_3e9738e6e6c45aed847983a73298da67))
}, {
name: "i_InvoiceAccountingEntries",
attrName: "i_InvoiceAccountingEntriesInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord))();
},
complexType: (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord))
}, {
name: "Division",
attrName: "divisionVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClickSendAccounting$vars", [{
name: "Amount",
attrName: "amountVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}, {
name: "IsError",
attrName: "isErrorVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IsErrorTotal",
attrName: "isErrorTotalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IsErrorSum",
attrName: "isErrorSumVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "TotalAmount",
attrName: "totalAmountVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}, {
name: "TotalToCompare",
attrName: "totalToCompareVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.EditField$vars", [{
name: "Field",
attrName: "fieldInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "IsToEdit",
attrName: "isToEditInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "CurrRow",
attrName: "currRowInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.Wb_PopupInvoiceModifyClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.OnClosePopupApproval$vars", [{
name: "IsOk",
attrName: "isOkInLocal",
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.Dropdown_IvaOnChange$vars", [{
name: "IsFirst",
attrName: "isFirstInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


