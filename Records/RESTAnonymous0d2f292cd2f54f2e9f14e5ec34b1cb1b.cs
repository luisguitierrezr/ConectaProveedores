using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_InRecord
public class RESTRC_b7bb8767fa20ac5740e9546367f0a67e : AbstractRESTStructure<RC_b7bb8767fa20ac5740e9546367f0a67e> {
[JsonProperty("TI_RETENCIONES_In")]
public ssConectaProveedores.RestRecords.RESTST_2859defd6257fe38677ed819621e4236Structure AttrTI_RETENCIONES_In;

public RESTRC_b7bb8767fa20ac5740e9546367f0a67e() { }

public RESTRC_b7bb8767fa20ac5740e9546367f0a67e (RC_b7bb8767fa20ac5740e9546367f0a67e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_In = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_In, new ST_2859defd6257fe38677ed819621e4236Structure(), ssConectaProveedores.RestRecords.RESTST_2859defd6257fe38677ed819621e4236Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_In = ssConectaProveedores.RestRecords.RESTST_2859defd6257fe38677ed819621e4236Structure.FromStructure(s.ssSTTI_RETENCIONES_In, config);
  }
}

public static RC_b7bb8767fa20ac5740e9546367f0a67e ToStructure(ssConectaProveedores.RestRecords.RESTRC_b7bb8767fa20ac5740e9546367f0a67e obj) { 
  RC_b7bb8767fa20ac5740e9546367f0a67e s = new RC_b7bb8767fa20ac5740e9546367f0a67e();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_In = ssConectaProveedores.RestRecords.RESTST_2859defd6257fe38677ed819621e4236Structure.ToStructure(obj.AttrTI_RETENCIONES_In);
  }
  return s;
}

public static Func<RC_b7bb8767fa20ac5740e9546367f0a67e, ssConectaProveedores.RestRecords.RESTRC_b7bb8767fa20ac5740e9546367f0a67e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b7bb8767fa20ac5740e9546367f0a67e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b7bb8767fa20ac5740e9546367f0a67e FromStructure(RC_b7bb8767fa20ac5740e9546367f0a67e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b7bb8767fa20ac5740e9546367f0a67e(s, config);
}

}


