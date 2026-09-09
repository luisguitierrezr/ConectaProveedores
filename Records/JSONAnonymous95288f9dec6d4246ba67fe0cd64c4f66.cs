using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesRecord
public class JSONRC_5a609a7b7b622cde2859ca506690f8db : AbstractRESTStructure<RC_5a609a7b7b622cde2859ca506690f8db> {
[JsonProperty("InvoiceAccountingServices")]
[JsonPropertyName("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

public JSONRC_5a609a7b7b622cde2859ca506690f8db() { }

public JSONRC_5a609a7b7b622cde2859ca506690f8db (RC_5a609a7b7b622cde2859ca506690f8db s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5a609a7b7b622cde2859ca506690f8db, RC_5a609a7b7b622cde2859ca506690f8db> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5a609a7b7b622cde2859ca506690f8db s) => ToStructure(s, config);
}
public static RC_5a609a7b7b622cde2859ca506690f8db ToStructure(ssConectaProveedores.RestRecords.JSONRC_5a609a7b7b622cde2859ca506690f8db obj, IBehaviorsConfiguration config) { 
  RC_5a609a7b7b622cde2859ca506690f8db s = new RC_5a609a7b7b622cde2859ca506690f8db();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices, config);
  }
  return s;
}

public static Func<RC_5a609a7b7b622cde2859ca506690f8db, ssConectaProveedores.RestRecords.JSONRC_5a609a7b7b622cde2859ca506690f8db> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5a609a7b7b622cde2859ca506690f8db s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5a609a7b7b622cde2859ca506690f8db FromStructure(RC_5a609a7b7b622cde2859ca506690f8db s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5a609a7b7b622cde2859ca506690f8db(s, config);
}

}


