import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { hideLoading$Action as ConectaProveedoresController$hideLoading$Action, showLoading$Action as ConectaProveedoresController$showLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByFile_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.wb_documentExtrationByFile.mvc$translationsResources.js";
import { ST_37a6487c1fae199ee92f583d495139beStructure } from "./ConectaProveedores.model.js";
import { ST_b1b6df219277397c7c2be747d587880aStructure } from "./Organization.model.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_wb_documentExtrationByFile_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
findBySupplier$ServerAction(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FindBySupplier", function (span) {
if(span) {
span.setAttribute("code.function", "FindBySupplier");
span.setAttribute("outsystems.function.key", "b6b3e4dd-b0d6-4120-bcbe-a71030152894");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
file: OS$DataConversion.ServerDataConverter.to(fileIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FindBySupplier", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ActionFindBySupplier", "wLf5C86IyLvlN4paF8qkdQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindBySupplier"))();
executeServerActionResult.listOut = OS$DataConversion.ServerDataConverter.from(outputs.List, (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure)));
executeServerActionResult.returnOut = OS$DataConversion.ServerDataConverter.from(outputs.return, ST_b1b6df219277397c7c2be747d587880aStructure);
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
findByAccount$ServerAction(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FindByAccount", function (span) {
if(span) {
span.setAttribute("code.function", "FindByAccount");
span.setAttribute("outsystems.function.key", "b5de618a-6fe0-49de-b6f8-3d359380200b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
file: OS$DataConversion.ServerDataConverter.to(fileIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FindByAccount", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ActionFindByAccount", "7U8Powbyk+8PkcWxr3ez2Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByAccount"))();
executeServerActionResult.listOut = OS$DataConversion.ServerDataConverter.from(outputs.List, (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure)));
executeServerActionResult.returnOut = OS$DataConversion.ServerDataConverter.from(outputs.return, ST_b1b6df219277397c7c2be747d587880aStructure);
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
findByPeriod$ServerAction(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FindByPeriod", function (span) {
if(span) {
span.setAttribute("code.function", "FindByPeriod");
span.setAttribute("outsystems.function.key", "bc4822b8-a04d-4647-8307-4725f1bd4b18");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
file: OS$DataConversion.ServerDataConverter.to(fileIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FindByPeriod", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ActionFindByPeriod", "VVFcyfSrkN2dTNXtshQnRw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByPeriod"))();
executeServerActionResult.listOut = OS$DataConversion.ServerDataConverter.from(outputs.List, (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure)));
executeServerActionResult.returnOut = OS$DataConversion.ServerDataConverter.from(outputs.return, ST_b1b6df219277397c7c2be747d587880aStructure);
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
findByUUID$ServerAction(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FindByUUID", function (span) {
if(span) {
span.setAttribute("code.function", "FindByUUID");
span.setAttribute("outsystems.function.key", "57467372-6158-43bd-b5a5-a31770843206");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
file: OS$DataConversion.ServerDataConverter.to(fileIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FindByUUID", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ActionFindByUUID", "T4d_eazlsKJX44gnqpagnA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByUUID"))();
executeServerActionResult.listOut = OS$DataConversion.ServerDataConverter.from(outputs.List, (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure)));
executeServerActionResult.returnOut = OS$DataConversion.ServerDataConverter.from(outputs.return, ST_b1b6df219277397c7c2be747d587880aStructure);
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
findByDateRanges$ServerAction(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FindByDateRanges", function (span) {
if(span) {
span.setAttribute("code.function", "FindByDateRanges");
span.setAttribute("outsystems.function.key", "05f8e76d-b665-4e96-9f0e-149cbabf457c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
file: OS$DataConversion.ServerDataConverter.to(fileIn, {
dataType: OS$DataTypes.DataTypes.BinaryData,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FindByDateRanges", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ActionFindByDateRanges", "zvqu7ScuqJhNORyIIVqVdQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByDateRanges"))();
executeServerActionResult.listOut = OS$DataConversion.ServerDataConverter.from(outputs.List, (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure)));
executeServerActionResult.returnOut = OS$DataConversion.ServerDataConverter.from(outputs.return, ST_b1b6df219277397c7c2be747d587880aStructure);
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
serviceGetDocumentsByListId$ServerAction(idsListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceGetDocumentsByListId", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceGetDocumentsByListId");
span.setAttribute("outsystems.function.key", "7d88e5e5-c804-41f0-a1a7-0fb27a70e1ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
IdsList: OS$DataConversion.ServerDataConverter.to(idsListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceGetDocumentsByListId", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ServiceAPIServiceGetDocumentsByListId", "B_km2SQBw90cnqn+1+_34g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ServiceAPIServiceGetDocumentsByListId"))();
executeServerActionResult.binaryZipOut = OS$DataConversion.ServerDataConverter.from(outputs.BinaryZip, OS$DataTypes.DataTypes.BinaryData);
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
downloadDocument$ServerAction(i_TypeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadDocument", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadDocument");
span.setAttribute("outsystems.function.key", "03e055e9-e1e9-40b5-83ac-0cc485ac7c0e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Type: OS$DataConversion.ServerDataConverter.to(i_TypeIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("DownloadDocument", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByFile/ActionDownloadDocument", "ODSQMjQA_euNhJ6jbgFiJg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionDownloadDocument"))();
executeServerActionResult.o_fileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_file, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.o_filenameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_filename, OS$DataTypes.DataTypes.Text);
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

get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = [];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_findOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("FindOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "FindOnClick");
span.setAttribute("outsystems.function.key", "03f9840f-6905-4a42-b20f-0d9a8839bcbe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("FindOnClick");
callContext = controller.callContext(callContext);
var findBySupplierVar = new OS$DataTypes.VariableHolder();
var findByAccountVar = new OS$DataTypes.VariableHolder();
var findByPeriodVar = new OS$DataTypes.VariableHolder();
var findByUUIDVar = new OS$DataTypes.VariableHolder();
var findBydateRangesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((!(OS$DataTypes.areBinaryNulls(model.variables.binaryDataVarVar, OS$BuiltinFunctions.nullBinary())))) {
// IsSelectOne = False
model.variables.isSelectOneVar = false;
return OS$Flow.executeSequence(function () {
if(((model.variables.selectionVar === "1"))) {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FindBySupplier
model.flush();
return controller.findBySupplier$ServerAction(model.variables.binaryDataVarVar, callContext).then(function (value) {
findBySupplierVar.value = value;
}).then(function () {
if((findBySupplierVar.value.returnOut.isSuccessAttr)) {
// OutputList = FindBySupplier.List
model.variables.outputListVar = findBySupplierVar.value.listOut;
// Return = FindBySupplier.return
model.variables.returnVar = findBySupplierVar.value.returnOut;
} else {
OS$FeedbackMessageService.showFeedbackMessage(findBySupplierVar.value.returnOut.messageAttr, /*Error*/ 3);
}

// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
return OS$Flow.executeSequence(function () {
if((model.variables.selectionVar === "2")) {
// Execute Action: ShowLoading2
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FindByUUID
model.flush();
return controller.findByUUID$ServerAction(model.variables.binaryDataVarVar, callContext).then(function (value) {
findByUUIDVar.value = value;
}).then(function () {
if((findByUUIDVar.value.returnOut.isSuccessAttr)) {
// OutputList = FindByUUID.List
model.variables.outputListVar = findByUUIDVar.value.listOut;
// Return = FindByUUID.return
model.variables.returnVar = findByUUIDVar.value.returnOut;
} else {
OS$FeedbackMessageService.showFeedbackMessage(findByUUIDVar.value.returnOut.messageAttr, /*Error*/ 3);
}

// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
return OS$Flow.executeSequence(function () {
if((model.variables.selectionVar === "3")) {
// Execute Action: ShowLoading3
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FindBydateRanges
model.flush();
return controller.findByDateRanges$ServerAction(model.variables.binaryDataVarVar, callContext).then(function (value) {
findBydateRangesVar.value = value;
}).then(function () {
if((findBydateRangesVar.value.returnOut.isSuccessAttr)) {
// OutputList = FindBydateRanges.List
model.variables.outputListVar = findBydateRangesVar.value.listOut;
// Return = FindBydateRanges.return
model.variables.returnVar = findBydateRangesVar.value.returnOut;
} else {
OS$FeedbackMessageService.showFeedbackMessage(findBydateRangesVar.value.returnOut.messageAttr, /*Error*/ 3);
}

// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
return OS$Flow.executeSequence(function () {
if((model.variables.selectionVar === "4")) {
// Execute Action: ShowLoading4
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FindByPeriod
model.flush();
return controller.findByPeriod$ServerAction(model.variables.binaryDataVarVar, callContext).then(function (value) {
findByPeriodVar.value = value;
}).then(function () {
if((findByPeriodVar.value.returnOut.isSuccessAttr)) {
// OutputList = FindByPeriod.List
model.variables.outputListVar = findByPeriodVar.value.listOut;
// Return = FindByPeriod.return
model.variables.returnVar = findByPeriodVar.value.returnOut;
} else {
OS$FeedbackMessageService.showFeedbackMessage(findByPeriodVar.value.returnOut.messageAttr, /*Error*/ 3);
}

// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
return OS$Flow.executeSequence(function () {
if((model.variables.selectionVar === "5")) {
// Execute Action: ShowLoading5
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FindByAccount
model.flush();
return controller.findByAccount$ServerAction(model.variables.binaryDataVarVar, callContext).then(function (value) {
findByAccountVar.value = value;
}).then(function () {
if((findByAccountVar.value.returnOut.isSuccessAttr)) {
// OutputList = FindByAccount.List
model.variables.outputListVar = findByAccountVar.value.listOut;
// Return = FindByAccount.return
model.variables.returnVar = findByAccountVar.value.returnOut;
} else {
OS$FeedbackMessageService.showFeedbackMessage(findByAccountVar.value.returnOut.messageAttr, /*Error*/ 3);
}

// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
});
}

});
}

});
}

});
}

});
}

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
span.setAttribute("outsystems.function.key", "0fe45752-adfb-45ac-b4f6-7303209b85d1");
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
_selectFile$Action(i_StorageIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectFile", function (span) {
if(span) {
span.setAttribute("code.function", "SelectFile");
span.setAttribute("outsystems.function.key", "2c776003-31b7-4386-9dd5-aaa98c165a11");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile.SelectFile$vars"))());
vars.value.i_StorageIdInLocal = i_StorageIdIn;
// StorageId = i_StorageId
model.variables.storageIdVar = vars.value.i_StorageIdInLocal;
// ForceRefresh = CurrDateTime
model.variables.forceRefreshVar = OS$BuiltinFunctions.currDateTime();
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenPopup", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopup");
span.setAttribute("outsystems.function.key", "3f9caf73-b838-4d6c-b316-7c7a78454f81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenPopup");
callContext = controller.callContext(callContext);
// ShowdownloadPopup = True
model.variables.showdownloadPopupVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_downloadAll$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadAll", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAll");
span.setAttribute("outsystems.function.key", "8acc7da1-a4d4-4212-bfd5-a9ff885100df");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadAll");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var serviceGetDocumentsByListIdVar = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.outputListVar, function (p) {
return p.selectAttr;
}, callContext);

// Execute Action: ServiceGetDocumentsByListId
model.flush();
return controller.serviceGetDocumentsByListId$ServerAction(OS$DataConversion.JSConversions.typeConvertRecordList(listFilterVar.value.filteredListOut, new OS$DataTypes.LongIntegerList(), function (source, target) {
target = source.storageIdAttr;
return target;
}), callContext).then(function (value) {
serviceGetDocumentsByListIdVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(serviceGetDocumentsByListIdVar.value.binaryZipOut, "Documents.zip"));
});
}).catch(function (ex) {
OS$Logger.debug("wb_documentExtrationByFile.DownloadAll", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "f678899f-cbeb-4208-bf7b-be31f3b1b42f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
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
_downloadTemplates$Action(typeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadTemplates", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadTemplates");
span.setAttribute("outsystems.function.key", "8c2ac558-a703-4b98-86e1-c40431ccbbd6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadTemplates");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile.DownloadTemplates$vars"))());
vars.value.typeInLocal = typeIn;
var downloadDocumentVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: DownloadDocument
model.flush();
return controller.downloadDocument$ServerAction(vars.value.typeInLocal, callContext).then(function (value) {
downloadDocumentVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(downloadDocumentVar.value.o_fileOut, downloadDocumentVar.value.o_filenameOut));
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
_closePopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClosePopup", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePopup");
span.setAttribute("outsystems.function.key", "b14906d5-deed-4c6c-b2fd-4d6e235736ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClosePopup");
callContext = controller.callContext(callContext);
// ShowdownloadPopup = False
model.variables.showdownloadPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_selectLines$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectLines", function (span) {
if(span) {
span.setAttribute("code.function", "SelectLines");
span.setAttribute("outsystems.function.key", "c6be1b35-0982-453b-83ed-4847f0ad2def");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectLines");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.outputListVar, function (p) {
return p.selectAttr;
}, callContext);

// IsSelectOne = notListFilter.FilteredList.Empty
model.variables.isSelectOneVar = (!(listFilterVar.value.filteredListOut.isEmpty));
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
span.setAttribute("outsystems.function.key", "f531a92e-07ed-422a-bc45-5ede5b4a6040");
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

findOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FindOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "FindOnClick");
span.setAttribute("outsystems.function.key", "03f9840f-6905-4a42-b20f-0d9a8839bcbe");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._findOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "0fe45752-adfb-45ac-b4f6-7303209b85d1");
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

selectFile$Action(i_StorageIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectFile");
span.setAttribute("outsystems.function.key", "2c776003-31b7-4386-9dd5-aaa98c165a11");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._selectFile$Action, callContext, i_StorageIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopup");
span.setAttribute("outsystems.function.key", "3f9caf73-b838-4d6c-b316-7c7a78454f81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

downloadAll$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadAll__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAll");
span.setAttribute("outsystems.function.key", "8acc7da1-a4d4-4212-bfd5-a9ff885100df");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadAll$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

downloadTemplates$Action(typeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadTemplates__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadTemplates");
span.setAttribute("outsystems.function.key", "8c2ac558-a703-4b98-86e1-c40431ccbbd6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadTemplates$Action, callContext, typeIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

closePopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClosePopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClosePopup");
span.setAttribute("outsystems.function.key", "b14906d5-deed-4c6c-b2fd-4d6e235736ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closePopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

selectLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectLines");
span.setAttribute("outsystems.function.key", "c6be1b35-0982-453b-83ed-4847f0ad2def");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._selectLines$Action, callContext);
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
span.setAttribute("outsystems.function.key", "f531a92e-07ed-422a-bc45-5ede5b4a6040");
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
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindBySupplier", [{
name: "List",
attrName: "listOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))
}, {
name: "return",
attrName: "returnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByAccount", [{
name: "List",
attrName: "listOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))
}, {
name: "return",
attrName: "returnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByPeriod", [{
name: "List",
attrName: "listOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))
}, {
name: "return",
attrName: "returnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByUUID", [{
name: "List",
attrName: "listOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))
}, {
name: "return",
attrName: "returnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionFindByDateRanges", [{
name: "List",
attrName: "listOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))
}, {
name: "return",
attrName: "returnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ServiceAPIServiceGetDocumentsByListId", [{
name: "BinaryZip",
attrName: "binaryZipOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile$ActionDownloadDocument", [{
name: "o_file",
attrName: "o_fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "o_filename",
attrName: "o_filenameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile.SelectFile$vars", [{
name: "i_StorageId",
attrName: "i_StorageIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByFile.DownloadTemplates$vars", [{
name: "Type",
attrName: "typeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


