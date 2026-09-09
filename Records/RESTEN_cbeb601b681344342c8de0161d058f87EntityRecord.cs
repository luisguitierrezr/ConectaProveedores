using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionComment
public class RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord : AbstractRESTStructure<EN_cbeb601b681344342c8de0161d058f87EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("Message")]
public string AttrMessage;

public RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord() { }

public RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord (EN_cbeb601b681344342c8de0161d058f87EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_cbeb601b681344342c8de0161d058f87EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord obj) { 
  EN_cbeb601b681344342c8de0161d058f87EntityRecord s = new EN_cbeb601b681344342c8de0161d058f87EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCommentTypeId = obj.AttrCommentTypeId == null ? 0 : obj.AttrCommentTypeId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionApprovalLevelId = obj.AttrRequisitionApprovalLevelId == null ? 0L : obj.AttrRequisitionApprovalLevelId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_cbeb601b681344342c8de0161d058f87EntityRecord, ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_cbeb601b681344342c8de0161d058f87EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord FromStructure(EN_cbeb601b681344342c8de0161d058f87EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_cbeb601b681344342c8de0161d058f87EntityRecord(s, config);
}

}


