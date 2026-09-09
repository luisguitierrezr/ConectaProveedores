using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFile
public class RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure : AbstractRESTStructure<ST_a23a10e9592e51ca9ffbbbc42c558496Structure> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("IsExtra")]
public bool? AttrIsExtra;

[JsonProperty("StorageId")]
public long? AttrStorageId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedByName")]
public string AttrCreatedByName;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Size")]
public long? AttrSize;

[JsonProperty("IsNewFile")]
public bool? AttrIsNewFile;

public RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure() { }

public RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure (ST_a23a10e9592e51ca9ffbbbc42c558496Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedByName = s.ssCreatedByName;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
AttrIsNewFile = ConvertToRestWithoutDefaults(s.ssIsNewFile, false);
  } else {
AttrId = (long?) s.ssId;
AttrFilename = s.ssFilename;
AttrFolioId = (long?) s.ssFolioId;
AttrIsExtra = (bool?) s.ssIsExtra;
AttrStorageId = (long?) s.ssStorageId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedByName = s.ssCreatedByName;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrSize = (long?) s.ssSize;
AttrIsNewFile = (bool?) s.ssIsNewFile;
  }
}

public static ST_a23a10e9592e51ca9ffbbbc42c558496Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure obj) { 
  ST_a23a10e9592e51ca9ffbbbc42c558496Structure s = new ST_a23a10e9592e51ca9ffbbbc42c558496Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedByName = obj.AttrCreatedByName == null ? "" : obj.AttrCreatedByName;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  s.ssIsNewFile = obj.AttrIsNewFile == null ? false : obj.AttrIsNewFile.Value;
  }
  return s;
}

public static Func<ST_a23a10e9592e51ca9ffbbbc42c558496Structure, ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a23a10e9592e51ca9ffbbbc42c558496Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure FromStructure(ST_a23a10e9592e51ca9ffbbbc42c558496Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_a23a10e9592e51ca9ffbbbc42c558496Structure(s, config);
}

}


