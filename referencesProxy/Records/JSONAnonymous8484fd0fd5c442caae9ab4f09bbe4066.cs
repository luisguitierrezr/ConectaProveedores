using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_MO_COSMOZ_Request_StructRecord
public class JSONRC_b314153fb124399932b620e84baf5772 : AbstractRESTStructure<RC_b314153fb124399932b620e84baf5772> {
[JsonProperty("EM_SM_MO_COSMOZ_Request_Struct")]
[JsonPropertyName("EM_SM_MO_COSMOZ_Request_Struct")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure AttrEM_SM_MO_COSMOZ_Request_Struct;

public JSONRC_b314153fb124399932b620e84baf5772() { }

public JSONRC_b314153fb124399932b620e84baf5772 (RC_b314153fb124399932b620e84baf5772 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Request_Struct, new ST_e88e810a3be3c7b278de1b477e897388Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b314153fb124399932b620e84baf5772, RC_b314153fb124399932b620e84baf5772> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b314153fb124399932b620e84baf5772 s) => ToStructure(s, config);
}
public static RC_b314153fb124399932b620e84baf5772 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b314153fb124399932b620e84baf5772 obj, IBehaviorsConfiguration config) { 
  RC_b314153fb124399932b620e84baf5772 s = new RC_b314153fb124399932b620e84baf5772();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<RC_b314153fb124399932b620e84baf5772, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b314153fb124399932b620e84baf5772> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b314153fb124399932b620e84baf5772 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b314153fb124399932b620e84baf5772 FromStructure(RC_b314153fb124399932b620e84baf5772 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b314153fb124399932b620e84baf5772(s, config);
}

}


