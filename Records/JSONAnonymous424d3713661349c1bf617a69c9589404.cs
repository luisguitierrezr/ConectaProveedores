using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFileRecord
public class JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5 : AbstractRESTStructure<RC_a8c9db0520f3bc88b53a407e39ea6fe5> {
[JsonProperty("FolioFile")]
[JsonPropertyName("FolioFile")]
public ssConectaProveedores.RestRecords.JSONST_a23a10e9592e51ca9ffbbbc42c558496Structure AttrFolioFile;

public JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5() { }

public JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5 (RC_a8c9db0520f3bc88b53a407e39ea6fe5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioFile = ConvertToRestWithoutDefaults(s.ssSTFolioFile, new ST_a23a10e9592e51ca9ffbbbc42c558496Structure(), ssConectaProveedores.RestRecords.JSONST_a23a10e9592e51ca9ffbbbc42c558496Structure.FromStructure, config);
  } else {
AttrFolioFile = ssConectaProveedores.RestRecords.JSONST_a23a10e9592e51ca9ffbbbc42c558496Structure.FromStructure(s.ssSTFolioFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5, RC_a8c9db0520f3bc88b53a407e39ea6fe5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5 s) => ToStructure(s, config);
}
public static RC_a8c9db0520f3bc88b53a407e39ea6fe5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5 obj, IBehaviorsConfiguration config) { 
  RC_a8c9db0520f3bc88b53a407e39ea6fe5 s = new RC_a8c9db0520f3bc88b53a407e39ea6fe5();
  if(obj != null) {
  s.ssSTFolioFile = ssConectaProveedores.RestRecords.JSONST_a23a10e9592e51ca9ffbbbc42c558496Structure.ToStructure(obj.AttrFolioFile, config);
  }
  return s;
}

public static Func<RC_a8c9db0520f3bc88b53a407e39ea6fe5, ssConectaProveedores.RestRecords.JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a8c9db0520f3bc88b53a407e39ea6fe5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5 FromStructure(RC_a8c9db0520f3bc88b53a407e39ea6fe5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a8c9db0520f3bc88b53a407e39ea6fe5(s, config);
}

}


