import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Authorization as OS$Authorization, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_m_Manuals_Help_mvc_TranslationsResources from "./ConectaProveedores.m_Manuals.Help.mvc$translationsResources.js";
import ConectaProveedores_m_ManualsController$default from "./ConectaProveedores.m_Manuals.controller.js";
import { RC_9558728eac8dc806cf1b0c0e9a8e1262 } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_m_Manuals_Help_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getManuals$AggrRefresh: -1,
getUserInfo$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getManuals$AggrRefresh: [],
getUserInfo$DataActRefresh: ["getManuals$AggrRefresh"]
};
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/m_Manuals/Help/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
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
return controller.callServerAction("DownloadManualFile", "screenservices/ConectaProveedores/m_Manuals/Help/ActionDownloadManualFile", "WaCanX4Ob3EIaho9a8RmAQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.m_Manuals.Help$ActionDownloadManualFile"))();
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

// Aggregates and Data Actions
get getManuals$AggrRefresh() {if(!(this.hasOwnProperty("_getManuals$AggrRefresh"))) {
this._getManuals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetManuals", "screenservices/ConectaProveedores/m_Manuals/Help/ScreenDataSetGetManuals", "apfuBrQfhlQfI0Pl30RJNg", maxRecords, startIndex, function (b) {
model.variables.getManualsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getManualsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getManualsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetManuals", function (span) {
if(span) {
span.setAttribute("code.function", "GetManuals");
span.setAttribute("outsystems.function.key", "4c995a14-ac3d-4c8e-89f5-7c29210e98ac");
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

return this._getManuals$AggrRefresh;
}set getManuals$AggrRefresh(value) {this._getManuals$AggrRefresh = value;
}

get getUserInfo$DataActRefresh() {if(!(this.hasOwnProperty("_getUserInfo$DataActRefresh"))) {
this._getUserInfo$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserInfo", "screenservices/ConectaProveedores/m_Manuals/Help/DataActionGetUserInfo", "UqYNhBnJkdPbJyARCOiQsQ", function (b) {
model.variables.getUserInfoDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserInfoDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserInfoDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserInfoOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserInfo", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserInfo");
span.setAttribute("outsystems.function.key", "d447e269-4cf9-4eb3-9f32-e30dc3c85195");
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

return this._getUserInfo$DataActRefresh;
}set getUserInfo$DataActRefresh(value) {this._getUserInfo$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getManuals$AggrRefresh", "getUserInfo$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "0e4091da-8265-4a50-82da-e1540b791d81");
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
rec.screenAttr = "Help";
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
_verOnClick$Action(i_ManualIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("VerOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "VerOnClick");
span.setAttribute("outsystems.function.key", "12125428-a0a5-4720-b712-b4949be2288c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("VerOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.m_Manuals.Help.VerOnClick$vars"))());
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "4edd0cf5-b4fe-4ecb-9abb-fa95edeff9e8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.m_Manuals.Help.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetManuals
var result = controller.getManuals$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
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
_descargarOnClick$Action(i_ManualIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DescargarOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DescargarOnClick");
span.setAttribute("outsystems.function.key", "63d182e5-cccc-4bad-8a33-709526eaa4ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DescargarOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.m_Manuals.Help.DescargarOnClick$vars"))());
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eetuGQ_0UEKydKP3VVoE+Q#Message.-1898722339.1", "It was not possible to find the document, try again later."), /*Error*/ 3);
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
_manualDetailViewClosePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ManualDetailViewClosePopup", function (span) {
if(span) {
span.setAttribute("code.function", "ManualDetailViewClosePopup");
span.setAttribute("outsystems.function.key", "68197b78-2d6c-4847-bb07-421cb925e4ac");
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
_manualDetailViewDownload$Action(i_ManualIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ManualDetailViewDownload", function (span) {
if(span) {
span.setAttribute("code.function", "ManualDetailViewDownload");
span.setAttribute("outsystems.function.key", "8877f145-7c01-4a3e-8fee-f780c29a84b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ManualDetailViewDownload");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.m_Manuals.Help.ManualDetailViewDownload$vars"))());
vars.value.i_ManualIdInLocal = i_ManualIdIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ManualDetailViewClosePopup
controller._manualDetailViewClosePopup$Action(callContext);
// Execute Action: DescargarOnClick
return controller._descargarOnClick$Action(vars.value.i_ManualIdInLocal, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_search$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Search", function (span) {
if(span) {
span.setAttribute("code.function", "Search");
span.setAttribute("outsystems.function.key", "b83289ee-9aac-4dd4-8778-eb1fc56948be");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Search");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetManuals
var result = controller.getManuals$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
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
_getUserInfoOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserInfoOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserInfoOnAfterFetch");
span.setAttribute("outsystems.function.key", "e3dcc8cb-2bbf-4f93-9c9b-a90cdb1e6572");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserInfoOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetManuals
var result = controller.getManuals$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "0e4091da-8265-4a50-82da-e1540b791d81");
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

verOnClick$Action(i_ManualIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("VerOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "VerOnClick");
span.setAttribute("outsystems.function.key", "12125428-a0a5-4720-b712-b4949be2288c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._verOnClick$Action, callContext, i_ManualIdIn);
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
span.setAttribute("outsystems.function.key", "4edd0cf5-b4fe-4ecb-9abb-fa95edeff9e8");
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

descargarOnClick$Action(i_ManualIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DescargarOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DescargarOnClick");
span.setAttribute("outsystems.function.key", "63d182e5-cccc-4bad-8a33-709526eaa4ac");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._descargarOnClick$Action, callContext, i_ManualIdIn);
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
span.setAttribute("outsystems.function.key", "68197b78-2d6c-4847-bb07-421cb925e4ac");
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

manualDetailViewDownload$Action(i_ManualIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ManualDetailViewDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ManualDetailViewDownload");
span.setAttribute("outsystems.function.key", "8877f145-7c01-4a3e-8fee-f780c29a84b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._manualDetailViewDownload$Action, callContext, i_ManualIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

search$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Search__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Search");
span.setAttribute("outsystems.function.key", "b83289ee-9aac-4dd4-8778-eb1fc56948be");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._search$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getUserInfoOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserInfoOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserInfoOnAfterFetch");
span.setAttribute("outsystems.function.key", "e3dcc8cb-2bbf-4f93-9c9b-a90cdb1e6572");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUserInfoOnAfterFetch$Action, callContext);
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
return ConectaProveedores_m_ManualsController$default.handleError(ex, this.callContext());
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
Controller.registerVariableGroupType("ConectaProveedores.m_Manuals.Help$ActionDownloadManualFile", [{
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
Controller.registerVariableGroupType("ConectaProveedores.m_Manuals.Help.VerOnClick$vars", [{
name: "i_ManualId",
attrName: "i_ManualIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.m_Manuals.Help.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.m_Manuals.Help.DescargarOnClick$vars", [{
name: "i_ManualId",
attrName: "i_ManualIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.m_Manuals.Help.ManualDetailViewDownload$vars", [{
name: "i_ManualId",
attrName: "i_ManualIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


