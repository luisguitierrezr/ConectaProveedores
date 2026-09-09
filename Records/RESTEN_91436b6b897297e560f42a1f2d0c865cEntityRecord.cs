using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserArea
public class RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord : AbstractRESTStructure<EN_91436b6b897297e560f42a1f2d0c865cEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord() { }

public RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord (EN_91436b6b897297e560f42a1f2d0c865cEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_91436b6b897297e560f42a1f2d0c865cEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord obj) { 
  EN_91436b6b897297e560f42a1f2d0c865cEntityRecord s = new EN_91436b6b897297e560f42a1f2d0c865cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? true : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_91436b6b897297e560f42a1f2d0c865cEntityRecord, ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_91436b6b897297e560f42a1f2d0c865cEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord FromStructure(EN_91436b6b897297e560f42a1f2d0c865cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_91436b6b897297e560f42a1f2d0c865cEntityRecord(s, config);
}

}


