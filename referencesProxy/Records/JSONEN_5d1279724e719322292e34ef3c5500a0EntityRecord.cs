using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Position
public class JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord : AbstractRESTStructure<EN_5d1279724e719322292e34ef3c5500a0EntityRecord> {
[JsonProperty("Position")]
[JsonPropertyName("Position")]
public string AttrPosition;

public JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord() { }

public JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord (EN_5d1279724e719322292e34ef3c5500a0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = s.ssPosition;
  } else {
AttrPosition = s.ssPosition;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord, EN_5d1279724e719322292e34ef3c5500a0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord s) => ToStructure(s, config);
}
public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5d1279724e719322292e34ef3c5500a0EntityRecord s = new EN_5d1279724e719322292e34ef3c5500a0EntityRecord();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  }
  return s;
}

public static Func<EN_5d1279724e719322292e34ef3c5500a0EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord FromStructure(EN_5d1279724e719322292e34ef3c5500a0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d1279724e719322292e34ef3c5500a0EntityRecord(s, config);
}

}


