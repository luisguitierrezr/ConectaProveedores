using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MainAccConceptSubAccConceptsRecord
public class JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 : AbstractRESTStructure<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> {
[JsonProperty("MainAccConcept")]
[JsonPropertyName("MainAccConcept")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrMainAccConcept;

[JsonProperty("SubAccConcepts")]
[JsonPropertyName("SubAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord[] AttrSubAccConcepts;

public JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9() { }

public JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 (RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMainAccConcept = ConvertToRestWithoutDefaults(s.ssENMainAccConcept, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.Length == 0 ? null : s.ssRLSubAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord>(ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructureDelegate(config));
  } else {
AttrMainAccConcept = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENMainAccConcept, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord>(ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 s) => ToStructure(s, config);
}
public static RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 obj, IBehaviorsConfiguration config) { 
  RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 s = new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();
  if(obj != null) {
  s.ssENMainAccConcept = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrMainAccConcept, config);
  s.ssRLSubAccConcepts = RL_8927ac1c2e0370738b28382fb988b5ee.ToList(obj.AttrSubAccConcepts, ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructureDelegate(config));
  }
  return s;
}

public static Func<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9, ssConectaProveedores.RestRecords.JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 FromStructure(RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9dc9d00c2e8dcb1797f7869ab9e5a7f9(s, config);
}

}


