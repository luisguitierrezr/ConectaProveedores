using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItems
public class JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord : AbstractRESTStructure<EN_868430b5192a8eb1a739e01247fc2704EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("OrderMainItemId")]
[JsonPropertyName("OrderMainItemId")]
public long? AttrOrderMainItemId;

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
public string AttrImportdelivery;

[JsonProperty("PEP")]
[JsonPropertyName("PEP")]
public string AttrPEP;

[JsonProperty("PlaceId")]
[JsonPropertyName("PlaceId")]
public string AttrPlaceId;

[JsonProperty("PlaceName")]
[JsonPropertyName("PlaceName")]
public string AttrPlaceName;

public JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord() { }

public JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord (EN_868430b5192a8eb1a739e01247fc2704EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrOrderMainItemId = ConvertToRestWithoutDefaults(s.ssOrderMainItemId, 0L);
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrArticleNumber = ConvertToRestWithoutDefaults(s.ssArticleNumber, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrInputationCode = ConvertToRestWithoutDefaults(s.ssInputationCode, "");
AttrDeliveryDate = ConvertDateToRestWithoutDefaults(s.ssDeliveryDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrInvoiceQtt = ConvertToRestWithoutDefaults(s.ssInvoiceQtt, 0.0M);
AttrRemainingQtt = ConvertToRestWithoutDefaults(s.ssRemainingQtt, 0.0M);
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, 0.0M);
AttrTotalPrice = ConvertToRestWithoutDefaults(s.ssTotalPrice, 0.0M);
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrDeliveryQtt = ConvertToRestWithoutDefaults(s.ssDeliveryQtt, "");
AttrImportdelivery = ConvertToRestWithoutDefaults(s.ssImportdelivery, "");
AttrPEP = ConvertToRestWithoutDefaults(s.ssPEP, "");
AttrPlaceId = ConvertToRestWithoutDefaults(s.ssPlaceId, "");
AttrPlaceName = ConvertToRestWithoutDefaults(s.ssPlaceName, "");
  } else {
AttrId = (long?) s.ssId;
AttrFolioId = (long?) s.ssFolioId;
AttrOrderMainItemId = (long?) s.ssOrderMainItemId;
AttrOrderNumber = s.ssOrderNumber;
AttrArticleNumber = s.ssArticleNumber;
AttrDescription = s.ssDescription;
AttrInputationCode = s.ssInputationCode;
AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDeliveryDate);
AttrInvoiceQtt = (decimal?) s.ssInvoiceQtt;
AttrRemainingQtt = (decimal?) s.ssRemainingQtt;
AttrUnitPrice = (decimal?) s.ssUnitPrice;
AttrTotalPrice = (decimal?) s.ssTotalPrice;
AttrQuantity = (decimal?) s.ssQuantity;
AttrDeliveryQtt = s.ssDeliveryQtt;
AttrImportdelivery = s.ssImportdelivery;
AttrPEP = s.ssPEP;
AttrPlaceId = s.ssPlaceId;
AttrPlaceName = s.ssPlaceName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord, EN_868430b5192a8eb1a739e01247fc2704EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord s) => ToStructure(s, config);
}
public static EN_868430b5192a8eb1a739e01247fc2704EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_868430b5192a8eb1a739e01247fc2704EntityRecord s = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssOrderMainItemId = obj.AttrOrderMainItemId == null ? 0L : obj.AttrOrderMainItemId.Value;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssArticleNumber = obj.AttrArticleNumber == null ? "" : obj.AttrArticleNumber;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssInputationCode = obj.AttrInputationCode == null ? "" : obj.AttrInputationCode;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDeliveryDate);
  s.ssInvoiceQtt = obj.AttrInvoiceQtt == null ? 0.0M : obj.AttrInvoiceQtt.Value;
  s.ssRemainingQtt = obj.AttrRemainingQtt == null ? 0.0M : obj.AttrRemainingQtt.Value;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? 0.0M : obj.AttrUnitPrice.Value;
  s.ssTotalPrice = obj.AttrTotalPrice == null ? 0.0M : obj.AttrTotalPrice.Value;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssDeliveryQtt = obj.AttrDeliveryQtt == null ? "" : obj.AttrDeliveryQtt;
  s.ssImportdelivery = obj.AttrImportdelivery == null ? "" : obj.AttrImportdelivery;
  s.ssPEP = obj.AttrPEP == null ? "" : obj.AttrPEP;
  s.ssPlaceId = obj.AttrPlaceId == null ? "" : obj.AttrPlaceId;
  s.ssPlaceName = obj.AttrPlaceName == null ? "" : obj.AttrPlaceName;
  }
  return s;
}

public static Func<EN_868430b5192a8eb1a739e01247fc2704EntityRecord, ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_868430b5192a8eb1a739e01247fc2704EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord FromStructure(EN_868430b5192a8eb1a739e01247fc2704EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord(s, config);
}

}


