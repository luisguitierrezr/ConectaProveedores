using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Position
public class RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord : AbstractRESTStructure<EN_5d1279724e719322292e34ef3c5500a0EntityRecord> {
[JsonProperty("Position")]
public string AttrPosition;

public RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord() { }

public RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord (EN_5d1279724e719322292e34ef3c5500a0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = s.ssPosition;
  } else {
AttrPosition = s.ssPosition;
  }
}

public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord obj) { 
  EN_5d1279724e719322292e34ef3c5500a0EntityRecord s = new EN_5d1279724e719322292e34ef3c5500a0EntityRecord();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  }
  return s;
}

public static Func<EN_5d1279724e719322292e34ef3c5500a0EntityRecord, ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord FromStructure(EN_5d1279724e719322292e34ef3c5500a0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_5d1279724e719322292e34ef3c5500a0EntityRecord(s, config);
}

}


