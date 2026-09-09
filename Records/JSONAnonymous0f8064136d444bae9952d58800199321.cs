using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceFileStorageRecord
public class JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26 : AbstractRESTStructure<RC_e89a3df29980b4bfe26cbaac4d2e6d26> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26() { }

public JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26 (RC_e89a3df29980b4bfe26cbaac4d2e6d26 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26, RC_e89a3df29980b4bfe26cbaac4d2e6d26> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26 s) => ToStructure(s, config);
}
public static RC_e89a3df29980b4bfe26cbaac4d2e6d26 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26 obj, IBehaviorsConfiguration config) { 
  RC_e89a3df29980b4bfe26cbaac4d2e6d26 s = new RC_e89a3df29980b4bfe26cbaac4d2e6d26();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_e89a3df29980b4bfe26cbaac4d2e6d26, ssConectaProveedores.RestRecords.JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e89a3df29980b4bfe26cbaac4d2e6d26 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26 FromStructure(RC_e89a3df29980b4bfe26cbaac4d2e6d26 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e89a3df29980b4bfe26cbaac4d2e6d26(s, config);
}

}


