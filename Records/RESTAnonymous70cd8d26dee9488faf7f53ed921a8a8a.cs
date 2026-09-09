using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_POS_InRecord
public class RESTRC_2e0c106d4606a1153081317391234712 : AbstractRESTStructure<RC_2e0c106d4606a1153081317391234712> {
[JsonProperty("TI_POS_In")]
public ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure AttrTI_POS_In;

public RESTRC_2e0c106d4606a1153081317391234712() { }

public RESTRC_2e0c106d4606a1153081317391234712 (RC_2e0c106d4606a1153081317391234712 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_POS_In = ConvertToRestWithoutDefaults(s.ssSTTI_POS_In, new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(), ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.FromStructure, config);
  } else {
AttrTI_POS_In = ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.FromStructure(s.ssSTTI_POS_In, config);
  }
}

public static RC_2e0c106d4606a1153081317391234712 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2e0c106d4606a1153081317391234712 obj) { 
  RC_2e0c106d4606a1153081317391234712 s = new RC_2e0c106d4606a1153081317391234712();
  if(obj != null) {
  s.ssSTTI_POS_In = ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.ToStructure(obj.AttrTI_POS_In);
  }
  return s;
}

public static Func<RC_2e0c106d4606a1153081317391234712, ssConectaProveedores.RestRecords.RESTRC_2e0c106d4606a1153081317391234712> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2e0c106d4606a1153081317391234712 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2e0c106d4606a1153081317391234712 FromStructure(RC_2e0c106d4606a1153081317391234712 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2e0c106d4606a1153081317391234712(s, config);
}

}


