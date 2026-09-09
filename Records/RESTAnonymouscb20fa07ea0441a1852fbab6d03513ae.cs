using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FAC_PAG_InRecord
public class RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706 : AbstractRESTStructure<RC_a22abd50b75fd1b0c73ec0aaf2ec5706> {
[JsonProperty("T_FAC_PAG_In")]
public ssConectaProveedores.RestRecords.RESTST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure AttrT_FAC_PAG_In;

public RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706() { }

public RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706 (RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FAC_PAG_In = ConvertToRestWithoutDefaults(s.ssSTT_FAC_PAG_In, new ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure(), ssConectaProveedores.RestRecords.RESTST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.FromStructure, config);
  } else {
AttrT_FAC_PAG_In = ssConectaProveedores.RestRecords.RESTST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.FromStructure(s.ssSTT_FAC_PAG_In, config);
  }
}

public static RC_a22abd50b75fd1b0c73ec0aaf2ec5706 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706 obj) { 
  RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s = new RC_a22abd50b75fd1b0c73ec0aaf2ec5706();
  if(obj != null) {
  s.ssSTT_FAC_PAG_In = ssConectaProveedores.RestRecords.RESTST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure.ToStructure(obj.AttrT_FAC_PAG_In);
  }
  return s;
}

public static Func<RC_a22abd50b75fd1b0c73ec0aaf2ec5706, ssConectaProveedores.RestRecords.RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706 FromStructure(RC_a22abd50b75fd1b0c73ec0aaf2ec5706 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a22abd50b75fd1b0c73ec0aaf2ec5706(s, config);
}

}


