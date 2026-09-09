using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserLoginResultRecord
public class JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb : AbstractRESTStructure<RC_f9a589fe5b81c3bda7db0e574d5d11fb> {
[JsonProperty("UserLoginResult")]
[JsonPropertyName("UserLoginResult")]
public ssConectaProveedores.RestRecords.JSONST_784fb57b420e5c0c2e1f611378088fbaStructure AttrUserLoginResult;

public JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb() { }

public JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb (RC_f9a589fe5b81c3bda7db0e574d5d11fb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserLoginResult = ConvertToRestWithoutDefaults(s.ssSTUserLoginResult, new ST_784fb57b420e5c0c2e1f611378088fbaStructure(), ssConectaProveedores.RestRecords.JSONST_784fb57b420e5c0c2e1f611378088fbaStructure.FromStructure, config);
  } else {
AttrUserLoginResult = ssConectaProveedores.RestRecords.JSONST_784fb57b420e5c0c2e1f611378088fbaStructure.FromStructure(s.ssSTUserLoginResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb, RC_f9a589fe5b81c3bda7db0e574d5d11fb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb s) => ToStructure(s, config);
}
public static RC_f9a589fe5b81c3bda7db0e574d5d11fb ToStructure(ssConectaProveedores.RestRecords.JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb obj, IBehaviorsConfiguration config) { 
  RC_f9a589fe5b81c3bda7db0e574d5d11fb s = new RC_f9a589fe5b81c3bda7db0e574d5d11fb();
  if(obj != null) {
  s.ssSTUserLoginResult = ssConectaProveedores.RestRecords.JSONST_784fb57b420e5c0c2e1f611378088fbaStructure.ToStructure(obj.AttrUserLoginResult, config);
  }
  return s;
}

public static Func<RC_f9a589fe5b81c3bda7db0e574d5d11fb, ssConectaProveedores.RestRecords.JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f9a589fe5b81c3bda7db0e574d5d11fb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb FromStructure(RC_f9a589fe5b81c3bda7db0e574d5d11fb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f9a589fe5b81c3bda7db0e574d5d11fb(s, config);
}

}


