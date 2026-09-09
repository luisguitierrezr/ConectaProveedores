using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UniquesCeBeCeCoRecord
public class RESTRC_a1752e53585489f4261982ca1b7d6861 : AbstractRESTStructure<RC_a1752e53585489f4261982ca1b7d6861> {
[JsonProperty("UniquesCeBeCeCo")]
public ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure AttrUniquesCeBeCeCo;

public RESTRC_a1752e53585489f4261982ca1b7d6861() { }

public RESTRC_a1752e53585489f4261982ca1b7d6861 (RC_a1752e53585489f4261982ca1b7d6861 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUniquesCeBeCeCo = ConvertToRestWithoutDefaults(s.ssSTUniquesCeBeCeCo, new ST_ec742cc5ff3341e853c9929e75681fd0Structure(), ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure.FromStructure, config);
  } else {
AttrUniquesCeBeCeCo = ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure.FromStructure(s.ssSTUniquesCeBeCeCo, config);
  }
}

public static RC_a1752e53585489f4261982ca1b7d6861 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a1752e53585489f4261982ca1b7d6861 obj) { 
  RC_a1752e53585489f4261982ca1b7d6861 s = new RC_a1752e53585489f4261982ca1b7d6861();
  if(obj != null) {
  s.ssSTUniquesCeBeCeCo = ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure.ToStructure(obj.AttrUniquesCeBeCeCo);
  }
  return s;
}

public static Func<RC_a1752e53585489f4261982ca1b7d6861, ssConectaProveedores.RestRecords.RESTRC_a1752e53585489f4261982ca1b7d6861> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a1752e53585489f4261982ca1b7d6861 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a1752e53585489f4261982ca1b7d6861 FromStructure(RC_a1752e53585489f4261982ca1b7d6861 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a1752e53585489f4261982ca1b7d6861(s, config);
}

}


