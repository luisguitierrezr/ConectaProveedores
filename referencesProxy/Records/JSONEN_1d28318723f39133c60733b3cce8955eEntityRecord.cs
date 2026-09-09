using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcessLevel
public class JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord : AbstractRESTStructure<EN_1d28318723f39133c60733b3cce8955eEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ApprovalProcessId")]
[JsonPropertyName("ApprovalProcessId")]
public long? AttrApprovalProcessId;

[JsonProperty("LevelNumber")]
[JsonPropertyName("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("IsApplicant")]
[JsonPropertyName("IsApplicant")]
public bool? AttrIsApplicant;

[JsonProperty("IsFirstApprover")]
[JsonPropertyName("IsFirstApprover")]
public bool? AttrIsFirstApprover;

[JsonProperty("JobTitle")]
[JsonPropertyName("JobTitle")]
public string AttrJobTitle;

[JsonProperty("EntraRoleId")]
[JsonPropertyName("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("DepartmentId")]
[JsonPropertyName("DepartmentId")]
public long? AttrDepartmentId;

[JsonProperty("ManagementId")]
[JsonPropertyName("ManagementId")]
public long? AttrManagementId;

[JsonProperty("SubdirectionId")]
[JsonPropertyName("SubdirectionId")]
public long? AttrSubdirectionId;

[JsonProperty("MinAmount")]
[JsonPropertyName("MinAmount")]
public decimal? AttrMinAmount;

[JsonProperty("MaxAmount")]
[JsonPropertyName("MaxAmount")]
public decimal? AttrMaxAmount;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("ExcludeRegion_DEPREC")]
[JsonPropertyName("ExcludeRegion_DEPREC")]
public string AttrExcludeRegion_DEPREC;

[JsonProperty("OnlyRegion")]
[JsonPropertyName("OnlyRegion")]
public string AttrOnlyRegion;

[JsonProperty("WithoutContract")]
[JsonPropertyName("WithoutContract")]
public bool? AttrWithoutContract;

[JsonProperty("NeedsProofOfForeignResidence")]
[JsonPropertyName("NeedsProofOfForeignResidence")]
public bool? AttrNeedsProofOfForeignResidence;

[JsonProperty("NeedsContract")]
[JsonPropertyName("NeedsContract")]
public bool? AttrNeedsContract;

[JsonProperty("IsAccounting_DEPREC")]
[JsonPropertyName("IsAccounting_DEPREC")]
public bool? AttrIsAccounting_DEPREC;

[JsonProperty("IsStartAccounting")]
[JsonPropertyName("IsStartAccounting")]
public bool? AttrIsStartAccounting;

[JsonProperty("CanBeFirstApprover")]
[JsonPropertyName("CanBeFirstApprover")]
public bool? AttrCanBeFirstApprover;

[JsonProperty("SelectsNextApprover")]
[JsonPropertyName("SelectsNextApprover")]
public bool? AttrSelectsNextApprover;

[JsonProperty("SelectsFirstApprover")]
[JsonPropertyName("SelectsFirstApprover")]
public bool? AttrSelectsFirstApprover;

[JsonProperty("IsExclude")]
[JsonPropertyName("IsExclude")]
public bool? AttrIsExclude;

[JsonProperty("IsMandatory")]
[JsonPropertyName("IsMandatory")]
public bool? AttrIsMandatory;

public JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord() { }

public JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord (EN_1d28318723f39133c60733b3cce8955eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrApprovalProcessId = ConvertToRestWithoutDefaults(s.ssApprovalProcessId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrIsApplicant = ConvertToRestWithoutDefaults(s.ssIsApplicant, false);
AttrIsFirstApprover = ConvertToRestWithoutDefaults(s.ssIsFirstApprover, false);
AttrJobTitle = ConvertToRestWithoutDefaults(s.ssJobTitle, "");
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrDepartmentId = ConvertToRestWithoutDefaults(s.ssDepartmentId, 0L);
AttrManagementId = ConvertToRestWithoutDefaults(s.ssManagementId, 0L);
AttrSubdirectionId = ConvertToRestWithoutDefaults(s.ssSubdirectionId, 0L);
AttrMinAmount = ConvertToRestWithoutDefaults(s.ssMinAmount, 0.0M);
AttrMaxAmount = ConvertToRestWithoutDefaults(s.ssMaxAmount, 0.0M);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrExcludeRegion_DEPREC = ConvertToRestWithoutDefaults(s.ssExcludeRegion_DEPREC, "");
AttrOnlyRegion = ConvertToRestWithoutDefaults(s.ssOnlyRegion, "");
AttrWithoutContract = ConvertToRestWithoutDefaults(s.ssWithoutContract, false);
AttrNeedsProofOfForeignResidence = ConvertToRestWithoutDefaults(s.ssNeedsProofOfForeignResidence, false);
AttrNeedsContract = ConvertToRestWithoutDefaults(s.ssNeedsContract, false);
AttrIsAccounting_DEPREC = ConvertToRestWithoutDefaults(s.ssIsAccounting_DEPREC, false);
AttrIsStartAccounting = ConvertToRestWithoutDefaults(s.ssIsStartAccounting, false);
AttrCanBeFirstApprover = ConvertToRestWithoutDefaults(s.ssCanBeFirstApprover, false);
AttrSelectsNextApprover = ConvertToRestWithoutDefaults(s.ssSelectsNextApprover, false);
AttrSelectsFirstApprover = ConvertToRestWithoutDefaults(s.ssSelectsFirstApprover, false);
AttrIsExclude = ConvertToRestWithoutDefaults(s.ssIsExclude, false);
AttrIsMandatory = ConvertToRestWithoutDefaults(s.ssIsMandatory, false);
  } else {
AttrId = (long?) s.ssId;
AttrApprovalProcessId = (long?) s.ssApprovalProcessId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrIsApplicant = (bool?) s.ssIsApplicant;
AttrIsFirstApprover = (bool?) s.ssIsFirstApprover;
AttrJobTitle = s.ssJobTitle;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrDepartmentId = (long?) s.ssDepartmentId;
AttrManagementId = (long?) s.ssManagementId;
AttrSubdirectionId = (long?) s.ssSubdirectionId;
AttrMinAmount = (decimal?) s.ssMinAmount;
AttrMaxAmount = (decimal?) s.ssMaxAmount;
AttrIsActive = (bool?) s.ssIsActive;
AttrExcludeRegion_DEPREC = s.ssExcludeRegion_DEPREC;
AttrOnlyRegion = s.ssOnlyRegion;
AttrWithoutContract = (bool?) s.ssWithoutContract;
AttrNeedsProofOfForeignResidence = (bool?) s.ssNeedsProofOfForeignResidence;
AttrNeedsContract = (bool?) s.ssNeedsContract;
AttrIsAccounting_DEPREC = (bool?) s.ssIsAccounting_DEPREC;
AttrIsStartAccounting = (bool?) s.ssIsStartAccounting;
AttrCanBeFirstApprover = (bool?) s.ssCanBeFirstApprover;
AttrSelectsNextApprover = (bool?) s.ssSelectsNextApprover;
AttrSelectsFirstApprover = (bool?) s.ssSelectsFirstApprover;
AttrIsExclude = (bool?) s.ssIsExclude;
AttrIsMandatory = (bool?) s.ssIsMandatory;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord, EN_1d28318723f39133c60733b3cce8955eEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord s) => ToStructure(s, config);
}
public static EN_1d28318723f39133c60733b3cce8955eEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_1d28318723f39133c60733b3cce8955eEntityRecord s = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssApprovalProcessId = obj.AttrApprovalProcessId == null ? 0L : obj.AttrApprovalProcessId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssIsApplicant = obj.AttrIsApplicant == null ? false : obj.AttrIsApplicant.Value;
  s.ssIsFirstApprover = obj.AttrIsFirstApprover == null ? false : obj.AttrIsFirstApprover.Value;
  s.ssJobTitle = obj.AttrJobTitle == null ? "" : obj.AttrJobTitle;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssDepartmentId = obj.AttrDepartmentId == null ? 0L : obj.AttrDepartmentId.Value;
  s.ssManagementId = obj.AttrManagementId == null ? 0L : obj.AttrManagementId.Value;
  s.ssSubdirectionId = obj.AttrSubdirectionId == null ? 0L : obj.AttrSubdirectionId.Value;
  s.ssMinAmount = obj.AttrMinAmount == null ? 0.0M : obj.AttrMinAmount.Value;
  s.ssMaxAmount = obj.AttrMaxAmount == null ? 0.0M : obj.AttrMaxAmount.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssExcludeRegion_DEPREC = obj.AttrExcludeRegion_DEPREC == null ? "" : obj.AttrExcludeRegion_DEPREC;
  s.ssOnlyRegion = obj.AttrOnlyRegion == null ? "" : obj.AttrOnlyRegion;
  s.ssWithoutContract = obj.AttrWithoutContract == null ? false : obj.AttrWithoutContract.Value;
  s.ssNeedsProofOfForeignResidence = obj.AttrNeedsProofOfForeignResidence == null ? false : obj.AttrNeedsProofOfForeignResidence.Value;
  s.ssNeedsContract = obj.AttrNeedsContract == null ? false : obj.AttrNeedsContract.Value;
  s.ssIsAccounting_DEPREC = obj.AttrIsAccounting_DEPREC == null ? false : obj.AttrIsAccounting_DEPREC.Value;
  s.ssIsStartAccounting = obj.AttrIsStartAccounting == null ? false : obj.AttrIsStartAccounting.Value;
  s.ssCanBeFirstApprover = obj.AttrCanBeFirstApprover == null ? false : obj.AttrCanBeFirstApprover.Value;
  s.ssSelectsNextApprover = obj.AttrSelectsNextApprover == null ? false : obj.AttrSelectsNextApprover.Value;
  s.ssSelectsFirstApprover = obj.AttrSelectsFirstApprover == null ? false : obj.AttrSelectsFirstApprover.Value;
  s.ssIsExclude = obj.AttrIsExclude == null ? false : obj.AttrIsExclude.Value;
  s.ssIsMandatory = obj.AttrIsMandatory == null ? false : obj.AttrIsMandatory.Value;
  }
  return s;
}

public static Func<EN_1d28318723f39133c60733b3cce8955eEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1d28318723f39133c60733b3cce8955eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord FromStructure(EN_1d28318723f39133c60733b3cce8955eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord(s, config);
}

}


