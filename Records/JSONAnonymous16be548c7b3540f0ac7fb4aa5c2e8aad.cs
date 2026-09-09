using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItemForOrderRecord
public class JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd : AbstractRESTStructure<RC_7b1aae62a8e090753ba4cda6cb9c5acd> {
[JsonProperty("FolioItemForOrder")]
[JsonPropertyName("FolioItemForOrder")]
public ssConectaProveedores.RestRecords.JSONST_662e235c01358293d93e19bedad72008Structure AttrFolioItemForOrder;

public JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd() { }

public JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd (RC_7b1aae62a8e090753ba4cda6cb9c5acd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioItemForOrder = ConvertToRestWithoutDefaults(s.ssSTFolioItemForOrder, new ST_662e235c01358293d93e19bedad72008Structure(), ssConectaProveedores.RestRecords.JSONST_662e235c01358293d93e19bedad72008Structure.FromStructure, config);
  } else {
AttrFolioItemForOrder = ssConectaProveedores.RestRecords.JSONST_662e235c01358293d93e19bedad72008Structure.FromStructure(s.ssSTFolioItemForOrder, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd, RC_7b1aae62a8e090753ba4cda6cb9c5acd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd s) => ToStructure(s, config);
}
public static RC_7b1aae62a8e090753ba4cda6cb9c5acd ToStructure(ssConectaProveedores.RestRecords.JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd obj, IBehaviorsConfiguration config) { 
  RC_7b1aae62a8e090753ba4cda6cb9c5acd s = new RC_7b1aae62a8e090753ba4cda6cb9c5acd();
  if(obj != null) {
  s.ssSTFolioItemForOrder = ssConectaProveedores.RestRecords.JSONST_662e235c01358293d93e19bedad72008Structure.ToStructure(obj.AttrFolioItemForOrder, config);
  }
  return s;
}

public static Func<RC_7b1aae62a8e090753ba4cda6cb9c5acd, ssConectaProveedores.RestRecords.JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7b1aae62a8e090753ba4cda6cb9c5acd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd FromStructure(RC_7b1aae62a8e090753ba4cda6cb9c5acd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7b1aae62a8e090753ba4cda6cb9c5acd(s, config);
}

}


