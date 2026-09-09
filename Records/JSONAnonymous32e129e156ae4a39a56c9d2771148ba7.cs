using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceFileSizeIsSelectedRecord
public class JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912 : AbstractRESTStructure<RC_0e55d0fdd23b58fdb0cbf299c27a7912> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public long? AttrSize;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

public JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912() { }

public JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912 (RC_0e55d0fdd23b58fdb0cbf299c27a7912 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrSize = (long?) s.ssSize;
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912, RC_0e55d0fdd23b58fdb0cbf299c27a7912> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912 s) => ToStructure(s, config);
}
public static RC_0e55d0fdd23b58fdb0cbf299c27a7912 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912 obj, IBehaviorsConfiguration config) { 
  RC_0e55d0fdd23b58fdb0cbf299c27a7912 s = new RC_0e55d0fdd23b58fdb0cbf299c27a7912();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_0e55d0fdd23b58fdb0cbf299c27a7912, ssConectaProveedores.RestRecords.JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e55d0fdd23b58fdb0cbf299c27a7912 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912 FromStructure(RC_0e55d0fdd23b58fdb0cbf299c27a7912 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0e55d0fdd23b58fdb0cbf299c27a7912(s, config);
}

}


