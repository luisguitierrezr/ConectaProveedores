using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingAccounts_ServiceTypeEntryBlockDatesRecord
public class JSONRC_286d2bb37686f509eeb33164e8470439 : AbstractRESTStructure<RC_286d2bb37686f509eeb33164e8470439> {
[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("EntryBlockDates")]
[JsonPropertyName("EntryBlockDates")]
public ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord AttrEntryBlockDates;

public JSONRC_286d2bb37686f509eeb33164e8470439() { }

public JSONRC_286d2bb37686f509eeb33164e8470439 (RC_286d2bb37686f509eeb33164e8470439 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrEntryBlockDates = ConvertToRestWithoutDefaults(s.ssENEntryBlockDates, new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure, config);
  } else {
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrEntryBlockDates = ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure(s.ssENEntryBlockDates, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_286d2bb37686f509eeb33164e8470439, RC_286d2bb37686f509eeb33164e8470439> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_286d2bb37686f509eeb33164e8470439 s) => ToStructure(s, config);
}
public static RC_286d2bb37686f509eeb33164e8470439 ToStructure(ssConectaProveedores.RestRecords.JSONRC_286d2bb37686f509eeb33164e8470439 obj, IBehaviorsConfiguration config) { 
  RC_286d2bb37686f509eeb33164e8470439 s = new RC_286d2bb37686f509eeb33164e8470439();
  if(obj != null) {
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType, config);
  s.ssENEntryBlockDates = ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.ToStructure(obj.AttrEntryBlockDates, config);
  }
  return s;
}

public static Func<RC_286d2bb37686f509eeb33164e8470439, ssConectaProveedores.RestRecords.JSONRC_286d2bb37686f509eeb33164e8470439> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_286d2bb37686f509eeb33164e8470439 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_286d2bb37686f509eeb33164e8470439 FromStructure(RC_286d2bb37686f509eeb33164e8470439 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_286d2bb37686f509eeb33164e8470439(s, config);
}

}


