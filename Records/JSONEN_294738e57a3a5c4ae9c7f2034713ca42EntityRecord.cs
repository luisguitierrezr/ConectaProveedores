using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderComment
public class JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord : AbstractRESTStructure<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("CommentTypeId")]
[JsonPropertyName("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

[JsonProperty("OrderApprovalLevelId")]
[JsonPropertyName("OrderApprovalLevelId")]
public long? AttrOrderApprovalLevelId;

[JsonProperty("EntraRoleId")]
[JsonPropertyName("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord() { }

public JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCommentTypeId = ConvertToRestWithoutDefaults(s.ssCommentTypeId, 0);
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrOrderApprovalLevelId = ConvertToRestWithoutDefaults(s.ssOrderApprovalLevelId, 0L);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrId = (long?) s.ssId;
AttrCommentTypeId = (int?) s.ssCommentTypeId;
AttrOrderId = (long?) s.ssOrderId;
AttrOrderApprovalLevelId = (long?) s.ssOrderApprovalLevelId;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrCreatedBy = s.ssCreatedBy;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s) => ToStructure(s, config);
}
public static EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s = new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCommentTypeId = obj.AttrCommentTypeId == null ? 0 : obj.AttrCommentTypeId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssOrderApprovalLevelId = obj.AttrOrderApprovalLevelId == null ? 0L : obj.AttrOrderApprovalLevelId.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord FromStructure(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(s, config);
}

}


