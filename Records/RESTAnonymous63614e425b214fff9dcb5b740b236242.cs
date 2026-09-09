using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MainAccConceptSubAccConceptsRecord
public class RESTRC_cdb29de40f41bea5403aac7edb2d6159 : AbstractRESTStructure<RC_cdb29de40f41bea5403aac7edb2d6159> {
[JsonProperty("MainAccConcept")]
public ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrMainAccConcept;

[JsonProperty("SubAccConcepts")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> AttrSubAccConcepts;

public RESTRC_cdb29de40f41bea5403aac7edb2d6159() { }

public RESTRC_cdb29de40f41bea5403aac7edb2d6159 (RC_cdb29de40f41bea5403aac7edb2d6159 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMainAccConcept = ConvertToRestWithoutDefaults(s.ssENMainAccConcept, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.Length == 0 ? null : s.ssRLSubAccConcepts.ToRestList<ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  } else {
AttrMainAccConcept = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENMainAccConcept, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.ToRestList<ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  }
}

public static RC_cdb29de40f41bea5403aac7edb2d6159 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cdb29de40f41bea5403aac7edb2d6159 obj) { 
  RC_cdb29de40f41bea5403aac7edb2d6159 s = new RC_cdb29de40f41bea5403aac7edb2d6159();
  if(obj != null) {
  s.ssENMainAccConcept = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrMainAccConcept);
  s.ssRLSubAccConcepts = RL_eb1e4f883a237aab70c23418de71281c.FromRestList(obj.AttrSubAccConcepts, ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure);
  }
  return s;
}

public static Func<RC_cdb29de40f41bea5403aac7edb2d6159, ssConectaProveedores.RestRecords.RESTRC_cdb29de40f41bea5403aac7edb2d6159> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cdb29de40f41bea5403aac7edb2d6159 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cdb29de40f41bea5403aac7edb2d6159 FromStructure(RC_cdb29de40f41bea5403aac7edb2d6159 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cdb29de40f41bea5403aac7edb2d6159(s, config);
}

}


