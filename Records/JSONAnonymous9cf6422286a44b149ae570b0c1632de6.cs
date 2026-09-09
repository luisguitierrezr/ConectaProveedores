using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQFilesRecord
public class JSONRC_70b13e28c6212feb2e7d4ad3155dda34 : AbstractRESTStructure<RC_70b13e28c6212feb2e7d4ad3155dda34> {
[JsonProperty("FolioQFiles")]
[JsonPropertyName("FolioQFiles")]
public ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure AttrFolioQFiles;

public JSONRC_70b13e28c6212feb2e7d4ad3155dda34() { }

public JSONRC_70b13e28c6212feb2e7d4ad3155dda34 (RC_70b13e28c6212feb2e7d4ad3155dda34 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioQFiles = ConvertToRestWithoutDefaults(s.ssSTFolioQFiles, new ST_b9bc0a93e29018653085b5de5dd1951eStructure(), ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure.FromStructure, config);
  } else {
AttrFolioQFiles = ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure.FromStructure(s.ssSTFolioQFiles, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_70b13e28c6212feb2e7d4ad3155dda34, RC_70b13e28c6212feb2e7d4ad3155dda34> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_70b13e28c6212feb2e7d4ad3155dda34 s) => ToStructure(s, config);
}
public static RC_70b13e28c6212feb2e7d4ad3155dda34 ToStructure(ssConectaProveedores.RestRecords.JSONRC_70b13e28c6212feb2e7d4ad3155dda34 obj, IBehaviorsConfiguration config) { 
  RC_70b13e28c6212feb2e7d4ad3155dda34 s = new RC_70b13e28c6212feb2e7d4ad3155dda34();
  if(obj != null) {
  s.ssSTFolioQFiles = ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure.ToStructure(obj.AttrFolioQFiles, config);
  }
  return s;
}

public static Func<RC_70b13e28c6212feb2e7d4ad3155dda34, ssConectaProveedores.RestRecords.JSONRC_70b13e28c6212feb2e7d4ad3155dda34> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_70b13e28c6212feb2e7d4ad3155dda34 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_70b13e28c6212feb2e7d4ad3155dda34 FromStructure(RC_70b13e28c6212feb2e7d4ad3155dda34 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_70b13e28c6212feb2e7d4ad3155dda34(s, config);
}

}


