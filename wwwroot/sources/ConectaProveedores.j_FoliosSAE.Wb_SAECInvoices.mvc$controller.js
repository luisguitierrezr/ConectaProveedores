import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_f68ab54e767928bb7cc21e9801e8642bStructure, ST_cbb2055cf19f871ed882642269bd43ceStructure } from "./TelcelIntegrations.model.js";
import { SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoicesByFolioId$AggrRefresh: 0,
getFolioById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoicesByFolioId$AggrRefresh: [],
getFolioById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
call_ZMXMIMMF_VISUALIZAR_SAL_ANT$ServerAction(requestIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Call_ZMXMIMMF_VISUALIZAR_SAL_ANT", function (span) {
if(span) {
span.setAttribute("code.function", "Call_ZMXMIMMF_VISUALIZAR_SAL_ANT");
span.setAttribute("outsystems.function.key", "d68763c3-0573-4d0f-b5af-83de06f6eb6c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Request: OS$DataConversion.ServerDataConverter.to(requestIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Call_ZMXMIMMF_VISUALIZAR_SAL_ANT", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECInvoices/ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT", "mEDBUNKMySFTPNFDy4Vl+Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices$ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT"))();
executeServerActionResult.responseOut = OS$DataConversion.ServerDataConverter.from(outputs.Response, ST_cbb2055cf19f871ed882642269bd43ceStructure);
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
downloadInvoiceFiles$ServerAction(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadInvoiceFiles");
span.setAttribute("outsystems.function.key", "a7ddfd23-59f0-4a80-8ec4-33c9d74b80ff");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadInvoiceFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECInvoices/ActionDownloadInvoiceFiles", "q4fidEzmLEnK5H0av1aFqw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices$ActionDownloadInvoiceFiles"))();
executeServerActionResult.binaryZIPOut = OS$DataConversion.ServerDataConverter.from(outputs.BinaryZIP, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.errorMsgOut = OS$DataConversion.ServerDataConverter.from(outputs.ErrorMsg, OS$DataTypes.DataTypes.Text);
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
folioApproval_Construction$ServerAction(folioIdIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioApproval_Construction", function (span) {
if(span) {
span.setAttribute("code.function", "FolioApproval_Construction");
span.setAttribute("outsystems.function.key", "7ae59225-4de1-4484-a80e-f40459330fca");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
FolioId: OS$DataConversion.ServerDataConverter.to(folioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioApproval_Construction", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECInvoices/ActionFolioApproval_Construction", "Kobc9IPla_3R74STLnLJLQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getInvoicesByFolioId$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoicesByFolioId$AggrRefresh"))) {
this._getInvoicesByFolioId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoicesByFolioId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECInvoices/ScreenDataSetGetInvoicesByFolioId", "glnE7+gRLkXbgsf8D8vOKg", maxRecords, startIndex, function (b) {
model.variables.getInvoicesByFolioIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesByFolioIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesByFolioIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getInvoicesByFolioIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesByFolioId", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByFolioId");
span.setAttribute("outsystems.function.key", "3dc8fdf4-b752-4a50-9efb-8326f1374dad");
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

return this._getInvoicesByFolioId$AggrRefresh;
}set getInvoicesByFolioId$AggrRefresh(value) {this._getInvoicesByFolioId$AggrRefresh = value;
}

get getFolioById$AggrRefresh() {if(!(this.hasOwnProperty("_getFolioById$AggrRefresh"))) {
this._getFolioById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFolioById", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECInvoices/ScreenDataSetGetFolioById", "7ueKcXlIr0yPrYZxMFEBDg", maxRecords, startIndex, function (b) {
model.variables.getFolioByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getFolioByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioById", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioById");
span.setAttribute("outsystems.function.key", "d0aaa019-a4ed-49e6-83f5-947143fc9011");
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

return this._getFolioById$AggrRefresh;
}set getFolioById$AggrRefresh(value) {this._getFolioById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoicesByFolioId$AggrRefresh", "getFolioById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getFolioByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "38194b33-15f2-46db-9925-c3aa111a3312");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetFolioByIdOnAfterFetch");
callContext = controller.callContext(callContext);
var call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: Call_ZMXMIMMF_VISUALIZAR_SAL_ANT
model.flush();
return controller.call_ZMXMIMMF_VISUALIZAR_SAL_ANT$ServerAction(function () {
var rec = new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
rec.pI_PEDIDOAttr = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr;
return rec;
}(), callContext).then(function (value) {
call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar.value = value;
}).then(function () {
// l_ImportAnticipo = Call_ZMXMIMMF_VISUALIZAR_SAL_ANT.Response.PO_IMP_ANT
model.variables.l_ImportAnticipoVar = call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar.value.responseOut.pO_IMP_ANTAttr;
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
_onClickDownload$Action(invoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickDownload", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickDownload");
span.setAttribute("outsystems.function.key", "3bc7a6bd-81d6-4f1e-9613-62cf65afbf51");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickDownload");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.OnClickDownload$vars"))());
vars.value.invoiceIdInLocal = invoiceIdIn;
var downloadInvoiceFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: DownloadInvoiceFiles
model.flush();
return controller.downloadInvoiceFiles$ServerAction(vars.value.invoiceIdInLocal, callContext).then(function (value) {
downloadInvoiceFilesVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadInvoiceFilesVar.value.binaryZIPOut, (((model.variables.getInvoicesByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr + "-") + OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.currDate())) + ".zip")));
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
_getInvoicesByFolioIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoicesByFolioIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "605a034c-a888-46b2-8be4-852ae4dcd6d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetInvoicesByFolioIdOnAfterFetch");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesByFolioIdAggr.listOut, function (p) {
return ((p.invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.canceled));
}, callContext);

// l_CanUploadInvoice = ListFilter.FilteredList.Empty
model.variables.l_CanUploadInvoiceVar = listFilterVar.value.filteredListOut.isEmpty;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_togglePopupUploadInvoices$Action(needsRefreshIn, invoiceIdIn, invoiceStatusIdIn, creditNoteInvoiceIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TogglePopupUploadInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupUploadInvoices");
span.setAttribute("outsystems.function.key", "673bbec0-ab01-4565-9293-43b2a6ab9405");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("TogglePopupUploadInvoices");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.TogglePopupUploadInvoices$vars"))());
vars.value.needsRefreshInLocal = needsRefreshIn;
vars.value.invoiceIdInLocal = invoiceIdIn;
vars.value.invoiceStatusIdInLocal = invoiceStatusIdIn;
vars.value.creditNoteInvoiceIdInLocal = creditNoteInvoiceIdIn;
return OS$Flow.executeAsyncFlow(function () {
// l_IsOpenPopupInvoices = notl_IsOpenPopupInvoices
model.variables.l_IsOpenPopupInvoicesVar = (!(model.variables.l_IsOpenPopupInvoicesVar));
// l_InvoiceIdToPopup = InvoiceId
model.variables.l_InvoiceIdToPopupVar = vars.value.invoiceIdInLocal;
// l_InvoiceStatusIdToPopup = InvoiceStatusId
model.variables.l_InvoiceStatusIdToPopupVar = vars.value.invoiceStatusIdInLocal;
// l_CreditNoteInvoiceIdToPopup = CreditNoteInvoiceId
model.variables.l_CreditNoteInvoiceIdToPopupVar = vars.value.creditNoteInvoiceIdInLocal;
return OS$Flow.executeSequence(function () {
if((vars.value.needsRefreshInLocal)) {
// Execute Action: OnInvoiceSuccess
return controller._onInvoiceSuccess$Action(callContext);
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
_onInvoiceSuccess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInvoiceSuccess", function (span) {
if(span) {
span.setAttribute("code.function", "OnInvoiceSuccess");
span.setAttribute("outsystems.function.key", "a60f3798-92d8-4fca-b305-1b9327c25870");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnInvoiceSuccess");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: FolioApproval_Construction
model.flush();
return controller.folioApproval_Construction$ServerAction(model.variables.i_FolioIdIn, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function () {
// Trigger Event: Refresh
return controller.refresh$Action(callContext);
}).then(function () {
// Refresh Query: GetInvoicesByFolioId
var result = controller.getInvoicesByFolioId$AggrRefresh(9999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetFolioById
var result = controller.getFolioById$AggrRefresh(1, 0, callContext);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "c447e21d-32cb-40c2-a414-27bb2e1556d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetInvoicesByFolioId
var result = controller.getInvoicesByFolioId$AggrRefresh(9999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetFolioById
var result = controller.getFolioById$AggrRefresh(1, 0, callContext);
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

getFolioByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetFolioByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "38194b33-15f2-46db-9925-c3aa111a3312");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getFolioByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onClickDownload$Action(invoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickDownload__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickDownload");
span.setAttribute("outsystems.function.key", "3bc7a6bd-81d6-4f1e-9613-62cf65afbf51");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickDownload$Action, callContext, invoiceIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getInvoicesByFolioIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoicesByFolioIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByFolioIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "605a034c-a888-46b2-8be4-852ae4dcd6d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getInvoicesByFolioIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

togglePopupUploadInvoices$Action(needsRefreshIn, invoiceIdIn, invoiceStatusIdIn, creditNoteInvoiceIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TogglePopupUploadInvoices__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TogglePopupUploadInvoices");
span.setAttribute("outsystems.function.key", "673bbec0-ab01-4565-9293-43b2a6ab9405");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._togglePopupUploadInvoices$Action, callContext, needsRefreshIn, invoiceIdIn, invoiceStatusIdIn, creditNoteInvoiceIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInvoiceSuccess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInvoiceSuccess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInvoiceSuccess");
span.setAttribute("outsystems.function.key", "a60f3798-92d8-4fca-b305-1b9327c25870");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onInvoiceSuccess$Action, callContext);
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
span.setAttribute("outsystems.function.key", "c447e21d-32cb-40c2-a414-27bb2e1556d1");
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices$ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT", [{
name: "Response",
attrName: "responseOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_cbb2055cf19f871ed882642269bd43ceStructure();
},
complexType: ST_cbb2055cf19f871ed882642269bd43ceStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices$ActionDownloadInvoiceFiles", [{
name: "BinaryZIP",
attrName: "binaryZIPOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.OnClickDownload$vars", [{
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.TogglePopupUploadInvoices$vars", [{
name: "NeedsRefresh",
attrName: "needsRefreshInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "InvoiceId",
attrName: "invoiceIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "InvoiceStatusId",
attrName: "invoiceStatusIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "CreditNoteInvoiceId",
attrName: "creditNoteInvoiceIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


