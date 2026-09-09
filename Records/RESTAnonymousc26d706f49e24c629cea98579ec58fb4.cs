using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidaCfdResultWrapperRecord
public class RESTRC_f1477873234f7ffa4a835a69241c272d : AbstractRESTStructure<RC_f1477873234f7ffa4a835a69241c272d> {
[JsonProperty("ValidaCfdResultWrapper")]
public ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure AttrValidaCfdResultWrapper;

public RESTRC_f1477873234f7ffa4a835a69241c272d() { }

public RESTRC_f1477873234f7ffa4a835a69241c272d (RC_f1477873234f7ffa4a835a69241c272d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidaCfdResultWrapper = ConvertToRestWithoutDefaults(s.ssSTValidaCfdResultWrapper, new ST_b861b971a77239711f72752e074dae26Structure(), ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure.FromStructure, config);
  } else {
AttrValidaCfdResultWrapper = ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure.FromStructure(s.ssSTValidaCfdResultWrapper, config);
  }
}

public static RC_f1477873234f7ffa4a835a69241c272d ToStructure(ssConectaProveedores.RestRecords.RESTRC_f1477873234f7ffa4a835a69241c272d obj) { 
  RC_f1477873234f7ffa4a835a69241c272d s = new RC_f1477873234f7ffa4a835a69241c272d();
  if(obj != null) {
  s.ssSTValidaCfdResultWrapper = ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure.ToStructure(obj.AttrValidaCfdResultWrapper);
  }
  return s;
}

public static Func<RC_f1477873234f7ffa4a835a69241c272d, ssConectaProveedores.RestRecords.RESTRC_f1477873234f7ffa4a835a69241c272d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f1477873234f7ffa4a835a69241c272d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f1477873234f7ffa4a835a69241c272d FromStructure(RC_f1477873234f7ffa4a835a69241c272d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f1477873234f7ffa4a835a69241c272d(s, config);
}

}


