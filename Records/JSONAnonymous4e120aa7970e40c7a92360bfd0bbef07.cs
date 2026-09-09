using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemOrderCostCenterAccountingAccounts_ServiceTypeDocumentTypeCostCenterSAPRecord
public class JSONRC_64471b6df37f8aec653dbc381bfea212 : AbstractRESTStructure<RC_64471b6df37f8aec653dbc381bfea212> {
[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("OrderCostCenter")]
[JsonPropertyName("OrderCostCenter")]
public ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord AttrOrderCostCenter;

[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("DocumentType")]
[JsonPropertyName("DocumentType")]
public ssConectaProveedores.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord AttrDocumentType;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public JSONRC_64471b6df37f8aec653dbc381bfea212() { }

public JSONRC_64471b6df37f8aec653dbc381bfea212 (RC_64471b6df37f8aec653dbc381bfea212 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrOrderCostCenter = ConvertToRestWithoutDefaults(s.ssENOrderCostCenter, new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrDocumentType = ConvertToRestWithoutDefaults(s.ssENDocumentType, new EN_a70d553ce1458b3952d039852f258a76EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrOrderCostCenter = ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure(s.ssENOrderCostCenter, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrDocumentType = ssConectaProveedores.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure(s.ssENDocumentType, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_64471b6df37f8aec653dbc381bfea212, RC_64471b6df37f8aec653dbc381bfea212> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_64471b6df37f8aec653dbc381bfea212 s) => ToStructure(s, config);
}
public static RC_64471b6df37f8aec653dbc381bfea212 ToStructure(ssConectaProveedores.RestRecords.JSONRC_64471b6df37f8aec653dbc381bfea212 obj, IBehaviorsConfiguration config) { 
  RC_64471b6df37f8aec653dbc381bfea212 s = new RC_64471b6df37f8aec653dbc381bfea212();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssENOrderCostCenter = ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.ToStructure(obj.AttrOrderCostCenter, config);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType, config);
  s.ssENDocumentType = ssConectaProveedores.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.ToStructure(obj.AttrDocumentType, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  }
  return s;
}

public static Func<RC_64471b6df37f8aec653dbc381bfea212, ssConectaProveedores.RestRecords.JSONRC_64471b6df37f8aec653dbc381bfea212> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_64471b6df37f8aec653dbc381bfea212 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_64471b6df37f8aec653dbc381bfea212 FromStructure(RC_64471b6df37f8aec653dbc381bfea212 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_64471b6df37f8aec653dbc381bfea212(s, config);
}

}


