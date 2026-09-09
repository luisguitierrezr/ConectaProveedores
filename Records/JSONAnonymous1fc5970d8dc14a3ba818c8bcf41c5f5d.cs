using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostValidacfdiprovResponseWrapperRecord
public class JSONRC_a668f8121762731dd2d951328537ae6f : AbstractRESTStructure<RC_a668f8121762731dd2d951328537ae6f> {
[JsonProperty("PostValidacfdiprovResponseWrapper")]
[JsonPropertyName("PostValidacfdiprovResponseWrapper")]
public ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure AttrPostValidacfdiprovResponseWrapper;

public JSONRC_a668f8121762731dd2d951328537ae6f() { }

public JSONRC_a668f8121762731dd2d951328537ae6f (RC_a668f8121762731dd2d951328537ae6f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostValidacfdiprovResponseWrapper = ConvertToRestWithoutDefaults(s.ssSTPostValidacfdiprovResponseWrapper, new ST_13caff817360521524d01995a65282cdStructure(), ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure.FromStructure, config);
  } else {
AttrPostValidacfdiprovResponseWrapper = ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure.FromStructure(s.ssSTPostValidacfdiprovResponseWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a668f8121762731dd2d951328537ae6f, RC_a668f8121762731dd2d951328537ae6f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a668f8121762731dd2d951328537ae6f s) => ToStructure(s, config);
}
public static RC_a668f8121762731dd2d951328537ae6f ToStructure(ssConectaProveedores.RestRecords.JSONRC_a668f8121762731dd2d951328537ae6f obj, IBehaviorsConfiguration config) { 
  RC_a668f8121762731dd2d951328537ae6f s = new RC_a668f8121762731dd2d951328537ae6f();
  if(obj != null) {
  s.ssSTPostValidacfdiprovResponseWrapper = ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure.ToStructure(obj.AttrPostValidacfdiprovResponseWrapper, config);
  }
  return s;
}

public static Func<RC_a668f8121762731dd2d951328537ae6f, ssConectaProveedores.RestRecords.JSONRC_a668f8121762731dd2d951328537ae6f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a668f8121762731dd2d951328537ae6f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a668f8121762731dd2d951328537ae6f FromStructure(RC_a668f8121762731dd2d951328537ae6f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a668f8121762731dd2d951328537ae6f(s, config);
}

}


