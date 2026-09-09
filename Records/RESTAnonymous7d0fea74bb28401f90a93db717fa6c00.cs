using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStylingOptionalConfigsRecord
public class RESTRC_34d5d5ab5565b38a57ae5f2563a8c466 : AbstractRESTStructure<RC_34d5d5ab5565b38a57ae5f2563a8c466> {
[JsonProperty("SeriesStylingOptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure AttrSeriesStylingOptionalConfigs;

public RESTRC_34d5d5ab5565b38a57ae5f2563a8c466() { }

public RESTRC_34d5d5ab5565b38a57ae5f2563a8c466 (RC_34d5d5ab5565b38a57ae5f2563a8c466 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesStylingOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTSeriesStylingOptionalConfigs, new ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure(), ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure.FromStructure, config);
  } else {
AttrSeriesStylingOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure.FromStructure(s.ssSTSeriesStylingOptionalConfigs, config);
  }
}

public static RC_34d5d5ab5565b38a57ae5f2563a8c466 ToStructure(ssConectaProveedores.RestRecords.RESTRC_34d5d5ab5565b38a57ae5f2563a8c466 obj) { 
  RC_34d5d5ab5565b38a57ae5f2563a8c466 s = new RC_34d5d5ab5565b38a57ae5f2563a8c466();
  if(obj != null) {
  s.ssSTSeriesStylingOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure.ToStructure(obj.AttrSeriesStylingOptionalConfigs);
  }
  return s;
}

public static Func<RC_34d5d5ab5565b38a57ae5f2563a8c466, ssConectaProveedores.RestRecords.RESTRC_34d5d5ab5565b38a57ae5f2563a8c466> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34d5d5ab5565b38a57ae5f2563a8c466 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_34d5d5ab5565b38a57ae5f2563a8c466 FromStructure(RC_34d5d5ab5565b38a57ae5f2563a8c466 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_34d5d5ab5565b38a57ae5f2563a8c466(s, config);
}

}


