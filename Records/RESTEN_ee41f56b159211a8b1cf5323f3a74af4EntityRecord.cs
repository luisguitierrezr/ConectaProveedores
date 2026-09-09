using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItem
public class RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord : AbstractRESTStructure<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("Position")]
public int? AttrPosition;

[JsonProperty("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("MaterialDescription")]
public string AttrMaterialDescription;

[JsonProperty("AssigmnentCode")]
public string AttrAssigmnentCode;

[JsonProperty("DocumentClassId")]
public long? AttrDocumentClassId;

[JsonProperty("DeliveryDate")]
public String AttrDeliveryDate;

[JsonProperty("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("UnitType")]
public string AttrUnitType;

[JsonProperty("UnitPrice")]
public decimal? AttrUnitPrice;

[JsonProperty("BaseQuantity")]
public int? AttrBaseQuantity;

[JsonProperty("IsDeleted")]
public bool? AttrIsDeleted;

[JsonProperty("IsBlocked")]
public bool? AttrIsBlocked;

[JsonProperty("IsFinalDelivery")]
public bool? AttrIsFinalDelivery;

[JsonProperty("GLAccountId")]
public long? AttrGLAccountId;

[JsonProperty("CostCenterId")]
public long? AttrCostCenterId;

[JsonProperty("FundsCenter")]
public string AttrFundsCenter;

[JsonProperty("Fund")]
public string AttrFund;

[JsonProperty("CommitmentItem")]
public string AttrCommitmentItem;

[JsonProperty("VATIndicator")]
public string AttrVATIndicator;

[JsonProperty("VATProcedure")]
public string AttrVATProcedure;

[JsonProperty("VATRate")]
public decimal? AttrVATRate;

[JsonProperty("PurchaseRequisitionNumber")]
public string AttrPurchaseRequisitionNumber;

[JsonProperty("PurchaseRequisitionItemNr")]
public int? AttrPurchaseRequisitionItemNr;

[JsonProperty("RegionId")]
public long? AttrRegionId;

[JsonProperty("Center")]
public string AttrCenter;

[JsonProperty("PEPElement")]
public string AttrPEPElement;

[JsonProperty("QuantityDelivered")]
public decimal? AttrQuantityDelivered;

[JsonProperty("OrderUnitOfMeasure")]
public string AttrOrderUnitOfMeasure;

[JsonProperty("Applicant")]
public string AttrApplicant;

[JsonProperty("Direction")]
public string AttrDirection;

[JsonProperty("ContractNumber")]
public string AttrContractNumber;

[JsonProperty("ContractPosition")]
public int? AttrContractPosition;

[JsonProperty("ContractStartDate")]
public String AttrContractStartDate;

[JsonProperty("ContractEndDate")]
public String AttrContractEndDate;

[JsonProperty("ContractPlannedValue")]
public decimal? AttrContractPlannedValue;

[JsonProperty("PositionType")]
public string AttrPositionType;

[JsonProperty("SerialNumberProfile")]
public string AttrSerialNumberProfile;

[JsonProperty("BatchManaged")]
public string AttrBatchManaged;

[JsonProperty("MaterialType")]
public string AttrMaterialType;

[JsonProperty("ItemGroup")]
public string AttrItemGroup;

[JsonProperty("OrderRequestCreatorSAPNumber")]
public string AttrOrderRequestCreatorSAPNumber;

[JsonProperty("IsMultipleImputation")]
public bool? AttrIsMultipleImputation;

[JsonProperty("InvoiceUsageId")]
public long? AttrInvoiceUsageId;

[JsonProperty("OrderMainItemStatusId")]
public int? AttrOrderMainItemStatusId;

[JsonProperty("DivisionId")]
public long? AttrDivisionId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

public RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord() { }

public RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, 0);
AttrMaterialCode = ConvertToRestWithoutDefaults(s.ssMaterialCode, "");
AttrMaterialDescription = ConvertToRestWithoutDefaults(s.ssMaterialDescription, "");
AttrAssigmnentCode = ConvertToRestWithoutDefaults(s.ssAssigmnentCode, "");
AttrDocumentClassId = ConvertToRestWithoutDefaults(s.ssDocumentClassId, 0L);
AttrDeliveryDate = ConvertDateToRestWithoutDefaults(s.ssDeliveryDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrUnitType = ConvertToRestWithoutDefaults(s.ssUnitType, "");
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, 0.0M);
AttrBaseQuantity = ConvertToRestWithoutDefaults(s.ssBaseQuantity, 0);
AttrIsDeleted = ConvertToRestWithoutDefaults(s.ssIsDeleted, false);
AttrIsBlocked = ConvertToRestWithoutDefaults(s.ssIsBlocked, false);
AttrIsFinalDelivery = ConvertToRestWithoutDefaults(s.ssIsFinalDelivery, false);
AttrGLAccountId = ConvertToRestWithoutDefaults(s.ssGLAccountId, 0L);
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssCostCenterId, 0L);
AttrFundsCenter = ConvertToRestWithoutDefaults(s.ssFundsCenter, "");
AttrFund = ConvertToRestWithoutDefaults(s.ssFund, "");
AttrCommitmentItem = ConvertToRestWithoutDefaults(s.ssCommitmentItem, "");
AttrVATIndicator = ConvertToRestWithoutDefaults(s.ssVATIndicator, "");
AttrVATProcedure = ConvertToRestWithoutDefaults(s.ssVATProcedure, "");
AttrVATRate = ConvertToRestWithoutDefaults(s.ssVATRate, 0.0M);
AttrPurchaseRequisitionNumber = s.ssPurchaseRequisitionNumber;
AttrPurchaseRequisitionItemNr = (int?) s.ssPurchaseRequisitionItemNr;
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrCenter = ConvertToRestWithoutDefaults(s.ssCenter, "");
AttrPEPElement = ConvertToRestWithoutDefaults(s.ssPEPElement, "");
AttrQuantityDelivered = ConvertToRestWithoutDefaults(s.ssQuantityDelivered, 0.0M);
AttrOrderUnitOfMeasure = s.ssOrderUnitOfMeasure;
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrContractNumber = ConvertToRestWithoutDefaults(s.ssContractNumber, "");
AttrContractPosition = ConvertToRestWithoutDefaults(s.ssContractPosition, 0);
AttrContractStartDate = ConvertDateToRestWithoutDefaults(s.ssContractStartDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrContractEndDate = ConvertDateToRestWithoutDefaults(s.ssContractEndDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrContractPlannedValue = ConvertToRestWithoutDefaults(s.ssContractPlannedValue, 0.0M);
AttrPositionType = ConvertToRestWithoutDefaults(s.ssPositionType, "");
AttrSerialNumberProfile = ConvertToRestWithoutDefaults(s.ssSerialNumberProfile, "");
AttrBatchManaged = ConvertToRestWithoutDefaults(s.ssBatchManaged, "");
AttrMaterialType = ConvertToRestWithoutDefaults(s.ssMaterialType, "");
AttrItemGroup = ConvertToRestWithoutDefaults(s.ssItemGroup, "");
AttrOrderRequestCreatorSAPNumber = ConvertToRestWithoutDefaults(s.ssOrderRequestCreatorSAPNumber, "");
AttrIsMultipleImputation = ConvertToRestWithoutDefaults(s.ssIsMultipleImputation, false);
AttrInvoiceUsageId = ConvertToRestWithoutDefaults(s.ssInvoiceUsageId, 0L);
AttrOrderMainItemStatusId = ConvertToRestWithoutDefaults(s.ssOrderMainItemStatusId, 0);
AttrDivisionId = ConvertToRestWithoutDefaults(s.ssDivisionId, 0L);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrPosition = (int?) s.ssPosition;
AttrMaterialCode = s.ssMaterialCode;
AttrMaterialDescription = s.ssMaterialDescription;
AttrAssigmnentCode = s.ssAssigmnentCode;
AttrDocumentClassId = (long?) s.ssDocumentClassId;
AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDeliveryDate);
AttrQuantity = (decimal?) s.ssQuantity;
AttrUnitType = s.ssUnitType;
AttrUnitPrice = (decimal?) s.ssUnitPrice;
AttrBaseQuantity = (int?) s.ssBaseQuantity;
AttrIsDeleted = (bool?) s.ssIsDeleted;
AttrIsBlocked = (bool?) s.ssIsBlocked;
AttrIsFinalDelivery = (bool?) s.ssIsFinalDelivery;
AttrGLAccountId = (long?) s.ssGLAccountId;
AttrCostCenterId = (long?) s.ssCostCenterId;
AttrFundsCenter = s.ssFundsCenter;
AttrFund = s.ssFund;
AttrCommitmentItem = s.ssCommitmentItem;
AttrVATIndicator = s.ssVATIndicator;
AttrVATProcedure = s.ssVATProcedure;
AttrVATRate = (decimal?) s.ssVATRate;
AttrPurchaseRequisitionNumber = s.ssPurchaseRequisitionNumber;
AttrPurchaseRequisitionItemNr = (int?) s.ssPurchaseRequisitionItemNr;
AttrRegionId = (long?) s.ssRegionId;
AttrCenter = s.ssCenter;
AttrPEPElement = s.ssPEPElement;
AttrQuantityDelivered = (decimal?) s.ssQuantityDelivered;
AttrOrderUnitOfMeasure = s.ssOrderUnitOfMeasure;
AttrApplicant = s.ssApplicant;
AttrDirection = s.ssDirection;
AttrContractNumber = s.ssContractNumber;
AttrContractPosition = (int?) s.ssContractPosition;
AttrContractStartDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssContractStartDate);
AttrContractEndDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssContractEndDate);
AttrContractPlannedValue = (decimal?) s.ssContractPlannedValue;
AttrPositionType = s.ssPositionType;
AttrSerialNumberProfile = s.ssSerialNumberProfile;
AttrBatchManaged = s.ssBatchManaged;
AttrMaterialType = s.ssMaterialType;
AttrItemGroup = s.ssItemGroup;
AttrOrderRequestCreatorSAPNumber = s.ssOrderRequestCreatorSAPNumber;
AttrIsMultipleImputation = (bool?) s.ssIsMultipleImputation;
AttrInvoiceUsageId = (long?) s.ssInvoiceUsageId;
AttrOrderMainItemStatusId = (int?) s.ssOrderMainItemStatusId;
AttrDivisionId = (long?) s.ssDivisionId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord obj) { 
  EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord s = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  s.ssMaterialCode = obj.AttrMaterialCode == null ? "" : obj.AttrMaterialCode;
  s.ssMaterialDescription = obj.AttrMaterialDescription == null ? "" : obj.AttrMaterialDescription;
  s.ssAssigmnentCode = obj.AttrAssigmnentCode == null ? "" : obj.AttrAssigmnentCode;
  s.ssDocumentClassId = obj.AttrDocumentClassId == null ? 0L : obj.AttrDocumentClassId.Value;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDeliveryDate);
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssUnitType = obj.AttrUnitType == null ? "" : obj.AttrUnitType;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? 0.0M : obj.AttrUnitPrice.Value;
  s.ssBaseQuantity = obj.AttrBaseQuantity == null ? 0 : obj.AttrBaseQuantity.Value;
  s.ssIsDeleted = obj.AttrIsDeleted == null ? false : obj.AttrIsDeleted.Value;
  s.ssIsBlocked = obj.AttrIsBlocked == null ? false : obj.AttrIsBlocked.Value;
  s.ssIsFinalDelivery = obj.AttrIsFinalDelivery == null ? false : obj.AttrIsFinalDelivery.Value;
  s.ssGLAccountId = obj.AttrGLAccountId == null ? 0L : obj.AttrGLAccountId.Value;
  s.ssCostCenterId = obj.AttrCostCenterId == null ? 0L : obj.AttrCostCenterId.Value;
  s.ssFundsCenter = obj.AttrFundsCenter == null ? "" : obj.AttrFundsCenter;
  s.ssFund = obj.AttrFund == null ? "" : obj.AttrFund;
  s.ssCommitmentItem = obj.AttrCommitmentItem == null ? "" : obj.AttrCommitmentItem;
  s.ssVATIndicator = obj.AttrVATIndicator == null ? "" : obj.AttrVATIndicator;
  s.ssVATProcedure = obj.AttrVATProcedure == null ? "" : obj.AttrVATProcedure;
  s.ssVATRate = obj.AttrVATRate == null ? 0.0M : obj.AttrVATRate.Value;
  s.ssPurchaseRequisitionNumber = obj.AttrPurchaseRequisitionNumber == null ? "" : obj.AttrPurchaseRequisitionNumber;
  s.ssPurchaseRequisitionItemNr = obj.AttrPurchaseRequisitionItemNr == null ? 0 : obj.AttrPurchaseRequisitionItemNr.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssCenter = obj.AttrCenter == null ? "" : obj.AttrCenter;
  s.ssPEPElement = obj.AttrPEPElement == null ? "" : obj.AttrPEPElement;
  s.ssQuantityDelivered = obj.AttrQuantityDelivered == null ? 0.0M : obj.AttrQuantityDelivered.Value;
  s.ssOrderUnitOfMeasure = obj.AttrOrderUnitOfMeasure == null ? "" : obj.AttrOrderUnitOfMeasure;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssContractNumber = obj.AttrContractNumber == null ? "" : obj.AttrContractNumber;
  s.ssContractPosition = obj.AttrContractPosition == null ? 0 : obj.AttrContractPosition.Value;
  s.ssContractStartDate = obj.AttrContractStartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrContractStartDate);
  s.ssContractEndDate = obj.AttrContractEndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrContractEndDate);
  s.ssContractPlannedValue = obj.AttrContractPlannedValue == null ? 0.0M : obj.AttrContractPlannedValue.Value;
  s.ssPositionType = obj.AttrPositionType == null ? "" : obj.AttrPositionType;
  s.ssSerialNumberProfile = obj.AttrSerialNumberProfile == null ? "" : obj.AttrSerialNumberProfile;
  s.ssBatchManaged = obj.AttrBatchManaged == null ? "" : obj.AttrBatchManaged;
  s.ssMaterialType = obj.AttrMaterialType == null ? "" : obj.AttrMaterialType;
  s.ssItemGroup = obj.AttrItemGroup == null ? "" : obj.AttrItemGroup;
  s.ssOrderRequestCreatorSAPNumber = obj.AttrOrderRequestCreatorSAPNumber == null ? "" : obj.AttrOrderRequestCreatorSAPNumber;
  s.ssIsMultipleImputation = obj.AttrIsMultipleImputation == null ? false : obj.AttrIsMultipleImputation.Value;
  s.ssInvoiceUsageId = obj.AttrInvoiceUsageId == null ? 0L : obj.AttrInvoiceUsageId.Value;
  s.ssOrderMainItemStatusId = obj.AttrOrderMainItemStatusId == null ? 0 : obj.AttrOrderMainItemStatusId.Value;
  s.ssDivisionId = obj.AttrDivisionId == null ? 0L : obj.AttrDivisionId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord, ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord FromStructure(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(s, config);
}

}


