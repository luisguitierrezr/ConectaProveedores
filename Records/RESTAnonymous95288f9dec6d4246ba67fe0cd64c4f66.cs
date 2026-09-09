using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesRecord
public class RESTRC_5a609a7b7b622cde2859ca506690f8db : AbstractRESTStructure<RC_5a609a7b7b622cde2859ca506690f8db> {
[JsonProperty("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

public RESTRC_5a609a7b7b622cde2859ca506690f8db() { }

public RESTRC_5a609a7b7b622cde2859ca506690f8db (RC_5a609a7b7b622cde2859ca506690f8db s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
  }
}

public static RC_5a609a7b7b622cde2859ca506690f8db ToStructure(ssConectaProveedores.RestRecords.RESTRC_5a609a7b7b622cde2859ca506690f8db obj) { 
  RC_5a609a7b7b622cde2859ca506690f8db s = new RC_5a609a7b7b622cde2859ca506690f8db();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices);
  }
  return s;
}

public static Func<RC_5a609a7b7b622cde2859ca506690f8db, ssConectaProveedores.RestRecords.RESTRC_5a609a7b7b622cde2859ca506690f8db> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5a609a7b7b622cde2859ca506690f8db s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5a609a7b7b622cde2859ca506690f8db FromStructure(RC_5a609a7b7b622cde2859ca506690f8db s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5a609a7b7b622cde2859ca506690f8db(s, config);
}

}


