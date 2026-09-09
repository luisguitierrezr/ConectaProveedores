using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserNameRecord
public class RESTRC_3ad59a78981b4fa31a09641e4a914930 : AbstractRESTStructure<RC_3ad59a78981b4fa31a09641e4a914930> {
[JsonProperty("UserName")]
public string AttrUserName;

public RESTRC_3ad59a78981b4fa31a09641e4a914930() { }

public RESTRC_3ad59a78981b4fa31a09641e4a914930 (RC_3ad59a78981b4fa31a09641e4a914930 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserName = ConvertToRestWithoutDefaults(s.ssUserName, "");
  } else {
AttrUserName = s.ssUserName;
  }
}

public static RC_3ad59a78981b4fa31a09641e4a914930 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930 obj) { 
  RC_3ad59a78981b4fa31a09641e4a914930 s = new RC_3ad59a78981b4fa31a09641e4a914930();
  if(obj != null) {
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_3ad59a78981b4fa31a09641e4a914930, ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ad59a78981b4fa31a09641e4a914930 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930 FromStructure(RC_3ad59a78981b4fa31a09641e4a914930 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3ad59a78981b4fa31a09641e4a914930(s, config);
}

}


