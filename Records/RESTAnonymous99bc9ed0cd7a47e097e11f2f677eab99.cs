using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StepRecord
public class RESTRC_c6d76d2db9750f8821329794e48c8217 : AbstractRESTStructure<RC_c6d76d2db9750f8821329794e48c8217> {
[JsonProperty("Step")]
public ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure AttrStep;

public RESTRC_c6d76d2db9750f8821329794e48c8217() { }

public RESTRC_c6d76d2db9750f8821329794e48c8217 (RC_c6d76d2db9750f8821329794e48c8217 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStep = ConvertToRestWithoutDefaults(s.ssSTStep, new ST_d1e6f35068707165b6684293e397ea3bStructure(), ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure.FromStructure, config);
  } else {
AttrStep = ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure.FromStructure(s.ssSTStep, config);
  }
}

public static RC_c6d76d2db9750f8821329794e48c8217 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c6d76d2db9750f8821329794e48c8217 obj) { 
  RC_c6d76d2db9750f8821329794e48c8217 s = new RC_c6d76d2db9750f8821329794e48c8217();
  if(obj != null) {
  s.ssSTStep = ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure.ToStructure(obj.AttrStep);
  }
  return s;
}

public static Func<RC_c6d76d2db9750f8821329794e48c8217, ssConectaProveedores.RestRecords.RESTRC_c6d76d2db9750f8821329794e48c8217> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6d76d2db9750f8821329794e48c8217 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c6d76d2db9750f8821329794e48c8217 FromStructure(RC_c6d76d2db9750f8821329794e48c8217 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c6d76d2db9750f8821329794e48c8217(s, config);
}

}


