using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostTokenResponse
public class RESTST_d5188f28891fd075d6bc1034899cfadeStructure : AbstractRESTStructure<ST_d5188f28891fd075d6bc1034899cfadeStructure> {
[JsonProperty("Token_type")]
public string AttrToken_type;

[JsonProperty("Expires_in")]
public long? AttrExpires_in;

[JsonProperty("Ext_expires_in")]
public long? AttrExt_expires_in;

[JsonProperty("Access_token")]
public string AttrAccess_token;

public RESTST_d5188f28891fd075d6bc1034899cfadeStructure() { }

public RESTST_d5188f28891fd075d6bc1034899cfadeStructure (ST_d5188f28891fd075d6bc1034899cfadeStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrToken_type = ConvertToRestWithoutDefaults(s.ssToken_type, "");
AttrExpires_in = ConvertToRestWithoutDefaults(s.ssExpires_in, 0L);
AttrExt_expires_in = ConvertToRestWithoutDefaults(s.ssExt_expires_in, 0L);
AttrAccess_token = ConvertToRestWithoutDefaults(s.ssAccess_token, "");
  } else {
AttrToken_type = s.ssToken_type;
AttrExpires_in = (long?) s.ssExpires_in;
AttrExt_expires_in = (long?) s.ssExt_expires_in;
AttrAccess_token = s.ssAccess_token;
  }
}

public static ST_d5188f28891fd075d6bc1034899cfadeStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_d5188f28891fd075d6bc1034899cfadeStructure obj) { 
  ST_d5188f28891fd075d6bc1034899cfadeStructure s = new ST_d5188f28891fd075d6bc1034899cfadeStructure();
  if(obj != null) {
  s.ssToken_type = obj.AttrToken_type == null ? "" : obj.AttrToken_type;
  s.ssExpires_in = obj.AttrExpires_in == null ? 0L : obj.AttrExpires_in.Value;
  s.ssExt_expires_in = obj.AttrExt_expires_in == null ? 0L : obj.AttrExt_expires_in.Value;
  s.ssAccess_token = obj.AttrAccess_token == null ? "" : obj.AttrAccess_token;
  }
  return s;
}

public static Func<ST_d5188f28891fd075d6bc1034899cfadeStructure, ssConectaProveedores.RestRecords.RESTST_d5188f28891fd075d6bc1034899cfadeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d5188f28891fd075d6bc1034899cfadeStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d5188f28891fd075d6bc1034899cfadeStructure FromStructure(ST_d5188f28891fd075d6bc1034899cfadeStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d5188f28891fd075d6bc1034899cfadeStructure(s, config);
}

}


