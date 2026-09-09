using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// KeyValue
public class JSONST_714c559a98f1e1080cbf60de3228e843Structure : AbstractRESTStructure<ST_714c559a98f1e1080cbf60de3228e843Structure> {
[JsonProperty("Key")]
[JsonPropertyName("Key")]
public int? AttrKey;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONST_714c559a98f1e1080cbf60de3228e843Structure() { }

public JSONST_714c559a98f1e1080cbf60de3228e843Structure (ST_714c559a98f1e1080cbf60de3228e843Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, 0);
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrKey = (int?) s.ssKey;
AttrValue = s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure, ST_714c559a98f1e1080cbf60de3228e843Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure s) => ToStructure(s, config);
}
public static ST_714c559a98f1e1080cbf60de3228e843Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure obj, IBehaviorsConfiguration config) { 
  ST_714c559a98f1e1080cbf60de3228e843Structure s = new ST_714c559a98f1e1080cbf60de3228e843Structure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? 0 : obj.AttrKey.Value;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_714c559a98f1e1080cbf60de3228e843Structure, ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_714c559a98f1e1080cbf60de3228e843Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure FromStructure(ST_714c559a98f1e1080cbf60de3228e843Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure(s, config);
}

}


