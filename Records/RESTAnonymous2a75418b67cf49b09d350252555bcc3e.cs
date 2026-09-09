using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApproverOrderApprovalOrderMainOrderApprovalLevelUserExtensionUser_Extended_InternalRecord
public class RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace : AbstractRESTStructure<RC_a5e9a82dc9980e7d5c34d4c26f706ace> {
[JsonProperty("Approver")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrApprover;

[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("UserExtension")]
public ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace() { }

public RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace (RC_a5e9a82dc9980e7d5c34d4c26f706ace s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprover = ConvertToRestWithoutDefaults(s.ssENApprover, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrApprover = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENApprover, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_a5e9a82dc9980e7d5c34d4c26f706ace ToStructure(ssConectaProveedores.RestRecords.RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace obj) { 
  RC_a5e9a82dc9980e7d5c34d4c26f706ace s = new RC_a5e9a82dc9980e7d5c34d4c26f706ace();
  if(obj != null) {
  s.ssENApprover = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrApprover);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_a5e9a82dc9980e7d5c34d4c26f706ace, ssConectaProveedores.RestRecords.RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a5e9a82dc9980e7d5c34d4c26f706ace s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace FromStructure(RC_a5e9a82dc9980e7d5c34d4c26f706ace s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a5e9a82dc9980e7d5c34d4c26f706ace(s, config);
}

}


