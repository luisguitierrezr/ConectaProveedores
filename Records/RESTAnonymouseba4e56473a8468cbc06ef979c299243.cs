using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_ResponseRecord
public class RESTRC_c6cff6fd026285ecdd3213ebaf518541 : AbstractRESTStructure<RC_c6cff6fd026285ecdd3213ebaf518541> {
[JsonProperty("EM_SM_MO_COSMOZ_Response")]
public ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure AttrEM_SM_MO_COSMOZ_Response;

public RESTRC_c6cff6fd026285ecdd3213ebaf518541() { }

public RESTRC_c6cff6fd026285ecdd3213ebaf518541 (RC_c6cff6fd026285ecdd3213ebaf518541 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Response = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Response, new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure(), ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Response = ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Response, config);
  }
}

public static RC_c6cff6fd026285ecdd3213ebaf518541 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c6cff6fd026285ecdd3213ebaf518541 obj) { 
  RC_c6cff6fd026285ecdd3213ebaf518541 s = new RC_c6cff6fd026285ecdd3213ebaf518541();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Response = ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Response);
  }
  return s;
}

public static Func<RC_c6cff6fd026285ecdd3213ebaf518541, ssConectaProveedores.RestRecords.RESTRC_c6cff6fd026285ecdd3213ebaf518541> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6cff6fd026285ecdd3213ebaf518541 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c6cff6fd026285ecdd3213ebaf518541 FromStructure(RC_c6cff6fd026285ecdd3213ebaf518541 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c6cff6fd026285ecdd3213ebaf518541(s, config);
}

}


