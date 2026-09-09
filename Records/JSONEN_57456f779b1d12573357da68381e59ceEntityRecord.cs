using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileImportLog
public class JSONEN_57456f779b1d12573357da68381e59ceEntityRecord : AbstractRESTStructure<EN_57456f779b1d12573357da68381e59ceEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("FileId")]
[JsonPropertyName("FileId")]
public long? AttrFileId;

[JsonProperty("Timestamp")]
[JsonPropertyName("Timestamp")]
public String AttrTimestamp;

[JsonProperty("ImportType")]
[JsonPropertyName("ImportType")]
public string AttrImportType;

[JsonProperty("ImportedBy")]
[JsonPropertyName("ImportedBy")]
public string AttrImportedBy;

public JSONEN_57456f779b1d12573357da68381e59ceEntityRecord() { }

public JSONEN_57456f779b1d12573357da68381e59ceEntityRecord (EN_57456f779b1d12573357da68381e59ceEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFileId = ConvertToRestWithoutDefaults(s.ssFileId, 0L);
AttrTimestamp = ConvertDateTimeToRestWithoutDefaults(s.ssTimestamp, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrImportType = ConvertToRestWithoutDefaults(s.ssImportType, "");
AttrImportedBy = ConvertToRestWithoutDefaults(s.ssImportedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrFileId = (long?) s.ssFileId;
AttrTimestamp = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssTimestamp, config.DateTimeFormat);
AttrImportType = s.ssImportType;
AttrImportedBy = s.ssImportedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord, EN_57456f779b1d12573357da68381e59ceEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord s) => ToStructure(s, config);
}
public static EN_57456f779b1d12573357da68381e59ceEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_57456f779b1d12573357da68381e59ceEntityRecord s = new EN_57456f779b1d12573357da68381e59ceEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFileId = obj.AttrFileId == null ? 0L : obj.AttrFileId.Value;
  s.ssTimestamp = obj.AttrTimestamp == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrTimestamp, config.DateTimeFormat);
  s.ssImportType = obj.AttrImportType == null ? "" : obj.AttrImportType;
  s.ssImportedBy = obj.AttrImportedBy == null ? "" : obj.AttrImportedBy;
  }
  return s;
}

public static Func<EN_57456f779b1d12573357da68381e59ceEntityRecord, ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_57456f779b1d12573357da68381e59ceEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord FromStructure(EN_57456f779b1d12573357da68381e59ceEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord(s, config);
}

}


