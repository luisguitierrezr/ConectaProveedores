using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TabsOptionalConfigs
public class JSONST_e3f9af4171d5e4a41700770295d05c77Structure : AbstractRESTStructure<ST_e3f9af4171d5e4a41700770295d05c77Structure> {
[JsonProperty("ContentAutoHeight")]
[JsonPropertyName("ContentAutoHeight")]
public bool? AttrContentAutoHeight;

[JsonProperty("JustifyHeaders")]
[JsonPropertyName("JustifyHeaders")]
public bool? AttrJustifyHeaders;

public JSONST_e3f9af4171d5e4a41700770295d05c77Structure() { }

public JSONST_e3f9af4171d5e4a41700770295d05c77Structure (ST_e3f9af4171d5e4a41700770295d05c77Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContentAutoHeight = ConvertToRestWithoutDefaults(s.ssContentAutoHeight, false);
AttrJustifyHeaders = ConvertToRestWithoutDefaults(s.ssJustifyHeaders, false);
  } else {
AttrContentAutoHeight = (bool?) s.ssContentAutoHeight;
AttrJustifyHeaders = (bool?) s.ssJustifyHeaders;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure, ST_e3f9af4171d5e4a41700770295d05c77Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure s) => ToStructure(s, config);
}
public static ST_e3f9af4171d5e4a41700770295d05c77Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure obj, IBehaviorsConfiguration config) { 
  ST_e3f9af4171d5e4a41700770295d05c77Structure s = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
  if(obj != null) {
  s.ssContentAutoHeight = obj.AttrContentAutoHeight == null ? false : obj.AttrContentAutoHeight.Value;
  s.ssJustifyHeaders = obj.AttrJustifyHeaders == null ? false : obj.AttrJustifyHeaders.Value;
  }
  return s;
}

public static Func<ST_e3f9af4171d5e4a41700770295d05c77Structure, ssConectaProveedores.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e3f9af4171d5e4a41700770295d05c77Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure FromStructure(ST_e3f9af4171d5e4a41700770295d05c77Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e3f9af4171d5e4a41700770295d05c77Structure(s, config);
}

}


