using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Region_TextRegionRecord
public class JSONRC_fd17f3b5298bdff8f863d6f0335db07c : AbstractRESTStructure<RC_fd17f3b5298bdff8f863d6f0335db07c> {
[JsonProperty("Region_Text")]
[JsonPropertyName("Region_Text")]
public string AttrRegion_Text;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_fd17f3b5298bdff8f863d6f0335db07c() { }

public JSONRC_fd17f3b5298bdff8f863d6f0335db07c (RC_fd17f3b5298bdff8f863d6f0335db07c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegion_Text = ConvertToRestWithoutDefaults(s.ssRegion_Text, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRegion_Text = s.ssRegion_Text;
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fd17f3b5298bdff8f863d6f0335db07c, RC_fd17f3b5298bdff8f863d6f0335db07c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fd17f3b5298bdff8f863d6f0335db07c s) => ToStructure(s, config);
}
public static RC_fd17f3b5298bdff8f863d6f0335db07c ToStructure(ssConectaProveedores.RestRecords.JSONRC_fd17f3b5298bdff8f863d6f0335db07c obj, IBehaviorsConfiguration config) { 
  RC_fd17f3b5298bdff8f863d6f0335db07c s = new RC_fd17f3b5298bdff8f863d6f0335db07c();
  if(obj != null) {
  s.ssRegion_Text = obj.AttrRegion_Text == null ? "" : obj.AttrRegion_Text;
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_fd17f3b5298bdff8f863d6f0335db07c, ssConectaProveedores.RestRecords.JSONRC_fd17f3b5298bdff8f863d6f0335db07c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fd17f3b5298bdff8f863d6f0335db07c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fd17f3b5298bdff8f863d6f0335db07c FromStructure(RC_fd17f3b5298bdff8f863d6f0335db07c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fd17f3b5298bdff8f863d6f0335db07c(s, config);
}

}


