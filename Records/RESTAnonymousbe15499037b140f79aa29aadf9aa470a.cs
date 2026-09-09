using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItemRecord
public class RESTRC_447a4f014542f360a86edbc89025680b : AbstractRESTStructure<RC_447a4f014542f360a86edbc89025680b> {
[JsonProperty("FolioItem")]
public ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure AttrFolioItem;

public RESTRC_447a4f014542f360a86edbc89025680b() { }

public RESTRC_447a4f014542f360a86edbc89025680b (RC_447a4f014542f360a86edbc89025680b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioItem = ConvertToRestWithoutDefaults(s.ssSTFolioItem, new ST_1bddfac19e9b0cef65924aa7568fd106Structure(), ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure.FromStructure, config);
  } else {
AttrFolioItem = ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure.FromStructure(s.ssSTFolioItem, config);
  }
}

public static RC_447a4f014542f360a86edbc89025680b ToStructure(ssConectaProveedores.RestRecords.RESTRC_447a4f014542f360a86edbc89025680b obj) { 
  RC_447a4f014542f360a86edbc89025680b s = new RC_447a4f014542f360a86edbc89025680b();
  if(obj != null) {
  s.ssSTFolioItem = ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure.ToStructure(obj.AttrFolioItem);
  }
  return s;
}

public static Func<RC_447a4f014542f360a86edbc89025680b, ssConectaProveedores.RestRecords.RESTRC_447a4f014542f360a86edbc89025680b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_447a4f014542f360a86edbc89025680b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_447a4f014542f360a86edbc89025680b FromStructure(RC_447a4f014542f360a86edbc89025680b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_447a4f014542f360a86edbc89025680b(s, config);
}

}


