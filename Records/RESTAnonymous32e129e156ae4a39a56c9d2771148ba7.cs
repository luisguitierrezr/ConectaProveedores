using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceFileSizeIsSelectedRecord
public class RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912 : AbstractRESTStructure<RC_0e55d0fdd23b58fdb0cbf299c27a7912> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("InvoiceFile")]
public ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Size")]
public long? AttrSize;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

public RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912() { }

public RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912 (RC_0e55d0fdd23b58fdb0cbf299c27a7912 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrSize = (long?) s.ssSize;
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static RC_0e55d0fdd23b58fdb0cbf299c27a7912 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912 obj) { 
  RC_0e55d0fdd23b58fdb0cbf299c27a7912 s = new RC_0e55d0fdd23b58fdb0cbf299c27a7912();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.RESTEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile);
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_0e55d0fdd23b58fdb0cbf299c27a7912, ssConectaProveedores.RestRecords.RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e55d0fdd23b58fdb0cbf299c27a7912 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912 FromStructure(RC_0e55d0fdd23b58fdb0cbf299c27a7912 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0e55d0fdd23b58fdb0cbf299c27a7912(s, config);
}

}


