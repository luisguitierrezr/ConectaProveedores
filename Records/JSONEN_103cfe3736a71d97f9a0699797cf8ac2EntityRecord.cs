using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServices
public class JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord : AbstractRESTStructure<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceAccountingId")]
[JsonPropertyName("InvoiceAccountingId")]
public long? AttrInvoiceAccountingId;

[JsonProperty("ServiceTypeId")]
[JsonPropertyName("ServiceTypeId")]
public long? AttrServiceTypeId;

[JsonProperty("Account")]
[JsonPropertyName("Account")]
public string AttrAccount;

[JsonProperty("CostCenterId")]
[JsonPropertyName("CostCenterId")]
public long? AttrCostCenterId;

[JsonProperty("CeBeCostCenterId")]
[JsonPropertyName("CeBeCostCenterId")]
public long? AttrCeBeCostCenterId;

[JsonProperty("Amount")]
[JsonPropertyName("Amount")]
public decimal? AttrAmount;

[JsonProperty("IVA_Old")]
[JsonPropertyName("IVA_Old")]
public string AttrIVA_Old;

[JsonProperty("IVAIndicatorId")]
[JsonPropertyName("IVAIndicatorId")]
public long? AttrIVAIndicatorId;

[JsonProperty("BuyDocNumber")]
[JsonPropertyName("BuyDocNumber")]
public string AttrBuyDocNumber;

[JsonProperty("BuyDocPosition")]
[JsonPropertyName("BuyDocPosition")]
public string AttrBuyDocPosition;

[JsonProperty("FreeText")]
[JsonPropertyName("FreeText")]
public string AttrFreeText;

[JsonProperty("Division")]
[JsonPropertyName("Division")]
public string AttrDivision;

[JsonProperty("ICME")]
[JsonPropertyName("ICME")]
public string AttrICME;

public JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord() { }

public JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceAccountingId = ConvertToRestWithoutDefaults(s.ssInvoiceAccountingId, 0L);
AttrServiceTypeId = ConvertToRestWithoutDefaults(s.ssServiceTypeId, 0L);
AttrAccount = ConvertToRestWithoutDefaults(s.ssAccount, "");
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssCostCenterId, 0L);
AttrCeBeCostCenterId = ConvertToRestWithoutDefaults(s.ssCeBeCostCenterId, 0L);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrIVA_Old = ConvertToRestWithoutDefaults(s.ssIVA_Old, "");
AttrIVAIndicatorId = ConvertToRestWithoutDefaults(s.ssIVAIndicatorId, 0L);
AttrBuyDocNumber = ConvertToRestWithoutDefaults(s.ssBuyDocNumber, "");
AttrBuyDocPosition = ConvertToRestWithoutDefaults(s.ssBuyDocPosition, "");
AttrFreeText = ConvertToRestWithoutDefaults(s.ssFreeText, "");
AttrDivision = ConvertToRestWithoutDefaults(s.ssDivision, "");
AttrICME = ConvertToRestWithoutDefaults(s.ssICME, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceAccountingId = (long?) s.ssInvoiceAccountingId;
AttrServiceTypeId = (long?) s.ssServiceTypeId;
AttrAccount = s.ssAccount;
AttrCostCenterId = (long?) s.ssCostCenterId;
AttrCeBeCostCenterId = (long?) s.ssCeBeCostCenterId;
AttrAmount = (decimal?) s.ssAmount;
AttrIVA_Old = s.ssIVA_Old;
AttrIVAIndicatorId = (long?) s.ssIVAIndicatorId;
AttrBuyDocNumber = s.ssBuyDocNumber;
AttrBuyDocPosition = s.ssBuyDocPosition;
AttrFreeText = s.ssFreeText;
AttrDivision = s.ssDivision;
AttrICME = s.ssICME;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord, EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord s) => ToStructure(s, config);
}
public static EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord s = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceAccountingId = obj.AttrInvoiceAccountingId == null ? 0L : obj.AttrInvoiceAccountingId.Value;
  s.ssServiceTypeId = obj.AttrServiceTypeId == null ? 0L : obj.AttrServiceTypeId.Value;
  s.ssAccount = obj.AttrAccount == null ? "" : obj.AttrAccount;
  s.ssCostCenterId = obj.AttrCostCenterId == null ? 0L : obj.AttrCostCenterId.Value;
  s.ssCeBeCostCenterId = obj.AttrCeBeCostCenterId == null ? 0L : obj.AttrCeBeCostCenterId.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssIVA_Old = obj.AttrIVA_Old == null ? "" : obj.AttrIVA_Old;
  s.ssIVAIndicatorId = obj.AttrIVAIndicatorId == null ? 0L : obj.AttrIVAIndicatorId.Value;
  s.ssBuyDocNumber = obj.AttrBuyDocNumber == null ? "" : obj.AttrBuyDocNumber;
  s.ssBuyDocPosition = obj.AttrBuyDocPosition == null ? "" : obj.AttrBuyDocPosition;
  s.ssFreeText = obj.AttrFreeText == null ? "" : obj.AttrFreeText;
  s.ssDivision = obj.AttrDivision == null ? "" : obj.AttrDivision;
  s.ssICME = obj.AttrICME == null ? "" : obj.AttrICME;
  }
  return s;
}

public static Func<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord, ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord FromStructure(EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(s, config);
}

}


