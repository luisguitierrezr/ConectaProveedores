using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MFU_File
public class RESTST_1d6498da9105fbe815a7f766352917c0Structure : AbstractRESTStructure<ST_1d6498da9105fbe815a7f766352917c0Structure> {
[JsonProperty("FileName")]
public string AttrFileName;

[JsonProperty("FileMimeType")]
public string AttrFileMimeType;

[JsonProperty("FileSize")]
public string AttrFileSize;

[JsonProperty("FileContent")]
public byte[] AttrFileContent;

[JsonProperty("FileContentURL")]
public string AttrFileContentURL;

[JsonProperty("FileBigFileId")]
public long? AttrFileBigFileId;

public RESTST_1d6498da9105fbe815a7f766352917c0Structure() { }

public RESTST_1d6498da9105fbe815a7f766352917c0Structure (ST_1d6498da9105fbe815a7f766352917c0Structure s, IBehaviorsConfiguration config) {
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

public static ST_1d6498da9105fbe815a7f766352917c0Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure obj) { 
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

public static Func<ST_1d6498da9105fbe815a7f766352917c0Structure, ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1d6498da9105fbe815a7f766352917c0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure FromStructure(ST_1d6498da9105fbe815a7f766352917c0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure(s, config);
}

}


