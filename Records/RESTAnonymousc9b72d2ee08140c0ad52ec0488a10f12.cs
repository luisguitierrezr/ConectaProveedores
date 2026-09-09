using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectoryRoleRecord
public class RESTRC_6f19ec7945aa4d185bdc790151967a09 : AbstractRESTStructure<RC_6f19ec7945aa4d185bdc790151967a09> {
[JsonProperty("DirectoryRole")]
public ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure AttrDirectoryRole;

public RESTRC_6f19ec7945aa4d185bdc790151967a09() { }

public RESTRC_6f19ec7945aa4d185bdc790151967a09 (RC_6f19ec7945aa4d185bdc790151967a09 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectoryRole = ConvertToRestWithoutDefaults(s.ssSTDirectoryRole, new ST_2d127d12a9d7c02aac84eb45d06f36fbStructure(), ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure.FromStructure, config);
  } else {
AttrDirectoryRole = ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure.FromStructure(s.ssSTDirectoryRole, config);
  }
}

public static RC_6f19ec7945aa4d185bdc790151967a09 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6f19ec7945aa4d185bdc790151967a09 obj) { 
  RC_6f19ec7945aa4d185bdc790151967a09 s = new RC_6f19ec7945aa4d185bdc790151967a09();
  if(obj != null) {
  s.ssSTDirectoryRole = ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure.ToStructure(obj.AttrDirectoryRole);
  }
  return s;
}

public static Func<RC_6f19ec7945aa4d185bdc790151967a09, ssConectaProveedores.RestRecords.RESTRC_6f19ec7945aa4d185bdc790151967a09> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6f19ec7945aa4d185bdc790151967a09 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6f19ec7945aa4d185bdc790151967a09 FromStructure(RC_6f19ec7945aa4d185bdc790151967a09 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6f19ec7945aa4d185bdc790151967a09(s, config);
}

}


