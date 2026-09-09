import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_mvc_TranslationsResources from "./ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.mvc$translationsResources.js";
import { ST_9f3831cec6ebd34416b59b8df7a27893Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getOrderDistributionConfig$AggrRefresh: 0,
getRegions$AggrRefresh: 0,
getOrderMainDataOnInput$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getOrderDistributionConfig$AggrRefresh: [],
getRegions$AggrRefresh: [],
getOrderMainDataOnInput$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
ordersDistribution_Assignment$ServerAction(orderDistributionConfigIdIn, orderMainIdIn, sendEmailsIn, updateOrderIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OrdersDistribution_Assignment", function (span) {
if(span) {
span.setAttribute("code.function", "OrdersDistribution_Assignment");
span.setAttribute("outsystems.function.key", "7fc6d530-f324-4efd-bed6-89a6d2f09630");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
OrderDistributionConfigId: OS$DataConversion.ServerDataConverter.to(orderDistributionConfigIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OrderMainId: OS$DataConversion.ServerDataConverter.to(orderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
SendEmails: OS$DataConversion.ServerDataConverter.to(sendEmailsIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
UpdateOrder: OS$DataConversion.ServerDataConverter.to(updateOrderIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("OrdersDistribution_Assignment", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_OrderDistributionConfig/ActionOrdersDistribution_Assignment", "BbFlnstVCn+Iyp_+kPEmww", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig$ActionOrdersDistribution_Assignment"))();
executeServerActionResult.resultOut = OS$DataConversion.ServerDataConverter.from(outputs.Result, ST_9f3831cec6ebd34416b59b8df7a27893Structure);
executeServerActionResult.positionFirstContactIdOut = OS$DataConversion.ServerDataConverter.from(outputs.PositionFirstContactId, OS$DataTypes.DataTypes.LongInteger);
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
get getOrderDistributionConfig$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderDistributionConfig$AggrRefresh"))) {
this._getOrderDistributionConfig$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderDistributionConfig", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_OrderDistributionConfig/ScreenDataSetGetOrderDistributionConfig", "3dBGiIBwfmo1x2fFgjC47w", maxRecords, startIndex, function (b) {
model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderDistributionConfigAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderDistributionConfigAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderDistributionConfig", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDistributionConfig");
span.setAttribute("outsystems.function.key", "6880cc18-da77-4ac3-a87d-aaa2dad191d5");
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

return this._getOrderDistributionConfig$AggrRefresh;
}set getOrderDistributionConfig$AggrRefresh(value) {this._getOrderDistributionConfig$AggrRefresh = value;
}

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_OrderDistributionConfig/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "f55febcb-3a09-4c43-acc7-46dd4945525a");
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

get getOrderMainDataOnInput$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderMainDataOnInput$DataActRefresh"))) {
this._getOrderMainDataOnInput$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderMainDataOnInput", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_OrderDistributionConfig/DataActionGetOrderMainDataOnInput", "MmvKChJ+B6EcyDwhnEWisQ", function (b) {
model.variables.getOrderMainDataOnInputDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainDataOnInputDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainDataOnInputDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderMainDataOnInputOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainDataOnInput", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainDataOnInput");
span.setAttribute("outsystems.function.key", "7fb8d008-c676-4928-9e1a-7082226725a4");
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

return this._getOrderMainDataOnInput$DataActRefresh;
}set getOrderMainDataOnInput$DataActRefresh(value) {this._getOrderMainDataOnInput$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getOrderDistributionConfig$AggrRefresh", "getRegions$AggrRefresh", "getOrderMainDataOnInput$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "1fbc51c3-e471-4845-8fad-831bbe110330");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetOrderDistributionConfig
var result = controller.getOrderDistributionConfig$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_datePickerOnClick$Action(datePickerIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnClick");
span.setAttribute("outsystems.function.key", "233d4d3c-c9fd-435a-b042-b5f0caca77f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.DatePickerOnClick$vars"))());
vars.value.datePickerIdInLocal = datePickerIdIn;
var datePickerOpenPaymentDateVar = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerOpenPaymentDate
datePickerOpenPaymentDateVar.value = OutSystemsUIController$datePickerOpen$Action(vars.value.datePickerIdInLocal, callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_togglePopupConfirmation$Action(toStore_RequestDistributionConfigIdIn, toStore_OrderMainIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupConfirmation", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupConfirmation");
span.setAttribute("outsystems.function.key", "47277e4e-2f13-4e12-ab0d-e526986f2eac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TogglePopupConfirmation");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.TogglePopupConfirmation$vars"))());
vars.value.toStore_RequestDistributionConfigIdInLocal = toStore_RequestDistributionConfigIdIn;
vars.value.toStore_OrderMainIdInLocal = toStore_OrderMainIdIn;
// IsOpenPopupConfirmation = notIsOpenPopupConfirmation
model.variables.isOpenPopupConfirmationVar = (!(model.variables.isOpenPopupConfirmationVar));
// RequestDistributionConfigId_ToSave = ToStore_RequestDistributionConfigId
model.variables.requestDistributionConfigId_ToSaveVar = vars.value.toStore_RequestDistributionConfigIdInLocal;
// OrderMainId_ToSave = ToStore_OrderMainId
model.variables.orderMainId_ToSaveVar = vars.value.toStore_OrderMainIdInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_confirmOnClick$Action(i_RequestDistributionConfigIdIn, i_OrderMainIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ConfirmOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "71f3f236-ba18-4d74-b81d-c7ce30fe4866");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ConfirmOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.ConfirmOnClick$vars"))());
vars.value.i_RequestDistributionConfigIdInLocal = i_RequestDistributionConfigIdIn;
vars.value.i_OrderMainIdInLocal = i_OrderMainIdIn;
var ordersDistribution_AssignmentVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: OrdersDistribution_Assignment
model.flush();
return controller.ordersDistribution_Assignment$ServerAction(vars.value.i_RequestDistributionConfigIdInLocal, vars.value.i_OrderMainIdInLocal, true, true, callContext).then(function (value) {
ordersDistribution_AssignmentVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if(((!(ordersDistribution_AssignmentVar.value.resultOut.hasSuccessAttr)))) {
OS$FeedbackMessageService.showFeedbackMessage(ordersDistribution_AssignmentVar.value.resultOut.errorMessageAttr, /*Error*/ 3);
} else {
// "Order has been assigned to a distribution line successfuly"
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V9zIMNC7eEyh8T8sjQ7QVg#Message.698441477.1", "Order has been assigned to a distribution line successfully"), /*Success*/ 1);
// Trigger Event: Event
return controller.event$Action(callContext);
}

});
}).then(function () {
// Execute Action: RefreshList
return controller._refreshList$Action(true, callContext).then(function () {
// Execute Action: TogglePopupConfirmation
controller._togglePopupConfirmation$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), callContext);
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
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "75dc39eb-8132-4836-8768-d7336923d532");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.OnSort$vars"))());
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
// Refresh Query: GetOrderDistributionConfig
var result = controller.getOrderDistributionConfig$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// Trigger Event: UpdateTabTableSort
return controller.updateTabTableSort$Action(0, model.variables.l_TableSortVar, callContext);
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
_datePickerOnSelected$Action(datePickerIdIn, selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "8e8a64f5-b1c1-4965-9f6d-a99283029b7b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.DatePickerOnSelected$vars"))());
vars.value.datePickerIdInLocal = datePickerIdIn;
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
if(((vars.value.datePickerIdInLocal === idService.getId("DatePickerPeriodEnd")))) {
// l_AuditFinalDateTime = SelectedDateTime
model.variables.l_AuditFinalDateTimeVar = vars.value.selectedDateTimeInLocal;
} else {
// l_AuditInitialDateTime = SelectedDateTime
model.variables.l_AuditInitialDateTimeVar = vars.value.selectedDateTimeInLocal;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_buttonGroupOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ButtonGroupOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "ButtonGroupOnChange");
span.setAttribute("outsystems.function.key", "96875ca6-cf3c-48ff-9a18-6c5acabd5439");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ButtonGroupOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
// OrderDistributionConfig_Division = ""
ConectaProveedoresClientVariables.setOrderDistributionConfig_Division("");
// Refresh Query: GetOrderDistributionConfig
var result = controller.getOrderDistributionConfig$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// Trigger Event: UpdateTabTableSort
return controller.updateTabTableSort$Action(model.variables.l_TabNumberVar, "", callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "96cb88e6-793b-484f-8d69-bfa76a4e8be5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetOrderMainDataOnInput
var result = controller.getOrderMainDataOnInput$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetOrderDistributionConfig
var result = controller.getOrderDistributionConfig$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "b2390063-1ef7-402f-98d9-b68265bb8119");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// OrderDistributionConfig_Applicant = ""
ConectaProveedoresClientVariables.setOrderDistributionConfig_Applicant("");
// OrderDistributionConfig_ApplicantDescription = ""
ConectaProveedoresClientVariables.setOrderDistributionConfig_ApplicantDescription("");
// OrderDistributionConfig_Direction = ""
ConectaProveedoresClientVariables.setOrderDistributionConfig_Direction("");
// OrderDistributionConfig_Role = ""
ConectaProveedoresClientVariables.setOrderDistributionConfig_Role("");
}

// Refresh Query: GetOrderDistributionConfig
var result = controller.getOrderDistributionConfig$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c3c1d9e6-587f-4586-bf42-30c1857d4ec4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// l_TabNumber = 0
model.variables.l_TabNumberVar = 0;
// l_AuditInitialDateTime = BuildDateTime
model.variables.l_AuditInitialDateTimeVar = OS$BuiltinFunctions.buildDateTime(OS$BuiltinFunctions.currDate(), (new OS$DataTypes.DateTime(1900, 1, 1, 0, 0, 0)));
// l_AuditFinalDateTime = BuildDateTime
model.variables.l_AuditFinalDateTimeVar = OS$BuiltinFunctions.buildDateTime(OS$BuiltinFunctions.currDate(), (new OS$DataTypes.DateTime(1900, 1, 1, 23, 59, 59)));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderMainDataOnInputOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainDataOnInputOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainDataOnInputOnAfterFetch");
span.setAttribute("outsystems.function.key", "ef3a0f42-b605-4763-ae20-314adc30f397");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderMainDataOnInputOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// SET CLIENTS
// l_TabNumber = GetOrderMainDataOnInput.OutFilters.TabNumber
model.variables.l_TabNumberVar = model.variables.getOrderMainDataOnInputDataAct.outFiltersOut.tabNumberAttr;
// OrderDistributionConfig_Division = GetOrderMainDataOnInput.OutFilters.Division
ConectaProveedoresClientVariables.setOrderDistributionConfig_Division(model.variables.getOrderMainDataOnInputDataAct.outFiltersOut.divisionAttr);
// OrderDistributionConfig_Applicant = GetOrderMainDataOnInput.OutFilters.Applicant
ConectaProveedoresClientVariables.setOrderDistributionConfig_Applicant(model.variables.getOrderMainDataOnInputDataAct.outFiltersOut.applicantAttr);
// OrderDistributionConfig_Direction = GetOrderMainDataOnInput.OutFilters.Direction
ConectaProveedoresClientVariables.setOrderDistributionConfig_Direction(model.variables.getOrderMainDataOnInputDataAct.outFiltersOut.directionAttr);
// OrderDistributionConfig_ApplicantDescription = GetOrderMainDataOnInput.OutFilters.ApplicantDescription
ConectaProveedoresClientVariables.setOrderDistributionConfig_ApplicantDescription(model.variables.getOrderMainDataOnInputDataAct.outFiltersOut.applicantDescriptionAttr);
// l_IsOrderRejected = GetOrderMainDataOnInput.IsOrderRejected
model.variables.l_IsOrderRejectedVar = model.variables.getOrderMainDataOnInputDataAct.isOrderRejectedOut;
// Refresh Query: GetOrderDistributionConfig
var result = controller.getOrderDistributionConfig$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_showAudit_OnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowAudit_OnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ShowAudit_OnClick");
span.setAttribute("outsystems.function.key", "fbe8cdde-6556-4f4c-b166-927bc798a8c3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowAudit_OnClick");
callContext = controller.callContext(callContext);
// l_ShowAudit = notl_ShowAudit
model.variables.l_ShowAuditVar = (!(model.variables.l_ShowAuditVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "1fbc51c3-e471-4845-8fad-831bbe110330");
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

datePickerOnClick$Action(datePickerIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnClick");
span.setAttribute("outsystems.function.key", "233d4d3c-c9fd-435a-b042-b5f0caca77f7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnClick$Action, callContext, datePickerIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

togglePopupConfirmation$Action(toStore_RequestDistributionConfigIdIn, toStore_OrderMainIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupConfirmation__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupConfirmation");
span.setAttribute("outsystems.function.key", "47277e4e-2f13-4e12-ab0d-e526986f2eac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._togglePopupConfirmation$Action, callContext, toStore_RequestDistributionConfigIdIn, toStore_OrderMainIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

confirmOnClick$Action(i_RequestDistributionConfigIdIn, i_OrderMainIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ConfirmOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "71f3f236-ba18-4d74-b81d-c7ce30fe4866");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._confirmOnClick$Action, callContext, i_RequestDistributionConfigIdIn, i_OrderMainIdIn);
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
span.setAttribute("outsystems.function.key", "75dc39eb-8132-4836-8768-d7336923d532");
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

datePickerOnSelected$Action(datePickerIdIn, selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "8e8a64f5-b1c1-4965-9f6d-a99283029b7b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnSelected$Action, callContext, datePickerIdIn, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

buttonGroupOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ButtonGroupOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ButtonGroupOnChange");
span.setAttribute("outsystems.function.key", "96875ca6-cf3c-48ff-9a18-6c5acabd5439");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._buttonGroupOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "96cb88e6-793b-484f-8d69-bfa76a4e8be5");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "b2390063-1ef7-402f-98d9-b68265bb8119");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c3c1d9e6-587f-4586-bf42-30c1857d4ec4");
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

getOrderMainDataOnInputOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainDataOnInputOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainDataOnInputOnAfterFetch");
span.setAttribute("outsystems.function.key", "ef3a0f42-b605-4763-ae20-314adc30f397");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderMainDataOnInputOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showAudit_OnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowAudit_OnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowAudit_OnClick");
span.setAttribute("outsystems.function.key", "fbe8cdde-6556-4f4c-b166-927bc798a8c3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showAudit_OnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get updateTabTableSort$Action() {if(!(this.hasOwnProperty("_updateTabTableSort$Action"))) {
this._updateTabTableSort$Action = function () {
return Promise.resolve();
};
}

return this._updateTabTableSort$Action;
}set updateTabTableSort$Action(value) {this._updateTabTableSort$Action = value;
}

get event$Action() {if(!(this.hasOwnProperty("_event$Action"))) {
this._event$Action = function () {
return Promise.resolve();
};
}

return this._event$Action;
}set event$Action(value) {this._event$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig$ActionOrdersDistribution_Assignment", [{
name: "Result",
attrName: "resultOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_9f3831cec6ebd34416b59b8df7a27893Structure();
},
complexType: ST_9f3831cec6ebd34416b59b8df7a27893Structure
}, {
name: "PositionFirstContactId",
attrName: "positionFirstContactIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.DatePickerOnClick$vars", [{
name: "DatePickerId",
attrName: "datePickerIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.TogglePopupConfirmation$vars", [{
name: "ToStore_RequestDistributionConfigId",
attrName: "toStore_RequestDistributionConfigIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "ToStore_OrderMainId",
attrName: "toStore_OrderMainIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.ConfirmOnClick$vars", [{
name: "i_RequestDistributionConfigId",
attrName: "i_RequestDistributionConfigIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "i_OrderMainId",
attrName: "i_OrderMainIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.DatePickerOnSelected$vars", [{
name: "DatePickerId",
attrName: "datePickerIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


