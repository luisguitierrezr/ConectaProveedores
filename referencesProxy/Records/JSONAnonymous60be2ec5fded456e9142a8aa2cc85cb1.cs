using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AccountingAccounts_ServiceTypeRecord
public class JSONRC_f52b5cefcfac404122195213ce1b53ba : AbstractRESTStructure<RC_f52b5cefcfac404122195213ce1b53ba> {
[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

public JSONRC_f52b5cefcfac404122195213ce1b53ba() { }

public JSONRC_f52b5cefcfac404122195213ce1b53ba (RC_f52b5cefcfac404122195213ce1b53ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
  } else {
AttrAccountingAccounts_ServiceType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f52b5cefcfac404122195213ce1b53ba, RC_f52b5cefcfac404122195213ce1b53ba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f52b5cefcfac404122195213ce1b53ba s) => ToStructure(s, config);
}
public static RC_f52b5cefcfac404122195213ce1b53ba ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f52b5cefcfac404122195213ce1b53ba obj, IBehaviorsConfiguration config) { 
  RC_f52b5cefcfac404122195213ce1b53ba s = new RC_f52b5cefcfac404122195213ce1b53ba();
  if(obj != null) {
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType, config);
  }
  return s;
}

public static Func<RC_f52b5cefcfac404122195213ce1b53ba, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f52b5cefcfac404122195213ce1b53ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f52b5cefcfac404122195213ce1b53ba s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f52b5cefcfac404122195213ce1b53ba FromStructure(RC_f52b5cefcfac404122195213ce1b53ba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f52b5cefcfac404122195213ce1b53ba(s, config);
}

}


