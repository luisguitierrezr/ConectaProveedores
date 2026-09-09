using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Region_TextRegionRecord
public class RESTRC_fd17f3b5298bdff8f863d6f0335db07c : AbstractRESTStructure<RC_fd17f3b5298bdff8f863d6f0335db07c> {
[JsonProperty("Region_Text")]
public string AttrRegion_Text;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_fd17f3b5298bdff8f863d6f0335db07c() { }

public RESTRC_fd17f3b5298bdff8f863d6f0335db07c (RC_fd17f3b5298bdff8f863d6f0335db07c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegion_Text = ConvertToRestWithoutDefaults(s.ssRegion_Text, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRegion_Text = s.ssRegion_Text;
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_fd17f3b5298bdff8f863d6f0335db07c ToStructure(ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c obj) { 
  RC_fd17f3b5298bdff8f863d6f0335db07c s = new RC_fd17f3b5298bdff8f863d6f0335db07c();
  if(obj != null) {
  s.ssRegion_Text = obj.AttrRegion_Text == null ? "" : obj.AttrRegion_Text;
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_fd17f3b5298bdff8f863d6f0335db07c, ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fd17f3b5298bdff8f863d6f0335db07c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c FromStructure(RC_fd17f3b5298bdff8f863d6f0335db07c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fd17f3b5298bdff8f863d6f0335db07c(s, config);
}

}


