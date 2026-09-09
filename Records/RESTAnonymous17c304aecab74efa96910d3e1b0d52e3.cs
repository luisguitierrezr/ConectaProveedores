using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Request_StructRecord
public class RESTRC_f55a11d7040a1cc865a8cd2002788075 : AbstractRESTStructure<RC_f55a11d7040a1cc865a8cd2002788075> {
[JsonProperty("EM_SM_RM_COSMOZ_Request_Struct")]
public ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure AttrEM_SM_RM_COSMOZ_Request_Struct;

public RESTRC_f55a11d7040a1cc865a8cd2002788075() { }

public RESTRC_f55a11d7040a1cc865a8cd2002788075 (RC_f55a11d7040a1cc865a8cd2002788075 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_RM_COSMOZ_Request_Struct, new ST_b38fe38940c72474a8e67442651bc995Structure(), ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure.FromStructure(s.ssSTEM_SM_RM_COSMOZ_Request_Struct, config);
  }
}

public static RC_f55a11d7040a1cc865a8cd2002788075 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f55a11d7040a1cc865a8cd2002788075 obj) { 
  RC_f55a11d7040a1cc865a8cd2002788075 s = new RC_f55a11d7040a1cc865a8cd2002788075();
  if(obj != null) {
  s.ssSTEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Request_Struct);
  }
  return s;
}

public static Func<RC_f55a11d7040a1cc865a8cd2002788075, ssConectaProveedores.RestRecords.RESTRC_f55a11d7040a1cc865a8cd2002788075> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f55a11d7040a1cc865a8cd2002788075 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f55a11d7040a1cc865a8cd2002788075 FromStructure(RC_f55a11d7040a1cc865a8cd2002788075 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f55a11d7040a1cc865a8cd2002788075(s, config);
}

}


