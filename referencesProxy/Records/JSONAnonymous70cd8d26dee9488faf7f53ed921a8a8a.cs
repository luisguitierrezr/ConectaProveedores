using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_POS_InRecord
public class JSONRC_2e0c106d4606a1153081317391234712 : AbstractRESTStructure<RC_2e0c106d4606a1153081317391234712> {
[JsonProperty("TI_POS_In")]
[JsonPropertyName("TI_POS_In")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure AttrTI_POS_In;

public JSONRC_2e0c106d4606a1153081317391234712() { }

public JSONRC_2e0c106d4606a1153081317391234712 (RC_2e0c106d4606a1153081317391234712 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_POS_In = ConvertToRestWithoutDefaults(s.ssSTTI_POS_In, new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.FromStructure, config);
  } else {
AttrTI_POS_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.FromStructure(s.ssSTTI_POS_In, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2e0c106d4606a1153081317391234712, RC_2e0c106d4606a1153081317391234712> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2e0c106d4606a1153081317391234712 s) => ToStructure(s, config);
}
public static RC_2e0c106d4606a1153081317391234712 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2e0c106d4606a1153081317391234712 obj, IBehaviorsConfiguration config) { 
  RC_2e0c106d4606a1153081317391234712 s = new RC_2e0c106d4606a1153081317391234712();
  if(obj != null) {
  s.ssSTTI_POS_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.ToStructure(obj.AttrTI_POS_In, config);
  }
  return s;
}

public static Func<RC_2e0c106d4606a1153081317391234712, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2e0c106d4606a1153081317391234712> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2e0c106d4606a1153081317391234712 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2e0c106d4606a1153081317391234712 FromStructure(RC_2e0c106d4606a1153081317391234712 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2e0c106d4606a1153081317391234712(s, config);
}

}


