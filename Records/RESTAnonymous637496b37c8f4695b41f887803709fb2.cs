using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileStorageRecord
public class RESTRC_7cb091de697d14a1ce465208aa77fcb0 : AbstractRESTStructure<RC_7cb091de697d14a1ce465208aa77fcb0> {
[JsonProperty("InvoiceFile")]
public ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_7cb091de697d14a1ce465208aa77fcb0() { }

public RESTRC_7cb091de697d14a1ce465208aa77fcb0 (RC_7cb091de697d14a1ce465208aa77fcb0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_7cb091de697d14a1ce465208aa77fcb0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0 obj) { 
  RC_7cb091de697d14a1ce465208aa77fcb0 s = new RC_7cb091de697d14a1ce465208aa77fcb0();
  if(obj != null) {
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_7cb091de697d14a1ce465208aa77fcb0, ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7cb091de697d14a1ce465208aa77fcb0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0 FromStructure(RC_7cb091de697d14a1ce465208aa77fcb0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0(s, config);
}

}


