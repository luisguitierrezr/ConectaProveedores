using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StartResetPasswordResultRecord
public class JSONRC_8f8c9b77bcc0996564febb7d38ea930a : AbstractRESTStructure<RC_8f8c9b77bcc0996564febb7d38ea930a> {
[JsonProperty("StartResetPasswordResult")]
[JsonPropertyName("StartResetPasswordResult")]
public ssConectaProveedores.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure AttrStartResetPasswordResult;

public JSONRC_8f8c9b77bcc0996564febb7d38ea930a() { }

public JSONRC_8f8c9b77bcc0996564febb7d38ea930a (RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartResetPasswordResult = ConvertToRestWithoutDefaults(s.ssSTStartResetPasswordResult, new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure(), ssConectaProveedores.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructure, config);
  } else {
AttrStartResetPasswordResult = ssConectaProveedores.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure.FromStructure(s.ssSTStartResetPasswordResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a, RC_8f8c9b77bcc0996564febb7d38ea930a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a s) => ToStructure(s, config);
}
public static RC_8f8c9b77bcc0996564febb7d38ea930a ToStructure(ssConectaProveedores.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a obj, IBehaviorsConfiguration config) { 
  RC_8f8c9b77bcc0996564febb7d38ea930a s = new RC_8f8c9b77bcc0996564febb7d38ea930a();
  if(obj != null) {
  s.ssSTStartResetPasswordResult = ssConectaProveedores.RestRecords.JSONST_7df0b593cd1052614bf3d2f66d1ab2efStructure.ToStructure(obj.AttrStartResetPasswordResult, config);
  }
  return s;
}

public static Func<RC_8f8c9b77bcc0996564febb7d38ea930a, ssConectaProveedores.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f8c9b77bcc0996564febb7d38ea930a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a FromStructure(RC_8f8c9b77bcc0996564febb7d38ea930a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8f8c9b77bcc0996564febb7d38ea930a(s, config);
}

}


