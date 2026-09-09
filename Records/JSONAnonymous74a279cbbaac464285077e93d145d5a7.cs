using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileIsSelectedStorageRecord
public class JSONRC_eb0c76f6f640a3fe05b6e66cf112863f : AbstractRESTStructure<RC_eb0c76f6f640a3fe05b6e66cf112863f> {
[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_eb0c76f6f640a3fe05b6e66cf112863f() { }

public JSONRC_eb0c76f6f640a3fe05b6e66cf112863f (RC_eb0c76f6f640a3fe05b6e66cf112863f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrIsSelected = (bool?) s.ssIsSelected;
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_eb0c76f6f640a3fe05b6e66cf112863f, RC_eb0c76f6f640a3fe05b6e66cf112863f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_eb0c76f6f640a3fe05b6e66cf112863f s) => ToStructure(s, config);
}
public static RC_eb0c76f6f640a3fe05b6e66cf112863f ToStructure(ssConectaProveedores.RestRecords.JSONRC_eb0c76f6f640a3fe05b6e66cf112863f obj, IBehaviorsConfiguration config) { 
  RC_eb0c76f6f640a3fe05b6e66cf112863f s = new RC_eb0c76f6f640a3fe05b6e66cf112863f();
  if(obj != null) {
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_eb0c76f6f640a3fe05b6e66cf112863f, ssConectaProveedores.RestRecords.JSONRC_eb0c76f6f640a3fe05b6e66cf112863f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eb0c76f6f640a3fe05b6e66cf112863f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_eb0c76f6f640a3fe05b6e66cf112863f FromStructure(RC_eb0c76f6f640a3fe05b6e66cf112863f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_eb0c76f6f640a3fe05b6e66cf112863f(s, config);
}

}


