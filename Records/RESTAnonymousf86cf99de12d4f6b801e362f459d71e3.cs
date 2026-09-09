using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdRolenameUserNameRecord
public class RESTRC_7170c97aaf61dfa14af07f5ef3cecd45 : AbstractRESTStructure<RC_7170c97aaf61dfa14af07f5ef3cecd45> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("Rolename")]
public string AttrRolename;

[JsonProperty("UserName")]
public string AttrUserName;

public RESTRC_7170c97aaf61dfa14af07f5ef3cecd45() { }

public RESTRC_7170c97aaf61dfa14af07f5ef3cecd45 (RC_7170c97aaf61dfa14af07f5ef3cecd45 s, IBehaviorsConfiguration config) {
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

public static RC_7170c97aaf61dfa14af07f5ef3cecd45 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7170c97aaf61dfa14af07f5ef3cecd45 obj) { 
  RC_7170c97aaf61dfa14af07f5ef3cecd45 s = new RC_7170c97aaf61dfa14af07f5ef3cecd45();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssRolename = obj.AttrRolename == null ? "" : obj.AttrRolename;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_7170c97aaf61dfa14af07f5ef3cecd45, ssConectaProveedores.RestRecords.RESTRC_7170c97aaf61dfa14af07f5ef3cecd45> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7170c97aaf61dfa14af07f5ef3cecd45 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7170c97aaf61dfa14af07f5ef3cecd45 FromStructure(RC_7170c97aaf61dfa14af07f5ef3cecd45 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7170c97aaf61dfa14af07f5ef3cecd45(s, config);
}

}


