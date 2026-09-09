using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionInvoicePolizaRecord
public class RESTRC_dc377962308205a06a34e4c0881035f7 : AbstractRESTStructure<RC_dc377962308205a06a34e4c0881035f7> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoicePoliza")]
public ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord AttrInvoicePoliza;

public RESTRC_dc377962308205a06a34e4c0881035f7() { }

public RESTRC_dc377962308205a06a34e4c0881035f7 (RC_dc377962308205a06a34e4c0881035f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoicePoliza = ConvertToRestWithoutDefaults(s.ssENInvoicePoliza, new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoicePoliza = ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure(s.ssENInvoicePoliza, config);
  }
}

public static RC_dc377962308205a06a34e4c0881035f7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dc377962308205a06a34e4c0881035f7 obj) { 
  RC_dc377962308205a06a34e4c0881035f7 s = new RC_dc377962308205a06a34e4c0881035f7();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENInvoicePoliza = ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.ToStructure(obj.AttrInvoicePoliza);
  }
  return s;
}

public static Func<RC_dc377962308205a06a34e4c0881035f7, ssConectaProveedores.RestRecords.RESTRC_dc377962308205a06a34e4c0881035f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dc377962308205a06a34e4c0881035f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dc377962308205a06a34e4c0881035f7 FromStructure(RC_dc377962308205a06a34e4c0881035f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dc377962308205a06a34e4c0881035f7(s, config);
}

}


