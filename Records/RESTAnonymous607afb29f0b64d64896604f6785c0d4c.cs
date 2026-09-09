using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceFileRecord
public class RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 : AbstractRESTStructure<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
public ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

public RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9() { }

public RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
  }
}

public static RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 obj) { 
  RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s = new RC_f5e20bd4e0a7c754f3e99b7ff28d38d9();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile);
  }
  return s;
}

public static Func<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9, ssConectaProveedores.RestRecords.RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9 FromStructure(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f5e20bd4e0a7c754f3e99b7ff28d38d9(s, config);
}

}


