using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FilesJson
public class RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure : AbstractRESTStructure<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure> {
[JsonProperty("FileId")]
public long? AttrFileId;

[JsonProperty("FileName")]
public string AttrFileName;

[JsonProperty("FileSize")]
public long? AttrFileSize;

[JsonProperty("TotalChunks")]
public int? AttrTotalChunks;

public RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure() { }

public RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileId = ConvertToRestWithoutDefaults(s.ssFileId, 0L);
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrFileSize = ConvertToRestWithoutDefaults(s.ssFileSize, 0L);
AttrTotalChunks = ConvertToRestWithoutDefaults(s.ssTotalChunks, 0);
  } else {
AttrFileId = (long?) s.ssFileId;
AttrFileName = s.ssFileName;
AttrFileSize = (long?) s.ssFileSize;
AttrTotalChunks = (int?) s.ssTotalChunks;
  }
}

public static ST_6c0a0d3b1d72414f90bb9301bad200fbStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure obj) { 
  ST_6c0a0d3b1d72414f90bb9301bad200fbStructure s = new ST_6c0a0d3b1d72414f90bb9301bad200fbStructure();
  if(obj != null) {
  s.ssFileId = obj.AttrFileId == null ? 0L : obj.AttrFileId.Value;
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssFileSize = obj.AttrFileSize == null ? 0L : obj.AttrFileSize.Value;
  s.ssTotalChunks = obj.AttrTotalChunks == null ? 0 : obj.AttrTotalChunks.Value;
  }
  return s;
}

public static Func<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure, ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure FromStructure(ST_6c0a0d3b1d72414f90bb9301bad200fbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure(s, config);
}

}


