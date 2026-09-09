using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoCaptionsRecord
public class RESTRC_23e4ac7b03ba2050af5811737c8cc89f : AbstractRESTStructure<RC_23e4ac7b03ba2050af5811737c8cc89f> {
[JsonProperty("VideoCaptions")]
public ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure AttrVideoCaptions;

public RESTRC_23e4ac7b03ba2050af5811737c8cc89f() { }

public RESTRC_23e4ac7b03ba2050af5811737c8cc89f (RC_23e4ac7b03ba2050af5811737c8cc89f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideoCaptions = ConvertToRestWithoutDefaults(s.ssSTVideoCaptions, new ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure(), ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.FromStructure, config);
  } else {
AttrVideoCaptions = ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.FromStructure(s.ssSTVideoCaptions, config);
  }
}

public static RC_23e4ac7b03ba2050af5811737c8cc89f ToStructure(ssConectaProveedores.RestRecords.RESTRC_23e4ac7b03ba2050af5811737c8cc89f obj) { 
  RC_23e4ac7b03ba2050af5811737c8cc89f s = new RC_23e4ac7b03ba2050af5811737c8cc89f();
  if(obj != null) {
  s.ssSTVideoCaptions = ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure.ToStructure(obj.AttrVideoCaptions);
  }
  return s;
}

public static Func<RC_23e4ac7b03ba2050af5811737c8cc89f, ssConectaProveedores.RestRecords.RESTRC_23e4ac7b03ba2050af5811737c8cc89f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_23e4ac7b03ba2050af5811737c8cc89f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_23e4ac7b03ba2050af5811737c8cc89f FromStructure(RC_23e4ac7b03ba2050af5811737c8cc89f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_23e4ac7b03ba2050af5811737c8cc89f(s, config);
}

}


