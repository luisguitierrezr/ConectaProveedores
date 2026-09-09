import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, Transitions as OS$Transitions, Navigation as OS$Navigation, Exceptions as OS$Exceptions, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_InitTimer_InitInterval_JSJS from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$controller.InitTimer.InitInterval_JSJS.js";
import ConectaProveedoresController$default, { setClientTimeouts$Action as ConectaProveedoresController$setClientTimeouts$Action, getClientTimeouts$Action as ConectaProveedoresController$getClientTimeouts$Action, setClientTimeouts$Action$Proxy as ConectaProveedoresController$setClientTimeouts$Action$Proxy } from "./ConectaProveedores.controller.js";
import ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_OnInitialize_DoLogoutJS from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$controller.OnInitialize.DoLogoutJS.js";
import ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_DoLogout_JavaScript1JS from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$controller.DoLogout.JavaScript1JS.js";
import ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_ClearInterval_ClearInterval_JSJS from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$controller.ClearInterval.ClearInterval_JSJS.js";
import ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_InitActivityListener_JavaScript1JS from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$controller.InitActivityListener.JavaScript1JS.js";
import ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_TranslationsResources from "./ConectaProveedores.y_Utils.Wb_SessionTimeout.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {
validate$Action: function validate$Action$Proxy() {
return controller.executeActionInsideJSNode(controller._validate$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "Validate");
},
doLogout$Action: function doLogout$Action$Proxy() {
return controller.executeActionInsideJSNode(controller._doLogout$Action.bind(controller), controller.callContext(), function (actionResults) {
return {};
}, function () {
return;
}, "DoLogout");
}
};
this.dataFetchDependenciesOriginal = {
getSettings$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getSettings$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/y_Utils/Wb_SessionTimeout/DataActionGetSettings", "fiyj3Po6FOjaVWkfVOcGrQ", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSettingsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "01e50d22-db47-4b2c-9ad7-8f3873c94730");
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
_logoutOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LogoutOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LogoutOnClick");
span.setAttribute("outsystems.function.key", "3643f90a-8dd7-4d61-94ad-bb99929dcd19");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LogoutOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DoLogout
return controller._doLogout$Action(callContext).then(function () {
// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
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
_initTimer$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("InitTimer", function (span) {
if(span) {
span.setAttribute("code.function", "InitTimer");
span.setAttribute("outsystems.function.key", "371b45b9-fcb8-4a27-a7c4-e2517829140f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("InitTimer");
callContext = controller.callContext(callContext);
var initInterval_JSJSResult = new OS$DataTypes.VariableHolder();
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
initInterval_JSJSResult.value = OS$Logger.startActiveSpan("InitInterval_JS", function (span) {
if(span) {
span.setAttribute("code.function", "InitInterval_JS");
span.setAttribute("outsystems.function.key", "52c624c5-648b-4c14-aa3c-1279e5a379fb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_InitTimer_InitInterval_JSJS, "InitInterval_JS", "InitTimer", {
IntervalId: OS$DataConversion.JSNodeParamConverter.to(OS$DataTypes.LongInteger.defaultValue, OS$DataTypes.DataTypes.LongInteger)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.y_Utils.Wb_SessionTimeout.InitTimer$initInterval_JSJSResult"))();
jsNodeResult.intervalIdOut = OS$DataConversion.JSNodeParamConverter.from($parameters.IntervalId, OS$DataTypes.DataTypes.LongInteger);
return jsNodeResult;
}, {
Validate: controller.clientActionProxies.validate$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IntervaltId = InitInterval_JS.IntervalId
model.variables.intervaltIdVar = initInterval_JSJSResult.value.intervalIdOut;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSettingsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSettingsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsOnAfterFetch");
span.setAttribute("outsystems.function.key", "4aae7a77-6666-4bf8-9f55-0a0b2d250911");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSettingsOnAfterFetch");
callContext = controller.callContext(callContext);
// Execute Action: SetClientTimeouts
ConectaProveedoresController$setClientTimeouts$Action(model.variables.getSettingsDataAct.warningTimeOut, model.variables.getSettingsDataAct.logoutTimeOut, callContext);
// Set Client Settings
// ShowWarning = False
model.variables.showWarningVar = false;
// Execute Action: InitTimer
controller._initTimer$Action(callContext);
// Execute Action: InitActivityListener
controller._initActivityListener$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "63f5c55d-e90e-4296-b892-c002f17e3e9a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var getClientTimeoutsVar = new OS$DataTypes.VariableHolder();
// Execute Action: GetClientTimeouts
getClientTimeoutsVar.value = ConectaProveedoresController$getClientTimeouts$Action(callContext);

if(((!(getClientTimeoutsVar.value.valueLogoutOut.equals(OS$BuiltinFunctions.nullDate())) && OS$BuiltinFunctions.currDateTime().gt(getClientTimeoutsVar.value.valueLogoutOut)))) {
OS$Logger.startActiveSpan("DoLogout", function (span) {
if(span) {
span.setAttribute("code.function", "DoLogout");
span.setAttribute("outsystems.function.key", "c25a43e5-02e7-4d32-bd8a-326d92acfb8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_OnInitialize_DoLogoutJS, "DoLogout", "OnInitialize", null, function ($parameters) {
}, {
DoLogout: controller.clientActionProxies.doLogout$Action
}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_doLogout$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DoLogout", function (span) {
if(span) {
span.setAttribute("code.function", "DoLogout");
span.setAttribute("outsystems.function.key", "81240c81-4841-41e0-81bb-e88da25076f9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DoLogout");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
OS$Logger.startActiveSpan("JavaScript1", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript1");
span.setAttribute("outsystems.function.key", "f7c3155f-cecb-4a40-acd9-3b003c754103");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_DoLogout_JavaScript1JS, "JavaScript1", "DoLogout", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

// Trigger Event: OnLogout
return controller.onLogout$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onDestroy$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDestroy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "903d2d65-7b0f-4bb8-a021-4486b679e7af");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnDestroy");
callContext = controller.callContext(callContext);
// Execute Action: ClearInterval
controller._clearInterval$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearInterval$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearInterval", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInterval");
span.setAttribute("outsystems.function.key", "c59131df-f249-4adc-a062-84e77c7c7727");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearInterval");
callContext = controller.callContext(callContext);
if((!(model.variables.intervaltIdVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
OS$Logger.startActiveSpan("ClearInterval_JS", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInterval_JS");
span.setAttribute("outsystems.function.key", "a91f2629-78ac-4b7b-9b9f-6eb6e220cb24");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_ClearInterval_ClearInterval_JSJS, "ClearInterval_JS", "ClearInterval", {
TimeoutId: OS$DataConversion.JSNodeParamConverter.to(model.variables.intervaltIdVar, OS$DataTypes.DataTypes.LongInteger)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// IntervaltId = NullIdentifier
model.variables.intervaltIdVar = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Validate", function (span) {
if(span) {
span.setAttribute("code.function", "Validate");
span.setAttribute("outsystems.function.key", "f30ff049-463c-4b33-8a05-5f46a3a62ff0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Validate");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var getClientTimeoutsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetClientTimeouts
getClientTimeoutsVar.value = ConectaProveedoresController$getClientTimeouts$Action(callContext);

if(((!(getClientTimeoutsVar.value.valueWarningOut.equals(OS$BuiltinFunctions.nullDate())) && OS$BuiltinFunctions.currDateTime().gt(getClientTimeoutsVar.value.valueWarningOut)))) {
// ShowWarning = True
model.variables.showWarningVar = true;
// Seconds = DiffSeconds
model.variables.secondsVar = OS$BuiltinFunctions.diffSeconds(OS$BuiltinFunctions.currDateTime(), getClientTimeoutsVar.value.valueLogoutOut);
// Seconds = If
model.variables.secondsVar = (((model.variables.secondsVar < 0)) ? (0) : (model.variables.secondsVar));
} else {
// ShowWarning = False
model.variables.showWarningVar = false;
}

return OS$Flow.executeSequence(function () {
if(((getClientTimeoutsVar.value.valueLogoutOut.equals(OS$BuiltinFunctions.nullDate()) || OS$BuiltinFunctions.currDateTime().gt(getClientTimeoutsVar.value.valueLogoutOut)))) {
// Execute Action: DoLogout
return controller._doLogout$Action(callContext);
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_SessionTimeout.Validate", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "aeac6a40-9024-4e33-b68b-a72b48d38ae3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_continueOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ContinueOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ContinueOnClick");
span.setAttribute("outsystems.function.key", "f8c783fe-75f9-4971-99c1-770199412ba0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ContinueOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSettings
var result = controller.getSettings$DataActRefresh(callContext);
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
_initActivityListener$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("InitActivityListener", function (span) {
if(span) {
span.setAttribute("code.function", "InitActivityListener");
span.setAttribute("outsystems.function.key", "fb95b78d-8776-4c08-b448-726e4617ed2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("InitActivityListener");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("JavaScript1", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript1");
span.setAttribute("outsystems.function.key", "b48404a7-135b-4100-8664-2a614aa168a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_y_Utils_Wb_SessionTimeout_mvc_controller_InitActivityListener_JavaScript1JS, "JavaScript1", "InitActivityListener", {
WarningTime: OS$DataConversion.JSNodeParamConverter.to(model.variables.getSettingsDataAct.warningMinutesOut, OS$DataTypes.DataTypes.Integer),
LogoutTime: OS$DataConversion.JSNodeParamConverter.to(model.variables.getSettingsDataAct.logoutMinutesOut, OS$DataTypes.DataTypes.Integer)
}, function ($parameters) {
}, {
SetClientTimeouts: ConectaProveedoresController$setClientTimeouts$Action$Proxy
}, {});
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

logoutOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LogoutOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LogoutOnClick");
span.setAttribute("outsystems.function.key", "3643f90a-8dd7-4d61-94ad-bb99929dcd19");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._logoutOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

initTimer$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InitTimer__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitTimer");
span.setAttribute("outsystems.function.key", "371b45b9-fcb8-4a27-a7c4-e2517829140f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._initTimer$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getSettingsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSettingsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsOnAfterFetch");
span.setAttribute("outsystems.function.key", "4aae7a77-6666-4bf8-9f55-0a0b2d250911");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSettingsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "63f5c55d-e90e-4296-b892-c002f17e3e9a");
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

doLogout$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DoLogout__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DoLogout");
span.setAttribute("outsystems.function.key", "81240c81-4841-41e0-81bb-e88da25076f9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._doLogout$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onDestroy$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDestroy__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDestroy");
span.setAttribute("outsystems.function.key", "903d2d65-7b0f-4bb8-a021-4486b679e7af");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onDestroy$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearInterval$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearInterval__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearInterval");
span.setAttribute("outsystems.function.key", "c59131df-f249-4adc-a062-84e77c7c7727");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._clearInterval$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Validate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Validate");
span.setAttribute("outsystems.function.key", "f30ff049-463c-4b33-8a05-5f46a3a62ff0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._validate$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

continueOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ContinueOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ContinueOnClick");
span.setAttribute("outsystems.function.key", "f8c783fe-75f9-4971-99c1-770199412ba0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._continueOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

initActivityListener$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("InitActivityListener__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "InitActivityListener");
span.setAttribute("outsystems.function.key", "fb95b78d-8776-4c08-b448-726e4617ed2b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._initActivityListener$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get onLogout$Action() {if(!(this.hasOwnProperty("_onLogout$Action"))) {
this._onLogout$Action = function () {
return Promise.resolve();
};
}

return this._onLogout$Action;
}set onLogout$Action(value) {this._onLogout$Action = value;
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
this._onDestroyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onDestroy$Action(callContext);

};
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.y_Utils.Wb_SessionTimeout.InitTimer$initInterval_JSJSResult", [{
name: "IntervalId",
attrName: "intervalIdOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


