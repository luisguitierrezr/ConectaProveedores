using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileStorageRecord
public class JSONRC_7cb091de697d14a1ce465208aa77fcb0 : AbstractRESTStructure<RC_7cb091de697d14a1ce465208aa77fcb0> {
[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_7cb091de697d14a1ce465208aa77fcb0() { }

public JSONRC_7cb091de697d14a1ce465208aa77fcb0 (RC_7cb091de697d14a1ce465208aa77fcb0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7cb091de697d14a1ce465208aa77fcb0, RC_7cb091de697d14a1ce465208aa77fcb0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7cb091de697d14a1ce465208aa77fcb0 s) => ToStructure(s, config);
}
public static RC_7cb091de697d14a1ce465208aa77fcb0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7cb091de697d14a1ce465208aa77fcb0 obj, IBehaviorsConfiguration config) { 
  RC_7cb091de697d14a1ce465208aa77fcb0 s = new RC_7cb091de697d14a1ce465208aa77fcb0();
  if(obj != null) {
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_7cb091de697d14a1ce465208aa77fcb0, ssConectaProveedores.RestRecords.JSONRC_7cb091de697d14a1ce465208aa77fcb0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7cb091de697d14a1ce465208aa77fcb0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7cb091de697d14a1ce465208aa77fcb0 FromStructure(RC_7cb091de697d14a1ce465208aa77fcb0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7cb091de697d14a1ce465208aa77fcb0(s, config);
}

}


