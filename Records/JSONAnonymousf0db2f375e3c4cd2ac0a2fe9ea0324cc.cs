using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingsCustomSettingValueRecord
public class JSONRC_65a6cd6541355f3cc5923c05ddee6119 : AbstractRESTStructure<RC_65a6cd6541355f3cc5923c05ddee6119> {
[JsonProperty("CustomSettings")]
[JsonPropertyName("CustomSettings")]
public ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord AttrCustomSettings;

[JsonProperty("CustomSettingValue")]
[JsonPropertyName("CustomSettingValue")]
public ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord AttrCustomSettingValue;

public JSONRC_65a6cd6541355f3cc5923c05ddee6119() { }

public JSONRC_65a6cd6541355f3cc5923c05ddee6119 (RC_65a6cd6541355f3cc5923c05ddee6119 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCustomSettings = ConvertToRestWithoutDefaults(s.ssENCustomSettings, new EN_2598b425876f6271c300c0879185e230EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure, config);
AttrCustomSettingValue = ConvertToRestWithoutDefaults(s.ssENCustomSettingValue, new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure, config);
  } else {
AttrCustomSettings = ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord.FromStructure(s.ssENCustomSettings, config);
AttrCustomSettingValue = ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.FromStructure(s.ssENCustomSettingValue, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_65a6cd6541355f3cc5923c05ddee6119, RC_65a6cd6541355f3cc5923c05ddee6119> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_65a6cd6541355f3cc5923c05ddee6119 s) => ToStructure(s, config);
}
public static RC_65a6cd6541355f3cc5923c05ddee6119 ToStructure(ssConectaProveedores.RestRecords.JSONRC_65a6cd6541355f3cc5923c05ddee6119 obj, IBehaviorsConfiguration config) { 
  RC_65a6cd6541355f3cc5923c05ddee6119 s = new RC_65a6cd6541355f3cc5923c05ddee6119();
  if(obj != null) {
  s.ssENCustomSettings = ssConectaProveedores.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord.ToStructure(obj.AttrCustomSettings, config);
  s.ssENCustomSettingValue = ssConectaProveedores.RestRecords.JSONEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord.ToStructure(obj.AttrCustomSettingValue, config);
  }
  return s;
}

public static Func<RC_65a6cd6541355f3cc5923c05ddee6119, ssConectaProveedores.RestRecords.JSONRC_65a6cd6541355f3cc5923c05ddee6119> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_65a6cd6541355f3cc5923c05ddee6119 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_65a6cd6541355f3cc5923c05ddee6119 FromStructure(RC_65a6cd6541355f3cc5923c05ddee6119 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_65a6cd6541355f3cc5923c05ddee6119(s, config);
}

}


