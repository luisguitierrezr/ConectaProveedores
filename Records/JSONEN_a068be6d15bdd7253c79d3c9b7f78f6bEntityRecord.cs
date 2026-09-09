using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioExtended
public class JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord : AbstractRESTStructure<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("IsAdvPayment")]
[JsonPropertyName("IsAdvPayment")]
public bool? AttrIsAdvPayment;

[JsonProperty("AdvPaymentValue")]
[JsonPropertyName("AdvPaymentValue")]
public decimal? AttrAdvPaymentValue;

[JsonProperty("IsCreditNote")]
[JsonPropertyName("IsCreditNote")]
public bool? AttrIsCreditNote;

[JsonProperty("CreditNoteValue")]
[JsonPropertyName("CreditNoteValue")]
public decimal? AttrCreditNoteValue;

[JsonProperty("IsVoucher")]
[JsonPropertyName("IsVoucher")]
public bool? AttrIsVoucher;

[JsonProperty("VoucherValue")]
[JsonPropertyName("VoucherValue")]
public decimal? AttrVoucherValue;

[JsonProperty("IsNa")]
[JsonPropertyName("IsNa")]
public bool? AttrIsNa;

public JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord() { }

public JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrIsAdvPayment = ConvertToRestWithoutDefaults(s.ssIsAdvPayment, false);
AttrAdvPaymentValue = ConvertToRestWithoutDefaults(s.ssAdvPaymentValue, 0.0M);
AttrIsCreditNote = ConvertToRestWithoutDefaults(s.ssIsCreditNote, false);
AttrCreditNoteValue = ConvertToRestWithoutDefaults(s.ssCreditNoteValue, 0.0M);
AttrIsVoucher = ConvertToRestWithoutDefaults(s.ssIsVoucher, false);
AttrVoucherValue = ConvertToRestWithoutDefaults(s.ssVoucherValue, 0.0M);
AttrIsNa = ConvertToRestWithoutDefaults(s.ssIsNa, false);
  } else {
AttrId = (long?) s.ssId;
AttrIsAdvPayment = (bool?) s.ssIsAdvPayment;
AttrAdvPaymentValue = (decimal?) s.ssAdvPaymentValue;
AttrIsCreditNote = (bool?) s.ssIsCreditNote;
AttrCreditNoteValue = (decimal?) s.ssCreditNoteValue;
AttrIsVoucher = (bool?) s.ssIsVoucher;
AttrVoucherValue = (decimal?) s.ssVoucherValue;
AttrIsNa = (bool?) s.ssIsNa;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord, EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord s) => ToStructure(s, config);
}
public static EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord s = new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssIsAdvPayment = obj.AttrIsAdvPayment == null ? false : obj.AttrIsAdvPayment.Value;
  s.ssAdvPaymentValue = obj.AttrAdvPaymentValue == null ? 0.0M : obj.AttrAdvPaymentValue.Value;
  s.ssIsCreditNote = obj.AttrIsCreditNote == null ? false : obj.AttrIsCreditNote.Value;
  s.ssCreditNoteValue = obj.AttrCreditNoteValue == null ? 0.0M : obj.AttrCreditNoteValue.Value;
  s.ssIsVoucher = obj.AttrIsVoucher == null ? false : obj.AttrIsVoucher.Value;
  s.ssVoucherValue = obj.AttrVoucherValue == null ? 0.0M : obj.AttrVoucherValue.Value;
  s.ssIsNa = obj.AttrIsNa == null ? false : obj.AttrIsNa.Value;
  }
  return s;
}

public static Func<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord, ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord FromStructure(EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord(s, config);
}

}


