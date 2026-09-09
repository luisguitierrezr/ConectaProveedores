import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_mvc_TranslationsResources from "./ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig.mvc$translationsResources.js";
import ConectaProveedores_h_OrderDistributionConfigController$default from "./ConectaProveedores.h_OrderDistributionConfig.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSettings$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfig/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
importOrderDistributionConfigFromExcel$ServerAction(fileContentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ImportOrderDistributionConfigFromExcel", function (span) {
if(span) {
span.setAttribute("code.function", "ImportOrderDistributionConfigFromExcel");
span.setAttribute("outsystems.function.key", "77826a58-9dc2-45fd-90f2-f27c67c7fb07");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
FileContent: OS$DataConversion.ServerDataConverter.to(fileContentIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ImportOrderDistributionConfigFromExcel", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfig/ActionImportOrderDistributionConfigFromExcel", "OSmQuiekvt_Bs0DSPUM4Mg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig$ActionImportOrderDistributionConfigFromExcel"))();
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
exportOrderDistributionConfig$ServerAction(i_OrderIdIn, i_TabNumberIn, i_TableSortIn, i_OrderDistributionConfig_ApplicantIn, i_OrderDistributionConfig_ApplicantDescriptionIn, i_OrderDistributionConfig_DirectionIn, i_OrderDistributionConfig_DivisionIn, i_OrderDistributionConfig_RoleIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportOrderDistributionConfig", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOrderDistributionConfig");
span.setAttribute("outsystems.function.key", "4eb277e3-b4fb-4e9c-9011-7b8db52a4dd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderId: OS$DataConversion.ServerDataConverter.to(i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_TabNumber: OS$DataConversion.ServerDataConverter.to(i_TabNumberIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_TableSort: OS$DataConversion.ServerDataConverter.to(i_TableSortIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_OrderDistributionConfig_Applicant: OS$DataConversion.ServerDataConverter.to(i_OrderDistributionConfig_ApplicantIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_OrderDistributionConfig_ApplicantDescription: OS$DataConversion.ServerDataConverter.to(i_OrderDistributionConfig_ApplicantDescriptionIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_OrderDistributionConfig_Direction: OS$DataConversion.ServerDataConverter.to(i_OrderDistributionConfig_DirectionIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_OrderDistributionConfig_Division: OS$DataConversion.ServerDataConverter.to(i_OrderDistributionConfig_DivisionIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_OrderDistributionConfig_Role: OS$DataConversion.ServerDataConverter.to(i_OrderDistributionConfig_RoleIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ExportOrderDistributionConfig", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfig/ActionExportOrderDistributionConfig", "5aypJeVhMe1__WONy4OmCw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig$ActionExportOrderDistributionConfig"))();
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

// Aggregates and Data Actions
get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/h_OrderDistributionConfig/OrderDistributionConfig/DataActionGetSettings", "N9tDUeibRoeXDWx8UfSXLw", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "ecfd81d7-6e35-4ec5-bd3e-c2a666f498c5");
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
this._dataFetchActionNames = ["getSettings$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "40860fa7-5b8e-446a-86e4-af0ea2ccaba6");
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
rec.screenAttr = "Order Distribution Config";
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
_wb_OrderDistributionConfigUpdateTabTableSort$Action(i_TabNumberIn, i_TableSortIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_OrderDistributionConfigUpdateTabTableSort", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_OrderDistributionConfigUpdateTabTableSort");
span.setAttribute("outsystems.function.key", "6328468a-e726-4eb8-9004-367d6fde5724");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_OrderDistributionConfigUpdateTabTableSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig.Wb_OrderDistributionConfigUpdateTabTableSort$vars"))());
vars.value.i_TabNumberInLocal = i_TabNumberIn;
vars.value.i_TableSortInLocal = i_TableSortIn;
if((((vars.value.i_TableSortInLocal) !== ("")))) {
// l_TableSort = i_TableSort
model.variables.l_TableSortVar = vars.value.i_TableSortInLocal;
} else {
// l_TabNumber = i_TabNumber
model.variables.l_TabNumberVar = vars.value.i_TabNumberInLocal;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_importOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ImportOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ImportOnClick");
span.setAttribute("outsystems.function.key", "b96c9f6f-89ff-478e-82fc-a69fad390a4b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ImportOnClick");
callContext = controller.callContext(callContext);
var importOrderDistributionConfigFromExcelVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_FileNameVar === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Aa6IylEFpUCK91eEyUiVQg#Message.612249493.1", "Please select a file first."), /*Info*/ 0);
} else {
// Execute Action: ImportOrderDistributionConfigFromExcel
model.flush();
return controller.importOrderDistributionConfigFromExcel$ServerAction(model.variables.l_FileContentVar, callContext).then(function (value) {
importOrderDistributionConfigFromExcelVar.value = value;
}).then(function () {
if((importOrderDistributionConfigFromExcelVar.value.hasSuccessOut)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5X_gO9KMGkWHtg7rUZKGtw#Message.1294058145.1", "File Imported with success"), /*Success*/ 1);
} else {
OS$FeedbackMessageService.showFeedbackMessage(importOrderDistributionConfigFromExcelVar.value.errorMessageOut, /*Error*/ 3);
}

// Destination: /ConectaProveedores/OrderDistributionConfig
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDistributionConfig", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
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
_exportStrucOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExportStrucOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ExportStrucOnClick");
span.setAttribute("outsystems.function.key", "d51320fc-d1ac-4265-9277-b003ddfc699a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExportStrucOnClick");
callContext = controller.callContext(callContext);
var exportStructVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ExportStruct
model.flush();
return controller.exportOrderDistributionConfig$ServerAction(OS$DataTypes.LongInteger.defaultValue, model.variables.l_TabNumberVar, model.variables.l_TableSortVar, ConectaProveedoresClientVariables.getOrderDistributionConfig_Applicant(), ConectaProveedoresClientVariables.getOrderDistributionConfig_ApplicantDescription(), ConectaProveedoresClientVariables.getOrderDistributionConfig_Direction(), ConectaProveedoresClientVariables.getOrderDistributionConfig_Division(), ConectaProveedoresClientVariables.getOrderDistributionConfig_Role(), callContext).then(function (value) {
exportStructVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportStructVar.value.o_FileOut.binaryDataAttr, exportStructVar.value.o_FileOut.nameAttr));
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "40860fa7-5b8e-446a-86e4-af0ea2ccaba6");
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

wb_OrderDistributionConfigUpdateTabTableSort$Action(i_TabNumberIn, i_TableSortIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_OrderDistributionConfigUpdateTabTableSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_OrderDistributionConfigUpdateTabTableSort");
span.setAttribute("outsystems.function.key", "6328468a-e726-4eb8-9004-367d6fde5724");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_OrderDistributionConfigUpdateTabTableSort$Action, callContext, i_TabNumberIn, i_TableSortIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

importOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ImportOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ImportOnClick");
span.setAttribute("outsystems.function.key", "b96c9f6f-89ff-478e-82fc-a69fad390a4b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._importOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

exportStrucOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportStrucOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExportStrucOnClick");
span.setAttribute("outsystems.function.key", "d51320fc-d1ac-4265-9277-b003ddfc699a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._exportStrucOnClick$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig$ActionImportOrderDistributionConfigFromExcel", [{
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
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig$ActionExportOrderDistributionConfig", [{
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
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig.Wb_OrderDistributionConfigUpdateTabTableSort$vars", [{
name: "i_TabNumber",
attrName: "i_TabNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "i_TableSort",
attrName: "i_TableSortInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


