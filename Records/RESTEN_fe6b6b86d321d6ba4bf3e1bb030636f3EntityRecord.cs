using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InternalConcept
public class RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord : AbstractRESTStructure<EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord() { }

public RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord (EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord obj) { 
  EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord s = new EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord, ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord FromStructure(EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord(s, config);
}

}


