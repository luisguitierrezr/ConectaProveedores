using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleCode
public class RESTST_e39617f0f094a322d4157f34fe424dadStructure : AbstractRESTStructure<ST_e39617f0f094a322d4157f34fe424dadStructure> {
[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("RoleName")]
public string AttrRoleName;

[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("IsSubstitute")]
public bool? AttrIsSubstitute;

public RESTST_e39617f0f094a322d4157f34fe424dadStructure() { }

public RESTST_e39617f0f094a322d4157f34fe424dadStructure (ST_e39617f0f094a322d4157f34fe424dadStructure s, IBehaviorsConfiguration config) {
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

public static ST_e39617f0f094a322d4157f34fe424dadStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure obj) { 
  ST_e39617f0f094a322d4157f34fe424dadStructure s = new ST_e39617f0f094a322d4157f34fe424dadStructure();
  if(obj != null) {
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssIsSubstitute = obj.AttrIsSubstitute == null ? false : obj.AttrIsSubstitute.Value;
  }
  return s;
}

public static Func<ST_e39617f0f094a322d4157f34fe424dadStructure, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e39617f0f094a322d4157f34fe424dadStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure FromStructure(ST_e39617f0f094a322d4157f34fe424dadStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure(s, config);
}

}


