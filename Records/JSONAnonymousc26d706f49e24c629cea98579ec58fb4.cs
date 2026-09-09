using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidaCfdResultWrapperRecord
public class JSONRC_f1477873234f7ffa4a835a69241c272d : AbstractRESTStructure<RC_f1477873234f7ffa4a835a69241c272d> {
[JsonProperty("ValidaCfdResultWrapper")]
[JsonPropertyName("ValidaCfdResultWrapper")]
public ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure AttrValidaCfdResultWrapper;

public JSONRC_f1477873234f7ffa4a835a69241c272d() { }

public JSONRC_f1477873234f7ffa4a835a69241c272d (RC_f1477873234f7ffa4a835a69241c272d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidaCfdResultWrapper = ConvertToRestWithoutDefaults(s.ssSTValidaCfdResultWrapper, new ST_b861b971a77239711f72752e074dae26Structure(), ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure.FromStructure, config);
  } else {
AttrValidaCfdResultWrapper = ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure.FromStructure(s.ssSTValidaCfdResultWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f1477873234f7ffa4a835a69241c272d, RC_f1477873234f7ffa4a835a69241c272d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f1477873234f7ffa4a835a69241c272d s) => ToStructure(s, config);
}
public static RC_f1477873234f7ffa4a835a69241c272d ToStructure(ssConectaProveedores.RestRecords.JSONRC_f1477873234f7ffa4a835a69241c272d obj, IBehaviorsConfiguration config) { 
  RC_f1477873234f7ffa4a835a69241c272d s = new RC_f1477873234f7ffa4a835a69241c272d();
  if(obj != null) {
  s.ssSTValidaCfdResultWrapper = ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure.ToStructure(obj.AttrValidaCfdResultWrapper, config);
  }
  return s;
}

public static Func<RC_f1477873234f7ffa4a835a69241c272d, ssConectaProveedores.RestRecords.JSONRC_f1477873234f7ffa4a835a69241c272d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f1477873234f7ffa4a835a69241c272d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f1477873234f7ffa4a835a69241c272d FromStructure(RC_f1477873234f7ffa4a835a69241c272d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f1477873234f7ffa4a835a69241c272d(s, config);
}

}


