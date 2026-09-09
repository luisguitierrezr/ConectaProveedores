using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActionResultRecord
public class JSONRC_485b607178d0c84cbed628be5b894f6f : AbstractRESTStructure<RC_485b607178d0c84cbed628be5b894f6f> {
[JsonProperty("ActionResult")]
[JsonPropertyName("ActionResult")]
public ssConectaProveedores.RestRecords.JSONST_9f3831cec6ebd34416b59b8df7a27893Structure AttrActionResult;

public JSONRC_485b607178d0c84cbed628be5b894f6f() { }

public JSONRC_485b607178d0c84cbed628be5b894f6f (RC_485b607178d0c84cbed628be5b894f6f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActionResult = ConvertToRestWithoutDefaults(s.ssSTActionResult, new ST_9f3831cec6ebd34416b59b8df7a27893Structure(), ssConectaProveedores.RestRecords.JSONST_9f3831cec6ebd34416b59b8df7a27893Structure.FromStructure, config);
  } else {
AttrActionResult = ssConectaProveedores.RestRecords.JSONST_9f3831cec6ebd34416b59b8df7a27893Structure.FromStructure(s.ssSTActionResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_485b607178d0c84cbed628be5b894f6f, RC_485b607178d0c84cbed628be5b894f6f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_485b607178d0c84cbed628be5b894f6f s) => ToStructure(s, config);
}
public static RC_485b607178d0c84cbed628be5b894f6f ToStructure(ssConectaProveedores.RestRecords.JSONRC_485b607178d0c84cbed628be5b894f6f obj, IBehaviorsConfiguration config) { 
  RC_485b607178d0c84cbed628be5b894f6f s = new RC_485b607178d0c84cbed628be5b894f6f();
  if(obj != null) {
  s.ssSTActionResult = ssConectaProveedores.RestRecords.JSONST_9f3831cec6ebd34416b59b8df7a27893Structure.ToStructure(obj.AttrActionResult, config);
  }
  return s;
}

public static Func<RC_485b607178d0c84cbed628be5b894f6f, ssConectaProveedores.RestRecords.JSONRC_485b607178d0c84cbed628be5b894f6f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_485b607178d0c84cbed628be5b894f6f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_485b607178d0c84cbed628be5b894f6f FromStructure(RC_485b607178d0c84cbed628be5b894f6f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_485b607178d0c84cbed628be5b894f6f(s, config);
}

}


