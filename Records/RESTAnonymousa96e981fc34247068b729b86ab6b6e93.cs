using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextValueRecord
public class RESTRC_99fa4277b2264c97bde8f4525bdc92e0 : AbstractRESTStructure<RC_99fa4277b2264c97bde8f4525bdc92e0> {
[JsonProperty("Text")]
public string AttrText;

[JsonProperty("Value")]
public int? AttrValue;

public RESTRC_99fa4277b2264c97bde8f4525bdc92e0() { }

public RESTRC_99fa4277b2264c97bde8f4525bdc92e0 (RC_99fa4277b2264c97bde8f4525bdc92e0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0);
  } else {
AttrText = s.ssText;
AttrValue = (int?) s.ssValue;
  }
}

public static RC_99fa4277b2264c97bde8f4525bdc92e0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0 obj) { 
  RC_99fa4277b2264c97bde8f4525bdc92e0 s = new RC_99fa4277b2264c97bde8f4525bdc92e0();
  if(obj != null) {
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  s.ssValue = obj.AttrValue == null ? 0 : obj.AttrValue.Value;
  }
  return s;
}

public static Func<RC_99fa4277b2264c97bde8f4525bdc92e0, ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_99fa4277b2264c97bde8f4525bdc92e0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0 FromStructure(RC_99fa4277b2264c97bde8f4525bdc92e0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0(s, config);
}

}


