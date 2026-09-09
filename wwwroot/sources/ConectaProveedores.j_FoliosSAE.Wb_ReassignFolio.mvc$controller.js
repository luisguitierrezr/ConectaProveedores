import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { ST_6fc999fa8f6e0055c73f2f167c4bad19Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioApprovalLevelsByAssignedTo$AggrRefresh: -1,
getUserApplicationRoles$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getFolioApprovalLevelsByAssignedTo$AggrRefresh: [],
getUserApplicationRoles$DataActRefresh: ["getFolioApprovalLevelsByAssignedTo$AggrRefresh"]
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
folioReassignGeneral$ServerAction(i_SourceUserIdIn, i_TargetUserIdIn, i_MotiveIn, i_FolioApprovalLevelListIn, i_IsInvoiceApprovalIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioReassignGeneral", function (span) {
if(span) {
span.setAttribute("code.function", "FolioReassignGeneral");
span.setAttribute("outsystems.function.key", "948f5f87-ddfb-4804-890c-c79a190662b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_SourceUserId: OS$DataConversion.ServerDataConverter.to(i_SourceUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_TargetUserId: OS$DataConversion.ServerDataConverter.to(i_TargetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Motive: OS$DataConversion.ServerDataConverter.to(i_MotiveIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_FolioApprovalLevelList: OS$DataConversion.ServerDataConverter.to(i_FolioApprovalLevelListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
i_IsInvoiceApproval: OS$DataConversion.ServerDataConverter.to(i_IsInvoiceApprovalIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioReassignGeneral", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolio/ActionFolioReassignGeneral", "FcUAb2GKO_hyEOoTOU+nRg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio$ActionFolioReassignGeneral"))();
executeServerActionResult.o_NotificationContentOut = OS$DataConversion.ServerDataConverter.from(outputs.o_NotificationContent, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure);
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

// Aggregates and Data Actions
get getFolioApprovalLevelsByAssignedTo$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioApprovalLevelsByAssignedTo$AggrRefresh"))) {
this._getFolioApprovalLevelsByAssignedTo$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioApprovalLevelsByAssignedTo", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolio/ScreenDataSetGetFolioApprovalLevelsByAssignedTo", "9TbeEhXx0NXYOqN1wsI+eg", maxRecords, startIndex, function (b) {
model.variables.getFolioApprovalLevelsByAssignedToAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioApprovalLevelsByAssignedToAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioApprovalLevelsByAssignedToAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioApprovalLevelsByAssignedTo", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalLevelsByAssignedTo");
span.setAttribute("outsystems.function.key", "47ac182b-3ed8-4135-8660-baca1c82adc1");
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

return this._getFolioApprovalLevelsByAssignedTo$AggrRefresh;
}set getFolioApprovalLevelsByAssignedTo$AggrRefresh(value) {this._getFolioApprovalLevelsByAssignedTo$AggrRefresh = value;
}

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_ReassignFolio/DataActionGetUserApplicationRoles", "Em4eq0ND_srkNxUcMKHmYA", function (b) {
model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserApplicationRolesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRoles", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRoles");
span.setAttribute("outsystems.function.key", "2a58e82a-0105-41c8-bf81-cf798fad41a8");
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

return this._getUserApplicationRoles$DataActRefresh;
}set getUserApplicationRoles$DataActRefresh(value) {this._getUserApplicationRoles$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioApprovalLevelsByAssignedTo$AggrRefresh", "getUserApplicationRoles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "06297ae6-1ea7-4fa4-8497-4c3382e95a2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetFolioApprovalLevelsByAssignedTo
var result = controller.getFolioApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_replaceOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ReplaceOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ReplaceOnClick");
span.setAttribute("outsystems.function.key", "28ee28ce-bf5a-4f29-951e-8ee32e52fa7a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ReplaceOnClick");
callContext = controller.callContext(callContext);
// Any field empty or not selected?
if((((((model.variables.l_SourceUserIdVar === OS$BuiltinFunctions.nullTextIdentifier()) || (model.variables.l_SubstituteUserIdVar === OS$BuiltinFunctions.nullTextIdentifier())) || (OS$BuiltinFunctions.trim(model.variables.l_MotiveVar) === "")) || ((!(model.variables.l_IsSelectAllVar)) && (!(model.variables.l_IsSelectVar)))))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JQ78tptjpUCC5iABu6I6Qg#Message.1463715464.1", "Please make sure you\'ve selected an original user, a substitute, at least one Folio and provide a reason for the reassignment!"), /*Error*/ 3);
} else {
// l_ShowConfirmPopup = True
model.variables.l_ShowConfirmPopupVar = true;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_SearchUserOriginal$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchUserOriginal", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserOriginal");
span.setAttribute("outsystems.function.key", "2c91c5f4-0896-404e-985f-968deed8a3b2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SearchUserOriginal");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.Wb_SearchUserOriginal$vars"))());
vars.value.userIdInLocal = userIdIn;
return OS$Flow.executeAsyncFlow(function () {
// l_SourceUserId = UserId
model.variables.l_SourceUserIdVar = vars.value.userIdInLocal;
return OS$Flow.executeSequence(function () {
if((((model.variables.l_SourceUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Refresh Query: GetUserApplicationRoles
var result = controller.getUserApplicationRoles$DataActRefresh(callContext);
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
_wb_ConfirmPopupConfirm$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_ConfirmPopupConfirm", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ConfirmPopupConfirm");
span.setAttribute("outsystems.function.key", "3356b343-b3b5-4420-a4fb-4a6d2836395d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_ConfirmPopupConfirm");
callContext = controller.callContext(callContext);
var folioReassignGeneralVar = new OS$DataTypes.VariableHolder();
var listFilterIsSelectedVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListFilterIsSelected
listFilterIsSelectedVar.value = OS$SystemActions.listFilter(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut, function (p) {
return p.isSelectedAttr;
}, callContext);

// Execute Action: FolioReassignGeneral
model.flush();
return controller.folioReassignGeneral$ServerAction(model.variables.l_SourceUserIdVar, model.variables.l_SubstituteUserIdVar, model.variables.l_MotiveVar, OS$DataConversion.JSConversions.typeConvertRecordList(listFilterIsSelectedVar.value.filteredListOut, new OS$DataTypes.LongIntegerList(), function (source, target) {
target = source.folioApprovalLevelAttr.idAttr;
return target;
}), model.variables.i_IsInvoiceApprovalIn, callContext).then(function (value) {
folioReassignGeneralVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((((folioReassignGeneralVar.value.errorMessageOut) !== ("")))) {
// Execute Action: Wb_ConfirmPopupClose
controller._wb_ConfirmPopupClose$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(folioReassignGeneralVar.value.errorMessageOut, /*Error*/ 3);
} else {
// Execute Action: Wb_ConfirmPopupClose2
controller._wb_ConfirmPopupClose$Action(callContext);
// Trigger Event: Confirm
return controller.confirm$Action(folioReassignGeneralVar.value.o_NotificationContentOut, callContext).then(function () {
// l_SourceUserId = NullTextIdentifier
model.variables.l_SourceUserIdVar = OS$BuiltinFunctions.nullTextIdentifier();
// l_SubstituteUserId = NullTextIdentifier
model.variables.l_SubstituteUserIdVar = OS$BuiltinFunctions.nullTextIdentifier();
// l_Motive = ""
model.variables.l_MotiveVar = "";
// l_IsSelectAll = False
model.variables.l_IsSelectAllVar = false;
// l_IsSelect = False
model.variables.l_IsSelectVar = false;
});
}

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
_wb_SearchUserSubstitute$Action(userIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchUserSubstitute", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserSubstitute");
span.setAttribute("outsystems.function.key", "59ddf45e-3699-41d8-b4fe-3212e6a7ba06");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SearchUserSubstitute");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.Wb_SearchUserSubstitute$vars"))());
vars.value.userIdInLocal = userIdIn;
// l_SubstituteUserId = UserId
model.variables.l_SubstituteUserIdVar = vars.value.userIdInLocal;
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
span.setAttribute("outsystems.function.key", "b37c8b92-81ab-438c-b552-c8a4dc8fc9e2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((false)) {
// Refresh Query: GetFolioApprovalLevelsByAssignedTo
var result = controller.getFolioApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_checkbox_IsSelectedOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Checkbox_IsSelectedOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Checkbox_IsSelectedOnChange");
span.setAttribute("outsystems.function.key", "c1555448-c65b-4bb6-a307-e23771d9a80a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Checkbox_IsSelectedOnChange");
callContext = controller.callContext(callContext);
var listIndexOfNotIsSelectedVar = new OS$DataTypes.VariableHolder();
if((model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)) {
// l_IsSelect = True
model.variables.l_IsSelectVar = true;
} else {
// l_IsSelect = False
model.variables.l_IsSelectVar = false;
}

// Execute Action: ListIndexOfNotIsSelected
listIndexOfNotIsSelectedVar.value = OS$SystemActions.listIndexOf(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut, function (p) {
return (!(p.isSelectedAttr));
}, callContext);

// l_IsSelectAll = ListIndexOfNotIsSelected.Position = -1
model.variables.l_IsSelectAllVar = (listIndexOfNotIsSelectedVar.value.positionOut === (-1));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_ConfirmPopupClose$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_ConfirmPopupClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ConfirmPopupClose");
span.setAttribute("outsystems.function.key", "f41ab860-2246-447b-9929-50f07352ad93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_ConfirmPopupClose");
callContext = controller.callContext(callContext);
// l_ShowConfirmPopup = False
model.variables.l_ShowConfirmPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_checkbox_IsSelectAllOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Checkbox_IsSelectAllOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Checkbox_IsSelectAllOnChange");
span.setAttribute("outsystems.function.key", "f43ac4a0-1e1d-43be-9f0c-044ecab3c9ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Checkbox_IsSelectAllOnChange");
callContext = controller.callContext(callContext);
// Foreach GetFolioApprovalLevelsByAssignedTo.List
callContext.iterationContext.registerIterationStart(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut);
try {var getFolioApprovalLevelsByAssignedToIterator = callContext.iterationContext.getIterator(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut);
var getFolioApprovalLevelsByAssignedToIndex = 0;
while (((getFolioApprovalLevelsByAssignedToIndex < model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.length))) {
getFolioApprovalLevelsByAssignedToIterator.currentRowNumber = getFolioApprovalLevelsByAssignedToIndex;
// GetFolioApprovalLevelsByAssignedTo.List.Current.IsSelected = l_IsSelectAll
model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut.getItem(getFolioApprovalLevelsByAssignedToIndex.valueOf()).isSelectedAttr = model.variables.l_IsSelectAllVar;
getFolioApprovalLevelsByAssignedToIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getFolioApprovalLevelsByAssignedToAggr.listOut);
}

// l_IsSelect = l_IsSelectAll
model.variables.l_IsSelectVar = model.variables.l_IsSelectAllVar;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "f94def88-8e85-4521-840e-3049954664d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioApprovalLevelsByAssignedTo
var result = controller.getFolioApprovalLevelsByAssignedTo$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "06297ae6-1ea7-4fa4-8497-4c3382e95a2b");
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

replaceOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ReplaceOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ReplaceOnClick");
span.setAttribute("outsystems.function.key", "28ee28ce-bf5a-4f29-951e-8ee32e52fa7a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._replaceOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_SearchUserOriginal$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchUserOriginal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserOriginal");
span.setAttribute("outsystems.function.key", "2c91c5f4-0896-404e-985f-968deed8a3b2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SearchUserOriginal$Action, callContext, userIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_ConfirmPopupConfirm$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_ConfirmPopupConfirm__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ConfirmPopupConfirm");
span.setAttribute("outsystems.function.key", "3356b343-b3b5-4420-a4fb-4a6d2836395d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_ConfirmPopupConfirm$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SearchUserSubstitute$Action(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchUserSubstitute__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchUserSubstitute");
span.setAttribute("outsystems.function.key", "59ddf45e-3699-41d8-b4fe-3212e6a7ba06");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SearchUserSubstitute$Action, callContext, userIdIn);
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
span.setAttribute("outsystems.function.key", "b37c8b92-81ab-438c-b552-c8a4dc8fc9e2");
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

checkbox_IsSelectedOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Checkbox_IsSelectedOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Checkbox_IsSelectedOnChange");
span.setAttribute("outsystems.function.key", "c1555448-c65b-4bb6-a307-e23771d9a80a");
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

wb_ConfirmPopupClose$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_ConfirmPopupClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ConfirmPopupClose");
span.setAttribute("outsystems.function.key", "f41ab860-2246-447b-9929-50f07352ad93");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_ConfirmPopupClose$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

checkbox_IsSelectAllOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Checkbox_IsSelectAllOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Checkbox_IsSelectAllOnChange");
span.setAttribute("outsystems.function.key", "f43ac4a0-1e1d-43be-9f0c-044ecab3c9ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._checkbox_IsSelectAllOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "f94def88-8e85-4521-840e-3049954664d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUserApplicationRolesOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get confirm$Action() {if(!(this.hasOwnProperty("_confirm$Action"))) {
this._confirm$Action = function () {
return Promise.resolve();
};
}

return this._confirm$Action;
}set confirm$Action(value) {this._confirm$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio$ActionFolioReassignGeneral", [{
name: "o_NotificationContent",
attrName: "o_NotificationContentOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
},
complexType: ST_6fc999fa8f6e0055c73f2f167c4bad19Structure
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.Wb_SearchUserOriginal$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_ReassignFolio.Wb_SearchUserSubstitute$vars", [{
name: "UserId",
attrName: "userIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


