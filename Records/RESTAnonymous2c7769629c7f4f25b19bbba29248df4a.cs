using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderFileTypesStructRecord
public class RESTRC_e2e47f886a2f72e5f0dffc8728d14117 : AbstractRESTStructure<RC_e2e47f886a2f72e5f0dffc8728d14117> {
[JsonProperty("OrderFileTypesStruct")]
public ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure AttrOrderFileTypesStruct;

public RESTRC_e2e47f886a2f72e5f0dffc8728d14117() { }

public RESTRC_e2e47f886a2f72e5f0dffc8728d14117 (RC_e2e47f886a2f72e5f0dffc8728d14117 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderFileTypesStruct = ConvertToRestWithoutDefaults(s.ssSTOrderFileTypesStruct, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.FromStructure, config);
  } else {
AttrOrderFileTypesStruct = ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.FromStructure(s.ssSTOrderFileTypesStruct, config);
  }
}

public static RC_e2e47f886a2f72e5f0dffc8728d14117 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e2e47f886a2f72e5f0dffc8728d14117 obj) { 
  RC_e2e47f886a2f72e5f0dffc8728d14117 s = new RC_e2e47f886a2f72e5f0dffc8728d14117();
  if(obj != null) {
  s.ssSTOrderFileTypesStruct = ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.ToStructure(obj.AttrOrderFileTypesStruct);
  }
  return s;
}

public static Func<RC_e2e47f886a2f72e5f0dffc8728d14117, ssConectaProveedores.RestRecords.RESTRC_e2e47f886a2f72e5f0dffc8728d14117> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e2e47f886a2f72e5f0dffc8728d14117 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e2e47f886a2f72e5f0dffc8728d14117 FromStructure(RC_e2e47f886a2f72e5f0dffc8728d14117 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e2e47f886a2f72e5f0dffc8728d14117(s, config);
}

}


