using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcess
public class JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord : AbstractRESTStructure<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("OffsetUtc")]
[JsonPropertyName("OffsetUtc")]
public int? AttrOffsetUtc;

[JsonProperty("Comment")]
[JsonPropertyName("Comment")]
public string AttrComment;

[JsonProperty("ProcessNumber")]
[JsonPropertyName("ProcessNumber")]
public int? AttrProcessNumber;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("NextTry")]
[JsonPropertyName("NextTry")]
public int? AttrNextTry;

[JsonProperty("InvoiceProcessStatusId")]
[JsonPropertyName("InvoiceProcessStatusId")]
public int? AttrInvoiceProcessStatusId;

public JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord() { }

public JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrOffsetUtc = ConvertToRestWithoutDefaults(s.ssOffsetUtc, 0);
AttrComment = ConvertToRestWithoutDefaults(s.ssComment, "");
AttrProcessNumber = ConvertToRestWithoutDefaults(s.ssProcessNumber, 0);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrNextTry = ConvertToRestWithoutDefaults(s.ssNextTry, 1);
AttrInvoiceProcessStatusId = ConvertToRestWithoutDefaults(s.ssInvoiceProcessStatusId, 0);
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrOffsetUtc = (int?) s.ssOffsetUtc;
AttrComment = s.ssComment;
AttrProcessNumber = (int?) s.ssProcessNumber;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrNextTry = (int?) s.ssNextTry;
AttrInvoiceProcessStatusId = (int?) s.ssInvoiceProcessStatusId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord s) => ToStructure(s, config);
}
public static EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d21666375df829d28ffce8e5e0a3400dEntityRecord s = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssOffsetUtc = obj.AttrOffsetUtc == null ? 0 : obj.AttrOffsetUtc.Value;
  s.ssComment = obj.AttrComment == null ? "" : obj.AttrComment;
  s.ssProcessNumber = obj.AttrProcessNumber == null ? 0 : obj.AttrProcessNumber.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssNextTry = obj.AttrNextTry == null ? 1 : obj.AttrNextTry.Value;
  s.ssInvoiceProcessStatusId = obj.AttrInvoiceProcessStatusId == null ? 0 : obj.AttrInvoiceProcessStatusId.Value;
  }
  return s;
}

public static Func<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord, ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord FromStructure(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord(s, config);
}

}


