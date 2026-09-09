using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Environment
public class RESTST_201dce7bb255178c132fec4d547942aeStructure : AbstractRESTStructure<ST_201dce7bb255178c132fec4d547942aeStructure> {
[JsonProperty("BaseURL")]
public string AttrBaseURL;

[JsonProperty("Locale")]
public string AttrLocale;

[JsonProperty("Timezone")]
public string AttrTimezone;

public RESTST_201dce7bb255178c132fec4d547942aeStructure() { }

public RESTST_201dce7bb255178c132fec4d547942aeStructure (ST_201dce7bb255178c132fec4d547942aeStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBaseURL = ConvertToRestWithoutDefaults(s.ssBaseURL, "");
AttrLocale = ConvertToRestWithoutDefaults(s.ssLocale, "");
AttrTimezone = ConvertToRestWithoutDefaults(s.ssTimezone, "");
  } else {
AttrBaseURL = s.ssBaseURL;
AttrLocale = s.ssLocale;
AttrTimezone = s.ssTimezone;
  }
}

public static ST_201dce7bb255178c132fec4d547942aeStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure obj) { 
  ST_201dce7bb255178c132fec4d547942aeStructure s = new ST_201dce7bb255178c132fec4d547942aeStructure();
  if(obj != null) {
  s.ssBaseURL = obj.AttrBaseURL == null ? "" : obj.AttrBaseURL;
  s.ssLocale = obj.AttrLocale == null ? "" : obj.AttrLocale;
  s.ssTimezone = obj.AttrTimezone == null ? "" : obj.AttrTimezone;
  }
  return s;
}

public static Func<ST_201dce7bb255178c132fec4d547942aeStructure, ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_201dce7bb255178c132fec4d547942aeStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure FromStructure(ST_201dce7bb255178c132fec4d547942aeStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure(s, config);
}

}


