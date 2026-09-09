using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionVersionRecord
public class RESTRC_47cc380fa539ce90830b02515458ecd2 : AbstractRESTStructure<RC_47cc380fa539ce90830b02515458ecd2> {
[JsonProperty("RequisitionVersion")]
public ssConectaProveedores.RestRecords.RESTEN_74284c742ed8c8eb5a05978b570ef620EntityRecord AttrRequisitionVersion;

public RESTRC_47cc380fa539ce90830b02515458ecd2() { }

public RESTRC_47cc380fa539ce90830b02515458ecd2 (RC_47cc380fa539ce90830b02515458ecd2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionVersion = ConvertToRestWithoutDefaults(s.ssENRequisitionVersion, new EN_74284c742ed8c8eb5a05978b570ef620EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_74284c742ed8c8eb5a05978b570ef620EntityRecord.FromStructure, config);
  } else {
AttrRequisitionVersion = ssConectaProveedores.RestRecords.RESTEN_74284c742ed8c8eb5a05978b570ef620EntityRecord.FromStructure(s.ssENRequisitionVersion, config);
  }
}

public static RC_47cc380fa539ce90830b02515458ecd2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_47cc380fa539ce90830b02515458ecd2 obj) { 
  RC_47cc380fa539ce90830b02515458ecd2 s = new RC_47cc380fa539ce90830b02515458ecd2();
  if(obj != null) {
  s.ssENRequisitionVersion = ssConectaProveedores.RestRecords.RESTEN_74284c742ed8c8eb5a05978b570ef620EntityRecord.ToStructure(obj.AttrRequisitionVersion);
  }
  return s;
}

public static Func<RC_47cc380fa539ce90830b02515458ecd2, ssConectaProveedores.RestRecords.RESTRC_47cc380fa539ce90830b02515458ecd2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_47cc380fa539ce90830b02515458ecd2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_47cc380fa539ce90830b02515458ecd2 FromStructure(RC_47cc380fa539ce90830b02515458ecd2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_47cc380fa539ce90830b02515458ecd2(s, config);
}

}


