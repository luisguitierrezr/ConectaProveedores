using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ChartLegendOptionalConfigs
public class JSONST_24000c8fde24da45a0d83940a64dbbafStructure : AbstractRESTStructure<ST_24000c8fde24da45a0d83940a64dbbafStructure> {
[JsonProperty("Floating")]
[JsonPropertyName("Floating")]
public bool? AttrFloating;

public JSONST_24000c8fde24da45a0d83940a64dbbafStructure() { }

public JSONST_24000c8fde24da45a0d83940a64dbbafStructure (ST_24000c8fde24da45a0d83940a64dbbafStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFloating = ConvertToRestWithoutDefaults(s.ssFloating, false);
  } else {
AttrFloating = (bool?) s.ssFloating;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure, ST_24000c8fde24da45a0d83940a64dbbafStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure s) => ToStructure(s, config);
}
public static ST_24000c8fde24da45a0d83940a64dbbafStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure obj, IBehaviorsConfiguration config) { 
  ST_24000c8fde24da45a0d83940a64dbbafStructure s = new ST_24000c8fde24da45a0d83940a64dbbafStructure();
  if(obj != null) {
  s.ssFloating = obj.AttrFloating == null ? false : obj.AttrFloating.Value;
  }
  return s;
}

public static Func<ST_24000c8fde24da45a0d83940a64dbbafStructure, ssConectaProveedores.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_24000c8fde24da45a0d83940a64dbbafStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure FromStructure(ST_24000c8fde24da45a0d83940a64dbbafStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure(s, config);
}

}


