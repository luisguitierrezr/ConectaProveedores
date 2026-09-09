using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_ResponseRecord
public class JSONRC_abfc8474e8c0b6d4329c91f8949f80f9 : AbstractRESTStructure<RC_abfc8474e8c0b6d4329c91f8949f80f9> {
[JsonProperty("EM_SM_CECO_COSMOZ_Response")]
[JsonPropertyName("EM_SM_CECO_COSMOZ_Response")]
public ssConectaProveedores.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure AttrEM_SM_CECO_COSMOZ_Response;

public JSONRC_abfc8474e8c0b6d4329c91f8949f80f9() { }

public JSONRC_abfc8474e8c0b6d4329c91f8949f80f9 (RC_abfc8474e8c0b6d4329c91f8949f80f9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Response = ConvertToRestWithoutDefaults(s.ssSTEM_SM_CECO_COSMOZ_Response, new ST_92e975006ec90075480e9af34dc228e3Structure(), ssConectaProveedores.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Response = ssConectaProveedores.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure.FromStructure(s.ssSTEM_SM_CECO_COSMOZ_Response, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_abfc8474e8c0b6d4329c91f8949f80f9, RC_abfc8474e8c0b6d4329c91f8949f80f9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_abfc8474e8c0b6d4329c91f8949f80f9 s) => ToStructure(s, config);
}
public static RC_abfc8474e8c0b6d4329c91f8949f80f9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_abfc8474e8c0b6d4329c91f8949f80f9 obj, IBehaviorsConfiguration config) { 
  RC_abfc8474e8c0b6d4329c91f8949f80f9 s = new RC_abfc8474e8c0b6d4329c91f8949f80f9();
  if(obj != null) {
  s.ssSTEM_SM_CECO_COSMOZ_Response = ssConectaProveedores.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Response, config);
  }
  return s;
}

public static Func<RC_abfc8474e8c0b6d4329c91f8949f80f9, ssConectaProveedores.RestRecords.JSONRC_abfc8474e8c0b6d4329c91f8949f80f9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_abfc8474e8c0b6d4329c91f8949f80f9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_abfc8474e8c0b6d4329c91f8949f80f9 FromStructure(RC_abfc8474e8c0b6d4329c91f8949f80f9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_abfc8474e8c0b6d4329c91f8949f80f9(s, config);
}

}


