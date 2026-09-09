using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_OutRecord
public class JSONRC_9162f01c71226303cd0e14f0309ed1b9 : AbstractRESTStructure<RC_9162f01c71226303cd0e14f0309ed1b9> {
[JsonProperty("TI_RETENCIONES_Out")]
[JsonPropertyName("TI_RETENCIONES_Out")]
public ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure AttrTI_RETENCIONES_Out;

public JSONRC_9162f01c71226303cd0e14f0309ed1b9() { }

public JSONRC_9162f01c71226303cd0e14f0309ed1b9 (RC_9162f01c71226303cd0e14f0309ed1b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_Out = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_Out, new ST_9e0fb2735a5b1c9875cbba9ab856e646Structure(), ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_Out = ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructure(s.ssSTTI_RETENCIONES_Out, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9, RC_9162f01c71226303cd0e14f0309ed1b9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9 s) => ToStructure(s, config);
}
public static RC_9162f01c71226303cd0e14f0309ed1b9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9 obj, IBehaviorsConfiguration config) { 
  RC_9162f01c71226303cd0e14f0309ed1b9 s = new RC_9162f01c71226303cd0e14f0309ed1b9();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_Out = ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.ToStructure(obj.AttrTI_RETENCIONES_Out, config);
  }
  return s;
}

public static Func<RC_9162f01c71226303cd0e14f0309ed1b9, ssConectaProveedores.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9162f01c71226303cd0e14f0309ed1b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9 FromStructure(RC_9162f01c71226303cd0e14f0309ed1b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9(s, config);
}

}


