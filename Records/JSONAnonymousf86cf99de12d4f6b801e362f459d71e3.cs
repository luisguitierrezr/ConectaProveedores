using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdRolenameUserNameRecord
public class JSONRC_7170c97aaf61dfa14af07f5ef3cecd45 : AbstractRESTStructure<RC_7170c97aaf61dfa14af07f5ef3cecd45> {
[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("Rolename")]
[JsonPropertyName("Rolename")]
public string AttrRolename;

[JsonProperty("UserName")]
[JsonPropertyName("UserName")]
public string AttrUserName;

public JSONRC_7170c97aaf61dfa14af07f5ef3cecd45() { }

public JSONRC_7170c97aaf61dfa14af07f5ef3cecd45 (RC_7170c97aaf61dfa14af07f5ef3cecd45 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrRolename = ConvertToRestWithoutDefaults(s.ssRolename, "");
AttrUserName = ConvertToRestWithoutDefaults(s.ssUserName, "");
  } else {
AttrUserId = s.ssUserId;
AttrRolename = s.ssRolename;
AttrUserName = s.ssUserName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7170c97aaf61dfa14af07f5ef3cecd45, RC_7170c97aaf61dfa14af07f5ef3cecd45> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7170c97aaf61dfa14af07f5ef3cecd45 s) => ToStructure(s, config);
}
public static RC_7170c97aaf61dfa14af07f5ef3cecd45 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7170c97aaf61dfa14af07f5ef3cecd45 obj, IBehaviorsConfiguration config) { 
  RC_7170c97aaf61dfa14af07f5ef3cecd45 s = new RC_7170c97aaf61dfa14af07f5ef3cecd45();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssRolename = obj.AttrRolename == null ? "" : obj.AttrRolename;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_7170c97aaf61dfa14af07f5ef3cecd45, ssConectaProveedores.RestRecords.JSONRC_7170c97aaf61dfa14af07f5ef3cecd45> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7170c97aaf61dfa14af07f5ef3cecd45 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7170c97aaf61dfa14af07f5ef3cecd45 FromStructure(RC_7170c97aaf61dfa14af07f5ef3cecd45 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7170c97aaf61dfa14af07f5ef3cecd45(s, config);
}

}


