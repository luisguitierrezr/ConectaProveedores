using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SeriesStylingOptionalConfigsRecord
public class JSONRC_34d5d5ab5565b38a57ae5f2563a8c466 : AbstractRESTStructure<RC_34d5d5ab5565b38a57ae5f2563a8c466> {
[JsonProperty("SeriesStylingOptionalConfigs")]
[JsonPropertyName("SeriesStylingOptionalConfigs")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure AttrSeriesStylingOptionalConfigs;

public JSONRC_34d5d5ab5565b38a57ae5f2563a8c466() { }

public JSONRC_34d5d5ab5565b38a57ae5f2563a8c466 (RC_34d5d5ab5565b38a57ae5f2563a8c466 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesStylingOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTSeriesStylingOptionalConfigs, new ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure.FromStructure, config);
  } else {
AttrSeriesStylingOptionalConfigs = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure.FromStructure(s.ssSTSeriesStylingOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_34d5d5ab5565b38a57ae5f2563a8c466, RC_34d5d5ab5565b38a57ae5f2563a8c466> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_34d5d5ab5565b38a57ae5f2563a8c466 s) => ToStructure(s, config);
}
public static RC_34d5d5ab5565b38a57ae5f2563a8c466 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_34d5d5ab5565b38a57ae5f2563a8c466 obj, IBehaviorsConfiguration config) { 
  RC_34d5d5ab5565b38a57ae5f2563a8c466 s = new RC_34d5d5ab5565b38a57ae5f2563a8c466();
  if(obj != null) {
  s.ssSTSeriesStylingOptionalConfigs = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure.ToStructure(obj.AttrSeriesStylingOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_34d5d5ab5565b38a57ae5f2563a8c466, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_34d5d5ab5565b38a57ae5f2563a8c466> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34d5d5ab5565b38a57ae5f2563a8c466 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_34d5d5ab5565b38a57ae5f2563a8c466 FromStructure(RC_34d5d5ab5565b38a57ae5f2563a8c466 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_34d5d5ab5565b38a57ae5f2563a8c466(s, config);
}

}


