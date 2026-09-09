using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Integer
public class JSONST_e4103a4d41689de0feae1065888fc2e0Structure : AbstractRESTStructure<ST_e4103a4d41689de0feae1065888fc2e0Structure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public int? AttrValue;

public JSONST_e4103a4d41689de0feae1065888fc2e0Structure() { }

public JSONST_e4103a4d41689de0feae1065888fc2e0Structure (ST_e4103a4d41689de0feae1065888fc2e0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0);
  } else {
AttrValue = (int?) s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure, ST_e4103a4d41689de0feae1065888fc2e0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure s) => ToStructure(s, config);
}
public static ST_e4103a4d41689de0feae1065888fc2e0Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure obj, IBehaviorsConfiguration config) { 
  ST_e4103a4d41689de0feae1065888fc2e0Structure s = new ST_e4103a4d41689de0feae1065888fc2e0Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? 0 : obj.AttrValue.Value;
  }
  return s;
}

public static Func<ST_e4103a4d41689de0feae1065888fc2e0Structure, ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e4103a4d41689de0feae1065888fc2e0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure FromStructure(ST_e4103a4d41689de0feae1065888fc2e0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure(s, config);
}

}


