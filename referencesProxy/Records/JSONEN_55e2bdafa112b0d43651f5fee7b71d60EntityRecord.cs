using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// InvoicesUsageAccounts
public class JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord : AbstractRESTStructure<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceUsageId")]
[JsonPropertyName("InvoiceUsageId")]
public long? AttrInvoiceUsageId;

[JsonProperty("AccountingAccount")]
[JsonPropertyName("AccountingAccount")]
public string AttrAccountingAccount;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

public JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord() { }

public JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceUsageId = ConvertToRestWithoutDefaults(s.ssInvoiceUsageId, 0L);
AttrAccountingAccount = ConvertToRestWithoutDefaults(s.ssAccountingAccount, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceUsageId = (long?) s.ssInvoiceUsageId;
AttrAccountingAccount = s.ssAccountingAccount;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord, EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord s) => ToStructure(s, config);
}
public static EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord s = new EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceUsageId = obj.AttrInvoiceUsageId == null ? 0L : obj.AttrInvoiceUsageId.Value;
  s.ssAccountingAccount = obj.AttrAccountingAccount == null ? "" : obj.AttrAccountingAccount;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord FromStructure(EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord(s, config);
}

}


