using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// RETURN2Record
public class JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 : AbstractRESTStructure<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> {
[JsonProperty("RETURN2")]
[JsonPropertyName("RETURN2")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure AttrRETURN2;

public JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3() { }

public JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRETURN2 = ConvertToRestWithoutDefaults(s.ssSTRETURN2, new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure.FromStructure, config);
  } else {
AttrRETURN2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure.FromStructure(s.ssSTRETURN2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3, RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s) => ToStructure(s, config);
}
public static RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 obj, IBehaviorsConfiguration config) { 
  RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s = new RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3();
  if(obj != null) {
  s.ssSTRETURN2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure.ToStructure(obj.AttrRETURN2, config);
  }
  return s;
}

public static Func<RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 FromStructure(RC_a4bd5e5c56d7a3f51c5c8f8e396a29c3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a4bd5e5c56d7a3f51c5c8f8e396a29c3(s, config);
}

}


