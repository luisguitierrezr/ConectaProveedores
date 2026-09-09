using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderApprovalLevelEntraRoleRecord
public class JSONRC_cb3079de01243d5d6995c7751ddd690b : AbstractRESTStructure<RC_cb3079de01243d5d6995c7751ddd690b> {
[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public JSONRC_cb3079de01243d5d6995c7751ddd690b() { }

public JSONRC_cb3079de01243d5d6995c7751ddd690b (RC_cb3079de01243d5d6995c7751ddd690b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cb3079de01243d5d6995c7751ddd690b, RC_cb3079de01243d5d6995c7751ddd690b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cb3079de01243d5d6995c7751ddd690b s) => ToStructure(s, config);
}
public static RC_cb3079de01243d5d6995c7751ddd690b ToStructure(ssConectaProveedores.RestRecords.JSONRC_cb3079de01243d5d6995c7751ddd690b obj, IBehaviorsConfiguration config) { 
  RC_cb3079de01243d5d6995c7751ddd690b s = new RC_cb3079de01243d5d6995c7751ddd690b();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  }
  return s;
}

public static Func<RC_cb3079de01243d5d6995c7751ddd690b, ssConectaProveedores.RestRecords.JSONRC_cb3079de01243d5d6995c7751ddd690b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cb3079de01243d5d6995c7751ddd690b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cb3079de01243d5d6995c7751ddd690b FromStructure(RC_cb3079de01243d5d6995c7751ddd690b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cb3079de01243d5d6995c7751ddd690b(s, config);
}

}


