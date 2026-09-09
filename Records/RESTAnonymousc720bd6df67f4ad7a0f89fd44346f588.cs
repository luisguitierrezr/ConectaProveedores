using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IntegerRecord
public class RESTRC_5f047dfa5f07a0c48614f5e378a26f43 : AbstractRESTStructure<RC_5f047dfa5f07a0c48614f5e378a26f43> {
[JsonProperty("Integer")]
public ssConectaProveedores.RestRecords.RESTST_e4103a4d41689de0feae1065888fc2e0Structure AttrInteger;

public RESTRC_5f047dfa5f07a0c48614f5e378a26f43() { }

public RESTRC_5f047dfa5f07a0c48614f5e378a26f43 (RC_5f047dfa5f07a0c48614f5e378a26f43 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInteger = ConvertToRestWithoutDefaults(s.ssSTInteger, new ST_e4103a4d41689de0feae1065888fc2e0Structure(), ssConectaProveedores.RestRecords.RESTST_e4103a4d41689de0feae1065888fc2e0Structure.FromStructure, config);
  } else {
AttrInteger = ssConectaProveedores.RestRecords.RESTST_e4103a4d41689de0feae1065888fc2e0Structure.FromStructure(s.ssSTInteger, config);
  }
}

public static RC_5f047dfa5f07a0c48614f5e378a26f43 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5f047dfa5f07a0c48614f5e378a26f43 obj) { 
  RC_5f047dfa5f07a0c48614f5e378a26f43 s = new RC_5f047dfa5f07a0c48614f5e378a26f43();
  if(obj != null) {
  s.ssSTInteger = ssConectaProveedores.RestRecords.RESTST_e4103a4d41689de0feae1065888fc2e0Structure.ToStructure(obj.AttrInteger);
  }
  return s;
}

public static Func<RC_5f047dfa5f07a0c48614f5e378a26f43, ssConectaProveedores.RestRecords.RESTRC_5f047dfa5f07a0c48614f5e378a26f43> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5f047dfa5f07a0c48614f5e378a26f43 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5f047dfa5f07a0c48614f5e378a26f43 FromStructure(RC_5f047dfa5f07a0c48614f5e378a26f43 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5f047dfa5f07a0c48614f5e378a26f43(s, config);
}

}


