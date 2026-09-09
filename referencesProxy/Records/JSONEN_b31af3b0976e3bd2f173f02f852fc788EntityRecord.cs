using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcess
public class JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord : AbstractRESTStructure<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProcessTypeId")]
[JsonPropertyName("ProcessTypeId")]
public long? AttrProcessTypeId;

[JsonProperty("SpecialWorkflowId")]
[JsonPropertyName("SpecialWorkflowId")]
public long? AttrSpecialWorkflowId;

[JsonProperty("ApprovalProcessTypeId")]
[JsonPropertyName("ApprovalProcessTypeId")]
public int? AttrApprovalProcessTypeId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("AccountingRegionId")]
[JsonPropertyName("AccountingRegionId")]
public long? AttrAccountingRegionId;

[JsonProperty("Group")]
[JsonPropertyName("Group")]
public string AttrGroup;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Version")]
[JsonPropertyName("Version")]
public int? AttrVersion;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("IsSpecial")]
[JsonPropertyName("IsSpecial")]
public bool? AttrIsSpecial;

[JsonProperty("IsDonation")]
[JsonPropertyName("IsDonation")]
public bool? AttrIsDonation;

[JsonProperty("IsCxPCorporativo_DEPREC")]
[JsonPropertyName("IsCxPCorporativo_DEPREC")]
public bool? AttrIsCxPCorporativo_DEPREC;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("IsSelectFirstApprover")]
[JsonPropertyName("IsSelectFirstApprover")]
public bool? AttrIsSelectFirstApprover;

public JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord() { }

public JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessTypeId = ConvertToRestWithoutDefaults(s.ssProcessTypeId, 0L);
AttrSpecialWorkflowId = ConvertToRestWithoutDefaults(s.ssSpecialWorkflowId, 0L);
AttrApprovalProcessTypeId = ConvertToRestWithoutDefaults(s.ssApprovalProcessTypeId, 0);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrAccountingRegionId = ConvertToRestWithoutDefaults(s.ssAccountingRegionId, 0L);
AttrGroup = ConvertToRestWithoutDefaults(s.ssGroup, "");
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrVersion = ConvertToRestWithoutDefaults(s.ssVersion, 0);
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrIsSpecial = ConvertToRestWithoutDefaults(s.ssIsSpecial, false);
AttrIsDonation = ConvertToRestWithoutDefaults(s.ssIsDonation, false);
AttrIsCxPCorporativo_DEPREC = ConvertToRestWithoutDefaults(s.ssIsCxPCorporativo_DEPREC, false);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsSelectFirstApprover = ConvertToRestWithoutDefaults(s.ssIsSelectFirstApprover, false);
  } else {
AttrId = (long?) s.ssId;
AttrProcessTypeId = (long?) s.ssProcessTypeId;
AttrSpecialWorkflowId = (long?) s.ssSpecialWorkflowId;
AttrApprovalProcessTypeId = (int?) s.ssApprovalProcessTypeId;
AttrRegionId = (long?) s.ssRegionId;
AttrAccountingRegionId = (long?) s.ssAccountingRegionId;
AttrGroup = s.ssGroup;
AttrCode = s.ssCode;
AttrVersion = (int?) s.ssVersion;
AttrDescription = s.ssDescription;
AttrIsActive = (bool?) s.ssIsActive;
AttrIsSpecial = (bool?) s.ssIsSpecial;
AttrIsDonation = (bool?) s.ssIsDonation;
AttrIsCxPCorporativo_DEPREC = (bool?) s.ssIsCxPCorporativo_DEPREC;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrIsSelectFirstApprover = (bool?) s.ssIsSelectFirstApprover;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord s) => ToStructure(s, config);
}
public static EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord s = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessTypeId = obj.AttrProcessTypeId == null ? 0L : obj.AttrProcessTypeId.Value;
  s.ssSpecialWorkflowId = obj.AttrSpecialWorkflowId == null ? 0L : obj.AttrSpecialWorkflowId.Value;
  s.ssApprovalProcessTypeId = obj.AttrApprovalProcessTypeId == null ? 0 : obj.AttrApprovalProcessTypeId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssAccountingRegionId = obj.AttrAccountingRegionId == null ? 0L : obj.AttrAccountingRegionId.Value;
  s.ssGroup = obj.AttrGroup == null ? "" : obj.AttrGroup;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssVersion = obj.AttrVersion == null ? 0 : obj.AttrVersion.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssIsSpecial = obj.AttrIsSpecial == null ? false : obj.AttrIsSpecial.Value;
  s.ssIsDonation = obj.AttrIsDonation == null ? false : obj.AttrIsDonation.Value;
  s.ssIsCxPCorporativo_DEPREC = obj.AttrIsCxPCorporativo_DEPREC == null ? false : obj.AttrIsCxPCorporativo_DEPREC.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssIsSelectFirstApprover = obj.AttrIsSelectFirstApprover == null ? false : obj.AttrIsSelectFirstApprover.Value;
  }
  return s;
}

public static Func<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord FromStructure(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(s, config);
}

}


