using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_Response_StructRecord
public class JSONRC_867a4629d09a2662a976db33711cd1ff : AbstractRESTStructure<RC_867a4629d09a2662a976db33711cd1ff> {
[JsonProperty("EM_SM_MO_COSMOZ_Response_Struct")]
[JsonPropertyName("EM_SM_MO_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure AttrEM_SM_MO_COSMOZ_Response_Struct;

public JSONRC_867a4629d09a2662a976db33711cd1ff() { }

public JSONRC_867a4629d09a2662a976db33711cd1ff (RC_867a4629d09a2662a976db33711cd1ff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_MO_COSMOZ_Response_Struct, new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure(), ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.FromStructure(s.ssSTEM_SM_MO_COSMOZ_Response_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_867a4629d09a2662a976db33711cd1ff, RC_867a4629d09a2662a976db33711cd1ff> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_867a4629d09a2662a976db33711cd1ff s) => ToStructure(s, config);
}
public static RC_867a4629d09a2662a976db33711cd1ff ToStructure(ssConectaProveedores.RestRecords.JSONRC_867a4629d09a2662a976db33711cd1ff obj, IBehaviorsConfiguration config) { 
  RC_867a4629d09a2662a976db33711cd1ff s = new RC_867a4629d09a2662a976db33711cd1ff();
  if(obj != null) {
  s.ssSTEM_SM_MO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Response_Struct, config);
  }
  return s;
}

public static Func<RC_867a4629d09a2662a976db33711cd1ff, ssConectaProveedores.RestRecords.JSONRC_867a4629d09a2662a976db33711cd1ff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_867a4629d09a2662a976db33711cd1ff s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_867a4629d09a2662a976db33711cd1ff FromStructure(RC_867a4629d09a2662a976db33711cd1ff s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_867a4629d09a2662a976db33711cd1ff(s, config);
}

}


