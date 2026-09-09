using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFile
public class RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord : AbstractRESTStructure<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("OrderFileId")]
public long? AttrOrderFileId;

[JsonProperty("ContractFileTypeId")]
public int? AttrContractFileTypeId;

[JsonProperty("Amount")]
public decimal? AttrAmount;

[JsonProperty("Tarif")]
public decimal? AttrTarif;

[JsonProperty("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("DepositTypeId")]
public int? AttrDepositTypeId;

[JsonProperty("InsuranceTypeId")]
public int? AttrInsuranceTypeId;

[JsonProperty("AdvancePaymentTypeId")]
public int? AttrAdvancePaymentTypeId;

[JsonProperty("StartBaseDate")]
public String AttrStartBaseDate;

[JsonProperty("EndBaseDate")]
public String AttrEndBaseDate;

[JsonProperty("PaymentTermsId")]
public long? AttrPaymentTermsId;

[JsonProperty("IsForVendorUpload")]
public bool? AttrIsForVendorUpload;

public RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord() { }

public RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrOrderFileId = ConvertToRestWithoutDefaults(s.ssOrderFileId, 0L);
AttrContractFileTypeId = ConvertToRestWithoutDefaults(s.ssContractFileTypeId, 0);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrTarif = ConvertToRestWithoutDefaults(s.ssTarif, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrDepositTypeId = ConvertToRestWithoutDefaults(s.ssDepositTypeId, 0);
AttrInsuranceTypeId = ConvertToRestWithoutDefaults(s.ssInsuranceTypeId, 0);
AttrAdvancePaymentTypeId = ConvertToRestWithoutDefaults(s.ssAdvancePaymentTypeId, 0);
AttrStartBaseDate = ConvertDateToRestWithoutDefaults(s.ssStartBaseDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrEndBaseDate = ConvertDateToRestWithoutDefaults(s.ssEndBaseDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrPaymentTermsId = ConvertToRestWithoutDefaults(s.ssPaymentTermsId, 0L);
AttrIsForVendorUpload = ConvertToRestWithoutDefaults(s.ssIsForVendorUpload, false);
  } else {
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrOrderFileId = (long?) s.ssOrderFileId;
AttrContractFileTypeId = (int?) s.ssContractFileTypeId;
AttrAmount = (decimal?) s.ssAmount;
AttrTarif = (decimal?) s.ssTarif;
AttrCurrencyId = s.ssCurrencyId;
AttrDepositTypeId = (int?) s.ssDepositTypeId;
AttrInsuranceTypeId = (int?) s.ssInsuranceTypeId;
AttrAdvancePaymentTypeId = (int?) s.ssAdvancePaymentTypeId;
AttrStartBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssStartBaseDate);
AttrEndBaseDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssEndBaseDate);
AttrPaymentTermsId = (long?) s.ssPaymentTermsId;
AttrIsForVendorUpload = (bool?) s.ssIsForVendorUpload;
  }
}

public static EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord obj) { 
  EN_17538b35348920159ed0ee43b3fb2b50EntityRecord s = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssOrderFileId = obj.AttrOrderFileId == null ? 0L : obj.AttrOrderFileId.Value;
  s.ssContractFileTypeId = obj.AttrContractFileTypeId == null ? 0 : obj.AttrContractFileTypeId.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssTarif = obj.AttrTarif == null ? 0.0M : obj.AttrTarif.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssDepositTypeId = obj.AttrDepositTypeId == null ? 0 : obj.AttrDepositTypeId.Value;
  s.ssInsuranceTypeId = obj.AttrInsuranceTypeId == null ? 0 : obj.AttrInsuranceTypeId.Value;
  s.ssAdvancePaymentTypeId = obj.AttrAdvancePaymentTypeId == null ? 0 : obj.AttrAdvancePaymentTypeId.Value;
  s.ssStartBaseDate = obj.AttrStartBaseDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrStartBaseDate);
  s.ssEndBaseDate = obj.AttrEndBaseDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrEndBaseDate);
  s.ssPaymentTermsId = obj.AttrPaymentTermsId == null ? 0L : obj.AttrPaymentTermsId.Value;
  s.ssIsForVendorUpload = obj.AttrIsForVendorUpload == null ? false : obj.AttrIsForVendorUpload.Value;
  }
  return s;
}

public static Func<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord, ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord FromStructure(EN_17538b35348920159ed0ee43b3fb2b50EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord(s, config);
}

}


