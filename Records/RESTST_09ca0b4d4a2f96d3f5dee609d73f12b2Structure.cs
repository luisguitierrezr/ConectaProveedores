using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFilesStruct
public class RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure : AbstractRESTStructure<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> {
[JsonProperty("Name")]
public string AttrName;

[JsonProperty("BinaryData")]
public byte[] AttrBinaryData;

[JsonProperty("IsExtra")]
public bool? AttrIsExtra;

[JsonProperty("StorageId")]
public long? AttrStorageId;

[JsonProperty("FileId")]
public long? AttrFileId;

public RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure() { }

public RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = s.ssName;
AttrBinaryData = s.ssBinaryData;
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrFileId = ConvertToRestWithoutDefaults(s.ssFileId, 0L);
  } else {
AttrName = s.ssName;
AttrBinaryData = s.ssBinaryData;
AttrIsExtra = (bool?) s.ssIsExtra;
AttrStorageId = (long?) s.ssStorageId;
AttrFileId = (long?) s.ssFileId;
  }
}

public static ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure obj) { 
  ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure s = new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssBinaryData = obj.AttrBinaryData == null ? new byte[] {} : obj.AttrBinaryData;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssFileId = obj.AttrFileId == null ? 0L : obj.AttrFileId.Value;
  }
  return s;
}

public static Func<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure FromStructure(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(s, config);
}

}


