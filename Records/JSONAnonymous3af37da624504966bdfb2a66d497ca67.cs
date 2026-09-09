using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionVersionRecord
public class JSONRC_47cc380fa539ce90830b02515458ecd2 : AbstractRESTStructure<RC_47cc380fa539ce90830b02515458ecd2> {
[JsonProperty("RequisitionVersion")]
[JsonPropertyName("RequisitionVersion")]
public ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord AttrRequisitionVersion;

public JSONRC_47cc380fa539ce90830b02515458ecd2() { }

public JSONRC_47cc380fa539ce90830b02515458ecd2 (RC_47cc380fa539ce90830b02515458ecd2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionVersion = ConvertToRestWithoutDefaults(s.ssENRequisitionVersion, new EN_74284c742ed8c8eb5a05978b570ef620EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord.FromStructure, config);
  } else {
AttrRequisitionVersion = ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord.FromStructure(s.ssENRequisitionVersion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_47cc380fa539ce90830b02515458ecd2, RC_47cc380fa539ce90830b02515458ecd2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_47cc380fa539ce90830b02515458ecd2 s) => ToStructure(s, config);
}
public static RC_47cc380fa539ce90830b02515458ecd2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_47cc380fa539ce90830b02515458ecd2 obj, IBehaviorsConfiguration config) { 
  RC_47cc380fa539ce90830b02515458ecd2 s = new RC_47cc380fa539ce90830b02515458ecd2();
  if(obj != null) {
  s.ssENRequisitionVersion = ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord.ToStructure(obj.AttrRequisitionVersion, config);
  }
  return s;
}

public static Func<RC_47cc380fa539ce90830b02515458ecd2, ssConectaProveedores.RestRecords.JSONRC_47cc380fa539ce90830b02515458ecd2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_47cc380fa539ce90830b02515458ecd2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_47cc380fa539ce90830b02515458ecd2 FromStructure(RC_47cc380fa539ce90830b02515458ecd2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_47cc380fa539ce90830b02515458ecd2(s, config);
}

}


