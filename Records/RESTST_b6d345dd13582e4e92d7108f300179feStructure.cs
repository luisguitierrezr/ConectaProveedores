using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Boolean
public class RESTST_b6d345dd13582e4e92d7108f300179feStructure : AbstractRESTStructure<ST_b6d345dd13582e4e92d7108f300179feStructure> {
[JsonProperty("Value")]
public bool? AttrValue;

public RESTST_b6d345dd13582e4e92d7108f300179feStructure() { }

public RESTST_b6d345dd13582e4e92d7108f300179feStructure (ST_b6d345dd13582e4e92d7108f300179feStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, false);
  } else {
AttrValue = (bool?) s.ssValue;
  }
}

public static ST_b6d345dd13582e4e92d7108f300179feStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure obj) { 
  ST_b6d345dd13582e4e92d7108f300179feStructure s = new ST_b6d345dd13582e4e92d7108f300179feStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? false : obj.AttrValue.Value;
  }
  return s;
}

public static Func<ST_b6d345dd13582e4e92d7108f300179feStructure, ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b6d345dd13582e4e92d7108f300179feStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure FromStructure(ST_b6d345dd13582e4e92d7108f300179feStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure(s, config);
}

}


