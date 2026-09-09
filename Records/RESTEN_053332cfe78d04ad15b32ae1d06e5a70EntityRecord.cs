using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItem
public class RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord : AbstractRESTStructure<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("ProductNumber")]
public string AttrProductNumber;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("Quantity")]
public int? AttrQuantity;

[JsonProperty("UnityPrice")]
public decimal? AttrUnityPrice;

[JsonProperty("Currency")]
public string AttrCurrency;

public RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord() { }

public RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord obj) { 
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

public static Func<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord, ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord FromStructure(EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(s, config);
}

}


