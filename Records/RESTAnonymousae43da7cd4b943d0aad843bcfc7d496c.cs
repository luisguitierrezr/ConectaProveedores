using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedSelloDigitalRecord
public class RESTRC_d5bae0a1e64415dc86dedbeae539158c : AbstractRESTStructure<RC_d5bae0a1e64415dc86dedbeae539158c> {
[JsonProperty("InvoiceExtendedSelloDigital")]
public ssConectaProveedores.RestRecords.RESTEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord AttrInvoiceExtendedSelloDigital;

public RESTRC_d5bae0a1e64415dc86dedbeae539158c() { }

public RESTRC_d5bae0a1e64415dc86dedbeae539158c (RC_d5bae0a1e64415dc86dedbeae539158c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedSelloDigital = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedSelloDigital, new EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedSelloDigital = ssConectaProveedores.RestRecords.RESTEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord.FromStructure(s.ssENInvoiceExtendedSelloDigital, config);
  }
}

public static RC_d5bae0a1e64415dc86dedbeae539158c ToStructure(ssConectaProveedores.RestRecords.RESTRC_d5bae0a1e64415dc86dedbeae539158c obj) { 
  RC_d5bae0a1e64415dc86dedbeae539158c s = new RC_d5bae0a1e64415dc86dedbeae539158c();
  if(obj != null) {
  s.ssENInvoiceExtendedSelloDigital = ssConectaProveedores.RestRecords.RESTEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord.ToStructure(obj.AttrInvoiceExtendedSelloDigital);
  }
  return s;
}

public static Func<RC_d5bae0a1e64415dc86dedbeae539158c, ssConectaProveedores.RestRecords.RESTRC_d5bae0a1e64415dc86dedbeae539158c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d5bae0a1e64415dc86dedbeae539158c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d5bae0a1e64415dc86dedbeae539158c FromStructure(RC_d5bae0a1e64415dc86dedbeae539158c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d5bae0a1e64415dc86dedbeae539158c(s, config);
}

}


