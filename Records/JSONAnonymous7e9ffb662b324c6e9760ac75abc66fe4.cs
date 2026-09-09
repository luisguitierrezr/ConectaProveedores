using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroupTelcelDirRecord
public class JSONRC_78f8de95e867ccc81eabb054968cbf5b : AbstractRESTStructure<RC_78f8de95e867ccc81eabb054968cbf5b> {
[JsonProperty("SegmentAccGroupTelcelDir")]
[JsonPropertyName("SegmentAccGroupTelcelDir")]
public ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord AttrSegmentAccGroupTelcelDir;

public JSONRC_78f8de95e867ccc81eabb054968cbf5b() { }

public JSONRC_78f8de95e867ccc81eabb054968cbf5b (RC_78f8de95e867ccc81eabb054968cbf5b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroupTelcelDir = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroupTelcelDir, new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure(s.ssENSegmentAccGroupTelcelDir, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b, RC_78f8de95e867ccc81eabb054968cbf5b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b s) => ToStructure(s, config);
}
public static RC_78f8de95e867ccc81eabb054968cbf5b ToStructure(ssConectaProveedores.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b obj, IBehaviorsConfiguration config) { 
  RC_78f8de95e867ccc81eabb054968cbf5b s = new RC_78f8de95e867ccc81eabb054968cbf5b();
  if(obj != null) {
  s.ssENSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.ToStructure(obj.AttrSegmentAccGroupTelcelDir, config);
  }
  return s;
}

public static Func<RC_78f8de95e867ccc81eabb054968cbf5b, ssConectaProveedores.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78f8de95e867ccc81eabb054968cbf5b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b FromStructure(RC_78f8de95e867ccc81eabb054968cbf5b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b(s, config);
}

}


