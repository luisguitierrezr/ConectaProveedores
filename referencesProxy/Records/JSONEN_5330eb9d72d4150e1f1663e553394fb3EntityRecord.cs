using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AccountableGuide
public class JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord : AbstractRESTStructure<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("SupplierId")]
[JsonPropertyName("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("Project_Asset_ServiceId")]
[JsonPropertyName("Project_Asset_ServiceId")]
public long? AttrProject_Asset_ServiceId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("AccountName")]
[JsonPropertyName("AccountName")]
public string AttrAccountName;

[JsonProperty("Account")]
[JsonPropertyName("Account")]
public string AttrAccount;

[JsonProperty("CostCenterSAPId")]
[JsonPropertyName("CostCenterSAPId")]
public long? AttrCostCenterSAPId;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

public JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord() { }

public JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrProject_Asset_ServiceId = ConvertToRestWithoutDefaults(s.ssProject_Asset_ServiceId, 0L);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrAccountName = ConvertToRestWithoutDefaults(s.ssAccountName, "");
AttrAccount = ConvertToRestWithoutDefaults(s.ssAccount, "");
AttrCostCenterSAPId = ConvertToRestWithoutDefaults(s.ssCostCenterSAPId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrSupplierId = (long?) s.ssSupplierId;
AttrProject_Asset_ServiceId = (long?) s.ssProject_Asset_ServiceId;
AttrRegionId = (long?) s.ssRegionId;
AttrAccountName = s.ssAccountName;
AttrAccount = s.ssAccount;
AttrCostCenterSAPId = (long?) s.ssCostCenterSAPId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord, EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord s) => ToStructure(s, config);
}
public static EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord s = new EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssProject_Asset_ServiceId = obj.AttrProject_Asset_ServiceId == null ? 0L : obj.AttrProject_Asset_ServiceId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssAccountName = obj.AttrAccountName == null ? "" : obj.AttrAccountName;
  s.ssAccount = obj.AttrAccount == null ? "" : obj.AttrAccount;
  s.ssCostCenterSAPId = obj.AttrCostCenterSAPId == null ? 0L : obj.AttrCostCenterSAPId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord FromStructure(EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord(s, config);
}

}


