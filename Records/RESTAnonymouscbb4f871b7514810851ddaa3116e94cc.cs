using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCostCenterCostCenterSAPRecord
public class RESTRC_7c130c22cc39a396afe0c98666f27e02 : AbstractRESTStructure<RC_7c130c22cc39a396afe0c98666f27e02> {
[JsonProperty("RequisitionCostCenter")]
public ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord AttrRequisitionCostCenter;

[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public RESTRC_7c130c22cc39a396afe0c98666f27e02() { }

public RESTRC_7c130c22cc39a396afe0c98666f27e02 (RC_7c130c22cc39a396afe0c98666f27e02 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionCostCenter = ConvertToRestWithoutDefaults(s.ssENRequisitionCostCenter, new EN_114fcf95674648310a3efb0d78529a37EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrRequisitionCostCenter = ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructure(s.ssENRequisitionCostCenter, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static RC_7c130c22cc39a396afe0c98666f27e02 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02 obj) { 
  RC_7c130c22cc39a396afe0c98666f27e02 s = new RC_7c130c22cc39a396afe0c98666f27e02();
  if(obj != null) {
  s.ssENRequisitionCostCenter = ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.ToStructure(obj.AttrRequisitionCostCenter);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  }
  return s;
}

public static Func<RC_7c130c22cc39a396afe0c98666f27e02, ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7c130c22cc39a396afe0c98666f27e02 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02 FromStructure(RC_7c130c22cc39a396afe0c98666f27e02 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02(s, config);
}

}


