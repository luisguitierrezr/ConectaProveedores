using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCostCenterCostCenterSAPRecord
public class JSONRC_7c130c22cc39a396afe0c98666f27e02 : AbstractRESTStructure<RC_7c130c22cc39a396afe0c98666f27e02> {
[JsonProperty("RequisitionCostCenter")]
[JsonPropertyName("RequisitionCostCenter")]
public ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord AttrRequisitionCostCenter;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public JSONRC_7c130c22cc39a396afe0c98666f27e02() { }

public JSONRC_7c130c22cc39a396afe0c98666f27e02 (RC_7c130c22cc39a396afe0c98666f27e02 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionCostCenter = ConvertToRestWithoutDefaults(s.ssENRequisitionCostCenter, new EN_114fcf95674648310a3efb0d78529a37EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrRequisitionCostCenter = ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord.FromStructure(s.ssENRequisitionCostCenter, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7c130c22cc39a396afe0c98666f27e02, RC_7c130c22cc39a396afe0c98666f27e02> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7c130c22cc39a396afe0c98666f27e02 s) => ToStructure(s, config);
}
public static RC_7c130c22cc39a396afe0c98666f27e02 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7c130c22cc39a396afe0c98666f27e02 obj, IBehaviorsConfiguration config) { 
  RC_7c130c22cc39a396afe0c98666f27e02 s = new RC_7c130c22cc39a396afe0c98666f27e02();
  if(obj != null) {
  s.ssENRequisitionCostCenter = ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord.ToStructure(obj.AttrRequisitionCostCenter, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  }
  return s;
}

public static Func<RC_7c130c22cc39a396afe0c98666f27e02, ssConectaProveedores.RestRecords.JSONRC_7c130c22cc39a396afe0c98666f27e02> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7c130c22cc39a396afe0c98666f27e02 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7c130c22cc39a396afe0c98666f27e02 FromStructure(RC_7c130c22cc39a396afe0c98666f27e02 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7c130c22cc39a396afe0c98666f27e02(s, config);
}

}


