using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCostCenterSAPRecord
public class JSONRC_cc5b09a13023b24fea23c488b525369e : AbstractRESTStructure<RC_cc5b09a13023b24fea23c488b525369e> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public JSONRC_cc5b09a13023b24fea23c488b525369e() { }

public JSONRC_cc5b09a13023b24fea23c488b525369e (RC_cc5b09a13023b24fea23c488b525369e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cc5b09a13023b24fea23c488b525369e, RC_cc5b09a13023b24fea23c488b525369e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cc5b09a13023b24fea23c488b525369e s) => ToStructure(s, config);
}
public static RC_cc5b09a13023b24fea23c488b525369e ToStructure(ssConectaProveedores.RestRecords.JSONRC_cc5b09a13023b24fea23c488b525369e obj, IBehaviorsConfiguration config) { 
  RC_cc5b09a13023b24fea23c488b525369e s = new RC_cc5b09a13023b24fea23c488b525369e();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  }
  return s;
}

public static Func<RC_cc5b09a13023b24fea23c488b525369e, ssConectaProveedores.RestRecords.JSONRC_cc5b09a13023b24fea23c488b525369e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cc5b09a13023b24fea23c488b525369e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cc5b09a13023b24fea23c488b525369e FromStructure(RC_cc5b09a13023b24fea23c488b525369e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cc5b09a13023b24fea23c488b525369e(s, config);
}

}


