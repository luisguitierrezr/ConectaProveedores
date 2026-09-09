using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingAccounts_ServiceTypeEntryBlockDatesRecord
public class RESTRC_286d2bb37686f509eeb33164e8470439 : AbstractRESTStructure<RC_286d2bb37686f509eeb33164e8470439> {
[JsonProperty("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("EntryBlockDates")]
public ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord AttrEntryBlockDates;

public RESTRC_286d2bb37686f509eeb33164e8470439() { }

public RESTRC_286d2bb37686f509eeb33164e8470439 (RC_286d2bb37686f509eeb33164e8470439 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrEntryBlockDates = ConvertToRestWithoutDefaults(s.ssENEntryBlockDates, new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure, config);
  } else {
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrEntryBlockDates = ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure(s.ssENEntryBlockDates, config);
  }
}

public static RC_286d2bb37686f509eeb33164e8470439 ToStructure(ssConectaProveedores.RestRecords.RESTRC_286d2bb37686f509eeb33164e8470439 obj) { 
  RC_286d2bb37686f509eeb33164e8470439 s = new RC_286d2bb37686f509eeb33164e8470439();
  if(obj != null) {
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType);
  s.ssENEntryBlockDates = ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.ToStructure(obj.AttrEntryBlockDates);
  }
  return s;
}

public static Func<RC_286d2bb37686f509eeb33164e8470439, ssConectaProveedores.RestRecords.RESTRC_286d2bb37686f509eeb33164e8470439> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_286d2bb37686f509eeb33164e8470439 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_286d2bb37686f509eeb33164e8470439 FromStructure(RC_286d2bb37686f509eeb33164e8470439 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_286d2bb37686f509eeb33164e8470439(s, config);
}

}


