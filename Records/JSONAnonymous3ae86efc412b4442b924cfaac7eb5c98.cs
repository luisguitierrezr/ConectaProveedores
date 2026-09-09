using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditStruc4ListRecord
public class JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0 : AbstractRESTStructure<RC_11a1c2c6093e72d7b098f7d9d4ea49b0> {
[JsonProperty("AuditStruc4List")]
[JsonPropertyName("AuditStruc4List")]
public ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure AttrAuditStruc4List;

public JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0() { }

public JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0 (RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAuditStruc4List = ConvertToRestWithoutDefaults(s.ssSTAuditStruc4List, new ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure(), ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.FromStructure, config);
  } else {
AttrAuditStruc4List = ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.FromStructure(s.ssSTAuditStruc4List, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0, RC_11a1c2c6093e72d7b098f7d9d4ea49b0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0 s) => ToStructure(s, config);
}
public static RC_11a1c2c6093e72d7b098f7d9d4ea49b0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0 obj, IBehaviorsConfiguration config) { 
  RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s = new RC_11a1c2c6093e72d7b098f7d9d4ea49b0();
  if(obj != null) {
  s.ssSTAuditStruc4List = ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.ToStructure(obj.AttrAuditStruc4List, config);
  }
  return s;
}

public static Func<RC_11a1c2c6093e72d7b098f7d9d4ea49b0, ssConectaProveedores.RestRecords.JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0 FromStructure(RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_11a1c2c6093e72d7b098f7d9d4ea49b0(s, config);
}

}


