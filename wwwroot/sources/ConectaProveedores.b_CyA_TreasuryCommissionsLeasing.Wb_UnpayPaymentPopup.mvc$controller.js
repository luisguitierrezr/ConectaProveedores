import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Injector as OS$Injector, ServiceNames as OS$ServiceNames, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { RC_df27c8a3fd58b3a0547b138755710019, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_controller_Input_FilenameOnClick_ClickUploadWidgetJS from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup.mvc$controller.Input_FilenameOnClick.ClickUploadWidgetJS.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_TranslationsResources from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
payUnpaySingleProposalLine$ServerAction(i_ProposalLineIdIn, i_IsPayIn, i_CommentIn, i_BinaryIn, i_FilenameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PayUnpaySingleProposalLine", function (span) {
if(span) {
span.setAttribute("code.function", "PayUnpaySingleProposalLine");
span.setAttribute("outsystems.function.key", "84c5752e-e525-491e-980e-8915d23cc8c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ProposalLineId: OS$DataConversion.ServerDataConverter.to(i_ProposalLineIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsPay: OS$DataConversion.ServerDataConverter.to(i_IsPayIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Binary: OS$DataConversion.ServerDataConverter.to(i_BinaryIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
}),
i_Filename: OS$DataConversion.ServerDataConverter.to(i_FilenameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("PayUnpaySingleProposalLine", "screenservices/ConectaProveedores/b_CyA_TreasuryCommissionsLeasing/Wb_UnpayPaymentPopup/ActionPayUnpaySingleProposalLine", "NUg35lY6yeqQ7J6gbZnlBg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup$ActionPayUnpaySingleProposalLine"))();
executeServerActionResult.o_HasProposalChangedStatusOut = OS$DataConversion.ServerDataConverter.from(outputs.o_HasProposalChangedStatus, OS$DataTypes.DataTypes.Boolean);
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

// Aggregates and Data Actions

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "898e81ce-17b0-4ed2-890d-a8d17a01f4a6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.l_DropdownReasonOptionsListVar, function () {
var list = new (OS$GenericTypeCache.getGenericList(RC_df27c8a3fd58b3a0547b138755710019))();
list.pushAll([function () {
var rec = new RC_df27c8a3fd58b3a0547b138755710019();
rec.optionAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yFv6uukDBkibL7B9BuSgJQ#Value.601535248.1", "Falla de la Banca Electrónica");
return rec;
}(), function () {
var rec = new RC_df27c8a3fd58b3a0547b138755710019();
rec.optionAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1EzoEKpv_0ypccnpAy1sYw#Value.-550553197.1", "Cuenta del Proveedor Bloqueada");
return rec;
}(), function () {
var rec = new RC_df27c8a3fd58b3a0547b138755710019();
rec.optionAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Tml1J2EAUUuYX7+g3uXz6w#Value.-1356964459.1", "Cuenta del Proveedor Cancelada");
return rec;
}(), function () {
var rec = new RC_df27c8a3fd58b3a0547b138755710019();
rec.optionAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Kq86JTw+NEeFvzUU6CFRMw#Value.2001674806.1", "No. de Cuenta Incorrecto");
return rec;
}(), function () {
var rec = new RC_df27c8a3fd58b3a0547b138755710019();
rec.optionAttr = "Otros";
return rec;
}()]);
return list;
}(), callContext);
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "a36eb91d-37fc-4a75-902a-47a9f3c909e8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_FilenameOnClick");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("ClickUploadWidget", function (span) {
if(span) {
span.setAttribute("code.function", "ClickUploadWidget");
span.setAttribute("outsystems.function.key", "986c21c3-4c46-47a5-ba41-ed4c01716e33");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_controller_Input_FilenameOnClick_ClickUploadWidgetJS, "ClickUploadWidget", "Input_FilenameOnClick", {
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
_unpaidOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UnpaidOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "UnpaidOnClick");
span.setAttribute("outsystems.function.key", "af828264-95d2-48bc-b0b1-a692f83fc7b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UnpaidOnClick");
callContext = controller.callContext(callContext);
var payUnpaySingleProposalLineVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// TextArea_l_UnpayReason.Valid = True
model.widgets.get(idService.getId("TextArea_l_UnpayReason")).validAttr = true;
// TextArea_l_UnpayReason.ValidationMessage = ""
model.widgets.get(idService.getId("TextArea_l_UnpayReason")).validationMessageAttr = "";
// Dropdown_ReasonSelected.Valid = True
model.widgets.get(idService.getId("Dropdown_ReasonSelected")).validAttr = true;
// Dropdown_ReasonSelected.ValidationMessage = ""
model.widgets.get(idService.getId("Dropdown_ReasonSelected")).validationMessageAttr = "";
return OS$Flow.executeSequence(function () {
if(((model.variables.l_DropdownReasonSelectedVar === ""))) {
// Dropdown_ReasonSelected.Valid = False
model.widgets.get(idService.getId("Dropdown_ReasonSelected")).validAttr = false;
// Dropdown_ReasonSelected.ValidationMessage = "You must select a motive."
model.widgets.get(idService.getId("Dropdown_ReasonSelected")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GZofrgGHe0eUbANKdOVKDA#Value.1371996507.1", "You must select a motive.");
} else {
return OS$Flow.executeSequence(function () {
if(((OS$BuiltinFunctions.trim(model.variables.l_UnpayReasonVar) === ""))) {
// TextArea_l_UnpayReason.Valid = False
model.widgets.get(idService.getId("TextArea_l_UnpayReason")).validAttr = false;
// TextArea_l_UnpayReason.ValidationMessage = "You must state a reason to not pay this proposal line."
model.widgets.get(idService.getId("TextArea_l_UnpayReason")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hKwlqVq7gk2YO3pOpJV4EQ#Value.1464377372.1", "You must state a reason to not pay this proposal line.");
} else {
// Execute Action: PayUnpaySingleProposalLine
model.flush();
return controller.payUnpaySingleProposalLine$ServerAction(model.variables.i_ProposalLineIdToUnpayPaymentIn, false, model.variables.l_UnpayReasonVar, model.variables.l_BinaryDataVar, model.variables.l_FilenameVar, callContext).then(function (value) {
payUnpaySingleProposalLineVar.value = value;
}).then(function () {
// Trigger Event: Unpay
return controller.unpay$Action(payUnpaySingleProposalLineVar.value.o_HasProposalChangedStatusOut, callContext);
}).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("M2Ij+Bke8EC+s0GPkxvCcw#Message.-551236647.1", "Proposal line has been unpaid."), /*Warning*/ 2);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "c1c9363e-7623-40d9-b6aa-34ce551a894d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// l_UnpayReason = ""
model.variables.l_UnpayReasonVar = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_ReasonSelectedOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_ReasonSelectedOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ReasonSelectedOnChange");
span.setAttribute("outsystems.function.key", "e22a4946-fc41-471c-805a-c861943895b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_ReasonSelectedOnChange");
callContext = controller.callContext(callContext);
// l_UnpayReason = If
model.variables.l_UnpayReasonVar = ((((OS$BuiltinFunctions.index(model.variables.l_UnpayReasonVar, ":", 0, false, false)) !== ((-1)))) ? (((model.variables.l_DropdownReasonSelectedVar + ": ") + OS$BuiltinFunctions.substr(model.variables.l_UnpayReasonVar, (OS$BuiltinFunctions.index(model.variables.l_UnpayReasonVar, ":", 0, false, false) + ((((OS$BuiltinFunctions.index(model.variables.l_UnpayReasonVar, ": ", 0, false, false)) !== ((-1)))) ? (2) : (1))), OS$BuiltinFunctions.length(model.variables.l_UnpayReasonVar)))) : (((model.variables.l_DropdownReasonSelectedVar + ": ") + model.variables.l_UnpayReasonVar)));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "898e81ce-17b0-4ed2-890d-a8d17a01f4a6");
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

input_FilenameOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_FilenameOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_FilenameOnClick");
span.setAttribute("outsystems.function.key", "a36eb91d-37fc-4a75-902a-47a9f3c909e8");
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

unpaidOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UnpaidOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UnpaidOnClick");
span.setAttribute("outsystems.function.key", "af828264-95d2-48bc-b0b1-a692f83fc7b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._unpaidOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "c1c9363e-7623-40d9-b6aa-34ce551a894d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_ReasonSelectedOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_ReasonSelectedOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ReasonSelectedOnChange");
span.setAttribute("outsystems.function.key", "e22a4946-fc41-471c-805a-c861943895b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_ReasonSelectedOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
}

get unpay$Action() {if(!(this.hasOwnProperty("_unpay$Action"))) {
this._unpay$Action = function () {
return Promise.resolve();
};
}

return this._unpay$Action;
}set unpay$Action(value) {this._unpay$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup$ActionPayUnpaySingleProposalLine", [{
name: "o_HasProposalChangedStatus",
attrName: "o_HasProposalChangedStatusOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);

// Client Actions - Variables

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


