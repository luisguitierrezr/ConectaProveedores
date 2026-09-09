import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, Authorization as OS$Authorization, GenericTypeCache as OS$GenericTypeCache, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_NewFolioSAE_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.NewFolioSAE.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";
import { ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_NewFolioSAE_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getCompanies$AggrRefresh: 0,
gerOrderByOrderNumber$AggrRefresh: -1,
getOrderMainItems$DataActRefresh: -1,
getOrders$DataActRefresh: 0,
getApplicantType$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getCompanies$AggrRefresh: [],
gerOrderByOrderNumber$AggrRefresh: ["getApplicantType$DataActRefresh"],
getOrderMainItems$DataActRefresh: [],
getOrders$DataActRefresh: [],
getApplicantType$DataActRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE/ScreenDataSetGetCompanies", "dUlLiZXilCXZfHjYY_ZYJg", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "22dde57d-3130-49ea-9c99-dfc550b3be13");
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

get gerOrderByOrderNumber$AggrRefresh() {if(!(this.hasOwnProperty("_gerOrderByOrderNumber$AggrRefresh"))) {
this._gerOrderByOrderNumber$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGerOrderByOrderNumber", "screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE/ScreenDataSetGerOrderByOrderNumber", "NhjoafPA4q7mcxB_zjErLw", maxRecords, startIndex, function (b) {
model.variables.gerOrderByOrderNumberAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.gerOrderByOrderNumberAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.gerOrderByOrderNumberAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GerOrderByOrderNumber", function (span) {
if(span) {
span.setAttribute("code.function", "GerOrderByOrderNumber");
span.setAttribute("outsystems.function.key", "9a31c4e6-c75f-4929-91ff-c59e281cfb4c");
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

return this._gerOrderByOrderNumber$AggrRefresh;
}set gerOrderByOrderNumber$AggrRefresh(value) {this._gerOrderByOrderNumber$AggrRefresh = value;
}

get getOrderMainItems$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderMainItems$DataActRefresh"))) {
this._getOrderMainItems$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderMainItems", "screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE/DataActionGetOrderMainItems", "nMYKJY2YKAefA8NljSFLTw", function (b) {
model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainItemsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainItemsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getOrderMainItemsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainItems", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItems");
span.setAttribute("outsystems.function.key", "1c40205d-5039-4184-9f48-6d0d1e530aeb");
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

return this._getOrderMainItems$DataActRefresh;
}set getOrderMainItems$DataActRefresh(value) {this._getOrderMainItems$DataActRefresh = value;
}

get getOrders$DataActRefresh() {if(!(this.hasOwnProperty("_getOrders$DataActRefresh"))) {
this._getOrders$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrders", "screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE/DataActionGetOrders", "nztVnJ1rATlUhtCef4c5Yg", function (b) {
model.variables.getOrdersDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrdersDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrdersDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrders", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrders");
span.setAttribute("outsystems.function.key", "79f96118-ec4f-4ec3-bc44-dd71a6c7bb6f");
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

return this._getOrders$DataActRefresh;
}set getOrders$DataActRefresh(value) {this._getOrders$DataActRefresh = value;
}

get getApplicantType$DataActRefresh() {if(!(this.hasOwnProperty("_getApplicantType$DataActRefresh"))) {
this._getApplicantType$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApplicantType", "screenservices/ConectaProveedores/j_FoliosSAE/NewFolioSAE/DataActionGetApplicantType", "PBHdt_0fOIvYzJzwvoc4tQ", function (b) {
model.variables.getApplicantTypeDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApplicantTypeDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApplicantTypeDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApplicantType", function (span) {
if(span) {
span.setAttribute("code.function", "GetApplicantType");
span.setAttribute("outsystems.function.key", "91ea3ec9-4648-461e-b0e5-ee4fa614036f");
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

return this._getApplicantType$DataActRefresh;
}set getApplicantType$DataActRefresh(value) {this._getApplicantType$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getCompanies$AggrRefresh", "gerOrderByOrderNumber$AggrRefresh", "getOrderMainItems$DataActRefresh", "getOrders$DataActRefresh", "getApplicantType$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_checkboxIsSelectAllOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckboxIsSelectAllOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectAllOnChange");
span.setAttribute("outsystems.function.key", "02cde249-f4f5-4465-af3b-695142059b79");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckboxIsSelectAllOnChange");
callContext = controller.callContext(callContext);
// Foreach GetOrderMainItems.List
callContext.iterationContext.registerIterationStart(model.variables.getOrderMainItemsDataAct.listOut);
try {var listIterator = callContext.iterationContext.getIterator(model.variables.getOrderMainItemsDataAct.listOut);
var listIndex = 0;
while (((listIndex < model.variables.getOrderMainItemsDataAct.listOut.length))) {
listIterator.currentRowNumber = listIndex;
// GetOrderMainItems.List.Current.Select = If
model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).selectAttr = (((((model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).isDeletedAttr === false)) && (model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).isBlockedAttr === false)) && (model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).isFinalDeliveredAttr === false))) ? (model.variables.l_IsSelectAllVar) : (false));
listIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getOrderMainItemsDataAct.listOut);
}

if((!(model.variables.l_IsSelectAllVar))) {
// IsSelected = False
model.variables.isSelectedVar = false;
}

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
span.setAttribute("outsystems.function.key", "412192af-bed5-4c0e-a419-ee708d1b068d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
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
_setStep$Action(i_StepIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetStep", function (span) {
if(span) {
span.setAttribute("code.function", "SetStep");
span.setAttribute("outsystems.function.key", "4ef1c058-54e7-4ad1-bd02-006379171a3c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetStep");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.SetStep$vars"))());
vars.value.i_StepInLocal = i_StepIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
if((!(((vars.value.i_StepInLocal === 2) && model.variables.l_OrderIdSelectedVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesVar);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesVar);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesVar.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// GetOrderMainItems.List.Current.Select = False
model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).selectAttr = false;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesVar);
}

// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getOrderMainItemsDataAct.listOut, function (p) {
return model.variables.isSelectedVar;
}, callContext);

if((!(((vars.value.i_StepInLocal === 3) && (model.variables.l_OrderIdSelectedVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || listFilterVar.value.filteredListOut.isEmpty))))) {
// l_Step = i_Step
model.variables.l_StepVar = vars.value.i_StepInLocal;
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
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
_addToRequestOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddToRequestOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "AddToRequestOnClick");
span.setAttribute("outsystems.function.key", "7453ce23-7f49-43c0-8a63-4bc092be10c8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AddToRequestOnClick");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.localSelectedLinesVar, callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getOrderMainItemsDataAct.listOut, function (p) {
return p.selectAttr;
}, callContext);

if((!(listFilterVar.value.filteredListOut.isEmpty))) {
// l_Step = 3
model.variables.l_StepVar = 3;
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.localSelectedLinesVar, OS$DataConversion.JSConversions.typeConvertRecordList(listFilterVar.value.filteredListOut, new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))(), function (source, target) {
target.orderMainIdAttr = source.orderMainItemIdAttr;
target.positionAttr = source.positionAttr;
target.orderNumberAttr = source.orderNumberAttr;
target.articleNumberAttr = source.materialCodeAttr;
target.descriptionAttr = source.materialDescriptionAttr;
target.inputationCodeAttr = source.assigmentCodeAttr;
target.deliveryDateAttr = OS$BuiltinFunctions.nullDate();
target.invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
target.remainingQttAttr = source.quantityAvailableAttr;
target.unitPriceAttr = source.unitPriceAttr;
target.totalPriceAttr = OS$BuiltinFunctions.integerToDecimal(0);
target.quantityAttr = source.quantityAttr;
target.deliveryQttAttr = OS$BuiltinFunctions.decimalToText(source.quantityDeliveredAttr);
target.importdeliveryAttr = source.importDeliveredAttr;
target.isInvoiceErrorAttr = false;
target.isDateErrorAttr = false;
target.isPEPErrorAttr = false;
target.pEPAttr = source.pEPAttr;
target.baseQuantityAttr = source.baseQuantityAttr;
target.vatRateAttr = source.vATRateAttr;
target.isMultipleImputationAttr = source.isMultipleImputationAttr;
return target;
}), callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderMainItemsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "7bde23c3-97b3-4a85-b41d-e7a23557d62f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetOrderMainItemsOnAfterFetch");
callContext = controller.callContext(callContext);
var listIndexOfVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getOrderMainItemsDataAct.listOut, function (p) {
return (((p.quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (p.isDeletedAttr === false)) && (p.isBlockedAttr === false)) && (p.isFinalDeliveredAttr === false));
}, callContext);

// l_IsShowSelectAll = ListIndexOf.Position <> -1
model.variables.l_IsShowSelectAllVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_checkboxIsSelectedOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckboxIsSelectedOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectedOnChange");
span.setAttribute("outsystems.function.key", "7e0d94af-c6f1-44e8-94f9-a272654b287a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CheckboxIsSelectedOnChange");
callContext = controller.callContext(callContext);
var listIndexOfVar = new OS$DataTypes.VariableHolder();
var listIndexOfSelectedVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getOrderMainItemsDataAct.listOut, function (p) {
return ((((p.quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (p.isDeletedAttr === false)) && (p.isBlockedAttr === false)) && (p.isFinalDeliveredAttr === false)) && (!(p.selectAttr)));
}, callContext);

// l_IsSelectAll = ListIndexOf.Position = -1
model.variables.l_IsSelectAllVar = (listIndexOfVar.value.positionOut === (-1));
// Execute Action: ListIndexOfSelected
listIndexOfSelectedVar.value = OS$SystemActions.listIndexOf(model.variables.getOrderMainItemsDataAct.listOut, function (p) {
return p.selectAttr;
}, callContext);

// IsSelected = ListIndexOfSelected.Position <> -1
model.variables.isSelectedVar = ((listIndexOfSelectedVar.value.positionOut) !== ((-1)));
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
span.setAttribute("outsystems.function.key", "8939fb9f-dbf1-4790-a693-46803840adca");
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
rec.screenAttr = "New Folio SAE";
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
_filtersChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("FiltersChange", function (span) {
if(span) {
span.setAttribute("code.function", "FiltersChange");
span.setAttribute("outsystems.function.key", "b6763c3a-6ee0-42e0-bad7-12515c200d93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("FiltersChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// IsSelected = False
model.variables.isSelectedVar = false;
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// Refresh Query: GetOrderMainItems
var result = controller.getOrderMainItems$DataActRefresh(callContext);
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
_refreshList$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "b9f7157b-c462-4559-8de5-2b67a088e743");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result.then(function () {
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
_selectOrder$Action(i_OrderMainIdIn, i_OrderIdNumberSelectedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectOrder", function (span) {
if(span) {
span.setAttribute("code.function", "SelectOrder");
span.setAttribute("outsystems.function.key", "f85493a1-f878-4d1a-93aa-819426be9085");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SelectOrder");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.SelectOrder$vars"))());
vars.value.i_OrderMainIdInLocal = i_OrderMainIdIn;
vars.value.i_OrderIdNumberSelectedInLocal = i_OrderIdNumberSelectedIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_OrderIdSelected = i_OrderMainId
model.variables.l_OrderIdSelectedVar = vars.value.i_OrderMainIdInLocal;
// l_Step = 2
model.variables.l_StepVar = 2;
// l_OrderIdNumberSelected = i_OrderIdNumberSelected
model.variables.l_OrderIdNumberSelectedVar = vars.value.i_OrderIdNumberSelectedInLocal;
return OS$Flow.executeSequence(function () {
if(((OS$BuiltinFunctions.trim(vars.value.i_OrderIdNumberSelectedInLocal) === ""))) {
// Raise Error: EntityException
throw new OS$Exceptions.Exceptions.UserException("ConectaProveedores.EntityException", OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GXrqHoB380OzTOPFiVZlrg#Message.976747601.1", "No order Found"));
} else {
// Refresh Query: GerOrderByOrderNumber
var result = controller.gerOrderByOrderNumber$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetApplicantType
var result = controller.getApplicantType$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetOrderMainItems
var result = controller.getOrderMainItems$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "ffbcc858-9e09-4db3-968e-acefca74cafc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((!((vars.value.sortByInLocal === "")))) {
// SortBy = OrderNumber
return OS$Flow.executeSequence(function () {
if(((vars.value.sortByInLocal === "OrderMain.OrderNumber"))) {
if(((model.variables.tableSortVar === "{OrderMain}.[OrderNumber] DESC"))) {
// "ASC"
// TableSort = "{OrderMain}.[OrderNumber] ASC"
model.variables.tableSortVar = "{OrderMain}.[OrderNumber] ASC";
} else {
// "DESC"
// TableSort = "{OrderMain}.[OrderNumber] DESC"
model.variables.tableSortVar = "{OrderMain}.[OrderNumber] DESC";
// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
}

// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
} else {
// SortBy = CompanyDescription
return OS$Flow.executeSequence(function () {
if(((vars.value.sortByInLocal === "Company.Description"))) {
if(((model.variables.tableSortVar === "{Company}.[Description] DESC"))) {
// "ASC"
// TableSort = "{Company}.[Description] ASC"
model.variables.tableSortVar = "{Company}.[Description] ASC";
} else {
// "DESC"
// TableSort = "{Company}.[Description] DESC"
model.variables.tableSortVar = "{Company}.[Description] DESC";
// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
}

// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
} else {
// SortBy = OrderStatusLabel
return OS$Flow.executeSequence(function () {
if(((vars.value.sortByInLocal === "OrderStatus.Label"))) {
if(((model.variables.tableSortVar === "{OrderStatus}.[Label] DESC"))) {
// "ASC"
// TableSort = "{OrderStatus}.[Label] ASC"
model.variables.tableSortVar = "{OrderStatus}.[Label] ASC";
} else {
// "DESC"
// TableSort = "{OrderStatus}.[Label] DESC"
model.variables.tableSortVar = "{OrderStatus}.[Label] DESC";
// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
}

// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
} else {
// SortBy = CurrencyName
return OS$Flow.executeSequence(function () {
if(((vars.value.sortByInLocal === "Currency.Name"))) {
if(((model.variables.tableSortVar === "{Currency}.[Name] DESC"))) {
// "ASC"
// TableSort = "{Currency}.[Name] ASC"
model.variables.tableSortVar = "{Currency}.[Name] ASC";
} else {
// "DESC"
// TableSort = "{Currency}.[Name] DESC"
model.variables.tableSortVar = "{Currency}.[Name] DESC";
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
} else {
// SortBy = OrderDate
return OS$Flow.executeSequence(function () {
if(((vars.value.sortByInLocal === "OrderMain.OrderDate"))) {
if(((model.variables.tableSortVar === "{OrderMain}.[OrderDate] DESC"))) {
// "ASC"
// TableSort = "{OrderMain}.[OrderDate] ASC"
model.variables.tableSortVar = "{OrderMain}.[OrderDate] ASC";
} else {
// "DESC"
// TableSort = "{OrderMain}.[OrderDate] DESC"
model.variables.tableSortVar = "{OrderMain}.[OrderDate] DESC";
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
} else {
// SortBy = QuantidadeTotal.Value
return OS$Flow.executeSequence(function () {
if(((vars.value.sortByInLocal === "OrderMain.TotalAmount"))) {
if(((model.variables.tableSortVar === "{OrderMain}.[TotalAmount] DESC"))) {
// "ASC"
// TableSort = "{OrderMain}.[TotalAmount] ASC"
model.variables.tableSortVar = "{OrderMain}.[TotalAmount] ASC";
} else {
// "DESC"
// TableSort = "{OrderMain}.[TotalAmount] DESC"
model.variables.tableSortVar = "{OrderMain}.[TotalAmount] DESC";
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
} else {
// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetOrders
var result = controller.getOrders$DataActRefresh(callContext);
model.flush();
return result;
}

});
}

});
}

});
}

});
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

checkboxIsSelectAllOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckboxIsSelectAllOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectAllOnChange");
span.setAttribute("outsystems.function.key", "02cde249-f4f5-4465-af3b-695142059b79");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkboxIsSelectAllOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "412192af-bed5-4c0e-a419-ee708d1b068d");
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

setStep$Action(i_StepIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetStep__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetStep");
span.setAttribute("outsystems.function.key", "4ef1c058-54e7-4ad1-bd02-006379171a3c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setStep$Action, callContext, i_StepIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

addToRequestOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddToRequestOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddToRequestOnClick");
span.setAttribute("outsystems.function.key", "7453ce23-7f49-43c0-8a63-4bc092be10c8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._addToRequestOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderMainItemsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "7bde23c3-97b3-4a85-b41d-e7a23557d62f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getOrderMainItemsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

checkboxIsSelectedOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckboxIsSelectedOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectedOnChange");
span.setAttribute("outsystems.function.key", "7e0d94af-c6f1-44e8-94f9-a272654b287a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkboxIsSelectedOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "8939fb9f-dbf1-4790-a693-46803840adca");
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

filtersChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FiltersChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FiltersChange");
span.setAttribute("outsystems.function.key", "b6763c3a-6ee0-42e0-bad7-12515c200d93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._filtersChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

refreshList$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "b9f7157b-c462-4559-8de5-2b67a088e743");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refreshList$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

selectOrder$Action(i_OrderMainIdIn, i_OrderIdNumberSelectedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectOrder__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectOrder");
span.setAttribute("outsystems.function.key", "f85493a1-f878-4d1a-93aa-819426be9085");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._selectOrder$Action, callContext, i_OrderMainIdIn, i_OrderIdNumberSelectedIn);
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
span.setAttribute("outsystems.function.key", "ffbcc858-9e09-4db3-968e-acefca74cafc");
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
roles: [ConectaProveedoresController$default.roles.Proveedor, ConectaProveedoresController$default.roles.Folios]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.SetStep$vars", [{
name: "i_Step",
attrName: "i_StepInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.SelectOrder$vars", [{
name: "i_OrderMainId",
attrName: "i_OrderMainIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_OrderIdNumberSelected",
attrName: "i_OrderIdNumberSelectedInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewFolioSAE.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


