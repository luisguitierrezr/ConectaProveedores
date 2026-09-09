using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioComment
public class JSONEN_a75639301080da49357fc03810b8d65fEntityRecord : AbstractRESTStructure<EN_a75639301080da49357fc03810b8d65fEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioApprovalLevelId")]
[JsonPropertyName("FolioApprovalLevelId")]
public long? AttrFolioApprovalLevelId;

[JsonProperty("CommentTypeId")]
[JsonPropertyName("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

[JsonProperty("IsPublic")]
[JsonPropertyName("IsPublic")]
public bool? AttrIsPublic;

public JSONEN_a75639301080da49357fc03810b8d65fEntityRecord() { }

public JSONEN_a75639301080da49357fc03810b8d65fEntityRecord (EN_a75639301080da49357fc03810b8d65fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrFolioApprovalLevelId = ConvertToRestWithoutDefaults(s.ssFolioApprovalLevelId, 0L);
AttrCommentTypeId = ConvertToRestWithoutDefaults(s.ssCommentTypeId, 0);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrIsPublic = (bool?) s.ssIsPublic;
  } else {
AttrId = (long?) s.ssId;
AttrFolioId = (long?) s.ssFolioId;
AttrFolioApprovalLevelId = (long?) s.ssFolioApprovalLevelId;
AttrCommentTypeId = (int?) s.ssCommentTypeId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrMessage = s.ssMessage;
AttrIsPublic = (bool?) s.ssIsPublic;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord, EN_a75639301080da49357fc03810b8d65fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord s) => ToStructure(s, config);
}
public static EN_a75639301080da49357fc03810b8d65fEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_a75639301080da49357fc03810b8d65fEntityRecord s = new EN_a75639301080da49357fc03810b8d65fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssFolioApprovalLevelId = obj.AttrFolioApprovalLevelId == null ? 0L : obj.AttrFolioApprovalLevelId.Value;
  s.ssCommentTypeId = obj.AttrCommentTypeId == null ? 0 : obj.AttrCommentTypeId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssIsPublic = obj.AttrIsPublic == null ? false : obj.AttrIsPublic.Value;
  }
  return s;
}

public static Func<EN_a75639301080da49357fc03810b8d65fEntityRecord, ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a75639301080da49357fc03810b8d65fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord FromStructure(EN_a75639301080da49357fc03810b8d65fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord(s, config);
}

}


