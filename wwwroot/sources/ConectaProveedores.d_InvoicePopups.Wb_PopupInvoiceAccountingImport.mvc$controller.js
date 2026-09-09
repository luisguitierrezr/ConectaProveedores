import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Flow as OS$Flow, Logger as OS$Logger, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord, RC_3a3d5d4cc50f8572263073b452541424, ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_mvc_TranslationsResources from "./ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {};
this.dataFetchDependentsGraph = {};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
importAccounting$ServerAction(i_FileIn, i_InvoiceIdIn, i_SupplierNumberIn, i_TotalAmountIn, i_InvoiceAccountingIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ImportAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "ImportAccounting");
span.setAttribute("outsystems.function.key", "2ba363b1-6ca2-4174-b658-da40d1f7add6");
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
}),
i_InvoiceId: OS$DataConversion.ServerDataConverter.to(i_InvoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_SupplierNumber: OS$DataConversion.ServerDataConverter.to(i_SupplierNumberIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_TotalAmount: OS$DataConversion.ServerDataConverter.to(i_TotalAmountIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
i_InvoiceAccountingId: OS$DataConversion.ServerDataConverter.to(i_InvoiceAccountingIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ImportAccounting", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceAccountingImport/ActionImportAccounting", "OMbxyeW5L5Tkg8sNafr97A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport$ActionImportAccounting"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.o_InvoiceAccountingOut = OS$DataConversion.ServerDataConverter.from(outputs.o_InvoiceAccounting, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord);
executeServerActionResult.o_InvoiceAccountingEntriesOut = OS$DataConversion.ServerDataConverter.from(outputs.o_InvoiceAccountingEntries, (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord)));
executeServerActionResult.o_InvoiceAccountingServicesOut = OS$DataConversion.ServerDataConverter.from(outputs.o_InvoiceAccountingServices, (OS$GenericTypeCache.getGenericList(RC_3a3d5d4cc50f8572263073b452541424)));
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
getAccountingLayoutFile$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetAccountingLayoutFile", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingLayoutFile");
span.setAttribute("outsystems.function.key", "2b71ebb8-111d-4b73-8fcc-6a7d3d2835ad");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("GetAccountingLayoutFile", "screenservices/ConectaProveedores/d_InvoicePopups/Wb_PopupInvoiceAccountingImport/ActionGetAccountingLayoutFile", "H0APOfOpZGNh722c5qkBJA", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport$ActionGetAccountingLayoutFile"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, ST_a158c76eb93396680623c04244f48b6cStructure);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "0a2cadd9-f8a0-4bd3-9fcf-330657d94e05");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
// l_File.Name = ""
model.variables.l_FileVar.nameAttr = "";
// l_File.BinaryData = NullBinary
model.variables.l_FileVar.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
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
span.setAttribute("outsystems.function.key", "4c5708ed-bbc2-49d8-9b14-92dd299a215f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ImportOnClick");
callContext = controller.callContext(callContext);
var importAccountingVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Empty file?
return OS$Flow.executeSequence(function () {
if((((model.variables.l_FileVar.nameAttr === "") || OS$DataTypes.areBinaryNulls(model.variables.l_FileVar.binaryDataAttr, OS$BuiltinFunctions.nullBinary())))) {
// l_Valid.IsValid = False
model.variables.l_ValidVar.isValidAttr = false;
// l_Valid.ValidationMessage = "This field is mandatory"
model.variables.l_ValidVar.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HToowdm2E0OcJytC4Q2omg#Value.-1029745557.1", "This field is mandatory");
} else {
// Execute Action: ImportAccounting
model.flush();
return controller.importAccounting$ServerAction(model.variables.l_FileVar, model.variables.i_InvoiceIdIn, model.variables.supplierNumberIn, model.variables.totalAmountIn, model.variables.i_InvoiceAccountingIdIn, callContext).then(function (value) {
importAccountingVar.value = value;
}).then(function () {
// Success?
return OS$Flow.executeSequence(function () {
if((importAccountingVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XQMRUu6XKkClkfp_y8s+4g#Message.1213196951.1", "File was imported with success!"), /*Success*/ 1);
// Trigger Event: Import
return controller.import$Action(importAccountingVar.value.o_InvoiceAccountingOut, importAccountingVar.value.o_InvoiceAccountingServicesOut, importAccountingVar.value.o_InvoiceAccountingEntriesOut, callContext);
} else {
OS$FeedbackMessageService.showFeedbackMessage(importAccountingVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
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
_downloadLayout$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DownloadLayout", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadLayout");
span.setAttribute("outsystems.function.key", "5cc80904-5cf3-443a-82d5-0d9fdf6c1d45");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DownloadLayout");
callContext = controller.callContext(callContext);
var getAccountingLayoutFileVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetAccountingLayoutFile
model.flush();
return controller.getAccountingLayoutFile$ServerAction(callContext).then(function (value) {
getAccountingLayoutFileVar.value = value;
}).then(function () {
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(getAccountingLayoutFileVar.value.o_FileOut.binaryDataAttr, getAccountingLayoutFileVar.value.o_FileOut.nameAttr));
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
_wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "fa9d3923-78c7-4d68-a9bf-5778e14d3341");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport.Wb_CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
vars.value.i_IsDeleteInLocal = i_IsDeleteIn;
if(((vars.value.errorInLocal.successAttr || OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
if((vars.value.i_IsDeleteInLocal)) {
// l_File.BinaryData = NullBinary
model.variables.l_FileVar.binaryDataAttr = OS$BuiltinFunctions.nullBinary();
// l_File.Name = ""
model.variables.l_FileVar.nameAttr = "";
} else {
// l_File.BinaryData = File.FileContent
model.variables.l_FileVar.binaryDataAttr = vars.value.fileInLocal.fileContentAttr;
// l_File.Name = File.FileName
model.variables.l_FileVar.nameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
OS$FeedbackMessageService.showFeedbackMessage(vars.value.errorInLocal.errorMessageAttr, /*Error*/ 3);
}

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
span.setAttribute("outsystems.function.key", "0a2cadd9-f8a0-4bd3-9fcf-330657d94e05");
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

importOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ImportOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ImportOnClick");
span.setAttribute("outsystems.function.key", "4c5708ed-bbc2-49d8-9b14-92dd299a215f");
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

downloadLayout$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DownloadLayout__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DownloadLayout");
span.setAttribute("outsystems.function.key", "5cc80904-5cf3-443a-82d5-0d9fdf6c1d45");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._downloadLayout$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "fa9d3923-78c7-4d68-a9bf-5778e14d3341");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CustomUploadOnFileChange$Action, callContext, fileIn, errorIn, i_IsDeleteIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

get import$Action() {if(!(this.hasOwnProperty("_import$Action"))) {
this._import$Action = function () {
return Promise.resolve();
};
}

return this._import$Action;
}set import$Action(value) {this._import$Action = value;
}

get close$Action() {if(!(this.hasOwnProperty("_close$Action"))) {
this._close$Action = function () {
return Promise.resolve();
};
}

return this._close$Action;
}set close$Action(value) {this._close$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport$ActionImportAccounting", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "o_InvoiceAccounting",
attrName: "o_InvoiceAccountingOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
},
complexType: EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord
}, {
name: "o_InvoiceAccountingEntries",
attrName: "o_InvoiceAccountingEntriesOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord))();
},
complexType: (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord))
}, {
name: "o_InvoiceAccountingServices",
attrName: "o_InvoiceAccountingServicesOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(RC_3a3d5d4cc50f8572263073b452541424))();
},
complexType: (OS$GenericTypeCache.getGenericList(RC_3a3d5d4cc50f8572263073b452541424))
}]);
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport$ActionGetAccountingLayoutFile", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
},
complexType: ST_a158c76eb93396680623c04244f48b6cStructure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.d_InvoicePopups.Wb_PopupInvoiceAccountingImport.Wb_CustomUploadOnFileChange$vars", [{
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
}, {
name: "i_IsDelete",
attrName: "i_IsDeleteInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


