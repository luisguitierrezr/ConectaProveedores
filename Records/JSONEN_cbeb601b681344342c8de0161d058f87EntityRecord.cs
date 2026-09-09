using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionComment
public class JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord : AbstractRESTStructure<EN_cbeb601b681344342c8de0161d058f87EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("CommentTypeId")]
[JsonPropertyName("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
[JsonPropertyName("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

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

public JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord() { }

public JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord (EN_cbeb601b681344342c8de0161d058f87EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCommentTypeId = ConvertToRestWithoutDefaults(s.ssCommentTypeId, 0);
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionApprovalLevelId = ConvertToRestWithoutDefaults(s.ssRequisitionApprovalLevelId, 0L);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrId = (long?) s.ssId;
AttrCommentTypeId = (int?) s.ssCommentTypeId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionApprovalLevelId = (long?) s.ssRequisitionApprovalLevelId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord, EN_cbeb601b681344342c8de0161d058f87EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord s) => ToStructure(s, config);
}
public static EN_cbeb601b681344342c8de0161d058f87EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_cbeb601b681344342c8de0161d058f87EntityRecord s = new EN_cbeb601b681344342c8de0161d058f87EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCommentTypeId = obj.AttrCommentTypeId == null ? 0 : obj.AttrCommentTypeId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionApprovalLevelId = obj.AttrRequisitionApprovalLevelId == null ? 0L : obj.AttrRequisitionApprovalLevelId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_cbeb601b681344342c8de0161d058f87EntityRecord, ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_cbeb601b681344342c8de0161d058f87EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord FromStructure(EN_cbeb601b681344342c8de0161d058f87EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord(s, config);
}

}


