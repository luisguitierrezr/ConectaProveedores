using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// UserApplicationRoleTemp
public class JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord : AbstractRESTStructure<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("EntraRoleId")]
[JsonPropertyName("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("AssignedBy")]
[JsonPropertyName("AssignedBy")]
public string AttrAssignedBy;

[JsonProperty("AssignedDate")]
[JsonPropertyName("AssignedDate")]
public String AttrAssignedDate;

[JsonProperty("RoleStatusId")]
[JsonPropertyName("RoleStatusId")]
public int? AttrRoleStatusId;

[JsonProperty("RevokedBy")]
[JsonPropertyName("RevokedBy")]
public string AttrRevokedBy;

[JsonProperty("RevokedDate")]
[JsonPropertyName("RevokedDate")]
public String AttrRevokedDate;

[JsonProperty("DateFrom")]
[JsonPropertyName("DateFrom")]
public String AttrDateFrom;

[JsonProperty("DateTo")]
[JsonPropertyName("DateTo")]
public String AttrDateTo;

[JsonProperty("LastUpdatedOn")]
[JsonPropertyName("LastUpdatedOn")]
public String AttrLastUpdatedOn;

[JsonProperty("ConceptId")]
[JsonPropertyName("ConceptId")]
public int? AttrConceptId;

[JsonProperty("RegionToBeAssign")]
[JsonPropertyName("RegionToBeAssign")]
public string AttrRegionToBeAssign;

public JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord() { }

public JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrAssignedBy = ConvertToRestWithoutDefaults(s.ssAssignedBy, "");
AttrAssignedDate = ConvertDateToRestWithoutDefaults(s.ssAssignedDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrRoleStatusId = ConvertToRestWithoutDefaults(s.ssRoleStatusId, 0);
AttrRevokedBy = ConvertToRestWithoutDefaults(s.ssRevokedBy, "");
AttrRevokedDate = ConvertDateToRestWithoutDefaults(s.ssRevokedDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrDateFrom = ConvertDateToRestWithoutDefaults(s.ssDateFrom, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrDateTo = ConvertDateToRestWithoutDefaults(s.ssDateTo, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrLastUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssLastUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrConceptId = ConvertToRestWithoutDefaults(s.ssConceptId, 0);
AttrRegionToBeAssign = ConvertToRestWithoutDefaults(s.ssRegionToBeAssign, "");
  } else {
AttrId = (long?) s.ssId;
AttrUserId = s.ssUserId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrAssignedBy = s.ssAssignedBy;
AttrAssignedDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAssignedDate);
AttrRoleStatusId = (int?) s.ssRoleStatusId;
AttrRevokedBy = s.ssRevokedBy;
AttrRevokedDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssRevokedDate);
AttrDateFrom = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDateFrom);
AttrDateTo = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDateTo);
AttrLastUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastUpdatedOn, config.DateTimeFormat);
AttrConceptId = (int?) s.ssConceptId;
AttrRegionToBeAssign = s.ssRegionToBeAssign;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord s) => ToStructure(s, config);
}
public static EN_20bdea9cf8f17569719f414a83b584b6EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_20bdea9cf8f17569719f414a83b584b6EntityRecord s = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssAssignedBy = obj.AttrAssignedBy == null ? "" : obj.AttrAssignedBy;
  s.ssAssignedDate = obj.AttrAssignedDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAssignedDate);
  s.ssRoleStatusId = obj.AttrRoleStatusId == null ? 0 : obj.AttrRoleStatusId.Value;
  s.ssRevokedBy = obj.AttrRevokedBy == null ? "" : obj.AttrRevokedBy;
  s.ssRevokedDate = obj.AttrRevokedDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrRevokedDate);
  s.ssDateFrom = obj.AttrDateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDateFrom);
  s.ssDateTo = obj.AttrDateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDateTo);
  s.ssLastUpdatedOn = obj.AttrLastUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastUpdatedOn, config.DateTimeFormat);
  s.ssConceptId = obj.AttrConceptId == null ? 0 : obj.AttrConceptId.Value;
  s.ssRegionToBeAssign = obj.AttrRegionToBeAssign == null ? "" : obj.AttrRegionToBeAssign;
  }
  return s;
}

public static Func<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord FromStructure(EN_20bdea9cf8f17569719f414a83b584b6EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord(s, config);
}

}


