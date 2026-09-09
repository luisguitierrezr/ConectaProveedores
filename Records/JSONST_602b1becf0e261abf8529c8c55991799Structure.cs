using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemLine
public class JSONST_602b1becf0e261abf8529c8c55991799Structure : AbstractRESTStructure<ST_602b1becf0e261abf8529c8c55991799Structure> {
[JsonProperty("Position")]
[JsonPropertyName("Position")]
public int? AttrPosition;

[JsonProperty("ArticleNr")]
[JsonPropertyName("ArticleNr")]
public string AttrArticleNr;

[JsonProperty("ArticleDescription")]
[JsonPropertyName("ArticleDescription")]
public string AttrArticleDescription;

[JsonProperty("ImputationCode")]
[JsonPropertyName("ImputationCode")]
public string AttrImputationCode;

[JsonProperty("DocumentClass")]
[JsonPropertyName("DocumentClass")]
public string AttrDocumentClass;

[JsonProperty("DeliveryDate")]
[JsonPropertyName("DeliveryDate")]
public string AttrDeliveryDate;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("UnitType")]
[JsonPropertyName("UnitType")]
public string AttrUnitType;

[JsonProperty("UnitPrice")]
[JsonPropertyName("UnitPrice")]
public decimal? AttrUnitPrice;

[JsonProperty("BaseQuantity")]
[JsonPropertyName("BaseQuantity")]
public int? AttrBaseQuantity;

[JsonProperty("ChangeIndicator")]
[JsonPropertyName("ChangeIndicator")]
public string AttrChangeIndicator;

[JsonProperty("FinalDelivery")]
[JsonPropertyName("FinalDelivery")]
public string AttrFinalDelivery;

[JsonProperty("GLAccountNumber")]
[JsonPropertyName("GLAccountNumber")]
public string AttrGLAccountNumber;

[JsonProperty("CostCenter")]
[JsonPropertyName("CostCenter")]
public string AttrCostCenter;

[JsonProperty("FundsCenter")]
[JsonPropertyName("FundsCenter")]
public string AttrFundsCenter;

[JsonProperty("Fund")]
[JsonPropertyName("Fund")]
public string AttrFund;

[JsonProperty("CommitmentItem")]
[JsonPropertyName("CommitmentItem")]
public string AttrCommitmentItem;

[JsonProperty("VATIndicator")]
[JsonPropertyName("VATIndicator")]
public string AttrVATIndicator;

[JsonProperty("VATProcedure")]
[JsonPropertyName("VATProcedure")]
public string AttrVATProcedure;

[JsonProperty("VATRate")]
[JsonPropertyName("VATRate")]
public decimal? AttrVATRate;

[JsonProperty("PurchaseRequisitionNumber")]
[JsonPropertyName("PurchaseRequisitionNumber")]
public string AttrPurchaseRequisitionNumber;

[JsonProperty("PurchaseRequisitionItemNumber")]
[JsonPropertyName("PurchaseRequisitionItemNumber")]
public int? AttrPurchaseRequisitionItemNumber;

[JsonProperty("BusinessArea")]
[JsonPropertyName("BusinessArea")]
public string AttrBusinessArea;

[JsonProperty("Center")]
[JsonPropertyName("Center")]
public string AttrCenter;

[JsonProperty("PEPElement")]
[JsonPropertyName("PEPElement")]
public string AttrPEPElement;

[JsonProperty("DeliveredQuantity")]
[JsonPropertyName("DeliveredQuantity")]
public decimal? AttrDeliveredQuantity;

[JsonProperty("UMP")]
[JsonPropertyName("UMP")]
public string AttrUMP;

[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public string AttrApplicant;

[JsonProperty("Direction")]
[JsonPropertyName("Direction")]
public string AttrDirection;

[JsonProperty("ContractNumber")]
[JsonPropertyName("ContractNumber")]
public string AttrContractNumber;

[JsonProperty("ContractPosition")]
[JsonPropertyName("ContractPosition")]
public int? AttrContractPosition;

[JsonProperty("ContractStartDate")]
[JsonPropertyName("ContractStartDate")]
public string AttrContractStartDate;

[JsonProperty("ContractEndDate")]
[JsonPropertyName("ContractEndDate")]
public string AttrContractEndDate;

[JsonProperty("ContractPlannedValue")]
[JsonPropertyName("ContractPlannedValue")]
public decimal? AttrContractPlannedValue;

[JsonProperty("PositionType")]
[JsonPropertyName("PositionType")]
public string AttrPositionType;

[JsonProperty("SerialNumberProfile")]
[JsonPropertyName("SerialNumberProfile")]
public string AttrSerialNumberProfile;

[JsonProperty("BatchManaged")]
[JsonPropertyName("BatchManaged")]
public string AttrBatchManaged;

[JsonProperty("MaterialType")]
[JsonPropertyName("MaterialType")]
public string AttrMaterialType;

[JsonProperty("ItemGroup")]
[JsonPropertyName("ItemGroup")]
public string AttrItemGroup;

[JsonProperty("CreatingUser")]
[JsonPropertyName("CreatingUser")]
public string AttrCreatingUser;

public JSONST_602b1becf0e261abf8529c8c55991799Structure() { }

public JSONST_602b1becf0e261abf8529c8c55991799Structure (ST_602b1becf0e261abf8529c8c55991799Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = (int?) s.ssPosition;
AttrArticleNr = ConvertToRestWithoutDefaults(s.ssArticleNr, "");
AttrArticleDescription = ConvertToRestWithoutDefaults(s.ssArticleDescription, "");
AttrImputationCode = ConvertToRestWithoutDefaults(s.ssImputationCode, "");
AttrDocumentClass = ConvertToRestWithoutDefaults(s.ssDocumentClass, "");
AttrDeliveryDate = ConvertToRestWithoutDefaults(s.ssDeliveryDate, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrUnitType = ConvertToRestWithoutDefaults(s.ssUnitType, "");
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, 0.0M);
AttrBaseQuantity = ConvertToRestWithoutDefaults(s.ssBaseQuantity, 0);
AttrChangeIndicator = ConvertToRestWithoutDefaults(s.ssChangeIndicator, "False");
AttrFinalDelivery = ConvertToRestWithoutDefaults(s.ssFinalDelivery, "False");
AttrGLAccountNumber = ConvertToRestWithoutDefaults(s.ssGLAccountNumber, "");
AttrCostCenter = ConvertToRestWithoutDefaults(s.ssCostCenter, "");
AttrFundsCenter = ConvertToRestWithoutDefaults(s.ssFundsCenter, "");
AttrFund = ConvertToRestWithoutDefaults(s.ssFund, "");
AttrCommitmentItem = ConvertToRestWithoutDefaults(s.ssCommitmentItem, "");
AttrVATIndicator = ConvertToRestWithoutDefaults(s.ssVATIndicator, "");
AttrVATProcedure = ConvertToRestWithoutDefaults(s.ssVATProcedure, "");
AttrVATRate = ConvertToRestWithoutDefaults(s.ssVATRate, 0.0M);
AttrPurchaseRequisitionNumber = ConvertToRestWithoutDefaults(s.ssPurchaseRequisitionNumber, "");
AttrPurchaseRequisitionItemNumber = ConvertToRestWithoutDefaults(s.ssPurchaseRequisitionItemNumber, 0);
AttrBusinessArea = ConvertToRestWithoutDefaults(s.ssBusinessArea, "");
AttrCenter = ConvertToRestWithoutDefaults(s.ssCenter, "");
AttrPEPElement = ConvertToRestWithoutDefaults(s.ssPEPElement, "");
AttrDeliveredQuantity = ConvertToRestWithoutDefaults(s.ssDeliveredQuantity, 0.0M);
AttrUMP = ConvertToRestWithoutDefaults(s.ssUMP, "");
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrContractNumber = ConvertToRestWithoutDefaults(s.ssContractNumber, "");
AttrContractPosition = ConvertToRestWithoutDefaults(s.ssContractPosition, 0);
AttrContractStartDate = ConvertToRestWithoutDefaults(s.ssContractStartDate, "");
AttrContractEndDate = ConvertToRestWithoutDefaults(s.ssContractEndDate, "");
AttrContractPlannedValue = ConvertToRestWithoutDefaults(s.ssContractPlannedValue, 0.0M);
AttrPositionType = ConvertToRestWithoutDefaults(s.ssPositionType, "");
AttrSerialNumberProfile = ConvertToRestWithoutDefaults(s.ssSerialNumberProfile, "");
AttrBatchManaged = ConvertToRestWithoutDefaults(s.ssBatchManaged, "");
AttrMaterialType = ConvertToRestWithoutDefaults(s.ssMaterialType, "");
AttrItemGroup = ConvertToRestWithoutDefaults(s.ssItemGroup, "");
AttrCreatingUser = ConvertToRestWithoutDefaults(s.ssCreatingUser, "");
  } else {
AttrPosition = (int?) s.ssPosition;
AttrArticleNr = s.ssArticleNr;
AttrArticleDescription = s.ssArticleDescription;
AttrImputationCode = s.ssImputationCode;
AttrDocumentClass = s.ssDocumentClass;
AttrDeliveryDate = s.ssDeliveryDate;
AttrQuantity = (decimal?) s.ssQuantity;
AttrUnitType = s.ssUnitType;
AttrUnitPrice = (decimal?) s.ssUnitPrice;
AttrBaseQuantity = (int?) s.ssBaseQuantity;
AttrChangeIndicator = s.ssChangeIndicator;
AttrFinalDelivery = s.ssFinalDelivery;
AttrGLAccountNumber = s.ssGLAccountNumber;
AttrCostCenter = s.ssCostCenter;
AttrFundsCenter = s.ssFundsCenter;
AttrFund = s.ssFund;
AttrCommitmentItem = s.ssCommitmentItem;
AttrVATIndicator = s.ssVATIndicator;
AttrVATProcedure = s.ssVATProcedure;
AttrVATRate = (decimal?) s.ssVATRate;
AttrPurchaseRequisitionNumber = s.ssPurchaseRequisitionNumber;
AttrPurchaseRequisitionItemNumber = (int?) s.ssPurchaseRequisitionItemNumber;
AttrBusinessArea = s.ssBusinessArea;
AttrCenter = s.ssCenter;
AttrPEPElement = s.ssPEPElement;
AttrDeliveredQuantity = (decimal?) s.ssDeliveredQuantity;
AttrUMP = s.ssUMP;
AttrApplicant = s.ssApplicant;
AttrDirection = s.ssDirection;
AttrContractNumber = s.ssContractNumber;
AttrContractPosition = (int?) s.ssContractPosition;
AttrContractStartDate = s.ssContractStartDate;
AttrContractEndDate = s.ssContractEndDate;
AttrContractPlannedValue = (decimal?) s.ssContractPlannedValue;
AttrPositionType = s.ssPositionType;
AttrSerialNumberProfile = s.ssSerialNumberProfile;
AttrBatchManaged = s.ssBatchManaged;
AttrMaterialType = s.ssMaterialType;
AttrItemGroup = s.ssItemGroup;
AttrCreatingUser = s.ssCreatingUser;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure, ST_602b1becf0e261abf8529c8c55991799Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure s) => ToStructure(s, config);
}
public static ST_602b1becf0e261abf8529c8c55991799Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure obj, IBehaviorsConfiguration config) { 
  ST_602b1becf0e261abf8529c8c55991799Structure s = new ST_602b1becf0e261abf8529c8c55991799Structure();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  s.ssArticleNr = obj.AttrArticleNr == null ? "" : obj.AttrArticleNr;
  s.ssArticleDescription = obj.AttrArticleDescription == null ? "" : obj.AttrArticleDescription;
  s.ssImputationCode = obj.AttrImputationCode == null ? "" : obj.AttrImputationCode;
  s.ssDocumentClass = obj.AttrDocumentClass == null ? "" : obj.AttrDocumentClass;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? "" : obj.AttrDeliveryDate;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssUnitType = obj.AttrUnitType == null ? "" : obj.AttrUnitType;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? 0.0M : obj.AttrUnitPrice.Value;
  s.ssBaseQuantity = obj.AttrBaseQuantity == null ? 0 : obj.AttrBaseQuantity.Value;
  s.ssChangeIndicator = obj.AttrChangeIndicator == null ? "False" : obj.AttrChangeIndicator;
  s.ssFinalDelivery = obj.AttrFinalDelivery == null ? "False" : obj.AttrFinalDelivery;
  s.ssGLAccountNumber = obj.AttrGLAccountNumber == null ? "" : obj.AttrGLAccountNumber;
  s.ssCostCenter = obj.AttrCostCenter == null ? "" : obj.AttrCostCenter;
  s.ssFundsCenter = obj.AttrFundsCenter == null ? "" : obj.AttrFundsCenter;
  s.ssFund = obj.AttrFund == null ? "" : obj.AttrFund;
  s.ssCommitmentItem = obj.AttrCommitmentItem == null ? "" : obj.AttrCommitmentItem;
  s.ssVATIndicator = obj.AttrVATIndicator == null ? "" : obj.AttrVATIndicator;
  s.ssVATProcedure = obj.AttrVATProcedure == null ? "" : obj.AttrVATProcedure;
  s.ssVATRate = obj.AttrVATRate == null ? 0.0M : obj.AttrVATRate.Value;
  s.ssPurchaseRequisitionNumber = obj.AttrPurchaseRequisitionNumber == null ? "" : obj.AttrPurchaseRequisitionNumber;
  s.ssPurchaseRequisitionItemNumber = obj.AttrPurchaseRequisitionItemNumber == null ? 0 : obj.AttrPurchaseRequisitionItemNumber.Value;
  s.ssBusinessArea = obj.AttrBusinessArea == null ? "" : obj.AttrBusinessArea;
  s.ssCenter = obj.AttrCenter == null ? "" : obj.AttrCenter;
  s.ssPEPElement = obj.AttrPEPElement == null ? "" : obj.AttrPEPElement;
  s.ssDeliveredQuantity = obj.AttrDeliveredQuantity == null ? 0.0M : obj.AttrDeliveredQuantity.Value;
  s.ssUMP = obj.AttrUMP == null ? "" : obj.AttrUMP;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssContractNumber = obj.AttrContractNumber == null ? "" : obj.AttrContractNumber;
  s.ssContractPosition = obj.AttrContractPosition == null ? 0 : obj.AttrContractPosition.Value;
  s.ssContractStartDate = obj.AttrContractStartDate == null ? "" : obj.AttrContractStartDate;
  s.ssContractEndDate = obj.AttrContractEndDate == null ? "" : obj.AttrContractEndDate;
  s.ssContractPlannedValue = obj.AttrContractPlannedValue == null ? 0.0M : obj.AttrContractPlannedValue.Value;
  s.ssPositionType = obj.AttrPositionType == null ? "" : obj.AttrPositionType;
  s.ssSerialNumberProfile = obj.AttrSerialNumberProfile == null ? "" : obj.AttrSerialNumberProfile;
  s.ssBatchManaged = obj.AttrBatchManaged == null ? "" : obj.AttrBatchManaged;
  s.ssMaterialType = obj.AttrMaterialType == null ? "" : obj.AttrMaterialType;
  s.ssItemGroup = obj.AttrItemGroup == null ? "" : obj.AttrItemGroup;
  s.ssCreatingUser = obj.AttrCreatingUser == null ? "" : obj.AttrCreatingUser;
  }
  return s;
}

public static Func<ST_602b1becf0e261abf8529c8c55991799Structure, ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_602b1becf0e261abf8529c8c55991799Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure FromStructure(ST_602b1becf0e261abf8529c8c55991799Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure(s, config);
}

}


