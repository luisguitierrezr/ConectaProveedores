using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceFileRecord
public class JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1 : AbstractRESTStructure<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

public JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1() { }

public JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1 (RC_2b77a78552d1dad3876c3ebd8f5c8ec1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1, RC_2b77a78552d1dad3876c3ebd8f5c8ec1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1 s) => ToStructure(s, config);
}
public static RC_2b77a78552d1dad3876c3ebd8f5c8ec1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1 obj, IBehaviorsConfiguration config) { 
  RC_2b77a78552d1dad3876c3ebd8f5c8ec1 s = new RC_2b77a78552d1dad3876c3ebd8f5c8ec1();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  }
  return s;
}

public static Func<RC_2b77a78552d1dad3876c3ebd8f5c8ec1, ssConectaProveedores.RestRecords.JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2b77a78552d1dad3876c3ebd8f5c8ec1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1 FromStructure(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2b77a78552d1dad3876c3ebd8f5c8ec1(s, config);
}

}


