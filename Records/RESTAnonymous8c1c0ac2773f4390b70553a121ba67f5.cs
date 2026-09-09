using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord
public class RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c : AbstractRESTStructure<RC_06ae1f23d9c7cedfe36d2b236ac6d94c> {
[JsonProperty("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("CompanyId")]
public long? AttrCompanyId;

[JsonProperty("DocumentTypeId")]
public long? AttrDocumentTypeId;

[JsonProperty("RegionId")]
public long? AttrRegionId;

public RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c() { }

public RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c (RC_06ae1f23d9c7cedfe36d2b236ac6d94c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssCompanyId, 0L);
AttrDocumentTypeId = ConvertToRestWithoutDefaults(s.ssDocumentTypeId, 0L);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
  } else {
AttrCurrencyId = s.ssCurrencyId;
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrDocumentTypeId = (long?) s.ssDocumentTypeId;
AttrRegionId = (long?) s.ssRegionId;
  }
}

public static RC_06ae1f23d9c7cedfe36d2b236ac6d94c ToStructure(ssConectaProveedores.RestRecords.RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c obj) { 
  RC_06ae1f23d9c7cedfe36d2b236ac6d94c s = new RC_06ae1f23d9c7cedfe36d2b236ac6d94c();
  if(obj != null) {
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssCompanyId = obj.AttrCompanyId == null ? 0L : obj.AttrCompanyId.Value;
  s.ssDocumentTypeId = obj.AttrDocumentTypeId == null ? 0L : obj.AttrDocumentTypeId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<RC_06ae1f23d9c7cedfe36d2b236ac6d94c, ssConectaProveedores.RestRecords.RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06ae1f23d9c7cedfe36d2b236ac6d94c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c FromStructure(RC_06ae1f23d9c7cedfe36d2b236ac6d94c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_06ae1f23d9c7cedfe36d2b236ac6d94c(s, config);
}

}


