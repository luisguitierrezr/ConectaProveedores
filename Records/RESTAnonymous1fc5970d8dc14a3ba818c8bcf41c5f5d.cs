using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostValidacfdiprovResponseWrapperRecord
public class RESTRC_a668f8121762731dd2d951328537ae6f : AbstractRESTStructure<RC_a668f8121762731dd2d951328537ae6f> {
[JsonProperty("PostValidacfdiprovResponseWrapper")]
public ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure AttrPostValidacfdiprovResponseWrapper;

public RESTRC_a668f8121762731dd2d951328537ae6f() { }

public RESTRC_a668f8121762731dd2d951328537ae6f (RC_a668f8121762731dd2d951328537ae6f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostValidacfdiprovResponseWrapper = ConvertToRestWithoutDefaults(s.ssSTPostValidacfdiprovResponseWrapper, new ST_13caff817360521524d01995a65282cdStructure(), ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure.FromStructure, config);
  } else {
AttrPostValidacfdiprovResponseWrapper = ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure.FromStructure(s.ssSTPostValidacfdiprovResponseWrapper, config);
  }
}

public static RC_a668f8121762731dd2d951328537ae6f ToStructure(ssConectaProveedores.RestRecords.RESTRC_a668f8121762731dd2d951328537ae6f obj) { 
  RC_a668f8121762731dd2d951328537ae6f s = new RC_a668f8121762731dd2d951328537ae6f();
  if(obj != null) {
  s.ssSTPostValidacfdiprovResponseWrapper = ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure.ToStructure(obj.AttrPostValidacfdiprovResponseWrapper);
  }
  return s;
}

public static Func<RC_a668f8121762731dd2d951328537ae6f, ssConectaProveedores.RestRecords.RESTRC_a668f8121762731dd2d951328537ae6f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a668f8121762731dd2d951328537ae6f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a668f8121762731dd2d951328537ae6f FromStructure(RC_a668f8121762731dd2d951328537ae6f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a668f8121762731dd2d951328537ae6f(s, config);
}

}


