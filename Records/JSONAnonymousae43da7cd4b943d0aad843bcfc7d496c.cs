using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedSelloDigitalRecord
public class JSONRC_d5bae0a1e64415dc86dedbeae539158c : AbstractRESTStructure<RC_d5bae0a1e64415dc86dedbeae539158c> {
[JsonProperty("InvoiceExtendedSelloDigital")]
[JsonPropertyName("InvoiceExtendedSelloDigital")]
public ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord AttrInvoiceExtendedSelloDigital;

public JSONRC_d5bae0a1e64415dc86dedbeae539158c() { }

public JSONRC_d5bae0a1e64415dc86dedbeae539158c (RC_d5bae0a1e64415dc86dedbeae539158c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedSelloDigital = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedSelloDigital, new EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedSelloDigital = ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord.FromStructure(s.ssENInvoiceExtendedSelloDigital, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d5bae0a1e64415dc86dedbeae539158c, RC_d5bae0a1e64415dc86dedbeae539158c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d5bae0a1e64415dc86dedbeae539158c s) => ToStructure(s, config);
}
public static RC_d5bae0a1e64415dc86dedbeae539158c ToStructure(ssConectaProveedores.RestRecords.JSONRC_d5bae0a1e64415dc86dedbeae539158c obj, IBehaviorsConfiguration config) { 
  RC_d5bae0a1e64415dc86dedbeae539158c s = new RC_d5bae0a1e64415dc86dedbeae539158c();
  if(obj != null) {
  s.ssENInvoiceExtendedSelloDigital = ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord.ToStructure(obj.AttrInvoiceExtendedSelloDigital, config);
  }
  return s;
}

public static Func<RC_d5bae0a1e64415dc86dedbeae539158c, ssConectaProveedores.RestRecords.JSONRC_d5bae0a1e64415dc86dedbeae539158c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5bae0a1e64415dc86dedbeae539158c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d5bae0a1e64415dc86dedbeae539158c FromStructure(RC_d5bae0a1e64415dc86dedbeae539158c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d5bae0a1e64415dc86dedbeae539158c(s, config);
}

}


