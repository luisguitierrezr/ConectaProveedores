using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MinuteDocumentTypeUpdateRecord
public class RESTRC_ac991ca3646258b2c6cf2ca4475c9215 : AbstractRESTStructure<RC_ac991ca3646258b2c6cf2ca4475c9215> {
[JsonProperty("MinuteDocumentTypeUpdate")]
public ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure AttrMinuteDocumentTypeUpdate;

public RESTRC_ac991ca3646258b2c6cf2ca4475c9215() { }

public RESTRC_ac991ca3646258b2c6cf2ca4475c9215 (RC_ac991ca3646258b2c6cf2ca4475c9215 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMinuteDocumentTypeUpdate = ConvertToRestWithoutDefaults(s.ssSTMinuteDocumentTypeUpdate, new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(), ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.FromStructure, config);
  } else {
AttrMinuteDocumentTypeUpdate = ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.FromStructure(s.ssSTMinuteDocumentTypeUpdate, config);
  }
}

public static RC_ac991ca3646258b2c6cf2ca4475c9215 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ac991ca3646258b2c6cf2ca4475c9215 obj) { 
  RC_ac991ca3646258b2c6cf2ca4475c9215 s = new RC_ac991ca3646258b2c6cf2ca4475c9215();
  if(obj != null) {
  s.ssSTMinuteDocumentTypeUpdate = ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.ToStructure(obj.AttrMinuteDocumentTypeUpdate);
  }
  return s;
}

public static Func<RC_ac991ca3646258b2c6cf2ca4475c9215, ssConectaProveedores.RestRecords.RESTRC_ac991ca3646258b2c6cf2ca4475c9215> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ac991ca3646258b2c6cf2ca4475c9215 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ac991ca3646258b2c6cf2ca4475c9215 FromStructure(RC_ac991ca3646258b2c6cf2ca4475c9215 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ac991ca3646258b2c6cf2ca4475c9215(s, config);
}

}


