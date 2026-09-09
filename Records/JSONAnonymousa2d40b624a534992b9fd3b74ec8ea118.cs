using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataInvoiceFolioInvoiceExtendedRecord
public class JSONRC_93224f6033b2fcf15869e73d67c629f2 : AbstractRESTStructure<RC_93224f6033b2fcf15869e73d67c629f2> {
[JsonProperty("FolioSAPData")]
[JsonPropertyName("FolioSAPData")]
public ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public JSONRC_93224f6033b2fcf15869e73d67c629f2() { }

public JSONRC_93224f6033b2fcf15869e73d67c629f2 (RC_93224f6033b2fcf15869e73d67c629f2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_93224f6033b2fcf15869e73d67c629f2, RC_93224f6033b2fcf15869e73d67c629f2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_93224f6033b2fcf15869e73d67c629f2 s) => ToStructure(s, config);
}
public static RC_93224f6033b2fcf15869e73d67c629f2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_93224f6033b2fcf15869e73d67c629f2 obj, IBehaviorsConfiguration config) { 
  RC_93224f6033b2fcf15869e73d67c629f2 s = new RC_93224f6033b2fcf15869e73d67c629f2();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  }
  return s;
}

public static Func<RC_93224f6033b2fcf15869e73d67c629f2, ssConectaProveedores.RestRecords.JSONRC_93224f6033b2fcf15869e73d67c629f2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_93224f6033b2fcf15869e73d67c629f2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_93224f6033b2fcf15869e73d67c629f2 FromStructure(RC_93224f6033b2fcf15869e73d67c629f2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_93224f6033b2fcf15869e73d67c629f2(s, config);
}

}


