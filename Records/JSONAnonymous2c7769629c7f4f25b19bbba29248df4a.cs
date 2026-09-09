using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderFileTypesStructRecord
public class JSONRC_e2e47f886a2f72e5f0dffc8728d14117 : AbstractRESTStructure<RC_e2e47f886a2f72e5f0dffc8728d14117> {
[JsonProperty("OrderFileTypesStruct")]
[JsonPropertyName("OrderFileTypesStruct")]
public ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure AttrOrderFileTypesStruct;

public JSONRC_e2e47f886a2f72e5f0dffc8728d14117() { }

public JSONRC_e2e47f886a2f72e5f0dffc8728d14117 (RC_e2e47f886a2f72e5f0dffc8728d14117 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderFileTypesStruct = ConvertToRestWithoutDefaults(s.ssSTOrderFileTypesStruct, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure.FromStructure, config);
  } else {
AttrOrderFileTypesStruct = ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure.FromStructure(s.ssSTOrderFileTypesStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e2e47f886a2f72e5f0dffc8728d14117, RC_e2e47f886a2f72e5f0dffc8728d14117> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e2e47f886a2f72e5f0dffc8728d14117 s) => ToStructure(s, config);
}
public static RC_e2e47f886a2f72e5f0dffc8728d14117 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e2e47f886a2f72e5f0dffc8728d14117 obj, IBehaviorsConfiguration config) { 
  RC_e2e47f886a2f72e5f0dffc8728d14117 s = new RC_e2e47f886a2f72e5f0dffc8728d14117();
  if(obj != null) {
  s.ssSTOrderFileTypesStruct = ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure.ToStructure(obj.AttrOrderFileTypesStruct, config);
  }
  return s;
}

public static Func<RC_e2e47f886a2f72e5f0dffc8728d14117, ssConectaProveedores.RestRecords.JSONRC_e2e47f886a2f72e5f0dffc8728d14117> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e2e47f886a2f72e5f0dffc8728d14117 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e2e47f886a2f72e5f0dffc8728d14117 FromStructure(RC_e2e47f886a2f72e5f0dffc8728d14117 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e2e47f886a2f72e5f0dffc8728d14117(s, config);
}

}


