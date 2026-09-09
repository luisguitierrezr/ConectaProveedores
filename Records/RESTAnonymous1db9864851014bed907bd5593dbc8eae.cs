using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemAccountingAccounts_ServiceTypeInvoiceUsageRecord
public class RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64 : AbstractRESTStructure<RC_16678e1ac2e17d1b5db4a9a7f4681e64> {
[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("InvoiceUsage")]
public ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord AttrInvoiceUsage;

public RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64() { }

public RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64 (RC_16678e1ac2e17d1b5db4a9a7f4681e64 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrInvoiceUsage = ConvertToRestWithoutDefaults(s.ssENInvoiceUsage, new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrInvoiceUsage = ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure(s.ssENInvoiceUsage, config);
  }
}

public static RC_16678e1ac2e17d1b5db4a9a7f4681e64 ToStructure(ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64 obj) { 
  RC_16678e1ac2e17d1b5db4a9a7f4681e64 s = new RC_16678e1ac2e17d1b5db4a9a7f4681e64();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType);
  s.ssENInvoiceUsage = ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.ToStructure(obj.AttrInvoiceUsage);
  }
  return s;
}

public static Func<RC_16678e1ac2e17d1b5db4a9a7f4681e64, ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_16678e1ac2e17d1b5db4a9a7f4681e64 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64 FromStructure(RC_16678e1ac2e17d1b5db4a9a7f4681e64 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64(s, config);
}

}


