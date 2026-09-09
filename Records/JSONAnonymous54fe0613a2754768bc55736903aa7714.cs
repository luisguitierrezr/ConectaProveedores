using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalRecord
public class JSONRC_6d2bef4b7e32de4c7c78886eeff75224 : AbstractRESTStructure<RC_6d2bef4b7e32de4c7c78886eeff75224> {
[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public JSONRC_6d2bef4b7e32de4c7c78886eeff75224() { }

public JSONRC_6d2bef4b7e32de4c7c78886eeff75224 (RC_6d2bef4b7e32de4c7c78886eeff75224 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6d2bef4b7e32de4c7c78886eeff75224, RC_6d2bef4b7e32de4c7c78886eeff75224> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6d2bef4b7e32de4c7c78886eeff75224 s) => ToStructure(s, config);
}
public static RC_6d2bef4b7e32de4c7c78886eeff75224 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6d2bef4b7e32de4c7c78886eeff75224 obj, IBehaviorsConfiguration config) { 
  RC_6d2bef4b7e32de4c7c78886eeff75224 s = new RC_6d2bef4b7e32de4c7c78886eeff75224();
  if(obj != null) {
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  }
  return s;
}

public static Func<RC_6d2bef4b7e32de4c7c78886eeff75224, ssConectaProveedores.RestRecords.JSONRC_6d2bef4b7e32de4c7c78886eeff75224> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d2bef4b7e32de4c7c78886eeff75224 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6d2bef4b7e32de4c7c78886eeff75224 FromStructure(RC_6d2bef4b7e32de4c7c78886eeff75224 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6d2bef4b7e32de4c7c78886eeff75224(s, config);
}

}


