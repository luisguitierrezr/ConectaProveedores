using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileRecord
public class JSONRC_73d8126c722e2b4dd662dab2bf1a72d1 : AbstractRESTStructure<RC_73d8126c722e2b4dd662dab2bf1a72d1> {
[JsonProperty("OrderRequestFile")]
[JsonPropertyName("OrderRequestFile")]
public ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

public JSONRC_73d8126c722e2b4dd662dab2bf1a72d1() { }

public JSONRC_73d8126c722e2b4dd662dab2bf1a72d1 (RC_73d8126c722e2b4dd662dab2bf1a72d1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_73d8126c722e2b4dd662dab2bf1a72d1, RC_73d8126c722e2b4dd662dab2bf1a72d1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_73d8126c722e2b4dd662dab2bf1a72d1 s) => ToStructure(s, config);
}
public static RC_73d8126c722e2b4dd662dab2bf1a72d1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_73d8126c722e2b4dd662dab2bf1a72d1 obj, IBehaviorsConfiguration config) { 
  RC_73d8126c722e2b4dd662dab2bf1a72d1 s = new RC_73d8126c722e2b4dd662dab2bf1a72d1();
  if(obj != null) {
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile, config);
  }
  return s;
}

public static Func<RC_73d8126c722e2b4dd662dab2bf1a72d1, ssConectaProveedores.RestRecords.JSONRC_73d8126c722e2b4dd662dab2bf1a72d1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_73d8126c722e2b4dd662dab2bf1a72d1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_73d8126c722e2b4dd662dab2bf1a72d1 FromStructure(RC_73d8126c722e2b4dd662dab2bf1a72d1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_73d8126c722e2b4dd662dab2bf1a72d1(s, config);
}

}


