using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceFileStorageRecord
public class RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5 : AbstractRESTStructure<RC_d0f36b0aa01c99a6864922a3e47b0bc5> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
public ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5() { }

public RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5 (RC_d0f36b0aa01c99a6864922a3e47b0bc5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_d0f36b0aa01c99a6864922a3e47b0bc5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5 obj) { 
  RC_d0f36b0aa01c99a6864922a3e47b0bc5 s = new RC_d0f36b0aa01c99a6864922a3e47b0bc5();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_d0f36b0aa01c99a6864922a3e47b0bc5, ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d0f36b0aa01c99a6864922a3e47b0bc5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5 FromStructure(RC_d0f36b0aa01c99a6864922a3e47b0bc5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5(s, config);
}

}


