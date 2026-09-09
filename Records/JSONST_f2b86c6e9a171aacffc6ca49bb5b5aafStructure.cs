using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NewNotification2
public class JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure : AbstractRESTStructure<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> {
[JsonProperty("userids")]
[JsonPropertyName("userids")]
public string[] Attruserids;

[JsonProperty("title")]
[JsonPropertyName("title")]
public string Attrtitle;

[JsonProperty("content")]
[JsonPropertyName("content")]
public string Attrcontent;

[JsonProperty("categoryclass")]
[JsonPropertyName("categoryclass")]
public string Attrcategoryclass;

public JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure() { }

public JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attruserids = s.ssuserids.Length == 0 ? null : s.ssuserids.ToArray();
Attrtitle = ConvertToRestWithoutDefaults(s.sstitle, "");
Attrcontent = ConvertToRestWithoutDefaults(s.sscontent, "");
Attrcategoryclass = ConvertToRestWithoutDefaults(s.sscategoryclass, "");
  } else {
Attruserids = s.ssuserids.ToArray();
Attrtitle = s.sstitle;
Attrcontent = s.sscontent;
Attrcategoryclass = s.sscategoryclass;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure, ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s) => ToStructure(s, config);
}
public static ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure obj, IBehaviorsConfiguration config) { 
  ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s = new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure();
  if(obj != null) {
  s.ssuserids = BasicTypeList<string>.ToList(obj.Attruserids);
  s.sstitle = obj.Attrtitle == null ? "" : obj.Attrtitle;
  s.sscontent = obj.Attrcontent == null ? "" : obj.Attrcontent;
  s.sscategoryclass = obj.Attrcategoryclass == null ? "" : obj.Attrcategoryclass;
  }
  return s;
}

public static Func<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure, ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure FromStructure(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(s, config);
}

}


