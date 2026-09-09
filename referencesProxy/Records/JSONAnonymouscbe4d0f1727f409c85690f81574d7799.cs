using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Users3Record
public class JSONRC_01936c4800922decb42c6cd59b069a6c : AbstractRESTStructure<RC_01936c4800922decb42c6cd59b069a6c> {
[JsonProperty("Users")]
[JsonPropertyName("Users")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure AttrUsers3;

public JSONRC_01936c4800922decb42c6cd59b069a6c() { }

public JSONRC_01936c4800922decb42c6cd59b069a6c (RC_01936c4800922decb42c6cd59b069a6c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUsers3 = ConvertToRestWithoutDefaults(s.ssSTUsers3, new ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure.FromStructure, config);
  } else {
AttrUsers3 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure.FromStructure(s.ssSTUsers3, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_01936c4800922decb42c6cd59b069a6c, RC_01936c4800922decb42c6cd59b069a6c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_01936c4800922decb42c6cd59b069a6c s) => ToStructure(s, config);
}
public static RC_01936c4800922decb42c6cd59b069a6c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_01936c4800922decb42c6cd59b069a6c obj, IBehaviorsConfiguration config) { 
  RC_01936c4800922decb42c6cd59b069a6c s = new RC_01936c4800922decb42c6cd59b069a6c();
  if(obj != null) {
  s.ssSTUsers3 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure.ToStructure(obj.AttrUsers3, config);
  }
  return s;
}

public static Func<RC_01936c4800922decb42c6cd59b069a6c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_01936c4800922decb42c6cd59b069a6c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_01936c4800922decb42c6cd59b069a6c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_01936c4800922decb42c6cd59b069a6c FromStructure(RC_01936c4800922decb42c6cd59b069a6c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_01936c4800922decb42c6cd59b069a6c(s, config);
}

}


