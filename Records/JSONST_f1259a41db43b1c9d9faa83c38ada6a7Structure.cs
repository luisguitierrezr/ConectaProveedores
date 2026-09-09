using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceCommentSA
public class JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure : AbstractRESTStructure<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceApprovalLevelId")]
[JsonPropertyName("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

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

public JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure() { }

public JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceApprovalLevelId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalLevelId, 0L);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrIsPublic = (bool?) s.ssIsPublic;
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceApprovalLevelId = (long?) s.ssInvoiceApprovalLevelId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrMessage = s.ssMessage;
AttrIsPublic = (bool?) s.ssIsPublic;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure, ST_f1259a41db43b1c9d9faa83c38ada6a7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure s) => ToStructure(s, config);
}
public static ST_f1259a41db43b1c9d9faa83c38ada6a7Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure obj, IBehaviorsConfiguration config) { 
  ST_f1259a41db43b1c9d9faa83c38ada6a7Structure s = new ST_f1259a41db43b1c9d9faa83c38ada6a7Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssIsPublic = obj.AttrIsPublic == null ? false : obj.AttrIsPublic.Value;
  }
  return s;
}

public static Func<ST_f1259a41db43b1c9d9faa83c38ada6a7Structure, ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f1259a41db43b1c9d9faa83c38ada6a7Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure FromStructure(ST_f1259a41db43b1c9d9faa83c38ada6a7Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure(s, config);
}

}


