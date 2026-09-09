using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractFileType
public class JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord : AbstractRESTStructure<EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord> {
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

public JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord() { }

public JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord, EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s) => ToStructure(s, config);
}
public static EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s = new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord, ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord FromStructure(EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(s, config);
}

}


