using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_OutRecord
public class RESTRC_9162f01c71226303cd0e14f0309ed1b9 : AbstractRESTStructure<RC_9162f01c71226303cd0e14f0309ed1b9> {
[JsonProperty("TI_RETENCIONES_Out")]
public ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure AttrTI_RETENCIONES_Out;

public RESTRC_9162f01c71226303cd0e14f0309ed1b9() { }

public RESTRC_9162f01c71226303cd0e14f0309ed1b9 (RC_9162f01c71226303cd0e14f0309ed1b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_Out = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_Out, new ST_9e0fb2735a5b1c9875cbba9ab856e646Structure(), ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_Out = ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructure(s.ssSTTI_RETENCIONES_Out, config);
  }
}

public static RC_9162f01c71226303cd0e14f0309ed1b9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9162f01c71226303cd0e14f0309ed1b9 obj) { 
  RC_9162f01c71226303cd0e14f0309ed1b9 s = new RC_9162f01c71226303cd0e14f0309ed1b9();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_Out = ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure.ToStructure(obj.AttrTI_RETENCIONES_Out);
  }
  return s;
}

public static Func<RC_9162f01c71226303cd0e14f0309ed1b9, ssConectaProveedores.RestRecords.RESTRC_9162f01c71226303cd0e14f0309ed1b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9162f01c71226303cd0e14f0309ed1b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9162f01c71226303cd0e14f0309ed1b9 FromStructure(RC_9162f01c71226303cd0e14f0309ed1b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9162f01c71226303cd0e14f0309ed1b9(s, config);
}

}


