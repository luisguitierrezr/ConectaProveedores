using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportItemRecord
public class JSONRC_f34a41d9ffacfaba4ed60814851ecbf3 : AbstractRESTStructure<RC_f34a41d9ffacfaba4ed60814851ecbf3> {
[JsonProperty("ValidationReportItem")]
[JsonPropertyName("ValidationReportItem")]
public ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure AttrValidationReportItem;

public JSONRC_f34a41d9ffacfaba4ed60814851ecbf3() { }

public JSONRC_f34a41d9ffacfaba4ed60814851ecbf3 (RC_f34a41d9ffacfaba4ed60814851ecbf3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidationReportItem = ConvertToRestWithoutDefaults(s.ssSTValidationReportItem, new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(), ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructure, config);
  } else {
AttrValidationReportItem = ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructure(s.ssSTValidationReportItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f34a41d9ffacfaba4ed60814851ecbf3, RC_f34a41d9ffacfaba4ed60814851ecbf3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f34a41d9ffacfaba4ed60814851ecbf3 s) => ToStructure(s, config);
}
public static RC_f34a41d9ffacfaba4ed60814851ecbf3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f34a41d9ffacfaba4ed60814851ecbf3 obj, IBehaviorsConfiguration config) { 
  RC_f34a41d9ffacfaba4ed60814851ecbf3 s = new RC_f34a41d9ffacfaba4ed60814851ecbf3();
  if(obj != null) {
  s.ssSTValidationReportItem = ssConectaProveedores.RestRecords.JSONST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.ToStructure(obj.AttrValidationReportItem, config);
  }
  return s;
}

public static Func<RC_f34a41d9ffacfaba4ed60814851ecbf3, ssConectaProveedores.RestRecords.JSONRC_f34a41d9ffacfaba4ed60814851ecbf3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f34a41d9ffacfaba4ed60814851ecbf3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f34a41d9ffacfaba4ed60814851ecbf3 FromStructure(RC_f34a41d9ffacfaba4ed60814851ecbf3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f34a41d9ffacfaba4ed60814851ecbf3(s, config);
}

}


