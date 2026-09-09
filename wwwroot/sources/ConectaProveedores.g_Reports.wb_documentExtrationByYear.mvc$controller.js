import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByYear_mvc_TranslationsResources from "./ConectaProveedores.g_Reports.wb_documentExtrationByYear.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_g_Reports_wb_documentExtrationByYear_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInvoiceFilesByCreatedOn$AggrRefresh: 0,
getYears$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInvoiceFilesByCreatedOn$AggrRefresh: [],
getYears$DataActRefresh: []
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
return controller.callServerAction("ServiceGetDocumentsByListId", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByYear/ServiceAPIServiceGetDocumentsByListId", "B_km2SQBw90cnqn+1+_34g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear$ServiceAPIServiceGetDocumentsByListId"))();
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
serviceStorageGetFile$ServerAction(i_StorageIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceStorageGetFile", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceStorageGetFile");
span.setAttribute("outsystems.function.key", "1d596008-dc18-403f-8ce0-92ac33d37308");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_StorageId: OS$DataConversion.ServerDataConverter.to(i_StorageIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceStorageGetFile", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByYear/ServiceAPIServiceStorageGetFile", "KQirY72iTSCacYF0YZ0tgQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear$ServiceAPIServiceStorageGetFile"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, OS$DataTypes.DataTypes.BinaryData);
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
get getInvoiceFilesByCreatedOn$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceFilesByCreatedOn$AggrRefresh"))) {
this._getInvoiceFilesByCreatedOn$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceFilesByCreatedOn", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByYear/ScreenDataSetGetInvoiceFilesByCreatedOn", "dKA6LeVFCCntq8AtL3Rolg", maxRecords, startIndex, function (b) {
model.variables.getInvoiceFilesByCreatedOnAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesByCreatedOnAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesByCreatedOnAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFilesByCreatedOn", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesByCreatedOn");
span.setAttribute("outsystems.function.key", "6aa661a5-0181-4b72-bf8f-d2fffa31110d");
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

return this._getInvoiceFilesByCreatedOn$AggrRefresh;
}set getInvoiceFilesByCreatedOn$AggrRefresh(value) {this._getInvoiceFilesByCreatedOn$AggrRefresh = value;
}

get getYears$DataActRefresh() {if(!(this.hasOwnProperty("_getYears$DataActRefresh"))) {
this._getYears$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetYears", "screenservices/ConectaProveedores/g_Reports/wb_documentExtrationByYear/DataActionGetYears", "zD7IAqrXfL8EWSLXwVvGqw", function (b) {
model.variables.getYearsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getYearsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getYearsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetYears", function (span) {
if(span) {
span.setAttribute("code.function", "GetYears");
span.setAttribute("outsystems.function.key", "189cfcad-f980-4374-a8e9-c8094c4272da");
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

return this._getYears$DataActRefresh;
}set getYears$DataActRefresh(value) {this._getYears$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInvoiceFilesByCreatedOn$AggrRefresh", "getYears$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_selectLines$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectLines", function (span) {
if(span) {
span.setAttribute("code.function", "SelectLines");
span.setAttribute("outsystems.function.key", "0172eb44-7920-4281-9a9e-5020c1998724");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectLines");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesByCreatedOnAggr.listOut, function (p) {
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
_refresh$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Refresh", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "02ed649b-ab73-40a9-af97-813b35d81e2b");
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
// Refresh Query: GetInvoiceFilesByCreatedOn
var result = controller.getInvoiceFilesByCreatedOn$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_yearAux$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("YearAux", function (span) {
if(span) {
span.setAttribute("code.function", "YearAux");
span.setAttribute("outsystems.function.key", "28bba222-f767-4bf8-be68-a3979f7bbfc8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("YearAux");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear.YearAux$vars"))());
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
// Refresh Query: GetInvoiceFilesByCreatedOn
var result = controller.getInvoiceFilesByCreatedOn$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "37e91d28-2f7e-4b88-ac10-44b7cfb9b67a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetInvoiceFilesByCreatedOn
var result = controller.getInvoiceFilesByCreatedOn$AggrRefresh(model.variables.maxRecordsVar, model.variables.startIndexVar, callContext);
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
_downloadAll$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadAll", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAll");
span.setAttribute("outsystems.function.key", "4870f9ea-079a-4aef-b9e5-65cad249c9a7");
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
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceFilesByCreatedOnAggr.listOut, function (p) {
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
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(serviceGetDocumentsByListIdVar.value.binaryZipOut, OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("oax9B5E2nU2lZlFaVDQkGw#Filename.-1894046005.1", "Documents.zip")));
});
}).catch(function (ex) {
OS$Logger.debug("wb_documentExtrationByYear.DownloadAll", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "ce7437de-55d3-4ba4-aa49-db496fa43a4f");
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
_downloadOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadOnClick");
span.setAttribute("outsystems.function.key", "4dd9b214-9fa3-47c5-9495-e9319d03c496");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var serviceStorageGetFileVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ServiceStorageGetFile
model.flush();
return controller.serviceStorageGetFile$ServerAction(model.variables.getInvoiceFilesByCreatedOnAggr.listOut.getCurrent(callContext.iterationContext).storageAttr.idAttr, callContext).then(function (value) {
serviceStorageGetFileVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(serviceStorageGetFileVar.value.o_FileOut, serviceStorageGetFileVar.value.o_filenameOut));
});
}).catch(function (ex) {
OS$Logger.debug("wb_documentExtrationByYear.DownloadOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "1985b476-6f97-4cd7-a1ef-ebadcd993888");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "a33774e5-0058-4e24-8152-13c44e296bad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Year = Year
model.variables.yearVar = OS$BuiltinFunctions.year(OS$BuiltinFunctions.currDate());
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
span.setAttribute("outsystems.function.key", "c8f3be90-11e9-465b-bcd7-0dba7b34c715");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear.SelectFile$vars"))());
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

selectLines$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectLines__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectLines");
span.setAttribute("outsystems.function.key", "0172eb44-7920-4281-9a9e-5020c1998724");
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

refresh$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Refresh__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Refresh");
span.setAttribute("outsystems.function.key", "02ed649b-ab73-40a9-af97-813b35d81e2b");
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

yearAux$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("YearAux__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "YearAux");
span.setAttribute("outsystems.function.key", "28bba222-f767-4bf8-be68-a3979f7bbfc8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._yearAux$Action, callContext, sortByIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "37e91d28-2f7e-4b88-ac10-44b7cfb9b67a");
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

downloadAll$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadAll__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadAll");
span.setAttribute("outsystems.function.key", "4870f9ea-079a-4aef-b9e5-65cad249c9a7");
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

downloadOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadOnClick");
span.setAttribute("outsystems.function.key", "4dd9b214-9fa3-47c5-9495-e9319d03c496");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "a33774e5-0058-4e24-8152-13c44e296bad");
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

selectFile$Action(i_StorageIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectFile");
span.setAttribute("outsystems.function.key", "c8f3be90-11e9-465b-bcd7-0dba7b34c715");
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
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear$ServiceAPIServiceGetDocumentsByListId", [{
name: "BinaryZip",
attrName: "binaryZipOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear$ServiceAPIServiceStorageGetFile", [{
name: "o_File",
attrName: "o_FileOut",
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
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear.YearAux$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.g_Reports.wb_documentExtrationByYear.SelectFile$vars", [{
name: "i_StorageId",
attrName: "i_StorageIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


