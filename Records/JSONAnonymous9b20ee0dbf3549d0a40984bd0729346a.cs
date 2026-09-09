using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextValueRecord
public class JSONRC_ee67c405f78e15f46603b032a29fae74 : AbstractRESTStructure<RC_ee67c405f78e15f46603b032a29fae74> {
[JsonProperty("Text")]
[JsonPropertyName("Text")]
public string AttrText;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public decimal? AttrValue;

public JSONRC_ee67c405f78e15f46603b032a29fae74() { }

public JSONRC_ee67c405f78e15f46603b032a29fae74 (RC_ee67c405f78e15f46603b032a29fae74 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0.0M);
  } else {
AttrText = s.ssText;
AttrValue = (decimal?) s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ee67c405f78e15f46603b032a29fae74, RC_ee67c405f78e15f46603b032a29fae74> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ee67c405f78e15f46603b032a29fae74 s) => ToStructure(s, config);
}
public static RC_ee67c405f78e15f46603b032a29fae74 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ee67c405f78e15f46603b032a29fae74 obj, IBehaviorsConfiguration config) { 
  RC_ee67c405f78e15f46603b032a29fae74 s = new RC_ee67c405f78e15f46603b032a29fae74();
  if(obj != null) {
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  s.ssValue = obj.AttrValue == null ? 0.0M : obj.AttrValue.Value;
  }
  return s;
}

public static Func<RC_ee67c405f78e15f46603b032a29fae74, ssConectaProveedores.RestRecords.JSONRC_ee67c405f78e15f46603b032a29fae74> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ee67c405f78e15f46603b032a29fae74 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ee67c405f78e15f46603b032a29fae74 FromStructure(RC_ee67c405f78e15f46603b032a29fae74 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ee67c405f78e15f46603b032a29fae74(s, config);
}

}


