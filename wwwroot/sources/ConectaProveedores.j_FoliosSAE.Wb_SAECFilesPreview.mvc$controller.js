import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioFiles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFolioFiles$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
addNewExtraFilToFolio$ServerAction(fileIn, folioIn, supplierNumberIn, invoiceIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddNewExtraFilToFolio", function (span) {
if(span) {
span.setAttribute("code.function", "AddNewExtraFilToFolio");
span.setAttribute("outsystems.function.key", "63201c97-c8df-4daa-8a94-71cb1aa9fbdc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
File: OS$DataConversion.ServerDataConverter.to(fileIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
Folio: OS$DataConversion.ServerDataConverter.to(folioIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
SupplierNumber: OS$DataConversion.ServerDataConverter.to(supplierNumberIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Invoice: OS$DataConversion.ServerDataConverter.to(invoiceIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AddNewExtraFilToFolio", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECFilesPreview/ActionAddNewExtraFilToFolio", "dNHN+Zcx3lyLEzPEtOvLwA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
deleteExtraFileFromInvoice$ServerAction(i_invoicefileIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DeleteExtraFileFromInvoice", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteExtraFileFromInvoice");
span.setAttribute("outsystems.function.key", "db67885b-bbbb-404e-9355-c022b109eea6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_invoicefileId: OS$DataConversion.ServerDataConverter.to(i_invoicefileIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DeleteExtraFileFromInvoice", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECFilesPreview/ActionDeleteExtraFileFromInvoice", "7GkpSulvDyxg5vnWrMbcBQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getFolioFiles$DataActRefresh() {if(!(this.hasOwnProperty("_getFolioFiles$DataActRefresh"))) {
this._getFolioFiles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFolioFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SAECFilesPreview/DataActionGetFolioFiles", "FPDsd6LSGmY9j530ZaFfeQ", function (b) {
model.variables.getFolioFilesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioFilesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioFilesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioFiles");
span.setAttribute("outsystems.function.key", "9aa2808d-b131-4435-8ae2-0371e5d9e675");
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

return this._getFolioFiles$DataActRefresh;
}set getFolioFiles$DataActRefresh(value) {this._getFolioFiles$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioFiles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "1d58b5d5-320f-47f3-ab33-2c79bdb47cf4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioFiles
var result = controller.getFolioFiles$DataActRefresh(callContext);
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
_wb_DownloadFileStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "2fc99ed2-d9ed-429b-ab35-f80654bd0ad5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadFileStart");
callContext = controller.callContext(callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_DownloadAllFolioFilesByFileListStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListStart");
span.setAttribute("outsystems.function.key", "37b923ef-ccc6-404a-acbe-e92a83b48de1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadAllFolioFilesByFileListStart");
callContext = controller.callContext(callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_CustomFileUploadOnDropFile$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDropFile", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDropFile");
span.setAttribute("outsystems.function.key", "49fe891b-95c2-4ad6-9023-39ab9b57b3b0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_CustomFileUploadOnDropFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.Wb_CustomFileUploadOnDropFile$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if(((vars.value.errorInLocal.successAttr && !(model.variables.getFolioFilesDataAct.invoiceIDOut.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: AddNewExtraFilToFolio
model.flush();
return controller.addNewExtraFilToFolio$ServerAction(vars.value.fileInLocal, model.variables.getFolioFilesDataAct.folioOut, model.variables.getFolioFilesDataAct.supplierNumberOut, model.variables.getFolioFilesDataAct.invoiceOut, callContext).then(function () {
// Refresh Query: GetFolioFiles
var result = controller.getFolioFiles$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// l_ShowPopupUpload = False
model.variables.l_ShowPopupUploadVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_wb_DownloadFileEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "821ea166-bf52-41a9-b16c-f6db555d5cf6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadFileEnd");
callContext = controller.callContext(callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_DownloadAllFolioFilesByFileListEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListEnd", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListEnd");
span.setAttribute("outsystems.function.key", "b85845e4-803d-45de-a7f5-c09178d4122b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_DownloadAllFolioFilesByFileListEnd");
callContext = controller.callContext(callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_deleteOnClick$Action(invoiceFileIDIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DeleteOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteOnClick");
span.setAttribute("outsystems.function.key", "b9c3258d-dd87-48a0-bc1a-16c83c84b7d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DeleteOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.DeleteOnClick$vars"))());
vars.value.invoiceFileIDInLocal = invoiceFileIDIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Is Construction?
return OS$Flow.executeSequence(function () {
if((model.variables.getFolioFilesDataAct.isConstructionOut)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: DeleteExtraFileFromInvoice
model.flush();
return controller.deleteExtraFileFromInvoice$ServerAction(vars.value.invoiceFileIDInLocal, callContext).then(function () {
// Refresh Query: GetFolioFiles
var result = controller.getFolioFiles$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_cancelOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "d66bd352-6d05-47a5-ae03-0bb695616a38");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CancelOnClick");
callContext = controller.callContext(callContext);
// l_ShowPopupUpload = False
model.variables.l_ShowPopupUploadVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_CustomFileUploadOnDelete$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDelete", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDelete");
span.setAttribute("outsystems.function.key", "f740e952-fc6a-4bb2-9123-b6e51fce939b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomFileUploadOnDelete");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "1d58b5d5-320f-47f3-ab33-2c79bdb47cf4");
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

wb_DownloadFileStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "2fc99ed2-d9ed-429b-ab35-f80654bd0ad5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadFileStart$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_DownloadAllFolioFilesByFileListStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListStart");
span.setAttribute("outsystems.function.key", "37b923ef-ccc6-404a-acbe-e92a83b48de1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadAllFolioFilesByFileListStart$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_CustomFileUploadOnDropFile$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDropFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDropFile");
span.setAttribute("outsystems.function.key", "49fe891b-95c2-4ad6-9023-39ab9b57b3b0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_CustomFileUploadOnDropFile$Action, callContext, fileIn, errorIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_DownloadFileEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "821ea166-bf52-41a9-b16c-f6db555d5cf6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadFileEnd$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_DownloadAllFolioFilesByFileListEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListEnd");
span.setAttribute("outsystems.function.key", "b85845e4-803d-45de-a7f5-c09178d4122b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_DownloadAllFolioFilesByFileListEnd$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

deleteOnClick$Action(invoiceFileIDIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DeleteOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteOnClick");
span.setAttribute("outsystems.function.key", "b9c3258d-dd87-48a0-bc1a-16c83c84b7d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._deleteOnClick$Action, callContext, invoiceFileIDIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

cancelOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "d66bd352-6d05-47a5-ae03-0bb695616a38");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._cancelOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_CustomFileUploadOnDelete$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDelete__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDelete");
span.setAttribute("outsystems.function.key", "f740e952-fc6a-4bb2-9123-b6e51fce939b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CustomFileUploadOnDelete$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get refreshAfterUploadMoreEcidence$Action() {if(!(this.hasOwnProperty("_refreshAfterUploadMoreEcidence$Action"))) {
this._refreshAfterUploadMoreEcidence$Action = function () {
return Promise.resolve();
};
}

return this._refreshAfterUploadMoreEcidence$Action;
}set refreshAfterUploadMoreEcidence$Action(value) {this._refreshAfterUploadMoreEcidence$Action = value;
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.Wb_CustomFileUploadOnDropFile$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}, {
name: "Error",
attrName: "errorInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
},
complexType: ST_f9f8b40f5330871047e55e068d129447Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.DeleteOnClick$vars", [{
name: "InvoiceFileID",
attrName: "invoiceFileIDInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


