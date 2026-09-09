import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { submenuClose$Action as OutSystemsUIController$submenuClose$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioActions_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FolioActions.mvc$translationsResources.js";
import { ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioApprovalLevelById$AggrRefresh: -1,
getFolioTypeDA$DataActRefresh: 0,
getUserInfo$DataActRefresh: 0,
getUserApplicationRoles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFolioApprovalLevelById$AggrRefresh: [],
getFolioTypeDA$DataActRefresh: [],
getUserInfo$DataActRefresh: [],
getUserApplicationRoles$DataActRefresh: ["getFolioApprovalLevelById$AggrRefresh"]
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
approvRejectFolio$ServerAction(i_FolioIdIn, i_FolioApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovRejectFolio", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovRejectFolio");
span.setAttribute("outsystems.function.key", "2b037169-b232-4efd-bcf0-327a5aae73e6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_FolioApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_FolioApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApprovRejectFolio", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ActionApprovRejectFolio", "3lMt9PSpF_QXCgb0Q9x67w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionApprovRejectFolio"))();
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
folioEvidenceRequest$ServerAction(i_FolioIdIn, i_FolioApprovalLevelIdIn, i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioEvidenceRequest", function (span) {
if(span) {
span.setAttribute("code.function", "FolioEvidenceRequest");
span.setAttribute("outsystems.function.key", "d2a4d1e9-1901-4546-b1a5-89ff1d18543e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_FolioApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_FolioApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioEvidenceRequest", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ActionFolioEvidenceRequest", "9AgLlP1GuLrYTvF7YC2zyQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioEvidenceRequest"))();
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
folioComment$ServerAction(i_FolioIdIn, i_FolioApprovalLevelIdIn, i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioComment", function (span) {
if(span) {
span.setAttribute("code.function", "FolioComment");
span.setAttribute("outsystems.function.key", "89b5acc9-6b5e-4c4c-bb1b-9fa5321fb364");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_FolioApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_FolioApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioComment", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ActionFolioComment", "BYpQxJkd7IP+1fF9sSUsoQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioComment"))();
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
folioResendEntry$ServerAction(i_FolioIdIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioResendEntry", function (span) {
if(span) {
span.setAttribute("code.function", "FolioResendEntry");
span.setAttribute("outsystems.function.key", "436de443-df4f-49a2-a1d5-33a9f6a22cf5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioResendEntry", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ActionFolioResendEntry", "Uvyersp6iOL1ZWrsJ+RR0A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioResendEntry"))();
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
folioCancelFromApprover$ServerAction(i_FolioIdIn, i_FolioApprovalLevelIdIn, i_CancelReasonIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioCancelFromApprover", function (span) {
if(span) {
span.setAttribute("code.function", "FolioCancelFromApprover");
span.setAttribute("outsystems.function.key", "a00d88ea-810f-4cc2-9f03-b210b3188175");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_FolioApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_FolioApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_CancelReason: OS$DataConversion.ServerDataConverter.to(i_CancelReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioCancelFromApprover", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ActionFolioCancelFromApprover", "aq_w99nG9UUaC__cmsK4LA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioCancelFromApprover"))();
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
folioCancelFromAlmacen$ServerAction(i_FolioIdIn, i_CancelReasonIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioCancelFromAlmacen", function (span) {
if(span) {
span.setAttribute("code.function", "FolioCancelFromAlmacen");
span.setAttribute("outsystems.function.key", "fbd467ab-ef3e-46be-8174-4c72f85340ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_FolioId: OS$DataConversion.ServerDataConverter.to(i_FolioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_CancelReason: OS$DataConversion.ServerDataConverter.to(i_CancelReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioCancelFromAlmacen", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ActionFolioCancelFromAlmacen", "_5HCI8sqPhlNg+JpFviiuw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioCancelFromAlmacen"))();
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
get getFolioApprovalLevelById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioApprovalLevelById$AggrRefresh"))) {
this._getFolioApprovalLevelById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioApprovalLevelById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/ScreenDataSetGetFolioApprovalLevelById", "lF8JS11150jvsCDoN4i47g", maxRecords, startIndex, function (b) {
model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioApprovalLevelByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioApprovalLevelByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getFolioApprovalLevelByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioApprovalLevelById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalLevelById");
span.setAttribute("outsystems.function.key", "734d69b6-2846-40e3-8908-fc8080964724");
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

return this._getFolioApprovalLevelById$AggrRefresh;
}set getFolioApprovalLevelById$AggrRefresh(value) {this._getFolioApprovalLevelById$AggrRefresh = value;
}

get getFolioTypeDA$DataActRefresh() {if(!(this.hasOwnProperty("_getFolioTypeDA$DataActRefresh"))) {
this._getFolioTypeDA$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFolioTypeDA", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/DataActionGetFolioTypeDA", "pVuYOEMQMtrZvtnPx4Y7mw", function (b) {
model.variables.getFolioTypeDADataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioTypeDADataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioTypeDADataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioTypeDA", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioTypeDA");
span.setAttribute("outsystems.function.key", "31f0c045-7fef-4ca3-a9b8-12ea129b4ae8");
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

return this._getFolioTypeDA$DataActRefresh;
}set getFolioTypeDA$DataActRefresh(value) {this._getFolioTypeDA$DataActRefresh = value;
}

get getUserInfo$DataActRefresh() {if(!(this.hasOwnProperty("_getUserInfo$DataActRefresh"))) {
this._getUserInfo$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserInfo", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/DataActionGetUserInfo", "BWQfTfvpsgByzN7d7Xpo3A", function (b) {
model.variables.getUserInfoDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserInfoDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserInfoDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserInfo", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserInfo");
span.setAttribute("outsystems.function.key", "52a76b7e-55ed-49e0-aa02-8e39a7876df4");
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

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioActions/DataActionGetUserApplicationRoles", "Em4eq0ND_srkNxUcMKHmYA", function (b) {
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
span.setAttribute("outsystems.function.key", "d1e5daec-8cee-4b1b-903f-ff25904bba78");
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
this._dataFetchActionNames = ["getFolioApprovalLevelById$AggrRefresh", "getFolioTypeDA$DataActRefresh", "getUserInfo$DataActRefresh", "getUserApplicationRoles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "0533263a-2218-477c-90b3-2b37a95092bf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioApprovalLevelById
var result = controller.getFolioApprovalLevelById$AggrRefresh(1, 0, callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "06c8b7a9-3c91-4bc3-98ba-12175c955a6e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioApprovalLevelById
var result = controller.getFolioApprovalLevelById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetUserInfo
var result = controller.getUserInfo$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetFolioTypeDA
var result = controller.getFolioTypeDA$DataActRefresh(callContext);
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
_wb_b_ApprovePopupOpenClose$Action(i_IsSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_ApprovePopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_ApprovePopupOpenClose");
span.setAttribute("outsystems.function.key", "0cd0bbe6-a980-4620-854c-2a8d964eddd8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_ApprovePopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_ApprovePopupOpenClose$vars"))());
vars.value.i_IsSaveInLocal = i_IsSaveIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Execute Action: ApproveRejectFolio
return controller._approveRejectFolio$Action(true, "", callContext);
}

}).then(function () {
// l_ShowApprovePopup = notl_ShowApprovePopup
model.variables.l_ShowApprovePopupVar = (!(model.variables.l_ShowApprovePopupVar));
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
_approveRejectFolio$Action(i_IsApproveIn, i_CommentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveRejectFolio", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRejectFolio");
span.setAttribute("outsystems.function.key", "13298702-95d3-42d5-a746-40ea1fda28c3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveRejectFolio");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.ApproveRejectFolio$vars"))());
vars.value.i_IsApproveInLocal = i_IsApproveIn;
vars.value.i_CommentInLocal = i_CommentIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var approvRejectFolioVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ApprovRejectFolio
model.flush();
return controller.approvRejectFolio$ServerAction(model.variables.i_FolioIdIn, model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr, vars.value.i_IsApproveInLocal, vars.value.i_CommentInLocal, ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
approvRejectFolioVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((approvRejectFolioVar.value.o_OutputOut.isSuccessAttr)) {
if((((approvRejectFolioVar.value.o_OutputOut.messageAttr) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ReznLLqpw0uv0n3R7w1QSg#Message.-142674135.1", "Folio has been") + " ") + ((vars.value.i_IsApproveInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ReznLLqpw0uv0n3R7w1QSg#Message.1249888983.1", "Approved")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ReznLLqpw0uv0n3R7w1QSg#Message.-543852386.1", "Rejected")))) + ".") + approvRejectFolioVar.value.o_OutputOut.messageAttr), /*Success*/ 1);
} else {
OS$FeedbackMessageService.showFeedbackMessage((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JsBk5DCGt0KzkCZUU4KxSg#Message.-142674135.1", "Folio has been") + " ") + ((vars.value.i_IsApproveInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JsBk5DCGt0KzkCZUU4KxSg#Message.1249888983.1", "Approved")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JsBk5DCGt0KzkCZUU4KxSg#Message.-543852386.1", "Rejected")))) + "."), /*Success*/ 1);
}

// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh
return controller.refresh$Action(false, true, false, model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.isInvoiceApprovalAttr, callContext).then(function () {
// Refresh Query: GetFolioApprovalLevelById
var result = controller.getFolioApprovalLevelById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
});
} else {
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(approvRejectFolioVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioActions.ApproveRejectFolio", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "680af8d0-d06a-4e2f-8a96-4655296e9f7c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_evidenceRequestFolio$Action(i_CommentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("EvidenceRequestFolio", function (span) {
if(span) {
span.setAttribute("code.function", "EvidenceRequestFolio");
span.setAttribute("outsystems.function.key", "16939645-4d73-4087-9a27-4016a23d93a7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("EvidenceRequestFolio");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.EvidenceRequestFolio$vars"))());
vars.value.i_CommentInLocal = i_CommentIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioEvidenceRequestVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FolioEvidenceRequest
model.flush();
return controller.folioEvidenceRequest$ServerAction(model.variables.i_FolioIdIn, model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr, vars.value.i_CommentInLocal, callContext).then(function (value) {
folioEvidenceRequestVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((folioEvidenceRequestVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("aaHt0OoL00iOetJNZyI63A#Message.887000711.1", "Request Evidence was sent."), /*Success*/ 1);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh
return controller.refresh$Action(false, false, false, false, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioEvidenceRequestVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioActions.EvidenceRequestFolio", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "49b16dcf-b4f1-41d4-9be5-9298f786f568");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_submenuInitialized$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SubmenuInitialized", function (span) {
if(span) {
span.setAttribute("code.function", "SubmenuInitialized");
span.setAttribute("outsystems.function.key", "22552c70-4a1e-4caf-9206-deabffbeef29");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SubmenuInitialized");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getFolioApprovalLevelByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioApprovalLevelByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalLevelByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "43eb899f-681c-41aa-8e8a-d82fe0eb4b91");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetFolioApprovalLevelByIdOnAfterFetch");
callContext = controller.callContext(callContext);
// l_IsFirstApprover = GetFolioApprovalLevelById.List.Current.FolioApprovalLevel.LevelNumber = 1
model.variables.l_IsFirstApproverVar = (model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.levelNumberAttr === 1);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_commentFolio$Action(i_CommentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CommentFolio", function (span) {
if(span) {
span.setAttribute("code.function", "CommentFolio");
span.setAttribute("outsystems.function.key", "4bb1b15b-04ce-4ca1-8120-c0a1665b74c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CommentFolio");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.CommentFolio$vars"))());
vars.value.i_CommentInLocal = i_CommentIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioCommentVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FolioComment
model.flush();
return controller.folioComment$ServerAction(model.variables.i_FolioIdIn, model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr, vars.value.i_CommentInLocal, callContext).then(function (value) {
folioCommentVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((folioCommentVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eiOrNOvfK0Soba7XJsFUpQ#Message.620780498.1", "Comment was added to Folio."), /*Success*/ 1);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh
return controller.refresh$Action(true, false, false, false, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioCommentVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioActions.CommentFolio", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "e9ec7fa3-3cf0-4831-bd26-f69180eb13c7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_resendEntryFolio$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ResendEntryFolio", function (span) {
if(span) {
span.setAttribute("code.function", "ResendEntryFolio");
span.setAttribute("outsystems.function.key", "535941bc-b3d7-4a30-85fb-6b6c9caeca7c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ResendEntryFolio");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioResendEntryVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FolioResendEntry
model.flush();
return controller.folioResendEntry$ServerAction(model.variables.i_FolioIdIn, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
folioResendEntryVar.value = value;
}).then(function () {
// error?
return OS$Flow.executeSequence(function () {
if(((!(folioResendEntryVar.value.o_OutputOut.isSuccessAttr)))) {
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(folioResendEntryVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
} else {
// message?
return OS$Flow.executeSequence(function () {
if((((folioResendEntryVar.value.o_OutputOut.messageAttr) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(folioResendEntryVar.value.o_OutputOut.messageAttr, /*Info*/ 0);
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh2
return controller.refresh$Action(false, false, false, false, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WlLyWGKsCEGRfJ7eBlsaqg#Message.-1881749851.1", "Entry request was successfull!"), /*Success*/ 1);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh
return controller.refresh$Action(false, false, false, false, callContext);
}

});
}

});
});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioActions.ResendEntryFolio", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "b672e695-4742-45a8-9e0e-05d0f830b94d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_wb_c_ReassignFolioFromRejectPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_c_ReassignFolioFromRejectPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_ReassignFolioFromRejectPopupOpenClose");
span.setAttribute("outsystems.function.key", "5fcb6c65-b873-4992-b82e-6d06f73abc8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_c_ReassignFolioFromRejectPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_c_ReassignFolioFromRejectPopupOpenClose$vars"))());
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

// l_ShowReassignFolioFromRejectPopup = notl_ShowReassignFolioFromRejectPopup
model.variables.l_ShowReassignFolioFromRejectPopupVar = (!(model.variables.l_ShowReassignFolioFromRejectPopupVar));
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsRefreshInLocal)) {
// Trigger Event: Refresh
return controller.refresh$Action(false, false, true, false, callContext);
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
_cancelFolio$Action(i_CommentIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelFolio", function (span) {
if(span) {
span.setAttribute("code.function", "CancelFolio");
span.setAttribute("outsystems.function.key", "6f6e985f-d12d-4892-8e20-8d344b4ed9e5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CancelFolio");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.CancelFolio$vars"))());
vars.value.i_CommentInLocal = i_CommentIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioCancelVar = new OS$DataTypes.VariableHolder();
var folioCancelFromAlmacenVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.getUserInfoDataAct.isAllowedReassignOut)) {
// Execute Action: FolioCancelFromAlmacen
model.flush();
return controller.folioCancelFromAlmacen$ServerAction(model.variables.i_FolioIdIn, vars.value.i_CommentInLocal, callContext).then(function (value) {
folioCancelFromAlmacenVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((folioCancelFromAlmacenVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4pszIhu_1ESZUeVYLYLjoQ#Message.997110435.1", "Form has been Canceled."), /*Success*/ 1);
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh2
return controller.refresh$Action(false, false, false, false, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioCancelFromAlmacenVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Execute Action: HideLoading7
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
} else {
// Execute Action: FolioCancel
model.flush();
return controller.folioCancelFromApprover$ServerAction(model.variables.i_FolioIdIn, model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr, vars.value.i_CommentInLocal, callContext).then(function (value) {
folioCancelVar.value = value;
}).then(function () {
// IsSuccess
return OS$Flow.executeSequence(function () {
if((folioCancelVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6GLk+GjH9UKOaYNxT1_5Yw#Message.997110435.1", "Form has been Canceled."), /*Success*/ 1);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Trigger Event: Refresh
return controller.refresh$Action(false, false, false, false, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioCancelVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioActions.CancelFolio", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "d6027b0e-5ee1-4227-9296-e6b093bfa96e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
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
_wb_b_CancelFolioPopupOpenClose$Action(isRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_CancelFolioPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_CancelFolioPopupOpenClose");
span.setAttribute("outsystems.function.key", "7cae2f74-63af-4d32-95ba-2fc69557028e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_CancelFolioPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_CancelFolioPopupOpenClose$vars"))());
vars.value.isRefreshInLocal = isRefreshIn;
return OS$Flow.executeAsyncFlow(function () {
// I_ShowCancelPopup = notI_ShowCancelPopup
model.variables.i_ShowCancelPopupVar = (!(model.variables.i_ShowCancelPopupVar));
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshInLocal)) {
// Trigger Event: Refresh
return controller.refresh$Action(false, true, false, false, callContext);
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
_wb_b_IncorrectAssignmentPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_IncorrectAssignmentPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_IncorrectAssignmentPopupOpenClose");
span.setAttribute("outsystems.function.key", "81c5dd60-8639-4326-884f-c62926ab9af9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_IncorrectAssignmentPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_IncorrectAssignmentPopupOpenClose$vars"))());
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
var submenuClose2Var = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose2
submenuClose2Var.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

// l_ShowIncorrectAssignmentPopup = notl_ShowIncorrectAssignmentPopup
model.variables.l_ShowIncorrectAssignmentPopupVar = (!(model.variables.l_ShowIncorrectAssignmentPopupVar));
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsRefreshInLocal)) {
// Trigger Event: Refresh
return controller.refresh$Action(false, true, false, false, callContext);
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
_wb_b_ResendEntryPopupOpenClose$Action(i_IsSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_ResendEntryPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_ResendEntryPopupOpenClose");
span.setAttribute("outsystems.function.key", "b32ae7e0-23dd-4bcb-b047-9ab25c475eba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_ResendEntryPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_ResendEntryPopupOpenClose$vars"))());
vars.value.i_IsSaveInLocal = i_IsSaveIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Execute Action: ResendEntryFolio
return controller._resendEntryFolio$Action(callContext);
}

}).then(function () {
// l_ShowResendEntryPopup = notl_ShowResendEntryPopup
model.variables.l_ShowResendEntryPopupVar = (!(model.variables.l_ShowResendEntryPopupVar));
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
_wb_b_EstablishFlowPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_EstablishFlowPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_EstablishFlowPopupOpenClose");
span.setAttribute("outsystems.function.key", "b482ac76-47a9-4739-add0-bd6a66a00adc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_EstablishFlowPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_EstablishFlowPopupOpenClose$vars"))());
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

// l_ShowEstablishFlowPopup = notl_ShowEstablishFlowPopup
model.variables.l_ShowEstablishFlowPopupVar = (!(model.variables.l_ShowEstablishFlowPopupVar));
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsRefreshInLocal)) {
// Trigger Event: Refresh
return controller.refresh$Action(false, true, false, false, callContext);
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
_wb_b_ReassignPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_ReassignPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_ReassignPopupOpenClose");
span.setAttribute("outsystems.function.key", "d293de6c-71f3-4516-b8bb-bfeba9cd8e75");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_ReassignPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_ReassignPopupOpenClose$vars"))());
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

// l_ShowReassignPopup = notl_ShowReassignPopup
model.variables.l_ShowReassignPopupVar = (!(model.variables.l_ShowReassignPopupVar));
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsRefreshInLocal)) {
// Trigger Event: Refresh
return controller.refresh$Action(false, true, false, false, callContext);
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
_wb_b_CompleteEntryPopupOpenClose$Action(i_IsSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_b_CompleteEntryPopupOpenClose", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_CompleteEntryPopupOpenClose");
span.setAttribute("outsystems.function.key", "e6d84479-3a5b-4d36-b4d6-027e3945591a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_b_CompleteEntryPopupOpenClose");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_CompleteEntryPopupOpenClose$vars"))());
vars.value.i_IsSaveInLocal = i_IsSaveIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Trigger Event: Refresh
return controller.refresh$Action(false, false, false, false, callContext);
} else {
// l_ShowCompleteEntryPopup = notl_ShowCompleteEntryPopup
model.variables.l_ShowCompleteEntryPopupVar = (!(model.variables.l_ShowCompleteEntryPopupVar));
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
_wb_a_OpenClosePopUp$Action(i_IsSaveIn, i_CommentIn, i_IsEvidenceRequestIn, i_IsRejectIn, i_IsCommentIn, i_IsCancelIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_a_OpenClosePopUp", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_OpenClosePopUp");
span.setAttribute("outsystems.function.key", "f394fae4-fb16-41d2-bfcf-6773e987cac9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_a_OpenClosePopUp");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_a_OpenClosePopUp$vars"))());
vars.value.i_IsSaveInLocal = i_IsSaveIn;
vars.value.i_CommentInLocal = i_CommentIn;
vars.value.i_IsEvidenceRequestInLocal = i_IsEvidenceRequestIn;
vars.value.i_IsRejectInLocal = i_IsRejectIn;
vars.value.i_IsCommentInLocal = i_IsCommentIn;
vars.value.i_IsCancelInLocal = i_IsCancelIn;
var submenuCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: SubmenuClose
submenuCloseVar.value = OutSystemsUIController$submenuClose$Action(idService.getId("Submenu"), callContext);

// Clear Locals
// l_EvidenceRequest = False
model.variables.l_EvidenceRequestVar = false;
// l_Reject = False
model.variables.l_RejectVar = false;
// l_Comment = False
model.variables.l_CommentVar = false;
// l_Cancel = False
model.variables.l_CancelVar = false;
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsEvidenceRequestInLocal)) {
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Execute Action: EvidenceRequestFolio
return controller._evidenceRequestFolio$Action(vars.value.i_CommentInLocal, callContext);
} else {
// l_PopupTitle = "Request Evidence Folio"
model.variables.l_PopupTitleVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("D7S1k6Epqki0Brd6a+mBmA#Value.104028145.1", "Request Evidence Folio");
// l_EvidenceRequest = i_IsEvidenceRequest
model.variables.l_EvidenceRequestVar = vars.value.i_IsEvidenceRequestInLocal;
}

});
} else {
return OS$Flow.executeSequence(function () {
if(vars.value.i_IsRejectInLocal) {
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Execute Action: ApproveRejectForm
return controller._approveRejectFolio$Action(false, vars.value.i_CommentInLocal, callContext);
} else {
// l_PopupTitle = "Reject Folio"
model.variables.l_PopupTitleVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("s6GzgJ4fF0u+oIkXBcc0Uw#Value.966454632.1", "Reject Folio");
// l_Reject = i_IsReject
model.variables.l_RejectVar = vars.value.i_IsRejectInLocal;
}

});
} else {
return OS$Flow.executeSequence(function () {
if(vars.value.i_IsCommentInLocal) {
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Execute Action: Comment
return controller._commentFolio$Action(vars.value.i_CommentInLocal, callContext);
} else {
// l_PopupTitle = "Comment Folio"
model.variables.l_PopupTitleVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5ELFyBKvYkWNq3ekTzc06Q#Value.2142516200.1", "Comment Folio");
// l_Comment = i_IsComment
model.variables.l_CommentVar = vars.value.i_IsCommentInLocal;
}

});
} else {
return OS$Flow.executeSequence(function () {
if(vars.value.i_IsCancelInLocal) {
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Execute Action: Cancel
return controller._cancelFolio$Action(vars.value.i_CommentInLocal, callContext);
} else {
// l_PopupTitle = "Cancel Folio"
model.variables.l_PopupTitleVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("J1j+WDO0I0Cixk5xSDEJbg#Value.1137498115.1", "Cancel Folio");
// l_Cancel = i_IsCancel
model.variables.l_CancelVar = vars.value.i_IsCancelInLocal;
}

});
} else {
return OS$Flow.returnAsync();

}

});
}

});
}

});
}

}).then(function () {
// l_ShowPopUp = notl_ShowPopUp
model.variables.l_ShowPopUpVar = (!(model.variables.l_ShowPopUpVar));
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsSaveInLocal)) {
// Refresh Query: GetFolioApprovalLevelById
var result = controller.getFolioApprovalLevelById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
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

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "0533263a-2218-477c-90b3-2b37a95092bf");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "06c8b7a9-3c91-4bc3-98ba-12175c955a6e");
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

wb_b_ApprovePopupOpenClose$Action(i_IsSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_ApprovePopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_ApprovePopupOpenClose");
span.setAttribute("outsystems.function.key", "0cd0bbe6-a980-4620-854c-2a8d964eddd8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_ApprovePopupOpenClose$Action, callContext, i_IsSaveIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

approveRejectFolio$Action(i_IsApproveIn, i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveRejectFolio__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRejectFolio");
span.setAttribute("outsystems.function.key", "13298702-95d3-42d5-a746-40ea1fda28c3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approveRejectFolio$Action, callContext, i_IsApproveIn, i_CommentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

evidenceRequestFolio$Action(i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("EvidenceRequestFolio__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "EvidenceRequestFolio");
span.setAttribute("outsystems.function.key", "16939645-4d73-4087-9a27-4016a23d93a7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._evidenceRequestFolio$Action, callContext, i_CommentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

submenuInitialized$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SubmenuInitialized__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SubmenuInitialized");
span.setAttribute("outsystems.function.key", "22552c70-4a1e-4caf-9206-deabffbeef29");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._submenuInitialized$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getFolioApprovalLevelByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioApprovalLevelByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioApprovalLevelByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "43eb899f-681c-41aa-8e8a-d82fe0eb4b91");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getFolioApprovalLevelByIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

commentFolio$Action(i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CommentFolio__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CommentFolio");
span.setAttribute("outsystems.function.key", "4bb1b15b-04ce-4ca1-8120-c0a1665b74c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._commentFolio$Action, callContext, i_CommentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

resendEntryFolio$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ResendEntryFolio__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ResendEntryFolio");
span.setAttribute("outsystems.function.key", "535941bc-b3d7-4a30-85fb-6b6c9caeca7c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._resendEntryFolio$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_c_ReassignFolioFromRejectPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_c_ReassignFolioFromRejectPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_c_ReassignFolioFromRejectPopupOpenClose");
span.setAttribute("outsystems.function.key", "5fcb6c65-b873-4992-b82e-6d06f73abc8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_c_ReassignFolioFromRejectPopupOpenClose$Action, callContext, i_IsRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

cancelFolio$Action(i_CommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelFolio__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelFolio");
span.setAttribute("outsystems.function.key", "6f6e985f-d12d-4892-8e20-8d344b4ed9e5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._cancelFolio$Action, callContext, i_CommentIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_CancelFolioPopupOpenClose$Action(isRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_CancelFolioPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_CancelFolioPopupOpenClose");
span.setAttribute("outsystems.function.key", "7cae2f74-63af-4d32-95ba-2fc69557028e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_CancelFolioPopupOpenClose$Action, callContext, isRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_IncorrectAssignmentPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_IncorrectAssignmentPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_IncorrectAssignmentPopupOpenClose");
span.setAttribute("outsystems.function.key", "81c5dd60-8639-4326-884f-c62926ab9af9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_IncorrectAssignmentPopupOpenClose$Action, callContext, i_IsRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_ResendEntryPopupOpenClose$Action(i_IsSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_ResendEntryPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_ResendEntryPopupOpenClose");
span.setAttribute("outsystems.function.key", "b32ae7e0-23dd-4bcb-b047-9ab25c475eba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_ResendEntryPopupOpenClose$Action, callContext, i_IsSaveIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_EstablishFlowPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_EstablishFlowPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_EstablishFlowPopupOpenClose");
span.setAttribute("outsystems.function.key", "b482ac76-47a9-4739-add0-bd6a66a00adc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_EstablishFlowPopupOpenClose$Action, callContext, i_IsRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_ReassignPopupOpenClose$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_ReassignPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_ReassignPopupOpenClose");
span.setAttribute("outsystems.function.key", "d293de6c-71f3-4516-b8bb-bfeba9cd8e75");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_ReassignPopupOpenClose$Action, callContext, i_IsRefreshIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_b_CompleteEntryPopupOpenClose$Action(i_IsSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_b_CompleteEntryPopupOpenClose__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_b_CompleteEntryPopupOpenClose");
span.setAttribute("outsystems.function.key", "e6d84479-3a5b-4d36-b4d6-027e3945591a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_b_CompleteEntryPopupOpenClose$Action, callContext, i_IsSaveIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_a_OpenClosePopUp$Action(i_IsSaveIn, i_CommentIn, i_IsEvidenceRequestIn, i_IsRejectIn, i_IsCommentIn, i_IsCancelIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_a_OpenClosePopUp__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_a_OpenClosePopUp");
span.setAttribute("outsystems.function.key", "f394fae4-fb16-41d2-bfcf-6773e987cac9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_a_OpenClosePopUp$Action, callContext, i_IsSaveIn, i_CommentIn, i_IsEvidenceRequestIn, i_IsRejectIn, i_IsCommentIn, i_IsCancelIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get refresh$Action() {if(!(this.hasOwnProperty("_refresh$Action"))) {
this._refresh$Action = function () {
return Promise.resolve();
};
}

return this._refresh$Action;
}set refresh$Action(value) {this._refresh$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionApprovRejectFolio", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioEvidenceRequest", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioComment", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioResendEntry", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioCancelFromApprover", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions$ActionFolioCancelFromAlmacen", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_ApprovePopupOpenClose$vars", [{
name: "i_IsSave",
attrName: "i_IsSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.ApproveRejectFolio$vars", [{
name: "i_IsApprove",
attrName: "i_IsApproveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_Comment",
attrName: "i_CommentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.EvidenceRequestFolio$vars", [{
name: "i_Comment",
attrName: "i_CommentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.CommentFolio$vars", [{
name: "i_Comment",
attrName: "i_CommentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_c_ReassignFolioFromRejectPopupOpenClose$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.CancelFolio$vars", [{
name: "i_Comment",
attrName: "i_CommentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_CancelFolioPopupOpenClose$vars", [{
name: "IsRefresh",
attrName: "isRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_IncorrectAssignmentPopupOpenClose$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_ResendEntryPopupOpenClose$vars", [{
name: "i_IsSave",
attrName: "i_IsSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_EstablishFlowPopupOpenClose$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_ReassignPopupOpenClose$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_b_CompleteEntryPopupOpenClose$vars", [{
name: "i_IsSave",
attrName: "i_IsSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioActions.Wb_a_OpenClosePopUp$vars", [{
name: "i_IsSave",
attrName: "i_IsSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_Comment",
attrName: "i_CommentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "i_IsEvidenceRequest",
attrName: "i_IsEvidenceRequestInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsReject",
attrName: "i_IsRejectInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsComment",
attrName: "i_IsCommentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsCancel",
attrName: "i_IsCancelInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


