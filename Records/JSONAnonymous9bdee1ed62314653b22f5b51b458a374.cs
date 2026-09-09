using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// URLQueryParameterRecord
public class JSONRC_60d938a257fca2197ed801370b55468f : AbstractRESTStructure<RC_60d938a257fca2197ed801370b55468f> {
[JsonProperty("URLQueryParameter")]
[JsonPropertyName("URLQueryParameter")]
public ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure AttrURLQueryParameter;

public JSONRC_60d938a257fca2197ed801370b55468f() { }

public JSONRC_60d938a257fca2197ed801370b55468f (RC_60d938a257fca2197ed801370b55468f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrURLQueryParameter = ConvertToRestWithoutDefaults(s.ssSTURLQueryParameter, new ST_f9be77c0ae9485d53ded05b1557548f9Structure(), ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructure, config);
  } else {
AttrURLQueryParameter = ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructure(s.ssSTURLQueryParameter, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_60d938a257fca2197ed801370b55468f, RC_60d938a257fca2197ed801370b55468f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_60d938a257fca2197ed801370b55468f s) => ToStructure(s, config);
}
public static RC_60d938a257fca2197ed801370b55468f ToStructure(ssConectaProveedores.RestRecords.JSONRC_60d938a257fca2197ed801370b55468f obj, IBehaviorsConfiguration config) { 
  RC_60d938a257fca2197ed801370b55468f s = new RC_60d938a257fca2197ed801370b55468f();
  if(obj != null) {
  s.ssSTURLQueryParameter = ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure.ToStructure(obj.AttrURLQueryParameter, config);
  }
  return s;
}

public static Func<RC_60d938a257fca2197ed801370b55468f, ssConectaProveedores.RestRecords.JSONRC_60d938a257fca2197ed801370b55468f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60d938a257fca2197ed801370b55468f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_60d938a257fca2197ed801370b55468f FromStructure(RC_60d938a257fca2197ed801370b55468f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_60d938a257fca2197ed801370b55468f(s, config);
}

}


