import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, GenericTypeCache as OS$GenericTypeCache, SystemActions as OS$SystemActions, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_f81a3d226103fd013068b8763798067aEntityRecord, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, RC_1c2482ce6cd4b83ca44ec0510b231d44, RC_45d2d2c3c5fe5caa10fa5e20326622ac } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import { ST_f68ab54e767928bb7cc21e9801e8642bStructure, ST_cbb2055cf19f871ed882642269bd43ceStructure } from "./TelcelIntegrations.model.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import { SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType, SE_currency as ConectaProveedores_staticEntities_currency } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_mvc_TranslationsResources from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getOrderDetail$AggrRefresh: 0,
getFirstApproverList$DataActRefresh: 1,
getSettings$DataActRefresh: 0,
getSummary$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getOrderDetail$AggrRefresh: ["getFirstApproverList$DataActRefresh"],
getFirstApproverList$DataActRefresh: [],
getSettings$DataActRefresh: [],
getSummary$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
call_ZMXMIMMF_VISUALIZAR_SAL_ANT$ServerAction(requestIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Call_ZMXMIMMF_VISUALIZAR_SAL_ANT", function (span) {
if(span) {
span.setAttribute("code.function", "Call_ZMXMIMMF_VISUALIZAR_SAL_ANT");
span.setAttribute("outsystems.function.key", "d68763c3-0573-4d0f-b5af-83de06f6eb6c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Request: OS$DataConversion.ServerDataConverter.to(requestIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Call_ZMXMIMMF_VISUALIZAR_SAL_ANT", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate/ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT", "mEDBUNKMySFTPNFDy4Vl+Q", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate$ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT"))();
executeServerActionResult.responseOut = OS$DataConversion.ServerDataConverter.from(outputs.Response, ST_cbb2055cf19f871ed882642269bd43ceStructure);
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
folioCreate$ServerAction(i_SelectedLinesIn, i_OrderMainIdIn, i_FirstApprovalIdIn, i_CommentsIn, invoiceExtendedIn, filesListExtraIn, filesListIn, invoiceIdIn, invoiceForeignToCreateIn, approvalProcessTypeIdIn, constructionDataIn, approvalProcessIdIn, i_SummaryRecIn, i_IsMassCreateIn, i_MinuteSelectedIn, i_OrderAccConceptIDIn, creditNoteFilesListIn, importAnticipoIn, isNationalIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("FolioCreate", function (span) {
if(span) {
span.setAttribute("code.function", "FolioCreate");
span.setAttribute("outsystems.function.key", "5287e67b-9bff-4876-8740-efe041dbf4cf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
I_SelectedLines: OS$DataConversion.ServerDataConverter.to(i_SelectedLinesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
I_OrderMainId: OS$DataConversion.ServerDataConverter.to(i_OrderMainIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
I_FirstApprovalId: OS$DataConversion.ServerDataConverter.to(i_FirstApprovalIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_Comments: OS$DataConversion.ServerDataConverter.to(i_CommentsIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
InvoiceExtended: OS$DataConversion.ServerDataConverter.to(invoiceExtendedIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
FilesListExtra: OS$DataConversion.ServerDataConverter.to(filesListExtraIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
FilesList: OS$DataConversion.ServerDataConverter.to(filesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
InvoiceId: OS$DataConversion.ServerDataConverter.to(invoiceIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
InvoiceForeignToCreate: OS$DataConversion.ServerDataConverter.to(invoiceForeignToCreateIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
ApprovalProcessTypeId: OS$DataConversion.ServerDataConverter.to(approvalProcessTypeIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
ConstructionData: OS$DataConversion.ServerDataConverter.to(constructionDataIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
ApprovalProcessId: OS$DataConversion.ServerDataConverter.to(approvalProcessIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_SummaryRec: OS$DataConversion.ServerDataConverter.to(i_SummaryRecIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_IsMassCreate: OS$DataConversion.ServerDataConverter.to(i_IsMassCreateIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_MinuteSelected: OS$DataConversion.ServerDataConverter.to(i_MinuteSelectedIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_OrderAccConceptID: OS$DataConversion.ServerDataConverter.to(i_OrderAccConceptIDIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
CreditNoteFilesList: OS$DataConversion.ServerDataConverter.to(creditNoteFilesListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
ImportAnticipo: OS$DataConversion.ServerDataConverter.to(importAnticipoIn, {
dataType: OS$DataTypes.DataTypes.Decimal,
pendingPromises: pendingPromises
}),
IsNational: OS$DataConversion.ServerDataConverter.to(isNationalIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("FolioCreate", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate/ActionFolioCreate", "4xnZBg4JdXDVujLeNhLc5A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate$ActionFolioCreate"))();
executeServerActionResult.o_FolioNameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_FolioName, OS$DataTypes.DataTypes.Text);
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

// Aggregates and Data Actions
get getOrderDetail$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderDetail$AggrRefresh"))) {
this._getOrderDetail$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderDetail", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate/ScreenDataSetGetOrderDetail", "lpqE3qzMg4wpZUViVv4nAQ", maxRecords, startIndex, function (b) {
model.variables.getOrderDetailAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderDetailAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderDetailAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderDetailOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderDetail", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetail");
span.setAttribute("outsystems.function.key", "a901ceac-4690-415e-a5f1-175d972582df");
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

return this._getOrderDetail$AggrRefresh;
}set getOrderDetail$AggrRefresh(value) {this._getOrderDetail$AggrRefresh = value;
}

get getFirstApproverList$DataActRefresh() {if(!(this.hasOwnProperty("_getFirstApproverList$DataActRefresh"))) {
this._getFirstApproverList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetFirstApproverList", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate/DataActionGetFirstApproverList", "+VmVnA2J3Jf85rcr_WAwdQ", function (b) {
model.variables.getFirstApproverListDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFirstApproverListDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFirstApproverListDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFirstApproverList", function (span) {
if(span) {
span.setAttribute("code.function", "GetFirstApproverList");
span.setAttribute("outsystems.function.key", "0fdc4444-4411-4281-a06e-6c00a43d78ee");
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

return this._getFirstApproverList$DataActRefresh;
}set getFirstApproverList$DataActRefresh(value) {this._getFirstApproverList$DataActRefresh = value;
}

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate/DataActionGetSettings", "qX8IZemszpVC7R9L8iHOqQ", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "b3f3b8c8-4ff1-44f4-a245-bb6d99c22ea4");
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

return this._getSettings$DataActRefresh;
}set getSettings$DataActRefresh(value) {this._getSettings$DataActRefresh = value;
}

get getSummary$DataActRefresh() {if(!(this.hasOwnProperty("_getSummary$DataActRefresh"))) {
this._getSummary$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSummary", "screenservices/ConectaProveedores/j_FoliosSAE/Wb_FolioCreate/DataActionGetSummary", "8Zn+WqR+1XoWIyMin1R8Vw", function (b) {
model.variables.getSummaryDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSummaryDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSummaryDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSummaryOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSummary", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummary");
span.setAttribute("outsystems.function.key", "e9f22b66-0ade-41ad-9a52-93eeba53b7dd");
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

return this._getSummary$DataActRefresh;
}set getSummary$DataActRefresh(value) {this._getSummary$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getOrderDetail$AggrRefresh", "getFirstApproverList$DataActRefresh", "getSettings$DataActRefresh", "getSummary$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "00d3305c-3378-4893-a8cd-c70469ff5763");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.RemainingQttTotal = LocalSelectedLines.Current.RemainingQtt
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr = model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr;
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
// LocalSelectedLines.Current.IsDateError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr = true;
// LocalSelectedLines.Current.IsPEPError = If
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isPEPErrorAttr = (((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).inputationCodeAttr === "Q")) ? ((((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).pEPAttr === "")) ? (true) : (false))) : (false));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSummaryOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSummaryOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummaryOnAfterFetch");
span.setAttribute("outsystems.function.key", "054f5985-e318-4a40-a4cb-8d2ce2dd6492");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSummaryOnAfterFetch");
callContext = controller.callContext(callContext);
// l_SummaryRec = GetSummary.o_SummaryRec
model.variables.l_SummaryRecVar = model.variables.getSummaryDataAct.o_SummaryRecOut;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_InvoiceSAECUploadSendInvoiceType$Action(orderAccConceptsID_ToSaveIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendInvoiceType", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendInvoiceType");
span.setAttribute("outsystems.function.key", "05821422-b0e3-4aac-b71d-8db63ff76b64");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_InvoiceSAECUploadSendInvoiceType");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_InvoiceSAECUploadSendInvoiceType$vars"))());
vars.value.orderAccConceptsID_ToSaveInLocal = orderAccConceptsID_ToSaveIn;
// OrderAccConceptsIdToCreate = OrderAccConceptsID_ToSave
model.variables.orderAccConceptsIdToCreateVar = vars.value.orderAccConceptsID_ToSaveInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_input_InvoiceQttOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_InvoiceQttOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_InvoiceQttOnChange");
span.setAttribute("outsystems.function.key", "28951365-8ca1-4437-aa5f-1366caf0d662");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_InvoiceQttOnChange");
callContext = controller.callContext(callContext);
// Smaller then 0?
if((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Set Zero
// LocalSelectedLines.Current.InvoiceQtt = 0
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
if((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.gt(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr))) {
// Set Max
// LocalSelectedLines.Current.InvoiceQtt = LocalSelectedLines.Current.RemainingQttTotal
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr = model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr;
}

// LocalSelectedLines.Current.IsInvoiceError = False
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = false;
if(((OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr)).gt(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr) || OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr)).equals(OS$BuiltinFunctions.integerToDecimal(0))))) {
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr = true;
}

// LocalSelectedLines.Current.RemainingQtt = LocalSelectedLines.Current.RemainingQttTotal - LocalSelectedLines.Current.InvoiceQtt
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr = model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr.minus(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr);
// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_debouncePEPOnDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DebouncePEPOnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "DebouncePEPOnDebounce");
span.setAttribute("outsystems.function.key", "2a508eca-db3e-48b1-bbb5-6fde19158908");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DebouncePEPOnDebounce");
callContext = controller.callContext(callContext);
// PEP Empty?
if(((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).pEPAttr === ""))) {
// PEPError
// LocalSelectedLines.Current.IsPEPError = True
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr = true;
} else {
// PEPError
// LocalSelectedLines.Current.IsPEPError = False
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr = false;
}

// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_InvoiceSAECUploadSendFiles$Action(o_FilesListIn, o_InvoiceIn, o_InvoiceForeignIn, isNationalIn, o_InvoiceExtendedIn, i_IsRemoveIn, o_CreditNoteFilesListIn, o_CreditNoteInvoiceIn, o_NeedsCNIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFiles", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFiles");
span.setAttribute("outsystems.function.key", "2f5f4256-1385-4994-8c01-e1d87d2c6c69");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_InvoiceSAECUploadSendFiles");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_InvoiceSAECUploadSendFiles$vars"))());
vars.value.o_FilesListInLocal = o_FilesListIn.clone();
vars.value.o_InvoiceInLocal = o_InvoiceIn.clone();
vars.value.o_InvoiceForeignInLocal = o_InvoiceForeignIn.clone();
vars.value.isNationalInLocal = isNationalIn;
vars.value.o_InvoiceExtendedInLocal = o_InvoiceExtendedIn.clone();
vars.value.i_IsRemoveInLocal = i_IsRemoveIn;
vars.value.o_CreditNoteFilesListInLocal = o_CreditNoteFilesListIn.clone();
vars.value.o_CreditNoteInvoiceInLocal = o_CreditNoteInvoiceIn.clone();
vars.value.o_NeedsCNInLocal = o_NeedsCNIn;
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.filesListVar, vars.value.o_FilesListInLocal, callContext);
// Execute Action: ListClear2
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// Execute Action: ListAppendAll2
OS$SystemActions.listAppendAll(model.variables.creditNoteFilesListVar, vars.value.o_CreditNoteFilesListInLocal, callContext);
if((vars.value.i_IsRemoveInLocal)) {
// l_SummaryRec.PartialDeliveryAmount = 0
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
// InvoiceToCreate = o_Invoice
model.variables.invoiceToCreateVar = vars.value.o_InvoiceInLocal;
// InvoiceForeignToCreate = o_InvoiceForeign
model.variables.invoiceForeignToCreateVar = vars.value.o_InvoiceForeignInLocal;
// L_IsNational = IsNational
model.variables.l_IsNationalVar = vars.value.isNationalInLocal;
// InvoiceExtendedToCreate = o_InvoiceExtended
model.variables.invoiceExtendedToCreateVar = vars.value.o_InvoiceExtendedInLocal;
// CreditNoteInvoiceToCreate = o_CreditNoteInvoice
model.variables.creditNoteInvoiceToCreateVar = vars.value.o_CreditNoteInvoiceInLocal;
// CreditNote_IsNeeded = o_NeedsCN
model.variables.creditNote_IsNeededVar = vars.value.o_NeedsCNInLocal;
// l_SummaryRec.PartialDeliveryAmount = o_InvoiceExtended.Subtotal
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = vars.value.o_InvoiceExtendedInLocal.subtotalAttr;
// Execute Action: Prorate
controller._prorate$Action(callContext);
// Execute Action: ValidateFiles
controller._validateFiles$Action(callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_removeFromList$Action(indexIn, isExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "30b2f5c3-39dc-4b6f-b463-1439f2188c81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.RemoveFromList$vars"))());
vars.value.indexInLocal = indexIn;
vars.value.isExtraInLocal = isExtraIn;
if((vars.value.isExtraInLocal)) {
// Execute Action: ListRemove2
OS$SystemActions.listRemove(model.variables.filesListExtraVar, vars.value.indexInLocal, callContext);
} else {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.filesListVar, vars.value.indexInLocal, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_SupportSAECUploadSendFilesExtra$Action(o_FilesListExtraIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SupportSAECUploadSendFilesExtra", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SupportSAECUploadSendFilesExtra");
span.setAttribute("outsystems.function.key", "313fc81e-a8f7-4e8c-8b63-357dc3ef8376");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_SupportSAECUploadSendFilesExtra");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_SupportSAECUploadSendFilesExtra$vars"))());
vars.value.o_FilesListExtraInLocal = o_FilesListExtraIn.clone();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListExtraVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.filesListExtraVar, vars.value.o_FilesListExtraInLocal, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_customUploadOnFileChangeBigFile$Action(fileIn, errorIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeBigFile", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeBigFile");
span.setAttribute("outsystems.function.key", "3aa2e272-cecb-444c-b9cd-52e80228b0d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CustomUploadOnFileChangeBigFile");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.CustomUploadOnFileChangeBigFile$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
// ok?
if((vars.value.errorInLocal.successAttr)) {
// exists?
if(((OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary()) && vars.value.fileInLocal.fileBigFileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("okziHi3G2USkq0Z2GQPJNw#Message.875725967.1", "Empty file"), /*Error*/ 3);
} else {
// Execute Action: ListAppend2
OS$SystemActions.listAppend(model.variables.filesListExtraVar, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
target.fileIdAttr = OS$BuiltinFunctions.longIntegerToIdentifier(source.fileBigFileIdAttr);
return target;
}), callContext);
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
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "47092510-c5b5-4df6-a4b3-48e35a55beb5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
// WithProrata = ActiveTab = 1
model.variables.withProrataVar = (vars.value.activeTabInLocal === 1);
if(((vars.value.activeTabInLocal === 0))) {
// l_SummaryRec.PartialDeliveryAmount = 0.00
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = (OS$DataTypes.Decimal.defaultValue);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// setError
// LocalSelectedLines.Current.IsInvoiceError = True
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = true;
// LocalSelectedLines.Current.InvoiceQtt = 0
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr = OS$BuiltinFunctions.integerToDecimal(0);
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderDetailOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderDetailOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetailOnAfterFetch");
span.setAttribute("outsystems.function.key", "65212b75-37bf-464b-a298-f092831ff645");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderDetailOnAfterFetch");
callContext = controller.callContext(callContext);
var call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetFirstApproverList
var result = controller.getFirstApproverList$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// Execute Action: Call_ZMXMIMMF_VISUALIZAR_SAL_ANT
model.flush();
return controller.call_ZMXMIMMF_VISUALIZAR_SAL_ANT$ServerAction(function () {
var rec = new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
rec.pI_PEDIDOAttr = model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr;
return rec;
}(), callContext).then(function (value) {
call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar.value = value;
});
}).then(function () {
// l_ImportAnticipo = Call_ZMXMIMMF_VISUALIZAR_SAL_ANT.Response.PO_IMP_ANT
model.variables.l_ImportAnticipoVar = call_ZMXMIMMF_VISUALIZAR_SAL_ANTVar.value.responseOut.pO_IMP_ANTAttr;
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
_wb_InvoiceSAECUploadSendFilesCreditNote$Action(o_CreditNoteFilesListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFilesCreditNote", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFilesCreditNote");
span.setAttribute("outsystems.function.key", "7b55b17e-f21b-44d3-aebe-61e7b4fdb5b2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_InvoiceSAECUploadSendFilesCreditNote");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_InvoiceSAECUploadSendFilesCreditNote$vars"))());
vars.value.o_CreditNoteFilesListInLocal = o_CreditNoteFilesListIn.clone();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.creditNoteFilesListVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.creditNoteFilesListVar, vars.value.o_CreditNoteFilesListInLocal, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validateDatesInvoiceQttPEP$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "830c869f-d250-40d5-b1bd-37f67b46c6ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateDatesInvoiceQttPEP");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.localSelectedLinesIn, function (p) {
return ((p.isDateErrorAttr || p.isInvoiceErrorAttr) || p.isPEPErrorAttr);
}, callContext);

// DatesQuantityPEPError = notListFilter.FilteredList.Empty
model.variables.datesQuantityPEPErrorVar = (!(listFilterVar.value.filteredListOut.isEmpty));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesNotifyFileId", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesNotifyFileId");
span.setAttribute("outsystems.function.key", "88f77fed-c2f1-442b-85ea-ffafe3f2bd10");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesNotifyFileId");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.wb_BigUploadMultipleFilesNotifyFileId$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.filenameInLocal = filenameIn;
vars.value.mimeTypeInLocal = mimeTypeIn;
// Execute Action: CustomUploadOnFileChangeBigFile
controller._customUploadOnFileChangeBigFile$Action(function () {
var rec = new ST_1d6498da9105fbe815a7f766352917c0Structure();
rec.fileNameAttr = vars.value.filenameInLocal;
rec.fileMimeTypeAttr = vars.value.mimeTypeInLocal;
rec.fileBigFileIdAttr = vars.value.fileIdInLocal;
return rec;
}(), function () {
var rec = new ST_f9f8b40f5330871047e55e068d129447Structure();
rec.successAttr = true;
return rec;
}(), callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_ApproverOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_ApproverOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ApproverOnChanged");
span.setAttribute("outsystems.function.key", "98dc82bc-acd0-4324-b361-918f90f6e184");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_ApproverOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Dropdown_ApproverOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// firstUserIdentifier = TextToIdentifier
model.variables.firstUserIdentifierVar = OS$BuiltinFunctions.textToIdentifier(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr);
// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
} finally {
if(span) {
span.end();
}

}

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
span.setAttribute("outsystems.function.key", "ae242a84-6108-4d43-b55e-06b3e6a2a605");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RemoveOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.RemoveOnClick$vars"))());
vars.value.l_CurrentRowNumberInLocal = l_CurrentRowNumberIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ListRemove
OS$SystemActions.listRemove(model.variables.localSelectedLinesIn, vars.value.l_CurrentRowNumberInLocal, callContext);
return OS$Flow.executeSequence(function () {
if((model.variables.localSelectedLinesIn.isEmpty)) {
// Trigger Event: GoBackToStep2
return controller.goBackToStep2$Action(callContext);
} else {
// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
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
_debounceInvoiceQttOnDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DebounceInvoiceQttOnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceInvoiceQttOnDebounce");
span.setAttribute("outsystems.function.key", "b64e03d0-e062-4120-84cc-e17158284a0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DebounceInvoiceQttOnDebounce");
callContext = controller.callContext(callContext);
// Execute Action: ValidateFiles
controller._validateFiles$Action(callContext);
// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_validateFinal$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateFinal", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "b7c715c6-4ea5-4c50-b639-26581697da88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateFinal");
callContext = controller.callContext(callContext);
// WithDatesError = False
model.variables.withDatesErrorVar = false;
// WithQuantityError = False
model.variables.withQuantityErrorVar = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr)) {
// WithQuantityError = True
model.variables.withQuantityErrorVar = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
if((model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr)) {
// WithDatesError = True
model.variables.withDatesErrorVar = true;
}

localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// No user Approver
if((((((model.variables.aprovalProcessTypeIdIn) !== (ConectaProveedores_staticEntities_approvalProcessType.alternative)) || ((OS$BuiltinFunctions.toUpper(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr)) !== ("Q"))) && (model.variables.firstUserIdentifierVar === OS$BuiltinFunctions.nullTextIdentifier())))) {
// ApproverValid = False
model.variables.approverValidVar = false;
// ApproverErrorMessage = "Select one"
model.variables.approverErrorMessageVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("QVWWlOpI5UyBXWyTAlWjTQ#Value.335965538.1", "Select one");
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_calcInvoiceAmount$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CalcInvoiceAmount", function (span) {
if(span) {
span.setAttribute("code.function", "CalcInvoiceAmount");
span.setAttribute("outsystems.function.key", "b9ac141a-bb9c-4abd-b794-76cf0762166d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CalcInvoiceAmount");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.CalcInvoiceAmount$vars"))());
// total = 0
// Total = 0.0
vars.value.totalVar = (OS$DataTypes.Decimal.defaultValue);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Total = Total + LocalSelectedLines.Current.InvoiceQtt / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
vars.value.totalVar = vars.value.totalVar.plus(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).baseQuantityAttr)).times(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// l_SummaryRec.InvoicingAmount = TextToDecimal
model.variables.l_SummaryRecVar.invoicingAmountAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(vars.value.totalVar, 2, ".", ""));
// l_SummaryRec.Difference_FormSAE_Invoice_Amount = l_SummaryRec.InvoicingAmount - l_SummaryRec.PartialDeliveryAmount
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr = model.variables.l_SummaryRecVar.invoicingAmountAttr.minus(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr);
// l_SummaryRec.Difference_FormSAE_Invoice_Percent = If
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr = ((model.variables.l_SummaryRecVar.invoicingAmountAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))) ? (OS$BuiltinFunctions.integerToDecimal(0)) : (model.variables.l_SummaryRecVar.invoicingAmountAttr.minus(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr).div(model.variables.l_SummaryRecVar.invoicingAmountAttr).times(OS$BuiltinFunctions.integerToDecimal(100))));
// l_SummaryRec.Difference_FormSAE_Invoice_Percent = TextToDecimal
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr, 2, ".", ""));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_createFolioOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CreateFolioOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CreateFolioOnClick");
span.setAttribute("outsystems.function.key", "bc2fe3b9-6640-41bb-a09f-91a7ab7afd99");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CreateFolioOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var communicationExceptionVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var folioCreateVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ValidateFinal
controller._validateFinal$Action(callContext);
// With Validation Error
return OS$Flow.executeSequence(function () {
if((((((model.variables.withFilesErrorVar || model.variables.datesQuantityPEPErrorVar) || model.variables.withDatesErrorVar) || model.variables.withQuantityErrorVar) || model.variables.maxAmountErrorVar))) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pYNoBvF+AkOsmYm6KzQ0Nw#Message.-1008290854.1", "It was not possible to create the Folio, please review introduced data"), /*Error*/ 3);
} else {
// Execute Action: FolioCreate
model.flush();
return controller.folioCreate$ServerAction(model.variables.localSelectedLinesIn, model.variables.i_OrderIdIn, model.variables.firstUserIdentifierVar, model.variables.commentsVar, model.variables.invoiceExtendedToCreateVar, model.variables.filesListExtraVar, model.variables.filesListVar, model.variables.invoiceToCreateVar.idAttr, model.variables.invoiceForeignToCreateVar, ((((model.variables.aprovalProcessTypeIdIn === ConectaProveedores_staticEntities_approvalProcessType.alternative) || (OS$BuiltinFunctions.toUpper(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr) === "Q"))) ? (ConectaProveedores_staticEntities_approvalProcessType.alternative) : (ConectaProveedores_staticEntities_approvalProcessType.normal)), new RC_1c2482ce6cd4b83ca44ec0510b231d44(), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.l_SummaryRecVar, new RC_45d2d2c3c5fe5caa10fa5e20326622ac(), function (source, target) {
target.amountDeliveredAttr = source.amountDeliveredAttr;
target.amountLeftAttr = source.amountLeftAttr;
target.currencyAttr = source.currencyAttr;
target.difference_FormSAE_Invoice_AmountAttr = source.difference_FormSAE_Invoice_AmountAttr;
target.difference_FormSAE_Invoice_PercentAttr = source.difference_FormSAE_Invoice_PercentAttr;
target.invoicingAmountAttr = source.invoicingAmountAttr;
target.partialDeliveryAmountAttr = source.partialDeliveryAmountAttr;
target.percentageDeliveredAttr = source.percentageDeliveredAttr;
target.totalAmountAttr = source.totalAmountAttr;
return target;
}), false, 0, model.variables.orderAccConceptsIdToCreateVar, model.variables.creditNoteFilesListVar, model.variables.l_ImportAnticipoVar, model.variables.l_IsNationalVar, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
folioCreateVar.value = value;
}).then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}).then(function () {
if(((folioCreateVar.value.errorMsgOut === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VAS9lkUZG0yw2+LpRf6gww#Message.68060425.1", "Folio") + " ") + folioCreateVar.value.o_FolioNameOut) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VAS9lkUZG0yw2+LpRf6gww#Message.664062632.1", "was successfully created.")), /*Success*/ 1);
// Destination: /ConectaProveedores/FolioSAE_Proveedor
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "FolioSAE_Proveedor", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(folioCreateVar.value.errorMsgOut, /*Error*/ 3);
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_FolioCreate.CreateFolioOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: CommunicationException
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.CommunicationException)) {
OS$Logger.error(null, ex, null, null, 1);
communicationExceptionVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("CommunicationException", function (span) {
if(span) {
span.setAttribute("code.function", "CommunicationException");
span.setAttribute("outsystems.function.key", "537fd9ec-5a60-4589-aec4-d69285a2ed86");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5VhW8hzMv0GxwwuMiH8a+g#Message.-1991744483.1", "There was a problem communicating with the server. Please try again or contact your administrator"), /*Error*/ 3);
return OS$Flow.returnAsync();

});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "2cc1ac27-e7b0-4e6f-b3d2-4d550f495719");
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
_validateFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ValidateFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFiles");
span.setAttribute("outsystems.function.key", "c3add3cb-03bc-4f87-a289-579980368739");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ValidateFiles");
callContext = controller.callContext(callContext);
// 2 Files?
if(((((model.variables.filesListVar.length === 2) && model.variables.l_IsNationalVar) || (model.variables.filesListVar.length === 1)))) {
// WithFilesError = False
model.variables.withFilesErrorVar = false;
// skip
if((!((!(model.variables.getSettingsDataAct.isActiveAmountValidationOut))))) {
if((model.variables.l_IsNationalVar)) {
if(((((model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.currencyIdAttr === ConectaProveedores_staticEntities_currency.mXN)) ? (((model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.minus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.plus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)))))))) : (((model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.minus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(model.variables.invoiceExtendedToCreateVar.subtotalAttr.plus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut))))))))))) {
OS$FeedbackMessageService.showFeedbackMessage(((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("p4uPmof6QkCUeLUVT0HTeg#Message.634980261.1", "The value on the invoice is different from the value on the folio:") + " ") + OS$BuiltinFunctions.formatDecimal(model.variables.invoiceExtendedToCreateVar.subtotalAttr, 2, ".", ",")), /*Error*/ 3);
// WithFilesError = True
model.variables.withFilesErrorVar = true;
}

} else {
// ALIGN
if(((((model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.currencyIdAttr === ConectaProveedores_staticEntities_currency.mXN)) ? (((model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).minus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).plus(model.variables.getSettingsDataAct.o_NationalCurrencyMarginOut)))))))) : (((model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut.equals(OS$BuiltinFunctions.integerToDecimal((-1)))) ? (false) : ((!((model.variables.l_SummaryRecVar.invoicingAmountAttr.gte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).minus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut)) && model.variables.l_SummaryRecVar.invoicingAmountAttr.lte(OS$BuiltinFunctions.textToDecimal(model.variables.invoiceForeignToCreateVar.totalAmountAttr).plus(model.variables.getSettingsDataAct.o_ForeignCurrencyMarginOut))))))))))) {
OS$FeedbackMessageService.showFeedbackMessage(((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BbspU77PaUm2hcnceGojJw#Message.634980261.1", "The value on the invoice is different from the value on the folio:") + " ") + model.variables.invoiceForeignToCreateVar.totalAmountAttr), /*Error*/ 3);
// WithFilesError = True
model.variables.withFilesErrorVar = true;
}

}

}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadMultipleFilesEventstartProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventstartProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventstartProcess");
span.setAttribute("outsystems.function.key", "d75f31c6-9ffa-434a-aab7-4a3c080bafdf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesEventstartProcess");
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
_selectDeliveryDate$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SelectDeliveryDate", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDeliveryDate");
span.setAttribute("outsystems.function.key", "d7d7eeb0-6ae3-4e5a-b850-d530fd69dda3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SelectDeliveryDate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.SelectDeliveryDate$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// LocalSelectedLines.Current.DeliveryDate = SelectedDateTime
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr = OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal);
// LocalSelectedLines.Current.IsDateError = If
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isDateErrorAttr = ((!(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (false) : (true));
// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadMultipleFilesEventEndProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventEndProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventEndProcess");
span.setAttribute("outsystems.function.key", "de732331-7ada-4f93-8100-abfec2bd02e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadMultipleFilesEventEndProcess");
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
_input_PartialDeliveryAmountOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "e7960f1f-09ba-4ecf-a447-c75604c17e6a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_PartialDeliveryAmountOnChange");
callContext = controller.callContext(callContext);
// Smaller then 0?
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.lt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Set Zero
// l_SummaryRec.PartialDeliveryAmount = 0
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.gt(model.variables.l_SummaryRecVar.maxAlowedAttr))) {
// Set Max
// l_SummaryRec.PartialDeliveryAmount = l_SummaryRec.MaxAlowed
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = model.variables.l_SummaryRecVar.maxAlowedAttr;
}

// MaxAmountError = False
model.variables.maxAmountErrorVar = false;
// Input_PartialDeliveryAmount.Valid = True
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validAttr = true;
// Pass Max amount 
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.gt(model.variables.l_SummaryRecVar.amountLeftAttr))) {
// MaxAmountError = True
model.variables.maxAmountErrorVar = true;
// Input_PartialDeliveryAmount.Valid = False
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validAttr = false;
// Input_PartialDeliveryAmount.ValidationMessage = "Value not allowed"
model.widgets.get(idService.getId("Input_PartialDeliveryAmount")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HEb8FWE43kudEvxx4VeQyQ#Value.-1625513716.1", "Value not allowed");
}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "f1fbc3b1-e8db-4cd4-b42d-6a4de9de8719");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.DatePickerOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// DeliveryDate = SelectedDateTime
model.variables.deliveryDateVar = OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.DeliveryDate = DeliveryDate
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).deliveryDateAttr = model.variables.deliveryDateVar;
// LocalSelectedLines.Current.IsDateError = SelectedDateTime = NullDate
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isDateErrorAttr = vars.value.selectedDateTimeInLocal.equals(OS$BuiltinFunctions.nullDate());
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_prorate$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Prorate", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "f5f63f68-dab4-49f4-837d-114e80e58aaf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Prorate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Prorate$vars"))());
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Total = 0
vars.value.totalVar = OS$BuiltinFunctions.integerToDecimal(0);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Total = Total + LocalSelectedLines.Current.RemainingQttTotal / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
vars.value.totalVar = vars.value.totalVar.plus(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttTotalAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).baseQuantityAttr)).times(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Perc = l_SummaryRec.PartialDeliveryAmount / Total
vars.value.percVar = model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.div(vars.value.totalVar);
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// setError
// LocalSelectedLines.Current.InvoiceQtt = TextToDecimal
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr = OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr.times(vars.value.percVar), 3, ".", ""));
// LocalSelectedLines.Current.IsInvoiceError = TextToDecimal > LocalSelectedLines.Current.RemainingQttTotal or TextToDecimal = 0
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).isInvoiceErrorAttr = (OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr)).gt(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr) || OS$BuiltinFunctions.textToDecimal(OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).invoiceQttAttr)).equals(OS$BuiltinFunctions.integerToDecimal(0)));
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// partial = 0
if((model.variables.l_SummaryRecVar.partialDeliveryAmountAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) {
// WithProrata = False
model.variables.withProrataVar = false;
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// Set Original value
// LocalSelectedLines.Current.RemainingQtt = LocalSelectedLines.Current.RemainingQttTotal
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr = model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

}

// Execute Action: CalcInvoiceAmount
controller._calcInvoiceAmount$Action(callContext);
// Execute Action: ValidateDatesInvoiceQttPEP
controller._validateDatesInvoiceQttPEP$Action(callContext);
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
span.setAttribute("outsystems.function.key", "fc58fa91-3dfe-4da4-ae9b-f72b23033e71");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Comments = ""
model.variables.commentsVar = "";
// Foreach LocalSelectedLines
callContext.iterationContext.registerIterationStart(model.variables.localSelectedLinesIn);
try {var localSelectedLinesIterator = callContext.iterationContext.getIterator(model.variables.localSelectedLinesIn);
var localSelectedLinesIndex = 0;
while (((localSelectedLinesIndex < model.variables.localSelectedLinesIn.length))) {
localSelectedLinesIterator.currentRowNumber = localSelectedLinesIndex;
// LocalSelectedLines.Current.RemainingQttTotal = LocalSelectedLines.Current.RemainingQtt
model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttTotalAttr = model.variables.localSelectedLinesIn.getItem(localSelectedLinesIndex.valueOf()).remainingQttAttr;
localSelectedLinesIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.localSelectedLinesIn);
}

// Refresh Query: GetOrderDetail
var result = controller.getOrderDetail$AggrRefresh(999999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSummary
var result = controller.getSummary$DataActRefresh(callContext);
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "00d3305c-3378-4893-a8cd-c70469ff5763");
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

getSummaryOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSummaryOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSummaryOnAfterFetch");
span.setAttribute("outsystems.function.key", "054f5985-e318-4a40-a4cb-8d2ce2dd6492");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSummaryOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_InvoiceSAECUploadSendInvoiceType$Action(orderAccConceptsID_ToSaveIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendInvoiceType__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendInvoiceType");
span.setAttribute("outsystems.function.key", "05821422-b0e3-4aac-b71d-8db63ff76b64");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_InvoiceSAECUploadSendInvoiceType$Action, callContext, orderAccConceptsID_ToSaveIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_InvoiceQttOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_InvoiceQttOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_InvoiceQttOnChange");
span.setAttribute("outsystems.function.key", "28951365-8ca1-4437-aa5f-1366caf0d662");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_InvoiceQttOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

debouncePEPOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebouncePEPOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebouncePEPOnDebounce");
span.setAttribute("outsystems.function.key", "2a508eca-db3e-48b1-bbb5-6fde19158908");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._debouncePEPOnDebounce$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_InvoiceSAECUploadSendFiles$Action(o_FilesListIn, o_InvoiceIn, o_InvoiceForeignIn, isNationalIn, o_InvoiceExtendedIn, i_IsRemoveIn, o_CreditNoteFilesListIn, o_CreditNoteInvoiceIn, o_NeedsCNIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFiles");
span.setAttribute("outsystems.function.key", "2f5f4256-1385-4994-8c01-e1d87d2c6c69");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_InvoiceSAECUploadSendFiles$Action, callContext, o_FilesListIn, o_InvoiceIn, o_InvoiceForeignIn, isNationalIn, o_InvoiceExtendedIn, i_IsRemoveIn, o_CreditNoteFilesListIn, o_CreditNoteInvoiceIn, o_NeedsCNIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeFromList$Action(indexIn, isExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "30b2f5c3-39dc-4b6f-b463-1439f2188c81");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, indexIn, isExtraIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_SupportSAECUploadSendFilesExtra$Action(o_FilesListExtraIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SupportSAECUploadSendFilesExtra__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SupportSAECUploadSendFilesExtra");
span.setAttribute("outsystems.function.key", "313fc81e-a8f7-4e8c-8b63-357dc3ef8376");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_SupportSAECUploadSendFilesExtra$Action, callContext, o_FilesListExtraIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

customUploadOnFileChangeBigFile$Action(fileIn, errorIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CustomUploadOnFileChangeBigFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CustomUploadOnFileChangeBigFile");
span.setAttribute("outsystems.function.key", "3aa2e272-cecb-444c-b9cd-52e80228b0d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._customUploadOnFileChangeBigFile$Action, callContext, fileIn, errorIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "47092510-c5b5-4df6-a4b3-48e35a55beb5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._tabsOnTabChange$Action, callContext, activeTabIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderDetailOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderDetailOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderDetailOnAfterFetch");
span.setAttribute("outsystems.function.key", "65212b75-37bf-464b-a298-f092831ff645");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderDetailOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_InvoiceSAECUploadSendFilesCreditNote$Action(o_CreditNoteFilesListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_InvoiceSAECUploadSendFilesCreditNote__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_InvoiceSAECUploadSendFilesCreditNote");
span.setAttribute("outsystems.function.key", "7b55b17e-f21b-44d3-aebe-61e7b4fdb5b2");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_InvoiceSAECUploadSendFilesCreditNote$Action, callContext, o_CreditNoteFilesListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validateDatesInvoiceQttPEP$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateDatesInvoiceQttPEP__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateDatesInvoiceQttPEP");
span.setAttribute("outsystems.function.key", "830c869f-d250-40d5-b1bd-37f67b46c6ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateDatesInvoiceQttPEP$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesNotifyFileId__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesNotifyFileId");
span.setAttribute("outsystems.function.key", "88f77fed-c2f1-442b-85ea-ffafe3f2bd10");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesNotifyFileId$Action, callContext, fileIdIn, filenameIn, mimeTypeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_ApproverOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_ApproverOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ApproverOnChanged");
span.setAttribute("outsystems.function.key", "98dc82bc-acd0-4324-b361-918f90f6e184");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_ApproverOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeOnClick$Action(l_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveOnClick");
span.setAttribute("outsystems.function.key", "ae242a84-6108-4d43-b55e-06b3e6a2a605");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._removeOnClick$Action, callContext, l_CurrentRowNumberIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

debounceInvoiceQttOnDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DebounceInvoiceQttOnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DebounceInvoiceQttOnDebounce");
span.setAttribute("outsystems.function.key", "b64e03d0-e062-4120-84cc-e17158284a0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._debounceInvoiceQttOnDebounce$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

validateFinal$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateFinal__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFinal");
span.setAttribute("outsystems.function.key", "b7c715c6-4ea5-4c50-b639-26581697da88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateFinal$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

calcInvoiceAmount$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CalcInvoiceAmount__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CalcInvoiceAmount");
span.setAttribute("outsystems.function.key", "b9ac141a-bb9c-4abd-b794-76cf0762166d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._calcInvoiceAmount$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

createFolioOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CreateFolioOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CreateFolioOnClick");
span.setAttribute("outsystems.function.key", "bc2fe3b9-6640-41bb-a09f-91a7ab7afd99");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._createFolioOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

validateFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ValidateFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFiles");
span.setAttribute("outsystems.function.key", "c3add3cb-03bc-4f87-a289-579980368739");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validateFiles$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadMultipleFilesEventstartProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventstartProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventstartProcess");
span.setAttribute("outsystems.function.key", "d75f31c6-9ffa-434a-aab7-4a3c080bafdf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesEventstartProcess$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

selectDeliveryDate$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SelectDeliveryDate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SelectDeliveryDate");
span.setAttribute("outsystems.function.key", "d7d7eeb0-6ae3-4e5a-b850-d530fd69dda3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._selectDeliveryDate$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadMultipleFilesEventEndProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadMultipleFilesEventEndProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadMultipleFilesEventEndProcess");
span.setAttribute("outsystems.function.key", "de732331-7ada-4f93-8100-abfec2bd02e4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadMultipleFilesEventEndProcess$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_PartialDeliveryAmountOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_PartialDeliveryAmountOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_PartialDeliveryAmountOnChange");
span.setAttribute("outsystems.function.key", "e7960f1f-09ba-4ecf-a447-c75604c17e6a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_PartialDeliveryAmountOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

datePickerOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerOnSelected");
span.setAttribute("outsystems.function.key", "f1fbc3b1-e8db-4cd4-b42d-6a4de9de8719");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

prorate$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Prorate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Prorate");
span.setAttribute("outsystems.function.key", "f5f63f68-dab4-49f4-837d-114e80e58aaf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._prorate$Action, callContext);
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
span.setAttribute("outsystems.function.key", "fc58fa91-3dfe-4da4-ae9b-f72b23033e71");
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

get goBackToStep2$Action() {if(!(this.hasOwnProperty("_goBackToStep2$Action"))) {
this._goBackToStep2$Action = function () {
return Promise.resolve();
};
}

return this._goBackToStep2$Action;
}set goBackToStep2$Action(value) {this._goBackToStep2$Action = value;
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate$ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT", [{
name: "Response",
attrName: "responseOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_cbb2055cf19f871ed882642269bd43ceStructure();
},
complexType: ST_cbb2055cf19f871ed882642269bd43ceStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate$ActionFolioCreate", [{
name: "o_FolioName",
attrName: "o_FolioNameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
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

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_InvoiceSAECUploadSendInvoiceType$vars", [{
name: "OrderAccConceptsID_ToSave",
attrName: "orderAccConceptsID_ToSaveInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_InvoiceSAECUploadSendFiles$vars", [{
name: "o_FilesList",
attrName: "o_FilesListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}, {
name: "o_Invoice",
attrName: "o_InvoiceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "o_InvoiceForeign",
attrName: "o_InvoiceForeignInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_6f620840109ac6f721328b723ec0152cStructure();
},
complexType: ST_6f620840109ac6f721328b723ec0152cStructure
}, {
name: "IsNational",
attrName: "isNationalInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_InvoiceExtended",
attrName: "o_InvoiceExtendedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_f81a3d226103fd013068b8763798067aEntityRecord();
},
complexType: EN_f81a3d226103fd013068b8763798067aEntityRecord
}, {
name: "i_IsRemove",
attrName: "i_IsRemoveInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_CreditNoteFilesList",
attrName: "o_CreditNoteFilesListInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}, {
name: "o_CreditNoteInvoice",
attrName: "o_CreditNoteInvoiceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
},
complexType: EN_d1d0320db36efbb094ad0082361435a0EntityRecord
}, {
name: "o_NeedsCN",
attrName: "o_NeedsCNInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.RemoveFromList$vars", [{
name: "Index",
attrName: "indexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "IsExtra",
attrName: "isExtraInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_SupportSAECUploadSendFilesExtra$vars", [{
name: "o_FilesListExtra",
attrName: "o_FilesListExtraInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.CustomUploadOnFileChangeBigFile$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Wb_InvoiceSAECUploadSendFilesCreditNote$vars", [{
name: "o_CreditNoteFilesList",
attrName: "o_CreditNoteFilesListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.wb_BigUploadMultipleFilesNotifyFileId$vars", [{
name: "FileId",
attrName: "fileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "Filename",
attrName: "filenameInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "MimeType",
attrName: "mimeTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Dropdown_ApproverOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.RemoveOnClick$vars", [{
name: "l_CurrentRowNumber",
attrName: "l_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.CalcInvoiceAmount$vars", [{
name: "Total",
attrName: "totalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.SelectDeliveryDate$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.DatePickerOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.Prorate$vars", [{
name: "Total",
attrName: "totalVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}, {
name: "Perc",
attrName: "percVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Decimal,
defaultValue: function () {
return OS$DataTypes.Decimal.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


