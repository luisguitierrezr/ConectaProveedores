using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicationRoleUserApplicationRoleTempByConceptUserApplicationRoleTempRecord
public class RESTRC_3d56036e64426be06ca36c503a3c39e0 : AbstractRESTStructure<RC_3d56036e64426be06ca36c503a3c39e0> {
[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("UserApplicationRoleTempByConcept")]
public ssConectaProveedores.RestRecords.RESTEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord AttrUserApplicationRoleTempByConcept;

[JsonProperty("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

public RESTRC_3d56036e64426be06ca36c503a3c39e0() { }

public RESTRC_3d56036e64426be06ca36c503a3c39e0 (RC_3d56036e64426be06ca36c503a3c39e0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUserApplicationRoleTempByConcept = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTempByConcept, new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.FromStructure, config);
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
  } else {
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUserApplicationRoleTempByConcept = ssConectaProveedores.RestRecords.RESTEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.FromStructure(s.ssENUserApplicationRoleTempByConcept, config);
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
  }
}

public static RC_3d56036e64426be06ca36c503a3c39e0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3d56036e64426be06ca36c503a3c39e0 obj) { 
  RC_3d56036e64426be06ca36c503a3c39e0 s = new RC_3d56036e64426be06ca36c503a3c39e0();
  if(obj != null) {
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  s.ssENUserApplicationRoleTempByConcept = ssConectaProveedores.RestRecords.RESTEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.ToStructure(obj.AttrUserApplicationRoleTempByConcept);
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp);
  }
  return s;
}

public static Func<RC_3d56036e64426be06ca36c503a3c39e0, ssConectaProveedores.RestRecords.RESTRC_3d56036e64426be06ca36c503a3c39e0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3d56036e64426be06ca36c503a3c39e0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3d56036e64426be06ca36c503a3c39e0 FromStructure(RC_3d56036e64426be06ca36c503a3c39e0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3d56036e64426be06ca36c503a3c39e0(s, config);
}

}


