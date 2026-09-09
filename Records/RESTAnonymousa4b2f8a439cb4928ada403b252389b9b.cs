using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioScreenTableStructureRecord
public class RESTRC_d4c9aad369e5098dd6cf11900712043f : AbstractRESTStructure<RC_d4c9aad369e5098dd6cf11900712043f> {
[JsonProperty("FolioScreenTableStructure")]
public ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure AttrFolioScreenTableStructure;

public RESTRC_d4c9aad369e5098dd6cf11900712043f() { }

public RESTRC_d4c9aad369e5098dd6cf11900712043f (RC_d4c9aad369e5098dd6cf11900712043f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioScreenTableStructure = ConvertToRestWithoutDefaults(s.ssSTFolioScreenTableStructure, new ST_3dc7a528e6a1e146b195db5c3edb006aStructure(), ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure.FromStructure, config);
  } else {
AttrFolioScreenTableStructure = ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure.FromStructure(s.ssSTFolioScreenTableStructure, config);
  }
}

public static RC_d4c9aad369e5098dd6cf11900712043f ToStructure(ssConectaProveedores.RestRecords.RESTRC_d4c9aad369e5098dd6cf11900712043f obj) { 
  RC_d4c9aad369e5098dd6cf11900712043f s = new RC_d4c9aad369e5098dd6cf11900712043f();
  if(obj != null) {
  s.ssSTFolioScreenTableStructure = ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure.ToStructure(obj.AttrFolioScreenTableStructure);
  }
  return s;
}

public static Func<RC_d4c9aad369e5098dd6cf11900712043f, ssConectaProveedores.RestRecords.RESTRC_d4c9aad369e5098dd6cf11900712043f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d4c9aad369e5098dd6cf11900712043f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d4c9aad369e5098dd6cf11900712043f FromStructure(RC_d4c9aad369e5098dd6cf11900712043f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d4c9aad369e5098dd6cf11900712043f(s, config);
}

}


