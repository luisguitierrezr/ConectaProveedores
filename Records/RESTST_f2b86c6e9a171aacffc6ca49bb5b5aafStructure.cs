using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NewNotification2
public class RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure : AbstractRESTStructure<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> {
[JsonProperty("userids")]
public RestList<string> Attruserids;

[JsonProperty("title")]
public string Attrtitle;

[JsonProperty("content")]
public string Attrcontent;

[JsonProperty("categoryclass")]
public string Attrcategoryclass;

public RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure() { }

public RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attruserids = s.ssuserids.Length == 0 ? null : s.ssuserids.ToRestList();
Attrtitle = ConvertToRestWithoutDefaults(s.sstitle, "");
Attrcontent = ConvertToRestWithoutDefaults(s.sscontent, "");
Attrcategoryclass = ConvertToRestWithoutDefaults(s.sscategoryclass, "");
  } else {
Attruserids = s.ssuserids.ToRestList();
Attrtitle = s.sstitle;
Attrcontent = s.sscontent;
Attrcategoryclass = s.sscategoryclass;
  }
}

public static ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure obj) { 
  ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s = new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure();
  if(obj != null) {
  s.ssuserids = BasicTypeList<string>.FromRestList(obj.Attruserids);
  s.sstitle = obj.Attrtitle == null ? "" : obj.Attrtitle;
  s.sscontent = obj.Attrcontent == null ? "" : obj.Attrcontent;
  s.sscategoryclass = obj.Attrcategoryclass == null ? "" : obj.Attrcategoryclass;
  }
  return s;
}

public static Func<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure, ssConectaProveedores.RestRecords.RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure FromStructure(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(s, config);
}

}


