using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQImportRecord
public class JSONRC_11133d573140bca413fb3e86df694e32 : AbstractRESTStructure<RC_11133d573140bca413fb3e86df694e32> {
[JsonProperty("FolioQImport")]
[JsonPropertyName("FolioQImport")]
public ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure AttrFolioQImport;

public JSONRC_11133d573140bca413fb3e86df694e32() { }

public JSONRC_11133d573140bca413fb3e86df694e32 (RC_11133d573140bca413fb3e86df694e32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioQImport = ConvertToRestWithoutDefaults(s.ssSTFolioQImport, new ST_9d31438c744477d5e7fa3ba41ac26dffStructure(), ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure.FromStructure, config);
  } else {
AttrFolioQImport = ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure.FromStructure(s.ssSTFolioQImport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_11133d573140bca413fb3e86df694e32, RC_11133d573140bca413fb3e86df694e32> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_11133d573140bca413fb3e86df694e32 s) => ToStructure(s, config);
}
public static RC_11133d573140bca413fb3e86df694e32 ToStructure(ssConectaProveedores.RestRecords.JSONRC_11133d573140bca413fb3e86df694e32 obj, IBehaviorsConfiguration config) { 
  RC_11133d573140bca413fb3e86df694e32 s = new RC_11133d573140bca413fb3e86df694e32();
  if(obj != null) {
  s.ssSTFolioQImport = ssConectaProveedores.RestRecords.JSONST_9d31438c744477d5e7fa3ba41ac26dffStructure.ToStructure(obj.AttrFolioQImport, config);
  }
  return s;
}

public static Func<RC_11133d573140bca413fb3e86df694e32, ssConectaProveedores.RestRecords.JSONRC_11133d573140bca413fb3e86df694e32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11133d573140bca413fb3e86df694e32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_11133d573140bca413fb3e86df694e32 FromStructure(RC_11133d573140bca413fb3e86df694e32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_11133d573140bca413fb3e86df694e32(s, config);
}

}


