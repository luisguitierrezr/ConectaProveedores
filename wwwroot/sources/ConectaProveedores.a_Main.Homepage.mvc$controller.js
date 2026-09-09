import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { updateChartColorScheme$Action as OutSystemsChartsController$updateChartColorScheme$Action } from "./OutSystemsCharts.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_a_Main_Homepage_mvc_TranslationsResources from "./ConectaProveedores.a_Main.Homepage.mvc$translationsResources.js";
import ConectaProveedores_a_MainController$default from "./ConectaProveedores.a_Main.controller.js";
import { RC_9558728eac8dc806cf1b0c0e9a8e1262 } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Main_Homepage_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getManuals2$DataActRefresh: -1,
getUserApplicationRolesAndMore$DataActRefresh: 0,
getRequisitionsKPI$DataActRefresh: -1,
getInvoicesKPI$DataActRefresh: -1,
getFoliosKPI$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getManuals2$DataActRefresh: [],
getUserApplicationRolesAndMore$DataActRefresh: ["getManuals2$DataActRefresh", "getRequisitionsKPI$DataActRefresh"],
getRequisitionsKPI$DataActRefresh: [],
getInvoicesKPI$DataActRefresh: [],
getFoliosKPI$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
downloadManualFile$ServerAction(i_ManualIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadManualFile", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadManualFile");
span.setAttribute("outsystems.function.key", "1a300ba8-4fd8-42b4-93e3-7ae466206f98");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ManualId: OS$DataConversion.ServerDataConverter.to(i_ManualIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadManualFile", "screenservices/ConectaProveedores/a_Main/Homepage/ActionDownloadManualFile", "WaCanX4Ob3EIaho9a8RmAQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.Homepage$ActionDownloadManualFile"))();
executeServerActionResult.fileOut = OS$DataConversion.ServerDataConverter.from(outputs.File, RC_9558728eac8dc806cf1b0c0e9a8e1262);
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/a_Main/Homepage/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getManuals2$DataActRefresh() {if(!(this.hasOwnProperty("_getManuals2$DataActRefresh"))) {
this._getManuals2$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetManuals2", "screenservices/ConectaProveedores/a_Main/Homepage/DataActionGetManuals2", "Ut5ZfBVhofM5zKXWAOypNw", function (b) {
model.variables.getManuals2DataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getManuals2DataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getManuals2DataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetManuals2", function (span) {
if(span) {
span.setAttribute("code.function", "GetManuals2");
span.setAttribute("outsystems.function.key", "28d37925-d77b-4d86-8653-7486e0ecc557");
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

return this._getManuals2$DataActRefresh;
}set getManuals2$DataActRefresh(value) {this._getManuals2$DataActRefresh = value;
}

get getUserApplicationRolesAndMore$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRolesAndMore$DataActRefresh"))) {
this._getUserApplicationRolesAndMore$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRolesAndMore", "screenservices/ConectaProveedores/a_Main/Homepage/DataActionGetUserApplicationRolesAndMore", "owOI7uBb0aQB2acn43FvGQ", function (b) {
model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesAndMoreDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesAndMoreDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserApplicationRolesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRolesAndMore", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesAndMore");
span.setAttribute("outsystems.function.key", "2bad5bf1-ded1-4594-8171-f02fe51b5323");
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

return this._getUserApplicationRolesAndMore$DataActRefresh;
}set getUserApplicationRolesAndMore$DataActRefresh(value) {this._getUserApplicationRolesAndMore$DataActRefresh = value;
}

get getRequisitionsKPI$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitionsKPI$DataActRefresh"))) {
this._getRequisitionsKPI$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitionsKPI", "screenservices/ConectaProveedores/a_Main/Homepage/DataActionGetRequisitionsKPI", "VGZbqSp59jFKIGY1KoDijA", function (b) {
model.variables.getRequisitionsKPIDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsKPIDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsKPIDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionsKPI", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsKPI");
span.setAttribute("outsystems.function.key", "73b69f48-7e8e-4222-a0c2-647c231c8fcb");
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

return this._getRequisitionsKPI$DataActRefresh;
}set getRequisitionsKPI$DataActRefresh(value) {this._getRequisitionsKPI$DataActRefresh = value;
}

get getInvoicesKPI$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoicesKPI$DataActRefresh"))) {
this._getInvoicesKPI$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoicesKPI", "screenservices/ConectaProveedores/a_Main/Homepage/DataActionGetInvoicesKPI", "qUAbMdPhnTqj7Iy5JvfqcQ", function (b) {
model.variables.getInvoicesKPIDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesKPIDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesKPIDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesKPI", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesKPI");
span.setAttribute("outsystems.function.key", "757f0ede-ecb8-4ea4-b912-750c1a10d75b");
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

return this._getInvoicesKPI$DataActRefresh;
}set getInvoicesKPI$DataActRefresh(value) {this._getInvoicesKPI$DataActRefresh = value;
}

get getFoliosKPI$DataActRefresh() {if(!(this.hasOwnProperty("_getFoliosKPI$DataActRefresh"))) {
this._getFoliosKPI$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFoliosKPI", "screenservices/ConectaProveedores/a_Main/Homepage/DataActionGetFoliosKPI", "dcWlK4C4vegfjhhdjepUkQ", function (b) {
model.variables.getFoliosKPIDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFoliosKPIDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFoliosKPIDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFoliosKPI", function (span) {
if(span) {
span.setAttribute("code.function", "GetFoliosKPI");
span.setAttribute("outsystems.function.key", "957acbca-e854-4252-92a5-f7e84a67e7d1");
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

return this._getFoliosKPI$DataActRefresh;
}set getFoliosKPI$DataActRefresh(value) {this._getFoliosKPI$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getManuals2$DataActRefresh", "getUserApplicationRolesAndMore$DataActRefresh", "getRequisitionsKPI$DataActRefresh", "getInvoicesKPI$DataActRefresh", "getFoliosKPI$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_donutChartOrdInitialized$Action(chartWidgetIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DonutChartOrdInitialized", function (span) {
if(span) {
span.setAttribute("code.function", "DonutChartOrdInitialized");
span.setAttribute("outsystems.function.key", "0d1abf7e-7a21-48b1-bc7c-f23d9e1c071b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DonutChartOrdInitialized");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.Homepage.DonutChartOrdInitialized$vars"))());
vars.value.chartWidgetIdInLocal = chartWidgetIdIn;
var updateChartColorSchemeVar = new OS$DataTypes.VariableHolder();
// Execute Action: UpdateChartColorScheme
updateChartColorSchemeVar.value = OutSystemsChartsController$updateChartColorScheme$Action(vars.value.chartWidgetIdInLocal, function () {
var list = new OS$DataTypes.TextList();
list.pushAll(["#1c802b", "#359543", "#4da85a", "#64bc71", "#7ccf88", "#94e39f"]);
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
_downloadManual$Action(i_ManualIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadManual", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadManual");
span.setAttribute("outsystems.function.key", "29f2bca7-4b73-410f-8eb8-bdb33ca35522");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadManual");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.Homepage.DownloadManual$vars"))());
vars.value.i_ManualIdInLocal = i_ManualIdIn;
var downloadManualFileVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: DownloadManualFile
model.flush();
return controller.downloadManualFile$ServerAction(vars.value.i_ManualIdInLocal, callContext).then(function (value) {
downloadManualFileVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
// With file
if((!(OS$DataTypes.areBinaryNulls(downloadManualFileVar.value.fileOut.binaryAttr, OS$BuiltinFunctions.nullBinary())))) {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadManualFileVar.value.fileOut.binaryAttr, downloadManualFileVar.value.fileOut.filenameAttr));
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8lar5SjkVUWZFkA2O4oKDg#Message.-1898722339.1", "It was not possible to find the document, try again later."), /*Error*/ 3);
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
_donutChartReqInitialized$Action(chartWidgetIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DonutChartReqInitialized", function (span) {
if(span) {
span.setAttribute("code.function", "DonutChartReqInitialized");
span.setAttribute("outsystems.function.key", "34865938-3c3b-4d95-b509-82a27d25d149");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DonutChartReqInitialized");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.Homepage.DonutChartReqInitialized$vars"))());
vars.value.chartWidgetIdInLocal = chartWidgetIdIn;
var updateChartColorSchemeVar = new OS$DataTypes.VariableHolder();
// Execute Action: UpdateChartColorScheme
updateChartColorSchemeVar.value = OutSystemsChartsController$updateChartColorScheme$Action(vars.value.chartWidgetIdInLocal, function () {
var list = new OS$DataTypes.TextList();
list.pushAll(["#1068eb", "#2d7bef", "#488df3", "#63a0f7", "#7fb2fb", "#9ac4ff"]);
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
_previewManual$Action(i_ManualIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PreviewManual", function (span) {
if(span) {
span.setAttribute("code.function", "PreviewManual");
span.setAttribute("outsystems.function.key", "3d39cd50-3309-4972-b3df-618d3349cf30");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PreviewManual");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.Homepage.PreviewManual$vars"))());
vars.value.i_ManualIdInLocal = i_ManualIdIn;
// l_ManualId = i_ManualId
model.variables.l_ManualIdVar = vars.value.i_ManualIdInLocal;
// ShowPopup = True
model.variables.showPopupVar = true;
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
span.setAttribute("outsystems.function.key", "44f23b48-3af5-4436-b069-342eaff22ca2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetRequisitionsKPI
var result = controller.getRequisitionsKPI$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoicesKPI
var result = controller.getInvoicesKPI$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetManuals2
var result = controller.getManuals2$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetFoliosKPI
var result = controller.getFoliosKPI$DataActRefresh(callContext);
model.flush();
return result;
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
_manualDetailViewClosePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ManualDetailViewClosePopup", function (span) {
if(span) {
span.setAttribute("code.function", "ManualDetailViewClosePopup");
span.setAttribute("outsystems.function.key", "54a60fda-e901-4b6b-a513-f1f7a2d018e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ManualDetailViewClosePopup");
callContext = controller.callContext(callContext);
// ShowPopup = False
model.variables.showPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c35b27b0-27b1-4acf-8dc6-6898d057413d");
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
rec.screenAttr = "Homepage";
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c969618e-b13c-4e70-92fd-9739bfcb1926");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
if((ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)) {
// Destination: /ConectaProveedores/Requisitions
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_donutChartInvInitialized$Action(chartWidgetIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DonutChartInvInitialized", function (span) {
if(span) {
span.setAttribute("code.function", "DonutChartInvInitialized");
span.setAttribute("outsystems.function.key", "de720773-8ba5-40e8-8826-2c46dfe21d54");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DonutChartInvInitialized");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Main.Homepage.DonutChartInvInitialized$vars"))());
vars.value.chartWidgetIdInLocal = chartWidgetIdIn;
var updateChartColorSchemeVar = new OS$DataTypes.VariableHolder();
// Execute Action: UpdateChartColorScheme
updateChartColorSchemeVar.value = OutSystemsChartsController$updateChartColorScheme$Action(vars.value.chartWidgetIdInLocal, function () {
var list = new OS$DataTypes.TextList();
list.pushAll(["#7b1fa2", "#8f3bb5", "#a256c8", "#b471da", "#c78bed", "#daa6ff"]);
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

donutChartOrdInitialized$Action(chartWidgetIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DonutChartOrdInitialized__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DonutChartOrdInitialized");
span.setAttribute("outsystems.function.key", "0d1abf7e-7a21-48b1-bc7c-f23d9e1c071b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._donutChartOrdInitialized$Action, callContext, chartWidgetIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

downloadManual$Action(i_ManualIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadManual__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadManual");
span.setAttribute("outsystems.function.key", "29f2bca7-4b73-410f-8eb8-bdb33ca35522");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadManual$Action, callContext, i_ManualIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

donutChartReqInitialized$Action(chartWidgetIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DonutChartReqInitialized__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DonutChartReqInitialized");
span.setAttribute("outsystems.function.key", "34865938-3c3b-4d95-b509-82a27d25d149");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._donutChartReqInitialized$Action, callContext, chartWidgetIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

previewManual$Action(i_ManualIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PreviewManual__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PreviewManual");
span.setAttribute("outsystems.function.key", "3d39cd50-3309-4972-b3df-618d3349cf30");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._previewManual$Action, callContext, i_ManualIdIn);
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
span.setAttribute("outsystems.function.key", "44f23b48-3af5-4436-b069-342eaff22ca2");
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

manualDetailViewClosePopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ManualDetailViewClosePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ManualDetailViewClosePopup");
span.setAttribute("outsystems.function.key", "54a60fda-e901-4b6b-a513-f1f7a2d018e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._manualDetailViewClosePopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "c35b27b0-27b1-4acf-8dc6-6898d057413d");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c969618e-b13c-4e70-92fd-9739bfcb1926");
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

donutChartInvInitialized$Action(chartWidgetIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DonutChartInvInitialized__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DonutChartInvInitialized");
span.setAttribute("outsystems.function.key", "de720773-8ba5-40e8-8826-2c46dfe21d54");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._donutChartInvInitialized$Action, callContext, chartWidgetIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

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
return ConectaProveedores_a_MainController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.ConectaProveedores, ConectaProveedoresController$default.roles.Proveedor]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Main.Homepage$ActionDownloadManualFile", [{
name: "File",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new RC_9558728eac8dc806cf1b0c0e9a8e1262();
},
complexType: RC_9558728eac8dc806cf1b0c0e9a8e1262
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Main.Homepage.DonutChartOrdInitialized$vars", [{
name: "ChartWidgetId",
attrName: "chartWidgetIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Main.Homepage.DownloadManual$vars", [{
name: "i_ManualId",
attrName: "i_ManualIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Main.Homepage.DonutChartReqInitialized$vars", [{
name: "ChartWidgetId",
attrName: "chartWidgetIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Main.Homepage.PreviewManual$vars", [{
name: "i_ManualId",
attrName: "i_ManualIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Main.Homepage.DonutChartInvInitialized$vars", [{
name: "ChartWidgetId",
attrName: "chartWidgetIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


