using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CFDIType
public class RESTEN_f6b1999c25654417411e080987a56a77EntityRecord : AbstractRESTStructure<EN_f6b1999c25654417411e080987a56a77EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_f6b1999c25654417411e080987a56a77EntityRecord() { }

public RESTEN_f6b1999c25654417411e080987a56a77EntityRecord (EN_f6b1999c25654417411e080987a56a77EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_f6b1999c25654417411e080987a56a77EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord obj) { 
  EN_f6b1999c25654417411e080987a56a77EntityRecord s = new EN_f6b1999c25654417411e080987a56a77EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_f6b1999c25654417411e080987a56a77EntityRecord, ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f6b1999c25654417411e080987a56a77EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord FromStructure(EN_f6b1999c25654417411e080987a56a77EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord(s, config);
}

}


