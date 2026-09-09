using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_RequestRecord
public class RESTRC_90eaabd400e22207e9526f366c8c042d : AbstractRESTStructure<RC_90eaabd400e22207e9526f366c8c042d> {
[JsonProperty("EM_SM_CECO_COSMOZ_Request")]
public ssConectaProveedores.RestRecords.RESTST_abeb699a3b96359819e408d199643162Structure AttrEM_SM_CECO_COSMOZ_Request;

public RESTRC_90eaabd400e22207e9526f366c8c042d() { }

public RESTRC_90eaabd400e22207e9526f366c8c042d (RC_90eaabd400e22207e9526f366c8c042d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Request = ConvertToRestWithoutDefaults(s.ssSTEM_SM_CECO_COSMOZ_Request, new ST_abeb699a3b96359819e408d199643162Structure(), ssConectaProveedores.RestRecords.RESTST_abeb699a3b96359819e408d199643162Structure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_abeb699a3b96359819e408d199643162Structure.FromStructure(s.ssSTEM_SM_CECO_COSMOZ_Request, config);
  }
}

public static RC_90eaabd400e22207e9526f366c8c042d ToStructure(ssConectaProveedores.RestRecords.RESTRC_90eaabd400e22207e9526f366c8c042d obj) { 
  RC_90eaabd400e22207e9526f366c8c042d s = new RC_90eaabd400e22207e9526f366c8c042d();
  if(obj != null) {
  s.ssSTEM_SM_CECO_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_abeb699a3b96359819e408d199643162Structure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Request);
  }
  return s;
}

public static Func<RC_90eaabd400e22207e9526f366c8c042d, ssConectaProveedores.RestRecords.RESTRC_90eaabd400e22207e9526f366c8c042d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_90eaabd400e22207e9526f366c8c042d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_90eaabd400e22207e9526f366c8c042d FromStructure(RC_90eaabd400e22207e9526f366c8c042d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_90eaabd400e22207e9526f366c8c042d(s, config);
}

}


