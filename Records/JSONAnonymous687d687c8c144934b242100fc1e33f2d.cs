using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicationRoleUserApplicationRoleTempByConceptUserApplicationRoleTempRecord
public class JSONRC_3d56036e64426be06ca36c503a3c39e0 : AbstractRESTStructure<RC_3d56036e64426be06ca36c503a3c39e0> {
[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("UserApplicationRoleTempByConcept")]
[JsonPropertyName("UserApplicationRoleTempByConcept")]
public ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord AttrUserApplicationRoleTempByConcept;

[JsonProperty("UserApplicationRoleTemp")]
[JsonPropertyName("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

public JSONRC_3d56036e64426be06ca36c503a3c39e0() { }

public JSONRC_3d56036e64426be06ca36c503a3c39e0 (RC_3d56036e64426be06ca36c503a3c39e0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUserApplicationRoleTempByConcept = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTempByConcept, new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.FromStructure, config);
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
  } else {
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUserApplicationRoleTempByConcept = ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.FromStructure(s.ssENUserApplicationRoleTempByConcept, config);
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3d56036e64426be06ca36c503a3c39e0, RC_3d56036e64426be06ca36c503a3c39e0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3d56036e64426be06ca36c503a3c39e0 s) => ToStructure(s, config);
}
public static RC_3d56036e64426be06ca36c503a3c39e0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3d56036e64426be06ca36c503a3c39e0 obj, IBehaviorsConfiguration config) { 
  RC_3d56036e64426be06ca36c503a3c39e0 s = new RC_3d56036e64426be06ca36c503a3c39e0();
  if(obj != null) {
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  s.ssENUserApplicationRoleTempByConcept = ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.ToStructure(obj.AttrUserApplicationRoleTempByConcept, config);
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp, config);
  }
  return s;
}

public static Func<RC_3d56036e64426be06ca36c503a3c39e0, ssConectaProveedores.RestRecords.JSONRC_3d56036e64426be06ca36c503a3c39e0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3d56036e64426be06ca36c503a3c39e0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3d56036e64426be06ca36c503a3c39e0 FromStructure(RC_3d56036e64426be06ca36c503a3c39e0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3d56036e64426be06ca36c503a3c39e0(s, config);
}

}


