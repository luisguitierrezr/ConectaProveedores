using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_RequestRecord
public class JSONRC_caf61a1959588019d4022d8eec32ba1c : AbstractRESTStructure<RC_caf61a1959588019d4022d8eec32ba1c> {
[JsonProperty("EM_SM_MO_COSMOZ_Request")]
[JsonPropertyName("EM_SM_MO_COSMOZ_Request")]
public ssConectaProveedores.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure AttrEM_SM_MO_COSMOZ_Request;

public JSONRC_caf61a1959588019d4022d8eec32ba1c() { }

public JSONRC_caf61a1959588019d4022d8eec32ba1c (RC_caf61a1959588019d4022d8eec32ba1c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Request = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Request, new ST_f61ad0d448ed247a1bde22a5051a7d04Structure(), ssConectaProveedores.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Request = ssConectaProveedores.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Request, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_caf61a1959588019d4022d8eec32ba1c, RC_caf61a1959588019d4022d8eec32ba1c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_caf61a1959588019d4022d8eec32ba1c s) => ToStructure(s, config);
}
public static RC_caf61a1959588019d4022d8eec32ba1c ToStructure(ssConectaProveedores.RestRecords.JSONRC_caf61a1959588019d4022d8eec32ba1c obj, IBehaviorsConfiguration config) { 
  RC_caf61a1959588019d4022d8eec32ba1c s = new RC_caf61a1959588019d4022d8eec32ba1c();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Request = ssConectaProveedores.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Request, config);
  }
  return s;
}

public static Func<RC_caf61a1959588019d4022d8eec32ba1c, ssConectaProveedores.RestRecords.JSONRC_caf61a1959588019d4022d8eec32ba1c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_caf61a1959588019d4022d8eec32ba1c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_caf61a1959588019d4022d8eec32ba1c FromStructure(RC_caf61a1959588019d4022d8eec32ba1c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_caf61a1959588019d4022d8eec32ba1c(s, config);
}

}


