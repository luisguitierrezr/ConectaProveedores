using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemOrderCostCenterAccountingAccounts_ServiceTypeDocumentTypeCostCenterSAPRecord
public class RESTRC_64471b6df37f8aec653dbc381bfea212 : AbstractRESTStructure<RC_64471b6df37f8aec653dbc381bfea212> {
[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("OrderCostCenter")]
public ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord AttrOrderCostCenter;

[JsonProperty("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("DocumentType")]
public ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord AttrDocumentType;

[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public RESTRC_64471b6df37f8aec653dbc381bfea212() { }

public RESTRC_64471b6df37f8aec653dbc381bfea212 (RC_64471b6df37f8aec653dbc381bfea212 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrOrderCostCenter = ConvertToRestWithoutDefaults(s.ssENOrderCostCenter, new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrDocumentType = ConvertToRestWithoutDefaults(s.ssENDocumentType, new EN_a70d553ce1458b3952d039852f258a76EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrOrderCostCenter = ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure(s.ssENOrderCostCenter, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrDocumentType = ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure(s.ssENDocumentType, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static RC_64471b6df37f8aec653dbc381bfea212 ToStructure(ssConectaProveedores.RestRecords.RESTRC_64471b6df37f8aec653dbc381bfea212 obj) { 
  RC_64471b6df37f8aec653dbc381bfea212 s = new RC_64471b6df37f8aec653dbc381bfea212();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENOrderCostCenter = ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.ToStructure(obj.AttrOrderCostCenter);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType);
  s.ssENDocumentType = ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord.ToStructure(obj.AttrDocumentType);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  }
  return s;
}

public static Func<RC_64471b6df37f8aec653dbc381bfea212, ssConectaProveedores.RestRecords.RESTRC_64471b6df37f8aec653dbc381bfea212> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_64471b6df37f8aec653dbc381bfea212 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_64471b6df37f8aec653dbc381bfea212 FromStructure(RC_64471b6df37f8aec653dbc381bfea212 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_64471b6df37f8aec653dbc381bfea212(s, config);
}

}


