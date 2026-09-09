using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFilesStorageRecord
public class RESTRC_db98be0f77f582e2a41dd64bb6a4005e : AbstractRESTStructure<RC_db98be0f77f582e2a41dd64bb6a4005e> {
[JsonProperty("FolioFiles")]
public ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_db98be0f77f582e2a41dd64bb6a4005e() { }

public RESTRC_db98be0f77f582e2a41dd64bb6a4005e (RC_db98be0f77f582e2a41dd64bb6a4005e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_db98be0f77f582e2a41dd64bb6a4005e ToStructure(ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e obj) { 
  RC_db98be0f77f582e2a41dd64bb6a4005e s = new RC_db98be0f77f582e2a41dd64bb6a4005e();
  if(obj != null) {
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_db98be0f77f582e2a41dd64bb6a4005e, ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_db98be0f77f582e2a41dd64bb6a4005e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e FromStructure(RC_db98be0f77f582e2a41dd64bb6a4005e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e(s, config);
}

}


