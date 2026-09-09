using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Proposal
public class RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord : AbstractRESTStructure<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("PaymentDate")]
public String AttrPaymentDate;

[JsonProperty("ProposalDate")]
public String AttrProposalDate;

[JsonProperty("ProposalTypeId")]
public int? AttrProposalTypeId;

[JsonProperty("BankId")]
public long? AttrBankId;

[JsonProperty("ProposalStatusId")]
public int? AttrProposalStatusId;

[JsonProperty("FileId")]
public long? AttrFileId;

[JsonProperty("TotalProposalLines")]
public int? AttrTotalProposalLines;

[JsonProperty("TotalValueML")]
public decimal? AttrTotalValueML;

[JsonProperty("TotalValueMD")]
public decimal? AttrTotalValueMD;

[JsonProperty("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("RegionId")]
public long? AttrRegionId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("LastUpdatedOn")]
public String AttrLastUpdatedOn;

[JsonProperty("MaxDatePaymentChanges")]
public String AttrMaxDatePaymentChanges;

[JsonProperty("AssignedToId")]
public string AttrAssignedToId;

public RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord() { }

public RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrPaymentDate = ConvertDateToRestWithoutDefaults(s.ssPaymentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrProposalDate = ConvertDateToRestWithoutDefaults(s.ssProposalDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrProposalTypeId = ConvertToRestWithoutDefaults(s.ssProposalTypeId, 0);
AttrBankId = ConvertToRestWithoutDefaults(s.ssBankId, 0L);
AttrProposalStatusId = ConvertToRestWithoutDefaults(s.ssProposalStatusId, 0);
AttrFileId = ConvertToRestWithoutDefaults(s.ssFileId, 0L);
AttrTotalProposalLines = ConvertToRestWithoutDefaults(s.ssTotalProposalLines, 0);
AttrTotalValueML = ConvertToRestWithoutDefaults(s.ssTotalValueML, 0.0M);
AttrTotalValueMD = ConvertToRestWithoutDefaults(s.ssTotalValueMD, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrLastUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssLastUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMaxDatePaymentChanges = ConvertDateToRestWithoutDefaults(s.ssMaxDatePaymentChanges, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrAssignedToId = ConvertToRestWithoutDefaults(s.ssAssignedToId, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
AttrProposalDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssProposalDate);
AttrProposalTypeId = (int?) s.ssProposalTypeId;
AttrBankId = (long?) s.ssBankId;
AttrProposalStatusId = (int?) s.ssProposalStatusId;
AttrFileId = (long?) s.ssFileId;
AttrTotalProposalLines = (int?) s.ssTotalProposalLines;
AttrTotalValueML = (decimal?) s.ssTotalValueML;
AttrTotalValueMD = (decimal?) s.ssTotalValueMD;
AttrCurrencyId = s.ssCurrencyId;
AttrRegionId = (long?) s.ssRegionId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrLastUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastUpdatedOn, config.DateTimeFormat);
AttrMaxDatePaymentChanges = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssMaxDatePaymentChanges);
AttrAssignedToId = s.ssAssignedToId;
  }
}

public static EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord obj) { 
  EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord s = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  s.ssProposalDate = obj.AttrProposalDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrProposalDate);
  s.ssProposalTypeId = obj.AttrProposalTypeId == null ? 0 : obj.AttrProposalTypeId.Value;
  s.ssBankId = obj.AttrBankId == null ? 0L : obj.AttrBankId.Value;
  s.ssProposalStatusId = obj.AttrProposalStatusId == null ? 0 : obj.AttrProposalStatusId.Value;
  s.ssFileId = obj.AttrFileId == null ? 0L : obj.AttrFileId.Value;
  s.ssTotalProposalLines = obj.AttrTotalProposalLines == null ? 0 : obj.AttrTotalProposalLines.Value;
  s.ssTotalValueML = obj.AttrTotalValueML == null ? 0.0M : obj.AttrTotalValueML.Value;
  s.ssTotalValueMD = obj.AttrTotalValueMD == null ? 0.0M : obj.AttrTotalValueMD.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssLastUpdatedOn = obj.AttrLastUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMaxDatePaymentChanges = obj.AttrMaxDatePaymentChanges == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrMaxDatePaymentChanges);
  s.ssAssignedToId = obj.AttrAssignedToId == null ? "" : obj.AttrAssignedToId;
  }
  return s;
}

public static Func<EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord, ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord FromStructure(EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(s, config);
}

}


