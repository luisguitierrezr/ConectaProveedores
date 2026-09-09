import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSupplierUsersByUserId$AggrRefresh: 0,
getInvoiceFiles$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getSupplierUsersByUserId$AggrRefresh: [],
getInvoiceFiles$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods

// Aggregates and Data Actions
get getSupplierUsersByUserId$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierUsersByUserId$AggrRefresh"))) {
this._getSupplierUsersByUserId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierUsersByUserId", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SupportSAEUploadEdit/ScreenDataSetGetSupplierUsersByUserId", "bSnCNyVXW3Wliu7s+vaqYg", maxRecords, startIndex, function (b) {
model.variables.getSupplierUsersByUserIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierUsersByUserIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierUsersByUserIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierUsersByUserId", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUsersByUserId");
span.setAttribute("outsystems.function.key", "1ed0bd39-0a62-4f11-bbbd-f622e9afe3cb");
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

return this._getSupplierUsersByUserId$AggrRefresh;
}set getSupplierUsersByUserId$AggrRefresh(value) {this._getSupplierUsersByUserId$AggrRefresh = value;
}

get getInvoiceFiles$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceFiles$AggrRefresh"))) {
this._getInvoiceFiles$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceFiles", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_SupportSAEUploadEdit/ScreenDataSetGetInvoiceFiles", "b3oEJAZW2rITZfWrfkdw6g", maxRecords, startIndex, function (b) {
model.variables.getInvoiceFilesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceFilesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceFilesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getInvoiceFilesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFiles");
span.setAttribute("outsystems.function.key", "ad9ec569-03be-44d4-96b8-80a0bae6fea8");
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
this._dataFetchActionNames = ["getSupplierUsersByUserId$AggrRefresh", "getInvoiceFiles$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_validationOtherFiles$Action(fileIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidationOtherFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationOtherFiles");
span.setAttribute("outsystems.function.key", "0bdc4ce4-323a-4942-a575-255c68fffd4c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidationOtherFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.ValidationOtherFiles$vars"))());
vars.value.fileInLocal = fileIn.clone();
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.filesListVar, function (p) {
return (vars.value.fileInLocal.fileNameAttr === p.nameAttr);
}, callContext);

// is unique?
if((!(listFilterVar.value.filteredListOut.isEmpty))) {
// ErrorMsg = "This filename already exists for this invoice"
model.variables.errorMsgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rE2V8R+sGkeb9aAN_OeSHw#Value.209850919.1", "This filename already exists for this invoice");
}

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
span.setAttribute("outsystems.function.key", "1fe5fcb3-2e9c-4930-9542-2369ecbdede6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSupplierUsersByUserId
var result = controller.getSupplierUsersByUserId$AggrRefresh(50, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetInvoiceFiles
var result = controller.getInvoiceFiles$AggrRefresh(999999999, 0, callContext);
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
_getInvoiceFilesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetInvoiceFilesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesOnAfterFetch");
span.setAttribute("outsystems.function.key", "78525ff1-bfb5-452a-8507-d92f53c9367d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetInvoiceFilesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getInvoiceFilesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), function (source, target) {
target.nameAttr = source.invoiceFileAttr.filenameAttr;
target.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
target.isExtraAttr = source.invoiceFileAttr.isExtraAttr;
target.storageIdAttr = source.invoiceFileAttr.storageIdAttr;
return target;
}), callContext);
// Trigger Event: SendFilesExtra
return controller.sendFilesExtra$Action(model.variables.filesListVar, callContext);
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
span.setAttribute("outsystems.function.key", "af4eadb3-6b71-4bdb-926e-9f91d92daee1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
// HasChanged = True
model.variables.hasChangedVar = true;
// Trigger Event: SendFilesExtra
return controller.sendFilesExtra$Action(model.variables.filesListVar, callContext);
});
}, function () {
if(span) {
span.end();
}

});
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
span.setAttribute("outsystems.function.key", "ceea08e9-dc88-477b-876e-85add5b4d7fd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// ok?
return OS$Flow.executeSequence(function () {
if((vars.value.errorInLocal.successAttr)) {
// exists?
return OS$Flow.executeSequence(function () {
if((!(OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
// Execute Action: ValidationOtherFiles
controller._validationOtherFiles$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), callContext);
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.isExtraAttr = true;
return target;
}), callContext);
// Trigger Event: SendFilesExtra
return controller.sendFilesExtra$Action(model.variables.filesListVar, callContext).then(function () {
// HasChanged = True
model.variables.hasChangedVar = true;
});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jPnrx4kEGUKZ_vBrcpAujQ#Message.875725967.1", "Empty file"), /*Error*/ 3);
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
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

validationOtherFiles$Action(fileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidationOtherFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidationOtherFiles");
span.setAttribute("outsystems.function.key", "0bdc4ce4-323a-4942-a575-255c68fffd4c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validationOtherFiles$Action, callContext, fileIn);
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
span.setAttribute("outsystems.function.key", "1fe5fcb3-2e9c-4930-9542-2369ecbdede6");
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

getInvoiceFilesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetInvoiceFilesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceFilesOnAfterFetch");
span.setAttribute("outsystems.function.key", "78525ff1-bfb5-452a-8507-d92f53c9367d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getInvoiceFilesOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "af4eadb3-6b71-4bdb-926e-9f91d92daee1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, indexIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

customUploadOnFileChange$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "ceea08e9-dc88-477b-876e-85add5b4d7fd");
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

get sendFilesExtra$Action() {if(!(this.hasOwnProperty("_sendFilesExtra$Action"))) {
this._sendFilesExtra$Action = function () {
return Promise.resolve();
};
}

return this._sendFilesExtra$Action;
}set sendFilesExtra$Action(value) {this._sendFilesExtra$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.ValidationOtherFiles$vars", [{
name: "File",
attrName: "fileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
},
complexType: ST_1d6498da9105fbe815a7f766352917c0Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.CustomUploadOnFileChange$vars", [{
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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


