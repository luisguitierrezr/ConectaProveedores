using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersImportRequest
public class JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord : AbstractRESTStructure<EN_8c3668a93870461b8ea1216c2848f298EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Origin")]
[JsonPropertyName("Origin")]
public string AttrOrigin;

[JsonProperty("ImportedData")]
[JsonPropertyName("ImportedData")]
public byte[] AttrImportedData;

[JsonProperty("_ImportedDataURL")]
public string _ImportedDataURL;

[JsonProperty("OrderMainId")]
[JsonPropertyName("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public int? AttrStatus;

[JsonProperty("LastRowNumberRead")]
[JsonPropertyName("LastRowNumberRead")]
public int? AttrLastRowNumberRead;

[JsonProperty("RowsWithError")]
[JsonPropertyName("RowsWithError")]
public string AttrRowsWithError;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

public JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord() { }

public JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord (EN_8c3668a93870461b8ea1216c2848f298EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_ImportedDataURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*c7lAIC7Clk2YNBzzJJr8rg", "ImportedData", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssImportedData);
}

if (config.OptimizeBinaries) {
s.ssImportedData = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*1jg1sj_Ao0Kl3j204QgaAg") ? s.ssImportedData : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrOrigin = ConvertToRestWithoutDefaults(s.ssOrigin, "");
AttrImportedData = ConvertToRestWithoutDefaults(s.ssImportedData);
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrStatus = (int?) s.ssStatus;
AttrLastRowNumberRead = ConvertToRestWithoutDefaults(s.ssLastRowNumberRead, 0);
AttrRowsWithError = ConvertToRestWithoutDefaults(s.ssRowsWithError, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_ImportedDataURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*c7lAIC7Clk2YNBzzJJr8rg", "ImportedData", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssImportedData);
}

if (config.OptimizeBinaries) {
s.ssImportedData = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*1jg1sj_Ao0Kl3j204QgaAg") ? s.ssImportedData : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrOrigin = s.ssOrigin;
AttrImportedData = s.ssImportedData;
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrStatus = (int?) s.ssStatus;
AttrLastRowNumberRead = (int?) s.ssLastRowNumberRead;
AttrRowsWithError = s.ssRowsWithError;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord, EN_8c3668a93870461b8ea1216c2848f298EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord s) => ToStructure(s, config);
}
public static EN_8c3668a93870461b8ea1216c2848f298EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_8c3668a93870461b8ea1216c2848f298EntityRecord s = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrigin = obj.AttrOrigin == null ? "" : obj.AttrOrigin;
  s.ssImportedData = obj.AttrImportedData == null ? new byte[] {} : obj.AttrImportedData;
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssStatus = obj.AttrStatus == null ? 0 : obj.AttrStatus.Value;
  s.ssLastRowNumberRead = obj.AttrLastRowNumberRead == null ? 0 : obj.AttrLastRowNumberRead.Value;
  s.ssRowsWithError = obj.AttrRowsWithError == null ? "" : obj.AttrRowsWithError;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_8c3668a93870461b8ea1216c2848f298EntityRecord, ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8c3668a93870461b8ea1216c2848f298EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord FromStructure(EN_8c3668a93870461b8ea1216c2848f298EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord(s, config);
}

}


