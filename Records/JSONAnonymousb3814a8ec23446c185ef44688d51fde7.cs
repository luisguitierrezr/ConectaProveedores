using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserNameRecord
public class JSONRC_3ad59a78981b4fa31a09641e4a914930 : AbstractRESTStructure<RC_3ad59a78981b4fa31a09641e4a914930> {
[JsonProperty("UserName")]
[JsonPropertyName("UserName")]
public string AttrUserName;

public JSONRC_3ad59a78981b4fa31a09641e4a914930() { }

public JSONRC_3ad59a78981b4fa31a09641e4a914930 (RC_3ad59a78981b4fa31a09641e4a914930 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserName = ConvertToRestWithoutDefaults(s.ssUserName, "");
  } else {
AttrUserName = s.ssUserName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3ad59a78981b4fa31a09641e4a914930, RC_3ad59a78981b4fa31a09641e4a914930> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3ad59a78981b4fa31a09641e4a914930 s) => ToStructure(s, config);
}
public static RC_3ad59a78981b4fa31a09641e4a914930 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3ad59a78981b4fa31a09641e4a914930 obj, IBehaviorsConfiguration config) { 
  RC_3ad59a78981b4fa31a09641e4a914930 s = new RC_3ad59a78981b4fa31a09641e4a914930();
  if(obj != null) {
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_3ad59a78981b4fa31a09641e4a914930, ssConectaProveedores.RestRecords.JSONRC_3ad59a78981b4fa31a09641e4a914930> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ad59a78981b4fa31a09641e4a914930 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3ad59a78981b4fa31a09641e4a914930 FromStructure(RC_3ad59a78981b4fa31a09641e4a914930 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3ad59a78981b4fa31a09641e4a914930(s, config);
}

}


