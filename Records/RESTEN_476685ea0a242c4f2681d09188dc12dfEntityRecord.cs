using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderService
public class RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord : AbstractRESTStructure<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("AccountingServiceTypeId")]
public long? AttrAccountingServiceTypeId;

[JsonProperty("FrequencyId")]
public int? AttrFrequencyId;

[JsonProperty("Amount")]
public decimal? AttrAmount;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("InvoiceUsageId")]
public long? AttrInvoiceUsageId;

public RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord() { }

public RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_476685ea0a242c4f2681d09188dc12dfEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord obj) { 
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

public static Func<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord, ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord FromStructure(EN_476685ea0a242c4f2681d09188dc12dfEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord(s, config);
}

}


