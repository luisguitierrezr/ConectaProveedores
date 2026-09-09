using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_2CompanyRecord
public class RESTRC_06b38e19582fc855dd67cd4191332383 : AbstractRESTStructure<RC_06b38e19582fc855dd67cd4191332383> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("User_2")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_2;

[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public RESTRC_06b38e19582fc855dd67cd4191332383() { }

public RESTRC_06b38e19582fc855dd67cd4191332383 (RC_06b38e19582fc855dd67cd4191332383 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_2 = ConvertToRestWithoutDefaults(s.ssENUser_2, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_2 = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_2, config);
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static RC_06b38e19582fc855dd67cd4191332383 ToStructure(ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383 obj) { 
  RC_06b38e19582fc855dd67cd4191332383 s = new RC_06b38e19582fc855dd67cd4191332383();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUser_2 = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_2);
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  }
  return s;
}

public static Func<RC_06b38e19582fc855dd67cd4191332383, ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06b38e19582fc855dd67cd4191332383 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383 FromStructure(RC_06b38e19582fc855dd67cd4191332383 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383(s, config);
}

}


