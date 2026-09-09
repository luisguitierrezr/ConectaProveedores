using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Requisition
public class JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord : AbstractRESTStructure<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Counter")]
[JsonPropertyName("Counter")]
public int? AttrCounter;

[JsonProperty("RequisitionStatusId")]
[JsonPropertyName("RequisitionStatusId")]
public int? AttrRequisitionStatusId;

[JsonProperty("SupplierId")]
[JsonPropertyName("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("AccountingRegionId")]
[JsonPropertyName("AccountingRegionId")]
public long? AttrAccountingRegionId;

[JsonProperty("ApplicantId")]
[JsonPropertyName("ApplicantId")]
public string AttrApplicantId;

[JsonProperty("MaxDateFinishCapture")]
[JsonPropertyName("MaxDateFinishCapture")]
public String AttrMaxDateFinishCapture;

[JsonProperty("ProjectAssetServiceId")]
[JsonPropertyName("ProjectAssetServiceId")]
public long? AttrProjectAssetServiceId;

[JsonProperty("ProjectAssetService")]
[JsonPropertyName("ProjectAssetService")]
public string AttrProjectAssetService;

[JsonProperty("ProjectDescription")]
[JsonPropertyName("ProjectDescription")]
public string AttrProjectDescription;

[JsonProperty("FrequencyId")]
[JsonPropertyName("FrequencyId")]
public int? AttrFrequencyId;

[JsonProperty("IsSustainability")]
[JsonPropertyName("IsSustainability")]
public bool? AttrIsSustainability;

[JsonProperty("SustainabilityId")]
[JsonPropertyName("SustainabilityId")]
public long? AttrSustainabilityId;

[JsonProperty("BusinessValueCategoryId")]
[JsonPropertyName("BusinessValueCategoryId")]
public long? AttrBusinessValueCategoryId;

[JsonProperty("BusinessValueSubcategoryId")]
[JsonPropertyName("BusinessValueSubcategoryId")]
public long? AttrBusinessValueSubcategoryId;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("DistributionId")]
[JsonPropertyName("DistributionId")]
public int? AttrDistributionId;

[JsonProperty("CostCenterId")]
[JsonPropertyName("CostCenterId")]
public long? AttrCostCenterId;

[JsonProperty("HasContract")]
[JsonPropertyName("HasContract")]
public bool? AttrHasContract;

[JsonProperty("IsContractPending")]
[JsonPropertyName("IsContractPending")]
public bool? AttrIsContractPending;

[JsonProperty("HasDeposit")]
[JsonPropertyName("HasDeposit")]
public bool? AttrHasDeposit;

[JsonProperty("HasInsurance")]
[JsonPropertyName("HasInsurance")]
public bool? AttrHasInsurance;

[JsonProperty("HasAdvancePayment")]
[JsonPropertyName("HasAdvancePayment")]
public bool? AttrHasAdvancePayment;

[JsonProperty("AccountingServiceTypeId_DEPR")]
[JsonPropertyName("AccountingServiceTypeId_DEPR")]
public long? AttrAccountingServiceTypeId_DEPR;

[JsonProperty("ServiceDescription_DEPREC")]
[JsonPropertyName("ServiceDescription_DEPREC")]
public string AttrServiceDescription_DEPREC;

[JsonProperty("InvoiceUsageId_DEPREC")]
[JsonPropertyName("InvoiceUsageId_DEPREC")]
public long? AttrInvoiceUsageId_DEPREC;

[JsonProperty("ServiceFormatId")]
[JsonPropertyName("ServiceFormatId")]
public long? AttrServiceFormatId;

[JsonProperty("CompanyId")]
[JsonPropertyName("CompanyId")]
public long? AttrCompanyId;

[JsonProperty("RetentionRate")]
[JsonPropertyName("RetentionRate")]
public decimal? AttrRetentionRate;

[JsonProperty("NegotiatedExchangeRate")]
[JsonPropertyName("NegotiatedExchangeRate")]
public decimal? AttrNegotiatedExchangeRate;

[JsonProperty("PaymentMethodId")]
[JsonPropertyName("PaymentMethodId")]
public long? AttrPaymentMethodId;

[JsonProperty("PaymentTermsId")]
[JsonPropertyName("PaymentTermsId")]
public long? AttrPaymentTermsId;

[JsonProperty("IsAutomaticAccounting")]
[JsonPropertyName("IsAutomaticAccounting")]
public bool? AttrIsAutomaticAccounting;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("CreatedByApplicationRole")]
[JsonPropertyName("CreatedByApplicationRole")]
public long? AttrCreatedByApplicationRole;

[JsonProperty("DateOfCommitment")]
[JsonPropertyName("DateOfCommitment")]
public String AttrDateOfCommitment;

[JsonProperty("HasContractFileUploaded")]
[JsonPropertyName("HasContractFileUploaded")]
public bool? AttrHasContractFileUploaded;

[JsonProperty("HasUpdatedDateOfCommitment")]
[JsonPropertyName("HasUpdatedDateOfCommitment")]
public bool? AttrHasUpdatedDateOfCommitment;

[JsonProperty("SubmittedOn")]
[JsonPropertyName("SubmittedOn")]
public String AttrSubmittedOn;

[JsonProperty("IsDonation")]
[JsonPropertyName("IsDonation")]
public bool? AttrIsDonation;

[JsonProperty("AdvWithoutInvoice")]
[JsonPropertyName("AdvWithoutInvoice")]
public bool? AttrAdvWithoutInvoice;

[JsonProperty("WasAdvWithoutInvoice")]
[JsonPropertyName("WasAdvWithoutInvoice")]
public bool? AttrWasAdvWithoutInvoice;

[JsonProperty("IsAdvanced")]
[JsonPropertyName("IsAdvanced")]
public bool? AttrIsAdvanced;

[JsonProperty("DocumentTypeId")]
[JsonPropertyName("DocumentTypeId")]
public long? AttrDocumentTypeId;

[JsonProperty("IsCreatedByAnAssistente")]
[JsonPropertyName("IsCreatedByAnAssistente")]
public bool? AttrIsCreatedByAnAssistente;

[JsonProperty("TelcelDirectionId")]
[JsonPropertyName("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

[JsonProperty("HasMultiUpload")]
[JsonPropertyName("HasMultiUpload")]
public bool? AttrHasMultiUpload;

[JsonProperty("AccountingDate")]
[JsonPropertyName("AccountingDate")]
public String AttrAccountingDate;

[JsonProperty("PaymentOptionsId")]
[JsonPropertyName("PaymentOptionsId")]
public long? AttrPaymentOptionsId;

[JsonProperty("PaymentWaysId")]
[JsonPropertyName("PaymentWaysId")]
public long? AttrPaymentWaysId;

[JsonProperty("BuyDocNumber")]
[JsonPropertyName("BuyDocNumber")]
public string AttrBuyDocNumber;

[JsonProperty("BuyDocPosition")]
[JsonPropertyName("BuyDocPosition")]
public string AttrBuyDocPosition;

public JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord() { }

public JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrCounter = ConvertToRestWithoutDefaults(s.ssCounter, 0);
AttrRequisitionStatusId = ConvertToRestWithoutDefaults(s.ssRequisitionStatusId, 0);
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrAccountingRegionId = ConvertToRestWithoutDefaults(s.ssAccountingRegionId, 0L);
AttrApplicantId = ConvertToRestWithoutDefaults(s.ssApplicantId, "");
AttrMaxDateFinishCapture = ConvertDateTimeToRestWithoutDefaults(s.ssMaxDateFinishCapture, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrProjectAssetServiceId = ConvertToRestWithoutDefaults(s.ssProjectAssetServiceId, 0L);
AttrProjectAssetService = ConvertToRestWithoutDefaults(s.ssProjectAssetService, "");
AttrProjectDescription = ConvertToRestWithoutDefaults(s.ssProjectDescription, "");
AttrFrequencyId = ConvertToRestWithoutDefaults(s.ssFrequencyId, 0);
AttrIsSustainability = ConvertToRestWithoutDefaults(s.ssIsSustainability, false);
AttrSustainabilityId = ConvertToRestWithoutDefaults(s.ssSustainabilityId, 0L);
AttrBusinessValueCategoryId = ConvertToRestWithoutDefaults(s.ssBusinessValueCategoryId, 0L);
AttrBusinessValueSubcategoryId = ConvertToRestWithoutDefaults(s.ssBusinessValueSubcategoryId, 0L);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrDistributionId = ConvertToRestWithoutDefaults(s.ssDistributionId, 0);
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssCostCenterId, 0L);
AttrHasContract = ConvertToRestWithoutDefaults(s.ssHasContract, false);
AttrIsContractPending = ConvertToRestWithoutDefaults(s.ssIsContractPending, false);
AttrHasDeposit = ConvertToRestWithoutDefaults(s.ssHasDeposit, false);
AttrHasInsurance = ConvertToRestWithoutDefaults(s.ssHasInsurance, false);
AttrHasAdvancePayment = ConvertToRestWithoutDefaults(s.ssHasAdvancePayment, false);
AttrAccountingServiceTypeId_DEPR = ConvertToRestWithoutDefaults(s.ssAccountingServiceTypeId_DEPR, 0L);
AttrServiceDescription_DEPREC = ConvertToRestWithoutDefaults(s.ssServiceDescription_DEPREC, "");
AttrInvoiceUsageId_DEPREC = ConvertToRestWithoutDefaults(s.ssInvoiceUsageId_DEPREC, 0L);
AttrServiceFormatId = ConvertToRestWithoutDefaults(s.ssServiceFormatId, 0L);
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssCompanyId, 0L);
AttrRetentionRate = ConvertToRestWithoutDefaults(s.ssRetentionRate, 0.0M);
AttrNegotiatedExchangeRate = ConvertToRestWithoutDefaults(s.ssNegotiatedExchangeRate, 0.0M);
AttrPaymentMethodId = ConvertToRestWithoutDefaults(s.ssPaymentMethodId, 0L);
AttrPaymentTermsId = ConvertToRestWithoutDefaults(s.ssPaymentTermsId, 0L);
AttrIsAutomaticAccounting = ConvertToRestWithoutDefaults(s.ssIsAutomaticAccounting, false);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrCreatedByApplicationRole = ConvertToRestWithoutDefaults(s.ssCreatedByApplicationRole, 0L);
AttrDateOfCommitment = ConvertDateToRestWithoutDefaults(s.ssDateOfCommitment, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrHasContractFileUploaded = ConvertToRestWithoutDefaults(s.ssHasContractFileUploaded, false);
AttrHasUpdatedDateOfCommitment = ConvertToRestWithoutDefaults(s.ssHasUpdatedDateOfCommitment, false);
AttrSubmittedOn = ConvertDateToRestWithoutDefaults(s.ssSubmittedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrIsDonation = ConvertToRestWithoutDefaults(s.ssIsDonation, false);
AttrAdvWithoutInvoice = ConvertToRestWithoutDefaults(s.ssAdvWithoutInvoice, false);
AttrWasAdvWithoutInvoice = (bool?) s.ssWasAdvWithoutInvoice;
AttrIsAdvanced = ConvertToRestWithoutDefaults(s.ssIsAdvanced, false);
AttrDocumentTypeId = ConvertToRestWithoutDefaults(s.ssDocumentTypeId, 0L);
AttrIsCreatedByAnAssistente = ConvertToRestWithoutDefaults(s.ssIsCreatedByAnAssistente, false);
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
AttrHasMultiUpload = ConvertToRestWithoutDefaults(s.ssHasMultiUpload, false);
AttrAccountingDate = ConvertDateToRestWithoutDefaults(s.ssAccountingDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrPaymentOptionsId = ConvertToRestWithoutDefaults(s.ssPaymentOptionsId, 0L);
AttrPaymentWaysId = ConvertToRestWithoutDefaults(s.ssPaymentWaysId, 0L);
AttrBuyDocNumber = ConvertToRestWithoutDefaults(s.ssBuyDocNumber, "");
AttrBuyDocPosition = ConvertToRestWithoutDefaults(s.ssBuyDocPosition, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrCounter = (int?) s.ssCounter;
AttrRequisitionStatusId = (int?) s.ssRequisitionStatusId;
AttrSupplierId = (long?) s.ssSupplierId;
AttrRegionId = (long?) s.ssRegionId;
AttrAccountingRegionId = (long?) s.ssAccountingRegionId;
AttrApplicantId = s.ssApplicantId;
AttrMaxDateFinishCapture = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMaxDateFinishCapture, config.DateTimeFormat);
AttrProjectAssetServiceId = (long?) s.ssProjectAssetServiceId;
AttrProjectAssetService = s.ssProjectAssetService;
AttrProjectDescription = s.ssProjectDescription;
AttrFrequencyId = (int?) s.ssFrequencyId;
AttrIsSustainability = (bool?) s.ssIsSustainability;
AttrSustainabilityId = (long?) s.ssSustainabilityId;
AttrBusinessValueCategoryId = (long?) s.ssBusinessValueCategoryId;
AttrBusinessValueSubcategoryId = (long?) s.ssBusinessValueSubcategoryId;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrCurrencyId = s.ssCurrencyId;
AttrDistributionId = (int?) s.ssDistributionId;
AttrCostCenterId = (long?) s.ssCostCenterId;
AttrHasContract = (bool?) s.ssHasContract;
AttrIsContractPending = (bool?) s.ssIsContractPending;
AttrHasDeposit = (bool?) s.ssHasDeposit;
AttrHasInsurance = (bool?) s.ssHasInsurance;
AttrHasAdvancePayment = (bool?) s.ssHasAdvancePayment;
AttrAccountingServiceTypeId_DEPR = (long?) s.ssAccountingServiceTypeId_DEPR;
AttrServiceDescription_DEPREC = s.ssServiceDescription_DEPREC;
AttrInvoiceUsageId_DEPREC = (long?) s.ssInvoiceUsageId_DEPREC;
AttrServiceFormatId = (long?) s.ssServiceFormatId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrRetentionRate = (decimal?) s.ssRetentionRate;
AttrNegotiatedExchangeRate = (decimal?) s.ssNegotiatedExchangeRate;
AttrPaymentMethodId = (long?) s.ssPaymentMethodId;
AttrPaymentTermsId = (long?) s.ssPaymentTermsId;
AttrIsAutomaticAccounting = (bool?) s.ssIsAutomaticAccounting;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrCreatedByApplicationRole = (long?) s.ssCreatedByApplicationRole;
AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDateOfCommitment);
AttrHasContractFileUploaded = (bool?) s.ssHasContractFileUploaded;
AttrHasUpdatedDateOfCommitment = (bool?) s.ssHasUpdatedDateOfCommitment;
AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssSubmittedOn);
AttrIsDonation = (bool?) s.ssIsDonation;
AttrAdvWithoutInvoice = (bool?) s.ssAdvWithoutInvoice;
AttrWasAdvWithoutInvoice = (bool?) s.ssWasAdvWithoutInvoice;
AttrIsAdvanced = (bool?) s.ssIsAdvanced;
AttrDocumentTypeId = (long?) s.ssDocumentTypeId;
AttrIsCreatedByAnAssistente = (bool?) s.ssIsCreatedByAnAssistente;
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
AttrHasMultiUpload = (bool?) s.ssHasMultiUpload;
AttrAccountingDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAccountingDate);
AttrPaymentOptionsId = (long?) s.ssPaymentOptionsId;
AttrPaymentWaysId = (long?) s.ssPaymentWaysId;
AttrBuyDocNumber = s.ssBuyDocNumber;
AttrBuyDocPosition = s.ssBuyDocPosition;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord s) => ToStructure(s, config);
}
public static EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_98680591dcf3728e0877a90eb5e1e552EntityRecord s = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssCounter = obj.AttrCounter == null ? 0 : obj.AttrCounter.Value;
  s.ssRequisitionStatusId = obj.AttrRequisitionStatusId == null ? 0 : obj.AttrRequisitionStatusId.Value;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssAccountingRegionId = obj.AttrAccountingRegionId == null ? 0L : obj.AttrAccountingRegionId.Value;
  s.ssApplicantId = obj.AttrApplicantId == null ? "" : obj.AttrApplicantId;
  s.ssMaxDateFinishCapture = obj.AttrMaxDateFinishCapture == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMaxDateFinishCapture, config.DateTimeFormat);
  s.ssProjectAssetServiceId = obj.AttrProjectAssetServiceId == null ? 0L : obj.AttrProjectAssetServiceId.Value;
  s.ssProjectAssetService = obj.AttrProjectAssetService == null ? "" : obj.AttrProjectAssetService;
  s.ssProjectDescription = obj.AttrProjectDescription == null ? "" : obj.AttrProjectDescription;
  s.ssFrequencyId = obj.AttrFrequencyId == null ? 0 : obj.AttrFrequencyId.Value;
  s.ssIsSustainability = obj.AttrIsSustainability == null ? false : obj.AttrIsSustainability.Value;
  s.ssSustainabilityId = obj.AttrSustainabilityId == null ? 0L : obj.AttrSustainabilityId.Value;
  s.ssBusinessValueCategoryId = obj.AttrBusinessValueCategoryId == null ? 0L : obj.AttrBusinessValueCategoryId.Value;
  s.ssBusinessValueSubcategoryId = obj.AttrBusinessValueSubcategoryId == null ? 0L : obj.AttrBusinessValueSubcategoryId.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssDistributionId = obj.AttrDistributionId == null ? 0 : obj.AttrDistributionId.Value;
  s.ssCostCenterId = obj.AttrCostCenterId == null ? 0L : obj.AttrCostCenterId.Value;
  s.ssHasContract = obj.AttrHasContract == null ? false : obj.AttrHasContract.Value;
  s.ssIsContractPending = obj.AttrIsContractPending == null ? false : obj.AttrIsContractPending.Value;
  s.ssHasDeposit = obj.AttrHasDeposit == null ? false : obj.AttrHasDeposit.Value;
  s.ssHasInsurance = obj.AttrHasInsurance == null ? false : obj.AttrHasInsurance.Value;
  s.ssHasAdvancePayment = obj.AttrHasAdvancePayment == null ? false : obj.AttrHasAdvancePayment.Value;
  s.ssAccountingServiceTypeId_DEPR = obj.AttrAccountingServiceTypeId_DEPR == null ? 0L : obj.AttrAccountingServiceTypeId_DEPR.Value;
  s.ssServiceDescription_DEPREC = obj.AttrServiceDescription_DEPREC == null ? "" : obj.AttrServiceDescription_DEPREC;
  s.ssInvoiceUsageId_DEPREC = obj.AttrInvoiceUsageId_DEPREC == null ? 0L : obj.AttrInvoiceUsageId_DEPREC.Value;
  s.ssServiceFormatId = obj.AttrServiceFormatId == null ? 0L : obj.AttrServiceFormatId.Value;
  s.ssCompanyId = obj.AttrCompanyId == null ? 0L : obj.AttrCompanyId.Value;
  s.ssRetentionRate = obj.AttrRetentionRate == null ? 0.0M : obj.AttrRetentionRate.Value;
  s.ssNegotiatedExchangeRate = obj.AttrNegotiatedExchangeRate == null ? 0.0M : obj.AttrNegotiatedExchangeRate.Value;
  s.ssPaymentMethodId = obj.AttrPaymentMethodId == null ? 0L : obj.AttrPaymentMethodId.Value;
  s.ssPaymentTermsId = obj.AttrPaymentTermsId == null ? 0L : obj.AttrPaymentTermsId.Value;
  s.ssIsAutomaticAccounting = obj.AttrIsAutomaticAccounting == null ? false : obj.AttrIsAutomaticAccounting.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssCreatedByApplicationRole = obj.AttrCreatedByApplicationRole == null ? 0L : obj.AttrCreatedByApplicationRole.Value;
  s.ssDateOfCommitment = obj.AttrDateOfCommitment == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDateOfCommitment);
  s.ssHasContractFileUploaded = obj.AttrHasContractFileUploaded == null ? false : obj.AttrHasContractFileUploaded.Value;
  s.ssHasUpdatedDateOfCommitment = obj.AttrHasUpdatedDateOfCommitment == null ? false : obj.AttrHasUpdatedDateOfCommitment.Value;
  s.ssSubmittedOn = obj.AttrSubmittedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrSubmittedOn);
  s.ssIsDonation = obj.AttrIsDonation == null ? false : obj.AttrIsDonation.Value;
  s.ssAdvWithoutInvoice = obj.AttrAdvWithoutInvoice == null ? false : obj.AttrAdvWithoutInvoice.Value;
  s.ssWasAdvWithoutInvoice = obj.AttrWasAdvWithoutInvoice == null ? false : obj.AttrWasAdvWithoutInvoice.Value;
  s.ssIsAdvanced = obj.AttrIsAdvanced == null ? false : obj.AttrIsAdvanced.Value;
  s.ssDocumentTypeId = obj.AttrDocumentTypeId == null ? 0L : obj.AttrDocumentTypeId.Value;
  s.ssIsCreatedByAnAssistente = obj.AttrIsCreatedByAnAssistente == null ? false : obj.AttrIsCreatedByAnAssistente.Value;
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  s.ssHasMultiUpload = obj.AttrHasMultiUpload == null ? false : obj.AttrHasMultiUpload.Value;
  s.ssAccountingDate = obj.AttrAccountingDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAccountingDate);
  s.ssPaymentOptionsId = obj.AttrPaymentOptionsId == null ? 0L : obj.AttrPaymentOptionsId.Value;
  s.ssPaymentWaysId = obj.AttrPaymentWaysId == null ? 0L : obj.AttrPaymentWaysId.Value;
  s.ssBuyDocNumber = obj.AttrBuyDocNumber == null ? "" : obj.AttrBuyDocNumber;
  s.ssBuyDocPosition = obj.AttrBuyDocPosition == null ? "" : obj.AttrBuyDocPosition;
  }
  return s;
}

public static Func<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord, ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord FromStructure(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord(s, config);
}

}


