using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CostCenterIdDirectionIdDivisionIdDocumentClassIdInvoiceUsageIdRegionIdServiceTypeIdRecord
public class JSONRC_b8337e876917ffb03ca766882c5f94fb : AbstractRESTStructure<RC_b8337e876917ffb03ca766882c5f94fb> {
[JsonProperty("CostCenterId")]
[JsonPropertyName("CostCenterId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrCostCenterId;

[JsonProperty("DirectionId")]
[JsonPropertyName("DirectionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDirectionId;

[JsonProperty("DivisionId")]
[JsonPropertyName("DivisionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDivisionId;

[JsonProperty("DocumentClassId")]
[JsonPropertyName("DocumentClassId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDocumentClassId;

[JsonProperty("InvoiceUsageId")]
[JsonPropertyName("InvoiceUsageId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrInvoiceUsageId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrRegionId;

[JsonProperty("ServiceTypeId")]
[JsonPropertyName("ServiceTypeId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrServiceTypeId;

public JSONRC_b8337e876917ffb03ca766882c5f94fb() { }

public JSONRC_b8337e876917ffb03ca766882c5f94fb (RC_b8337e876917ffb03ca766882c5f94fb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssSTCostCenterId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDirectionId = ConvertToRestWithoutDefaults(s.ssSTDirectionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDivisionId = ConvertToRestWithoutDefaults(s.ssSTDivisionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDocumentClassId = ConvertToRestWithoutDefaults(s.ssSTDocumentClassId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrInvoiceUsageId = ConvertToRestWithoutDefaults(s.ssSTInvoiceUsageId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssSTRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrServiceTypeId = ConvertToRestWithoutDefaults(s.ssSTServiceTypeId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
  } else {
AttrCostCenterId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTCostCenterId, config);
AttrDirectionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDirectionId, config);
AttrDivisionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDivisionId, config);
AttrDocumentClassId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDocumentClassId, config);
AttrInvoiceUsageId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTInvoiceUsageId, config);
AttrRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTRegionId, config);
AttrServiceTypeId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTServiceTypeId, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b8337e876917ffb03ca766882c5f94fb, RC_b8337e876917ffb03ca766882c5f94fb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b8337e876917ffb03ca766882c5f94fb s) => ToStructure(s, config);
}
public static RC_b8337e876917ffb03ca766882c5f94fb ToStructure(ssConectaProveedores.RestRecords.JSONRC_b8337e876917ffb03ca766882c5f94fb obj, IBehaviorsConfiguration config) { 
  RC_b8337e876917ffb03ca766882c5f94fb s = new RC_b8337e876917ffb03ca766882c5f94fb();
  if(obj != null) {
  s.ssSTCostCenterId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrCostCenterId, config);
  s.ssSTDirectionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDirectionId, config);
  s.ssSTDivisionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDivisionId, config);
  s.ssSTDocumentClassId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDocumentClassId, config);
  s.ssSTInvoiceUsageId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrInvoiceUsageId, config);
  s.ssSTRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrRegionId, config);
  s.ssSTServiceTypeId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrServiceTypeId, config);
  }
  return s;
}

public static Func<RC_b8337e876917ffb03ca766882c5f94fb, ssConectaProveedores.RestRecords.JSONRC_b8337e876917ffb03ca766882c5f94fb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b8337e876917ffb03ca766882c5f94fb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b8337e876917ffb03ca766882c5f94fb FromStructure(RC_b8337e876917ffb03ca766882c5f94fb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b8337e876917ffb03ca766882c5f94fb(s, config);
}

}


