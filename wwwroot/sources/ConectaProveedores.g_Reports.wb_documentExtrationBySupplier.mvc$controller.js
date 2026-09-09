import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceFiles$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceFiles$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("ServiceGetDocumentsByListId", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationBySupplier/ServiceAPIServiceGetDocumentsByListId", "B_km2SQBw90cnqn+1+_34g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier$ServiceAPIServiceGetDocumentsByListId"))();
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

// Aggregates and Data Actions
get getInvoiceFiles$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceFiles$AggrRefresh"))) {
this._getInvoiceFiles$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceFiles", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationBySupplier/ScreenDataSetGetInvoiceFiles", "L8qZamwm7RrsX3v5bQm8YA", maxRecords, startIndex, function (b) {
model.variables.getInvoiceFilesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFiles");
span.setAttribute("outsystems.function.key", "7c86d796-aa79-4852-bf65-56be96138890");
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

return this._getInvoiceFiles$AggrRefresh;
}set getInvoiceFiles$AggrRefresh(value) {this._getInvoiceFiles$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoiceFiles$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_downloadAll$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadAll", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAll");
span.setAttribute("outsystems.function.key", "12ba713e-44a6-485f-9469-ee9c645ba1b7");
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
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesAggr.listOut, function (p) {
return p.selectAttr;
}, callContext);

// Execute Action: ServiceGetDocumentsByListId
model.flush();
return controller.serviceGetDocumentsByListId$ServerAction(OS$DataConversion.JSConversions.typeConvertRecordList(listFilterVar.value.filteredListOut, new OS$DataTypes.LongIntegerList(), function (source, target) {
target = source.invoiceFileAttr.storageIdAttr;
return target;
}), callContext).then(function (value) {
serviceGetDocumentsByListIdVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(serviceGetDocumentsByListIdVar.value.binaryZipOut, "Documents.zip"));
});
}).catch(function (ex) {
OS$Logger.debug("wb_documentExtrationBySupplier.DownloadAll", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "7248f752-8403-4e4b-a787-9ba5a2041e1c");
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
_dropdownSuppliersOnChanged$Action(supplierId2In, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "23f43dac-a057-48b5-8872-5e636a787118");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSuppliersOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.DropdownSuppliersOnChanged$vars"))());
vars.value.supplierId2InLocal = supplierId2In;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// SupplierId = SupplierId2
model.variables.supplierIdVar = vars.value.supplierId2InLocal;
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_wb_DownloadFileStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_DownloadFileStart", function (span) {
if(span) {
span.setAttribute("code.function", "wb_DownloadFileStart");
span.setAttribute("outsystems.function.key", "316bda7b-59cd-47ce-8934-62bbe111d150");
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
span.setAttribute("outsystems.function.key", "4304009f-5e96-4e34-b03f-0bc13643b0f5");
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
_wb_CalendarClearEnd$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CalendarClearEnd", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CalendarClearEnd");
span.setAttribute("outsystems.function.key", "6b823087-e641-4796-8f70-4b4a7dca9401");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_CalendarClearEnd");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// DateEnd = NullDate
model.variables.dateEndVar = OS$BuiltinFunctions.nullDate();
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("EndDate"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("EndDate"), callContext);

// Execute Action: Refresh
return controller._refresh$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
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
span.setAttribute("outsystems.function.key", "6bf3c742-9005-4dfc-9641-2672954e942a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.SelectFile$vars"))());
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
_wb_CalendarClearStart$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CalendarClearStart", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CalendarClearStart");
span.setAttribute("outsystems.function.key", "921fdd89-3b56-4a4e-881b-e9f3a0017578");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_CalendarClearStart");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// DateStart = NullDate
model.variables.dateStartVar = OS$BuiltinFunctions.nullDate();
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("StartDate"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("StartDate"), callContext);

// Execute Action: Refresh
return controller._refresh$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "992007ee-e4f9-4304-b5ad-70cd016401a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort2 += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort2 = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex2 = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_datePickerOnSelectedStart$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelectedStart", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelectedStart");
span.setAttribute("outsystems.function.key", "a5517334-1e79-4a4f-b86c-a8167908d735");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DatePickerOnSelectedStart");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.DatePickerOnSelectedStart$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
return OS$Flow.executeAsyncFlow(function () {
// DateStart = SelectedDateTime
model.variables.dateStartVar = vars.value.selectedDateTimeInLocal;
// Execute Action: Refresh
return controller._refresh$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_datePickerOnSelectedEnd$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelectedEnd", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelectedEnd");
span.setAttribute("outsystems.function.key", "a79a35d4-2022-4d24-850c-a144b817904d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DatePickerOnSelectedEnd");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.DatePickerOnSelectedEnd$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
return OS$Flow.executeAsyncFlow(function () {
// DateEnd = SelectedDateTime
model.variables.dateEndVar = vars.value.selectedDateTimeInLocal;
// Execute Action: Refresh
return controller._refresh$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
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
span.setAttribute("outsystems.function.key", "cf820b0b-f180-400d-a858-966b53d14372");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectLines");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesAggr.listOut, function (p) {
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "e0c722a1-0d41-4433-a80e-5db04bfbb138");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_refresh$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Refresh", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "fee9373c-986e-49c3-afc2-c4e7ea635455");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Refresh");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
model.flush();
return result.then(function () {
// IsSelectOne = False
model.variables.isSelectOneVar = false;
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

downloadAll$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadAll__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAll");
span.setAttribute("outsystems.function.key", "12ba713e-44a6-485f-9469-ee9c645ba1b7");
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

dropdownSuppliersOnChanged$Action(supplierId2In, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSuppliersOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSuppliersOnChanged");
span.setAttribute("outsystems.function.key", "23f43dac-a057-48b5-8872-5e636a787118");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSuppliersOnChanged$Action, callContext, supplierId2In);
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
span.setAttribute("outsystems.function.key", "316bda7b-59cd-47ce-8934-62bbe111d150");
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
span.setAttribute("outsystems.function.key", "4304009f-5e96-4e34-b03f-0bc13643b0f5");
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

wb_CalendarClearEnd$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CalendarClearEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CalendarClearEnd");
span.setAttribute("outsystems.function.key", "6b823087-e641-4796-8f70-4b4a7dca9401");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_CalendarClearEnd$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

selectFile$Action(i_StorageIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectFile");
span.setAttribute("outsystems.function.key", "6bf3c742-9005-4dfc-9641-2672954e942a");
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

wb_CalendarClearStart$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CalendarClearStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CalendarClearStart");
span.setAttribute("outsystems.function.key", "921fdd89-3b56-4a4e-881b-e9f3a0017578");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_CalendarClearStart$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "992007ee-e4f9-4304-b5ad-70cd016401a9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSort$Action, callContext, sortByIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerOnSelectedStart$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelectedStart__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelectedStart");
span.setAttribute("outsystems.function.key", "a5517334-1e79-4a4f-b86c-a8167908d735");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._datePickerOnSelectedStart$Action, callContext, selectedDateTimeIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerOnSelectedEnd$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelectedEnd__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelectedEnd");
span.setAttribute("outsystems.function.key", "a79a35d4-2022-4d24-850c-a144b817904d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._datePickerOnSelectedEnd$Action, callContext, selectedDateTimeIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

selectLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectLines");
span.setAttribute("outsystems.function.key", "cf820b0b-f180-400d-a858-966b53d14372");
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

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "e0c722a1-0d41-4433-a80e-5db04bfbb138");
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

refresh$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Refresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "fee9373c-986e-49c3-afc2-c4e7ea635455");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refresh$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier$ServiceAPIServiceGetDocumentsByListId", [{
name: "BinaryZip",
attrName: "binaryZipOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.DropdownSuppliersOnChanged$vars", [{
name: "SupplierId2",
attrName: "supplierId2InLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.SelectFile$vars", [{
name: "i_StorageId",
attrName: "i_StorageIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.DatePickerOnSelectedStart$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.DatePickerOnSelectedEnd$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


