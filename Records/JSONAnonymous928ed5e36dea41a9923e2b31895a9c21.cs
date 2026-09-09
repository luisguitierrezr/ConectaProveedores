using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_2CompanyRecord
public class JSONRC_06b38e19582fc855dd67cd4191332383 : AbstractRESTStructure<RC_06b38e19582fc855dd67cd4191332383> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("User_2")]
[JsonPropertyName("User_2")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_2;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public JSONRC_06b38e19582fc855dd67cd4191332383() { }

public JSONRC_06b38e19582fc855dd67cd4191332383 (RC_06b38e19582fc855dd67cd4191332383 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_2 = ConvertToRestWithoutDefaults(s.ssENUser_2, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_2 = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_2, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_06b38e19582fc855dd67cd4191332383, RC_06b38e19582fc855dd67cd4191332383> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_06b38e19582fc855dd67cd4191332383 s) => ToStructure(s, config);
}
public static RC_06b38e19582fc855dd67cd4191332383 ToStructure(ssConectaProveedores.RestRecords.JSONRC_06b38e19582fc855dd67cd4191332383 obj, IBehaviorsConfiguration config) { 
  RC_06b38e19582fc855dd67cd4191332383 s = new RC_06b38e19582fc855dd67cd4191332383();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUser_2 = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_2, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  }
  return s;
}

public static Func<RC_06b38e19582fc855dd67cd4191332383, ssConectaProveedores.RestRecords.JSONRC_06b38e19582fc855dd67cd4191332383> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06b38e19582fc855dd67cd4191332383 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_06b38e19582fc855dd67cd4191332383 FromStructure(RC_06b38e19582fc855dd67cd4191332383 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_06b38e19582fc855dd67cd4191332383(s, config);
}

}


