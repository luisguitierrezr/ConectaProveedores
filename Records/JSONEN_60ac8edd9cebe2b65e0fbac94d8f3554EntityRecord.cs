using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMain
public class JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord : AbstractRESTStructure<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderDate")]
[JsonPropertyName("OrderDate")]
public String AttrOrderDate;

[JsonProperty("OrderStatusId")]
[JsonPropertyName("OrderStatusId")]
public int? AttrOrderStatusId;

[JsonProperty("PreviousOrderStatusId")]
[JsonPropertyName("PreviousOrderStatusId")]
public int? AttrPreviousOrderStatusId;

[JsonProperty("AssignmentCode")]
[JsonPropertyName("AssignmentCode")]
public string AttrAssignmentCode;

[JsonProperty("SupplierId")]
[JsonPropertyName("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("CompanyId")]
[JsonPropertyName("CompanyId")]
public long? AttrCompanyId;

[JsonProperty("DocumentTypeId")]
[JsonPropertyName("DocumentTypeId")]
public long? AttrDocumentTypeId;

[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("TelcelDirectionId")]
[JsonPropertyName("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

[JsonProperty("ProcurementGroup")]
[JsonPropertyName("ProcurementGroup")]
public string AttrProcurementGroup;

[JsonProperty("CreatorSAPNumber")]
[JsonPropertyName("CreatorSAPNumber")]
public string AttrCreatorSAPNumber;

[JsonProperty("CreatorSAPName")]
[JsonPropertyName("CreatorSAPName")]
public string AttrCreatorSAPName;

[JsonProperty("Country")]
[JsonPropertyName("Country")]
public string AttrCountry;

[JsonProperty("IsDeleted")]
[JsonPropertyName("IsDeleted")]
public bool? AttrIsDeleted;

[JsonProperty("IsReleased")]
[JsonPropertyName("IsReleased")]
public bool? AttrIsReleased;

[JsonProperty("ExchangeRate")]
[JsonPropertyName("ExchangeRate")]
public decimal? AttrExchangeRate;

[JsonProperty("SustainabilityCategory")]
[JsonPropertyName("SustainabilityCategory")]
public string AttrSustainabilityCategory;

[JsonProperty("SustainabilitySubcategory")]
[JsonPropertyName("SustainabilitySubcategory")]
public string AttrSustainabilitySubcategory;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("FromCosmoz")]
[JsonPropertyName("FromCosmoz")]
public bool? AttrFromCosmoz;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("DivisionId")]
[JsonPropertyName("DivisionId")]
public long? AttrDivisionId;

[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public string AttrApplicant;

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

public JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord() { }

public JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderDate);
AttrOrderStatusId = (int?) s.ssOrderStatusId;
AttrPreviousOrderStatusId = ConvertToRestWithoutDefaults(s.ssPreviousOrderStatusId, 0);
AttrAssignmentCode = ConvertToRestWithoutDefaults(s.ssAssignmentCode, "");
AttrSupplierId = (long?) s.ssSupplierId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrDocumentTypeId = ConvertToRestWithoutDefaults(s.ssDocumentTypeId, 0L);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
AttrProcurementGroup = ConvertToRestWithoutDefaults(s.ssProcurementGroup, "");
AttrCreatorSAPNumber = ConvertToRestWithoutDefaults(s.ssCreatorSAPNumber, "");
AttrCreatorSAPName = ConvertToRestWithoutDefaults(s.ssCreatorSAPName, "");
AttrCountry = s.ssCountry;
AttrIsDeleted = ConvertToRestWithoutDefaults(s.ssIsDeleted, false);
AttrIsReleased = ConvertToRestWithoutDefaults(s.ssIsReleased, false);
AttrExchangeRate = (decimal?) s.ssExchangeRate;
AttrSustainabilityCategory = ConvertToRestWithoutDefaults(s.ssSustainabilityCategory, "");
AttrSustainabilitySubcategory = ConvertToRestWithoutDefaults(s.ssSustainabilitySubcategory, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrFromCosmoz = ConvertToRestWithoutDefaults(s.ssFromCosmoz, false);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrDivisionId = ConvertToRestWithoutDefaults(s.ssDivisionId, 0L);
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderDate);
AttrOrderStatusId = (int?) s.ssOrderStatusId;
AttrPreviousOrderStatusId = (int?) s.ssPreviousOrderStatusId;
AttrAssignmentCode = s.ssAssignmentCode;
AttrSupplierId = (long?) s.ssSupplierId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrDocumentTypeId = (long?) s.ssDocumentTypeId;
AttrCurrencyId = s.ssCurrencyId;
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
AttrProcurementGroup = s.ssProcurementGroup;
AttrCreatorSAPNumber = s.ssCreatorSAPNumber;
AttrCreatorSAPName = s.ssCreatorSAPName;
AttrCountry = s.ssCountry;
AttrIsDeleted = (bool?) s.ssIsDeleted;
AttrIsReleased = (bool?) s.ssIsReleased;
AttrExchangeRate = (decimal?) s.ssExchangeRate;
AttrSustainabilityCategory = s.ssSustainabilityCategory;
AttrSustainabilitySubcategory = s.ssSustainabilitySubcategory;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrFromCosmoz = (bool?) s.ssFromCosmoz;
AttrRegionId = (long?) s.ssRegionId;
AttrDivisionId = (long?) s.ssDivisionId;
AttrApplicant = s.ssApplicant;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord s) => ToStructure(s, config);
}
public static EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord s = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderDate = obj.AttrOrderDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrOrderDate);
  s.ssOrderStatusId = obj.AttrOrderStatusId == null ? 0 : obj.AttrOrderStatusId.Value;
  s.ssPreviousOrderStatusId = obj.AttrPreviousOrderStatusId == null ? 0 : obj.AttrPreviousOrderStatusId.Value;
  s.ssAssignmentCode = obj.AttrAssignmentCode == null ? "" : obj.AttrAssignmentCode;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssCompanyId = obj.AttrCompanyId == null ? 0L : obj.AttrCompanyId.Value;
  s.ssDocumentTypeId = obj.AttrDocumentTypeId == null ? 0L : obj.AttrDocumentTypeId.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  s.ssProcurementGroup = obj.AttrProcurementGroup == null ? "" : obj.AttrProcurementGroup;
  s.ssCreatorSAPNumber = obj.AttrCreatorSAPNumber == null ? "" : obj.AttrCreatorSAPNumber;
  s.ssCreatorSAPName = obj.AttrCreatorSAPName == null ? "" : obj.AttrCreatorSAPName;
  s.ssCountry = obj.AttrCountry == null ? "" : obj.AttrCountry;
  s.ssIsDeleted = obj.AttrIsDeleted == null ? false : obj.AttrIsDeleted.Value;
  s.ssIsReleased = obj.AttrIsReleased == null ? false : obj.AttrIsReleased.Value;
  s.ssExchangeRate = obj.AttrExchangeRate == null ? 0.0M : obj.AttrExchangeRate.Value;
  s.ssSustainabilityCategory = obj.AttrSustainabilityCategory == null ? "" : obj.AttrSustainabilityCategory;
  s.ssSustainabilitySubcategory = obj.AttrSustainabilitySubcategory == null ? "" : obj.AttrSustainabilitySubcategory;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssFromCosmoz = obj.AttrFromCosmoz == null ? false : obj.AttrFromCosmoz.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssDivisionId = obj.AttrDivisionId == null ? 0L : obj.AttrDivisionId.Value;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord, ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord FromStructure(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(s, config);
}

}


