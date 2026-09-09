using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_ApprovedUser_AssignedOrderApprovalOrderComment_CancelOrderComment_ModifyOrderMainOrderApprovalLevelEntraRoleRecord
public class RESTRC_12d88e24134057c9d8b3dfc84a66166f : AbstractRESTStructure<RC_12d88e24134057c9d8b3dfc84a66166f> {
[JsonProperty("User_Approved")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Approved;

[JsonProperty("User_Assigned")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Assigned;

[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderComment_Cancel")]
public ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord AttrOrderComment_Cancel;

[JsonProperty("OrderComment_Modify")]
public ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord AttrOrderComment_Modify;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public RESTRC_12d88e24134057c9d8b3dfc84a66166f() { }

public RESTRC_12d88e24134057c9d8b3dfc84a66166f (RC_12d88e24134057c9d8b3dfc84a66166f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Approved = ConvertToRestWithoutDefaults(s.ssENUser_Approved, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Assigned = ConvertToRestWithoutDefaults(s.ssENUser_Assigned, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderComment_Cancel = ConvertToRestWithoutDefaults(s.ssENOrderComment_Cancel, new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure, config);
AttrOrderComment_Modify = ConvertToRestWithoutDefaults(s.ssENOrderComment_Modify, new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrUser_Approved = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Approved, config);
AttrUser_Assigned = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Assigned, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderComment_Cancel = ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure(s.ssENOrderComment_Cancel, config);
AttrOrderComment_Modify = ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure(s.ssENOrderComment_Modify, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static RC_12d88e24134057c9d8b3dfc84a66166f ToStructure(ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f obj) { 
  RC_12d88e24134057c9d8b3dfc84a66166f s = new RC_12d88e24134057c9d8b3dfc84a66166f();
  if(obj != null) {
  s.ssENUser_Approved = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Approved);
  s.ssENUser_Assigned = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Assigned);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderComment_Cancel = ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.ToStructure(obj.AttrOrderComment_Cancel);
  s.ssENOrderComment_Modify = ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.ToStructure(obj.AttrOrderComment_Modify);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  }
  return s;
}

public static Func<RC_12d88e24134057c9d8b3dfc84a66166f, ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_12d88e24134057c9d8b3dfc84a66166f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f FromStructure(RC_12d88e24134057c9d8b3dfc84a66166f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f(s, config);
}

}


