using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingRecord
public class JSONRC_c398a83ea7d109886e6be693f6d07867 : AbstractRESTStructure<RC_c398a83ea7d109886e6be693f6d07867> {
[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

public JSONRC_c398a83ea7d109886e6be693f6d07867() { }

public JSONRC_c398a83ea7d109886e6be693f6d07867 (RC_c398a83ea7d109886e6be693f6d07867 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c398a83ea7d109886e6be693f6d07867, RC_c398a83ea7d109886e6be693f6d07867> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c398a83ea7d109886e6be693f6d07867 s) => ToStructure(s, config);
}
public static RC_c398a83ea7d109886e6be693f6d07867 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c398a83ea7d109886e6be693f6d07867 obj, IBehaviorsConfiguration config) { 
  RC_c398a83ea7d109886e6be693f6d07867 s = new RC_c398a83ea7d109886e6be693f6d07867();
  if(obj != null) {
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  }
  return s;
}

public static Func<RC_c398a83ea7d109886e6be693f6d07867, ssConectaProveedores.RestRecords.JSONRC_c398a83ea7d109886e6be693f6d07867> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c398a83ea7d109886e6be693f6d07867 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c398a83ea7d109886e6be693f6d07867 FromStructure(RC_c398a83ea7d109886e6be693f6d07867 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c398a83ea7d109886e6be693f6d07867(s, config);
}

}


