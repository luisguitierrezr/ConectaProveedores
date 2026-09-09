using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleCode
public class JSONST_e39617f0f094a322d4157f34fe424dadStructure : AbstractRESTStructure<ST_e39617f0f094a322d4157f34fe424dadStructure> {
[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("RoleName")]
[JsonPropertyName("RoleName")]
public string AttrRoleName;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("IsSubstitute")]
[JsonPropertyName("IsSubstitute")]
public bool? AttrIsSubstitute;

public JSONST_e39617f0f094a322d4157f34fe424dadStructure() { }

public JSONST_e39617f0f094a322d4157f34fe424dadStructure (ST_e39617f0f094a322d4157f34fe424dadStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrRoleName = ConvertToRestWithoutDefaults(s.ssRoleName, "");
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrIsSubstitute = ConvertToRestWithoutDefaults(s.ssIsSubstitute, false);
  } else {
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrRoleName = s.ssRoleName;
AttrCode = s.ssCode;
AttrIsSubstitute = (bool?) s.ssIsSubstitute;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure, ST_e39617f0f094a322d4157f34fe424dadStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure s) => ToStructure(s, config);
}
public static ST_e39617f0f094a322d4157f34fe424dadStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure obj, IBehaviorsConfiguration config) { 
  ST_e39617f0f094a322d4157f34fe424dadStructure s = new ST_e39617f0f094a322d4157f34fe424dadStructure();
  if(obj != null) {
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssIsSubstitute = obj.AttrIsSubstitute == null ? false : obj.AttrIsSubstitute.Value;
  }
  return s;
}

public static Func<ST_e39617f0f094a322d4157f34fe424dadStructure, ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e39617f0f094a322d4157f34fe424dadStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure FromStructure(ST_e39617f0f094a322d4157f34fe424dadStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure(s, config);
}

}


