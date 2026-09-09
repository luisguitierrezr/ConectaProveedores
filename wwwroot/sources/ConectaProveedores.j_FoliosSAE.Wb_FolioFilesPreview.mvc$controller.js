import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFolioFiles2$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getFolioFiles2$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("DeleteExtraFileFromInvoice", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioFilesPreview/ActionDeleteExtraFileFromInvoice", "7GkpSulvDyxg5vnWrMbcBQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
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
return controller.callServerAction("AddNewExtraFilToFolio", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioFilesPreview/ActionAddNewExtraFilToFolio", "dNHN+Zcx3lyLEzPEtOvLwA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getFolioFiles2$DataActRefresh() {if(!(this.hasOwnProperty("_getFolioFiles2$DataActRefresh"))) {
this._getFolioFiles2$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFolioFiles2", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioFilesPreview/DataActionGetFolioFiles2", "9ZFVAm++ZKS8GuAuXPCCrQ", function (b) {
model.variables.getFolioFiles2DataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFolioFiles2DataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFolioFiles2DataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFolioFiles2", function (span) {
if(span) {
span.setAttribute("code.function", "GetFolioFiles2");
span.setAttribute("outsystems.function.key", "3c097206-2f10-4aac-a7c8-7c6a0188ce77");
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

return this._getFolioFiles2$DataActRefresh;
}set getFolioFiles2$DataActRefresh(value) {this._getFolioFiles2$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFolioFiles2$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_deleteOnClick$Action(invoiceFileIDIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DeleteOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteOnClick");
span.setAttribute("outsystems.function.key", "289b097b-a708-4e0b-b206-47da65abb283");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DeleteOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.DeleteOnClick$vars"))());
vars.value.invoiceFileIDInLocal = invoiceFileIDIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Is Construction?
return OS$Flow.executeSequence(function () {
if((model.variables.getFolioFiles2DataAct.isConstructionOut)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: DeleteExtraFileFromInvoice
model.flush();
return controller.deleteExtraFileFromInvoice$ServerAction(vars.value.invoiceFileIDInLocal, callContext).then(function () {
// Refresh Query: GetFolioFiles2
var result = controller.getFolioFiles2$DataActRefresh(callContext);
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
_wb_CustomFileUploadOnDropFile$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDropFile", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDropFile");
span.setAttribute("outsystems.function.key", "48c23ee6-6082-4ef8-adf6-ec7271ccefd8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_CustomFileUploadOnDropFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.Wb_CustomFileUploadOnDropFile$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if(((vars.value.errorInLocal.successAttr && !(model.variables.getFolioFiles2DataAct.invoiceIDOut.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: AddNewExtraFilToFolio
model.flush();
return controller.addNewExtraFilToFolio$ServerAction(vars.value.fileInLocal, model.variables.getFolioFiles2DataAct.folioOut, model.variables.getFolioFiles2DataAct.supplierNumberOut, model.variables.getFolioFiles2DataAct.invoiceOut, callContext).then(function () {
// Refresh Query: GetFolioFiles2
var result = controller.getFolioFiles2$DataActRefresh(callContext);
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
_wb_CustomFileUploadOnDelete$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDelete", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDelete");
span.setAttribute("outsystems.function.key", "4da030b8-a6c8-41bb-b369-13c753265fe1");
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
_wb_DownloadAllFolioFilesByFileListStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListStart");
span.setAttribute("outsystems.function.key", "54184996-3d33-4755-b2a3-b04ee5c2bdf6");
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
_cancelOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "6ed34128-7a28-4b76-875d-d5f5807ab45f");
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
_wb_DownloadFileStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "9d6b464a-1ab5-4fcd-94c7-ab98044b756a");
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
_wb_DownloadFileEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "b1b51d04-885f-49d3-8cc0-a1402108a227");
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "c6d695e3-fc03-4c08-bf4f-f1101addbe68");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFolioFiles2
var result = controller.getFolioFiles2$DataActRefresh(callContext);
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
_wb_DownloadAllFolioFilesByFileListEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListEnd", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListEnd");
span.setAttribute("outsystems.function.key", "d0112456-da83-4739-817f-065ca4c0069b");
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
_linkOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "fad17382-7503-45f3-9fce-fb7fa88916cd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("LinkOnClick");
callContext = controller.callContext(callContext);
// l_ShowPopupUpload = True
model.variables.l_ShowPopupUploadVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

deleteOnClick$Action(invoiceFileIDIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DeleteOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DeleteOnClick");
span.setAttribute("outsystems.function.key", "289b097b-a708-4e0b-b206-47da65abb283");
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

wb_CustomFileUploadOnDropFile$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDropFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDropFile");
span.setAttribute("outsystems.function.key", "48c23ee6-6082-4ef8-adf6-ec7271ccefd8");
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

wb_CustomFileUploadOnDelete$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomFileUploadOnDelete__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomFileUploadOnDelete");
span.setAttribute("outsystems.function.key", "4da030b8-a6c8-41bb-b369-13c753265fe1");
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

wb_DownloadAllFolioFilesByFileListStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListStart");
span.setAttribute("outsystems.function.key", "54184996-3d33-4755-b2a3-b04ee5c2bdf6");
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

cancelOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelOnClick");
span.setAttribute("outsystems.function.key", "6ed34128-7a28-4b76-875d-d5f5807ab45f");
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

wb_DownloadFileStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "9d6b464a-1ab5-4fcd-94c7-ab98044b756a");
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

wb_DownloadFileEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadFileEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileEnd");
span.setAttribute("outsystems.function.key", "b1b51d04-885f-49d3-8cc0-a1402108a227");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "c6d695e3-fc03-4c08-bf4f-f1101addbe68");
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

wb_DownloadAllFolioFilesByFileListEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_DownloadAllFolioFilesByFileListEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadAllFolioFilesByFileListEnd");
span.setAttribute("outsystems.function.key", "d0112456-da83-4739-817f-065ca4c0069b");
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

linkOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LinkOnClick");
span.setAttribute("outsystems.function.key", "fad17382-7503-45f3-9fce-fb7fa88916cd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._linkOnClick$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.DeleteOnClick$vars", [{
name: "InvoiceFileID",
attrName: "invoiceFileIDInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.Wb_CustomFileUploadOnDropFile$vars", [{
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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


