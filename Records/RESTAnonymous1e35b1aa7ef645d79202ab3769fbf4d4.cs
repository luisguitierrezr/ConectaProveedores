using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoice_CNRecord
public class RESTRC_986e250fa802967d9a3443950a5e3b6b : AbstractRESTStructure<RC_986e250fa802967d9a3443950a5e3b6b> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Invoice_CN")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice_CN;

public RESTRC_986e250fa802967d9a3443950a5e3b6b() { }

public RESTRC_986e250fa802967d9a3443950a5e3b6b (RC_986e250fa802967d9a3443950a5e3b6b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoice_CN = ConvertToRestWithoutDefaults(s.ssENInvoice_CN, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoice_CN = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice_CN, config);
  }
}

public static RC_986e250fa802967d9a3443950a5e3b6b ToStructure(ssConectaProveedores.RestRecords.RESTRC_986e250fa802967d9a3443950a5e3b6b obj) { 
  RC_986e250fa802967d9a3443950a5e3b6b s = new RC_986e250fa802967d9a3443950a5e3b6b();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoice_CN = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice_CN);
  }
  return s;
}

public static Func<RC_986e250fa802967d9a3443950a5e3b6b, ssConectaProveedores.RestRecords.RESTRC_986e250fa802967d9a3443950a5e3b6b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_986e250fa802967d9a3443950a5e3b6b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_986e250fa802967d9a3443950a5e3b6b FromStructure(RC_986e250fa802967d9a3443950a5e3b6b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_986e250fa802967d9a3443950a5e3b6b(s, config);
}

}


