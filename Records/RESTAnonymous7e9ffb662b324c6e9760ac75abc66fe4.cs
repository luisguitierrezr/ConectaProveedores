using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroupTelcelDirRecord
public class RESTRC_78f8de95e867ccc81eabb054968cbf5b : AbstractRESTStructure<RC_78f8de95e867ccc81eabb054968cbf5b> {
[JsonProperty("SegmentAccGroupTelcelDir")]
public ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord AttrSegmentAccGroupTelcelDir;

public RESTRC_78f8de95e867ccc81eabb054968cbf5b() { }

public RESTRC_78f8de95e867ccc81eabb054968cbf5b (RC_78f8de95e867ccc81eabb054968cbf5b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSegmentAccGroupTelcelDir = ConvertToRestWithoutDefaults(s.ssENSegmentAccGroupTelcelDir, new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure, config);
  } else {
AttrSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.FromStructure(s.ssENSegmentAccGroupTelcelDir, config);
  }
}

public static RC_78f8de95e867ccc81eabb054968cbf5b ToStructure(ssConectaProveedores.RestRecords.RESTRC_78f8de95e867ccc81eabb054968cbf5b obj) { 
  RC_78f8de95e867ccc81eabb054968cbf5b s = new RC_78f8de95e867ccc81eabb054968cbf5b();
  if(obj != null) {
  s.ssENSegmentAccGroupTelcelDir = ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord.ToStructure(obj.AttrSegmentAccGroupTelcelDir);
  }
  return s;
}

public static Func<RC_78f8de95e867ccc81eabb054968cbf5b, ssConectaProveedores.RestRecords.RESTRC_78f8de95e867ccc81eabb054968cbf5b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78f8de95e867ccc81eabb054968cbf5b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_78f8de95e867ccc81eabb054968cbf5b FromStructure(RC_78f8de95e867ccc81eabb054968cbf5b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_78f8de95e867ccc81eabb054968cbf5b(s, config);
}

}


