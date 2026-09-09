using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceExtendedRecord
public class JSONRC_b6257dfb536e679f8b7be7b4b56f189b : AbstractRESTStructure<RC_b6257dfb536e679f8b7be7b4b56f189b> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public JSONRC_b6257dfb536e679f8b7be7b4b56f189b() { }

public JSONRC_b6257dfb536e679f8b7be7b4b56f189b (RC_b6257dfb536e679f8b7be7b4b56f189b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b6257dfb536e679f8b7be7b4b56f189b, RC_b6257dfb536e679f8b7be7b4b56f189b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b6257dfb536e679f8b7be7b4b56f189b s) => ToStructure(s, config);
}
public static RC_b6257dfb536e679f8b7be7b4b56f189b ToStructure(ssConectaProveedores.RestRecords.JSONRC_b6257dfb536e679f8b7be7b4b56f189b obj, IBehaviorsConfiguration config) { 
  RC_b6257dfb536e679f8b7be7b4b56f189b s = new RC_b6257dfb536e679f8b7be7b4b56f189b();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  }
  return s;
}

public static Func<RC_b6257dfb536e679f8b7be7b4b56f189b, ssConectaProveedores.RestRecords.JSONRC_b6257dfb536e679f8b7be7b4b56f189b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b6257dfb536e679f8b7be7b4b56f189b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b6257dfb536e679f8b7be7b4b56f189b FromStructure(RC_b6257dfb536e679f8b7be7b4b56f189b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b6257dfb536e679f8b7be7b4b56f189b(s, config);
}

}


