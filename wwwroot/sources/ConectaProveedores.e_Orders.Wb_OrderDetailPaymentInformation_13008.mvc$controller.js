import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, Transitions as OS$Transitions, Navigation as OS$Navigation, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { SE_accountingDataType as ConectaProveedores_staticEntities_accountingDataType, SE_contractFileType as ConectaProveedores_staticEntities_contractFileType, SE_contractStatus as ConectaProveedores_staticEntities_contractStatus, SE_orderStatus as ConectaProveedores_staticEntities_orderStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord, RC_dd1ef552e394be88b7a9660ce51d9447, ST_d9010d115c38fb059bccbc457fe11b18Structure, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, EN_17538b35348920159ed0ee43b3fb2b50EntityRecord, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSpecialApprovals$AggrRefresh: 0,
getAccountingDataTypes$AggrRefresh: 0,
getAdvancedPaymentTypes$AggrRefresh: 0,
getSpecialPostDeliveryAuthorizations$AggrRefresh: 0,
getContractStatuses$AggrRefresh: 0,
getProjectAssetServiceOtro$AggrRefresh: 0,
getSuppliers$AggrRefresh: -1,
getBusinessValueSubcategoriesByCategoryId$AggrRefresh: 1,
getSupplierByRequisition$AggrRefresh: -1,
getOrderMainById$AggrRefresh: 0,
getProjectAssetServices$AggrRefresh: 0,
getInvoiceUsages$AggrRefresh: 0,
getOrderRetentionTypes$AggrRefresh: 0,
getBusinessValueCategories$AggrRefresh: 0,
getPaymentTerms$AggrRefresh: 0,
getInsuranceTypes$AggrRefresh: 0,
getFrequencies$AggrRefresh: 0,
getPaymentOptions$AggrRefresh: 1,
getPaymentWays$AggrRefresh: 1,
getOrderMainItemsByOrderMainId$AggrRefresh: 0,
getCurrencies$AggrRefresh: 0,
getDepositTypes$AggrRefresh: 0,
getPaymentMethods$AggrRefresh: 0,
getRejectComment$AggrRefresh: -1,
getOrderFilesList$DataActRefresh: 0,
getPaymentTermSpecial$DataActRefresh: 0,
getAccountingData$DataActRefresh: 0,
getOrderContractData$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getSpecialApprovals$AggrRefresh: [],
getAccountingDataTypes$AggrRefresh: [],
getAdvancedPaymentTypes$AggrRefresh: [],
getSpecialPostDeliveryAuthorizations$AggrRefresh: [],
getContractStatuses$AggrRefresh: [],
getProjectAssetServiceOtro$AggrRefresh: [],
getSuppliers$AggrRefresh: [],
getBusinessValueSubcategoriesByCategoryId$AggrRefresh: [],
getSupplierByRequisition$AggrRefresh: [],
getOrderMainById$AggrRefresh: ["getSuppliers$AggrRefresh", "getBusinessValueSubcategoriesByCategoryId$AggrRefresh", "getSupplierByRequisition$AggrRefresh", "getPaymentOptions$AggrRefresh", "getPaymentWays$AggrRefresh"],
getProjectAssetServices$AggrRefresh: [],
getInvoiceUsages$AggrRefresh: [],
getOrderRetentionTypes$AggrRefresh: [],
getBusinessValueCategories$AggrRefresh: [],
getPaymentTerms$AggrRefresh: [],
getInsuranceTypes$AggrRefresh: [],
getFrequencies$AggrRefresh: [],
getPaymentOptions$AggrRefresh: [],
getPaymentWays$AggrRefresh: [],
getOrderMainItemsByOrderMainId$AggrRefresh: [],
getCurrencies$AggrRefresh: [],
getDepositTypes$AggrRefresh: [],
getPaymentMethods$AggrRefresh: [],
getRejectComment$AggrRefresh: [],
getOrderFilesList$DataActRefresh: [],
getPaymentTermSpecial$DataActRefresh: [],
getAccountingData$DataActRefresh: [],
getOrderContractData$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
saveOrderDetail$ServerAction(orderMainIn, orderDetailIn, orderMainItemListIn, orderFilesIn, orderAccountingIn, orderAccConcept_EstimEqualAgIn, orderAccConcept_CreditNoteIn, orderAccConcept_VoucherIn, orderAccConcept_FiniquitoIn, orderAccConcept_AnticipoIn, orderRequestFilesIn, isFinishIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveOrderDetail", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOrderDetail");
span.setAttribute("outsystems.function.key", "ba84f7cd-e8b0-45d8-abff-3522d8c21e17");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
OrderMain: OS$DataConversion.ServerDataConverter.to(orderMainIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderDetail: OS$DataConversion.ServerDataConverter.to(orderDetailIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderMainItemList: OS$DataConversion.ServerDataConverter.to(orderMainItemListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
OrderFiles: OS$DataConversion.ServerDataConverter.to(orderFilesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
OrderAccounting: OS$DataConversion.ServerDataConverter.to(orderAccountingIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderAccConcept_EstimEqualAg: OS$DataConversion.ServerDataConverter.to(orderAccConcept_EstimEqualAgIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderAccConcept_CreditNote: OS$DataConversion.ServerDataConverter.to(orderAccConcept_CreditNoteIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderAccConcept_Voucher: OS$DataConversion.ServerDataConverter.to(orderAccConcept_VoucherIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderAccConcept_Finiquito: OS$DataConversion.ServerDataConverter.to(orderAccConcept_FiniquitoIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderAccConcept_Anticipo: OS$DataConversion.ServerDataConverter.to(orderAccConcept_AnticipoIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
OrderRequestFiles: OS$DataConversion.ServerDataConverter.to(orderRequestFilesIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
}),
IsFinish: OS$DataConversion.ServerDataConverter.to(isFinishIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SaveOrderDetail", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ActionSaveOrderDetail", "8bUUYXRDhmNPVkKX04isBA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008$ActionSaveOrderDetail"))();
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
getIsUserCxP$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetIsUserCxP", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsUserCxP");
span.setAttribute("outsystems.function.key", "7e96f822-fed7-41be-8321-3332ee6ef119");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("GetIsUserCxP", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ActionGetIsUserCxP", "fta9NfmxtZhlAN71d2CU6w", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008$ActionGetIsUserCxP"))();
executeServerActionResult.o_ValueOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Value, OS$DataTypes.DataTypes.Boolean);
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
approvRejectOrder$ServerAction(i_OrderIdIn, i_OrderApprovalLevelIdIn, i_IsApproveIn, i_ReasonIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovRejectOrder", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovRejectOrder");
span.setAttribute("outsystems.function.key", "f73279b7-e725-4093-b0d6-b5e1b430d251");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderId: OS$DataConversion.ServerDataConverter.to(i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_OrderApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_OrderApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Reason: OS$DataConversion.ServerDataConverter.to(i_ReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApprovRejectOrder", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ActionApprovRejectOrder", "XUq3ADSWmTtz946jlce+mA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008$ActionApprovRejectOrder"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
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
saveContractFile$ServerAction(i_OrderIdIn, i_ContractFileIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveContractFile", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractFile");
span.setAttribute("outsystems.function.key", "3a2b13e2-28c3-4322-8365-95f6a9941c23");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_OrderId: OS$DataConversion.ServerDataConverter.to(i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_ContractFile: OS$DataConversion.ServerDataConverter.to(i_ContractFileIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SaveContractFile", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ActionSaveContractFile", "Z8yqXl5OlSHTHLD8JQVLAQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getSpecialApprovals$AggrRefresh() {if(!(this.hasOwnProperty("_getSpecialApprovals$AggrRefresh"))) {
this._getSpecialApprovals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSpecialApprovals", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetSpecialApprovals", "vnJOYyFcujOLSxybVuL+qg", maxRecords, startIndex, function (b) {
model.variables.getSpecialApprovalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialApprovalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialApprovalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialApprovals", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovals");
span.setAttribute("outsystems.function.key", "010a0a5a-28cb-48b7-ba30-5a6540e879ab");
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

return this._getSpecialApprovals$AggrRefresh;
}set getSpecialApprovals$AggrRefresh(value) {this._getSpecialApprovals$AggrRefresh = value;
}

get getAccountingDataTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountingDataTypes$AggrRefresh"))) {
this._getAccountingDataTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountingDataTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetAccountingDataTypes", "GSdIV_2QnHAjbJAYrKgrwA", maxRecords, startIndex, function (b) {
model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingDataTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingDataTypes");
span.setAttribute("outsystems.function.key", "07d0d94e-0d14-4e08-9742-e36489f73f3f");
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

return this._getAccountingDataTypes$AggrRefresh;
}set getAccountingDataTypes$AggrRefresh(value) {this._getAccountingDataTypes$AggrRefresh = value;
}

get getAdvancedPaymentTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAdvancedPaymentTypes$AggrRefresh"))) {
this._getAdvancedPaymentTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAdvancedPaymentTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetAdvancedPaymentTypes", "hoLIYf+Dyd+VynjpRubgCg", maxRecords, startIndex, function (b) {
model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAdvancedPaymentTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAdvancedPaymentTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAdvancedPaymentTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAdvancedPaymentTypes");
span.setAttribute("outsystems.function.key", "1397094d-879d-4d09-b122-b15110f6ccb0");
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

return this._getAdvancedPaymentTypes$AggrRefresh;
}set getAdvancedPaymentTypes$AggrRefresh(value) {this._getAdvancedPaymentTypes$AggrRefresh = value;
}

get getSpecialPostDeliveryAuthorizations$AggrRefresh() {if(!(this.hasOwnProperty("_getSpecialPostDeliveryAuthorizations$AggrRefresh"))) {
this._getSpecialPostDeliveryAuthorizations$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSpecialPostDeliveryAuthorizations", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetSpecialPostDeliveryAuthorizations", "Y+TV7QGweLMoZLG_kLPK+w", maxRecords, startIndex, function (b) {
model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialPostDeliveryAuthorizationsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialPostDeliveryAuthorizationsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialPostDeliveryAuthorizations", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialPostDeliveryAuthorizations");
span.setAttribute("outsystems.function.key", "3219dddd-d718-4df6-ac8a-fc801cd0dcd8");
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

return this._getSpecialPostDeliveryAuthorizations$AggrRefresh;
}set getSpecialPostDeliveryAuthorizations$AggrRefresh(value) {this._getSpecialPostDeliveryAuthorizations$AggrRefresh = value;
}

get getContractStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getContractStatuses$AggrRefresh"))) {
this._getContractStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetContractStatuses", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetContractStatuses", "dl5W+NgcsOF6re7ASrOsKA", maxRecords, startIndex, function (b) {
model.variables.getContractStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getContractStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getContractStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetContractStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetContractStatuses");
span.setAttribute("outsystems.function.key", "36e0f5a0-58cb-4082-8f47-378f0ca3b7bd");
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

return this._getContractStatuses$AggrRefresh;
}set getContractStatuses$AggrRefresh(value) {this._getContractStatuses$AggrRefresh = value;
}

get getProjectAssetServiceOtro$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServiceOtro$AggrRefresh"))) {
this._getProjectAssetServiceOtro$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServiceOtro", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetProjectAssetServiceOtro", "z8ETxh4PZYxYihpoWu9+nA", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServiceOtroAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServiceOtroAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServiceOtro", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServiceOtro");
span.setAttribute("outsystems.function.key", "4c3779e3-1efb-477b-8374-f65b3a47711c");
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

return this._getProjectAssetServiceOtro$AggrRefresh;
}set getProjectAssetServiceOtro$AggrRefresh(value) {this._getProjectAssetServiceOtro$AggrRefresh = value;
}

get getSuppliers$AggrRefresh() {if(!(this.hasOwnProperty("_getSuppliers$AggrRefresh"))) {
this._getSuppliers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSuppliers", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetSuppliers", "MarLzvC0Ak57cuL9zvu4SQ", maxRecords, startIndex, function (b) {
model.variables.getSuppliersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSuppliersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSuppliersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "GetSuppliers");
span.setAttribute("outsystems.function.key", "5823e2f7-8f94-4f37-924c-ecf6999b00f0");
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

return this._getSuppliers$AggrRefresh;
}set getSuppliers$AggrRefresh(value) {this._getSuppliers$AggrRefresh = value;
}

get getBusinessValueSubcategoriesByCategoryId$AggrRefresh() {if(!(this.hasOwnProperty("_getBusinessValueSubcategoriesByCategoryId$AggrRefresh"))) {
this._getBusinessValueSubcategoriesByCategoryId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "OPm1pOj_KeAJWjXogYPfSQ", maxRecords, startIndex, function (b) {
model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBusinessValueSubcategoriesByCategoryId", function (span) {
if(span) {
span.setAttribute("code.function", "GetBusinessValueSubcategoriesByCategoryId");
span.setAttribute("outsystems.function.key", "699f98d7-717c-4b8c-9f65-20a48ae40539");
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

return this._getBusinessValueSubcategoriesByCategoryId$AggrRefresh;
}set getBusinessValueSubcategoriesByCategoryId$AggrRefresh(value) {this._getBusinessValueSubcategoriesByCategoryId$AggrRefresh = value;
}

get getSupplierByRequisition$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierByRequisition$AggrRefresh"))) {
this._getSupplierByRequisition$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierByRequisition", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetSupplierByRequisition", "H3U5Elt6W9ibSLwdPH1HvQ", maxRecords, startIndex, function (b) {
model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierByRequisitionAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierByRequisitionAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierByRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByRequisition");
span.setAttribute("outsystems.function.key", "8f8cf40f-8dcd-4e93-a6c7-0d528c2f2b15");
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

return this._getSupplierByRequisition$AggrRefresh;
}set getSupplierByRequisition$AggrRefresh(value) {this._getSupplierByRequisition$AggrRefresh = value;
}

get getOrderMainById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainById$AggrRefresh"))) {
this._getOrderMainById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainById", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetOrderMainById", "13fYgXR65HFVmrZ2ywJoHw", maxRecords, startIndex, function (b) {
model.variables.getOrderMainByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderMainByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainById", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainById");
span.setAttribute("outsystems.function.key", "9eac237a-8941-4026-a8cd-c7ff8d32b3ab");
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

return this._getOrderMainById$AggrRefresh;
}set getOrderMainById$AggrRefresh(value) {this._getOrderMainById$AggrRefresh = value;
}

get getProjectAssetServices$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServices$AggrRefresh"))) {
this._getProjectAssetServices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetProjectAssetServices", "QmIftqTsNkC++1frUcNFQw", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "9f55af31-8e1f-4a59-9e6d-7d2474207e91");
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

return this._getProjectAssetServices$AggrRefresh;
}set getProjectAssetServices$AggrRefresh(value) {this._getProjectAssetServices$AggrRefresh = value;
}

get getInvoiceUsages$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceUsages$AggrRefresh"))) {
this._getInvoiceUsages$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceUsages", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetInvoiceUsages", "9K4ozixnDaUYQeFRQ9_iQQ", maxRecords, startIndex, function (b) {
model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceUsagesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceUsagesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceUsages", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceUsages");
span.setAttribute("outsystems.function.key", "a2ed8707-6660-44f4-8b44-97cc48ca1c01");
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

return this._getInvoiceUsages$AggrRefresh;
}set getInvoiceUsages$AggrRefresh(value) {this._getInvoiceUsages$AggrRefresh = value;
}

get getOrderRetentionTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderRetentionTypes$AggrRefresh"))) {
this._getOrderRetentionTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderRetentionTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetOrderRetentionTypes", "iW+O1+oPx3_XDEqe18dTPQ", maxRecords, startIndex, function (b) {
model.variables.getOrderRetentionTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderRetentionTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderRetentionTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderRetentionTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRetentionTypes");
span.setAttribute("outsystems.function.key", "a3e01037-4021-4eb7-b22b-050f905c7bf1");
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

return this._getOrderRetentionTypes$AggrRefresh;
}set getOrderRetentionTypes$AggrRefresh(value) {this._getOrderRetentionTypes$AggrRefresh = value;
}

get getBusinessValueCategories$AggrRefresh() {if(!(this.hasOwnProperty("_getBusinessValueCategories$AggrRefresh"))) {
this._getBusinessValueCategories$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBusinessValueCategories", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetBusinessValueCategories", "3K1jXP9IJF_nMwQ5zqcRyg", maxRecords, startIndex, function (b) {
model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBusinessValueCategoriesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBusinessValueCategoriesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBusinessValueCategories", function (span) {
if(span) {
span.setAttribute("code.function", "GetBusinessValueCategories");
span.setAttribute("outsystems.function.key", "acb4618b-97a9-4ebe-a1ba-b98907051a6b");
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

return this._getBusinessValueCategories$AggrRefresh;
}set getBusinessValueCategories$AggrRefresh(value) {this._getBusinessValueCategories$AggrRefresh = value;
}

get getPaymentTerms$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentTerms$AggrRefresh"))) {
this._getPaymentTerms$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentTerms", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetPaymentTerms", "+6OhqwjTKpS9lXyr02rGqw", maxRecords, startIndex, function (b) {
model.variables.getPaymentTermsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTerms", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTerms");
span.setAttribute("outsystems.function.key", "ae6b2ff2-d8c0-4839-a62d-92e4a4992986");
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

return this._getPaymentTerms$AggrRefresh;
}set getPaymentTerms$AggrRefresh(value) {this._getPaymentTerms$AggrRefresh = value;
}

get getInsuranceTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getInsuranceTypes$AggrRefresh"))) {
this._getInsuranceTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInsuranceTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetInsuranceTypes", "0kLj6620Ezk+l1bssUC0yw", maxRecords, startIndex, function (b) {
model.variables.getInsuranceTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInsuranceTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInsuranceTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInsuranceTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetInsuranceTypes");
span.setAttribute("outsystems.function.key", "b30adab8-145b-482a-89d8-1ee30a63ac7b");
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

return this._getInsuranceTypes$AggrRefresh;
}set getInsuranceTypes$AggrRefresh(value) {this._getInsuranceTypes$AggrRefresh = value;
}

get getFrequencies$AggrRefresh() {if(!(this.hasOwnProperty("_getFrequencies$AggrRefresh"))) {
this._getFrequencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFrequencies", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetFrequencies", "AzjepyCQFApZH_95qbpcQw", maxRecords, startIndex, function (b) {
model.variables.getFrequenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFrequenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFrequenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFrequencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetFrequencies");
span.setAttribute("outsystems.function.key", "b47bebc7-1666-44fa-af90-1fb3531b0007");
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

return this._getFrequencies$AggrRefresh;
}set getFrequencies$AggrRefresh(value) {this._getFrequencies$AggrRefresh = value;
}

get getPaymentOptions$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentOptions$AggrRefresh"))) {
this._getPaymentOptions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentOptions", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetPaymentOptions", "KbZTSZCiHg_XFOVlv16P7g", maxRecords, startIndex, function (b) {
model.variables.getPaymentOptionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentOptionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentOptionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentOptions", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentOptions");
span.setAttribute("outsystems.function.key", "bbd3cae6-f305-41bd-a538-059968c43265");
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

return this._getPaymentOptions$AggrRefresh;
}set getPaymentOptions$AggrRefresh(value) {this._getPaymentOptions$AggrRefresh = value;
}

get getPaymentWays$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentWays$AggrRefresh"))) {
this._getPaymentWays$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentWays", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetPaymentWays", "ksLZ9v9fiVInXkNX+iiybw", maxRecords, startIndex, function (b) {
model.variables.getPaymentWaysAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentWaysAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentWaysAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentWays", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentWays");
span.setAttribute("outsystems.function.key", "bc44a5fb-e314-4f2d-b920-bc9993a3526b");
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

return this._getPaymentWays$AggrRefresh;
}set getPaymentWays$AggrRefresh(value) {this._getPaymentWays$AggrRefresh = value;
}

get getOrderMainItemsByOrderMainId$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainItemsByOrderMainId$AggrRefresh"))) {
this._getOrderMainItemsByOrderMainId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainItemsByOrderMainId", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetOrderMainItemsByOrderMainId", "AG6iWE4JO8TzLOOrh0+jgA", maxRecords, startIndex, function (b) {
model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainItemsByOrderMainIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainItemsByOrderMainIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainItemsByOrderMainId", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsByOrderMainId");
span.setAttribute("outsystems.function.key", "d23797dc-5d91-474e-a71c-03135b396e11");
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

return this._getOrderMainItemsByOrderMainId$AggrRefresh;
}set getOrderMainItemsByOrderMainId$AggrRefresh(value) {this._getOrderMainItemsByOrderMainId$AggrRefresh = value;
}

get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "d8435131-d5ad-4109-a5bd-2f6035904c0b");
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

return this._getCurrencies$AggrRefresh;
}set getCurrencies$AggrRefresh(value) {this._getCurrencies$AggrRefresh = value;
}

get getDepositTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getDepositTypes$AggrRefresh"))) {
this._getDepositTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetDepositTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetDepositTypes", "xNMlgKuJEXDYt59dj4cBjw", maxRecords, startIndex, function (b) {
model.variables.getDepositTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDepositTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDepositTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetDepositTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetDepositTypes");
span.setAttribute("outsystems.function.key", "e47b7137-3f66-4ebd-b247-ed577c090dd6");
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

return this._getDepositTypes$AggrRefresh;
}set getDepositTypes$AggrRefresh(value) {this._getDepositTypes$AggrRefresh = value;
}

get getPaymentMethods$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentMethods$AggrRefresh"))) {
this._getPaymentMethods$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentMethods", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetPaymentMethods", "npZ34hlfwoGQJHz7xDdwVw", maxRecords, startIndex, function (b) {
model.variables.getPaymentMethodsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentMethodsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentMethodsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentMethods", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentMethods");
span.setAttribute("outsystems.function.key", "e57e3ed6-36ab-4d88-b062-127aeb7037e9");
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

return this._getPaymentMethods$AggrRefresh;
}set getPaymentMethods$AggrRefresh(value) {this._getPaymentMethods$AggrRefresh = value;
}

get getRejectComment$AggrRefresh() {if(!(this.hasOwnProperty("_getRejectComment$AggrRefresh"))) {
this._getRejectComment$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRejectComment", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/ScreenDataSetGetRejectComment", "kSrfER1EWt2N4ouy+vFO3w", maxRecords, startIndex, function (b) {
model.variables.getRejectCommentAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRejectCommentAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRejectCommentAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRejectComment", function (span) {
if(span) {
span.setAttribute("code.function", "GetRejectComment");
span.setAttribute("outsystems.function.key", "fe12ab02-c38a-4d03-a4be-60dcf478dbcc");
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

return this._getRejectComment$AggrRefresh;
}set getRejectComment$AggrRefresh(value) {this._getRejectComment$AggrRefresh = value;
}

get getOrderFilesList$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderFilesList$DataActRefresh"))) {
this._getOrderFilesList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderFilesList", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/DataActionGetOrderFilesList", "iwVgKLM44h5Mf9QfrdV7Rg", function (b) {
model.variables.getOrderFilesListDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderFilesListDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderFilesListDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderFilesList", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderFilesList");
span.setAttribute("outsystems.function.key", "1929719e-01a7-45ed-8a8f-2618ca6b512c");
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

return this._getOrderFilesList$DataActRefresh;
}set getOrderFilesList$DataActRefresh(value) {this._getOrderFilesList$DataActRefresh = value;
}

get getPaymentTermSpecial$DataActRefresh() {if(!(this.hasOwnProperty("_getPaymentTermSpecial$DataActRefresh"))) {
this._getPaymentTermSpecial$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetPaymentTermSpecial", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/DataActionGetPaymentTermSpecial", "LgvHliYK+IN211qCoIq_3w", function (b) {
model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermSpecialDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermSpecialDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTermSpecial", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTermSpecial");
span.setAttribute("outsystems.function.key", "880dd03d-b54d-4b32-bddb-d9b72fcd7681");
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

return this._getPaymentTermSpecial$DataActRefresh;
}set getPaymentTermSpecial$DataActRefresh(value) {this._getPaymentTermSpecial$DataActRefresh = value;
}

get getAccountingData$DataActRefresh() {if(!(this.hasOwnProperty("_getAccountingData$DataActRefresh"))) {
this._getAccountingData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetAccountingData", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/DataActionGetAccountingData", "Zd_MWC__YbLGroLDgfQTbw", function (b) {
model.variables.getAccountingDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingData", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingData");
span.setAttribute("outsystems.function.key", "af65a441-b6c8-4417-99c0-4fe4c1e951c9");
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

return this._getAccountingData$DataActRefresh;
}set getAccountingData$DataActRefresh(value) {this._getAccountingData$DataActRefresh = value;
}

get getOrderContractData$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderContractData$DataActRefresh"))) {
this._getOrderContractData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderContractData", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation_13008/DataActionGetOrderContractData", "uLSW9dgaKiYPwp0+6Wa8ug", function (b) {
model.variables.getOrderContractDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderContractDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderContractDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getOrderContractDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderContractData", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderContractData");
span.setAttribute("outsystems.function.key", "dbee65ff-58a3-452c-a32e-1d32d51c5ac5");
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

return this._getOrderContractData$DataActRefresh;
}set getOrderContractData$DataActRefresh(value) {this._getOrderContractData$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSpecialApprovals$AggrRefresh", "getAccountingDataTypes$AggrRefresh", "getAdvancedPaymentTypes$AggrRefresh", "getSpecialPostDeliveryAuthorizations$AggrRefresh", "getContractStatuses$AggrRefresh", "getProjectAssetServiceOtro$AggrRefresh", "getSuppliers$AggrRefresh", "getBusinessValueSubcategoriesByCategoryId$AggrRefresh", "getSupplierByRequisition$AggrRefresh", "getOrderMainById$AggrRefresh", "getProjectAssetServices$AggrRefresh", "getInvoiceUsages$AggrRefresh", "getOrderRetentionTypes$AggrRefresh", "getBusinessValueCategories$AggrRefresh", "getPaymentTerms$AggrRefresh", "getInsuranceTypes$AggrRefresh", "getFrequencies$AggrRefresh", "getPaymentOptions$AggrRefresh", "getPaymentWays$AggrRefresh", "getOrderMainItemsByOrderMainId$AggrRefresh", "getCurrencies$AggrRefresh", "getDepositTypes$AggrRefresh", "getPaymentMethods$AggrRefresh", "getRejectComment$AggrRefresh", "getOrderFilesList$DataActRefresh", "getPaymentTermSpecial$DataActRefresh", "getAccountingData$DataActRefresh", "getOrderContractData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_dropdown_BusinessCategoryValueOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_BusinessCategoryValueOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_BusinessCategoryValueOnChange");
span.setAttribute("outsystems.function.key", "273f09cc-4739-45b0-8ce8-f145d5d63b85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_BusinessCategoryValueOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// GetOrderMainById.List.Current.OrderDetail.BusinessValueSubcategoryId = NullIdentifier
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueSubcategoryIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
// Refresh Query: GetBusinessValueSubcategoriesByCategoryId
var result = controller.getBusinessValueSubcategoriesByCategoryId$AggrRefresh(50, 0, callContext);
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
_dropdown_InsuranceTypeOnChange$Action(i_InsuranceTypeIdIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_InsuranceTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InsuranceTypeOnChange");
span.setAttribute("outsystems.function.key", "29b747e8-a56e-4da0-907e-748be33c2d92");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_InsuranceTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_InsuranceTypeOnChange$vars"))());
vars.value.i_InsuranceTypeIdInLocal = i_InsuranceTypeIdIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Null
if((!((vars.value.i_InsuranceTypeIdInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut, function (p) {
return (p.orderContractFileAttr.insuranceTypeIdAttr === vars.value.i_InsuranceTypeIdInLocal);
}, callContext);

// Second Record same Type?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// GetOrderContractData.o_ContractInsuranceList[i_CurrentRowNumber].OrderContractFile.InsuranceTypeId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getItem(vars.value.i_CurrentRowNumberInLocal).orderContractFileAttr.insuranceTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IfM5kHM4kEmz6F0RlpOlsw#Message.-1556557250.1", "You cannot have multiple Insurances of same type"), /*Info*/ 0);
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
_showHideOrderReject_Popup$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideOrderReject_Popup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideOrderReject_Popup");
span.setAttribute("outsystems.function.key", "37c9bc67-0ab3-4306-b6bc-5fa934a37939");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideOrderReject_Popup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.ShowHideOrderReject_Popup$vars"))());
vars.value.i_IsRefreshInLocal = i_IsRefreshIn;
// ShowOrderReject_Popup = notShowOrderReject_Popup
model.variables.showOrderReject_PopupVar = (!(model.variables.showOrderReject_PopupVar));
if((vars.value.i_IsRefreshInLocal)) {
// Destination: /ConectaProveedores/OrderDetail
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_input_RetentionOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_RetentionOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_RetentionOnChange");
span.setAttribute("outsystems.function.key", "397f7081-7817-4836-9604-d70feb88cb61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Input_RetentionOnChange");
callContext = controller.callContext(callContext);
// Smaller then 0?
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr.lt(OS$BuiltinFunctions.integerToDecimal(0)))) {
// Set Zero
// GetOrderMainById.List.Current.OrderDetail.RetentionRate = 0
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr = OS$BuiltinFunctions.integerToDecimal(0);
} else {
// Retention Rate
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr.gt((new OS$DataTypes.Decimal("100.00"))))) {
// Max 100.00
// GetOrderMainById.List.Current.OrderDetail.RetentionRate = 100.00
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr = (new OS$DataTypes.Decimal("100.00"));
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
_dropdown_AccountingDataType5OnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataType5OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataType5OnChange");
span.setAttribute("outsystems.function.key", "558dc41f-5001-47ad-bb9e-5c15e46bfe31");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_AccountingDataType5OnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_AccountingDataType5OnChange$vars"))());
vars.value.i_AccountingDataTypeInLocal = i_AccountingDataTypeIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Null?
if((!((vars.value.i_AccountingDataTypeInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// AgreedPayment?
if((!((vars.value.i_AccountingDataTypeInLocal === ConectaProveedores_staticEntities_accountingDataType.agreedPayments)))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === vars.value.i_AccountingDataTypeInLocal);
}, callContext);

// Second Record same Type?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// GetAccountingData.o_Anticipo.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("094EtBpv8UykVpMvE+bGCw#Message.-663497229.1", "You cannot have multiple same types"), /*Info*/ 0);
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
_onClickSave$Action(isFinishIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickSave", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSave");
span.setAttribute("outsystems.function.key", "6232a14d-9d32-4262-b1bb-7a937cf2f3dc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickSave");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.OnClickSave$vars"))());
vars.value.isFinishInLocal = isFinishIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var saveOrderDetailVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
if((vars.value.isFinishInLocal)) {
// Execute Action: Validations
controller._validations$Action(callContext);
if((!((model.variables.l_FormIsValidVar && model.widgets.get(idService.getId("Form")).validAttr)))) {
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(((model.variables.l_IsMissingEstimEqualAgFiniquitoVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5X+CoIoltUy99cD0s3Wo1A#Message.-246665552.1", "You need to select at least one payment. You need at least one payment of Estimation/Equalization/AgreedPayments or Settlement.")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5X+CoIoltUy99cD0s3Wo1A#Message.-1752268912.1", "Some mandatory fields are not being filled"))), /*Error*/ 3);
return OS$Flow.returnAsync();

}

}

// Execute Action: ClearFields
controller._clearFields$Action(callContext);
// Execute Action: ListOfFiles
controller._listOfFiles$Action(callContext);
// Execute Action: SaveOrderDetail
model.flush();
return controller.saveOrderDetail$ServerAction(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr, OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord))(), function (source, target) {
target = source.orderMainItemAttr;
return target;
}), model.variables.filesListVar, model.variables.getAccountingDataDataAct.orderAccountingOut, OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut, new RC_dd1ef552e394be88b7a9660ce51d9447(), function (source, target) {
target.mainAccConceptsAttr = source.mainAccConceptAttr;
target.subAccConceptsAttr = source.subAccConceptsAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getAccountingDataDataAct.o_CreditNoteOut, new RC_dd1ef552e394be88b7a9660ce51d9447(), function (source, target) {
target.mainAccConceptsAttr = source.mainAccConceptAttr;
target.subAccConceptsAttr = source.subAccConceptsAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getAccountingDataDataAct.o_VoucherOut, new RC_dd1ef552e394be88b7a9660ce51d9447(), function (source, target) {
target.mainAccConceptsAttr = source.mainAccConceptAttr;
target.subAccConceptsAttr = source.subAccConceptsAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getAccountingDataDataAct.o_FiniquitoOut, new RC_dd1ef552e394be88b7a9660ce51d9447(), function (source, target) {
target.mainAccConceptsAttr = source.mainAccConceptAttr;
target.subAccConceptsAttr = source.subAccConceptsAttr;
return target;
}), OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getAccountingDataDataAct.o_AnticipoOut, new RC_dd1ef552e394be88b7a9660ce51d9447(), function (source, target) {
target.mainAccConceptsAttr = source.mainAccConceptAttr;
target.subAccConceptsAttr = source.subAccConceptsAttr;
return target;
}), model.variables.l_OrderRequestFilesVar, vars.value.isFinishInLocal, callContext).then(function (value) {
saveOrderDetailVar.value = value;
}).then(function () {
// ok?
if(((saveOrderDetailVar.value.errorMsgOut === ""))) {
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isFinishInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ALdAJw4YJUmIqP1rh5aXGA#Message.-1258891452.1", "Your request was successfully sent to approval")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ALdAJw4YJUmIqP1rh5aXGA#Message.-610115733.1", "Changes successfully saved"))), /*Success*/ 1);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/OrderDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(saveOrderDetailVar.value.errorMsgOut, /*Error*/ 3);
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
}

});
}).catch(function (ex) {
OS$Logger.debug("Wb_OrderDetailPaymentInformation_13008.OnClickSave", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "dde29724-c748-4d01-8a3f-8a008c656af4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2PTg4WpNg0Wg0f36k3_OPg#Message.-1973574713.1", "There was a problem. Please contact the administrator"), /*Error*/ 3);
// Execute Action: HideLoading2
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "71e9e05f-f3b4-48c5-9299-c655bc73c673");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// i_ForceRefresh = i_ForceRefresh
model.variables.i_ForceRefreshIn = model.variables.i_ForceRefreshIn;
// Refresh Query: GetOrderMainById
var result = controller.getOrderMainById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetOrderMainItemsByOrderMainId
var result = controller.getOrderMainItemsByOrderMainId$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetAccountingData
var result = controller.getAccountingData$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetOrderContractData
var result = controller.getOrderContractData$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetOrderFilesList
var result = controller.getOrderFilesList$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((!(true))) {
// Refresh Query: GetRejectComment
var result = controller.getRejectComment$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}

});
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
_wb_OrderDetail_AttachmentsUploadMainParent$Action(orderRequestFilesInIn, hasntRequestDocumentsIn, isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_OrderDetail_AttachmentsUploadMainParent", function (span) {
if(span) {
span.setAttribute("code.function", "wb_OrderDetail_AttachmentsUploadMainParent");
span.setAttribute("outsystems.function.key", "72e69ecb-cd9f-403f-96b3-803a3dc62caf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_OrderDetail_AttachmentsUploadMainParent");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.wb_OrderDetail_AttachmentsUploadMainParent$vars"))());
vars.value.orderRequestFilesInInLocal = orderRequestFilesInIn.clone();
vars.value.hasntRequestDocumentsInLocal = hasntRequestDocumentsIn;
vars.value.isValidInLocal = isValidIn;
// GetOrderMainById.List.Current.OrderDetail.HasntRequestDocuments = HasntRequestDocuments
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr = vars.value.hasntRequestDocumentsInLocal;
// l_IsValidReqDoc = IsValid
model.variables.l_IsValidReqDocVar = vars.value.isValidInLocal;
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_OrderRequestFilesVar, callContext);
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.l_OrderRequestFilesVar, vars.value.orderRequestFilesInInLocal, callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_addRecord$Action(i_IsDepositIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddRecord", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "73f4472e-6e53-475e-aaa3-1cf7c2525665");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AddRecord");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.AddRecord$vars"))());
vars.value.i_IsDepositInLocal = i_IsDepositIn;
vars.value.i_IsInsuranceInLocal = i_IsInsuranceIn;
vars.value.i_IsEstim_Equal_AgreedInLocal = i_IsEstim_Equal_AgreedIn;
vars.value.i_IsCreditNoteInLocal = i_IsCreditNoteIn;
vars.value.i_IsVoucherInLocal = i_IsVoucherIn;
vars.value.i_IsfiniquitoInLocal = i_IsfiniquitoIn;
vars.value.i_IsAnticipoInLocal = i_IsAnticipoIn;
if((vars.value.i_IsDepositInLocal)) {
// Execute Action: ListAppendDeposit
OS$SystemActions.listAppend(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut, function () {
var rec = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();
rec.orderContractFileAttr = function () {
var rec = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.orderIdAttr = model.variables.i_OrderIdIn;
rec.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.deposit;
return rec;
}();
return rec;
}(), callContext);
} else {
if(vars.value.i_IsInsuranceInLocal) {
// Execute Action: ListAppendInsurance
OS$SystemActions.listAppend(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut, function () {
var rec = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();
rec.orderContractFileAttr = function () {
var rec = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.orderIdAttr = model.variables.i_OrderIdIn;
rec.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.insurance;
return rec;
}();
return rec;
}(), callContext);
} else {
if(vars.value.i_IsEstim_Equal_AgreedInLocal) {
// Execute Action: ListAppendEstim_Equal_Agreed
OS$SystemActions.listAppend(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function () {
var rec = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.estim_Equal_Agreed;
rec.orderAccConceptsIdAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.idAttr;
rec.paymentTermIdAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(0).paymentTermIdAttr;
rec.paymentTermCustomDaysAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(0).paymentTermCustomDaysAttr;
return rec;
}(), callContext);
} else {
if(vars.value.i_IsCreditNoteInLocal) {
// Execute Action: ListAppendCreditNote
OS$SystemActions.listAppend(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr, function () {
var rec = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.creditNote;
rec.orderAccConceptsIdAttr = model.variables.getAccountingDataDataAct.o_CreditNoteOut.mainAccConceptAttr.idAttr;
return rec;
}(), callContext);
} else {
if(vars.value.i_IsVoucherInLocal) {
// Execute Action: Voucher
OS$SystemActions.listAppend(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr, function () {
var rec = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.voucher;
rec.orderAccConceptsIdAttr = model.variables.getAccountingDataDataAct.o_VoucherOut.mainAccConceptAttr.idAttr;
return rec;
}(), callContext);
} else {
if(vars.value.i_IsfiniquitoInLocal) {
// Execute Action: ListAppendFiniquito
OS$SystemActions.listAppend(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr, function () {
var rec = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.settlement;
rec.orderAccConceptsIdAttr = model.variables.getAccountingDataDataAct.o_FiniquitoOut.mainAccConceptAttr.idAttr;
return rec;
}(), callContext);
} else {
if(vars.value.i_IsAnticipoInLocal) {
// Execute Action: ListAppendAnticipo
OS$SystemActions.listAppend(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr, function () {
var rec = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.anticipo;
rec.orderAccConceptsIdAttr = model.variables.getAccountingDataDataAct.o_AnticipoOut.mainAccConceptAttr.idAttr;
return rec;
}(), callContext);
}

}

}

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
_removeFromList$Action(i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, is_Estim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "851badc2-8f91-4c4e-80dd-5cf206bed7c4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.RemoveFromList$vars"))());
vars.value.i_PositionInLocal = i_PositionIn;
vars.value.i_IsDepositInLocal = i_IsDepositIn;
vars.value.i_IsServiceInLocal = i_IsServiceIn;
vars.value.i_IsAttachedFileInLocal = i_IsAttachedFileIn;
vars.value.i_IsInsuranceInLocal = i_IsInsuranceIn;
vars.value.is_Estim_Equal_AgreedInLocal = is_Estim_Equal_AgreedIn;
vars.value.i_IsCreditNoteInLocal = i_IsCreditNoteIn;
vars.value.i_IsVoucherInLocal = i_IsVoucherIn;
vars.value.i_IsfiniquitoInLocal = i_IsfiniquitoIn;
vars.value.i_IsAnticipoInLocal = i_IsAnticipoIn;
if((vars.value.i_IsDepositInLocal)) {
// Execute Action: ListRemoveDeposit
OS$SystemActions.listRemove(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsInsuranceInLocal) {
// Execute Action: ListRemoveInsurance
OS$SystemActions.listRemove(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsAttachedFileInLocal) {
// Execute Action: ListRemoveFile
OS$SystemActions.listRemove(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.is_Estim_Equal_AgreedInLocal) {
// Execute Action: ListRemoveEstim_Equal_Agreed
OS$SystemActions.listRemove(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsCreditNoteInLocal) {
// Execute Action: ListRemoveCreditNote
OS$SystemActions.listRemove(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsVoucherInLocal) {
// Execute Action: ListRemoveVoucher
OS$SystemActions.listRemove(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsfiniquitoInLocal) {
// Execute Action: ListRemoveFiniquito
OS$SystemActions.listRemove(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsAnticipoInLocal) {
// Execute Action: ListRemoveAnticipo
OS$SystemActions.listRemove(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr, vars.value.i_PositionInLocal, callContext);
}

}

}

}

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
_switch_OnChange$Action(contractFileTypeIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_OnChange");
span.setAttribute("outsystems.function.key", "8c4eed26-cb86-40e5-9825-fcfa48af2ade");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_OnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Switch_OnChange$vars"))());
vars.value.contractFileTypeIdInLocal = contractFileTypeIdIn;
// Empty?
if((((model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.isEmpty && (vars.value.contractFileTypeIdInLocal === ConectaProveedores_staticEntities_contractFileType.deposit)) || (model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.isEmpty && (vars.value.contractFileTypeIdInLocal === ConectaProveedores_staticEntities_contractFileType.insurance))))) {
// Execute Action: AddDeposit3
controller._addRecord$Action((vars.value.contractFileTypeIdInLocal === ConectaProveedores_staticEntities_contractFileType.deposit), (vars.value.contractFileTypeIdInLocal === ConectaProveedores_staticEntities_contractFileType.insurance), false, false, false, false, false, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderContractDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderContractDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderContractDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "9026628f-78a7-4218-8cb1-14273c3315aa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderContractDataOnAfterFetch");
callContext = controller.callContext(callContext);
var getIsUserCxPVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_IsSavingContractFile = False
model.variables.l_IsSavingContractFileVar = false;
// Execute Action: GetIsUserCxP
model.flush();
return controller.getIsUserCxP$ServerAction(callContext).then(function (value) {
getIsUserCxPVar.value = value;
}).then(function () {
// l_CanUploadContract = GetIsUserCxP.o_Value and GetOrderContractData.o_ContractFile.OrderFile.StorageId = NullIdentifier
model.variables.l_CanUploadContractVar = (getIsUserCxPVar.value.o_ValueOut && model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())));
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
_listOfFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ListOfFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ListOfFiles");
span.setAttribute("outsystems.function.key", "9383d573-1c47-47f2-8492-9dc5efbd6555");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ListOfFiles");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// HasFinaceAuth?
if(((!(OS$DataTypes.areBinaryNulls(model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) && ((model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendFinance
OS$SystemActions.listAppend(model.variables.filesListVar, model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut, callContext);
}

// HasForeign?
if((((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) && !(OS$DataTypes.areBinaryNulls(model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.binaryAttr, OS$BuiltinFunctions.nullBinary()))) && ((model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendForeign
OS$SystemActions.listAppend(model.variables.filesListVar, model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut, callContext);
}

// Has Contract
if((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes) && (!(OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))))) {
// Execute Action: ListAppendContract
OS$SystemActions.listAppend(model.variables.filesListVar, model.variables.getOrderContractDataDataAct.o_ContractFileOut, callContext);
}

// IsContractPending
if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending))) {
// Execute Action: ListAppendContractPendingJustification
OS$SystemActions.listAppend(model.variables.filesListVar, model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut, callContext);
}

// Attached Files
if(((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes) || (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending)) && (!(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.isEmpty))))) {
// Execute Action: ListAppendAllAttachFiles
OS$SystemActions.listAppendAll(model.variables.filesListVar, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut, callContext);
}

// Has Deposit?
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasDepositAttr)) {
// Execute Action: ListAppendAllDeposit
OS$SystemActions.listAppendAll(model.variables.filesListVar, model.variables.getOrderContractDataDataAct.o_ContractDepositListOut, callContext);
}

// Has Insurance?
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasInsuranceAttr)) {
// Execute Action: ListAppendAllInsurance
OS$SystemActions.listAppendAll(model.variables.filesListVar, model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut, callContext);
}

// Has AdvancePayment
if((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasAdvancePaymentAttr && !(OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr, OS$BuiltinFunctions.nullBinary()))) && ((model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.orderFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendAdvancePayment
OS$SystemActions.listAppend(model.variables.filesListVar, model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_DepositTypeOnChange$Action(i_DepositTypeIdIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_DepositTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DepositTypeOnChange");
span.setAttribute("outsystems.function.key", "9de29940-9dd5-4bef-a71c-c9842f6dfe1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_DepositTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_DepositTypeOnChange$vars"))());
vars.value.i_DepositTypeIdInLocal = i_DepositTypeIdIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Null
if((!((vars.value.i_DepositTypeIdInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut, function (p) {
return (p.orderContractFileAttr.depositTypeIdAttr === vars.value.i_DepositTypeIdInLocal);
}, callContext);

// Second Record same Type?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// GetOrderContractData.o_ContractDepositList[i_CurrentRowNumber].OrderContractFile.DepositTypeId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getItem(vars.value.i_CurrentRowNumberInLocal).orderContractFileAttr.depositTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mR_3jR4fI0SPPRWlNO6mag#Message.-322431486.1", "You cannot have multiple Deposits of same type"), /*Info*/ 0);
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
_clearFields$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFields", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFields");
span.setAttribute("outsystems.function.key", "a498c7ec-c4c8-41d5-9f31-f2ec8527cb5e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearFields");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_InvoiceUsageItemOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_InvoiceUsageItemOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InvoiceUsageItemOnChange");
span.setAttribute("outsystems.function.key", "aa4f1025-ee24-4fa1-97c8-af4697f96060");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_InvoiceUsageItemOnChange");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getInvoiceUsagesAggr.listOut, function (p) {
return p.invoiceUsageAttr.idAttr.equals(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.invoiceUsageIdAttr);
}, callContext);

// GetOrderMainItemsByOrderMainId.List.Current.InvoiceUsage = ListFilter.FilteredList.Current.InvoiceUsage
model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceUsageAttr = listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).invoiceUsageAttr;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getOrderMainByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "ab64778f-9a63-4d29-809f-3a786cb8a8b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetOrderMainByIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_CanEditForm = GetOrderMainById.List.Current.OrderMain.OrderStatusId = InInformationCompletion and GetOrderMainById.List.Current.IsCurrentApprover or GetOrderMainById.List.Current.OrderMain.OrderStatusId = ApprovalRejected and GetOrderMainById.List.Current.IsCurrentApprover
model.variables.l_CanEditFormVar = (((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.inInformationCompletion) && model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).isCurrentApproverAttr) || ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approvalRejected) && model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).isCurrentApproverAttr));
return OS$Flow.executeSequence(function () {
if((model.variables.l_CanEditFormVar)) {
// Refresh Query: GetSuppliers
var result = controller.getSuppliers$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
} else {
// Refresh Query: GetSupplierByRequisition
var result = controller.getSupplierByRequisition$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}

}).then(function () {
// ApprovalRejected?
return OS$Flow.executeSequence(function () {
if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approvalRejected))) {
// Refresh Query: GetRejectComment
var result = controller.getRejectComment$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}

});
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
_wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "c1a9e1f4-58d7-4ca4-8a76-c04b64d1bea5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Wb_CustomUploadOnFileChange$vars"))());
vars.value.fileInLocal = fileIn.clone();
vars.value.errorInLocal = errorIn.clone();
vars.value.i_IsDeleteInLocal = i_IsDeleteIn;
vars.value.i_IsFinanceAuthorizationInLocal = i_IsFinanceAuthorizationIn;
vars.value.i_IsProofOfForeignResidenceInLocal = i_IsProofOfForeignResidenceIn;
vars.value.i_IsContractInLocal = i_IsContractIn;
vars.value.i_IsDepositInLocal = i_IsDepositIn;
vars.value.i_IsInsuranceInLocal = i_IsInsuranceIn;
vars.value.i_IsAdvancePaymentInLocal = i_IsAdvancePaymentIn;
vars.value.i_IsExchangeRateEvidenceInLocal = i_IsExchangeRateEvidenceIn;
vars.value.i_IsAttachedFilesInLocal = i_IsAttachedFilesIn;
vars.value.i_IsContractPendingJustificationInLocal = i_IsContractPendingJustificationIn;
vars.value.i_IsREPSEInLocal = i_IsREPSEIn;
if(((vars.value.errorInLocal.successAttr || OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
if((vars.value.i_IsFinanceAuthorizationInLocal)) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderFilesList.o_FinanceAuthorization.Binary = NullBinary
model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderFilesList.o_FinanceAuthorization.OrderFile.Filename = ""
model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.filenameAttr = "";
// GetOrderFilesList.o_FinanceAuthorization.OrderFile.StorageId = NullIdentifier
model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderFilesList.o_FinanceAuthorization.OrderContractFile.ContractFileTypeId = FinanceAuthorization
model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.financeAuthorization;
}

// GetOrderFilesList.o_FinanceAuthorization.Binary = File.FileContent
model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderFilesList.o_FinanceAuthorization.OrderFile.Filename = File.FileName
model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsProofOfForeignResidenceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderFilesList.o_ProofOfForeignResidence.Binary = NullBinary
model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderFilesList.o_ProofOfForeignResidence.OrderFile.Filename = ""
model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.filenameAttr = "";
// GetOrderFilesList.o_ProofOfForeignResidence.OrderFile.StorageId = NullIdentifier
model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderFilesList.o_ProofOfForeignResidence.OrderContractFile.ContractFileTypeId = ProofOfForeignResidence
model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.proofOfForeignResidence;
}

// GetOrderFilesList.o_ProofOfForeignResidence.Binary = File.FileContent
model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderFilesList.o_ProofOfForeignResidence.OrderFile.Filename = File.FileName
model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsContractInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderContractData.o_ContractFile.Binary = NullBinary
model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderContractData.o_ContractFile.OrderFile.Filename = ""
model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr = "";
// GetOrderContractData.o_ContractFile.OrderFile.StorageId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderContractData.o_ContractFile.OrderContractFile.ContractFileTypeId = Contract
model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.contract;
}

// GetOrderContractData.o_ContractFile.Binary = File.FileContent
model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderContractData.o_ContractFile.OrderFile.Filename = File.FileName
model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsAttachedFilesInLocal) {
// Execute Action: ListAppendFile
OS$SystemActions.listAppend(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), function (source, target) {
target.orderContractFileAttr.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.orderContractFileAttr.orderIdAttr = model.variables.i_OrderIdIn;
target.orderFileAttr.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.orderFileAttr.filenameAttr = source.fileNameAttr;
target.orderFileAttr.createdByAttr = OS$BuiltinFunctions.getUserId();
target.orderFileAttr.createdOnAttr = OS$BuiltinFunctions.currDateTime();
target.binaryAttr = source.fileContentAttr;
return target;
}), callContext);
} else {
if(vars.value.i_IsDepositInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderContractData.o_ContractDepositList.Current.Binary = NullBinary
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderContractData.o_ContractDepositList.Current.OrderFile.Filename = ""
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr = "";
// GetOrderContractData.o_ContractDepositList.Current.OrderFile.StorageId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderContractData.o_ContractDepositList.Current.OrderContractFile.ContractFileTypeId = Deposit
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.deposit;
}

// GetOrderContractData.o_ContractDepositList.Current.Binary = File.FileContent
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderContractData.o_ContractDepositList.Current.OrderFile.Filename = File.FileName
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsInsuranceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderContractData.o_ContractInsuranceList.Current.Binary = NullBinary
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderContractData.o_ContractInsuranceList.Current.OrderFile.Filename = ""
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr = "";
// GetOrderContractData.o_ContractInsuranceList.Current.OrderFile.StorageId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderContractData.o_ContractInsuranceList.Current.OrderContractFile.ContractFileTypeId = Insurance
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.insurance;
}

// GetOrderContractData.o_ContractInsuranceList.Current.Binary = File.FileContent
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderContractData.o_ContractInsuranceList.Current.OrderFile.Filename = File.FileName
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsAdvancePaymentInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderContractData.o_ContractAdvancePayment.Binary = NullBinary
model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderContractData.o_ContractAdvancePayment.OrderFile.Filename = ""
model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.orderFileAttr.filenameAttr = "";
// GetOrderContractData.o_ContractAdvancePayment.OrderFile.StorageId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderContractData.o_ContractAdvancePayment.OrderContractFile.ContractFileTypeId = AdvancePayment
model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.advancePayment;
}

// GetOrderContractData.o_ContractAdvancePayment.Binary = File.FileContent
model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderContractData.o_ContractAdvancePayment.OrderFile.Filename = File.FileName
model.variables.getOrderContractDataDataAct.o_ContractAdvancePaymentOut.orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsExchangeRateEvidenceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
}

} else {
if(vars.value.i_IsContractPendingJustificationInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetOrderContractData.o_ContractPendingJustification.Binary = NullBinary
model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetOrderContractData.o_ContractPendingJustification.OrderFile.Filename = ""
model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.orderFileAttr.filenameAttr = "";
// GetOrderContractData.o_ContractPendingJustification.OrderFile.StorageId = NullIdentifier
model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.orderFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.orderContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetOrderContractData.o_ContractPendingJustification.OrderContractFile.ContractFileTypeId = ContractPendingJustification
model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.orderContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.contractPendingJustification;
}

// GetOrderContractData.o_ContractPendingJustification.Binary = File.FileContent
model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetOrderContractData.o_ContractPendingJustification.OrderFile.Filename = File.FileName
model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.orderFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsREPSEInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
}

}

}

}

}

}

}

}

}

}

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
_approve$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Approve", function (span) {
if(span) {
span.setAttribute("code.function", "Approve");
span.setAttribute("outsystems.function.key", "d047273f-0abb-40f2-8492-26f58b99b004");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Approve");
callContext = controller.callContext(callContext);
var approvRejectOrderVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ApprovRejectOrder
model.flush();
return controller.approvRejectOrder$ServerAction(model.variables.i_OrderIdIn, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.idAttr, true, "", callContext).then(function (value) {
approvRejectOrderVar.value = value;
}).then(function () {
// IsSuccess?
if((approvRejectOrderVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qUr3jYOWXUm5elti0woMbA#Message.637262369.1", "Order approved with success!"), /*Success*/ 1);
// Destination: /ConectaProveedores/OrderDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.i_OrderIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(approvRejectOrderVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// Execute Action: HideLoading2
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
_saveContractFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveContractFile", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractFile");
span.setAttribute("outsystems.function.key", "debae820-2129-4f1b-a8bd-c4eae1d069b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveContractFile");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// l_IsSavingContractFile = True
model.variables.l_IsSavingContractFileVar = true;
return OS$Flow.executeSequence(function () {
if((model.variables.l_CanUploadContractVar)) {
return OS$Flow.executeSequence(function () {
if(((OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) || (model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr === "")))) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("S2W3R2Pyh0aE7E6SJm3MKw#Message.-967893839.1", "Make sure you upload a file with content and a filename!"), /*Error*/ 3);
} else {
// Execute Action: SaveContractFile
model.flush();
return controller.saveContractFile$ServerAction(model.variables.i_OrderIdIn, model.variables.getOrderContractDataDataAct.o_ContractFileOut, callContext).then(function () {
// Refresh Query: GetOrderContractData
var result = controller.getOrderContractData$DataActRefresh(callContext);
model.flush();
return result;
}).then(function () {
return OS$Flow.returnAsync();

});
}

});
} else {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bcSWqz1hl0qvKysOEvNHNw#Message.-940469518.1", "Contract file upload is not available!"), /*Error*/ 3);
}

}).then(function () {
// l_IsSavingContractFile = False
model.variables.l_IsSavingContractFileVar = false;
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
_validations$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Validations", function (span) {
if(span) {
span.setAttribute("code.function", "Validations");
span.setAttribute("outsystems.function.key", "edf48c5c-cebf-4069-8ba1-7553514b5743");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Validations");
callContext = controller.callContext(callContext);
// l_FormIsValid = True
model.variables.l_FormIsValidVar = true;
// l_RequestDocsErrorMessage = ""
model.variables.l_RequestDocsErrorMessageVar = "";
// l_IsMissingEstimEqualAgFiniquito = False
model.variables.l_IsMissingEstimEqualAgFiniquitoVar = false;
// No Contract File?
if(((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes) && (OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) || (model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr === ""))) && model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetOrderContractData.o_ContractFile.Valid.IsValid = False
model.variables.getOrderContractDataDataAct.o_ContractFileOut.validAttr.isValidAttr = false;
// GetOrderContractData.o_ContractFile.Valid.ValidationMessage = "This field is mandatory"
model.variables.getOrderContractDataDataAct.o_ContractFileOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("xb_cF4lxWUaaWiN3kx2I7A#Value.-1029745557.1", "This field is mandatory");
}

// No Order Files and Hasnt Request
if(((model.variables.l_OrderRequestFilesVar.isEmpty && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// l_RequestDocsErrorMessage = "You need to request at least a file!"
model.variables.l_RequestDocsErrorMessageVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("99Otjwj9dk2t57oTSWTxIA#Value.2074211503.1", "You need to request at least a file!");
}

// Empty Order Files?
if(((!(model.variables.l_IsValidReqDocVar)))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
}

if(((!((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr || model.variables.getAccountingDataDataAct.o_FiniquitoOut.mainAccConceptAttr.isActiveAttr))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// l_IsMissingEstimEqualAgFiniquito = True
model.variables.l_IsMissingEstimEqualAgFiniquitoVar = true;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_AccountingDataTypeOnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataTypeOnChange");
span.setAttribute("outsystems.function.key", "f3c468cf-8139-4ffc-b358-b047c312b694");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_AccountingDataTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_AccountingDataTypeOnChange$vars"))());
vars.value.i_AccountingDataTypeInLocal = i_AccountingDataTypeIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterForEstimacionesVar = new OS$DataTypes.VariableHolder();
var listFilterForAgreedPaymentsVar = new OS$DataTypes.VariableHolder();
var listFilterForIgualaVar = new OS$DataTypes.VariableHolder();
// Null?
if((!((vars.value.i_AccountingDataTypeInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// AgreedPayment?
if((!((vars.value.i_AccountingDataTypeInLocal === ConectaProveedores_staticEntities_accountingDataType.agreedPayments)))) {
// Execute Action: ListFilterForIguala
listFilterForIgualaVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.equalization);
}, callContext);

// Second Record same Type?
if(((listFilterForIgualaVar.value.filteredListOut.length > 1))) {
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fv928pvc0UOSwmIWIFwZrg#Message.80107734.1", "You cannot have 2 Ugualas"), /*Info*/ 0);
} else {
// Execute Action: ListFilterForEstimaciones
listFilterForEstimacionesVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.estimation);
}, callContext);

// Second Record same Type?
if(((listFilterForEstimacionesVar.value.filteredListOut.length > 6))) {
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yrsolsoMY0CttJXVrEsC6g#Message.-1019087901.1", "You cannot have 7 Estimations"), /*Info*/ 0);
} else {
// Execute Action: ListFilterForAgreedPayments
listFilterForAgreedPaymentsVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.agreedPayments);
}, callContext);

// Second Record same Type?
if(((listFilterForAgreedPaymentsVar.value.filteredListOut.length > 6))) {
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tQtSrz__q028nm7pIIf1kw#Message.1178440656.1", "You cannot have 7 Agreed Payments"), /*Info*/ 0);
}

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

dropdown_BusinessCategoryValueOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_BusinessCategoryValueOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_BusinessCategoryValueOnChange");
span.setAttribute("outsystems.function.key", "273f09cc-4739-45b0-8ce8-f145d5d63b85");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_BusinessCategoryValueOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_InsuranceTypeOnChange$Action(i_InsuranceTypeIdIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_InsuranceTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InsuranceTypeOnChange");
span.setAttribute("outsystems.function.key", "29b747e8-a56e-4da0-907e-748be33c2d92");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_InsuranceTypeOnChange$Action, callContext, i_InsuranceTypeIdIn, i_CurrentRowNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

showHideOrderReject_Popup$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideOrderReject_Popup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideOrderReject_Popup");
span.setAttribute("outsystems.function.key", "37c9bc67-0ab3-4306-b6bc-5fa934a37939");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideOrderReject_Popup$Action, callContext, i_IsRefreshIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

input_RetentionOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_RetentionOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_RetentionOnChange");
span.setAttribute("outsystems.function.key", "397f7081-7817-4836-9604-d70feb88cb61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._input_RetentionOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_AccountingDataType5OnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataType5OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataType5OnChange");
span.setAttribute("outsystems.function.key", "558dc41f-5001-47ad-bb9e-5c15e46bfe31");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_AccountingDataType5OnChange$Action, callContext, i_AccountingDataTypeIn, i_CurrentRowNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickSave$Action(isFinishIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickSave__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSave");
span.setAttribute("outsystems.function.key", "6232a14d-9d32-4262-b1bb-7a937cf2f3dc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onClickSave$Action, callContext, isFinishIn);
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
span.setAttribute("outsystems.function.key", "71e9e05f-f3b4-48c5-9299-c655bc73c673");
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

wb_OrderDetail_AttachmentsUploadMainParent$Action(orderRequestFilesInIn, hasntRequestDocumentsIn, isValidIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_OrderDetail_AttachmentsUploadMainParent__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_OrderDetail_AttachmentsUploadMainParent");
span.setAttribute("outsystems.function.key", "72e69ecb-cd9f-403f-96b3-803a3dc62caf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_OrderDetail_AttachmentsUploadMainParent$Action, callContext, orderRequestFilesInIn, hasntRequestDocumentsIn, isValidIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

addRecord$Action(i_IsDepositIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddRecord__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "73f4472e-6e53-475e-aaa3-1cf7c2525665");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._addRecord$Action, callContext, i_IsDepositIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeFromList$Action(i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, is_Estim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "851badc2-8f91-4c4e-80dd-5cf206bed7c4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, is_Estim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

switch_OnChange$Action(contractFileTypeIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_OnChange");
span.setAttribute("outsystems.function.key", "8c4eed26-cb86-40e5-9825-fcfa48af2ade");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._switch_OnChange$Action, callContext, contractFileTypeIdIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderContractDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderContractDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderContractDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "9026628f-78a7-4218-8cb1-14273c3315aa");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderContractDataOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

listOfFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ListOfFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ListOfFiles");
span.setAttribute("outsystems.function.key", "9383d573-1c47-47f2-8492-9dc5efbd6555");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._listOfFiles$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_DepositTypeOnChange$Action(i_DepositTypeIdIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_DepositTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DepositTypeOnChange");
span.setAttribute("outsystems.function.key", "9de29940-9dd5-4bef-a71c-c9842f6dfe1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_DepositTypeOnChange$Action, callContext, i_DepositTypeIdIn, i_CurrentRowNumberIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

clearFields$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFields__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFields");
span.setAttribute("outsystems.function.key", "a498c7ec-c4c8-41d5-9f31-f2ec8527cb5e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._clearFields$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_InvoiceUsageItemOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_InvoiceUsageItemOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InvoiceUsageItemOnChange");
span.setAttribute("outsystems.function.key", "aa4f1025-ee24-4fa1-97c8-af4697f96060");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_InvoiceUsageItemOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getOrderMainByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "ab64778f-9a63-4d29-809f-3a786cb8a8b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getOrderMainByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "c1a9e1f4-58d7-4ca4-8a76-c04b64d1bea5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CustomUploadOnFileChange$Action, callContext, fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

approve$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Approve__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Approve");
span.setAttribute("outsystems.function.key", "d047273f-0abb-40f2-8492-26f58b99b004");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approve$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

saveContractFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveContractFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractFile");
span.setAttribute("outsystems.function.key", "debae820-2129-4f1b-a8bd-c4eae1d069b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveContractFile$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

validations$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Validations__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Validations");
span.setAttribute("outsystems.function.key", "edf48c5c-cebf-4069-8ba1-7553514b5743");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._validations$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_AccountingDataTypeOnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataTypeOnChange");
span.setAttribute("outsystems.function.key", "f3c468cf-8139-4ffc-b358-b047c312b694");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_AccountingDataTypeOnChange$Action, callContext, i_AccountingDataTypeIn, i_CurrentRowNumberIn);
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008$ActionSaveOrderDetail", [{
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008$ActionGetIsUserCxP", [{
name: "o_Value",
attrName: "o_ValueOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008$ActionApprovRejectOrder", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_InsuranceTypeOnChange$vars", [{
name: "i_InsuranceTypeId",
attrName: "i_InsuranceTypeIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "i_CurrentRowNumber",
attrName: "i_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.ShowHideOrderReject_Popup$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_AccountingDataType5OnChange$vars", [{
name: "i_AccountingDataType",
attrName: "i_AccountingDataTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "i_CurrentRowNumber",
attrName: "i_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.OnClickSave$vars", [{
name: "IsFinish",
attrName: "isFinishInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.wb_OrderDetail_AttachmentsUploadMainParent$vars", [{
name: "OrderRequestFilesIn",
attrName: "orderRequestFilesInInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))
}, {
name: "HasntRequestDocuments",
attrName: "hasntRequestDocumentsInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "IsValid",
attrName: "isValidInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.AddRecord$vars", [{
name: "i_IsDeposit",
attrName: "i_IsDepositInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsInsurance",
attrName: "i_IsInsuranceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsEstim_Equal_Agreed",
attrName: "i_IsEstim_Equal_AgreedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsCreditNote",
attrName: "i_IsCreditNoteInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsVoucher",
attrName: "i_IsVoucherInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_Isfiniquito",
attrName: "i_IsfiniquitoInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsAnticipo",
attrName: "i_IsAnticipoInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.RemoveFromList$vars", [{
name: "i_Position",
attrName: "i_PositionInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "i_IsDeposit",
attrName: "i_IsDepositInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsService",
attrName: "i_IsServiceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsAttachedFile",
attrName: "i_IsAttachedFileInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsInsurance",
attrName: "i_IsInsuranceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "Is_Estim_Equal_Agreed",
attrName: "is_Estim_Equal_AgreedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsCreditNote",
attrName: "i_IsCreditNoteInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsVoucher",
attrName: "i_IsVoucherInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_Isfiniquito",
attrName: "i_IsfiniquitoInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsAnticipo",
attrName: "i_IsAnticipoInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Switch_OnChange$vars", [{
name: "ContractFileTypeId",
attrName: "contractFileTypeIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_DepositTypeOnChange$vars", [{
name: "i_DepositTypeId",
attrName: "i_DepositTypeIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "i_CurrentRowNumber",
attrName: "i_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Wb_CustomUploadOnFileChange$vars", [{
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
}, {
name: "i_IsFinanceAuthorization",
attrName: "i_IsFinanceAuthorizationInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsProofOfForeignResidence",
attrName: "i_IsProofOfForeignResidenceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsContract",
attrName: "i_IsContractInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsDeposit",
attrName: "i_IsDepositInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsInsurance",
attrName: "i_IsInsuranceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsAdvancePayment",
attrName: "i_IsAdvancePaymentInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsExchangeRateEvidence",
attrName: "i_IsExchangeRateEvidenceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsAttachedFiles",
attrName: "i_IsAttachedFilesInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsContractPendingJustification",
attrName: "i_IsContractPendingJustificationInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "i_IsREPSE",
attrName: "i_IsREPSEInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.Dropdown_AccountingDataTypeOnChange$vars", [{
name: "i_AccountingDataType",
attrName: "i_AccountingDataTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "i_CurrentRowNumber",
attrName: "i_CurrentRowNumberInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


