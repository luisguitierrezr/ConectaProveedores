using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemSM_MORecord
public class RESTRC_cd6f33f299248253665f3cd688191346 : AbstractRESTStructure<RC_cd6f33f299248253665f3cd688191346> {
[JsonProperty("ItemSM_MO")]
public ssConectaProveedores.RestRecords.RESTST_67da2825930e4cc01dda17107c43d1e6Structure AttrItemSM_MO;

public RESTRC_cd6f33f299248253665f3cd688191346() { }

public RESTRC_cd6f33f299248253665f3cd688191346 (RC_cd6f33f299248253665f3cd688191346 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemSM_MO = ConvertToRestWithoutDefaults(s.ssSTItemSM_MO, new ST_67da2825930e4cc01dda17107c43d1e6Structure(), ssConectaProveedores.RestRecords.RESTST_67da2825930e4cc01dda17107c43d1e6Structure.FromStructure, config);
  } else {
AttrItemSM_MO = ssConectaProveedores.RestRecords.RESTST_67da2825930e4cc01dda17107c43d1e6Structure.FromStructure(s.ssSTItemSM_MO, config);
  }
}

public static RC_cd6f33f299248253665f3cd688191346 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cd6f33f299248253665f3cd688191346 obj) { 
  RC_cd6f33f299248253665f3cd688191346 s = new RC_cd6f33f299248253665f3cd688191346();
  if(obj != null) {
  s.ssSTItemSM_MO = ssConectaProveedores.RestRecords.RESTST_67da2825930e4cc01dda17107c43d1e6Structure.ToStructure(obj.AttrItemSM_MO);
  }
  return s;
}

public static Func<RC_cd6f33f299248253665f3cd688191346, ssConectaProveedores.RestRecords.RESTRC_cd6f33f299248253665f3cd688191346> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cd6f33f299248253665f3cd688191346 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cd6f33f299248253665f3cd688191346 FromStructure(RC_cd6f33f299248253665f3cd688191346 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cd6f33f299248253665f3cd688191346(s, config);
}

}


