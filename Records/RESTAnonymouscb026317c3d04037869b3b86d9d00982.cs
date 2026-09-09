using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroupRecord
public class RESTRC_941bbff9017349761a37494fcd214b98 : AbstractRESTStructure<RC_941bbff9017349761a37494fcd214b98> {
[JsonProperty("SegmentAccGroup")]
public ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord AttrSegmentAccGroup;

public RESTRC_941bbff9017349761a37494fcd214b98() { }

public RESTRC_941bbff9017349761a37494fcd214b98 (RC_941bbff9017349761a37494fcd214b98 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroup = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroup, new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroup = ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure(s.ssENSegmentAccGroup, config);
  }
}

public static RC_941bbff9017349761a37494fcd214b98 ToStructure(ssConectaProveedores.RestRecords.RESTRC_941bbff9017349761a37494fcd214b98 obj) { 
  RC_941bbff9017349761a37494fcd214b98 s = new RC_941bbff9017349761a37494fcd214b98();
  if(obj != null) {
  s.ssENSegmentAccGroup = ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.ToStructure(obj.AttrSegmentAccGroup);
  }
  return s;
}

public static Func<RC_941bbff9017349761a37494fcd214b98, ssConectaProveedores.RestRecords.RESTRC_941bbff9017349761a37494fcd214b98> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_941bbff9017349761a37494fcd214b98 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_941bbff9017349761a37494fcd214b98 FromStructure(RC_941bbff9017349761a37494fcd214b98 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_941bbff9017349761a37494fcd214b98(s, config);
}

}


