using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IntegerRecord
public class JSONRC_5f047dfa5f07a0c48614f5e378a26f43 : AbstractRESTStructure<RC_5f047dfa5f07a0c48614f5e378a26f43> {
[JsonProperty("Integer")]
[JsonPropertyName("Integer")]
public ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure AttrInteger;

public JSONRC_5f047dfa5f07a0c48614f5e378a26f43() { }

public JSONRC_5f047dfa5f07a0c48614f5e378a26f43 (RC_5f047dfa5f07a0c48614f5e378a26f43 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInteger = ConvertToRestWithoutDefaults(s.ssSTInteger, new ST_e4103a4d41689de0feae1065888fc2e0Structure(), ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure.FromStructure, config);
  } else {
AttrInteger = ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure.FromStructure(s.ssSTInteger, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5f047dfa5f07a0c48614f5e378a26f43, RC_5f047dfa5f07a0c48614f5e378a26f43> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5f047dfa5f07a0c48614f5e378a26f43 s) => ToStructure(s, config);
}
public static RC_5f047dfa5f07a0c48614f5e378a26f43 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5f047dfa5f07a0c48614f5e378a26f43 obj, IBehaviorsConfiguration config) { 
  RC_5f047dfa5f07a0c48614f5e378a26f43 s = new RC_5f047dfa5f07a0c48614f5e378a26f43();
  if(obj != null) {
  s.ssSTInteger = ssConectaProveedores.RestRecords.JSONST_e4103a4d41689de0feae1065888fc2e0Structure.ToStructure(obj.AttrInteger, config);
  }
  return s;
}

public static Func<RC_5f047dfa5f07a0c48614f5e378a26f43, ssConectaProveedores.RestRecords.JSONRC_5f047dfa5f07a0c48614f5e378a26f43> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5f047dfa5f07a0c48614f5e378a26f43 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5f047dfa5f07a0c48614f5e378a26f43 FromStructure(RC_5f047dfa5f07a0c48614f5e378a26f43 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5f047dfa5f07a0c48614f5e378a26f43(s, config);
}

}


