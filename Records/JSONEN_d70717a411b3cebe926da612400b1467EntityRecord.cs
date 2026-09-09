using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRole
public class JSONEN_d70717a411b3cebe926da612400b1467EntityRecord : AbstractRESTStructure<EN_d70717a411b3cebe926da612400b1467EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("RegionToBeAssign")]
[JsonPropertyName("RegionToBeAssign")]
public string AttrRegionToBeAssign;

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

[JsonProperty("ConceptId")]
[JsonPropertyName("ConceptId")]
public int? AttrConceptId;

public JSONEN_d70717a411b3cebe926da612400b1467EntityRecord() { }

public JSONEN_d70717a411b3cebe926da612400b1467EntityRecord (EN_d70717a411b3cebe926da612400b1467EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrRegionToBeAssign = ConvertToRestWithoutDefaults(s.ssRegionToBeAssign, "");
AttrAssignedBy = ConvertToRestWithoutDefaults(s.ssAssignedBy, "");
AttrAssignedDate = ConvertDateToRestWithoutDefaults(s.ssAssignedDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrRoleStatusId = ConvertToRestWithoutDefaults(s.ssRoleStatusId, 0);
AttrRevokedBy = ConvertToRestWithoutDefaults(s.ssRevokedBy, "");
AttrRevokedDate = ConvertDateToRestWithoutDefaults(s.ssRevokedDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrConceptId = ConvertToRestWithoutDefaults(s.ssConceptId, 0);
  } else {
AttrId = (long?) s.ssId;
AttrUserId = s.ssUserId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrRegionToBeAssign = s.ssRegionToBeAssign;
AttrAssignedBy = s.ssAssignedBy;
AttrAssignedDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAssignedDate);
AttrRoleStatusId = (int?) s.ssRoleStatusId;
AttrRevokedBy = s.ssRevokedBy;
AttrRevokedDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssRevokedDate);
AttrConceptId = (int?) s.ssConceptId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord, EN_d70717a411b3cebe926da612400b1467EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord s) => ToStructure(s, config);
}
public static EN_d70717a411b3cebe926da612400b1467EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d70717a411b3cebe926da612400b1467EntityRecord s = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssRegionToBeAssign = obj.AttrRegionToBeAssign == null ? "" : obj.AttrRegionToBeAssign;
  s.ssAssignedBy = obj.AttrAssignedBy == null ? "" : obj.AttrAssignedBy;
  s.ssAssignedDate = obj.AttrAssignedDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAssignedDate);
  s.ssRoleStatusId = obj.AttrRoleStatusId == null ? 0 : obj.AttrRoleStatusId.Value;
  s.ssRevokedBy = obj.AttrRevokedBy == null ? "" : obj.AttrRevokedBy;
  s.ssRevokedDate = obj.AttrRevokedDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrRevokedDate);
  s.ssConceptId = obj.AttrConceptId == null ? 0 : obj.AttrConceptId.Value;
  }
  return s;
}

public static Func<EN_d70717a411b3cebe926da612400b1467EntityRecord, ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d70717a411b3cebe926da612400b1467EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord FromStructure(EN_d70717a411b3cebe926da612400b1467EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord(s, config);
}

}


