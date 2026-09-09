import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, Authorization as OS$Authorization, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_j_FoliosSAE_EditFolioSAE_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.EditFolioSAE.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_EditFolioSAE_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioById$AggrRefresh: 0,
getFolioItemsByFolioId$AggrRefresh: -1,
getOrderMainItems$DataActRefresh: -1,
getSettings$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFolioById$AggrRefresh: [],
getFolioItemsByFolioId$AggrRefresh: [],
getOrderMainItems$DataActRefresh: [],
getSettings$DataActRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/EditFolioSAE/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/EditFolioSAE/ScreenDataSetGetFolioById", "uRcOJN1T+1Y2nTASaCAA_w", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getFolioByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "51e42c50-cfee-4dc1-a09b-dc6b01e20592");
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

get getFolioItemsByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioItemsByFolioId$AggrRefresh"))) {
this._getFolioItemsByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioItemsByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/EditFolioSAE/ScreenDataSetGetFolioItemsByFolioId", "3hWkR5MZcJ0XElZpxxi9+Q", maxRecords, startIndex, function (b) {
model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioItemsByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioItemsByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getFolioItemsByFolioIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioItemsByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioId");
span.setAttribute("outsystems.function.key", "94d2bb1d-2904-485e-a2ae-3bfbd5b8e79e");
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

get getOrderMainItems$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderMainItems$DataActRefresh"))) {
this._getOrderMainItems$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderMainItems", "screenservices/ConectaProveedores/j_FoliosSAE/EditFolioSAE/DataActionGetOrderMainItems", "nMYKJY2YKAefA8NljSFLTw", function (b) {
model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainItemsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainItemsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderMainItemsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainItems", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItems");
span.setAttribute("outsystems.function.key", "01ae4064-6f99-4e6c-a8db-f25301335a29");
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

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/EditFolioSAE/DataActionGetSettings", "r35x3kNoc8QS20hnRywXYw", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "8e704df4-eeba-4dc6-a6b5-d5bf339cbb0f");
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

return this._getSettings$DataActRefresh;
}set getSettings$DataActRefresh(value) {this._getSettings$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioById$AggrRefresh", "getFolioItemsByFolioId$AggrRefresh", "getOrderMainItems$DataActRefresh", "getSettings$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1316665f-505e-480d-a6e9-30579fb92fbd");
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
rec.identifierAttr = model.variables.folioIdIn;
rec.messageAttr = "";
rec.screenAttr = "Edit Folio SAE";
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
_getFolioByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "36bcbc2d-9ce2-4509-9457-0da54871d195");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetFolioByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_OrderIdSelected = GetFolioById.List.Current.OrderMain.Id
model.variables.l_OrderIdSelectedVar = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr;
// l_OrderIdNumberSelected = GetFolioById.List.Current.OrderMain.OrderNumber
model.variables.l_OrderIdNumberSelectedVar = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr;
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
_checkboxIsSelectedOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckboxIsSelectedOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectedOnChange");
span.setAttribute("outsystems.function.key", "635b4eb7-dd25-4ce0-9e2d-71014d7c3460");
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
return (((p.quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (p.isDeletedAttr === false)) && (p.isBlockedAttr === false)) && (!(p.selectAttr)));
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
_cancelOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "66cd93b6-8bf9-4105-a838-5a1cc3a6ac64");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CancelOnClick");
callContext = controller.callContext(callContext);
// ShowPopup = False
model.variables.showPopupVar = false;
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "69329e1b-fe6a-4a45-8d80-ee6635b4a229");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetStep");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.EditFolioSAE.SetStep$vars"))());
vars.value.i_StepInLocal = i_StepIn;
if((!(((vars.value.i_StepInLocal === 2) && model.variables.l_OrderIdSelectedVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
if((!(((vars.value.i_StepInLocal === 3) && model.variables.l_OrderIdSelectedVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
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
_getOrderMainItemsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "7272407f-2d90-4b14-94cc-09fe990de9b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderMainItemsOnAfterFetch");
callContext = controller.callContext(callContext);
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getOrderMainItemsDataAct.listOut, function (p) {
return ((p.quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (p.isDeletedAttr === false)) && (p.isBlockedAttr === false));
}, callContext);

// l_IsShowSelectAll = ListIndexOf.Position <> -1
model.variables.l_IsShowSelectAllVar = ((listIndexOfVar.value.positionOut) !== ((-1)));
// Refresh Query: GetFolioItemsByFolioId
var result = controller.getFolioItemsByFolioId$AggrRefresh(999999999, 0, callContext);
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
_getFolioItemsByFolioIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioItemsByFolioIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "76c7b8ac-423e-4a7f-9e3b-cae4964de08d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetFolioItemsByFolioIdOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Foreach GetOrderMainItems.List
callContext.iterationContext.registerIterationStart(model.variables.getOrderMainItemsDataAct.listOut);
try {var listIterator = callContext.iterationContext.getIterator(model.variables.getOrderMainItemsDataAct.listOut);
var listIndex = 0;
while (((listIndex < model.variables.getOrderMainItemsDataAct.listOut.length))) {
listIterator.currentRowNumber = listIndex;
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getFolioItemsByFolioIdAggr.listOut, function (p) {
return p.folioItemsAttr.orderMainItemIdAttr.equals(model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).orderMainItemIdAttr);
}, callContext);

// GetOrderMainItems.List.Current.Select = notListFilter.FilteredList.Empty
model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).selectAttr = (!(listFilterVar.value.filteredListOut.isEmpty));
listIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getOrderMainItemsDataAct.listOut);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_yesOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("YesOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "YesOnClick");
span.setAttribute("outsystems.function.key", "dbe3e117-ea4d-4ebb-afc6-11b4d5ae980b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("YesOnClick");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_checkboxIsSelectAllOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckboxIsSelectAllOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectAllOnChange");
span.setAttribute("outsystems.function.key", "e13b4c5c-3570-46f2-906e-a5762b9d9458");
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
model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).selectAttr = ((((model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).isDeletedAttr === false)) && (model.variables.getOrderMainItemsDataAct.listOut.getItem(listIndex.valueOf()).isBlockedAttr === false))) ? (model.variables.l_IsSelectAllVar) : (false));
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
_addToRequestOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddToRequestOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "AddToRequestOnClick");
span.setAttribute("outsystems.function.key", "f42e6cec-9c7d-4c27-b1ac-c62211c8a877");
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
// l_Step = 2
model.variables.l_StepVar = 2;
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "1316665f-505e-480d-a6e9-30579fb92fbd");
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
span.setAttribute("outsystems.function.key", "36bcbc2d-9ce2-4509-9457-0da54871d195");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getFolioByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

checkboxIsSelectedOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckboxIsSelectedOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectedOnChange");
span.setAttribute("outsystems.function.key", "635b4eb7-dd25-4ce0-9e2d-71014d7c3460");
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

cancelOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "66cd93b6-8bf9-4105-a838-5a1cc3a6ac64");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._cancelOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

setStep$Action(i_StepIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetStep__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetStep");
span.setAttribute("outsystems.function.key", "69329e1b-fe6a-4a45-8d80-ee6635b4a229");
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

getOrderMainItemsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainItemsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsOnAfterFetch");
span.setAttribute("outsystems.function.key", "7272407f-2d90-4b14-94cc-09fe990de9b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderMainItemsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getFolioItemsByFolioIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioItemsByFolioIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioItemsByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "76c7b8ac-423e-4a7f-9e3b-cae4964de08d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getFolioItemsByFolioIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

yesOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("YesOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "YesOnClick");
span.setAttribute("outsystems.function.key", "dbe3e117-ea4d-4ebb-afc6-11b4d5ae980b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._yesOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

checkboxIsSelectAllOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckboxIsSelectAllOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckboxIsSelectAllOnChange");
span.setAttribute("outsystems.function.key", "e13b4c5c-3570-46f2-906e-a5762b9d9458");
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

addToRequestOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddToRequestOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddToRequestOnClick");
span.setAttribute("outsystems.function.key", "f42e6cec-9c7d-4c27-b1ac-c62211c8a877");
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
roles: [ConectaProveedoresController$default.roles.Folios, ConectaProveedoresController$default.roles.Proveedor]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.EditFolioSAE.SetStep$vars", [{
name: "i_Step",
attrName: "i_StepInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


