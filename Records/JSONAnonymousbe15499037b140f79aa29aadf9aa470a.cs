using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItemRecord
public class JSONRC_447a4f014542f360a86edbc89025680b : AbstractRESTStructure<RC_447a4f014542f360a86edbc89025680b> {
[JsonProperty("FolioItem")]
[JsonPropertyName("FolioItem")]
public ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure AttrFolioItem;

public JSONRC_447a4f014542f360a86edbc89025680b() { }

public JSONRC_447a4f014542f360a86edbc89025680b (RC_447a4f014542f360a86edbc89025680b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioItem = ConvertToRestWithoutDefaults(s.ssSTFolioItem, new ST_1bddfac19e9b0cef65924aa7568fd106Structure(), ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure.FromStructure, config);
  } else {
AttrFolioItem = ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure.FromStructure(s.ssSTFolioItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_447a4f014542f360a86edbc89025680b, RC_447a4f014542f360a86edbc89025680b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_447a4f014542f360a86edbc89025680b s) => ToStructure(s, config);
}
public static RC_447a4f014542f360a86edbc89025680b ToStructure(ssConectaProveedores.RestRecords.JSONRC_447a4f014542f360a86edbc89025680b obj, IBehaviorsConfiguration config) { 
  RC_447a4f014542f360a86edbc89025680b s = new RC_447a4f014542f360a86edbc89025680b();
  if(obj != null) {
  s.ssSTFolioItem = ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure.ToStructure(obj.AttrFolioItem, config);
  }
  return s;
}

public static Func<RC_447a4f014542f360a86edbc89025680b, ssConectaProveedores.RestRecords.JSONRC_447a4f014542f360a86edbc89025680b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_447a4f014542f360a86edbc89025680b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_447a4f014542f360a86edbc89025680b FromStructure(RC_447a4f014542f360a86edbc89025680b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_447a4f014542f360a86edbc89025680b(s, config);
}

}


