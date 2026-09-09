using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MainAccConceptsSubAccConceptsRecord
public class JSONRC_baf165956df9a5eebdc813b129b5fb73 : AbstractRESTStructure<RC_baf165956df9a5eebdc813b129b5fb73> {
[JsonProperty("MainAccConcepts")]
[JsonPropertyName("MainAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrMainAccConcepts;

[JsonProperty("SubAccConcepts")]
[JsonPropertyName("SubAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord[] AttrSubAccConcepts;

public JSONRC_baf165956df9a5eebdc813b129b5fb73() { }

public JSONRC_baf165956df9a5eebdc813b129b5fb73 (RC_baf165956df9a5eebdc813b129b5fb73 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMainAccConcepts = ConvertToRestWithoutDefaults(s.ssENMainAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.Length == 0 ? null : s.ssRLSubAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  } else {
AttrMainAccConcepts = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENMainAccConcepts, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.ToArray<ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>(ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_baf165956df9a5eebdc813b129b5fb73, RC_baf165956df9a5eebdc813b129b5fb73> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_baf165956df9a5eebdc813b129b5fb73 s) => ToStructure(s, config);
}
public static RC_baf165956df9a5eebdc813b129b5fb73 ToStructure(ssConectaProveedores.RestRecords.JSONRC_baf165956df9a5eebdc813b129b5fb73 obj, IBehaviorsConfiguration config) { 
  RC_baf165956df9a5eebdc813b129b5fb73 s = new RC_baf165956df9a5eebdc813b129b5fb73();
  if(obj != null) {
  s.ssENMainAccConcepts = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrMainAccConcepts, config);
  s.ssRLSubAccConcepts = RL_eb1e4f883a237aab70c23418de71281c.ToList(obj.AttrSubAccConcepts, ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructureDelegate(config));
  }
  return s;
}

public static Func<RC_baf165956df9a5eebdc813b129b5fb73, ssConectaProveedores.RestRecords.JSONRC_baf165956df9a5eebdc813b129b5fb73> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_baf165956df9a5eebdc813b129b5fb73 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_baf165956df9a5eebdc813b129b5fb73 FromStructure(RC_baf165956df9a5eebdc813b129b5fb73 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_baf165956df9a5eebdc813b129b5fb73(s, config);
}

}


