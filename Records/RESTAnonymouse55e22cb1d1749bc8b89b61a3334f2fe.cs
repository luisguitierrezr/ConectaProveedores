using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DistributionRecord
public class RESTRC_a6482208c24ce2e6c9c6ba16e57b0185 : AbstractRESTStructure<RC_a6482208c24ce2e6c9c6ba16e57b0185> {
[JsonProperty("Distribution")]
public ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord AttrDistribution;

public RESTRC_a6482208c24ce2e6c9c6ba16e57b0185() { }

public RESTRC_a6482208c24ce2e6c9c6ba16e57b0185 (RC_a6482208c24ce2e6c9c6ba16e57b0185 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDistribution = ConvertToRestWithoutDefaults(s.ssENDistribution, new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure, config);
  } else {
AttrDistribution = ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure(s.ssENDistribution, config);
  }
}

public static RC_a6482208c24ce2e6c9c6ba16e57b0185 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185 obj) { 
  RC_a6482208c24ce2e6c9c6ba16e57b0185 s = new RC_a6482208c24ce2e6c9c6ba16e57b0185();
  if(obj != null) {
  s.ssENDistribution = ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.ToStructure(obj.AttrDistribution);
  }
  return s;
}

public static Func<RC_a6482208c24ce2e6c9c6ba16e57b0185, ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6482208c24ce2e6c9c6ba16e57b0185 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185 FromStructure(RC_a6482208c24ce2e6c9c6ba16e57b0185 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185(s, config);
}

}


