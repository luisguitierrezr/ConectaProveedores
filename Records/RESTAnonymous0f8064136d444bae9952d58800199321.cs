using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceFileStorageRecord
public class RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26 : AbstractRESTStructure<RC_e89a3df29980b4bfe26cbaac4d2e6d26> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
public ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26() { }

public RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26 (RC_e89a3df29980b4bfe26cbaac4d2e6d26 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_e89a3df29980b4bfe26cbaac4d2e6d26 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26 obj) { 
  RC_e89a3df29980b4bfe26cbaac4d2e6d26 s = new RC_e89a3df29980b4bfe26cbaac4d2e6d26();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_e89a3df29980b4bfe26cbaac4d2e6d26, ssConectaProveedores.RestRecords.RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e89a3df29980b4bfe26cbaac4d2e6d26 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26 FromStructure(RC_e89a3df29980b4bfe26cbaac4d2e6d26 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e89a3df29980b4bfe26cbaac4d2e6d26(s, config);
}

}


