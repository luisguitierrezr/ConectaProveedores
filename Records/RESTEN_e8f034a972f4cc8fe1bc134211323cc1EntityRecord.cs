using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Reassignments
public class RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord : AbstractRESTStructure<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("SourceUserId")]
public string AttrSourceUserId;

[JsonProperty("TargetUserId")]
public string AttrTargetUserId;

[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("Reason")]
public string AttrReason;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("RevokedBy")]
public string AttrRevokedBy;

[JsonProperty("RevokedOn")]
public String AttrRevokedOn;

[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioApprovalLevelId")]
public long? AttrFolioApprovalLevelId;

[JsonProperty("SourceEntraRoleId")]
public long? AttrSourceEntraRoleId;

[JsonProperty("TargetEntraRoleId")]
public long? AttrTargetEntraRoleId;

[JsonProperty("IsFolioApprovalLevelInvoice")]
public bool? AttrIsFolioApprovalLevelInvoice;

public RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord() { }

public RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSourceUserId = ConvertToRestWithoutDefaults(s.ssSourceUserId, "");
AttrTargetUserId = ConvertToRestWithoutDefaults(s.ssTargetUserId, "");
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionApprovalLevelId = ConvertToRestWithoutDefaults(s.ssRequisitionApprovalLevelId, 0L);
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceApprovalLevelId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalLevelId, 0L);
AttrReason = ConvertToRestWithoutDefaults(s.ssReason, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRevokedBy = ConvertToRestWithoutDefaults(s.ssRevokedBy, "");
AttrRevokedOn = ConvertDateTimeToRestWithoutDefaults(s.ssRevokedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrFolioApprovalLevelId = ConvertToRestWithoutDefaults(s.ssFolioApprovalLevelId, 0L);
AttrSourceEntraRoleId = ConvertToRestWithoutDefaults(s.ssSourceEntraRoleId, 0L);
AttrTargetEntraRoleId = ConvertToRestWithoutDefaults(s.ssTargetEntraRoleId, 0L);
AttrIsFolioApprovalLevelInvoice = ConvertToRestWithoutDefaults(s.ssIsFolioApprovalLevelInvoice, false);
  } else {
AttrId = (long?) s.ssId;
AttrSourceUserId = s.ssSourceUserId;
AttrTargetUserId = s.ssTargetUserId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionApprovalLevelId = (long?) s.ssRequisitionApprovalLevelId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceApprovalLevelId = (long?) s.ssInvoiceApprovalLevelId;
AttrReason = s.ssReason;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrRevokedBy = s.ssRevokedBy;
AttrRevokedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRevokedOn, config.DateTimeFormat);
AttrFolioId = (long?) s.ssFolioId;
AttrFolioApprovalLevelId = (long?) s.ssFolioApprovalLevelId;
AttrSourceEntraRoleId = (long?) s.ssSourceEntraRoleId;
AttrTargetEntraRoleId = (long?) s.ssTargetEntraRoleId;
AttrIsFolioApprovalLevelInvoice = (bool?) s.ssIsFolioApprovalLevelInvoice;
  }
}

public static EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord obj) { 
  EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s = new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSourceUserId = obj.AttrSourceUserId == null ? "" : obj.AttrSourceUserId;
  s.ssTargetUserId = obj.AttrTargetUserId == null ? "" : obj.AttrTargetUserId;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionApprovalLevelId = obj.AttrRequisitionApprovalLevelId == null ? 0L : obj.AttrRequisitionApprovalLevelId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssReason = obj.AttrReason == null ? "" : obj.AttrReason;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRevokedBy = obj.AttrRevokedBy == null ? "" : obj.AttrRevokedBy;
  s.ssRevokedOn = obj.AttrRevokedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRevokedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssFolioApprovalLevelId = obj.AttrFolioApprovalLevelId == null ? 0L : obj.AttrFolioApprovalLevelId.Value;
  s.ssSourceEntraRoleId = obj.AttrSourceEntraRoleId == null ? 0L : obj.AttrSourceEntraRoleId.Value;
  s.ssTargetEntraRoleId = obj.AttrTargetEntraRoleId == null ? 0L : obj.AttrTargetEntraRoleId.Value;
  s.ssIsFolioApprovalLevelInvoice = obj.AttrIsFolioApprovalLevelInvoice == null ? false : obj.AttrIsFolioApprovalLevelInvoice.Value;
  }
  return s;
}

public static Func<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord, ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord FromStructure(EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(s, config);
}

}


