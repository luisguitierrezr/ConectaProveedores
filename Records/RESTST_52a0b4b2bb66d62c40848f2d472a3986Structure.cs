using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LongIntegerIdentifier
public class RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure : AbstractRESTStructure<ST_52a0b4b2bb66d62c40848f2d472a3986Structure> {
[JsonProperty("Value")]
public long? AttrValue;

public RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure() { }

public RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure (ST_52a0b4b2bb66d62c40848f2d472a3986Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, Convert.ToInt64(0));
  } else {
AttrValue = (long?) s.ssValue;
  }
}

public static ST_52a0b4b2bb66d62c40848f2d472a3986Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure obj) { 
  ST_52a0b4b2bb66d62c40848f2d472a3986Structure s = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? Convert.ToInt64(0) : obj.AttrValue.Value;
  }
  return s;
}

public static Func<ST_52a0b4b2bb66d62c40848f2d472a3986Structure, ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_52a0b4b2bb66d62c40848f2d472a3986Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure FromStructure(ST_52a0b4b2bb66d62c40848f2d472a3986Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure(s, config);
}

}


