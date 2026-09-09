import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin, SE_orderStatus as ConectaProveedores_staticEntities_orderStatus } from "./ConectaProveedores.staticEntities.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_e_Orders_OrderDetail_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.OrderDetail.mvc$translationsResources.js";
import ConectaProveedores_e_OrdersController$default from "./ConectaProveedores.e_Orders.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_OrderDetail_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRejectComment$AggrRefresh: -1,
getOrdersByContractNumber$AggrRefresh: -1,
getOrderMainById$AggrRefresh: 0,
getSettings$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getRejectComment$AggrRefresh: [],
getOrdersByContractNumber$AggrRefresh: [],
getOrderMainById$AggrRefresh: ["getOrdersByContractNumber$AggrRefresh"],
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/e_Orders/OrderDetail/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getRejectComment$AggrRefresh() {if(!(this.hasOwnProperty("_getRejectComment$AggrRefresh"))) {
this._getRejectComment$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRejectComment", "screenservices/ConectaProveedores/e_Orders/OrderDetail/ScreenDataSetGetRejectComment", "kSrfER1EWt2N4ouy+vFO3w", maxRecords, startIndex, function (b) {
model.variables.getRejectCommentAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRejectCommentAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRejectCommentAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRejectComment", function (span) {
if(span) {
span.setAttribute("code.function", "GetRejectComment");
span.setAttribute("outsystems.function.key", "0ec3d5f3-1ccf-4165-be14-4a9e7874fce0");
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

return this._getRejectComment$AggrRefresh;
}set getRejectComment$AggrRefresh(value) {this._getRejectComment$AggrRefresh = value;
}

get getOrdersByContractNumber$AggrRefresh() {if(!(this.hasOwnProperty("_getOrdersByContractNumber$AggrRefresh"))) {
this._getOrdersByContractNumber$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrdersByContractNumber", "screenservices/ConectaProveedores/e_Orders/OrderDetail/ScreenDataSetGetOrdersByContractNumber", "9IY714ivHHJPGA70NCBs5g", maxRecords, startIndex, function (b) {
model.variables.getOrdersByContractNumberAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrdersByContractNumberAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrdersByContractNumberAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrdersByContractNumber", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrdersByContractNumber");
span.setAttribute("outsystems.function.key", "45ed6cf1-f819-4b70-9d7c-37a7d0374ae0");
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

return this._getOrdersByContractNumber$AggrRefresh;
}set getOrdersByContractNumber$AggrRefresh(value) {this._getOrdersByContractNumber$AggrRefresh = value;
}

get getOrderMainById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainById$AggrRefresh"))) {
this._getOrderMainById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainById", "screenservices/ConectaProveedores/e_Orders/OrderDetail/ScreenDataSetGetOrderMainById", "VGBFEm0efhCiTwokxCmF0Q", maxRecords, startIndex, function (b) {
model.variables.getOrderMainByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderMainByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainById");
span.setAttribute("outsystems.function.key", "ddca47bf-9720-4366-960a-7b2db030fd7e");
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

return this._getOrderMainById$AggrRefresh;
}set getOrderMainById$AggrRefresh(value) {this._getOrderMainById$AggrRefresh = value;
}

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/e_Orders/OrderDetail/DataActionGetSettings", "bC78gmCKDDEz1pDpYZrGcw", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "2f7ffc95-9807-4551-a6fa-95f7f16406f6");
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
this._dataFetchActionNames = ["getRejectComment$AggrRefresh", "getOrdersByContractNumber$AggrRefresh", "getOrderMainById$AggrRefresh", "getSettings$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "19585603-0617-420e-a084-37fb33b6df96");
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
rec.identifierAttr = model.variables.i_OrderIdIn;
rec.messageAttr = "";
rec.screenAttr = "FcP - Order Detail";
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
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "445856f2-02b1-46ea-9c4a-98d4237d41f2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.OrderDetail.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
// l_ActiveTab = ActiveTab
model.variables.l_ActiveTabVar = vars.value.activeTabInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_SearchSupplierForOrderEvent$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchSupplierForOrderEvent", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchSupplierForOrderEvent");
span.setAttribute("outsystems.function.key", "5d6f5749-77b7-4597-8e93-f6645315d57a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SearchSupplierForOrderEvent");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openSidebarOnClick$Action(isHistoricIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenSidebarOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "OpenSidebarOnClick");
span.setAttribute("outsystems.function.key", "7ce43ae2-27b9-44fe-8e81-4e4af4d0a659");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenSidebarOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.OrderDetail.OpenSidebarOnClick$vars"))());
vars.value.isHistoricInLocal = isHistoricIn;
var sidebarOpenVar = new OS$DataTypes.VariableHolder();
// l_RefreshSideBar = CurrDateTime
model.variables.l_RefreshSideBarVar = OS$BuiltinFunctions.currDateTime();
// IsShowHistoric = IsHistoric
model.variables.isShowHistoricVar = vars.value.isHistoricInLocal;
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
_wB_OrderFinancialFilesRefresh2$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("WB_OrderFinancialFilesRefresh2", function (span) {
if(span) {
span.setAttribute("code.function", "WB_OrderFinancialFilesRefresh2");
span.setAttribute("outsystems.function.key", "a397baca-c7bb-4d3d-9aa7-94e7667d8ee3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("WB_OrderFinancialFilesRefresh2");
callContext = controller.callContext(callContext);
// l_ForceRefresh = CurrDateTime
model.variables.l_ForceRefreshVar = OS$BuiltinFunctions.currDateTime();
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderMainByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "abfaf025-5c9b-4951-b82f-e3868eb914fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderMainByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: LogMessage
OS$SystemActions.logMessage(OS$BuiltinFunctions.longIntegerToText(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.idAttr), "OAL Id", callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.getOrderMainByIdAggr.listOut.isEmpty)) {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Refresh Query: GetOrdersByContractNumber
var result = controller.getOrdersByContractNumber$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
// ApprovalRejected?
return OS$Flow.executeSequence(function () {
if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approvalRejected))) {
// Refresh Query: GetRejectComment
var result = controller.getRejectComment$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}

});
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
_showHideOrderReject_Popup$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideOrderReject_Popup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideOrderReject_Popup");
span.setAttribute("outsystems.function.key", "c796a7dc-4428-4418-9033-bf54e2d528f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideOrderReject_Popup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.OrderDetail.ShowHideOrderReject_Popup$vars"))());
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
// ShowOrderReject_Popup = notShowOrderReject_Popup
model.variables.showOrderReject_PopupVar = (!(model.variables.showOrderReject_PopupVar));
if((vars.value.i_IsRefreshInLocal)) {
// Destination: /ConectaProveedores/OrderDetail
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
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
span.setAttribute("outsystems.function.key", "d07020cd-53ef-4684-990c-0d44b5f0d780");
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "19585603-0617-420e-a084-37fb33b6df96");
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

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "445856f2-02b1-46ea-9c4a-98d4237d41f2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._tabsOnTabChange$Action, callContext, activeTabIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_SearchSupplierForOrderEvent$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchSupplierForOrderEvent__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchSupplierForOrderEvent");
span.setAttribute("outsystems.function.key", "5d6f5749-77b7-4597-8e93-f6645315d57a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SearchSupplierForOrderEvent$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openSidebarOnClick$Action(isHistoricIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenSidebarOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenSidebarOnClick");
span.setAttribute("outsystems.function.key", "7ce43ae2-27b9-44fe-8e81-4e4af4d0a659");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openSidebarOnClick$Action, callContext, isHistoricIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wB_OrderFinancialFilesRefresh2$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("WB_OrderFinancialFilesRefresh2__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "WB_OrderFinancialFilesRefresh2");
span.setAttribute("outsystems.function.key", "a397baca-c7bb-4d3d-9aa7-94e7667d8ee3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wB_OrderFinancialFilesRefresh2$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderMainByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "abfaf025-5c9b-4951-b82f-e3868eb914fa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderMainByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showHideOrderReject_Popup$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideOrderReject_Popup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideOrderReject_Popup");
span.setAttribute("outsystems.function.key", "c796a7dc-4428-4418-9033-bf54e2d528f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideOrderReject_Popup$Action, callContext, i_IsRefreshIn);
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
span.setAttribute("outsystems.function.key", "d07020cd-53ef-4684-990c-0d44b5f0d780");
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
return ConectaProveedores_e_OrdersController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ConectaProveedores, ConectaProveedoresController$default.roles.Pedidos, ConectaProveedoresController$default.roles.Requisiciones, ConectaProveedoresController$default.roles.Proveedor]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.OrderDetail.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.OrderDetail.OpenSidebarOnClick$vars", [{
name: "IsHistoric",
attrName: "isHistoricInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.OrderDetail.ShowHideOrderReject_Popup$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


