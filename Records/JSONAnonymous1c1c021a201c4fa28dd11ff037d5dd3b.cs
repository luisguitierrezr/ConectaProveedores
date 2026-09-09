using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroupSegmentAccGroupTelcelDirRecord
public class JSONRC_dbac6e35b37e102dd601262a956066d2 : AbstractRESTStructure<RC_dbac6e35b37e102dd601262a956066d2> {
[JsonProperty("SegmentAccGroup")]
[JsonPropertyName("SegmentAccGroup")]
public ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord AttrSegmentAccGroup;

[JsonProperty("SegmentAccGroupTelcelDir")]
[JsonPropertyName("SegmentAccGroupTelcelDir")]
public ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord AttrSegmentAccGroupTelcelDir;

public JSONRC_dbac6e35b37e102dd601262a956066d2() { }

public JSONRC_dbac6e35b37e102dd601262a956066d2 (RC_dbac6e35b37e102dd601262a956066d2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroup = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroup, new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure, config);
AttrSegmentAccGroupTelcelDir = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroupTelcelDir, new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroup = ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.FromStructure(s.ssENSegmentAccGroup, config);
AttrSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure(s.ssENSegmentAccGroupTelcelDir, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_dbac6e35b37e102dd601262a956066d2, RC_dbac6e35b37e102dd601262a956066d2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_dbac6e35b37e102dd601262a956066d2 s) => ToStructure(s, config);
}
public static RC_dbac6e35b37e102dd601262a956066d2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_dbac6e35b37e102dd601262a956066d2 obj, IBehaviorsConfiguration config) { 
  RC_dbac6e35b37e102dd601262a956066d2 s = new RC_dbac6e35b37e102dd601262a956066d2();
  if(obj != null) {
  s.ssENSegmentAccGroup = ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord.ToStructure(obj.AttrSegmentAccGroup, config);
  s.ssENSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.ToStructure(obj.AttrSegmentAccGroupTelcelDir, config);
  }
  return s;
}

public static Func<RC_dbac6e35b37e102dd601262a956066d2, ssConectaProveedores.RestRecords.JSONRC_dbac6e35b37e102dd601262a956066d2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dbac6e35b37e102dd601262a956066d2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_dbac6e35b37e102dd601262a956066d2 FromStructure(RC_dbac6e35b37e102dd601262a956066d2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_dbac6e35b37e102dd601262a956066d2(s, config);
}

}


