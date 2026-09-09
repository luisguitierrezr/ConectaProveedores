using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioFilesStorageRecord
public class JSONRC_524c288faf455ce3a30a531f7ff5854e : AbstractRESTStructure<RC_524c288faf455ce3a30a531f7ff5854e> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("FolioFiles")]
[JsonPropertyName("FolioFiles")]
public ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_524c288faf455ce3a30a531f7ff5854e() { }

public JSONRC_524c288faf455ce3a30a531f7ff5854e (RC_524c288faf455ce3a30a531f7ff5854e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolioFiles = ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_524c288faf455ce3a30a531f7ff5854e, RC_524c288faf455ce3a30a531f7ff5854e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_524c288faf455ce3a30a531f7ff5854e s) => ToStructure(s, config);
}
public static RC_524c288faf455ce3a30a531f7ff5854e ToStructure(ssConectaProveedores.RestRecords.JSONRC_524c288faf455ce3a30a531f7ff5854e obj, IBehaviorsConfiguration config) { 
  RC_524c288faf455ce3a30a531f7ff5854e s = new RC_524c288faf455ce3a30a531f7ff5854e();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_524c288faf455ce3a30a531f7ff5854e, ssConectaProveedores.RestRecords.JSONRC_524c288faf455ce3a30a531f7ff5854e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_524c288faf455ce3a30a531f7ff5854e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_524c288faf455ce3a30a531f7ff5854e FromStructure(RC_524c288faf455ce3a30a531f7ff5854e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_524c288faf455ce3a30a531f7ff5854e(s, config);
}

}


