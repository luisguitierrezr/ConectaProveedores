import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_controller_OnReady_JavaScript1JS from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$controller.OnReady.JavaScript1JS.js";
import { EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_controller_OnClickSendMsg_scrollToBottomJS from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$controller.OnClickSendMsg.scrollToBottomJS.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_controller_GetInvoiceCommentsOnAfterFetch_scrollToBottomJS from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$controller.GetInvoiceCommentsOnAfterFetch.scrollToBottomJS.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_TranslationsResources from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceCommentsByInvoiceId$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceCommentsByInvoiceId$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
addComment$ServerAction(i_InvoiceCommentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddComment", function (span) {
if(span) {
span.setAttribute("code.function", "AddComment");
span.setAttribute("outsystems.function.key", "50e9bd3f-efad-4902-b737-8b22ea5dbb10");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_InvoiceComment: OS$DataConversion.ServerDataConverter.to(i_InvoiceCommentIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AddComment", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsChat/ActionAddComment", "szhCwpdNyjZU166N3EQtMw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat$ActionAddComment"))();
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
get getInvoiceCommentsByInvoiceId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceCommentsByInvoiceId$AggrRefresh"))) {
this._getInvoiceCommentsByInvoiceId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceCommentsByInvoiceId", "screenservices/ConectaProveedores/d_Invoices/Wb_InvoiceDetailsChat/ScreenDataSetGetInvoiceCommentsByInvoiceId", "cxf70vYAHTvZ4iB9hYC1gw", maxRecords, startIndex, function (b) {
model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceCommentsByInvoiceIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceCommentsByInvoiceIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getInvoiceCommentsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceCommentsByInvoiceId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCommentsByInvoiceId");
span.setAttribute("outsystems.function.key", "1324e1cb-eeef-4928-ab3a-2dd306546de1");
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

return this._getInvoiceCommentsByInvoiceId$AggrRefresh;
}set getInvoiceCommentsByInvoiceId$AggrRefresh(value) {this._getInvoiceCommentsByInvoiceId$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoiceCommentsByInvoiceId$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "1241642f-2a73-40b0-9791-1a4060c7bcc0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
if((ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)) {
// IsPublic = True
model.variables.isPublicVar = true;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onScrollEnding$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnScrollEnding", function (span) {
if(span) {
span.setAttribute("code.function", "OnScrollEnding");
span.setAttribute("outsystems.function.key", "1472cebc-d365-4269-ba16-350115f0a522");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnScrollEnding");
callContext = controller.callContext(callContext);
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
span.setAttribute("outsystems.function.key", "1aabd7c3-23be-42ee-909d-db84c4811b38");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("JavaScript1", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript1");
span.setAttribute("outsystems.function.key", "d60caeac-dc23-4932-8666-9418ad597a47");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_controller_OnReady_JavaScript1JS, "JavaScript1", "OnReady", null, function ($parameters) {
}, {}, {});
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
_onClickSendMsg$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickSendMsg", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSendMsg");
span.setAttribute("outsystems.function.key", "602d5a77-145a-4469-9bd5-ebf30bb5583f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickSendMsg");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var addCommentVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: AddComment
model.flush();
return controller.addComment$ServerAction(function () {
var rec = new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.invoiceIdAttr = model.variables.i_InvoiceIdIn;
rec.messageAttr = model.variables.newMsgVar;
rec.isPublicAttr = model.variables.isPublicVar;
return rec;
}(), callContext).then(function (value) {
addCommentVar.value = value;
}).then(function () {
// Refresh Query: GetInvoiceCommentsByInvoiceId
var result = controller.getInvoiceCommentsByInvoiceId$AggrRefresh(model.variables.l_MaxRecordsVar, 0, callContext);
model.flush();
return result;
}).then(function () {
// NewMsg = ""
model.variables.newMsgVar = "";
OS$Logger.startActiveSpan("scrollToBottom", function (span) {
if(span) {
span.setAttribute("code.function", "scrollToBottom");
span.setAttribute("outsystems.function.key", "60450d4a-4ced-4ad3-927f-f5ae3facf6f5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_controller_OnClickSendMsg_scrollToBottomJS, "scrollToBottom", "OnClickSendMsg", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
});
}).catch(function (ex) {
OS$Logger.debug("Wb_InvoiceDetailsChat.OnClickSendMsg", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "b704338c-29aa-4256-946d-687ae686897c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("N3PKbCt5ykCT0WUItMb0qQ#Message.1940766226.1", "Message not sent due to a error"), /*Error*/ 3);
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
_getInvoiceCommentsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceCommentsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCommentsOnAfterFetch");
span.setAttribute("outsystems.function.key", "75221066-4d94-40b3-a177-7e8709e0fbf5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetInvoiceCommentsOnAfterFetch");
callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("scrollToBottom", function (span) {
if(span) {
span.setAttribute("code.function", "scrollToBottom");
span.setAttribute("outsystems.function.key", "f6fe00a8-8d46-4ca0-a3bb-b2e52d4bb2ed");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_controller_GetInvoiceCommentsOnAfterFetch_scrollToBottomJS, "scrollToBottom", "GetInvoiceCommentsOnAfterFetch", null, function ($parameters) {
}, {}, {});
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
_onClickMenu$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickMenu", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickMenu");
span.setAttribute("outsystems.function.key", "7a3c6b03-b2a5-4d2a-a4b8-5bedcb044567");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickMenu");
callContext = controller.callContext(callContext);
// IsOpenMenu = notIsOpenMenu
model.variables.isOpenMenuVar = (!(model.variables.isOpenMenuVar));
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
span.setAttribute("outsystems.function.key", "9d6e0c52-4f63-4ddb-83a0-ace25640260a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoiceCommentsByInvoiceId
var result = controller.getInvoiceCommentsByInvoiceId$AggrRefresh(model.variables.l_MaxRecordsVar, 0, callContext);
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
_onClickErase$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickErase", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickErase");
span.setAttribute("outsystems.function.key", "c979c574-05be-45c7-9496-b43756fe7b3b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickErase");
callContext = controller.callContext(callContext);
// NewMsg = ""
model.variables.newMsgVar = "";
// IsOpenMenu = False
model.variables.isOpenMenuVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_closeMenu$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseMenu", function (span) {
if(span) {
span.setAttribute("code.function", "CloseMenu");
span.setAttribute("outsystems.function.key", "d38537e0-f52d-4111-8d98-1be6dc481202");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseMenu");
callContext = controller.callContext(callContext);
// IsOpenMenu = False
model.variables.isOpenMenuVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "1241642f-2a73-40b0-9791-1a4060c7bcc0");
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

onScrollEnding$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnScrollEnding__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnScrollEnding");
span.setAttribute("outsystems.function.key", "1472cebc-d365-4269-ba16-350115f0a522");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onScrollEnding$Action, callContext);
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
span.setAttribute("outsystems.function.key", "1aabd7c3-23be-42ee-909d-db84c4811b38");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickSendMsg$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickSendMsg__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSendMsg");
span.setAttribute("outsystems.function.key", "602d5a77-145a-4469-9bd5-ebf30bb5583f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickSendMsg$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getInvoiceCommentsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceCommentsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceCommentsOnAfterFetch");
span.setAttribute("outsystems.function.key", "75221066-4d94-40b3-a177-7e8709e0fbf5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getInvoiceCommentsOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickMenu$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickMenu__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickMenu");
span.setAttribute("outsystems.function.key", "7a3c6b03-b2a5-4d2a-a4b8-5bedcb044567");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickMenu$Action, callContext);
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
span.setAttribute("outsystems.function.key", "9d6e0c52-4f63-4ddb-83a0-ace25640260a");
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

onClickErase$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickErase__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickErase");
span.setAttribute("outsystems.function.key", "c979c574-05be-45c7-9496-b43756fe7b3b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickErase$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

closeMenu$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseMenu__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseMenu");
span.setAttribute("outsystems.function.key", "d38537e0-f52d-4111-8d98-1be6dc481202");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeMenu$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat$ActionAddComment", [{
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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


