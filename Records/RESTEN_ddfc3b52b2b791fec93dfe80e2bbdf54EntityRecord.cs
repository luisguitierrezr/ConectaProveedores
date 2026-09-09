using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryBlockDates
public class RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord : AbstractRESTStructure<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InitialDate")]
public String AttrInitialDate;

[JsonProperty("EndingDate")]
public String AttrEndingDate;

[JsonProperty("ImputationCode")]
public string AttrImputationCode;

[JsonProperty("GLAccountsId")]
public long? AttrGLAccountsId;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord() { }

public RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord obj) { 
  EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s = new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInitialDate = obj.AttrInitialDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrInitialDate);
  s.ssEndingDate = obj.AttrEndingDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrEndingDate);
  s.ssImputationCode = obj.AttrImputationCode == null ? "" : obj.AttrImputationCode;
  s.ssGLAccountsId = obj.AttrGLAccountsId == null ? 0L : obj.AttrGLAccountsId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord, ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord FromStructure(EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord(s, config);
}

}


