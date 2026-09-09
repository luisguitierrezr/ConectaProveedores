using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DayOfWeek
public class RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord : AbstractRESTStructure<EN_994a40086cd6e8196835f26327ddf330EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord() { }

public RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord (EN_994a40086cd6e8196835f26327ddf330EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_994a40086cd6e8196835f26327ddf330EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord obj) { 
  EN_994a40086cd6e8196835f26327ddf330EntityRecord s = new EN_994a40086cd6e8196835f26327ddf330EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_994a40086cd6e8196835f26327ddf330EntityRecord, ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_994a40086cd6e8196835f26327ddf330EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord FromStructure(EN_994a40086cd6e8196835f26327ddf330EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord(s, config);
}

}


