using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFileRecord
public class RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5 : AbstractRESTStructure<RC_a8c9db0520f3bc88b53a407e39ea6fe5> {
[JsonProperty("FolioFile")]
public ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure AttrFolioFile;

public RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5() { }

public RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5 (RC_a8c9db0520f3bc88b53a407e39ea6fe5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioFile = ConvertToRestWithoutDefaults(s.ssSTFolioFile, new ST_a23a10e9592e51ca9ffbbbc42c558496Structure(), ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.FromStructure, config);
  } else {
AttrFolioFile = ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.FromStructure(s.ssSTFolioFile, config);
  }
}

public static RC_a8c9db0520f3bc88b53a407e39ea6fe5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5 obj) { 
  RC_a8c9db0520f3bc88b53a407e39ea6fe5 s = new RC_a8c9db0520f3bc88b53a407e39ea6fe5();
  if(obj != null) {
  s.ssSTFolioFile = ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure.ToStructure(obj.AttrFolioFile);
  }
  return s;
}

public static Func<RC_a8c9db0520f3bc88b53a407e39ea6fe5, ssConectaProveedores.RestRecords.RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a8c9db0520f3bc88b53a407e39ea6fe5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5 FromStructure(RC_a8c9db0520f3bc88b53a407e39ea6fe5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a8c9db0520f3bc88b53a407e39ea6fe5(s, config);
}

}


