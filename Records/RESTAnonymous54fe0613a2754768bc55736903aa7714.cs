using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalRecord
public class RESTRC_6d2bef4b7e32de4c7c78886eeff75224 : AbstractRESTStructure<RC_6d2bef4b7e32de4c7c78886eeff75224> {
[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public RESTRC_6d2bef4b7e32de4c7c78886eeff75224() { }

public RESTRC_6d2bef4b7e32de4c7c78886eeff75224 (RC_6d2bef4b7e32de4c7c78886eeff75224 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static RC_6d2bef4b7e32de4c7c78886eeff75224 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6d2bef4b7e32de4c7c78886eeff75224 obj) { 
  RC_6d2bef4b7e32de4c7c78886eeff75224 s = new RC_6d2bef4b7e32de4c7c78886eeff75224();
  if(obj != null) {
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  }
  return s;
}

public static Func<RC_6d2bef4b7e32de4c7c78886eeff75224, ssConectaProveedores.RestRecords.RESTRC_6d2bef4b7e32de4c7c78886eeff75224> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d2bef4b7e32de4c7c78886eeff75224 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6d2bef4b7e32de4c7c78886eeff75224 FromStructure(RC_6d2bef4b7e32de4c7c78886eeff75224 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6d2bef4b7e32de4c7c78886eeff75224(s, config);
}

}


