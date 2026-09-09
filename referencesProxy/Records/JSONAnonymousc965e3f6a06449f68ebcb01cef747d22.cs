using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_RETENCIONES_OutRecord
public class JSONRC_9162f01c71226303cd0e14f0309ed1b9 : AbstractRESTStructure<RC_9162f01c71226303cd0e14f0309ed1b9> {
[JsonProperty("TI_RETENCIONES_Out")]
[JsonPropertyName("TI_RETENCIONES_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure AttrTI_RETENCIONES_Out;

public JSONRC_9162f01c71226303cd0e14f0309ed1b9() { }

public JSONRC_9162f01c71226303cd0e14f0309ed1b9 (RC_9162f01c71226303cd0e14f0309ed1b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_Out = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_Out, new ST_9e0fb2735a5b1c9875cbba9ab856e646Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructure(s.ssSTTI_RETENCIONES_Out, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9, RC_9162f01c71226303cd0e14f0309ed1b9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9 s) => ToStructure(s, config);
}
public static RC_9162f01c71226303cd0e14f0309ed1b9 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9 obj, IBehaviorsConfiguration config) { 
  RC_9162f01c71226303cd0e14f0309ed1b9 s = new RC_9162f01c71226303cd0e14f0309ed1b9();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.ToStructure(obj.AttrTI_RETENCIONES_Out, config);
  }
  return s;
}

public static Func<RC_9162f01c71226303cd0e14f0309ed1b9, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9162f01c71226303cd0e14f0309ed1b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9 FromStructure(RC_9162f01c71226303cd0e14f0309ed1b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9162f01c71226303cd0e14f0309ed1b9(s, config);
}

}


