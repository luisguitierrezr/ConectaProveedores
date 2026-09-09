using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionServiceRecord
public class RESTRC_04e7247757060d4016b43102119b0dd6 : AbstractRESTStructure<RC_04e7247757060d4016b43102119b0dd6> {
[JsonProperty("RequisitionService")]
public ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord AttrRequisitionService;

public RESTRC_04e7247757060d4016b43102119b0dd6() { }

public RESTRC_04e7247757060d4016b43102119b0dd6 (RC_04e7247757060d4016b43102119b0dd6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionService = ConvertToRestWithoutDefaults(s.ssENRequisitionService, new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.FromStructure, config);
  } else {
AttrRequisitionService = ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.FromStructure(s.ssENRequisitionService, config);
  }
}

public static RC_04e7247757060d4016b43102119b0dd6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6 obj) { 
  RC_04e7247757060d4016b43102119b0dd6 s = new RC_04e7247757060d4016b43102119b0dd6();
  if(obj != null) {
  s.ssENRequisitionService = ssConectaProveedores.RestRecords.RESTEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.ToStructure(obj.AttrRequisitionService);
  }
  return s;
}

public static Func<RC_04e7247757060d4016b43102119b0dd6, ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04e7247757060d4016b43102119b0dd6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6 FromStructure(RC_04e7247757060d4016b43102119b0dd6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6(s, config);
}

}


