using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailNotification
public class RESTST_12668886130225cd5b17c72a6562dd7cStructure : AbstractRESTStructure<ST_12668886130225cd5b17c72a6562dd7cStructure> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("EmailTo")]
public string AttrEmailTo;

public RESTST_12668886130225cd5b17c72a6562dd7cStructure() { }

public RESTST_12668886130225cd5b17c72a6562dd7cStructure (ST_12668886130225cd5b17c72a6562dd7cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrEmailTo = ConvertToRestWithoutDefaults(s.ssEmailTo, "");
  } else {
AttrUserId = s.ssUserId;
AttrEmail = s.ssEmail;
AttrName = s.ssName;
AttrEmailTo = s.ssEmailTo;
  }
}

public static ST_12668886130225cd5b17c72a6562dd7cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure obj) { 
  ST_12668886130225cd5b17c72a6562dd7cStructure s = new ST_12668886130225cd5b17c72a6562dd7cStructure();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssEmailTo = obj.AttrEmailTo == null ? "" : obj.AttrEmailTo;
  }
  return s;
}

public static Func<ST_12668886130225cd5b17c72a6562dd7cStructure, ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_12668886130225cd5b17c72a6562dd7cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure FromStructure(ST_12668886130225cd5b17c72a6562dd7cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_12668886130225cd5b17c72a6562dd7cStructure(s, config);
}

}


