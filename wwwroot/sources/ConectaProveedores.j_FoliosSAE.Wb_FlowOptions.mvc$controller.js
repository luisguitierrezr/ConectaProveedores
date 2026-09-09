import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { dropdownNotValid$Action as OutSystemsUIController$dropdownNotValid$Action, dropdownClearValidation$Action as OutSystemsUIController$dropdownClearValidation$Action } from "./OutSystemsUI.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getApprovalProcesses$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getApprovalProcesses$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getApprovalProcesses$DataActRefresh() {if(!(this.hasOwnProperty("_getApprovalProcesses$DataActRefresh"))) {
this._getApprovalProcesses$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApprovalProcesses", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FlowOptions/DataActionGetApprovalProcesses", "wI6dG0Lkf5DSzmdKBEpJuA", function (b) {
model.variables.getApprovalProcessesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalProcessesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalProcessesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalProcesses", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalProcesses");
span.setAttribute("outsystems.function.key", "c7b3576b-8e05-4629-9f32-915f4feb8459");
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

return this._getApprovalProcesses$DataActRefresh;
}set getApprovalProcesses$DataActRefresh(value) {this._getApprovalProcesses$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getApprovalProcesses$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdownSearchApprovProcessOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchApprovProcessOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchApprovProcessOnChanged");
span.setAttribute("outsystems.function.key", "26b945c3-12a5-4f24-a7e9-e3ac92a25fe9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchApprovProcessOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.DropdownSearchApprovProcessOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// l_ApprovalProcessId = LongIntegerToIdentifier
model.variables.l_ApprovalProcessIdVar = OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr));
// Trigger Event: ApprovalProcessSelected
return controller.approvalProcessSelected$Action(model.variables.l_ApprovalProcessIdVar, callContext);
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
span.setAttribute("outsystems.function.key", "8a2bdfcb-7f4d-46b6-9e60-34b3c4278d48");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var dropdownNotValidVar = new OS$DataTypes.VariableHolder();
var dropdownClearValidationVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Mandatory Input changes?
return OS$Flow.executeSequence(function () {
if((((model.variables.l_IsMandatoryErrorVar) !== (model.variables.i_MandatoryErrorIn)))) {
// MandatoryError?
if((model.variables.i_MandatoryErrorIn)) {
// Execute Action: DropdownNotValid
dropdownNotValidVar.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("Dropdown"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lMz4NFvQfUGftVI1iJDwgw#Value.-1857341149.1", "This field is mandatory."), callContext);

} else {
// Execute Action: DropdownClearValidation
dropdownClearValidationVar.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("Dropdown"), callContext);

}

// l_IsMandatoryError = i_MandatoryError
model.variables.l_IsMandatoryErrorVar = model.variables.i_MandatoryErrorIn;
} else {
// Refresh Query: GetApprovalProcesses
var result = controller.getApprovalProcesses$DataActRefresh(callContext);
model.flush();
return result;
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

dropdownSearchApprovProcessOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchApprovProcessOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchApprovProcessOnChanged");
span.setAttribute("outsystems.function.key", "26b945c3-12a5-4f24-a7e9-e3ac92a25fe9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchApprovProcessOnChanged$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "8a2bdfcb-7f4d-46b6-9e60-34b3c4278d48");
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

get approvalProcessSelected$Action() {if(!(this.hasOwnProperty("_approvalProcessSelected$Action"))) {
this._approvalProcessSelected$Action = function () {
return Promise.resolve();
};
}

return this._approvalProcessSelected$Action;
}set approvalProcessSelected$Action(value) {this._approvalProcessSelected$Action = value;
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.DropdownSearchApprovProcessOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


