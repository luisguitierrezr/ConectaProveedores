using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CostCenterIdDirectionIdDivisionIdDocumentClassIdInvoiceUsageIdRegionIdServiceTypeIdRecord
public class RESTRC_b8337e876917ffb03ca766882c5f94fb : AbstractRESTStructure<RC_b8337e876917ffb03ca766882c5f94fb> {
[JsonProperty("CostCenterId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrCostCenterId;

[JsonProperty("DirectionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDirectionId;

[JsonProperty("DivisionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDivisionId;

[JsonProperty("DocumentClassId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDocumentClassId;

[JsonProperty("InvoiceUsageId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrInvoiceUsageId;

[JsonProperty("RegionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrRegionId;

[JsonProperty("ServiceTypeId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrServiceTypeId;

public RESTRC_b8337e876917ffb03ca766882c5f94fb() { }

public RESTRC_b8337e876917ffb03ca766882c5f94fb (RC_b8337e876917ffb03ca766882c5f94fb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCostCenterId = ConvertToRestWithoutDefaults(s.ssSTCostCenterId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDirectionId = ConvertToRestWithoutDefaults(s.ssSTDirectionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDivisionId = ConvertToRestWithoutDefaults(s.ssSTDivisionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDocumentClassId = ConvertToRestWithoutDefaults(s.ssSTDocumentClassId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrInvoiceUsageId = ConvertToRestWithoutDefaults(s.ssSTInvoiceUsageId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssSTRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrServiceTypeId = ConvertToRestWithoutDefaults(s.ssSTServiceTypeId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
  } else {
AttrCostCenterId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTCostCenterId, config);
AttrDirectionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDirectionId, config);
AttrDivisionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDivisionId, config);
AttrDocumentClassId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDocumentClassId, config);
AttrInvoiceUsageId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTInvoiceUsageId, config);
AttrRegionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTRegionId, config);
AttrServiceTypeId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTServiceTypeId, config);
  }
}

public static RC_b8337e876917ffb03ca766882c5f94fb ToStructure(ssConectaProveedores.RestRecords.RESTRC_b8337e876917ffb03ca766882c5f94fb obj) { 
  RC_b8337e876917ffb03ca766882c5f94fb s = new RC_b8337e876917ffb03ca766882c5f94fb();
  if(obj != null) {
  s.ssSTCostCenterId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrCostCenterId);
  s.ssSTDirectionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDirectionId);
  s.ssSTDivisionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDivisionId);
  s.ssSTDocumentClassId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDocumentClassId);
  s.ssSTInvoiceUsageId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrInvoiceUsageId);
  s.ssSTRegionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrRegionId);
  s.ssSTServiceTypeId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrServiceTypeId);
  }
  return s;
}

public static Func<RC_b8337e876917ffb03ca766882c5f94fb, ssConectaProveedores.RestRecords.RESTRC_b8337e876917ffb03ca766882c5f94fb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b8337e876917ffb03ca766882c5f94fb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b8337e876917ffb03ca766882c5f94fb FromStructure(RC_b8337e876917ffb03ca766882c5f94fb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b8337e876917ffb03ca766882c5f94fb(s, config);
}

}


