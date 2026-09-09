using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQFilesRecord
public class RESTRC_70b13e28c6212feb2e7d4ad3155dda34 : AbstractRESTStructure<RC_70b13e28c6212feb2e7d4ad3155dda34> {
[JsonProperty("FolioQFiles")]
public ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure AttrFolioQFiles;

public RESTRC_70b13e28c6212feb2e7d4ad3155dda34() { }

public RESTRC_70b13e28c6212feb2e7d4ad3155dda34 (RC_70b13e28c6212feb2e7d4ad3155dda34 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioQFiles = ConvertToRestWithoutDefaults(s.ssSTFolioQFiles, new ST_b9bc0a93e29018653085b5de5dd1951eStructure(), ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure.FromStructure, config);
  } else {
AttrFolioQFiles = ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure.FromStructure(s.ssSTFolioQFiles, config);
  }
}

public static RC_70b13e28c6212feb2e7d4ad3155dda34 ToStructure(ssConectaProveedores.RestRecords.RESTRC_70b13e28c6212feb2e7d4ad3155dda34 obj) { 
  RC_70b13e28c6212feb2e7d4ad3155dda34 s = new RC_70b13e28c6212feb2e7d4ad3155dda34();
  if(obj != null) {
  s.ssSTFolioQFiles = ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure.ToStructure(obj.AttrFolioQFiles);
  }
  return s;
}

public static Func<RC_70b13e28c6212feb2e7d4ad3155dda34, ssConectaProveedores.RestRecords.RESTRC_70b13e28c6212feb2e7d4ad3155dda34> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_70b13e28c6212feb2e7d4ad3155dda34 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_70b13e28c6212feb2e7d4ad3155dda34 FromStructure(RC_70b13e28c6212feb2e7d4ad3155dda34 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_70b13e28c6212feb2e7d4ad3155dda34(s, config);
}

}


