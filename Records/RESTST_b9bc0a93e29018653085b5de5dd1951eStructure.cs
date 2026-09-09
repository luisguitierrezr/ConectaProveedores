using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQFiles
public class RESTST_b9bc0a93e29018653085b5de5dd1951eStructure : AbstractRESTStructure<ST_b9bc0a93e29018653085b5de5dd1951eStructure> {
[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("Binary")]
public byte[] AttrBinary;

[JsonProperty("BinaryFilename")]
public string AttrBinaryFilename;

[JsonProperty("FileExists")]
public bool? AttrFileExists;

[JsonProperty("IsExtra")]
public bool? AttrIsExtra;

public RESTST_b9bc0a93e29018653085b5de5dd1951eStructure() { }

public RESTST_b9bc0a93e29018653085b5de5dd1951eStructure (ST_b9bc0a93e29018653085b5de5dd1951eStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
AttrBinaryFilename = ConvertToRestWithoutDefaults(s.ssBinaryFilename, "");
AttrFileExists = ConvertToRestWithoutDefaults(s.ssFileExists, false);
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
  } else {
AttrFilename = s.ssFilename;
AttrBinary = s.ssBinary;
AttrBinaryFilename = s.ssBinaryFilename;
AttrFileExists = (bool?) s.ssFileExists;
AttrIsExtra = (bool?) s.ssIsExtra;
  }
}

public static ST_b9bc0a93e29018653085b5de5dd1951eStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure obj) { 
  ST_b9bc0a93e29018653085b5de5dd1951eStructure s = new ST_b9bc0a93e29018653085b5de5dd1951eStructure();
  if(obj != null) {
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  s.ssBinaryFilename = obj.AttrBinaryFilename == null ? "" : obj.AttrBinaryFilename;
  s.ssFileExists = obj.AttrFileExists == null ? false : obj.AttrFileExists.Value;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  }
  return s;
}

public static Func<ST_b9bc0a93e29018653085b5de5dd1951eStructure, ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b9bc0a93e29018653085b5de5dd1951eStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure FromStructure(ST_b9bc0a93e29018653085b5de5dd1951eStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b9bc0a93e29018653085b5de5dd1951eStructure(s, config);
}

}


