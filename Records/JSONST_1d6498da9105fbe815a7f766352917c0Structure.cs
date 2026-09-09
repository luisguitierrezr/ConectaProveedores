using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MFU_File
public class JSONST_1d6498da9105fbe815a7f766352917c0Structure : AbstractRESTStructure<ST_1d6498da9105fbe815a7f766352917c0Structure> {
[JsonProperty("FileName")]
[JsonPropertyName("FileName")]
public string AttrFileName;

[JsonProperty("FileMimeType")]
[JsonPropertyName("FileMimeType")]
public string AttrFileMimeType;

[JsonProperty("FileSize")]
[JsonPropertyName("FileSize")]
public string AttrFileSize;

[JsonProperty("FileContent")]
[JsonPropertyName("FileContent")]
public byte[] AttrFileContent;

[JsonProperty("FileContentURL")]
[JsonPropertyName("FileContentURL")]
public string AttrFileContentURL;

[JsonProperty("FileBigFileId")]
[JsonPropertyName("FileBigFileId")]
public long? AttrFileBigFileId;

public JSONST_1d6498da9105fbe815a7f766352917c0Structure() { }

public JSONST_1d6498da9105fbe815a7f766352917c0Structure (ST_1d6498da9105fbe815a7f766352917c0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrFileMimeType = ConvertToRestWithoutDefaults(s.ssFileMimeType, "");
AttrFileSize = ConvertToRestWithoutDefaults(s.ssFileSize, "");
AttrFileContent = ConvertToRestWithoutDefaults(s.ssFileContent);
AttrFileContentURL = ConvertToRestWithoutDefaults(s.ssFileContentURL, "");
AttrFileBigFileId = ConvertToRestWithoutDefaults(s.ssFileBigFileId, 0L);
  } else {
AttrFileName = s.ssFileName;
AttrFileMimeType = s.ssFileMimeType;
AttrFileSize = s.ssFileSize;
AttrFileContent = s.ssFileContent;
AttrFileContentURL = s.ssFileContentURL;
AttrFileBigFileId = (long?) s.ssFileBigFileId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1d6498da9105fbe815a7f766352917c0Structure, ST_1d6498da9105fbe815a7f766352917c0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1d6498da9105fbe815a7f766352917c0Structure s) => ToStructure(s, config);
}
public static ST_1d6498da9105fbe815a7f766352917c0Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1d6498da9105fbe815a7f766352917c0Structure obj, IBehaviorsConfiguration config) { 
  ST_1d6498da9105fbe815a7f766352917c0Structure s = new ST_1d6498da9105fbe815a7f766352917c0Structure();
  if(obj != null) {
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssFileMimeType = obj.AttrFileMimeType == null ? "" : obj.AttrFileMimeType;
  s.ssFileSize = obj.AttrFileSize == null ? "" : obj.AttrFileSize;
  s.ssFileContent = obj.AttrFileContent == null ? new byte[] {} : obj.AttrFileContent;
  s.ssFileContentURL = obj.AttrFileContentURL == null ? "" : obj.AttrFileContentURL;
  s.ssFileBigFileId = obj.AttrFileBigFileId == null ? 0L : obj.AttrFileBigFileId.Value;
  }
  return s;
}

public static Func<ST_1d6498da9105fbe815a7f766352917c0Structure, ssConectaProveedores.RestRecords.JSONST_1d6498da9105fbe815a7f766352917c0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1d6498da9105fbe815a7f766352917c0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1d6498da9105fbe815a7f766352917c0Structure FromStructure(ST_1d6498da9105fbe815a7f766352917c0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1d6498da9105fbe815a7f766352917c0Structure(s, config);
}

}


