using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFolioRecord
public class JSONRC_b668eee4846e2937101a51355804499d : AbstractRESTStructure<RC_b668eee4846e2937101a51355804499d> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

public JSONRC_b668eee4846e2937101a51355804499d() { }

public JSONRC_b668eee4846e2937101a51355804499d (RC_b668eee4846e2937101a51355804499d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b668eee4846e2937101a51355804499d, RC_b668eee4846e2937101a51355804499d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b668eee4846e2937101a51355804499d s) => ToStructure(s, config);
}
public static RC_b668eee4846e2937101a51355804499d ToStructure(ssConectaProveedores.RestRecords.JSONRC_b668eee4846e2937101a51355804499d obj, IBehaviorsConfiguration config) { 
  RC_b668eee4846e2937101a51355804499d s = new RC_b668eee4846e2937101a51355804499d();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  }
  return s;
}

public static Func<RC_b668eee4846e2937101a51355804499d, ssConectaProveedores.RestRecords.JSONRC_b668eee4846e2937101a51355804499d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b668eee4846e2937101a51355804499d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b668eee4846e2937101a51355804499d FromStructure(RC_b668eee4846e2937101a51355804499d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b668eee4846e2937101a51355804499d(s, config);
}

}


