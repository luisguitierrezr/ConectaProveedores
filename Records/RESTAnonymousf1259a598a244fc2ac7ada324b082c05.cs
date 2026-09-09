using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileRecord
public class RESTRC_73d8126c722e2b4dd662dab2bf1a72d1 : AbstractRESTStructure<RC_73d8126c722e2b4dd662dab2bf1a72d1> {
[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

public RESTRC_73d8126c722e2b4dd662dab2bf1a72d1() { }

public RESTRC_73d8126c722e2b4dd662dab2bf1a72d1 (RC_73d8126c722e2b4dd662dab2bf1a72d1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
  }
}

public static RC_73d8126c722e2b4dd662dab2bf1a72d1 ToStructure(ssConectaProveedores.RestRecords.RESTRC_73d8126c722e2b4dd662dab2bf1a72d1 obj) { 
  RC_73d8126c722e2b4dd662dab2bf1a72d1 s = new RC_73d8126c722e2b4dd662dab2bf1a72d1();
  if(obj != null) {
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  }
  return s;
}

public static Func<RC_73d8126c722e2b4dd662dab2bf1a72d1, ssConectaProveedores.RestRecords.RESTRC_73d8126c722e2b4dd662dab2bf1a72d1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_73d8126c722e2b4dd662dab2bf1a72d1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_73d8126c722e2b4dd662dab2bf1a72d1 FromStructure(RC_73d8126c722e2b4dd662dab2bf1a72d1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_73d8126c722e2b4dd662dab2bf1a72d1(s, config);
}

}


