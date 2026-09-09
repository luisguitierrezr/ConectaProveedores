using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConcepts
public class JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord : AbstractRESTStructure<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderAccountingId")]
[JsonPropertyName("OrderAccountingId")]
public long? AttrOrderAccountingId;

[JsonProperty("AccountingDataTypeId")]
[JsonPropertyName("AccountingDataTypeId")]
public int? AttrAccountingDataTypeId;

[JsonProperty("NumberOfPayments")]
[JsonPropertyName("NumberOfPayments")]
public int? AttrNumberOfPayments;

[JsonProperty("Amount")]
[JsonPropertyName("Amount")]
public decimal? AttrAmount;

[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("OrderAccConceptsId")]
[JsonPropertyName("OrderAccConceptsId")]
public long? AttrOrderAccConceptsId;

[JsonProperty("ApplyForRequestProject")]
[JsonPropertyName("ApplyForRequestProject")]
public bool? AttrApplyForRequestProject;

[JsonProperty("PaymentTermId")]
[JsonPropertyName("PaymentTermId")]
public long? AttrPaymentTermId;

[JsonProperty("PaymentTermCustomDays")]
[JsonPropertyName("PaymentTermCustomDays")]
public int? AttrPaymentTermCustomDays;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("AdvancePaymentTypeId")]
[JsonPropertyName("AdvancePaymentTypeId")]
public int? AttrAdvancePaymentTypeId;

[JsonProperty("PaymentDate")]
[JsonPropertyName("PaymentDate")]
public String AttrPaymentDate;

[JsonProperty("PaymentMethodsIdToDelete")]
[JsonPropertyName("PaymentMethodsIdToDelete")]
public long? AttrPaymentMethodsIdToDelete;

public JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord() { }

public JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderAccountingId = ConvertToRestWithoutDefaults(s.ssOrderAccountingId, 0L);
AttrAccountingDataTypeId = ConvertToRestWithoutDefaults(s.ssAccountingDataTypeId, 0);
AttrNumberOfPayments = ConvertToRestWithoutDefaults(s.ssNumberOfPayments, 0);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrOrderAccConceptsId = ConvertToRestWithoutDefaults(s.ssOrderAccConceptsId, 0L);
AttrApplyForRequestProject = ConvertToRestWithoutDefaults(s.ssApplyForRequestProject, false);
AttrPaymentTermId = ConvertToRestWithoutDefaults(s.ssPaymentTermId, 0L);
AttrPaymentTermCustomDays = ConvertToRestWithoutDefaults(s.ssPaymentTermCustomDays, 0);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrAdvancePaymentTypeId = ConvertToRestWithoutDefaults(s.ssAdvancePaymentTypeId, 0);
AttrPaymentDate = ConvertDateToRestWithoutDefaults(s.ssPaymentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrPaymentMethodsIdToDelete = ConvertToRestWithoutDefaults(s.ssPaymentMethodsIdToDelete, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrOrderAccountingId = (long?) s.ssOrderAccountingId;
AttrAccountingDataTypeId = (int?) s.ssAccountingDataTypeId;
AttrNumberOfPayments = (int?) s.ssNumberOfPayments;
AttrAmount = (decimal?) s.ssAmount;
AttrCurrencyId = s.ssCurrencyId;
AttrOrderAccConceptsId = (long?) s.ssOrderAccConceptsId;
AttrApplyForRequestProject = (bool?) s.ssApplyForRequestProject;
AttrPaymentTermId = (long?) s.ssPaymentTermId;
AttrPaymentTermCustomDays = (int?) s.ssPaymentTermCustomDays;
AttrIsActive = (bool?) s.ssIsActive;
AttrAdvancePaymentTypeId = (int?) s.ssAdvancePaymentTypeId;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
AttrPaymentMethodsIdToDelete = (long?) s.ssPaymentMethodsIdToDelete;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord s) => ToStructure(s, config);
}
public static EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_3e07a23619060cc7dc5624548803f5fdEntityRecord s = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderAccountingId = obj.AttrOrderAccountingId == null ? 0L : obj.AttrOrderAccountingId.Value;
  s.ssAccountingDataTypeId = obj.AttrAccountingDataTypeId == null ? 0 : obj.AttrAccountingDataTypeId.Value;
  s.ssNumberOfPayments = obj.AttrNumberOfPayments == null ? 0 : obj.AttrNumberOfPayments.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssOrderAccConceptsId = obj.AttrOrderAccConceptsId == null ? 0L : obj.AttrOrderAccConceptsId.Value;
  s.ssApplyForRequestProject = obj.AttrApplyForRequestProject == null ? false : obj.AttrApplyForRequestProject.Value;
  s.ssPaymentTermId = obj.AttrPaymentTermId == null ? 0L : obj.AttrPaymentTermId.Value;
  s.ssPaymentTermCustomDays = obj.AttrPaymentTermCustomDays == null ? 0 : obj.AttrPaymentTermCustomDays.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssAdvancePaymentTypeId = obj.AttrAdvancePaymentTypeId == null ? 0 : obj.AttrAdvancePaymentTypeId.Value;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  s.ssPaymentMethodsIdToDelete = obj.AttrPaymentMethodsIdToDelete == null ? 0L : obj.AttrPaymentMethodsIdToDelete.Value;
  }
  return s;
}

public static Func<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord, ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord FromStructure(EN_3e07a23619060cc7dc5624548803f5fdEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord(s, config);
}

}


