using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SegmentAccGroupRecord
public class JSONRC_941bbff9017349761a37494fcd214b98 : AbstractRESTStructure<RC_941bbff9017349761a37494fcd214b98> {
[JsonProperty("SegmentAccGroup")]
[JsonPropertyName("SegmentAccGroup")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord AttrSegmentAccGroup;

public JSONRC_941bbff9017349761a37494fcd214b98() { }

public JSONRC_941bbff9017349761a37494fcd214b98 (RC_941bbff9017349761a37494fcd214b98 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroup = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroup, new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroup = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure(s.ssENSegmentAccGroup, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_941bbff9017349761a37494fcd214b98, RC_941bbff9017349761a37494fcd214b98> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_941bbff9017349761a37494fcd214b98 s) => ToStructure(s, config);
}
public static RC_941bbff9017349761a37494fcd214b98 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_941bbff9017349761a37494fcd214b98 obj, IBehaviorsConfiguration config) { 
  RC_941bbff9017349761a37494fcd214b98 s = new RC_941bbff9017349761a37494fcd214b98();
  if(obj != null) {
  s.ssENSegmentAccGroup = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.ToStructure(obj.AttrSegmentAccGroup, config);
  }
  return s;
}

public static Func<RC_941bbff9017349761a37494fcd214b98, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_941bbff9017349761a37494fcd214b98> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_941bbff9017349761a37494fcd214b98 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_941bbff9017349761a37494fcd214b98 FromStructure(RC_941bbff9017349761a37494fcd214b98 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_941bbff9017349761a37494fcd214b98(s, config);
}

}


