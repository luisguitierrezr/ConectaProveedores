using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingValueRecord
public class JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa : AbstractRESTStructure<RC_fef56662c61d7afd2d3c90e5f49cfcfa> {
[JsonProperty("CustomSettingValue")]
[JsonPropertyName("CustomSettingValue")]
public ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord AttrCustomSettingValue;

public JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa() { }

public JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa (RC_fef56662c61d7afd2d3c90e5f49cfcfa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCustomSettingValue = ConvertToRestWithoutDefaults(s.ssENCustomSettingValue, new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure, config);
  } else {
AttrCustomSettingValue = ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure(s.ssENCustomSettingValue, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa, RC_fef56662c61d7afd2d3c90e5f49cfcfa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa s) => ToStructure(s, config);
}
public static RC_fef56662c61d7afd2d3c90e5f49cfcfa ToStructure(ssConectaProveedores.RestRecords.JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa obj, IBehaviorsConfiguration config) { 
  RC_fef56662c61d7afd2d3c90e5f49cfcfa s = new RC_fef56662c61d7afd2d3c90e5f49cfcfa();
  if(obj != null) {
  s.ssENCustomSettingValue = ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.ToStructure(obj.AttrCustomSettingValue, config);
  }
  return s;
}

public static Func<RC_fef56662c61d7afd2d3c90e5f49cfcfa, ssConectaProveedores.RestRecords.JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fef56662c61d7afd2d3c90e5f49cfcfa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa FromStructure(RC_fef56662c61d7afd2d3c90e5f49cfcfa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fef56662c61d7afd2d3c90e5f49cfcfa(s, config);
}

}


