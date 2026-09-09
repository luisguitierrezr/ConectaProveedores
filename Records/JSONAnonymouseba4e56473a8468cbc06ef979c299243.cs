using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_ResponseRecord
public class JSONRC_c6cff6fd026285ecdd3213ebaf518541 : AbstractRESTStructure<RC_c6cff6fd026285ecdd3213ebaf518541> {
[JsonProperty("EM_SM_MO_COSMOZ_Response")]
[JsonPropertyName("EM_SM_MO_COSMOZ_Response")]
public ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure AttrEM_SM_MO_COSMOZ_Response;

public JSONRC_c6cff6fd026285ecdd3213ebaf518541() { }

public JSONRC_c6cff6fd026285ecdd3213ebaf518541 (RC_c6cff6fd026285ecdd3213ebaf518541 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Response = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Response, new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure(), ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Response = ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Response, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c6cff6fd026285ecdd3213ebaf518541, RC_c6cff6fd026285ecdd3213ebaf518541> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c6cff6fd026285ecdd3213ebaf518541 s) => ToStructure(s, config);
}
public static RC_c6cff6fd026285ecdd3213ebaf518541 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c6cff6fd026285ecdd3213ebaf518541 obj, IBehaviorsConfiguration config) { 
  RC_c6cff6fd026285ecdd3213ebaf518541 s = new RC_c6cff6fd026285ecdd3213ebaf518541();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Response = ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Response, config);
  }
  return s;
}

public static Func<RC_c6cff6fd026285ecdd3213ebaf518541, ssConectaProveedores.RestRecords.JSONRC_c6cff6fd026285ecdd3213ebaf518541> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6cff6fd026285ecdd3213ebaf518541 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c6cff6fd026285ecdd3213ebaf518541 FromStructure(RC_c6cff6fd026285ecdd3213ebaf518541 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c6cff6fd026285ecdd3213ebaf518541(s, config);
}

}


