using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdEmailNameOrderNumberRecord
public class RESTRC_0abe3ce56ac5cb76651869d42c67839f : AbstractRESTStructure<RC_0abe3ce56ac5cb76651869d42c67839f> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

public RESTRC_0abe3ce56ac5cb76651869d42c67839f() { }

public RESTRC_0abe3ce56ac5cb76651869d42c67839f (RC_0abe3ce56ac5cb76651869d42c67839f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
  } else {
AttrUserId = s.ssUserId;
AttrEmail = s.ssEmail;
AttrName = s.ssName;
AttrOrderNumber = s.ssOrderNumber;
  }
}

public static RC_0abe3ce56ac5cb76651869d42c67839f ToStructure(ssConectaProveedores.RestRecords.RESTRC_0abe3ce56ac5cb76651869d42c67839f obj) { 
  RC_0abe3ce56ac5cb76651869d42c67839f s = new RC_0abe3ce56ac5cb76651869d42c67839f();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  }
  return s;
}

public static Func<RC_0abe3ce56ac5cb76651869d42c67839f, ssConectaProveedores.RestRecords.RESTRC_0abe3ce56ac5cb76651869d42c67839f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0abe3ce56ac5cb76651869d42c67839f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0abe3ce56ac5cb76651869d42c67839f FromStructure(RC_0abe3ce56ac5cb76651869d42c67839f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0abe3ce56ac5cb76651869d42c67839f(s, config);
}

}


