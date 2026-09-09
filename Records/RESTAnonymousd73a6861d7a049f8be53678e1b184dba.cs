using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_In3Record
public class RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f : AbstractRESTStructure<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> {
[JsonProperty("TI_RETENCIONES_In3")]
public ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure AttrTI_RETENCIONES_In3;

public RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f() { }

public RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_In3 = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_In3, new ST_57edec30140ebe846267970253841d11Structure(), ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_In3 = ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure.FromStructure(s.ssSTTI_RETENCIONES_In3, config);
  }
}

public static RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f ToStructure(ssConectaProveedores.RestRecords.RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f obj) { 
  RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s = new RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_In3 = ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure.ToStructure(obj.AttrTI_RETENCIONES_In3);
  }
  return s;
}

public static Func<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f, ssConectaProveedores.RestRecords.RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f FromStructure(RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7ef1f3edcd56f6b47d6e604ed6ee0f1f(s, config);
}

}


