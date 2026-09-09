import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_6dc39d329f4b959722daa75bc2f62c1fStructure, ST_118fe20454dd0bf1f0e6d925e7d7544bStructure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.mvc$translationsResources.js";
import ConectaProveedores_j_FoliosSAEController$default from "./ConectaProveedores.j_FoliosSAE.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSupplierName$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getSupplierName$DataActRefresh: []
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/j_FoliosSAE/NewMassiveFolioSAE/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
folioMassCreate$ServerAction(folioQListIn, filesListIn, orderAccConceptIDIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioMassCreate", function (span) {
if(span) {
span.setAttribute("code.function", "FolioMassCreate");
span.setAttribute("outsystems.function.key", "5d000fd4-bb11-4301-82d2-6d30937240e7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
FolioQList: OS$DataConversion.ServerDataConverter.to(folioQListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
FilesList: OS$DataConversion.ServerDataConverter.to(filesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
OrderAccConceptID: OS$DataConversion.ServerDataConverter.to(orderAccConceptIDIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioMassCreate", "screenservices/ConectaProveedores/j_FoliosSAE/NewMassiveFolioSAE/ActionFolioMassCreate", "9UZJj9OlptFnrPFljMxvgQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE$ActionFolioMassCreate"))();
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
folioQMassUpload$ServerAction(filesListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioQMassUpload", function (span) {
if(span) {
span.setAttribute("code.function", "FolioQMassUpload");
span.setAttribute("outsystems.function.key", "4a3abb9c-b012-4c99-8ff2-ea86db3f42ec");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
FilesList: OS$DataConversion.ServerDataConverter.to(filesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioQMassUpload", "screenservices/ConectaProveedores/j_FoliosSAE/NewMassiveFolioSAE/ActionFolioQMassUpload", "6QL8fT57pPcuUYumB9f+lg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE$ActionFolioQMassUpload"))();
executeServerActionResult.folioQListOut = OS$DataConversion.ServerDataConverter.from(outputs.FolioQList, (OS$GenericTypeCache.getGenericList(ST_118fe20454dd0bf1f0e6d925e7d7544bStructure)));
executeServerActionResult.numberOfRecordsOut = OS$DataConversion.ServerDataConverter.from(outputs.NumberOfRecords, OS$DataTypes.DataTypes.Integer);
executeServerActionResult.numberOfErrosOut = OS$DataConversion.ServerDataConverter.from(outputs.NumberOfErros, OS$DataTypes.DataTypes.Integer);
executeServerActionResult.orderNumberOut = OS$DataConversion.ServerDataConverter.from(outputs.OrderNumber, OS$DataTypes.DataTypes.LongInteger);
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
dowloadExcelTemplateFolioQ$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DowloadExcelTemplateFolioQ", function (span) {
if(span) {
span.setAttribute("code.function", "DowloadExcelTemplateFolioQ");
span.setAttribute("outsystems.function.key", "dfad02f9-1ee2-4ac3-8d54-54406d0fb77f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("DowloadExcelTemplateFolioQ", "screenservices/ConectaProveedores/j_FoliosSAE/NewMassiveFolioSAE/ActionDowloadExcelTemplateFolioQ", "TUnll4bAhaf_SIU88w9Ddw", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE$ActionDowloadExcelTemplateFolioQ"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, OS$DataTypes.DataTypes.BinaryData);
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
get getSupplierName$DataActRefresh() {if(!(this.hasOwnProperty("_getSupplierName$DataActRefresh"))) {
this._getSupplierName$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSupplierName", "screenservices/ConectaProveedores/j_FoliosSAE/NewMassiveFolioSAE/DataActionGetSupplierName", "LF7GgcFJOqCWLV1LroExSg", function (b) {
model.variables.getSupplierNameDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierNameDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierNameDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierName", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierName");
span.setAttribute("outsystems.function.key", "fe37cf69-b048-4461-b296-4fce37420027");
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

return this._getSupplierName$DataActRefresh;
}set getSupplierName$DataActRefresh(value) {this._getSupplierName$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSupplierName$DataActRefresh"];
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
span.setAttribute("outsystems.function.key", "21f67aa2-fe50-4a33-9303-5564dc461a22");
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
rec.screenAttr = "New Massive Folio SAE";
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
_customUploadOnFileChange$Action(file2In, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "4de1a54d-249c-4b18-bae4-d23bff759637");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.CustomUploadOnFileChange$vars"))());
vars.value.file2InLocal = file2In.clone();
vars.value.errorInLocal = errorIn.clone();
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// ok?
if((vars.value.errorInLocal.successAttr)) {
// exists?
if((!(OS$DataTypes.areBinaryNulls(vars.value.file2InLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.file2InLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
}), callContext);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("K+N+lxnXzEK5fzEmSuHo8Q#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_importOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ImportOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ImportOnClick");
span.setAttribute("outsystems.function.key", "5194195d-4d56-4984-b066-0a45c59f267d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ImportOnClick");
callContext = controller.callContext(callContext);
var folioMassCreateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FolioMassCreate
model.flush();
return controller.folioMassCreate$ServerAction(model.variables.folioQListVar, model.variables.filesListVar, model.variables.l_FolioAccDataVar.orderAccConceptIDAttr, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
folioMassCreateVar.value = value;
}).then(function () {
// WithoutError
if(((folioMassCreateVar.value.errorMsgOut === ""))) {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BUe_SX_YZUippofjsnmv1w#Message.-112311028.1", "Folios created successfully!"), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Proveedor
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Proveedor", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(folioMassCreateVar.value.errorMsgOut, /*Error*/ 3);
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
_removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "5983116f-1d77-4812-a89e-cfdffe85080e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.RemoveOnClick$vars"))());
vars.value.l_CurrentRowNumberInLocal = l_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.folioQListVar, vars.value.l_CurrentRowNumberInLocal, callContext);
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.folioQListVar, function (p) {
return p.withErrorAttr;
}, callContext);

// NumberOfRecords = 0
model.variables.numberOfRecordsVar = 0;
// Foreach FolioQList
callContext.iterationContext.registerIterationStart(model.variables.folioQListVar);
try {var folioQListIterator = callContext.iterationContext.getIterator(model.variables.folioQListVar);
var folioQListIndex = 0;
while (((folioQListIndex < model.variables.folioQListVar.length))) {
folioQListIterator.currentRowNumber = folioQListIndex;
// NumberOfRecords = NumberOfRecords + FolioQList.Current.FolioQFilesList.Length
model.variables.numberOfRecordsVar = (model.variables.numberOfRecordsVar + model.variables.folioQListVar.getItem(folioQListIndex.valueOf()).folioQFilesListAttr.length);
folioQListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.folioQListVar);
}

// NumberWithErrors = ListFilter.FilteredList.Length
model.variables.numberWithErrorsVar = listFilterVar.value.filteredListOut.length;
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
span.setAttribute("outsystems.function.key", "5aaafbb2-8e27-4922-bd72-c23d9fdfd67d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenPopup");
callContext = controller.callContext(callContext);
// HelpPopup = True
model.variables.helpPopupVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_uploadNewFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UploadNewFile", function (span) {
if(span) {
span.setAttribute("code.function", "UploadNewFile");
span.setAttribute("outsystems.function.key", "75145d93-149d-49f9-ad55-3a47330b2b58");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("UploadNewFile");
callContext = controller.callContext(callContext);
var folioQMassUploadVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: FolioQMassUpload
model.flush();
return controller.folioQMassUpload$ServerAction(model.variables.filesListVar, callContext).then(function (value) {
folioQMassUploadVar.value = value;
}).then(function () {
// error
if((((folioQMassUploadVar.value.errorMsgOut) !== ("")))) {
OS$FeedbackMessageService.showFeedbackMessage(folioQMassUploadVar.value.errorMsgOut, /*Error*/ 3);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// FolioQList = FolioQMassUpload.FolioQList
model.variables.folioQListVar = folioQMassUploadVar.value.folioQListOut;
// NumberOfRecords = FolioQMassUpload.NumberOfRecords
model.variables.numberOfRecordsVar = folioQMassUploadVar.value.numberOfRecordsOut;
// NumberWithErrors = FolioQMassUpload.NumberOfErros
model.variables.numberWithErrorsVar = folioQMassUploadVar.value.numberOfErrosOut;
// l_OrderMainID = FolioQMassUpload.OrderNumber
model.variables.l_OrderMainIDVar = folioQMassUploadVar.value.orderNumberOut;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
_removeFromList$Action(indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "971b6e61-d993-4d6e-8460-a6ba487734ba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_clearOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ClearOnClick");
span.setAttribute("outsystems.function.key", "a1d58706-f65d-484a-b998-3db88a48cff8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearOnClick");
callContext = controller.callContext(callContext);
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Destination: /ConectaProveedores/NewMassiveFolioSAE
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "NewMassiveFolioSAE", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_downloadTemplateOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadTemplateOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadTemplateOnClick");
span.setAttribute("outsystems.function.key", "ba39d244-7217-4f5e-8445-3c2054876928");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadTemplateOnClick");
callContext = controller.callContext(callContext);
var dowloadExcelTemplateFolioQVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: DowloadExcelTemplateFolioQ
model.flush();
return controller.dowloadExcelTemplateFolioQ$ServerAction(callContext).then(function (value) {
dowloadExcelTemplateFolioQVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(dowloadExcelTemplateFolioQVar.value.o_FileOut, "CargaMassivaImputacionQ.xlsx"));
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
span.setAttribute("outsystems.function.key", "da7e6211-5d6b-460f-bec5-d5a20fe88fb1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClosePopup");
callContext = controller.callContext(callContext);
// HelpPopup = False
model.variables.helpPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_AccSelectSendOrderAccConcept$Action(oFolioAccDataIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_AccSelectSendOrderAccConcept", function (span) {
if(span) {
span.setAttribute("code.function", "wb_AccSelectSendOrderAccConcept");
span.setAttribute("outsystems.function.key", "fb0a800f-e5b6-4deb-8fd8-83023de4ddcb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_AccSelectSendOrderAccConcept");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.wb_AccSelectSendOrderAccConcept$vars"))());
vars.value.oFolioAccDataInLocal = oFolioAccDataIn.clone();
// l_FolioAccData = oFolioAccData
model.variables.l_FolioAccDataVar = vars.value.oFolioAccDataInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "21f67aa2-fe50-4a33-9303-5564dc461a22");
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

customUploadOnFileChange$Action(file2In, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "4de1a54d-249c-4b18-bae4-d23bff759637");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._customUploadOnFileChange$Action, callContext, file2In, errorIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

importOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ImportOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ImportOnClick");
span.setAttribute("outsystems.function.key", "5194195d-4d56-4984-b066-0a45c59f267d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._importOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "5983116f-1d77-4812-a89e-cfdffe85080e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeOnClick$Action, callContext, l_CurrentRowNumberIn);
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
span.setAttribute("outsystems.function.key", "5aaafbb2-8e27-4922-bd72-c23d9fdfd67d");
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

uploadNewFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadNewFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UploadNewFile");
span.setAttribute("outsystems.function.key", "75145d93-149d-49f9-ad55-3a47330b2b58");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._uploadNewFile$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

removeFromList$Action(indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "971b6e61-d993-4d6e-8460-a6ba487734ba");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, indexIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearOnClick");
span.setAttribute("outsystems.function.key", "a1d58706-f65d-484a-b998-3db88a48cff8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._clearOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

downloadTemplateOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadTemplateOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadTemplateOnClick");
span.setAttribute("outsystems.function.key", "ba39d244-7217-4f5e-8445-3c2054876928");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadTemplateOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "da7e6211-5d6b-460f-bec5-d5a20fe88fb1");
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

wb_AccSelectSendOrderAccConcept$Action(oFolioAccDataIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_AccSelectSendOrderAccConcept__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_AccSelectSendOrderAccConcept");
span.setAttribute("outsystems.function.key", "fb0a800f-e5b6-4deb-8fd8-83023de4ddcb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_AccSelectSendOrderAccConcept$Action, callContext, oFolioAccDataIn);
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
return ConectaProveedores_j_FoliosSAEController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Proveedor, ConectaProveedoresController$default.roles.Folios]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE$ActionFolioMassCreate", [{
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE$ActionFolioQMassUpload", [{
name: "FolioQList",
attrName: "folioQListOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_118fe20454dd0bf1f0e6d925e7d7544bStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_118fe20454dd0bf1f0e6d925e7d7544bStructure))
}, {
name: "NumberOfRecords",
attrName: "numberOfRecordsOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "NumberOfErros",
attrName: "numberOfErrosOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "OrderNumber",
attrName: "orderNumberOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE$ActionDowloadExcelTemplateFolioQ", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.CustomUploadOnFileChange$vars", [{
name: "File2",
attrName: "file2InLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}, {
name: "Error",
attrName: "errorInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
},
complexType: ST_f9f8b40f5330871047e55e068d129447Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.RemoveOnClick$vars", [{
name: "l_CurrentRowNumber",
attrName: "l_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.wb_AccSelectSendOrderAccConcept$vars", [{
name: "oFolioAccData",
attrName: "oFolioAccDataInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6dc39d329f4b959722daa75bc2f62c1fStructure();
},
complexType: ST_6dc39d329f4b959722daa75bc2f62c1fStructure
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


