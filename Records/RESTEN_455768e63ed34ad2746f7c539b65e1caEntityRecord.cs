using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionService
public class RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord : AbstractRESTStructure<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

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

public RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord() { }

public RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrAccountingServiceTypeId = ConvertToRestWithoutDefaults(s.ssAccountingServiceTypeId, 0L);
AttrFrequencyId = ConvertToRestWithoutDefaults(s.ssFrequencyId, 0);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrInvoiceUsageId = ConvertToRestWithoutDefaults(s.ssInvoiceUsageId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrAccountingServiceTypeId = (long?) s.ssAccountingServiceTypeId;
AttrFrequencyId = (int?) s.ssFrequencyId;
AttrAmount = (decimal?) s.ssAmount;
AttrDescription = s.ssDescription;
AttrInvoiceUsageId = (long?) s.ssInvoiceUsageId;
  }
}

public static EN_455768e63ed34ad2746f7c539b65e1caEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord obj) { 
  EN_455768e63ed34ad2746f7c539b65e1caEntityRecord s = new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssAccountingServiceTypeId = obj.AttrAccountingServiceTypeId == null ? 0L : obj.AttrAccountingServiceTypeId.Value;
  s.ssFrequencyId = obj.AttrFrequencyId == null ? 0 : obj.AttrFrequencyId.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssInvoiceUsageId = obj.AttrInvoiceUsageId == null ? 0L : obj.AttrInvoiceUsageId.Value;
  }
  return s;
}

public static Func<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord FromStructure(EN_455768e63ed34ad2746f7c539b65e1caEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord(s, config);
}

}


