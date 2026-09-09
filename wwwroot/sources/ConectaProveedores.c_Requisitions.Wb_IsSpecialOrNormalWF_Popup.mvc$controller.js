import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFirstApproverList$DataActRefresh: -1,
getSettings$DataActRefresh: 0,
getSpecialWorkflows$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFirstApproverList$DataActRefresh: [],
getSettings$DataActRefresh: [],
getSpecialWorkflows$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getFirstApproverList$DataActRefresh() {if(!(this.hasOwnProperty("_getFirstApproverList$DataActRefresh"))) {
this._getFirstApproverList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFirstApproverList", "screenservices/ConectaProveedores/c_Requisitions/Wb_IsSpecialOrNormalWF_Popup/DataActionGetFirstApproverList", "2XL9pGIxfGmg5lIHbmVV3g", function (b) {
model.variables.getFirstApproverListDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFirstApproverListDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFirstApproverListDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFirstApproverList", function (span) {
if(span) {
span.setAttribute("code.function", "GetFirstApproverList");
span.setAttribute("outsystems.function.key", "70ceae99-e1d3-40cb-9560-77b3a9ab1aa6");
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

return this._getFirstApproverList$DataActRefresh;
}set getFirstApproverList$DataActRefresh(value) {this._getFirstApproverList$DataActRefresh = value;
}

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/c_Requisitions/Wb_IsSpecialOrNormalWF_Popup/DataActionGetSettings", "Gcqc9anSeEXGppKmB3Iymg", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "a5cdfcba-8fbb-4583-a3c9-95c7d38698f9");
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

get getSpecialWorkflows$DataActRefresh() {if(!(this.hasOwnProperty("_getSpecialWorkflows$DataActRefresh"))) {
this._getSpecialWorkflows$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSpecialWorkflows", "screenservices/ConectaProveedores/c_Requisitions/Wb_IsSpecialOrNormalWF_Popup/DataActionGetSpecialWorkflows", "rzJLIajIdj91LlIPpgEp6g", function (b) {
model.variables.getSpecialWorkflowsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialWorkflowsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialWorkflowsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialWorkflows", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialWorkflows");
span.setAttribute("outsystems.function.key", "fa9f62e6-306c-494c-a277-887f69e285cf");
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

return this._getSpecialWorkflows$DataActRefresh;
}set getSpecialWorkflows$DataActRefresh(value) {this._getSpecialWorkflows$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFirstApproverList$DataActRefresh", "getSettings$DataActRefresh", "getSpecialWorkflows$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdownSearchOnChangedWorkflow$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedWorkflow", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedWorkflow");
span.setAttribute("outsystems.function.key", "10719c17-507c-4591-a159-781066b20761");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchOnChangedWorkflow");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.DropdownSearchOnChangedWorkflow$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
var listIndexOfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_SpecialWorkflowSelected.l_ApprovalProcessId = LongIntegerToIdentifier
model.variables.l_SpecialWorkflowSelectedVar.l_ApprovalProcessIdAttr = OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr));
// l_FirstApproverUserId = NullTextIdentifier
model.variables.l_FirstApproverUserIdVar = OS$BuiltinFunctions.nullTextIdentifier();
// o_IsActiveDEV_FlujoRRHH?
return OS$Flow.executeSequence(function () {
if((model.variables.getSettingsDataAct.o_IsActiveDEV_FlujoRRHHOut)) {
// Execute Action: ListIndexOf
listIndexOfVar.value = OS$SystemActions.listIndexOf(model.variables.getSpecialWorkflowsDataAct.approvalProcessListOut, function (p) {
return p.idAttr.equals(model.variables.l_SpecialWorkflowSelectedVar.l_ApprovalProcessIdAttr);
}, callContext);

// l_SpecialWorkflowSelected.l_IsSelectFirstApprover = If
model.variables.l_SpecialWorkflowSelectedVar.l_IsSelectFirstApproverAttr = (((listIndexOfVar.value.positionOut === (-1))) ? (false) : (model.variables.getSpecialWorkflowsDataAct.approvalProcessListOut.getItem(listIndexOfVar.value.positionOut).isSelectFirstApproverAttr));
// l_IsSelectFirstApprover?
return OS$Flow.executeSequence(function () {
if((model.variables.l_SpecialWorkflowSelectedVar.l_IsSelectFirstApproverAttr)) {
// Refresh Query: GetFirstApproverList
var result = controller.getFirstApproverList$DataActRefresh(callContext);
model.flush();
return result;
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
span.setAttribute("outsystems.function.key", "3fa5cf8a-b734-492d-84bb-c644c78db247");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSpecialWorkflows
var result = controller.getSpecialWorkflows$DataActRefresh(callContext);
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
_confirmOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ConfirmOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "7ff434ac-89a4-41fa-8808-873238dafc18");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ConfirmOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.l_SpecialWorkflowSelectedVar.l_ApprovalProcessIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("UEtx0js1Iki_Uqz1w4khxA#Message.1547875572.1", "You need to select a special workflow!"), /*Error*/ 3);
} else {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_SpecialWorkflowSelectedVar.l_IsSelectFirstApproverAttr && (model.variables.l_FirstApproverUserIdVar === OS$BuiltinFunctions.nullTextIdentifier())))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("F9Ey+UPEdEqiaH6b7HxTJQ#Message.-994905853.1", "This special workflow requires you to select the first approver!"), /*Error*/ 3);
} else {
// Trigger Event: SelectWorkflow
return controller.selectWorkflow$Action(model.variables.l_SpecialWorkflowSelectedVar.l_ApprovalProcessIdAttr, model.variables.l_FirstApproverUserIdVar, callContext);
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
_dropdownSearchOnChangedFirstApprover$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedFirstApprover", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedFirstApprover");
span.setAttribute("outsystems.function.key", "9fb2c336-1d45-471d-b6b9-c882999b8471");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchOnChangedFirstApprover");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.DropdownSearchOnChangedFirstApprover$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// l_FirstApproverUserId = TextToIdentifier
model.variables.l_FirstApproverUserIdVar = OS$BuiltinFunctions.textToIdentifier(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

dropdownSearchOnChangedWorkflow$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedWorkflow__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedWorkflow");
span.setAttribute("outsystems.function.key", "10719c17-507c-4591-a159-781066b20761");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchOnChangedWorkflow$Action, callContext, selectedOptionListIn);
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
span.setAttribute("outsystems.function.key", "3fa5cf8a-b734-492d-84bb-c644c78db247");
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

confirmOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ConfirmOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "7ff434ac-89a4-41fa-8808-873238dafc18");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._confirmOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdownSearchOnChangedFirstApprover$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedFirstApprover__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedFirstApprover");
span.setAttribute("outsystems.function.key", "9fb2c336-1d45-471d-b6b9-c882999b8471");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchOnChangedFirstApprover$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get selectWorkflow$Action() {if(!(this.hasOwnProperty("_selectWorkflow$Action"))) {
this._selectWorkflow$Action = function () {
return Promise.resolve();
};
}

return this._selectWorkflow$Action;
}set selectWorkflow$Action(value) {this._selectWorkflow$Action = value;
}

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.DropdownSearchOnChangedWorkflow$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.DropdownSearchOnChangedFirstApprover$vars", [{
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


