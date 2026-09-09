using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFolioFilesStorageSupplierRecord
public class JSONRC_c6c14818b27b1ae2048888ac314317c1 : AbstractRESTStructure<RC_c6c14818b27b1ae2048888ac314317c1> {
[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioFiles")]
[JsonPropertyName("FolioFiles")]
public ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_c6c14818b27b1ae2048888ac314317c1() { }

public JSONRC_c6c14818b27b1ae2048888ac314317c1 (RC_c6c14818b27b1ae2048888ac314317c1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioFiles = ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c6c14818b27b1ae2048888ac314317c1, RC_c6c14818b27b1ae2048888ac314317c1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c6c14818b27b1ae2048888ac314317c1 s) => ToStructure(s, config);
}
public static RC_c6c14818b27b1ae2048888ac314317c1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c6c14818b27b1ae2048888ac314317c1 obj, IBehaviorsConfiguration config) { 
  RC_c6c14818b27b1ae2048888ac314317c1 s = new RC_c6c14818b27b1ae2048888ac314317c1();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_c6c14818b27b1ae2048888ac314317c1, ssConectaProveedores.RestRecords.JSONRC_c6c14818b27b1ae2048888ac314317c1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6c14818b27b1ae2048888ac314317c1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c6c14818b27b1ae2048888ac314317c1 FromStructure(RC_c6c14818b27b1ae2048888ac314317c1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c6c14818b27b1ae2048888ac314317c1(s, config);
}

}


