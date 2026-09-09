using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LegendPositionRecord
public class JSONRC_054139ee1b4e118a0de0bda9edde9b3e : AbstractRESTStructure<RC_054139ee1b4e118a0de0bda9edde9b3e> {
[JsonProperty("LegendPosition")]
[JsonPropertyName("LegendPosition")]
public ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord AttrLegendPosition;

public JSONRC_054139ee1b4e118a0de0bda9edde9b3e() { }

public JSONRC_054139ee1b4e118a0de0bda9edde9b3e (RC_054139ee1b4e118a0de0bda9edde9b3e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLegendPosition = ConvertToRestWithoutDefaults(s.ssENLegendPosition, new EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord.FromStructure, config);
  } else {
AttrLegendPosition = ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord.FromStructure(s.ssENLegendPosition, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_054139ee1b4e118a0de0bda9edde9b3e, RC_054139ee1b4e118a0de0bda9edde9b3e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_054139ee1b4e118a0de0bda9edde9b3e s) => ToStructure(s, config);
}
public static RC_054139ee1b4e118a0de0bda9edde9b3e ToStructure(ssConectaProveedores.RestRecords.JSONRC_054139ee1b4e118a0de0bda9edde9b3e obj, IBehaviorsConfiguration config) { 
  RC_054139ee1b4e118a0de0bda9edde9b3e s = new RC_054139ee1b4e118a0de0bda9edde9b3e();
  if(obj != null) {
  s.ssENLegendPosition = ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord.ToStructure(obj.AttrLegendPosition, config);
  }
  return s;
}

public static Func<RC_054139ee1b4e118a0de0bda9edde9b3e, ssConectaProveedores.RestRecords.JSONRC_054139ee1b4e118a0de0bda9edde9b3e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_054139ee1b4e118a0de0bda9edde9b3e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_054139ee1b4e118a0de0bda9edde9b3e FromStructure(RC_054139ee1b4e118a0de0bda9edde9b3e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_054139ee1b4e118a0de0bda9edde9b3e(s, config);
}

}


