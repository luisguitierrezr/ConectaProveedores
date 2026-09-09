using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentMethodsRecord
public class RESTRC_45208e184b912aa1623cdf19760e8e7e : AbstractRESTStructure<RC_45208e184b912aa1623cdf19760e8e7e> {
[JsonProperty("PaymentMethods")]
public ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

public RESTRC_45208e184b912aa1623cdf19760e8e7e() { }

public RESTRC_45208e184b912aa1623cdf19760e8e7e (RC_45208e184b912aa1623cdf19760e8e7e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
  } else {
AttrPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
  }
}

public static RC_45208e184b912aa1623cdf19760e8e7e ToStructure(ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e obj) { 
  RC_45208e184b912aa1623cdf19760e8e7e s = new RC_45208e184b912aa1623cdf19760e8e7e();
  if(obj != null) {
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods);
  }
  return s;
}

public static Func<RC_45208e184b912aa1623cdf19760e8e7e, ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_45208e184b912aa1623cdf19760e8e7e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e FromStructure(RC_45208e184b912aa1623cdf19760e8e7e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e(s, config);
}

}


