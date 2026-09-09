using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StepRecord
public class JSONRC_c6d76d2db9750f8821329794e48c8217 : AbstractRESTStructure<RC_c6d76d2db9750f8821329794e48c8217> {
[JsonProperty("Step")]
[JsonPropertyName("Step")]
public ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure AttrStep;

public JSONRC_c6d76d2db9750f8821329794e48c8217() { }

public JSONRC_c6d76d2db9750f8821329794e48c8217 (RC_c6d76d2db9750f8821329794e48c8217 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStep = ConvertToRestWithoutDefaults(s.ssSTStep, new ST_d1e6f35068707165b6684293e397ea3bStructure(), ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure.FromStructure, config);
  } else {
AttrStep = ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure.FromStructure(s.ssSTStep, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c6d76d2db9750f8821329794e48c8217, RC_c6d76d2db9750f8821329794e48c8217> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c6d76d2db9750f8821329794e48c8217 s) => ToStructure(s, config);
}
public static RC_c6d76d2db9750f8821329794e48c8217 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c6d76d2db9750f8821329794e48c8217 obj, IBehaviorsConfiguration config) { 
  RC_c6d76d2db9750f8821329794e48c8217 s = new RC_c6d76d2db9750f8821329794e48c8217();
  if(obj != null) {
  s.ssSTStep = ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure.ToStructure(obj.AttrStep, config);
  }
  return s;
}

public static Func<RC_c6d76d2db9750f8821329794e48c8217, ssConectaProveedores.RestRecords.JSONRC_c6d76d2db9750f8821329794e48c8217> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6d76d2db9750f8821329794e48c8217 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c6d76d2db9750f8821329794e48c8217 FromStructure(RC_c6d76d2db9750f8821329794e48c8217 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c6d76d2db9750f8821329794e48c8217(s, config);
}

}


