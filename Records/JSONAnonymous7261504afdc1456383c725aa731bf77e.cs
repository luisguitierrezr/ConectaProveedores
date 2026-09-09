using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFolioInvoiceExtendedRecord
public class JSONRC_a23c38bc44b370f52521e410e49fc2ac : AbstractRESTStructure<RC_a23c38bc44b370f52521e410e49fc2ac> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public JSONRC_a23c38bc44b370f52521e410e49fc2ac() { }

public JSONRC_a23c38bc44b370f52521e410e49fc2ac (RC_a23c38bc44b370f52521e410e49fc2ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a23c38bc44b370f52521e410e49fc2ac, RC_a23c38bc44b370f52521e410e49fc2ac> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a23c38bc44b370f52521e410e49fc2ac s) => ToStructure(s, config);
}
public static RC_a23c38bc44b370f52521e410e49fc2ac ToStructure(ssConectaProveedores.RestRecords.JSONRC_a23c38bc44b370f52521e410e49fc2ac obj, IBehaviorsConfiguration config) { 
  RC_a23c38bc44b370f52521e410e49fc2ac s = new RC_a23c38bc44b370f52521e410e49fc2ac();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  }
  return s;
}

public static Func<RC_a23c38bc44b370f52521e410e49fc2ac, ssConectaProveedores.RestRecords.JSONRC_a23c38bc44b370f52521e410e49fc2ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a23c38bc44b370f52521e410e49fc2ac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a23c38bc44b370f52521e410e49fc2ac FromStructure(RC_a23c38bc44b370f52521e410e49fc2ac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a23c38bc44b370f52521e410e49fc2ac(s, config);
}

}


