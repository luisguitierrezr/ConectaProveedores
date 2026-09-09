using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextValueRecord
public class JSONRC_99fa4277b2264c97bde8f4525bdc92e0 : AbstractRESTStructure<RC_99fa4277b2264c97bde8f4525bdc92e0> {
[JsonProperty("Text")]
[JsonPropertyName("Text")]
public string AttrText;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public int? AttrValue;

public JSONRC_99fa4277b2264c97bde8f4525bdc92e0() { }

public JSONRC_99fa4277b2264c97bde8f4525bdc92e0 (RC_99fa4277b2264c97bde8f4525bdc92e0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0);
  } else {
AttrText = s.ssText;
AttrValue = (int?) s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_99fa4277b2264c97bde8f4525bdc92e0, RC_99fa4277b2264c97bde8f4525bdc92e0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_99fa4277b2264c97bde8f4525bdc92e0 s) => ToStructure(s, config);
}
public static RC_99fa4277b2264c97bde8f4525bdc92e0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_99fa4277b2264c97bde8f4525bdc92e0 obj, IBehaviorsConfiguration config) { 
  RC_99fa4277b2264c97bde8f4525bdc92e0 s = new RC_99fa4277b2264c97bde8f4525bdc92e0();
  if(obj != null) {
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  s.ssValue = obj.AttrValue == null ? 0 : obj.AttrValue.Value;
  }
  return s;
}

public static Func<RC_99fa4277b2264c97bde8f4525bdc92e0, ssConectaProveedores.RestRecords.JSONRC_99fa4277b2264c97bde8f4525bdc92e0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_99fa4277b2264c97bde8f4525bdc92e0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_99fa4277b2264c97bde8f4525bdc92e0 FromStructure(RC_99fa4277b2264c97bde8f4525bdc92e0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_99fa4277b2264c97bde8f4525bdc92e0(s, config);
}

}


