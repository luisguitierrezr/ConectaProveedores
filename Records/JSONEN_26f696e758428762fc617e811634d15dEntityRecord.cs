using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDetail
public class JSONEN_26f696e758428762fc617e811634d15dEntityRecord : AbstractRESTStructure<EN_26f696e758428762fc617e811634d15dEntityRecord> {
[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

[JsonProperty("IsApprovalFromUserArea")]
[JsonPropertyName("IsApprovalFromUserArea")]
public bool? AttrIsApprovalFromUserArea;

[JsonProperty("ProjectAssetServiceId")]
[JsonPropertyName("ProjectAssetServiceId")]
public long? AttrProjectAssetServiceId;

[JsonProperty("ProjectAssetService")]
[JsonPropertyName("ProjectAssetService")]
public string AttrProjectAssetService;

[JsonProperty("ProjectDescription")]
[JsonPropertyName("ProjectDescription")]
public string AttrProjectDescription;

[JsonProperty("BusinessValueCategoryId")]
[JsonPropertyName("BusinessValueCategoryId")]
public long? AttrBusinessValueCategoryId;

[JsonProperty("BusinessValueSubcategoryId")]
[JsonPropertyName("BusinessValueSubcategoryId")]
public long? AttrBusinessValueSubcategoryId;

[JsonProperty("PaymentTermsId")]
[JsonPropertyName("PaymentTermsId")]
public long? AttrPaymentTermsId;

[JsonProperty("PaymentMethodId")]
[JsonPropertyName("PaymentMethodId")]
public long? AttrPaymentMethodId;

[JsonProperty("NegotiatedExchangeRate")]
[JsonPropertyName("NegotiatedExchangeRate")]
public decimal? AttrNegotiatedExchangeRate;

[JsonProperty("ContractStatus")]
[JsonPropertyName("ContractStatus")]
public int? AttrContractStatus;

[JsonProperty("DateOfCommitment")]
[JsonPropertyName("DateOfCommitment")]
public String AttrDateOfCommitment;

[JsonProperty("HasDeposit")]
[JsonPropertyName("HasDeposit")]
public bool? AttrHasDeposit;

[JsonProperty("HasInsurance")]
[JsonPropertyName("HasInsurance")]
public bool? AttrHasInsurance;

[JsonProperty("DistributionId")]
[JsonPropertyName("DistributionId")]
public int? AttrDistributionId;

[JsonProperty("HasAdvancePayment")]
[JsonPropertyName("HasAdvancePayment")]
public bool? AttrHasAdvancePayment;

[JsonProperty("RetentionRate")]
[JsonPropertyName("RetentionRate")]
public decimal? AttrRetentionRate;

[JsonProperty("HasBaseDate")]
[JsonPropertyName("HasBaseDate")]
public bool? AttrHasBaseDate;

[JsonProperty("StartBaseDate")]
[JsonPropertyName("StartBaseDate")]
public String AttrStartBaseDate;

[JsonProperty("EndBaseDate")]
[JsonPropertyName("EndBaseDate")]
public String AttrEndBaseDate;

[JsonProperty("ContractNumber")]
[JsonPropertyName("ContractNumber")]
public string AttrContractNumber;

[JsonProperty("IsRetentionApplied")]
[JsonPropertyName("IsRetentionApplied")]
public bool? AttrIsRetentionApplied;

[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public int? AttrFrequency;

[JsonProperty("Period")]
[JsonPropertyName("Period")]
public string AttrPeriod;

[JsonProperty("OrderRetentionTypeId")]
[JsonPropertyName("OrderRetentionTypeId")]
public int? AttrOrderRetentionTypeId;

[JsonProperty("PaymentOptionsId")]
[JsonPropertyName("PaymentOptionsId")]
public long? AttrPaymentOptionsId;

[JsonProperty("PaymentWaysId")]
[JsonPropertyName("PaymentWaysId")]
public long? AttrPaymentWaysId;

[JsonProperty("OrdersContract")]
[JsonPropertyName("OrdersContract")]
public string AttrOrdersContract;

[JsonProperty("ContractAmount")]
[JsonPropertyName("ContractAmount")]
public decimal? AttrContractAmount;

[JsonProperty("ContractTarif")]
[JsonPropertyName("ContractTarif")]
public decimal? AttrContractTarif;

[JsonProperty("ContractSupplier")]
[JsonPropertyName("ContractSupplier")]
public long? AttrContractSupplier;

[JsonProperty("IsDependentFromFolios")]
[JsonPropertyName("IsDependentFromFolios")]
public bool? AttrIsDependentFromFolios;

[JsonProperty("SpecialApprovalId")]
[JsonPropertyName("SpecialApprovalId")]
public int? AttrSpecialApprovalId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("AllContactFilesValidated")]
[JsonPropertyName("AllContactFilesValidated")]
public bool? AttrAllContactFilesValidated;

[JsonProperty("HasntRequestDocuments")]
[JsonPropertyName("HasntRequestDocuments")]
public bool? AttrHasntRequestDocuments;

public JSONEN_26f696e758428762fc617e811634d15dEntityRecord() { }

public JSONEN_26f696e758428762fc617e811634d15dEntityRecord (EN_26f696e758428762fc617e811634d15dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderId = (long?) s.ssOrderId;
AttrIsApprovalFromUserArea = ConvertToRestWithoutDefaults(s.ssIsApprovalFromUserArea, false);
AttrProjectAssetServiceId = ConvertToRestWithoutDefaults(s.ssProjectAssetServiceId, 0L);
AttrProjectAssetService = ConvertToRestWithoutDefaults(s.ssProjectAssetService, "");
AttrProjectDescription = ConvertToRestWithoutDefaults(s.ssProjectDescription, "");
AttrBusinessValueCategoryId = ConvertToRestWithoutDefaults(s.ssBusinessValueCategoryId, 0L);
AttrBusinessValueSubcategoryId = ConvertToRestWithoutDefaults(s.ssBusinessValueSubcategoryId, 0L);
AttrPaymentTermsId = ConvertToRestWithoutDefaults(s.ssPaymentTermsId, 0L);
AttrPaymentMethodId = ConvertToRestWithoutDefaults(s.ssPaymentMethodId, 0L);
AttrNegotiatedExchangeRate = ConvertToRestWithoutDefaults(s.ssNegotiatedExchangeRate, 0.0M);
AttrContractStatus = ConvertToRestWithoutDefaults(s.ssContractStatus, 0);
AttrDateOfCommitment = ConvertDateToRestWithoutDefaults(s.ssDateOfCommitment, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrHasDeposit = ConvertToRestWithoutDefaults(s.ssHasDeposit, false);
AttrHasInsurance = ConvertToRestWithoutDefaults(s.ssHasInsurance, false);
AttrDistributionId = ConvertToRestWithoutDefaults(s.ssDistributionId, 0);
AttrHasAdvancePayment = ConvertToRestWithoutDefaults(s.ssHasAdvancePayment, false);
AttrRetentionRate = ConvertToRestWithoutDefaults(s.ssRetentionRate, 0.0M);
AttrHasBaseDate = ConvertToRestWithoutDefaults(s.ssHasBaseDate, false);
AttrStartBaseDate = ConvertDateToRestWithoutDefaults(s.ssStartBaseDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrEndBaseDate = ConvertDateToRestWithoutDefaults(s.ssEndBaseDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrContractNumber = ConvertToRestWithoutDefaults(s.ssContractNumber, "");
AttrIsRetentionApplied = ConvertToRestWithoutDefaults(s.ssIsRetentionApplied, false);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssFrequency, 0);
AttrPeriod = ConvertToRestWithoutDefaults(s.ssPeriod, "");
AttrOrderRetentionTypeId = ConvertToRestWithoutDefaults(s.ssOrderRetentionTypeId, 0);
AttrPaymentOptionsId = ConvertToRestWithoutDefaults(s.ssPaymentOptionsId, 0L);
AttrPaymentWaysId = ConvertToRestWithoutDefaults(s.ssPaymentWaysId, 0L);
AttrOrdersContract = ConvertToRestWithoutDefaults(s.ssOrdersContract, "");
AttrContractAmount = ConvertToRestWithoutDefaults(s.ssContractAmount, 0.0M);
AttrContractTarif = ConvertToRestWithoutDefaults(s.ssContractTarif, 0.0M);
AttrContractSupplier = ConvertToRestWithoutDefaults(s.ssContractSupplier, 0L);
AttrIsDependentFromFolios = ConvertToRestWithoutDefaults(s.ssIsDependentFromFolios, false);
AttrSpecialApprovalId = ConvertToRestWithoutDefaults(s.ssSpecialApprovalId, 0);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrAllContactFilesValidated = (bool?) s.ssAllContactFilesValidated;
AttrHasntRequestDocuments = ConvertToRestWithoutDefaults(s.ssHasntRequestDocuments, false);
  } else {
AttrOrderId = (long?) s.ssOrderId;
AttrIsApprovalFromUserArea = (bool?) s.ssIsApprovalFromUserArea;
AttrProjectAssetServiceId = (long?) s.ssProjectAssetServiceId;
AttrProjectAssetService = s.ssProjectAssetService;
AttrProjectDescription = s.ssProjectDescription;
AttrBusinessValueCategoryId = (long?) s.ssBusinessValueCategoryId;
AttrBusinessValueSubcategoryId = (long?) s.ssBusinessValueSubcategoryId;
AttrPaymentTermsId = (long?) s.ssPaymentTermsId;
AttrPaymentMethodId = (long?) s.ssPaymentMethodId;
AttrNegotiatedExchangeRate = (decimal?) s.ssNegotiatedExchangeRate;
AttrContractStatus = (int?) s.ssContractStatus;
AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDateOfCommitment);
AttrHasDeposit = (bool?) s.ssHasDeposit;
AttrHasInsurance = (bool?) s.ssHasInsurance;
AttrDistributionId = (int?) s.ssDistributionId;
AttrHasAdvancePayment = (bool?) s.ssHasAdvancePayment;
AttrRetentionRate = (decimal?) s.ssRetentionRate;
AttrHasBaseDate = (bool?) s.ssHasBaseDate;
AttrStartBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssStartBaseDate);
AttrEndBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssEndBaseDate);
AttrContractNumber = s.ssContractNumber;
AttrIsRetentionApplied = (bool?) s.ssIsRetentionApplied;
AttrFrequency = (int?) s.ssFrequency;
AttrPeriod = s.ssPeriod;
AttrOrderRetentionTypeId = (int?) s.ssOrderRetentionTypeId;
AttrPaymentOptionsId = (long?) s.ssPaymentOptionsId;
AttrPaymentWaysId = (long?) s.ssPaymentWaysId;
AttrOrdersContract = s.ssOrdersContract;
AttrContractAmount = (decimal?) s.ssContractAmount;
AttrContractTarif = (decimal?) s.ssContractTarif;
AttrContractSupplier = (long?) s.ssContractSupplier;
AttrIsDependentFromFolios = (bool?) s.ssIsDependentFromFolios;
AttrSpecialApprovalId = (int?) s.ssSpecialApprovalId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrAllContactFilesValidated = (bool?) s.ssAllContactFilesValidated;
AttrHasntRequestDocuments = (bool?) s.ssHasntRequestDocuments;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord, EN_26f696e758428762fc617e811634d15dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord s) => ToStructure(s, config);
}
public static EN_26f696e758428762fc617e811634d15dEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_26f696e758428762fc617e811634d15dEntityRecord s = new EN_26f696e758428762fc617e811634d15dEntityRecord();
  if(obj != null) {
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssIsApprovalFromUserArea = obj.AttrIsApprovalFromUserArea == null ? false : obj.AttrIsApprovalFromUserArea.Value;
  s.ssProjectAssetServiceId = obj.AttrProjectAssetServiceId == null ? 0L : obj.AttrProjectAssetServiceId.Value;
  s.ssProjectAssetService = obj.AttrProjectAssetService == null ? "" : obj.AttrProjectAssetService;
  s.ssProjectDescription = obj.AttrProjectDescription == null ? "" : obj.AttrProjectDescription;
  s.ssBusinessValueCategoryId = obj.AttrBusinessValueCategoryId == null ? 0L : obj.AttrBusinessValueCategoryId.Value;
  s.ssBusinessValueSubcategoryId = obj.AttrBusinessValueSubcategoryId == null ? 0L : obj.AttrBusinessValueSubcategoryId.Value;
  s.ssPaymentTermsId = obj.AttrPaymentTermsId == null ? 0L : obj.AttrPaymentTermsId.Value;
  s.ssPaymentMethodId = obj.AttrPaymentMethodId == null ? 0L : obj.AttrPaymentMethodId.Value;
  s.ssNegotiatedExchangeRate = obj.AttrNegotiatedExchangeRate == null ? 0.0M : obj.AttrNegotiatedExchangeRate.Value;
  s.ssContractStatus = obj.AttrContractStatus == null ? 0 : obj.AttrContractStatus.Value;
  s.ssDateOfCommitment = obj.AttrDateOfCommitment == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDateOfCommitment);
  s.ssHasDeposit = obj.AttrHasDeposit == null ? false : obj.AttrHasDeposit.Value;
  s.ssHasInsurance = obj.AttrHasInsurance == null ? false : obj.AttrHasInsurance.Value;
  s.ssDistributionId = obj.AttrDistributionId == null ? 0 : obj.AttrDistributionId.Value;
  s.ssHasAdvancePayment = obj.AttrHasAdvancePayment == null ? false : obj.AttrHasAdvancePayment.Value;
  s.ssRetentionRate = obj.AttrRetentionRate == null ? 0.0M : obj.AttrRetentionRate.Value;
  s.ssHasBaseDate = obj.AttrHasBaseDate == null ? false : obj.AttrHasBaseDate.Value;
  s.ssStartBaseDate = obj.AttrStartBaseDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrStartBaseDate);
  s.ssEndBaseDate = obj.AttrEndBaseDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrEndBaseDate);
  s.ssContractNumber = obj.AttrContractNumber == null ? "" : obj.AttrContractNumber;
  s.ssIsRetentionApplied = obj.AttrIsRetentionApplied == null ? false : obj.AttrIsRetentionApplied.Value;
  s.ssFrequency = obj.AttrFrequency == null ? 0 : obj.AttrFrequency.Value;
  s.ssPeriod = obj.AttrPeriod == null ? "" : obj.AttrPeriod;
  s.ssOrderRetentionTypeId = obj.AttrOrderRetentionTypeId == null ? 0 : obj.AttrOrderRetentionTypeId.Value;
  s.ssPaymentOptionsId = obj.AttrPaymentOptionsId == null ? 0L : obj.AttrPaymentOptionsId.Value;
  s.ssPaymentWaysId = obj.AttrPaymentWaysId == null ? 0L : obj.AttrPaymentWaysId.Value;
  s.ssOrdersContract = obj.AttrOrdersContract == null ? "" : obj.AttrOrdersContract;
  s.ssContractAmount = obj.AttrContractAmount == null ? 0.0M : obj.AttrContractAmount.Value;
  s.ssContractTarif = obj.AttrContractTarif == null ? 0.0M : obj.AttrContractTarif.Value;
  s.ssContractSupplier = obj.AttrContractSupplier == null ? 0L : obj.AttrContractSupplier.Value;
  s.ssIsDependentFromFolios = obj.AttrIsDependentFromFolios == null ? false : obj.AttrIsDependentFromFolios.Value;
  s.ssSpecialApprovalId = obj.AttrSpecialApprovalId == null ? 0 : obj.AttrSpecialApprovalId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssAllContactFilesValidated = obj.AttrAllContactFilesValidated == null ? false : obj.AttrAllContactFilesValidated.Value;
  s.ssHasntRequestDocuments = obj.AttrHasntRequestDocuments == null ? false : obj.AttrHasntRequestDocuments.Value;
  }
  return s;
}

public static Func<EN_26f696e758428762fc617e811634d15dEntityRecord, ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_26f696e758428762fc617e811634d15dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord FromStructure(EN_26f696e758428762fc617e811634d15dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord(s, config);
}

}


