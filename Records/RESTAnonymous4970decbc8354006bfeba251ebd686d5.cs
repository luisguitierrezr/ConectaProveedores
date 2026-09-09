using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManualUserAreaRecord
public class RESTRC_53bfb6ba3a8f9433f06f269f872b84c8 : AbstractRESTStructure<RC_53bfb6ba3a8f9433f06f269f872b84c8> {
[JsonProperty("ManualUserArea")]
public ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord AttrManualUserArea;

public RESTRC_53bfb6ba3a8f9433f06f269f872b84c8() { }

public RESTRC_53bfb6ba3a8f9433f06f269f872b84c8 (RC_53bfb6ba3a8f9433f06f269f872b84c8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManualUserArea = ConvertToRestWithoutDefaults(s.ssENManualUserArea, new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.FromStructure, config);
  } else {
AttrManualUserArea = ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.FromStructure(s.ssENManualUserArea, config);
  }
}

public static RC_53bfb6ba3a8f9433f06f269f872b84c8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_53bfb6ba3a8f9433f06f269f872b84c8 obj) { 
  RC_53bfb6ba3a8f9433f06f269f872b84c8 s = new RC_53bfb6ba3a8f9433f06f269f872b84c8();
  if(obj != null) {
  s.ssENManualUserArea = ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord.ToStructure(obj.AttrManualUserArea);
  }
  return s;
}

public static Func<RC_53bfb6ba3a8f9433f06f269f872b84c8, ssConectaProveedores.RestRecords.RESTRC_53bfb6ba3a8f9433f06f269f872b84c8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53bfb6ba3a8f9433f06f269f872b84c8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_53bfb6ba3a8f9433f06f269f872b84c8 FromStructure(RC_53bfb6ba3a8f9433f06f269f872b84c8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_53bfb6ba3a8f9433f06f269f872b84c8(s, config);
}

}


