using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionServiceRecord
public class JSONRC_04e7247757060d4016b43102119b0dd6 : AbstractRESTStructure<RC_04e7247757060d4016b43102119b0dd6> {
[JsonProperty("RequisitionService")]
[JsonPropertyName("RequisitionService")]
public ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord AttrRequisitionService;

public JSONRC_04e7247757060d4016b43102119b0dd6() { }

public JSONRC_04e7247757060d4016b43102119b0dd6 (RC_04e7247757060d4016b43102119b0dd6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionService = ConvertToRestWithoutDefaults(s.ssENRequisitionService, new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.FromStructure, config);
  } else {
AttrRequisitionService = ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.FromStructure(s.ssENRequisitionService, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6, RC_04e7247757060d4016b43102119b0dd6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6 s) => ToStructure(s, config);
}
public static RC_04e7247757060d4016b43102119b0dd6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6 obj, IBehaviorsConfiguration config) { 
  RC_04e7247757060d4016b43102119b0dd6 s = new RC_04e7247757060d4016b43102119b0dd6();
  if(obj != null) {
  s.ssENRequisitionService = ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.ToStructure(obj.AttrRequisitionService, config);
  }
  return s;
}

public static Func<RC_04e7247757060d4016b43102119b0dd6, ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04e7247757060d4016b43102119b0dd6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6 FromStructure(RC_04e7247757060d4016b43102119b0dd6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_04e7247757060d4016b43102119b0dd6(s, config);
}

}


