using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8> outParamList;
[JsonProperty("SortClause")]
public string outParamSortClause;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_a88cee033f640538574578015052224b outParamList, string outParamSortClause) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8 tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
tmpoutParamListElement.AttrCurrency.AttrCode = outParamList.CurrentRec.ssENCurrency.ssCode;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENApprovalStatus to the tmpoutParamListElement.AttrApprovalStatus
tmpoutParamListElement.AttrApprovalStatus = new ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
tmpoutParamListElement.AttrApprovalStatus.AttrId = (int?) outParamList.CurrentRec.ssENApprovalStatus.ssId;
tmpoutParamListElement.AttrApprovalStatus.AttrLabel = outParamList.CurrentRec.ssENApprovalStatus.ssLabel;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrClass
tmpoutParamListElement.AttrApprovalStatus.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrOrder
tmpoutParamListElement.AttrApprovalStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active
tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsReq
tmpoutParamListElement.AttrApprovalStatus.AttrIsReq = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsInv
tmpoutParamListElement.AttrApprovalStatus.AttrIsInv = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrLabelES
tmpoutParamListElement.AttrApprovalStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisition to the tmpoutParamListElement.AttrRequisition
tmpoutParamListElement.AttrRequisition = new ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
// Write optimized tmpoutParamListElement.AttrRequisition.AttrId
tmpoutParamListElement.AttrRequisition.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRequisition.AttrName = outParamList.CurrentRec.ssENRequisition.ssName;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCounter
tmpoutParamListElement.AttrRequisition.AttrCounter = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrRequisitionStatusId
tmpoutParamListElement.AttrRequisition.AttrRequisitionStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrSupplierId
tmpoutParamListElement.AttrRequisition.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrRegionId
tmpoutParamListElement.AttrRequisition.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAccountingRegionId
tmpoutParamListElement.AttrRequisition.AttrAccountingRegionId = (long?) 0L;
tmpoutParamListElement.AttrRequisition.AttrApplicantId = outParamList.CurrentRec.ssENRequisition.ssApplicantId;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrMaxDateFinishCapture
tmpoutParamListElement.AttrRequisition.AttrMaxDateFinishCapture = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisition.AttrProjectAssetServiceId
tmpoutParamListElement.AttrRequisition.AttrProjectAssetServiceId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrProjectAssetService
tmpoutParamListElement.AttrRequisition.AttrProjectAssetService = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrProjectDescription
tmpoutParamListElement.AttrRequisition.AttrProjectDescription = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrFrequencyId
tmpoutParamListElement.AttrRequisition.AttrFrequencyId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsSustainability
tmpoutParamListElement.AttrRequisition.AttrIsSustainability = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrSustainabilityId
tmpoutParamListElement.AttrRequisition.AttrSustainabilityId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBusinessValueCategoryId
tmpoutParamListElement.AttrRequisition.AttrBusinessValueCategoryId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBusinessValueSubcategoryId
tmpoutParamListElement.AttrRequisition.AttrBusinessValueSubcategoryId = (long?) 0L;
tmpoutParamListElement.AttrRequisition.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssENRequisition.ssTotalAmount;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCurrencyId
tmpoutParamListElement.AttrRequisition.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrDistributionId
tmpoutParamListElement.AttrRequisition.AttrDistributionId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCostCenterId
tmpoutParamListElement.AttrRequisition.AttrCostCenterId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasContract
tmpoutParamListElement.AttrRequisition.AttrHasContract = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsContractPending
tmpoutParamListElement.AttrRequisition.AttrIsContractPending = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasDeposit
tmpoutParamListElement.AttrRequisition.AttrHasDeposit = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasInsurance
tmpoutParamListElement.AttrRequisition.AttrHasInsurance = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasAdvancePayment
tmpoutParamListElement.AttrRequisition.AttrHasAdvancePayment = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR
tmpoutParamListElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrServiceDescription_DEPREC
tmpoutParamListElement.AttrRequisition.AttrServiceDescription_DEPREC = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrInvoiceUsageId_DEPREC
tmpoutParamListElement.AttrRequisition.AttrInvoiceUsageId_DEPREC = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrServiceFormatId
tmpoutParamListElement.AttrRequisition.AttrServiceFormatId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCompanyId
tmpoutParamListElement.AttrRequisition.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrRetentionRate
tmpoutParamListElement.AttrRequisition.AttrRetentionRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrNegotiatedExchangeRate
tmpoutParamListElement.AttrRequisition.AttrNegotiatedExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentMethodId
tmpoutParamListElement.AttrRequisition.AttrPaymentMethodId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentTermsId
tmpoutParamListElement.AttrRequisition.AttrPaymentTermsId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsAutomaticAccounting
tmpoutParamListElement.AttrRequisition.AttrIsAutomaticAccounting = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCreatedBy
tmpoutParamListElement.AttrRequisition.AttrCreatedBy = "";
tmpoutParamListElement.AttrRequisition.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENRequisition.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrRequisition.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENRequisition.ssUpdatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisition.AttrUpdatedBy
tmpoutParamListElement.AttrRequisition.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCreatedByApplicationRole
tmpoutParamListElement.AttrRequisition.AttrCreatedByApplicationRole = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrDateOfCommitment
tmpoutParamListElement.AttrRequisition.AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasContractFileUploaded
tmpoutParamListElement.AttrRequisition.AttrHasContractFileUploaded = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasUpdatedDateOfCommitment
tmpoutParamListElement.AttrRequisition.AttrHasUpdatedDateOfCommitment = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrSubmittedOn
tmpoutParamListElement.AttrRequisition.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsDonation
tmpoutParamListElement.AttrRequisition.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAdvWithoutInvoice
tmpoutParamListElement.AttrRequisition.AttrAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrWasAdvWithoutInvoice
tmpoutParamListElement.AttrRequisition.AttrWasAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsAdvanced
tmpoutParamListElement.AttrRequisition.AttrIsAdvanced = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrDocumentTypeId
tmpoutParamListElement.AttrRequisition.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsCreatedByAnAssistente
tmpoutParamListElement.AttrRequisition.AttrIsCreatedByAnAssistente = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrTelcelDirectionId
tmpoutParamListElement.AttrRequisition.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasMultiUpload
tmpoutParamListElement.AttrRequisition.AttrHasMultiUpload = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAccountingDate
tmpoutParamListElement.AttrRequisition.AttrAccountingDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentOptionsId
tmpoutParamListElement.AttrRequisition.AttrPaymentOptionsId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentWaysId
tmpoutParamListElement.AttrRequisition.AttrPaymentWaysId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBuyDocNumber
tmpoutParamListElement.AttrRequisition.AttrBuyDocNumber = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBuyDocPosition
tmpoutParamListElement.AttrRequisition.AttrBuyDocPosition = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisitionApprovalLevel to the tmpoutParamListElement.AttrRequisitionApprovalLevel
tmpoutParamListElement.AttrRequisitionApprovalLevel = new ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord();
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrId = (long?) outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequisitionApprovalId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequisitionApprovalId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrLevelNumber
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrLevelNumber = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApplicationRoleId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApplicationRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraJobTitle
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraJobTitle = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrDepartmentId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrManagementId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrManagementId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrSubdirectionId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrSubdirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraRoleId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraUserName
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraUserName = "";
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrAssignedTo = outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrNeedsContract
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrNeedsContract = (bool?) false;
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovalStatusId = (int?) outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedBy
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedBy = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedOn
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyBy
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyBy = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyOn
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledBy
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledBy = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_DEPREC
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_DEPREC = (bool?) false;
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsAccounting = (bool?) outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsAccounting;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsStartAccounting
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsStartAccounting = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_ = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApproveAsAreaUsuaria
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApproveAsAreaUsuaria = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsMandatory
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsMandatory = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsReassigned
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsReassigned = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsSubstituteFor
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsSubstituteFor = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisitionApproval to the tmpoutParamListElement.AttrRequisitionApproval
tmpoutParamListElement.AttrRequisitionApproval = new ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrId
tmpoutParamListElement.AttrRequisitionApproval.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRequisitionApproval.AttrRequisitionId = (long?) outParamList.CurrentRec.ssENRequisitionApproval.ssRequisitionId;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrAprovalProcessId
tmpoutParamListElement.AttrRequisitionApproval.AttrAprovalProcessId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrProcessTypeCode
tmpoutParamListElement.AttrRequisitionApproval.AttrProcessTypeCode = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrApprovalProcessVersion
tmpoutParamListElement.AttrRequisitionApproval.AttrApprovalProcessVersion = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrCurrentLevel
tmpoutParamListElement.AttrRequisitionApproval.AttrCurrentLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrMaxLevel
tmpoutParamListElement.AttrRequisitionApproval.AttrMaxLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrStartedOn
tmpoutParamListElement.AttrRequisitionApproval.AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrFinishedOn
tmpoutParamListElement.AttrRequisitionApproval.AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrHasStartedAccounting
tmpoutParamListElement.AttrRequisitionApproval.AttrHasStartedAccounting = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisitionStatus to the tmpoutParamListElement.AttrRequisitionStatus
tmpoutParamListElement.AttrRequisitionStatus = new ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
tmpoutParamListElement.AttrRequisitionStatus.AttrId = (int?) outParamList.CurrentRec.ssENRequisitionStatus.ssId;
tmpoutParamListElement.AttrRequisitionStatus.AttrLabel = outParamList.CurrentRec.ssENRequisitionStatus.ssLabel;
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrClass
tmpoutParamListElement.AttrRequisitionStatus.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrOrder
tmpoutParamListElement.AttrRequisitionStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrIs_Active
tmpoutParamListElement.AttrRequisitionStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrLabelES
tmpoutParamListElement.AttrRequisitionStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssSTUpdatedBy to the tmpoutParamListElement.AttrUpdatedBy
tmpoutParamListElement.AttrUpdatedBy = new ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure();
tmpoutParamListElement.AttrUpdatedBy.AttrValue = outParamList.CurrentRec.ssSTUpdatedBy.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssSTUserApplicantName to the tmpoutParamListElement.AttrUserApplicantName
tmpoutParamListElement.AttrUserApplicantName = new ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure();
tmpoutParamListElement.AttrUserApplicantName.AttrValue = outParamList.CurrentRec.ssSTUserApplicantName.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssSTDontShowAction to the tmpoutParamListElement.AttrDontShowAction
tmpoutParamListElement.AttrDontShowAction = new ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure();
// Write optimized tmpoutParamListElement.AttrDontShowAction.AttrValue
tmpoutParamListElement.AttrDontShowAction.AttrValue = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssSTIsUserFromThisRegion to the tmpoutParamListElement.AttrIsUserFromThisRegion
tmpoutParamListElement.AttrIsUserFromThisRegion = new ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure();
// Write optimized tmpoutParamListElement.AttrIsUserFromThisRegion.AttrValue
tmpoutParamListElement.AttrIsUserFromThisRegion.AttrValue = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENApplicationRole to the tmpoutParamListElement.AttrApplicationRole
tmpoutParamListElement.AttrApplicationRole = new ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrId
tmpoutParamListElement.AttrApplicationRole.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrCode
tmpoutParamListElement.AttrApplicationRole.AttrCode = "";
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrName
tmpoutParamListElement.AttrApplicationRole.AttrName = "";
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrIsActive
tmpoutParamListElement.AttrApplicationRole.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrIsAreaUsuaria
tmpoutParamListElement.AttrApplicationRole.AttrIsAreaUsuaria = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrIsAreaCxP
tmpoutParamListElement.AttrApplicationRole.AttrIsAreaCxP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrCanBulkApproveFolios
tmpoutParamListElement.AttrApplicationRole.AttrCanBulkApproveFolios = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENCompany to the tmpoutParamListElement.AttrCompany
tmpoutParamListElement.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamListElement.AttrCompany.AttrId
tmpoutParamListElement.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCompany.AttrExternalId
tmpoutParamListElement.AttrCompany.AttrExternalId = "";
tmpoutParamListElement.AttrCompany.AttrDescription = outParamList.CurrentRec.ssENCompany.ssDescription;
// Write optimized tmpoutParamListElement.AttrCompany.AttrRFC
tmpoutParamListElement.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrPostalCode
tmpoutParamListElement.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrCyAImport
tmpoutParamListElement.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrFsPUse
tmpoutParamListElement.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedOn
tmpoutParamListElement.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedBy
tmpoutParamListElement.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedOn
tmpoutParamListElement.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedBy
tmpoutParamListElement.AttrCompany.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSupplier to the tmpoutParamListElement.AttrSupplier
tmpoutParamListElement.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamListElement.AttrSupplier.AttrId
tmpoutParamListElement.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTratamiento
tmpoutParamListElement.AttrSupplier.AttrTratamiento = "";
tmpoutParamListElement.AttrSupplier.AttrName = outParamList.CurrentRec.ssENSupplier.ssName;
tmpoutParamListElement.AttrSupplier.AttrNumber = outParamList.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCalle_Numero
tmpoutParamListElement.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrDistrito
tmpoutParamListElement.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPais
tmpoutParamListElement.AttrSupplier.AttrPais = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegion_
tmpoutParamListElement.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIdioma
tmpoutParamListElement.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTelefono
tmpoutParamListElement.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrExtension
tmpoutParamListElement.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrFax
tmpoutParamListElement.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCliente
tmpoutParamListElement.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada
tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrClavedegrupo
tmpoutParamListElement.AttrSupplier.AttrClavedegrupo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1
tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPersonafisica
tmpoutParamListElement.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRamo
tmpoutParamListElement.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrGrupodeporte
tmpoutParamListElement.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrEmail
tmpoutParamListElement.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIsActive
tmpoutParamListElement.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedOn
tmpoutParamListElement.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedBy
tmpoutParamListElement.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedOn
tmpoutParamListElement.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedBy
tmpoutParamListElement.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegionId
tmpoutParamListElement.AttrSupplier.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamList.CurrentRec.ssENCostCenterSAP to the tmpoutParamListElement.AttrCostCenterSAP
tmpoutParamListElement.AttrCostCenterSAP = new ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrId
tmpoutParamListElement.AttrCostCenterSAP.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrRegionId
tmpoutParamListElement.AttrCostCenterSAP.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCompanyId
tmpoutParamListElement.AttrCostCenterSAP.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrSoc_
tmpoutParamListElement.AttrCostCenterSAP.AttrSoc_ = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrDiv_
tmpoutParamListElement.AttrCostCenterSAP.AttrDiv_ = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrArea
tmpoutParamListElement.AttrCostCenterSAP.AttrArea = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCe_coste
tmpoutParamListElement.AttrCostCenterSAP.AttrCe_coste = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCeBe
tmpoutParamListElement.AttrCostCenterSAP.AttrCeBe = "";
tmpoutParamListElement.AttrCostCenterSAP.AttrDenominacion = outParamList.CurrentRec.ssENCostCenterSAP.ssDenominacion;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrDescripcion
tmpoutParamListElement.AttrCostCenterSAP.AttrDescripcion = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrResponsable
tmpoutParamListElement.AttrCostCenterSAP.AttrResponsable = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCeCo
tmpoutParamListElement.AttrCostCenterSAP.AttrCeCo = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprim_reales_Ind_debloq
tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprim_reales_Ind_debloq = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_reales_Ind_debl
tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_reales_Ind_debl = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosreales_Ind_debloqueo
tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosreales_Ind_debloqueo = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrActualiz_comprom__Ind_debloq
tmpoutParamListElement.AttrCostCenterSAP.AttrActualiz_comprom__Ind_debloq = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprimariosplan_Ind_debl
tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprimariosplan_Ind_debl = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_plan_Ind_debloq
tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_plan_Ind_debloq = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosplan_Ind_debloqueo_
tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosplan_Ind_debloqueo_ = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrAutor
tmpoutParamListElement.AttrCostCenterSAP.AttrAutor = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedOn
tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedBy
tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedOn
tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedBy
tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrIsActive
tmpoutParamListElement.AttrCostCenterSAP.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENTelcelDirection to the tmpoutParamListElement.AttrTelcelDirection
tmpoutParamListElement.AttrTelcelDirection = new ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrId
tmpoutParamListElement.AttrTelcelDirection.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrName
tmpoutParamListElement.AttrTelcelDirection.AttrName = "";
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrIsActive
tmpoutParamListElement.AttrTelcelDirection.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrCreatedOn
tmpoutParamListElement.AttrTelcelDirection.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrCreatedBy
tmpoutParamListElement.AttrTelcelDirection.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedOn
tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedBy
tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSegmentAccGroup to the tmpoutParamListElement.AttrSegmentAccGroup
tmpoutParamListElement.AttrSegmentAccGroup = new ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord();
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrId
tmpoutParamListElement.AttrSegmentAccGroup.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrGroupName
tmpoutParamListElement.AttrSegmentAccGroup.AttrGroupName = "";
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrIsActive
tmpoutParamListElement.AttrSegmentAccGroup.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedOn
tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedBy
tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedOn
tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedBy
tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProject_Asset_Service to the tmpoutParamListElement.AttrProject_Asset_Service
tmpoutParamListElement.AttrProject_Asset_Service = new ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrId
tmpoutParamListElement.AttrProject_Asset_Service.AttrId = (long?) 0L;
tmpoutParamListElement.AttrProject_Asset_Service.AttrDescription = outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription;
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrIsOthers
tmpoutParamListElement.AttrProject_Asset_Service.AttrIsOthers = (bool?) false;
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedOn
tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedBy
tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedOn
tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedBy
tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir to the tmpoutParamListElement.AttrSegmentAccGroupTelcelDir
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir = new ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrId
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrSegmentAccGroupId
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrSegmentAccGroupId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrTelcelDirectionId
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedOn
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedBy
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRegion to the tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamListElement.AttrRegion.AttrId
tmpoutParamListElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRegion.AttrCode = outParamList.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamListElement.AttrRegion.AttrName
tmpoutParamListElement.AttrRegion.AttrName = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrDivisionFI
tmpoutParamListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCentroRTP
tmpoutParamListElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCommissionRegion
tmpoutParamListElement.AttrRegion.AttrCommissionRegion = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsActive
tmpoutParamListElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedOn
tmpoutParamListElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedBy
tmpoutParamListElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedOn
tmpoutParamListElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedBy
tmpoutParamListElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFsP
tmpoutParamListElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFcP
tmpoutParamListElement.AttrRegion.AttrIsFcP = (bool?) false;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8>(new ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
tmpoutParamListElement.AttrCurrency.AttrCode = outParamList.CurrentRec.ssENCurrency.ssCode;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENApprovalStatus to the tmpoutParamListElement.AttrApprovalStatus
tmpoutParamListElement.AttrApprovalStatus = new ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
tmpoutParamListElement.AttrApprovalStatus.AttrId = (int?) outParamList.CurrentRec.ssENApprovalStatus.ssId;
tmpoutParamListElement.AttrApprovalStatus.AttrLabel = outParamList.CurrentRec.ssENApprovalStatus.ssLabel;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrClass
tmpoutParamListElement.AttrApprovalStatus.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrOrder
tmpoutParamListElement.AttrApprovalStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active
tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsReq
tmpoutParamListElement.AttrApprovalStatus.AttrIsReq = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsInv
tmpoutParamListElement.AttrApprovalStatus.AttrIsInv = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrLabelES
tmpoutParamListElement.AttrApprovalStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisition to the tmpoutParamListElement.AttrRequisition
tmpoutParamListElement.AttrRequisition = new ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
// Write optimized tmpoutParamListElement.AttrRequisition.AttrId
tmpoutParamListElement.AttrRequisition.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRequisition.AttrName = outParamList.CurrentRec.ssENRequisition.ssName;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCounter
tmpoutParamListElement.AttrRequisition.AttrCounter = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrRequisitionStatusId
tmpoutParamListElement.AttrRequisition.AttrRequisitionStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrSupplierId
tmpoutParamListElement.AttrRequisition.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrRegionId
tmpoutParamListElement.AttrRequisition.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAccountingRegionId
tmpoutParamListElement.AttrRequisition.AttrAccountingRegionId = (long?) 0L;
tmpoutParamListElement.AttrRequisition.AttrApplicantId = outParamList.CurrentRec.ssENRequisition.ssApplicantId;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrMaxDateFinishCapture
tmpoutParamListElement.AttrRequisition.AttrMaxDateFinishCapture = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisition.AttrProjectAssetServiceId
tmpoutParamListElement.AttrRequisition.AttrProjectAssetServiceId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrProjectAssetService
tmpoutParamListElement.AttrRequisition.AttrProjectAssetService = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrProjectDescription
tmpoutParamListElement.AttrRequisition.AttrProjectDescription = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrFrequencyId
tmpoutParamListElement.AttrRequisition.AttrFrequencyId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsSustainability
tmpoutParamListElement.AttrRequisition.AttrIsSustainability = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrSustainabilityId
tmpoutParamListElement.AttrRequisition.AttrSustainabilityId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBusinessValueCategoryId
tmpoutParamListElement.AttrRequisition.AttrBusinessValueCategoryId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBusinessValueSubcategoryId
tmpoutParamListElement.AttrRequisition.AttrBusinessValueSubcategoryId = (long?) 0L;
tmpoutParamListElement.AttrRequisition.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssENRequisition.ssTotalAmount;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCurrencyId
tmpoutParamListElement.AttrRequisition.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrDistributionId
tmpoutParamListElement.AttrRequisition.AttrDistributionId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCostCenterId
tmpoutParamListElement.AttrRequisition.AttrCostCenterId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasContract
tmpoutParamListElement.AttrRequisition.AttrHasContract = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsContractPending
tmpoutParamListElement.AttrRequisition.AttrIsContractPending = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasDeposit
tmpoutParamListElement.AttrRequisition.AttrHasDeposit = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasInsurance
tmpoutParamListElement.AttrRequisition.AttrHasInsurance = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasAdvancePayment
tmpoutParamListElement.AttrRequisition.AttrHasAdvancePayment = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR
tmpoutParamListElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrServiceDescription_DEPREC
tmpoutParamListElement.AttrRequisition.AttrServiceDescription_DEPREC = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrInvoiceUsageId_DEPREC
tmpoutParamListElement.AttrRequisition.AttrInvoiceUsageId_DEPREC = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrServiceFormatId
tmpoutParamListElement.AttrRequisition.AttrServiceFormatId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCompanyId
tmpoutParamListElement.AttrRequisition.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrRetentionRate
tmpoutParamListElement.AttrRequisition.AttrRetentionRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrNegotiatedExchangeRate
tmpoutParamListElement.AttrRequisition.AttrNegotiatedExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentMethodId
tmpoutParamListElement.AttrRequisition.AttrPaymentMethodId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentTermsId
tmpoutParamListElement.AttrRequisition.AttrPaymentTermsId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsAutomaticAccounting
tmpoutParamListElement.AttrRequisition.AttrIsAutomaticAccounting = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCreatedBy
tmpoutParamListElement.AttrRequisition.AttrCreatedBy = "";
tmpoutParamListElement.AttrRequisition.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENRequisition.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrRequisition.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENRequisition.ssUpdatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisition.AttrUpdatedBy
tmpoutParamListElement.AttrRequisition.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrCreatedByApplicationRole
tmpoutParamListElement.AttrRequisition.AttrCreatedByApplicationRole = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrDateOfCommitment
tmpoutParamListElement.AttrRequisition.AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasContractFileUploaded
tmpoutParamListElement.AttrRequisition.AttrHasContractFileUploaded = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasUpdatedDateOfCommitment
tmpoutParamListElement.AttrRequisition.AttrHasUpdatedDateOfCommitment = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrSubmittedOn
tmpoutParamListElement.AttrRequisition.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsDonation
tmpoutParamListElement.AttrRequisition.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAdvWithoutInvoice
tmpoutParamListElement.AttrRequisition.AttrAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrWasAdvWithoutInvoice
tmpoutParamListElement.AttrRequisition.AttrWasAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsAdvanced
tmpoutParamListElement.AttrRequisition.AttrIsAdvanced = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrDocumentTypeId
tmpoutParamListElement.AttrRequisition.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrIsCreatedByAnAssistente
tmpoutParamListElement.AttrRequisition.AttrIsCreatedByAnAssistente = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrTelcelDirectionId
tmpoutParamListElement.AttrRequisition.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrHasMultiUpload
tmpoutParamListElement.AttrRequisition.AttrHasMultiUpload = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrAccountingDate
tmpoutParamListElement.AttrRequisition.AttrAccountingDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentOptionsId
tmpoutParamListElement.AttrRequisition.AttrPaymentOptionsId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrPaymentWaysId
tmpoutParamListElement.AttrRequisition.AttrPaymentWaysId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBuyDocNumber
tmpoutParamListElement.AttrRequisition.AttrBuyDocNumber = "";
// Write optimized tmpoutParamListElement.AttrRequisition.AttrBuyDocPosition
tmpoutParamListElement.AttrRequisition.AttrBuyDocPosition = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisitionApprovalLevel to the tmpoutParamListElement.AttrRequisitionApprovalLevel
tmpoutParamListElement.AttrRequisitionApprovalLevel = new ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord();
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrId = (long?) outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequisitionApprovalId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequisitionApprovalId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrLevelNumber
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrLevelNumber = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApplicationRoleId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApplicationRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraJobTitle
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraJobTitle = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrDepartmentId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrManagementId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrManagementId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrSubdirectionId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrSubdirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraRoleId
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraUserName
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrEntraUserName = "";
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrAssignedTo = outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrNeedsContract
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrNeedsContract = (bool?) false;
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovalStatusId = (int?) outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedBy
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedBy = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedOn
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyBy
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyBy = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyOn
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrRequestToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledBy
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledBy = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_DEPREC
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_DEPREC = (bool?) false;
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsAccounting = (bool?) outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsAccounting;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsStartAccounting
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsStartAccounting = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrCanceledOn_ = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApproveAsAreaUsuaria
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrApproveAsAreaUsuaria = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsMandatory
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsMandatory = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsReassigned
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsReassigned = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsSubstituteFor
tmpoutParamListElement.AttrRequisitionApprovalLevel.AttrIsSubstituteFor = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisitionApproval to the tmpoutParamListElement.AttrRequisitionApproval
tmpoutParamListElement.AttrRequisitionApproval = new ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrId
tmpoutParamListElement.AttrRequisitionApproval.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRequisitionApproval.AttrRequisitionId = (long?) outParamList.CurrentRec.ssENRequisitionApproval.ssRequisitionId;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrAprovalProcessId
tmpoutParamListElement.AttrRequisitionApproval.AttrAprovalProcessId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrProcessTypeCode
tmpoutParamListElement.AttrRequisitionApproval.AttrProcessTypeCode = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrApprovalProcessVersion
tmpoutParamListElement.AttrRequisitionApproval.AttrApprovalProcessVersion = "";
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrCurrentLevel
tmpoutParamListElement.AttrRequisitionApproval.AttrCurrentLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrMaxLevel
tmpoutParamListElement.AttrRequisitionApproval.AttrMaxLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrStartedOn
tmpoutParamListElement.AttrRequisitionApproval.AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrFinishedOn
tmpoutParamListElement.AttrRequisitionApproval.AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRequisitionApproval.AttrHasStartedAccounting
tmpoutParamListElement.AttrRequisitionApproval.AttrHasStartedAccounting = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENRequisitionStatus to the tmpoutParamListElement.AttrRequisitionStatus
tmpoutParamListElement.AttrRequisitionStatus = new ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
tmpoutParamListElement.AttrRequisitionStatus.AttrId = (int?) outParamList.CurrentRec.ssENRequisitionStatus.ssId;
tmpoutParamListElement.AttrRequisitionStatus.AttrLabel = outParamList.CurrentRec.ssENRequisitionStatus.ssLabel;
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrClass
tmpoutParamListElement.AttrRequisitionStatus.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrOrder
tmpoutParamListElement.AttrRequisitionStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrIs_Active
tmpoutParamListElement.AttrRequisitionStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRequisitionStatus.AttrLabelES
tmpoutParamListElement.AttrRequisitionStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssSTUpdatedBy to the tmpoutParamListElement.AttrUpdatedBy
tmpoutParamListElement.AttrUpdatedBy = new ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure();
tmpoutParamListElement.AttrUpdatedBy.AttrValue = outParamList.CurrentRec.ssSTUpdatedBy.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssSTUserApplicantName to the tmpoutParamListElement.AttrUserApplicantName
tmpoutParamListElement.AttrUserApplicantName = new ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure();
tmpoutParamListElement.AttrUserApplicantName.AttrValue = outParamList.CurrentRec.ssSTUserApplicantName.ssValue;
// Write the needed fields of the record outParamList.CurrentRec.ssSTDontShowAction to the tmpoutParamListElement.AttrDontShowAction
tmpoutParamListElement.AttrDontShowAction = new ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure();
// Write optimized tmpoutParamListElement.AttrDontShowAction.AttrValue
tmpoutParamListElement.AttrDontShowAction.AttrValue = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssSTIsUserFromThisRegion to the tmpoutParamListElement.AttrIsUserFromThisRegion
tmpoutParamListElement.AttrIsUserFromThisRegion = new ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure();
// Write optimized tmpoutParamListElement.AttrIsUserFromThisRegion.AttrValue
tmpoutParamListElement.AttrIsUserFromThisRegion.AttrValue = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENApplicationRole to the tmpoutParamListElement.AttrApplicationRole
tmpoutParamListElement.AttrApplicationRole = new ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrId
tmpoutParamListElement.AttrApplicationRole.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrCode
tmpoutParamListElement.AttrApplicationRole.AttrCode = "";
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrName
tmpoutParamListElement.AttrApplicationRole.AttrName = "";
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrIsActive
tmpoutParamListElement.AttrApplicationRole.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrIsAreaUsuaria
tmpoutParamListElement.AttrApplicationRole.AttrIsAreaUsuaria = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrIsAreaCxP
tmpoutParamListElement.AttrApplicationRole.AttrIsAreaCxP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApplicationRole.AttrCanBulkApproveFolios
tmpoutParamListElement.AttrApplicationRole.AttrCanBulkApproveFolios = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENCompany to the tmpoutParamListElement.AttrCompany
tmpoutParamListElement.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamListElement.AttrCompany.AttrId
tmpoutParamListElement.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCompany.AttrExternalId
tmpoutParamListElement.AttrCompany.AttrExternalId = "";
tmpoutParamListElement.AttrCompany.AttrDescription = outParamList.CurrentRec.ssENCompany.ssDescription;
// Write optimized tmpoutParamListElement.AttrCompany.AttrRFC
tmpoutParamListElement.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrPostalCode
tmpoutParamListElement.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrCyAImport
tmpoutParamListElement.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrFsPUse
tmpoutParamListElement.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedOn
tmpoutParamListElement.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedBy
tmpoutParamListElement.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedOn
tmpoutParamListElement.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedBy
tmpoutParamListElement.AttrCompany.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSupplier to the tmpoutParamListElement.AttrSupplier
tmpoutParamListElement.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamListElement.AttrSupplier.AttrId
tmpoutParamListElement.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTratamiento
tmpoutParamListElement.AttrSupplier.AttrTratamiento = "";
tmpoutParamListElement.AttrSupplier.AttrName = outParamList.CurrentRec.ssENSupplier.ssName;
tmpoutParamListElement.AttrSupplier.AttrNumber = outParamList.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCalle_Numero
tmpoutParamListElement.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrDistrito
tmpoutParamListElement.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPais
tmpoutParamListElement.AttrSupplier.AttrPais = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegion_
tmpoutParamListElement.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIdioma
tmpoutParamListElement.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTelefono
tmpoutParamListElement.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrExtension
tmpoutParamListElement.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrFax
tmpoutParamListElement.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCliente
tmpoutParamListElement.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada
tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrClavedegrupo
tmpoutParamListElement.AttrSupplier.AttrClavedegrupo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1
tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPersonafisica
tmpoutParamListElement.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRamo
tmpoutParamListElement.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrGrupodeporte
tmpoutParamListElement.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrEmail
tmpoutParamListElement.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIsActive
tmpoutParamListElement.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedOn
tmpoutParamListElement.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedBy
tmpoutParamListElement.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedOn
tmpoutParamListElement.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedBy
tmpoutParamListElement.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegionId
tmpoutParamListElement.AttrSupplier.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamList.CurrentRec.ssENCostCenterSAP to the tmpoutParamListElement.AttrCostCenterSAP
tmpoutParamListElement.AttrCostCenterSAP = new ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrId
tmpoutParamListElement.AttrCostCenterSAP.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrRegionId
tmpoutParamListElement.AttrCostCenterSAP.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCompanyId
tmpoutParamListElement.AttrCostCenterSAP.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrSoc_
tmpoutParamListElement.AttrCostCenterSAP.AttrSoc_ = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrDiv_
tmpoutParamListElement.AttrCostCenterSAP.AttrDiv_ = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrArea
tmpoutParamListElement.AttrCostCenterSAP.AttrArea = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCe_coste
tmpoutParamListElement.AttrCostCenterSAP.AttrCe_coste = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCeBe
tmpoutParamListElement.AttrCostCenterSAP.AttrCeBe = "";
tmpoutParamListElement.AttrCostCenterSAP.AttrDenominacion = outParamList.CurrentRec.ssENCostCenterSAP.ssDenominacion;
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrDescripcion
tmpoutParamListElement.AttrCostCenterSAP.AttrDescripcion = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrResponsable
tmpoutParamListElement.AttrCostCenterSAP.AttrResponsable = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCeCo
tmpoutParamListElement.AttrCostCenterSAP.AttrCeCo = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprim_reales_Ind_debloq
tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprim_reales_Ind_debloq = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_reales_Ind_debl
tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_reales_Ind_debl = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosreales_Ind_debloqueo
tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosreales_Ind_debloqueo = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrActualiz_comprom__Ind_debloq
tmpoutParamListElement.AttrCostCenterSAP.AttrActualiz_comprom__Ind_debloq = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprimariosplan_Ind_debl
tmpoutParamListElement.AttrCostCenterSAP.AttrCostesprimariosplan_Ind_debl = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_plan_Ind_debloq
tmpoutParamListElement.AttrCostCenterSAP.AttrCostessecund_plan_Ind_debloq = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosplan_Ind_debloqueo_
tmpoutParamListElement.AttrCostCenterSAP.AttrIngresosplan_Ind_debloqueo_ = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrAutor
tmpoutParamListElement.AttrCostCenterSAP.AttrAutor = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedOn
tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedBy
tmpoutParamListElement.AttrCostCenterSAP.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedOn
tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedBy
tmpoutParamListElement.AttrCostCenterSAP.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrCostCenterSAP.AttrIsActive
tmpoutParamListElement.AttrCostCenterSAP.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENTelcelDirection to the tmpoutParamListElement.AttrTelcelDirection
tmpoutParamListElement.AttrTelcelDirection = new ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrId
tmpoutParamListElement.AttrTelcelDirection.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrName
tmpoutParamListElement.AttrTelcelDirection.AttrName = "";
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrIsActive
tmpoutParamListElement.AttrTelcelDirection.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrCreatedOn
tmpoutParamListElement.AttrTelcelDirection.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrCreatedBy
tmpoutParamListElement.AttrTelcelDirection.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedOn
tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedBy
tmpoutParamListElement.AttrTelcelDirection.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSegmentAccGroup to the tmpoutParamListElement.AttrSegmentAccGroup
tmpoutParamListElement.AttrSegmentAccGroup = new ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord();
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrId
tmpoutParamListElement.AttrSegmentAccGroup.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrGroupName
tmpoutParamListElement.AttrSegmentAccGroup.AttrGroupName = "";
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrIsActive
tmpoutParamListElement.AttrSegmentAccGroup.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedOn
tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedBy
tmpoutParamListElement.AttrSegmentAccGroup.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedOn
tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedBy
tmpoutParamListElement.AttrSegmentAccGroup.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProject_Asset_Service to the tmpoutParamListElement.AttrProject_Asset_Service
tmpoutParamListElement.AttrProject_Asset_Service = new ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrId
tmpoutParamListElement.AttrProject_Asset_Service.AttrId = (long?) 0L;
tmpoutParamListElement.AttrProject_Asset_Service.AttrDescription = outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription;
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrIsOthers
tmpoutParamListElement.AttrProject_Asset_Service.AttrIsOthers = (bool?) false;
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedOn
tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedBy
tmpoutParamListElement.AttrProject_Asset_Service.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedOn
tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedBy
tmpoutParamListElement.AttrProject_Asset_Service.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir to the tmpoutParamListElement.AttrSegmentAccGroupTelcelDir
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir = new ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrId
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrSegmentAccGroupId
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrSegmentAccGroupId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrTelcelDirectionId
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedOn
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedBy
tmpoutParamListElement.AttrSegmentAccGroupTelcelDir.AttrCreatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENRegion to the tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamListElement.AttrRegion.AttrId
tmpoutParamListElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRegion.AttrCode = outParamList.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamListElement.AttrRegion.AttrName
tmpoutParamListElement.AttrRegion.AttrName = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrDivisionFI
tmpoutParamListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCentroRTP
tmpoutParamListElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCommissionRegion
tmpoutParamListElement.AttrRegion.AttrCommissionRegion = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsActive
tmpoutParamListElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedOn
tmpoutParamListElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedBy
tmpoutParamListElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedOn
tmpoutParamListElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedBy
tmpoutParamListElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFsP
tmpoutParamListElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFcP
tmpoutParamListElement.AttrRegion.AttrIsFcP = (bool?) false;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8));
}

// Write optimized result.outParamSortClause
result.outParamSortClause = "";
return result;
}


    public static ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Model ToModel(RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs variables) {ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Model();
result.outParamList = variables == null ? new RL_a88cee033f640538574578015052224b() : RL_a88cee033f640538574578015052224b.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8.ToStructure);
result.outParamSortClause = variables == null || variables.outParamSortClause == null ? "" : variables.outParamSortClause;
return result;
}


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_DataActionGetRequisitionsFull_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8>(ssConectaProveedores.RestRecords.RESTRC_ed0b8e4be2720d34635f080b43e417d8.FromStructureDelegate(conf));
result.outParamSortClause = screenModel.outParamSortClause;
return result;
}

}
