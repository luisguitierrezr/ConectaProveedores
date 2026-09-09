using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CFDIType
public class JSONEN_f6b1999c25654417411e080987a56a77EntityRecord : AbstractRESTStructure<EN_f6b1999c25654417411e080987a56a77EntityRecord> {
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

public JSONEN_f6b1999c25654417411e080987a56a77EntityRecord() { }

public JSONEN_f6b1999c25654417411e080987a56a77EntityRecord (EN_f6b1999c25654417411e080987a56a77EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord, EN_f6b1999c25654417411e080987a56a77EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord s) => ToStructure(s, config);
}
public static EN_f6b1999c25654417411e080987a56a77EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f6b1999c25654417411e080987a56a77EntityRecord s = new EN_f6b1999c25654417411e080987a56a77EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_f6b1999c25654417411e080987a56a77EntityRecord, ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f6b1999c25654417411e080987a56a77EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord FromStructure(EN_f6b1999c25654417411e080987a56a77EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord(s, config);
}

}


