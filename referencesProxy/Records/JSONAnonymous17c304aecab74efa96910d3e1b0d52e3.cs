using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_RM_COSMOZ_Request_StructRecord
public class JSONRC_f55a11d7040a1cc865a8cd2002788075 : AbstractRESTStructure<RC_f55a11d7040a1cc865a8cd2002788075> {
[JsonProperty("EM_SM_RM_COSMOZ_Request_Struct")]
[JsonPropertyName("EM_SM_RM_COSMOZ_Request_Struct")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure AttrEM_SM_RM_COSMOZ_Request_Struct;

public JSONRC_f55a11d7040a1cc865a8cd2002788075() { }

public JSONRC_f55a11d7040a1cc865a8cd2002788075 (RC_f55a11d7040a1cc865a8cd2002788075 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_RM_COSMOZ_Request_Struct, new ST_b38fe38940c72474a8e67442651bc995Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.FromStructure(s.ssSTEM_SM_RM_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f55a11d7040a1cc865a8cd2002788075, RC_f55a11d7040a1cc865a8cd2002788075> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f55a11d7040a1cc865a8cd2002788075 s) => ToStructure(s, config);
}
public static RC_f55a11d7040a1cc865a8cd2002788075 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f55a11d7040a1cc865a8cd2002788075 obj, IBehaviorsConfiguration config) { 
  RC_f55a11d7040a1cc865a8cd2002788075 s = new RC_f55a11d7040a1cc865a8cd2002788075();
  if(obj != null) {
  s.ssSTEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<RC_f55a11d7040a1cc865a8cd2002788075, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f55a11d7040a1cc865a8cd2002788075> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f55a11d7040a1cc865a8cd2002788075 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f55a11d7040a1cc865a8cd2002788075 FromStructure(RC_f55a11d7040a1cc865a8cd2002788075 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f55a11d7040a1cc865a8cd2002788075(s, config);
}

}


