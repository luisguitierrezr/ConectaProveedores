using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingValueRecord
public class RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa : AbstractRESTStructure<RC_fef56662c61d7afd2d3c90e5f49cfcfa> {
[JsonProperty("CustomSettingValue")]
public ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord AttrCustomSettingValue;

public RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa() { }

public RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa (RC_fef56662c61d7afd2d3c90e5f49cfcfa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCustomSettingValue = ConvertToRestWithoutDefaults(s.ssENCustomSettingValue, new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure, config);
  } else {
AttrCustomSettingValue = ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure(s.ssENCustomSettingValue, config);
  }
}

public static RC_fef56662c61d7afd2d3c90e5f49cfcfa ToStructure(ssConectaProveedores.RestRecords.RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa obj) { 
  RC_fef56662c61d7afd2d3c90e5f49cfcfa s = new RC_fef56662c61d7afd2d3c90e5f49cfcfa();
  if(obj != null) {
  s.ssENCustomSettingValue = ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.ToStructure(obj.AttrCustomSettingValue);
  }
  return s;
}

public static Func<RC_fef56662c61d7afd2d3c90e5f49cfcfa, ssConectaProveedores.RestRecords.RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fef56662c61d7afd2d3c90e5f49cfcfa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa FromStructure(RC_fef56662c61d7afd2d3c90e5f49cfcfa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fef56662c61d7afd2d3c90e5f49cfcfa(s, config);
}

}


