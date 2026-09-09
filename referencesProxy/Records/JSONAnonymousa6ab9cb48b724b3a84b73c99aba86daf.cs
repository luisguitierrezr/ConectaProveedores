using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_CECO_COSMOZ_RequestRecord
public class JSONRC_90eaabd400e22207e9526f366c8c042d : AbstractRESTStructure<RC_90eaabd400e22207e9526f366c8c042d> {
[JsonProperty("EM_SM_CECO_COSMOZ_Request")]
[JsonPropertyName("EM_SM_CECO_COSMOZ_Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure AttrEM_SM_CECO_COSMOZ_Request;

public JSONRC_90eaabd400e22207e9526f366c8c042d() { }

public JSONRC_90eaabd400e22207e9526f366c8c042d (RC_90eaabd400e22207e9526f366c8c042d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Request = ConvertToRestWithoutDefaults(s.ssSTEM_SM_CECO_COSMOZ_Request, new ST_abeb699a3b96359819e408d199643162Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Request = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure.FromStructure(s.ssSTEM_SM_CECO_COSMOZ_Request, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_90eaabd400e22207e9526f366c8c042d, RC_90eaabd400e22207e9526f366c8c042d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_90eaabd400e22207e9526f366c8c042d s) => ToStructure(s, config);
}
public static RC_90eaabd400e22207e9526f366c8c042d ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_90eaabd400e22207e9526f366c8c042d obj, IBehaviorsConfiguration config) { 
  RC_90eaabd400e22207e9526f366c8c042d s = new RC_90eaabd400e22207e9526f366c8c042d();
  if(obj != null) {
  s.ssSTEM_SM_CECO_COSMOZ_Request = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Request, config);
  }
  return s;
}

public static Func<RC_90eaabd400e22207e9526f366c8c042d, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_90eaabd400e22207e9526f366c8c042d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_90eaabd400e22207e9526f366c8c042d s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_90eaabd400e22207e9526f366c8c042d FromStructure(RC_90eaabd400e22207e9526f366c8c042d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_90eaabd400e22207e9526f366c8c042d(s, config);
}

}


