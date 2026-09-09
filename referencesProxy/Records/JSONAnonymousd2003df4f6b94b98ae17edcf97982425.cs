using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// FrequencyRecord
public class JSONRC_f2c609d858f8411e75fbedee60c5dddf : AbstractRESTStructure<RC_f2c609d858f8411e75fbedee60c5dddf> {
[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

public JSONRC_f2c609d858f8411e75fbedee60c5dddf() { }

public JSONRC_f2c609d858f8411e75fbedee60c5dddf (RC_f2c609d858f8411e75fbedee60c5dddf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
  } else {
AttrFrequency = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f2c609d858f8411e75fbedee60c5dddf, RC_f2c609d858f8411e75fbedee60c5dddf> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f2c609d858f8411e75fbedee60c5dddf s) => ToStructure(s, config);
}
public static RC_f2c609d858f8411e75fbedee60c5dddf ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f2c609d858f8411e75fbedee60c5dddf obj, IBehaviorsConfiguration config) { 
  RC_f2c609d858f8411e75fbedee60c5dddf s = new RC_f2c609d858f8411e75fbedee60c5dddf();
  if(obj != null) {
  s.ssENFrequency = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency, config);
  }
  return s;
}

public static Func<RC_f2c609d858f8411e75fbedee60c5dddf, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f2c609d858f8411e75fbedee60c5dddf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f2c609d858f8411e75fbedee60c5dddf s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f2c609d858f8411e75fbedee60c5dddf FromStructure(RC_f2c609d858f8411e75fbedee60c5dddf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f2c609d858f8411e75fbedee60c5dddf(s, config);
}

}


