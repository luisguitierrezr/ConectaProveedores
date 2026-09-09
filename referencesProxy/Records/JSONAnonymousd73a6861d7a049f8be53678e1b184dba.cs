using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_RETENCIONES_In3Record
public class JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f : AbstractRESTStructure<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> {
[JsonProperty("TI_RETENCIONES_In3")]
[JsonPropertyName("TI_RETENCIONES_In3")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure AttrTI_RETENCIONES_In3;

public JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f() { }

public JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_In3 = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_In3, new ST_57edec30140ebe846267970253841d11Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_In3 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure.FromStructure(s.ssSTTI_RETENCIONES_In3, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f, RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s) => ToStructure(s, config);
}
public static RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f obj, IBehaviorsConfiguration config) { 
  RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s = new RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_In3 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure.ToStructure(obj.AttrTI_RETENCIONES_In3, config);
  }
  return s;
}

public static Func<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f FromStructure(RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f(s, config);
}

}


