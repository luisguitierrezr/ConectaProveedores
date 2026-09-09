using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Users3Record
public class RESTRC_01936c4800922decb42c6cd59b069a6c : AbstractRESTStructure<RC_01936c4800922decb42c6cd59b069a6c> {
[JsonProperty("Users")]
public ssConectaProveedores.RestRecords.RESTST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure AttrUsers3;

public RESTRC_01936c4800922decb42c6cd59b069a6c() { }

public RESTRC_01936c4800922decb42c6cd59b069a6c (RC_01936c4800922decb42c6cd59b069a6c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUsers3 = ConvertToRestWithoutDefaults(s.ssSTUsers3, new ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure(), ssConectaProveedores.RestRecords.RESTST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure.FromStructure, config);
  } else {
AttrUsers3 = ssConectaProveedores.RestRecords.RESTST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure.FromStructure(s.ssSTUsers3, config);
  }
}

public static RC_01936c4800922decb42c6cd59b069a6c ToStructure(ssConectaProveedores.RestRecords.RESTRC_01936c4800922decb42c6cd59b069a6c obj) { 
  RC_01936c4800922decb42c6cd59b069a6c s = new RC_01936c4800922decb42c6cd59b069a6c();
  if(obj != null) {
  s.ssSTUsers3 = ssConectaProveedores.RestRecords.RESTST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure.ToStructure(obj.AttrUsers3);
  }
  return s;
}

public static Func<RC_01936c4800922decb42c6cd59b069a6c, ssConectaProveedores.RestRecords.RESTRC_01936c4800922decb42c6cd59b069a6c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_01936c4800922decb42c6cd59b069a6c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_01936c4800922decb42c6cd59b069a6c FromStructure(RC_01936c4800922decb42c6cd59b069a6c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_01936c4800922decb42c6cd59b069a6c(s, config);
}

}


