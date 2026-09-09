using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// URLQueryParameterRecord
public class RESTRC_60d938a257fca2197ed801370b55468f : AbstractRESTStructure<RC_60d938a257fca2197ed801370b55468f> {
[JsonProperty("URLQueryParameter")]
public ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure AttrURLQueryParameter;

public RESTRC_60d938a257fca2197ed801370b55468f() { }

public RESTRC_60d938a257fca2197ed801370b55468f (RC_60d938a257fca2197ed801370b55468f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrURLQueryParameter = ConvertToRestWithoutDefaults(s.ssSTURLQueryParameter, new ST_f9be77c0ae9485d53ded05b1557548f9Structure(), ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructure, config);
  } else {
AttrURLQueryParameter = ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructure(s.ssSTURLQueryParameter, config);
  }
}

public static RC_60d938a257fca2197ed801370b55468f ToStructure(ssConectaProveedores.RestRecords.RESTRC_60d938a257fca2197ed801370b55468f obj) { 
  RC_60d938a257fca2197ed801370b55468f s = new RC_60d938a257fca2197ed801370b55468f();
  if(obj != null) {
  s.ssSTURLQueryParameter = ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure.ToStructure(obj.AttrURLQueryParameter);
  }
  return s;
}

public static Func<RC_60d938a257fca2197ed801370b55468f, ssConectaProveedores.RestRecords.RESTRC_60d938a257fca2197ed801370b55468f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60d938a257fca2197ed801370b55468f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_60d938a257fca2197ed801370b55468f FromStructure(RC_60d938a257fca2197ed801370b55468f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_60d938a257fca2197ed801370b55468f(s, config);
}

}


