using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ItemSM_MORecord
public class JSONRC_cd6f33f299248253665f3cd688191346 : AbstractRESTStructure<RC_cd6f33f299248253665f3cd688191346> {
[JsonProperty("ItemSM_MO")]
[JsonPropertyName("ItemSM_MO")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure AttrItemSM_MO;

public JSONRC_cd6f33f299248253665f3cd688191346() { }

public JSONRC_cd6f33f299248253665f3cd688191346 (RC_cd6f33f299248253665f3cd688191346 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemSM_MO = ConvertToRestWithoutDefaults(s.ssSTItemSM_MO, new ST_67da2825930e4cc01dda17107c43d1e6Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure.FromStructure, config);
  } else {
AttrItemSM_MO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure.FromStructure(s.ssSTItemSM_MO, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cd6f33f299248253665f3cd688191346, RC_cd6f33f299248253665f3cd688191346> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cd6f33f299248253665f3cd688191346 s) => ToStructure(s, config);
}
public static RC_cd6f33f299248253665f3cd688191346 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cd6f33f299248253665f3cd688191346 obj, IBehaviorsConfiguration config) { 
  RC_cd6f33f299248253665f3cd688191346 s = new RC_cd6f33f299248253665f3cd688191346();
  if(obj != null) {
  s.ssSTItemSM_MO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure.ToStructure(obj.AttrItemSM_MO, config);
  }
  return s;
}

public static Func<RC_cd6f33f299248253665f3cd688191346, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cd6f33f299248253665f3cd688191346> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cd6f33f299248253665f3cd688191346 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cd6f33f299248253665f3cd688191346 FromStructure(RC_cd6f33f299248253665f3cd688191346 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cd6f33f299248253665f3cd688191346(s, config);
}

}


