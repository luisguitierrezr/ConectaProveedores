using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MainAccConceptSubAccConceptsRecord
public class JSONRC_cdb29de40f41bea5403aac7edb2d6159 : AbstractRESTStructure<RC_cdb29de40f41bea5403aac7edb2d6159> {
[JsonProperty("MainAccConcept")]
[JsonPropertyName("MainAccConcept")]
public ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrMainAccConcept;

[JsonProperty("SubAccConcepts")]
[JsonPropertyName("SubAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord[] AttrSubAccConcepts;

public JSONRC_cdb29de40f41bea5403aac7edb2d6159() { }

public JSONRC_cdb29de40f41bea5403aac7edb2d6159 (RC_cdb29de40f41bea5403aac7edb2d6159 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMainAccConcept = ConvertToRestWithoutDefaults(s.ssENMainAccConcept, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.Length == 0 ? null : s.ssRLSubAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  } else {
AttrMainAccConcept = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENMainAccConcept, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159, RC_cdb29de40f41bea5403aac7edb2d6159> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159 s) => ToStructure(s, config);
}
public static RC_cdb29de40f41bea5403aac7edb2d6159 ToStructure(ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159 obj, IBehaviorsConfiguration config) { 
  RC_cdb29de40f41bea5403aac7edb2d6159 s = new RC_cdb29de40f41bea5403aac7edb2d6159();
  if(obj != null) {
  s.ssENMainAccConcept = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrMainAccConcept, config);
  s.ssRLSubAccConcepts = RL_eb1e4f883a237aab70c23418de71281c.ToList(obj.AttrSubAccConcepts, ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructureDelegate(config));
  }
  return s;
}

public static Func<RC_cdb29de40f41bea5403aac7edb2d6159, ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cdb29de40f41bea5403aac7edb2d6159 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159 FromStructure(RC_cdb29de40f41bea5403aac7edb2d6159 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cdb29de40f41bea5403aac7edb2d6159(s, config);
}

}


