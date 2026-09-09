using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemAccountingAccounts_ServiceTypeCostCenterSAPRegionRecord
public class JSONRC_34d74f643477f98fc1cbb3375068d112 : AbstractRESTStructure<RC_34d74f643477f98fc1cbb3375068d112> {
[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_34d74f643477f98fc1cbb3375068d112() { }

public JSONRC_34d74f643477f98fc1cbb3375068d112 (RC_34d74f643477f98fc1cbb3375068d112 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_34d74f643477f98fc1cbb3375068d112, RC_34d74f643477f98fc1cbb3375068d112> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_34d74f643477f98fc1cbb3375068d112 s) => ToStructure(s, config);
}
public static RC_34d74f643477f98fc1cbb3375068d112 ToStructure(ssConectaProveedores.RestRecords.JSONRC_34d74f643477f98fc1cbb3375068d112 obj, IBehaviorsConfiguration config) { 
  RC_34d74f643477f98fc1cbb3375068d112 s = new RC_34d74f643477f98fc1cbb3375068d112();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_34d74f643477f98fc1cbb3375068d112, ssConectaProveedores.RestRecords.JSONRC_34d74f643477f98fc1cbb3375068d112> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34d74f643477f98fc1cbb3375068d112 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_34d74f643477f98fc1cbb3375068d112 FromStructure(RC_34d74f643477f98fc1cbb3375068d112 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_34d74f643477f98fc1cbb3375068d112(s, config);
}

}


