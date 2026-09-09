using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioFilesStorageRecord
public class RESTRC_524c288faf455ce3a30a531f7ff5854e : AbstractRESTStructure<RC_524c288faf455ce3a30a531f7ff5854e> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("FolioFiles")]
public ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_524c288faf455ce3a30a531f7ff5854e() { }

public RESTRC_524c288faf455ce3a30a531f7ff5854e (RC_524c288faf455ce3a30a531f7ff5854e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_524c288faf455ce3a30a531f7ff5854e ToStructure(ssConectaProveedores.RestRecords.RESTRC_524c288faf455ce3a30a531f7ff5854e obj) { 
  RC_524c288faf455ce3a30a531f7ff5854e s = new RC_524c288faf455ce3a30a531f7ff5854e();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_524c288faf455ce3a30a531f7ff5854e, ssConectaProveedores.RestRecords.RESTRC_524c288faf455ce3a30a531f7ff5854e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_524c288faf455ce3a30a531f7ff5854e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_524c288faf455ce3a30a531f7ff5854e FromStructure(RC_524c288faf455ce3a30a531f7ff5854e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_524c288faf455ce3a30a531f7ff5854e(s, config);
}

}


