using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersRequest
public class JSONST_9c87dd52bd762501ef8a064794927f08Structure : AbstractRESTStructure<ST_9c87dd52bd762501ef8a064794927f08Structure> {
[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("CompanyCode")]
[JsonPropertyName("CompanyCode")]
public string AttrCompanyCode;

[JsonProperty("ClassDocument")]
[JsonPropertyName("ClassDocument")]
public string AttrClassDocument;

[JsonProperty("DeletedIndicator")]
[JsonPropertyName("DeletedIndicator")]
public string AttrDeletedIndicator;

[JsonProperty("OrderDate")]
[JsonPropertyName("OrderDate")]
public string AttrOrderDate;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("ProcurementGroup")]
[JsonPropertyName("ProcurementGroup")]
public string AttrProcurementGroup;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedByName")]
[JsonPropertyName("CreatedByName")]
public string AttrCreatedByName;

[JsonProperty("CountryCode")]
[JsonPropertyName("CountryCode")]
public string AttrCountryCode;

[JsonProperty("Released")]
[JsonPropertyName("Released")]
public string AttrReleased;

[JsonProperty("ExchangeRate")]
[JsonPropertyName("ExchangeRate")]
public decimal? AttrExchangeRate;

[JsonProperty("CurrencyCode")]
[JsonPropertyName("CurrencyCode")]
public string AttrCurrencyCode;

[JsonProperty("SustainabilityCategory")]
[JsonPropertyName("SustainabilityCategory")]
public string AttrSustainabilityCategory;

[JsonProperty("SustainabilitySubcategory")]
[JsonPropertyName("SustainabilitySubcategory")]
public string AttrSustainabilitySubcategory;

[JsonProperty("OrderItems")]
[JsonPropertyName("OrderItems")]
public ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure[] AttrOrderItems;

public JSONST_9c87dd52bd762501ef8a064794927f08Structure() { }

public JSONST_9c87dd52bd762501ef8a064794927f08Structure (ST_9c87dd52bd762501ef8a064794927f08Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = s.ssOrderNumber;
AttrCompanyCode = ConvertToRestWithoutDefaults(s.ssCompanyCode, "");
AttrClassDocument = ConvertToRestWithoutDefaults(s.ssClassDocument, "");
AttrDeletedIndicator = ConvertToRestWithoutDefaults(s.ssDeletedIndicator, "False");
AttrOrderDate = ConvertToRestWithoutDefaults(s.ssOrderDate, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrProcurementGroup = ConvertToRestWithoutDefaults(s.ssProcurementGroup, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedByName = ConvertToRestWithoutDefaults(s.ssCreatedByName, "");
AttrCountryCode = ConvertToRestWithoutDefaults(s.ssCountryCode, "");
AttrReleased = ConvertToRestWithoutDefaults(s.ssReleased, "False");
AttrExchangeRate = ConvertToRestWithoutDefaults(s.ssExchangeRate, 0.0M);
AttrCurrencyCode = ConvertToRestWithoutDefaults(s.ssCurrencyCode, "");
AttrSustainabilityCategory = ConvertToRestWithoutDefaults(s.ssSustainabilityCategory, "");
AttrSustainabilitySubcategory = ConvertToRestWithoutDefaults(s.ssSustainabilitySubcategory, "");
AttrOrderItems = s.ssOrderItems.Length == 0 ? null : s.ssOrderItems.ToArray<ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure>(ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure.FromStructureDelegate(config));
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrCompanyCode = s.ssCompanyCode;
AttrClassDocument = s.ssClassDocument;
AttrDeletedIndicator = s.ssDeletedIndicator;
AttrOrderDate = s.ssOrderDate;
AttrSupplierNumber = s.ssSupplierNumber;
AttrSupplierName = s.ssSupplierName;
AttrProcurementGroup = s.ssProcurementGroup;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedByName = s.ssCreatedByName;
AttrCountryCode = s.ssCountryCode;
AttrReleased = s.ssReleased;
AttrExchangeRate = (decimal?) s.ssExchangeRate;
AttrCurrencyCode = s.ssCurrencyCode;
AttrSustainabilityCategory = s.ssSustainabilityCategory;
AttrSustainabilitySubcategory = s.ssSustainabilitySubcategory;
AttrOrderItems = s.ssOrderItems.ToArray<ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure>(ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure, ST_9c87dd52bd762501ef8a064794927f08Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure s) => ToStructure(s, config);
}
public static ST_9c87dd52bd762501ef8a064794927f08Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure obj, IBehaviorsConfiguration config) { 
  ST_9c87dd52bd762501ef8a064794927f08Structure s = new ST_9c87dd52bd762501ef8a064794927f08Structure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssCompanyCode = obj.AttrCompanyCode == null ? "" : obj.AttrCompanyCode;
  s.ssClassDocument = obj.AttrClassDocument == null ? "" : obj.AttrClassDocument;
  s.ssDeletedIndicator = obj.AttrDeletedIndicator == null ? "False" : obj.AttrDeletedIndicator;
  s.ssOrderDate = obj.AttrOrderDate == null ? "" : obj.AttrOrderDate;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssProcurementGroup = obj.AttrProcurementGroup == null ? "" : obj.AttrProcurementGroup;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedByName = obj.AttrCreatedByName == null ? "" : obj.AttrCreatedByName;
  s.ssCountryCode = obj.AttrCountryCode == null ? "" : obj.AttrCountryCode;
  s.ssReleased = obj.AttrReleased == null ? "False" : obj.AttrReleased;
  s.ssExchangeRate = obj.AttrExchangeRate == null ? 0.0M : obj.AttrExchangeRate.Value;
  s.ssCurrencyCode = obj.AttrCurrencyCode == null ? "" : obj.AttrCurrencyCode;
  s.ssSustainabilityCategory = obj.AttrSustainabilityCategory == null ? "" : obj.AttrSustainabilityCategory;
  s.ssSustainabilitySubcategory = obj.AttrSustainabilitySubcategory == null ? "" : obj.AttrSustainabilitySubcategory;
  s.ssOrderItems = RL_5a5dc4e5843197429d3408a507236d6a.ToList(obj.AttrOrderItems, ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_9c87dd52bd762501ef8a064794927f08Structure, ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9c87dd52bd762501ef8a064794927f08Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure FromStructure(ST_9c87dd52bd762501ef8a064794927f08Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure(s, config);
}

}


