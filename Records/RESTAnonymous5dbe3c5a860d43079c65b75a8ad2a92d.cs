using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyRequisitionRequisitionApprovalRequisitionStatusCompanySupplierCostCenterSAPProject_Asset_ServiceRecord
public class RESTRC_86423f353b6ff38800cf09bdbbb2131d : AbstractRESTStructure<RC_86423f353b6ff38800cf09bdbbb2131d> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

[JsonProperty("RequisitionStatus")]
public ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

[JsonProperty("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

public RESTRC_86423f353b6ff38800cf09bdbbb2131d() { }

public RESTRC_86423f353b6ff38800cf09bdbbb2131d (RC_86423f353b6ff38800cf09bdbbb2131d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
AttrRequisitionStatus = ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
  }
}

public static RC_86423f353b6ff38800cf09bdbbb2131d ToStructure(ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d obj) { 
  RC_86423f353b6ff38800cf09bdbbb2131d s = new RC_86423f353b6ff38800cf09bdbbb2131d();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus);
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service);
  }
  return s;
}

public static Func<RC_86423f353b6ff38800cf09bdbbb2131d, ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_86423f353b6ff38800cf09bdbbb2131d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d FromStructure(RC_86423f353b6ff38800cf09bdbbb2131d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d(s, config);
}

}


