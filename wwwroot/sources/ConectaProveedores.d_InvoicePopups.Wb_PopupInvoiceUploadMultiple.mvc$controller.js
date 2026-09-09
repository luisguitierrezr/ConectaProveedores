import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_5478c3bb197e3019856d4a634c17d91dStructure } from "./ConectaProveedores.model.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_mvc_TranslationsResources from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoicesByRequisitionOrFolio$DataActRefresh: 0,
getSupplier$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoicesByRequisitionOrFolio$DataActRefresh: [],
getSupplier$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
validateZIPInvoices$ServerAction(i_FileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateZIPInvoices", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateZIPInvoices");
span.setAttribute("outsystems.function.key", "f42db43b-4785-4a2a-83be-436d039a08bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_File: OS$DataConversion.ServerDataConverter.to(i_FileIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ValidateZIPInvoices", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadMultiple/ActionValidateZIPInvoices", "H_Veye90wmWbWmS8rwLNrw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple$ActionValidateZIPInvoices"))();
executeServerActionResult.multiUploadInvoiceFileStructOut = OS$DataConversion.ServerDataConverter.from(outputs.MultiUploadInvoiceFileStruct, ST_5478c3bb197e3019856d4a634c17d91dStructure);
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
uploadInvoiceFilesMultiple$ServerAction(invoiceIdIn, requisitionIdIn, orderMainIdIn, folioIdIn, multiUploadInvoiceFileStructListIn, isStartApprovalIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UploadInvoiceFilesMultiple", function (span) {
if(span) {
span.setAttribute("code.function", "UploadInvoiceFilesMultiple");
span.setAttribute("outsystems.function.key", "467437e1-f00f-4935-a538-f49797781f09");
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
}),
RequisitionId: OS$DataConversion.ServerDataConverter.to(requisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OrderMainId: OS$DataConversion.ServerDataConverter.to(orderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
FolioId: OS$DataConversion.ServerDataConverter.to(folioIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
MultiUploadInvoiceFileStructList: OS$DataConversion.ServerDataConverter.to(multiUploadInvoiceFileStructListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
IsStartApproval: OS$DataConversion.ServerDataConverter.to(isStartApprovalIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("UploadInvoiceFilesMultiple", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadMultiple/ActionUploadInvoiceFilesMultiple", "+dvOmjQ2E0nvA84QUnSsRQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple$ActionUploadInvoiceFilesMultiple"))();
executeServerActionResult.error_MultiUploadInvoiceFileStructListOut = OS$DataConversion.ServerDataConverter.from(outputs.Error_MultiUploadInvoiceFileStructList, (OS$GenericTypeCache.getGenericList(ST_5478c3bb197e3019856d4a634c17d91dStructure)));
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
get getInvoicesByRequisitionOrFolio$DataActRefresh() {if(!(this.hasOwnProperty("_getInvoicesByRequisitionOrFolio$DataActRefresh"))) {
this._getInvoicesByRequisitionOrFolio$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetInvoicesByRequisitionOrFolio", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadMultiple/DataActionGetInvoicesByRequisitionOrFolio", "+5mzVrZaW0x1hOwVdK+6iQ", function (b) {
model.variables.getInvoicesByRequisitionOrFolioDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoicesByRequisitionOrFolioDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoicesByRequisitionOrFolioDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoicesByRequisitionOrFolio", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoicesByRequisitionOrFolio");
span.setAttribute("outsystems.function.key", "7807cac5-6b08-4736-82e7-b56b89d1a94a");
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

return this._getInvoicesByRequisitionOrFolio$DataActRefresh;
}set getInvoicesByRequisitionOrFolio$DataActRefresh(value) {this._getInvoicesByRequisitionOrFolio$DataActRefresh = value;
}

get getSupplier$DataActRefresh() {if(!(this.hasOwnProperty("_getSupplier$DataActRefresh"))) {
this._getSupplier$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSupplier", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceUploadMultiple/DataActionGetSupplier", "1iS_e72X9zgr0D2tjUCYKQ", function (b) {
model.variables.getSupplierDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplier", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplier");
span.setAttribute("outsystems.function.key", "e9151e12-d393-4747-bed5-3dc26ceac766");
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

return this._getSupplier$DataActRefresh;
}set getSupplier$DataActRefresh(value) {this._getSupplier$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoicesByRequisitionOrFolio$DataActRefresh", "getSupplier$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_removeFromList$Action(indexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "017b2d7d-85e4-4b39-95fe-36c8c17c641a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
// HasChanged = True
model.variables.hasChangedVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "7d754101-20c5-43f5-9025-6b989b367fc6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
var validateZIPInvoicesVar = new OS$DataTypes.VariableHolder();
var listFilter2Var = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// ErrorMsg = ""
model.variables.errorMsgVar = "";
// Execute Action: ValidateZIPInvoices
model.flush();
return controller.validateZIPInvoices$ServerAction(vars.value.fileInLocal, callContext).then(function (value) {
validateZIPInvoicesVar.value = value;
}).then(function () {
// Execute Action: ListFilter2
listFilter2Var.value = OS$SystemActions.listFilter(model.variables.filesListVar, function (p) {
return (OS$BuiltinFunctions.substr(p.nameAttr, 0, OS$BuiltinFunctions.index(p.nameAttr, ".", 0, false, false)) === OS$BuiltinFunctions.substr(validateZIPInvoicesVar.value.multiUploadInvoiceFileStructOut.nameAttr, 0, OS$BuiltinFunctions.index(validateZIPInvoicesVar.value.multiUploadInvoiceFileStructOut.nameAttr, ".", 0, false, false)));
}, callContext);

}).then(function () {
// exists in this upload?
if(((!(listFilter2Var.value.filteredListOut.isEmpty)))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gbJge2eUnkys571V88V38w#Message.1572004662.1", "Duplicated files were not included."), /*Warning*/ 2);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoicesByRequisitionOrFolioDataAct.invoicesListOut, function (p) {
return (p.invoiceAttr.nameAttr === OS$BuiltinFunctions.substr(validateZIPInvoicesVar.value.multiUploadInvoiceFileStructOut.nameAttr, 0, OS$BuiltinFunctions.index(validateZIPInvoicesVar.value.multiUploadInvoiceFileStructOut.nameAttr, ".", 0, false, false)));
}, callContext);

// exists in req?
if(((!(listFilterVar.value.filteredListOut.isEmpty)))) {
// error
// ValidateZIPInvoices.MultiUploadInvoiceFileStruct.ErrorMsg = "Duplicated invoice "
validateZIPInvoicesVar.value.multiUploadInvoiceFileStructOut.errorMsgAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fkt1HpsCGkKwQl8VXFDebw#Value.-719604230.1", "Duplicated invoice ");
}

// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.filesListVar, validateZIPInvoicesVar.value.multiUploadInvoiceFileStructOut, callContext);
// HasChanged = True
model.variables.hasChangedVar = true;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bkqG5cf3AUSKf1t32wjS6w#Message.875725967.1", "Empty file"), /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
// Execute Action: HideLoading4
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "b623873a-1d2a-4d61-a168-17971b352d16");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_saveOnClick$Action(isStartApprovalIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "f311db5c-06df-471e-b6de-3f966cb58137");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.SaveOnClick$vars"))());
vars.value.isStartApprovalInLocal = isStartApprovalIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var uploadInvoiceFilesMultipleVar = new OS$DataTypes.VariableHolder();
var listFilterErrorFilesVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// IsExecuting = IsStartApproval
model.variables.isExecutingVar = vars.value.isStartApprovalInLocal;
// IsSaving = notIsStartApproval
model.variables.isSavingVar = (!(vars.value.isStartApprovalInLocal));
// no change
return OS$Flow.executeSequence(function () {
if((((!(model.variables.hasChangedVar)) && (!(vars.value.isStartApprovalInLocal))))) {
// Trigger Event: ClosePopup2
return controller.closePopup$Action(false, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
});
} else {
// empty
return OS$Flow.executeSequence(function () {
if((model.variables.filesListVar.isEmpty)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ghVJnCB5HEOkLcF+jiNLBQ#Message.-701348175.1", "Please insert a file to proceed."), /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading6
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: ListFilterErrorFiles
listFilterErrorFilesVar.value = OS$SystemActions.listFilter(model.variables.filesListVar, function (p) {
return ((p.errorMsgAttr) !== (""));
}, callContext);

// error on files
return OS$Flow.executeSequence(function () {
if(((!(listFilterErrorFilesVar.value.filteredListOut.isEmpty)))) {
// Foreach ListFilterErrorFiles.FilteredList
callContext.iterationContext.registerIterationStart(listFilterErrorFilesVar.value.filteredListOut);
try {var filteredListIterator = callContext.iterationContext.getIterator(listFilterErrorFilesVar.value.filteredListOut);
var filteredListIndex = 0;
while (((filteredListIndex < listFilterErrorFilesVar.value.filteredListOut.length))) {
filteredListIterator.currentRowNumber = filteredListIndex;
// ErrorList = ErrorList + If + ListFilterErrorFiles.FilteredList.Current.Name + " - " + ListFilterErrorFiles.FilteredList.Current.ErrorMsg
vars.value.errorListVar = ((((vars.value.errorListVar + (((listFilterErrorFilesVar.value.filteredListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? ("") : (" // "))) + listFilterErrorFilesVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).nameAttr) + " - ") + listFilterErrorFilesVar.value.filteredListOut.getItem(filteredListIndex.valueOf()).errorMsgAttr);
filteredListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(listFilterErrorFilesVar.value.filteredListOut);
}

OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorListVar, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: UploadInvoiceFilesMultiple
model.flush();
return controller.uploadInvoiceFilesMultiple$ServerAction(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), model.variables.requisitionIdIn, OS$DataTypes.LongInteger.defaultValue, model.variables.folioIdIn, model.variables.filesListVar, vars.value.isStartApprovalInLocal, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
uploadInvoiceFilesMultipleVar.value = value;
}).then(function () {
// error on validations
return OS$Flow.executeSequence(function () {
if(((!(uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut.isEmpty)))) {
// Foreach UploadInvoiceFilesMultiple.Error_MultiUploadInvoiceFileStructList
callContext.iterationContext.registerIterationStart(uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut);
try {var error_MultiUploadInvoiceFileStructListIterator = callContext.iterationContext.getIterator(uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut);
var error_MultiUploadInvoiceFileStructListIndex = 0;
while (((error_MultiUploadInvoiceFileStructListIndex < uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut.length))) {
error_MultiUploadInvoiceFileStructListIterator.currentRowNumber = error_MultiUploadInvoiceFileStructListIndex;
// ErrorList = ErrorList + If + UploadInvoiceFilesMultiple.Error_MultiUploadInvoiceFileStructList.Current.Name + " - " + UploadInvoiceFilesMultiple.Error_MultiUploadInvoiceFileStructList.Current.ErrorMsg
vars.value.errorListVar = ((((vars.value.errorListVar + (((uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut.getCurrentRowNumber(callContext.iterationContext) === 0)) ? ("") : (" // "))) + uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut.getItem(error_MultiUploadInvoiceFileStructListIndex.valueOf()).nameAttr) + " - ") + uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut.getItem(error_MultiUploadInvoiceFileStructListIndex.valueOf()).errorMsgAttr);
error_MultiUploadInvoiceFileStructListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(uploadInvoiceFilesMultipleVar.value.error_MultiUploadInvoiceFileStructListOut);
}

OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorListVar, /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.executeSequence(function () {
if((vars.value.isStartApprovalInLocal)) {
// Trigger Event: ClosePopup3
return controller.closePopup$Action(true, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
});
}

});
} else {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Success
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isStartApprovalInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Ilx_vYRogkGjpK7NcZ1b_A#Message.1934877117.1", "Approval process has began")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Ilx_vYRogkGjpK7NcZ1b_A#Message.-490039358.1", "Saved with success"))), /*Success*/ 1);
// Trigger Event: ClosePopup
return controller.closePopup$Action(true, callContext).then(function () {
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
});
}

});
});
}

});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_PopupInvoiceUploadMultiple.SaveOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "f7c36868-12f8-405a-8e88-d202f0f3c4a4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7xLCc+T73kKqcXacCLp4_Q#Message.-892909564.1", "Error while trying to upload invoice. Please try again later"), /*Error*/ 3);
// IsExecuting = False
model.variables.isExecutingVar = false;
// IsSaving = False
model.variables.isSavingVar = false;
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

removeFromList$Action(indexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "017b2d7d-85e4-4b39-95fe-36c8c17c641a");
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

customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "7d754101-20c5-43f5-9025-6b989b367fc6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._customUploadOnFileChange$Action, callContext, fileIn, errorIn);
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
span.setAttribute("outsystems.function.key", "b623873a-1d2a-4d61-a168-17971b352d16");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

saveOnClick$Action(isStartApprovalIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "f311db5c-06df-471e-b6de-3f966cb58137");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveOnClick$Action, callContext, isStartApprovalIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get closePopup$Action() {if(!(this.hasOwnProperty("_closePopup$Action"))) {
this._closePopup$Action = function () {
return Promise.resolve();
};
}

return this._closePopup$Action;
}set closePopup$Action(value) {this._closePopup$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple$ActionValidateZIPInvoices", [{
name: "MultiUploadInvoiceFileStruct",
attrName: "multiUploadInvoiceFileStructOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_5478c3bb197e3019856d4a634c17d91dStructure();
},
complexType: ST_5478c3bb197e3019856d4a634c17d91dStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple$ActionUploadInvoiceFilesMultiple", [{
name: "Error_MultiUploadInvoiceFileStructList",
attrName: "error_MultiUploadInvoiceFileStructListOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_5478c3bb197e3019856d4a634c17d91dStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_5478c3bb197e3019856d4a634c17d91dStructure))
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.CustomUploadOnFileChange$vars", [{
name: "File",
attrName: "fileInLocal",
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceUploadMultiple.SaveOnClick$vars", [{
name: "IsStartApproval",
attrName: "isStartApprovalInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "ErrorList",
attrName: "errorListVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


