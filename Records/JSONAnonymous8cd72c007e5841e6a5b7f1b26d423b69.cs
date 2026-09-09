using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecord
public class JSONRC_4dd2c54294876907ff3203d83c5ad25d : AbstractRESTStructure<RC_4dd2c54294876907ff3203d83c5ad25d> {
[JsonProperty("Account")]
[JsonPropertyName("Account")]
public string AttrAccount;

[JsonProperty("AmountMD")]
[JsonPropertyName("AmountMD")]
public string AttrAmountMD;

[JsonProperty("AmountML")]
[JsonPropertyName("AmountML")]
public string AttrAmountML;

[JsonProperty("Comment")]
[JsonPropertyName("Comment")]
public string AttrComment;

[JsonProperty("CurrencyMD")]
[JsonPropertyName("CurrencyMD")]
public string AttrCurrencyMD;

[JsonProperty("CurrencyML")]
[JsonPropertyName("CurrencyML")]
public string AttrCurrencyML;

[JsonProperty("NumDoc")]
[JsonPropertyName("NumDoc")]
public string AttrNumDoc;

[JsonProperty("Ref")]
[JsonPropertyName("Ref")]
public string AttrRef;

[JsonProperty("RegionName")]
[JsonPropertyName("RegionName")]
public string AttrRegionName;

[JsonProperty("SocietyName")]
[JsonPropertyName("SocietyName")]
public string AttrSocietyName;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

public JSONRC_4dd2c54294876907ff3203d83c5ad25d() { }

public JSONRC_4dd2c54294876907ff3203d83c5ad25d (RC_4dd2c54294876907ff3203d83c5ad25d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccount = ConvertToRestWithoutDefaults(s.ssAccount, "");
AttrAmountMD = ConvertToRestWithoutDefaults(s.ssAmountMD, "");
AttrAmountML = ConvertToRestWithoutDefaults(s.ssAmountML, "");
AttrComment = ConvertToRestWithoutDefaults(s.ssComment, "");
AttrCurrencyMD = ConvertToRestWithoutDefaults(s.ssCurrencyMD, "");
AttrCurrencyML = ConvertToRestWithoutDefaults(s.ssCurrencyML, "");
AttrNumDoc = ConvertToRestWithoutDefaults(s.ssNumDoc, "");
AttrRef = ConvertToRestWithoutDefaults(s.ssRef, "");
AttrRegionName = ConvertToRestWithoutDefaults(s.ssRegionName, "");
AttrSocietyName = ConvertToRestWithoutDefaults(s.ssSocietyName, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
  } else {
AttrAccount = s.ssAccount;
AttrAmountMD = s.ssAmountMD;
AttrAmountML = s.ssAmountML;
AttrComment = s.ssComment;
AttrCurrencyMD = s.ssCurrencyMD;
AttrCurrencyML = s.ssCurrencyML;
AttrNumDoc = s.ssNumDoc;
AttrRef = s.ssRef;
AttrRegionName = s.ssRegionName;
AttrSocietyName = s.ssSocietyName;
AttrSupplierName = s.ssSupplierName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4dd2c54294876907ff3203d83c5ad25d, RC_4dd2c54294876907ff3203d83c5ad25d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4dd2c54294876907ff3203d83c5ad25d s) => ToStructure(s, config);
}
public static RC_4dd2c54294876907ff3203d83c5ad25d ToStructure(ssConectaProveedores.RestRecords.JSONRC_4dd2c54294876907ff3203d83c5ad25d obj, IBehaviorsConfiguration config) { 
  RC_4dd2c54294876907ff3203d83c5ad25d s = new RC_4dd2c54294876907ff3203d83c5ad25d();
  if(obj != null) {
  s.ssAccount = obj.AttrAccount == null ? "" : obj.AttrAccount;
  s.ssAmountMD = obj.AttrAmountMD == null ? "" : obj.AttrAmountMD;
  s.ssAmountML = obj.AttrAmountML == null ? "" : obj.AttrAmountML;
  s.ssComment = obj.AttrComment == null ? "" : obj.AttrComment;
  s.ssCurrencyMD = obj.AttrCurrencyMD == null ? "" : obj.AttrCurrencyMD;
  s.ssCurrencyML = obj.AttrCurrencyML == null ? "" : obj.AttrCurrencyML;
  s.ssNumDoc = obj.AttrNumDoc == null ? "" : obj.AttrNumDoc;
  s.ssRef = obj.AttrRef == null ? "" : obj.AttrRef;
  s.ssRegionName = obj.AttrRegionName == null ? "" : obj.AttrRegionName;
  s.ssSocietyName = obj.AttrSocietyName == null ? "" : obj.AttrSocietyName;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  }
  return s;
}

public static Func<RC_4dd2c54294876907ff3203d83c5ad25d, ssConectaProveedores.RestRecords.JSONRC_4dd2c54294876907ff3203d83c5ad25d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4dd2c54294876907ff3203d83c5ad25d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4dd2c54294876907ff3203d83c5ad25d FromStructure(RC_4dd2c54294876907ff3203d83c5ad25d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4dd2c54294876907ff3203d83c5ad25d(s, config);
}

}


