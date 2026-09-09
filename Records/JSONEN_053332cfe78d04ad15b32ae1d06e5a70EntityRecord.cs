using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItem
public class JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord : AbstractRESTStructure<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("ProductNumber")]
[JsonPropertyName("ProductNumber")]
public string AttrProductNumber;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("MaterialCode")]
[JsonPropertyName("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public int? AttrQuantity;

[JsonProperty("UnityPrice")]
[JsonPropertyName("UnityPrice")]
public decimal? AttrUnityPrice;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

public JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord() { }

public JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrProductNumber = ConvertToRestWithoutDefaults(s.ssProductNumber, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrMaterialCode = ConvertToRestWithoutDefaults(s.ssMaterialCode, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0);
AttrUnityPrice = ConvertToRestWithoutDefaults(s.ssUnityPrice, 0.0M);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrProductNumber = s.ssProductNumber;
AttrDescription = s.ssDescription;
AttrMaterialCode = s.ssMaterialCode;
AttrQuantity = (int?) s.ssQuantity;
AttrUnityPrice = (decimal?) s.ssUnityPrice;
AttrCurrency = s.ssCurrency;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord, EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s) => ToStructure(s, config);
}
public static EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssProductNumber = obj.AttrProductNumber == null ? "" : obj.AttrProductNumber;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssMaterialCode = obj.AttrMaterialCode == null ? "" : obj.AttrMaterialCode;
  s.ssQuantity = obj.AttrQuantity == null ? 0 : obj.AttrQuantity.Value;
  s.ssUnityPrice = obj.AttrUnityPrice == null ? 0.0M : obj.AttrUnityPrice.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  }
  return s;
}

public static Func<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord, ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord FromStructure(EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(s, config);
}

}


