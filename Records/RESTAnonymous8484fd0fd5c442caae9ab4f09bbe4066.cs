using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_Request_StructRecord
public class RESTRC_b314153fb124399932b620e84baf5772 : AbstractRESTStructure<RC_b314153fb124399932b620e84baf5772> {
[JsonProperty("EM_SM_MO_COSMOZ_Request_Struct")]
public ssConectaProveedores.RestRecords.RESTST_e88e810a3be3c7b278de1b477e897388Structure AttrEM_SM_MO_COSMOZ_Request_Struct;

public RESTRC_b314153fb124399932b620e84baf5772() { }

public RESTRC_b314153fb124399932b620e84baf5772 (RC_b314153fb124399932b620e84baf5772 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Request_Struct, new ST_e88e810a3be3c7b278de1b477e897388Structure(), ssConectaProveedores.RestRecords.RESTST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Request_Struct, config);
  }
}

public static RC_b314153fb124399932b620e84baf5772 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b314153fb124399932b620e84baf5772 obj) { 
  RC_b314153fb124399932b620e84baf5772 s = new RC_b314153fb124399932b620e84baf5772();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_e88e810a3be3c7b278de1b477e897388Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Request_Struct);
  }
  return s;
}

public static Func<RC_b314153fb124399932b620e84baf5772, ssConectaProveedores.RestRecords.RESTRC_b314153fb124399932b620e84baf5772> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b314153fb124399932b620e84baf5772 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b314153fb124399932b620e84baf5772 FromStructure(RC_b314153fb124399932b620e84baf5772 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b314153fb124399932b620e84baf5772(s, config);
}

}


