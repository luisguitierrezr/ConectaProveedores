using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InternalConceptRecord
public class RESTRC_fe70e85a2080a52611f1c24f3043653c : AbstractRESTStructure<RC_fe70e85a2080a52611f1c24f3043653c> {
[JsonProperty("InternalConcept")]
public ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord AttrInternalConcept;

public RESTRC_fe70e85a2080a52611f1c24f3043653c() { }

public RESTRC_fe70e85a2080a52611f1c24f3043653c (RC_fe70e85a2080a52611f1c24f3043653c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInternalConcept = ConvertToRestWithoutDefaults(s.ssENInternalConcept, new EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord.FromStructure, config);
  } else {
AttrInternalConcept = ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord.FromStructure(s.ssENInternalConcept, config);
  }
}

public static RC_fe70e85a2080a52611f1c24f3043653c ToStructure(ssConectaProveedores.RestRecords.RESTRC_fe70e85a2080a52611f1c24f3043653c obj) { 
  RC_fe70e85a2080a52611f1c24f3043653c s = new RC_fe70e85a2080a52611f1c24f3043653c();
  if(obj != null) {
  s.ssENInternalConcept = ssConectaProveedores.RestRecords.RESTEN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord.ToStructure(obj.AttrInternalConcept);
  }
  return s;
}

public static Func<RC_fe70e85a2080a52611f1c24f3043653c, ssConectaProveedores.RestRecords.RESTRC_fe70e85a2080a52611f1c24f3043653c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fe70e85a2080a52611f1c24f3043653c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fe70e85a2080a52611f1c24f3043653c FromStructure(RC_fe70e85a2080a52611f1c24f3043653c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fe70e85a2080a52611f1c24f3043653c(s, config);
}

}


