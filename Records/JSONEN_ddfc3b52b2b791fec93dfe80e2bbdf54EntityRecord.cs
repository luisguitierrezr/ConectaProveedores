using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryBlockDates
public class JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord : AbstractRESTStructure<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InitialDate")]
[JsonPropertyName("InitialDate")]
public String AttrInitialDate;

[JsonProperty("EndingDate")]
[JsonPropertyName("EndingDate")]
public String AttrEndingDate;

[JsonProperty("ImputationCode")]
[JsonPropertyName("ImputationCode")]
public string AttrImputationCode;

[JsonProperty("GLAccountsId")]
[JsonPropertyName("GLAccountsId")]
public long? AttrGLAccountsId;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

public JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord() { }

public JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInitialDate = ConvertDateToRestWithoutDefaults(s.ssInitialDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrEndingDate = ConvertDateToRestWithoutDefaults(s.ssEndingDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrImputationCode = ConvertToRestWithoutDefaults(s.ssImputationCode, "");
AttrGLAccountsId = ConvertToRestWithoutDefaults(s.ssGLAccountsId, 0L);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrInitialDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssInitialDate);
AttrEndingDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssEndingDate);
AttrImputationCode = s.ssImputationCode;
AttrGLAccountsId = (long?) s.ssGLAccountsId;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord, EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s) => ToStructure(s, config);
}
public static EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s = new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInitialDate = obj.AttrInitialDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrInitialDate);
  s.ssEndingDate = obj.AttrEndingDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrEndingDate);
  s.ssImputationCode = obj.AttrImputationCode == null ? "" : obj.AttrImputationCode;
  s.ssGLAccountsId = obj.AttrGLAccountsId == null ? 0L : obj.AttrGLAccountsId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord, ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord FromStructure(EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord(s, config);
}

}


