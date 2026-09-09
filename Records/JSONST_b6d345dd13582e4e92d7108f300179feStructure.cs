using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Boolean
public class JSONST_b6d345dd13582e4e92d7108f300179feStructure : AbstractRESTStructure<ST_b6d345dd13582e4e92d7108f300179feStructure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public bool? AttrValue;

public JSONST_b6d345dd13582e4e92d7108f300179feStructure() { }

public JSONST_b6d345dd13582e4e92d7108f300179feStructure (ST_b6d345dd13582e4e92d7108f300179feStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, false);
  } else {
AttrValue = (bool?) s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure, ST_b6d345dd13582e4e92d7108f300179feStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure s) => ToStructure(s, config);
}
public static ST_b6d345dd13582e4e92d7108f300179feStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure obj, IBehaviorsConfiguration config) { 
  ST_b6d345dd13582e4e92d7108f300179feStructure s = new ST_b6d345dd13582e4e92d7108f300179feStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? false : obj.AttrValue.Value;
  }
  return s;
}

public static Func<ST_b6d345dd13582e4e92d7108f300179feStructure, ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b6d345dd13582e4e92d7108f300179feStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure FromStructure(ST_b6d345dd13582e4e92d7108f300179feStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure(s, config);
}

}


