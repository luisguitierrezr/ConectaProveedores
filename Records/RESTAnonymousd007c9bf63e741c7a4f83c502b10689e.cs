using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailRecord
public class RESTRC_d95f07a9b902c9473d3a2501fb475225 : AbstractRESTStructure<RC_d95f07a9b902c9473d3a2501fb475225> {
[JsonProperty("Email")]
public string AttrEmail;

public RESTRC_d95f07a9b902c9473d3a2501fb475225() { }

public RESTRC_d95f07a9b902c9473d3a2501fb475225 (RC_d95f07a9b902c9473d3a2501fb475225 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
  } else {
AttrEmail = s.ssEmail;
  }
}

public static RC_d95f07a9b902c9473d3a2501fb475225 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d95f07a9b902c9473d3a2501fb475225 obj) { 
  RC_d95f07a9b902c9473d3a2501fb475225 s = new RC_d95f07a9b902c9473d3a2501fb475225();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  }
  return s;
}

public static Func<RC_d95f07a9b902c9473d3a2501fb475225, ssConectaProveedores.RestRecords.RESTRC_d95f07a9b902c9473d3a2501fb475225> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d95f07a9b902c9473d3a2501fb475225 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d95f07a9b902c9473d3a2501fb475225 FromStructure(RC_d95f07a9b902c9473d3a2501fb475225 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d95f07a9b902c9473d3a2501fb475225(s, config);
}

}


