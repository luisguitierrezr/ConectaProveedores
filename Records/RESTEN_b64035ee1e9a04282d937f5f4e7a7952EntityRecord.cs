using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFiles
public class RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord : AbstractRESTStructure<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord> {
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

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("IsNewFile")]
public bool? AttrIsNewFile;

public RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord() { }

public RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrIsNewFile = ConvertToRestWithoutDefaults(s.ssIsNewFile, false);
  } else {
AttrId = (long?) s.ssId;
AttrFilename = s.ssFilename;
AttrFolioId = (long?) s.ssFolioId;
AttrIsExtra = (bool?) s.ssIsExtra;
AttrStorageId = (long?) s.ssStorageId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrIsNewFile = (bool?) s.ssIsNewFile;
  }
}

public static EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord obj) { 
  EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord s = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsNewFile = obj.AttrIsNewFile == null ? false : obj.AttrIsNewFile.Value;
  }
  return s;
}

public static Func<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord FromStructure(EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(s, config);
}

}


