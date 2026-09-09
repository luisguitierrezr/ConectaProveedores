using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// WizardApprovalDisplay
public class JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure : AbstractRESTStructure<ST_3c480a6d17a69eed60b057b7ed343a1dStructure> {
[JsonProperty("LevelNumber")]
[JsonPropertyName("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("ApprovalStatusId")]
[JsonPropertyName("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("CombinedJobTitles")]
[JsonPropertyName("CombinedJobTitles")]
public string AttrCombinedJobTitles;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public string AttrApplicationRole;

[JsonProperty("IsReassigned")]
[JsonPropertyName("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("IsSubstituteFor")]
[JsonPropertyName("IsSubstituteFor")]
public string AttrIsSubstituteFor;

public JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure() { }

public JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure (ST_3c480a6d17a69eed60b057b7ed343a1dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrCombinedJobTitles = ConvertToRestWithoutDefaults(s.ssCombinedJobTitles, "");
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssApplicationRole, "");
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrIsSubstituteFor = ConvertToRestWithoutDefaults(s.ssIsSubstituteFor, "");
  } else {
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrName = s.ssName;
AttrCombinedJobTitles = s.ssCombinedJobTitles;
AttrApplicationRole = s.ssApplicationRole;
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrIsSubstituteFor = s.ssIsSubstituteFor;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure, ST_3c480a6d17a69eed60b057b7ed343a1dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure s) => ToStructure(s, config);
}
public static ST_3c480a6d17a69eed60b057b7ed343a1dStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure obj, IBehaviorsConfiguration config) { 
  ST_3c480a6d17a69eed60b057b7ed343a1dStructure s = new ST_3c480a6d17a69eed60b057b7ed343a1dStructure();
  if(obj != null) {
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssCombinedJobTitles = obj.AttrCombinedJobTitles == null ? "" : obj.AttrCombinedJobTitles;
  s.ssApplicationRole = obj.AttrApplicationRole == null ? "" : obj.AttrApplicationRole;
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssIsSubstituteFor = obj.AttrIsSubstituteFor == null ? "" : obj.AttrIsSubstituteFor;
  }
  return s;
}

public static Func<ST_3c480a6d17a69eed60b057b7ed343a1dStructure, ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3c480a6d17a69eed60b057b7ed343a1dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure FromStructure(ST_3c480a6d17a69eed60b057b7ed343a1dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure(s, config);
}

}


