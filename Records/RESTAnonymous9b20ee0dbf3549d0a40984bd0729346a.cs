using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextValueRecord
public class RESTRC_ee67c405f78e15f46603b032a29fae74 : AbstractRESTStructure<RC_ee67c405f78e15f46603b032a29fae74> {
[JsonProperty("Text")]
public string AttrText;

[JsonProperty("Value")]
public decimal? AttrValue;

public RESTRC_ee67c405f78e15f46603b032a29fae74() { }

public RESTRC_ee67c405f78e15f46603b032a29fae74 (RC_ee67c405f78e15f46603b032a29fae74 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0.0M);
  } else {
AttrText = s.ssText;
AttrValue = (decimal?) s.ssValue;
  }
}

public static RC_ee67c405f78e15f46603b032a29fae74 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ee67c405f78e15f46603b032a29fae74 obj) { 
  RC_ee67c405f78e15f46603b032a29fae74 s = new RC_ee67c405f78e15f46603b032a29fae74();
  if(obj != null) {
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  s.ssValue = obj.AttrValue == null ? 0.0M : obj.AttrValue.Value;
  }
  return s;
}

public static Func<RC_ee67c405f78e15f46603b032a29fae74, ssConectaProveedores.RestRecords.RESTRC_ee67c405f78e15f46603b032a29fae74> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ee67c405f78e15f46603b032a29fae74 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ee67c405f78e15f46603b032a29fae74 FromStructure(RC_ee67c405f78e15f46603b032a29fae74 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ee67c405f78e15f46603b032a29fae74(s, config);
}

}


