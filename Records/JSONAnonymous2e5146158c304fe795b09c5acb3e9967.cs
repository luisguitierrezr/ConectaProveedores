using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionInvoicePolizaRecord
public class JSONRC_dc377962308205a06a34e4c0881035f7 : AbstractRESTStructure<RC_dc377962308205a06a34e4c0881035f7> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoicePoliza")]
[JsonPropertyName("InvoicePoliza")]
public ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord AttrInvoicePoliza;

public JSONRC_dc377962308205a06a34e4c0881035f7() { }

public JSONRC_dc377962308205a06a34e4c0881035f7 (RC_dc377962308205a06a34e4c0881035f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoicePoliza = ConvertToRestWithoutDefaults(s.ssENInvoicePoliza, new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoicePoliza = ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure(s.ssENInvoicePoliza, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_dc377962308205a06a34e4c0881035f7, RC_dc377962308205a06a34e4c0881035f7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_dc377962308205a06a34e4c0881035f7 s) => ToStructure(s, config);
}
public static RC_dc377962308205a06a34e4c0881035f7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_dc377962308205a06a34e4c0881035f7 obj, IBehaviorsConfiguration config) { 
  RC_dc377962308205a06a34e4c0881035f7 s = new RC_dc377962308205a06a34e4c0881035f7();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoicePoliza = ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.ToStructure(obj.AttrInvoicePoliza, config);
  }
  return s;
}

public static Func<RC_dc377962308205a06a34e4c0881035f7, ssConectaProveedores.RestRecords.JSONRC_dc377962308205a06a34e4c0881035f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dc377962308205a06a34e4c0881035f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_dc377962308205a06a34e4c0881035f7 FromStructure(RC_dc377962308205a06a34e4c0881035f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_dc377962308205a06a34e4c0881035f7(s, config);
}

}


