using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_RETENCIONES_InRecord
public class JSONRC_b7bb8767fa20ac5740e9546367f0a67e : AbstractRESTStructure<RC_b7bb8767fa20ac5740e9546367f0a67e> {
[JsonProperty("TI_RETENCIONES_In")]
[JsonPropertyName("TI_RETENCIONES_In")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure AttrTI_RETENCIONES_In;

public JSONRC_b7bb8767fa20ac5740e9546367f0a67e() { }

public JSONRC_b7bb8767fa20ac5740e9546367f0a67e (RC_b7bb8767fa20ac5740e9546367f0a67e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_In = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_In, new ST_2859defd6257fe38677ed819621e4236Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure.FromStructure(s.ssSTTI_RETENCIONES_In, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b7bb8767fa20ac5740e9546367f0a67e, RC_b7bb8767fa20ac5740e9546367f0a67e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b7bb8767fa20ac5740e9546367f0a67e s) => ToStructure(s, config);
}
public static RC_b7bb8767fa20ac5740e9546367f0a67e ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b7bb8767fa20ac5740e9546367f0a67e obj, IBehaviorsConfiguration config) { 
  RC_b7bb8767fa20ac5740e9546367f0a67e s = new RC_b7bb8767fa20ac5740e9546367f0a67e();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure.ToStructure(obj.AttrTI_RETENCIONES_In, config);
  }
  return s;
}

public static Func<RC_b7bb8767fa20ac5740e9546367f0a67e, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b7bb8767fa20ac5740e9546367f0a67e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b7bb8767fa20ac5740e9546367f0a67e s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b7bb8767fa20ac5740e9546367f0a67e FromStructure(RC_b7bb8767fa20ac5740e9546367f0a67e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b7bb8767fa20ac5740e9546367f0a67e(s, config);
}

}


