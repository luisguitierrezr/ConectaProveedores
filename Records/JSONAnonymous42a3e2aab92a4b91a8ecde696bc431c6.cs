using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentMethodsRecord
public class JSONRC_45208e184b912aa1623cdf19760e8e7e : AbstractRESTStructure<RC_45208e184b912aa1623cdf19760e8e7e> {
[JsonProperty("PaymentMethods")]
[JsonPropertyName("PaymentMethods")]
public ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

public JSONRC_45208e184b912aa1623cdf19760e8e7e() { }

public JSONRC_45208e184b912aa1623cdf19760e8e7e (RC_45208e184b912aa1623cdf19760e8e7e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
  } else {
AttrPaymentMethods = ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e, RC_45208e184b912aa1623cdf19760e8e7e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e s) => ToStructure(s, config);
}
public static RC_45208e184b912aa1623cdf19760e8e7e ToStructure(ssConectaProveedores.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e obj, IBehaviorsConfiguration config) { 
  RC_45208e184b912aa1623cdf19760e8e7e s = new RC_45208e184b912aa1623cdf19760e8e7e();
  if(obj != null) {
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods, config);
  }
  return s;
}

public static Func<RC_45208e184b912aa1623cdf19760e8e7e, ssConectaProveedores.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_45208e184b912aa1623cdf19760e8e7e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e FromStructure(RC_45208e184b912aa1623cdf19760e8e7e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_45208e184b912aa1623cdf19760e8e7e(s, config);
}

}


