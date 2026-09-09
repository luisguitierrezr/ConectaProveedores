using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionStatusHistoryRecord
public class RESTRC_aa9fab59faf7c7de355dae43478ba7e5 : AbstractRESTStructure<RC_aa9fab59faf7c7de355dae43478ba7e5> {
[JsonProperty("RequisitionStatusHistory")]
public ssConectaProveedores.RestRecords.RESTEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord AttrRequisitionStatusHistory;

public RESTRC_aa9fab59faf7c7de355dae43478ba7e5() { }

public RESTRC_aa9fab59faf7c7de355dae43478ba7e5 (RC_aa9fab59faf7c7de355dae43478ba7e5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionStatusHistory = ConvertToRestWithoutDefaults(s.ssENRequisitionStatusHistory, new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord.FromStructure, config);
  } else {
AttrRequisitionStatusHistory = ssConectaProveedores.RestRecords.RESTEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord.FromStructure(s.ssENRequisitionStatusHistory, config);
  }
}

public static RC_aa9fab59faf7c7de355dae43478ba7e5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_aa9fab59faf7c7de355dae43478ba7e5 obj) { 
  RC_aa9fab59faf7c7de355dae43478ba7e5 s = new RC_aa9fab59faf7c7de355dae43478ba7e5();
  if(obj != null) {
  s.ssENRequisitionStatusHistory = ssConectaProveedores.RestRecords.RESTEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord.ToStructure(obj.AttrRequisitionStatusHistory);
  }
  return s;
}

public static Func<RC_aa9fab59faf7c7de355dae43478ba7e5, ssConectaProveedores.RestRecords.RESTRC_aa9fab59faf7c7de355dae43478ba7e5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aa9fab59faf7c7de355dae43478ba7e5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_aa9fab59faf7c7de355dae43478ba7e5 FromStructure(RC_aa9fab59faf7c7de355dae43478ba7e5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_aa9fab59faf7c7de355dae43478ba7e5(s, config);
}

}


