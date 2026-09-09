using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_Request_StructRecord
public class RESTRC_2a95beba087a746fe5db4671c0cbdf13 : AbstractRESTStructure<RC_2a95beba087a746fe5db4671c0cbdf13> {
[JsonProperty("EM_COSMOZ_Request_Struct")]
public ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure AttrEM_COSMOZ_Request_Struct;

public RESTRC_2a95beba087a746fe5db4671c0cbdf13() { }

public RESTRC_2a95beba087a746fe5db4671c0cbdf13 (RC_2a95beba087a746fe5db4671c0cbdf13 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_COSMOZ_Request_Struct, new ST_54b441362fa983751bf9575ed6b668beStructure(), ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure.FromStructure(s.ssSTEM_COSMOZ_Request_Struct, config);
  }
}

public static RC_2a95beba087a746fe5db4671c0cbdf13 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2a95beba087a746fe5db4671c0cbdf13 obj) { 
  RC_2a95beba087a746fe5db4671c0cbdf13 s = new RC_2a95beba087a746fe5db4671c0cbdf13();
  if(obj != null) {
  s.ssSTEM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure.ToStructure(obj.AttrEM_COSMOZ_Request_Struct);
  }
  return s;
}

public static Func<RC_2a95beba087a746fe5db4671c0cbdf13, ssConectaProveedores.RestRecords.RESTRC_2a95beba087a746fe5db4671c0cbdf13> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a95beba087a746fe5db4671c0cbdf13 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2a95beba087a746fe5db4671c0cbdf13 FromStructure(RC_2a95beba087a746fe5db4671c0cbdf13 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2a95beba087a746fe5db4671c0cbdf13(s, config);
}

}


