using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderService
public class JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord : AbstractRESTStructure<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

[JsonProperty("AccountingServiceTypeId")]
[JsonPropertyName("AccountingServiceTypeId")]
public long? AttrAccountingServiceTypeId;

[JsonProperty("FrequencyId")]
[JsonPropertyName("FrequencyId")]
public int? AttrFrequencyId;

[JsonProperty("Amount")]
[JsonPropertyName("Amount")]
public decimal? AttrAmount;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("InvoiceUsageId")]
[JsonPropertyName("InvoiceUsageId")]
public long? AttrInvoiceUsageId;

public JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord() { }

public JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrAccountingServiceTypeId = ConvertToRestWithoutDefaults(s.ssAccountingServiceTypeId, 0L);
AttrFrequencyId = ConvertToRestWithoutDefaults(s.ssFrequencyId, 0);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrInvoiceUsageId = ConvertToRestWithoutDefaults(s.ssInvoiceUsageId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrAccountingServiceTypeId = (long?) s.ssAccountingServiceTypeId;
AttrFrequencyId = (int?) s.ssFrequencyId;
AttrAmount = (decimal?) s.ssAmount;
AttrDescription = s.ssDescription;
AttrInvoiceUsageId = (long?) s.ssInvoiceUsageId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord, EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord s) => ToStructure(s, config);
}
public static EN_476685ea0a242c4f2681d09188dc12dfEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s = new EN_476685ea0a242c4f2681d09188dc12dfEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssAccountingServiceTypeId = obj.AttrAccountingServiceTypeId == null ? 0L : obj.AttrAccountingServiceTypeId.Value;
  s.ssFrequencyId = obj.AttrFrequencyId == null ? 0 : obj.AttrFrequencyId.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssInvoiceUsageId = obj.AttrInvoiceUsageId == null ? 0L : obj.AttrInvoiceUsageId.Value;
  }
  return s;
}

public static Func<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord, ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord FromStructure(EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord(s, config);
}

}


