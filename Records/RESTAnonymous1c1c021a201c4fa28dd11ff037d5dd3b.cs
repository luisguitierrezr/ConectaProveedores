using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroupSegmentAccGroupTelcelDirRecord
public class RESTRC_dbac6e35b37e102dd601262a956066d2 : AbstractRESTStructure<RC_dbac6e35b37e102dd601262a956066d2> {
[JsonProperty("SegmentAccGroup")]
public ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord AttrSegmentAccGroup;

[JsonProperty("SegmentAccGroupTelcelDir")]
public ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord AttrSegmentAccGroupTelcelDir;

public RESTRC_dbac6e35b37e102dd601262a956066d2() { }

public RESTRC_dbac6e35b37e102dd601262a956066d2 (RC_dbac6e35b37e102dd601262a956066d2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroup = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroup, new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure, config);
AttrSegmentAccGroupTelcelDir = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroupTelcelDir, new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroup = ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure(s.ssENSegmentAccGroup, config);
AttrSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure(s.ssENSegmentAccGroupTelcelDir, config);
  }
}

public static RC_dbac6e35b37e102dd601262a956066d2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dbac6e35b37e102dd601262a956066d2 obj) { 
  RC_dbac6e35b37e102dd601262a956066d2 s = new RC_dbac6e35b37e102dd601262a956066d2();
  if(obj != null) {
  s.ssENSegmentAccGroup = ssConectaProveedores.RestRecords.RESTEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.ToStructure(obj.AttrSegmentAccGroup);
  s.ssENSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.ToStructure(obj.AttrSegmentAccGroupTelcelDir);
  }
  return s;
}

public static Func<RC_dbac6e35b37e102dd601262a956066d2, ssConectaProveedores.RestRecords.RESTRC_dbac6e35b37e102dd601262a956066d2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dbac6e35b37e102dd601262a956066d2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dbac6e35b37e102dd601262a956066d2 FromStructure(RC_dbac6e35b37e102dd601262a956066d2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dbac6e35b37e102dd601262a956066d2(s, config);
}

}


