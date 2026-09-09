using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Folio
public class RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord : AbstractRESTStructure<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("IsDraft")]
public bool? AttrIsDraft;

[JsonProperty("FolioNumber")]
public string AttrFolioNumber;

[JsonProperty("CanProveedorCancel")]
public bool? AttrCanProveedorCancel;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("CompanyId")]
public long? AttrCompanyId;

[JsonProperty("FolioStatusId")]
public int? AttrFolioStatusId;

[JsonProperty("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("TotalIVA_Amount")]
public decimal? AttrTotalIVA_Amount;

[JsonProperty("PartialAmount")]
public decimal? AttrPartialAmount;

[JsonProperty("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("FirstApproverUserId")]
public string AttrFirstApproverUserId;

[JsonProperty("ApprovalProcessTypeId")]
public int? AttrApprovalProcessTypeId;

[JsonProperty("SAPEntryError")]
public string AttrSAPEntryError;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("MinuteSelected")]
public int? AttrMinuteSelected;

public RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord() { }

public RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrIsDraft = ConvertToRestWithoutDefaults(s.ssIsDraft, false);
AttrFolioNumber = ConvertToRestWithoutDefaults(s.ssFolioNumber, "");
AttrCanProveedorCancel = ConvertToRestWithoutDefaults(s.ssCanProveedorCancel, false);
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssCompanyId, 0L);
AttrFolioStatusId = ConvertToRestWithoutDefaults(s.ssFolioStatusId, 0);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrTotalIVA_Amount = ConvertToRestWithoutDefaults(s.ssTotalIVA_Amount, 0.0M);
AttrPartialAmount = ConvertToRestWithoutDefaults(s.ssPartialAmount, 0.0M);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrFirstApproverUserId = ConvertToRestWithoutDefaults(s.ssFirstApproverUserId, "");
AttrApprovalProcessTypeId = ConvertToRestWithoutDefaults(s.ssApprovalProcessTypeId, 0);
AttrSAPEntryError = ConvertToRestWithoutDefaults(s.ssSAPEntryError, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMinuteSelected = ConvertToRestWithoutDefaults(s.ssMinuteSelected, 0);
  } else {
AttrId = (long?) s.ssId;
AttrIsDraft = (bool?) s.ssIsDraft;
AttrFolioNumber = s.ssFolioNumber;
AttrCanProveedorCancel = (bool?) s.ssCanProveedorCancel;
AttrOrderId = (long?) s.ssOrderId;
AttrSupplierId = (long?) s.ssSupplierId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrFolioStatusId = (int?) s.ssFolioStatusId;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrTotalIVA_Amount = (decimal?) s.ssTotalIVA_Amount;
AttrPartialAmount = (decimal?) s.ssPartialAmount;
AttrCurrencyId = s.ssCurrencyId;
AttrFirstApproverUserId = s.ssFirstApproverUserId;
AttrApprovalProcessTypeId = (int?) s.ssApprovalProcessTypeId;
AttrSAPEntryError = s.ssSAPEntryError;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrMinuteSelected = (int?) s.ssMinuteSelected;
  }
}

public static EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord obj) { 
  EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord s = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssIsDraft = obj.AttrIsDraft == null ? false : obj.AttrIsDraft.Value;
  s.ssFolioNumber = obj.AttrFolioNumber == null ? "" : obj.AttrFolioNumber;
  s.ssCanProveedorCancel = obj.AttrCanProveedorCancel == null ? false : obj.AttrCanProveedorCancel.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssCompanyId = obj.AttrCompanyId == null ? 0L : obj.AttrCompanyId.Value;
  s.ssFolioStatusId = obj.AttrFolioStatusId == null ? 0 : obj.AttrFolioStatusId.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssTotalIVA_Amount = obj.AttrTotalIVA_Amount == null ? 0.0M : obj.AttrTotalIVA_Amount.Value;
  s.ssPartialAmount = obj.AttrPartialAmount == null ? 0.0M : obj.AttrPartialAmount.Value;
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssFirstApproverUserId = obj.AttrFirstApproverUserId == null ? "" : obj.AttrFirstApproverUserId;
  s.ssApprovalProcessTypeId = obj.AttrApprovalProcessTypeId == null ? 0 : obj.AttrApprovalProcessTypeId.Value;
  s.ssSAPEntryError = obj.AttrSAPEntryError == null ? "" : obj.AttrSAPEntryError;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMinuteSelected = obj.AttrMinuteSelected == null ? 0 : obj.AttrMinuteSelected.Value;
  }
  return s;
}

public static Func<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord FromStructure(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(s, config);
}

}


