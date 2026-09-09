using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActionResultRecord
public class RESTRC_485b607178d0c84cbed628be5b894f6f : AbstractRESTStructure<RC_485b607178d0c84cbed628be5b894f6f> {
[JsonProperty("ActionResult")]
public ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure AttrActionResult;

public RESTRC_485b607178d0c84cbed628be5b894f6f() { }

public RESTRC_485b607178d0c84cbed628be5b894f6f (RC_485b607178d0c84cbed628be5b894f6f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActionResult = ConvertToRestWithoutDefaults(s.ssSTActionResult, new ST_9f3831cec6ebd34416b59b8df7a27893Structure(), ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure.FromStructure, config);
  } else {
AttrActionResult = ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure.FromStructure(s.ssSTActionResult, config);
  }
}

public static RC_485b607178d0c84cbed628be5b894f6f ToStructure(ssConectaProveedores.RestRecords.RESTRC_485b607178d0c84cbed628be5b894f6f obj) { 
  RC_485b607178d0c84cbed628be5b894f6f s = new RC_485b607178d0c84cbed628be5b894f6f();
  if(obj != null) {
  s.ssSTActionResult = ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure.ToStructure(obj.AttrActionResult);
  }
  return s;
}

public static Func<RC_485b607178d0c84cbed628be5b894f6f, ssConectaProveedores.RestRecords.RESTRC_485b607178d0c84cbed628be5b894f6f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_485b607178d0c84cbed628be5b894f6f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_485b607178d0c84cbed628be5b894f6f FromStructure(RC_485b607178d0c84cbed628be5b894f6f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_485b607178d0c84cbed628be5b894f6f(s, config);
}

}


