using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceFileIsSelectedStorageRecord
public class JSONRC_decd99b444cc9b15cdd3bf7e05218957 : AbstractRESTStructure<RC_decd99b444cc9b15cdd3bf7e05218957> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_decd99b444cc9b15cdd3bf7e05218957() { }

public JSONRC_decd99b444cc9b15cdd3bf7e05218957 (RC_decd99b444cc9b15cdd3bf7e05218957 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrIsSelected = (bool?) s.ssIsSelected;
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_decd99b444cc9b15cdd3bf7e05218957, RC_decd99b444cc9b15cdd3bf7e05218957> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_decd99b444cc9b15cdd3bf7e05218957 s) => ToStructure(s, config);
}
public static RC_decd99b444cc9b15cdd3bf7e05218957 ToStructure(ssConectaProveedores.RestRecords.JSONRC_decd99b444cc9b15cdd3bf7e05218957 obj, IBehaviorsConfiguration config) { 
  RC_decd99b444cc9b15cdd3bf7e05218957 s = new RC_decd99b444cc9b15cdd3bf7e05218957();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_decd99b444cc9b15cdd3bf7e05218957, ssConectaProveedores.RestRecords.JSONRC_decd99b444cc9b15cdd3bf7e05218957> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_decd99b444cc9b15cdd3bf7e05218957 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_decd99b444cc9b15cdd3bf7e05218957 FromStructure(RC_decd99b444cc9b15cdd3bf7e05218957 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_decd99b444cc9b15cdd3bf7e05218957(s, config);
}

}


