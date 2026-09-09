import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { dropdownClearValidation$Action as OutSystemsUIController$dropdownClearValidation$Action, dropdownNotValid$Action as OutSystemsUIController$dropdownNotValid$Action, dropdownClear$Action as OutSystemsUIController$dropdownClear$Action, dropdownClose$Action as OutSystemsUIController$dropdownClose$Action } from "./OutSystemsUI.controller.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_mvc_TranslationsResources from "./ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.mvc$translationsResources.js";
import { ST_6fc999fa8f6e0055c73f2f167c4bad19Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSourceUserByEntraId$AggrRefresh: -1,
getSourceUserContent$DataActRefresh: -1,
getUsersTarget$DataActRefresh: -1,
getUsersSource$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getSourceUserByEntraId$AggrRefresh: ["getUsersTarget$DataActRefresh"],
getSourceUserContent$DataActRefresh: [],
getUsersTarget$DataActRefresh: [],
getUsersSource$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
reassign$ServerAction(invListIn, reqListIn, i_TargetUserAUEntraIdIn, i_ReasonIn, i_SourceUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Reassign", function (span) {
if(span) {
span.setAttribute("code.function", "Reassign");
span.setAttribute("outsystems.function.key", "925670dc-8e5e-4858-8873-923ab905c3f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
InvList: OS$DataConversion.ServerDataConverter.to(invListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
ReqList: OS$DataConversion.ServerDataConverter.to(reqListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_TargetUserAUEntraId: OS$DataConversion.ServerDataConverter.to(i_TargetUserAUEntraIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Reason: OS$DataConversion.ServerDataConverter.to(i_ReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_SourceUserId: OS$DataConversion.ServerDataConverter.to(i_SourceUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Reassign", "screenservices/ConectaProveedores/a_Reassignments/Wb_ReassignmentForm/ActionReassign", "KEJJgTOVAyxU3ze3Zh_U5w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm$ActionReassign"))();
executeServerActionResult.o_NotificationContentOut = OS$DataConversion.ServerDataConverter.from(outputs.o_NotificationContent, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure);
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
get getSourceUserByEntraId$AggrRefresh() {if(!(this.hasOwnProperty("_getSourceUserByEntraId$AggrRefresh"))) {
this._getSourceUserByEntraId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSourceUserByEntraId", "screenservices/ConectaProveedores/a_Reassignments/Wb_ReassignmentForm/ScreenDataSetGetSourceUserByEntraId", "_eEoaK3hjpQQwQeweC9GrQ", maxRecords, startIndex, function (b) {
model.variables.getSourceUserByEntraIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSourceUserByEntraIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSourceUserByEntraIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSourceUserByEntraIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSourceUserByEntraId", function (span) {
if(span) {
span.setAttribute("code.function", "GetSourceUserByEntraId");
span.setAttribute("outsystems.function.key", "e71edb2c-5848-4168-861c-998ab2f652fd");
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

return this._getSourceUserByEntraId$AggrRefresh;
}set getSourceUserByEntraId$AggrRefresh(value) {this._getSourceUserByEntraId$AggrRefresh = value;
}

get getSourceUserContent$DataActRefresh() {if(!(this.hasOwnProperty("_getSourceUserContent$DataActRefresh"))) {
this._getSourceUserContent$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSourceUserContent", "screenservices/ConectaProveedores/a_Reassignments/Wb_ReassignmentForm/DataActionGetSourceUserContent", "Vm9Q1MPOI8X7NXDdEKOSjA", function (b) {
model.variables.getSourceUserContentDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSourceUserContentDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSourceUserContentDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSourceUserContentOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSourceUserContent", function (span) {
if(span) {
span.setAttribute("code.function", "GetSourceUserContent");
span.setAttribute("outsystems.function.key", "0003791f-5947-4044-8d78-6ad52795fd9c");
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

return this._getSourceUserContent$DataActRefresh;
}set getSourceUserContent$DataActRefresh(value) {this._getSourceUserContent$DataActRefresh = value;
}

get getUsersTarget$DataActRefresh() {if(!(this.hasOwnProperty("_getUsersTarget$DataActRefresh"))) {
this._getUsersTarget$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUsersTarget", "screenservices/ConectaProveedores/a_Reassignments/Wb_ReassignmentForm/DataActionGetUsersTarget", "YeJIvyFT8kQy8RlPocF2bA", function (b) {
model.variables.getUsersTargetDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersTargetDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersTargetDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsersTarget", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsersTarget");
span.setAttribute("outsystems.function.key", "296b6aa2-90f9-48e2-ba58-605be8df35fb");
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

return this._getUsersTarget$DataActRefresh;
}set getUsersTarget$DataActRefresh(value) {this._getUsersTarget$DataActRefresh = value;
}

get getUsersSource$DataActRefresh() {if(!(this.hasOwnProperty("_getUsersSource$DataActRefresh"))) {
this._getUsersSource$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUsersSource", "screenservices/ConectaProveedores/a_Reassignments/Wb_ReassignmentForm/DataActionGetUsersSource", "V2AkkDVJnc1CWzkqTLI_Hg", function (b) {
model.variables.getUsersSourceDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersSourceDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersSourceDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getUsersSourceOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUsersSource", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsersSource");
span.setAttribute("outsystems.function.key", "cdc89d7d-5ea7-44f0-8c7c-0956e37c50e3");
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

return this._getUsersSource$DataActRefresh;
}set getUsersSource$DataActRefresh(value) {this._getUsersSource$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSourceUserByEntraId$AggrRefresh", "getSourceUserContent$DataActRefresh", "getUsersTarget$DataActRefresh", "getUsersSource$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getUsersSourceOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUsersSourceOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsersSourceOnAfterFetch");
span.setAttribute("outsystems.function.key", "08b2d96a-d261-4ce3-877b-06e5f6c63b73");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetUsersSourceOnAfterFetch");
callContext = controller.callContext(callContext);
if((model.variables.getUsersSourceDataAct.o_HasErrorOut)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XMXOvcRHeE2lyefr0dCvCg#Message.-1965238662.1", "Error getting information from Active Directory. You will not be able to create new Reassignemnts."), /*Error*/ 3);
}

} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "0a346d4b-9fe8-4a7c-8926-ef6289300b86");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ConfirmOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.ConfirmOnClick$vars"))());
var reassignVar = new OS$DataTypes.VariableHolder();
var dropdownNotValidVar = new OS$DataTypes.VariableHolder();
var dropdownClearSourceUserVar = new OS$DataTypes.VariableHolder();
var dropdownClearValidationVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: DropdownClearValidation
dropdownClearValidationVar.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("DD_SourceUser"), callContext);

// l_FormValid = True
vars.value.l_FormValidVar = true;
return OS$Flow.executeSequence(function () {
if((!((!(model.widgets.get(idService.getId("Form")).validAttr))))) {
if(((model.variables.l_SourceUserIdVar === OS$BuiltinFunctions.nullTextIdentifier()))) {
// Execute Action: DropdownNotValid
dropdownNotValidVar.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("DD_SourceUser"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("48OSJHrJNUOPuI_TVYcO3g#Value.-2070237913.1", "Select the Original user"), callContext);

// l_FormValid = False
vars.value.l_FormValidVar = false;
}

if(((model.variables.l_TargetUserAUEntraIdVar === ""))) {
// l_FormValid = False
vars.value.l_FormValidVar = false;
}

// l_FormValid = l_FormValid and l_IsAllowConfirm
vars.value.l_FormValidVar = (vars.value.l_FormValidVar && model.variables.l_IsAllowConfirmVar);
return OS$Flow.executeSequence(function () {
if((vars.value.l_FormValidVar)) {
// Execute Action: Reassign
model.flush();
return controller.reassign$ServerAction(model.variables.getSourceUserContentDataAct.invListOut, model.variables.getSourceUserContentDataAct.reqListOut, model.variables.l_TargetUserAUEntraIdVar, model.variables.l_ReasonVar, model.variables.l_SourceUserIdVar, callContext).then(function (value) {
reassignVar.value = value;
}).then(function () {
// IsSuccess?
return OS$Flow.executeSequence(function () {
if((reassignVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Confirm
return controller.confirm$Action(reassignVar.value.o_NotificationContentOut, callContext).then(function () {
// Execute Action: DropdownClearSourceUser
dropdownClearSourceUserVar.value = OutSystemsUIController$dropdownClear$Action(idService.getId("DD_SourceUser"), true, callContext);

// l_SourceUserEntraId = ""
model.variables.l_SourceUserEntraIdVar = "";
// Refresh Query: GetSourceUserByEntraId
var result = controller.getSourceUserByEntraId$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// l_Reason = ""
model.variables.l_ReasonVar = "";
});
} else {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(reassignVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
});
} else {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_getSourceUserContentOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSourceUserContentOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSourceUserContentOnAfterFetch");
span.setAttribute("outsystems.function.key", "152076cc-e957-4a85-bc58-a82ed8c5690f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSourceUserContentOnAfterFetch");
callContext = controller.callContext(callContext);
// l_IsAllowConfirm = notGetSourceUserContent.ReqList.Empty or notGetSourceUserContent.InvList.Empty
model.variables.l_IsAllowConfirmVar = ((!(model.variables.getSourceUserContentDataAct.reqListOut.isEmpty)) || (!(model.variables.getSourceUserContentDataAct.invListOut.isEmpty)));
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "338c6046-7981-4c9b-a30b-7a59b8560c33");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
var dropdownCloseVar = new OS$DataTypes.VariableHolder();
var dropdownClose2Var = new OS$DataTypes.VariableHolder();
if((!(model.variables.i_IsSidebarOpenIn))) {
// Execute Action: DropdownClose
dropdownCloseVar.value = OutSystemsUIController$dropdownClose$Action(idService.getId("DD_SourceUser"), callContext);

// Execute Action: DropdownClose2
dropdownClose2Var.value = OutSystemsUIController$dropdownClose$Action(idService.getId("DD_TargetUserAU"), callContext);

}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_checkbox_IsSelectedOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Checkbox_IsSelectedOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Checkbox_IsSelectedOnChange");
span.setAttribute("outsystems.function.key", "6ab9cc4f-3bba-403d-86f7-4ba4c5144cfd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Checkbox_IsSelectedOnChange");
callContext = controller.callContext(callContext);
var listIndexOfReqListVar = new OS$DataTypes.VariableHolder();
var listIndexOfInvListVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListIndexOfReqList
listIndexOfReqListVar.value = OS$SystemActions.listIndexOf(model.variables.getSourceUserContentDataAct.reqListOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// Execute Action: ListIndexOfInvList
listIndexOfInvListVar.value = OS$SystemActions.listIndexOf(model.variables.getSourceUserContentDataAct.invListOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// Found?
if(((((listIndexOfReqListVar.value.positionOut) !== ((-1))) || ((listIndexOfInvListVar.value.positionOut) !== ((-1)))))) {
// l_IsAllowConfirm = True
model.variables.l_IsAllowConfirmVar = true;
} else {
// l_IsAllowConfirm = False
model.variables.l_IsAllowConfirmVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dD_TargetUserAUOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DD_TargetUserAUOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DD_TargetUserAUOnChanged");
span.setAttribute("outsystems.function.key", "b1744e9e-7e1a-40d6-bb20-18a5fd4654c6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DD_TargetUserAUOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.DD_TargetUserAUOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// l_TargetUserAUEntraId = SelectedOptionList.Current.Value
model.variables.l_TargetUserAUEntraIdVar = vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_searchOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SearchOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnChange");
span.setAttribute("outsystems.function.key", "ce4c1c9a-e309-4f82-b1f0-120e0782aad9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSourceUserContent
var result = controller.getSourceUserContent$DataActRefresh(callContext);
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
_getSourceUserByEntraIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSourceUserByEntraIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSourceUserByEntraIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "d5090eb5-aa5f-4e43-9bc3-fc13c5e3ab1b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSourceUserByEntraIdOnAfterFetch");
callContext = controller.callContext(callContext);
var dropdownClearTargetUserVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((model.variables.l_SourceUserEntraIdVar === (OS$BuiltinFunctions.nullIdentifier()).toString()) || model.variables.getSourceUserByEntraIdAggr.listOut.isEmpty))) {
// l_SourceUserId = NullTextIdentifier
model.variables.l_SourceUserIdVar = OS$BuiltinFunctions.nullTextIdentifier();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.getSourceUserContentDataAct.reqListOut, callContext);
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.getSourceUserContentDataAct.invListOut, callContext);
// Execute Action: DropdownClearTargetUser
dropdownClearTargetUserVar.value = OutSystemsUIController$dropdownClear$Action(idService.getId("DD_TargetUserAU"), true, callContext);

} else {
// l_SourceUserId = GetSourceUserByEntraId.List.Current.User.Id
model.variables.l_SourceUserIdVar = model.variables.getSourceUserByEntraIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.idAttr;
// Refresh Query: GetSourceUserContent
var result = controller.getSourceUserContent$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetUsersTarget
var result = controller.getUsersTarget$DataActRefresh(callContext);
model.flush();
return result;
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
_dD_SourceUserOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DD_SourceUserOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DD_SourceUserOnChanged");
span.setAttribute("outsystems.function.key", "dbb25e3b-390a-453c-b944-7dce084d8197");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DD_SourceUserOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.DD_SourceUserOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// l_SourceUserEntraId = SelectedOptionList.Current.Value
model.variables.l_SourceUserEntraIdVar = vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr;
// Refresh Query: GetSourceUserByEntraId
var result = controller.getSourceUserByEntraId$AggrRefresh(1, 0, callContext);
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

getUsersSourceOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUsersSourceOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsersSourceOnAfterFetch");
span.setAttribute("outsystems.function.key", "08b2d96a-d261-4ce3-877b-06e5f6c63b73");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getUsersSourceOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

confirmOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ConfirmOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ConfirmOnClick");
span.setAttribute("outsystems.function.key", "0a346d4b-9fe8-4a7c-8926-ef6289300b86");
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

getSourceUserContentOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSourceUserContentOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSourceUserContentOnAfterFetch");
span.setAttribute("outsystems.function.key", "152076cc-e957-4a85-bc58-a82ed8c5690f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSourceUserContentOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "338c6046-7981-4c9b-a30b-7a59b8560c33");
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

checkbox_IsSelectedOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Checkbox_IsSelectedOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Checkbox_IsSelectedOnChange");
span.setAttribute("outsystems.function.key", "6ab9cc4f-3bba-403d-86f7-4ba4c5144cfd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkbox_IsSelectedOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dD_TargetUserAUOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DD_TargetUserAUOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DD_TargetUserAUOnChanged");
span.setAttribute("outsystems.function.key", "b1744e9e-7e1a-40d6-bb20-18a5fd4654c6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dD_TargetUserAUOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

searchOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnChange");
span.setAttribute("outsystems.function.key", "ce4c1c9a-e309-4f82-b1f0-120e0782aad9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._searchOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getSourceUserByEntraIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSourceUserByEntraIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSourceUserByEntraIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "d5090eb5-aa5f-4e43-9bc3-fc13c5e3ab1b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSourceUserByEntraIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dD_SourceUserOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DD_SourceUserOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DD_SourceUserOnChanged");
span.setAttribute("outsystems.function.key", "dbb25e3b-390a-453c-b944-7dce084d8197");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dD_SourceUserOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
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

get confirm$Action() {if(!(this.hasOwnProperty("_confirm$Action"))) {
this._confirm$Action = function () {
return Promise.resolve();
};
}

return this._confirm$Action;
}set confirm$Action(value) {this._confirm$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm$ActionReassign", [{
name: "o_NotificationContent",
attrName: "o_NotificationContentOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
},
complexType: ST_6fc999fa8f6e0055c73f2f167c4bad19Structure
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
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.ConfirmOnClick$vars", [{
name: "l_FormValid",
attrName: "l_FormValidVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.DD_TargetUserAUOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.DD_SourceUserOnChanged$vars", [{
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


