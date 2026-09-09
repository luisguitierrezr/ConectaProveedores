using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SegmentAccGroupTelcelDirRecord
public class JSONRC_78f8de95e867ccc81eabb054968cbf5b : AbstractRESTStructure<RC_78f8de95e867ccc81eabb054968cbf5b> {
[JsonProperty("SegmentAccGroupTelcelDir")]
[JsonPropertyName("SegmentAccGroupTelcelDir")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord AttrSegmentAccGroupTelcelDir;

public JSONRC_78f8de95e867ccc81eabb054968cbf5b() { }

public JSONRC_78f8de95e867ccc81eabb054968cbf5b (RC_78f8de95e867ccc81eabb054968cbf5b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroupTelcelDir = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroupTelcelDir, new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroupTelcelDir = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure(s.ssENSegmentAccGroupTelcelDir, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b, RC_78f8de95e867ccc81eabb054968cbf5b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b s) => ToStructure(s, config);
}
public static RC_78f8de95e867ccc81eabb054968cbf5b ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b obj, IBehaviorsConfiguration config) { 
  RC_78f8de95e867ccc81eabb054968cbf5b s = new RC_78f8de95e867ccc81eabb054968cbf5b();
  if(obj != null) {
  s.ssENSegmentAccGroupTelcelDir = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.ToStructure(obj.AttrSegmentAccGroupTelcelDir, config);
  }
  return s;
}

public static Func<RC_78f8de95e867ccc81eabb054968cbf5b, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78f8de95e867ccc81eabb054968cbf5b s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b FromStructure(RC_78f8de95e867ccc81eabb054968cbf5b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_78f8de95e867ccc81eabb054968cbf5b(s, config);
}

}


