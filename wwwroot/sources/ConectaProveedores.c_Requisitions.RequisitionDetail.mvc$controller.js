import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, SystemActions as OS$SystemActions, GenericTypeCache as OS$GenericTypeCache, FeedbackMessageService as OS$FeedbackMessageService, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions, Navigation as OS$Navigation, Authorization as OS$Authorization } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { hideLoading$Action as ConectaProveedoresController$hideLoading$Action, showLoading$Action as ConectaProveedoresController$showLoading$Action, getUserRegion$Action as ConectaProveedoresController$getUserRegion$Action, generateReqName$Action as ConectaProveedoresController$generateReqName$Action } from "./ConectaProveedores.controller.js";
import { SE_contractFileType as ConectaProveedores_staticEntities_contractFileType, SE_accountingDataType as ConectaProveedores_staticEntities_accountingDataType, SE_concept as ConectaProveedores_staticEntities_concept, SE_advancePaymentType as ConectaProveedores_staticEntities_advancePaymentType, SE_distribution as ConectaProveedores_staticEntities_distribution, SE_currency as ConectaProveedores_staticEntities_currency, SE_requisitionStatus as ConectaProveedores_staticEntities_requisitionStatus, SE_origin as ConectaProveedores_staticEntities_origin, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import { ST_26b16bea631cbd94cf555acb5c7a4be3Structure, EN_aeab0089a9236dfc6c684ea98f650647EntityRecord, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord, RC_f80fde4acf9a7dc465a1d535c05dfb8e, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, RC_44742d4360afdf16ff97b37b2eff1760, ST_046fb53ebbe142526d95e87ef1ae9711Structure, RC_cc86cc41f7a6d52842bfa86c15f13d61, RC_ee67c405f78e15f46603b032a29fae74 } from "./ConectaProveedores.model.js";
import { EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord } from "./Organization.model.js";
import { sidebarOpen$Action as OutSystemsUIController$sidebarOpen$Action, datePickerOpen$Action as OutSystemsUIController$datePickerOpen$Action, dropdownClearValidation$Action as OutSystemsUIController$dropdownClearValidation$Action, dropdownNotValid$Action as OutSystemsUIController$dropdownNotValid$Action, sidebarClose$Action as OutSystemsUIController$sidebarClose$Action } from "./OutSystemsUI.controller.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_c_Requisitions_RequisitionDetail_mvc_controller_OnReady_JavaScriptJS from "./ConectaProveedores.c_Requisitions.RequisitionDetail.mvc$controller.OnReady.JavaScriptJS.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import ConectaProveedores_c_Requisitions_RequisitionDetail_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.RequisitionDetail.mvc$translationsResources.js";
import ConectaProveedores_c_RequisitionsController$default from "./ConectaProveedores.c_Requisitions.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_RequisitionDetail_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getFrequencies$AggrRefresh: 0,
getUserById$AggrRefresh: -1,
getPaymentTerms$AggrRefresh: 0,
getSpecialPostDeliveryAuthorizations$AggrRefresh: 0,
getPaymentWays$AggrRefresh: -1,
getAdvancedPaymentTypes$AggrRefresh: 0,
getProjectAssetServices$AggrRefresh: 0,
getInsuranceTypes$AggrRefresh: 0,
getCostCenters$AggrRefresh: -1,
getDocumentTypeAnticipoKW$AggrRefresh: 0,
getAccountableGuide$AggrRefresh: -1,
getAccountingAccountsServiceTypes$AggrRefresh: 0,
getSupplierSocieties$AggrRefresh: -1,
getProjectAssetByRequisition$AggrRefresh: -1,
getCurrencies$AggrRefresh: 0,
getPaymentOptions$AggrRefresh: -1,
getSustainabilities$AggrRefresh: 0,
getInvoiceUsages$AggrRefresh: 0,
getCostCenterSAPByRequisitionId$AggrRefresh: -1,
getProjectAssetServiceOtro$AggrRefresh: 0,
getPaymentWay99$AggrRefresh: -1,
getAccountingDataTypes$AggrRefresh: 0,
getServiceFormats$AggrRefresh: 0,
getDistributions$AggrRefresh: 0,
getBusinessValueCategories$AggrRefresh: 0,
getRequisitionServicesByRequisitionId$AggrRefresh: 0,
getBusinessValueSubcategoriesByCategoryId$AggrRefresh: -1,
getEntraRole$AggrRefresh: 0,
getRequisitionCostCentersByRequisitionId$AggrRefresh: -1,
getSupplierByRequisition$AggrRefresh: -1,
getDocumentTypeKR$AggrRefresh: 0,
getSupplierDetailBySociety$AggrRefresh: -1,
getRequisitionById$AggrRefresh: -1,
getDepositTypes$AggrRefresh: 0,
getRequisitionContractData$DataActRefresh: -1,
getShowSelectReqPopup$DataActRefresh: 0,
getAdvWithoutInvoiceData$DataActRefresh: 0,
getConfiguration$DataActRefresh: 0,
getAccountingData$DataActRefresh: -1,
getShowIsDonation$DataActRefresh: 0,
getSettings$DataActRefresh: 0,
getRequisitionFiles$DataActRefresh: 0,
getUserApplicationRoles$DataActRefresh: -1,
getPaymentMethodsBySupplierId$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getFrequencies$AggrRefresh: [],
getUserById$AggrRefresh: [],
getPaymentTerms$AggrRefresh: [],
getSpecialPostDeliveryAuthorizations$AggrRefresh: [],
getPaymentWays$AggrRefresh: [],
getAdvancedPaymentTypes$AggrRefresh: [],
getProjectAssetServices$AggrRefresh: [],
getInsuranceTypes$AggrRefresh: [],
getCostCenters$AggrRefresh: [],
getDocumentTypeAnticipoKW$AggrRefresh: [],
getAccountableGuide$AggrRefresh: [],
getAccountingAccountsServiceTypes$AggrRefresh: [],
getSupplierSocieties$AggrRefresh: [],
getProjectAssetByRequisition$AggrRefresh: [],
getCurrencies$AggrRefresh: [],
getPaymentOptions$AggrRefresh: [],
getSustainabilities$AggrRefresh: [],
getInvoiceUsages$AggrRefresh: [],
getCostCenterSAPByRequisitionId$AggrRefresh: [],
getProjectAssetServiceOtro$AggrRefresh: [],
getPaymentWay99$AggrRefresh: [],
getAccountingDataTypes$AggrRefresh: [],
getServiceFormats$AggrRefresh: [],
getDistributions$AggrRefresh: [],
getBusinessValueCategories$AggrRefresh: [],
getRequisitionServicesByRequisitionId$AggrRefresh: [],
getBusinessValueSubcategoriesByCategoryId$AggrRefresh: [],
getEntraRole$AggrRefresh: [],
getRequisitionCostCentersByRequisitionId$AggrRefresh: [],
getSupplierByRequisition$AggrRefresh: [],
getDocumentTypeKR$AggrRefresh: [],
getSupplierDetailBySociety$AggrRefresh: ["getPaymentMethodsBySupplierId$DataActRefresh"],
getRequisitionById$AggrRefresh: ["getUserById$AggrRefresh", "getPaymentWays$AggrRefresh", "getCostCenters$AggrRefresh", "getAccountableGuide$AggrRefresh", "getSupplierSocieties$AggrRefresh", "getProjectAssetByRequisition$AggrRefresh", "getPaymentOptions$AggrRefresh", "getBusinessValueSubcategoriesByCategoryId$AggrRefresh", "getSupplierByRequisition$AggrRefresh", "getSupplierDetailBySociety$AggrRefresh"],
getDepositTypes$AggrRefresh: [],
getRequisitionContractData$DataActRefresh: [],
getShowSelectReqPopup$DataActRefresh: [],
getAdvWithoutInvoiceData$DataActRefresh: [],
getConfiguration$DataActRefresh: [],
getAccountingData$DataActRefresh: [],
getShowIsDonation$DataActRefresh: [],
getSettings$DataActRefresh: [],
getRequisitionFiles$DataActRefresh: [],
getUserApplicationRoles$DataActRefresh: ["getRequisitionById$AggrRefresh"],
getPaymentMethodsBySupplierId$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
getIsForSpecialWorkflow$ServerAction(userIdIn, isDonationIn, processTypeCodeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetIsForSpecialWorkflow", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsForSpecialWorkflow");
span.setAttribute("outsystems.function.key", "74839c6c-2dda-4cf9-9e55-40d335b298a1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserId: OS$DataConversion.ServerDataConverter.to(userIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IsDonation: OS$DataConversion.ServerDataConverter.to(isDonationIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
ProcessTypeCode: OS$DataConversion.ServerDataConverter.to(processTypeCodeIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetIsForSpecialWorkflow", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionGetIsForSpecialWorkflow", "nyveEdaaGnRJsHq2FgEAQw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionGetIsForSpecialWorkflow"))();
executeServerActionResult.isForSpecialWorkflowOut = OS$DataConversion.ServerDataConverter.from(outputs.IsForSpecialWorkflow, OS$DataTypes.DataTypes.Boolean);
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
approveRequisitionAccounting$ServerAction(i_RequisitionIn, i_RequisitionApprovalLevelIdIn, offsetUtcIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveRequisitionAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRequisitionAccounting");
span.setAttribute("outsystems.function.key", "e32ff10c-c525-4d46-9d1c-74cfd1f04bd8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Requisition: OS$DataConversion.ServerDataConverter.to(i_RequisitionIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_RequisitionApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_RequisitionApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApproveRequisitionAccounting", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionApproveRequisitionAccounting", "OWWgmAXRbJoQaxVkmZo_EA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionApproveRequisitionAccounting"))();
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
requisitionCancel$ServerAction(i_RequisitionIdIn, i_RequisitionApprovalLevelIdIn, i_CancelReasonIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RequisitionCancel", function (span) {
if(span) {
span.setAttribute("code.function", "RequisitionCancel");
span.setAttribute("outsystems.function.key", "01f1538f-b892-4923-9da1-2d68a8666f63");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_RequisitionApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_RequisitionApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_CancelReason: OS$DataConversion.ServerDataConverter.to(i_CancelReasonIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("RequisitionCancel", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionRequisitionCancel", "t_Cz8TUtEbxHcmD_3NS1BQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionRequisitionCancel"))();
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
getIsCorporativoCxPFromUAR$ServerAction(i_ConceptIdIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetIsCorporativoCxPFromUAR", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsCorporativoCxPFromUAR");
span.setAttribute("outsystems.function.key", "11c9f89f-492c-4dec-b015-c8dfe0995eb9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ConceptId: OS$DataConversion.ServerDataConverter.to(i_ConceptIdIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetIsCorporativoCxPFromUAR", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionGetIsCorporativoCxPFromUAR", "7YjwFrGkIiE_47Mb_0MgLw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionGetIsCorporativoCxPFromUAR"))();
executeServerActionResult.o_IsFromCorporativoOut = OS$DataConversion.ServerDataConverter.from(outputs.o_IsFromCorporativo, OS$DataTypes.DataTypes.Boolean);
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
approvModifReq$ServerAction(i_RequisitionIdIn, i_RequisitionApprovalLevelIdIn, i_IsApproveIn, i_CommentIn, offsetUtcIn, i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApprovModifReq", function (span) {
if(span) {
span.setAttribute("code.function", "ApprovModifReq");
span.setAttribute("outsystems.function.key", "d9c5608c-7e94-4e74-aa02-418c0dbd29bb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_RequisitionApprovalLevelId: OS$DataConversion.ServerDataConverter.to(i_RequisitionApprovalLevelIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_IsApprove: OS$DataConversion.ServerDataConverter.to(i_IsApproveIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_Comment: OS$DataConversion.ServerDataConverter.to(i_CommentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(offsetUtcIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ApprovModifReq", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionApprovModifReq", "edod8NCxISGEGK70q5rSdA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionApprovModifReq"))();
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
getIsShowAssignFirstApproverPopup$ServerAction(userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetIsShowAssignFirstApproverPopup", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsShowAssignFirstApproverPopup");
span.setAttribute("outsystems.function.key", "b72e8b36-bae5-400f-b611-fa4fe08ed6c4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserId: OS$DataConversion.ServerDataConverter.to(userIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetIsShowAssignFirstApproverPopup", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionGetIsShowAssignFirstApproverPopup", "JGsXGIRYn8uOWvGvhG5tUA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionGetIsShowAssignFirstApproverPopup"))();
executeServerActionResult.isShowOut = OS$DataConversion.ServerDataConverter.from(outputs.IsShow, OS$DataTypes.DataTypes.Boolean);
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
saveRequisition$ServerAction(i_RequisitionIn, i_IsFinishCaptureIn, i_IsNewVersionIn, i_CreateForUserIn, approvalProcessIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "SaveRequisition");
span.setAttribute("outsystems.function.key", "8712a6e2-f6d8-4f99-93f7-6c2e10a62d8e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Requisition: OS$DataConversion.ServerDataConverter.to(i_RequisitionIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_IsFinishCapture: OS$DataConversion.ServerDataConverter.to(i_IsFinishCaptureIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_IsNewVersion: OS$DataConversion.ServerDataConverter.to(i_IsNewVersionIn, {
dataType: OS$DataTypes.DataTypes.Boolean,
pendingPromises: pendingPromises
}),
i_CreateForUser: OS$DataConversion.ServerDataConverter.to(i_CreateForUserIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
ApprovalProcessId: OS$DataConversion.ServerDataConverter.to(approvalProcessIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SaveRequisition", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionSaveRequisition", "MDGWDzgVlPO4OgHad5sFUA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionSaveRequisition"))();
executeServerActionResult.o_OutputOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Output, ST_046fb53ebbe142526d95e87ef1ae9711Structure);
executeServerActionResult.o_RequisitionIdOut = OS$DataConversion.ServerDataConverter.from(outputs.o_RequisitionId, OS$DataTypes.DataTypes.LongInteger);
executeServerActionResult.o_HasChangedStatusOut = OS$DataConversion.ServerDataConverter.from(outputs.o_HasChangedStatus, OS$DataTypes.DataTypes.Boolean);
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
saveContractPendingInfo$ServerAction(i_RequisitionIn, i_RequisitionFileTypesStructIn, i_OG_DateOfCommitmentIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveContractPendingInfo", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractPendingInfo");
span.setAttribute("outsystems.function.key", "bf53efa2-b5d1-47fd-8742-a14b58679029");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Requisition: OS$DataConversion.ServerDataConverter.to(i_RequisitionIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_RequisitionFileTypesStruct: OS$DataConversion.ServerDataConverter.to(i_RequisitionFileTypesStructIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
}),
i_OG_DateOfCommitment: OS$DataConversion.ServerDataConverter.to(i_OG_DateOfCommitmentIn, {
dataType: OS$DataTypes.DataTypes.Date,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SaveContractPendingInfo", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionSaveContractPendingInfo", "8TJhVlKyY1M6AGLprL2y7A", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
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
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
get getFrequencies$AggrRefresh() {if(!(this.hasOwnProperty("_getFrequencies$AggrRefresh"))) {
this._getFrequencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetFrequencies", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetFrequencies", "AzjepyCQFApZH_95qbpcQw", maxRecords, startIndex, function (b) {
model.variables.getFrequenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getFrequenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getFrequenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetFrequencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetFrequencies");
span.setAttribute("outsystems.function.key", "06ed67a3-accb-4b7d-acdf-389b8a4867a2");
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

get getUserById$AggrRefresh() {if(!(this.hasOwnProperty("_getUserById$AggrRefresh"))) {
this._getUserById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserById", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetUserById", "Lu5CdVoA_dZJHFmwxG6+Sg", maxRecords, startIndex, function (b) {
model.variables.getUserByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserById", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserById");
span.setAttribute("outsystems.function.key", "1ab7cb97-a112-46c7-a1bd-4e7878487e4a");
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

return this._getUserById$AggrRefresh;
}set getUserById$AggrRefresh(value) {this._getUserById$AggrRefresh = value;
}

get getPaymentTerms$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentTerms$AggrRefresh"))) {
this._getPaymentTerms$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentTerms", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetPaymentTerms", "+6OhqwjTKpS9lXyr02rGqw", maxRecords, startIndex, function (b) {
model.variables.getPaymentTermsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTerms", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTerms");
span.setAttribute("outsystems.function.key", "1e7c98c1-097d-45f2-9d9e-5d0aca1edebc");
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

get getSpecialPostDeliveryAuthorizations$AggrRefresh() {if(!(this.hasOwnProperty("_getSpecialPostDeliveryAuthorizations$AggrRefresh"))) {
this._getSpecialPostDeliveryAuthorizations$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSpecialPostDeliveryAuthorizations", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetSpecialPostDeliveryAuthorizations", "Y+TV7QGweLMoZLG_kLPK+w", maxRecords, startIndex, function (b) {
model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSpecialPostDeliveryAuthorizationsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSpecialPostDeliveryAuthorizationsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSpecialPostDeliveryAuthorizations", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialPostDeliveryAuthorizations");
span.setAttribute("outsystems.function.key", "2d4bb10c-db1e-4b07-a8a5-d7dddb2d6985");
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

get getPaymentWays$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentWays$AggrRefresh"))) {
this._getPaymentWays$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentWays", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetPaymentWays", "ksLZ9v9fiVInXkNX+iiybw", maxRecords, startIndex, function (b) {
model.variables.getPaymentWaysAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentWaysAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentWaysAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentWays", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentWays");
span.setAttribute("outsystems.function.key", "39a04d7a-6e0b-40c7-bdc7-3814b48a6ea9");
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

get getAdvancedPaymentTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAdvancedPaymentTypes$AggrRefresh"))) {
this._getAdvancedPaymentTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAdvancedPaymentTypes", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetAdvancedPaymentTypes", "hqarK6sC984ovwvfeAzylg", maxRecords, startIndex, function (b) {
model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAdvancedPaymentTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAdvancedPaymentTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAdvancedPaymentTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAdvancedPaymentTypes");
span.setAttribute("outsystems.function.key", "3cbfaa3d-6c44-4129-87ce-3c23cc5f85de");
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

get getProjectAssetServices$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServices$AggrRefresh"))) {
this._getProjectAssetServices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetProjectAssetServices", "FfqLkGjlF9nFE9ew73TmYg", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "42fbfa56-f87a-4a6b-b15e-3004715c6858");
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

get getInsuranceTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getInsuranceTypes$AggrRefresh"))) {
this._getInsuranceTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInsuranceTypes", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetInsuranceTypes", "0kLj6620Ezk+l1bssUC0yw", maxRecords, startIndex, function (b) {
model.variables.getInsuranceTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInsuranceTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInsuranceTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInsuranceTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetInsuranceTypes");
span.setAttribute("outsystems.function.key", "46766af9-5fb9-4ba1-9d19-4b603b8355ec");
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

get getCostCenters$AggrRefresh() {if(!(this.hasOwnProperty("_getCostCenters$AggrRefresh"))) {
this._getCostCenters$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCostCenters", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetCostCenters", "+LM+H9dP71kdpAQW3pvlww", maxRecords, startIndex, function (b) {
model.variables.getCostCentersAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCostCentersAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCostCentersAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCostCenters", function (span) {
if(span) {
span.setAttribute("code.function", "GetCostCenters");
span.setAttribute("outsystems.function.key", "477d92fa-aa7a-46d4-b290-01f87ad493c7");
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

return this._getCostCenters$AggrRefresh;
}set getCostCenters$AggrRefresh(value) {this._getCostCenters$AggrRefresh = value;
}

get getDocumentTypeAnticipoKW$AggrRefresh() {if(!(this.hasOwnProperty("_getDocumentTypeAnticipoKW$AggrRefresh"))) {
this._getDocumentTypeAnticipoKW$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetDocumentTypeAnticipoKW", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetDocumentTypeAnticipoKW", "p8X4c++qiQB+kEcnXAkbTQ", maxRecords, startIndex, function (b) {
model.variables.getDocumentTypeAnticipoKWAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDocumentTypeAnticipoKWAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDocumentTypeAnticipoKWAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetDocumentTypeAnticipoKW", function (span) {
if(span) {
span.setAttribute("code.function", "GetDocumentTypeAnticipoKW");
span.setAttribute("outsystems.function.key", "5038f60e-24b7-43e5-a6c4-b626517ec796");
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

return this._getDocumentTypeAnticipoKW$AggrRefresh;
}set getDocumentTypeAnticipoKW$AggrRefresh(value) {this._getDocumentTypeAnticipoKW$AggrRefresh = value;
}

get getAccountableGuide$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountableGuide$AggrRefresh"))) {
this._getAccountableGuide$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountableGuide", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetAccountableGuide", "NRpuHi6Fm6RJclIzkTLvog", maxRecords, startIndex, function (b) {
model.variables.getAccountableGuideAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountableGuideAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountableGuideAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getAccountableGuideOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountableGuide", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountableGuide");
span.setAttribute("outsystems.function.key", "5d4f50ff-cc22-4670-830e-7d892127aa7f");
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

return this._getAccountableGuide$AggrRefresh;
}set getAccountableGuide$AggrRefresh(value) {this._getAccountableGuide$AggrRefresh = value;
}

get getAccountingAccountsServiceTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountingAccountsServiceTypes$AggrRefresh"))) {
this._getAccountingAccountsServiceTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountingAccountsServiceTypes", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetAccountingAccountsServiceTypes", "RQnj2rC7UL6_VGnODKsX3w", maxRecords, startIndex, function (b) {
model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingAccountsServiceTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingAccountsServiceTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingAccountsServiceTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingAccountsServiceTypes");
span.setAttribute("outsystems.function.key", "5fc8b6a1-0d72-47ea-87bf-4501320854b6");
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

return this._getAccountingAccountsServiceTypes$AggrRefresh;
}set getAccountingAccountsServiceTypes$AggrRefresh(value) {this._getAccountingAccountsServiceTypes$AggrRefresh = value;
}

get getSupplierSocieties$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierSocieties$AggrRefresh"))) {
this._getSupplierSocieties$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierSocieties", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetSupplierSocieties", "5ASageWvg9Etl4rMFBZd6w", maxRecords, startIndex, function (b) {
model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierSocietiesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierSocietiesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierSocieties", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierSocieties");
span.setAttribute("outsystems.function.key", "6600ce65-a4b8-4513-9ba0-a746fa256f04");
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

return this._getSupplierSocieties$AggrRefresh;
}set getSupplierSocieties$AggrRefresh(value) {this._getSupplierSocieties$AggrRefresh = value;
}

get getProjectAssetByRequisition$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetByRequisition$AggrRefresh"))) {
this._getProjectAssetByRequisition$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetByRequisition", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetProjectAssetByRequisition", "0v2_wm9N5CpeSe5v0O_kFg", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetByRequisitionAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetByRequisitionAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetByRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetByRequisition");
span.setAttribute("outsystems.function.key", "682aed27-9cea-4806-ba6e-56b8f497f81d");
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

return this._getProjectAssetByRequisition$AggrRefresh;
}set getProjectAssetByRequisition$AggrRefresh(value) {this._getProjectAssetByRequisition$AggrRefresh = value;
}

get getCurrencies$AggrRefresh() {if(!(this.hasOwnProperty("_getCurrencies$AggrRefresh"))) {
this._getCurrencies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCurrencies", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetCurrencies", "f+VnB3EzqSeam1tAXE44KQ", maxRecords, startIndex, function (b) {
model.variables.getCurrenciesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCurrenciesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCurrenciesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCurrencies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCurrencies");
span.setAttribute("outsystems.function.key", "718ebccc-1974-41c1-8239-a11fbd89de77");
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

get getPaymentOptions$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentOptions$AggrRefresh"))) {
this._getPaymentOptions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentOptions", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetPaymentOptions", "KbZTSZCiHg_XFOVlv16P7g", maxRecords, startIndex, function (b) {
model.variables.getPaymentOptionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentOptionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentOptionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentOptions", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentOptions");
span.setAttribute("outsystems.function.key", "74ab067a-535c-4d71-8b68-496fd96f9a2f");
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

get getSustainabilities$AggrRefresh() {if(!(this.hasOwnProperty("_getSustainabilities$AggrRefresh"))) {
this._getSustainabilities$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSustainabilities", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetSustainabilities", "h7Vr7Bphk+yLg4jqz0eqPw", maxRecords, startIndex, function (b) {
model.variables.getSustainabilitiesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSustainabilitiesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSustainabilitiesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSustainabilities", function (span) {
if(span) {
span.setAttribute("code.function", "GetSustainabilities");
span.setAttribute("outsystems.function.key", "7b23fd8b-5559-4ff3-ab57-c28df0dd7f29");
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

return this._getSustainabilities$AggrRefresh;
}set getSustainabilities$AggrRefresh(value) {this._getSustainabilities$AggrRefresh = value;
}

get getInvoiceUsages$AggrRefresh() {if(!(this.hasOwnProperty("_getInvoiceUsages$AggrRefresh"))) {
this._getInvoiceUsages$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetInvoiceUsages", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetInvoiceUsages", "9K4ozixnDaUYQeFRQ9_iQQ", maxRecords, startIndex, function (b) {
model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getInvoiceUsagesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getInvoiceUsagesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetInvoiceUsages", function (span) {
if(span) {
span.setAttribute("code.function", "GetInvoiceUsages");
span.setAttribute("outsystems.function.key", "7c830c73-517f-40f6-a877-a4c800f40a7d");
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

get getCostCenterSAPByRequisitionId$AggrRefresh() {if(!(this.hasOwnProperty("_getCostCenterSAPByRequisitionId$AggrRefresh"))) {
this._getCostCenterSAPByRequisitionId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCostCenterSAPByRequisitionId", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetCostCenterSAPByRequisitionId", "egVcIAqcw3AuF356OfR6TQ", maxRecords, startIndex, function (b) {
model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCostCenterSAPByRequisitionIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCostCenterSAPByRequisitionIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCostCenterSAPByRequisitionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetCostCenterSAPByRequisitionId");
span.setAttribute("outsystems.function.key", "80eba519-cd35-478d-bcdf-27996599925a");
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

return this._getCostCenterSAPByRequisitionId$AggrRefresh;
}set getCostCenterSAPByRequisitionId$AggrRefresh(value) {this._getCostCenterSAPByRequisitionId$AggrRefresh = value;
}

get getProjectAssetServiceOtro$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServiceOtro$AggrRefresh"))) {
this._getProjectAssetServiceOtro$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServiceOtro", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetProjectAssetServiceOtro", "z8ETxh4PZYxYihpoWu9+nA", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServiceOtroAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServiceOtroAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServiceOtro", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServiceOtro");
span.setAttribute("outsystems.function.key", "85b293df-ab00-4acb-a3ff-36eea254cdf4");
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

get getPaymentWay99$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentWay99$AggrRefresh"))) {
this._getPaymentWay99$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentWay99", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetPaymentWay99", "VbVapBl_e7phISAELyWS_A", maxRecords, startIndex, function (b) {
model.variables.getPaymentWay99Aggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentWay99Aggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentWay99Aggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentWay99", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentWay99");
span.setAttribute("outsystems.function.key", "a14b0599-0c8a-401d-b20c-1b866ed97dd4");
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

return this._getPaymentWay99$AggrRefresh;
}set getPaymentWay99$AggrRefresh(value) {this._getPaymentWay99$AggrRefresh = value;
}

get getAccountingDataTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getAccountingDataTypes$AggrRefresh"))) {
this._getAccountingDataTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAccountingDataTypes", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetAccountingDataTypes", "oTqvoifuD3rqjmlGN6zMaQ", maxRecords, startIndex, function (b) {
model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingDataTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingDataTypes");
span.setAttribute("outsystems.function.key", "a6fee243-441d-4954-8d60-2e53faebf00d");
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

get getServiceFormats$AggrRefresh() {if(!(this.hasOwnProperty("_getServiceFormats$AggrRefresh"))) {
this._getServiceFormats$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetServiceFormats", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetServiceFormats", "M4kJHcj4X_mBfDg0VDbLPg", maxRecords, startIndex, function (b) {
model.variables.getServiceFormatsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getServiceFormatsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getServiceFormatsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetServiceFormats", function (span) {
if(span) {
span.setAttribute("code.function", "GetServiceFormats");
span.setAttribute("outsystems.function.key", "ab4d7df2-0645-43ab-9456-0e42e8545bbc");
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

return this._getServiceFormats$AggrRefresh;
}set getServiceFormats$AggrRefresh(value) {this._getServiceFormats$AggrRefresh = value;
}

get getDistributions$AggrRefresh() {if(!(this.hasOwnProperty("_getDistributions$AggrRefresh"))) {
this._getDistributions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetDistributions", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetDistributions", "uJgw9gaFXhq9IagWfEabsw", maxRecords, startIndex, function (b) {
model.variables.getDistributionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDistributionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDistributionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetDistributions", function (span) {
if(span) {
span.setAttribute("code.function", "GetDistributions");
span.setAttribute("outsystems.function.key", "b1abe1d7-1393-4126-8dcd-9c8919c18dbd");
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

return this._getDistributions$AggrRefresh;
}set getDistributions$AggrRefresh(value) {this._getDistributions$AggrRefresh = value;
}

get getBusinessValueCategories$AggrRefresh() {if(!(this.hasOwnProperty("_getBusinessValueCategories$AggrRefresh"))) {
this._getBusinessValueCategories$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBusinessValueCategories", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetBusinessValueCategories", "3K1jXP9IJF_nMwQ5zqcRyg", maxRecords, startIndex, function (b) {
model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBusinessValueCategoriesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBusinessValueCategoriesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBusinessValueCategories", function (span) {
if(span) {
span.setAttribute("code.function", "GetBusinessValueCategories");
span.setAttribute("outsystems.function.key", "be3a6521-9e65-42e6-ba68-df2d6bb381c4");
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

get getRequisitionServicesByRequisitionId$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionServicesByRequisitionId$AggrRefresh"))) {
this._getRequisitionServicesByRequisitionId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionServicesByRequisitionId", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetRequisitionServicesByRequisitionId", "v7fwvkjFtbFu2_BtuhfbSQ", maxRecords, startIndex, function (b) {
model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionServicesByRequisitionIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionServicesByRequisitionIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getRequisitionServicesByRequisitionIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionServicesByRequisitionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionServicesByRequisitionId");
span.setAttribute("outsystems.function.key", "c00c4195-f0e1-4fac-a82b-c434417ee54c");
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

return this._getRequisitionServicesByRequisitionId$AggrRefresh;
}set getRequisitionServicesByRequisitionId$AggrRefresh(value) {this._getRequisitionServicesByRequisitionId$AggrRefresh = value;
}

get getBusinessValueSubcategoriesByCategoryId$AggrRefresh() {if(!(this.hasOwnProperty("_getBusinessValueSubcategoriesByCategoryId$AggrRefresh"))) {
this._getBusinessValueSubcategoriesByCategoryId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "OPm1pOj_KeAJWjXogYPfSQ", maxRecords, startIndex, function (b) {
model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetBusinessValueSubcategoriesByCategoryId", function (span) {
if(span) {
span.setAttribute("code.function", "GetBusinessValueSubcategoriesByCategoryId");
span.setAttribute("outsystems.function.key", "c1e4c060-2caf-401e-b4d0-e610ca4de009");
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

get getEntraRole$AggrRefresh() {if(!(this.hasOwnProperty("_getEntraRole$AggrRefresh"))) {
this._getEntraRole$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetEntraRole", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetEntraRole", "7qyGTC_5OnA_VV8+D1QF6g", maxRecords, startIndex, function (b) {
model.variables.getEntraRoleAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getEntraRoleAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getEntraRoleAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetEntraRole", function (span) {
if(span) {
span.setAttribute("code.function", "GetEntraRole");
span.setAttribute("outsystems.function.key", "c4d1f198-bc7d-45e7-a3f3-a203427ac304");
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

return this._getEntraRole$AggrRefresh;
}set getEntraRole$AggrRefresh(value) {this._getEntraRole$AggrRefresh = value;
}

get getRequisitionCostCentersByRequisitionId$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionCostCentersByRequisitionId$AggrRefresh"))) {
this._getRequisitionCostCentersByRequisitionId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionCostCentersByRequisitionId", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetRequisitionCostCentersByRequisitionId", "XxcC4JaQe14aT0KZ6nVfHA", maxRecords, startIndex, function (b) {
model.variables.getRequisitionCostCentersByRequisitionIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionCostCentersByRequisitionIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionCostCentersByRequisitionIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionCostCentersByRequisitionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionCostCentersByRequisitionId");
span.setAttribute("outsystems.function.key", "d236a367-9920-4171-b20c-93b1dff55eca");
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

return this._getRequisitionCostCentersByRequisitionId$AggrRefresh;
}set getRequisitionCostCentersByRequisitionId$AggrRefresh(value) {this._getRequisitionCostCentersByRequisitionId$AggrRefresh = value;
}

get getSupplierByRequisition$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierByRequisition$AggrRefresh"))) {
this._getSupplierByRequisition$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierByRequisition", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetSupplierByRequisition", "H3U5Elt6W9ibSLwdPH1HvQ", maxRecords, startIndex, function (b) {
model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierByRequisitionAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierByRequisitionAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierByRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierByRequisition");
span.setAttribute("outsystems.function.key", "d9ee4b6a-5279-4d4c-bf11-5c6a56f5b29f");
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

get getDocumentTypeKR$AggrRefresh() {if(!(this.hasOwnProperty("_getDocumentTypeKR$AggrRefresh"))) {
this._getDocumentTypeKR$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetDocumentTypeKR", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetDocumentTypeKR", "VYLcnqZUXHgUsGI2Lwn0vQ", maxRecords, startIndex, function (b) {
model.variables.getDocumentTypeKRAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDocumentTypeKRAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDocumentTypeKRAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetDocumentTypeKR", function (span) {
if(span) {
span.setAttribute("code.function", "GetDocumentTypeKR");
span.setAttribute("outsystems.function.key", "e2ba3ff0-7265-4074-8045-4be8f3eb5a88");
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

return this._getDocumentTypeKR$AggrRefresh;
}set getDocumentTypeKR$AggrRefresh(value) {this._getDocumentTypeKR$AggrRefresh = value;
}

get getSupplierDetailBySociety$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierDetailBySociety$AggrRefresh"))) {
this._getSupplierDetailBySociety$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierDetailBySociety", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetSupplierDetailBySociety", "bNncmvAfcGecixzi0Z4SCQ", maxRecords, startIndex, function (b) {
model.variables.getSupplierDetailBySocietyAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierDetailBySocietyAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierDetailBySocietyAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSupplierDetailBySocietyOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierDetailBySociety", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierDetailBySociety");
span.setAttribute("outsystems.function.key", "e3efd35e-e5ce-4c83-9a8d-7f40de75d070");
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

return this._getSupplierDetailBySociety$AggrRefresh;
}set getSupplierDetailBySociety$AggrRefresh(value) {this._getSupplierDetailBySociety$AggrRefresh = value;
}

get getRequisitionById$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionById$AggrRefresh"))) {
this._getRequisitionById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionById", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetRequisitionById", "vn3eWcmXpi4h1XT38BEXtw", maxRecords, startIndex, function (b) {
model.variables.getRequisitionByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionByIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionById", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionById");
span.setAttribute("outsystems.function.key", "e78714d0-06e0-4d29-962a-ba29432daefa");
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

return this._getRequisitionById$AggrRefresh;
}set getRequisitionById$AggrRefresh(value) {this._getRequisitionById$AggrRefresh = value;
}

get getDepositTypes$AggrRefresh() {if(!(this.hasOwnProperty("_getDepositTypes$AggrRefresh"))) {
this._getDepositTypes$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetDepositTypes", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/ScreenDataSetGetDepositTypes", "xNMlgKuJEXDYt59dj4cBjw", maxRecords, startIndex, function (b) {
model.variables.getDepositTypesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDepositTypesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDepositTypesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetDepositTypes", function (span) {
if(span) {
span.setAttribute("code.function", "GetDepositTypes");
span.setAttribute("outsystems.function.key", "f9646c4e-1d7c-45d2-93c7-38b8ebf50743");
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

get getRequisitionContractData$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitionContractData$DataActRefresh"))) {
this._getRequisitionContractData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitionContractData", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetRequisitionContractData", "WBgpQ6OUgFPnH3xosJkMEw", function (b) {
model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionContractDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionContractDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionContractData", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionContractData");
span.setAttribute("outsystems.function.key", "01c453bf-8e37-4702-806a-345645cc9d0d");
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

return this._getRequisitionContractData$DataActRefresh;
}set getRequisitionContractData$DataActRefresh(value) {this._getRequisitionContractData$DataActRefresh = value;
}

get getShowSelectReqPopup$DataActRefresh() {if(!(this.hasOwnProperty("_getShowSelectReqPopup$DataActRefresh"))) {
this._getShowSelectReqPopup$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetShowSelectReqPopup", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetShowSelectReqPopup", "fdlE3m1sueTKOTiLgX90jQ", function (b) {
model.variables.getShowSelectReqPopupDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getShowSelectReqPopupDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getShowSelectReqPopupDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getShowSelectReqPopupOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetShowSelectReqPopup", function (span) {
if(span) {
span.setAttribute("code.function", "GetShowSelectReqPopup");
span.setAttribute("outsystems.function.key", "09d362cc-0168-4c26-9915-415dbc64b361");
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

return this._getShowSelectReqPopup$DataActRefresh;
}set getShowSelectReqPopup$DataActRefresh(value) {this._getShowSelectReqPopup$DataActRefresh = value;
}

get getAdvWithoutInvoiceData$DataActRefresh() {if(!(this.hasOwnProperty("_getAdvWithoutInvoiceData$DataActRefresh"))) {
this._getAdvWithoutInvoiceData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetAdvWithoutInvoiceData", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetAdvWithoutInvoiceData", "UZZytAEkoL_4U2gTS6zd1g", function (b) {
model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAdvWithoutInvoiceDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAdvWithoutInvoiceDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAdvWithoutInvoiceData", function (span) {
if(span) {
span.setAttribute("code.function", "GetAdvWithoutInvoiceData");
span.setAttribute("outsystems.function.key", "5173134e-1ec0-4d2c-a95e-39c40168846d");
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

return this._getAdvWithoutInvoiceData$DataActRefresh;
}set getAdvWithoutInvoiceData$DataActRefresh(value) {this._getAdvWithoutInvoiceData$DataActRefresh = value;
}

get getConfiguration$DataActRefresh() {if(!(this.hasOwnProperty("_getConfiguration$DataActRefresh"))) {
this._getConfiguration$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetConfiguration", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetConfiguration", "8byajVrg1APzv75RPoiseQ", function (b) {
model.variables.getConfigurationDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getConfigurationDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getConfigurationDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetConfiguration", function (span) {
if(span) {
span.setAttribute("code.function", "GetConfiguration");
span.setAttribute("outsystems.function.key", "52c72034-ecbf-48a3-80c4-89986a68b67c");
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

return this._getConfiguration$DataActRefresh;
}set getConfiguration$DataActRefresh(value) {this._getConfiguration$DataActRefresh = value;
}

get getAccountingData$DataActRefresh() {if(!(this.hasOwnProperty("_getAccountingData$DataActRefresh"))) {
this._getAccountingData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetAccountingData", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetAccountingData", "3l9EW4D2qrCaBdpzAbvkww", function (b) {
model.variables.getAccountingDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAccountingDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAccountingDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAccountingData", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountingData");
span.setAttribute("outsystems.function.key", "62050c81-67d3-4d43-a772-77e491d17cb1");
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

get getShowIsDonation$DataActRefresh() {if(!(this.hasOwnProperty("_getShowIsDonation$DataActRefresh"))) {
this._getShowIsDonation$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetShowIsDonation", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetShowIsDonation", "aM_9sbl5NECc6IM67cP6KQ", function (b) {
model.variables.getShowIsDonationDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getShowIsDonationDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getShowIsDonationDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetShowIsDonation", function (span) {
if(span) {
span.setAttribute("code.function", "GetShowIsDonation");
span.setAttribute("outsystems.function.key", "8f6bd1fe-419d-4923-84fc-ccbe02df5c78");
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

return this._getShowIsDonation$DataActRefresh;
}set getShowIsDonation$DataActRefresh(value) {this._getShowIsDonation$DataActRefresh = value;
}

get getSettings$DataActRefresh() {if(!(this.hasOwnProperty("_getSettings$DataActRefresh"))) {
this._getSettings$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettings", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetSettings", "nwGBi8iduWl5+EjGVzenpA", function (b) {
model.variables.getSettingsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "a949482b-71ab-4de6-8c5f-d8886958f04b");
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

get getRequisitionFiles$DataActRefresh() {if(!(this.hasOwnProperty("_getRequisitionFiles$DataActRefresh"))) {
this._getRequisitionFiles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetRequisitionFiles", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetRequisitionFiles", "cqjMuq5xj+mTS2d7OPKW0Q", function (b) {
model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionFilesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionFilesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionFiles", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionFiles");
span.setAttribute("outsystems.function.key", "b5c234d2-fe19-4d90-a9c9-12b17d659288");
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

return this._getRequisitionFiles$DataActRefresh;
}set getRequisitionFiles$DataActRefresh(value) {this._getRequisitionFiles$DataActRefresh = value;
}

get getUserApplicationRoles$DataActRefresh() {if(!(this.hasOwnProperty("_getUserApplicationRoles$DataActRefresh"))) {
this._getUserApplicationRoles$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetUserApplicationRoles", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetUserApplicationRoles", "LMoeEqUnWN1DWSkmmaKOUw", function (b) {
model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserApplicationRolesDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserApplicationRolesDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getUserApplicationRolesOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetUserApplicationRoles", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRoles");
span.setAttribute("outsystems.function.key", "cd03034f-02db-4eb3-a7f9-838e0a69264a");
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

return this._getUserApplicationRoles$DataActRefresh;
}set getUserApplicationRoles$DataActRefresh(value) {this._getUserApplicationRoles$DataActRefresh = value;
}

get getPaymentMethodsBySupplierId$DataActRefresh() {if(!(this.hasOwnProperty("_getPaymentMethodsBySupplierId$DataActRefresh"))) {
this._getPaymentMethodsBySupplierId$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetPaymentMethodsBySupplierId", "screenservices/ConectaProveedores/c_Requisitions/RequisitionDetail/DataActionGetPaymentMethodsBySupplierId", "kr7Jgm25OPydEuZYV6NPVA", function (b) {
model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentMethodsBySupplierIdDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentMethodsBySupplierIdDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentMethodsBySupplierId", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentMethodsBySupplierId");
span.setAttribute("outsystems.function.key", "cec22df2-f6e6-4413-ad70-27a270753e97");
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

return this._getPaymentMethodsBySupplierId$DataActRefresh;
}set getPaymentMethodsBySupplierId$DataActRefresh(value) {this._getPaymentMethodsBySupplierId$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getFrequencies$AggrRefresh", "getUserById$AggrRefresh", "getPaymentTerms$AggrRefresh", "getSpecialPostDeliveryAuthorizations$AggrRefresh", "getPaymentWays$AggrRefresh", "getAdvancedPaymentTypes$AggrRefresh", "getProjectAssetServices$AggrRefresh", "getInsuranceTypes$AggrRefresh", "getCostCenters$AggrRefresh", "getDocumentTypeAnticipoKW$AggrRefresh", "getAccountableGuide$AggrRefresh", "getAccountingAccountsServiceTypes$AggrRefresh", "getSupplierSocieties$AggrRefresh", "getProjectAssetByRequisition$AggrRefresh", "getCurrencies$AggrRefresh", "getPaymentOptions$AggrRefresh", "getSustainabilities$AggrRefresh", "getInvoiceUsages$AggrRefresh", "getCostCenterSAPByRequisitionId$AggrRefresh", "getProjectAssetServiceOtro$AggrRefresh", "getPaymentWay99$AggrRefresh", "getAccountingDataTypes$AggrRefresh", "getServiceFormats$AggrRefresh", "getDistributions$AggrRefresh", "getBusinessValueCategories$AggrRefresh", "getRequisitionServicesByRequisitionId$AggrRefresh", "getBusinessValueSubcategoriesByCategoryId$AggrRefresh", "getEntraRole$AggrRefresh", "getRequisitionCostCentersByRequisitionId$AggrRefresh", "getSupplierByRequisition$AggrRefresh", "getDocumentTypeKR$AggrRefresh", "getSupplierDetailBySociety$AggrRefresh", "getRequisitionById$AggrRefresh", "getDepositTypes$AggrRefresh", "getRequisitionContractData$DataActRefresh", "getShowSelectReqPopup$DataActRefresh", "getAdvWithoutInvoiceData$DataActRefresh", "getConfiguration$DataActRefresh", "getAccountingData$DataActRefresh", "getShowIsDonation$DataActRefresh", "getSettings$DataActRefresh", "getRequisitionFiles$DataActRefresh", "getUserApplicationRoles$DataActRefresh", "getPaymentMethodsBySupplierId$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_showHideModifyPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideModifyPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideModifyPopup");
span.setAttribute("outsystems.function.key", "0007e601-70cb-4c95-84b4-f128c0bedefc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideModifyPopup");
callContext = controller.callContext(callContext);
// l_ShowModifyPopup = notl_ShowModifyPopup
model.variables.l_ShowModifyPopupVar = (!(model.variables.l_ShowModifyPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getIsForSpecialWorkflow$Action(createForUserIn, approvalProcessIdIn, isHierarquicalFlowIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetIsForSpecialWorkflow", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsForSpecialWorkflow");
span.setAttribute("outsystems.function.key", "05cff0da-abfb-403b-ab6c-2758577f11fc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetIsForSpecialWorkflow");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.GetIsForSpecialWorkflow$vars"))());
vars.value.createForUserInLocal = createForUserIn;
vars.value.approvalProcessIdInLocal = approvalProcessIdIn;
vars.value.isHierarquicalFlowInLocal = isHierarquicalFlowIn;
var getIsForSpecialWorkflowVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetIsForSpecialWorkflow
model.flush();
return controller.getIsForSpecialWorkflow$ServerAction(OS$BuiltinFunctions.getUserId(), model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr, "REQ", callContext).then(function (value) {
getIsForSpecialWorkflowVar.value = value;
}).then(function () {
if(((((getIsForSpecialWorkflowVar.value.isForSpecialWorkflowOut && (!(vars.value.isHierarquicalFlowInLocal))) && vars.value.approvalProcessIdInLocal.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && (vars.value.createForUserInLocal === OS$BuiltinFunctions.nullTextIdentifier())))) {
// Execute Action: ShowHideSpecialOrNormalWorkflowPopup
controller._showHideSpecialOrNormalWorkflowPopup$Action(callContext);
// Execute Action: HideLoading4
ConectaProveedoresController$hideLoading$Action(callContext);
// l_IsToExitCapture = True
model.variables.l_IsToExitCaptureVar = true;
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
_listOfFiles$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ListOfFiles", function (span) {
if(span) {
span.setAttribute("code.function", "ListOfFiles");
span.setAttribute("outsystems.function.key", "078dcfde-f77a-41d3-9fcd-2ad037dc348d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ListOfFiles");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_AllFilesVar, callContext);
// HasFinaceAuth?
if(((((!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(0)))) && ((model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendFinance
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut, callContext);
}

// HasForeign?
if(((((((model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) && !(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && (!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) && ((model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendForeign
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut, callContext);
}

// Has Contract
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && (!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) && ((model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendContract
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getRequisitionContractDataDataAct.o_ContractFileOut, callContext);
}

// IsContractPending
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr) && (!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))))) {
// Execute Action: ListAppendContractPendingJustification
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut, callContext);
}

// Attached Files
if(((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && (!(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.isEmpty))))) {
// Execute Action: ListAppendAllAttachFiles
OS$SystemActions.listAppendAll(model.variables.l_AllFilesVar, model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut, callContext);
}

// Has Deposit?
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr)) {
// Execute Action: ListAppendAllDeposit
OS$SystemActions.listAppendAll(model.variables.l_AllFilesVar, model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut, callContext);
}

// Has Insurance?
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr)) {
// Execute Action: ListAppendAllInsurance
OS$SystemActions.listAppendAll(model.variables.l_AllFilesVar, model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut, callContext);
}

// Has AdvancePayment
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr && (!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) && ((model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendAdvancePayment
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut, callContext);
}

// HasAdvWithoutInvoice
if(((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr && (!(OS$DataTypes.areBinaryNulls(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))))) {
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionContractFile.ContractFileTypeId = AdvancePayment
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.advancePayment;
// Execute Action: ListAppendAdvWithoutInvoice
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut, callContext);
}

// HasExchangeRateEvidence
if(((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))) && (!(OS$DataTypes.areBinaryNulls(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) && ((model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendExchangeRateEvidence
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut, callContext);
}

// HasREPSE
if(((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr) && (!(OS$DataTypes.areBinaryNulls(model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) && ((model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr) !== (""))))) {
// Execute Action: ListAppendREPSE
OS$SystemActions.listAppend(model.variables.l_AllFilesVar, model.variables.getAccountingDataDataAct.rEPSEOut, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_addRecord$Action(i_IsDepositIn, i_IsServiceIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsConceptsIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddRecord", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "0cbaa7e9-96bf-419f-90ce-050828225e68");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AddRecord");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.AddRecord$vars"))());
vars.value.i_IsDepositInLocal = i_IsDepositIn;
vars.value.i_IsServiceInLocal = i_IsServiceIn;
vars.value.i_IsInsuranceInLocal = i_IsInsuranceIn;
vars.value.i_IsEstim_Equal_AgreedInLocal = i_IsEstim_Equal_AgreedIn;
vars.value.i_IsConceptsInLocal = i_IsConceptsIn;
if((vars.value.i_IsDepositInLocal)) {
// Execute Action: ListAppendDeposit
OS$SystemActions.listAppend(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut, function () {
var rec = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();
rec.requisitionContractFileAttr = function () {
var rec = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.deposit;
rec.currencyIdAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
return rec;
}();
return rec;
}(), callContext);
} else {
if(vars.value.i_IsInsuranceInLocal) {
// Execute Action: ListAppendInsurance
OS$SystemActions.listAppend(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut, function () {
var rec = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();
rec.requisitionContractFileAttr = function () {
var rec = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.insurance;
rec.currencyIdAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
return rec;
}();
return rec;
}(), callContext);
} else {
if(vars.value.i_IsServiceInLocal) {
// Execute Action: ListAppendService
OS$SystemActions.listAppend(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut, function () {
var rec = new (OS$GenericTypeCache.getImplicitRecord(EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, {
name: "RequisitionService",
attrName: "requisitionServiceAttr",
nameForJson: "RequisitionService",
uniqueId: "04e72477-5706-0d40-16b4-3102119b0dd6"
}))();
rec.requisitionServiceAttr = function () {
var rec = new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.requisitionIdAttr = model.variables.i_RequisitionIdIn;
rec.accountingServiceTypeIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
return rec;
}();
return rec;
}(), callContext);
} else {
if(vars.value.i_IsEstim_Equal_AgreedInLocal) {
// Execute Action: ListAppendEstim_Equal_Agreed
OS$SystemActions.listAppend(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function () {
var rec = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.requisitionAccConceptsIdAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.idAttr;
return rec;
}(), callContext);
} else {
if(vars.value.i_IsConceptsInLocal) {
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.getAccountingDataDataAct.o_RemainingOut, function () {
var list = new (OS$GenericTypeCache.getGenericList(RC_f80fde4acf9a7dc465a1d535c05dfb8e))();
list.pushAll([function () {
var rec = new RC_f80fde4acf9a7dc465a1d535c05dfb8e();
rec.accountingDataTypeAttr = function () {
var rec = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
rec.idAttr = ConectaProveedores_staticEntities_accountingDataType.settlement;
rec.labelAttr = (ConectaProveedores_staticEntities_accountingDataType.settlement).toString();
rec.orderAttr = ConectaProveedores_staticEntities_accountingDataType.settlement;
rec.is_ActiveAttr = true;
return rec;
}();
rec.requisitionAccConceptsAttr = function () {
var rec = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.settlement;
return rec;
}();
return rec;
}(), function () {
var rec = new RC_f80fde4acf9a7dc465a1d535c05dfb8e();
rec.accountingDataTypeAttr = function () {
var rec = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
rec.idAttr = ConectaProveedores_staticEntities_accountingDataType.creditNote;
rec.labelAttr = (ConectaProveedores_staticEntities_accountingDataType.creditNote).toString();
rec.orderAttr = ConectaProveedores_staticEntities_accountingDataType.creditNote;
rec.is_ActiveAttr = true;
return rec;
}();
rec.requisitionAccConceptsAttr = function () {
var rec = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.creditNote;
return rec;
}();
return rec;
}(), function () {
var rec = new RC_f80fde4acf9a7dc465a1d535c05dfb8e();
rec.accountingDataTypeAttr = function () {
var rec = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
rec.idAttr = ConectaProveedores_staticEntities_accountingDataType.voucher;
rec.labelAttr = (ConectaProveedores_staticEntities_accountingDataType.voucher).toString();
rec.orderAttr = ConectaProveedores_staticEntities_accountingDataType.voucher;
rec.is_ActiveAttr = true;
return rec;
}();
rec.requisitionAccConceptsAttr = function () {
var rec = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.accountingDataTypeIdAttr = ConectaProveedores_staticEntities_accountingDataType.voucher;
return rec;
}();
return rec;
}()]);
return list;
}(), callContext);
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
_seeLogsOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SeeLogsOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "10d8267c-797a-493f-a905-81aa1243b8cd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SeeLogsOnClick");
callContext = controller.callContext(callContext);
var sidebarOpenVar = new OS$DataTypes.VariableHolder();
// l_RefreshSideBar = CurrDateTime
model.variables.l_RefreshSideBarVar = OS$BuiltinFunctions.currDateTime();
// Execute Action: SidebarOpen
sidebarOpenVar.value = OutSystemsUIController$sidebarOpen$Action(idService.getId("SidebarLog"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_approveRequisitionAccounting$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveRequisitionAccounting", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRequisitionAccounting");
span.setAttribute("outsystems.function.key", "111d5c53-ff3e-46d2-be26-e241390e8f0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveRequisitionAccounting");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var approveRequisitionAccountingVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsBusy = True
model.variables.l_IsBusyVar = true;
// l_FormIsValid = True
model.variables.l_FormIsValidVar = true;
// l_NotValidPaymentsValue = False
model.variables.l_NotValidPaymentsValueVar = false;
// l_NotValidContractValue = False
model.variables.l_NotValidContractValueVar = false;
if((model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out)) {
// Not AdvancedPay
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)))) {
// AccountServiceType
if((model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Set Valid
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// l_NotValid = True
model.variables.l_NotValidVar = true;
}

}

}

// For Each Payment
// Foreach GetAccountingData.o_Remaining
callContext.iterationContext.registerIterationStart(model.variables.getAccountingDataDataAct.o_RemainingOut);
try {var o_RemainingIterator = callContext.iterationContext.getIterator(model.variables.getAccountingDataDataAct.o_RemainingOut);
var o_RemainingIndex = 0;
while (((o_RemainingIndex < model.variables.getAccountingDataDataAct.o_RemainingOut.length))) {
o_RemainingIterator.currentRowNumber = o_RemainingIndex;
// amount error
if(((model.variables.getAccountingDataDataAct.o_RemainingOut.getItem(o_RemainingIndex.valueOf()).requisitionAccConceptsAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr) && model.variables.getAccountingDataDataAct.o_RemainingOut.getItem(o_RemainingIndex.valueOf()).requisitionAccConceptsAttr.isActiveAttr))) {
// l_NotValidPaymentsValue = True
model.variables.l_NotValidPaymentsValueVar = true;
}

o_RemainingIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getAccountingDataDataAct.o_RemainingOut);
}

// For Each SubAccConcepts
// Foreach GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts
callContext.iterationContext.registerIterationStart(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr);
try {var subAccConceptsIterator = callContext.iterationContext.getIterator(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr);
var subAccConceptsIndex = 0;
while (((subAccConceptsIndex < model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.length))) {
subAccConceptsIterator.currentRowNumber = subAccConceptsIndex;
// amount error
if(((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(subAccConceptsIndex.valueOf()).amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr) && model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(subAccConceptsIndex.valueOf()).isActiveAttr))) {
// l_NotValidPaymentsValue = True
model.variables.l_NotValidPaymentsValueVar = true;
}

subAccConceptsIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr);
}

// For Each ContractDeposit
// Foreach GetRequisitionContractData.o_ContractDepositList
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
try {var o_ContractDepositListIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
var o_ContractDepositListIndex = 0;
while (((o_ContractDepositListIndex < model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.length))) {
o_ContractDepositListIterator.currentRowNumber = o_ContractDepositListIndex;
// amount error
if((model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).requisitionContractFileAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr))) {
// l_NotValidContractValue = True
model.variables.l_NotValidContractValueVar = true;
}

o_ContractDepositListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
}

// For Each ContractInsurance
// Foreach GetRequisitionContractData.o_ContractInsuranceList
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
try {var o_ContractInsuranceListIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
var o_ContractInsuranceListIndex = 0;
while (((o_ContractInsuranceListIndex < model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.length))) {
o_ContractInsuranceListIterator.currentRowNumber = o_ContractInsuranceListIndex;
// amount error
if((model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getItem(o_ContractInsuranceListIndex.valueOf()).requisitionContractFileAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr))) {
// l_NotValidContractValue = True
model.variables.l_NotValidContractValueVar = true;
}

o_ContractInsuranceListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
}

// amount error
if((model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr))) {
// l_NotValidContractValue = True
model.variables.l_NotValidContractValueVar = true;
}

// not valid amount
return OS$Flow.executeSequence(function () {
if(((model.variables.l_NotValidPaymentsValueVar || model.variables.l_NotValidContractValueVar))) {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
OS$FeedbackMessageService.showFeedbackMessage(((model.variables.l_NotValidContractValueVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RL6fU5_VKUS3k5nIQw4kgg#Message.-1656441815.1", "The total amount of contracts is higher then the total amount defined by the requisition, please revise your payments\"")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RL6fU5_VKUS3k5nIQw4kgg#Message.-1842369923.1", "The total amount of payments is higher then the total amount defined by the requisition, please revise your payments"))), /*Error*/ 3);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// not valid form
return OS$Flow.executeSequence(function () {
if((((!(model.widgets.get(idService.getId("Form")).validAttr)) || (model.variables.l_FormIsValidVar === false)))) {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4DVlOwi7m0mQfBa1f35qjg#Message.-1274683029.1", "Errors in the form. Please check the fields with error."), /*Error*/ 3);
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} else {
// Execute Action: ClearFields
controller._clearFields$Action(callContext);
// Execute Action: ListOfFiles
controller._listOfFiles$Action(callContext);
// Execute Action: ApproveRequisitionAccounting
model.flush();
return controller.approveRequisitionAccounting$ServerAction(function () {
var rec = new RC_cc86cc41f7a6d52842bfa86c15f13d61();
rec.allFilesAttr = model.variables.l_AllFilesVar;
rec.i_RequisitionAccConcept_EstimEqualAgAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut;
rec.requisitionAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr;
rec.requisitionAccConceptsAttr = model.variables.getAccountingDataDataAct.o_RemainingOut;
rec.requisitionAccountingAttr = model.variables.getAccountingDataDataAct.requisitionAccountingOut;
return rec;
}(), model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.idAttr, ConectaProveedoresClientVariables.getOffsetUtc(), callContext).then(function (value) {
approveRequisitionAccountingVar.value = value;
}).then(function () {
// Success?
return OS$Flow.executeSequence(function () {
if((approveRequisitionAccountingVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gmtWhfpRw0KzVe3z1IREyA#Message.-1801877403.1", "Requisição aprovada."), /*Success*/ 1);
// Refresh Query: GetRequisitionById
var result = controller.getRequisitionById$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
} else {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(approveRequisitionAccountingVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
});
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("RequisitionDetail.ApproveRequisitionAccounting", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "a37b78c4-8b43-4d25-bfdb-6ed1edf48cc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gGH+FCnySUK_2AwS_0Do5A#Message.-958295302.1", "Error while trying to approve the requisition!"), /*Error*/ 3);
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
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
_cancelRequisition$Action(i_IsDataCaptureIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CancelRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "CancelRequisition");
span.setAttribute("outsystems.function.key", "1497898a-dccc-48d9-aac1-99de07d2fc47");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CancelRequisition");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.CancelRequisition$vars"))());
vars.value.i_IsDataCaptureInLocal = i_IsDataCaptureIn;
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var requisitionCancelVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.i_IsDataCaptureInLocal)) {
// Execute Action: RequisitionCancel
model.flush();
return controller.requisitionCancel$ServerAction(model.variables.i_RequisitionIdIn, OS$DataTypes.LongInteger.defaultValue, "", "", callContext).then(function (value) {
requisitionCancelVar.value = value;
}).then(function () {
// Success?
if((requisitionCancelVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VpQJPncP60G7NZwzaUGoDQ#Message.-1406923915.1", "Requisition canceled with success!"), /*Success*/ 1);
// Destination: /ConectaProveedores/Requisitions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
OS$FeedbackMessageService.showFeedbackMessage(requisitionCancelVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
} else {
// Execute Action: ShowHidePopup
controller._showHideCancelPopup$Action(callContext);
// Destination: /ConectaProveedores/Requisitions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
}

});
}).catch(function (ex) {
OS$Logger.debug("RequisitionDetail.CancelRequisition", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "5a221f4a-5bc7-4611-816c-ce81b9a30ae4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AP2ljKL5hkWjY1z72eEKtQ#Message.751629479.1", "Error while trying to cancel the requisition!"), /*Error*/ 3);
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
_dropdown_Project2OnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_Project2OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_Project2OnChange");
span.setAttribute("outsystems.function.key", "1758fbfb-65e7-4378-8d4c-a10664f8e94b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_Project2OnChange");
callContext = controller.callContext(callContext);
// GetRequisitionById.List.Current.Requisition.ProjectAssetService = ""
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr = "";
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onClickOpenDatePickerDateOfCommitment$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnClickOpenDatePickerDateOfCommitment", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenDatePickerDateOfCommitment");
span.setAttribute("outsystems.function.key", "17a3ce4c-e957-4071-9f9f-50fd482c7db8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnClickOpenDatePickerDateOfCommitment");
callContext = controller.callContext(callContext);
var datePickerOpenDateOfCommitmentVar = new OS$DataTypes.VariableHolder();
// Execute Action: DatePickerOpenDateOfCommitment
datePickerOpenDateOfCommitmentVar.value = OutSystemsUIController$datePickerOpen$Action(idService.getId("DatePickerPaymentDateRequisitions"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getRequisitionByIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionByIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "1d0b7fdf-9a73-46d2-b479-876b5b2e2e13");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRequisitionByIdOnAfterFetch");
callContext = controller.callContext(callContext);
var getIsCorporativoCxPFromUARVar = new OS$DataTypes.VariableHolder();
var generateReqNameVar = new OS$DataTypes.VariableHolder();
var getUserRegionVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
if((((((((!(model.variables.getUserApplicationRolesDataAct.isSegmentationCorporativoOut)) || (!(model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut))) || (model.variables.getUserApplicationRolesDataAct.telcelDirectionsListTextOut === "")) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(model.variables.getUserApplicationRolesDataAct.corporativoRegionIdOut) && ((OS$BuiltinFunctions.index(model.variables.getUserApplicationRolesDataAct.telcelDirectionsListTextOut, (("," + OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.telcelDirectionIdAttr)) + ","), 0, false, false)) !== ((-1))))) || !(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(model.variables.getUserApplicationRolesDataAct.corporativoRegionIdOut))) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr === OS$BuiltinFunctions.getUserId())))) {
// l_AllowActions = True
model.variables.l_AllowActionsVar = true;
} else {
// l_AllowActions = False or GetRequisitionById.List.Current.Requisition.RequisitionStatusId = DataCapture and GetRequisitionById.List.Current.Requisition.ApplicantId = GetUserId or i_RequisitionId = NullIdentifier
model.variables.l_AllowActionsVar = ((false || ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()))) || model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())));
}

// Execute Action: GetIsCorporativoCxPFromUAR
model.flush();
return controller.getIsCorporativoCxPFromUAR$ServerAction(ConectaProveedores_staticEntities_concept.fsP, "", callContext).then(function (value) {
getIsCorporativoCxPFromUARVar.value = value;
}).then(function () {
// No permissions
return OS$Flow.executeSequence(function () {
if(((((!(model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionByIdAggr.listOut.isEmpty) && (!(getIsCorporativoCxPFromUARVar.value.o_IsFromCorporativoOut))) && (!(model.variables.getUserApplicationRolesDataAct.canUploadInvoicesOut))))) {
// Destination: /ConectaProveedores/InvalidPermissions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "InvalidPermissions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Supplier and Requisition Status?
return OS$Flow.executeSequence(function () {
if(((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr) !== (ConectaProveedores_staticEntities_requisitionStatus.approved)) && model.variables.i_IsUploadInvoiceIn))) {
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// l_CanEditUserArea = i_RequisitionId = NullIdentifier or GetRequisitionById.List.Current.Requisition.RequisitionStatusId = DataCapture or GetRequisitionById.List.Current.Requisition.RequisitionStatusId = Modify and GetRequisitionById.List.Current.Requisition.ApplicantId = GetUserId
model.variables.l_CanEditUserAreaVar = (model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.modify)) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId())));
// l_CanEditAccounting = GetRequisitionById.List.Current.RequisitionApprovalLevel.IsAccounting and GetRequisitionById.List.Current.RequisitionApprovalLevel.ApprovalStatusId = NotApproved
model.variables.l_CanEditAccountingVar = (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved));
// l_OriginalDateOfCommitment = GetRequisitionById.List.Current.Requisition.DateOfCommitment
model.variables.l_OriginalDateOfCommitmentVar = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr;
// l_CanSeeAdvanceWithOrWithoutInvoice = notGetRequisitionById.List.Current.RequisitionApproval.HasStartedAccounting and GetRequisitionById.List.Current.Requisition.IsAdvanced
model.variables.l_CanSeeAdvanceWithOrWithoutInvoiceVar = (!((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)));
// AssignTempSelectedCostCenter
// l_PreviousSelectedCostCenter = GetRequisitionById.List.Current.Requisition.CostCenterId
model.variables.l_PreviousSelectedCostCenterVar = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr;
// Req is New?
return OS$Flow.executeSequence(function () {
if((model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// GetRequisitionById.List.Current.Requisition.RegionId = l_RegionId
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr = model.variables.l_RegionIdVar;
// Execute Action: GetUserRegion
model.flush();
return ConectaProveedoresController$getUserRegion$Action(callContext).then(function (value) {
getUserRegionVar.value = value;
}).then(function () {
// Execute Action: GenerateReqName
model.flush();
return ConectaProveedoresController$generateReqName$Action(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr) : (getUserRegionVar.value.regionIdOut)), callContext).then(function (value) {
generateReqNameVar.value = value;
});
}).then(function () {
// SetRegion
// GetRequisitionById.List.Current.Requisition.RegionId = If
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr = ((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr) : (getUserRegionVar.value.regionIdOut));
// Name
// GetRequisitionById.List.Current.Requisition.Name = GenerateReqName.o_Name
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr = generateReqNameVar.value.o_NameOut;
// ALIGN
});
} else {
// Has contract?
return OS$Flow.executeSequence(function () {
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr)) {
// Refresh Query: GetRequisitionContractData
var result = controller.getRequisitionContractData$DataActRefresh(callContext);
model.flush();
return result;
}

}).then(function () {
// Has Accounting?
return OS$Flow.executeSequence(function () {
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr)) {
// Refresh Query: GetAccountingData
var result = controller.getAccountingData$DataActRefresh(callContext);
model.flush();
return result;
}

});
}).then(function () {
// Refresh Query: GetSupplierByRequisition
var result = controller.getSupplierByRequisition$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetCostCenterSAPByRequisitionId
var result = controller.getCostCenterSAPByRequisitionId$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetBusinessValueSubcategoriesByCategoryId
var result = controller.getBusinessValueSubcategoriesByCategoryId$AggrRefresh(50, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetProjectAssetByRequisition
var result = controller.getProjectAssetByRequisition$AggrRefresh(1, 0, callContext);
model.flush();
return result;
});
});
}

}).then(function () {
// Refresh Query: GetUserById
var result = controller.getUserById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}).then(function () {
// No Company
return OS$Flow.executeSequence(function () {
if((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// Refresh Query: GetSupplierDetailBySociety
var result = controller.getSupplierDetailBySociety$AggrRefresh(1, 0, callContext);
model.flush();
return result;
}

});
}).then(function () {
// Execute Action: ListAppendAll
OS$SystemActions.listAppendAll(model.variables.l_RetentionPercentageListVar, function () {
var list = new (OS$GenericTypeCache.getGenericList(RC_ee67c405f78e15f46603b032a29fae74))();
list.pushAll([function () {
var rec = new RC_ee67c405f78e15f46603b032a29fae74();
rec.textAttr = "0.0 %";
rec.valueAttr = OS$BuiltinFunctions.integerToDecimal(0);
return rec;
}(), function () {
var rec = new RC_ee67c405f78e15f46603b032a29fae74();
rec.textAttr = "10.00 %";
rec.valueAttr = (new OS$DataTypes.Decimal("10.00"));
return rec;
}(), function () {
var rec = new RC_ee67c405f78e15f46603b032a29fae74();
rec.textAttr = "25.00 %";
rec.valueAttr = (new OS$DataTypes.Decimal("25.00"));
return rec;
}()]);
return list;
}(), callContext);
// Refresh Query: GetRequisitionCostCentersByRequisitionId
var result = controller.getRequisitionCostCentersByRequisitionId$AggrRefresh(999999, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSupplierSocieties
var result = controller.getSupplierSocieties$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetCostCenters
var result = controller.getCostCenters$AggrRefresh(999999999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetPaymentOptions
var result = controller.getPaymentOptions$AggrRefresh(9999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetPaymentWays
var result = controller.getPaymentWays$AggrRefresh(99999, 0, callContext);
model.flush();
return result;
}).then(function () {
// Refresh Query: GetPaymentWay99
var result = controller.getPaymentWay99$AggrRefresh(1, 0, callContext);
model.flush();
return result;
});
});
}

});
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
_dropdown_AdvancedPaymentTypeOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_AdvancedPaymentTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AdvancedPaymentTypeOnChange");
span.setAttribute("outsystems.function.key", "1ef99bc0-5c4e-4330-b1ab-f40b541c91ca");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_AdvancedPaymentTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_AdvancedPaymentTypeOnChange$vars"))());
// IsAdvWithoutInv = GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionContractFile.AdvancePaymentTypeId = WithoutInvoice
vars.value.isAdvWithoutInvVar = (model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr === ConectaProveedores_staticEntities_advancePaymentType.withoutInvoice);
// Set Variables
// GetRequisitionById.List.Current.Requisition.DocumentTypeId = If
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.documentTypeIdAttr = ((vars.value.isAdvWithoutInvVar) ? (model.variables.getDocumentTypeAnticipoKWAggr.listOut.getCurrent(callContext.iterationContext).documentTypeAttr.idAttr) : (model.variables.getDocumentTypeKRAggr.listOut.getCurrent(callContext.iterationContext).documentTypeAttr.idAttr));
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionContractFile.AdvancePaymentTypeId = GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionContractFile.AdvancePaymentTypeId
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr = model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr;
// GetRequisitionById.List.Current.Requisition.WasAdvWithoutInvoice = IsAdvWithoutInv
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.wasAdvWithoutInvoiceAttr = vars.value.isAdvWithoutInvVar;
// GetRequisitionById.List.Current.Requisition.AdvWithoutInvoice = IsAdvWithoutInv
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr = vars.value.isAdvWithoutInvVar;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_showHideAssignFirstApproverPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideAssignFirstApproverPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideAssignFirstApproverPopup");
span.setAttribute("outsystems.function.key", "1f2c9797-da87-4d28-a77c-80ae66950b25");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideAssignFirstApproverPopup");
callContext = controller.callContext(callContext);
// l_ShowAssignFirstApproverPopup = notl_ShowAssignFirstApproverPopup
model.variables.l_ShowAssignFirstApproverPopupVar = (!(model.variables.l_ShowAssignFirstApproverPopupVar));
if(((!(model.variables.l_ShowAssignFirstApproverPopupVar)))) {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadEventEndProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadEventEndProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadEventEndProcess");
span.setAttribute("outsystems.function.key", "253c477c-2227-4c98-9a7e-a42233a95a21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadEventEndProcess");
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
_dropdown_ServiceTypeOnChange$Action(accountIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_ServiceTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ServiceTypeOnChange");
span.setAttribute("outsystems.function.key", "2701d536-0ce1-4a33-bf6b-6690c521844c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_ServiceTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_ServiceTypeOnChange$vars"))());
vars.value.accountInLocal = accountIn;
return OS$Flow.executeAsyncFlow(function () {
// has costcenter
return OS$Flow.executeSequence(function () {
if((!(!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// l_SelectedAccount = Account
model.variables.l_SelectedAccountVar = vars.value.accountInLocal;
// Refresh Query: GetAccountableGuide
var result = controller.getAccountableGuide$AggrRefresh(1, 0, callContext);
model.flush();
return result;
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
_approveRequisition$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ApproveRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRequisition");
span.setAttribute("outsystems.function.key", "2ef6c68c-aa41-4aeb-93e6-8cd35fb8c2b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ApproveRequisition");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var testingExceptionsSAP_AMVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var approvModifReqVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsBusy = True
model.variables.l_IsBusyVar = true;
// Execute Action: ApprovModifReq
model.flush();
return controller.approvModifReq$ServerAction(model.variables.i_RequisitionIdIn, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.idAttr, true, "", ConectaProveedoresClientVariables.getOffsetUtc(), "", callContext).then(function (value) {
approvModifReqVar.value = value;
}).then(function () {
// Success?
if((approvModifReqVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("D8brWNuq10KGy7bqaGE_jg#Message.-1801877403.1", "Requisição aprovada."), /*Success*/ 1);
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(approvModifReqVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
}).catch(function (ex) {
OS$Logger.debug("RequisitionDetail.ApproveRequisition", OS$Exceptions.getMessage(ex));
// Handle Error: TestingExceptionsSAP_AM
if(OS$Exceptions.isInstanceOf(ex, OS$Exceptions.Exceptions.UserException, "ConectaProveedores.TestingExceptionsSAP_AM")) {
OS$Logger.error(null, ex, null, null, 1);
testingExceptionsSAP_AMVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("TestingExceptionsSAP_AM", function (span) {
if(span) {
span.setAttribute("code.function", "TestingExceptionsSAP_AM");
span.setAttribute("outsystems.function.key", "74bff7a6-b9c2-4eb9-ac78-c3293d5cdd98");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(testingExceptionsSAP_AMVar.value.exceptionMessageAttr, /*Error*/ 3);
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
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

// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "0b0f810a-e3dc-4936-9203-11ba8ae42676");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FBpipafdL06zrKNnkXSbIw#Message.-958295302.1", "Error while trying to approve the requisition!"), /*Error*/ 3);
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading3
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
_wb_BigUploadNotifyFileId$Action(fileIdIn, filenameIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadNotifyFileId", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadNotifyFileId");
span.setAttribute("outsystems.function.key", "2f5024b5-f97f-4c63-99a0-bc9345bc570d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadNotifyFileId");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.wb_BigUploadNotifyFileId$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.filenameInLocal = filenameIn;
// GetRequisitionFiles.o_FinanceAuthorization.BigUploadfileId = FileId
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.bigUploadfileIdAttr = vars.value.fileIdInLocal;
// GetRequisitionFiles.o_FinanceAuthorization.RequisitionFile.Filename = Filename
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr = vars.value.filenameInLocal;
// Execute Action: Wb_CustomUploadOnFileChange
controller._wb_CustomUploadOnFileChange$Action(function () {
var rec = new ST_1d6498da9105fbe815a7f766352917c0Structure();
rec.fileNameAttr = vars.value.filenameInLocal;
rec.fileBigFileIdAttr = vars.value.fileIdInLocal;
return rec;
}(), new ST_f9f8b40f5330871047e55e068d129447Structure(), false, true, false, false, false, false, false, false, false, false, false, false, callContext);
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
span.setAttribute("outsystems.function.key", "349179db-7447-4410-a47a-ecae51cba911");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ClearFields");
callContext = controller.callContext(callContext);
// not Advanced
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)))) {
// GetRequisitionById.List.Current.Requisition.AdvWithoutInvoice = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr = false;
// GetRequisitionById.List.Current.Requisition.WasAdvWithoutInvoice = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.wasAdvWithoutInvoiceAttr = false;
// GetRequisitionById.List.Current.Requisition.BuyDocNumber = ""
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr = "";
// GetRequisitionById.List.Current.Requisition.BuyDocPosition = ""
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr = "";
}

// No Project
if((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr.equals(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr)))) {
// ProjectService
// GetRequisitionById.List.Current.Requisition.ProjectAssetService = ""
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr = "";
}

// Distribution Variable?
if(((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr) !== (ConectaProveedores_staticEntities_distribution.fixed)) && (!(model.variables.getRequisitionCostCentersByRequisitionIdAggr.listOut.isEmpty))))) {
// Execute Action: ListClearCostCenters
OS$SystemActions.listClear(model.variables.getRequisitionCostCentersByRequisitionIdAggr.listOut, callContext);
}

// MXN Currency?
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr === ConectaProveedores_staticEntities_currency.mXN) && !(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))))) {
// Exchange Rate
// GetRequisitionById.List.Current.Requisition.NegotiatedExchangeRate = 0
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr = OS$BuiltinFunctions.integerToDecimal(0);
}

// No Sustainability?
if((((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr)) && !(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Sustainability
// GetRequisitionById.List.Current.Requisition.SustainabilityId = NullIdentifier
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}

// No Foreign?
if((((model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr === "MX") && ((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr.equals(OS$BuiltinFunctions.integerToDecimal(0))) || !(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr, OS$BuiltinFunctions.nullBinary()))) || ((model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr) !== ("")))))) {
// Retention Rate
// GetRequisitionById.List.Current.Requisition.RetentionRate = 0
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr = OS$BuiltinFunctions.integerToDecimal(0);
// GetRequisitionFiles.o_ProofOfForeignResidence.Binary = NullBinary
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionFiles.o_ProofOfForeignResidence.RequisitionFile.Filename = ""
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr = "";
}

// No Contract?
if((((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr)) && (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr || model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr) || model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr) || model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr)))) {
// GetRequisitionById.List.Current.Requisition.IsContractPending = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr = false;
// GetRequisitionById.List.Current.Requisition.HasDeposit = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr = false;
// GetRequisitionById.List.Current.Requisition.HasInsurance = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr = false;
// GetRequisitionById.List.Current.Requisition.HasAdvancePayment = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr = false;
}

// not Contract Pending
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr)))) {
// set DateOfCommit
// GetRequisitionById.List.Current.Requisition.DateOfCommitment = NullDate
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr = OS$BuiltinFunctions.nullDate();
}

// not Accounting
if((!((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr))))) {
// No Special?
if((((!(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr)) && ((model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr) !== (OS$BuiltinFunctions.nullIdentifier()))))) {
// Special
// GetAccountingData.RequisitionAccounting.SpecialPostDeliveryAuthId = NullIdentifier
model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr = OS$BuiltinFunctions.nullIdentifier();
}

// No Exchanged Rate?
if((((OS$BuiltinFunctions.decimalToText(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr) === "") && ((model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr) !== (""))))) {
// Comment
// GetAccountingData.RequisitionAccounting.ExchangeRateComment = ""
model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr = "";
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
_getIsShowAssignFirstApproverPopup$Action(createForUserIn, approvalProcessIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetIsShowAssignFirstApproverPopup", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsShowAssignFirstApproverPopup");
span.setAttribute("outsystems.function.key", "354b0c2c-aa87-40c1-bfe3-49b2e0729cb8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetIsShowAssignFirstApproverPopup");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.GetIsShowAssignFirstApproverPopup$vars"))());
vars.value.createForUserInLocal = createForUserIn;
vars.value.approvalProcessIdInLocal = approvalProcessIdIn;
var getIsShowAssignFirstApproverPopupVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetIsShowAssignFirstApproverPopup
model.flush();
return controller.getIsShowAssignFirstApproverPopup$ServerAction(OS$BuiltinFunctions.getUserId(), callContext).then(function (value) {
getIsShowAssignFirstApproverPopupVar.value = value;
}).then(function () {
if((((getIsShowAssignFirstApproverPopupVar.value.isShowOut && (vars.value.createForUserInLocal === OS$BuiltinFunctions.nullTextIdentifier())) && vars.value.approvalProcessIdInLocal.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// Execute Action: HideLoading3
ConectaProveedoresController$hideLoading$Action(callContext);
// Execute Action: ShowHideAssignFirstApproverPopup
controller._showHideAssignFirstApproverPopup$Action(callContext);
// l_IsToExitCapture = True
model.variables.l_IsToExitCaptureVar = true;
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
_saveOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "374c6639-04e7-488a-a31f-b4aec82d803c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var saveRequisitionVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsBusy = True
model.variables.l_IsBusyVar = true;
// Execute Action: ClearFields
controller._clearFields$Action(callContext);
// Execute Action: ListOfFiles
controller._listOfFiles$Action(callContext);
// Execute Action: SaveRequisition
model.flush();
return controller.saveRequisition$ServerAction(function () {
var rec = new RC_44742d4360afdf16ff97b37b2eff1760();
rec.allFilesAttr = model.variables.l_AllFilesVar;
rec.i_RequisitionAccConcept_EstimEqualAgAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut;
rec.requisitionAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr;
rec.requisitionAccConceptsRecordListAttr = model.variables.getAccountingDataDataAct.o_RemainingOut;
rec.requisitionAccountingAttr = model.variables.getAccountingDataDataAct.requisitionAccountingOut;
rec.requisitionCostCentersAttr = model.variables.l_SelectedCostCentersListVar;
rec.requisitionServicesAttr = model.variables.getRequisitionServicesByRequisitionIdAggr.listOut;
return rec;
}(), false, (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.modify), "", OS$DataTypes.LongInteger.defaultValue, callContext).then(function (value) {
saveRequisitionVar.value = value;
}).then(function () {
// Success?
if((saveRequisitionVar.value.o_OutputOut.isSuccessAttr)) {
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5YvRq14OnUmU+t3SIxd+oA#Message.-1983796447.1", "Alterações guardadas com sucesso."), /*Success*/ 1);
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(saveRequisitionVar.value.o_RequisitionIdOut, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(saveRequisitionVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
}

});
}).catch(function (ex) {
OS$Logger.debug("RequisitionDetail.SaveOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "751e12fb-45fc-4cb6-ad99-35f9ce073727");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading3
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
_wb_SelectReqRegion_PopupSelect$Action(i_RegionIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SelectReqRegion_PopupSelect", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SelectReqRegion_PopupSelect");
span.setAttribute("outsystems.function.key", "37e9dac4-5f4f-4c1d-9c46-b12931fe2fd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SelectReqRegion_PopupSelect");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_SelectReqRegion_PopupSelect$vars"))());
vars.value.i_RegionIdInLocal = i_RegionIdIn;
return OS$Flow.executeAsyncFlow(function () {
// l_RegionId = i_RegionId
model.variables.l_RegionIdVar = vars.value.i_RegionIdInLocal;
// l_ShowHideSelectReqRegion_Popup = False
model.variables.l_ShowHideSelectReqRegion_PopupVar = false;
// Refresh Query: GetUserApplicationRoles
var result = controller.getUserApplicationRoles$DataActRefresh(callContext);
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
_dropdown_CostCenterSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_CostCenterSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CostCenterSearchOnChanged");
span.setAttribute("outsystems.function.key", "438160f5-028a-4e14-87e8-db05e2c584b8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_CostCenterSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_CostCenterSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// GetRequisitionById.List.Current.Requisition.CostCenterId = LongIntegerToIdentifier
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr = OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_switch_DepositOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_DepositOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_DepositOnChange");
span.setAttribute("outsystems.function.key", "43f92155-6716-49c0-951f-134c6ee62444");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_DepositOnChange");
callContext = controller.callContext(callContext);
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr)))) {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut, callContext);
}

// Empty?
if((model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.isEmpty)) {
// Execute Action: AddDeposit
controller._addRecord$Action(true, false, false, false, false, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_removeFromList$Action(i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, isEstim_Equal_AgreedIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RemoveFromList", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "4a073dd4-e895-4e32-854c-6b405b5fffda");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RemoveFromList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.RemoveFromList$vars"))());
vars.value.i_PositionInLocal = i_PositionIn;
vars.value.i_IsDepositInLocal = i_IsDepositIn;
vars.value.i_IsServiceInLocal = i_IsServiceIn;
vars.value.i_IsAttachedFileInLocal = i_IsAttachedFileIn;
vars.value.i_IsInsuranceInLocal = i_IsInsuranceIn;
vars.value.isEstim_Equal_AgreedInLocal = isEstim_Equal_AgreedIn;
if((vars.value.i_IsDepositInLocal)) {
// Execute Action: ListRemoveDeposit
OS$SystemActions.listRemove(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsInsuranceInLocal) {
// Execute Action: ListRemoveInsurance
OS$SystemActions.listRemove(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.i_IsServiceInLocal) {
// Execute Action: ListRemoveService
OS$SystemActions.listRemove(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut, vars.value.i_PositionInLocal, callContext);
// Execute Action: RecalculateTotalAmount
controller._recalculateTotalAmount$Action(callContext);
} else {
if(vars.value.i_IsAttachedFileInLocal) {
// Execute Action: ListRemoveFile
OS$SystemActions.listRemove(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut, vars.value.i_PositionInLocal, callContext);
} else {
if(vars.value.isEstim_Equal_AgreedInLocal) {
// Execute Action: ListRemoveEstim_Equal_Agreed
OS$SystemActions.listRemove(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, vars.value.i_PositionInLocal, callContext);
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
_switch_AdvancedPayment2OnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_AdvancedPayment2OnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_AdvancedPayment2OnChange");
span.setAttribute("outsystems.function.key", "51edcfae-5777-4a19-942a-23ba498c9add");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_AdvancedPayment2OnChange");
callContext = controller.callContext(callContext);
// not advance
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr)))) {
// reset values
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionContractFile.Amount = 0
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr = OS$BuiltinFunctions.integerToDecimal(0);
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionContractFile.AdvancePaymentTypeId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionContractFile.InsuranceTypeId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.insuranceTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_event_ChangeSupplier$Action(i_SupplierIdIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Event_ChangeSupplier", function (span) {
if(span) {
span.setAttribute("code.function", "Event_ChangeSupplier");
span.setAttribute("outsystems.function.key", "5fa6f975-d0b8-4202-a8da-abaf9217b766");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Event_ChangeSupplier");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Event_ChangeSupplier$vars"))());
vars.value.i_SupplierIdInLocal = i_SupplierIdIn;
return OS$Flow.executeAsyncFlow(function () {
// GetRequisitionById.List.Current.Requisition.SupplierId = i_SupplierId
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr = vars.value.i_SupplierIdInLocal;
// Refresh Query: GetSupplierByRequisition
var result = controller.getSupplierByRequisition$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Refresh Query: GetSupplierSocieties
var result = controller.getSupplierSocieties$AggrRefresh(999999999, 0, callContext);
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
_wb_SearchDropdownRefresh_Project$Action(newMaxRecordsIn, newSearchTextIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchDropdownRefresh_Project", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchDropdownRefresh_Project");
span.setAttribute("outsystems.function.key", "6a6b03e2-bf28-4154-a24d-9424a896b911");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SearchDropdownRefresh_Project");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_SearchDropdownRefresh_Project$vars"))());
vars.value.newMaxRecordsInLocal = newMaxRecordsIn;
vars.value.newSearchTextInLocal = newSearchTextIn;
return OS$Flow.executeAsyncFlow(function () {
// ProjectAssetMaxRecord = newMaxRecords
model.variables.projectAssetMaxRecordVar = vars.value.newMaxRecordsInLocal;
// ProjectAssetSearchText = newSearchText
model.variables.projectAssetSearchTextVar = vars.value.newSearchTextInLocal;
// Refresh Query: GetProjectAssetServices
var result = controller.getProjectAssetServices$AggrRefresh(model.variables.projectAssetMaxRecordVar, 0, callContext);
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
_saveContractPendingInfo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveContractPendingInfo", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractPendingInfo");
span.setAttribute("outsystems.function.key", "6b8e3271-7bc3-41d5-93a8-eca295ab3b04");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveContractPendingInfo");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// GetRequisitionById.List.Current.Requisition.HasUpdatedDateOfCommitment = If
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr = ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr) ? (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr) : (!(model.variables.l_OriginalDateOfCommitmentVar.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr))));
// Execute Action: SaveContractPendingInfo
model.flush();
return controller.saveContractPendingInfo$ServerAction(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr, model.variables.getRequisitionContractDataDataAct.o_ContractFileOut, model.variables.l_OriginalDateOfCommitmentVar, callContext).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("LLd4RsiGRk+dzxZAzGg6mA#Message.-1983796447.1", "Alterações guardadas com sucesso."), /*Success*/ 1);
// l_ShowSavePendingInfoBtn = False
model.variables.l_ShowSavePendingInfoBtnVar = false;
// Refresh Query: GetRequisitionById
var result = controller.getRequisitionById$AggrRefresh(1, 0, callContext);
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
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "6bed97be-19c7-41a5-9242-2d273293fd9d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// JavaScript to auto height text areas.
OS$Logger.startActiveSpan("JavaScript", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript");
span.setAttribute("outsystems.function.key", "587ce69a-68c9-4bfe-9caf-f666de19cadb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_c_Requisitions_RequisitionDetail_mvc_controller_OnReady_JavaScriptJS, "JavaScript", "OnReady", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Execute Action: AuditCreateWrapper
model.flush();
return controller.auditCreateWrapper$ServerAction(function () {
var rec = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.originAttr = ConectaProveedores_staticEntities_origin.screenAccess;
rec.identifierAttr = model.variables.i_RequisitionIdIn;
rec.messageAttr = "";
rec.screenAttr = "FsP - Requisition Detail";
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
_dropdown_InsuranceTypeOnChange$Action(i_InsuranceTypeIdIn, i_CurrentRowNumberIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_InsuranceTypeOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InsuranceTypeOnChange");
span.setAttribute("outsystems.function.key", "6e2fe1c1-d7ea-49cb-b1f6-50d27b1f16ea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_InsuranceTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_InsuranceTypeOnChange$vars"))());
vars.value.i_InsuranceTypeIdInLocal = i_InsuranceTypeIdIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Null
if((!((vars.value.i_InsuranceTypeIdInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut, function (p) {
return (p.requisitionContractFileAttr.insuranceTypeIdAttr === vars.value.i_InsuranceTypeIdInLocal);
}, callContext);

// Second Record same Type?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// GetRequisitionContractData.o_ContractInsuranceList[i_CurrentRowNumber].RequisitionContractFile.InsuranceTypeId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getItem(vars.value.i_CurrentRowNumberInLocal).requisitionContractFileAttr.insuranceTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("onrhWki1k0SBcHUxvE8I2A#Message.-1556557250.1", "You cannot have multiple Insurances of same type"), /*Info*/ 0);
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
_dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "73b8bbf0-81ea-4f32-94d9-a48af3cb24cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.DropdownSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// GetRequisitionServicesByRequisitionId.List.Current.RequisitionService.AccountingServiceTypeId = IntegerToIdentifier
model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getAccountingAccountsServiceTypesAggr.listOut, function (p) {
return p.accountingAccounts_ServiceTypeAttr.idAttr.equals(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr);
}, callContext);

// Execute Action: Dropdown_ServiceTypeOnChange
return controller._dropdown_ServiceTypeOnChange$Action(listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.cCAttr, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_modifyRequisition$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ModifyRequisition", function (span) {
if(span) {
span.setAttribute("code.function", "ModifyRequisition");
span.setAttribute("outsystems.function.key", "7c989fda-979a-43ee-a99c-3635d5b546fc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ModifyRequisition");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
try {// Execute Action: ShowHidePopup
controller._showHideModifyPopup$Action(callContext);
// Destination: /ConectaProveedores/Requisitions
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} catch (ex) {
(function () {
OS$Logger.debug("RequisitionDetail.ModifyRequisition", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "31c18122-e06f-4f2a-a1dc-baaf26248fb5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

try {OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XyUVbpWXrkmN_kDZsgO1rg#Message.653357671.1", "Error while trying to modify the requisition!"), /*Error*/ 3);
return ;

} finally {
if(span) {
span.end();
}

}

}, 1);
}

throw ex;
})();
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
span.setAttribute("outsystems.function.key", "7eddd01c-a7be-49de-8053-f2c2bd1e3f8d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_AccountingDataTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_AccountingDataTypeOnChange$vars"))());
vars.value.i_AccountingDataTypeInLocal = i_AccountingDataTypeIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Null
if((!((vars.value.i_AccountingDataTypeInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr, function (p) {
return (p.accountingDataTypeIdAttr === vars.value.i_AccountingDataTypeInLocal);
}, callContext);

// Second Record same Type?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts[i_CurrentRowNumber].AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getItem(vars.value.i_CurrentRowNumberInLocal).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("L1zC72ycrUGNnkFiO4bAlg#Message.-663497229.1", "You cannot have multiple same types"), /*Info*/ 0);
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
span.setAttribute("outsystems.function.key", "8440a936-7981-4f9d-abe4-0e4e05b23854");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Validations");
callContext = controller.callContext(callContext);
var dropdownNotValid3Var = new OS$DataTypes.VariableHolder();
var dropdownNotValid4Var = new OS$DataTypes.VariableHolder();
var dropdownClearValidation4Var = new OS$DataTypes.VariableHolder();
var insuranceVar = new OS$DataTypes.VariableHolder();
var depositVar = new OS$DataTypes.VariableHolder();
var dropdownClearValidation3Var = new OS$DataTypes.VariableHolder();
// l_FormIsValid = True
model.variables.l_FormIsValidVar = true;
// GetRequisitionFiles.o_FinanceAuthorization.Valid.IsValid = True
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr.isValidAttr = true;
// l_NotValid = False
model.variables.l_NotValidVar = false;
// l_DropdownSupplierValid = True
model.variables.l_DropdownSupplierValidVar = true;
// Execute Action: DropdownClearValidation3
dropdownClearValidation3Var.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("CostCenterSearch"), callContext);

// Execute Action: DropdownClearValidation4
dropdownClearValidation4Var.value = OutSystemsUIController$dropdownClearValidation$Action(idService.getId("SocietySearch"), callContext);

// HasContract and not Pending
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr))) && (((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr === ""))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionContractData.o_ContractFile.Valid.IsValid = False
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr.isValidAttr = false;
// GetRequisitionContractData.o_ContractFile.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Dk3O3anazUepAF6dMA+OYg#Value.-1029745557.1", "This field is mandatory");
}

// IsContractPending
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr) && (((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr === ""))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionContractData.o_ContractPendingJustification.Valid.IsValid = False
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr.isValidAttr = false;
// GetRequisitionContractData.o_ContractPendingJustification.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AMjzJVnG_kypv2v08SvnsA#Value.-1029745557.1", "This field is mandatory");
}

// Supplier
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// l_DropdownSupplierValid = False
model.variables.l_DropdownSupplierValidVar = false;
}

// CostCenters
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr === ConectaProveedores_staticEntities_distribution.fixed) && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) {
// Execute Action: DropdownNotValid3
dropdownNotValid3Var.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("CostCenterSearch"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9lG1kM1neEeZ0aL39Gi+sA#Value.-1029745557.1", "This field is mandatory"), callContext);

// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
}

// Society
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: DropdownNotValid4
dropdownNotValid4Var.value = OutSystemsUIController$dropdownNotValid$Action(idService.getId("SocietySearch"), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cFHFewQDSEqUASPTwP3A5Q#Value.-1029745557.1", "This field is mandatory"), callContext);

// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
}

if((!(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out))) {
// Not AdvancedPay
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)))) {
// AccountServiceType
if((model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) {
// Set Valid
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// l_NotValid = True
model.variables.l_NotValidVar = true;
}

}

}

// IsAdvancePay
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)) {
if((((OS$DataTypes.areBinaryNulls(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr === "")))) {
// Set Valid
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.Valid.IsValid = False
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr.isValidAttr = false;
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.Valid.ValidationMessage = "This field is mandatory"
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Ap6xFteX8USlW_rc_hj_Qg#Value.-1029745557.1", "This field is mandatory");
}

}

// Finance
if((((!((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr || model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr))) && (((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(0))) || (model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr === ""))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionFiles.o_FinanceAuthorization.Valid.IsValid = False
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr.isValidAttr = false;
// GetRequisitionFiles.o_FinanceAuthorization.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("X8DiMTMPgEiMf0MZROMLFw#Value.-1029745557.1", "This field is mandatory");
}

// Execute Action: Deposit
depositVar.value = OS$SystemActions.listFilter(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut, function (p) {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr) && OS$DataTypes.areBinaryNulls(p.binaryAttr, OS$BuiltinFunctions.nullBinary()));
}, callContext);

// DepositEmpty
if((!(depositVar.value.filteredListOut.isEmpty))) {
// Foreach GetRequisitionContractData.o_ContractDepositList
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
try {var o_ContractDepositListIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
var o_ContractDepositListIndex = 0;
while (((o_ContractDepositListIndex < model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.length))) {
o_ContractDepositListIterator.currentRowNumber = o_ContractDepositListIndex;
if(((((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).requisitionFileAttr.filenameAttr === "")))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionContractData.o_ContractDepositList.Current.Valid.IsValid = False
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).validAttr.isValidAttr = false;
// GetRequisitionContractData.o_ContractDepositList.Current.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("E9H7bAwK+0eqfueTloiUsQ#Value.-1029745557.1", "This field is mandatory");
}

o_ContractDepositListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
}

}

// Execute Action: Insurance
insuranceVar.value = OS$SystemActions.listFilter(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut, function (p) {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr) && OS$DataTypes.areBinaryNulls(p.binaryAttr, OS$BuiltinFunctions.nullBinary()));
}, callContext);

// InsuranceEmpty_
if((!(insuranceVar.value.filteredListOut.isEmpty))) {
// Foreach GetRequisitionContractData.o_ContractInsuranceList
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
try {var o_ContractInsuranceListIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
var o_ContractInsuranceListIndex = 0;
while (((o_ContractInsuranceListIndex < model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.length))) {
o_ContractInsuranceListIterator.currentRowNumber = o_ContractInsuranceListIndex;
if(((((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getItem(o_ContractInsuranceListIndex.valueOf()).requisitionFileAttr.filenameAttr === "")))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionContractData.o_ContractInsuranceList.Current.Valid.IsValid = False
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getItem(o_ContractInsuranceListIndex.valueOf()).validAttr.isValidAttr = false;
// GetRequisitionContractData.o_ContractInsuranceList.Current.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getItem(o_ContractInsuranceListIndex.valueOf()).validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4RBovGXFJkGkEIqf+8RDPQ#Value.-1029745557.1", "This field is mandatory");
}

o_ContractInsuranceListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
}

}

// AdvancePayment
if(((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr && (((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.bigUploadfileIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr === ""))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionContractData.o_ContractAdvancePayment.Valid.IsValid = False
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr.isValidAttr = false;
// GetRequisitionContractData.o_ContractAdvancePayment.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1n0HXfSJp0mh166xXwosHQ#Value.-1029745557.1", "This field is mandatory");
}

// HasContract and not Pending
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr) && ((OS$DataTypes.areBinaryNulls(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr, OS$BuiltinFunctions.nullBinary()) && model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || (model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr === ""))))) {
// l_FormIsValid = False
model.variables.l_FormIsValidVar = false;
// GetRequisitionFiles.o_FinanceAuthorization.Valid.IsValid = False
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr.isValidAttr = false;
// GetRequisitionFiles.o_FinanceAuthorization.Valid.ValidationMessage = "This field is mandatory"
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr.validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("U5vftvdcmkKuJ5FCJPDyvQ#Value.-1029745557.1", "This field is mandatory");
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_captureOnClick$Action(createForUserIn, approvalProcessIdIn, isHierarquicalFlowIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CaptureOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CaptureOnClick");
span.setAttribute("outsystems.function.key", "85fdf1e0-6656-4e08-9da2-642a783e50b1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("CaptureOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.CaptureOnClick$vars"))());
vars.value.createForUserInLocal = createForUserIn;
vars.value.approvalProcessIdInLocal = approvalProcessIdIn;
vars.value.isHierarquicalFlowInLocal = isHierarquicalFlowIn;
var saveRequisitionVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// l_IsBusy = True
model.variables.l_IsBusyVar = true;
// Execute Action: Validations
controller._validations$Action(callContext);
// not valid?
return OS$Flow.executeSequence(function () {
if((((!(model.widgets.get(idService.getId("Form")).validAttr)) || (!(model.variables.l_FormIsValidVar))))) {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5vbLkehXh0GZFP8+wWpOVQ#Message.-1752268912.1", "Some mandatory fields are not being filled"), /*Error*/ 3);
} else {
// l_NotValidContractValue = False
model.variables.l_NotValidContractValueVar = false;
// contract deposit
// Foreach GetRequisitionContractData.o_ContractDepositList
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
try {var o_ContractDepositListIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
var o_ContractDepositListIndex = 0;
while (((o_ContractDepositListIndex < model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.length))) {
o_ContractDepositListIterator.currentRowNumber = o_ContractDepositListIndex;
// amount error
if((model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(o_ContractDepositListIndex.valueOf()).requisitionContractFileAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr))) {
// l_NotValidContractValue = True
model.variables.l_NotValidContractValueVar = true;
}

o_ContractDepositListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut);
}

// contract insurance
// Foreach GetRequisitionContractData.o_ContractInsuranceList
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
try {var o_ContractInsuranceListIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
var o_ContractInsuranceListIndex = 0;
while (((o_ContractInsuranceListIndex < model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.length))) {
o_ContractInsuranceListIterator.currentRowNumber = o_ContractInsuranceListIndex;
// amount error
if((model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getItem(o_ContractInsuranceListIndex.valueOf()).requisitionContractFileAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr))) {
// l_NotValidContractValue = True
model.variables.l_NotValidContractValueVar = true;
}

o_ContractInsuranceListIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut);
}

// contract file amount error
if((model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr.gt(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr))) {
// l_NotValidContractValue = True
model.variables.l_NotValidContractValueVar = true;
}

// NotValidPaymentsValue
// l_FormIsValid = notl_NotValidContractValue
model.variables.l_FormIsValidVar = (!(model.variables.l_NotValidContractValueVar));
// Valid?
return OS$Flow.executeSequence(function () {
if(((model.widgets.get(idService.getId("Form")).validAttr && model.variables.l_FormIsValidVar))) {
// Execute Action: ClearFields
controller._clearFields$Action(callContext);
// Execute Action: ListOfFiles
controller._listOfFiles$Action(callContext);
// Execute Action: GetIsForSpecialWorkflow
return controller._getIsForSpecialWorkflow$Action(vars.value.createForUserInLocal, vars.value.approvalProcessIdInLocal, vars.value.isHierarquicalFlowInLocal, callContext).then(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.l_IsToExitCaptureVar)) {
// reset
// l_IsToExitCapture = False
model.variables.l_IsToExitCaptureVar = false;
} else {
// Execute Action: GetIsShowAssignFirstApproverPopup
return controller._getIsShowAssignFirstApproverPopup$Action(vars.value.createForUserInLocal, vars.value.approvalProcessIdInLocal, callContext).then(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.l_IsToExitCaptureVar)) {
// reset
// l_IsToExitCapture = False
model.variables.l_IsToExitCaptureVar = false;
} else {
// Execute Action: SaveRequisition
model.flush();
return controller.saveRequisition$ServerAction(function () {
var rec = new RC_44742d4360afdf16ff97b37b2eff1760();
rec.allFilesAttr = model.variables.l_AllFilesVar;
rec.i_RequisitionAccConcept_EstimEqualAgAttr = model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut;
rec.requisitionAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr;
rec.requisitionAccConceptsRecordListAttr = model.variables.getAccountingDataDataAct.o_RemainingOut;
rec.requisitionAccountingAttr = model.variables.getAccountingDataDataAct.requisitionAccountingOut;
rec.requisitionCostCentersAttr = model.variables.l_SelectedCostCentersListVar;
rec.requisitionServicesAttr = model.variables.getRequisitionServicesByRequisitionIdAggr.listOut;
return rec;
}(), true, (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.modify), vars.value.createForUserInLocal, vars.value.approvalProcessIdInLocal, callContext).then(function (value) {
saveRequisitionVar.value = value;
}).then(function () {
// Success?
if((saveRequisitionVar.value.o_OutputOut.isSuccessAttr)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mVjKJUxDBEycuftOp5JFKg#Message.-308488654.1", "Captura de dados finalizada com sucesso. Requisição submetida para aprovação."), /*Success*/ 1);
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(saveRequisitionVar.value.o_RequisitionIdOut, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
// Execute Action: HideLoading2
ConectaProveedoresController$hideLoading$Action(callContext);
OS$FeedbackMessageService.showFeedbackMessage(saveRequisitionVar.value.o_OutputOut.messageAttr, /*Error*/ 3);
// has Id
if((!(saveRequisitionVar.value.o_RequisitionIdOut.equals(model.variables.i_RequisitionIdIn)))) {
// Destination: /ConectaProveedores/RequisitionDetail
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(saveRequisitionVar.value.o_RequisitionIdOut, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
}

}

});
}

});
});
}

});
});
} else {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AfjlJmPbGEui9zeHaBZtIQ#Message.-1842369923.1", "The total amount of payments is higher then the total amount defined by the requisition, please revise your payments"), /*Warning*/ 2);
// Execute Action: HideLoading5
ConectaProveedoresController$hideLoading$Action(callContext);
}

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
_showHideSelectReqRegion_Popup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideSelectReqRegion_Popup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideSelectReqRegion_Popup");
span.setAttribute("outsystems.function.key", "866044e0-191d-4563-b5bc-b89b9272695e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideSelectReqRegion_Popup");
callContext = controller.callContext(callContext);
// l_ShowHideSelectReqRegion_Popup = notl_ShowHideSelectReqRegion_Popup
model.variables.l_ShowHideSelectReqRegion_PopupVar = (!(model.variables.l_ShowHideSelectReqRegion_PopupVar));
if((!(model.variables.l_ShowHideSelectReqRegion_PopupVar))) {
// Destination: /ConectaProveedores/Requisitions
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_switch_ContractOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_ContractOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_ContractOnChange");
span.setAttribute("outsystems.function.key", "889a05b7-953e-4490-ae5d-eaad9504a4e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Switch_ContractOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Set Contract
// GetRequisitionById.List.Current.Requisition.IsContractPending = False
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr = false;
// GetRequisitionById.List.Current.Requisition.IsAdvanced = If
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr = ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr) ? (false) : (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr));
// Refresh Query: GetCurrencies
var result = controller.getCurrencies$AggrRefresh(50, 0, callContext);
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
_getUserApplicationRolesOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "89f4f3cd-28e6-4b66-9bf2-d8293c9f9fd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetUserApplicationRolesOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetRequisitionById
var result = controller.getRequisitionById$AggrRefresh(1, 0, callContext);
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
_getAccountableGuideOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetAccountableGuideOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountableGuideOnAfterFetch");
span.setAttribute("outsystems.function.key", "8c61914b-0fb9-4df7-90d8-fc94c5c4b5a1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetAccountableGuideOnAfterFetch");
callContext = controller.callContext(callContext);
// variable
if((!((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr === ConectaProveedores_staticEntities_distribution.variable)))) {
// set costcenter
// GetRequisitionById.List.Current.Requisition.CostCenterId = GetAccountableGuide.List.Current.AccountableGuide.CostCenterSAPId
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr = model.variables.getAccountableGuideAggr.listOut.getCurrent(callContext.iterationContext).accountableGuideAttr.costCenterSAPIdAttr;
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
span.setAttribute("outsystems.function.key", "8ed05a56-b210-4c0e-9408-f918840ad803");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Approve");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Is Accounting?
return OS$Flow.executeSequence(function () {
if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr)) {
// Execute Action: ApproveRequisitionAccounting
return controller._approveRequisitionAccounting$Action(callContext);
} else {
// Execute Action: ApproveRequisition
return controller._approveRequisition$Action(callContext);
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
_showHideCancelPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideCancelPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideCancelPopup");
span.setAttribute("outsystems.function.key", "988402c1-a7d6-4b4c-aaa6-a7086e925de4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideCancelPopup");
callContext = controller.callContext(callContext);
// ShowCancelPopup
// l_ShowCancelPopup = notl_ShowCancelPopup
model.variables.l_ShowCancelPopupVar = (!(model.variables.l_ShowCancelPopupVar));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_switch_InsuranceOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_InsuranceOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_InsuranceOnChange");
span.setAttribute("outsystems.function.key", "9c7b740b-c061-458e-b02b-735994d8a58d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_InsuranceOnChange");
callContext = controller.callContext(callContext);
if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr)))) {
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut, callContext);
}

// Empty?
if((model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.isEmpty)) {
// Execute Action: AddInsurance
controller._addRecord$Action(false, false, true, false, false, callContext);
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
span.setAttribute("outsystems.function.key", "a08cca0e-e4b0-42b2-bc77-4ba46ae051d8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_DepositTypeOnChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_DepositTypeOnChange$vars"))());
vars.value.i_DepositTypeIdInLocal = i_DepositTypeIdIn;
vars.value.i_CurrentRowNumberInLocal = i_CurrentRowNumberIn;
var listFilterVar = new OS$DataTypes.VariableHolder();
// Null
if((!((vars.value.i_DepositTypeIdInLocal === OS$BuiltinFunctions.nullIdentifier())))) {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut, function (p) {
return (p.requisitionContractFileAttr.depositTypeIdAttr === vars.value.i_DepositTypeIdInLocal);
}, callContext);

// Second Record same Type?
if(((listFilterVar.value.filteredListOut.length > 1))) {
// GetRequisitionContractData.o_ContractDepositList[i_CurrentRowNumber].RequisitionContractFile.DepositTypeId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getItem(vars.value.i_CurrentRowNumberInLocal).requisitionContractFileAttr.depositTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2Kz20umKk0ya4m23lDihNg#Message.-322431486.1", "You cannot have multiple Deposits of same type"), /*Info*/ 0);
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
_dropdown_CurrencyOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_CurrencyOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CurrencyOnChange");
span.setAttribute("outsystems.function.key", "a0cdf1a1-d835-4114-a67c-fcc526989aea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Dropdown_CurrencyOnChange");
callContext = controller.callContext(callContext);
if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Set Currencies
// GetRequisitionContractData.o_ContractDepositList.Current.RequisitionContractFile.CurrencyId = GetRequisitionById.List.Current.Requisition.CurrencyId
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
// GetRequisitionContractData.o_ContractInsuranceList.Current.RequisitionContractFile.CurrencyId = GetRequisitionById.List.Current.Requisition.CurrencyId
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionContractFile.CurrencyId = GetRequisitionById.List.Current.Requisition.CurrencyId
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdownSearchOnChangedFormats$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedFormats", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedFormats");
span.setAttribute("outsystems.function.key", "ac779921-8c1c-4278-bea5-458691730d39");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DropdownSearchOnChangedFormats");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.DropdownSearchOnChangedFormats$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
// GetRequisitionById.List.Current.Requisition.ServiceFormatId = IntegerToIdentifier
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdown_DistributionOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_DistributionOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DistributionOnChange");
span.setAttribute("outsystems.function.key", "b2816968-1b7f-499e-97c4-3ad7e1771b80");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_DistributionOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Cost Centers Fetched?
return OS$Flow.executeSequence(function () {
if((!((model.variables.getRequisitionCostCentersByRequisitionIdAggr.isDataFetchedAttr && model.variables.getRequisitionCostCentersByRequisitionIdAggr.hasFetchErrorAttr)))) {
// Refresh Query: GetRequisitionCostCentersByRequisitionId
var result = controller.getRequisitionCostCentersByRequisitionId$AggrRefresh(999999, 0, callContext);
model.flush();
return result;
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
_switch_IsActiveOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_IsActiveOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_IsActiveOnChange");
span.setAttribute("outsystems.function.key", "b7453bd9-884e-4504-8044-289802d20d61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_IsActiveOnChange");
callContext = controller.callContext(callContext);
if(((!(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr)))) {
// Clear field
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts.Current.Amount = 0
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr = OS$BuiltinFunctions.integerToDecimal(0);
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts.Current.AccountingDataTypeId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr = OS$BuiltinFunctions.nullIdentifier();
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts.Current.NumberOfPayments = 0
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr = 0;
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts.Current.CurrencyId = NullTextIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).currencyIdAttr = OS$BuiltinFunctions.nullTextIdentifier();
// GetAccountingData.o_Estim_Equal_Agreed.SubAccConcepts.Current.RequisitionAccConceptsId = NullIdentifier
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).requisitionAccConceptsIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
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
span.setAttribute("outsystems.function.key", "c4ea7ab5-6987-4959-a692-e633755ee1bf");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.DatePickerOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
if((((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved)) && (OS$BuiltinFunctions.getUserId() === model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr)) && (!(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal).equals(model.variables.l_OriginalDateOfCommitmentVar)) || (!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) && ((model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr) !== (""))))))) {
// l_ShowSavePendingInfoBtn = True
model.variables.l_ShowSavePendingInfoBtnVar = true;
} else {
// l_ShowSavePendingInfoBtn = False
model.variables.l_ShowSavePendingInfoBtnVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSupplierDetailBySocietyOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierDetailBySocietyOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierDetailBySocietyOnAfterFetch");
span.setAttribute("outsystems.function.key", "c74410da-b202-48d2-b61c-9f4ffb5189e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSupplierDetailBySocietyOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetPaymentMethodsBySupplierId
var result = controller.getPaymentMethodsBySupplierId$DataActRefresh(callContext);
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
_wb_SearchDropdownBigSetVar_Project$Action(idIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_SearchDropdownBigSetVar_Project", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchDropdownBigSetVar_Project");
span.setAttribute("outsystems.function.key", "ceff623c-0315-4d3f-a2e8-ca777e961fe4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Wb_SearchDropdownBigSetVar_Project");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_SearchDropdownBigSetVar_Project$vars"))());
vars.value.idInLocal = idIn;
return OS$Flow.executeAsyncFlow(function () {
// set id
// GetRequisitionById.List.Current.Requisition.ProjectAssetServiceId = IntegerToIdentifier
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(OS$BuiltinFunctions.longIntegerToText(vars.value.idInLocal))));
// Refresh Query: GetProjectAssetByRequisition
var result = controller.getProjectAssetByRequisition$AggrRefresh(1, 0, callContext);
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
_recalculateTotalAmount$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RecalculateTotalAmount", function (span) {
if(span) {
span.setAttribute("code.function", "RecalculateTotalAmount");
span.setAttribute("outsystems.function.key", "d4e04c3b-ea82-44b5-a69b-158cb54c7827");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("RecalculateTotalAmount");
callContext = controller.callContext(callContext);
// GetRequisitionById.List.Current.Requisition.TotalAmount = 0
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr = OS$BuiltinFunctions.integerToDecimal(0);
// Foreach GetRequisitionServicesByRequisitionId.List
callContext.iterationContext.registerIterationStart(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut);
try {var getRequisitionServicesByRequisitionIdIterator = callContext.iterationContext.getIterator(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut);
var getRequisitionServicesByRequisitionIdIndex = 0;
while (((getRequisitionServicesByRequisitionIdIndex < model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.length))) {
getRequisitionServicesByRequisitionIdIterator.currentRowNumber = getRequisitionServicesByRequisitionIdIndex;
// GetRequisitionById.List.Current.Requisition.TotalAmount = GetRequisitionById.List.Current.Requisition.TotalAmount + GetRequisitionServicesByRequisitionId.List.Current.RequisitionService.Amount
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr.plus(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getItem(getRequisitionServicesByRequisitionIdIndex.valueOf()).requisitionServiceAttr.amountAttr);
getRequisitionServicesByRequisitionIdIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getShowSelectReqPopupOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetShowSelectReqPopupOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetShowSelectReqPopupOnAfterFetch");
span.setAttribute("outsystems.function.key", "eb2fb443-30b2-4dd3-b35b-fad3024cd1a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetShowSelectReqPopupOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((model.variables.getShowSelectReqPopupDataAct.isCorporativoOut)) {
// Execute Action: ShowHideSelectReqRegion_Popup
controller._showHideSelectReqRegion_Popup$Action(callContext);
} else {
// Refresh Query: GetUserApplicationRoles
var result = controller.getUserApplicationRoles$DataActRefresh(callContext);
model.flush();
return result;
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
_showHideSpecialOrNormalWorkflowPopup$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowHideSpecialOrNormalWorkflowPopup", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideSpecialOrNormalWorkflowPopup");
span.setAttribute("outsystems.function.key", "f125f91e-ad32-45d1-938d-59d9217f05b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowHideSpecialOrNormalWorkflowPopup");
callContext = controller.callContext(callContext);
// l_ShowHideSpecialOrNormalWorkflow = notl_ShowHideSpecialOrNormalWorkflow
model.variables.l_ShowHideSpecialOrNormalWorkflowVar = (!(model.variables.l_ShowHideSpecialOrNormalWorkflowVar));
if(((!(model.variables.l_ShowHideSpecialOrNormalWorkflowVar)))) {
// l_IsBusy = False
model.variables.l_IsBusyVar = false;
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_closeSidebar$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseSidebar", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "f1e494ba-81ca-428b-b135-477b1d1952ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseSidebar");
callContext = controller.callContext(callContext);
var sidebarCloseVar = new OS$DataTypes.VariableHolder();
// Execute Action: SidebarClose
sidebarCloseVar.value = OutSystemsUIController$sidebarClose$Action(idService.getId("SidebarLog"), callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_switch_ConceptOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Switch_ConceptOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_ConceptOnChange");
span.setAttribute("outsystems.function.key", "f2b31692-55ad-45c4-8781-d5ee09c0c19a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Switch_ConceptOnChange");
callContext = controller.callContext(callContext);
// not active
if(((!(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.isActiveAttr)))) {
// reset amount
// GetAccountingData.o_Remaining.Current.RequisitionAccConcepts.Amount = 0
model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.amountAttr = OS$BuiltinFunctions.integerToDecimal(0);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_wb_BigUploadEventstartProcess$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("wb_BigUploadEventstartProcess", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadEventstartProcess");
span.setAttribute("outsystems.function.key", "f47b1893-4189-429a-bac7-277022a3b8eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("wb_BigUploadEventstartProcess");
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
_dropdown_BusinessCategoryValueOnChange$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Dropdown_BusinessCategoryValueOnChange", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_BusinessCategoryValueOnChange");
span.setAttribute("outsystems.function.key", "f653c9dc-4d2a-4698-a579-acb7cde51072");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("Dropdown_BusinessCategoryValueOnChange");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// GetRequisitionById.List.Current.Requisition.BusinessValueSubcategoryId = NullIdentifier
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
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
_getRequisitionServicesByRequisitionIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionServicesByRequisitionIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionServicesByRequisitionIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "f70bba6d-a500-473d-bd05-d0290199d874");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetRequisitionServicesByRequisitionIdOnAfterFetch");
callContext = controller.callContext(callContext);
if((model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.isEmpty)) {
// Execute Action: AddService
controller._addRecord$Action(false, true, false, false, false, callContext);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_societySearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SocietySearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "SocietySearchOnChanged");
span.setAttribute("outsystems.function.key", "f85cf1b7-d902-4bd9-b23b-d7175a942cb8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SocietySearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.SocietySearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
var listFilterVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Set Society Id
// GetRequisitionById.List.Current.Requisition.CompanyId = IntegerToIdentifier
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)));
// Refresh Query: GetSupplierDetailBySociety
var result = controller.getSupplierDetailBySociety$AggrRefresh(1, 0, callContext);
model.flush();
return result.then(function () {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getPaymentTermsAggr.listOut, function (p) {
return (OS$BuiltinFunctions.toUpper(p.paymentTermsAttr.estructuraDescripcionPROPAttr) === OS$BuiltinFunctions.toUpper(model.variables.getSupplierDetailBySocietyAggr.listOut.getCurrent(callContext.iterationContext).supplierDetailAttr.cond_pagoAttr));
}, callContext);

// SetValues
// GetRequisitionById.List.Current.Requisition.PaymentTermsId = ListFilter.FilteredList.Current.PaymentTerms.Id
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr = listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).paymentTermsAttr.idAttr;
// Refresh Query: GetCostCenters
var result = controller.getCostCenters$AggrRefresh(999999999, 0, callContext);
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
_wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, i_IsAdvWithoutInvoiceIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "ff30ac52-9a47-4036-919c-f8145340d8f5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Wb_CustomUploadOnFileChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_CustomUploadOnFileChange$vars"))());
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
vars.value.i_IsAdvWithoutInvoiceInLocal = i_IsAdvWithoutInvoiceIn;
if(((vars.value.errorInLocal.successAttr || OS$DataTypes.areBinaryNulls(vars.value.fileInLocal.fileContentAttr, OS$BuiltinFunctions.nullBinary())))) {
if((vars.value.i_IsFinanceAuthorizationInLocal)) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionFiles.o_FinanceAuthorization.Binary = NullBinary
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionFiles.o_FinanceAuthorization.RequisitionFile.Filename = ""
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr = "";
// GetRequisitionFiles.o_FinanceAuthorization.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionFiles.o_FinanceAuthorization.RequisitionContractFile.ContractFileTypeId = FinanceAuthorization
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.financeAuthorization;
}

// GetRequisitionFiles.o_FinanceAuthorization.Binary = File.FileContent
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionFiles.o_FinanceAuthorization.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
// GetRequisitionFiles.o_FinanceAuthorization.BigUploadfileId = File.FileBigFileId
model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.bigUploadfileIdAttr = vars.value.fileInLocal.fileBigFileIdAttr;
}

} else {
if(vars.value.i_IsProofOfForeignResidenceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionFiles.o_ProofOfForeignResidence.Binary = NullBinary
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionFiles.o_ProofOfForeignResidence.RequisitionFile.Filename = ""
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr = "";
// GetRequisitionFiles.o_ProofOfForeignResidence.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionFiles.o_ProofOfForeignResidence.RequisitionContractFile.ContractFileTypeId = ProofOfForeignResidence
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.proofOfForeignResidence;
}

// GetRequisitionFiles.o_ProofOfForeignResidence.Binary = File.FileContent
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionFiles.o_ProofOfForeignResidence.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsContractInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionContractData.o_ContractFile.Binary = NullBinary
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionContractData.o_ContractFile.RequisitionFile.Filename = ""
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr = "";
// GetRequisitionContractData.o_ContractFile.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionContractData.o_ContractFile.RequisitionContractFile.ContractFileTypeId = Contract
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.contract;
}

// GetRequisitionContractData.o_ContractFile.Binary = File.FileContent
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionContractData.o_ContractFile.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

if((((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved)) && (OS$BuiltinFunctions.getUserId() === model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr)) && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr.equals(model.variables.l_OriginalDateOfCommitmentVar)) || (!(OS$DataTypes.areBinaryNulls(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary())) && ((model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr) !== (""))))))) {
// l_ShowSavePendingInfoBtn = True
model.variables.l_ShowSavePendingInfoBtnVar = true;
} else {
// l_ShowSavePendingInfoBtn = False
model.variables.l_ShowSavePendingInfoBtnVar = false;
}

} else {
if(vars.value.i_IsAttachedFilesInLocal) {
// Execute Action: ListAppendFile
OS$SystemActions.listAppend(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut, OS$DataConversion.JSConversions.typeConvertRecord(vars.value.fileInLocal, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), function (source, target) {
target.requisitionContractFileAttr.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.requisitionContractFileAttr.requisitionIdAttr = model.variables.i_RequisitionIdIn;
target.requisitionFileAttr.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
target.requisitionFileAttr.filenameAttr = source.fileNameAttr;
target.requisitionFileAttr.createdByAttr = OS$BuiltinFunctions.getUserId();
target.requisitionFileAttr.createdOnAttr = OS$BuiltinFunctions.currDateTime();
target.binaryAttr = source.fileContentAttr;
return target;
}), callContext);
// l_Attached_Filename = ""
model.variables.l_Attached_FilenameVar = "";
// l_AttachedFile_BinaryData = NullBinary
model.variables.l_AttachedFile_BinaryDataVar = OS$BuiltinFunctions.nullBinary();
} else {
if(vars.value.i_IsDepositInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionContractData.o_ContractDepositList.Current.Binary = NullBinary
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionContractData.o_ContractDepositList.Current.RequisitionFile.Filename = ""
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr = "";
// GetRequisitionContractData.o_ContractDepositList.Current.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionContractData.o_ContractDepositList.Current.RequisitionContractFile.ContractFileTypeId = Deposit
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.deposit;
}

// GetRequisitionContractData.o_ContractDepositList.Current.Binary = File.FileContent
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionContractData.o_ContractDepositList.Current.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsInsuranceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionContractData.o_ContractInsuranceList.Current.Binary = NullBinary
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionContractData.o_ContractInsuranceList.Current.RequisitionFile.Filename = ""
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr = "";
// GetRequisitionContractData.o_ContractInsuranceList.Current.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionContractData.o_ContractInsuranceList.Current.RequisitionContractFile.ContractFileTypeId = Insurance
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.insurance;
}

// GetRequisitionContractData.o_ContractInsuranceList.Current.Binary = File.FileContent
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionContractData.o_ContractInsuranceList.Current.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsAdvancePaymentInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionContractData.o_ContractAdvancePayment.Binary = NullBinary
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionFile.Filename = ""
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr = "";
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionContractFile.ContractFileTypeId = AdvancePayment
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.advancePayment;
}

// GetRequisitionContractData.o_ContractAdvancePayment.Binary = File.FileContent
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionContractData.o_ContractAdvancePayment.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsExchangeRateEvidenceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetAccountingData.ExchangeRateEvidence.Binary = NullBinary
model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetAccountingData.ExchangeRateEvidence.RequisitionFile.Filename = ""
model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr = "";
// GetAccountingData.ExchangeRateEvidence.RequisitionFile.StorageId = NullIdentifier
model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetAccountingData.ExchangeRateEvidence.RequisitionContractFile.ContractFileTypeId = ExchangeRateEvidence
model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.exchangeRateEvidence;
}

// GetAccountingData.ExchangeRateEvidence.Binary = File.FileContent
model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetAccountingData.ExchangeRateEvidence.RequisitionFile.Filename = File.FileName
model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsContractPendingJustificationInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetRequisitionContractData.o_ContractPendingJustification.Binary = NullBinary
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetRequisitionContractData.o_ContractPendingJustification.RequisitionFile.Filename = ""
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr = "";
// GetRequisitionContractData.o_ContractPendingJustification.RequisitionFile.StorageId = NullIdentifier
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetRequisitionContractData.o_ContractPendingJustification.RequisitionContractFile.ContractFileTypeId = ContractPendingJustification
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.contractPendingJustification;
}

// GetRequisitionContractData.o_ContractPendingJustification.Binary = File.FileContent
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetRequisitionContractData.o_ContractPendingJustification.RequisitionFile.Filename = File.FileName
model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsREPSEInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetAccountingData.REPSE.Binary = NullBinary
model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetAccountingData.REPSE.RequisitionFile.Filename = ""
model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr = "";
// GetAccountingData.REPSE.RequisitionFile.StorageId = NullIdentifier
model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetAccountingData.REPSE.RequisitionContractFile.ContractFileTypeId = REPSE
model.variables.getAccountingDataDataAct.rEPSEOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.rEPSE;
}

// GetAccountingData.REPSE.Binary = File.FileContent
model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetAccountingData.REPSE.RequisitionFile.Filename = File.FileName
model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
}

} else {
if(vars.value.i_IsAdvWithoutInvoiceInLocal) {
if((vars.value.i_IsDeleteInLocal)) {
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.Binary = NullBinary
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr = OS$BuiltinFunctions.nullBinary();
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionFile.Filename = ""
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr = "";
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionFile.StorageId = NullIdentifier
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
} else {
// Already Exists?
if((!(!(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))))) {
// Type
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionContractFile.ContractFileTypeId = AdvancePayment
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.contractFileTypeIdAttr = ConectaProveedores_staticEntities_contractFileType.advancePayment;
}

// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.Binary = File.FileContent
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr = vars.value.fileInLocal.fileContentAttr;
// GetAdvWithoutInvoiceData.o_AdvWithoutInvoice.RequisitionFile.Filename = File.FileName
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr = vars.value.fileInLocal.fileNameAttr;
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

showHideModifyPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideModifyPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideModifyPopup");
span.setAttribute("outsystems.function.key", "0007e601-70cb-4c95-84b4-f128c0bedefc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideModifyPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getIsForSpecialWorkflow$Action(createForUserIn, approvalProcessIdIn, isHierarquicalFlowIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetIsForSpecialWorkflow__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsForSpecialWorkflow");
span.setAttribute("outsystems.function.key", "05cff0da-abfb-403b-ab6c-2758577f11fc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getIsForSpecialWorkflow$Action, callContext, createForUserIn, approvalProcessIdIn, isHierarquicalFlowIn);
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
span.setAttribute("outsystems.function.key", "078dcfde-f77a-41d3-9fcd-2ad037dc348d");
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

addRecord$Action(i_IsDepositIn, i_IsServiceIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsConceptsIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddRecord__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddRecord");
span.setAttribute("outsystems.function.key", "0cbaa7e9-96bf-419f-90ce-050828225e68");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._addRecord$Action, callContext, i_IsDepositIn, i_IsServiceIn, i_IsInsuranceIn, i_IsEstim_Equal_AgreedIn, i_IsConceptsIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

seeLogsOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SeeLogsOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SeeLogsOnClick");
span.setAttribute("outsystems.function.key", "10d8267c-797a-493f-a905-81aa1243b8cd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._seeLogsOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

approveRequisitionAccounting$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveRequisitionAccounting__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRequisitionAccounting");
span.setAttribute("outsystems.function.key", "111d5c53-ff3e-46d2-be26-e241390e8f0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approveRequisitionAccounting$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

cancelRequisition$Action(i_IsDataCaptureIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CancelRequisition__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CancelRequisition");
span.setAttribute("outsystems.function.key", "1497898a-dccc-48d9-aac1-99de07d2fc47");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._cancelRequisition$Action, callContext, i_IsDataCaptureIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_Project2OnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_Project2OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_Project2OnChange");
span.setAttribute("outsystems.function.key", "1758fbfb-65e7-4378-8d4c-a10664f8e94b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_Project2OnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onClickOpenDatePickerDateOfCommitment$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnClickOpenDatePickerDateOfCommitment__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnClickOpenDatePickerDateOfCommitment");
span.setAttribute("outsystems.function.key", "17a3ce4c-e957-4071-9f9f-50fd482c7db8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onClickOpenDatePickerDateOfCommitment$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getRequisitionByIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionByIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionByIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "1d0b7fdf-9a73-46d2-b479-876b5b2e2e13");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRequisitionByIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_AdvancedPaymentTypeOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_AdvancedPaymentTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_AdvancedPaymentTypeOnChange");
span.setAttribute("outsystems.function.key", "1ef99bc0-5c4e-4330-b1ab-f40b541c91ca");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_AdvancedPaymentTypeOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

showHideAssignFirstApproverPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideAssignFirstApproverPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideAssignFirstApproverPopup");
span.setAttribute("outsystems.function.key", "1f2c9797-da87-4d28-a77c-80ae66950b25");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideAssignFirstApproverPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadEventEndProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadEventEndProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadEventEndProcess");
span.setAttribute("outsystems.function.key", "253c477c-2227-4c98-9a7e-a42233a95a21");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadEventEndProcess$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_ServiceTypeOnChange$Action(accountIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_ServiceTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_ServiceTypeOnChange");
span.setAttribute("outsystems.function.key", "2701d536-0ce1-4a33-bf6b-6690c521844c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_ServiceTypeOnChange$Action, callContext, accountIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

approveRequisition$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ApproveRequisition__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ApproveRequisition");
span.setAttribute("outsystems.function.key", "2ef6c68c-aa41-4aeb-93e6-8cd35fb8c2b9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._approveRequisition$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_BigUploadNotifyFileId$Action(fileIdIn, filenameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadNotifyFileId__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadNotifyFileId");
span.setAttribute("outsystems.function.key", "2f5024b5-f97f-4c63-99a0-bc9345bc570d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadNotifyFileId$Action, callContext, fileIdIn, filenameIn);
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
span.setAttribute("outsystems.function.key", "349179db-7447-4410-a47a-ecae51cba911");
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

getIsShowAssignFirstApproverPopup$Action(createForUserIn, approvalProcessIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetIsShowAssignFirstApproverPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetIsShowAssignFirstApproverPopup");
span.setAttribute("outsystems.function.key", "354b0c2c-aa87-40c1-bfe3-49b2e0729cb8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getIsShowAssignFirstApproverPopup$Action, callContext, createForUserIn, approvalProcessIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

saveOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveOnClick");
span.setAttribute("outsystems.function.key", "374c6639-04e7-488a-a31f-b4aec82d803c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SelectReqRegion_PopupSelect$Action(i_RegionIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SelectReqRegion_PopupSelect__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SelectReqRegion_PopupSelect");
span.setAttribute("outsystems.function.key", "37e9dac4-5f4f-4c1d-9c46-b12931fe2fd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SelectReqRegion_PopupSelect$Action, callContext, i_RegionIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

dropdown_CostCenterSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_CostCenterSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CostCenterSearchOnChanged");
span.setAttribute("outsystems.function.key", "438160f5-028a-4e14-87e8-db05e2c584b8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_CostCenterSearchOnChanged$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

switch_DepositOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_DepositOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_DepositOnChange");
span.setAttribute("outsystems.function.key", "43f92155-6716-49c0-951f-134c6ee62444");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._switch_DepositOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

removeFromList$Action(i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, isEstim_Equal_AgreedIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RemoveFromList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RemoveFromList");
span.setAttribute("outsystems.function.key", "4a073dd4-e895-4e32-854c-6b405b5fffda");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._removeFromList$Action, callContext, i_PositionIn, i_IsDepositIn, i_IsServiceIn, i_IsAttachedFileIn, i_IsInsuranceIn, isEstim_Equal_AgreedIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

switch_AdvancedPayment2OnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_AdvancedPayment2OnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_AdvancedPayment2OnChange");
span.setAttribute("outsystems.function.key", "51edcfae-5777-4a19-942a-23ba498c9add");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._switch_AdvancedPayment2OnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

event_ChangeSupplier$Action(i_SupplierIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Event_ChangeSupplier__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Event_ChangeSupplier");
span.setAttribute("outsystems.function.key", "5fa6f975-d0b8-4202-a8da-abaf9217b766");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._event_ChangeSupplier$Action, callContext, i_SupplierIdIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SearchDropdownRefresh_Project$Action(newMaxRecordsIn, newSearchTextIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchDropdownRefresh_Project__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchDropdownRefresh_Project");
span.setAttribute("outsystems.function.key", "6a6b03e2-bf28-4154-a24d-9424a896b911");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SearchDropdownRefresh_Project$Action, callContext, newMaxRecordsIn, newSearchTextIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

saveContractPendingInfo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveContractPendingInfo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveContractPendingInfo");
span.setAttribute("outsystems.function.key", "6b8e3271-7bc3-41d5-93a8-eca295ab3b04");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveContractPendingInfo$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "6bed97be-19c7-41a5-9242-2d273293fd9d");
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

dropdown_InsuranceTypeOnChange$Action(i_InsuranceTypeIdIn, i_CurrentRowNumberIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_InsuranceTypeOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_InsuranceTypeOnChange");
span.setAttribute("outsystems.function.key", "6e2fe1c1-d7ea-49cb-b1f6-50d27b1f16ea");
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

dropdownSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChanged");
span.setAttribute("outsystems.function.key", "73b8bbf0-81ea-4f32-94d9-a48af3cb24cb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

modifyRequisition$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ModifyRequisition__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ModifyRequisition");
span.setAttribute("outsystems.function.key", "7c989fda-979a-43ee-a99c-3635d5b546fc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._modifyRequisition$Action, callContext);
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
span.setAttribute("outsystems.function.key", "7eddd01c-a7be-49de-8053-f2c2bd1e3f8d");
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
span.setAttribute("outsystems.function.key", "8440a936-7981-4f9d-abe4-0e4e05b23854");
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

captureOnClick$Action(createForUserIn, approvalProcessIdIn, isHierarquicalFlowIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CaptureOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CaptureOnClick");
span.setAttribute("outsystems.function.key", "85fdf1e0-6656-4e08-9da2-642a783e50b1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._captureOnClick$Action, callContext, createForUserIn, approvalProcessIdIn, isHierarquicalFlowIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showHideSelectReqRegion_Popup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideSelectReqRegion_Popup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideSelectReqRegion_Popup");
span.setAttribute("outsystems.function.key", "866044e0-191d-4563-b5bc-b89b9272695e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideSelectReqRegion_Popup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

switch_ContractOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_ContractOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_ContractOnChange");
span.setAttribute("outsystems.function.key", "889a05b7-953e-4490-ae5d-eaad9504a4e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._switch_ContractOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getUserApplicationRolesOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserApplicationRolesOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserApplicationRolesOnAfterFetch");
span.setAttribute("outsystems.function.key", "89f4f3cd-28e6-4b66-9bf2-d8293c9f9fd0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getUserApplicationRolesOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getAccountableGuideOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetAccountableGuideOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetAccountableGuideOnAfterFetch");
span.setAttribute("outsystems.function.key", "8c61914b-0fb9-4df7-90d8-fc94c5c4b5a1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getAccountableGuideOnAfterFetch$Action, callContext);
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
span.setAttribute("outsystems.function.key", "8ed05a56-b210-4c0e-9408-f918840ad803");
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

showHideCancelPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideCancelPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideCancelPopup");
span.setAttribute("outsystems.function.key", "988402c1-a7d6-4b4c-aaa6-a7086e925de4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideCancelPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

switch_InsuranceOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_InsuranceOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_InsuranceOnChange");
span.setAttribute("outsystems.function.key", "9c7b740b-c061-458e-b02b-735994d8a58d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._switch_InsuranceOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "a08cca0e-e4b0-42b2-bc77-4ba46ae051d8");
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

dropdown_CurrencyOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_CurrencyOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_CurrencyOnChange");
span.setAttribute("outsystems.function.key", "a0cdf1a1-d835-4114-a67c-fcc526989aea");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdown_CurrencyOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdownSearchOnChangedFormats$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchOnChangedFormats__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchOnChangedFormats");
span.setAttribute("outsystems.function.key", "ac779921-8c1c-4278-bea5-458691730d39");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._dropdownSearchOnChangedFormats$Action, callContext, selectedOptionListIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdown_DistributionOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Dropdown_DistributionOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Dropdown_DistributionOnChange");
span.setAttribute("outsystems.function.key", "b2816968-1b7f-499e-97c4-3ad7e1771b80");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdown_DistributionOnChange$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

switch_IsActiveOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_IsActiveOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_IsActiveOnChange");
span.setAttribute("outsystems.function.key", "b7453bd9-884e-4504-8044-289802d20d61");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._switch_IsActiveOnChange$Action, callContext);
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
span.setAttribute("outsystems.function.key", "c4ea7ab5-6987-4959-a692-e633755ee1bf");
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

getSupplierDetailBySocietyOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierDetailBySocietyOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierDetailBySocietyOnAfterFetch");
span.setAttribute("outsystems.function.key", "c74410da-b202-48d2-b61c-9f4ffb5189e1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSupplierDetailBySocietyOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_SearchDropdownBigSetVar_Project$Action(idIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_SearchDropdownBigSetVar_Project__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_SearchDropdownBigSetVar_Project");
span.setAttribute("outsystems.function.key", "ceff623c-0315-4d3f-a2e8-ca777e961fe4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._wb_SearchDropdownBigSetVar_Project$Action, callContext, idIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

recalculateTotalAmount$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RecalculateTotalAmount__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RecalculateTotalAmount");
span.setAttribute("outsystems.function.key", "d4e04c3b-ea82-44b5-a69b-158cb54c7827");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._recalculateTotalAmount$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getShowSelectReqPopupOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetShowSelectReqPopupOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetShowSelectReqPopupOnAfterFetch");
span.setAttribute("outsystems.function.key", "eb2fb443-30b2-4dd3-b35b-fad3024cd1a3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getShowSelectReqPopupOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

showHideSpecialOrNormalWorkflowPopup$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowHideSpecialOrNormalWorkflowPopup__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowHideSpecialOrNormalWorkflowPopup");
span.setAttribute("outsystems.function.key", "f125f91e-ad32-45d1-938d-59d9217f05b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showHideSpecialOrNormalWorkflowPopup$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

closeSidebar$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseSidebar__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseSidebar");
span.setAttribute("outsystems.function.key", "f1e494ba-81ca-428b-b135-477b1d1952ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeSidebar$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

switch_ConceptOnChange$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Switch_ConceptOnChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Switch_ConceptOnChange");
span.setAttribute("outsystems.function.key", "f2b31692-55ad-45c4-8781-d5ee09c0c19a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._switch_ConceptOnChange$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

wb_BigUploadEventstartProcess$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("wb_BigUploadEventstartProcess__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "wb_BigUploadEventstartProcess");
span.setAttribute("outsystems.function.key", "f47b1893-4189-429a-bac7-277022a3b8eb");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_BigUploadEventstartProcess$Action, callContext);
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
span.setAttribute("outsystems.function.key", "f653c9dc-4d2a-4698-a579-acb7cde51072");
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

getRequisitionServicesByRequisitionIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionServicesByRequisitionIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionServicesByRequisitionIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "f70bba6d-a500-473d-bd05-d0290199d874");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getRequisitionServicesByRequisitionIdOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

societySearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SocietySearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SocietySearchOnChanged");
span.setAttribute("outsystems.function.key", "f85cf1b7-d902-4bd9-b23b-d7175a942cb8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._societySearchOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

wb_CustomUploadOnFileChange$Action(fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, i_IsAdvWithoutInvoiceIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Wb_CustomUploadOnFileChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Wb_CustomUploadOnFileChange");
span.setAttribute("outsystems.function.key", "ff30ac52-9a47-4036-919c-f8145340d8f5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._wb_CustomUploadOnFileChange$Action, callContext, fileIn, errorIn, i_IsDeleteIn, i_IsFinanceAuthorizationIn, i_IsProofOfForeignResidenceIn, i_IsContractIn, i_IsDepositIn, i_IsInsuranceIn, i_IsAdvancePaymentIn, i_IsExchangeRateEvidenceIn, i_IsAttachedFilesIn, i_IsContractPendingJustificationIn, i_IsREPSEIn, i_IsAdvWithoutInvoiceIn);
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
return ConectaProveedores_c_RequisitionsController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Requisiciones, ConectaProveedoresController$default.roles.Proveedor]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionGetIsForSpecialWorkflow", [{
name: "IsForSpecialWorkflow",
attrName: "isForSpecialWorkflowOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionApproveRequisitionAccounting", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionRequisitionCancel", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionGetIsCorporativoCxPFromUAR", [{
name: "o_IsFromCorporativo",
attrName: "o_IsFromCorporativoOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionApprovModifReq", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionGetIsShowAssignFirstApproverPopup", [{
name: "IsShow",
attrName: "isShowOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail$ActionSaveRequisition", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
},
complexType: ST_046fb53ebbe142526d95e87ef1ae9711Structure
}, {
name: "o_RequisitionId",
attrName: "o_RequisitionIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "o_HasChangedStatus",
attrName: "o_HasChangedStatusOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.GetIsForSpecialWorkflow$vars", [{
name: "CreateForUser",
attrName: "createForUserInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ApprovalProcessId",
attrName: "approvalProcessIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "IsHierarquicalFlow",
attrName: "isHierarquicalFlowInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.AddRecord$vars", [{
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
name: "i_IsConcepts",
attrName: "i_IsConceptsInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.CancelRequisition$vars", [{
name: "i_IsDataCapture",
attrName: "i_IsDataCaptureInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_AdvancedPaymentTypeOnChange$vars", [{
name: "IsAdvWithoutInv",
attrName: "isAdvWithoutInvVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_ServiceTypeOnChange$vars", [{
name: "Account",
attrName: "accountInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.wb_BigUploadNotifyFileId$vars", [{
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
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.GetIsShowAssignFirstApproverPopup$vars", [{
name: "CreateForUser",
attrName: "createForUserInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ApprovalProcessId",
attrName: "approvalProcessIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_SelectReqRegion_PopupSelect$vars", [{
name: "i_RegionId",
attrName: "i_RegionIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_CostCenterSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.RemoveFromList$vars", [{
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
name: "IsEstim_Equal_Agreed",
attrName: "isEstim_Equal_AgreedInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Event_ChangeSupplier$vars", [{
name: "i_SupplierId",
attrName: "i_SupplierIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_SearchDropdownRefresh_Project$vars", [{
name: "newMaxRecords",
attrName: "newMaxRecordsInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "newSearchText",
attrName: "newSearchTextInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_InsuranceTypeOnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.DropdownSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_AccountingDataTypeOnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.CaptureOnClick$vars", [{
name: "CreateForUser",
attrName: "createForUserInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "ApprovalProcessId",
attrName: "approvalProcessIdInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "IsHierarquicalFlow",
attrName: "isHierarquicalFlowInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Dropdown_DepositTypeOnChange$vars", [{
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.DropdownSearchOnChangedFormats$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.DatePickerOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_SearchDropdownBigSetVar_Project$vars", [{
name: "Id",
attrName: "idInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.SocietySearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.RequisitionDetail.Wb_CustomUploadOnFileChange$vars", [{
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
}, {
name: "i_IsAdvWithoutInvoice",
attrName: "i_IsAdvWithoutInvoiceInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


