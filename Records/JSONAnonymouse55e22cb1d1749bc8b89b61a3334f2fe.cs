using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DistributionRecord
public class JSONRC_a6482208c24ce2e6c9c6ba16e57b0185 : AbstractRESTStructure<RC_a6482208c24ce2e6c9c6ba16e57b0185> {
[JsonProperty("Distribution")]
[JsonPropertyName("Distribution")]
public ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord AttrDistribution;

public JSONRC_a6482208c24ce2e6c9c6ba16e57b0185() { }

public JSONRC_a6482208c24ce2e6c9c6ba16e57b0185 (RC_a6482208c24ce2e6c9c6ba16e57b0185 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDistribution = ConvertToRestWithoutDefaults(s.ssENDistribution, new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure, config);
  } else {
AttrDistribution = ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure(s.ssENDistribution, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a6482208c24ce2e6c9c6ba16e57b0185, RC_a6482208c24ce2e6c9c6ba16e57b0185> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a6482208c24ce2e6c9c6ba16e57b0185 s) => ToStructure(s, config);
}
public static RC_a6482208c24ce2e6c9c6ba16e57b0185 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a6482208c24ce2e6c9c6ba16e57b0185 obj, IBehaviorsConfiguration config) { 
  RC_a6482208c24ce2e6c9c6ba16e57b0185 s = new RC_a6482208c24ce2e6c9c6ba16e57b0185();
  if(obj != null) {
  s.ssENDistribution = ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.ToStructure(obj.AttrDistribution, config);
  }
  return s;
}

public static Func<RC_a6482208c24ce2e6c9c6ba16e57b0185, ssConectaProveedores.RestRecords.JSONRC_a6482208c24ce2e6c9c6ba16e57b0185> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6482208c24ce2e6c9c6ba16e57b0185 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a6482208c24ce2e6c9c6ba16e57b0185 FromStructure(RC_a6482208c24ce2e6c9c6ba16e57b0185 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a6482208c24ce2e6c9c6ba16e57b0185(s, config);
}

}


