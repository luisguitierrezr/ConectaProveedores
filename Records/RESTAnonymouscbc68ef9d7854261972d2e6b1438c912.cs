using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderApprovalLevelEntraRoleRecord
public class RESTRC_cb3079de01243d5d6995c7751ddd690b : AbstractRESTStructure<RC_cb3079de01243d5d6995c7751ddd690b> {
[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public RESTRC_cb3079de01243d5d6995c7751ddd690b() { }

public RESTRC_cb3079de01243d5d6995c7751ddd690b (RC_cb3079de01243d5d6995c7751ddd690b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static RC_cb3079de01243d5d6995c7751ddd690b ToStructure(ssConectaProveedores.RestRecords.RESTRC_cb3079de01243d5d6995c7751ddd690b obj) { 
  RC_cb3079de01243d5d6995c7751ddd690b s = new RC_cb3079de01243d5d6995c7751ddd690b();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  }
  return s;
}

public static Func<RC_cb3079de01243d5d6995c7751ddd690b, ssConectaProveedores.RestRecords.RESTRC_cb3079de01243d5d6995c7751ddd690b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cb3079de01243d5d6995c7751ddd690b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cb3079de01243d5d6995c7751ddd690b FromStructure(RC_cb3079de01243d5d6995c7751ddd690b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cb3079de01243d5d6995c7751ddd690b(s, config);
}

}


