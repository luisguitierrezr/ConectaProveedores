using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MainAccConceptsSubAccConceptsRecord
public class RESTRC_baf165956df9a5eebdc813b129b5fb73 : AbstractRESTStructure<RC_baf165956df9a5eebdc813b129b5fb73> {
[JsonProperty("MainAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrMainAccConcepts;

[JsonProperty("SubAccConcepts")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> AttrSubAccConcepts;

public RESTRC_baf165956df9a5eebdc813b129b5fb73() { }

public RESTRC_baf165956df9a5eebdc813b129b5fb73 (RC_baf165956df9a5eebdc813b129b5fb73 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMainAccConcepts = ConvertToRestWithoutDefaults(s.ssENMainAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.Length == 0 ? null : s.ssRLSubAccConcepts.ToRestList<ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  } else {
AttrMainAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENMainAccConcepts, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.ToRestList<ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  }
}

public static RC_baf165956df9a5eebdc813b129b5fb73 ToStructure(ssConectaProveedores.RestRecords.RESTRC_baf165956df9a5eebdc813b129b5fb73 obj) { 
  RC_baf165956df9a5eebdc813b129b5fb73 s = new RC_baf165956df9a5eebdc813b129b5fb73();
  if(obj != null) {
  s.ssENMainAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrMainAccConcepts);
  s.ssRLSubAccConcepts = RL_eb1e4f883a237aab70c23418de71281c.FromRestList(obj.AttrSubAccConcepts, ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure);
  }
  return s;
}

public static Func<RC_baf165956df9a5eebdc813b129b5fb73, ssConectaProveedores.RestRecords.RESTRC_baf165956df9a5eebdc813b129b5fb73> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_baf165956df9a5eebdc813b129b5fb73 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_baf165956df9a5eebdc813b129b5fb73 FromStructure(RC_baf165956df9a5eebdc813b129b5fb73 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_baf165956df9a5eebdc813b129b5fb73(s, config);
}

}


