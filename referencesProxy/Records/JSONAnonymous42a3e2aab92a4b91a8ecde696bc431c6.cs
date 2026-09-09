using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaymentMethodsRecord
public class JSONRC_45208e184b912aa1623cdf19760e8e7e : AbstractRESTStructure<RC_45208e184b912aa1623cdf19760e8e7e> {
[JsonProperty("PaymentMethods")]
[JsonPropertyName("PaymentMethods")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

public JSONRC_45208e184b912aa1623cdf19760e8e7e() { }

public JSONRC_45208e184b912aa1623cdf19760e8e7e (RC_45208e184b912aa1623cdf19760e8e7e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
  } else {
AttrPaymentMethods = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e, RC_45208e184b912aa1623cdf19760e8e7e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e s) => ToStructure(s, config);
}
public static RC_45208e184b912aa1623cdf19760e8e7e ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e obj, IBehaviorsConfiguration config) { 
  RC_45208e184b912aa1623cdf19760e8e7e s = new RC_45208e184b912aa1623cdf19760e8e7e();
  if(obj != null) {
  s.ssENPaymentMethods = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods, config);
  }
  return s;
}

public static Func<RC_45208e184b912aa1623cdf19760e8e7e, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_45208e184b912aa1623cdf19760e8e7e s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e FromStructure(RC_45208e184b912aa1623cdf19760e8e7e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e(s, config);
}

}


