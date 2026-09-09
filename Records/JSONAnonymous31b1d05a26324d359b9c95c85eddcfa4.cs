using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InternalConceptRecord
public class JSONRC_fe70e85a2080a52611f1c24f3043653c : AbstractRESTStructure<RC_fe70e85a2080a52611f1c24f3043653c> {
[JsonProperty("InternalConcept")]
[JsonPropertyName("InternalConcept")]
public ssConectaProveedores.RestRecords.JSONEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord AttrInternalConcept;

public JSONRC_fe70e85a2080a52611f1c24f3043653c() { }

public JSONRC_fe70e85a2080a52611f1c24f3043653c (RC_fe70e85a2080a52611f1c24f3043653c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternalConcept = ConvertToRestWithoutDefaults(s.ssENInternalConcept, new EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord.FromStructure, config);
  } else {
AttrInternalConcept = ssConectaProveedores.RestRecords.JSONEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord.FromStructure(s.ssENInternalConcept, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fe70e85a2080a52611f1c24f3043653c, RC_fe70e85a2080a52611f1c24f3043653c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fe70e85a2080a52611f1c24f3043653c s) => ToStructure(s, config);
}
public static RC_fe70e85a2080a52611f1c24f3043653c ToStructure(ssConectaProveedores.RestRecords.JSONRC_fe70e85a2080a52611f1c24f3043653c obj, IBehaviorsConfiguration config) { 
  RC_fe70e85a2080a52611f1c24f3043653c s = new RC_fe70e85a2080a52611f1c24f3043653c();
  if(obj != null) {
  s.ssENInternalConcept = ssConectaProveedores.RestRecords.JSONEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord.ToStructure(obj.AttrInternalConcept, config);
  }
  return s;
}

public static Func<RC_fe70e85a2080a52611f1c24f3043653c, ssConectaProveedores.RestRecords.JSONRC_fe70e85a2080a52611f1c24f3043653c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fe70e85a2080a52611f1c24f3043653c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fe70e85a2080a52611f1c24f3043653c FromStructure(RC_fe70e85a2080a52611f1c24f3043653c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fe70e85a2080a52611f1c24f3043653c(s, config);
}

}


