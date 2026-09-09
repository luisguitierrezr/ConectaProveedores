using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQImportRecord
public class RESTRC_11133d573140bca413fb3e86df694e32 : AbstractRESTStructure<RC_11133d573140bca413fb3e86df694e32> {
[JsonProperty("FolioQImport")]
public ssConectaProveedores.RestRecords.RESTST_9d31438c744477d5e7fa3ba41ac26dffStructure AttrFolioQImport;

public RESTRC_11133d573140bca413fb3e86df694e32() { }

public RESTRC_11133d573140bca413fb3e86df694e32 (RC_11133d573140bca413fb3e86df694e32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioQImport = ConvertToRestWithoutDefaults(s.ssSTFolioQImport, new ST_9d31438c744477d5e7fa3ba41ac26dffStructure(), ssConectaProveedores.RestRecords.RESTST_9d31438c744477d5e7fa3ba41ac26dffStructure.FromStructure, config);
  } else {
AttrFolioQImport = ssConectaProveedores.RestRecords.RESTST_9d31438c744477d5e7fa3ba41ac26dffStructure.FromStructure(s.ssSTFolioQImport, config);
  }
}

public static RC_11133d573140bca413fb3e86df694e32 ToStructure(ssConectaProveedores.RestRecords.RESTRC_11133d573140bca413fb3e86df694e32 obj) { 
  RC_11133d573140bca413fb3e86df694e32 s = new RC_11133d573140bca413fb3e86df694e32();
  if(obj != null) {
  s.ssSTFolioQImport = ssConectaProveedores.RestRecords.RESTST_9d31438c744477d5e7fa3ba41ac26dffStructure.ToStructure(obj.AttrFolioQImport);
  }
  return s;
}

public static Func<RC_11133d573140bca413fb3e86df694e32, ssConectaProveedores.RestRecords.RESTRC_11133d573140bca413fb3e86df694e32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11133d573140bca413fb3e86df694e32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_11133d573140bca413fb3e86df694e32 FromStructure(RC_11133d573140bca413fb3e86df694e32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_11133d573140bca413fb3e86df694e32(s, config);
}

}


