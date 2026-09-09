using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_ApprovedUser_AssignedOrderApprovalOrderComment_CancelOrderComment_ModifyOrderMainOrderApprovalLevelEntraRoleRecord
public class JSONRC_12d88e24134057c9d8b3dfc84a66166f : AbstractRESTStructure<RC_12d88e24134057c9d8b3dfc84a66166f> {
[JsonProperty("User_Approved")]
[JsonPropertyName("User_Approved")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Approved;

[JsonProperty("User_Assigned")]
[JsonPropertyName("User_Assigned")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Assigned;

[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderComment_Cancel")]
[JsonPropertyName("OrderComment_Cancel")]
public ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord AttrOrderComment_Cancel;

[JsonProperty("OrderComment_Modify")]
[JsonPropertyName("OrderComment_Modify")]
public ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord AttrOrderComment_Modify;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public JSONRC_12d88e24134057c9d8b3dfc84a66166f() { }

public JSONRC_12d88e24134057c9d8b3dfc84a66166f (RC_12d88e24134057c9d8b3dfc84a66166f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Approved = ConvertToRestWithoutDefaults(s.ssENUser_Approved, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Assigned = ConvertToRestWithoutDefaults(s.ssENUser_Assigned, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderComment_Cancel = ConvertToRestWithoutDefaults(s.ssENOrderComment_Cancel, new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure, config);
AttrOrderComment_Modify = ConvertToRestWithoutDefaults(s.ssENOrderComment_Modify, new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrUser_Approved = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Approved, config);
AttrUser_Assigned = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Assigned, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderComment_Cancel = ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure(s.ssENOrderComment_Cancel, config);
AttrOrderComment_Modify = ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure(s.ssENOrderComment_Modify, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_12d88e24134057c9d8b3dfc84a66166f, RC_12d88e24134057c9d8b3dfc84a66166f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_12d88e24134057c9d8b3dfc84a66166f s) => ToStructure(s, config);
}
public static RC_12d88e24134057c9d8b3dfc84a66166f ToStructure(ssConectaProveedores.RestRecords.JSONRC_12d88e24134057c9d8b3dfc84a66166f obj, IBehaviorsConfiguration config) { 
  RC_12d88e24134057c9d8b3dfc84a66166f s = new RC_12d88e24134057c9d8b3dfc84a66166f();
  if(obj != null) {
  s.ssENUser_Approved = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Approved, config);
  s.ssENUser_Assigned = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Assigned, config);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderComment_Cancel = ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.ToStructure(obj.AttrOrderComment_Cancel, config);
  s.ssENOrderComment_Modify = ssConectaProveedores.RestRecords.JSONEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.ToStructure(obj.AttrOrderComment_Modify, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  }
  return s;
}

public static Func<RC_12d88e24134057c9d8b3dfc84a66166f, ssConectaProveedores.RestRecords.JSONRC_12d88e24134057c9d8b3dfc84a66166f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_12d88e24134057c9d8b3dfc84a66166f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_12d88e24134057c9d8b3dfc84a66166f FromStructure(RC_12d88e24134057c9d8b3dfc84a66166f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_12d88e24134057c9d8b3dfc84a66166f(s, config);
}

}


