using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyRequisitionRequisitionStatusCompanySupplierCostCenterSAPProject_Asset_ServicePaymentTermsRegionRecord
public class JSONRC_01ef322df050d27e5e0ba635cc767de3 : AbstractRESTStructure<RC_01ef322df050d27e5e0ba635cc767de3> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionStatus")]
[JsonPropertyName("RequisitionStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

[JsonProperty("Project_Asset_Service")]
[JsonPropertyName("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_01ef322df050d27e5e0ba635cc767de3() { }

public JSONRC_01ef322df050d27e5e0ba635cc767de3 (RC_01ef322df050d27e5e0ba635cc767de3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_01ef322df050d27e5e0ba635cc767de3, RC_01ef322df050d27e5e0ba635cc767de3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_01ef322df050d27e5e0ba635cc767de3 s) => ToStructure(s, config);
}
public static RC_01ef322df050d27e5e0ba635cc767de3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_01ef322df050d27e5e0ba635cc767de3 obj, IBehaviorsConfiguration config) { 
  RC_01ef322df050d27e5e0ba635cc767de3 s = new RC_01ef322df050d27e5e0ba635cc767de3();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_01ef322df050d27e5e0ba635cc767de3, ssConectaProveedores.RestRecords.JSONRC_01ef322df050d27e5e0ba635cc767de3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_01ef322df050d27e5e0ba635cc767de3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_01ef322df050d27e5e0ba635cc767de3 FromStructure(RC_01ef322df050d27e5e0ba635cc767de3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_01ef322df050d27e5e0ba635cc767de3(s, config);
}

}


