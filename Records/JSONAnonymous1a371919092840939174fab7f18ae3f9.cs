using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionSupplierCostCenterSAPFrequencyProject_Asset_ServiceRegionRecord
public class JSONRC_8b7c923e868586b85592884287e2136d : AbstractRESTStructure<RC_8b7c923e868586b85592884287e2136d> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

[JsonProperty("Project_Asset_Service")]
[JsonPropertyName("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_8b7c923e868586b85592884287e2136d() { }

public JSONRC_8b7c923e868586b85592884287e2136d (RC_8b7c923e868586b85592884287e2136d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
AttrFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8b7c923e868586b85592884287e2136d, RC_8b7c923e868586b85592884287e2136d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8b7c923e868586b85592884287e2136d s) => ToStructure(s, config);
}
public static RC_8b7c923e868586b85592884287e2136d ToStructure(ssConectaProveedores.RestRecords.JSONRC_8b7c923e868586b85592884287e2136d obj, IBehaviorsConfiguration config) { 
  RC_8b7c923e868586b85592884287e2136d s = new RC_8b7c923e868586b85592884287e2136d();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  s.ssENFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency, config);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_8b7c923e868586b85592884287e2136d, ssConectaProveedores.RestRecords.JSONRC_8b7c923e868586b85592884287e2136d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8b7c923e868586b85592884287e2136d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8b7c923e868586b85592884287e2136d FromStructure(RC_8b7c923e868586b85592884287e2136d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8b7c923e868586b85592884287e2136d(s, config);
}

}


