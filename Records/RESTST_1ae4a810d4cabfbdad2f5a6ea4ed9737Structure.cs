using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStylingOptionalConfigs
public class RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure : AbstractRESTStructure<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> {
[JsonProperty("ShowInLegend")]
public bool? AttrShowInLegend;

[JsonProperty("xAxisId")]
public string AttrxAxisId;

[JsonProperty("yAxisId")]
public string AttryAxisId;

public RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure() { }

public RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s, IBehaviorsConfiguration config) {
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

public static ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure obj) { 
  ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s = new ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure();
  if(obj != null) {
  s.ssShowInLegend = obj.AttrShowInLegend == null ? true : obj.AttrShowInLegend.Value;
  s.ssxAxisId = obj.AttrxAxisId == null ? RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_xAxisId : obj.AttrxAxisId;
  s.ssyAxisId = obj.AttryAxisId == null ? RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_yAxisId : obj.AttryAxisId;
  }
  return s;
}

public static Func<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure, ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure FromStructure(ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure(s, config);
}

}


