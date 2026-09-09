using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_Request_StructRecord
public class JSONRC_2a95beba087a746fe5db4671c0cbdf13 : AbstractRESTStructure<RC_2a95beba087a746fe5db4671c0cbdf13> {
[JsonProperty("EM_COSMOZ_Request_Struct")]
[JsonPropertyName("EM_COSMOZ_Request_Struct")]
public ssConectaProveedores.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure AttrEM_COSMOZ_Request_Struct;

public JSONRC_2a95beba087a746fe5db4671c0cbdf13() { }

public JSONRC_2a95beba087a746fe5db4671c0cbdf13 (RC_2a95beba087a746fe5db4671c0cbdf13 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_COSMOZ_Request_Struct, new ST_54b441362fa983751bf9575ed6b668beStructure(), ssConectaProveedores.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.FromStructure(s.ssSTEM_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2a95beba087a746fe5db4671c0cbdf13, RC_2a95beba087a746fe5db4671c0cbdf13> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2a95beba087a746fe5db4671c0cbdf13 s) => ToStructure(s, config);
}
public static RC_2a95beba087a746fe5db4671c0cbdf13 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2a95beba087a746fe5db4671c0cbdf13 obj, IBehaviorsConfiguration config) { 
  RC_2a95beba087a746fe5db4671c0cbdf13 s = new RC_2a95beba087a746fe5db4671c0cbdf13();
  if(obj != null) {
  s.ssSTEM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.ToStructure(obj.AttrEM_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<RC_2a95beba087a746fe5db4671c0cbdf13, ssConectaProveedores.RestRecords.JSONRC_2a95beba087a746fe5db4671c0cbdf13> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a95beba087a746fe5db4671c0cbdf13 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2a95beba087a746fe5db4671c0cbdf13 FromStructure(RC_2a95beba087a746fe5db4671c0cbdf13 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2a95beba087a746fe5db4671c0cbdf13(s, config);
}

}


