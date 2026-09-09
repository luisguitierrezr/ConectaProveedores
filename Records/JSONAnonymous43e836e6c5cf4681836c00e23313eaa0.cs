using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord
public class JSONRC_1c2482ce6cd4b83ca44ec0510b231d44 : AbstractRESTStructure<RC_1c2482ce6cd4b83ca44ec0510b231d44> {
[JsonProperty("AdvPaymentValue")]
[JsonPropertyName("AdvPaymentValue")]
public decimal? AttrAdvPaymentValue;

[JsonProperty("CreditNoteValue")]
[JsonPropertyName("CreditNoteValue")]
public decimal? AttrCreditNoteValue;

[JsonProperty("VoucherValue")]
[JsonPropertyName("VoucherValue")]
public decimal? AttrVoucherValue;

[JsonProperty("AdvPayment")]
[JsonPropertyName("AdvPayment")]
public bool? AttrAdvPayment;

[JsonProperty("CreditNote")]
[JsonPropertyName("CreditNote")]
public bool? AttrCreditNote;

[JsonProperty("NA")]
[JsonPropertyName("NA")]
public bool? AttrNA;

[JsonProperty("Voucher")]
[JsonPropertyName("Voucher")]
public bool? AttrVoucher;

public JSONRC_1c2482ce6cd4b83ca44ec0510b231d44() { }

public JSONRC_1c2482ce6cd4b83ca44ec0510b231d44 (RC_1c2482ce6cd4b83ca44ec0510b231d44 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAdvPaymentValue = ConvertToRestWithoutDefaults(s.ssAdvPaymentValue, 0.0M);
AttrCreditNoteValue = ConvertToRestWithoutDefaults(s.ssCreditNoteValue, 0.0M);
AttrVoucherValue = ConvertToRestWithoutDefaults(s.ssVoucherValue, 0.0M);
AttrAdvPayment = ConvertToRestWithoutDefaults(s.ssAdvPayment, false);
AttrCreditNote = ConvertToRestWithoutDefaults(s.ssCreditNote, false);
AttrNA = ConvertToRestWithoutDefaults(s.ssNA, false);
AttrVoucher = ConvertToRestWithoutDefaults(s.ssVoucher, false);
  } else {
AttrAdvPaymentValue = (decimal?) s.ssAdvPaymentValue;
AttrCreditNoteValue = (decimal?) s.ssCreditNoteValue;
AttrVoucherValue = (decimal?) s.ssVoucherValue;
AttrAdvPayment = (bool?) s.ssAdvPayment;
AttrCreditNote = (bool?) s.ssCreditNote;
AttrNA = (bool?) s.ssNA;
AttrVoucher = (bool?) s.ssVoucher;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1c2482ce6cd4b83ca44ec0510b231d44, RC_1c2482ce6cd4b83ca44ec0510b231d44> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1c2482ce6cd4b83ca44ec0510b231d44 s) => ToStructure(s, config);
}
public static RC_1c2482ce6cd4b83ca44ec0510b231d44 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1c2482ce6cd4b83ca44ec0510b231d44 obj, IBehaviorsConfiguration config) { 
  RC_1c2482ce6cd4b83ca44ec0510b231d44 s = new RC_1c2482ce6cd4b83ca44ec0510b231d44();
  if(obj != null) {
  s.ssAdvPaymentValue = obj.AttrAdvPaymentValue == null ? 0.0M : obj.AttrAdvPaymentValue.Value;
  s.ssCreditNoteValue = obj.AttrCreditNoteValue == null ? 0.0M : obj.AttrCreditNoteValue.Value;
  s.ssVoucherValue = obj.AttrVoucherValue == null ? 0.0M : obj.AttrVoucherValue.Value;
  s.ssAdvPayment = obj.AttrAdvPayment == null ? false : obj.AttrAdvPayment.Value;
  s.ssCreditNote = obj.AttrCreditNote == null ? false : obj.AttrCreditNote.Value;
  s.ssNA = obj.AttrNA == null ? false : obj.AttrNA.Value;
  s.ssVoucher = obj.AttrVoucher == null ? false : obj.AttrVoucher.Value;
  }
  return s;
}

public static Func<RC_1c2482ce6cd4b83ca44ec0510b231d44, ssConectaProveedores.RestRecords.JSONRC_1c2482ce6cd4b83ca44ec0510b231d44> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1c2482ce6cd4b83ca44ec0510b231d44 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1c2482ce6cd4b83ca44ec0510b231d44 FromStructure(RC_1c2482ce6cd4b83ca44ec0510b231d44 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1c2482ce6cd4b83ca44ec0510b231d44(s, config);
}

}


