using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FrequencyRecord
public class RESTRC_f2c609d858f8411e75fbedee60c5dddf : AbstractRESTStructure<RC_f2c609d858f8411e75fbedee60c5dddf> {
[JsonProperty("Frequency")]
public ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

public RESTRC_f2c609d858f8411e75fbedee60c5dddf() { }

public RESTRC_f2c609d858f8411e75fbedee60c5dddf (RC_f2c609d858f8411e75fbedee60c5dddf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
  } else {
AttrFrequency = ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
  }
}

public static RC_f2c609d858f8411e75fbedee60c5dddf ToStructure(ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf obj) { 
  RC_f2c609d858f8411e75fbedee60c5dddf s = new RC_f2c609d858f8411e75fbedee60c5dddf();
  if(obj != null) {
  s.ssENFrequency = ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency);
  }
  return s;
}

public static Func<RC_f2c609d858f8411e75fbedee60c5dddf, ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f2c609d858f8411e75fbedee60c5dddf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf FromStructure(RC_f2c609d858f8411e75fbedee60c5dddf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf(s, config);
}

}


