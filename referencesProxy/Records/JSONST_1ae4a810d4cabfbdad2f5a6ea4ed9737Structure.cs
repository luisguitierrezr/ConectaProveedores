using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SeriesStylingOptionalConfigs
public class JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure : AbstractRESTStructure<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> {
[JsonProperty("ShowInLegend")]
[JsonPropertyName("ShowInLegend")]
public bool? AttrShowInLegend;

[JsonProperty("xAxisId")]
[JsonPropertyName("xAxisId")]
public string AttrxAxisId;

[JsonProperty("yAxisId")]
[JsonPropertyName("yAxisId")]
public string AttryAxisId;

public JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure() { }

public JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShowInLegend = ConvertToRestWithoutDefaults(s.ssShowInLegend, true);
AttrxAxisId = ConvertToRestWithoutDefaults(s.ssxAxisId, RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_xAxisId);
AttryAxisId = ConvertToRestWithoutDefaults(s.ssyAxisId, RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_yAxisId);
  } else {
AttrShowInLegend = (bool?) s.ssShowInLegend;
AttrxAxisId = s.ssxAxisId;
AttryAxisId = s.ssyAxisId;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure, ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s) => ToStructure(s, config);
}
public static ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure obj, IBehaviorsConfiguration config) { 
  ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s = new ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure();
  if(obj != null) {
  s.ssShowInLegend = obj.AttrShowInLegend == null ? true : obj.AttrShowInLegend.Value;
  s.ssxAxisId = obj.AttrxAxisId == null ? RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_xAxisId : obj.AttrxAxisId;
  s.ssyAxisId = obj.AttryAxisId == null ? RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_yAxisId : obj.AttryAxisId;
  }
  return s;
}

public static Func<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure FromStructure(ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure(s, config);
}

}


