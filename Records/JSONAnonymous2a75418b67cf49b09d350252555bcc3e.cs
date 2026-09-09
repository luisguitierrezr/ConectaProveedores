using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApproverOrderApprovalOrderMainOrderApprovalLevelUserExtensionUser_Extended_InternalRecord
public class JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace : AbstractRESTStructure<RC_a5e9a82dc9980e7d5c34d4c26f706ace> {
[JsonProperty("Approver")]
[JsonPropertyName("Approver")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrApprover;

[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace() { }

public JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace (RC_a5e9a82dc9980e7d5c34d4c26f706ace s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprover = ConvertToRestWithoutDefaults(s.ssENApprover, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrApprover = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENApprover, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace, RC_a5e9a82dc9980e7d5c34d4c26f706ace> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace s) => ToStructure(s, config);
}
public static RC_a5e9a82dc9980e7d5c34d4c26f706ace ToStructure(ssConectaProveedores.RestRecords.JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace obj, IBehaviorsConfiguration config) { 
  RC_a5e9a82dc9980e7d5c34d4c26f706ace s = new RC_a5e9a82dc9980e7d5c34d4c26f706ace();
  if(obj != null) {
  s.ssENApprover = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrApprover, config);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  }
  return s;
}

public static Func<RC_a5e9a82dc9980e7d5c34d4c26f706ace, ssConectaProveedores.RestRecords.JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a5e9a82dc9980e7d5c34d4c26f706ace s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace FromStructure(RC_a5e9a82dc9980e7d5c34d4c26f706ace s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a5e9a82dc9980e7d5c34d4c26f706ace(s, config);
}

}


