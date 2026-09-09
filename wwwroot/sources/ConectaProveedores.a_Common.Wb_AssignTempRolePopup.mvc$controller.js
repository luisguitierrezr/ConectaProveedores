import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvc_TranslationsResources from "./ConectaProveedores.a_Common.Wb_AssignTempRolePopup.mvc$translationsResources.js";
import { ST_346a76e47f982dbf41625f8a893affccStructure } from "./SecurityAuth.model.js";
import { SE_roleStatus as ConectaProveedores_staticEntities_roleStatus } from "./ConectaProveedores.staticEntities.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getLoggedUserInfo$AggrRefresh: 0,
getUsersFromSameRegion$AggrRefresh: -1
};
this.dataFetchDependentsGraph = {
getLoggedUserInfo$AggrRefresh: ["getUsersFromSameRegion$AggrRefresh"],
getUsersFromSameRegion$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
serviceUserApplicationRoleTempAssign$ServerAction(sourceIn, userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceUserApplicationRoleTempAssign", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceUserApplicationRoleTempAssign");
span.setAttribute("outsystems.function.key", "7e2855ca-bed7-4b9c-a4c5-f62524931567");
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
UserId: OS$DataConversion.ServerDataConverter.to(userIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceUserApplicationRoleTempAssign", "screenservices/ConectaProveedores/a_Common/Wb_AssignTempRolePopup/ServiceAPIServiceUserApplicationRoleTempAssign", "XQvLVdv6EnEYP1aN3hc+cQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_AssignTempRolePopup$ServiceAPIServiceUserApplicationRoleTempAssign"))();
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
get getLoggedUserInfo$AggrRefresh() {if(!(this.hasOwnProperty("_getLoggedUserInfo$AggrRefresh"))) {
this._getLoggedUserInfo$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetLoggedUserInfo", "screenservices/ConectaProveedores/a_Common/Wb_AssignTempRolePopup/ScreenDataSetGetLoggedUserInfo", "3Y1EyNd3T2V0+MaATv_Lww", maxRecords, startIndex, function (b) {
model.variables.getLoggedUserInfoAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getLoggedUserInfoAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getLoggedUserInfoAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getLoggedUserRegionOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetLoggedUserInfo", function (span) {
if(span) {
span.setAttribute("code.function", "GetLoggedUserInfo");
span.setAttribute("outsystems.function.key", "19507c2f-95c6-461c-ae53-752c9b066492");
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

return this._getLoggedUserInfo$AggrRefresh;
}set getLoggedUserInfo$AggrRefresh(value) {this._getLoggedUserInfo$AggrRefresh = value;
}

get getUsersFromSameRegion$AggrRefresh() {if(!(this.hasOwnProperty("_getUsersFromSameRegion$AggrRefresh"))) {
this._getUsersFromSameRegion$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUsersFromSameRegion", "screenservices/ConectaProveedores/a_Common/Wb_AssignTempRolePopup/ScreenDataSetGetUsersFromSameRegion", "w+WPaosRoxS77CyV5KEhEQ", maxRecords, startIndex, function (b) {
model.variables.getUsersFromSameRegionAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUsersFromSameRegionAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUsersFromSameRegionAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUsersFromSameRegion", function (span) {
if(span) {
span.setAttribute("code.function", "GetUsersFromSameRegion");
span.setAttribute("outsystems.function.key", "8587829e-392a-43aa-9e69-6b0b7caa1b5c");
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

return this._getUsersFromSameRegion$AggrRefresh;
}set getUsersFromSameRegion$AggrRefresh(value) {this._getUsersFromSameRegion$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getLoggedUserInfo$AggrRefresh", "getUsersFromSameRegion$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dateFromPickerOnSelected$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DateFromPickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DateFromPickerOnSelected");
span.setAttribute("outsystems.function.key", "1bac720f-1a05-43f8-b6da-39a913b9ac03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DateFromPickerOnSelected");
callContext = controller.callContext(callContext);
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
span.setAttribute("outsystems.function.key", "7401081d-316c-41e5-8847-6b1277f298be");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveOnClick");
callContext = controller.callContext(callContext);
var serviceUserApplicationRoleTempCreateOrUpdateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_UserDropdownValid = True
model.variables.l_UserDropdownValidVar = true;
// l_UserDropdownValidationMessage = ""
model.variables.l_UserDropdownValidationMessageVar = "";
// Input_DateFrom.Valid = True
model.widgets.get(idService.getId("Input_DateFrom")).validAttr = true;
// Input_DateFrom.ValidationMessage = ""
model.widgets.get(idService.getId("Input_DateFrom")).validationMessageAttr = "";
// Input_DateTo.Valid = True
model.widgets.get(idService.getId("Input_DateTo")).validAttr = true;
return OS$Flow.executeSequence(function () {
if(((model.variables.l_UserApplicationRoleTempIn.userIdAttr === OS$BuiltinFunctions.nullTextIdentifier()))) {
// l_UserDropdownValid = False
model.variables.l_UserDropdownValidVar = false;
// l_UserDropdownValidationMessage = "You need to select a user."
model.variables.l_UserDropdownValidationMessageVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cv2Uu3m8ZUGEI0cmFjpGQA#Value.-1978855780.1", "You need to select a user.");
} else {
return OS$Flow.executeSequence(function () {
if((((((model.variables.l_UserApplicationRoleTempIn.dateFromAttr.lt(OS$BuiltinFunctions.currDate()) || model.variables.l_UserApplicationRoleTempIn.dateToAttr.lt(OS$BuiltinFunctions.currDate())) || model.variables.l_UserApplicationRoleTempIn.dateFromAttr.equals(OS$BuiltinFunctions.nullDate())) || model.variables.l_UserApplicationRoleTempIn.dateToAttr.equals(OS$BuiltinFunctions.nullDate())) || model.variables.l_UserApplicationRoleTempIn.dateToAttr.lt(model.variables.l_UserApplicationRoleTempIn.dateFromAttr)))) {
// Input_DateFrom.Valid = False
model.widgets.get(idService.getId("Input_DateFrom")).validAttr = false;
// Input_DateFrom.ValidationMessage = "Select a valid date interval."
model.widgets.get(idService.getId("Input_DateFrom")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NBofoNVmM0i9MQUdDUBbbw#Value.-73157474.1", "Select a valid date interval.");
// Input_DateTo.Valid = False
model.widgets.get(idService.getId("Input_DateTo")).validAttr = false;
} else {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_UserApplicationRoleTempIn.dateToAttr.gt(OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.currDate(), 30))) || model.variables.l_UserApplicationRoleTempIn.dateFromAttr.gt(OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.currDate(), 30)))))) {
// Input_DateFrom.Valid = False
model.widgets.get(idService.getId("Input_DateFrom")).validAttr = false;
// Input_DateFrom.ValidationMessage = "None of the dates can exceed 30 days from now."
model.widgets.get(idService.getId("Input_DateFrom")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5dt_SnT2akmRfUiAnoJXKw#Value.862104759.1", "None of the dates can exceed 30 days from now.");
// Input_DateTo.Valid = False
model.widgets.get(idService.getId("Input_DateTo")).validAttr = false;
} else {
// l_UserApplicationRoleTemp.ApplicationRoleId = GetLoggedUserInfo.List.Current.UserApplicationRole.ApplicationRoleId
model.variables.l_UserApplicationRoleTempIn.applicationRoleIdAttr = model.variables.getLoggedUserInfoAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleAttr.applicationRoleIdAttr;
// l_UserApplicationRoleTemp.AssignedBy = GetUserId
model.variables.l_UserApplicationRoleTempIn.assignedByAttr = OS$BuiltinFunctions.getUserId();
// l_UserApplicationRoleTemp.AssignedDate = CurrDate
model.variables.l_UserApplicationRoleTempIn.assignedDateAttr = OS$BuiltinFunctions.currDate();
// l_UserApplicationRoleTemp.RoleStatusId = ToBeActive
model.variables.l_UserApplicationRoleTempIn.roleStatusIdAttr = ConectaProveedores_staticEntities_roleStatus.toBeActive;
// Execute Action: ServiceUserApplicationRoleTempCreateOrUpdate
model.flush();
return controller.serviceUserApplicationRoleTempAssign$ServerAction(model.variables.l_UserApplicationRoleTempIn, OS$BuiltinFunctions.getUserId(), callContext).then(function (value) {
serviceUserApplicationRoleTempCreateOrUpdateVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((serviceUserApplicationRoleTempCreateOrUpdateVar.value.outputOut.isSuccessAttr)) {
// Trigger Event: Save
return controller.save$Action(callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mMN33gmkzEWEmT5uyjq8pQ#Message.-1439979299.1", "Substitution saved!"), /*Success*/ 1);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync();

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(serviceUserApplicationRoleTempCreateOrUpdateVar.value.outputOut.messageAttr, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync();

}

});
});
}

});
}

});
}

}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_getLoggedUserRegionOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetLoggedUserRegionOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetLoggedUserRegionOnAfterFetch");
span.setAttribute("outsystems.function.key", "9c224df9-e895-4adc-82d6-81af2e556832");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetLoggedUserRegionOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetUsersFromSameRegion
var result = controller.getUsersFromSameRegion$AggrRefresh(99999, 0, callContext);
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
_dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "ac4a6762-9608-4ce8-bd05-72709e76f740");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Wb_AssignTempRolePopup.DropdownSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// l_UserApplicationRoleTemp.UserId = TextToIdentifier
model.variables.l_UserApplicationRoleTempIn.userIdAttr = OS$BuiltinFunctions.textToIdentifier(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dateToPickerOnSelected$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DateToPickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DateToPickerOnSelected");
span.setAttribute("outsystems.function.key", "d3adf102-638d-4997-86ff-579c723cc406");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DateToPickerOnSelected");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

dateFromPickerOnSelected$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DateFromPickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DateFromPickerOnSelected");
span.setAttribute("outsystems.function.key", "1bac720f-1a05-43f8-b6da-39a913b9ac03");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dateFromPickerOnSelected$Action, callContext);
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
span.setAttribute("outsystems.function.key", "7401081d-316c-41e5-8847-6b1277f298be");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getLoggedUserRegionOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetLoggedUserRegionOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetLoggedUserRegionOnAfterFetch");
span.setAttribute("outsystems.function.key", "9c224df9-e895-4adc-82d6-81af2e556832");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getLoggedUserRegionOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "ac4a6762-9608-4ce8-bd05-72709e76f740");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dateToPickerOnSelected$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DateToPickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DateToPickerOnSelected");
span.setAttribute("outsystems.function.key", "d3adf102-638d-4997-86ff-579c723cc406");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dateToPickerOnSelected$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get save$Action() {if(!(this.hasOwnProperty("_save$Action"))) {
this._save$Action = function () {
return Promise.resolve();
};
}

return this._save$Action;
}set save$Action(value) {this._save$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_AssignTempRolePopup$ServiceAPIServiceUserApplicationRoleTempAssign", [{
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
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Wb_AssignTempRolePopup.DropdownSearchOnChanged$vars", [{
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


