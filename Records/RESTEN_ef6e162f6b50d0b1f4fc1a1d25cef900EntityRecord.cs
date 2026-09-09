using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioLog
public class RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord : AbstractRESTStructure<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("IsError")]
public bool? AttrIsError;

[JsonProperty("IsForSupplier")]
public bool? AttrIsForSupplier;

public RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord() { }

public RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsError = ConvertToRestWithoutDefaults(s.ssIsError, false);
AttrIsForSupplier = ConvertToRestWithoutDefaults(s.ssIsForSupplier, false);
  } else {
AttrId = (long?) s.ssId;
AttrFolioId = (long?) s.ssFolioId;
AttrMessage = s.ssMessage;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrIsError = (bool?) s.ssIsError;
AttrIsForSupplier = (bool?) s.ssIsForSupplier;
  }
}

public static EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord obj) { 
  EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord s = new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  s.ssIsForSupplier = obj.AttrIsForSupplier == null ? false : obj.AttrIsForSupplier.Value;
  }
  return s;
}

public static Func<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord, ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord FromStructure(EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(s, config);
}

}


