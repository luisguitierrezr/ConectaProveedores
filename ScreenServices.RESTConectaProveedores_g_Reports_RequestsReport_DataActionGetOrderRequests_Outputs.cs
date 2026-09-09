using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List2")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba> outParamList2;
[JsonProperty("Count")]
public int? outParamCount;


    public static RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_f5a2fdd028de7dc3b32fee45ae563140 outParamList2, int outParamCount) {RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs result = new RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs();
// Write the needed fields of the list outParamList2 to the result.outParamList2
ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba tmpoutParamList2Element;
if(outParamList2.Empty) {
// Write the needed fields of the record outParamList2.CurrentRec to the tmpoutParamList2Element
tmpoutParamList2Element = new ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba();
// Write the needed fields of the record outParamList2.CurrentRec.ssENCurrency to the tmpoutParamList2Element.AttrCurrency
tmpoutParamList2Element.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrCode
tmpoutParamList2Element.AttrCurrency.AttrCode = "";
tmpoutParamList2Element.AttrCurrency.AttrName = outParamList2.CurrentRec.ssENCurrency.ssName;
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrSymbol
tmpoutParamList2Element.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamList2Element.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrIsActive
tmpoutParamList2Element.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList2.CurrentRec.ssENUser to the tmpoutParamList2Element.AttrUser
tmpoutParamList2Element.AttrUser = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamList2Element.AttrUser.AttrId
tmpoutParamList2Element.AttrUser.AttrId = "";
tmpoutParamList2Element.AttrUser.AttrName = outParamList2.CurrentRec.ssENUser.ssName;
// Write optimized tmpoutParamList2Element.AttrUser.AttrEmail
tmpoutParamList2Element.AttrUser.AttrEmail = "";
// Write optimized tmpoutParamList2Element.AttrUser.AttrPhotoUrl
tmpoutParamList2Element.AttrUser.AttrPhotoUrl = "";
// Write optimized tmpoutParamList2Element.AttrUser.AttrUsername
tmpoutParamList2Element.AttrUser.AttrUsername = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderStatus to the tmpoutParamList2Element.AttrOrderStatus
tmpoutParamList2Element.AttrOrderStatus = new ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrId
tmpoutParamList2Element.AttrOrderStatus.AttrId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrLabel
tmpoutParamList2Element.AttrOrderStatus.AttrLabel = "";
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrClass
tmpoutParamList2Element.AttrOrderStatus.AttrClass = "";
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrOrder
tmpoutParamList2Element.AttrOrderStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrIs_Active
tmpoutParamList2Element.AttrOrderStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrLabelES
tmpoutParamList2Element.AttrOrderStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderMainItem to the tmpoutParamList2Element.AttrOrderMainItem
tmpoutParamList2Element.AttrOrderMainItem = new ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrId
tmpoutParamList2Element.AttrOrderMainItem.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainId
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainId = (long?) 0L;
tmpoutParamList2Element.AttrOrderMainItem.AttrPosition = (int?) outParamList2.CurrentRec.ssENOrderMainItem.ssPosition;
tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialCode = outParamList2.CurrentRec.ssENOrderMainItem.ssMaterialCode;
tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialDescription = outParamList2.CurrentRec.ssENOrderMainItem.ssMaterialDescription;
tmpoutParamList2Element.AttrOrderMainItem.AttrAssigmnentCode = outParamList2.CurrentRec.ssENOrderMainItem.ssAssigmnentCode;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrDocumentClassId
tmpoutParamList2Element.AttrOrderMainItem.AttrDocumentClassId = (long?) 0L;
tmpoutParamList2Element.AttrOrderMainItem.AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList2.CurrentRec.ssENOrderMainItem.ssDeliveryDate);
tmpoutParamList2Element.AttrOrderMainItem.AttrQuantity = (decimal?) outParamList2.CurrentRec.ssENOrderMainItem.ssQuantity;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrUnitType
tmpoutParamList2Element.AttrOrderMainItem.AttrUnitType = "";
tmpoutParamList2Element.AttrOrderMainItem.AttrUnitPrice = (decimal?) outParamList2.CurrentRec.ssENOrderMainItem.ssUnitPrice;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrBaseQuantity
tmpoutParamList2Element.AttrOrderMainItem.AttrBaseQuantity = (int?) 0;
tmpoutParamList2Element.AttrOrderMainItem.AttrIsDeleted = (bool?) outParamList2.CurrentRec.ssENOrderMainItem.ssIsDeleted;
tmpoutParamList2Element.AttrOrderMainItem.AttrIsBlocked = (bool?) outParamList2.CurrentRec.ssENOrderMainItem.ssIsBlocked;
tmpoutParamList2Element.AttrOrderMainItem.AttrIsFinalDelivery = (bool?) outParamList2.CurrentRec.ssENOrderMainItem.ssIsFinalDelivery;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrGLAccountId
tmpoutParamList2Element.AttrOrderMainItem.AttrGLAccountId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCostCenterId
tmpoutParamList2Element.AttrOrderMainItem.AttrCostCenterId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrFundsCenter
tmpoutParamList2Element.AttrOrderMainItem.AttrFundsCenter = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrFund
tmpoutParamList2Element.AttrOrderMainItem.AttrFund = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCommitmentItem
tmpoutParamList2Element.AttrOrderMainItem.AttrCommitmentItem = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrVATIndicator
tmpoutParamList2Element.AttrOrderMainItem.AttrVATIndicator = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrVATProcedure
tmpoutParamList2Element.AttrOrderMainItem.AttrVATProcedure = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrVATRate
tmpoutParamList2Element.AttrOrderMainItem.AttrVATRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionNumber
tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionItemNr
tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionItemNr = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrRegionId
tmpoutParamList2Element.AttrOrderMainItem.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCenter
tmpoutParamList2Element.AttrOrderMainItem.AttrCenter = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPEPElement
tmpoutParamList2Element.AttrOrderMainItem.AttrPEPElement = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrQuantityDelivered
tmpoutParamList2Element.AttrOrderMainItem.AttrQuantityDelivered = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderUnitOfMeasure
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderUnitOfMeasure = "";
tmpoutParamList2Element.AttrOrderMainItem.AttrApplicant = outParamList2.CurrentRec.ssENOrderMainItem.ssApplicant;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrDirection
tmpoutParamList2Element.AttrOrderMainItem.AttrDirection = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractNumber
tmpoutParamList2Element.AttrOrderMainItem.AttrContractNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractPosition
tmpoutParamList2Element.AttrOrderMainItem.AttrContractPosition = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractStartDate
tmpoutParamList2Element.AttrOrderMainItem.AttrContractStartDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractEndDate
tmpoutParamList2Element.AttrOrderMainItem.AttrContractEndDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractPlannedValue
tmpoutParamList2Element.AttrOrderMainItem.AttrContractPlannedValue = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPositionType
tmpoutParamList2Element.AttrOrderMainItem.AttrPositionType = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrSerialNumberProfile
tmpoutParamList2Element.AttrOrderMainItem.AttrSerialNumberProfile = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrBatchManaged
tmpoutParamList2Element.AttrOrderMainItem.AttrBatchManaged = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialType
tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialType = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrItemGroup
tmpoutParamList2Element.AttrOrderMainItem.AttrItemGroup = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderRequestCreatorSAPNumber
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderRequestCreatorSAPNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrIsMultipleImputation
tmpoutParamList2Element.AttrOrderMainItem.AttrIsMultipleImputation = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrInvoiceUsageId
tmpoutParamList2Element.AttrOrderMainItem.AttrInvoiceUsageId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainItemStatusId
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainItemStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrDivisionId
tmpoutParamList2Element.AttrOrderMainItem.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedBy
tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedOn
tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedBy
tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedOn
tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderMainItemStatus to the tmpoutParamList2Element.AttrOrderMainItemStatus
tmpoutParamList2Element.AttrOrderMainItemStatus = new ssConectaProveedores.RestRecords.RESTEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderMainItemStatus.AttrId
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrId = (int?) 0;
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrLabel = outParamList2.CurrentRec.ssENOrderMainItemStatus.ssLabel;
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrClass = outParamList2.CurrentRec.ssENOrderMainItemStatus.ssClass;
// Write optimized tmpoutParamList2Element.AttrOrderMainItemStatus.AttrOrder
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItemStatus.AttrIs_Active
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrIs_Active = (bool?) false;
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderMain to the tmpoutParamList2Element.AttrOrderMain
tmpoutParamList2Element.AttrOrderMain = new ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrId
tmpoutParamList2Element.AttrOrderMain.AttrId = (long?) 0L;
tmpoutParamList2Element.AttrOrderMain.AttrOrderNumber = outParamList2.CurrentRec.ssENOrderMain.ssOrderNumber;
tmpoutParamList2Element.AttrOrderMain.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList2.CurrentRec.ssENOrderMain.ssOrderDate);
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrOrderStatusId
tmpoutParamList2Element.AttrOrderMain.AttrOrderStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrPreviousOrderStatusId
tmpoutParamList2Element.AttrOrderMain.AttrPreviousOrderStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrAssignmentCode
tmpoutParamList2Element.AttrOrderMain.AttrAssignmentCode = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrSupplierId
tmpoutParamList2Element.AttrOrderMain.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCompanyId
tmpoutParamList2Element.AttrOrderMain.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrDocumentTypeId
tmpoutParamList2Element.AttrOrderMain.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCurrencyId
tmpoutParamList2Element.AttrOrderMain.AttrCurrencyId = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrTelcelDirectionId
tmpoutParamList2Element.AttrOrderMain.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrProcurementGroup
tmpoutParamList2Element.AttrOrderMain.AttrProcurementGroup = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPNumber
tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPName
tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPName = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCountry
tmpoutParamList2Element.AttrOrderMain.AttrCountry = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrIsDeleted
tmpoutParamList2Element.AttrOrderMain.AttrIsDeleted = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrIsReleased
tmpoutParamList2Element.AttrOrderMain.AttrIsReleased = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrExchangeRate
tmpoutParamList2Element.AttrOrderMain.AttrExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrSustainabilityCategory
tmpoutParamList2Element.AttrOrderMain.AttrSustainabilityCategory = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrSustainabilitySubcategory
tmpoutParamList2Element.AttrOrderMain.AttrSustainabilitySubcategory = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrTotalAmount
tmpoutParamList2Element.AttrOrderMain.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrFromCosmoz
tmpoutParamList2Element.AttrOrderMain.AttrFromCosmoz = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrRegionId
tmpoutParamList2Element.AttrOrderMain.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrDivisionId
tmpoutParamList2Element.AttrOrderMain.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrApplicant
tmpoutParamList2Element.AttrOrderMain.AttrApplicant = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatedBy
tmpoutParamList2Element.AttrOrderMain.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatedOn
tmpoutParamList2Element.AttrOrderMain.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrUpdatedBy
tmpoutParamList2Element.AttrOrderMain.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrUpdatedOn
tmpoutParamList2Element.AttrOrderMain.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderDetail to the tmpoutParamList2Element.AttrOrderDetail
tmpoutParamList2Element.AttrOrderDetail = new ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrOrderId
tmpoutParamList2Element.AttrOrderDetail.AttrOrderId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrIsApprovalFromUserArea
tmpoutParamList2Element.AttrOrderDetail.AttrIsApprovalFromUserArea = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetServiceId
tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetServiceId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetService
tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetService = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrProjectDescription
tmpoutParamList2Element.AttrOrderDetail.AttrProjectDescription = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueCategoryId
tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueCategoryId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueSubcategoryId
tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueSubcategoryId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentTermsId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentTermsId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentMethodId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentMethodId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrNegotiatedExchangeRate
tmpoutParamList2Element.AttrOrderDetail.AttrNegotiatedExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractStatus
tmpoutParamList2Element.AttrOrderDetail.AttrContractStatus = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrDateOfCommitment
tmpoutParamList2Element.AttrOrderDetail.AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasDeposit
tmpoutParamList2Element.AttrOrderDetail.AttrHasDeposit = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasInsurance
tmpoutParamList2Element.AttrOrderDetail.AttrHasInsurance = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrDistributionId
tmpoutParamList2Element.AttrOrderDetail.AttrDistributionId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasAdvancePayment
tmpoutParamList2Element.AttrOrderDetail.AttrHasAdvancePayment = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrRetentionRate
tmpoutParamList2Element.AttrOrderDetail.AttrRetentionRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasBaseDate
tmpoutParamList2Element.AttrOrderDetail.AttrHasBaseDate = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrStartBaseDate
tmpoutParamList2Element.AttrOrderDetail.AttrStartBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrEndBaseDate
tmpoutParamList2Element.AttrOrderDetail.AttrEndBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractNumber
tmpoutParamList2Element.AttrOrderDetail.AttrContractNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrIsRetentionApplied
tmpoutParamList2Element.AttrOrderDetail.AttrIsRetentionApplied = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrFrequency
tmpoutParamList2Element.AttrOrderDetail.AttrFrequency = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPeriod
tmpoutParamList2Element.AttrOrderDetail.AttrPeriod = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrOrderRetentionTypeId
tmpoutParamList2Element.AttrOrderDetail.AttrOrderRetentionTypeId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentOptionsId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentOptionsId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentWaysId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentWaysId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrOrdersContract
tmpoutParamList2Element.AttrOrderDetail.AttrOrdersContract = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractAmount
tmpoutParamList2Element.AttrOrderDetail.AttrContractAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractTarif
tmpoutParamList2Element.AttrOrderDetail.AttrContractTarif = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractSupplier
tmpoutParamList2Element.AttrOrderDetail.AttrContractSupplier = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrIsDependentFromFolios
tmpoutParamList2Element.AttrOrderDetail.AttrIsDependentFromFolios = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrSpecialApprovalId
tmpoutParamList2Element.AttrOrderDetail.AttrSpecialApprovalId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrCreatedBy
tmpoutParamList2Element.AttrOrderDetail.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrCreatedOn
tmpoutParamList2Element.AttrOrderDetail.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedBy
tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedOn
tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrAllContactFilesValidated
tmpoutParamList2Element.AttrOrderDetail.AttrAllContactFilesValidated = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasntRequestDocuments
tmpoutParamList2Element.AttrOrderDetail.AttrHasntRequestDocuments = (bool?) false;
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderApprovalLevel to the tmpoutParamList2Element.AttrOrderApprovalLevel
tmpoutParamList2Element.AttrOrderApprovalLevel = new ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrOrderApprovalId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrOrderApprovalId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrLevelNumber
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrLevelNumber = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrEntraRoleId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedTo
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedTo = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovalStatusId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovalStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsComplement
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsComplement = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsReassigned
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsReassigned = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsSubstituteFor
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsSubstituteFor = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrWasCanceledBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrWasCanceledBy = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssSTQtdDelivered to the tmpoutParamList2Element.AttrQtdDelivered
tmpoutParamList2Element.AttrQtdDelivered = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamList2Element.AttrQtdDelivered.AttrValue = (decimal?) outParamList2.CurrentRec.ssSTQtdDelivered.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssSTQuantityAvailable to the tmpoutParamList2Element.AttrQuantityAvailable
tmpoutParamList2Element.AttrQuantityAvailable = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamList2Element.AttrQuantityAvailable.AttrValue = (decimal?) outParamList2.CurrentRec.ssSTQuantityAvailable.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssSTTotal to the tmpoutParamList2Element.AttrTotal
tmpoutParamList2Element.AttrTotal = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamList2Element.AttrTotal.AttrValue = (decimal?) outParamList2.CurrentRec.ssSTTotal.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssSTDeliveryStatus to the tmpoutParamList2Element.AttrDeliveryStatus
tmpoutParamList2Element.AttrDeliveryStatus = new ssConectaProveedores.RestRecords.RESTSTTextStructure();
tmpoutParamList2Element.AttrDeliveryStatus.AttrValue = outParamList2.CurrentRec.ssSTDeliveryStatus.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssENUser_Extended_Internal to the tmpoutParamList2Element.AttrUser_Extended_Internal
tmpoutParamList2Element.AttrUser_Extended_Internal = new ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrId = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEmployeeNumber
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEmployeeNumber = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagedBy
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagedBy = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrRegionId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrDepartmentId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagementId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagementId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrSubdirectionId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrSubdirectionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDirectionId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCity
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCity = "";
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrJobTitle = outParamList2.CurrentRec.ssENUser_Extended_Internal.ssJobTitle;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraRoleId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttronPremisesDistinguishedName
tmpoutParamList2Element.AttrUser_Extended_Internal.AttronPremisesDistinguishedName = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrHasRolesAssigned
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrHasRolesAssigned = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrLastSync
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrLastSync = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedBy
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedOn
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedBy
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedOn
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraId = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDireccion
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDireccion = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENCompany to the tmpoutParamList2Element.AttrCompany
tmpoutParamList2Element.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamList2Element.AttrCompany.AttrId
tmpoutParamList2Element.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrExternalId
tmpoutParamList2Element.AttrCompany.AttrExternalId = "";
tmpoutParamList2Element.AttrCompany.AttrDescription = outParamList2.CurrentRec.ssENCompany.ssDescription;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrRFC
tmpoutParamList2Element.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamList2Element.AttrCompany.AttrPostalCode
tmpoutParamList2Element.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamList2Element.AttrCompany.AttrCyAImport
tmpoutParamList2Element.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrFsPUse
tmpoutParamList2Element.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrCreatedOn
tmpoutParamList2Element.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrCompany.AttrCreatedBy
tmpoutParamList2Element.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrCompany.AttrUpdatedOn
tmpoutParamList2Element.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrCompany.AttrUpdatedBy
tmpoutParamList2Element.AttrCompany.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENSupplier to the tmpoutParamList2Element.AttrSupplier
tmpoutParamList2Element.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrId
tmpoutParamList2Element.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrTratamiento
tmpoutParamList2Element.AttrSupplier.AttrTratamiento = "";
tmpoutParamList2Element.AttrSupplier.AttrName = outParamList2.CurrentRec.ssENSupplier.ssName;
tmpoutParamList2Element.AttrSupplier.AttrNumber = outParamList2.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamList2Element.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCalle_Numero
tmpoutParamList2Element.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrDistrito
tmpoutParamList2Element.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamList2Element.AttrSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrPais
tmpoutParamList2Element.AttrSupplier.AttrPais = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrRegion_
tmpoutParamList2Element.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrIdioma
tmpoutParamList2Element.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrTelefono
tmpoutParamList2Element.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrExtension
tmpoutParamList2Element.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrFax
tmpoutParamList2Element.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCliente
tmpoutParamList2Element.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrSoc_GLasociada
tmpoutParamList2Element.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrClavedegrupo
tmpoutParamList2Element.AttrSupplier.AttrClavedegrupo = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrN_ident_fis_1
tmpoutParamList2Element.AttrSupplier.AttrN_ident_fis_1 = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrPersonafisica
tmpoutParamList2Element.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrRamo
tmpoutParamList2Element.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrGrupodeporte
tmpoutParamList2Element.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrEmail
tmpoutParamList2Element.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrIsActive
tmpoutParamList2Element.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCreatedOn
tmpoutParamList2Element.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCreatedBy
tmpoutParamList2Element.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrUpdatedOn
tmpoutParamList2Element.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrUpdatedBy
tmpoutParamList2Element.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrRegionId
tmpoutParamList2Element.AttrSupplier.AttrRegionId = (long?) 0L;
result.outParamList2 = new RestList<ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba>(new ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba[] {}, tmpoutParamList2Element);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba>
 tmpoutParamList21List = new List<ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba>
();
try {outParamList2.StartIteration();
while (!(outParamList2.Eof)) {
// Write the needed fields of the record outParamList2.CurrentRec to the tmpoutParamList2Element
tmpoutParamList2Element = new ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba();
// Write the needed fields of the record outParamList2.CurrentRec.ssENCurrency to the tmpoutParamList2Element.AttrCurrency
tmpoutParamList2Element.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrCode
tmpoutParamList2Element.AttrCurrency.AttrCode = "";
tmpoutParamList2Element.AttrCurrency.AttrName = outParamList2.CurrentRec.ssENCurrency.ssName;
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrSymbol
tmpoutParamList2Element.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamList2Element.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrCurrency.AttrIsActive
tmpoutParamList2Element.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList2.CurrentRec.ssENUser to the tmpoutParamList2Element.AttrUser
tmpoutParamList2Element.AttrUser = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamList2Element.AttrUser.AttrId
tmpoutParamList2Element.AttrUser.AttrId = "";
tmpoutParamList2Element.AttrUser.AttrName = outParamList2.CurrentRec.ssENUser.ssName;
// Write optimized tmpoutParamList2Element.AttrUser.AttrEmail
tmpoutParamList2Element.AttrUser.AttrEmail = "";
// Write optimized tmpoutParamList2Element.AttrUser.AttrPhotoUrl
tmpoutParamList2Element.AttrUser.AttrPhotoUrl = "";
// Write optimized tmpoutParamList2Element.AttrUser.AttrUsername
tmpoutParamList2Element.AttrUser.AttrUsername = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderStatus to the tmpoutParamList2Element.AttrOrderStatus
tmpoutParamList2Element.AttrOrderStatus = new ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrId
tmpoutParamList2Element.AttrOrderStatus.AttrId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrLabel
tmpoutParamList2Element.AttrOrderStatus.AttrLabel = "";
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrClass
tmpoutParamList2Element.AttrOrderStatus.AttrClass = "";
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrOrder
tmpoutParamList2Element.AttrOrderStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrIs_Active
tmpoutParamList2Element.AttrOrderStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderStatus.AttrLabelES
tmpoutParamList2Element.AttrOrderStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderMainItem to the tmpoutParamList2Element.AttrOrderMainItem
tmpoutParamList2Element.AttrOrderMainItem = new ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrId
tmpoutParamList2Element.AttrOrderMainItem.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainId
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainId = (long?) 0L;
tmpoutParamList2Element.AttrOrderMainItem.AttrPosition = (int?) outParamList2.CurrentRec.ssENOrderMainItem.ssPosition;
tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialCode = outParamList2.CurrentRec.ssENOrderMainItem.ssMaterialCode;
tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialDescription = outParamList2.CurrentRec.ssENOrderMainItem.ssMaterialDescription;
tmpoutParamList2Element.AttrOrderMainItem.AttrAssigmnentCode = outParamList2.CurrentRec.ssENOrderMainItem.ssAssigmnentCode;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrDocumentClassId
tmpoutParamList2Element.AttrOrderMainItem.AttrDocumentClassId = (long?) 0L;
tmpoutParamList2Element.AttrOrderMainItem.AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList2.CurrentRec.ssENOrderMainItem.ssDeliveryDate);
tmpoutParamList2Element.AttrOrderMainItem.AttrQuantity = (decimal?) outParamList2.CurrentRec.ssENOrderMainItem.ssQuantity;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrUnitType
tmpoutParamList2Element.AttrOrderMainItem.AttrUnitType = "";
tmpoutParamList2Element.AttrOrderMainItem.AttrUnitPrice = (decimal?) outParamList2.CurrentRec.ssENOrderMainItem.ssUnitPrice;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrBaseQuantity
tmpoutParamList2Element.AttrOrderMainItem.AttrBaseQuantity = (int?) 0;
tmpoutParamList2Element.AttrOrderMainItem.AttrIsDeleted = (bool?) outParamList2.CurrentRec.ssENOrderMainItem.ssIsDeleted;
tmpoutParamList2Element.AttrOrderMainItem.AttrIsBlocked = (bool?) outParamList2.CurrentRec.ssENOrderMainItem.ssIsBlocked;
tmpoutParamList2Element.AttrOrderMainItem.AttrIsFinalDelivery = (bool?) outParamList2.CurrentRec.ssENOrderMainItem.ssIsFinalDelivery;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrGLAccountId
tmpoutParamList2Element.AttrOrderMainItem.AttrGLAccountId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCostCenterId
tmpoutParamList2Element.AttrOrderMainItem.AttrCostCenterId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrFundsCenter
tmpoutParamList2Element.AttrOrderMainItem.AttrFundsCenter = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrFund
tmpoutParamList2Element.AttrOrderMainItem.AttrFund = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCommitmentItem
tmpoutParamList2Element.AttrOrderMainItem.AttrCommitmentItem = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrVATIndicator
tmpoutParamList2Element.AttrOrderMainItem.AttrVATIndicator = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrVATProcedure
tmpoutParamList2Element.AttrOrderMainItem.AttrVATProcedure = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrVATRate
tmpoutParamList2Element.AttrOrderMainItem.AttrVATRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionNumber
tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionItemNr
tmpoutParamList2Element.AttrOrderMainItem.AttrPurchaseRequisitionItemNr = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrRegionId
tmpoutParamList2Element.AttrOrderMainItem.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCenter
tmpoutParamList2Element.AttrOrderMainItem.AttrCenter = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPEPElement
tmpoutParamList2Element.AttrOrderMainItem.AttrPEPElement = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrQuantityDelivered
tmpoutParamList2Element.AttrOrderMainItem.AttrQuantityDelivered = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderUnitOfMeasure
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderUnitOfMeasure = "";
tmpoutParamList2Element.AttrOrderMainItem.AttrApplicant = outParamList2.CurrentRec.ssENOrderMainItem.ssApplicant;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrDirection
tmpoutParamList2Element.AttrOrderMainItem.AttrDirection = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractNumber
tmpoutParamList2Element.AttrOrderMainItem.AttrContractNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractPosition
tmpoutParamList2Element.AttrOrderMainItem.AttrContractPosition = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractStartDate
tmpoutParamList2Element.AttrOrderMainItem.AttrContractStartDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractEndDate
tmpoutParamList2Element.AttrOrderMainItem.AttrContractEndDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrContractPlannedValue
tmpoutParamList2Element.AttrOrderMainItem.AttrContractPlannedValue = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrPositionType
tmpoutParamList2Element.AttrOrderMainItem.AttrPositionType = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrSerialNumberProfile
tmpoutParamList2Element.AttrOrderMainItem.AttrSerialNumberProfile = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrBatchManaged
tmpoutParamList2Element.AttrOrderMainItem.AttrBatchManaged = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialType
tmpoutParamList2Element.AttrOrderMainItem.AttrMaterialType = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrItemGroup
tmpoutParamList2Element.AttrOrderMainItem.AttrItemGroup = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderRequestCreatorSAPNumber
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderRequestCreatorSAPNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrIsMultipleImputation
tmpoutParamList2Element.AttrOrderMainItem.AttrIsMultipleImputation = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrInvoiceUsageId
tmpoutParamList2Element.AttrOrderMainItem.AttrInvoiceUsageId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainItemStatusId
tmpoutParamList2Element.AttrOrderMainItem.AttrOrderMainItemStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrDivisionId
tmpoutParamList2Element.AttrOrderMainItem.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedBy
tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedOn
tmpoutParamList2Element.AttrOrderMainItem.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedBy
tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedOn
tmpoutParamList2Element.AttrOrderMainItem.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderMainItemStatus to the tmpoutParamList2Element.AttrOrderMainItemStatus
tmpoutParamList2Element.AttrOrderMainItemStatus = new ssConectaProveedores.RestRecords.RESTEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderMainItemStatus.AttrId
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrId = (int?) 0;
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrLabel = outParamList2.CurrentRec.ssENOrderMainItemStatus.ssLabel;
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrClass = outParamList2.CurrentRec.ssENOrderMainItemStatus.ssClass;
// Write optimized tmpoutParamList2Element.AttrOrderMainItemStatus.AttrOrder
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMainItemStatus.AttrIs_Active
tmpoutParamList2Element.AttrOrderMainItemStatus.AttrIs_Active = (bool?) false;
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderMain to the tmpoutParamList2Element.AttrOrderMain
tmpoutParamList2Element.AttrOrderMain = new ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrId
tmpoutParamList2Element.AttrOrderMain.AttrId = (long?) 0L;
tmpoutParamList2Element.AttrOrderMain.AttrOrderNumber = outParamList2.CurrentRec.ssENOrderMain.ssOrderNumber;
tmpoutParamList2Element.AttrOrderMain.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList2.CurrentRec.ssENOrderMain.ssOrderDate);
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrOrderStatusId
tmpoutParamList2Element.AttrOrderMain.AttrOrderStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrPreviousOrderStatusId
tmpoutParamList2Element.AttrOrderMain.AttrPreviousOrderStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrAssignmentCode
tmpoutParamList2Element.AttrOrderMain.AttrAssignmentCode = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrSupplierId
tmpoutParamList2Element.AttrOrderMain.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCompanyId
tmpoutParamList2Element.AttrOrderMain.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrDocumentTypeId
tmpoutParamList2Element.AttrOrderMain.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCurrencyId
tmpoutParamList2Element.AttrOrderMain.AttrCurrencyId = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrTelcelDirectionId
tmpoutParamList2Element.AttrOrderMain.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrProcurementGroup
tmpoutParamList2Element.AttrOrderMain.AttrProcurementGroup = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPNumber
tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPName
tmpoutParamList2Element.AttrOrderMain.AttrCreatorSAPName = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCountry
tmpoutParamList2Element.AttrOrderMain.AttrCountry = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrIsDeleted
tmpoutParamList2Element.AttrOrderMain.AttrIsDeleted = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrIsReleased
tmpoutParamList2Element.AttrOrderMain.AttrIsReleased = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrExchangeRate
tmpoutParamList2Element.AttrOrderMain.AttrExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrSustainabilityCategory
tmpoutParamList2Element.AttrOrderMain.AttrSustainabilityCategory = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrSustainabilitySubcategory
tmpoutParamList2Element.AttrOrderMain.AttrSustainabilitySubcategory = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrTotalAmount
tmpoutParamList2Element.AttrOrderMain.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrFromCosmoz
tmpoutParamList2Element.AttrOrderMain.AttrFromCosmoz = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrRegionId
tmpoutParamList2Element.AttrOrderMain.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrDivisionId
tmpoutParamList2Element.AttrOrderMain.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrApplicant
tmpoutParamList2Element.AttrOrderMain.AttrApplicant = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatedBy
tmpoutParamList2Element.AttrOrderMain.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrCreatedOn
tmpoutParamList2Element.AttrOrderMain.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrUpdatedBy
tmpoutParamList2Element.AttrOrderMain.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderMain.AttrUpdatedOn
tmpoutParamList2Element.AttrOrderMain.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderDetail to the tmpoutParamList2Element.AttrOrderDetail
tmpoutParamList2Element.AttrOrderDetail = new ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrOrderId
tmpoutParamList2Element.AttrOrderDetail.AttrOrderId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrIsApprovalFromUserArea
tmpoutParamList2Element.AttrOrderDetail.AttrIsApprovalFromUserArea = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetServiceId
tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetServiceId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetService
tmpoutParamList2Element.AttrOrderDetail.AttrProjectAssetService = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrProjectDescription
tmpoutParamList2Element.AttrOrderDetail.AttrProjectDescription = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueCategoryId
tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueCategoryId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueSubcategoryId
tmpoutParamList2Element.AttrOrderDetail.AttrBusinessValueSubcategoryId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentTermsId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentTermsId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentMethodId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentMethodId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrNegotiatedExchangeRate
tmpoutParamList2Element.AttrOrderDetail.AttrNegotiatedExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractStatus
tmpoutParamList2Element.AttrOrderDetail.AttrContractStatus = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrDateOfCommitment
tmpoutParamList2Element.AttrOrderDetail.AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasDeposit
tmpoutParamList2Element.AttrOrderDetail.AttrHasDeposit = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasInsurance
tmpoutParamList2Element.AttrOrderDetail.AttrHasInsurance = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrDistributionId
tmpoutParamList2Element.AttrOrderDetail.AttrDistributionId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasAdvancePayment
tmpoutParamList2Element.AttrOrderDetail.AttrHasAdvancePayment = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrRetentionRate
tmpoutParamList2Element.AttrOrderDetail.AttrRetentionRate = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasBaseDate
tmpoutParamList2Element.AttrOrderDetail.AttrHasBaseDate = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrStartBaseDate
tmpoutParamList2Element.AttrOrderDetail.AttrStartBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrEndBaseDate
tmpoutParamList2Element.AttrOrderDetail.AttrEndBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractNumber
tmpoutParamList2Element.AttrOrderDetail.AttrContractNumber = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrIsRetentionApplied
tmpoutParamList2Element.AttrOrderDetail.AttrIsRetentionApplied = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrFrequency
tmpoutParamList2Element.AttrOrderDetail.AttrFrequency = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPeriod
tmpoutParamList2Element.AttrOrderDetail.AttrPeriod = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrOrderRetentionTypeId
tmpoutParamList2Element.AttrOrderDetail.AttrOrderRetentionTypeId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentOptionsId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentOptionsId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrPaymentWaysId
tmpoutParamList2Element.AttrOrderDetail.AttrPaymentWaysId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrOrdersContract
tmpoutParamList2Element.AttrOrderDetail.AttrOrdersContract = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractAmount
tmpoutParamList2Element.AttrOrderDetail.AttrContractAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractTarif
tmpoutParamList2Element.AttrOrderDetail.AttrContractTarif = (decimal?) 0.0M;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrContractSupplier
tmpoutParamList2Element.AttrOrderDetail.AttrContractSupplier = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrIsDependentFromFolios
tmpoutParamList2Element.AttrOrderDetail.AttrIsDependentFromFolios = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrSpecialApprovalId
tmpoutParamList2Element.AttrOrderDetail.AttrSpecialApprovalId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrCreatedBy
tmpoutParamList2Element.AttrOrderDetail.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrCreatedOn
tmpoutParamList2Element.AttrOrderDetail.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedBy
tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedOn
tmpoutParamList2Element.AttrOrderDetail.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrAllContactFilesValidated
tmpoutParamList2Element.AttrOrderDetail.AttrAllContactFilesValidated = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderDetail.AttrHasntRequestDocuments
tmpoutParamList2Element.AttrOrderDetail.AttrHasntRequestDocuments = (bool?) false;
// Write the needed fields of the record outParamList2.CurrentRec.ssENOrderApprovalLevel to the tmpoutParamList2Element.AttrOrderApprovalLevel
tmpoutParamList2Element.AttrOrderApprovalLevel = new ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord();
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrOrderApprovalId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrOrderApprovalId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrLevelNumber
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrLevelNumber = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrEntraRoleId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedTo
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedTo = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovalStatusId
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovalStatusId = (int?) 0;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsComplement
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsComplement = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsReassigned
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsReassigned = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsSubstituteFor
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrIsSubstituteFor = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyBy = "";
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyOn
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrOrderApprovalLevel.AttrWasCanceledBy
tmpoutParamList2Element.AttrOrderApprovalLevel.AttrWasCanceledBy = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssSTQtdDelivered to the tmpoutParamList2Element.AttrQtdDelivered
tmpoutParamList2Element.AttrQtdDelivered = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamList2Element.AttrQtdDelivered.AttrValue = (decimal?) outParamList2.CurrentRec.ssSTQtdDelivered.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssSTQuantityAvailable to the tmpoutParamList2Element.AttrQuantityAvailable
tmpoutParamList2Element.AttrQuantityAvailable = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamList2Element.AttrQuantityAvailable.AttrValue = (decimal?) outParamList2.CurrentRec.ssSTQuantityAvailable.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssSTTotal to the tmpoutParamList2Element.AttrTotal
tmpoutParamList2Element.AttrTotal = new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure();
tmpoutParamList2Element.AttrTotal.AttrValue = (decimal?) outParamList2.CurrentRec.ssSTTotal.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssSTDeliveryStatus to the tmpoutParamList2Element.AttrDeliveryStatus
tmpoutParamList2Element.AttrDeliveryStatus = new ssConectaProveedores.RestRecords.RESTSTTextStructure();
tmpoutParamList2Element.AttrDeliveryStatus.AttrValue = outParamList2.CurrentRec.ssSTDeliveryStatus.ssValue;
// Write the needed fields of the record outParamList2.CurrentRec.ssENUser_Extended_Internal to the tmpoutParamList2Element.AttrUser_Extended_Internal
tmpoutParamList2Element.AttrUser_Extended_Internal = new ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrId = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEmployeeNumber
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEmployeeNumber = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagedBy
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagedBy = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrRegionId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrDepartmentId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagementId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrManagementId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrSubdirectionId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrSubdirectionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDirectionId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCity
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCity = "";
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrJobTitle = outParamList2.CurrentRec.ssENUser_Extended_Internal.ssJobTitle;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraRoleId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttronPremisesDistinguishedName
tmpoutParamList2Element.AttrUser_Extended_Internal.AttronPremisesDistinguishedName = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrHasRolesAssigned
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrHasRolesAssigned = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrLastSync
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrLastSync = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedBy
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedOn
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedBy
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedOn
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraId
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrEntraId = "";
// Write optimized tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDireccion
tmpoutParamList2Element.AttrUser_Extended_Internal.AttrTelcelDireccion = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENCompany to the tmpoutParamList2Element.AttrCompany
tmpoutParamList2Element.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamList2Element.AttrCompany.AttrId
tmpoutParamList2Element.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrExternalId
tmpoutParamList2Element.AttrCompany.AttrExternalId = "";
tmpoutParamList2Element.AttrCompany.AttrDescription = outParamList2.CurrentRec.ssENCompany.ssDescription;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrRFC
tmpoutParamList2Element.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamList2Element.AttrCompany.AttrPostalCode
tmpoutParamList2Element.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamList2Element.AttrCompany.AttrCyAImport
tmpoutParamList2Element.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrFsPUse
tmpoutParamList2Element.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrCompany.AttrCreatedOn
tmpoutParamList2Element.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrCompany.AttrCreatedBy
tmpoutParamList2Element.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrCompany.AttrUpdatedOn
tmpoutParamList2Element.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrCompany.AttrUpdatedBy
tmpoutParamList2Element.AttrCompany.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList2.CurrentRec.ssENSupplier to the tmpoutParamList2Element.AttrSupplier
tmpoutParamList2Element.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrId
tmpoutParamList2Element.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrTratamiento
tmpoutParamList2Element.AttrSupplier.AttrTratamiento = "";
tmpoutParamList2Element.AttrSupplier.AttrName = outParamList2.CurrentRec.ssENSupplier.ssName;
tmpoutParamList2Element.AttrSupplier.AttrNumber = outParamList2.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamList2Element.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCalle_Numero
tmpoutParamList2Element.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrDistrito
tmpoutParamList2Element.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamList2Element.AttrSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrPais
tmpoutParamList2Element.AttrSupplier.AttrPais = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrRegion_
tmpoutParamList2Element.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrIdioma
tmpoutParamList2Element.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrTelefono
tmpoutParamList2Element.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrExtension
tmpoutParamList2Element.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrFax
tmpoutParamList2Element.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCliente
tmpoutParamList2Element.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrSoc_GLasociada
tmpoutParamList2Element.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrClavedegrupo
tmpoutParamList2Element.AttrSupplier.AttrClavedegrupo = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrN_ident_fis_1
tmpoutParamList2Element.AttrSupplier.AttrN_ident_fis_1 = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrPersonafisica
tmpoutParamList2Element.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrRamo
tmpoutParamList2Element.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrGrupodeporte
tmpoutParamList2Element.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrEmail
tmpoutParamList2Element.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrIsActive
tmpoutParamList2Element.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCreatedOn
tmpoutParamList2Element.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrCreatedBy
tmpoutParamList2Element.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrUpdatedOn
tmpoutParamList2Element.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrUpdatedBy
tmpoutParamList2Element.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamList2Element.AttrSupplier.AttrRegionId
tmpoutParamList2Element.AttrSupplier.AttrRegionId = (long?) 0L;
tmpoutParamList21List.Add(tmpoutParamList2Element);
outParamList2.Advance();
}

} finally {
outParamList2.EndIteration();
}

result.outParamList2 = new RestList<ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba>(tmpoutParamList21List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba));
}

result.outParamCount = (int?) outParamCount;
return result;
}


    public static ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model ToModel(RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs variables) {ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model result = new ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model();
result.outParamList2 = variables == null ? new RL_f5a2fdd028de7dc3b32fee45ae563140() : RL_f5a2fdd028de7dc3b32fee45ae563140.FromRestList(variables.outParamList2, ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0 : variables.outParamCount.Value;
return result;
}


    public static RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs result = new RESTConectaProveedores_g_Reports_RequestsReport_DataActionGetOrderRequests_Outputs();
result.outParamList2 = screenModel.outParamList2.ToRestList<ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba>(ssConectaProveedores.RestRecords.RESTRC_aae113dc341165a54f51793c1371eeba.FromStructureDelegate(conf));
result.outParamCount = (int?) screenModel.outParamCount;
return result;
}

}
