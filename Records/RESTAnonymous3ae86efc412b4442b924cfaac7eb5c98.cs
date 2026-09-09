using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditStruc4ListRecord
public class RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0 : AbstractRESTStructure<RC_11a1c2c6093e72d7b098f7d9d4ea49b0> {
[JsonProperty("AuditStruc4List")]
public ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure AttrAuditStruc4List;

public RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0() { }

public RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0 (RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAuditStruc4List = ConvertToRestWithoutDefaults(s.ssSTAuditStruc4List, new ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure(), ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.FromStructure, config);
  } else {
AttrAuditStruc4List = ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.FromStructure(s.ssSTAuditStruc4List, config);
  }
}

public static RC_11a1c2c6093e72d7b098f7d9d4ea49b0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0 obj) { 
  RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s = new RC_11a1c2c6093e72d7b098f7d9d4ea49b0();
  if(obj != null) {
  s.ssSTAuditStruc4List = ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.ToStructure(obj.AttrAuditStruc4List);
  }
  return s;
}

public static Func<RC_11a1c2c6093e72d7b098f7d9d4ea49b0, ssConectaProveedores.RestRecords.RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0 FromStructure(RC_11a1c2c6093e72d7b098f7d9d4ea49b0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_11a1c2c6093e72d7b098f7d9d4ea49b0(s, config);
}

}


