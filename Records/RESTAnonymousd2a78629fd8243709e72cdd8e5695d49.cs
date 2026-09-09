using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MainAccConceptsSubAccConceptsRecord
public class RESTRC_dd1ef552e394be88b7a9660ce51d9447 : AbstractRESTStructure<RC_dd1ef552e394be88b7a9660ce51d9447> {
[JsonProperty("MainAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrMainAccConcepts;

[JsonProperty("SubAccConcepts")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord> AttrSubAccConcepts;

public RESTRC_dd1ef552e394be88b7a9660ce51d9447() { }

public RESTRC_dd1ef552e394be88b7a9660ce51d9447 (RC_dd1ef552e394be88b7a9660ce51d9447 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMainAccConcepts = ConvertToRestWithoutDefaults(s.ssENMainAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.Length == 0 ? null : s.ssRLSubAccConcepts.ToRestList<ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord>(ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructureDelegate(config));
  } else {
AttrMainAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENMainAccConcepts, config);
AttrSubAccConcepts = s.ssRLSubAccConcepts.ToRestList<ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord>(ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructureDelegate(config));
  }
}

public static RC_dd1ef552e394be88b7a9660ce51d9447 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dd1ef552e394be88b7a9660ce51d9447 obj) { 
  RC_dd1ef552e394be88b7a9660ce51d9447 s = new RC_dd1ef552e394be88b7a9660ce51d9447();
  if(obj != null) {
  s.ssENMainAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrMainAccConcepts);
  s.ssRLSubAccConcepts = RL_8927ac1c2e0370738b28382fb988b5ee.FromRestList(obj.AttrSubAccConcepts, ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure);
  }
  return s;
}

public static Func<RC_dd1ef552e394be88b7a9660ce51d9447, ssConectaProveedores.RestRecords.RESTRC_dd1ef552e394be88b7a9660ce51d9447> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dd1ef552e394be88b7a9660ce51d9447 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dd1ef552e394be88b7a9660ce51d9447 FromStructure(RC_dd1ef552e394be88b7a9660ce51d9447 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dd1ef552e394be88b7a9660ce51d9447(s, config);
}

}


