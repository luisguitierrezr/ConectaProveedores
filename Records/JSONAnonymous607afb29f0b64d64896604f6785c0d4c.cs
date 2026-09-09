using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceFileRecord
public class JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 : AbstractRESTStructure<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

public JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9() { }

public JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9, RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s) => ToStructure(s, config);
}
public static RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 obj, IBehaviorsConfiguration config) { 
  RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s = new RC_f5e20bd4e0a7c754f3e99b7ff28d38d9();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  }
  return s;
}

public static Func<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9, ssConectaProveedores.RestRecords.JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 FromStructure(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f5e20bd4e0a7c754f3e99b7ff28d38d9(s, config);
}

}


