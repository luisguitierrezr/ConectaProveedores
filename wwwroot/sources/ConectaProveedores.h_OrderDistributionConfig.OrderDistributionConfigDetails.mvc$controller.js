import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, JSONUtils as OS$JSONUtils, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action } from "./OutSystemsUI.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_mvc_TranslationsResources from "./ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.mvc$translationsResources.js";
import ConectaProveedores_h_OrderDistributionConfigController$default from "./ConectaProveedores.h_OrderDistributionConfig.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRegions$AggrRefresh: 0,
getOrderDistributionConfigById$AggrRefresh: 0,
getTelcelDirections$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getRegions$AggrRefresh: [],
getOrderDistributionConfigById$AggrRefresh: [],
getTelcelDirections$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
saveAndValidateOrderDistributionConfig$ServerAction(sourceIn, justificationIn, originalJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveAndValidateOrderDistributionConfig", function (span) {
if(span) {
span.setAttribute("code.function", "SaveAndValidateOrderDistributionConfig");
span.setAttribute("outsystems.function.key", "9a37d238-4362-448d-8cd0-dbb40768b0dc");
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
}),
Justification: OS$DataConversion.ServerDataConverter.to(justificationIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OriginalJSON: OS$DataConversion.ServerDataConverter.to(originalJSONIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SaveAndValidateOrderDistributionConfig", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfigDetails/ActionSaveAndValidateOrderDistributionConfig", "cooZWcnguJW81EBCjpfQEA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails$ActionSaveAndValidateOrderDistributionConfig"))();
executeServerActionResult.idOut = OS$DataConversion.ServerDataConverter.from(outputs.Id, OS$DataTypes.DataTypes.LongInteger);
executeServerActionResult.hasSuccessOut = OS$DataConversion.ServerDataConverter.from(outputs.HasSuccess, OS$DataTypes.DataTypes.Boolean);
executeServerActionResult.errorMessageOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMessage, OS$DataTypes.DataTypes.Text);
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfigDetails/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfigDetails/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "212d3465-c02b-4ff4-939a-16b0ed9a4bbd");
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

get getOrderDistributionConfigById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderDistributionConfigById$AggrRefresh"))) {
this._getOrderDistributionConfigById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderDistributionConfigById", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfigDetails/ScreenDataSetGetOrderDistributionConfigById", "oICCVZdoW0skgcx1jtL7dw", maxRecords, startIndex, function (b) {
model.variables.getOrderDistributionConfigByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderDistributionConfigByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderDistributionConfigByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getRequestDistributionConfigsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderDistributionConfigById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDistributionConfigById");
span.setAttribute("outsystems.function.key", "77af2f51-5447-4a64-9b81-a788eb89fd56");
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

return this._getOrderDistributionConfigById$AggrRefresh;
}set getOrderDistributionConfigById$AggrRefresh(value) {this._getOrderDistributionConfigById$AggrRefresh = value;
}

get getTelcelDirections$AggrRefresh() {if(!(this.hasOwnProperty("_getTelcelDirections$AggrRefresh"))) {
this._getTelcelDirections$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetTelcelDirections", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfigDetails/ScreenDataSetGetTelcelDirections", "FYAwP2s2APtNzU1Y4DBbfg", maxRecords, startIndex, function (b) {
model.variables.getTelcelDirectionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getTelcelDirectionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getTelcelDirectionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetTelcelDirections", function (span) {
if(span) {
span.setAttribute("code.function", "GetTelcelDirections");
span.setAttribute("outsystems.function.key", "8d659e0d-be3e-4ac3-9f59-64e2b82a1e81");
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

return this._getTelcelDirections$AggrRefresh;
}set getTelcelDirections$AggrRefresh(value) {this._getTelcelDirections$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getRegions$AggrRefresh", "getOrderDistributionConfigById$AggrRefresh", "getTelcelDirections$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_PopupMessageResult$Action(textIn, actionContinueIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_PopupMessageResult", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_PopupMessageResult");
span.setAttribute("outsystems.function.key", "4460eaae-afaf-454a-a9cf-e13740284561");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_PopupMessageResult");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.Wb_PopupMessageResult$vars"))());
vars.value.textInLocal = textIn;
vars.value.actionContinueInLocal = actionContinueIn;
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.actionContinueInLocal)) {
// Execute Action: SaveDistribution
return controller._saveDistribution$Action(vars.value.textInLocal, callContext);
}

}).then(function () {
// ShowPopup = False
model.variables.showPopupVar = false;
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
_seeLogsOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeLogsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "80fb9849-6ed3-4b13-86f5-6fabee56a324");
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
_saveDistribution$Action(justificationIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveDistribution", function (span) {
if(span) {
span.setAttribute("code.function", "SaveDistribution");
span.setAttribute("outsystems.function.key", "b0960476-f530-4862-8382-c7692645640a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveDistribution");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.SaveDistribution$vars"))());
vars.value.justificationInLocal = justificationIn;
var saveAndValidateOrderDistributionConfigVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Division Empty?
if((model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.regionIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Dropdown_Division.Valid = False
model.widgets.get(idService.getId("Dropdown_Division")).validAttr = false;
// Dropdown_Division.ValidationMessage = "Mandatory field"
model.widgets.get(idService.getId("Dropdown_Division")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+rpuxI6G1UafG78x2bHLoQ#Value.-19492909.1", "Mandatory field");
}

// Management Empty?
if(((model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr === ""))) {
// Input_Applicant.Valid = False
model.widgets.get(idService.getId("Input_Applicant")).validAttr = false;
// Input_Applicant.ValidationMessage = "Mandatory field"
model.widgets.get(idService.getId("Input_Applicant")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("F0lQfpE6XEeoZ84e50fg9Q#Value.-19492909.1", "Mandatory field");
}

// Requesting Department Empty?
if(((model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr === ""))) {
// Input_ApplicantDescription.Valid = False
model.widgets.get(idService.getId("Input_ApplicantDescription")).validAttr = false;
// Input_ApplicantDescription.ValidationMessage = "Mandatory field"
model.widgets.get(idService.getId("Input_ApplicantDescription")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XC9P0paN8EeLTqbzJgKC8w#Value.-19492909.1", "Mandatory field");
}

// Requesting Department Empty?
if(((OS$BuiltinFunctions.length(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr) > 200))) {
// Input_ApplicantDescription.Valid = False
model.widgets.get(idService.getId("Input_ApplicantDescription")).validAttr = false;
// Input_ApplicantDescription.ValidationMessage = "Max length exceded (200)"
model.widgets.get(idService.getId("Input_ApplicantDescription")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6fHBq_OKL02kd8KErLv0TQ#Value.-1185555601.1", "Max length exceded (200)");
}

// Direction Empty?
if((model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.directionIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Dropdown_Direction.Valid = False
model.widgets.get(idService.getId("Dropdown_Direction")).validAttr = false;
// Dropdown_Direction.ValidationMessage = "Mandatory field"
model.widgets.get(idService.getId("Dropdown_Direction")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qJvg2WU4yEOG9aU2Gex4QQ#Value.-19492909.1", "Mandatory field");
}

return OS$Flow.executeSequence(function () {
if(((((model.widgets.get(idService.getId("Form1")).validAttr && !(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstContact_EntraRoleIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondContact_EntraRoleIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && !(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstApprover_EntraRoleIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
if((model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// OriginalJSON = ""
model.variables.originalJSONVar = "";
}

// Execute Action: SaveAndValidateOrderDistributionConfig
model.flush();
return controller.saveAndValidateOrderDistributionConfig$ServerAction(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr, vars.value.justificationInLocal, model.variables.originalJSONVar, callContext).then(function (value) {
saveAndValidateOrderDistributionConfigVar.value = value;
}).then(function () {
if((saveAndValidateOrderDistributionConfigVar.value.hasSuccessOut)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9oRiuDQsI0mfRcrCMP8FIw#Message.-490039358.1", "Saved with success"), /*Success*/ 1);
// Destination: /ConectaProveedores/OrderDistributionConfig
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDistributionConfig", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(saveAndValidateOrderDistributionConfigVar.value.errorMessageOut, /*Error*/ 3);
// ShowPopup = notShowPopup
model.variables.showPopupVar = (!(model.variables.showPopupVar));
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
_getRequestDistributionConfigsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequestDistributionConfigsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequestDistributionConfigsOnAfterFetch");
span.setAttribute("outsystems.function.key", "b2a59424-ae9b-4592-b31c-91de971cf6ab");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetRequestDistributionConfigsOnAfterFetch");
callContext = controller.callContext(callContext);
var jSONSerialize1Var = new OS$DataTypes.VariableHolder(new OS$DataTypes.JSONSerializeOutputType());
// JSON Serialize: JSONSerialize1
jSONSerialize1Var.value.jSONOut = OS$JSONUtils.serializeToJSON(model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr, true, false);
// OriginalJSON = JSONSerialize1.JSON
model.variables.originalJSONVar = jSONSerialize1Var.value.jSONOut;
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
span.setAttribute("outsystems.function.key", "b8a10c58-3e9c-433e-937a-f29ebe65aece");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarDocumentCloseVar = new OS$DataTypes.VariableHolder();
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarLog"), callContext);

// Execute Action: SidebarDocumentClose
sidebarDocumentCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarLog"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_PositionContactOnChangePositionContact$Action(newPositionContactIn, positionContactNrIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_PositionContactOnChangePositionContact", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_PositionContactOnChangePositionContact");
span.setAttribute("outsystems.function.key", "c266f669-5380-4216-9933-1d4e6db38da7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_PositionContactOnChangePositionContact");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.Wb_PositionContactOnChangePositionContact$vars"))());
vars.value.newPositionContactInLocal = newPositionContactIn;
vars.value.positionContactNrInLocal = positionContactNrIn;
// GetOrderDistributionConfigById.List.Current.OrderDistributionConfig.FirstContact_EntraRoleId = If
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstContact_EntraRoleIdAttr = (((vars.value.positionContactNrInLocal === 1)) ? (vars.value.newPositionContactInLocal) : (model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstContact_EntraRoleIdAttr));
// GetOrderDistributionConfigById.List.Current.OrderDistributionConfig.SecondContact_EntraRoleId = If
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondContact_EntraRoleIdAttr = (((vars.value.positionContactNrInLocal === 2)) ? (vars.value.newPositionContactInLocal) : (model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondContact_EntraRoleIdAttr));
// GetOrderDistributionConfigById.List.Current.OrderDistributionConfig.FirstApprover_EntraRoleId = If
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstApprover_EntraRoleIdAttr = (((vars.value.positionContactNrInLocal === 3)) ? (vars.value.newPositionContactInLocal) : (model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.firstApprover_EntraRoleIdAttr));
// GetOrderDistributionConfigById.List.Current.OrderDistributionConfig.SecondApprover_EntraRoleId = If
model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondApprover_EntraRoleIdAttr = (((vars.value.positionContactNrInLocal === 4)) ? (vars.value.newPositionContactInLocal) : (model.variables.getOrderDistributionConfigByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.secondApprover_EntraRoleIdAttr));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_saveOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "c4d8784c-66c5-4dd8-9c38-c9735a51234d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SaveOnClick");
callContext = controller.callContext(callContext);
// ShowPopup = True
model.variables.showPopupVar = true;
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
span.setAttribute("outsystems.function.key", "e1d27553-3858-4ce1-b43c-85de154e62a4");
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
rec.identifierAttr = model.variables.configIdIn;
rec.messageAttr = "";
rec.screenAttr = "Order Distribution Config Details";
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

wb_PopupMessageResult$Action(textIn, actionContinueIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_PopupMessageResult__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_PopupMessageResult");
span.setAttribute("outsystems.function.key", "4460eaae-afaf-454a-a9cf-e13740284561");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_PopupMessageResult$Action, callContext, textIn, actionContinueIn);
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
span.setAttribute("outsystems.function.key", "80fb9849-6ed3-4b13-86f5-6fabee56a324");
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

saveDistribution$Action(justificationIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveDistribution__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveDistribution");
span.setAttribute("outsystems.function.key", "b0960476-f530-4862-8382-c7692645640a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveDistribution$Action, callContext, justificationIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getRequestDistributionConfigsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequestDistributionConfigsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequestDistributionConfigsOnAfterFetch");
span.setAttribute("outsystems.function.key", "b2a59424-ae9b-4592-b31c-91de971cf6ab");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getRequestDistributionConfigsOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "b8a10c58-3e9c-433e-937a-f29ebe65aece");
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

wb_PositionContactOnChangePositionContact$Action(newPositionContactIn, positionContactNrIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_PositionContactOnChangePositionContact__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_PositionContactOnChangePositionContact");
span.setAttribute("outsystems.function.key", "c266f669-5380-4216-9933-1d4e6db38da7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_PositionContactOnChangePositionContact$Action, callContext, newPositionContactIn, positionContactNrIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

saveOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "c4d8784c-66c5-4dd8-9c38-c9735a51234d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._saveOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "e1d27553-3858-4ce1-b43c-85de154e62a4");
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
return ConectaProveedores_h_OrderDistributionConfigController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ConectaProveedoresAdmin]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails$ActionSaveAndValidateOrderDistributionConfig", [{
name: "Id",
attrName: "idOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "HasSuccess",
attrName: "hasSuccessOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.Wb_PopupMessageResult$vars", [{
name: "Text",
attrName: "textInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ActionContinue",
attrName: "actionContinueInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.SaveDistribution$vars", [{
name: "Justification",
attrName: "justificationInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.Wb_PositionContactOnChangePositionContact$vars", [{
name: "NewPositionContact",
attrName: "newPositionContactInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "PositionContactNr",
attrName: "positionContactNrInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


