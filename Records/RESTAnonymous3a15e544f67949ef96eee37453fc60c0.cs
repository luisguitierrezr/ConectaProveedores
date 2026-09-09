using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemFolioItemsAccountingAccounts_ServiceTypeCostCenterSAPRegionRecord
public class RESTRC_082bf66064d5a51dc7db708fe5577120 : AbstractRESTStructure<RC_082bf66064d5a51dc7db708fe5577120> {
[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("FolioItems")]
public ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

[JsonProperty("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_082bf66064d5a51dc7db708fe5577120() { }

public RESTRC_082bf66064d5a51dc7db708fe5577120 (RC_082bf66064d5a51dc7db708fe5577120 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_082bf66064d5a51dc7db708fe5577120 ToStructure(ssConectaProveedores.RestRecords.RESTRC_082bf66064d5a51dc7db708fe5577120 obj) { 
  RC_082bf66064d5a51dc7db708fe5577120 s = new RC_082bf66064d5a51dc7db708fe5577120();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_082bf66064d5a51dc7db708fe5577120, ssConectaProveedores.RestRecords.RESTRC_082bf66064d5a51dc7db708fe5577120> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_082bf66064d5a51dc7db708fe5577120 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_082bf66064d5a51dc7db708fe5577120 FromStructure(RC_082bf66064d5a51dc7db708fe5577120 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_082bf66064d5a51dc7db708fe5577120(s, config);
}

}


