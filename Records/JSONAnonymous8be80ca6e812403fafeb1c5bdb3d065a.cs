using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanyIdCompanyId_cDocumentTypeIdDocumentTypeId_cOrderMainIdOrderMainId_cRegionIdRegionId_cCurrencyIdCurrencyId_cRecord
public class JSONRC_f8d32413a09252891cf320a9f349aadb : AbstractRESTStructure<RC_f8d32413a09252891cf320a9f349aadb> {
[JsonProperty("CompanyId")]
[JsonPropertyName("CompanyId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrCompanyId;

[JsonProperty("CompanyId_c")]
[JsonPropertyName("CompanyId_c")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrCompanyId_c;

[JsonProperty("DocumentTypeId")]
[JsonPropertyName("DocumentTypeId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDocumentTypeId;

[JsonProperty("DocumentTypeId_c")]
[JsonPropertyName("DocumentTypeId_c")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDocumentTypeId_c;

[JsonProperty("OrderMainId")]
[JsonPropertyName("OrderMainId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrOrderMainId;

[JsonProperty("OrderMainId_c")]
[JsonPropertyName("OrderMainId_c")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrOrderMainId_c;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrRegionId;

[JsonProperty("RegionId_c")]
[JsonPropertyName("RegionId_c")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrRegionId_c;

[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrCurrencyId;

[JsonProperty("CurrencyId_c")]
[JsonPropertyName("CurrencyId_c")]
public ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrCurrencyId_c;

public JSONRC_f8d32413a09252891cf320a9f349aadb() { }

public JSONRC_f8d32413a09252891cf320a9f349aadb (RC_f8d32413a09252891cf320a9f349aadb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssSTCompanyId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrCompanyId_c = ConvertToRestWithoutDefaults(s.ssSTCompanyId_c, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDocumentTypeId = ConvertToRestWithoutDefaults(s.ssSTDocumentTypeId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDocumentTypeId_c = ConvertToRestWithoutDefaults(s.ssSTDocumentTypeId_c, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssSTOrderMainId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrOrderMainId_c = ConvertToRestWithoutDefaults(s.ssSTOrderMainId_c, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssSTRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrRegionId_c = ConvertToRestWithoutDefaults(s.ssSTRegionId_c, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssSTCurrencyId, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
AttrCurrencyId_c = ConvertToRestWithoutDefaults(s.ssSTCurrencyId_c, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
  } else {
AttrCompanyId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTCompanyId, config);
AttrCompanyId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTCompanyId_c, config);
AttrDocumentTypeId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDocumentTypeId, config);
AttrDocumentTypeId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDocumentTypeId_c, config);
AttrOrderMainId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTOrderMainId, config);
AttrOrderMainId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTOrderMainId_c, config);
AttrRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTRegionId, config);
AttrRegionId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTRegionId_c, config);
AttrCurrencyId = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTCurrencyId, config);
AttrCurrencyId_c = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTCurrencyId_c, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f8d32413a09252891cf320a9f349aadb, RC_f8d32413a09252891cf320a9f349aadb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f8d32413a09252891cf320a9f349aadb s) => ToStructure(s, config);
}
public static RC_f8d32413a09252891cf320a9f349aadb ToStructure(ssConectaProveedores.RestRecords.JSONRC_f8d32413a09252891cf320a9f349aadb obj, IBehaviorsConfiguration config) { 
  RC_f8d32413a09252891cf320a9f349aadb s = new RC_f8d32413a09252891cf320a9f349aadb();
  if(obj != null) {
  s.ssSTCompanyId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrCompanyId, config);
  s.ssSTCompanyId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrCompanyId_c, config);
  s.ssSTDocumentTypeId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDocumentTypeId, config);
  s.ssSTDocumentTypeId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDocumentTypeId_c, config);
  s.ssSTOrderMainId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrOrderMainId, config);
  s.ssSTOrderMainId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrOrderMainId_c, config);
  s.ssSTRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrRegionId, config);
  s.ssSTRegionId_c = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrRegionId_c, config);
  s.ssSTCurrencyId = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrCurrencyId, config);
  s.ssSTCurrencyId_c = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrCurrencyId_c, config);
  }
  return s;
}

public static Func<RC_f8d32413a09252891cf320a9f349aadb, ssConectaProveedores.RestRecords.JSONRC_f8d32413a09252891cf320a9f349aadb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f8d32413a09252891cf320a9f349aadb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f8d32413a09252891cf320a9f349aadb FromStructure(RC_f8d32413a09252891cf320a9f349aadb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f8d32413a09252891cf320a9f349aadb(s, config);
}

}


