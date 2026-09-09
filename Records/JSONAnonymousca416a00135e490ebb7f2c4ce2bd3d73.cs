using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountMaxAlowedPartialDeliveryAmountPercentageDeliveredTotalAmountRecord
public class JSONRC_0b2176705fa164c9531eb643caf0e9d4 : AbstractRESTStructure<RC_0b2176705fa164c9531eb643caf0e9d4> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("AmountDelivered")]
[JsonPropertyName("AmountDelivered")]
public decimal? AttrAmountDelivered;

[JsonProperty("AmountLeft")]
[JsonPropertyName("AmountLeft")]
public decimal? AttrAmountLeft;

[JsonProperty("Difference_FormSAE_Invoice_Amount")]
[JsonPropertyName("Difference_FormSAE_Invoice_Amount")]
public decimal? AttrDifference_FormSAE_Invoice_Amount;

[JsonProperty("Difference_FormSAE_Invoice_Percent")]
[JsonPropertyName("Difference_FormSAE_Invoice_Percent")]
public decimal? AttrDifference_FormSAE_Invoice_Percent;

[JsonProperty("InvoicingAmount")]
[JsonPropertyName("InvoicingAmount")]
public decimal? AttrInvoicingAmount;

[JsonProperty("MaxAlowed")]
[JsonPropertyName("MaxAlowed")]
public decimal? AttrMaxAlowed;

[JsonProperty("PartialDeliveryAmount")]
[JsonPropertyName("PartialDeliveryAmount")]
public decimal? AttrPartialDeliveryAmount;

[JsonProperty("PercentageDelivered")]
[JsonPropertyName("PercentageDelivered")]
public decimal? AttrPercentageDelivered;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

public JSONRC_0b2176705fa164c9531eb643caf0e9d4() { }

public JSONRC_0b2176705fa164c9531eb643caf0e9d4 (RC_0b2176705fa164c9531eb643caf0e9d4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrAmountDelivered = ConvertToRestWithoutDefaults(s.ssAmountDelivered, 0.0M);
AttrAmountLeft = ConvertToRestWithoutDefaults(s.ssAmountLeft, 0.0M);
AttrDifference_FormSAE_Invoice_Amount = ConvertToRestWithoutDefaults(s.ssDifference_FormSAE_Invoice_Amount, 0.0M);
AttrDifference_FormSAE_Invoice_Percent = ConvertToRestWithoutDefaults(s.ssDifference_FormSAE_Invoice_Percent, 0.0M);
AttrInvoicingAmount = ConvertToRestWithoutDefaults(s.ssInvoicingAmount, 0.0M);
AttrMaxAlowed = ConvertToRestWithoutDefaults(s.ssMaxAlowed, 0.0M);
AttrPartialDeliveryAmount = ConvertToRestWithoutDefaults(s.ssPartialDeliveryAmount, 0.0M);
AttrPercentageDelivered = ConvertToRestWithoutDefaults(s.ssPercentageDelivered, 0.0M);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
  } else {
AttrCurrency = s.ssCurrency;
AttrAmountDelivered = (decimal?) s.ssAmountDelivered;
AttrAmountLeft = (decimal?) s.ssAmountLeft;
AttrDifference_FormSAE_Invoice_Amount = (decimal?) s.ssDifference_FormSAE_Invoice_Amount;
AttrDifference_FormSAE_Invoice_Percent = (decimal?) s.ssDifference_FormSAE_Invoice_Percent;
AttrInvoicingAmount = (decimal?) s.ssInvoicingAmount;
AttrMaxAlowed = (decimal?) s.ssMaxAlowed;
AttrPartialDeliveryAmount = (decimal?) s.ssPartialDeliveryAmount;
AttrPercentageDelivered = (decimal?) s.ssPercentageDelivered;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0b2176705fa164c9531eb643caf0e9d4, RC_0b2176705fa164c9531eb643caf0e9d4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0b2176705fa164c9531eb643caf0e9d4 s) => ToStructure(s, config);
}
public static RC_0b2176705fa164c9531eb643caf0e9d4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0b2176705fa164c9531eb643caf0e9d4 obj, IBehaviorsConfiguration config) { 
  RC_0b2176705fa164c9531eb643caf0e9d4 s = new RC_0b2176705fa164c9531eb643caf0e9d4();
  if(obj != null) {
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssAmountDelivered = obj.AttrAmountDelivered == null ? 0.0M : obj.AttrAmountDelivered.Value;
  s.ssAmountLeft = obj.AttrAmountLeft == null ? 0.0M : obj.AttrAmountLeft.Value;
  s.ssDifference_FormSAE_Invoice_Amount = obj.AttrDifference_FormSAE_Invoice_Amount == null ? 0.0M : obj.AttrDifference_FormSAE_Invoice_Amount.Value;
  s.ssDifference_FormSAE_Invoice_Percent = obj.AttrDifference_FormSAE_Invoice_Percent == null ? 0.0M : obj.AttrDifference_FormSAE_Invoice_Percent.Value;
  s.ssInvoicingAmount = obj.AttrInvoicingAmount == null ? 0.0M : obj.AttrInvoicingAmount.Value;
  s.ssMaxAlowed = obj.AttrMaxAlowed == null ? 0.0M : obj.AttrMaxAlowed.Value;
  s.ssPartialDeliveryAmount = obj.AttrPartialDeliveryAmount == null ? 0.0M : obj.AttrPartialDeliveryAmount.Value;
  s.ssPercentageDelivered = obj.AttrPercentageDelivered == null ? 0.0M : obj.AttrPercentageDelivered.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  }
  return s;
}

public static Func<RC_0b2176705fa164c9531eb643caf0e9d4, ssConectaProveedores.RestRecords.JSONRC_0b2176705fa164c9531eb643caf0e9d4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0b2176705fa164c9531eb643caf0e9d4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0b2176705fa164c9531eb643caf0e9d4 FromStructure(RC_0b2176705fa164c9531eb643caf0e9d4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0b2176705fa164c9531eb643caf0e9d4(s, config);
}

}


