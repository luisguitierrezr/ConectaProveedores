using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Reassignments
public class JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord : AbstractRESTStructure<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("SourceUserId")]
[JsonPropertyName("SourceUserId")]
public string AttrSourceUserId;

[JsonProperty("TargetUserId")]
[JsonPropertyName("TargetUserId")]
public string AttrTargetUserId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
[JsonPropertyName("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceApprovalLevelId")]
[JsonPropertyName("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("Reason")]
[JsonPropertyName("Reason")]
public string AttrReason;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("RevokedBy")]
[JsonPropertyName("RevokedBy")]
public string AttrRevokedBy;

[JsonProperty("RevokedOn")]
[JsonPropertyName("RevokedOn")]
public String AttrRevokedOn;

[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioApprovalLevelId")]
[JsonPropertyName("FolioApprovalLevelId")]
public long? AttrFolioApprovalLevelId;

[JsonProperty("SourceEntraRoleId")]
[JsonPropertyName("SourceEntraRoleId")]
public long? AttrSourceEntraRoleId;

[JsonProperty("TargetEntraRoleId")]
[JsonPropertyName("TargetEntraRoleId")]
public long? AttrTargetEntraRoleId;

[JsonProperty("IsFolioApprovalLevelInvoice")]
[JsonPropertyName("IsFolioApprovalLevelInvoice")]
public bool? AttrIsFolioApprovalLevelInvoice;

public JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord() { }

public JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord, EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s) => ToStructure(s, config);
}
public static EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord obj, IBehaviorsConfiguration config) { 
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
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssRevokedBy = obj.AttrRevokedBy == null ? "" : obj.AttrRevokedBy;
  s.ssRevokedOn = obj.AttrRevokedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRevokedOn, config.DateTimeFormat);
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssFolioApprovalLevelId = obj.AttrFolioApprovalLevelId == null ? 0L : obj.AttrFolioApprovalLevelId.Value;
  s.ssSourceEntraRoleId = obj.AttrSourceEntraRoleId == null ? 0L : obj.AttrSourceEntraRoleId.Value;
  s.ssTargetEntraRoleId = obj.AttrTargetEntraRoleId == null ? 0L : obj.AttrTargetEntraRoleId.Value;
  s.ssIsFolioApprovalLevelInvoice = obj.AttrIsFolioApprovalLevelInvoice == null ? false : obj.AttrIsFolioApprovalLevelInvoice.Value;
  }
  return s;
}

public static Func<EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord, ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord FromStructure(EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(s, config);
}

}


