using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TabsOptionalConfigs
public class RESTST_e3f9af4171d5e4a41700770295d05c77Structure : AbstractRESTStructure<ST_e3f9af4171d5e4a41700770295d05c77Structure> {
[JsonProperty("ContentAutoHeight")]
public bool? AttrContentAutoHeight;

[JsonProperty("JustifyHeaders")]
public bool? AttrJustifyHeaders;

public RESTST_e3f9af4171d5e4a41700770295d05c77Structure() { }

public RESTST_e3f9af4171d5e4a41700770295d05c77Structure (ST_e3f9af4171d5e4a41700770295d05c77Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContentAutoHeight = ConvertToRestWithoutDefaults(s.ssContentAutoHeight, false);
AttrJustifyHeaders = ConvertToRestWithoutDefaults(s.ssJustifyHeaders, false);
  } else {
AttrContentAutoHeight = (bool?) s.ssContentAutoHeight;
AttrJustifyHeaders = (bool?) s.ssJustifyHeaders;
  }
}

public static ST_e3f9af4171d5e4a41700770295d05c77Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_e3f9af4171d5e4a41700770295d05c77Structure obj) { 
  ST_e3f9af4171d5e4a41700770295d05c77Structure s = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
  if(obj != null) {
  s.ssContentAutoHeight = obj.AttrContentAutoHeight == null ? false : obj.AttrContentAutoHeight.Value;
  s.ssJustifyHeaders = obj.AttrJustifyHeaders == null ? false : obj.AttrJustifyHeaders.Value;
  }
  return s;
}

public static Func<ST_e3f9af4171d5e4a41700770295d05c77Structure, ssConectaProveedores.RestRecords.RESTST_e3f9af4171d5e4a41700770295d05c77Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e3f9af4171d5e4a41700770295d05c77Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_e3f9af4171d5e4a41700770295d05c77Structure FromStructure(ST_e3f9af4171d5e4a41700770295d05c77Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_e3f9af4171d5e4a41700770295d05c77Structure(s, config);
}

}


