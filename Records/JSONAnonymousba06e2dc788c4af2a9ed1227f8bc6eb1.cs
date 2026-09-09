using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionStatusHistoryRecord
public class JSONRC_aa9fab59faf7c7de355dae43478ba7e5 : AbstractRESTStructure<RC_aa9fab59faf7c7de355dae43478ba7e5> {
[JsonProperty("RequisitionStatusHistory")]
[JsonPropertyName("RequisitionStatusHistory")]
public ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord AttrRequisitionStatusHistory;

public JSONRC_aa9fab59faf7c7de355dae43478ba7e5() { }

public JSONRC_aa9fab59faf7c7de355dae43478ba7e5 (RC_aa9fab59faf7c7de355dae43478ba7e5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionStatusHistory = ConvertToRestWithoutDefaults(s.ssENRequisitionStatusHistory, new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord.FromStructure, config);
  } else {
AttrRequisitionStatusHistory = ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord.FromStructure(s.ssENRequisitionStatusHistory, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_aa9fab59faf7c7de355dae43478ba7e5, RC_aa9fab59faf7c7de355dae43478ba7e5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_aa9fab59faf7c7de355dae43478ba7e5 s) => ToStructure(s, config);
}
public static RC_aa9fab59faf7c7de355dae43478ba7e5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_aa9fab59faf7c7de355dae43478ba7e5 obj, IBehaviorsConfiguration config) { 
  RC_aa9fab59faf7c7de355dae43478ba7e5 s = new RC_aa9fab59faf7c7de355dae43478ba7e5();
  if(obj != null) {
  s.ssENRequisitionStatusHistory = ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord.ToStructure(obj.AttrRequisitionStatusHistory, config);
  }
  return s;
}

public static Func<RC_aa9fab59faf7c7de355dae43478ba7e5, ssConectaProveedores.RestRecords.JSONRC_aa9fab59faf7c7de355dae43478ba7e5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aa9fab59faf7c7de355dae43478ba7e5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_aa9fab59faf7c7de355dae43478ba7e5 FromStructure(RC_aa9fab59faf7c7de355dae43478ba7e5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_aa9fab59faf7c7de355dae43478ba7e5(s, config);
}

}


