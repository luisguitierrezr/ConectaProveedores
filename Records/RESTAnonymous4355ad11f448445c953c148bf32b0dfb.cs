using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RETURN2Record
public class RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 : AbstractRESTStructure<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> {
[JsonProperty("RETURN2")]
public ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure AttrRETURN2;

public RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3() { }

public RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRETURN2 = ConvertToRestWithoutDefaults(s.ssSTRETURN2, new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure(), ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure.FromStructure, config);
  } else {
AttrRETURN2 = ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure.FromStructure(s.ssSTRETURN2, config);
  }
}

public static RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 obj) { 
  RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s = new RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3();
  if(obj != null) {
  s.ssSTRETURN2 = ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure.ToStructure(obj.AttrRETURN2);
  }
  return s;
}

public static Func<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3, ssConectaProveedores.RestRecords.RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 FromStructure(RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3(s, config);
}

}


