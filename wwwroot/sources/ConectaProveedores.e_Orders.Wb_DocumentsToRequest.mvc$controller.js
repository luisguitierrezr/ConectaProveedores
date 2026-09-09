import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, Exceptions as OS$Exceptions, SystemActions as OS$SystemActions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { isListValid$Action as ConectaProveedoresController$isListValid$Action } from "./ConectaProveedores.controller.js";
import { ST_d9010d115c38fb059bccbc457fe11b18Structure, RC_9b26d66c2c2462dead9020a39a074a2b, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_DocumentsToRequest.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_DocumentsToRequest_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSupplierUsersBySupplierId$AggrRefresh: 0,
getOrderRequestFiles$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getSupplierUsersBySupplierId$AggrRefresh: [],
getOrderRequestFiles$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
sendDocuments$ServerAction(documentsRecordListIn, userIdsIn, getOrderRequestFiles_RequestFilesIn, getSupplierUsersBySupplierId_ListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendDocuments", function (span) {
if(span) {
span.setAttribute("code.function", "SendDocuments");
span.setAttribute("outsystems.function.key", "2904340f-f348-43a5-b2df-fd04a326ac55");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
DocumentsRecordList: OS$DataConversion.ServerDataConverter.to(documentsRecordListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
UserIds: OS$DataConversion.ServerDataConverter.to(userIdsIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
GetOrderRequestFiles_RequestFiles: OS$DataConversion.ServerDataConverter.to(getOrderRequestFiles_RequestFilesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
GetSupplierUsersBySupplierId_List: OS$DataConversion.ServerDataConverter.to(getSupplierUsersBySupplierId_ListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SendDocuments", "screenservices/ConectaProveedores/e_Orders/Wb_DocumentsToRequest/ActionSendDocuments", "838pdhdSQTe5RU9IbDPE4A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getSupplierUsersBySupplierId$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierUsersBySupplierId$AggrRefresh"))) {
this._getSupplierUsersBySupplierId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierUsersBySupplierId", "screenservices/ConectaProveedores/e_Orders/Wb_DocumentsToRequest/ScreenDataSetGetSupplierUsersBySupplierId", "RA0Cwu5tY1TSNtbMTNmA5A", maxRecords, startIndex, function (b) {
model.variables.getSupplierUsersBySupplierIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierUsersBySupplierIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierUsersBySupplierIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierUsersBySupplierId", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUsersBySupplierId");
span.setAttribute("outsystems.function.key", "ab20b35e-ffc8-451a-9766-90d2d84b8ddc");
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

return this._getSupplierUsersBySupplierId$AggrRefresh;
}set getSupplierUsersBySupplierId$AggrRefresh(value) {this._getSupplierUsersBySupplierId$AggrRefresh = value;
}

get getOrderRequestFiles$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderRequestFiles$DataActRefresh"))) {
this._getOrderRequestFiles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderRequestFiles", "screenservices/ConectaProveedores/e_Orders/Wb_DocumentsToRequest/DataActionGetOrderRequestFiles", "6ZTUqAc9FXa7jDtKTC5D5g", function (b) {
model.variables.getOrderRequestFilesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderRequestFilesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderRequestFilesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderRequestFilesByOrderIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderRequestFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRequestFiles");
span.setAttribute("outsystems.function.key", "7bf83dac-cd96-45e9-9e5e-4258e2c61c8a");
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

return this._getOrderRequestFiles$DataActRefresh;
}set getOrderRequestFiles$DataActRefresh(value) {this._getOrderRequestFiles$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSupplierUsersBySupplierId$AggrRefresh", "getOrderRequestFiles$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_checkValid$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CheckValid", function (span) {
if(span) {
span.setAttribute("code.function", "CheckValid");
span.setAttribute("outsystems.function.key", "28914cea-5d8e-47d4-aa7e-a107c3127282");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CheckValid");
callContext = controller.callContext(callContext);
var isListValidVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: IsListValid
isListValidVar.value = ConectaProveedoresController$isListValid$Action(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderRequestFilesDataAct.requestFilesOut, new OS$DataTypes.TextList(), function (source, target) {
target = source.descriptionAttr;
return target;
}), callContext);

// l_IsValidList = IsListValid.Result
model.variables.l_IsValidListVar = isListValidVar.value.resultOut;
// Trigger Event: UploadParent
return controller.uploadParent$Action(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderRequestFilesDataAct.requestFilesOut, new (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))(), function (source, target) {
target.orderRequestFileAttr.idAttr = source.idAttr;
target.orderRequestFileAttr.orderIdAttr = source.orderIdAttr;
target.orderRequestFileAttr.invoiceIdAttr = source.invoiceIdAttr;
target.orderRequestFileAttr.filenameAttr = source.filenameAttr;
target.orderRequestFileAttr.storageIdAttr = source.storageIdAttr;
target.orderRequestFileAttr.descriptionAttr = source.descriptionAttr;
target.orderRequestFileAttr.needsApprovalAttr = source.needsApprovalAttr;
target.orderRequestFileAttr.isApprovedAttr = source.isApprovedAttr;
target.orderRequestFileAttr.isRejectedAttr = source.isRejectedAttr;
target.orderRequestFileAttr.createdByAttr = source.createdByAttr;
target.orderRequestFileAttr.createdOnAttr = source.createdOnAttr;
target.orderRequestFileAttr.updatedByAttr = source.updatedByAttr;
target.orderRequestFileAttr.updatedOnAttr = source.updatedOnAttr;
target.orderRequestFileAttr.orderAccConceptIdAttr = source.orderAccConceptIdAttr;
target.orderRequestFileAttr.isFinancialFileAttr = source.isFinancialFileAttr;
target.orderRequestFileAttr.orderContractFileAttr = source.orderContractFileAttr;
target.orderRequestFileAttr.needAccountingAttr = source.needAccountingAttr;
return target;
}), model.variables.i_HasntRequestDocumentsIn, isListValidVar.value.resultOut, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_removeOnClick$Action(rowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "758714ff-fd3b-4f5b-bba9-2f79d4896edc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_DocumentsToRequest.RemoveOnClick$vars"))());
vars.value.rowNumberInLocal = rowNumberIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.getOrderRequestFilesDataAct.requestFilesOut, vars.value.rowNumberInLocal, callContext);
// Execute Action: CheckValid
return controller._checkValid$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_sendOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SendOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SendOnClick");
span.setAttribute("outsystems.function.key", "c6aebc49-5272-4d55-ba2d-61739247ad8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SendOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_DocumentsToRequest.SendOnClick$vars"))());
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
return OS$Flow.executeAsyncFlow(function () {
// l_IsBusy = True
model.variables.l_IsBusyVar = true;
// Execute Action: SendDocuments
model.flush();
return controller.sendDocuments$ServerAction(vars.value.documentsRecordListVar, vars.value.userIdsVar, model.variables.getOrderRequestFilesDataAct.requestFilesOut, model.variables.getSupplierUsersBySupplierIdAggr.listOut, callContext).then(function () {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Success
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SpZgmsHffE2U7a00IJga2Q#Message.-1986375283.1", "Notification sent"), /*Info*/ 0);
});
}).catch(function (ex) {
OS$Logger.debug("Wb_DocumentsToRequest.SendOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "e810e5cb-4fda-42d5-aa22-6f4619dbcc35");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("aOaXm3iMwky1iK8I5dN7Xw#Message.1545432873.1", "Error sending notification"), /*Error*/ 3);
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
_getOrderRequestFilesByOrderIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderRequestFilesByOrderIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRequestFilesByOrderIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "deec299f-6bc8-4eb8-b18b-deeda8531610");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderRequestFilesByOrderIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: CheckValid
return controller._checkValid$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_addRecord$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddRecord", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "e97830aa-7b1a-4008-9bd4-2a6e23b01b85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("AddRecord");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.getOrderRequestFilesDataAct.requestFilesOut, function () {
var rec = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.orderIdAttr = model.variables.i_OrderIdIn;
rec.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.descriptionAttr = "";
return rec;
}(), callContext);
// Execute Action: CheckValid
return controller._checkValid$Action(callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_switchOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SwitchOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "SwitchOnChange");
span.setAttribute("outsystems.function.key", "ee593d11-7624-433b-8517-3ebaba056379");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SwitchOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Not Applicable with files?
return OS$Flow.executeSequence(function () {
if(((model.variables.i_HasntRequestDocumentsIn && (!(model.variables.getOrderRequestFilesDataAct.requestFilesOut.isEmpty))))) {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.getOrderRequestFilesDataAct.requestFilesOut, callContext);
// Trigger Event: UploadParent2
return controller.uploadParent$Action(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderRequestFilesDataAct.requestFilesOut, new (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))(), function (source, target) {
target.orderRequestFileAttr.idAttr = source.idAttr;
target.orderRequestFileAttr.orderIdAttr = source.orderIdAttr;
target.orderRequestFileAttr.invoiceIdAttr = source.invoiceIdAttr;
target.orderRequestFileAttr.filenameAttr = source.filenameAttr;
target.orderRequestFileAttr.storageIdAttr = source.storageIdAttr;
target.orderRequestFileAttr.descriptionAttr = source.descriptionAttr;
target.orderRequestFileAttr.needsApprovalAttr = source.needsApprovalAttr;
target.orderRequestFileAttr.isApprovedAttr = source.isApprovedAttr;
target.orderRequestFileAttr.isRejectedAttr = source.isRejectedAttr;
target.orderRequestFileAttr.createdByAttr = source.createdByAttr;
target.orderRequestFileAttr.createdOnAttr = source.createdOnAttr;
target.orderRequestFileAttr.updatedByAttr = source.updatedByAttr;
target.orderRequestFileAttr.updatedOnAttr = source.updatedOnAttr;
target.orderRequestFileAttr.orderAccConceptIdAttr = source.orderAccConceptIdAttr;
target.orderRequestFileAttr.isFinancialFileAttr = source.isFinancialFileAttr;
target.orderRequestFileAttr.orderContractFileAttr = source.orderContractFileAttr;
target.orderRequestFileAttr.needAccountingAttr = source.needAccountingAttr;
return target;
}), model.variables.i_HasntRequestDocumentsIn, false, callContext);
} else {
// Trigger Event: UploadParent
return controller.uploadParent$Action(OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderRequestFilesDataAct.requestFilesOut, new (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))(), function (source, target) {
target.orderRequestFileAttr.idAttr = source.idAttr;
target.orderRequestFileAttr.orderIdAttr = source.orderIdAttr;
target.orderRequestFileAttr.invoiceIdAttr = source.invoiceIdAttr;
target.orderRequestFileAttr.filenameAttr = source.filenameAttr;
target.orderRequestFileAttr.storageIdAttr = source.storageIdAttr;
target.orderRequestFileAttr.descriptionAttr = source.descriptionAttr;
target.orderRequestFileAttr.needsApprovalAttr = source.needsApprovalAttr;
target.orderRequestFileAttr.isApprovedAttr = source.isApprovedAttr;
target.orderRequestFileAttr.isRejectedAttr = source.isRejectedAttr;
target.orderRequestFileAttr.createdByAttr = source.createdByAttr;
target.orderRequestFileAttr.createdOnAttr = source.createdOnAttr;
target.orderRequestFileAttr.updatedByAttr = source.updatedByAttr;
target.orderRequestFileAttr.updatedOnAttr = source.updatedOnAttr;
target.orderRequestFileAttr.orderAccConceptIdAttr = source.orderAccConceptIdAttr;
target.orderRequestFileAttr.isFinancialFileAttr = source.isFinancialFileAttr;
target.orderRequestFileAttr.orderContractFileAttr = source.orderContractFileAttr;
target.orderRequestFileAttr.needAccountingAttr = source.needAccountingAttr;
return target;
}), model.variables.i_HasntRequestDocumentsIn, false, callContext);
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
span.setAttribute("outsystems.function.key", "fd4b2d5f-ef62-4e20-a591-060cf63da190");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((model.variables.i_HasErrorIn) !== (model.variables.l_HasErrorVar)))) {
// l_HasError = i_HasError
model.variables.l_HasErrorVar = model.variables.i_HasErrorIn;
} else {
// Refresh Query: GetOrderRequestFiles
var result = controller.getOrderRequestFiles$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSupplierUsersBySupplierId
var result = controller.getSupplierUsersBySupplierId$AggrRefresh(30, 0, callContext);
model.flush();
return result;
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

checkValid$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckValid__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CheckValid");
span.setAttribute("outsystems.function.key", "28914cea-5d8e-47d4-aa7e-a107c3127282");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._checkValid$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

removeOnClick$Action(rowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "758714ff-fd3b-4f5b-bba9-2f79d4896edc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeOnClick$Action, callContext, rowNumberIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

sendOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SendOnClick");
span.setAttribute("outsystems.function.key", "c6aebc49-5272-4d55-ba2d-61739247ad8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._sendOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getOrderRequestFilesByOrderIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderRequestFilesByOrderIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRequestFilesByOrderIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "deec299f-6bc8-4eb8-b18b-deeda8531610");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderRequestFilesByOrderIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

addRecord$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddRecord__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "e97830aa-7b1a-4008-9bd4-2a6e23b01b85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._addRecord$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

switchOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SwitchOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SwitchOnChange");
span.setAttribute("outsystems.function.key", "ee593d11-7624-433b-8517-3ebaba056379");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._switchOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "fd4b2d5f-ef62-4e20-a591-060cf63da190");
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

get uploadParent$Action() {if(!(this.hasOwnProperty("_uploadParent$Action"))) {
this._uploadParent$Action = function () {
return Promise.resolve();
};
}

return this._uploadParent$Action;
}set uploadParent$Action(value) {this._uploadParent$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_DocumentsToRequest.RemoveOnClick$vars", [{
name: "RowNumber",
attrName: "rowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_DocumentsToRequest.SendOnClick$vars", [{
name: "UserIds",
attrName: "userIdsVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new OS$DataTypes.TextList();
},
complexType: OS$DataTypes.TextList
}, {
name: "DocumentsRecordList",
attrName: "documentsRecordListVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(RC_9b26d66c2c2462dead9020a39a074a2b))();
},
complexType: (OS$GenericTypeCache.getGenericList(RC_9b26d66c2c2462dead9020a39a074a2b))
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


