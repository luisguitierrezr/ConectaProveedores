using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFile
public class RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord : AbstractRESTStructure<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionFileId")]
public long? AttrRequisitionFileId;

[JsonProperty("ContractFileTypeId")]
public int? AttrContractFileTypeId;

[JsonProperty("Amount")]
public decimal? AttrAmount;

[JsonProperty("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("DepositTypeId")]
public int? AttrDepositTypeId;

[JsonProperty("InsuranceTypeId")]
public int? AttrInsuranceTypeId;

[JsonProperty("AdvancePaymentTypeId")]
public int? AttrAdvancePaymentTypeId;

public RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord() { }

public RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionFileId = ConvertToRestWithoutDefaults(s.ssRequisitionFileId, 0L);
AttrContractFileTypeId = ConvertToRestWithoutDefaults(s.ssContractFileTypeId, 0);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrDepositTypeId = ConvertToRestWithoutDefaults(s.ssDepositTypeId, 0);
AttrInsuranceTypeId = ConvertToRestWithoutDefaults(s.ssInsuranceTypeId, 0);
AttrAdvancePaymentTypeId = ConvertToRestWithoutDefaults(s.ssAdvancePaymentTypeId, 0);
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionFileId = (long?) s.ssRequisitionFileId;
AttrContractFileTypeId = (int?) s.ssContractFileTypeId;
AttrAmount = (decimal?) s.ssAmount;
AttrCurrencyId = s.ssCurrencyId;
AttrDepositTypeId = (int?) s.ssDepositTypeId;
AttrInsuranceTypeId = (int?) s.ssInsuranceTypeId;
AttrAdvancePaymentTypeId = (int?) s.ssAdvancePaymentTypeId;
  }
}

public static EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord obj) { 
  EN_aeab0089a9236dfc6c684ea98f650647EntityRecord s = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionFileId = obj.AttrRequisitionFileId == null ? 0L : obj.AttrRequisitionFileId.Value;
  s.ssContractFileTypeId = obj.AttrContractFileTypeId == null ? 0 : obj.AttrContractFileTypeId.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssDepositTypeId = obj.AttrDepositTypeId == null ? 0 : obj.AttrDepositTypeId.Value;
  s.ssInsuranceTypeId = obj.AttrInsuranceTypeId == null ? 0 : obj.AttrInsuranceTypeId.Value;
  s.ssAdvancePaymentTypeId = obj.AttrAdvancePaymentTypeId == null ? 0 : obj.AttrAdvancePaymentTypeId.Value;
  }
  return s;
}

public static Func<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord, ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord FromStructure(EN_aeab0089a9236dfc6c684ea98f650647EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord(s, config);
}

}


