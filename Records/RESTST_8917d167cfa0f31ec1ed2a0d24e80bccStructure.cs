using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StorageFileStruct
public class RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure : AbstractRESTStructure<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> {
[JsonProperty("StorageId")]
public long? AttrStorageId;

[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("Size")]
public long? AttrSize;

public RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure() { }

public RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
  } else {
AttrStorageId = (long?) s.ssStorageId;
AttrFilename = s.ssFilename;
AttrSize = (long?) s.ssSize;
  }
}

public static ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure obj) { 
  ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure s = new ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
  if(obj != null) {
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  }
  return s;
}

public static Func<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure, ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure FromStructure(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure(s, config);
}

}


