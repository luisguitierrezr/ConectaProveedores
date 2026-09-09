using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingsCustomSettingValueRecord
public class RESTRC_65a6cd6541355f3cc5923c05ddee6119 : AbstractRESTStructure<RC_65a6cd6541355f3cc5923c05ddee6119> {
[JsonProperty("CustomSettings")]
public ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord AttrCustomSettings;

[JsonProperty("CustomSettingValue")]
public ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord AttrCustomSettingValue;

public RESTRC_65a6cd6541355f3cc5923c05ddee6119() { }

public RESTRC_65a6cd6541355f3cc5923c05ddee6119 (RC_65a6cd6541355f3cc5923c05ddee6119 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCustomSettings = ConvertToRestWithoutDefaults(s.ssENCustomSettings, new EN_2598b425876f6271c300c0879185e230EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure, config);
AttrCustomSettingValue = ConvertToRestWithoutDefaults(s.ssENCustomSettingValue, new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure, config);
  } else {
AttrCustomSettings = ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure(s.ssENCustomSettings, config);
AttrCustomSettingValue = ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure(s.ssENCustomSettingValue, config);
  }
}

public static RC_65a6cd6541355f3cc5923c05ddee6119 ToStructure(ssConectaProveedores.RestRecords.RESTRC_65a6cd6541355f3cc5923c05ddee6119 obj) { 
  RC_65a6cd6541355f3cc5923c05ddee6119 s = new RC_65a6cd6541355f3cc5923c05ddee6119();
  if(obj != null) {
  s.ssENCustomSettings = ssConectaProveedores.RestRecords.RESTEN_2598b425876f6271c300c0879185e230EntityRecord.ToStructure(obj.AttrCustomSettings);
  s.ssENCustomSettingValue = ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.ToStructure(obj.AttrCustomSettingValue);
  }
  return s;
}

public static Func<RC_65a6cd6541355f3cc5923c05ddee6119, ssConectaProveedores.RestRecords.RESTRC_65a6cd6541355f3cc5923c05ddee6119> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_65a6cd6541355f3cc5923c05ddee6119 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_65a6cd6541355f3cc5923c05ddee6119 FromStructure(RC_65a6cd6541355f3cc5923c05ddee6119 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_65a6cd6541355f3cc5923c05ddee6119(s, config);
}

}


