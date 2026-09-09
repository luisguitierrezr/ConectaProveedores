using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatus
public class JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord : AbstractRESTStructure<EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Class")]
[JsonPropertyName("Class")]
public string AttrClass;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("IsInAccounting")]
[JsonPropertyName("IsInAccounting")]
public bool? AttrIsInAccounting;

[JsonProperty("LabelES")]
[JsonPropertyName("LabelES")]
public string AttrLabelES;

public JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord() { }

public JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrIsInAccounting = ConvertToRestWithoutDefaults(s.ssIsInAccounting, false);
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = s.ssClass;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrIsInAccounting = (bool?) s.ssIsInAccounting;
AttrLabelES = s.ssLabelES;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord, EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s) => ToStructure(s, config);
}
public static EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssIsInAccounting = obj.AttrIsInAccounting == null ? false : obj.AttrIsInAccounting.Value;
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  }
  return s;
}

public static Func<EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord, ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord FromStructure(EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(s, config);
}

}


