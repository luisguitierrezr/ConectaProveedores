using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaymentOptionsRecord
public class JSONRC_2813028c34d1b3ce080a3e2c9febe797 : AbstractRESTStructure<RC_2813028c34d1b3ce080a3e2c9febe797> {
[JsonProperty("PaymentOptions")]
[JsonPropertyName("PaymentOptions")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord AttrPaymentOptions;

public JSONRC_2813028c34d1b3ce080a3e2c9febe797() { }

public JSONRC_2813028c34d1b3ce080a3e2c9febe797 (RC_2813028c34d1b3ce080a3e2c9febe797 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentOptions = ConvertToRestWithoutDefaults(s.ssENPaymentOptions, new EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord.FromStructure, config);
  } else {
AttrPaymentOptions = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord.FromStructure(s.ssENPaymentOptions, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2813028c34d1b3ce080a3e2c9febe797, RC_2813028c34d1b3ce080a3e2c9febe797> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2813028c34d1b3ce080a3e2c9febe797 s) => ToStructure(s, config);
}
public static RC_2813028c34d1b3ce080a3e2c9febe797 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2813028c34d1b3ce080a3e2c9febe797 obj, IBehaviorsConfiguration config) { 
  RC_2813028c34d1b3ce080a3e2c9febe797 s = new RC_2813028c34d1b3ce080a3e2c9febe797();
  if(obj != null) {
  s.ssENPaymentOptions = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord.ToStructure(obj.AttrPaymentOptions, config);
  }
  return s;
}

public static Func<RC_2813028c34d1b3ce080a3e2c9febe797, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2813028c34d1b3ce080a3e2c9febe797> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2813028c34d1b3ce080a3e2c9febe797 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2813028c34d1b3ce080a3e2c9febe797 FromStructure(RC_2813028c34d1b3ce080a3e2c9febe797 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2813028c34d1b3ce080a3e2c9febe797(s, config);
}

}


