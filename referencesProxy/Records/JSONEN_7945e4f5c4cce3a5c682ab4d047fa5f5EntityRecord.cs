using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Concept
public class JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord : AbstractRESTStructure<EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord> {
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

public JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord() { }

public JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord (EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord, EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord s) => ToStructure(s, config);
}
public static EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord s = new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord FromStructure(EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord(s, config);
}

}


