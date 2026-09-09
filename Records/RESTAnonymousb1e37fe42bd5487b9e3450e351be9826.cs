using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceFileIsSelectedStorageRecord
public class RESTRC_decd99b444cc9b15cdd3bf7e05218957 : AbstractRESTStructure<RC_decd99b444cc9b15cdd3bf7e05218957> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("InvoiceFile")]
public ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_decd99b444cc9b15cdd3bf7e05218957() { }

public RESTRC_decd99b444cc9b15cdd3bf7e05218957 (RC_decd99b444cc9b15cdd3bf7e05218957 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrIsSelected = (bool?) s.ssIsSelected;
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_decd99b444cc9b15cdd3bf7e05218957 ToStructure(ssConectaProveedores.RestRecords.RESTRC_decd99b444cc9b15cdd3bf7e05218957 obj) { 
  RC_decd99b444cc9b15cdd3bf7e05218957 s = new RC_decd99b444cc9b15cdd3bf7e05218957();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_decd99b444cc9b15cdd3bf7e05218957, ssConectaProveedores.RestRecords.RESTRC_decd99b444cc9b15cdd3bf7e05218957> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_decd99b444cc9b15cdd3bf7e05218957 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_decd99b444cc9b15cdd3bf7e05218957 FromStructure(RC_decd99b444cc9b15cdd3bf7e05218957 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_decd99b444cc9b15cdd3bf7e05218957(s, config);
}

}


