using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderComment
public class RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord : AbstractRESTStructure<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("OrderApprovalLevelId")]
public long? AttrOrderApprovalLevelId;

[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("Message")]
public string AttrMessage;

public RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord() { }

public RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord obj) { 
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

public static Func<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord FromStructure(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(s, config);
}

}


