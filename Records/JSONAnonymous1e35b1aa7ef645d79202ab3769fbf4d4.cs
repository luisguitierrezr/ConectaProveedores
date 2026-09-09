using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoice_CNRecord
public class JSONRC_986e250fa802967d9a3443950a5e3b6b : AbstractRESTStructure<RC_986e250fa802967d9a3443950a5e3b6b> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Invoice_CN")]
[JsonPropertyName("Invoice_CN")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice_CN;

public JSONRC_986e250fa802967d9a3443950a5e3b6b() { }

public JSONRC_986e250fa802967d9a3443950a5e3b6b (RC_986e250fa802967d9a3443950a5e3b6b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoice_CN = ConvertToRestWithoutDefaults(s.ssENInvoice_CN, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoice_CN = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice_CN, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_986e250fa802967d9a3443950a5e3b6b, RC_986e250fa802967d9a3443950a5e3b6b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_986e250fa802967d9a3443950a5e3b6b s) => ToStructure(s, config);
}
public static RC_986e250fa802967d9a3443950a5e3b6b ToStructure(ssConectaProveedores.RestRecords.JSONRC_986e250fa802967d9a3443950a5e3b6b obj, IBehaviorsConfiguration config) { 
  RC_986e250fa802967d9a3443950a5e3b6b s = new RC_986e250fa802967d9a3443950a5e3b6b();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoice_CN = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice_CN, config);
  }
  return s;
}

public static Func<RC_986e250fa802967d9a3443950a5e3b6b, ssConectaProveedores.RestRecords.JSONRC_986e250fa802967d9a3443950a5e3b6b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_986e250fa802967d9a3443950a5e3b6b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_986e250fa802967d9a3443950a5e3b6b FromStructure(RC_986e250fa802967d9a3443950a5e3b6b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_986e250fa802967d9a3443950a5e3b6b(s, config);
}

}


