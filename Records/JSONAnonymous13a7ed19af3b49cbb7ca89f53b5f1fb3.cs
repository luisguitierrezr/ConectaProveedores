using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CostCenterIdDivisionIdDocumentClassIdRegionIdServiceTypeIdCurrencyIdRecord
public class JSONRC_6238dc44386da10198e9e1b2b81cc9aa : AbstractRESTStructure<RC_6238dc44386da10198e9e1b2b81cc9aa> {
[JsonProperty("CostCenterId")]
[JsonPropertyName("CostCenterId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrCostCenterId;

[JsonProperty("DivisionId")]
[JsonPropertyName("DivisionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDivisionId;

[JsonProperty("DocumentClassId")]
[JsonPropertyName("DocumentClassId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDocumentClassId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrRegionId;

[JsonProperty("ServiceTypeId")]
[JsonPropertyName("ServiceTypeId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrServiceTypeId;

[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrCurrencyId;

public JSONRC_6238dc44386da10198e9e1b2b81cc9aa() { }

public JSONRC_6238dc44386da10198e9e1b2b81cc9aa (RC_6238dc44386da10198e9e1b2b81cc9aa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssSTCostCenterId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDivisionId = ConvertToRestWithoutDefaults(s.ssSTDivisionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDocumentClassId = ConvertToRestWithoutDefaults(s.ssSTDocumentClassId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssSTRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrServiceTypeId = ConvertToRestWithoutDefaults(s.ssSTServiceTypeId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssSTCurrencyId, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
  } else {
AttrCostCenterId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTCostCenterId, config);
AttrDivisionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDivisionId, config);
AttrDocumentClassId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDocumentClassId, config);
AttrRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTRegionId, config);
AttrServiceTypeId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTServiceTypeId, config);
AttrCurrencyId = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTCurrencyId, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6238dc44386da10198e9e1b2b81cc9aa, RC_6238dc44386da10198e9e1b2b81cc9aa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6238dc44386da10198e9e1b2b81cc9aa s) => ToStructure(s, config);
}
public static RC_6238dc44386da10198e9e1b2b81cc9aa ToStructure(ssConectaProveedores.RestRecords.JSONRC_6238dc44386da10198e9e1b2b81cc9aa obj, IBehaviorsConfiguration config) { 
  RC_6238dc44386da10198e9e1b2b81cc9aa s = new RC_6238dc44386da10198e9e1b2b81cc9aa();
  if(obj != null) {
  s.ssSTCostCenterId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrCostCenterId, config);
  s.ssSTDivisionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDivisionId, config);
  s.ssSTDocumentClassId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDocumentClassId, config);
  s.ssSTRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrRegionId, config);
  s.ssSTServiceTypeId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrServiceTypeId, config);
  s.ssSTCurrencyId = ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrCurrencyId, config);
  }
  return s;
}

public static Func<RC_6238dc44386da10198e9e1b2b81cc9aa, ssConectaProveedores.RestRecords.JSONRC_6238dc44386da10198e9e1b2b81cc9aa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6238dc44386da10198e9e1b2b81cc9aa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6238dc44386da10198e9e1b2b81cc9aa FromStructure(RC_6238dc44386da10198e9e1b2b81cc9aa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6238dc44386da10198e9e1b2b81cc9aa(s, config);
}

}


