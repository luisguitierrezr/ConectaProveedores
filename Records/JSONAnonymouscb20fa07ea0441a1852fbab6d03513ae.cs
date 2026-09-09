using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FAC_PAG_InRecord
public class JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706 : AbstractRESTStructure<RC_a22abd50b75fd1b0c73ec0aaf2ec5706> {
[JsonProperty("T_FAC_PAG_In")]
[JsonPropertyName("T_FAC_PAG_In")]
public ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure AttrT_FAC_PAG_In;

public JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706() { }

public JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706 (RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FAC_PAG_In = ConvertToRestWithoutDefaults(s.ssSTT_FAC_PAG_In, new ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure(), ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.FromStructure, config);
  } else {
AttrT_FAC_PAG_In = ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.FromStructure(s.ssSTT_FAC_PAG_In, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706, RC_a22abd50b75fd1b0c73ec0aaf2ec5706> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706 s) => ToStructure(s, config);
}
public static RC_a22abd50b75fd1b0c73ec0aaf2ec5706 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706 obj, IBehaviorsConfiguration config) { 
  RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s = new RC_a22abd50b75fd1b0c73ec0aaf2ec5706();
  if(obj != null) {
  s.ssSTT_FAC_PAG_In = ssConectaProveedores.RestRecords.JSONST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.ToStructure(obj.AttrT_FAC_PAG_In, config);
  }
  return s;
}

public static Func<RC_a22abd50b75fd1b0c73ec0aaf2ec5706, ssConectaProveedores.RestRecords.JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706 FromStructure(RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a22abd50b75fd1b0c73ec0aaf2ec5706(s, config);
}

}


