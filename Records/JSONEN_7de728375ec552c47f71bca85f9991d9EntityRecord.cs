using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalType
public class JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord : AbstractRESTStructure<EN_7de728375ec552c47f71bca85f9991d9EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord() { }

public JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord (EN_7de728375ec552c47f71bca85f9991d9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord, EN_7de728375ec552c47f71bca85f9991d9EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord s) => ToStructure(s, config);
}
public static EN_7de728375ec552c47f71bca85f9991d9EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7de728375ec552c47f71bca85f9991d9EntityRecord s = new EN_7de728375ec552c47f71bca85f9991d9EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_7de728375ec552c47f71bca85f9991d9EntityRecord, ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7de728375ec552c47f71bca85f9991d9EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord FromStructure(EN_7de728375ec552c47f71bca85f9991d9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord(s, config);
}

}


