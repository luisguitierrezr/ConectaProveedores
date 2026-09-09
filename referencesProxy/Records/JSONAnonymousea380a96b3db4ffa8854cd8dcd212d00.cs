using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ConceptRecord
public class JSONRC_a70b8366666f6f8d6d35b774d39f9230 : AbstractRESTStructure<RC_a70b8366666f6f8d6d35b774d39f9230> {
[JsonProperty("Concept")]
[JsonPropertyName("Concept")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord AttrConcept;

public JSONRC_a70b8366666f6f8d6d35b774d39f9230() { }

public JSONRC_a70b8366666f6f8d6d35b774d39f9230 (RC_a70b8366666f6f8d6d35b774d39f9230 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrConcept = ConvertToRestWithoutDefaults(s.ssENConcept, new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure, config);
  } else {
AttrConcept = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.FromStructure(s.ssENConcept, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a70b8366666f6f8d6d35b774d39f9230, RC_a70b8366666f6f8d6d35b774d39f9230> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a70b8366666f6f8d6d35b774d39f9230 s) => ToStructure(s, config);
}
public static RC_a70b8366666f6f8d6d35b774d39f9230 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a70b8366666f6f8d6d35b774d39f9230 obj, IBehaviorsConfiguration config) { 
  RC_a70b8366666f6f8d6d35b774d39f9230 s = new RC_a70b8366666f6f8d6d35b774d39f9230();
  if(obj != null) {
  s.ssENConcept = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord.ToStructure(obj.AttrConcept, config);
  }
  return s;
}

public static Func<RC_a70b8366666f6f8d6d35b774d39f9230, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a70b8366666f6f8d6d35b774d39f9230> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a70b8366666f6f8d6d35b774d39f9230 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a70b8366666f6f8d6d35b774d39f9230 FromStructure(RC_a70b8366666f6f8d6d35b774d39f9230 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a70b8366666f6f8d6d35b774d39f9230(s, config);
}

}


