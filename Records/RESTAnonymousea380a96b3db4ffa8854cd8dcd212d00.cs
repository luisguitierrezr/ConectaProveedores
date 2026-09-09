using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ConceptRecord
public class RESTRC_a70b8366666f6f8d6d35b774d39f9230 : AbstractRESTStructure<RC_a70b8366666f6f8d6d35b774d39f9230> {
[JsonProperty("Concept")]
public ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord AttrConcept;

public RESTRC_a70b8366666f6f8d6d35b774d39f9230() { }

public RESTRC_a70b8366666f6f8d6d35b774d39f9230 (RC_a70b8366666f6f8d6d35b774d39f9230 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrConcept = ConvertToRestWithoutDefaults(s.ssENConcept, new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure, config);
  } else {
AttrConcept = ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure(s.ssENConcept, config);
  }
}

public static RC_a70b8366666f6f8d6d35b774d39f9230 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a70b8366666f6f8d6d35b774d39f9230 obj) { 
  RC_a70b8366666f6f8d6d35b774d39f9230 s = new RC_a70b8366666f6f8d6d35b774d39f9230();
  if(obj != null) {
  s.ssENConcept = ssConectaProveedores.RestRecords.RESTEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.ToStructure(obj.AttrConcept);
  }
  return s;
}

public static Func<RC_a70b8366666f6f8d6d35b774d39f9230, ssConectaProveedores.RestRecords.RESTRC_a70b8366666f6f8d6d35b774d39f9230> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a70b8366666f6f8d6d35b774d39f9230 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a70b8366666f6f8d6d35b774d39f9230 FromStructure(RC_a70b8366666f6f8d6d35b774d39f9230 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a70b8366666f6f8d6d35b774d39f9230(s, config);
}

}


