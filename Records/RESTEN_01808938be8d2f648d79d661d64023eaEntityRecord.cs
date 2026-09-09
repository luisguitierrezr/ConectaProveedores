using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AppConcept
public class RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord : AbstractRESTStructure<EN_01808938be8d2f648d79d661d64023eaEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord() { }

public RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord (EN_01808938be8d2f648d79d661d64023eaEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_01808938be8d2f648d79d661d64023eaEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord obj) { 
  EN_01808938be8d2f648d79d661d64023eaEntityRecord s = new EN_01808938be8d2f648d79d661d64023eaEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_01808938be8d2f648d79d661d64023eaEntityRecord, ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_01808938be8d2f648d79d661d64023eaEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord FromStructure(EN_01808938be8d2f648d79d661d64023eaEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord(s, config);
}

}


