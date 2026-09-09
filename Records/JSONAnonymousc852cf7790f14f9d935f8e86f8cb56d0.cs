using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PasswordValidationResultRecord
public class JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 : AbstractRESTStructure<RC_b27f0b968b0f7cea61506ac9d6ee7c27> {
[JsonProperty("PasswordValidationResult")]
[JsonPropertyName("PasswordValidationResult")]
public ssConectaProveedores.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure AttrPasswordValidationResult;

public JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27() { }

public JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 (RC_b27f0b968b0f7cea61506ac9d6ee7c27 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordValidationResult = ConvertToRestWithoutDefaults(s.ssSTPasswordValidationResult, new ST_b9e6959231369ae517164f0fb8e8606dStructure(), ssConectaProveedores.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure.FromStructure, config);
  } else {
AttrPasswordValidationResult = ssConectaProveedores.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure.FromStructure(s.ssSTPasswordValidationResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27, RC_b27f0b968b0f7cea61506ac9d6ee7c27> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 s) => ToStructure(s, config);
}
public static RC_b27f0b968b0f7cea61506ac9d6ee7c27 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 obj, IBehaviorsConfiguration config) { 
  RC_b27f0b968b0f7cea61506ac9d6ee7c27 s = new RC_b27f0b968b0f7cea61506ac9d6ee7c27();
  if(obj != null) {
  s.ssSTPasswordValidationResult = ssConectaProveedores.RestRecords.JSONST_b9e6959231369ae517164f0fb8e8606dStructure.ToStructure(obj.AttrPasswordValidationResult, config);
  }
  return s;
}

public static Func<RC_b27f0b968b0f7cea61506ac9d6ee7c27, ssConectaProveedores.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b27f0b968b0f7cea61506ac9d6ee7c27 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27 FromStructure(RC_b27f0b968b0f7cea61506ac9d6ee7c27 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b27f0b968b0f7cea61506ac9d6ee7c27(s, config);
}

}


