using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatus
public class RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord : AbstractRESTStructure<EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Class")]
public string AttrClass;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("IsInAccounting")]
public bool? AttrIsInAccounting;

[JsonProperty("LabelES")]
public string AttrLabelES;

public RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord() { }

public RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord obj) { 
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

public static Func<EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord, ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord FromStructure(EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(s, config);
}

}


