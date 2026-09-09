using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessRequisitionApprovalRecord
public class JSONRC_98120f161aa796efec5482157f929b99 : AbstractRESTStructure<RC_98120f161aa796efec5482157f929b99> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public JSONRC_98120f161aa796efec5482157f929b99() { }

public JSONRC_98120f161aa796efec5482157f929b99 (RC_98120f161aa796efec5482157f929b99 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_98120f161aa796efec5482157f929b99, RC_98120f161aa796efec5482157f929b99> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_98120f161aa796efec5482157f929b99 s) => ToStructure(s, config);
}
public static RC_98120f161aa796efec5482157f929b99 ToStructure(ssConectaProveedores.RestRecords.JSONRC_98120f161aa796efec5482157f929b99 obj, IBehaviorsConfiguration config) { 
  RC_98120f161aa796efec5482157f929b99 s = new RC_98120f161aa796efec5482157f929b99();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  }
  return s;
}

public static Func<RC_98120f161aa796efec5482157f929b99, ssConectaProveedores.RestRecords.JSONRC_98120f161aa796efec5482157f929b99> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_98120f161aa796efec5482157f929b99 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_98120f161aa796efec5482157f929b99 FromStructure(RC_98120f161aa796efec5482157f929b99 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_98120f161aa796efec5482157f929b99(s, config);
}

}


