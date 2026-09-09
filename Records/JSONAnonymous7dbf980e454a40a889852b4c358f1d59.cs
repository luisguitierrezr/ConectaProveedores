using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CounterRecord
public class JSONRC_d93780ae9c35b458438c31065b3f06ba : AbstractRESTStructure<RC_d93780ae9c35b458438c31065b3f06ba> {
[JsonProperty("Counter")]
[JsonPropertyName("Counter")]
public int? AttrCounter;

public JSONRC_d93780ae9c35b458438c31065b3f06ba() { }

public JSONRC_d93780ae9c35b458438c31065b3f06ba (RC_d93780ae9c35b458438c31065b3f06ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCounter = ConvertToRestWithoutDefaults(s.ssCounter, 0);
  } else {
AttrCounter = (int?) s.ssCounter;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d93780ae9c35b458438c31065b3f06ba, RC_d93780ae9c35b458438c31065b3f06ba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d93780ae9c35b458438c31065b3f06ba s) => ToStructure(s, config);
}
public static RC_d93780ae9c35b458438c31065b3f06ba ToStructure(ssConectaProveedores.RestRecords.JSONRC_d93780ae9c35b458438c31065b3f06ba obj, IBehaviorsConfiguration config) { 
  RC_d93780ae9c35b458438c31065b3f06ba s = new RC_d93780ae9c35b458438c31065b3f06ba();
  if(obj != null) {
  s.ssCounter = obj.AttrCounter == null ? 0 : obj.AttrCounter.Value;
  }
  return s;
}

public static Func<RC_d93780ae9c35b458438c31065b3f06ba, ssConectaProveedores.RestRecords.JSONRC_d93780ae9c35b458438c31065b3f06ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d93780ae9c35b458438c31065b3f06ba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d93780ae9c35b458438c31065b3f06ba FromStructure(RC_d93780ae9c35b458438c31065b3f06ba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d93780ae9c35b458438c31065b3f06ba(s, config);
}

}


