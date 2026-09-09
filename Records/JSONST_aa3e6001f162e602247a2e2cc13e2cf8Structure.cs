using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioStruct
public class JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure : AbstractRESTStructure<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure> {
[JsonProperty("OrderMainId")]
[JsonPropertyName("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("Position")]
[JsonPropertyName("Position")]
public string AttrPosition;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("ArticleNumber")]
[JsonPropertyName("ArticleNumber")]
public string AttrArticleNumber;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("InputationCode")]
[JsonPropertyName("InputationCode")]
public string AttrInputationCode;

[JsonProperty("DeliveryDate")]
[JsonPropertyName("DeliveryDate")]
public String AttrDeliveryDate;

[JsonProperty("InvoiceQtt")]
[JsonPropertyName("InvoiceQtt")]
public decimal? AttrInvoiceQtt;

[JsonProperty("RemainingQtt")]
[JsonPropertyName("RemainingQtt")]
public decimal? AttrRemainingQtt;

[JsonProperty("RemainingQttTotal")]
[JsonPropertyName("RemainingQttTotal")]
public decimal? AttrRemainingQttTotal;

[JsonProperty("UnitPrice")]
[JsonPropertyName("UnitPrice")]
public decimal? AttrUnitPrice;

[JsonProperty("TotalPrice")]
[JsonPropertyName("TotalPrice")]
public decimal? AttrTotalPrice;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("DeliveryQtt")]
[JsonPropertyName("DeliveryQtt")]
public string AttrDeliveryQtt;

[JsonProperty("Importdelivery")]
[JsonPropertyName("Importdelivery")]
public decimal? AttrImportdelivery;

[JsonProperty("IsInvoiceError")]
[JsonPropertyName("IsInvoiceError")]
public bool? AttrIsInvoiceError;

[JsonProperty("IsDateError")]
[JsonPropertyName("IsDateError")]
public bool? AttrIsDateError;

[JsonProperty("IsPEPError")]
[JsonPropertyName("IsPEPError")]
public bool? AttrIsPEPError;

[JsonProperty("PEP")]
[JsonPropertyName("PEP")]
public string AttrPEP;

[JsonProperty("PlaceId")]
[JsonPropertyName("PlaceId")]
public string AttrPlaceId;

[JsonProperty("PlaceName")]
[JsonPropertyName("PlaceName")]
public string AttrPlaceName;

[JsonProperty("BaseQuantity")]
[JsonPropertyName("BaseQuantity")]
public int? AttrBaseQuantity;

[JsonProperty("VatRate")]
[JsonPropertyName("VatRate")]
public decimal? AttrVatRate;

[JsonProperty("IsMultipleImputation")]
[JsonPropertyName("IsMultipleImputation")]
public bool? AttrIsMultipleImputation;

public JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure() { }

public JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrArticleNumber = ConvertToRestWithoutDefaults(s.ssArticleNumber, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrInputationCode = ConvertToRestWithoutDefaults(s.ssInputationCode, "");
AttrDeliveryDate = ConvertDateToRestWithoutDefaults(s.ssDeliveryDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrInvoiceQtt = ConvertToRestWithoutDefaults(s.ssInvoiceQtt, 0.0M);
AttrRemainingQtt = ConvertToRestWithoutDefaults(s.ssRemainingQtt, 0.0M);
AttrRemainingQttTotal = ConvertToRestWithoutDefaults(s.ssRemainingQttTotal, 0.0M);
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, 0.0M);
AttrTotalPrice = ConvertToRestWithoutDefaults(s.ssTotalPrice, 0.0M);
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrDeliveryQtt = ConvertToRestWithoutDefaults(s.ssDeliveryQtt, "");
AttrImportdelivery = ConvertToRestWithoutDefaults(s.ssImportdelivery, 0.0M);
AttrIsInvoiceError = ConvertToRestWithoutDefaults(s.ssIsInvoiceError, false);
AttrIsDateError = ConvertToRestWithoutDefaults(s.ssIsDateError, false);
AttrIsPEPError = ConvertToRestWithoutDefaults(s.ssIsPEPError, false);
AttrPEP = ConvertToRestWithoutDefaults(s.ssPEP, "");
AttrPlaceId = ConvertToRestWithoutDefaults(s.ssPlaceId, "");
AttrPlaceName = ConvertToRestWithoutDefaults(s.ssPlaceName, "");
AttrBaseQuantity = ConvertToRestWithoutDefaults(s.ssBaseQuantity, 0);
AttrVatRate = ConvertToRestWithoutDefaults(s.ssVatRate, 0.0M);
AttrIsMultipleImputation = ConvertToRestWithoutDefaults(s.ssIsMultipleImputation, false);
  } else {
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrPosition = s.ssPosition;
AttrOrderNumber = s.ssOrderNumber;
AttrArticleNumber = s.ssArticleNumber;
AttrDescription = s.ssDescription;
AttrInputationCode = s.ssInputationCode;
AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDeliveryDate);
AttrInvoiceQtt = (decimal?) s.ssInvoiceQtt;
AttrRemainingQtt = (decimal?) s.ssRemainingQtt;
AttrRemainingQttTotal = (decimal?) s.ssRemainingQttTotal;
AttrUnitPrice = (decimal?) s.ssUnitPrice;
AttrTotalPrice = (decimal?) s.ssTotalPrice;
AttrQuantity = (decimal?) s.ssQuantity;
AttrDeliveryQtt = s.ssDeliveryQtt;
AttrImportdelivery = (decimal?) s.ssImportdelivery;
AttrIsInvoiceError = (bool?) s.ssIsInvoiceError;
AttrIsDateError = (bool?) s.ssIsDateError;
AttrIsPEPError = (bool?) s.ssIsPEPError;
AttrPEP = s.ssPEP;
AttrPlaceId = s.ssPlaceId;
AttrPlaceName = s.ssPlaceName;
AttrBaseQuantity = (int?) s.ssBaseQuantity;
AttrVatRate = (decimal?) s.ssVatRate;
AttrIsMultipleImputation = (bool?) s.ssIsMultipleImputation;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure s) => ToStructure(s, config);
}
public static ST_aa3e6001f162e602247a2e2cc13e2cf8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure obj, IBehaviorsConfiguration config) { 
  ST_aa3e6001f162e602247a2e2cc13e2cf8Structure s = new ST_aa3e6001f162e602247a2e2cc13e2cf8Structure();
  if(obj != null) {
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssArticleNumber = obj.AttrArticleNumber == null ? "" : obj.AttrArticleNumber;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssInputationCode = obj.AttrInputationCode == null ? "" : obj.AttrInputationCode;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDeliveryDate);
  s.ssInvoiceQtt = obj.AttrInvoiceQtt == null ? 0.0M : obj.AttrInvoiceQtt.Value;
  s.ssRemainingQtt = obj.AttrRemainingQtt == null ? 0.0M : obj.AttrRemainingQtt.Value;
  s.ssRemainingQttTotal = obj.AttrRemainingQttTotal == null ? 0.0M : obj.AttrRemainingQttTotal.Value;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? 0.0M : obj.AttrUnitPrice.Value;
  s.ssTotalPrice = obj.AttrTotalPrice == null ? 0.0M : obj.AttrTotalPrice.Value;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssDeliveryQtt = obj.AttrDeliveryQtt == null ? "" : obj.AttrDeliveryQtt;
  s.ssImportdelivery = obj.AttrImportdelivery == null ? 0.0M : obj.AttrImportdelivery.Value;
  s.ssIsInvoiceError = obj.AttrIsInvoiceError == null ? false : obj.AttrIsInvoiceError.Value;
  s.ssIsDateError = obj.AttrIsDateError == null ? false : obj.AttrIsDateError.Value;
  s.ssIsPEPError = obj.AttrIsPEPError == null ? false : obj.AttrIsPEPError.Value;
  s.ssPEP = obj.AttrPEP == null ? "" : obj.AttrPEP;
  s.ssPlaceId = obj.AttrPlaceId == null ? "" : obj.AttrPlaceId;
  s.ssPlaceName = obj.AttrPlaceName == null ? "" : obj.AttrPlaceName;
  s.ssBaseQuantity = obj.AttrBaseQuantity == null ? 0 : obj.AttrBaseQuantity.Value;
  s.ssVatRate = obj.AttrVatRate == null ? 0.0M : obj.AttrVatRate.Value;
  s.ssIsMultipleImputation = obj.AttrIsMultipleImputation == null ? false : obj.AttrIsMultipleImputation.Value;
  }
  return s;
}

public static Func<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure, ssConectaProveedores.RestRecords.JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure FromStructure(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_aa3e6001f162e602247a2e2cc13e2cf8Structure(s, config);
}

}


