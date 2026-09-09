using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// DirectoryRoleRecord
public class JSONRC_6f19ec7945aa4d185bdc790151967a09 : AbstractRESTStructure<RC_6f19ec7945aa4d185bdc790151967a09> {
[JsonProperty("DirectoryRole")]
[JsonPropertyName("DirectoryRole")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2d127d12a9d7c02aac84eb45d06f36fbStructure AttrDirectoryRole;

public JSONRC_6f19ec7945aa4d185bdc790151967a09() { }

public JSONRC_6f19ec7945aa4d185bdc790151967a09 (RC_6f19ec7945aa4d185bdc790151967a09 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectoryRole = ConvertToRestWithoutDefaults(s.ssSTDirectoryRole, new ST_2d127d12a9d7c02aac84eb45d06f36fbStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2d127d12a9d7c02aac84eb45d06f36fbStructure.FromStructure, config);
  } else {
AttrDirectoryRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2d127d12a9d7c02aac84eb45d06f36fbStructure.FromStructure(s.ssSTDirectoryRole, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6f19ec7945aa4d185bdc790151967a09, RC_6f19ec7945aa4d185bdc790151967a09> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6f19ec7945aa4d185bdc790151967a09 s) => ToStructure(s, config);
}
public static RC_6f19ec7945aa4d185bdc790151967a09 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6f19ec7945aa4d185bdc790151967a09 obj, IBehaviorsConfiguration config) { 
  RC_6f19ec7945aa4d185bdc790151967a09 s = new RC_6f19ec7945aa4d185bdc790151967a09();
  if(obj != null) {
  s.ssSTDirectoryRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2d127d12a9d7c02aac84eb45d06f36fbStructure.ToStructure(obj.AttrDirectoryRole, config);
  }
  return s;
}

public static Func<RC_6f19ec7945aa4d185bdc790151967a09, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6f19ec7945aa4d185bdc790151967a09> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6f19ec7945aa4d185bdc790151967a09 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6f19ec7945aa4d185bdc790151967a09 FromStructure(RC_6f19ec7945aa4d185bdc790151967a09 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6f19ec7945aa4d185bdc790151967a09(s, config);
}

}


