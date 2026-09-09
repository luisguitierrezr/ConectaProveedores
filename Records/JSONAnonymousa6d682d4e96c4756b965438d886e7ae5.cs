using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdEmailNameOrderNumberRecord
public class JSONRC_0abe3ce56ac5cb76651869d42c67839f : AbstractRESTStructure<RC_0abe3ce56ac5cb76651869d42c67839f> {
[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

public JSONRC_0abe3ce56ac5cb76651869d42c67839f() { }

public JSONRC_0abe3ce56ac5cb76651869d42c67839f (RC_0abe3ce56ac5cb76651869d42c67839f s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONRC_0abe3ce56ac5cb76651869d42c67839f, RC_0abe3ce56ac5cb76651869d42c67839f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0abe3ce56ac5cb76651869d42c67839f s) => ToStructure(s, config);
}
public static RC_0abe3ce56ac5cb76651869d42c67839f ToStructure(ssConectaProveedores.RestRecords.JSONRC_0abe3ce56ac5cb76651869d42c67839f obj, IBehaviorsConfiguration config) { 
  RC_0abe3ce56ac5cb76651869d42c67839f s = new RC_0abe3ce56ac5cb76651869d42c67839f();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  }
  return s;
}

public static Func<RC_0abe3ce56ac5cb76651869d42c67839f, ssConectaProveedores.RestRecords.JSONRC_0abe3ce56ac5cb76651869d42c67839f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0abe3ce56ac5cb76651869d42c67839f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0abe3ce56ac5cb76651869d42c67839f FromStructure(RC_0abe3ce56ac5cb76651869d42c67839f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0abe3ce56ac5cb76651869d42c67839f(s, config);
}

}


