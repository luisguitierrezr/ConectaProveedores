import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { EN_20bdea9cf8f17569719f414a83b584b6EntityRecord, ST_346a76e47f982dbf41625f8a893affccStructure } from "./SecurityAuth.model.js";
import { SE_roleStatus as ConectaProveedores_staticEntities_roleStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_TranslationsResources from "./ConectaProveedores.a_Common.Wb_TempRoleAssignments.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getUserApplicationRoleTempsByUserId$AggrRefresh: 0,
getUserApplicationRoleTempsByAssignedBy$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserApplicationRoleTempsByUserId$AggrRefresh: [],
getUserApplicationRoleTempsByAssignedBy$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
serviceUserApplicationRoleTempRevoke$ServerAction(sourceIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceUserApplicationRoleTempRevoke", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceUserApplicationRoleTempRevoke");
span.setAttribute("outsystems.function.key", "f664729f-e9c8-4663-ab65-602341b32073");
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
return controller.callServerAction("ServiceUserApplicationRoleTempRevoke", "screenservices/ConectaProveedores/a_Common/Wb_TempRoleAssignments/ServiceAPIServiceUserApplicationRoleTempRevoke", "oGRxmLjmaDt2TDUkhHTUqg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments$ServiceAPIServiceUserApplicationRoleTempRevoke"))();
executeServerActionResult.idOut = OS$DataConversion.ServerDataConverter.from(outputs.Id, OS$DataTypes.DataTypes.LongInteger);
executeServerActionResult.outputOut = OS$DataConversion.ServerDataConverter.from(outputs.Output, ST_346a76e47f982dbf41625f8a893affccStructure);
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
get getUserApplicationRoleTempsByUserId$AggrRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoleTempsByUserId$AggrRefresh"))) {
this._getUserApplicationRoleTempsByUserId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserApplicationRoleTempsByUserId", "screenservices/ConectaProveedores/a_Common/Wb_TempRoleAssignments/ScreenDataSetGetUserApplicationRoleTempsByUserId", "9OWUt54ngKqlYpSl8CxZXw", maxRecords, startIndex, function (b) {
model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRoleTempsByUserIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRoleTempsByUserIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRoleTempsByUserId", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRoleTempsByUserId");
span.setAttribute("outsystems.function.key", "345ef0eb-1f20-43b6-9b8c-277dbaeb50c4");
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

return this._getUserApplicationRoleTempsByUserId$AggrRefresh;
}set getUserApplicationRoleTempsByUserId$AggrRefresh(value) {this._getUserApplicationRoleTempsByUserId$AggrRefresh = value;
}

get getUserApplicationRoleTempsByAssignedBy$AggrRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoleTempsByAssignedBy$AggrRefresh"))) {
this._getUserApplicationRoleTempsByAssignedBy$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserApplicationRoleTempsByAssignedBy", "screenservices/ConectaProveedores/a_Common/Wb_TempRoleAssignments/ScreenDataSetGetUserApplicationRoleTempsByAssignedBy", "MKMU03LLht8oKYsxgwXUIg", maxRecords, startIndex, function (b) {
model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRoleTempsByAssignedByAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRoleTempsByAssignedByAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRoleTempsByAssignedBy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRoleTempsByAssignedBy");
span.setAttribute("outsystems.function.key", "62d2bfbc-275a-4c78-a751-e150315e83a4");
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

return this._getUserApplicationRoleTempsByAssignedBy$AggrRefresh;
}set getUserApplicationRoleTempsByAssignedBy$AggrRefresh(value) {this._getUserApplicationRoleTempsByAssignedBy$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserApplicationRoleTempsByUserId$AggrRefresh", "getUserApplicationRoleTempsByAssignedBy$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_showHideConfirmPopup$Action(i_UserApplicationRoleTempIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideConfirmPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideConfirmPopup");
span.setAttribute("outsystems.function.key", "28482c87-2d0b-40bb-9493-c91705c7a85e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideConfirmPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.ShowHideConfirmPopup$vars"))());
vars.value.i_UserApplicationRoleTempInLocal = i_UserApplicationRoleTempIn.clone();
// l_ShowConfirmPopup = notl_ShowConfirmPopup
model.variables.l_ShowConfirmPopupVar = (!(model.variables.l_ShowConfirmPopupVar));
// l_UserApplicationRoleTemp = i_UserApplicationRoleTemp
model.variables.l_UserApplicationRoleTempVar = vars.value.i_UserApplicationRoleTempInLocal;
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "284df72f-81e8-468f-b363-fc0eef231542");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_ConfirmPopupConfirm");
callContext = controller.callContext(callContext);
var serviceUserApplicationRoleTempRevokeVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_UserApplicationRoleTemp.RevokedBy = GetUserId
model.variables.l_UserApplicationRoleTempVar.revokedByAttr = OS$BuiltinFunctions.getUserId();
// l_UserApplicationRoleTemp.RevokedDate = CurrDate
model.variables.l_UserApplicationRoleTempVar.revokedDateAttr = OS$BuiltinFunctions.currDate();
// l_UserApplicationRoleTemp.RoleStatusId = Revoked
model.variables.l_UserApplicationRoleTempVar.roleStatusIdAttr = ConectaProveedores_staticEntities_roleStatus.revoked;
// Execute Action: ServiceUserApplicationRoleTempRevoke
model.flush();
return controller.serviceUserApplicationRoleTempRevoke$ServerAction(model.variables.l_UserApplicationRoleTempVar, callContext).then(function (value) {
serviceUserApplicationRoleTempRevokeVar.value = value;
}).then(function () {
// Refresh Query: GetUserApplicationRoleTempsByAssignedBy
var result = controller.getUserApplicationRoleTempsByAssignedBy$AggrRefresh(model.variables.l_MaxRecordsVar, model.variables.l_StartIndexVar, callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: ShowHideConfirmPopup
controller._showHideConfirmPopup$Action(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1aTr7TXjcE2UU8O2rlJyrA#Message.-627471211.1", "Substitution revoked successfully!"), /*Success*/ 1);
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
span.setAttribute("outsystems.function.key", "28ba61a0-0eb2-485f-8b4b-01a717e52ae4");
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
// Refresh Query: GetUserApplicationRoleTempsByAssignedBy
var result = controller.getUserApplicationRoleTempsByAssignedBy$AggrRefresh(model.variables.l_MaxRecordsVar, model.variables.l_StartIndexVar, callContext);
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
_wb_AssignTempRolePopupSave$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_AssignTempRolePopupSave", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_AssignTempRolePopupSave");
span.setAttribute("outsystems.function.key", "89b36fb3-c8df-44e2-abe3-94faf5532e04");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_AssignTempRolePopupSave");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetUserApplicationRoleTempsByAssignedBy
var result = controller.getUserApplicationRoleTempsByAssignedBy$AggrRefresh(model.variables.l_MaxRecordsVar, model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// Execute Action: ShowHideShowAssignTempRolePopup
controller._showHideShowAssignTempRolePopup$Action(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), callContext);
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
_showHideShowAssignTempRolePopup$Action(i_UserApplicationRoleTempIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideShowAssignTempRolePopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideShowAssignTempRolePopup");
span.setAttribute("outsystems.function.key", "97717e76-cacc-4224-9e15-6e89ab97528d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideShowAssignTempRolePopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.ShowHideShowAssignTempRolePopup$vars"))());
vars.value.i_UserApplicationRoleTempInLocal = i_UserApplicationRoleTempIn.clone();
// l_ShowAssignTempRolePopup = notl_ShowAssignTempRolePopup
model.variables.l_ShowAssignTempRolePopupVar = (!(model.variables.l_ShowAssignTempRolePopupVar));
// l_UserApplicationRoleTemp = i_UserApplicationRoleTemp
model.variables.l_UserApplicationRoleTempVar = vars.value.i_UserApplicationRoleTempInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "a68dcbe0-d64f-45eb-b0a5-1c5c086a38ba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetUserApplicationRoleTempsByAssignedBy
var result = controller.getUserApplicationRoleTempsByAssignedBy$AggrRefresh(model.variables.l_MaxRecordsVar, model.variables.l_StartIndexVar, callContext);
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
_paginationOnNavigateAssigned$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigateAssigned", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigateAssigned");
span.setAttribute("outsystems.function.key", "cc2cefba-d9b2-44d2-915c-2d02ae3869aa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigateAssigned");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.PaginationOnNavigateAssigned$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndexAssigned = NewStartIndex
model.variables.l_StartIndexAssignedVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetUserApplicationRoleTempsByUserId
var result = controller.getUserApplicationRoleTempsByUserId$AggrRefresh(model.variables.l_MaxRecordsAssignedVar, model.variables.l_StartIndexAssignedVar, callContext);
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

showHideConfirmPopup$Action(i_UserApplicationRoleTempIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideConfirmPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideConfirmPopup");
span.setAttribute("outsystems.function.key", "28482c87-2d0b-40bb-9493-c91705c7a85e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideConfirmPopup$Action, callContext, i_UserApplicationRoleTempIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_ConfirmPopupConfirm$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_ConfirmPopupConfirm__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_ConfirmPopupConfirm");
span.setAttribute("outsystems.function.key", "284df72f-81e8-468f-b363-fc0eef231542");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "28ba61a0-0eb2-485f-8b4b-01a717e52ae4");
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

wb_AssignTempRolePopupSave$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_AssignTempRolePopupSave__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_AssignTempRolePopupSave");
span.setAttribute("outsystems.function.key", "89b36fb3-c8df-44e2-abe3-94faf5532e04");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_AssignTempRolePopupSave$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showHideShowAssignTempRolePopup$Action(i_UserApplicationRoleTempIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideShowAssignTempRolePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideShowAssignTempRolePopup");
span.setAttribute("outsystems.function.key", "97717e76-cacc-4224-9e15-6e89ab97528d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideShowAssignTempRolePopup$Action, callContext, i_UserApplicationRoleTempIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "a68dcbe0-d64f-45eb-b0a5-1c5c086a38ba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._paginationOnNavigate$Action, callContext, newStartIndexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

paginationOnNavigateAssigned$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigateAssigned__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigateAssigned");
span.setAttribute("outsystems.function.key", "cc2cefba-d9b2-44d2-915c-2d02ae3869aa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._paginationOnNavigateAssigned$Action, callContext, newStartIndexIn);
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments$ServiceAPIServiceUserApplicationRoleTempRevoke", [{
name: "Id",
attrName: "idOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "Output",
attrName: "outputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_346a76e47f982dbf41625f8a893affccStructure();
},
complexType: ST_346a76e47f982dbf41625f8a893affccStructure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.ShowHideConfirmPopup$vars", [{
name: "i_UserApplicationRoleTemp",
attrName: "i_UserApplicationRoleTempInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
},
complexType: EN_20bdea9cf8f17569719f414a83b584b6EntityRecord
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.ShowHideShowAssignTempRolePopup$vars", [{
name: "i_UserApplicationRoleTemp",
attrName: "i_UserApplicationRoleTempInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
},
complexType: EN_20bdea9cf8f17569719f414a83b584b6EntityRecord
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_TempRoleAssignments.PaginationOnNavigateAssigned$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


