using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// User_Extended_Internal
public class JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord : AbstractRESTStructure<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("EmployeeNumber")]
[JsonPropertyName("EmployeeNumber")]
public string AttrEmployeeNumber;

[JsonProperty("ManagedBy")]
[JsonPropertyName("ManagedBy")]
public string AttrManagedBy;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("DepartmentId")]
[JsonPropertyName("DepartmentId")]
public long? AttrDepartmentId;

[JsonProperty("ManagementId")]
[JsonPropertyName("ManagementId")]
public long? AttrManagementId;

[JsonProperty("SubdirectionId")]
[JsonPropertyName("SubdirectionId")]
public long? AttrSubdirectionId;

[JsonProperty("TelcelDirectionId")]
[JsonPropertyName("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

[JsonProperty("City")]
[JsonPropertyName("City")]
public string AttrCity;

[JsonProperty("JobTitle")]
[JsonPropertyName("JobTitle")]
public string AttrJobTitle;

[JsonProperty("EntraRoleId")]
[JsonPropertyName("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("onPremisesDistinguishedName")]
[JsonPropertyName("onPremisesDistinguishedName")]
public string AttronPremisesDistinguishedName;

[JsonProperty("HasRolesAssigned")]
[JsonPropertyName("HasRolesAssigned")]
public bool? AttrHasRolesAssigned;

[JsonProperty("LastSync")]
[JsonPropertyName("LastSync")]
public String AttrLastSync;

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

[JsonProperty("EntraId")]
[JsonPropertyName("EntraId")]
public string AttrEntraId;

[JsonProperty("TelcelDireccion")]
[JsonPropertyName("TelcelDireccion")]
public string AttrTelcelDireccion;

public JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord() { }

public JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrEmployeeNumber = ConvertToRestWithoutDefaults(s.ssEmployeeNumber, "");
AttrManagedBy = ConvertToRestWithoutDefaults(s.ssManagedBy, "");
AttrRegionId = (long?) s.ssRegionId;
AttrDepartmentId = (long?) s.ssDepartmentId;
AttrManagementId = ConvertToRestWithoutDefaults(s.ssManagementId, 0L);
AttrSubdirectionId = ConvertToRestWithoutDefaults(s.ssSubdirectionId, 0L);
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
AttrCity = ConvertToRestWithoutDefaults(s.ssCity, "");
AttrJobTitle = ConvertToRestWithoutDefaults(s.ssJobTitle, "");
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttronPremisesDistinguishedName = ConvertToRestWithoutDefaults(s.ssonPremisesDistinguishedName, "");
AttrHasRolesAssigned = ConvertToRestWithoutDefaults(s.ssHasRolesAssigned, false);
AttrLastSync = ConvertDateTimeToRestWithoutDefaults(s.ssLastSync, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrEntraId = ConvertToRestWithoutDefaults(s.ssEntraId, "");
AttrTelcelDireccion = ConvertToRestWithoutDefaults(s.ssTelcelDireccion, "");
  } else {
AttrId = s.ssId;
AttrEmployeeNumber = s.ssEmployeeNumber;
AttrManagedBy = s.ssManagedBy;
AttrRegionId = (long?) s.ssRegionId;
AttrDepartmentId = (long?) s.ssDepartmentId;
AttrManagementId = (long?) s.ssManagementId;
AttrSubdirectionId = (long?) s.ssSubdirectionId;
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
AttrCity = s.ssCity;
AttrJobTitle = s.ssJobTitle;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttronPremisesDistinguishedName = s.ssonPremisesDistinguishedName;
AttrHasRolesAssigned = (bool?) s.ssHasRolesAssigned;
AttrLastSync = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastSync, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrEntraId = s.ssEntraId;
AttrTelcelDireccion = s.ssTelcelDireccion;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord, EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord s) => ToStructure(s, config);
}
public static EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord s = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssEmployeeNumber = obj.AttrEmployeeNumber == null ? "" : obj.AttrEmployeeNumber;
  s.ssManagedBy = obj.AttrManagedBy == null ? "" : obj.AttrManagedBy;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssDepartmentId = obj.AttrDepartmentId == null ? 0L : obj.AttrDepartmentId.Value;
  s.ssManagementId = obj.AttrManagementId == null ? 0L : obj.AttrManagementId.Value;
  s.ssSubdirectionId = obj.AttrSubdirectionId == null ? 0L : obj.AttrSubdirectionId.Value;
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  s.ssCity = obj.AttrCity == null ? "" : obj.AttrCity;
  s.ssJobTitle = obj.AttrJobTitle == null ? "" : obj.AttrJobTitle;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssonPremisesDistinguishedName = obj.AttronPremisesDistinguishedName == null ? "" : obj.AttronPremisesDistinguishedName;
  s.ssHasRolesAssigned = obj.AttrHasRolesAssigned == null ? false : obj.AttrHasRolesAssigned.Value;
  s.ssLastSync = obj.AttrLastSync == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastSync, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssEntraId = obj.AttrEntraId == null ? "" : obj.AttrEntraId;
  s.ssTelcelDireccion = obj.AttrTelcelDireccion == null ? "" : obj.AttrTelcelDireccion;
  }
  return s;
}

public static Func<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord FromStructure(EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(s, config);
}

}


