using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UniquesCeBeCeCoRecord
public class JSONRC_a1752e53585489f4261982ca1b7d6861 : AbstractRESTStructure<RC_a1752e53585489f4261982ca1b7d6861> {
[JsonProperty("UniquesCeBeCeCo")]
[JsonPropertyName("UniquesCeBeCeCo")]
public ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure AttrUniquesCeBeCeCo;

public JSONRC_a1752e53585489f4261982ca1b7d6861() { }

public JSONRC_a1752e53585489f4261982ca1b7d6861 (RC_a1752e53585489f4261982ca1b7d6861 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniquesCeBeCeCo = ConvertToRestWithoutDefaults(s.ssSTUniquesCeBeCeCo, new ST_ec742cc5ff3341e853c9929e75681fd0Structure(), ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure.FromStructure, config);
  } else {
AttrUniquesCeBeCeCo = ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure.FromStructure(s.ssSTUniquesCeBeCeCo, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a1752e53585489f4261982ca1b7d6861, RC_a1752e53585489f4261982ca1b7d6861> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a1752e53585489f4261982ca1b7d6861 s) => ToStructure(s, config);
}
public static RC_a1752e53585489f4261982ca1b7d6861 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a1752e53585489f4261982ca1b7d6861 obj, IBehaviorsConfiguration config) { 
  RC_a1752e53585489f4261982ca1b7d6861 s = new RC_a1752e53585489f4261982ca1b7d6861();
  if(obj != null) {
  s.ssSTUniquesCeBeCeCo = ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure.ToStructure(obj.AttrUniquesCeBeCeCo, config);
  }
  return s;
}

public static Func<RC_a1752e53585489f4261982ca1b7d6861, ssConectaProveedores.RestRecords.JSONRC_a1752e53585489f4261982ca1b7d6861> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a1752e53585489f4261982ca1b7d6861 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a1752e53585489f4261982ca1b7d6861 FromStructure(RC_a1752e53585489f4261982ca1b7d6861 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a1752e53585489f4261982ca1b7d6861(s, config);
}

}


