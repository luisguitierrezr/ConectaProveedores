import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_mvc_controller_Input_FilenameOnClick_ClickUploadWidgetJS from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.mvc$controller.Input_FilenameOnClick.ClickUploadWidgetJS.js";
import { ST_ba28fce29317fb1a65969ecb0fce5c4bStructure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.mvc$translationsResources.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasingController$default from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.controller.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalManualUpload/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
importFile$ServerAction(i_FilenameIn, i_FileIn, i_CreatedByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ImportFile", function (span) {
if(span) {
span.setAttribute("code.function", "ImportFile");
span.setAttribute("outsystems.function.key", "6f26bf87-501f-4fca-9b10-18a5e8a7f3f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Filename: OS$DataConversion.ServerDataConverter.to(i_FilenameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_File: OS$DataConversion.ServerDataConverter.to(i_FileIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
}),
i_CreatedBy: OS$DataConversion.ServerDataConverter.to(i_CreatedByIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ImportFile", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalManualUpload/ActionImportFile", "LdAxI6dN4hK9mO7yGVua_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload$ActionImportFile"))();
executeServerActionResult.o_OuputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Ouput, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
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
verifyAndValidateFilename$ServerAction(i_FilenameIn, i_IsCommissionIn, i_IsComissionUnknownIn, i_BinaryIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("VerifyAndValidateFilename", function (span) {
if(span) {
span.setAttribute("code.function", "VerifyAndValidateFilename");
span.setAttribute("outsystems.function.key", "c445672d-f209-4376-9c0a-a5729eaa6891");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Filename: OS$DataConversion.ServerDataConverter.to(i_FilenameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_IsCommission: OS$DataConversion.ServerDataConverter.to(i_IsCommissionIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_IsComissionUnknown: OS$DataConversion.ServerDataConverter.to(i_IsComissionUnknownIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Binary: OS$DataConversion.ServerDataConverter.to(i_BinaryIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("VerifyAndValidateFilename", "screenservices/ConectaProveedores/b_CyA_AdminCommissionsLeasing/ProposalManualUpload/ActionVerifyAndValidateFilename", "AhRvete08kRiYygl9OwRJw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload$ActionVerifyAndValidateFilename"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.o_ProposalTempDataOut = OS$DataConversion.ServerDataConverter.from(outputs.o_ProposalTempData, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure);
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

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
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
span.setAttribute("outsystems.function.key", "193463bc-08df-45f0-b1cf-ab3e5dd30657");
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
rec.screenAttr = "CyA - Proposal Manual Upload";
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
_input_FilenameOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_FilenameOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "Input_FilenameOnClick");
span.setAttribute("outsystems.function.key", "a6dd865f-d088-4f24-bc99-902065c459c8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_FilenameOnClick");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("ClickUploadWidget", function (span) {
if(span) {
span.setAttribute("code.function", "ClickUploadWidget");
span.setAttribute("outsystems.function.key", "33f678e8-80f5-4125-be1c-a151d0a708ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_mvc_controller_Input_FilenameOnClick_ClickUploadWidgetJS, "ClickUploadWidget", "Input_FilenameOnClick", {
WidgetId: OS$DataConversion.JSNodeParamConverter.to(idService.getId("Upload"), OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_saveFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveFile", function (span) {
if(span) {
span.setAttribute("code.function", "SaveFile");
span.setAttribute("outsystems.function.key", "cd136a02-b947-43c6-b784-e326ebae74d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveFile");
callContext = controller.callContext(callContext);
var importFileVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// IsExecuting = true
// l_IsExecuting = True
model.variables.l_IsExecutingVar = true;
// Execute Action: ImportFile
model.flush();
return controller.importFile$ServerAction(model.variables.l_FilenameVar, model.variables.l_BinaryDataVar, OS$BuiltinFunctions.getUserId(), callContext).then(function (value) {
importFileVar.value = value;
}).then(function () {
if((importFileVar.value.o_OuputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qfPCvAQfME2AxrPM7JxcQQ#Message.715208465.1", "Your file will be submited."), /*Success*/ 1);
// Destination: /ConectaProveedores/ProposalsList
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// IsExecuting = false
// l_IsExecuting = False
model.variables.l_IsExecutingVar = false;
OS$FeedbackMessageService.showFeedbackMessage(importFileVar.value.o_OuputOut.messageAttr, /*Error*/ 3);
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
_uploadFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UploadFile", function (span) {
if(span) {
span.setAttribute("code.function", "UploadFile");
span.setAttribute("outsystems.function.key", "e8daa95d-fc35-4f28-bfb7-db7a40be1908");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UploadFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.UploadFile$vars"))());
var verifyAndValidateFilenameVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Input_Filename.Valid = True
model.widgets.get(idService.getId("Input_Filename")).validAttr = true;
// l_ValidationMessage = ""
model.variables.l_ValidationMessageVar = "";
// l_ProposalTempData = l_ProposalTempDataEmpty
model.variables.l_ProposalTempDataVar = vars.value.l_ProposalTempDataEmptyVar;
// l_IsLoading = True
model.variables.l_IsLoadingVar = true;
// Execute Action: VerifyAndValidateFilename
model.flush();
return controller.verifyAndValidateFilename$ServerAction(model.variables.l_FilenameVar, false, true, model.variables.l_BinaryDataVar, callContext).then(function (value) {
verifyAndValidateFilenameVar.value = value;
}).then(function () {
if((verifyAndValidateFilenameVar.value.o_OutputOut.isSuccessAttr)) {
// l_ProposalTempData = VerifyAndValidateFilename.o_ProposalTempData
model.variables.l_ProposalTempDataVar = verifyAndValidateFilenameVar.value.o_ProposalTempDataOut;
// l_IsLoading = False
model.variables.l_IsLoadingVar = false;
} else {
// Input_Filename.Valid = False
model.widgets.get(idService.getId("Input_Filename")).validAttr = false;
// l_ValidationMessage = VerifyAndValidateFilename.o_Output.Message
model.variables.l_ValidationMessageVar = verifyAndValidateFilenameVar.value.o_OutputOut.messageAttr;
// l_IsLoading = False
model.variables.l_IsLoadingVar = false;
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "193463bc-08df-45f0-b1cf-ab3e5dd30657");
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

input_FilenameOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_FilenameOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_FilenameOnClick");
span.setAttribute("outsystems.function.key", "a6dd865f-d088-4f24-bc99-902065c459c8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_FilenameOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

saveFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveFile");
span.setAttribute("outsystems.function.key", "cd136a02-b947-43c6-b784-e326ebae74d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveFile$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

uploadFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UploadFile");
span.setAttribute("outsystems.function.key", "e8daa95d-fc35-4f28-bfb7-db7a40be1908");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._uploadFile$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload$ActionImportFile", [{
name: "o_Ouput",
attrName: "o_OuputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload$ActionVerifyAndValidateFilename", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "o_ProposalTempData",
attrName: "o_ProposalTempDataOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure();
},
complexType: ST_ba28fce29317fb1a65969ecb0fce5c4bStructure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.UploadFile$vars", [{
name: "l_ProposalTempDataEmpty",
attrName: "l_ProposalTempDataEmptyVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure();
},
complexType: ST_ba28fce29317fb1a65969ecb0fce5c4bStructure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


