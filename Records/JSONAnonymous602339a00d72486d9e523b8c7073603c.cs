using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MinuteDocumentTypeUpdateRecord
public class JSONRC_ac991ca3646258b2c6cf2ca4475c9215 : AbstractRESTStructure<RC_ac991ca3646258b2c6cf2ca4475c9215> {
[JsonProperty("MinuteDocumentTypeUpdate")]
[JsonPropertyName("MinuteDocumentTypeUpdate")]
public ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure AttrMinuteDocumentTypeUpdate;

public JSONRC_ac991ca3646258b2c6cf2ca4475c9215() { }

public JSONRC_ac991ca3646258b2c6cf2ca4475c9215 (RC_ac991ca3646258b2c6cf2ca4475c9215 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMinuteDocumentTypeUpdate = ConvertToRestWithoutDefaults(s.ssSTMinuteDocumentTypeUpdate, new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(), ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.FromStructure, config);
  } else {
AttrMinuteDocumentTypeUpdate = ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.FromStructure(s.ssSTMinuteDocumentTypeUpdate, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ac991ca3646258b2c6cf2ca4475c9215, RC_ac991ca3646258b2c6cf2ca4475c9215> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ac991ca3646258b2c6cf2ca4475c9215 s) => ToStructure(s, config);
}
public static RC_ac991ca3646258b2c6cf2ca4475c9215 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ac991ca3646258b2c6cf2ca4475c9215 obj, IBehaviorsConfiguration config) { 
  RC_ac991ca3646258b2c6cf2ca4475c9215 s = new RC_ac991ca3646258b2c6cf2ca4475c9215();
  if(obj != null) {
  s.ssSTMinuteDocumentTypeUpdate = ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.ToStructure(obj.AttrMinuteDocumentTypeUpdate, config);
  }
  return s;
}

public static Func<RC_ac991ca3646258b2c6cf2ca4475c9215, ssConectaProveedores.RestRecords.JSONRC_ac991ca3646258b2c6cf2ca4475c9215> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ac991ca3646258b2c6cf2ca4475c9215 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ac991ca3646258b2c6cf2ca4475c9215 FromStructure(RC_ac991ca3646258b2c6cf2ca4475c9215 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ac991ca3646258b2c6cf2ca4475c9215(s, config);
}

}


