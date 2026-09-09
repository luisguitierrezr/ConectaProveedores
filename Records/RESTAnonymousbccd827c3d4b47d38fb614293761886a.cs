using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFolioFilesStorageSupplierRecord
public class RESTRC_c6c14818b27b1ae2048888ac314317c1 : AbstractRESTStructure<RC_c6c14818b27b1ae2048888ac314317c1> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioFiles")]
public ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_c6c14818b27b1ae2048888ac314317c1() { }

public RESTRC_c6c14818b27b1ae2048888ac314317c1 (RC_c6c14818b27b1ae2048888ac314317c1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_c6c14818b27b1ae2048888ac314317c1 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c6c14818b27b1ae2048888ac314317c1 obj) { 
  RC_c6c14818b27b1ae2048888ac314317c1 s = new RC_c6c14818b27b1ae2048888ac314317c1();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_c6c14818b27b1ae2048888ac314317c1, ssConectaProveedores.RestRecords.RESTRC_c6c14818b27b1ae2048888ac314317c1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6c14818b27b1ae2048888ac314317c1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c6c14818b27b1ae2048888ac314317c1 FromStructure(RC_c6c14818b27b1ae2048888ac314317c1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c6c14818b27b1ae2048888ac314317c1(s, config);
}

}


