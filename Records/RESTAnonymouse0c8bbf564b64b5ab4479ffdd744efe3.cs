using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderApprovalLevelRecord
public class RESTRC_2929b54077988f623db253f22a62f498 : AbstractRESTStructure<RC_2929b54077988f623db253f22a62f498> {
[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public RESTRC_2929b54077988f623db253f22a62f498() { }

public RESTRC_2929b54077988f623db253f22a62f498 (RC_2929b54077988f623db253f22a62f498 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static RC_2929b54077988f623db253f22a62f498 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2929b54077988f623db253f22a62f498 obj) { 
  RC_2929b54077988f623db253f22a62f498 s = new RC_2929b54077988f623db253f22a62f498();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  }
  return s;
}

public static Func<RC_2929b54077988f623db253f22a62f498, ssConectaProveedores.RestRecords.RESTRC_2929b54077988f623db253f22a62f498> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2929b54077988f623db253f22a62f498 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2929b54077988f623db253f22a62f498 FromStructure(RC_2929b54077988f623db253f22a62f498 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2929b54077988f623db253f22a62f498(s, config);
}

}


