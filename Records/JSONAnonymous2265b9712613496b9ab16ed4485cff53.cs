using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemSM_RMRecord
public class JSONRC_460505b3c40cd288809440d484d2598e : AbstractRESTStructure<RC_460505b3c40cd288809440d484d2598e> {
[JsonProperty("ItemSM_RM")]
[JsonPropertyName("ItemSM_RM")]
public ssConectaProveedores.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure AttrItemSM_RM;

public JSONRC_460505b3c40cd288809440d484d2598e() { }

public JSONRC_460505b3c40cd288809440d484d2598e (RC_460505b3c40cd288809440d484d2598e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemSM_RM = ConvertToRestWithoutDefaults(s.ssSTItemSM_RM, new ST_c6a30ab803e481b26794961e87468e52Structure(), ssConectaProveedores.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure.FromStructure, config);
  } else {
AttrItemSM_RM = ssConectaProveedores.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure.FromStructure(s.ssSTItemSM_RM, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_460505b3c40cd288809440d484d2598e, RC_460505b3c40cd288809440d484d2598e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_460505b3c40cd288809440d484d2598e s) => ToStructure(s, config);
}
public static RC_460505b3c40cd288809440d484d2598e ToStructure(ssConectaProveedores.RestRecords.JSONRC_460505b3c40cd288809440d484d2598e obj, IBehaviorsConfiguration config) { 
  RC_460505b3c40cd288809440d484d2598e s = new RC_460505b3c40cd288809440d484d2598e();
  if(obj != null) {
  s.ssSTItemSM_RM = ssConectaProveedores.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure.ToStructure(obj.AttrItemSM_RM, config);
  }
  return s;
}

public static Func<RC_460505b3c40cd288809440d484d2598e, ssConectaProveedores.RestRecords.JSONRC_460505b3c40cd288809440d484d2598e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_460505b3c40cd288809440d484d2598e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_460505b3c40cd288809440d484d2598e FromStructure(RC_460505b3c40cd288809440d484d2598e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_460505b3c40cd288809440d484d2598e(s, config);
}

}


