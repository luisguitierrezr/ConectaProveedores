using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractFileType
public class RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord : AbstractRESTStructure<EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord() { }

public RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord obj) { 
  EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s = new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord, ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord FromStructure(EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(s, config);
}

}


