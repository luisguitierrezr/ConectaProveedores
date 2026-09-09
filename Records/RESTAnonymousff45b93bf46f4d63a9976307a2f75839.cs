using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_RequestRecord
public class RESTRC_caf61a1959588019d4022d8eec32ba1c : AbstractRESTStructure<RC_caf61a1959588019d4022d8eec32ba1c> {
[JsonProperty("EM_SM_MO_COSMOZ_Request")]
public ssConectaProveedores.RestRecords.RESTST_f61ad0d448ed247a1bde22a5051a7d04Structure AttrEM_SM_MO_COSMOZ_Request;

public RESTRC_caf61a1959588019d4022d8eec32ba1c() { }

public RESTRC_caf61a1959588019d4022d8eec32ba1c (RC_caf61a1959588019d4022d8eec32ba1c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Request = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Request, new ST_f61ad0d448ed247a1bde22a5051a7d04Structure(), ssConectaProveedores.RestRecords.RESTST_f61ad0d448ed247a1bde22a5051a7d04Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_f61ad0d448ed247a1bde22a5051a7d04Structure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Request, config);
  }
}

public static RC_caf61a1959588019d4022d8eec32ba1c ToStructure(ssConectaProveedores.RestRecords.RESTRC_caf61a1959588019d4022d8eec32ba1c obj) { 
  RC_caf61a1959588019d4022d8eec32ba1c s = new RC_caf61a1959588019d4022d8eec32ba1c();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_f61ad0d448ed247a1bde22a5051a7d04Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Request);
  }
  return s;
}

public static Func<RC_caf61a1959588019d4022d8eec32ba1c, ssConectaProveedores.RestRecords.RESTRC_caf61a1959588019d4022d8eec32ba1c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_caf61a1959588019d4022d8eec32ba1c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_caf61a1959588019d4022d8eec32ba1c FromStructure(RC_caf61a1959588019d4022d8eec32ba1c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_caf61a1959588019d4022d8eec32ba1c(s, config);
}

}


