using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConcepts
public class RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord : AbstractRESTStructure<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RequisitionAccountingId")]
public long? AttrRequisitionAccountingId;

[JsonProperty("AccountingDataTypeId")]
public int? AttrAccountingDataTypeId;

[JsonProperty("NumberOfPayments")]
public int? AttrNumberOfPayments;

[JsonProperty("Amount")]
public decimal? AttrAmount;

[JsonProperty("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("RequisitionAccConceptsId")]
public long? AttrRequisitionAccConceptsId;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

public RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord() { }

public RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionAccountingId = ConvertToRestWithoutDefaults(s.ssRequisitionAccountingId, 0L);
AttrAccountingDataTypeId = ConvertToRestWithoutDefaults(s.ssAccountingDataTypeId, 0);
AttrNumberOfPayments = ConvertToRestWithoutDefaults(s.ssNumberOfPayments, 0);
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrRequisitionAccConceptsId = ConvertToRestWithoutDefaults(s.ssRequisitionAccConceptsId, 0L);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionAccountingId = (long?) s.ssRequisitionAccountingId;
AttrAccountingDataTypeId = (int?) s.ssAccountingDataTypeId;
AttrNumberOfPayments = (int?) s.ssNumberOfPayments;
AttrAmount = (decimal?) s.ssAmount;
AttrCurrencyId = s.ssCurrencyId;
AttrRequisitionAccConceptsId = (long?) s.ssRequisitionAccConceptsId;
AttrIsActive = (bool?) s.ssIsActive;
  }
}

public static EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord obj) { 
  EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord s = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionAccountingId = obj.AttrRequisitionAccountingId == null ? 0L : obj.AttrRequisitionAccountingId.Value;
  s.ssAccountingDataTypeId = obj.AttrAccountingDataTypeId == null ? 0 : obj.AttrAccountingDataTypeId.Value;
  s.ssNumberOfPayments = obj.AttrNumberOfPayments == null ? 0 : obj.AttrNumberOfPayments.Value;
  s.ssAmount = obj.AttrAmount == null ? 0.0M : obj.AttrAmount.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssRequisitionAccConceptsId = obj.AttrRequisitionAccConceptsId == null ? 0L : obj.AttrRequisitionAccConceptsId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord, ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord FromStructure(EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(s, config);
}

}


