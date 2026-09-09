using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportItemRecord
public class RESTRC_f34a41d9ffacfaba4ed60814851ecbf3 : AbstractRESTStructure<RC_f34a41d9ffacfaba4ed60814851ecbf3> {
[JsonProperty("ValidationReportItem")]
public ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure AttrValidationReportItem;

public RESTRC_f34a41d9ffacfaba4ed60814851ecbf3() { }

public RESTRC_f34a41d9ffacfaba4ed60814851ecbf3 (RC_f34a41d9ffacfaba4ed60814851ecbf3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidationReportItem = ConvertToRestWithoutDefaults(s.ssSTValidationReportItem, new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(), ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructure, config);
  } else {
AttrValidationReportItem = ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructure(s.ssSTValidationReportItem, config);
  }
}

public static RC_f34a41d9ffacfaba4ed60814851ecbf3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f34a41d9ffacfaba4ed60814851ecbf3 obj) { 
  RC_f34a41d9ffacfaba4ed60814851ecbf3 s = new RC_f34a41d9ffacfaba4ed60814851ecbf3();
  if(obj != null) {
  s.ssSTValidationReportItem = ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.ToStructure(obj.AttrValidationReportItem);
  }
  return s;
}

public static Func<RC_f34a41d9ffacfaba4ed60814851ecbf3, ssConectaProveedores.RestRecords.RESTRC_f34a41d9ffacfaba4ed60814851ecbf3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f34a41d9ffacfaba4ed60814851ecbf3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f34a41d9ffacfaba4ed60814851ecbf3 FromStructure(RC_f34a41d9ffacfaba4ed60814851ecbf3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f34a41d9ffacfaba4ed60814851ecbf3(s, config);
}

}


