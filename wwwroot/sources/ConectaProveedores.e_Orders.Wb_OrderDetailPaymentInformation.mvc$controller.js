import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, FeedbackMessageService as OS$FeedbackMessageService, Transitions as OS$Transitions, Navigation as OS$Navigation, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord, RC_dd1ef552e394be88b7a9660ce51d9447, EN_17538b35348920159ed0ee43b3fb2b50EntityRecord, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord, ST_d9010d115c38fb059bccbc457fe11b18Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure } from "./ConectaProveedores.model.js";
import { SE_accountingDataType as ConectaProveedores_staticEntities_accountingDataType, SE_contractStatus as ConectaProveedores_staticEntities_contractStatus, SE_orderStatus as ConectaProveedores_staticEntities_orderStatus, SE_contractFileType as ConectaProveedores_staticEntities_contractFileType } from "./ConectaProveedores.staticEntities.js";
import { dropdownClearValidation$Action as OutSystemsUIController$dropdownClearValidation$Action, dropdownNotValid$Action as OutSystemsUIController$dropdownNotValid$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_TranslationsResources from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$translationsResources.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getInsuranceTypes$AggrRefresh: 0,
getDepositTypes$AggrRefresh: 0,
getPaymentWays$AggrRefresh: 1,
getAccountingDataTypes$AggrRefresh: 0,
getBusinessValueCategories$AggrRefresh: 0,
getOrderMainItemsByOrderMainId$AggrRefresh: 0,
getAdvancedPaymentTypes$AggrRefresh: 0,
getBusinessValueSubcategoriesByCategoryId$AggrRefresh: 1,
getInvoiceUsages$AggrRefresh: 0,
getFrequencies$AggrRefresh: 0,
getProjectAssetServices$AggrRefresh: 0,
getRejectComment$AggrRefresh: -1,
getSupplierByRequisition$AggrRefresh: -1,
getSpecialApprovals$AggrRefresh: 0,
getPaymentTerms$AggrRefresh: 0,
getPaymentMethods$AggrRefresh: 0,
getOrderRetentionTypes$AggrRefresh: 0,
getCurrencies$AggrRefresh: 0,
getOrderMainById$AggrRefresh: 0,
getSpecialPostDeliveryAuthorizations$AggrRefresh: 0,
getProjectAssetServiceOtro$AggrRefresh: 0,
getContractStatuses$AggrRefresh: 0,
getSuppliers$AggrRefresh: -1,
getPaymentOptions$AggrRefresh: 1,
getPaymentTermSpecial$DataActRefresh: 0,
getOrderContractData$DataActRefresh: 0,
getOrderFilesList$DataActRefresh: 0,
getAccountingData$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getInsuranceTypes$AggrRefresh: [],
getDepositTypes$AggrRefresh: [],
getPaymentWays$AggrRefresh: [],
getAccountingDataTypes$AggrRefresh: [],
getBusinessValueCategories$AggrRefresh: [],
getOrderMainItemsByOrderMainId$AggrRefresh: [],
getAdvancedPaymentTypes$AggrRefresh: [],
getBusinessValueSubcategoriesByCategoryId$AggrRefresh: [],
getInvoiceUsages$AggrRefresh: [],
getFrequencies$AggrRefresh: [],
getProjectAssetServices$AggrRefresh: [],
getRejectComment$AggrRefresh: [],
getSupplierByRequisition$AggrRefresh: [],
getSpecialApprovals$AggrRefresh: [],
getPaymentTerms$AggrRefresh: [],
getPaymentMethods$AggrRefresh: [],
getOrderRetentionTypes$AggrRefresh: [],
getCurrencies$AggrRefresh: [],
getOrderMainById$AggrRefresh: ["getPaymentWays$AggrRefresh", "getBusinessValueSubcategoriesByCategoryId$AggrRefresh", "getSupplierByRequisition$AggrRefresh", "getSuppliers$AggrRefresh", "getPaymentOptions$AggrRefresh"],
getSpecialPostDeliveryAuthorizations$AggrRefresh: [],
getProjectAssetServiceOtro$AggrRefresh: [],
getContractStatuses$AggrRefresh: [],
getSuppliers$AggrRefresh: [],
getPaymentOptions$AggrRefresh: [],
getPaymentTermSpecial$DataActRefresh: [],
getOrderContractData$DataActRefresh: [],
getOrderFilesList$DataActRefresh: [],
getAccountingData$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
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
return controller.callServerAction("ApprovRejectOrder", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ActionApprovRejectOrder", "XUq3ADSWmTtz946jlce+mA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation$ActionApprovRejectOrder"))();
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
return controller.callServerAction("GetIsUserCxP", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ActionGetIsUserCxP", "fta9NfmxtZhlAN71d2CU6w", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation$ActionGetIsUserCxP"))();
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
return controller.callServerAction("SaveOrderDetail", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ActionSaveOrderDetail", "8bUUYXRDhmNPVkKX04isBA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation$ActionSaveOrderDetail"))();
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
return controller.callServerAction("SaveContractFile", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ActionSaveContractFile", "Z8yqXl5OlSHTHLD8JQVLAQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getInsuranceTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getInsuranceTypes$AggrRefresh"))) {
this._getInsuranceTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInsuranceTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetInsuranceTypes", "0kLj6620Ezk+l1bssUC0yw", maxRecords, startIndex, function (b) {
model.variables.getInsuranceTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInsuranceTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInsuranceTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInsuranceTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetInsuranceTypes");
span.setAttribute("outsystems.function.key", "08d6578d-efd7-4d32-8468-0ade450c749d");
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

get getDepositTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getDepositTypes$AggrRefresh"))) {
this._getDepositTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetDepositTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetDepositTypes", "xNMlgKuJEXDYt59dj4cBjw", maxRecords, startIndex, function (b) {
model.variables.getDepositTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDepositTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDepositTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetDepositTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetDepositTypes");
span.setAttribute("outsystems.function.key", "0e5bf6ca-71d6-4c56-9853-b1ce29980969");
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

get getPaymentWays$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentWays$AggrRefresh"))) {
this._getPaymentWays$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentWays", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetPaymentWays", "ksLZ9v9fiVInXkNX+iiybw", maxRecords, startIndex, function (b) {
model.variables.getPaymentWaysAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentWaysAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentWaysAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentWays", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentWays");
span.setAttribute("outsystems.function.key", "240e77e4-5a23-4811-bfbd-0131631a0525");
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

get getAccountingDataTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountingDataTypes$AggrRefresh"))) {
this._getAccountingDataTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountingDataTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetAccountingDataTypes", "GSdIV_2QnHAjbJAYrKgrwA", maxRecords, startIndex, function (b) {
model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingDataTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingDataTypes");
span.setAttribute("outsystems.function.key", "33d29aff-f8f5-408f-afef-cf1504460e1c");
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

get getBusinessValueCategories$AggrRefresh() {if(!(this.hasOwnProperty("_getBusinessValueCategories$AggrRefresh"))) {
this._getBusinessValueCategories$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBusinessValueCategories", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetBusinessValueCategories", "3K1jXP9IJF_nMwQ5zqcRyg", maxRecords, startIndex, function (b) {
model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBusinessValueCategoriesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBusinessValueCategoriesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBusinessValueCategories", function (span) {
if(span) {
span.setAttribute("code.function", "GetBusinessValueCategories");
span.setAttribute("outsystems.function.key", "4124aca8-5530-4793-8e83-90213e6afe3f");
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

get getOrderMainItemsByOrderMainId$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainItemsByOrderMainId$AggrRefresh"))) {
this._getOrderMainItemsByOrderMainId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainItemsByOrderMainId", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetOrderMainItemsByOrderMainId", "AG6iWE4JO8TzLOOrh0+jgA", maxRecords, startIndex, function (b) {
model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderMainItemsByOrderMainIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderMainItemsByOrderMainIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderMainItemsByOrderMainId", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainItemsByOrderMainId");
span.setAttribute("outsystems.function.key", "65ea08f9-b8d2-43b0-b642-e3c564823f7e");
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

get getAdvancedPaymentTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAdvancedPaymentTypes$AggrRefresh"))) {
this._getAdvancedPaymentTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAdvancedPaymentTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetAdvancedPaymentTypes", "hoLIYf+Dyd+VynjpRubgCg", maxRecords, startIndex, function (b) {
model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAdvancedPaymentTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAdvancedPaymentTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAdvancedPaymentTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAdvancedPaymentTypes");
span.setAttribute("outsystems.function.key", "65f70b3a-55d6-4a71-8891-21899417dabb");
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

get getBusinessValueSubcategoriesByCategoryId$AggrRefresh() {if(!(this.hasOwnProperty("_getBusinessValueSubcategoriesByCategoryId$AggrRefresh"))) {
this._getBusinessValueSubcategoriesByCategoryId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "OPm1pOj_KeAJWjXogYPfSQ", maxRecords, startIndex, function (b) {
model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBusinessValueSubcategoriesByCategoryId", function (span) {
if(span) {
span.setAttribute("code.function", "GetBusinessValueSubcategoriesByCategoryId");
span.setAttribute("outsystems.function.key", "6d1dbff6-23ec-4bbd-bde7-723f0cfbedc5");
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

get getInvoiceUsages$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceUsages$AggrRefresh"))) {
this._getInvoiceUsages$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceUsages", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetInvoiceUsages", "9K4ozixnDaUYQeFRQ9_iQQ", maxRecords, startIndex, function (b) {
model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceUsagesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceUsagesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceUsages", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceUsages");
span.setAttribute("outsystems.function.key", "7141e4fc-55ee-4a33-ba43-9e5412a97648");
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

get getFrequencies$AggrRefresh() {if(!(this.hasOwnProperty("_getFrequencies$AggrRefresh"))) {
this._getFrequencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFrequencies", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetFrequencies", "AzjepyCQFApZH_95qbpcQw", maxRecords, startIndex, function (b) {
model.variables.getFrequenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFrequenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFrequenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFrequencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetFrequencies");
span.setAttribute("outsystems.function.key", "82047ef5-587f-42ce-a927-b0ce2c5a06b9");
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

get getProjectAssetServices$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServices$AggrRefresh"))) {
this._getProjectAssetServices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetProjectAssetServices", "QmIftqTsNkC++1frUcNFQw", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "90f96309-22bc-4d38-8817-1b1b6c46d1ba");
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

get getRejectComment$AggrRefresh() {if(!(this.hasOwnProperty("_getRejectComment$AggrRefresh"))) {
this._getRejectComment$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRejectComment", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetRejectComment", "kSrfER1EWt2N4ouy+vFO3w", maxRecords, startIndex, function (b) {
model.variables.getRejectCommentAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRejectCommentAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRejectCommentAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRejectComment", function (span) {
if(span) {
span.setAttribute("code.function", "GetRejectComment");
span.setAttribute("outsystems.function.key", "9123deeb-6fdc-4d77-86e2-255f8b5b9fa0");
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

get getSupplierByRequisition$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierByRequisition$AggrRefresh"))) {
this._getSupplierByRequisition$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierByRequisition", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetSupplierByRequisition", "H3U5Elt6W9ibSLwdPH1HvQ", maxRecords, startIndex, function (b) {
model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierByRequisitionAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierByRequisitionAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierByRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByRequisition");
span.setAttribute("outsystems.function.key", "9bcb2a14-37b6-4296-b931-48a7fe1d8c74");
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

get getSpecialApprovals$AggrRefresh() {if(!(this.hasOwnProperty("_getSpecialApprovals$AggrRefresh"))) {
this._getSpecialApprovals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSpecialApprovals", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetSpecialApprovals", "vnJOYyFcujOLSxybVuL+qg", maxRecords, startIndex, function (b) {
model.variables.getSpecialApprovalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialApprovalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialApprovalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialApprovals", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialApprovals");
span.setAttribute("outsystems.function.key", "aadc29b3-61df-4db9-a126-50e7eafc58a1");
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

get getPaymentTerms$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentTerms$AggrRefresh"))) {
this._getPaymentTerms$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentTerms", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetPaymentTerms", "+6OhqwjTKpS9lXyr02rGqw", maxRecords, startIndex, function (b) {
model.variables.getPaymentTermsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTerms", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTerms");
span.setAttribute("outsystems.function.key", "bb3051d9-78af-419a-a521-d567b410ddc4");
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

get getPaymentMethods$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentMethods$AggrRefresh"))) {
this._getPaymentMethods$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentMethods", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetPaymentMethods", "npZ34hlfwoGQJHz7xDdwVw", maxRecords, startIndex, function (b) {
model.variables.getPaymentMethodsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentMethodsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentMethodsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentMethods", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentMethods");
span.setAttribute("outsystems.function.key", "c190032c-c351-4ded-9caf-29b319f527b6");
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

get getOrderRetentionTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderRetentionTypes$AggrRefresh"))) {
this._getOrderRetentionTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderRetentionTypes", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetOrderRetentionTypes", "iW+O1+oPx3_XDEqe18dTPQ", maxRecords, startIndex, function (b) {
model.variables.getOrderRetentionTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderRetentionTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderRetentionTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderRetentionTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderRetentionTypes");
span.setAttribute("outsystems.function.key", "d8fb4d84-feb0-4257-8269-953457e374df");
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

get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "db2ac1ac-5762-4690-a932-5bf87e52c271");
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

get getOrderMainById$AggrRefresh() {if(!(this.hasOwnProperty("_getOrderMainById$AggrRefresh"))) {
this._getOrderMainById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetOrderMainById", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetOrderMainById", "13fYgXR65HFVmrZ2ywJoHw", maxRecords, startIndex, function (b) {
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
span.setAttribute("outsystems.function.key", "e1045109-8ca8-4326-94e2-040f7df8590b");
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

get getSpecialPostDeliveryAuthorizations$AggrRefresh() {if(!(this.hasOwnProperty("_getSpecialPostDeliveryAuthorizations$AggrRefresh"))) {
this._getSpecialPostDeliveryAuthorizations$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSpecialPostDeliveryAuthorizations", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetSpecialPostDeliveryAuthorizations", "Y+TV7QGweLMoZLG_kLPK+w", maxRecords, startIndex, function (b) {
model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialPostDeliveryAuthorizationsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialPostDeliveryAuthorizationsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialPostDeliveryAuthorizations", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialPostDeliveryAuthorizations");
span.setAttribute("outsystems.function.key", "e4d47f30-7f5f-4ed6-8ab7-1f48f2a91405");
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

get getProjectAssetServiceOtro$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServiceOtro$AggrRefresh"))) {
this._getProjectAssetServiceOtro$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServiceOtro", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetProjectAssetServiceOtro", "z8ETxh4PZYxYihpoWu9+nA", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServiceOtroAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServiceOtroAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServiceOtro", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServiceOtro");
span.setAttribute("outsystems.function.key", "e542b2c0-60cc-438a-a8d0-a28b59ea99dd");
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

get getContractStatuses$AggrRefresh() {if(!(this.hasOwnProperty("_getContractStatuses$AggrRefresh"))) {
this._getContractStatuses$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetContractStatuses", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetContractStatuses", "dl5W+NgcsOF6re7ASrOsKA", maxRecords, startIndex, function (b) {
model.variables.getContractStatusesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getContractStatusesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getContractStatusesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetContractStatuses", function (span) {
if(span) {
span.setAttribute("code.function", "GetContractStatuses");
span.setAttribute("outsystems.function.key", "e864324a-5c8b-42a8-b455-4c5fee5a4883");
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

get getSuppliers$AggrRefresh() {if(!(this.hasOwnProperty("_getSuppliers$AggrRefresh"))) {
this._getSuppliers$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSuppliers", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetSuppliers", "MarLzvC0Ak57cuL9zvu4SQ", maxRecords, startIndex, function (b) {
model.variables.getSuppliersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSuppliersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSuppliersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSuppliers", function (span) {
if(span) {
span.setAttribute("code.function", "GetSuppliers");
span.setAttribute("outsystems.function.key", "fa3d5c75-4314-4520-ab6e-1f57226b99ba");
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

get getPaymentOptions$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentOptions$AggrRefresh"))) {
this._getPaymentOptions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentOptions", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/ScreenDataSetGetPaymentOptions", "KbZTSZCiHg_XFOVlv16P7g", maxRecords, startIndex, function (b) {
model.variables.getPaymentOptionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentOptionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentOptionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentOptions", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentOptions");
span.setAttribute("outsystems.function.key", "fe31fc88-e5d5-4631-9eb9-24299571fbc9");
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

get getPaymentTermSpecial$DataActRefresh() {if(!(this.hasOwnProperty("_getPaymentTermSpecial$DataActRefresh"))) {
this._getPaymentTermSpecial$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetPaymentTermSpecial", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/DataActionGetPaymentTermSpecial", "LgvHliYK+IN211qCoIq_3w", function (b) {
model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermSpecialDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermSpecialDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTermSpecial", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTermSpecial");
span.setAttribute("outsystems.function.key", "2f015864-814c-47e5-a171-47e1decab9a5");
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

get getOrderContractData$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderContractData$DataActRefresh"))) {
this._getOrderContractData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderContractData", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/DataActionGetOrderContractData", "uLSW9dgaKiYPwp0+6Wa8ug", function (b) {
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
span.setAttribute("outsystems.function.key", "4ee98934-63eb-4728-810a-ed92cad7e1a6");
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

get getOrderFilesList$DataActRefresh() {if(!(this.hasOwnProperty("_getOrderFilesList$DataActRefresh"))) {
this._getOrderFilesList$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetOrderFilesList", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/DataActionGetOrderFilesList", "iwVgKLM44h5Mf9QfrdV7Rg", function (b) {
model.variables.getOrderFilesListDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getOrderFilesListDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getOrderFilesListDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetOrderFilesList", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderFilesList");
span.setAttribute("outsystems.function.key", "987c8ff1-edb7-4caa-a02b-04bbd7ea3dd8");
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

get getAccountingData$DataActRefresh() {if(!(this.hasOwnProperty("_getAccountingData$DataActRefresh"))) {
this._getAccountingData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetAccountingData", "screenservices/ConectaProveedores/e_Orders/Wb_OrderDetailPaymentInformation/DataActionGetAccountingData", "Zd_MWC__YbLGroLDgfQTbw", function (b) {
model.variables.getAccountingDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingData", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingData");
span.setAttribute("outsystems.function.key", "f1fb6e5e-e3c5-46e3-8482-1734449b29b9");
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


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getInsuranceTypes$AggrRefresh", "getDepositTypes$AggrRefresh", "getPaymentWays$AggrRefresh", "getAccountingDataTypes$AggrRefresh", "getBusinessValueCategories$AggrRefresh", "getOrderMainItemsByOrderMainId$AggrRefresh", "getAdvancedPaymentTypes$AggrRefresh", "getBusinessValueSubcategoriesByCategoryId$AggrRefresh", "getInvoiceUsages$AggrRefresh", "getFrequencies$AggrRefresh", "getProjectAssetServices$AggrRefresh", "getRejectComment$AggrRefresh", "getSupplierByRequisition$AggrRefresh", "getSpecialApprovals$AggrRefresh", "getPaymentTerms$AggrRefresh", "getPaymentMethods$AggrRefresh", "getOrderRetentionTypes$AggrRefresh", "getCurrencies$AggrRefresh", "getOrderMainById$AggrRefresh", "getSpecialPostDeliveryAuthorizations$AggrRefresh", "getProjectAssetServiceOtro$AggrRefresh", "getContractStatuses$AggrRefresh", "getSuppliers$AggrRefresh", "getPaymentOptions$AggrRefresh", "getPaymentTermSpecial$DataActRefresh", "getOrderContractData$DataActRefresh", "getOrderFilesList$DataActRefresh", "getAccountingData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "0659455e-83a3-4a4f-b1ab-f6d93ab6b57b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Wb_CustomUploadOnFileChange$vars"))());
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
_dropdown_AccountingDataTypeOnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataTypeOnChange");
span.setAttribute("outsystems.function.key", "104ec097-3767-499d-92e1-85a6491141ed");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_AccountingDataTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_AccountingDataTypeOnChange$vars"))());
vars.value.i_AccountingDataTypeInLocal = i_AccountingDataTypeIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterForIgualaVar = new OS$DataTypes.VariableHolder();
var listFilterForEstimacionesVar = new OS$DataTypes.VariableHolder();
var listFilterForAgreedPaymentsVar = new OS$DataTypes.VariableHolder();
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ATvOyiPd00Ghsdk6zyFotw#Message.80107734.1", "You cannot have 2 Ugualas"), /*Info*/ 0);
} else {
// Execute Action: ListFilterForEstimaciones
listFilterForEstimacionesVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.estimation);
}, callContext);

// Second Record same Type?
if(((listFilterForEstimacionesVar.value.filteredListOut.length > 6))) {
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6EVRlyheV0e85Xo_NbIRKQ#Message.-1019087901.1", "You cannot have 7 Estimations"), /*Info*/ 0);
} else {
// Execute Action: ListFilterForAgreedPayments
listFilterForAgreedPaymentsVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.agreedPayments);
}, callContext);

// Second Record same Type?
if(((listFilterForAgreedPaymentsVar.value.filteredListOut.length > 6))) {
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3nyrx8lGG0ugtIyLTCLJSg#Message.1178440656.1", "You cannot have 7 Agreed Payments"), /*Info*/ 0);
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
_validations$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Validations", function (span) {
if(span) {
span.setAttribute("code.function", "Validations");
span.setAttribute("outsystems.function.key", "1d62c8e6-798e-4e26-9a44-493b7aa5d412");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Validations");
callContext = controller.callContext(callContext);
var dropdownClearValidation3Var = new OS$DataTypes.VariableHolder();
var dropdownClearValidationVar = new OS$DataTypes.VariableHolder();
var dropdownNotValidVar = new OS$DataTypes.VariableHolder();
var dropdownNotValid2Var = new OS$DataTypes.VariableHolder();
var dropdownNotValid3Var = new OS$DataTypes.VariableHolder();
var dropdownClearValidation2Var = new OS$DataTypes.VariableHolder();
// l_FormIsValid = True
model.variables.l_FormIsValidVar = true;
// l_RequestDocsErrorMessage = ""
model.variables.l_RequestDocsErrorMessageVar = "";
// l_IsMissingEstimEqualAgFiniquito = False
model.variables.l_IsMissingEstimEqualAgFiniquitoVar = false;
// Execute Action: DropdownClearValidation
dropdownClearValidationVar.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("Dropdown_projectassetservice"), callContext);

// Execute Action: DropdownClearValidation2
dropdownClearValidation2Var.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("Dropdown_BusinessCategoryValue"), callContext);

// Execute Action: DropdownClearValidation3
dropdownClearValidation3Var.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("Dropdown_BusinessCategorySubValue"), callContext);

// ProjectAssetServiceId
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: DropdownNotValid
dropdownNotValidVar.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("Dropdown_projectassetservice"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("sRVf45cZSEuownebL5A6Xw#Value.-1029745557.1", "This field is mandatory"), callContext);

// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
}

// BusinessValueCategoryId 
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueCategoryIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: DropdownNotValid2
dropdownNotValid2Var.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("Dropdown_BusinessCategoryValue"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KKFhDLu71kagZRxk9K5p3g#Value.-1029745557.1", "This field is mandatory"), callContext);

// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
}

// BusinessValueCategoryId 
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueSubcategoryIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: DropdownNotValid3
dropdownNotValid3Var.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("Dropdown_BusinessCategorySubValue"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9q+QzvnygkKE6QYCKeQxxQ#Value.-1029745557.1", "This field is mandatory"), callContext);

// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
}

// No Contract File?
if(((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes) && (OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) || (model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr === ""))) && model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetOrderContractData.o_ContractFile.Valid.IsValid = False
model.variables.getOrderContractDataDataAct.o_ContractFileOut.validAttr.isValidAttr = false;
// GetOrderContractData.o_ContractFile.Valid.ValidationMessage = "This field is mandatory"
model.variables.getOrderContractDataDataAct.o_ContractFileOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gew_QxN9aE2UwoRUJhs9sA#Value.-1029745557.1", "This field is mandatory");
}

// No Order Files and Has Request
if(((model.variables.l_OrderRequestFilesVar.isEmpty && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// l_RequestDocsErrorMessage = "You need to request at least a file!"
model.variables.l_RequestDocsErrorMessageVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("R4DG6sPscEiwA7Dhk7AUMg#Value.2074211503.1", "You need to request at least a file!");
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
_dropdown_InsuranceTypeOnChange$Action(i_InsuranceTypeIdIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_InsuranceTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InsuranceTypeOnChange");
span.setAttribute("outsystems.function.key", "2778e902-a4b8-4cea-920d-912802e5463b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_InsuranceTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_InsuranceTypeOnChange$vars"))());
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Wa55cqDUTkeOmndCKJUfwg#Message.-1556557250.1", "You cannot have multiple Insurances of same type"), /*Info*/ 0);
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
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "29b3b87b-ca12-4c13-8bb6-4d8b4591afb4");
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
_dropdown_AccountingDataType5OnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataType5OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataType5OnChange");
span.setAttribute("outsystems.function.key", "59250437-221a-4a98-8872-f45d192ac37b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_AccountingDataType5OnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_AccountingDataType5OnChange$vars"))());
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3UL_825E_EivTikcbD0Pjw#Message.-663497229.1", "You cannot have multiple same types"), /*Info*/ 0);
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
span.setAttribute("outsystems.function.key", "60c86136-b830-4510-8e38-d741c5fb8b9e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.RemoveFromList$vars"))());
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
_approve$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Approve", function (span) {
if(span) {
span.setAttribute("code.function", "Approve");
span.setAttribute("outsystems.function.key", "6ad79395-0dd0-4256-8cb4-565209f1b3c2");
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VABzRAsgfke8fBWf9gfAzg#Message.637262369.1", "Order approved with success!"), /*Success*/ 1);
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
_showHideOrderReject_Popup$Action(i_IsRefreshIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideOrderReject_Popup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideOrderReject_Popup");
span.setAttribute("outsystems.function.key", "6dda13fa-c67c-47fb-9bc0-e8a52e8994d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideOrderReject_Popup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.ShowHideOrderReject_Popup$vars"))());
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
_dropdown_DepositTypeOnChange$Action(i_DepositTypeIdIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_DepositTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DepositTypeOnChange");
span.setAttribute("outsystems.function.key", "725b4352-9d11-465a-90d2-8fc6ae67fdd3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_DepositTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_DepositTypeOnChange$vars"))());
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("e3Mg3oURZ0CQUQMFBHXWxg#Message.-322431486.1", "You cannot have multiple Deposits of same type"), /*Info*/ 0);
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
_getOrderMainByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderMainByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "76375d35-8380-4718-8a31-17caa8213774");
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
_getOrderContractDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetOrderContractDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderContractDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "76e56b25-6375-4975-841b-0768a28121bd");
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
_input_RetentionOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Input_RetentionOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Input_RetentionOnChange");
span.setAttribute("outsystems.function.key", "7b2f314c-e200-4937-9fe9-9e486f76d45b");
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
_onClickSave$Action(isFinishIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickSave", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSave");
span.setAttribute("outsystems.function.key", "890df1af-c728-4e7e-bc87-ce0d82ec0941");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnClickSave");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.OnClickSave$vars"))());
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
OS$FeedbackMessageService.showFeedbackMessage(((model.variables.l_IsMissingEstimEqualAgFiniquitoVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3SRAt91I6kaijj5TyDH1DA#Message.-246665552.1", "You need to select at least one payment. You need at least one payment of Estimation/Equalization/AgreedPayments or Settlement.")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3SRAt91I6kaijj5TyDH1DA#Message.-1752268912.1", "Some mandatory fields are not being filled"))), /*Error*/ 3);
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
OS$FeedbackMessageService.showFeedbackMessage(((vars.value.isFinishInLocal) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V8_p51+lFUaT3KWleiXmzw#Message.-1258891452.1", "Your request was successfully sent to approval")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("V8_p51+lFUaT3KWleiXmzw#Message.-610115733.1", "Changes successfully saved"))), /*Success*/ 1);
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
OS$Logger.debug("Wb_OrderDetailPaymentInformation.OnClickSave", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "77015f3f-5a84-46ae-98f7-bfd6d90229e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("32LPZ6X5nEavoHfT30JmSg#Message.-1973574713.1", "There was a problem. Please contact the administrator"), /*Error*/ 3);
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
_saveContractFile$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveContractFile", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractFile");
span.setAttribute("outsystems.function.key", "9e7124a0-c17e-4958-9b63-af8c4f01044d");
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qNTzSJLz_0ebxJYRoJb6Yw#Message.-967893839.1", "Make sure you upload a file with content and a filename!"), /*Error*/ 3);
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
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EG2Gqzs7GE23S77BRywY8g#Message.-940469518.1", "Contract file upload is not available!"), /*Error*/ 3);
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
_switch_OnChange$Action(contractFileTypeIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_OnChange");
span.setAttribute("outsystems.function.key", "a2e70e4a-c1f6-4938-9476-98c1dedde651");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_OnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Switch_OnChange$vars"))());
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
_listOfFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ListOfFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ListOfFiles");
span.setAttribute("outsystems.function.key", "b70416a5-fd25-4e20-b80d-2e579645b205");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ListOfFiles");
callContext = controller.callContext(callContext);
var listFilter2Var = new OS$DataTypes.VariableHolder();
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.filesListVar, callContext);
// HasFinaceAuth?
if(((!(OS$DataTypes.areBinaryNulls(model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
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
if((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending) && (!(OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getOrderContractDataDataAct.o_ContractPendingJustificationOut.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))))) {
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
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut, function (p) {
return (!(OS$DataTypes.areBinaryNulls(p.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(p.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, callContext);

// Execute Action: ListAppendAllDeposit
OS$SystemActions.listAppendAll(model.variables.filesListVar, listFilterVar.value.filteredListOut, callContext);
}

// Has Insurance?
if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasInsuranceAttr)) {
// Execute Action: ListFilter2
listFilter2Var.value = OS$SystemActions.listFilter(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut, function (p) {
return (!(OS$DataTypes.areBinaryNulls(p.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(p.orderFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, callContext);

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
_dropdown_InvoiceUsageItemOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_InvoiceUsageItemOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InvoiceUsageItemOnChange");
span.setAttribute("outsystems.function.key", "d9082879-be76-428d-ad63-f5755510a242");
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
_addRecord$Action(i_IsDepositIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddRecord", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "dc27af01-7d37-41fd-bfc3-12e99e591578");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AddRecord");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.AddRecord$vars"))());
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
_dropdown_BusinessCategoryValueOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_BusinessCategoryValueOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_BusinessCategoryValueOnChange");
span.setAttribute("outsystems.function.key", "e6e2dcaa-c48a-4c3f-b9fc-bf7d955ce6b5");
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
_wb_OrderDetail_AttachmentsUploadMainParent$Action(orderRequestFilesInIn, hasntRequestDocumentsIn, isValidIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_OrderDetail_AttachmentsUploadMainParent", function (span) {
if(span) {
span.setAttribute("code.function", "wb_OrderDetail_AttachmentsUploadMainParent");
span.setAttribute("outsystems.function.key", "f51f1bf2-972a-425d-be35-26ffebf41038");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_OrderDetail_AttachmentsUploadMainParent");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.wb_OrderDetail_AttachmentsUploadMainParent$vars"))());
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
_clearFields$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearFields", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFields");
span.setAttribute("outsystems.function.key", "fc9e1ae3-6508-41e6-b9cf-e657e5f26637");
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

wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "0659455e-83a3-4a4f-b1ab-f6d93ab6b57b");
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

dropdown_AccountingDataTypeOnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataTypeOnChange");
span.setAttribute("outsystems.function.key", "104ec097-3767-499d-92e1-85a6491141ed");
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

validations$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Validations__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Validations");
span.setAttribute("outsystems.function.key", "1d62c8e6-798e-4e26-9a44-493b7aa5d412");
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

dropdown_InsuranceTypeOnChange$Action(i_InsuranceTypeIdIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_InsuranceTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InsuranceTypeOnChange");
span.setAttribute("outsystems.function.key", "2778e902-a4b8-4cea-920d-912802e5463b");
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

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "29b3b87b-ca12-4c13-8bb6-4d8b4591afb4");
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

dropdown_AccountingDataType5OnChange$Action(i_AccountingDataTypeIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_AccountingDataType5OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AccountingDataType5OnChange");
span.setAttribute("outsystems.function.key", "59250437-221a-4a98-8872-f45d192ac37b");
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

removeFromList$Action(i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, is_Estim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "60c86136-b830-4510-8e38-d741c5fb8b9e");
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

approve$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Approve__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Approve");
span.setAttribute("outsystems.function.key", "6ad79395-0dd0-4256-8cb4-565209f1b3c2");
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

showHideOrderReject_Popup$Action(i_IsRefreshIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideOrderReject_Popup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideOrderReject_Popup");
span.setAttribute("outsystems.function.key", "6dda13fa-c67c-47fb-9bc0-e8a52e8994d8");
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

dropdown_DepositTypeOnChange$Action(i_DepositTypeIdIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_DepositTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DepositTypeOnChange");
span.setAttribute("outsystems.function.key", "725b4352-9d11-465a-90d2-8fc6ae67fdd3");
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

getOrderMainByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderMainByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderMainByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "76375d35-8380-4718-8a31-17caa8213774");
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

getOrderContractDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetOrderContractDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetOrderContractDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "76e56b25-6375-4975-841b-0768a28121bd");
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

input_RetentionOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Input_RetentionOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Input_RetentionOnChange");
span.setAttribute("outsystems.function.key", "7b2f314c-e200-4937-9fe9-9e486f76d45b");
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

onClickSave$Action(isFinishIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickSave__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickSave");
span.setAttribute("outsystems.function.key", "890df1af-c728-4e7e-bc87-ce0d82ec0941");
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

saveContractFile$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveContractFile__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractFile");
span.setAttribute("outsystems.function.key", "9e7124a0-c17e-4958-9b63-af8c4f01044d");
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

switch_OnChange$Action(contractFileTypeIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_OnChange");
span.setAttribute("outsystems.function.key", "a2e70e4a-c1f6-4938-9476-98c1dedde651");
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

listOfFiles$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ListOfFiles__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ListOfFiles");
span.setAttribute("outsystems.function.key", "b70416a5-fd25-4e20-b80d-2e579645b205");
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

dropdown_InvoiceUsageItemOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_InvoiceUsageItemOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InvoiceUsageItemOnChange");
span.setAttribute("outsystems.function.key", "d9082879-be76-428d-ad63-f5755510a242");
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

addRecord$Action(i_IsDepositIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsCreditNoteIn, i_IsVoucherIn, i_IsfiniquitoIn, i_IsAnticipoIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddRecord__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "dc27af01-7d37-41fd-bfc3-12e99e591578");
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

dropdown_BusinessCategoryValueOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_BusinessCategoryValueOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_BusinessCategoryValueOnChange");
span.setAttribute("outsystems.function.key", "e6e2dcaa-c48a-4c3f-b9fc-bf7d955ce6b5");
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

wb_OrderDetail_AttachmentsUploadMainParent$Action(orderRequestFilesInIn, hasntRequestDocumentsIn, isValidIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_OrderDetail_AttachmentsUploadMainParent__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_OrderDetail_AttachmentsUploadMainParent");
span.setAttribute("outsystems.function.key", "f51f1bf2-972a-425d-be35-26ffebf41038");
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

clearFields$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearFields__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearFields");
span.setAttribute("outsystems.function.key", "fc9e1ae3-6508-41e6-b9cf-e657e5f26637");
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation$ActionApprovRejectOrder", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation$ActionGetIsUserCxP", [{
name: "o_Value",
attrName: "o_ValueOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation$ActionSaveOrderDetail", [{
name: "ErrorMsg",
attrName: "errorMsgOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Wb_CustomUploadOnFileChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_AccountingDataTypeOnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_InsuranceTypeOnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_AccountingDataType5OnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.RemoveFromList$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.ShowHideOrderReject_Popup$vars", [{
name: "i_IsRefresh",
attrName: "i_IsRefreshInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Dropdown_DepositTypeOnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.OnClickSave$vars", [{
name: "IsFinish",
attrName: "isFinishInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.Switch_OnChange$vars", [{
name: "ContractFileTypeId",
attrName: "contractFileTypeIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.AddRecord$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.wb_OrderDetail_AttachmentsUploadMainParent$vars", [{
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

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


