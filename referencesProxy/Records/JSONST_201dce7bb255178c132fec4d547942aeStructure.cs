using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Environment
public class JSONST_201dce7bb255178c132fec4d547942aeStructure : AbstractRESTStructure<ST_201dce7bb255178c132fec4d547942aeStructure> {
[JsonProperty("BaseURL")]
[JsonPropertyName("BaseURL")]
public string AttrBaseURL;

[JsonProperty("Locale")]
[JsonPropertyName("Locale")]
public string AttrLocale;

[JsonProperty("Timezone")]
[JsonPropertyName("Timezone")]
public string AttrTimezone;

public JSONST_201dce7bb255178c132fec4d547942aeStructure() { }

public JSONST_201dce7bb255178c132fec4d547942aeStructure (ST_201dce7bb255178c132fec4d547942aeStructure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure, ST_201dce7bb255178c132fec4d547942aeStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure s) => ToStructure(s, config);
}
public static ST_201dce7bb255178c132fec4d547942aeStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure obj, IBehaviorsConfiguration config) { 
  ST_201dce7bb255178c132fec4d547942aeStructure s = new ST_201dce7bb255178c132fec4d547942aeStructure();
  if(obj != null) {
  s.ssBaseURL = obj.AttrBaseURL == null ? "" : obj.AttrBaseURL;
  s.ssLocale = obj.AttrLocale == null ? "" : obj.AttrLocale;
  s.ssTimezone = obj.AttrTimezone == null ? "" : obj.AttrTimezone;
  }
  return s;
}

public static Func<ST_201dce7bb255178c132fec4d547942aeStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_201dce7bb255178c132fec4d547942aeStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure FromStructure(ST_201dce7bb255178c132fec4d547942aeStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure(s, config);
}

}


