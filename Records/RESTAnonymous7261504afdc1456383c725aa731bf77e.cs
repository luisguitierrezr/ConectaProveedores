using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFolioInvoiceExtendedRecord
public class RESTRC_a23c38bc44b370f52521e410e49fc2ac : AbstractRESTStructure<RC_a23c38bc44b370f52521e410e49fc2ac> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public RESTRC_a23c38bc44b370f52521e410e49fc2ac() { }

public RESTRC_a23c38bc44b370f52521e410e49fc2ac (RC_a23c38bc44b370f52521e410e49fc2ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static RC_a23c38bc44b370f52521e410e49fc2ac ToStructure(ssConectaProveedores.RestRecords.RESTRC_a23c38bc44b370f52521e410e49fc2ac obj) { 
  RC_a23c38bc44b370f52521e410e49fc2ac s = new RC_a23c38bc44b370f52521e410e49fc2ac();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended);
  }
  return s;
}

public static Func<RC_a23c38bc44b370f52521e410e49fc2ac, ssConectaProveedores.RestRecords.RESTRC_a23c38bc44b370f52521e410e49fc2ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a23c38bc44b370f52521e410e49fc2ac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a23c38bc44b370f52521e410e49fc2ac FromStructure(RC_a23c38bc44b370f52521e410e49fc2ac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a23c38bc44b370f52521e410e49fc2ac(s, config);
}

}


