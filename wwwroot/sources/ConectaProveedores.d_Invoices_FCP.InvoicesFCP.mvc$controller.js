import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Authorization as OS$Authorization, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { EN_d1d0320db36efbb094ad0082361435a0EntityRecord } from "./ConectaProveedores.model.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_d_Invoices_FCP_InvoicesFCP_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices_FCP.InvoicesFCP.mvc$translationsResources.js";
import ConectaProveedores_d_Invoices_FCPController$default from "./ConectaProveedores.d_Invoices_FCP.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_FCP_InvoicesFCP_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoicesFCP$AggrRefresh: -1,
getUserApplicationRolesAndMore$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoicesFCP$AggrRefresh: [],
getUserApplicationRolesAndMore$DataActRefresh: ["getInvoicesFCP$AggrRefresh"]
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/d_Invoices_FCP/InvoicesFCP/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP$ActionGetSettings"))();
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
invoiceManualAccounting$ServerAction(invoiceIdIn, polizaSAPIn, polizaSAP_CNIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InvoiceManualAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "InvoiceManualAccounting");
span.setAttribute("outsystems.function.key", "a1d822c6-14ff-4323-8e4e-d6abfe06e828");
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
PolizaSAP: OS$DataConversion.ServerDataConverter.to(polizaSAPIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
PolizaSAP_CN: OS$DataConversion.ServerDataConverter.to(polizaSAP_CNIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("InvoiceManualAccounting", "screenservices/ConectaProveedores/d_Invoices_FCP/InvoicesFCP/ActionInvoiceManualAccounting", "70CD5pt9N98aimktDxDlXg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP$ActionInvoiceManualAccounting"))();
executeServerActionResult.successOut = OS$DataConversion.ServerDataConverter.from(outputs.Success, OS$DataTypes.DataTypes.Boolean);
executeServerActionResult.messageOut = OS$DataConversion.ServerDataConverter.from(outputs.Message, OS$DataTypes.DataTypes.Text);
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/d_Invoices_FCP/InvoicesFCP/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/d_Invoices_FCP/InvoicesFCP/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getInvoicesFCP$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesFCP$AggrRefresh"))) {
this._getInvoicesFCP$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesFCP", "screenservices/ConectaProveedores/d_Invoices_FCP/InvoicesFCP/ScreenDataSetGetInvoicesFCP", "eVQhKGQK4TplemxJLixiOg", maxRecords, startIndex, function (b) {
model.variables.getInvoicesFCPAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesFCPAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesFCPAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoicesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesFCP", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesFCP");
span.setAttribute("outsystems.function.key", "c901d9a1-5fd7-4531-89ff-6140a56e6599");
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

return this._getInvoicesFCP$AggrRefresh;
}set getInvoicesFCP$AggrRefresh(value) {this._getInvoicesFCP$AggrRefresh = value;
}

get getUserApplicationRolesAndMore$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRolesAndMore$DataActRefresh"))) {
this._getUserApplicationRolesAndMore$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRolesAndMore", "screenservices/ConectaProveedores/d_Invoices_FCP/InvoicesFCP/DataActionGetUserApplicationRolesAndMore", "rAmeqWbqQS3M0ZRhHx3a4w", function (b) {
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
span.setAttribute("outsystems.function.key", "fa8f4a75-7d5a-49a7-aa4b-6d5262b294bd");
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
this._dataFetchActionNames = ["getInvoicesFCP$AggrRefresh", "getUserApplicationRolesAndMore$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_togglePopup$Action(ip_InvoiceIn, ip_Invoice_CNIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopup", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "138e6915-232e-4f70-97eb-4d52cf709091");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.TogglePopup$vars"))());
vars.value.ip_InvoiceInLocal = ip_InvoiceIn.clone();
vars.value.ip_Invoice_CNInLocal = ip_Invoice_CNIn.clone();
// l_IsOpenPopupAccounting = notl_IsOpenPopupAccounting
model.variables.l_IsOpenPopupAccountingVar = (!(model.variables.l_IsOpenPopupAccountingVar));
// l_Invoice_Popup = ip_Invoice
model.variables.l_Invoice_PopupVar = vars.value.ip_InvoiceInLocal;
// l_Invoice_CN_Popup = ip_Invoice_CN
model.variables.l_Invoice_CN_PopupVar = vars.value.ip_Invoice_CNInLocal;
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
span.setAttribute("outsystems.function.key", "3da2680a-ecc1-4982-b2d5-260880bebc20");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Execute Action: ResetFilters
controller._resetFilters$Action(callContext);
}

// Refresh Query: GetInvoicesFCP
var result = controller.getInvoicesFCP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
span.setAttribute("outsystems.function.key", "4f95405e-b2b1-4318-b1ed-d2df98a9d8fe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.OnSort$vars"))());
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
// Refresh Query: GetInvoicesFCP
var result = controller.getInvoicesFCP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_getInvoicesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "576d51db-bc92-4038-bfee-0fa2ab278385");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoicesOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Count
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchVar === 0))) {
// l_CountAfterFetch = l_CountAfterFetch + 1
model.variables.l_CountAfterFetchVar = (model.variables.l_CountAfterFetchVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("InvoicesTableFCP"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVar = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarVar = getSettingsVar.value.outSettingsTextOut;
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
_onClosePopup$Action(isSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClosePopup", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopup");
span.setAttribute("outsystems.function.key", "5aa21246-5a1c-45c8-ba39-cd34c966b67c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClosePopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.OnClosePopup$vars"))());
vars.value.isSaveInLocal = isSaveIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var invoiceManualAccountingVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// not save
return OS$Flow.executeSequence(function () {
if(((!(vars.value.isSaveInLocal)))) {
// Execute Action: TogglePopup2
controller._togglePopup$Action(model.variables.l_Invoice_PopupVar, model.variables.l_Invoice_CN_PopupVar, callContext);
} else {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_FormValid = True
vars.value.l_FormValidVar = true;
// poliza error
if(((model.variables.l_ID_POLIZA_SAPVar === ""))) {
// Validations
// Input_l_ID_POLIZA_SAP.Valid = False
model.widgets.get(idService.getId("Input_l_ID_POLIZA_SAP")).validAttr = false;
// Input_l_ID_POLIZA_SAP.ValidationMessage = "This field is mandatory"
model.widgets.get(idService.getId("Input_l_ID_POLIZA_SAP")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZqV0YZC6E0qVx5QyLddpow#Value.-1029745557.1", "This field is mandatory");
// l_FormValid = False
vars.value.l_FormValidVar = false;
}

// credit note error
if(((!(model.variables.l_Invoice_PopupVar.creditNoteInvoiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (model.variables.l_ID_POLIZA_SAP_CNVar === "")))) {
// Validations
// Input_l_ID_POLIZA_SAP2.Valid = False
model.widgets.get(idService.getId("Input_l_ID_POLIZA_SAP2")).validAttr = false;
// Input_l_ID_POLIZA_SAP2.ValidationMessage = "This field is mandatory"
model.widgets.get(idService.getId("Input_l_ID_POLIZA_SAP2")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yzMasgPrKUGVpf7x8LFoMA#Value.-1029745557.1", "This field is mandatory");
// l_FormValid = False
vars.value.l_FormValidVar = false;
}

// invalid form
return OS$Flow.executeSequence(function () {
if(((!(vars.value.l_FormValidVar)))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("939gtKd56kC9ku_jai1h2g#Message.-137279408.1", "Check all fields"), /*Warning*/ 2);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: InvoiceManualAccounting
model.flush();
return controller.invoiceManualAccounting$ServerAction(model.variables.l_Invoice_PopupVar.idAttr, model.variables.l_ID_POLIZA_SAPVar, model.variables.l_ID_POLIZA_SAP_CNVar, callContext).then(function (value) {
invoiceManualAccountingVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if(((!(invoiceManualAccountingVar.value.successOut)))) {
// Error Message
OS$FeedbackMessageService.showFeedbackMessage(invoiceManualAccountingVar.value.messageOut, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("q8TQm4MOn02m6iL+6_fTDg#Message.-712417038.1", "Invoice Accounting registered with success!"), /*Success*/ 1);
// Refresh Query: GetInvoicesFCP
var result = controller.getInvoicesFCP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// Execute Action: TogglePopup
controller._togglePopup$Action(model.variables.l_Invoice_PopupVar, model.variables.l_Invoice_CN_PopupVar, callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
}

});
});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("InvoicesFCP.OnClosePopup", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "a0f68b56-9d18-4312-99fe-a2154486a413");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "808d9c9d-6851-42d7-a9ac-91bd357dec15");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("InvoicesTableFCP"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "a0e78549-429c-4e7d-b095-aa6a99c89cd2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsCorporativoCXP
return OS$Flow.executeSequence(function () {
if((model.variables.getUserApplicationRolesAndMoreDataAct.isCxPOut)) {
// Refresh Query: GetInvoicesFCP
var result = controller.getInvoicesFCP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
});
} else {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
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
span.setAttribute("outsystems.function.key", "a4d112e6-60e4-4cfc-af9a-4c43b09e510f");
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
_resetFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResetFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "b9f06030-dc93-4fdb-8722-1b59800f7030");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ResetFilters");
callContext = controller.callContext(callContext);
// Reset Filters
// InvoicesFCP_FolioNumber = ""
ConectaProveedoresClientVariables.setInvoicesFCP_FolioNumber("");
// InvoicesFCP_Name = ""
ConectaProveedoresClientVariables.setInvoicesFCP_Name("");
// InvoicesFCP_OrderNumber = ""
ConectaProveedoresClientVariables.setInvoicesFCP_OrderNumber("");
// InvoicesFCP_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setInvoicesFCP_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// InvoicesFCP_TotalAmount = 0
ConectaProveedoresClientVariables.setInvoicesFCP_TotalAmount(0);
// InvoicesFCP_UploadDate = NullDate
ConectaProveedoresClientVariables.setInvoicesFCP_UploadDate(OS$BuiltinFunctions.nullDate());
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
span.setAttribute("outsystems.function.key", "c61a2c3d-e451-4a1c-afb8-85e42d4115f2");
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "ca0e17c8-756c-46aa-abc8-2ae26b9751ff");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetInvoicesFCP
var result = controller.getInvoicesFCP$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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

togglePopup$Action(ip_InvoiceIn, ip_Invoice_CNIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopup");
span.setAttribute("outsystems.function.key", "138e6915-232e-4f70-97eb-4d52cf709091");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopup$Action, callContext, ip_InvoiceIn, ip_Invoice_CNIn);
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
span.setAttribute("outsystems.function.key", "3da2680a-ecc1-4982-b2d5-260880bebc20");
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
span.setAttribute("outsystems.function.key", "4f95405e-b2b1-4318-b1ed-d2df98a9d8fe");
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

getInvoicesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesOnAfterFetch");
span.setAttribute("outsystems.function.key", "576d51db-bc92-4038-bfee-0fa2ab278385");
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

onClosePopup$Action(isSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClosePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClosePopup");
span.setAttribute("outsystems.function.key", "5aa21246-5a1c-45c8-ba39-cd34c966b67c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClosePopup$Action, callContext, isSaveIn);
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
span.setAttribute("outsystems.function.key", "808d9c9d-6851-42d7-a9ac-91bd357dec15");
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

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "a0e78549-429c-4e7d-b095-aa6a99c89cd2");
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
span.setAttribute("outsystems.function.key", "a4d112e6-60e4-4cfc-af9a-4c43b09e510f");
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

resetFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResetFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResetFilters");
span.setAttribute("outsystems.function.key", "b9f06030-dc93-4fdb-8722-1b59800f7030");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "c61a2c3d-e451-4a1c-afb8-85e42d4115f2");
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

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "ca0e17c8-756c-46aa-abc8-2ae26b9751ff");
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
return ConectaProveedores_d_Invoices_FCPController$default.handleError(ex, this.callContext());
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP$ActionInvoiceManualAccounting", [{
name: "Success",
attrName: "successOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return true;
}
}, {
name: "Message",
attrName: "messageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.TogglePopup$vars", [{
name: "ip_Invoice",
attrName: "ip_InvoiceInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "ip_Invoice_CN",
attrName: "ip_Invoice_CNInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.OnClosePopup$vars", [{
name: "IsSave",
attrName: "isSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "l_FormValid",
attrName: "l_FormValidVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices_FCP.InvoicesFCP.OnPaginationNavigate$vars", [{
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


